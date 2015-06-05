namespace Network.Client
{
    #region Rem -> [ Imported Librarys ]
    using System;
    using System.Text;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    //using SmartDoor;
    using System.Threading;
    #endregion
    #region Rem -> [ Socket Client Base Class ]
    public class Client
    {
        #region Rem -> [ Declaration Of Private & Public Objects ]
        //***************************************************************************************************************************************************//
        private Socket MainSocket;                      // Rem-> Main Socket Object, which handel all communications.
        private AsyncCallback CallBackHandler;          // Rem-> Callback handelar which will handel the callback raised by socket object.
        //***************************************************************************************************************************************************//
        public delegate void SocketDataArg(object Sender, SocketDataEventsArg sde);             // Rem-> Delegate to mount data event.
        public delegate void SocketErrorArg(object Sender, SocketErrorEventsArg see);           // Rem-> Delegate to mount error event.
        public delegate void SocketStatusArg(object Sender, EventArgs ea);                      // Rem-> Delegate to mount normal events.
        public delegate void SocketDisconnectArg(object Sender, SocketDisconnectEventsArg sde); // Rem-> Delegate to mount disconnection events.
        //***************************************************************************************************************************************************//
        public event SocketStatusArg Connected;         // Rem-> Event which will fired when the client is connected to remote point.
        public event SocketDataArg DataReceived;        // Rem-> Event which will fired when the client receive data from remote point.
        public event SocketErrorArg ErrorCatched;       // Rem-> Event which will fired when an error is catched while execution.
        public event SocketDisconnectArg Disconnected;  // Rem-> Event which will fired when the client is disconnected from remote point.
        //***************************************************************************************************************************************************//
        #endregion
        #region Rem -> [ Public Functions ]
        public void Connect(string RemoteIP, string Port)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Overload the connect function to maintain the class flexability.
            Connect(RemoteIP, Convert.ToInt32(Port));
        }
        public void Connect(string RemoteIP, int Port)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if the socket is allready connected to remote point or not, if connected, then disconnect.
                if (MainSocket != null) { if (MainSocket.Connected) { Disconnect(); } }

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Intialize an new instance of the socket calss and assign the refrence to main socket object.
                MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Invoke the socket object to connect the remote end point[IP,Port].
                MainSocket.Connect(new IPEndPoint(IPAddress.Parse(RemoteIP), Port));

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if there is a connection established or not, if no connection, then Exception will be raised.
                if (MainSocket.Connected)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Client have an direct connection to the server, inform the main thread with connectivity.
                    Connected(this, new EventArgs());

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Configure the client object to wait for data coming from remote point.
                    PollingForData();
                }
            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                // Rem-> An expexted error can be occure if the client don't find a listener, 
                // Rem-> In this case an error will occure -> "Connection Rejected!!."
                ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
            }
        }
        public void Disconnect()
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the socket object if its refrenced or not, as we can't deal with disposed object.
                if (MainSocket != null)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> If the socket is connected to remote point then destroy the connection, by using disconnect command.
                    if (MainSocket.Connected) MainSocket.Disconnect(false);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Close the socket connection and release all associated resources.
                    MainSocket.Close();

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Destroy the object on memory.
                    MainSocket = null;
                }
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Inform the main thread that socket is disconnected localy, And disconnection is performed softly, by firing the Disconnected event.
                Disconnected(this, new SocketDisconnectEventsArg(false, false));
            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
            }
        }
        public void SendMessage(string Message)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the socket object if its refrenced or not, as we can't deal with disposed object.
                if (MainSocket != null)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Check the socket object if its connected or not, as we can't send data through disconnected socket.
                    if (MainSocket.Connected)
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Create an new instance of network stream, which will handel the process of sending data to remote point.
                        // Rem-> Network stream will be associated with an given socket.
                        NetworkStream NetStream = new NetworkStream(MainSocket);

                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Intialize an new instance of stream writer which will write an message to specific network stream.
                        StreamWriter SocketStream = new StreamWriter(NetStream);

                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Writing the message to the stream.
                        SocketStream.Write(Message);
                        
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Start writing buffered data to the underlying stream.
                        SocketStream.Flush();
                    }
                }

            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
            }
            catch (Exception E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(E.Message, 0));
            }
        }
        public void SendMessage(byte[] Data)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the socket object if its refrenced or not, as we can't deal with disposed object.
                if (MainSocket != null)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Check the socket object if its connected or not, as we can't send data through disconnected socket.
                    if (MainSocket.Connected)
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Send the specified number of bytes of data to a connected remote point.
                        MainSocket.Send(Data);
                    }
                }
            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
            }
            catch (Exception E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(E.Message, 0));
            }
        }
        #endregion
        #region Rem -> [ Private CallBack & Helper Functions ]
        private void PollingForData()
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if the Callback object is refrenced or not, the callback object, act as an pointer to function, when an.
                // Rem-> Specific event occure the socket object will call{Point_To} the function we specifiy in the callback
                if (CallBackHandler == null) { CallBackHandler = new AsyncCallback(OnDataReceived); }

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Mounting the client socket to user defined class which act as packet, this packet will passed to the CallBack.
                // Rem-> Function, to be processed, this packed contain the socket object and the data buffer, that hold incoming data.
                SocketPacket Packet = new SocketPacket();
                Packet.MainSocket = MainSocket;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Invoke the socket object to begin receiving data, when this method is invoked the socket object poll the network stream.
                // Rem-> I.e. Polling the network stream and stay there when data is detected in the stream, the socket come back with this data.
                // Rem-> When the socket detect the data on the stream it wake up and give us the data founded by the OnDataReceived function.
                // Rem-> Also the packet object will be passed to the OnDataReceived function, to deal with the object.
                MainSocket.BeginReceive(Packet.Data, 0, Packet.Data.Length, SocketFlags.None, CallBackHandler, Packet);
            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
            }
            catch (Exception E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(E.Message, 0));
            }
        }
        private void OnDataReceived(IAsyncResult Asyn)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Geting back the socket object which orginally passed by the PoolingForData function, this packet contain the socket object.
                // Rem-> And the data buffer, which contain the data collected from the network stream.
                SocketPacket Packet = (SocketPacket)Asyn.AsyncState;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if the socket is connected or not, as an null value will received if the client is disconnected.
                if (!Packet.MainSocket.Connected) return;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> As we invoke this function with BeginReceive Method {PollingForData Function}, So we must terminate this invoking.
                // Rem-> By using the EndReceive method, this will return to us the length of data collected from stream.
                int CollectedDataLength = Packet.MainSocket.EndReceive(Asyn);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the length of the data collected from the network stream.
                if (CollectedDataLength == 0)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An null value has been returned to us, this mean that socket has been received null value from remote point.
                    // Rem-> This case occur when the remote host is terminated, when this happen the client will receive an continues 
                    // Rem-> Sequance of null values, so when we detect these sequance we will disconnect the socket explicitly.

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> If the socket is connected to remote point then destroy the connection, by using disconnect command.
                    if (MainSocket.Connected) MainSocket.Disconnect(false);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Close the socket connection and release all associated resources.
                    MainSocket.Close();

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Destroy the object on memory.
                    MainSocket = null;

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Inform the main thread that socket is disconnected remotly {By The Peer}, And disconnection is performed softly,
                    // Rem-> by firing the Disconnected event.
                    Disconnected(this, new SocketDisconnectEventsArg(true, false));
                }
                else
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Real data has been detected on the stream, so parse this data, to be deleverd to main thread.

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Incode the incoming data from array of byte to string and Inform the main thread that we got data from remote point.
                    DataReceived(this, new SocketDataEventsArg(Packet.Data));

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Invoke the socket object to poll again, which force the socket object to go to network stream and stay there.
                    // Rem-> Untill an data coming, when data coming this function will be invoked again, and so on :). Piece of cake.
                    PollingForData();
                }
            }
            catch (ObjectDisposedException)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, The socket object is disposed, which mean is disconnected locally and softly, So inform main thread.
                Disconnected(this, new SocketDisconnectEventsArg(false, false));
            }
            catch (SocketException SE)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check to see if remote host terminated upnormally, ErrorCode[10054] mean connection forcibly rejected.
                if (SE.ErrorCode == 10054)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, The socket object is disposed, which mean is disconnected remotly.
                    // Rem-> And disconnection is performed Hardly, So inform main thread.
                    Disconnected(this, new SocketDisconnectEventsArg(true, true));
                }
                else
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, So inform the main thread with that error.
                    ErrorCatched(this, new SocketErrorEventsArg(SE.Message, SE.ErrorCode));
                }
            }
            catch (Exception E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, So inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(E.Message, 0));
            }
        }
        #endregion
    }
    #endregion
    #region Rem -> [ Socket Packet Helper Class ]
    class SocketPacket
    {
        public Socket MainSocket;
        public byte[] Data = new byte[1024];
    }
    #endregion
    #region Rem -> [ Socket Event Arguments Class ]
    public class SocketDataEventsArg : EventArgs
    {
        private byte[] mData = new byte[1024];
        public byte[] Data
        {
            get { return (mData); }
        }
        public SocketDataEventsArg(byte[] Data)
        {
            mData = Data;
        }
    }
    public class SocketErrorEventsArg : EventArgs
    {
        private int mErrorCode = 0;
        private string mMessage = "";
        public string Message
        {
            get { return (mMessage); }
        }
        public int ErrorCode
        {
            get { return (mErrorCode); }
        }
        public SocketErrorEventsArg(string Message, int ErrorCode)
        {
            mMessage = Message;
            mErrorCode = ErrorCode;
        }
    }
    public class SocketDisconnectEventsArg : EventArgs
    {
        private bool mDisconnectedRemotly = false;
        private bool mDisconnectedForcibly = false;
        public bool DisconnectedRemotly
        {
            get { return (mDisconnectedRemotly); }
        }
        public bool DisconnectedForcibly
        {
            get { return (mDisconnectedForcibly); }
        }
        public SocketDisconnectEventsArg(bool DisconnectedRemotly, bool DisconnectedForcibly)
        {
            mDisconnectedRemotly = DisconnectedRemotly;
            mDisconnectedForcibly = DisconnectedForcibly;
        }
    }
    #endregion
}

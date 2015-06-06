namespace Network.Server
{
    #region Rem -> [ Imported Librarys ]
    using System;  
    using System.Collections;  
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;  
    #endregion
    #region Rem -> [ Socket Server Base Class ]
    public class Server
    {
        #region Rem -> [ Declaration Of Private & Public Objects ]
        //***************************************************************************************************************************************************//
        private Socket MainSocket;                          // Rem-> Main Socket Object, which handel all communications, Act as listener.
        private AsyncCallback CallBackOnConnectionRequest;  // Rem-> Callback handelar which will handel OnConnectionRequested event.
        private AsyncCallback CallBackOnDataReceive;        // Rem-> Callback handelar which will handel OnDataReceive event.
        //***************************************************************************************************************************************************//
        private ArrayList ArrClientsList = ArrayList.Synchronized(new ArrayList());  // Rem-> Array which will hold the refrences of connected clients, using thread-safe technique.
        private int mClientCount = 0;                       // Rem-> Variable which will hold the count of connected client
        private bool mShutingDown = false;                  // Rem-> Variable used as tag, to detect if MainSocket is about to close or not.
        private bool mIsSocketStarted = false;              // Rem-> Variable used as tag, to detect if Server is started or not.
        //***************************************************************************************************************************************************//
        public delegate void SocketDataArg(object Sender, SocketDataEventsArg sde);                 // Rem-> Delegate to mount data event.
        public delegate void SocketErrorArg(object Sender, SocketErrorEventsArg see);               // Rem-> Delegate to mount error event.
        public delegate void SocketDisconnectArg(object Sender, SocketDisconnectEventsArg sde);     // Rem-> Delegate to mount disconnection events.
        public delegate void ServerListeningArg(object Sender, ServerListeningEventsArg sle);       // Rem-> Delegate to mount server status events.
        public delegate void SocketConnectedArg(object Sender, SocketConnectedEventsArg sce);       // Rem-> Delegate to mount connect events.
        //***************************************************************************************************************************************************//
        public event ServerListeningArg ServerListening;        // Rem-> Event which will fired when the server is listening or not.
        public event SocketConnectedArg SocketConnected;        // Rem-> Event which will fired when the client is connected to server.
        public event SocketDisconnectArg SocketDisconnected;    // Rem-> Event which will fired when the client is disconnected from server.
        public event SocketDataArg DataReceived;                // Rem-> Event which will fired when the server receive data from client.
        public event SocketErrorArg ErrorCatched;               // Rem-> Event which will fired when an error is catched while execution.
        //***************************************************************************************************************************************************//
        #endregion
        #region Rem -> [ Public Functions ]
        public void StartServer(int Port, bool Start)
        {
            if (Start)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if the CallBackOnConnectionRequest object is refrenced or not, the callback object, act as an pointer to function, when an.
                // Rem-> Specific event occure the socket object will call{Point_To} the function we specifiy in the callback
                try
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Close the server if its allready runing.
                    if (mIsSocketStarted) StartServer(Port, !Start);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> CallBackOnConnectionRequest Object will {Point_To} the OnConnectionRequest event.
                    if (CallBackOnConnectionRequest == null) { CallBackOnConnectionRequest = new AsyncCallback(OnConnectionRequest); }

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> CallBackOnDataReceive Object will {Point_To} the OnDataReceive event.
                    if (CallBackOnDataReceive == null) { CallBackOnDataReceive = new AsyncCallback(OnDataReceive); }

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Reseting the local variables, which hold the connected clients count, and ShutingDown tag.
                    mClientCount = 0;
                    mShutingDown = false;

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Create an new instance of the socket object, This object act as the listener which accept the incoming connection.
                    // Rem-> And assign the connected client to an client object, in which added to Client array list.
                    MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Bind the server(listener), to listen on specified port, A.K.A as local point.
                    MainSocket.Bind(new IPEndPoint(IPAddress.Any, Port));

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Start listening on specified port, given bending connection queue of 1000.
                    MainSocket.Listen(1000);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Inform the main thread with the status of the server.
                    ServerListening(this, new ServerListeningEventsArg(Start));

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Begining accept the incoming connection, i.e. when client request a connection, this CallBackOnConnectionRequest object.
                    // Rem-> Will {Point_TO} the OnConnectionRequest function.
                    MainSocket.BeginAccept(CallBackOnConnectionRequest, null);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Announce that server is runing.
                    mIsSocketStarted = true;
                }
                catch (SocketException SE)
                {
                    if (SE.ErrorCode == 10048)
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> An exception has been catched, so inform the main thread with that error.
                        ErrorCatched(this, new SocketErrorEventsArg(-1, "The address provided is used by another application [" + Port.ToString() + "]\n\n" + SE.Message, SE.ErrorCode));
                    }
                    else
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> An exception has been catched, so inform the main thread with that error.
                        ErrorCatched(this, new SocketErrorEventsArg(-1, SE.Message, SE.ErrorCode));
                    }
                }
                catch (Exception E)
                {
                    ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, so inform the main thread with that error.
                    //ErrorCatched = new ErrorCatched(this, new SocketErrorEventsArg(0, E.Message, 0));
                }
            }
            else
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> To shutdown the server [1]- we should close each client-socket, [2]- and also we shoud remove it from client list {From Arraylist}.
                // Rem-> In this function we are going to close the socket only, and inform the OnDataReceive to remove the socket from the array.
                // Rem-> So we will create an shallow copy of client list, to a temp array, and close sockets inside that array, when we do so,
                // Rem-> The disposed socket will fire the OnDataReceive, which will remove the socket from the original array.

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if server is runing or not.
                if (!mIsSocketStarted) return;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Creating an shallow copy of the clients list to temp array.
                ArrayList ClonedList = (ArrayList)ArrClientsList.Clone();

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Loop through each socket inside the Cloned array.
                foreach (SocketPacket CP in ClonedList)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Call the socket droper which close the socket.
                    DropClient(CP, false, false);
                }
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Assign the tag mShutingDown with true, which will prevent invoking of OnAccept callback.
                mShutingDown = true;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Reset the client count tag.
                mClientCount = 0;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Close the server{listener} socket.
                if (MainSocket != null) { MainSocket.Close(); }

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Announce that server is idle.
                mIsSocketStarted = false;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Inform the main thread with the status of the server.
                ServerListening(this, new ServerListeningEventsArg(Start));

                // Rem-> ~~~~~~~~~~~~~~~~~
                // Rem-> Free some memory.
                GC.Collect();
            }
        }
        public string GetRemoteIP(int SocketID)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Return the remote end point.
            return (GetSocketPacket(SocketID).mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString());
        }
        public string GetLocalIP()
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Return the local point.
            return (Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString());
        }
        public void DisconnectSocket(int SocketID)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Drop The Client Socket.
            DropClient(GetSocketPacket(SocketID), false, false);
        }
        public bool SendMessage(int SocketID, byte[] Data)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the socket object if its connected or not, as we can't send data through disconnected socket.
                if (GetSocketPacket(SocketID).mClientSocket.Connected)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Send the specified number of bytes of data to a connected remote point.
                    //GetSocketPacket(SocketID).mClientSocket.Send(Data,Data.Length,SocketFlags.None);
                    //new BinaryWriter(new NetworkStream(GetSocketPacket(SocketID).mClientSocket)).Write(Encoding.Default.GetString(Data));
                    SendMessage(SocketID, Encoding.Default.GetString(Data));
                    
                    return (true);
                }
                else { return (false); }
            }
            catch { return (false); }
        }
        public bool SendMessage(int SocketID, string Message)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check the socket object if its connected or not, as we can't send data through disconnected socket.
                if (GetSocketPacket(SocketID).mClientSocket.Connected)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Create an new instance of network stream, which will handel the process of sending data to remote point.
                    // Rem-> Network stream will be associated with an given socket.
                    NetworkStream NetStream = new NetworkStream(GetSocketPacket(SocketID).mClientSocket);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Intialize an new instance of stream writer which will write an message to specific network stream.
                    //StreamWriter SocketStream = new StreamWriter(NetStream);
                    BinaryWriter SocketStream = new BinaryWriter(NetStream,Encoding.Default);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Writing the message to the stream.
                    SocketStream.Write(Message);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Start writing buffered data to the underlying stream.
                    SocketStream.Flush();
                    return (true);
                }
                else { return (false); }
            }
            catch { return (false); }
        }       
        public void Broadcast(string Message)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Loop through connected clients.
            for (int I = 1; I <= ArrClientsList.Count; I++)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Send the message to specied client.
                SendMessage(I, Message);
            }
        }
        public void Broadcast(byte[] Data)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Loop through connected clients.
            for (int I = 1; I <= ArrClientsList.Count; I++)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Send the message to specied client.
                SendMessage(I, Data);
            }
        }
        #endregion
        #region Rem -> [ Private CallBack & Helper Functions ]
        private void OnConnectionRequest(IAsyncResult ar)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> This function will fired when an remote client try to connect to server, when this happen the server.
            // Rem-> Will call this function and provide the socket object of connected client.
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check to see if the StopServer function is called or not, as if its, then all client will disconnected.
                // Rem-> And while socket is disconnection, it will fire this function, so will ignore that call, supposing that.
                // Rem-> Server is shutting-Down, so there is no need to handel the incoming connection.
                if (mShutingDown) return;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> As we begin an accept call from Listen function, so we must end that begin, as in Async. call We start process.
                // Rem-> By Begin call, so we must end that process with End call, when we do so, we got the object of connected client.
                Socket ClientSocket = MainSocket.EndAccept(ar);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check to see if the client is still connected or not, to maintain the memory, as no need to keep an disconnected socket.
                if (!ClientSocket.Connected) return;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Tag which hold the connected client id.
                int SocketID = 1;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check to see, if the count of client is zero, then the client id is 1.
                if (ArrClientsList.Count > 0)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> We have connected client, so get the ID of the last connected client and increament it with one, which will be the id of new client.
                    SocketID = (ArrClientsList[ArrClientsList.Count - 1] as SocketPacket).mSocketID + 1;
                }

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Create new client packet which contain Socket object, DataBuffer, and the socket id to identify it later.
                SocketPacket ConnectedClient = new SocketPacket(ClientSocket, SocketID);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Add the connected client packet to the Client-List [ArrayList].
                ArrClientsList.Add(ConnectedClient);
                try
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Begin receiving data from the connected client, as when client try to send data, CallBack pointer will.
                    // Rem-> Point_TO OnDataReceive function, which handel incoming data.
                    ClientSocket.BeginReceive(ConnectedClient.DataBuffer, 0, ConnectedClient.DataBuffer.Length, SocketFlags.None, CallBackOnDataReceive, ConnectedClient);

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Increment the connected clients, with the connected one.
                    mClientCount++;

                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Inform the main thread that a new client connected.
                    SocketConnected(this, new SocketConnectedEventsArg(ConnectedClient.mSocketID, mClientCount, ConnectedClient.mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString()));
                }
                catch (SocketException E)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, so inform the main thread with that error.
                    ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                }

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Get ready for next incoming connection.
                MainSocket.BeginAccept(CallBackOnConnectionRequest, null);
            }
            catch (ObjectDisposedException E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, so inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
            }
            catch (Exception E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> An exception has been catched, so inform the main thread with that error.
                ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
            }
        }
        private void OnDataReceive(IAsyncResult ar)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Retrive the client packet sent by the OnConnectionRequest function, and put it in local object.
            SocketPacket ConnectedClient = (SocketPacket)ar.AsyncState;
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> As we begin reveive befor, so we must end that recive, when we do so, we got the length of collected data.
                int BytesCollected = ConnectedClient.mClientSocket.EndReceive(ar);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> When the remote point disconnected, the collector thread keep reading a null value from network stream,
                // Rem-> So if we get null value from the network stream this mean, that remote point disconnected.
                if (BytesCollected > 0)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> We got data from the other side, so lets parse it from bytes, to usable string.
                    try
                    {
                        try
                        {
                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> Inform the main thread that we got an data from client, and provide the client id.
                            DataReceived(this, new SocketDataEventsArg(ConnectedClient.mSocketID, ConnectedClient.DataBuffer));
                        }
                        catch (Exception E)
                        {
                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> An exception has been catched, so inform the main thread with that error.
                            ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                        }

                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Force the collector thread to get down to network stream, and stay there untill new data come.
                        ConnectedClient.mClientSocket.BeginReceive(ConnectedClient.DataBuffer, 0, ConnectedClient.DataBuffer.Length, SocketFlags.None, CallBackOnDataReceive, ConnectedClient);
                    }
                    catch (Exception E)
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> A socket is disposed, so drop it from the client list.
                        DropClient(ConnectedClient, true, false);

                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> An exception has been catched, so inform the main thread with that error.
                        ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                    }
                }
                else
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> A socket is disposed, so drop it from the client list.
                    DropClient(ConnectedClient, true, false);
                }
            }
            catch (SocketException E)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> A socket is disposed, so drop it from the client list.
                DropClient(ConnectedClient, true, true);

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> 10054 is the code of refused connection, occure when remote side disposed, which handeld by dropping the socket.
                if (E.ErrorCode != 10054)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, so inform the main thread with that error.
                    ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, E.ErrorCode));
                }
            }
        }
        private void DropClient(SocketPacket DisposedSocket, bool DisconnectedRemotly, bool DisconnectedForcibly)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Shutdown the given socket.
                DisposedSocket.mClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch { }

            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Declaring an local variable which will help us to detect if given socket is removed or not.
            bool IsRemoved = false;

            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> As this function is called frequantly from many threads, and all of these threads are trying to access the.
            // Rem-> ClientList array, this may lead to a Dead-Lock, so we are going to prevent the dead lock by using the lock.
            // Rem-> Keyword which ensures that one thread does not enter a critical section of code while another thread is in.
            // Rem-> The critical section. If another thread attempts to enter a locked code, it will wait, block, until the object is released.
            lock (ArrClientsList.SyncRoot)
            {
                try
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Looping through available client list, checking if its the given socket or not, if its then remove it.
                    for (int SckID = 0; !IsRemoved && (SckID < ArrClientsList.Count); SckID++)
                    {
                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Casting the current SocketPacket object to a Socket object to check if its the requierd one or not.
                        SocketPacket ClientSocket = (SocketPacket)ArrClientsList[SckID];

                        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                        // Rem-> Comparing the current socket with the given one.
                        if (ClientSocket.mClientSocket == DisposedSocket.mClientSocket)
                        {
                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> Its the required one, so remove it from the list.
                            ArrClientsList.Remove(ClientSocket);



                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> Decrement the client count with one, which is the disconnected one.
                            mClientCount--;

                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> Assign the tag with true, to break the for loop.
                            IsRemoved = true;

                            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                            // Rem-> Inform the main thread that the client disconnected.
                            SocketDisconnected(this, new SocketDisconnectEventsArg(ClientSocket.mSocketID, mClientCount, DisconnectedRemotly, DisconnectedForcibly, ClientSocket.mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString()));
                        }
                    }
                }
                catch (Exception E)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> An exception has been catched, so inform the main thread with that error.
                   // if (DisposedSocket!=null)
                    ErrorCatched(this, new SocketErrorEventsArg(DisposedSocket.mSocketID, E.Message, -1));
                }
            }
        }
        private SocketPacket GetSocketPacket(int SocketID)
        {
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Create an new object of SocketPacket class, which will handel our selected client.
            SocketPacket mClientSocket = null;

            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Loop through existed clients.
            foreach (SocketPacket ClientSocket in ArrClientsList)
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Rem-> Check if the current client is the existed bone, by comparing its id.
                if (ClientSocket.mSocketID == SocketID)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    // Rem-> Its the requerd one, hold it withen the tag.
                    mClientSocket = ClientSocket;

                    // Rem-> ~~~~~~~~~~~~~~~
                    // Rem-> Break the loop.
                    break;
                }
            }
            // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~
            // Rem-> Return it to the caller.
            return (mClientSocket);
        }
        #endregion
        #region Rem -> [ Public property ]
        public int GetClientCount
        {
            get { return (mClientCount); }
        }
        #endregion
    }
    #endregion
    #region Rem -> [ Socket Packet Helper Class ]
    class SocketPacket
    {
        internal readonly Socket mClientSocket;
        internal readonly int mSocketID;
        internal byte[] DataBuffer = new byte[20480];
        public SocketPacket(Socket ClientSocket, int SocketID)
        {
            mClientSocket = ClientSocket;
            mSocketID = SocketID;
        }
    }
    #endregion
    #region Rem -> [ Socket Event Arguments Class ]
    public class ServerListeningEventsArg : EventArgs
    {
        private bool mListening = false;
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public bool Listening
        {
            get { return (mListening); }
        }
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public ServerListeningEventsArg(bool Listening)
        {
            mListening = Listening;
        }
    }
    public class SocketDataEventsArg : EventArgs
    {
        private int mSocketID = 0;
        private byte[] mData = new byte[1024];
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public int SocketID
        {
            get { return (mSocketID); }
        }
        public byte[] Data
        {
            get { return (mData); }
        }
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public SocketDataEventsArg(int SocketID, byte[] Data)
        {
            mSocketID = SocketID;
            mData = Data;
        }
    }
    public class SocketErrorEventsArg : EventArgs
    {
        private int mSocketID = 0;
        private int mErrorCode = 0;
        private string mMessage = "";
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public int SocketID
        {
            get { return (mSocketID); }
        }
        public string Message
        {
            get { return (mMessage); }
        }
        public int ErrorCode
        {
            get { return (mErrorCode); }
        }
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public SocketErrorEventsArg(int SocketID, string Message, int ErrorCode)
        {
            mSocketID = SocketID;
            mMessage = Message;
            mErrorCode = ErrorCode;
        }
    }
    public class SocketDisconnectEventsArg : EventArgs
    {
        private int mSocketID = 0;
        private int mClientCount = 0;
        private bool mDisconnectedRemotly = false;
        private bool mDisconnectedForcibly = false;
        private string mRemoteIP = "";
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public int SocketID
        {
            get { return (mSocketID); }
        }
        public int ClientCount
        {
            get { return (mClientCount); }
        }
        public bool DisconnectedRemotly
        {
            get { return (mDisconnectedRemotly); }
        }
        public bool DisconnectedForcibly
        {
            get { return (mDisconnectedForcibly); }
        }
        public string RemoteIP
        {
            get { return (mRemoteIP); }
        }
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public SocketDisconnectEventsArg(int SocketID, int ClientCount, bool DisconnectedRemotly, bool DisconnectedForcibly, string RemoteIP)
        {
            mSocketID = SocketID;
            mClientCount = ClientCount;
            mDisconnectedRemotly = DisconnectedRemotly;
            mDisconnectedForcibly = DisconnectedForcibly;
            mRemoteIP = RemoteIP;
        }
    }
    public class SocketConnectedEventsArg : EventArgs
    {
        private int mSocketID = 0;
        private int mClientCount = 0;
        private string mRemoteIP = "";
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public int SocketID
        {
            get { return (mSocketID); }
        }
        public int ClientCount
        {
            get { return (mClientCount); }
        }
        public string RemoteIP
        {
            get { return (mRemoteIP); }
        }
        // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public SocketConnectedEventsArg(int SocketID, int ClientCount, string RemoteIP)
        {
            mSocketID = SocketID;
            mClientCount = ClientCount;
            mRemoteIP = RemoteIP;
        }
    }
    #endregion   
    
}

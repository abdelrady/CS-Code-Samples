namespace Network.Server
{
    #region Rem -> [ Imported Librarys ]
    using System;  
    using System.Collections;  
    using System.IO;
    using System.Net;
    using System.Net.Sockets;  
    #endregion
    #region Rem -> [ Socket Server Base Class ]
    public class Server
    {
        #region Rem -> [ Declaration Of Private & Public Objects ]
        private Socket MainSocket;
        private AsyncCallback CallBackOnConnectionRequest;
        private AsyncCallback CallBackOnDataReceive;  
        private ArrayList ArrClientsList = ArrayList.Synchronized(new ArrayList()); 
        private int mClientCount = 0;                 
        private bool mShutingDown = false;              
        private bool mIsSocketStarted = false;                      
        public delegate void SocketDataArg(object Sender, SocketDataEventsArg sde);    
        public delegate void SocketErrorArg(object Sender, SocketErrorEventsArg see);   
        public delegate void SocketDisconnectArg(object Sender, SocketDisconnectEventsArg sde);   
        public delegate void ServerListeningArg(object Sender, ServerListeningEventsArg sle);    
        public delegate void SocketConnectedArg(object Sender, SocketConnectedEventsArg sce);    
        public event SocketDisconnectArg SocketDisconnected;       
        public event SocketDataArg DataReceived;          
        public event SocketErrorArg ErrorCatched;     
    
#endregion
        #region Rem -> [ Public Functions ]
        public void StartServer(int Port, bool Start)
        {
            if (Start)
            {
                try
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    if (mIsSocketStarted) StartServer(Port, !Start);

                    if (CallBackOnConnectionRequest == null) { CallBackOnConnectionRequest = new AsyncCallback(OnConnectionRequest); }

                    if (CallBackOnDataReceive == null) { CallBackOnDataReceive = new AsyncCallback(OnDataReceive); }

                    mClientCount = 0;
                    mShutingDown = false;

                    MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    MainSocket.Bind(new IPEndPoint(IPAddress.Any, Port));

                    MainSocket.Listen(1000);

                    ServerListening(this, new ServerListeningEventsArg(Start));

                    MainSocket.BeginAccept(CallBackOnConnectionRequest, null);

                    mIsSocketStarted = true;
                }
                catch (SocketException SE)
                {
                    if (SE.ErrorCode == 10048)
                    {
                        ErrorCatched(this, new SocketErrorEventsArg(-1, "The address provided is used by another application [" + Port.ToString() + "]\n\n" + SE.Message, SE.ErrorCode));
                    }
                    else
                    {
                        ErrorCatched(this, new SocketErrorEventsArg(-1, SE.Message, SE.ErrorCode));
                    }
                }
                catch (Exception E)
                {
                    ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
                }
            }
            else
            {
                // Rem-> So we will create an shallow copy of client list, to a temp array, and close sockets inside that array, when we do so,

                // Rem-> Check if server is runing or not.
                if (!mIsSocketStarted) return;

                ArrayList ClonedList = (ArrayList)ArrClientsList.Clone();

                foreach (SocketPacket CP in ClonedList)
                {
                    DropClient(CP, false, false);
                }
                mShutingDown = true;

                // Rem-> Reset the client count tag.
                mClientCount = 0;

                if (MainSocket != null) { MainSocket.Close(); }

                mIsSocketStarted = false;

                ServerListening(this, new ServerListeningEventsArg(Start));

                GC.Collect();
            }
        }
        public string GetRemoteIP(int SocketID)
        {
            return (GetSocketPacket(SocketID).mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString());
        }
        public string GetLocalIP()
        {
            return (Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString());
        }
        public void DisconnectSocket(int SocketID)
        {
            DropClient(GetSocketPacket(SocketID), false, false);
        }
        public bool SendMessage(int SocketID, byte[] Data)
        {
            try
            {
                if (GetSocketPacket(SocketID).mClientSocket.Connected)
                {
                    GetSocketPacket(SocketID).mClientSocket.Send(Data, Data.Length, SocketFlags.None);

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
                if (GetSocketPacket(SocketID).mClientSocket.Connected)
                {
                    NetworkStream NetStream = new NetworkStream(GetSocketPacket(SocketID).mClientSocket);

                    StreamWriter SocketStream = new StreamWriter(NetStream);

                    SocketStream.Write(Message);

                    SocketStream.Flush();
                    return (true);
                }
                else { return (false); }
            }
            catch { return (false); }
        }
        public void Broadcast(string Message)
        {
            for (int I = 1; I <= ArrClientsList.Count; I++)
            {
                SendMessage(I, Message);
            }
        }
        public void Broadcast(byte[] Data)
        {
            for (int I = 1; I <= ArrClientsList.Count; I++)
            {
                SendMessage(I, Data);
            }
        }
        #endregion
        #region Rem -> [ Private CallBack & Helper Functions ]
        private void OnConnectionRequest(IAsyncResult ar)
        {
            try
            {
                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                if (mShutingDown) return;

                // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Socket ClientSocket = MainSocket.EndAccept(ar);

                // Rem-> Check to see if the client is still connected or not, to maintain the memory, as no need to keep an disconnected socket.
                if (!ClientSocket.Connected) return;

                int SocketID = 1;

                if (ArrClientsList.Count > 0)
                {
                    SocketID = (ArrClientsList[ArrClientsList.Count - 1] as SocketPacket).mSocketID + 1;
                }

                SocketPacket ConnectedClient = new SocketPacket(ClientSocket, SocketID);

                ArrClientsList.Add(ConnectedClient);
                try
                {
                    ClientSocket.BeginReceive(ConnectedClient.DataBuffer, 0, ConnectedClient.DataBuffer.Length, SocketFlags.None, CallBackOnDataReceive, ConnectedClient);

                    mClientCount++;

                    SocketConnected(this, new SocketConnectedEventsArg(ConnectedClient.mSocketID, mClientCount, ConnectedClient.mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString()));
                }
                catch (SocketException E)
                {
                    ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                }

                MainSocket.BeginAccept(CallBackOnConnectionRequest, null);
            }
            catch (ObjectDisposedException E)
            {
                ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
            }
            catch (Exception E)
            {
                ErrorCatched(this, new SocketErrorEventsArg(-1, E.Message, -1));
            }
        }
        private void OnDataReceive(IAsyncResult ar)
        {
            SocketPacket ConnectedClient = (SocketPacket)ar.AsyncState;
            try
            {
                int BytesCollected = ConnectedClient.mClientSocket.EndReceive(ar);

                if (BytesCollected > 0)
                {
                    // Rem-> ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    try
                    {
                        try
                        {
                            DataReceived(this, new SocketDataEventsArg(ConnectedClient.mSocketID, ConnectedClient.DataBuffer));
                        }
                        catch (Exception E)
                        {
                            ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                        }

                        ConnectedClient.mClientSocket.BeginReceive(ConnectedClient.DataBuffer, 0, ConnectedClient.DataBuffer.Length, SocketFlags.None, CallBackOnDataReceive, ConnectedClient);
                    }
                    catch (Exception E)
                    {
                        DropClient(ConnectedClient, true, false);

                        ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, -1));
                    }
                }
                else
                {
                    DropClient(ConnectedClient, true, false);
                }
            }
            catch (SocketException E)
            {
                DropClient(ConnectedClient, true, true);

                if (E.ErrorCode != 10054)
                {
                    // Rem-> An exception has been catched, so inform the main thread with that error.
                    ErrorCatched(this, new SocketErrorEventsArg(ConnectedClient.mSocketID, E.Message, E.ErrorCode));
                }
            }
        }
        private void DropClient(SocketPacket DisposedSocket, bool DisconnectedRemotly, bool DisconnectedForcibly)
        {
            try
            {
                DisposedSocket.mClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch { }

            bool IsRemoved = false;

            // Rem-> As this function is called frequantly from many threads, and all of these threads are trying to access the.
            lock (ArrClientsList.SyncRoot)
            {
                try
                {
                    for (int SckID = 0; !IsRemoved && (SckID < ArrClientsList.Count); SckID++)
                    {
                        SocketPacket ClientSocket = (SocketPacket)ArrClientsList[SckID];

                        if (ClientSocket.mClientSocket == DisposedSocket.mClientSocket)
                        {
                            ArrClientsList.Remove(ClientSocket);



                            mClientCount--;

                            IsRemoved = true;

                            SocketDisconnected(this, new SocketDisconnectEventsArg(ClientSocket.mSocketID, mClientCount, DisconnectedRemotly, DisconnectedForcibly, ClientSocket.mClientSocket.RemoteEndPoint.ToString().Split(':').GetValue(0).ToString()));
                        }
                    }
                }
                catch (Exception E)
                {
                    ErrorCatched(this, new SocketErrorEventsArg(DisposedSocket.mSocketID, E.Message, -1));
                }
            }
        }
        private SocketPacket GetSocketPacket(int SocketID)
        {
            SocketPacket mClientSocket = null;

            // Rem-> Loop through existed clients.
            foreach (SocketPacket ClientSocket in ArrClientsList)
            {
                if (ClientSocket.mSocketID == SocketID)
                {
                    mClientSocket = ClientSocket;

                    break;
                }
            }
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
        public bool Listening
        {
            get { return (mListening); }

            set
            {
                mListening = Listening;
            }
        }
    }
    public class SocketDataEventsArg : EventArgs
    {
        private int mSocketID = 0;
        private byte[] mData = new byte[1024];
                public int SocketID
        {
            get { return (mSocketID); }
        }
        public byte[] Data
        {
            get { return (mData); }
        }
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
                public SocketConnectedEventsArg(int SocketID, int ClientCount, string RemoteIP)
        {
            mSocketID = SocketID;
            mClientCount = ClientCount;
            mRemoteIP = RemoteIP;
        }
    }
    #endregion   
    
}

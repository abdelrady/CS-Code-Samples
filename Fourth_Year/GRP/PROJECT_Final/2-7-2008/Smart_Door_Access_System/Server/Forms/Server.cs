using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Data.SqlClient;
using Network.Server;
using System.Text;
using System.Drawing.Drawing2D;
using SmartDoor.Properties;
using System.Data;
using System.Diagnostics;
using SmartDoor.Forms;
using SmartDoor.Classes;


namespace SmartDoor
{
    public partial class ServerFRM : System.Windows.Forms.Form
    {
        #region [Synch. C/S Variables]
        private ArrayList connection = new ArrayList();
        private Thread readThread;
        private ArrayList Clients = new ArrayList();
        private LinkedList<Client_Interface> ClientList = new LinkedList<Client_Interface>();
        private TcpListener listener;
        private int counter = -1;
       
        private Client_Interface current_To_Send;
        #endregion
        bool Restarting = false;
        #region [Asynch. C/S Variables]
        private Server server = new Server();
        private Server UpdatesServer = new Server();
        private TSCUpdater ListViewUpdator;
        private TSCUpdater LogViewUpdator;
        private SqlConnection Server_db_connection;
        private DBUtility ServerUtility;
        private ArrayList LST_SocketIds = new ArrayList();
        private ArrayList LST_ClientNames = new ArrayList();
        private VideoFrm videoViewer;
        public string UserName;
        public Server LogServer = new Server();
       

        #endregion
        Thread th=null;
        #region Constructor
        public ServerFRM(string username, SqlConnection sqlConnection)
        {
            /*Eagles Co.*/

            InitializeComponent();
          
            ServerUtility = new DBUtility(this);           
            ServerUtility.m_DbConnection = sqlConnection;
            ServerUtility.IsConnected = true;
            Server_db_connection = sqlConnection;
            dataGridView1.GridColor = Color.Green;
            ServerUtility.Fill(dataGridView1,BuildQuery());

            //th.Suspend();

            UserName = username;
            ConnectToDB.Image = ExitMBTN.Image;
            dbStatus.Text = "Connected To Database";
            dbStatus.ForeColor = Color.Green;
            dbStatus.Image = Resources.smallsuccess;
            ConnectToDB.Text = "Close Database Connection";

            /*
             * initialize safe thread control updator
             * to ban cross thread Ex during debug or exe,..
             */
            InitializeThreadSafeCtrls();

            /*
             * Server Events Handellation 
             */
            InitializeServerEvents();
            InitializeUpdatesServerEvents();
            InitializeLogEvents();


        }


       
        private void InitializeLogEvents()
        {
            LogServer.SocketConnected += new Server.SocketConnectedArg(LogServer_SocketConnected);
            LogServer.ErrorCatched += new Server.SocketErrorArg(LogServer_ErrorCatched);
            LogServer.SocketDisconnected += new Server.SocketDisconnectArg(LogServer_SocketDisconnected);
            LogServer.ServerListening += new Server.ServerListeningArg(LogServer_ServerListening);
            LogServer.DataReceived += new Server.SocketDataArg(LogServer_DataReceived);
        }
        bool firstTime = true;
        void LogServer_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            // LBLUpdates.Text = "Receiving Updates... ";
            //LBLUpdates.ForeColor = Color.Green;
            if (firstTime)
            {
                Log("Receiving Logs From Door With IP [ " + LogServer.GetRemoteIP(sde.SocketID) + " ]...", Color.Blue);
                firstTime = false;
            }
            StringBuilder All = new StringBuilder();
            //  All.Length = 0;
            /// StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + Configuration.lo, false);
            string IncommingData = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });
            // MessageBox.Show(IncommingData);
            if (!IncommingData.EndsWith("#<EndOFList>#"))
            {
                //  MessageBox.Show("eag");
                All.AppendLine(IncommingData);
            }
            else
            {
                All.AppendLine(IncommingData.Remove(IncommingData.Length - 13));
                Log("Receiving Logs From Door With IP [ " + LogServer.GetRemoteIP(sde.SocketID) + " ] Finished.", Color.Green);
                firstTime = true;
                new Thread(new ParameterizedThreadStart(AddlogsToDataBase)).Start(All.ToString());
                // MessageBox.Show(All.ToString());
            }

        }
        public void AddlogsToDataBase(object longLogs)
        {
            string logs = longLogs as string;
            string[] LogEntries;
            string[] individualLogs = logs.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < individualLogs.Length - 1; i++)
            {
                LogEntries = individualLogs[i].Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                //MessageBox.Show(LogEntries[0] + "$$" + LogEntries[1] + "$$" + LogEntries[2] + "$$" + LogEntries[3] + "$$"  + "Standalone");
                ServerUtility.Append_User_Log(LogEntries[0], LogEntries[1], LogEntries[2], LogEntries[3], "Standalone");

            }

        }

        void LogServer_ServerListening(object Sender, ServerListeningEventsArg sle)
        { }

        void LogServer_SocketDisconnected(object Sender, SocketDisconnectEventsArg sde)
        { }

        void LogServer_ErrorCatched(object Sender, SocketErrorEventsArg see)
        { }

        void LogServer_SocketConnected(object Sender, SocketConnectedEventsArg sce)
        { }
        #endregion

        #region <<<<<<<<<<<<< Update Server Event Handellation >>>>>>>>>>>>>>>
        private void UpdatesServer_SocketConnected(object sender, SocketConnectedEventsArg sce)
        {
            /*
             *Send NoWWWWWWWWWWWWWWWWW! 
             */
            //this line either sends alist or if no one then Block All
            UpdatesServer.SendMessage(sce.SocketID, Get_LongString_Users(ServerUtility.Get_Single_Value("SELECT doorNum FROM Doors WHERE DoorName = '" + LST_ClientNames[Find_Index(sce.SocketID)] + "'").ToString()));

        }

        private string Get_LongString_Users(string m_DoorNumber)
        {
            /*
            * here ,dear abdo we are attempting to send every door the
            * latest list of students
            */
            ServerUtility.Update_Door_Time(m_DoorNumber);
            string[] D_All = ServerUtility.Users_List(m_DoorNumber);
            if (D_All != null)
            {
                /*
                 * concat them
                 */
                string All = String.Join("#", D_All);

                /*
                 * "khtm El nsr" At last of message 
                 */
                All = String.Concat(All, "[#<End>#]");
                return All;
            }
            /*if null returned then all students are blocked to enter this door then send ablock message to him to block all students*/
            return "[#<Block_All>#]";
        }

        void UpdatesServer_SocketDisconnected(object Sender, SocketDisconnectEventsArg sde)
        { }
        void UpdatesServer_ErrorCatched(object Sender, SocketErrorEventsArg see)
        { }
        void UpdatesServer_ServerListening(object Sender, ServerListeningEventsArg sle)
        { }
        #endregion

        #region <<<<<<<<<< Asynch. Server Events Function ,By. Eagles >>>>>>>>

        void Server_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            string IncomingCommand = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });  // An clean string which contain the commands arguments.
            if (IncomingCommand.StartsWith("[#<CMD>#]"))    // Detect the existance of command on the received data.
            {
                // An command detected, split it to retrive the arguments
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<CMD>#]").Length).Split(new string[] { "[#]" }, 8, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {

                    case ("[#Barcode#]"):
                        {
                            /*
                             * Here is The barcode Param.
                             */

                            //CmdArg[1] Barcode 
                            //CmdArg[2] Door name 
                            //CmdArg[2] Door number 

                            //Assign to global Var
                            if (!ServerUtility.IsConnected)
                            {
                                server.SendMessage(sde.SocketID, "[#<Information>#][#Not_Connected_To_DB#]");
                                Log("Door [" + CmdArg[1] + "] IP [" + server.GetRemoteIP(sde.SocketID) + "] Logged in while not connected to Database.", Color.Red);
                              //  server.DisconnectSocket(sde.SocketID);

                            }
                            else
                            {
                                new Thread(new ParameterizedThreadStart(Retreive_And_Send_Data)).Start(new DoorObject(sde.SocketID, CmdArg[1], CmdArg[2], CmdArg[3]));
                            }
                            break;
                        }
                    case ("[#Authentication#]"):
                        {
                            //CmdArg[1]-->User&DoorName
                            //CmdArg[2]-->Password
                            //CmdArg[3]--> Door_Number 

                            //Check DB Connection first if not Connected inform The door 
                            //to try login later in another time
                            if (!ServerUtility.IsConnected)
                            {
                                server.SendMessage(sde.SocketID, "[#<Information>#][#Not_Connected_To_DB#]");
                                Log("Door [" + CmdArg[1] + "] IP [" + server.GetRemoteIP(sde.SocketID) + "] Logged in while not connected to Database.", Color.Red);
                                server.DisconnectSocket(sde.SocketID);
                            }
                            else
                            {
                                //Assign to global Var to be copied by consumer threads
                                /*    Door_Number = CmdArg[3];
                                    Door_Name   = CmdArg[1];*/

                                /*
                                 * here we Synchronize door name at client and server
                                 * this is important as bad User may change door location from configuration
                                 * database at server must keep the same door name
                                 */
                                if (CmdArg[1] != "")
                                    ServerUtility.Synchronize_Door_Name(CmdArg[1], CmdArg[3], server.GetRemoteIP(sde.SocketID));

                                //Check door name and password
                                if (!ServerUtility.Verify_Door_Authorization(CmdArg[3], CmdArg[2]))
                                {
                                    server.SendMessage(sde.SocketID, "[#<Information>#][#UnAuthorized_Door#]");
                                    server.DisconnectSocket(sde.SocketID);
                                }
                                else
                                {
                                    server.SendMessage(sde.SocketID, "[#<Information>#][#Login_Successful#]");

                                    /*
                                     * here we store mapping Soc.ID--->DoorNames 
                                     * To Facilitate manipulation
                                     */
                                    LST_ClientNames.Add(CmdArg[1]);
                                    LST_SocketIds.Add(sde.SocketID);

                                    /*Append The door in the list view*/
                                    ListViewUpdator.AddItem = new ListViewItem(CmdArg[1], 0);


                                }
                            }
                            break;
                        }
                }
            }
        }

        void Server_SocketDisconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            /*Get the index of the disconnected Socket*/
            int index = Find_Index(sde.SocketID);
            if (index < 0)
                return;
            UpdatesServer.DisconnectSocket(Convert.ToInt32(LST_SocketIds[index]));

            /*remove from the list view*/
            ListViewUpdator.DeleteItem = LST_ClientNames[index].ToString();
            Log("Door [" + LST_ClientNames[index].ToString() + "] IP [" + sde.RemoteIP + "] had disconnected at " + DateTime.Now.ToString() + ".", Color.Red);
            Log("Door [" + LST_ClientNames[index].ToString() + "] IP [" + sde.RemoteIP + "] Socket Disconnected " + GetCompinationCode(sde.DisconnectedRemotly, sde.DisconnectedForcibly) + ".", Color.Blue);
            /*Clean the lists*/
            LST_SocketIds.RemoveAt(index);
            LST_SocketIds.TrimToSize();
            LST_ClientNames.RemoveAt(index);
            LST_ClientNames.TrimToSize();

            ClientCountLBL.Text = sde.ClientCount.ToString();

        }

        private int Find_Index(int p)
        {
            for (int i = 0; i < LST_SocketIds.Count; i++)
                if (Convert.ToInt32(LST_SocketIds[i]) == p)
                    return i;
            return -1;
        }
        void Server_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            //  /*This line is to us to know what happen ,once project had finished we will remove it */
            Log("Socket ID: [" + see.SocketID.ToString() + "]\n" + see.Message, Color.Red);
            //  int index = Find_Index(see.SocketID);

            //  UpdatesServer.DisconnectSocket(Convert.ToInt32(LST_SocketIds[index]));

            //  /*remove from the list view*/
            //  ListViewUpdator.DeleteItem = LST_ClientNames[index].ToString();
            //  Log("Error Catched With Door [" + LST_ClientNames[index].ToString() + "] IP [" + server.GetRemoteIP(see.SocketID) + "]at " + DateTime.Now.ToString() + ".", Color.Red);
            //  /*Clean the lists*/
            //  LST_SocketIds.RemoveAt(index);
            //  LST_SocketIds.TrimToSize();
            //  LST_ClientNames.RemoveAt(index);
            //  LST_ClientNames.TrimToSize();

            //  ClientCountLBL.Text = (server.GetClientCount-1).ToString();
        }
        void Server_SocketConnected(object Sender, SocketConnectedEventsArg sce)
        {
            ClientCountLBL.Text = sce.ClientCount.ToString();
            //DoorsView.Items[0].ToolTipText = "asd\n\rf";
            //ClientCountUpdator.Text = sce.ClientCount.ToString();
            //ClientListUpdator.AddItem = sce.SocketID.ToString() + "#" + sce.RemoteIP + "#-";
            //ExceptionsUpdator.Text = "[Client Connected]\n\n- ID: " + sce.SocketID + "\n- End Point: " + sce.RemoteIP;
            //System.Media.SystemSounds.Exclamation.Play();
        }
        void Server_ServerListening(object Sender, ServerListeningEventsArg sle)
        {
            //SetGUI(sle.Listening);
        }
        #endregion

        #region <<<<<<<<<<<[Synchronous client/server] Functions >>>>>>>>>
        // allows a client to connect and displays the text it sends
        public void RunServer()
        {
            try
            {
                listener = new TcpListener(50000);
                listener.Start();
                while (true)
                {
                    /*
                     * Amazing trick by --**Eagles**-- 
                     * 
                     * 1-Adding new node to the linked list
                     * 2-passing the accepted socket to it's constructor
                     * 3-wentmashee Ya 3m El 7g
                     */

                    ClientList.AddFirst(new Client_Interface(listener.AcceptSocket(), ++counter));
                    //process this connection in a new thread
                    new Thread(new ThreadStart(GetStreams)).Start();
                    LogTXT.AppendText("\nconnection " + counter.ToString() + " received\r\n");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(
                    error.ToString() + " \n Application will Exit Now.",
                    "Error in main Server Thread ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*Gets Data sent by Clienst Synchronous <<<Client/Server>>> ,Discurded option*/
        private void GetStreams()
        {
            /*
             * Get this new client from the LL and ,....
             */
            Client_Interface Current = ClientList.First.Value;
            /*
             * send the client his Key - Important 
             * after that key will recived from Client but just it is a test 
             */
            Current.SendKey();
            /*
             * You Are Welcome             
             */
            Current.M_Writer.Write("test send text to client succeeded");

            try
            {
                while (true)
                {
                    /*
                     * those are special vars that is used for 
                     * the current operating client
                     */
                    //  passed_barcode_from_Remote_host = Current.M_Reader.ReadString();
                    current_To_Send = Current;

                    /*
                     * append the log
                     */
                    //  LogTXT.AppendText("\nDoor# " + Current.M_Key.ToString() + ":" + passed_barcode_from_Remote_host);

                    /*
                     * it is responsable for getting data and send it to the remote door
                     * but it's in thread so that appliaction must continue reading 
                     * from the transport connection 
                     */
                    //  new Thread(new ThreadStart(Retreive_And_Send_Data)).Start();
                }
            }
            catch (Exception e)
            {

                /*this means that this client was closed and it vars 
                needed to be cleaned also reduce the counter of clients */

                MessageBox.Show(e.ToString() + "\n\rClient " + Current.M_Key.ToString() + " Had Disconnected ",
                    "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Current.Finilize();
                ClientList.Remove(Current);

            }
        }

        #endregion

        #region Helper Functions

        private void Paint_Gradiant(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 10), new Rectangle(this.Width - 1, this.Height - 1, 0, 0));

            LinearGradientBrush brBrush;
            Rectangle rcBrush = new Rectangle(0, 0, this.Width, this.Height); ;
            brBrush = new LinearGradientBrush(rcBrush, Color.Green, Color.Black, LinearGradientMode.ForwardDiagonal);

            brBrush.WrapMode = WrapMode.Tile;
            brBrush.SetSigmaBellShape(0);
            ColorBlend cb = new ColorBlend(2);
            cb.Positions[0] = 0.0f;
            cb.Positions[1] = 1.0f;
            cb.Colors[0] = Color.White;
            cb.Colors[1] = Color.Silver;


            brBrush.InterpolationColors = cb;

            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingMode = CompositingMode.SourceCopy;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle rcClient = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rcContent = rcClient;
            e.Graphics.FillRectangle(brBrush, rcContent);
            //  e.Graphics.DrawRectangle(new Pen(Color.Black, 5), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            
        }

        private void InitializeUpdatesServerEvents()
        {
            UpdatesServer.SocketConnected += new Server.SocketConnectedArg(UpdatesServer_SocketConnected);
            UpdatesServer.ErrorCatched += new Server.SocketErrorArg(UpdatesServer_ErrorCatched);
            UpdatesServer.SocketDisconnected += new Server.SocketDisconnectArg(UpdatesServer_SocketDisconnected);
            UpdatesServer.ServerListening += new Server.ServerListeningArg(UpdatesServer_ServerListening);
        }

        private void InitializeServerEvents()
        {

            server.ErrorCatched += new Server.SocketErrorArg(Server_ErrorCatched);
            server.SocketDisconnected += new Server.SocketDisconnectArg(Server_SocketDisconnected);
            server.DataReceived += new Server.SocketDataArg(Server_DataReceived);
            server.SocketConnected += new Server.SocketConnectedArg(Server_SocketConnected);
            server.ServerListening += new Server.ServerListeningArg(Server_ServerListening);
        }

        private void InitializeThreadSafeCtrls()
        {
            ListViewUpdator = new TSCUpdater(DoorsView);
            LogViewUpdator = new TSCUpdater(LogTXT);
        }

        private void BroadCast_Students_List()
        {
            string List_Of_Students;
            while (true)
            {
                for (int i = 0; i < UpdatesServer.GetClientCount; i++)
                {
                    List_Of_Students = Get_LongString_Users(ServerUtility.Get_Single_Value("SELECT doorNum FROM Doors WHERE DoorName = '" + LST_ClientNames[Find_Index(Convert.ToInt32(LST_SocketIds[i]))] + "'").ToString());
                    UpdatesServer.SendMessage(Convert.ToInt32(LST_SocketIds[i]), List_Of_Students);
                }
                Thread.Sleep(int.Parse(Configuration.sendUpdatesEvery));//wait for minute
            }
        }

        private void Retreive_And_Send_Data(object DoorOb)
        {
            byte[] ImageData;
            string[] Data;
            string Message;
            int Soc_ID = (DoorOb as DoorObject).Current_Socket;
            string mDoorNumber = (DoorOb as DoorObject).Door_Number;
            string barCode = (DoorOb as DoorObject).passed_barcode_from_Remote_host;
            string mDoorName = (DoorOb as DoorObject).Door_Name;


            DBUtility.User_Status U_Status = ServerUtility.GetRow(mDoorNumber, barCode, out Data, out ImageData);

            try
            {
                if (U_Status == DBUtility.User_Status.User_Not_Exist)
                /*
                 * Not Found
                 */
                {
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "],Not Authorized User [Not Exist in The Database], Barcode: [" + barCode + "] .", Color.Red);
                    Message = "[#<User_Data>#][#Student_Does_Not_Exist#][#]" + barCode + "[#]";                 
                    server.SendMessage(Soc_ID, Message);

                    ResponseSZ.Text = Message.Length.ToString() + " B";
                }

                /*
                 * Exist but not allowed
                 */
                else if (U_Status == DBUtility.User_Status.User_Theif)
                {
                    int sz;
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Invalid User, ID Number: [" + barCode + "] .", Color.Red);

                    Message = "[#<User_Data>#][#User_Theif#][#]" + barCode + "[#]";

                    server.SendMessage(Soc_ID, Message);
                    sz = Message.Length;
                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "False", "User Theif"
                        );
                    //string _SentMessage = String.Join("[#]", Data /*Str_Data*/);

                    //Message = "[#<User_Data>#][#Display_Only#][#]" + _SentMessage + "[#]" + ((ImageData == null) ? "[#NoImage#][#]" : "[#Image#][#]");
                  
                    //server.SendMessage(Soc_ID, Message);
                    //sz += Message.Length;

                    ///*
                    // * Send The Size Of Data Image 
                    // */
                    //if (ImageData != null)
                    //{
                    //    server.SendMessage(Soc_ID, ImageData);
                    //    sz += ImageData.Length;
                    //}
                    ResponseSZ.Text = sz.ToString() + " B";
                }

                /*
                 * not allowed to enter this door
                 */
                else if (U_Status == DBUtility.User_Status.User_Not_Allowed_To_Enter_Door)
                {
                    int sz;
                    /*outPut To GUI*/
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Unauthorized User, ID Number: [" + barCode + "] .", Color.Red);

                    Message = "[#<User_Data>#][#Student_Not_Allowed_To_Enter_Door#][#]" + barCode + "[#]";

                    server.SendMessage(Soc_ID, Message);
                    sz = Message.Length;
                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "False", "Not Allowed"
                        );
                    //string _SentMessage = String.Join("[#]", Data /*Str_Data*/);

                    //Message = "[#<User_Data>#][#Display_Only#][#]" + _SentMessage + "[#]" + ((ImageData == null) ? "[#NoImage#][#]" : "[#Image#][#]");

                    //server.SendMessage(Soc_ID, Message);
                    //sz += Message.Length;
                    ///*
                    //* Send The Size Of Data Image 
                    //*/
                    //if (ImageData != null)
                    //{
                    //    server.SendMessage(Soc_ID, ImageData);
                    //    sz += ImageData.Length;
                    //}
                    ResponseSZ.Text = sz.ToString() + " B";
                }
                /*
                 * reader is busy
                 */
                else if (U_Status == DBUtility.User_Status.None)
                {
                    Log("Server is Now Busy!.", Color.Red);
                    server.SendMessage(Soc_ID, "[#<Information>#][#Server_Busy#]");
                }
                /*
                 * Found And Valid User and allowed
                 */

                else if (U_Status == DBUtility.User_Status.User_Valid_And_Allowed_Enter)
                {
                    int sz;
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Authorized User Had Entered, ID Number: [" + barCode + "] .", Color.Green);
                    /*Appending The log*/
                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "True", "Enter");
                    string _SentMessage = String.Join("[#]", Data);

                    Message = "[#<User_Data>#][#Text_Enter#][#]" + _SentMessage + "[#]" + ((ImageData == null) ? "[#NoImage#][#]" : "[#Image#][#]");

                    server.SendMessage(Soc_ID, Message);
                    sz = Message.Length;

                    /*
                     * Send The Size Of Data Image 
                     */
                    if (ImageData != null)
                    {
                        server.SendMessage(Soc_ID, ImageData);
                        sz += ImageData.Length;
                    }
                    ResponseSZ.Text = sz.ToString() + " B";
                }
                else if (U_Status == DBUtility.User_Status.User_Valid_Exit)
                {
                    int sz;
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Authorized User Had Exited, ID Number: [" + barCode + "] .", Color.Green);

                    /*Appending The log*/
                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "True", "Exit Door");

                    string _SentMessage = String.Join("[#]", Data /*Str_Data*/);

                    Message = "[#<User_Data>#][#Text_Exit#][#]" + _SentMessage + "[#]" + ((ImageData == null) ? "[#NoImage#][#]" : "[#Image#][#]");

                    server.SendMessage(Soc_ID, Message);
                    sz = Message.Length;
                    /*
                  * Send The Size Of Data Image 
                  */
                    if (ImageData != null)
                    {
                        server.SendMessage(Soc_ID, ImageData);
                        sz += ImageData.Length;
                    }
                    ResponseSZ.Text = sz.ToString() + " B";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Log(string p, Color col)
        {
            LogTXT.AppendText(p + "\n");
            LogTXT.Select(LogTXT.Text.Length - 1 - p.Length, p.Length);
            LogTXT.SelectionColor = col;


        }

        private string GetCompinationCode(bool DRemotly, bool DForcibly)
        {
            string Temp = "";
            switch (DRemotly)
            {
                case (true):
                    if (DForcibly) { Temp = "Remotly, And Forcibly"; }
                    else { Temp = "Remotly, And Softly"; }
                    break;
                case (false):
                    if (DForcibly) { Temp = "Localy, And Forcibly"; }
                    else { Temp = "Localy, And Softly"; }
                    break;
            }
            return (Temp);
        }

        private void Show_Details(string sid)
        {

            new Door_Details(
                 sid,
                 Server_db_connection,
                 DoorsView.SelectedItems[0].Text,
                 ServerUtility.Get_Single_Value(
                 "SELECT doorNum FROM Doors WHERE DoorName = '" + DoorsView.SelectedItems[0].Text + "'").ToString()
                 ).ShowDialog(this);
        }

        private int Find_Index(string p)
        {
            for (int i = 0; i < LST_ClientNames.Count; i++)
                if (Convert.ToString(LST_ClientNames[i]) == p)
                    return i;
            return -1;
        }

        #endregion

        #region GUI Functions
        private void SendBTN_Click(object sender, EventArgs e)
        {
            // MessageTXT.Clear();
            try
            {
                foreach (Client_Interface Client in ClientList)
                {
                    //   Client.M_Writer.Write("SERVER: " + MessageTXT.Text);
                }
                //    LogTXT.AppendText("\nSERVER: " + MessageTXT.Text);
                //  MessageTXT.Focus();
                //  SendBTN.Enabled = false;

            }
            catch (SocketException)
            {
                LogTXT.AppendText("\nError writing object");
            }
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            //readThread = new Thread(new ThreadStart(RunServer));
            //readThread.Start();  
            Adjust_server_GUI();

        }

        private void Adjust_server_GUI()
        {
            if (ConnectBTN.Text == "Connect Server")
            {
                server.StartServer(int.Parse(Configuration.mainPortNumber), true);
                /*Start updates Client*/
                UpdatesServer.StartServer(int.Parse(Configuration.UpdatesPort), true);
                LogServer.StartServer(7000, true);
                new Thread(new ThreadStart(BroadCast_Students_List)).Start();

                ConnectBTN.Image = ExitMBTN.Image;
                networkStatus.Text = "Online";
                networkStatus.ForeColor = Color.Green;
                networkStatus.Image = (Image)Resources.smallsuccess;
                ConnectBTN.Text = "Disconnect Server";
            }
            else
            {
                server.StartServer(int.Parse(Configuration.mainPortNumber), false);

                UpdatesServer.StartServer(int.Parse(Configuration.UpdatesPort), false);

                LogServer.StartServer(7000, false);

                ConnectBTN.Image = SmartDoor.Properties.Resources.play;
                networkStatus.Text = "Offline";
                networkStatus.ForeColor = Color.Red;
                networkStatus.Image = (Image)Resources.smallfail;
                ConnectBTN.Text = "Connect Server";

                ArrayList al = LST_SocketIds;
                for (int j = 0; j < al.Count; j++)
                {
                    server.DisconnectSocket(Convert.ToInt32(al[j]));
                }
                if (LST_SocketIds.Count > 0)
                {
                    Log("Server is not Connected.\nDoors had been droped.", Color.Red);
                }
                DoorsView.Items.Clear();
            }
        }

        private void ExitMBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogTXT_TextChanged(object sender, EventArgs e)
        {
            LogTXT.ScrollToCaret();
        }

        private void MessageTXT_TextChanged(object sender, EventArgs e)
        {
            /* if (MessageTXT.Text.Trim().Length == 0)
                 SendBTN.Enabled = false;
             else
                 SendBTN.Enabled = true;*/
        }

        private void ConnectToDB_Click(object sender, EventArgs e)
        {
            if (!ServerUtility.IsConnected)
            {
                Server_db_connection = ServerUtility.ConnectToSQL();
                /*Eagle may ex raised so don not update gui till it connected really*/
                if (ServerUtility.IsConnected)
                {
                    ConnectToDB.Image = ExitMBTN.Image;
                    dbStatus.Text = "Connected To Database";
                    dbStatus.ForeColor = Color.Green;
                    dbStatus.Image = Resources.smallsuccess;
                    ConnectToDB.Text = "Close Database Connection";
                }
            }
            else
            {
                ServerUtility.DisConnectToSQL();
                ConnectToDB.Image = SmartDoor.Properties.Resources.play;
                dbStatus.Text = "Disconnectd To Database";
                dbStatus.ForeColor = Color.Red;
                dbStatus.Image = Resources.smallfail;
                ConnectToDB.Text = "Connect To Database";

                /*
                 * Disconnect All Doors
                 */

                while (LST_SocketIds.Count > 0)
                {
                    server.DisconnectSocket(Convert.ToInt32(LST_SocketIds[0]));
                }
                if (LST_SocketIds.Count > 0)
                {
                    Log("Connection To Database had been broken.\nConnected Doors had been droped.", Color.Red);
                }
                DoorsView.Items.Clear();

            }
        }

        private void ServerFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ServerUtility.IsConnected)
                ServerUtility.DisConnectToSQL();
            if (networkStatus.Text == "Online")
            {
                server.StartServer(int.Parse(Configuration.mainPortNumber), false);
                UpdatesServer.StartServer(int.Parse(Configuration.UpdatesPort), false);
                LogServer.StartServer(7000, false);
            }
            if (Restarting)
                Process.Start(Application.ExecutablePath);
            System.Environment.Exit(Environment.ExitCode);

        }

        private void ServerFRM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Logs' table. You can move, or remove it, as needed.
       
            ConnectBTN.PerformClick();
           
        }

        private void LoadComboBoxes()
        {
            doornamesCbo.DataSource = ServerUtility.GetDataColumn("Door Names");
           usernamesCbo.DataSource = ServerUtility.GetDataColumn("User Names");
    
        }
        private void ServerStatus_Paint(object sender, PaintEventArgs e)
        {
            Paint_Gradiant(e);
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {
            Paint_Gradiant(e);
        }

        private void Action_Menu_Opening(object sender, CancelEventArgs e)
        {
            if (DoorsView.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Getting the index*/
            int index = Find_Index(DoorsView.SelectedItems[0].Text);
            Show_Details(LST_SocketIds[index].ToString());
        }

        private void DoorsView_DoubleClick(object sender, EventArgs e)
        {
            /*Getting the index*/
            int index = Find_Index(DoorsView.SelectedItems[0].Text);
            Show_Details(LST_SocketIds[index].ToString());
        }

        private void Clear_Action_Click(object sender, EventArgs e)
        {
            LogViewUpdator.Text = "";
        }

        private void Action_menu_Log_Opening(object sender, CancelEventArgs e)
        {
            if (LogTXT.Text.Length == 0)
                e.Cancel = true;
        }

        private void Save_Action_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "ServerLog " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".rtf";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (LogTXT.Text.Length != 0)
                    LogTXT.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void CMD_Disconnect_Click(object sender, EventArgs e)
        {
            int index = Find_Index(DoorsView.SelectedItems[0].Text);
            server.DisconnectSocket(Convert.ToInt32(LST_SocketIds[index]));

        }

        private void CMD_Setting_Click(object sender, EventArgs e)
        {
            new Settingfrm().ShowDialog(this);
        }

        private void CMD_Restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure that you want to restart Application", "Smart Door", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Restarting = true;
                Close();
            }
        }

        private void CMD_Monitor_Click(object sender, EventArgs e)
        {
            //new Thread(new ThreadStart(RunVideo)).Start();
            RunVideo();
        }
        public static string time1;
        void RunVideo()
        {
            /*
             */
            videoViewer = new VideoFrm(this);
            /* for synchronous Send & Recieve........................
            */

            /*
             *
            videoViewer = new VideoFrm(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]));
             /* for Asynchronous Send & Recieve........................
             */
            videoViewer.Text = "Monitor Door[" + DoorsView.SelectedItems[0].Text + "]";
            //  videoViewer.ClosingEvent += new VideoFrm.closingDelegate(videoViewer_ClosingEvent);

            string Message = "[#<CMD>#][#StartMonitor#][#]";
            server.SendMessage(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]), Message);
            time1 = DateTime.Now.ToLongTimeString();

            videoViewer.ShowDialog(this);
        }
        void videoViewer_ClosingEvent(object sender)
        {

            /* string Message = "[#<CMD>#][#StopMonitor#][#]";
             server.SendMessage(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]), Message);
             videoViewer.Close();
             videoViewer = null;
             GC.Collect();*/
        }

        private void CMD_Restart_Remote_App_Click(object sender, EventArgs e)
        {
            string Message = "[#<CMD>#][#Restart#][#]";
            server.SendMessage(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]), Message);

        }

        private void CMD_openDoor_Click(object sender, EventArgs e)
        {
            string Message = "[#<CMD>#][#Open#][#]";
            server.SendMessage(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]), Message);

        }

        private void aboutSmartDoorProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ServerUtility.IsConnected)
                MessageBox.Show(this, "You Are Now not connected to Database\nYou have to Connect first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                profile frmProfile = new profile(ServerUtility.m_DbConnection, UserName, this);

                frmProfile.Text += "-" + UserName;
                frmProfile.ShowDialog(this);
            }

        }
        int CurrentQuality = 25;
    

        private void CMD_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                ServerUtility.Fill(dataGridView1, BuildQuery());
               
            }
            catch { }
        }
        public void UpdateLogs()
        {
            while (true)
            {
                try
                {
                    try
                    {
                        ServerUtility.Fill(dataGridView1, BuildQuery());
                    }
                    catch { }
                    Thread.Sleep(int.Parse(txtrefreshrate.Value.ToString()));
                }
                catch { }
            }
        }
        string TOP = "";
        string OrderBy = "'Action Time'";
        string ASCDEC = "desc";

        string startDate = string.Join("-", new string[] { DateTime.Now.ToShortDateString().Split(new char[] { '/' })[2], DateTime.Now.ToShortDateString().Split(new char[] { '/' })[1], DateTime.Now.ToShortDateString().Split(new char[] { '/' })[0] }), EndDate = string.Join("-", new string[] { DateTime.Now.ToShortDateString().Split(new char[] { '/' })[2], DateTime.Now.ToShortDateString().Split(new char[] { '/' })[1], DateTime.Now.ToShortDateString().Split(new char[] { '/' })[0] });
        string MuserName = "", DoorName = "", Estatus = "Enter";

        private string BuildQuery()
        {
            if (checkBox3.Checked == true)
            {
                if (TOP == "")
                {
                    return "SELECT Logs.ID AS 'Barcode', Users.userfName + ' ' + Users.userlName AS 'User Name',Logs.Enter_time as 'Action Time',  Doors.doorName as 'Door Name',  Logs.Status as 'Action' FROM    Logs INNER JOIN  Doors ON Logs.doorNumber = Doors.doorNum INNER JOIN Users ON Logs.ID = Users.userID order BY " + OrderBy + " " + ASCDEC;

                }
                else
                {
                    return "SELECT TOP " + TOP + " Logs.ID AS 'Barcode',Users.userfName + ' ' + Users.userlName AS 'User Name',Logs.Enter_time as 'Action Time',  Doors.doorName as 'Door Name',  Logs.Status as 'Action' FROM    Logs INNER JOIN  Doors ON Logs.doorNumber = Doors.doorNum INNER JOIN Users ON Logs.ID = Users.userID order BY " + OrderBy + " " + ASCDEC;

                }
            }
            else 
            {
                string where = " WHERE";
                string orderBy = " order BY " + OrderBy + " " + ASCDEC;
                if (TOP == "")
                {
                    string Query = "SELECT Logs.ID AS 'Barcode', Users.userfName + ' ' + Users.userlName AS 'User Name',Logs.Enter_time as 'Action Time',  Doors.doorName as 'Door Name',  Logs.Status as 'Action' FROM    Logs INNER JOIN  Doors ON Logs.doorNumber = Doors.doorNum INNER JOIN Users ON Logs.ID = Users.userID ";

                    if (startDate == "" && EndDate == "" && MuserName == "" && DoorName == "" && Estatus == "")
                    {
                        return Quality + orderBy;
                    }
                    else 
                    {
                        if (startDate != null && EndDate != null) 
                        {
                            //where = " WHERE";
                            where += " Logs.Enter_time > '" + startDate + "' and Logs.Enter_time < '" +EndDate + "'";
                        }
                        //userName = "", DoorName = "", Estatus = "";
                        if (MuserName != "")
                        {
                            if(where!="")
                                where += "  and Users.userfName + ' ' + Users.userlName='" + MuserName+"'";
                            else
                                where += " Users.userfName + ' ' + Users.userlName='" + MuserName + "'";
                        }
                        if (DoorName != "")
                        {

                             if(where!="")
                         where += " and  Doors.doorName ='" + DoorName+"'";
                            else
                                where += "  Doors.doorName ='" + DoorName+"'";

                            
                        }
                        if (Estatus != "")
                        {

                            
                             if(where!="")
                         where += " and  Logs.Status ='" + Estatus+"'";
                            else
                               where += "   Logs.Status ='" + Estatus+"'";

                          
                        }

                        return Query + where + orderBy;
                    }
                }
                else
                {
                    string Query = "SELECT TOP " + TOP + " Logs.ID AS 'Barcode', Users.userfName + ' ' + Users.userlName AS 'User Name',Logs.Enter_time as 'Action Time',  Doors.doorName as 'Door Name',  Logs.Status as 'Action' FROM    Logs INNER JOIN  Doors ON Logs.doorNumber = Doors.doorNum INNER JOIN Users ON Logs.ID = Users.userID ";

                    if (startDate == "" && EndDate == "" && MuserName == "" && DoorName == "" && Estatus == "")
                    {
                        return Quality + orderBy;
                    }
                    else
                    {
                        if (startDate != null && EndDate != null)
                        {
                            where += " Logs.Enter_time > '" + startDate + "' and Logs.Enter_time < '" + EndDate+"'";
                        }
                        //userName = "", DoorName = "", Estatus = "";
                        if (MuserName != "")
                        {
                            if (where != "")
                                where += "  and Users.userfName + ' ' + Users.userlName='" + MuserName + "'";
                            else
                                where += " Users.userfName + ' ' + Users.userlName='" + MuserName + "'";
                        }
                        if (DoorName != "")
                        {

                            if (where != "")
                                where += " and  Doors.doorName ='" + DoorName + "'";
                            else
                                where += "  Doors.doorName ='" + DoorName + "'";


                        }
                        if (Estatus != "")
                        {


                            if (where != "")
                                where += " and  Logs.Status ='" + Estatus + "'";
                            else
                                where += "   Logs.Status ='" + Estatus + "'";


                        }

                        return Query + where + orderBy;
                    }
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked==true)

                OrderBy = "'Action Time'";
          

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)

                OrderBy = "'User Name'";
          
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)

                OrderBy = "'Door Name'";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TOP = "";
                panel3.Enabled = false;
            }
            else
            {
                panel3.Enabled = true;
                TOP = numericUpDown1.Value.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TOP = numericUpDown1.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ASCDEC = "asc";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ASCDEC = "desc";
        }

        private void btnIncQuality_Click(object sender, EventArgs e)
        {
            if (CurrentQuality == 100) return;
            ++CurrentQuality;
            ServerUtility.ImageQuality = CurrentQuality;
            Quality.Text = CurrentQuality.ToString() + "%";
        }

        private void btnDecQuality_Click(object sender, EventArgs e)
        {
            if (CurrentQuality == 0) return;
            --CurrentQuality;
            ServerUtility.ImageQuality = CurrentQuality;
            Quality.Text = CurrentQuality.ToString() + "%";
        }
    
        private void btnIncQuality_MouseDown(object sender, MouseEventArgs e)
        {

            if (CurrentQuality == 100) return;
            ++CurrentQuality;
            ServerUtility.ImageQuality = CurrentQuality;
            Quality.Text = CurrentQuality.ToString() + "%";
          
        }

        private void btnDecQuality_MouseDown(object sender, MouseEventArgs e)
        {
            if (CurrentQuality == 0) return;
            --CurrentQuality;
            ServerUtility.ImageQuality = CurrentQuality;
            Quality.Text = CurrentQuality.ToString() + "%";
            
        }

        private void DisplayDetails(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            new UserDetail(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),ServerUtility.m_DbConnection).ShowDialog(this);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (th == null)
                {
                    th = new Thread(new ThreadStart(UpdateLogs));
                    th.IsBackground = true;
                    th.Priority = ThreadPriority.Lowest;
                    th.Start();
                }
                else { th.Resume(); }
                panel4.Enabled = false;
            }
            else
            {
                if(th!=null)
                th.Suspend();         
                panel4.Enabled = true;
            }
        }

        private void helpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("SmartDoor.chm");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                //TOP = "";
                groupBox1.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = true;
                LoadComboBoxes();
                //TOP = numericUpDown1.Value.ToString();
            }
        }

        private void doornamesCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoorName = doornamesCbo.SelectedValue.ToString(); 
        }

        private void usernamesCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MuserName = usernamesCbo.SelectedValue.ToString(); 
        }

        private void statusCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estatus = statusCbo.SelectedItem.ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startDate = string.Join("-", new string[] { dateTimePicker1.Value.ToShortDateString().Split(new char[] { '/' })[2], dateTimePicker1.Value.ToShortDateString().Split(new char[] { '/' })[1], dateTimePicker1.Value.ToShortDateString().Split(new char[] { '/' })[0] });
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            EndDate = string.Join("-", new string[] { dateTimePicker2.Value.ToShortDateString().Split(new char[] { '/' })[2], dateTimePicker2.Value.ToShortDateString().Split(new char[] { '/' })[1], dateTimePicker2.Value.ToShortDateString().Split(new char[] { '/' })[0] });
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            Process.Start(WriteHtmlReport());
        }

        private string WriteHtmlReport()
        {
            StreamWriter sr = new StreamWriter(File.Create("Report.hta"));
            sr.WriteLine("<body>");
            sr.WriteLine("<Font face = tahoma color=blue >");
            sr.WriteLine("<h5>Smart Door Access System</h5>");
            sr.WriteLine("<h6>Printed on:"+DateTime.Now.ToString()+"</h6>");

            sr.WriteLine("<table cellpadding = 2px style=\" font-weight:normal; font-size:12px; border:dottted;\">");


          
            sr.WriteLine("<tr bgcolor=#999999>");
            sr.WriteLine("<th>Barcode Number</th>");
            sr.WriteLine("<th> User Name</th>");
            sr.WriteLine("<th>Action Time</th>");
            sr.WriteLine("<th>Door Name</th>");
            sr.WriteLine("<th>Status</th>");
            sr.WriteLine("</tr>");
            int i;
            for ( i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sr.WriteLine("<tr>");
                sr.WriteLine("<th>" + dataGridView1.Rows[i].Cells[0].Value + "</th>");
                sr.WriteLine("<th>" + dataGridView1.Rows[i].Cells[1].Value + "</th>");
                sr.WriteLine("<th>" + dataGridView1.Rows[i].Cells[2].Value + "</th>");
                sr.WriteLine("<th>" + dataGridView1.Rows[i].Cells[3].Value + "</th>");

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Enter" ||dataGridView1.Rows[i].Cells[4].Value.ToString()=="Exit Door")
                sr.WriteLine("<th><font color = green>" + dataGridView1.Rows[i].Cells[4].Value + "</font></th>");
                else
                sr.WriteLine("<th><font color = red>" + dataGridView1.Rows[i].Cells[4].Value + "</font></th>");
          
                sr.WriteLine("</tr>");                                      
            }
            sr.WriteLine("<tr bgcolor=#999999>");
            sr.WriteLine("<th height=1pt colspan=5>Total Number of Logs is : " + i.ToString() +"</th>");
            sr.WriteLine("</tr>");     
            sr.WriteLine("</table>");
            //sr.WriteLine("<h6>Total Number of Logs is:" + i.ToString() + "</h6>");
            sr.Close();
            return "Report.hta";
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ServerUtility.InsertImage(@"F:\Games\Face Hack\Ali3.jpg", "333");
        //} 
        #endregion
    }

}

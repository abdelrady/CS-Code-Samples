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
        private byte[] Image_Array;
        private Server server = new Server();
        private Server UpdatesServer = new Server();
        private TSCUpdater ListViewUpdator;
        private TSCUpdater LogViewUpdator;
        private SqlConnection Server_db_connection;
        private DBUtility ServerUtility;
        private ArrayList LST_SocketIds = new ArrayList();
        private ArrayList LST_ClientNames = new ArrayList();
        VideoFrm videoViewer;
        #endregion

        #region Constructor
        public ServerFRM()
        {
            /*Eagles Co.*/
            
                InitializeComponent();
                ServerUtility = new DBUtility(this);

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
           

        } 
        #endregion

        #region <<<<<<<<<<<<< Update Server Event Handellation >>>>>>>>>>>>>>>
        private void UpdatesServer_SocketConnected(object sender, SocketConnectedEventsArg sce)
        {
            /*
             *Send NoWWWWWWWWWWWWWWWWW! 
             */
            //this line either sends alist or if no one then Block All
            UpdatesServer.SendMessage(sce.SocketID, Get_LongString_Users( ServerUtility.Get_Single_Value("SELECT doorNum FROM Doors WHERE DoorName = '" + LST_ClientNames[Find_Index(sce.SocketID)] + "'").ToString()));

        }

        private string Get_LongString_Users(string m_DoorNumber)
        {
             /*
             * here ,dear abdo we are attempting to send every door the
             * latest list of students
             */
            ServerUtility.Update_Door_Time(m_DoorNumber);
            string[] D_All = ServerUtility.Users_List( m_DoorNumber);
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
                                server.DisconnectSocket(sde.SocketID);

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
                                Log("Door [" + CmdArg[1] + "] IP ["+server.GetRemoteIP(sde.SocketID)+"] Logged in while not connected to Database.",Color.Red);
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
                                    ServerUtility.Synchronize_Door_Name(CmdArg[1], CmdArg[3]);

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
                                    ListViewUpdator.AddItem = new ListViewItem( CmdArg[1],0);
                                   
                                  
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
            if (index < 0)//الله اكبر جبتك جبتك.......................!!!!!
                return;//مفيش اكسبشن
            UpdatesServer.DisconnectSocket(Convert.ToInt32(LST_SocketIds[index]));

            /*remove from the list view*/
            ListViewUpdator.DeleteItem = LST_ClientNames[index].ToString();
            Log("Door [" + LST_ClientNames[index].ToString() + "] IP [" + sde.RemoteIP + "] had disconnected at "+DateTime.Now.ToString()+".",Color.Red);
            Log("Door [" + LST_ClientNames[index].ToString() + "] IP [" + sde.RemoteIP +"] Socket Disconnected " + GetCompinationCode(sde.DisconnectedRemotly, sde.DisconnectedForcibly)+".",Color.Blue);
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
        byte[] ImageData;
        private void Retreive_And_Send_Data(object DoorOb)
        {
            
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
                }

                /*
                 * Exist but not allowed
                 */
                else if (U_Status == DBUtility.User_Status.User_Invalid)
                {
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Invalid User, Barcode: [" + barCode + "] .", Color.Red);

                     Message = "[#<User_Data>#][#Invalid_Student#][#]" + barCode + "[#]";

                    server.SendMessage(Soc_ID, Message);

                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "False",
                        Server_db_connection);
                }

                /*
                 * not allowed to enter this door
                 */
                else if (U_Status == DBUtility.User_Status.User_Not_Allowed_To_Enter_Door)
                {
                    /*outPut To GUI*/
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Unauthorized User, Barcode: [" + barCode + "] .", Color.Red);

                     Message = "[#<User_Data>#][#Student_Not_Allowed_To_Enter_Door#][#]" + barCode + "[#]";

                    server.SendMessage(Soc_ID, Message);

                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "False",
                        Server_db_connection);
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

                else
                {
                    Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Authorized User, Barcode: [" + barCode + "] .", Color.Green);

                    /*Appending The log*/
                    ServerUtility.Append_User_Log(
                        mDoorNumber,
                        barCode,
                        DateTime.Now.ToString(),
                        "True",
                        Server_db_connection);

                    //string[] Str_Data = DBUtility.Get_String_Data(Data.ItemArray);

                    string _SentMessage = String.Join("[#]", Data /*Str_Data*/);

                    Message = "[#<User_Data>#][#Text#][#]" + _SentMessage + "[#]";

                    server.SendMessage(Soc_ID, Message);

                    /*
                     * Here We Can User Serialization
                     */
                    ///////////////////////////////////////////////////////////////////////////////////////////      
                    //      Message = "[#<User_Data>#][#Serialized_Data#]";                                  //
                    //      /*Inform Client*/                                                                //
                    //      server.SendMessage(Soc_ID, Message);                                             //
                    //      /*Then Send The Bytes*/                                                          //
                    //      server.SendMessage(Soc_ID, new Serialization(Data).BinarySerialize());           //
                    ///////////////////////////////////////////////////////////////////////////////////////////
                    /*
                     * Send The Size Of Data Image 
                     */
                    if (ImageData != null)
                    {
                        Message = "[#<User_Data>#][#Image#][#]" + _SentMessage + "[#]";
                        server.SendMessage(Soc_ID, ImageData);
                    }
                }               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Log(string p, Color col)
        {
            LogTXT.AppendText(p + "\n");
            LogTXT.Select(LogTXT.Text.Length-1 - p.Length, p.Length);
            LogTXT.SelectionColor = col;

            /** if (col == Color.Green)
                 LogTXT.SelectionFont = new Font("tahoma",9);*/
          
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
            }
            if (Restarting)
                Process.Start(Application.ExecutablePath);
            System.Environment.Exit(Environment.ExitCode);

        }

        private void ServerFRM_Load(object sender, EventArgs e)
        {
           ConnectBTN.PerformClick();
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
          // new Thread(new ThreadStart(RunVideo)).Start();
            RunVideo();
        }
        public static string time1;
        void RunVideo()
        {
            string Message = "[#<CMD>#][#StartMonitor#][#]";
            server.SendMessage(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]), Message);
            time1 = DateTime.Now.ToLongTimeString();
            videoViewer = new VideoFrm(Convert.ToInt32(LST_SocketIds[Find_Index(DoorsView.SelectedItems[0].Text)]));
            videoViewer.Text = "Monitor Door[" + DoorsView.SelectedItems[0].Text + "]";
            //  videoViewer.ClosingEvent += new VideoFrm.closingDelegate(videoViewer_ClosingEvent);
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

       

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ServerUtility.InsertImage(@"F:\Games\Face Hack\Ali3.jpg", "333");
        //} 
        #endregion
    }

}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using Serialization;
using Network.Client;
using System.Data;
using System.Text;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Data.SqlClient;
using SmartDoor.Properties;
using System.Runtime.InteropServices;

namespace SmartDoor
{
    public partial class ClientFrm : System.Windows.Forms.Form
    {
        private NetworkStream output;
        private BinaryWriter writer;
        private BinaryReader reader;
        private string message = "";
        private Thread readThread;
        private string[] mStudent;
        long lengthofrichtextbox = 0;
        private bool ClientConnected = false;
        ChatClient.Forms.AuthorizationFrm Warnning_Form;
        ArrayList IncomingImages = new ArrayList();
        Client client = new Client();
        Client MClient ;
        TSCUpdater LogTXT, ImageUpdator;
        Client UpdatesClient = new Client();
        bool Restarting = false;
        bool Block = false;
        Thread th;
        int ImageQuality=30;
        DBUtility ServerUtility;
      
        /*
         * this variable is activated when we not
         * recieve any name from the server
         */
        private ArrayList Allowed_Students = new ArrayList();       
        InputDevice id;
        int NumberOfKeyboards;
        SlideDialog sd;
        private DriveDetector driveDetector = null;
        public static KeyboardHook kh;


        public ClientFrm()
        {
            ServerUtility = new DBUtility(this);
            #region Configuration Reading & File Processing
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Data\\Config.ini") || Configuration.Not_Valid())
            {
                MessageBox.Show(
                        this,
                        "Configuration file [Config.int] Not Exists,Or Unvalid configuration,\nApplication will exit.",
                        "Fetal Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
            #endregion   
            
            else 
            {
                InitializeComponent();
                InitializeBarcode();

                ImageUpdator = new TSCUpdater(image);
                LogTXT = new TSCUpdater(displayREdit);
              
                this.Text = "Door Client-" + Configuration.ClientName;
   
                if (Configuration.StandaloneMode.ToUpper() == "on".ToUpper())
                {
                    /*Adjust GUI For StandAlone Mode*/

                    UpDateGUI();

                    if (!File.Exists(Directory.GetCurrentDirectory() + Configuration.StandaloneModeStudentsFile))
                    {
                        File.Create(Directory.GetCurrentDirectory() + Configuration.StandaloneModeStudentsFile).Close();//<---- Release creation handel ,,Eagles                                      
                        MessageBox.Show(this, "[" + Configuration.StandaloneModeStudentsFile + "] Already created and empty, No one is allowed to enter \nYou must fill it by students.", "Smart Door", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Process.Start(Directory.GetCurrentDirectory() + Configuration.StandaloneModeStudentsFile);
                    }
                    else 
                    {
                        new Thread(new ThreadStart(Read_Students_List)).Start();
                    }                   
                }
                else 
                {
                    #region Init Asynch. Client & Form 

                    client.ErrorCatched += new Client.SocketErrorArg     (Client_ErrorCatched);
                    client.Disconnected += new Client.SocketDisconnectArg(Client_Disconnected);
                    client.DataReceived += new Client.SocketDataArg      (Client_DataReceived);
                    client.Connected    += new Client.SocketStatusArg    (  Client_Connected );
                    
                    #endregion

                    #region Init Asynch. Updates Client

                    UpdatesClient.DataReceived += new Client.SocketDataArg      (UpdatesClient_DataReceived);
                    UpdatesClient.ErrorCatched += new Client.SocketErrorArg     (UpdatesClient_ErrorCatched);
                    UpdatesClient.Connected    += new Client.SocketStatusArg    (  UpdatesClient_Connected );
                    UpdatesClient.Disconnected += new Client.SocketDisconnectArg(UpdatesClient_Disconnected);

                    #endregion
                }
            }  
        }

        private void InitializeBarcode()
        {
            driveDetector = new DriveDetector(this);
           
            driveDetector.DeviceChanged += new DriveDetectorEventHandler(OnDevChange);
            id = new InputDevice(Handle);
            id.DeviceHandel =int.Parse( HandelTXT.Text);//Machine Dependent
            NumberOfKeyboards = id.EnumerateDevices();
            id.BarcodeRecieved +=new InputDevice.DeviceEventHandler(id_BarcodeRecieved);
            /*kh = new KeyboardHook();
            kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(OnKeyIntecept);*/

        }
        void OnKeyIntecept(KeyboardHook.KeyboardHookEventArgs e)
        {
          
        }
        protected override void WndProc(ref Message message)
        {
            if (id != null)
            {
                id.ProcessMessage(message);
            }
            if (driveDetector != null)
            {
                driveDetector.WndProc(ref message);
            }

            base.WndProc(ref message);

        }
        private void OnDevChange(object sender, DriveDetectorEventArgs e)
        {

            id.EnumerateDevices();
            //this.label2.Text = "Barcode Status Changed.";
        }

        void id_BarcodeRecieved(object sender, InputDevice.KeyControlEventArgs e)
        {

            if (Configuration.SQLConnection)
            {
                ClearForm();
                inputTextBox.Text = e.Barcode;

                string[] Data;
                byte[] ImageData;

                DBUtility.User_Status U_Status = ServerUtility.GetRow(Configuration.ClientId, e.Barcode, out Data, out ImageData);
                try
                {
                    if (U_Status == DBUtility.User_Status.User_Not_Exist)
                    /*
                     * Not Found
                     */
                    {
                        //Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "],Not Authorized User [Not Exist in The Database], Barcode: [" + barCode + "] .", Color.Red);
                        //string Message = "[#<User_Data>#][#Student_Does_Not_Exist#][#]" + barCode + "[#]";
                        MessageBox.Show(this, "Sorry, There is no account for you\nYou have to call your System Adminstrator.", "Smart Door", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    /*
                     * Exist but not allowed
                     */
                    else if (U_Status == DBUtility.User_Status.User_Invalid)
                    {
                        //Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Invalid User, Barcode: [" + barCode + "] .", Color.Red);

                        //string Message = "[#<User_Data>#][#Invalid_Student#][#]" + barCode + "[#]";

                        //server.SendMessage(Soc_ID, Message);

                        //ServerUtility.Append_User_Log(
                        //    mDoorNumber,
                        //    barCode,
                        //    DateTime.Now.ToString(),
                        //    "False",
                        //    Server_db_connection);

                        new Thread(new ThreadStart(Turn_Warnning)).Start();

                    }

                    /*
                     * not allowed to enter this door
                     */
                    else if (U_Status == DBUtility.User_Status.User_Not_Allowed_To_Enter_Door)
                    {
                        /*outPut To GUI*/
                        //Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Unauthorized User, Barcode: [" + barCode + "] .", Color.Red);

                        //string Message = "[#<User_Data>#][#Student_Not_Allowed_To_Enter_Door#][#]" + barCode + "[#]";

                        //server.SendMessage(Soc_ID, Message);

                        //ServerUtility.Append_User_Log(
                        //    mDoorNumber,
                        //    barCode,
                        //    DateTime.Now.ToString(),
                        //    "False",
                        //    Server_db_connection);

                        new Thread(new ThreadStart(Turn_Warnning)).Start();
                    }

                    /*
                     * Found And Valid User and allowed
                     */
                    else
                    {

                        //Log("Door [" + mDoorName + "] IP [" + server.GetRemoteIP(Soc_ID) + "], Authorized User, Barcode: [" + barCode + "] .", Color.Green);

                        ///*Appending The log*/
                        //ServerUtility.Append_User_Log(
                        //    Door_Number,
                        //    barCode,
                        //    DateTime.Now.ToString(),
                        //    "True",
                        //    Server_db_connection);

                        ////string[] Str_Data = DBUtility.Get_String_Data(Data.ItemArray);

                        //string _SentMessage = String.Join("[#]", Data /*Str_Data*/);

                        //string Message = "[#<User_Data>#][#Text#][#]" + _SentMessage + "[#]";

                        //server.SendMessage(Soc_ID, Message);

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
                        //Image_Array = ServerUtility.Retrieve_Image(barCode);
                        //if (ImageData != null)
                        //{
                        //    server.SendMessage(Soc_ID, ImageData);
                        //    Thread.Sleep(100);
                        //    server.SendMessage(Soc_ID, Encoding.Default.GetBytes("[#<End_of_data>#]"));
                        //}
                        ////server.SendMessage(Soc_ID, "[#<User_Data>#][#ReadyToSend#][#]" + Convert.ToString(ImageData.Length - 9) + "[#]");
                        //   else  server.SendMessage(Soc_ID, "[#<EOF>#]"); 
                    }
                    //current_To_Send.M_Writer.Write("#USERDATA#");
                    //Seriallized_User user = new Seriallized_User(Data,  current_To_Send.M_NetworkStream);
                    SetText(userfnametxt, Data[0]);
                    SetText(userlnametxt, Data[1]);
                    SetText(useremailtxt, Data[2]);
                    SetText(userphonetxt, Data[3]);
                    SetText(userdescriptiontxt, Data[4]);
                    SetText(userstagecbo, Data[5]);
                    this.image.Image = Image.FromStream(new MemoryStream(ImageData));
                    System.Media.SystemSounds.Asterisk.Play();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                inputTextBox.Text = e.Barcode;
                if (!Block)
                {
                    Block = true;
                    try
                    {
                        /*
                         * Sending Barcode and door number for logging 
                         */
                        if (Mode_Status.Text == "Normal")
                        {
                            if (ClientConnected)
                            {

                                client.SendMessage("[#<CMD>#][#Barcode#][#]" + e.Barcode + "[#]" + Configuration.ClientName + "[#]" + Configuration.ClientId + "[#]");
                                Log("Sending Barcode [" + e.Barcode + "] to Server...", Color.Blue);
                                ClearForm();
                            }
                            else
                            {
                                Log("Door Now is not Connected to Server Or Blocked.\nYou Have To Log in First.", Color.Red);
                                ClearForm();
                            }
                            //inputTextBox.Clear();
                        }
                        else
                        {

                            if (Allowed_Students.BinarySearch(e.Barcode) < 0)
                            // Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning , . . .
                            {
                                new Thread(new ThreadStart(Turn_Warnning)).Start();
                            }
                            else
                            {
                                /**************************************************/
                                /*               OPEN THE DOOR                    */
                                /*              OPEN  THE  DOOR                   */
                                /**************************************************/
                                MessageBox.Show("Allowed");
                            }
                            //inputTextBox.Clear();
                            ClearForm();
                        }

                    }
                    catch (SocketException)
                    {
                        Log("Error sending barcode", Color.Red);
                        MessageBox.Show(this, "Error sending barcode [" + inputTextBox.Text + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { Log("Blokkkkkkkkkkkkkkkkkkkkk;", Color.Red); }
            }
        }

        private void UpDateGUI()
        {
            Mode_Status.Text = "Standalone";
            toolStripStatusLabel6.Visible = false;
            LblLastUpdate.Visible = false;
            LBLUpdates.Visible = false;
            toolStripStatusLabel8.Visible = false;
            toolStripStatusLabel1.Visible = false;
            toolStripStatus.Visible = false;
            CmdConnect.Visible = false;
            toolStripSeparator1.Visible = false;
            groupBox.Visible = false;
            panel1.Location = new Point(/*this.Width / 2 - BarcodePanel.Width / 2*/82, 56/* this.Height / 2 - BarcodePanel.Height / 2*/);

        }

        private void Read_Students_List()
        {
            /*used to inform User For The first Time*/
            bool First_Time = true;
            while (true)
            {
                Allowed_Students.Clear();
                Allowed_Students.TrimToSize();
                StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + Configuration.StandaloneModeStudentsFile);
                if (reader.BaseStream.Length == 0&&First_Time)
                {
                    First_Time = false;
                    MessageBox.Show(this, "[" + Configuration.StandaloneModeStudentsFile + "] is empty ,\nYou Must Fill it By Students", "Smart Door", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Process.Start(Directory.GetCurrentDirectory() + Configuration.StandaloneModeStudentsFile);
                }
                else
                {
                    while (!reader.EndOfStream)
                    {
                        Allowed_Students.Add(reader.ReadLine());
                    }
                    reader.Close();
                    Allowed_Students.Sort();
                }
                Thread.Sleep(1000); //check every 5 seconds
            }
        }

        #region <<<<<<<<<<<<<< Updates Client Event Handellation >>>>>>>>>>>>>>
        private void UpdatesClient_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            LBLUpdates.Text = "Receiving Updates... ";
            LBLUpdates.ForeColor = Color.Green;
            string All = "";
            #region ######## File Creation & Preparation ########


            if (!File.Exists(Directory.GetCurrentDirectory() + Configuration.NormalModeStudentsFile))
            {
                //file not created
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Configuration.NormalModeStudentsFile.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[0]))
                {
                    /*create the directory */
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Configuration.NormalModeStudentsFile.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                    /*and create the file*/
                    File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation handel ,,Eagles
                }
                else//directory exist but file no
                    File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation handel ,,Eagles                                      

            }          

            #endregion
            StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + Configuration.NormalModeStudentsFile, false);
            string IncomingCommand = Encoding.ASCII.GetString(sde.Data).Trim(new char[] { '\0' });
            if (IncomingCommand == "[#<Block_All>#]")
            {              
                LBLUpdates.Text = "All Blocked.";
                LBLUpdates.ForeColor = Color.Red;
                LblLastUpdate.Text = DateTime.Now.ToLongTimeString();
                sr.WriteLine("Students are not allowed\nto use this door since\n"+DateTime.Now.ToString());
                sr.Close();
            }
            else
            {
               
                if (IncomingCommand.EndsWith("[#<End>#]"))
                {
                    IncomingCommand = IncomingCommand.Remove(IncomingCommand.Length - 9, 9);
                    All = string.Concat(All, IncomingCommand);

                    string[] UserIdS = All.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < UserIdS.Length; i++)
                    {
                        sr.WriteLine(UserIdS[i]);
                    }
                    sr.Close();
                    LBLUpdates.Text = "Idle.";
                    LBLUpdates.ForeColor = Color.Blue;
                    LblLastUpdate.Text = DateTime.Now.ToLongTimeString();
                }
                else /*in this case the incoming chunck is the rest of names*/
                {
                    All = string.Concat(All, IncomingCommand);
                }
            }
        }
        void UpdatesClient_Connected(object Sender, EventArgs ea)
        {

        }
        void UpdatesClient_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {

        }

        void UpdatesClient_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
         //   Log("[Error Catched]:\n" + see.Message, Color.Red);
        }
        
        #endregion

        #region <<<<<<<<<<<<<< Client Events Handellation For Asynch. C/S >>>>>>>>>>>>>>
        void Client_Connected(object Sender, EventArgs ea)
        {            
            /*
             * Send Door Username and Password to server
             */
            client.SendMessage("[#<CMD>#][#Authentication#][#]" + Configuration.ClientName + "[#]" + Configuration.ClientPassword + "[#]"+Configuration.ClientId+"[#]");
            Log("Sending username and password to Server...",Color.Blue);
        }

        private void SetGUI(bool p)
        {
            ClientConnected = p;
          
            if (p) 
            {
                if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower())
                {
                    th.Suspend();//stop retry connection
                }          
                toolStripStatus.Text = "Connected";
                toolStripStatus.Image = (Image)SmartDoor.Properties.Resources.smallsuccess;  
                CmdConnect.Text = "&Disconnect";
                CmdConnect.Image = (Image)SmartDoor.Properties.Resources.cross;
                toolStripStatus.ForeColor = Color.Green;

            }
            else
            {
                try
                {
                    if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower())
                    {
                        th.Resume();//stop retry connection
                    }
                   
                }
                catch { }                      
                CmdConnect.Text = "&Connect";
                toolStripStatus.Text = "Disconnected";
                toolStripStatus.Image = (Image)SmartDoor.Properties.Resources.smallfail;
                CmdConnect.Image = (Image)SmartDoor.Properties.Resources.next;
                toolStripStatus.ForeColor = Color.Red;
            }
        }
        void Client_DataReceived(object Sender, SocketDataEventsArg sde)
        {
                        
            string IncomingCommand = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });  // An clean string which contain the commands arguments.
            /*
             * User Data&,........
             */
            if (IncomingCommand.StartsWith("[#<User_Data>#]"))    // Detect the existance of command on the received data.
            {
                // An command detected, split it to retrive the arguments
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<User_Data>#]").Length).Split(new string[] { "[#]" }, 8, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case ("[#Text#]"):
                        {
                           
                            //display data from server on door GUI  
                            Display_User_Data(CmdArg);

                            /**************************************************/
                            /*               OPEN THE DOOR                    */
                            /*              OPEN  THE  DOOR                   */
                            /**************************************************/
                            break;
                        }
                   /* case ("[#ReadyToSend#]"):
                        {
                            if (GetClientPacket() != null)
                            {
                                IncomingImages.Remove(GetClientPacket());
                            }
                            IncomingImages.Add(new FilePacket(int.Parse(CmdArg[1])));
                            client.SendMessage("[#<CMD>#][#ReadyToReceive#][#]");
                            break;
                        }*/
                    case ("[#Invalid_Student#]"):
                        {
                            /*Student Not Activated*/

                            /*   ÝÖÇíÍ  
                             * Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning , . . .
                             */
                            new Thread(new ThreadStart(Turn_Warnning)).Start();
                            Block = false;
                            break;
                        }
                    case ("[#Student_Not_Allowed_To_Enter_Door#]"):
                        {
                            /*Student Not Allowed*/

                            /*   ÝÖÇíÍ  
                             * Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning , . . .
                             */
                            new Thread(new ThreadStart(Turn_Warnning)).Start();
                            break;
                        }
                    case ("[#Student_Does_Not_Exist#]"):
                        {
                            MessageBox.Show(this,"Sorry, There is no account for you\nYou have to call your System Adminstrator.","Smart Door",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Block = false;
                            break;
                        }
                }
            }

            /*
             * this Part to handel information messages such authorization,...etc
             */
            else if (IncomingCommand.StartsWith("[#<Information>#]"))
            {
                
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<Information>#]").Length).Split(new string[] { "[#]" }, 3, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case ("[#UnAuthorized_Door#]"):
                        {
                            /*Server Will Disconnect This door*/
                            Log("Login Failed, invalid Username Or Password.",Color.Red);
                            if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower())
                            {
                                th.Suspend();//stop retry connection
                            }
                            break;
                        }
                    case ("[#Login_Successful#]"):
                        {
                            /*here we can connect Updates Client*/
                            UpdatesClient.Connect(Configuration.ServerIP, Configuration.UpdatesPort);

                            SetGUI(true);                         

                            Log("Login Succeeded.", Color.Green);
                            break;
                        }
                    case ("[#Not_Connected_To_DB#]"):
                        {
                            Log("\nLogin failed...\nServer now is not Connected to Database,Try to Login later.", Color.Red);
                            break;
                        }                       
                }
            }
            else if (IncomingCommand.StartsWith("[#<CMD>#]"))
            {
                    /*Server Will Disconnect This door*/
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<CMD>#]").Length).Split(new string[] { "[#]" }, 8, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case ("[#StartMonitor#]"):
                        {
                            Log("Door Monitoring Started.", Color.Green);
                            startMonitorClient();
                            break;
                        }
                    case ("[#StopMonitor#]"):
                        {
                            MClient.Disconnect();
                            MClient = null;
                            Log("Door Monitoring Stopped.", Color.Red);
                            GC.Collect();
                            break;
                        }
                }         
            }
            else if (IncomingCommand.StartsWith("[#<End_of_data>#]"))
            {
                Block = false;
                Log("User Data retrieved Successfully.", Color.Green);
            }
            /*
             * Incoming data not command, so its data so put it in right place
             */
            else
            {
               
                string DetectEOF = Encoding.ASCII.GetString(sde.Data);  //Detect the End Of File, by looking for the [#<EOF>#] inside encoded data.
                if (DetectEOF.IndexOf("[#<EOF>#]") > -1)        //EOF detected, so remove that tag, and all the garbish follow it, an only keep data befor that tag.
                {
                    byte[] ClonedChunk = (byte[])sde.Data.Clone();
                    Array.Resize(ref ClonedChunk, DetectEOF.IndexOf("[#<EOF>#]"));
                    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    ClientPacket.WriteData(ClonedChunk, true);
                    ImageUpdator.Image = ClientPacket.ClientImage;

                    ClientPacket.Truncate();
                    //for (int i = 0; i < IncomingImages.ToArray().Length; i++)
                    //    IncomingImages.RemoveAt(i);
                    //if (DetectEOF.IndexOf("[#<End_of_data>#]") > -1)
                    //{
                    //    Log("end of    if (DetectEOF.IndexOf", Color.Red);
                    //    Block = false;
                    //}
                }
                else
                {
                    //if (ClientPacket.mProgress > 102400)//if larger than 100kb show this first
                    //{
                    //    ClientPacket.WriteData(sde.Data, true);
                    //}
                    //else
                    //{
                    //Log(sde.Data.Length.ToString(), Color.Brown);
                    ClientPacket.WriteData(sde.Data, false);
                    //}
                }
            }
            System.Threading.Thread.Sleep(0);   //Without that line you will got just rabish, as the processor will execute it very fastly and collect garbish data from stream, so we must delay the execution.            
        }
        FilePacket ClientPacket = new FilePacket();
        private void startMonitorClient()
        {
            MClient = new Client();
            MClient.DataReceived += new Client.SocketDataArg(M_DataReceived);
            MClient.ErrorCatched += new Client.SocketErrorArg(M_ErrorCatched);
            MClient.Connected += new Client.SocketStatusArg(M_Connected);
            MClient.Disconnected += new Client.SocketDisconnectArg(M_Disconnected);
            MClient.Connect(Configuration.ServerIP, 6000);
            
        }
        //int[,] FramesDelay=new int[500,2];
        //int index1=0;
        //bool firstVal = false, secondVal = false;
        void M_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            string IncomingCommand = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });  // An clean string which contain the commands arguments.
            //Log("incoming command= " + IncomingCommand, Color.Green); 
            if (IncomingCommand.StartsWith("[#<CMD>#]"))    // Detect the existance of command on the received data.
            {
                // An command detected, split it to retrive the arguments
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<CMD>#]").Length).Split(new string[] { "[#]" }, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case ("[#ReadyToReceive#]"):
                        {
                            /*lock (this)
                             {
                                 if (!firstVal)
                                 {
                                     FramesDelay[index1, 0] = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
                                     firstVal = true;
                                     secondVal = false;
                                 }

                             }*/
                            ImageQuality = int.Parse(CmdArg[2]);//[#Quality#][#]ImageQuality[#]
                            /*Log("Quality=" + ImageQuality, Color.Green);*/
                            //Thread.Sleep(10);
                            MClient.SendMessage(DesktopImage.GetDesktopImage(ImageQuality))/*imageData*/;

                            break;
                        }
                    case ("[#EndOfReceive#]"):
                        {
                            //Thread.Sleep(10);
                            //MessageBox.Show("");
                            /*lock (this)
                            {
                               if (!secondVal)
                                {
                                    FramesDelay[index1++, 1] = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
                                    firstVal = false;
                                    secondVal = true;
                                }
                            }*/
                            ReadyToSend();
                            break;
                        }
                    case ("[#StopMonitor#]"):
                        {
                            //MClient.Disconnect();

                            Log("Door Monitoring Stopped.", Color.Red);
                            break;
                        }
                    case ("[#StartMonitor#]"):
                        {
                            Log("Door Monitoring Started.", Color.Green);
                            MClient.Connect(Configuration.ServerIP, 6000);
                            break;
                        }
                    case ("[#MouseEvents#]"):
                        {

                            xPos =int.Parse( CmdArg[3]); yPos =int.Parse( CmdArg[5]);
                            //SetCursorPos(xPos, yPos);
                            
                            switch (CmdArg[7])//Button Type
                            {
                                case ("Left"):
                                    MouseBtn = MouseButtons.Left;
                                    break;
                                case ("Right"):
                                    MouseBtn = MouseButtons.Right;
                                    break;
                                case ("Middle"):
                                    MouseBtn = MouseButtons.Middle;
                                    break;
                                case ("None"):
                                    MouseBtn = MouseButtons.None;
                                    break;
                            }

                            switch (CmdArg[1])//Mouse Event Type
                            {
                                case ("[#MouseMove#]"):
                                   // Log("M Move Event", Color.Red);
                                    //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MOVE, 0, 0, 0, 0);
                                    MouseSendInput(MOUSEEVENTF_MOVE, xPos, yPos);
                                    break;
                                case ("[#MouseDown#]"):
                                    Log("M Down Event", Color.Red);
                                    if(MouseBtn==MouseButtons.Left)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_LEFTDOWN, xPos, yPos);
                                    else if (MouseBtn == MouseButtons.Right)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_RIGHTDOWN, xPos, yPos);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_MIDDLEDOWN, xPos, yPos);
                                    break;
                                case ("[#MouseUp#]"):
                                    Log("M Up Event", Color.Red);
                                    if (MouseBtn == MouseButtons.Left)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_LEFTUP, xPos, yPos);
                                    else if (MouseBtn == MouseButtons.Right)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_RIGHTUP, xPos, yPos);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_MIDDLEUP, xPos, yPos);
                                    break;
                                case ("[#MouseClick#]"):
                                    if (MouseBtn == MouseButtons.Left)
                                    {
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_LEFTDOWN, xPos, yPos);
                                        MouseSendInput(MOUSEEVENTF_LEFTUP, xPos, yPos);
                                    }
                                    else if (MouseBtn == MouseButtons.Right)
                                    {
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_RIGHTDOWN, xPos, yPos);
                                        MouseSendInput(MOUSEEVENTF_RIGHTUP, xPos, yPos);
                                    }
                                    else if (MouseBtn == MouseButtons.Middle)
                                    {
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                        //mouse_event(MOUSEEVENTF_ABSOLUTE|MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                        MouseSendInput(MOUSEEVENTF_MIDDLEDOWN, xPos, yPos);
                                        MouseSendInput(MOUSEEVENTF_MIDDLEUP, xPos, yPos);
                                    }
                                    break;
                                case ("[#MouseDoubleClick#]"):
                                    //mouse_event(MOUSEEVENTF_MOVE, xPos, yPos, 0, 0);

                                    //Send the first click to the same location
                                    MouseSendInput(MOUSEEVENTF_LEFTDOWN, xPos, yPos);
                                    MouseSendInput(MOUSEEVENTF_LEFTUP, xPos, yPos);
                                    
                                    //Sleep to simulate delay
                                    Thread.Sleep(80);

                                    //Send second click to the same location
                                    MouseSendInput(MOUSEEVENTF_LEFTDOWN, xPos, yPos);
                                    MouseSendInput(MOUSEEVENTF_LEFTUP, xPos, yPos);

                                    break;
                            }
                            
                            break;
                        }

                }
                System.Threading.Thread.Sleep(0);   //Without that line you will got just rabish, as the processor will execute it very fastly and collect garbish data from stream, so we must delay the execution.            
            }
        }

        int xPos, yPos;
        MouseButtons MouseBtn;
        #region General Declarations
        void MouseSendInput(int Flag,int xPos,int yPos)
        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            int x2 = (65535 * xPos) / screen.Width;
            int y2 = (65535 * yPos) / screen.Height;

            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = x2; //clickLocation.X;
            i.mi.dy = y2; // clickLocation.Y;
            i.mi.dwFlags =MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE| Flag;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
//            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
  //          SendInput(1, ref i, Marshal.SizeOf(i));
        }
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern Int32 SetCursorPos(Int32 x, Int32 y);
        Int32 MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        Int32 MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        Int32 MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        Int32 MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        Int32 MOUSEEVENTF_RIGHTUP = 0x0010;/* right button up */
        Int32 MOUSEEVENTF_MIDDLEDOWN = 0x0020;/* middle button down */
        Int32 MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        Int32 MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        Int32 MOUSEEVENTF_XUP = 0x0100; /* x button down */
        Int32 MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        Int32 MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        Int32 MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */
        #endregion

/// <summary>
        /// used to inform server that client is ready to send desktop image.......
        /// </summary>
        private void ReadyToSend()
        {

            int imageDataLength;
            lock (this)
            {
                imageDataLength = DesktopImage.GetDesktopImage(ImageQuality, false);
            }
           /* Log("Frame Size= "+(imageDataLength/1024).ToString()+" KBytes.", Color.Gold);*/
            if (imageDataLength != 0)
                MClient.SendMessage("[#<CMD>#][#ReadyToSend#][#]" + Convert.ToString(imageDataLength - 9) + "[#]");
            imageDataLength = 0;
        }
       
        void M_Connected(object Sender, EventArgs ea)
        {
            //Log("try to send image", Color.Red);
            //ReadyToSend();
            //conn = true;
        }
        void M_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            Log("Server Monitoring Disconnect Event...",Color.Gold);
            //conn = false;
        }

        void M_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            Log("Monitoring Error: "+see.Message, Color.Gold);
        }
       

        public void Turn_Warnning()
        {   
            Warnning_Form = new ChatClient.Forms.AuthorizationFrm("You Are not Authorized!");
            Warnning_Form.Times = 2;/*beep twice only do not make bollika*/
            Warnning_Form.ShowDialog(this);
        }

        FilePacket GetClientPacket()
        {
            FilePacket ClientPacket = null;
            for (int I = 0; I < IncomingImages.Count; I++)
            {
                ClientPacket = (FilePacket)IncomingImages[I];
            }
            return ClientPacket;
        }

        private void Display_User_Data(string[] CmdArg)
        {
            /*ÔÛÇáå äÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÇÑ*/
            //to a void so called "cross-thread" Exception
            SetText(userfnametxt, CmdArg[1]);
            SetText(userlnametxt, CmdArg[2]);
            SetText(useremailtxt, CmdArg[3]);
            SetText(userphonetxt, CmdArg[4]);
            SetText(userdescriptiontxt, CmdArg[5]);
            SetText(userstagecbo, CmdArg[6]);
            System.Media.SystemSounds.Asterisk.Play();

            Append_Log_In_File(CmdArg[1], CmdArg[2]);
        }

        private void Append_Log_In_File(string Fname, string Lname)
        {
            #region ######## File Creation & Preparation ########
            if (Configuration.TextLog.ToUpper() == "on".ToUpper())
            //if door is configured to append 
            //log of students who enter
            {
                if (!File.Exists(Directory.GetCurrentDirectory() + Configuration.TextLogFileName))
                {
                    //file not created
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + Configuration.TextLogFileName.Split(new char[] { '\\' }, 2, StringSplitOptions.RemoveEmptyEntries)[0]))
                    {
                        /*create the directory */
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + Configuration.TextLogFileName.Split(new char[] { '\\' }, 2, StringSplitOptions.RemoveEmptyEntries)[0]);
                        /*and create the file*/
                        File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation handel ,,Eagles
                    }
                    else//directory exist but file no
                        File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation handel ,,Eagles                                      
                }             

            #endregion

                //* Here at this point file is exist ... exist no straggile*//
                //*write what you wanna *\\
                StreamWriter Log_Writer = new StreamWriter(Directory.GetCurrentDirectory() + Configuration.TextLogFileName, true);

                Log_Writer.WriteLine(Fname + " " + Lname + ", Has Entered at " + DateTime.Now.ToString());

                Log_Writer.Close();

            }
        }
        void Client_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            SetGUI(false);
            Log("Main Connection Broken.", Color.Red);
            //Log("[Error Catched]:\n" + sde., Color.Red);
          // if(Configuration.AutoConnect)
          //   new Thread( new ThreadStart(AutoConnect)).Start();
            
        }

        void Client_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
             //Log("Connection Failed.", Color.Red);
             //if (Configuration.AutoConnect)
              //  new Thread(new ThreadStart(AutoConnect)).Start();
             Log("[Error Catched]:\n" + see.Message, Color.Red);
        }
        #endregion     
       
        private void Log(string p, Color col)
        {
           
            LogTXT.AppendText(p);
            lengthofrichtextbox += p.Length;
            LogTXT.Select((int)lengthofrichtextbox - p.Length, p.Length);
            LogTXT.SelectionColor = col;
            /** if (col == Color.Green)
                 LogTXT.SelectionFont = new Font("tahoma",9);*/
            LogTXT.AppendText("\n\n");
            lengthofrichtextbox += "\n\n".Length;
            
           
        }     

        private void ClearForm()
        {
            foreach (Control c in groupBox.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    new TSCUpdater(c).Text = "";
                else if (c.GetType() == typeof(PictureBox))
                    new TSCUpdater(c).Image = null;
            }
        }

        private delegate void SetTextDelegate(Control Ctrl, object Index);
        private void SetText(Control Ctrl, object Index)
        {
            if (Ctrl.InvokeRequired)
            {
                Invoke(new SetTextDelegate(SetText), new object[] { Ctrl, Index });
            }
            else
            {
                if (Ctrl.GetType() == typeof(TextBox))
                {

                    ((TextBox)Ctrl).Text = Index.ToString();
                }

                else if (Ctrl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)Ctrl).Checked = (Index.ToString() == "True") ? true : false;

                }
                else if (Ctrl.GetType() == typeof(PictureBox))
                {
                    ((PictureBox)Ctrl).Image = Image.FromStream((MemoryStream)Index);

                }
                else if (Ctrl.GetType() == typeof(Label))
                {
                    ((Label)Ctrl).Text = (Index.ToString() == "True") ? "Valid" : "Unvalid";
                }

            }
        }
        #region Code For Synch. C/S [Not Used]

        public void RunClient()
        {
            TcpClient client;
            try
            {
                displayREdit.Text += "Attempting connection\r\n";

                client = new TcpClient();
                client.Connect("localhost", 50000);

                output = client.GetStream();

                writer = new BinaryWriter(output);
                reader = new BinaryReader(output);

                displayREdit.Text += "\r\nGot I/O streams\r\n";
                inputTextBox.ReadOnly = false;
                /*
                 * Write client key at form Title
                 */
                this.Text = reader.ReadInt16().ToString();
                GetStreams();

                displayREdit.Text += "\r\nClosing connection.\r\n";
                writer.Close();
                reader.Close();
                output.Close();
                client.Close();
                Application.Exit();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void GetStreams()
        {
            do
            {
                try
                {
                    message = reader.ReadString();
                    if (message == "#USERDATA#")
                    {
                        Seriallized_User user_De_Serial = new Seriallized_User((NetworkStream)reader.BaseStream);

                        //settext(userfnametxt, user_De_Serial.User_Obj.m_userfName);
                        //settext(userdescriptiontxt, user_De_Serial.User_Obj.m_userDescription);
                        //settext(useremailtxt, user_De_Serial.User_Obj.m_userEmail);
                        //settext(userlnametxt, user_De_Serial.User_Obj.m_userlName);
                        //settext(userphonetxt, user_De_Serial.User_Obj.m_userPhone);
                        //settext(userstagecbo, user_De_Serial.User_Obj.m_userStage);
                        ////vaildCHK.Checked  , user_De_Serial.User_Obj.m_userValid;

                    }
                    else
                        displayREdit.Text += "\r\n" + message;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(System.Environment.ExitCode);
                }
            }
            while (true);
        } 
        #endregion


        private void StartStop()
        {
            switch (CmdConnect.Text)
            {
                case ("&Connect"):
                    client.Connect(Configuration.ServerIP, Configuration.ServerPort);
                    break;
                case ("&Disconnect"):
                    client.Disconnect();
                    ClientConnected = false;
                    UpdatesClient.Disconnect();
                    break;
            }

        }

        private void ClientFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (CmdConnect.Text == "&Disconnect")
                    //this line to enable client to send his name to server before close
                    client.Disconnect();
                if (Restarting)
                    Process.Start(Application.ExecutablePath);
                System.Environment.Exit(System.Environment.ExitCode);
            }
            catch { }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void displayREdit_TextChanged(object sender, EventArgs e)
        {
            displayREdit.ScrollToCaret();
        }
        public static void Paint_Gradiant(PaintEventArgs e,Form mForm)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 10), new Rectangle(mForm.Width - 1, mForm.Height - 1, 0, 0));

            LinearGradientBrush brBrush;
            Rectangle rcBrush = new Rectangle(0, 0, mForm.Width, mForm.Height); ;
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

            Rectangle rcClient = new Rectangle(0, 0, mForm.Width, mForm.Height);
            Rectangle rcContent = rcClient;
            e.Graphics.FillRectangle(brBrush, rcContent);
            //  e.Graphics.DrawRectangle(new Pen(Color.Black, 5), new Rectangle(0, 0, this.Width - 1, this.Height - 1));

        }
        private void ClientFrm_Paint(object sender, PaintEventArgs e)
        {
            //Paint_Gradiant(e,this);
        }       

        private void CmdConnect_Click(object sender, EventArgs e)
        {
            try
            {               
                StartStop();
            }
            catch { }
        }

        private void ExitMBTN_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            Paint_Gradiant(e,this);
        }

        private void ConfigureBTN_Click(object sender, EventArgs e)
        {
            new Door_Config(Configuration.ClientName).ShowDialog(this);
        }
        private void Action_Menu_Paint(object sender, PaintEventArgs e)
        {
            //Paint_Gradiant(e);
        }

        private void image_Click(object sender, EventArgs e)
        {
            if (image.Image == null)
                return;
            new ChatClient.Forms.Full_Image(image.Image).ShowDialog(this);
        }         

        private void Action_Menu_Opening(object sender, CancelEventArgs e)
        {
            if (displayREdit.Text.Length == 0)
                e.Cancel = true;
        }

        private void Save_Action_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "ServerLog_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".txt";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (displayREdit.Text.Length != 0)
                    displayREdit.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Clear_Action_Click(object sender, EventArgs e)
        {
            displayREdit.Text = "";
        }

        private void RestartApp_CMD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure that you want to restart Application", "Smart Door", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Restarting = true;
                Close();
            }
         }

        private void CMD_Eject_Click(object sender, EventArgs e)
        {
             if (Mode_Status.Text == "Normal")
            sd = new SlideDialog(this, (float)0.1,client,null,HandelTXT);
             else
            sd = new SlideDialog(this, (float)0.1, null, Allowed_Students, HandelTXT);
            sd.SlideDirection = SlideDialog.SLIDE_DIRECTION.RIGHT;

            sd.Slide();
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {
            Paint_Gradiant(e, this);
        }

        private void HandelTXT_TextChanged(object sender, EventArgs e)
        {
            if (HandelTXT.Text.Length == 0)
                id.DeviceHandel = 0;
            else
            {
                try
                {
                    id.DeviceHandel = int.Parse(HandelTXT.Text);
                }
                catch { }
            }

        }

        private void ClientFrm_Load(object sender, EventArgs e)
        {
            if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower())
            {
                th = new Thread(new ThreadStart(AutoConnect));
                th.Start();
            }

        }

        private void AutoConnect()
        {

            while (true)
            {             
             
                Log("Attempt connection...", Color.Blue);
                CmdConnect.PerformClick();               
                Thread.Sleep(int.Parse(Configuration.TimeOut));}
           
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!Block)
            {
                client.SendMessage("[#<CMD>#][#Barcode#][#]" + (555).ToString() + "[#]" + Configuration.ClientName + "[#]" + Configuration.ClientId + "[#]");

                //Log("Sending Barcode [" + inputTextBox.Text + "] to Server...");

                ClearForm();
            }
            else { Log("Blokkkkkkkkkkkkkkkkkkkkk;", Color.Red); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReadyToSend();
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Block = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //byte[] arr;
            //int sec1=DateTime.Now.Millisecond;
            //arr=DesktopImage.GetDesktopImage(100);
            //int sec2 = DateTime.Now.Millisecond;
            //MessageBox.Show((sec2-sec1).ToString());
            /*string str = "";
            int sum = 0;
            int count = 0;
            int diff = 0;
            for (int i = 0; i < FramesDelay.GetLength(0); i++)
            {
                diff = FramesDelay[i, 1] - FramesDelay[i, 0];
                if (i % 10 == 0) str += "\r\n";
                str += (diff).ToString() + "\t";
                if (diff > 0)
                {
                    sum += diff;
                    count++;
                }
            }
            MessageBox.Show(str);
            MessageBox.Show((sum / count).ToString());
            */

        }
        private SqlConnection Server_db_connection;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!ServerUtility.IsConnected)
            {
                Server_db_connection = ServerUtility.ConnectToSQL();
                /*Eagle may ex raised so don not update gui till it connected really*/
                if (ServerUtility.IsConnected)
                {
                    //ConnectToDB.Image = ExitMBTN.Image;
                    toolStripStatus.Text = "Connected To Database";
                    toolStripStatus.ForeColor = Color.Green;
                    toolStripStatus.Image = Resources.smallsuccess;
                    toolStripMenuItem1.Text = "Close Database Connection";
                }
            }
            else
            {
                ServerUtility.DisConnectToSQL();
                //ConnectToDB.Image = SmartDoor.Properties.Resources.play;
                toolStripStatus.Text = "Disconnectd To Database";
                toolStripStatus.ForeColor = Color.Red;
                toolStripStatus.Image = Resources.smallfail;
                toolStripMenuItem1.Text = "Connect To Database";
            }
        }


    }
}

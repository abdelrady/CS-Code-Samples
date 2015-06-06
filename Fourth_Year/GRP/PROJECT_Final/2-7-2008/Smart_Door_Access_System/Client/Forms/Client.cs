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
using System.Net.NetworkInformation;
using SmartDoor.Forms;


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
        private long lengthofrichtextbox = 0;
        private bool ClientConnected = false;
        private ChatClient.Forms.AuthorizationFrm Warnning_Form;
        private ArrayList IncomingImages = new ArrayList();
        private Client client = new Client();
        private Client MClient;
        private Client LogClient = new Client();
        private TSCUpdater LogTXT, ImageUpdator;
        private Client UpdatesClient = new Client();
        private bool Restarting = false;
        private bool Block = false;
        private Thread th;
        private int ImageQuality = 30;
        private DBUtility ServerUtility;
        private Door door;
        private ArrayList Allowed_Students = new ArrayList();
        private InputDevice id;
        private int NumberOfKeyboards;
        private SlideDialog sd;
        private DriveDetector driveDetector = null;
        public static KeyboardHook kh;

        string strNoAccount = "There is no account for you.";
        string strTheif = "You are already inside another door.";
        string strNotAllowed = "You are not allowed to enter this door.";

        public void SetStatus(string p)
        {
            lblStatus.Text= p;
        }
        public ClientFrm()
        {
            ServerUtility = new DBUtility(this);        
          
            #region Configuration Reading & File Processing
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Data\\Config.ini") || Configuration.Not_Valid())
            {
                MessageBox.Show(
                        this,
                        "Configuration file [Config.ini] Not Exists,Or Unvalid configuration,\nApplication will exit.",
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
                
                //Door may be not invloved in the operation
                if (!Configuration.DoorDisabled)
                {
                    lblDoorStatus.Text = "Enabled.";
                    lblDoorStatus.ForeColor = Color.Green;
                  
                    door = new Door(true, this);
                }
                else if (Configuration.DoorDisabled)
                {

                    lblDoorStatus.Text = "Disabled.";
                    lblDoorStatus.ForeColor = Color.Red;
                   
                }
                this.Text = "Door Client-" + Configuration.ClientName;

                /*Adjust GUI For StandAlone Mode to Apply Current Mode Selected*/

                UpDateGUI();


                if (Configuration.StandaloneMode.ToUpper() == "on".ToUpper())
                {


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

                    client.ErrorCatched += new Client.SocketErrorArg(Client_ErrorCatched);
                    client.Disconnected += new Client.SocketDisconnectArg(Client_Disconnected);
                    client.DataReceived += new Client.SocketDataArg(Client_DataReceived);
                    client.Connected += new Client.SocketStatusArg(Client_Connected);

                    #endregion
                    #region Init Asynch. Updates Client

                    UpdatesClient.DataReceived += new Client.SocketDataArg(UpdatesClient_DataReceived);
                    UpdatesClient.ErrorCatched += new Client.SocketErrorArg(UpdatesClient_ErrorCatched);
                    UpdatesClient.Connected += new Client.SocketStatusArg(UpdatesClient_Connected);
                    UpdatesClient.Disconnected += new Client.SocketDisconnectArg(UpdatesClient_Disconnected);

                    #endregion
                    #region Init Asynch. Logs Client

                    LogClient.ErrorCatched += new Client.SocketErrorArg(LogClient_ErrorCatched);
                    LogClient.Disconnected += new Client.SocketDisconnectArg(LogClient_Disconnected);
                    LogClient.DataReceived += new Client.SocketDataArg(LogClient_DataReceived);
                    LogClient.Connected += new Client.SocketStatusArg(LogClient_Connected);

                     #endregion

                }
            }
        }

        void LogClient_Connected(object Sender, EventArgs ea)
        {
          
            Log("Sending Logs To Server...", Color.Blue);
            StreamReader sr = new StreamReader(File.OpenRead(Directory.GetCurrentDirectory() + Configuration.TextLogFileName));
            StringBuilder sb = new StringBuilder();
            while(!sr.EndOfStream)                           
               sb.Append(sr.ReadLine()+"#");          
            sb.Append("#<EndOFList>#");
            LogClient.SendMessage(Encoding.UTF8.GetBytes(sb.ToString()));        
            sr.Close();
            Log("Sending Logs To Server Finished.", Color.Green);        
            File.Open(Directory.GetCurrentDirectory() + Configuration.TextLogFileName,FileMode.Truncate).Close();
        }

        void LogClient_DataReceived(object Sender, SocketDataEventsArg sde)
        { }
        void LogClient_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        { }

        void LogClient_ErrorCatched(object Sender, SocketErrorEventsArg see)
        { }

        private void InitializeBarcode()
        {
            driveDetector = new DriveDetector(this);

            driveDetector.DeviceChanged += new DriveDetectorEventHandler(OnDevChange);
            id = new InputDevice(Handle);
            id.DeviceHandel = int.Parse(HandelTXT.Text);//Machine Dependent
            NumberOfKeyboards = id.EnumerateDevices();
            id.BarcodeRecieved += new InputDevice.DeviceEventHandler(id_BarcodeRecieved);
           // kh = new KeyboardHook();
           // kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(OnKeyIntecept);

        }
        void OnKeyIntecept(KeyboardHook.KeyboardHookEventArgs e)
        { }
        protected override void WndProc(ref Message message)
        {
            if (!Block)
            {
                if (id != null)
                {
                    id.ProcessMessage(message);
                }
                if (driveDetector != null)
                {
                    driveDetector.WndProc(ref message);
                }
            }
            base.WndProc(ref message);

        }
        private void OnDevChange(object sender, DriveDetectorEventArgs e)
        {
            /*Re enum KB devices*/
            id.EnumerateDevices();         
        }    
      

        void id_BarcodeRecieved(object sender, InputDevice.KeyControlEventArgs e)
        {
            inputTextBox.Text = e.Barcode;           
            if (!Configuration.DoorDisabled)
            {
                if (door.doorStatus == Door.DoorStatus.Opened || door.doorStatus == Door.DoorStatus.InWork)
                {
                    Log("Sorry Door Is Already In Work...", Color.Black);
                    return;
                }
            }
            if (Configuration.StandaloneMode.ToLower() == "on")
            {

                if (Allowed_Students.BinarySearch(e.Barcode) < 0)
                //Warning...Beep beep Warning , . . .
                {
                    Turn_Warnning(strNotAllowed); 
                    Append_Log_In_File(e.Barcode, "False");
                }
                else
                {                  
                    //open the door
                    if (!Configuration.DoorDisabled)
                    new Thread(new ThreadStart(door.Open_The_Door)).Start();
                    //door.Open_The_Door();
                    
                    Log("Door Opened,You Are Welcome.", Color.Green);
                    Log("[" + e.Barcode + "] You Are Allowed To Enter.", Color.Green);
                    Append_Log_In_File(e.Barcode, "True");
                }
                //inputTextBox.Clear();                 

            }
            else if (Configuration.SQLConnection)
            {
                if (!ServerUtility.IsConnected)
                {
                    Log("You Must Connect To Database First.", Color.Red);
                    return;
                }
                ClearForm();
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
                            Turn_Warnning(strNoAccount);                          
                            Log("Sorry, There is no account for you\nYou have to call your System Adminstrator.", Color.Brown);
                        
                        }

                        /*
                         * Exist but not allowed
                         */
                        else if (U_Status == DBUtility.User_Status.User_Theif)
                        {

                            Turn_Warnning(strTheif);
                            /*SetText(userfnametxt, Data[0]);
                            SetText(userlnametxt, Data[1]);
                            SetText(userphonetxt, Data[2]);
                            SetText(userstagecbo, Data[3]);
                            SetText(useremailtxt, Data[4]);
                            SetText(userdescriptiontxt, Data[5]);
                            if (ImageData != null)
                                image.Image = Image.FromStream(new MemoryStream(ImageData));
                            else
                                image.Image = Resources.UnknownCharacter;*/
                            ServerUtility.Append_User_Log(
                           Configuration.ClientId,
                           e.Barcode,
                           DateTime.Now.ToString(),
                           "False", "User Theif");
                            Log("You Are not allowed to enter.", Color.Red);
                        }

                        /*
                         * not allowed to enter this door
                         */
                        else if (U_Status == DBUtility.User_Status.User_Not_Allowed_To_Enter_Door)
                        {
                            Turn_Warnning(strNotAllowed);
                            /*SetText(userfnametxt, Data[0]);
                            SetText(userlnametxt, Data[1]);
                            SetText(userphonetxt, Data[2]);
                            SetText(userstagecbo, Data[3]);
                            SetText(useremailtxt, Data[4]);
                            SetText(userdescriptiontxt, Data[5]);
                            if (ImageData != null)
                                image.Image = Image.FromStream(new MemoryStream(ImageData));
                            else
                                image.Image = Resources.UnknownCharacter;*/
                            ServerUtility.Append_User_Log(
                            Configuration.ClientId,
                            e.Barcode,
                            DateTime.Now.ToString(),
                            "False","Not Allowed");
                            Log("You Are not allowed to enter.", Color.Red);
                          
                        }

                        /*
                         * Found And Valid User and allowed
                         */
                        else if(U_Status== DBUtility.User_Status.User_Valid_And_Allowed_Enter)
                        {

                            SetText(userfnametxt, Data[0]);
                            SetText(userlnametxt, Data[1]);
                            SetText(userphonetxt , Data[2]);
                            SetText(userstagecbo, Data[3]);
                            SetText(useremailtxt , Data[4]);
                            SetText(userdescriptiontxt, Data[5]);
                            if (ImageData != null)
                                image.Image = Image.FromStream(new MemoryStream(ImageData));
                            else
                                image.Image = Resources.UnknownCharacter;
                            System.Media.SystemSounds.Asterisk.Play();
                            if (!Configuration.DoorDisabled)
                            new Thread(new ThreadStart(door.Open_The_Door)).Start();       
                            //door.Open_The_Door();

                            ServerUtility.Append_User_Log(
                            Configuration.ClientId,
                            e.Barcode,
                            DateTime.Now.ToString(),
                            "True","Enter");
                            Log("Door Opened,You Are allowed to Enter.", Color.Green);
                        }
                        else if(U_Status== DBUtility.User_Status.User_Valid_Exit)                      
                        {
                            SetText(userfnametxt, Data[0]);
                            SetText(userlnametxt, Data[1]);
                            SetText(userphonetxt , Data[2]);
                            SetText(userstagecbo, Data[3]);
                            SetText(useremailtxt , Data[4]);
                            SetText(userdescriptiontxt, Data[5]);
                            if (ImageData != null)
                                image.Image = Image.FromStream(new MemoryStream(ImageData));
                            else
                                image.Image = Resources.UnknownCharacter;
                            System.Media.SystemSounds.Asterisk.Play();
                            if (!Configuration.DoorDisabled)
                            new Thread(new ThreadStart(door.Open_The_Door)).Start();       
                            //door.Open_The_Door();

                            ServerUtility.Append_User_Log(
                            Configuration.ClientId,
                            e.Barcode,
                            DateTime.Now.ToString(),
                            "True","Exit Door" );
                            Log("Door Opened,You Are allowed to Exit.", Color.Green);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //conected to doors server
                else if(Configuration.StandaloneMode.ToLower()=="off")
                {
                    if (!Block)
                    {     
                   
                        try
                        {
                            /*
                             * Sending Barcode and door number for logging 
                             */
                            if (ClientConnected)
                            {
                                Block = true;
                                lblWait.Visible = true;
                                client.SendMessage("[#<CMD>#][#Barcode#][#]" + e.Barcode + "[#]" + Configuration.ClientName + "[#]" + Configuration.ClientId + "[#]");
                                Log("Sending Barcode [" + e.Barcode + "] to Server...", Color.Blue);
                                ClearForm();
                            }
                            else
                            {
                                Log("Door Now is not Connected to Server.\nYou Have To Log in First.", Color.Red);
                                ClearForm();
                            }                            
                        }
                        catch (SocketException)
                        {
                            Log("Error sending barcode", Color.Red);
                            MessageBox.Show(this, "Error sending barcode [" + inputTextBox.Text + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { Log("Wait Please, Previous Data Is being Received.", Color.Red); }
                }
           
        }

        private void UpDateGUI()
        {
            if (Configuration.StandaloneMode.ToLower() == "on")
            {
                Mode_Status.Text = "Standalone";
                
                LblLastUpdate.Visible = false;
                LBLUpdates.Visible = false;
                toolStripStatusLabel8.Visible = false;
                toolStripStatusLabel6.Visible = false;
                toolStripStatusLabel1.Visible = false;
                toolStripStatus.Visible = false;
                CmdConnect.Visible = false;
                toolStripSeparator1.Visible = false;
                groupBox.Visible = false;
                groupBox3.Size = new Size(778, 435);
                // panel1.Location = new Point(/*this.Width / 2 - BarcodePanel.Width / 2*/25, 219 /* this.Height / 2 - BarcodePanel.Height / 2*/);
            }
            else if (Configuration.SQLConnection == true)
            {
                Mode_Status.Text = "Remote SQLSever ";
                LBLUpdates.Visible = false;
                CmdConnect.Visible = false;
                LblLastUpdate.Visible = false;
                toolStripMenuItem1.Visible = true;
                toolStripStatusLabel8.Visible = false;
                toolStripStatusLabel6.Visible = false;
            }
            else 
            {
                Mode_Status.Text = "Normal";

                LblLastUpdate.Visible = true;
                LBLUpdates.Visible = true;
                toolStripStatusLabel8.Visible = true;
                toolStripStatusLabel6.Visible = true;
                toolStripStatusLabel1.Visible = true;
                toolStripStatus.Visible = true;
                CmdConnect.Visible = true;
                toolStripSeparator1.Visible = true;
                groupBox.Visible = true;
                groupBox3.Size = new Size(275, 469);
            }
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
                if (reader.BaseStream.Length == 0 && First_Time)
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
                Thread.Sleep(1000); //check every 1 second
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
                    File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation h ,,Eagles
                }
                else//directory exist but file no
                    File.Create(Directory.GetCurrentDirectory() + Configuration.TextLogFileName).Close();//<---- Release creation h ,,Eagles                                      

            }

            #endregion
            StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + Configuration.NormalModeStudentsFile, false);
            string IncomingCommand = Encoding.ASCII.GetString(sde.Data).Trim(new char[] { '\0' });
            if (IncomingCommand == "[#<Block_All>#]")
            {
                LBLUpdates.Text = "All Blocked.";
                LBLUpdates.ForeColor = Color.Red;
                LblLastUpdate.Text = DateTime.Now.ToLongTimeString();
                sr.WriteLine("Students are not allowed\nto use this door since\n" + DateTime.Now.ToString());
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
            client.SendMessage("[#<CMD>#][#Authentication#][#]" + Configuration.ClientName + "[#]" + Configuration.ClientPassword + "[#]" + Configuration.ClientId + "[#]");
            Log("Sending username and password to Server...", Color.Blue);
        }

        private void SetGUI(bool p)
        {
            ClientConnected = p;

            if (p)
            {
                if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower() && !Configuration.SQLConnection)
                {
                    if (th != null&&th.ThreadState== System.Threading.ThreadState.Running)
                    {
                        th.Suspend();//stop retry connection
                    }
                }
                toolStripStatus.Text = "Connected";
                toolStripStatus.Image = (Image)SmartDoor.Properties.Resources.smallsuccess;
                CmdConnect.Text = "&Disconnect";
                CmdConnect.Image = ExitMBTN.Image;
                toolStripStatus.ForeColor = Color.Green;

            }
            else
            {
                try
                {
                    if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower() && !Configuration.SQLConnection)
                    {
                        if (th != null)
                        {
                            count = 0;

                            th.Resume();//stop retry connection
                        }
                    }
                }
                catch { }
                CmdConnect.Text = "&Connect to Doors Server";
                toolStripStatus.Text = "Disconnected";
                toolStripStatus.Image = (Image)SmartDoor.Properties.Resources.smallfail;
                CmdConnect.Image = (Image)SmartDoor.Properties.Resources.next;
                toolStripStatus.ForeColor = Color.Red;
            }
        }
        void Client_DataReceived(object Sender, SocketDataEventsArg sde)
        {
           // Log(sde.Data.Length.ToString(), Color.Black);
            
            string IncomingCommand = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });  // An clean string which contain the commands arguments.

         //   Log(IncomingCommand.Length.ToString(), Color.Black);

            /*
             * User Data&,........
             */
            if (IncomingCommand.StartsWith("[#<User_Data>#]"))    // Detect the existance of command on the received data.
            {
                // An command detected, split it to retrive the arguments
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<User_Data>#]").Length).Split(new string[] { "[#]" }, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case ("[#Text_Enter#]"):
                        {
                            //display data from server on door GUI  
                            Display_User_Data(CmdArg);
                            if (!Configuration.DoorDisabled)
                            new Thread(new ThreadStart(door.Open_The_Door)).Start();                           
                            Log("Door Opened,You Are allowed to Enter.", Color.Green);
                            break;
                        }
                        //case ("[#Display_Only#]"):
                        //{
                        //    Display_User_Data(CmdArg);
                        //    Log("Sorry,You Are not allowed to Enter.", Color.Red);
                        //    break;
                        //}
                    case ("[#Text_Exit#]"):
                        {

                            //display data from server on door GUI  
                            Display_User_Data(CmdArg);
                            if (!Configuration.DoorDisabled)
                                new Thread(new ThreadStart(door.Open_The_Door)).Start();
                            Log("Door Opened,You Are allowed to exit.", Color.Green);
                            break;
                        }
                    case ("[#User_Theif#]"):
                        {
                            /*Student Not Activated*/

                            /*     
                             * Warning 
                             */
                            Log("You Are Already inside another Door.", Color.Red);
                            Turn_Warnning(strTheif);
                            break;
                        }
                    case ("[#Student_Not_Allowed_To_Enter_Door#]"):
                        {
                            /*Student Not Allowed*/

                            /*  
                             * Warning , . . .
                             */
                            Log("Sorrry you are not allowed to enter this.", Color.Red);
                            
                            Turn_Warnning(strNotAllowed);
                            break;
                        }
                    case ("[#Student_Does_Not_Exist#]"):
                        {
                            Block = false;
                            lblWait.Visible = false;
                            Turn_Warnning(strNoAccount); 
                            Log("Sorry, There is no account for you\nYou have to call your System Adminstrator.", Color.Brown);
                            break;
                        }
                    default:
                        Log(Encoding.ASCII.GetString(sde.Data), Color.Aqua);
                        break;
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
                            Log("Login Failed, invalid Username Or Password.", Color.Red);
                            if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower() && !Configuration.SQLConnection)
                            {
                                try
                                {
                                    if (th != null)
                                    {
                                        th.Abort();//stop retry connection
                                    }
                                }
                                catch { }
                            }
                            break;
                        }
                    case ("[#Login_Successful#]"):
                        {
                            /*here we can connect Updates Client*/
                            UpdatesClient.Connect(Configuration.ServerIP, Configuration.UpdatesPort);
                            /*/*//*/*//*/*//*/*//*/*//*/*//*/*//*/*//*/*//*/*//*/*//*/*///*/
                            FileInfo fi = new FileInfo(Directory.GetCurrentDirectory() + Configuration.TextLogFileName);
                            if (fi.Length != 0)
                            {
                                LogClient.Connect(Configuration.ServerIP, 7000);                              
                               
                            }
                            else
                            {
                                Log("No Logs To be Sent.", Color.Blue);
                            }
                            //set GUI to Connected state
                            SetGUI(true);
                            Configuration.StandaloneMode = "off";
                            UpDateGUI();                          
                            ConnectionDisplayLog = true;
                            Log("Login Succeeded.", Color.Green);
                            if (th != null && th.ThreadState == System.Threading.ThreadState.Running) th.Suspend();
                            break;
                        }
                    case ("[#Not_Connected_To_DB#]"):
                        {
                            Log("\nLogin failed...\nServer now is not Connected to Database,Try to Login later.", Color.Red);
                            break;
                        }
                    case ("[#Server_Busy#]"):
                        {
                            Block = false;
                            lblWait.Visible = false;
                            Log(" Server is busy ,Try to after few seconds.", Color.Red);
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

                            Thread.Sleep(100);
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
                    case ("[#Restart#]"):
                        {
                            Restarting = true;
                            Close();
                            break;
                        }                 

                    case ("[#Open#]"):
                        {
                            if (!Configuration.DoorDisabled)
                            new Thread(new ThreadStart(door.Open_The_Door)).Start();
                            //door.Open_The_Door();
                            Log("Door Opened,You Are Welcome.", Color.Green);
                            break;
                        }
                }
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
                    lock (this)
                    {                       
                        ImageUpdator.Image = ClientPacket.ClientImage;
                        Thread.Sleep(100);
                        Block = false;
                        lblWait.Visible = false;
                    }
                    ClientPacket.Truncate();                
                    Log("User Data retrieved Successfully.", Color.Green);
                }
                else
                {
                    ClientPacket.WriteData(sde.Data, false);
                }

            }
            System.Threading.Thread.Sleep(0);   //Without that line you will got just rabish, as the processor will execute it very fastly and collect garbish data from stream, so we must delay the execution.            
        }

       
        
        FilePacket ClientPacket = new FilePacket();
        bool Synchronous = true;
        SmartDoor.Client_Monitoring SynchClient;
        private void startMonitorClient()
        {
            if (!Synchronous)
            {
                MClient = new Client();
                MClient.DataReceived += new Client.SocketDataArg(M_DataReceived);
                MClient.ErrorCatched += new Client.SocketErrorArg(M_ErrorCatched);
                MClient.Connected += new Client.SocketStatusArg(M_Connected);
                MClient.Disconnected += new Client.SocketDisconnectArg(M_Disconnected);
                MClient.Connect(Configuration.ServerIP, 6000);
            }
            else
            {
                SynchClient = new Client_Monitoring(this);
                SynchClient.Start();
            }

        }
        
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
                            ImageQuality = int.Parse(CmdArg[2]);
                            Log("Quality=" + ImageQuality, Color.Green);
                         
                            MClient.SendMessage(DesktopImage.GetDesktopImage(ImageQuality))/*imageData*/;

                            break;
                        }
                    case ("[#EndOfReceive#]"):
                        {                            
                            ReadyToSend();
                            break;
                        }
                    case ("[#StopMonitor#]"):
                        {                

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

                            xPos = int.Parse(CmdArg[3]); yPos = int.Parse(CmdArg[5]);
                            SetCursorPos(xPos, yPos);

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
                                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, xPos, yPos, 0, 0);
                                    break;
                                case ("[#MouseDown#]"):
                                    Log("M Down Event", Color.Red);
                                    if (MouseBtn == MouseButtons.Left)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Right)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                    break;
                                case ("[#MouseUp#]"):
                                    Log("M Up Event", Color.Red);
                                    if (MouseBtn == MouseButtons.Left)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Right)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                    break;
                                case ("[#MouseClick#]"):
                                    if (MouseBtn == MouseButtons.Left)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                    }
                                    else if (MouseBtn == MouseButtons.Right)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                    }
                                    else if (MouseBtn == MouseButtons.Middle)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                    }
                                    break;
                                case ("[#MouseDoubleClick#]"):
                                    //mouse_event(MOUSEEVENTF_MOVE, xPos, yPos, 0, 0);
                                    break;
                            }

                            break;
                        }


                }
                System.Threading.Thread.Sleep(0);   //Without that line you will got just rabish, as the processor will execute it very fastly and collect garbish data from stream, so we must delay the execution.            
            }
        }
        
        #region General Declarations
        int xPos, yPos;
        MouseButtons MouseBtn;

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
            Log("Frame Size= " + (imageDataLength / 1024).ToString() + " KBytes.", Color.Gold);
            if (imageDataLength != 0)
                MClient.SendMessage("[#<CMD>#][#ReadyToSend#][#]" + Convert.ToString(imageDataLength - 9) + "[#]");
            imageDataLength = 0;
        }

        void M_Connected(object Sender, EventArgs ea)
        {
            MClient.SendMessage("[#<CMD>#][#Information#][#]" + Screen.PrimaryScreen.Bounds.Width.ToString() + "[#]" + Screen.PrimaryScreen.Bounds.Height.ToString()+"[#]");
          
        }
        void M_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            Log("Server Monitoring Disconnect Event...", Color.Gold);
          
        }

        void M_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            Log("Monitoring Error: " + see.Message, Color.Gold);
        }

     
        public void Turn_Warnning(object msg)
        {
            Block = true;
            lblWait.Visible = false;
            Warnning_Form = new ChatClient.Forms.AuthorizationFrm((string)msg);
            Warnning_Form.Times = 2;/*beep twice only do not make bollika*/
            Warnning_Form.ShowDialog(this);
            Block = false;
        }

        private void Display_User_Data(string[] CmdArg)
        {
            /*‘€«·Â ‰««««««««««««««««««««««««««««««««—*/
            //to a void so called "cross-thread" Exception
            SetText(userfnametxt, CmdArg[1]);
            SetText(userlnametxt, CmdArg[2]);
            SetText(userphonetxt, CmdArg[3]);
            SetText(userstagecbo, CmdArg[4]);
            SetText(useremailtxt, CmdArg[5]);
            SetText(userdescriptiontxt, CmdArg[6]);
            if (CmdArg[7] == "[#NoImage#]")
            {
                image.Image = Resources.UnknownCharacter;
                Block = false;
                lblWait.Visible = false;
            }
            System.Media.SystemSounds.Asterisk.Play();

            
        }

        private void Append_Log_In_File(string barcode, string Allowed)
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
                FileInfo fi = new FileInfo(Directory.GetCurrentDirectory() + Configuration.TextLogFileName);
                if (fi.Length >= 1000)
                    return;
                StreamWriter Log_Writer = new StreamWriter(new FileStream(Directory.GetCurrentDirectory() + Configuration.TextLogFileName,FileMode.Append,FileAccess.Write));

                Log_Writer.WriteLine(Configuration.ClientId + "&" + barcode + "&" + DateTime.Now.ToString() + "&" + Allowed);

                Log_Writer.Close();

            }
        }
        void Client_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            SetGUI(false);            
            Log("Client Socket Had been Disconnected.", Color.Red);
            try { if (th != null) { th.Resume(); count = 0; } }
            catch { }            
        }

        void Client_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            
            if (ConnectionDisplayLog)
            {
                if (see.ErrorCode == 10061)
                    Log("Doors Server Unreachble.", Color.Red);
                else if (see.ErrorCode == 0)
                    return;
                else
                    Log("[Error Catched]:\n" + see.ErrorCode+ " " + see.Message, Color.Red);
            }
        }
        #endregion

        public void Log(string p, Color col)
        {

            try
            {
                displayREdit.AppendText(p + "\n");
                displayREdit.Select(displayREdit.Text.Length - 1 - p.Length, p.Length);
                displayREdit.SelectionColor = col;              
            }
            catch { }

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


        private void StartStop()
        {
            switch (CmdConnect.Text)
            {
                case ("&Connect to Doors Server"):
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
                {
                    //this line to enable client to send his name to server before close
                    client.Disconnect();
                    LogClient.Disconnect();
                   
                }
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
        public static void Paint_Gradiant(PaintEventArgs e, Form mForm)
        {/*
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
            */
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
            Paint_Gradiant(e, this);
        }
      
        private void ConfigureBTN_Click(object sender, EventArgs e)
        {
            LoginToConfiguration cl = new LoginToConfiguration();
            if (cl.ShowDialogModel() == true)
            {
                new Door_Config(Configuration.ClientName, door, cl.Password).ShowDialog(this);
            }  
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
            saveFileDialog.FileName = "ServerLog_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".rtf";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (displayREdit.Text.Length != 0)
                    displayREdit.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Clear_Action_Click(object sender, EventArgs e)
        {
            LogTXT.Text = "";
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
                sd = new SlideDialog(this, (float)0.1, client, null, HandelTXT);
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
            System.Type supaType = skinEngine1.GetType();
            supaType.GetProperty("SerialNumber").GetSetMethod(true).Invoke(skinEngine1, new object[] { "isBx30VBCC0GTnJuOKmQ0jK7I8NqeyOjDigXGIG5v1dN7aw4qc3Ogw==" });

            if(!Configuration.DoorDisabled)
            lblStatus.Text = porting.Inp(Configuration.LptPortAddressBase+1).ToString();
            //this.Text +="   "+ door.doorStatus;
            th = new Thread(new ThreadStart(AutoConnect));
            if (Configuration.AutoConnect && Configuration.StandaloneMode.ToLower() == "oFF".ToLower() && !Configuration.SQLConnection)
            {
                th.Start();
            }
            //else { /*th.Start(); th.Suspend();*/ }
        }
        bool Ping(string IP)
        {
            string ServerIP = IP;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ServerIP, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool StandAloneStatus = false;
        bool ConnectionDisplayLog = true;
        int count = 0;
        private void AutoConnect()
        {
            while (true)
            {
              
                
                if (ClientConnected) { th.Suspend(); }
                
                if (ConnectionDisplayLog)
                    Log("Attempt connection...", Color.Blue);

                if (Ping(Configuration.ServerIP))
                {
                    try
                    {
                        StartStop();
                        StandAloneStatus = false;
                    }
                    catch { }
                    if(!ClientConnected)
                    {
                        if (Configuration.StandaloneMode.ToLower() != "on")
                        {
                            if (count == int.Parse(Configuration.AttemptsCount))
                            {
                                Configuration.StandaloneMode = "on";
                                ClearForm();
                                displayREdit.Clear();
                                Log("Turnning to Standalone Mode...", Color.Blue);
                                TurnToStandalone();

                                /*i used this var so that we can perform silent attempts to doors server*/
                                ConnectionDisplayLog = false;
                                count = 0;
                                StandAloneStatus = true;
                            }
                            else
                            {
                                ++count;
                            }
                        }
                    }
                }

                else
                {
                    if (!StandAloneStatus)
                    {
                        Configuration.StandaloneMode = "on";
                        ClearForm();
                        displayREdit.Clear();
                        Log("Turnning to Standalone Mode...", Color.Blue);
                        TurnToStandalone();

                        /*i used this var so that we can perform silent attempts to doors server*/
                        ConnectionDisplayLog = false;
                        StandAloneStatus = true;
                    }
                    //th.Suspend();
                }

                Thread.Sleep(int.Parse(Configuration.TimeOut));
            }
        }
       
        private void TurnToStandalone()
        {          
           
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
                Log("Turnning to Completed.", Color.Green);
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
                    //toolStripMenuItem1.Image = ExitMBTN.Image;
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

        private void LblUB_Click(object sender, EventArgs e)
        {
            Block = false;
        }              

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!Block)
                    {                        
                        try
                        {
                            /*
                             * Sending Barcode and door number for logging 
                             */
                            if (ClientConnected)
                            {
                                Block = true;

                                lblWait.Visible = true;
                                client.SendMessage("[#<CMD>#][#Barcode#][#]1620040006009[#]" + Configuration.ClientName + "[#]" + Configuration.ClientId + "[#]");
                                Log("Sending Barcode [1] to Server...", Color.Blue);
                                ClearForm();
                            }
                            else
                            {
                                Log("Door Now is not Connected to Server.\nYou Have To Log in First.", Color.Red);
                                ClearForm();
                            }
                            //inputTextBox.Clear();
                        }
                        catch (SocketException)
                        {
                            Log("Error sending barcode", Color.Red);
                            MessageBox.Show(this, "Error sending barcode [" + inputTextBox.Text + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { Log("Wait Please While Old Data Is being Received.", Color.Red); }
                }

        private void label10_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }
        int IStyle = 1;
        private void changeStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.ApplyAdditionalBuiltInSkins(IStyle++ % 12);
        }

        private void aboutSmartDoorProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void helpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("SmartDoor.chm");
        }

      
    }
}


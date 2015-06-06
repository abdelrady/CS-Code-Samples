using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Server.Properties;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace Server
{
    public partial class Server : Form
    {
        #region "Attributes"
        private int hHwnd;
        private AudioSender[] audioSender = new AudioSender[MAXCLIENTS];     
        private enum Mood {FullMode , BackGroundMode};
        private System.Media.SoundPlayer Ssound ;
        private const int MAXCLIENTS  = 30;   //max number fo concurrent clients 
        private Socket MainConnection;     
        private int portNum , mainPort;
        private NetworkStream MainsocketStream;
        private BinaryWriter MainWriter;
        private BinaryReader reader;
        private IPAddress local;
        private int ClientIndex = -1 , Rcvport=8000,SendPort=9000;  
        private TcpListener mainlistener;
        private TcpListener[] subConnections = new TcpListener[MAXCLIENTS];
        private Socket[] SubSocets = new Socket[MAXCLIENTS];
        private NetworkStream[] substreams = new NetworkStream[MAXCLIENTS];
        private BinaryWriter[] SubWriter = new BinaryWriter[MAXCLIENTS];
        private BinaryReader[] readers = new BinaryReader[MAXCLIENTS];
        private bool[] Online = new bool[MAXCLIENTS];//stores the indices of the online Clients   
        private bool[] AchatAudioStartedBefore = new bool[MAXCLIENTS];
        private bool Running = false;
        private bool[] initiated = new bool[MAXCLIENTS]; 
        private string nickName = "", Client_Nickname = "", toClient, IP = "", message;
        private string[] ClientIPAddr = new string[MAXCLIENTS];//Clients ip's
        private bool[] started = new bool[MAXCLIENTS];
        private Thread MainThread;
        private DateTime LastNudge;
        private AudioReceiver audioReceiver;
        private VideoSender[] VideoSenders = new VideoSender[30];       
        private int videoSentchatPort = 6000;
        private int videorcvChatPort = 7000;
        private const short WM_CAP = 1024;
        private const int WM_CAP_DRIVER_CONNECT = WM_CAP + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_CAP + 11;
       
        private const int WM_CAP_SET_PREVIEW = WM_CAP + 50;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP + 52;
        private const int WM_CAP_SET_SCALE = WM_CAP + 53;
        private const int WS_CHILD = 1073741824;
        private const int WS_VISIBLE = 268435456;
        private const short SWP_NOMOVE = 2;
        private const short SWP_NOSIZE = 1;
        private const short SWP_NOZORDER = 4;
        private const short HWND_BOTTOM = 1;
        private int iDevice = 0;
        
        private string iptostartVChat;
        [DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] 
			object lParam);
        [DllImport("user32", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32")]
        static extern bool DestroyWindow(int hndw);
        [DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);
        [DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);
        #endregion

        public Server()
        {
            InitializeComponent();
            //
            //Initialize "Online" Default is Online
            //
            for (int C = 0; C < MAXCLIENTS; C++)
            {
                AchatAudioStartedBefore[C] = false;
                Online[C] = true;
                initiated[C] = false;
                started[C] = false;
            }
          
            //
            //Sound player
            //
            Ssound = new System.Media.SoundPlayer();
        }

        private void PlaySoundLogIn()
        {
            lock (this)
            {
                byte[] buffer = new byte[Resources.NEWEMAIL.Length];
                Resources.NEWEMAIL.Read(buffer, 0, (int)Resources.NEWEMAIL.Length);
                System.IO.MemoryStream memStr = new MemoryStream(buffer);
                Ssound.Stream = memStr;
                Ssound.Play();
            }
        }

        private void PlaySoundLogOut()
        {
            lock (this)
            {
                byte[] buffer = new byte[Resources.Windows_XP_Information_Bar.Length];
                Resources.Windows_XP_Information_Bar.Read(buffer, 0, (int)Resources.Windows_XP_Information_Bar.Length);
                System.IO.MemoryStream memStr = new MemoryStream(buffer);
                Ssound.Stream = memStr;
                Ssound.Play();
            }
        }    

        private void WorkBTN_Click(object sender, EventArgs e)
        {
            //
            //GUI
            //
            label4.Visible = false;
             device_number_textBox.Visible = false;
            WorkBTN.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            IpTXT.Visible = false;
            PortTXT.Visible = false;
            ClientsTXT.Visible = false;
            this.Size = new System.Drawing.Size(370, 450);
            Running = true;//server Running
            menuItem3.Enabled = true; //stop/resume menue item
            workInBackgroundToolStripMenuItem.Enabled = true;
            this.AcceptButton = SendBTN;
            ClientsTXT.Enabled = false; 
            notifyIcon1.Icon = Resources.display;
            notifyIcon1.Text = "Server connected.";
            WorkBTN.Enabled = false;          
            IpTXT.Enabled = false;
            PortTXT.Enabled = false;
            statusLBL.Text = "Waiting for Clients...";    
            listenToClientsToolStripMenuItem.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;

            //
            //Ip parsing "remove spaces"
            //
            IP = ParseIP(IpTXT.Text);     
  
            //
            // clients incremental port
            //
            portNum = int.Parse(PortTXT.Text);
            
            //
            //assign main listen port
            //
            mainPort = portNum; 
            
            //
            //run main thread
            //
            MainThread = new Thread(new ThreadStart(WaitMainConnection));
            MainThread.Start();
        }

        private string ParseIP(string retIP)
        {
            for (int i = 0; i < retIP.Length; i++)
                if ((retIP.ToCharArray())[i] == ' ')
                {
                    retIP = retIP.Remove(i, 1);
                }
            return retIP;
        }

        private void WaitMainConnection()
        {
            local = IPAddress.Parse(IP);
            mainlistener = new TcpListener(local, mainPort);
            mainlistener.Start();
            while (true)
            {               
                try
                {
                    MainConnection = mainlistener.AcceptSocket();
                    MainsocketStream = new NetworkStream(MainConnection);
                    MainWriter = new BinaryWriter(MainsocketStream);
                    reader = new BinaryReader(MainsocketStream);

                    //
                    //Client Logged on then increment
                    //
                    ++portNum;
                    ++ClientIndex;

                    //
                    //some code to handel if client# is not exceed "MAXCLIENTS" here check "ClientIndex"
                    //
                    
                    //
                    //send port to client to connect using it
                    //
                    MainWriter.Write(portNum);                     
                    
                    //
                    //GUI
                    //
                    sentTXT.Enabled = true;
                    ToallCHK.Enabled = true;

                    //
                    //Play "Trim"
                    //
                    new Thread(new ThreadStart(PlaySoundLogIn)).Start();

                    //
                    //Process subconnection and continue work
                    //
                    new Thread(new ThreadStart(ProcessSubConnection)).Start();
                }
                catch (Exception error) { MessageBox.Show(error.ToString() + "\nServer will disconnect. ", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
            }
            MainWriter.Close();
            reader.Close();
            MainsocketStream.Close();
            MainConnection.Close();
        }

        public void ProcessSubConnection()
        {
            try
            {
                subConnections[ClientIndex] = new TcpListener(local, portNum);
                subConnections[ClientIndex].Start();
                SubSocets[ClientIndex] = subConnections[ClientIndex].AcceptSocket();
                GetStreamsFromClient(ClientIndex);                
            }
            catch (SocketException error)
            {
                MessageBox.Show(error.ToString(), "server:SocketException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetStreamsFromClient(int Index)
        {
            //
            //Adjust Streams
            //
            substreams[Index] = new NetworkStream(SubSocets[Index]);
            SubWriter[Index] = new BinaryWriter(substreams[Index]);
            readers[Index] = new BinaryReader(substreams[Index]);

            //
            //read Client IP &parse it
            //           
            string intermediateVariable = readers[Index].ReadString();//read IP
            ClientIPAddr[ClientIndex] = intermediateVariable.Substring(0, intermediateVariable.Length - 5);
         
            //
            //reading nick name
            //
            nickName = readers[Index].ReadString();

            //
            //Process NickName Duplication         
            //
            //if(ProcessNickNameDuplication(Index)==true)
            //{
            //   statusLBL.Text = "Connection refused.";

             /*  SubWriter[Index].Close();
               readers[Index].Close();
               SubSocets[Index].Close();
               SubSocets[Index].Close();*/
            
            //}
            //
            //
            //send list of clients to the signed client that is known from his "Index"
            //
            SendListOfClientsToTheNewClient(Index);

            //
            //adding him to list
            //
            AddClientToViewAndAdjustStatus(Index);   

            //
            //send the new client to all but the new 
            //
            SendClientToAll(nickName);            

            //
            //processing 
            //         
            do
            {
                try
                {
                    Client_Nickname = readers[Index].ReadString();//first of any message client name is wrote at client Side and readed
                    toClient = readers[Index].ReadString();//to home to be sent by client                   
                    message = readers[Index].ReadString();

                    //
                    //ensure that it is not a file "Special Message"
                    //

                    //
                    //Client wants to initiate An Audio conversation
                    //
                    //file
                    //file
                    if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->ClientSendsAfile()")
                    {
                        Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + Client_Nickname + " sends a File to " + toClient + " ..." + Environment.NewLine);
                        //new th mmmmm
                        statusLBL.Text = "Receiving file ....";

                        if (toClient == "Server")
                        {
                            NetUtility.FileAttacher RecObj = new NetUtility.FileAttacher();
                            RecObj.IP = ClientIPAddr[Index];
                            new Thread(new ThreadStart(RecObj.RecieveFile)).Start();

                        }
                        else
                        {
                            //
                            //file is sent to client no server
                            //
                            NetUtility.FileAttacher Rec_Send_Obj = new NetUtility.FileAttacher();
                            Rec_Send_Obj.Parent = this;
                            Rec_Send_Obj.IP = ClientIPAddr[Index];
                            //
                            //Download it in localhost
                            //
                            new Thread(new ThreadStart(Rec_Send_Obj.RecieveFile)).Start();

                            //get Client To send file to
                            for (int i = 0; i < ClientVEW.Items.Count; i++)
                            {
                                if (ClientVEW.Items[i].Text == toClient)
                                {
                                    SubWriter[i].Write(Client_Nickname);//sender
                                    //special mesage
                                    SubWriter[i].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->ClientSendsAfile()");
                                    new Thread(new ThreadStart(Rec_Send_Obj.SendFile)).Start();
                                    break;//stop search
                                }
                            }
                        }
                    }
                    //
                    //nudge
                    //
                    else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()")
                    {
                        Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + Client_Nickname + " sends a Nudge to " + toClient + " ..." + Environment.NewLine);
                        for (int i = 0; i < ClientVEW.Items.Count; i++)
                        {
                            if (ClientVEW.Items[i].Text == toClient && Online[i])
                            {
                                SubWriter[i].Write(Client_Nickname);//sender
                                //special mesage
                                SubWriter[i].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()");
                                break;//stop search
                            }
                        }
                    }
                    else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->AudioChatting()")
                    {
                        ++Rcvport;
                        Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + Client_Nickname + " initiates Audio Chat With Server ..." + Environment.NewLine);

                        SubWriter[Index].Write("ServerAcceptAudio");//write sender
                        SubWriter[Index].Write(Rcvport.ToString());//send him the port to send on                     
                        
                       
                    }
                    else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartAudioChatting()")
                    {


                        audioReceiver = new AudioReceiver(ClientIPAddr[Index], Rcvport);
                        audioReceiver.StartReceiveAudio();
                    }                    
                    //text
                    else
                    {
                        Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + Client_Nickname + " sayes : " + Environment.NewLine + message + Environment.NewLine);
                        if (toClient != "Server")//message is not to server only but to other Clints
                            //send list of online clients 
                            SendMessageToClient();
                    }
                }
                catch
                {
                    //
                    //make him offline   
                    //
                    ClientVEW.Items[Index].ImageIndex = 2;
                    ClientVEW.Items[Index].ForeColor = System.Drawing.Color.Brown;
                    Online[Index] = false;

                    //
                    //Adjust GUI
                    //
                    Log.AppendText(Environment.NewLine + ClientVEW.Items[Index].Text + " Signed out ... " + Environment.NewLine);
                    statusLBL.Text = ClientVEW.Items[Index].Text + " signed out...";
                    //
                    //Send notify to clients that this client has signed out 
                    //
                    /**/SendNotify(ClientVEW.Items[Index].Text,Index);

                    if (getOnlineCount() == 0)
                    {
                        sentTXT.Enabled = false;
                        SendBTN.Enabled = false;
                        ToallCHK.Enabled = false;
                    }
                    
                    
                    //
                    //Play "Trot"
                    //
                    new Thread(new ThreadStart(PlaySoundLogOut)).Start(); 
            
                    //
                    //stop dealing with this client
                    //
                    break;
                }
            } while (true);         
            SubWriter[Index].Close();
            readers[Index].Close();
            SubSocets[Index].Close();
            SubSocets[Index].Close();
        }
       private delegate bool ProcessNickNameDuplicationDelegate(int Index );
        private bool ProcessNickNameDuplication(int Index)
        {
            if (ClientVEW.InvokeRequired) 
            {
                Invoke(new ProcessNickNameDuplicationDelegate(ProcessNickNameDuplication), new object[] { Index });
            }
            else
            {
                for (int i = 0; i < ClientVEW.Items.Count; i++)
                    if (ClientVEW.Items[i].Text == nickName)
                    {
                        SubWriter[Index].Write("ConnectionRefused");                      
                        --ClientIndex;
                        --portNum;
                        return true;//dup

                    }
                SubWriter[Index].Write("Good");                    
            }
            return false;//no dup
        }

        private void SendMessageToClient()
        {
            for (int i = 0; i < ClientVEW.Items.Count; i++)
            {
                if (ClientVEW.Items[i].Text == toClient)
                {
                    SubWriter[i].Write(Client_Nickname);
                    SubWriter[i].Write(message);
                    break;//stop search
                }
                
            }
        }

        private void SendNotify(string theSignedOutClient, int Index)
        {
            if (getOnlineCount() == 0) return; //avoid dendng to null obj's
            for (int clnt = 0; clnt < ClientVEW.Items.Count/*ßáåã ÇáãÑå Ïì */; clnt++)
            {
                if (Online[clnt])//if he is online send the Notify that one signed out
                {
                    if (clnt != Index)//don't send to him                 
                    {
                        try
                        {
                            SubWriter[clnt].Write("SignOut");
                            SubWriter[clnt].Write(theSignedOutClient);
                        }
                        catch { }
                    }
                }
            }  
        }

        private void SendClientToAll(string theNew)
        {
            for (int clnt = 0; clnt <ClientVEW.Items.Count-1/*ãÇÚÏÇ Ïå*/; clnt++)
            {
               if (Online[clnt])//if he is online send the message
                {                  
                    SubWriter[clnt].Write("NewUSer");
                    SubWriter[clnt].Write(theNew);
                }
            }             
        }

        private int getOnlineCount()
        {
            int count = 0;
            for (int i = 0; i < ClientIndex; i++)           
                if (Online[i]) 
                    ++count;
            return count;
            
        }

        private void AddClientToViewAndAdjustStatus(int Index)
        {
            ListViewItem item = new System.Windows.Forms.ListViewItem(new string[] { nickName, DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), ClientIPAddr[Index] }, 3);
            ClientVEW.Items.AddRange(new ListViewItem[] { item });
            Log.AppendText(Environment.NewLine + nickName + " Signed in ... " + Environment.NewLine);
            statusLBL.Text = nickName + " signed in...";         
        }

        private void SendListOfClientsToTheNewClient(int Index)
        {
            string clientsBuffer = "";
            for (int count = 0; count < ClientVEW.Items.Count; count++)
            {
                if (Online[count])
                    clientsBuffer += ClientVEW.Items[count].Text + "\n";
            }
            SubWriter[Index].Write(clientsBuffer);//send it
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { for (int i = 0;i<30 ;i++ ) if(initiated[i])audioSender[i].Dispose(); }
            catch { };
            notifyIcon1.Icon = null;
            GC.Collect();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Server sayes : " +Environment.NewLine+ sentTXT.Text + Environment.NewLine);
            new Thread(new ThreadStart(SendStreamsToClient)).Start();
            sentTXT.Focus();
        }

        private void SendStreamsToClient()
        {
            //
            //if no broadcast or selection
            //
            if (ClientVEW.SelectedIndices.Count == 0 && ToallCHK.Checked == false)
            {
                MessageBox.Show(this, "You must select client. ", "Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            //
            //send to ...
            //
            try
            {
                //
                //All
                //
                if (ToallCHK.Checked == false)
                {
                    for (int clnt = 0; clnt < ClientVEW.SelectedIndices.Count; clnt++)
                    {
                        if (Online[ClientVEW.SelectedIndices[clnt]])//if he is online send the message
                        {
                            SubWriter[ClientVEW.SelectedIndices[clnt]].Write("Server");
                            SubWriter[ClientVEW.SelectedIndices[clnt]].Write(sentTXT.Text);
                            
                        }
                    }                
                }
                //
                //or only online selected
                //
                else
                {
                    for (int clnt = 0; clnt < ClientVEW.Items.Count; clnt++)
                    {
                        if (Online[clnt])//if he is online send the message
                        {
                            SubWriter[clnt].Write("Server");//write sender
                            SubWriter[clnt].Write(sentTXT.Text);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error sending text.\n"+exp.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(System.Environment.ExitCode);
            }
            sentTXT.Clear();
            sentTXT.Focus();
        }

        private void listenToClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            WorkBTN.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void workInBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMood(Mood.BackGroundMode);
            notifyIcon1.Text = "Server Working in Background.";
        } 

        private void fullServerMoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMood(Mood.FullMode);
            notifyIcon1.Text = "Server Connected.";
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetMood(Mood.FullMode);        
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                WorkBTN.PerformClick();
                SetMood(Mood.BackGroundMode);
                Running = true;
            }
            else SetMood(Mood.BackGroundMode);
             
        } 
        private void SetMood(Mood mood)
        {
            bool p = false;
            if (mood == Mood.BackGroundMode)
                p = false;
            else if (mood == Mood.FullMode)
                p = true;

            this.Visible = p;
            this.ShowInTaskbar = p;
            toolStripMenuItem2.Enabled = p;
            fullServerMoodToolStripMenuItem.Enabled = !p;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void sentTXT_TextChanged(object sender, EventArgs e)
        {
            if(sentTXT.Text.Length!=0)
                SendBTN.Enabled = true;
            else
                SendBTN.Enabled = false;
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            new Students__House_Control.About().ShowDialog(this);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(ProcessStopResume)).Start();
        }

        private void ProcessStopResume()
        {
            if (menuItem3.Text == "Stop ...")
            {
              
                MainThread.Suspend();
                menuItem3.Text = "Resume ...";
                Running = true;
                notifyIcon1.Text = "Server Stopped";
                notifyIcon1.Icon = Resources.display_off;
            }
            else if (menuItem3.Text == "Resume ...")
            {              
                MainThread.Resume();
                menuItem3.Text = "Stop ...";
                Running = false;
                notifyIcon1.Text = "Server Working in Background";
                notifyIcon1.Icon = Resources.display;
            }
        }

        private void contextMenu2_Popup(object sender, EventArgs e)
        {
            if (ClientVEW.SelectedIndices.Count == 0 || !Online[ClientVEW.SelectedIndices[0]])//ÇáÍÑÝäå
            {
                contextMenu2.MenuItems[0].Visible = false;
                contextMenu2.MenuItems[1].Visible = false;
                contextMenu2.MenuItems[2].Visible = false;
                contextMenu2.MenuItems[3].Visible = false;
            }
            else
            {

                contextMenu2.MenuItems[0].Visible = true;
                contextMenu2.MenuItems[1].Visible = true;
                contextMenu2.MenuItems[2].Visible = true;
                contextMenu2.MenuItems[3].Visible = true;
                if (ClientVEW.Items[ClientVEW.SelectedIndices[0]].ImageIndex == 4)
                    contextMenu2.MenuItems[3].Text = "Stop Audio Exchange";
                else contextMenu2.MenuItems[3].Text = "Start Audio Exchange";

                try
                {
                    if (VideoSenders[ClientVEW.SelectedIndices[0]].StoppedOfSending == true)
                        menuItem12.Text = "Start Video Exchange";
                    else
                        menuItem12.Text = "Stop Video Exchange";
                }
                catch { menuItem12.Text = "Start Video Exchange"; }
              
            }
        }
        private void menuItem9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientVEW.SelectedIndices.Count; i++)
            {
                if (Online[i])//Dismiss bl jomla means dismiss group
                {
                    Log.AppendText(Environment.NewLine + ClientVEW.Items[i].Text + " had dismissed ... " + Environment.NewLine);
                    SubWriter[ClientVEW.SelectedIndices[i]].Write("GoToHill");
                    SubWriter[ClientVEW.SelectedIndices[i]].Write("AnyTextGoesHere");
                }                               
            }                
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {

            if (LastNudge.AddSeconds(3) <= DateTime.Now)
            {
                try
                {
                    for (int i = 0; i < ClientVEW.Items.Count; i++)
                    {
                        if (Online[i])
                        {
                            Log.AppendText(Environment.NewLine + "You have just send Nudge to  " + ClientVEW.Items[i].Text + "." + Environment.NewLine);
                            SubWriter[ClientVEW.SelectedIndices[i]].Write("Server");//sender                   
                            SubWriter[ClientVEW.SelectedIndices[i]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()"); //special mesage
                        }
                    }
                }
                catch { }
                LastNudge = DateTime.Now;
            }
            else 
            { 
                Log.AppendText(Environment.NewLine + "You can't send Nudge." + Environment.NewLine);
                statusLBL.Text = "You can't send Nudge.";
            }

            
        }

        private void Server_Load(object sender, EventArgs e)
        {

            IPHostEntry hoste = new IPHostEntry();

            IpTXT.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            this.Text = "ChatMaster Server- User ' " + Environment.UserName+" '" ;
            LastNudge = DateTime.Now;
        }

        private void ClientVEW_DoubleClick(object sender, EventArgs e)
        {
            if (LastNudge.AddSeconds(3) <= DateTime.Now)
            {
                if (Online[ClientVEW.SelectedIndices[0]])
                {
                    Log.AppendText(Environment.NewLine + "You have just send Nudge to  " + ClientVEW.Items[ClientVEW.SelectedIndices[0]].Text + "." + Environment.NewLine);
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("Server");//sender                   
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()"); //special mesage
                    LastNudge = DateTime.Now;
                }               
            }
            else 
            {
                Log.AppendText(Environment.NewLine + "You can't send Nudge." + Environment.NewLine);
                statusLBL.Text = "You can't send Nudge.";
            }
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientVEW.SelectedIndices.Count;i++ )
                if (menuItem13.Text == "Start Audio Exchange")
                {
                    if (Online[ClientVEW.SelectedIndices[i]])
                    {
                        menuItem13.Text = "Stop Audio Exchange";
                        ClientVEW.Items[ClientVEW.SelectedIndices[i]].ImageIndex = 4;
                        if (!initiated[ClientVEW.SelectedIndices[i]])
                        {

                            Log.AppendText(Environment.NewLine + "starting audio chat with  " + ClientVEW.Items[ClientVEW.SelectedIndices[i]].Text + "." + Environment.NewLine);
                            SubWriter[ClientVEW.SelectedIndices[i]].Write("Server");//sender                   
                            SubWriter[ClientVEW.SelectedIndices[i]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->audioChating()"); //special mesage
                            SubWriter[ClientVEW.SelectedIndices[i]].Write(Rcvport.ToString() + SendPort.ToString());//send ports
                            audioSender[ClientVEW.SelectedIndices[i]] = new AudioSender(ClientVEW.Items[ClientVEW.SelectedIndices[i]].SubItems[2].Text, SendPort);
                            audioSender[ClientVEW.SelectedIndices[i]].StartSendAudio();
                            initiated[ClientVEW.SelectedIndices[i]] = true;
                            ++SendPort;
                        }
                        else
                        {
                            audioSender[ClientVEW.SelectedIndices[i]].ResumeAudioChat();
                        }
                    }
                }
                else
                {
                    ClientVEW.Items[ClientVEW.SelectedIndices[i]].ImageIndex = 3;
                    menuItem13.Text = "Start Audio Exchange";
                    audioSender[ClientVEW.SelectedIndices[i]].StopAudioChat();
                    SubWriter[ClientVEW.SelectedIndices[i]].Write("Server");//sender                   
                    SubWriter[ClientVEW.SelectedIndices[i]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StopaudioChating()"); //special mesage                
                }
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            if (menuItem12.Text == "Start Video Exchange")
            {
                if (!started[ClientVEW.SelectedIndices[0]])//create objects for the first chat "started befor"
                {
                    iptostartVChat = ClientIPAddr[ClientVEW.SelectedIndices[0]];
                    menuItem12.Text = "Stop Video Exchange";
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("Server");//sender                   
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartVideo"); //special mesage
                    SubWriter[ClientVEW.SelectedIndices[0]].Write(videoSentchatPort);
                    VideoSenders[ClientVEW.SelectedIndices[0]] = new VideoSender(iptostartVChat, videoSentchatPort, LocalView, hHwnd);
                    new Thread(new ThreadStart(VideoSenders[ClientVEW.SelectedIndices[0]].Start_Sending_Video_Conference));
                    ++videoSentchatPort;
                    started[ClientVEW.SelectedIndices[0]] = true;
                }
                else
                {
                    VideoSenders[ClientVEW.SelectedIndices[0]].StoppedOfSending = false;
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("Server");//sender                   
                    SubWriter[ClientVEW.SelectedIndices[0]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartVideoShowDlg"); //special mesage}//Resume
                }
            }
            else
            {
                SubWriter[ClientVEW.SelectedIndices[0]].Write("Server");//sender                   
                SubWriter[ClientVEW.SelectedIndices[0]].Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->CloseVideo"); //special mesage

                VideoSenders[ClientVEW.SelectedIndices[0]].StoppedOfSending = true;
            }
        }      

        private void OpenPreviewWindow()
        {
            int iHeight = 171;
            int iWidth = 219;
            // 
            //  Open Preview window in picturebox
            // 
            hHwnd = 
                capCreateCaptureWindowA(iDevice.ToString(),
                (WS_VISIBLE | WS_CHILD), 0, 0, 640, 480, 
                LocalView.Handle.ToInt32(), 0);
            // 
            //  Connect to device
            // 
            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) == 1)
            {
                // 
                // Set the preview scale
                // 
                SendMessage(hHwnd, WM_CAP_SET_SCALE, 1, 0);
                // 
                // Set the preview rate in milliseconds
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0);
                // 
                // Start previewing the image from the camera
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, 1, 0);
                // 
                //  Resize window to fit in picturebox
                // 
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, iWidth, iHeight, (SWP_NOMOVE | SWP_NOZORDER));
            }
            else
            {
                // 
                //  Error connecting to device close window
                // 
                MessageBox.Show(this,"There is no capturing device in your computer", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DestroyWindow(hHwnd);
            }
        }
        private void ClosePreviewWindow()
        {
            // 
            //  Disconnect from device
            // 
            SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0);
            // 
            //  close window
            // 
            DestroyWindow(hHwnd);
        }

        private void SCaptureBtn_Click(object sender, EventArgs e)
        {  
            iDevice = int.Parse(device_number_textBox.Text);
            OpenPreviewWindow();                
            SCaptureBtn.Enabled = false;
            StopBTN.Enabled = true;           
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            LocalView.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            ClosePreviewWindow();
            SCaptureBtn.Enabled = true;
            StopBTN.Enabled = false;
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            new AudioSetting().ShowDialog(this);
        }                     
    }
}
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Client_s_.Properties;
using System.Drawing;

namespace Client_s_
{
    public partial class ClientFRM : Form
    {
        private System.Media.SoundPlayer Ssound = new System.Media.SoundPlayer();
        private string message, TagMessage, IPAddresseToConnect = "",
                       ClientNickName = "", ClientsBuffer = "", item = "", stringPortNumbers;
        private Int16 portReaded = 0;
        private NetworkStream output, outputSub;
        private BinaryWriter writer, writerSub;
        private BinaryReader reader, readerSub;
        private int PortNumberToConnect = 0 ,X, Y , RcvPort , SendPort;
        private TcpClient Mclient, ClientSub;
        private SignIn frm = new SignIn();
        private bool initiated = false;
        private int VRCVport;      
        private SlideDialog VR;
      
        private enum ConnectionStatusClosed{ServerDisconnted,//sever closed
                                            ServerDismissedMe,//server taradny  
                                            SignOutByUser,
                                            NickNameDuplication};//user clicked sign out

        private ConnectionStatusClosed Status = ConnectionStatusClosed.ServerDisconnted;//Default action
        private DateTime LastNudge;
        private Splash splash;    
        private AudioReceiver audioReceiver;
        private AudioSender audioSender;
  
        public ClientFRM()
        {
           
          
            InitializeComponent();
            splash = new Splash(20, true); 
            ShowSplash();            
        }
        private void PlaySoundLogError()
        {
            byte[] buffer = new byte[Resources.Windows_XP_Critical_Stop.Length];
            Resources.Windows_XP_Critical_Stop.Read(buffer, 0, (int)Resources.Windows_XP_Critical_Stop.Length);
            System.IO.MemoryStream memStr = new MemoryStream(buffer);
            Ssound.Stream = memStr;
            Ssound.Play();
        }
        private delegate void AdjustGUIDelegate();

        private void AdjustGUI()
        {
            //
            //that return GUI To meet this " server disconnect " state
            //
            ClientVEW.Items.Clear();
            rcvTXT.Clear();
            disconnectToolStripMenuItem.Enabled = false;
            this.AcceptButton = signInLnkLBL;
            this.Text = "Messenger Offline";
          
            signInLnkLBL.Visible = true;
            axShockwaveFlash.Visible = true;
            panel1.Visible = false;
            if (Status == ConnectionStatusClosed.ServerDisconnted)
            {
                
                StatusLBL.ForeColor = Color.Red;
                if (ErrorTXT.InvokeRequired) 
                {
                    Invoke(new AdjustGUIDelegate(AdjustGUI));
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default
                }
                else
                {
                    ErrorTXT.Visible = true;
                    ErrorTXT.Text = "Error: Server has been disconnected"+Environment.NewLine+" at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ", you have to sign in again.";
                    StatusLBL.Text = "Connection error.";
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default
                }
            }
            else if (Status == ConnectionStatusClosed.ServerDismissedMe)
            {
               
                StatusLBL.ForeColor = Color.DarkGreen;
                if (ErrorTXT.InvokeRequired)
                { 
                    Invoke(new AdjustGUIDelegate(AdjustGUI)); 
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default 
                }
                else
                {
                    ErrorTXT.Visible = true;
                    ErrorTXT.Text = "Server dismissed you" + Environment.NewLine + " at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " .";
                    StatusLBL.Text = "Client dismissed.";
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default 
                }
            }
            else if (Status == ConnectionStatusClosed.NickNameDuplication)
            {
                StatusLBL.ForeColor = Color.Green;
                if (ErrorTXT.InvokeRequired)
                {
                    Invoke(new AdjustGUIDelegate(AdjustGUI));
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default 
                }
                else
                {
                    ErrorTXT.Visible = true;
                    ErrorTXT.Text = "A Similar Nickname is already exists at server ," + Environment.NewLine + " Use another NickName .";
                    StatusLBL.Text = "Connection refused.";
                    Status = ConnectionStatusClosed.ServerDisconnted;//return to default 
                }
                Status = ConnectionStatusClosed.ServerDisconnted;//return to default 
            }
            else { StatusLBL.Text = "Disconnected ..."; Status = ConnectionStatusClosed.ServerDisconnted; } // i.e Status = ConnectionStatusClosed.SignOutByUser 
        }
        private void RunClient()
        {
            StatusLBL.ForeColor = Color.Black;
            while (true)
            {
                try
                {
                    Mclient = new TcpClient();
                    Mclient.Connect(IPAddresseToConnect, PortNumberToConnect);
                    output = Mclient.GetStream();
                    writer = new BinaryWriter(output);
                    reader = new BinaryReader(output);
                    
                    //
                    //read port                   
                    //
                    ReadPort();              

                    //
                    //Close main Connections
                    //
                    CloseMainConnections();

                    //
                    //initiate the new connection
                    //
                    ClientSub = new TcpClient();
                    ClientSub.Connect(IPAddresseToConnect, portReaded);
                    outputSub = ClientSub.GetStream();
                    writerSub = new BinaryWriter(outputSub);
                    readerSub = new BinaryReader(outputSub);
                    StatusLBL.Text = "Connected to server...";

                    //
                    //server may refuse connecton "Dublicate nickname"
                    //                   
                    //new  Thread(new ThreadStart( CheckAccept)).Start();
                    //CheckAccept();
                    //Thread.Sleep(2300);
                    //
                    //send nickname to server and adjust Client GUi 
                    //
                    SendNicNameAndAdjustGUI();

                    //
                    //Play Welcome Flash "Acceptance"
                    //
                    PlayWelcomeFlash();

                    //
                    //Wait flash Until finish and close
                    //
                    Thread.Sleep(2300);
                    axShockwaveFlash.GotoFrame(0);
                    axShockwaveFlash.Visible = false;
                    axShockwaveFlash.Stop();

                    //
                    //reads clients list from stream "to Agree Server has sent them auto. at this time"
                    //
                    GetTheClientsThatServerHasSent();

                    while (true)
                    {
                        try
                        {
                            TagMessage = readerSub.ReadString();
                            message = readerSub.ReadString();          

                            //
                            //parse To Know Its Type
                            //
                            if (TagMessage == "SignOut")//some one gone to hill
                            {
                                MessageBox.Show(this, message + " has signed out.", "Messenger", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                rcvTXT.AppendText(message + " Signed out ... " + Environment.NewLine);
                                StatusLBL.Text = message + " has signed out ...";
                                for (int i = 0; i < ClientVEW.Items.Count; i++)
                                {
                                    if (ClientVEW.Items[i].Text == message)
                                    {
                                        ClientVEW.Items[i].ImageIndex = 2;
                                        ClientVEW.Items[i].ForeColor = Color.Brown;
                                        break;//stop search
                                    }
                                }
                            }
                            else if (TagMessage == "NewUSer") //Server sends new one entered room
                            {
                                ListViewItem viewItem = new System.Windows.Forms.ListViewItem(message, 3);
                                ClientVEW.Items.AddRange(new ListViewItem[] { viewItem });
                                rcvTXT.AppendText(message + " Signed in ... " + Environment.NewLine);
                             
                                StatusLBL.Text = message + " has signed in ...";
                            }
                            else if (TagMessage == "ServerAcceptAudio") //Server sends new one entered room
                            {
                                int port = int.Parse(message);
                                audioSender = new AudioSender(IPAddresseToConnect, port);
                                audioSender.StartSendAudio();
                                initiated = true;
                                writerSub.Write(ClientNickName);
                                writerSub.Write("Server");//the client to reciev
                                writerSub.Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartAudioChatting()");  
                               
                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->ClientSendsAfile()")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + TagMessage + " sends you a file ... " + Environment.NewLine);
                                NetUtility.FileAttacher RecObj = new NetUtility.FileAttacher();
                                RecObj.Parent = this;
                                RecObj.SenderClient = TagMessage;
                                RecObj.IP = IPAddresseToConnect;
                                new Thread(new ThreadStart(RecObj.RecieveFile)).Start();
                                
                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " You have just received a Nudge from " + TagMessage + Environment.NewLine);
                                new Thread(new ThreadStart(PalyNudgeSound)).Start();
                                new Thread(new ThreadStart(PalyNudgeMotion)).Start();

                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartVideoShowDlg")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Receiving video Streams from " + TagMessage + Environment.NewLine);
                               // new Thread(new ThreadStart(this.VR.Slide)).Start();   
                               // this.VR.Slide();

                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StartVideo")
                            {

                                VRCVport = readerSub.ReadInt16();
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Receiving video Streams from " + TagMessage + Environment.NewLine);
                            //    new Thread(new ThreadStart(ShowDlg)).Start();

                                VR = new SlideDialog(this, (float)0.05, VRCVport);
                                VR.SlideDirection = SlideDialog.SLIDE_DIRECTION.LEFT;
                            //    this.VR.Slide();
                              //  new Thread(new ThreadStart(this.VR.Slide)).Start();
                                     

                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->CloseVideo")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Video Exchange with remote host terminated."+ Environment.NewLine);
                               // new Thread(new ThreadStart(VR.Slide)).Start();
                               // this.VR.Slide();
                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->audioChating()")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Receiving Audio Streams from " + TagMessage + Environment.NewLine);
                                stringPortNumbers = readerSub.ReadString();
                                ParsePortNumbers();
                                audioReceiver = new AudioReceiver(IPAddresseToConnect, RcvPort);
                                audioReceiver.StartReceiveAudio();
                            }
                            else if (message == "CandyIsDandyButTriggerIsQuicker_AfxGetApp()->StopaudioChating()")
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " Audio exchange paused." + Environment.NewLine);
                            }

                            else if (TagMessage == "GoToHill")
                            {
                                Status = ConnectionStatusClosed.ServerDismissedMe;
                                CloseConnection();
                            }
                            else //display message "chat"
                            {
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + TagMessage + " sayes : " + Environment.NewLine + message + Environment.NewLine);
                                StatusLBL.Text = TagMessage + " has send you message ...";
                            }
                        }
                        catch //(Exception gg)
                        {
                            //MessageBox.Show(gg.Message + "no conn", "Client:SocketException ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AdjustGUI();
                            return;   // to begin Sign in „‰ «·«Ê· ÊÃœÌœ   
                            //·Ê ⁄«Ì“ «Œ·ÌÂ Ì⁄„· —Ì —«Ï ·ÊÕœÂ ‘Ì· «·ﬂÊ„‰  „‰ ⁄·Ï ÃÊ Ê Ê «··«»· Ê«⁄„· ﬂÊ„‰  ⁄·Ï —Ì —‰
                            //goto LBL;
                        }
                    }
                    writerSub.Close();
                    readerSub.Close();
                    outputSub.Close();
                    ClientSub.Close();
                    //LBL:;                    //label with empty statement toavoid close connections
                    //Application.Exit();    //if i wanna close
                }
                catch
                {
                    new Thread(new ThreadStart(PlaySoundLogError)).Start();
                    frm.WorkBTN.Text = "&Retry";
                    frm.statusLBL.Text = "Server not found, press Retry to connect again.";
                    frm.statusLBL.ForeColor = Color.Red;
                    frm.ShowDialog(this);
                    IPAddresseToConnect = frm.ipAddr;
                    ClientNickName = frm.nickName;
                    PortNumberToConnect = frm.portNum;
                    signInLnkLBL.Visible = false;
                    //MessageBox.Show(gg.Message +"no conn", "Client:SocketException ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //System.Environment.Exit(System.Environment.ExitCode);
                }
            }
        }
        private void ShowDlg()
        {
            VR = new SlideDialog(this, (float)0.05, VRCVport);
            VR.SlideDirection = SlideDialog.SLIDE_DIRECTION.LEFT;      
           
        }
        private void ParsePortNumbers()
        {
            SendPort = int.Parse(stringPortNumbers.Substring(0, 4));
            RcvPort = int.Parse(stringPortNumbers.Substring(4));            
        }

        private void CheckAccept()
        {
           string Errormessage = readerSub.ReadString();
           if (Errormessage == "ConnectionRefused")
           {


               PlaySoundLogError();

               writerSub.Close();
               readerSub.Close();
               outputSub.Close();
               ClientSub.Close();
               Status = ConnectionStatusClosed.NickNameDuplication;
           }
          //  else MessageBox.Show("cliebt food");
        }

        private void GetTheClientsThatServerHasSent()
        {
            ClientsBuffer = readerSub.ReadString();

            //
            //append to view
            //
            for (int i = 0; i < ClientsBuffer.Length; i++)
            {
                if (ClientsBuffer[i] != '\n')
                    item += ClientsBuffer[i];
                else
                {
                    ListViewItem viewItem = new System.Windows.Forms.ListViewItem(item, 3);
                    ClientVEW.Items.AddRange(new ListViewItem[] { viewItem });
                    item = "";
                }
            }
        }

        private void PlayWelcomeFlash()
        {
            axShockwaveFlash.LoadMovie(0, Directory.GetCurrentDirectory() + "\\1.SWF");
            axShockwaveFlash.GotoFrame(0);
            axShockwaveFlash.Play();
            panel1.Visible = true;
        }

        private void SendNicNameAndAdjustGUI()
        {   
            //adjust GUI "Connected to Server" state
            disconnectToolStripMenuItem.Enabled = true;
            this.Text = "You are online " + ClientNickName;
            ToserverCHK.Enabled = true;
            StatusLBL.Text = "Sending nick name ...";
            //
            //Sending IP to server
            //
            writerSub.Write(ClientSub.Client.LocalEndPoint.ToString());

            writerSub.Write(ClientNickName);
            StatusLBL.Text = "Connected ...";         
            this.AcceptButton = SendBTN;
            signInLnkLBL.Visible = false;

        }

        private void CloseMainConnections()
        {
            Mclient.Close();         
            reader.Close();
            output.Close();
            StatusLBL.Text = "Main connection closed...";
        }

        private void ReadPort()
        {
            ErrorTXT.Visible = false;
            portReaded = reader.ReadInt16();
            StatusLBL.Text = "Reading received port...";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try { audioReceiver.Dispose(); audioSender.Dispose(); }
            catch { };
            System.Environment.Exit(System.Environment.ExitCode);
        }
        private void signInLnkLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm.WorkBTN.Text = "&Connect";
            frm.statusLBL.Text = "Fill in Sign in data . . .";
            frm.statusLBL.ForeColor = Color.Blue;
            frm.ShowDialog(this);      
            IPAddresseToConnect = frm.ipAddr;
            ClientNickName = frm.nickName;
            PortNumberToConnect = frm.portNum;
            Thread Readth = new Thread(new ThreadStart(RunClient));
            Readth.Start();        

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void SendBTN_Click_1(object sender, EventArgs e)
        {
            int count = 0;//to check any is online or no
            if (ClientVEW.SelectedIndices.Count == 0&&ToserverCHK.Checked==false)
            {
                MessageBox.Show(this, "You must select target. ", "Messenger", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (ToserverCHK.Checked == true && ClientVEW.Items.Count == 0)
            {                
                writerSub.Write(ClientNickName);
                writerSub.Write("Server");//the client to reciev
                writerSub.Write(SentTXT.Text);
                MessageBox.Show(this, "Message has sent only to Sever. ", "Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                try
                {
                    for (int i = 0; i < ClientVEW.SelectedIndices.Count; i++)
                    {
                        if (ClientVEW.Items[ClientVEW.SelectedIndices[i]].ImageIndex != 2)//not offline
                        {
                            if (i == 0)//dispaly it to me "one time only"
                                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + " " + ClientNickName + " sayes : " + Environment.NewLine + SentTXT.Text + Environment.NewLine);
                            ++count;//at least one is online
                            writerSub.Write(ClientNickName);
                            writerSub.Write(ClientVEW.Items[ClientVEW.SelectedIndices[i]].Text);//the client to reciev
                            writerSub.Write(SentTXT.Text);
                        }
                    }
                    if (count == 0 && ToserverCHK.Checked == true)//«·—”«·Â „ »⁄  ‘ ·«Ï Ê«Õœ
                    {                
                        writerSub.Write(ClientNickName);
                        writerSub.Write("Server");//the client to reciev
                        writerSub.Write(SentTXT.Text);
                        MessageBox.Show(this, "Message has sent only to Sever. ", "Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (count == 0 && ToserverCHK.Checked == false)
                    {
                        MessageBox.Show(this, "You must select destination. ", "Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Client:Error Sending Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(System.Environment.ExitCode);
                }
            SentTXT.Clear();
            SentTXT.Focus();
        }

        private void SentTXT_TextChanged(object sender, EventArgs e)
        {
            if (SentTXT.Text.Length != 0)
                SendBTN.Enabled = true;
            else
                SendBTN.Enabled = false;
        }        

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = ConnectionStatusClosed.SignOutByUser; //"user" signed out
            CloseConnection();
          
        }

        private void CloseConnection()
        {
            //
            //causes SoketExp to be raised and GUI Adjusted according to "Status"
            //           
            writerSub.Close();
            readerSub.Close();
            outputSub.Close();
            ClientSub.Close();
        }

        private void sendFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SendFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                writerSub.Write(ClientNickName);
                writerSub.Write(ClientVEW.Items[ClientVEW.SelectedIndices[0]].Text);//the client to reciev
                writerSub.Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->ClientSendsAfile()");
                NetUtility.FileAttacher sendObj = new NetUtility.FileAttacher();             
                sendObj.FileName = SendFileDialog.FileName;
                new Thread(new ThreadStart(sendObj.SendFile)).Start();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (ClientVEW.SelectedIndices.Count == 0 || ClientVEW.Items[ClientVEW.SelectedIndices[0]].ImageIndex==2)//offline or no item dont show menu
                e.Cancel = true;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastNudge.AddSeconds(3) <= DateTime.Now)
            {
                writerSub.Write(ClientNickName);
                writerSub.Write(ClientVEW.Items[ClientVEW.SelectedIndices[0]].Text);//the client to reciev
                writerSub.Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()");
                LastNudge = DateTime.Now;
            }
            else { rcvTXT.AppendText(Environment.NewLine + "You can't send Nudge." + Environment.NewLine); }
        }
        private void PalyNudgeMotion()
        {
            if (this.WindowState == FormWindowState.Minimized||this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            Nudge n = new Nudge(this);
            new Thread(new ThreadStart(n.NudgeMe)).Start();      
        }
              
        private void PalyNudgeSound()
        {
            lock (this)
            {
                byte[] buffer = new byte[Resources.NUDGE.Length];
                Resources.NUDGE.Read(buffer, 0, (int)Resources.NUDGE.Length);
                System.IO.MemoryStream memStr = new MemoryStream(buffer);
                Ssound.Stream = memStr;
                Ssound.Play();
            }
        }

        private void aboutMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Students__House_Control.About().ShowDialog(this);
        }

        private void ClientVEW_DoubleClick(object sender, EventArgs e)
        {
            if (LastNudge.AddSeconds(3) <= DateTime.Now)
            {
                writerSub.Write(ClientNickName);
                writerSub.Write(ClientVEW.Items[ClientVEW.SelectedIndices[0]].Text);//the client to reciev
                writerSub.Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->SendNudge()");
                LastNudge = DateTime.Now;
            }
            else { rcvTXT.AppendText(Environment.NewLine + "You can't send Nudge." + Environment.NewLine); }
            
        }

        private void ClientFRM_Load(object sender, EventArgs e)
        {           
            LastNudge = DateTime.Now;          
        }

        private void ShowSplash()
        {
            splash.ShowDialog(this);
        }

        private void showSplashScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splash = new Splash(40,false);
            ShowSplash();  
        }

        private void stopAudioChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stopAudioChatToolStripMenuItem.Text == "Start Audio Chat")
            {  
                stopAudioChatToolStripMenuItem.Text = "Stop Audio Chat";
                if (!initiated)
                {
                  
                    writerSub.Write(ClientNickName);
                    writerSub.Write("Server");//the client to reciev
                    writerSub.Write("CandyIsDandyButTriggerIsQuicker_AfxGetApp()->AudioChatting()");
                }
                else {
                    audioSender.ResumeAudioChat();
                }
            }
            else
            {
                stopAudioChatToolStripMenuItem.Text = "Start Audio Chat";
                audioSender.StopAudioChat();
            }        
        }
        private void audioExchangeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AudioSetting().ShowDialog(this);
        }   

        private void sdeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                VR.Slide();
            }
            catch { MessageBox.Show("Server must initiate video sending ,then you can use this button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }             
    }
}
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Network.Server;
using System.Threading;
using System.IO;

namespace SmartDoor
{
    public partial class VideoFrm : Form
    {
        ArrayList IncomingImages = new ArrayList();
        Server mainServer = null;
        Server s = new Server();
        int SocketID;
        public delegate void closingDelegate(object sender);
        public event closingDelegate ClosingEvent;

        SmartDoor.Server_Monitoring server;
        bool Synchronous = true;
        ServerFRM ServerFrm;
        public VideoFrm(ServerFRM form)
        {
            InitializeComponent();
            ServerFrm = form;

            server = new Server_Monitoring(this);
            //server.SetPicture += new Server_Monitoring.SetImage(server_SetPicture);
            server.sychDataRecieved += new Server_Monitoring.SychDataRecieved(server_sychDataRecieved);
            server.sychClientDissconnected += new Server_Monitoring.SychClientDisconnected(server_sychClientDissconnected);
            server.OnSychClientErrorCatched += new Server_Monitoring.SychClientErrorCatched(server_OnSychClientErrorCatched);
            server.Start();
        }

        void server_OnSychClientErrorCatched(string Data)
        {
            ServerFrm.Log(Data, Color.Black);//"Client Disconnected."
           // this.Close();
        }

        void server_sychClientDissconnected(string Data)
        {
            if (this.button1.Text.ToLower() != "Enable Control".ToLower())
            {
                try
                {
                    this.button1.Text = "Enable Control";
                    this.PicBImage.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDoubleClick);
                    this.PicBImage.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseClick);
                    //this.PicBImage.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseUp);
                    this.PicBImage.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseMove);
                    //this.PicBImage.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDown);
                }
                catch { }
            }
            //ServerFrm.Log(Data, Color.Black);//"Client Disconnected."
            server.Close();
            //this.Close();
            //MessageBox.Show(Data);
        }

        void server_sychDataRecieved(string Data)
        {
            if (Data.StartsWith("[#<CMD>#]"))
            {
                string[] CmdArg = Data.Remove(0, ("[#<CMD>#]").Length).Split(new string[] { "[#]" }, StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                    case "[#Information#]":
                        lock (this)
                        {
                            RemoteScreenWidth = int.Parse(CmdArg[1]);
                            RemoteScreenHeight = int.Parse(CmdArg[2]);
                        }
                        break;
                }

            }
            else
            {
                lock (this) { this.PicBImage.Image = Image.FromStream(new MemoryStream(Encoding.Default.GetBytes(Data))); }
            }
        }

        void server_SetPicture(Image I)
        {
            lock (this)
            {
                this.PicBImage.Image = I;
            }
        }
        public VideoFrm(/*Server */ int SocketID)
        {
            InitializeComponent();
            //Ali_API.CloseButtonRemove.Disable(this);
           // mainServer = MServer;
            this.SocketID = SocketID;
            s.ServerListening += new Server.ServerListeningArg(s_ServerListening);
            s.ErrorCatched += new Server.SocketErrorArg(s_ErrorCatched);
            s.DataReceived += new Server.SocketDataArg(s_DataReceived);
            s.SocketDisconnected += new Server.SocketDisconnectArg(s_SocketDisconnected);
            s.SocketConnected += new Server.SocketConnectedArg(s_SocketConnected);
            s.StartServer(6000, true);

        }
        Thread imagesThread;
        void s_SocketDisconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            imagesThread.Abort();
        }
        void s_ErrorCatched(object Sender, SocketErrorEventsArg see)
        { }
        void s_ServerListening(object Sender, ServerListeningEventsArg sle)
        { }
        private void s_SocketConnected(object sender, SocketConnectedEventsArg sce)
        { 
            imagesThread = new Thread(new ThreadStart(SendACK));
            imagesThread.Start();
        }
        int RemoteScreenWidth, RemoteScreenHeight;
        FilePacket ClientPacket=new FilePacket();
        int icount = 0;
        int NumOfFrames = 0, NumOfFrames2=0;
        public string time2;
        void s_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            //SocketID = sde.SocketID;
            string IncomingCommand = Encoding.UTF8.GetString(sde.Data).Trim(new char[] { '\0' });  // An clean string which contain the commands arguments.
            /*
             * User Data&,........
             */
            if (IncomingCommand.StartsWith("[#<CMD>#]"))    // Detect the existance of command on the received data.
            {
                // An command detected, split it to retrive the arguments
                string[] CmdArg = IncomingCommand.Remove(0, ("[#<CMD>#]").Length).Split(new string[] { "[#]" },  StringSplitOptions.RemoveEmptyEntries);
                switch (CmdArg[0])  //Args[0] which represent the command key.
                {
                      case ("[#ReadyToSend#]"):
                        {
                            /*if (GetClientPacket() != null)
                            {
                                for (int i = 0; i < IncomingImages.ToArray().Length; i++)
                                    IncomingImages.RemoveAt(i);
                                //IncomingImages.Remove(GetClientPacket());
                            }
                            IncomingImages.Add(new FilePacket(int.Parse(CmdArg[1])));*/
                            //ClientPacket = null;
                            //ClientPacket = new FilePacket();
                            ClientPacket.Truncate();
                            Thread.Sleep(10);
                            lock (this)
                            {
                                s.SendMessage(sde.SocketID, "[#<CMD>#][#ReadyToReceive#][#][#ImageQuality#][#]" + this.barQuality.Value + "[#]");
                            }
                            break;
                        }
                    case "[#Information#]":
                        lock (this)
                        {
                            RemoteScreenWidth =int.Parse( CmdArg[1]);
                            RemoteScreenHeight =int.Parse( CmdArg[2]);
                        }
                        break;
                }
            }
            else
            {
                //ClientPacket = GetClientPacket();
                string DetectEOF = Encoding.ASCII.GetString(sde.Data);  //Detect the End Of File, by looking for the [#<EOF>#] inside encoded data.
                if (DetectEOF.IndexOf("[#<EOF>#]") > -1)        //EOF detected, so remove that tag, and all the garbish follow it, an only keep data befor that tag.
                {
                    //MessageBox.Show(sde.Data.Length.ToString());
                    byte[] ClonedChunk = (byte[])sde.Data.Clone();
                    Array.Resize(ref ClonedChunk, DetectEOF.IndexOf("[#<EOF>#]"));
                    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    ClientPacket.WriteData(ClonedChunk, true);
                    //MemoryStream mms=new MemoryStream();
                    //ClientPacket.ClientImage.Save(mms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    lock(this){NumOfFrames2++;}
                    new TSCUpdater(PicBImage).Image = ClientPacket.ClientImage;
                    ClientPacket.Truncate();
                   // PicBImage.Image = ClientPacket.ClientImage;
                  //  Thread.Sleep(10);

                  //  string strr = Directory.GetCurrentDirectory() + "\\dir" + DateTime.Now.Minute.ToString();

                 //   if (!Directory.Exists(strr))
                 //   {
                      //  Directory.CreateDirectory(strr);
                 //   }
                    //mms.WriteTo(new FileStream(strr+ "\\pic" + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".jpg",FileMode.Create));
                    //mms.Flush();
                    //PicBImage.Image = Image.FromStream(mms);
                    //mms.Close();
                    //ClientPacket.ClientImage.Save(strr+ "\\pic" + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    //MessageBox.Show("");
                    //ClientPacket = null;
                  
                    //PicBImage.Image = null;
                    //FileStream fs = new FileStream("c:\\Orginal.jpg", FileMode.Truncate, FileAccess.Write, FileShare.Read);
                    //PicBImage.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //fs.Close();
                    //fs=null;
                    SocketID = sde.SocketID;
                  
                }
                else
                {
                    //MessageBox.Show("client packet length: "+ClientPacket.mProgress.ToString());
                    //lock (this)
                    {
                    //    icount++;
                    //    this.Text = icount.ToString();
                    }
                    /*if (ClientPacket.mProgress > 56200)
                    {
                        //this.PicBImage.Image=Image.FromStream(new MemoryStream(ClientPacket.ClientImage));
                        ClientPacket.WriteData(sde.Data, true);
                        //Thread.Sleep(0);
                        ClientPacket = null;
                    }*/
                    //else
                    {
                        ClientPacket.WriteData(sde.Data, true);
                        //new TSCUpdater(PicBImage).Image = ClientPacket.ClientImage;
                        //ClientPacket = null;
                    }
                }
            }
            System.Threading.Thread.Sleep(0); 
        }
         
        private void SendACK()
        {
            int sd = SocketID;
            while (true)
            {
                if (!pause)
                {
                    s.SendMessage(sd, "[#<CMD>#][#EndOfReceive#][#]");
                    Requstedlbl.Text = "Requsted :"+ NumOfFrames.ToString() ;
                    LBL_Received.Text  = "Received:" + NumOfFrames2.ToString() ;;
                    NumOfFrames++;
                }
                Thread.Sleep(200);
            }
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
      
        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            btnStartMonitor.Enabled = false;
            btnPause.Enabled = true;
            this.button1.Enabled = !radioButton4.Checked;
            pause = false;
            server.Send("[#<CMD>#][#Start#][#][#Camera#][#]" + radioButton4.Checked);
            if (Synchronous) { server.Resume(); }
        }

        bool pause = false;
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStartMonitor.Enabled = true;
            btnPause.Enabled = false;
            pause = true;
            if (Synchronous) { server.Pause(); }
        }


        private void VideoFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (!Synchronous)
                {
                    
                    string Message = "[#<CMD>#][#StopMonitor#][#]";
                    
                    s.SendMessage(SocketID, Message);
                    // MessageBox.Show("connect!");
                    s.StartServer(6000, false);
                    //s.DisconnectSocket(SocketID);
                    imagesThread.Abort();
                    imagesThread = null;
                    //CMD_CloseBool = true;
                    //ClosingEvent(this);
                    //Close();
                   
                }
                else
                {
                    try
                    {
                        server.Close();
                    }
                    catch { }
                }
            }
            catch { Close(); }
        }

        bool CMD_CloseBool = false;

        private void VideoFrm_MouseDown(object sender, MouseEventArgs e)
        {
            //          Thread.Sleep(10);
            string Message = "[#<CMD>#][#MouseEvents#][#][#MouseDown#][#][#X#][#]" + (e.X * RemoteScreenWidth / this.PicBImage.Width) + "[#][#Y#][#]"
                + (e.Y * RemoteScreenHeight / this.PicBImage.Height) + "[#][#MouseButton#][#]" + e.Button + "[#][#WheelDelta#][#]" + e.Delta + "[#]";
            if (!Synchronous) { s.SendMessage(SocketID, Message); }
            else
            {
                server.Send(Message);
            }
        }

        private void VideoFrm_MouseMove(object sender, MouseEventArgs e)
        {
            //            Thread.Sleep(10);
            string Message = "[#<CMD>#][#MouseEvents#][#][#MouseMove#][#][#X#][#]" + (e.X * RemoteScreenWidth / this.PicBImage.Width) + "[#][#Y#][#]"
                + (e.Y * RemoteScreenHeight / this.PicBImage.Height) + "[#][#MouseButton#][#]" + e.Button + "[#][#WheelDelta#][#]" + e.Delta + "[#]";
            if (!Synchronous) { s.SendMessage(SocketID, Message); }
            else
            {
                server.Send(Message);
            }
        }

        private void VideoFrm_MouseUp(object sender, MouseEventArgs e)
        {
            //        Thread.Sleep(100);
            string Message = "[#<CMD>#][#MouseEvents#][#][#MouseUp#][#][#X#][#]" + (e.X * RemoteScreenWidth / this.PicBImage.Width) + "[#][#Y#][#]"
                + (e.Y * RemoteScreenHeight / this.PicBImage.Height) + "[#][#MouseButton#][#]" + e.Button + "[#][#WheelDelta#][#]" + e.Delta + "[#]";
            if (!Synchronous) { s.SendMessage(SocketID, Message); }
            {
                server.Send(Message);
            }
        }

        private void VideoFrm_MouseClick(object sender, MouseEventArgs e)
        {
            //      Thread.Sleep(10);
            string Message = "[#<CMD>#][#MouseEvents#][#][#MouseClick#][#][#X#][#]" + (e.X * RemoteScreenWidth / this.PicBImage.Width) + "[#][#Y#][#]"
                + (e.Y * RemoteScreenHeight / this.PicBImage.Height) + "[#][#MouseButton#][#]" + e.Button + "[#][#WheelDelta#][#]" + e.Delta + "[#]";
            if (!Synchronous) { s.SendMessage(SocketID, Message); }
            else
            {
                server.Send(Message);
            }
        }

        private void VideoFrm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //    Thread.Sleep(10);
            string Message = "[#<CMD>#][#MouseEvents#][#][#MouseDoubleClick#][#][#X#][#]" + (e.X * RemoteScreenWidth / this.PicBImage.Width) + "[#][#Y#][#]"
                + (e.Y * RemoteScreenHeight / this.PicBImage.Height) + "[#][#MouseButton#][#]" + e.Button + "[#][#WheelDelta#][#]" + e.Delta + "[#]";
            if (Synchronous) { s.SendMessage(SocketID, Message); }
            else
            {
                server.Send(Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.ToLower() == "Enable Control".ToLower())
            {
                this.button1.Text = "Disable Control";
                this.PicBImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDoubleClick);
                this.PicBImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseClick);
                //this.PicBImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseUp);
                this.PicBImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseMove);
                //this.PicBImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDown);
            }
            else
            {
            
                this.button1.Text = "Enable Control";
                this.PicBImage.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDoubleClick);
                this.PicBImage.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseClick);
                //this.PicBImage.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseUp);
                this.PicBImage.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseMove);
                //this.PicBImage.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.VideoFrm_MouseDown);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.btnStartMonitor.PerformClick();
            
            if (radioButton4.Checked)
            {
                server.Send("[#<CMD>#][#Start#][#][#Camera#][#]true");
                server.CamMonitoring = true;
            }
            else
            {
                server.CamMonitoring = false;
                server.Send("[#<CMD>#][#Stop#][#][#Camera#][#]false");
                //server.Send("[#<CMD>#][#Start#][#][#Camera#][#]false");
            }
            //ResetUI();
            //pause = false;
            //server.Resume();
        }
        void ResetUI()
        {
            this.btnPause.Enabled = true;
            this.btnStartMonitor.Enabled = false;
            this.button1.Enabled = !radioButton4.Checked;
        }

      


    }

}
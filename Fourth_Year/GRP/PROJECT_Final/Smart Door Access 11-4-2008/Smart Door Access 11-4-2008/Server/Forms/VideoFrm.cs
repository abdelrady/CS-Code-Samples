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
            pause = false;

        }

        bool pause = false;
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStartMonitor.Enabled = true;
            btnPause.Enabled = false;
            pause = true;         
           
        }


        private void VideoFrm_FormClosing(object sender, FormClosingEventArgs e)
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

    }

}
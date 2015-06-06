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
        private string message, NickName, IPAddresseToConnect = "", ClientNickName = "";
        //Common Tools
        private Int16 portReaded = 0;
        private NetworkStream output, outputSub;
        // network data stream           

        private BinaryWriter writer, writerSub;
        // facilitates writing to the stream    

        private BinaryReader reader, readerSub;
        // facilitates reading from the stream  
        private int PortNumberToConnect = 0;
        SigninFRM frm = new SigninFRM();

        public ClientFRM()
        {
            InitializeComponent();
        }
        private void PlaySoundLogError()
        {
            byte[] buffer = new byte[Resources.Windows_XP_Critical_Stop.Length];
            Resources.Windows_XP_Critical_Stop.Read(buffer, 0, (int)Resources.Windows_XP_Critical_Stop.Length);
            System.IO.MemoryStream memStr = new MemoryStream(buffer);
            Ssound.Stream = memStr;
            Ssound.Play();
        }
        private void AdjustGUI()
        {
            //that return GUI To meet this " server disconnect " state

            this.AcceptButton = signInLnkLBL;
            StatusLBL.Text = "Error: Server has been disconnected, at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ", you have to sign in again.";
            StatusLBL.ForeColor = Color.Red;
            signInLnkLBL.Visible = true;
            axShockwaveFlash.Visible = true;
            panel1.Visible = false;
        }
        private void RunClient()
        {
            string ClientsBuffer = "" , item = "";
            StatusLBL.ForeColor = Color.Black;
            TcpClient Mclient, ClientSub;
            while (true)
            {
                try
                {
                    Mclient = new TcpClient();
                    Mclient.Connect(IPAddresseToConnect, PortNumberToConnect);
                    output = Mclient.GetStream();
                    writer = new BinaryWriter(output);
                    reader = new BinaryReader(output);

                    //read port                   
                    portReaded = reader.ReadInt16();
                    StatusLBL.Text = "Reading received port...";

                    Mclient.Close();
                    writer.Close();
                    reader.Close();
                    output.Close();
                    StatusLBL.Text = "Main connection closed...";

                    ClientSub = new TcpClient();
                    ClientSub.Connect(IPAddresseToConnect, portReaded);
                    outputSub = ClientSub.GetStream();
                    writerSub = new BinaryWriter(outputSub);
                    readerSub = new BinaryReader(outputSub);
                    StatusLBL.Text = "Connected to server...";

                    //send nickname   
                    this.Text = "You are online " + ClientNickName;
                    StatusLBL.Text = "Sending nick name ...";
                    writerSub.Write(ClientNickName);
                    StatusLBL.Text = "Connected ...";

                    //adjust GUI "Connected to Server" state
                    this.AcceptButton = SendBTN;
                    signInLnkLBL.Visible = false;

                    axShockwaveFlash.LoadMovie(0, Directory.GetCurrentDirectory() + "\\1.SWF");
                    axShockwaveFlash.GotoFrame(0);
                    axShockwaveFlash.Play();

                    panel1.Visible = true;
                    Thread.Sleep(3000);
                    axShockwaveFlash.Visible = false;
                    //axShockwaveFlash.Stop();

                    //
                    //reads clients list from stream
                    //
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

                    while (true)
                    {
                        try
                        {
                            NickName = readerSub.ReadString();
                            message = readerSub.ReadString();
                            rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + NickName + ":" + message + Environment.NewLine);
                        }
                        catch
                        {
                            new Thread(new ThreadStart(AdjustGUI)).Start();
                            return;   // to begin Sign in ãä ÇáÇæá æÌÏíÏ   
                            //áæ ÚÇíÒ ÇÎáíå íÚãá ÑíÊÑÇì áæÍÏå Ôíá ÇáßæãäÊ ãä Úáì ÌæÊæ æ ÇááÇÈá æÇÚãá ßæãäÊ Úáì ÑíÊÑä
                            //goto x;
                        }
                    }
                    writer.Close();
                    reader.Close();
                    output.Close();
                    ClientSub.Close();
                    //x:;                    //label with empty statement toavoid close connections
                    //Application.Exit();    //if i wanna close
                }
                catch // server not found
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
                    //MessageBox.Show("no conn", "Client:SocketException ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // System.Environment.Exit(System.Environment.ExitCode);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            // Thread.Sleep(3000);

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void SendBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                writerSub.Write(ClientNickName);
                writerSub.Write(SentTXT.Text);
                rcvTXT.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ClientNickName + ":" + SentTXT.Text + Environment.NewLine);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Client:Error Sending Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(System.Environment.ExitCode);
            }
            SentTXT.Clear();
        }

    }
}
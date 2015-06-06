using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Server.Properties;

namespace Server
{
    public partial class Server : Form
    {
        private System.Media.SoundPlayer Ssound = new System.Media.SoundPlayer();
        private const int MAXCLIENTS  = 30;   //max number fo concurrent clents 
        private Socket MainConnection;     
        private int portNum , mainPort;
        private NetworkStream MainsocketStream;
        private BinaryWriter MainWriter;
        private BinaryReader reader;
        private IPAddress local;
        private int ClientIndex = -1;  
        private TcpListener mainlistener;
        private TcpListener[] subConnections = new TcpListener[MAXCLIENTS];
        private Socket[] SubSocets = new Socket[MAXCLIENTS];
        private NetworkStream[] substreams = new NetworkStream[MAXCLIENTS];
        private BinaryWriter[] SubWriter = new BinaryWriter[MAXCLIENTS];
        private BinaryReader[] readers = new BinaryReader[MAXCLIENTS];
        private bool[] Online = new bool[MAXCLIENTS];//stores the indices of the online Clients
        private string IP = "" ;
        private string nickName = "", Client_Nickname="";

        public Server()
        {
            InitializeComponent();
            for (int C = 0; C < MAXCLIENTS; C++)
            {
                Online[C] = true;
            }
        }
        private void PlaySoundLogIn()
        {
            byte[] buffer = new byte[Resources.NEWEMAIL.Length];
            Resources.NEWEMAIL.Read(buffer, 0, (int)Resources.NEWEMAIL.Length);
            System.IO.MemoryStream memStr = new MemoryStream(buffer);
            Ssound.Stream = memStr;
            Ssound.Play();
        }
        private void PlaySoundLogOut()
        {
            byte[] buffer = new byte[Resources.Windows_XP_Information_Bar.Length];
            Resources.Windows_XP_Information_Bar.Read(buffer, 0, (int)Resources.Windows_XP_Information_Bar.Length);
            System.IO.MemoryStream memStr = new MemoryStream(buffer);
            Ssound.Stream = memStr;
            Ssound.Play();
        }    
        private void WorkBTN_Click(object sender, EventArgs e)
        {
            workInBackgroundToolStripMenuItem.Enabled = true;
        
            notifyIcon1.Icon = Resources.display;
            WorkBTN.Visible = false;
            label1.Visible = false;
            label2.Visible = false ;
            groupBox3.Size = new System.Drawing.Size(609, 93);
            IpTXT.Visible = false;
            PortTXT.Visible = false ;

            statusLBL.Text = "Waiting for Clients...";
            IpTXT.Enabled = false;
            PortTXT.Enabled = false;
            WorkBTN.Enabled = false;
            listenToClientsToolStripMenuItem.Enabled = false;
            IP = ParseIP(IpTXT.Text);          
            portNum = int.Parse(PortTXT.Text); // clients incremental port
            mainPort = portNum; //assign main listen port
            this.AcceptButton = SendBTN;          
            new Thread(new ThreadStart(WaitMainConnection)).Start();
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
                    nickName = "";
                    MainConnection = mainlistener.AcceptSocket();
                    MainsocketStream = new NetworkStream(MainConnection);
                    MainWriter = new BinaryWriter(MainsocketStream);
                    reader = new BinaryReader(MainsocketStream);
                    ++portNum;
                    ++ClientIndex;
                    //
                    //some code to handel if client# is not exceed "MAXCLIENTS" here check "ClientIndex"
                    //
                    MainWriter.Write(portNum); //send port to client to connect using it
                    
                    sentTXT.Enabled = true;
                    SendBTN.Enabled = true;
                    ToallCHK.Enabled = true;

                    new Thread(new ThreadStart(PlaySoundLogIn)).Start();
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
            substreams[Index] = new NetworkStream(SubSocets[Index]);
            SubWriter[Index] = new BinaryWriter(substreams[Index]);
            readers[Index] = new BinaryReader(substreams[Index]);
            //
            //reading nick name
            //
            nickName = readers[Index].ReadString(); 
  
            //
            //send list of clients to the signed client
            //
            string clientsBuffer = "";
            for (int count = 0; count < ClientVEW.Items.Count; count++)
            {
                if (Online[count])
                    clientsBuffer += ClientVEW.Items[count].Text+"\n";
            }
            SubWriter[Index].Write(clientsBuffer);//send it
            //
            //adding him to list
            //
            ListViewItem item = new System.Windows.Forms.ListViewItem(new string[] { nickName, DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(),subConnections[Index].LocalEndpoint.AddressFamily.ToString() }, 3);
            ClientVEW.Items.AddRange(new ListViewItem[] { item });
            Log.AppendText(Environment.NewLine + nickName + " Signed in ... " + Environment.NewLine);
            statusLBL.Text = "Some Client signed in...";            
            //
            //processing 
            //
            string message;
            do
            {
                try
                {
                    Client_Nickname = readers[Index].ReadString();//first of any message client name is wrote and readed
                    message = readers[Index].ReadString();
                    Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + Client_Nickname + ":" + message + Environment.NewLine);   
                    //send list of online clients                  
                }
                catch 
                {
                    ClientVEW.Items[Index].ImageIndex = 2;
                    Online[Index] = false;//make him offline   
                    Log.AppendText(Environment.NewLine + ClientVEW.Items[Index].Text + " Signed out ... " + Environment.NewLine);
                    statusLBL.Text = "Some Client signed out...";
                    new Thread(new ThreadStart(PlaySoundLogOut)).Start();             
                    break;
                }
            } while (true);
            SubWriter[Index].Close();
            readers[Index].Close();
            SubSocets[Index].Close();
            SubSocets[Index].Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Icon = null;
            System.Environment.Exit(System.Environment.ExitCode);
        }
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
        private void SendBTN_Click(object sender, EventArgs e)
        {
            Log.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + "Server" + ":" + sentTXT.Text + Environment.NewLine);
            new Thread(new ThreadStart(SendStreamsToClient)).Start();
        }
        private void SendStreamsToClient()
        {
            if (ClientVEW.SelectedIndices.Count == 0 && ToallCHK.Checked == false)
                MessageBox.Show(this,"You must select client. ", "Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
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
            this.ShowInTaskbar = false;
            fullServerMoodToolStripMenuItem.Enabled = true;
            this.Visible = false;
        }

        private void fullServerMoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            fullServerMoodToolStripMenuItem.Enabled =false ;
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            fullServerMoodToolStripMenuItem.Enabled = false;
        }             
    }
}
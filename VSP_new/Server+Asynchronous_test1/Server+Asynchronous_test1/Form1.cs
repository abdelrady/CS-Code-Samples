using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Network.Server;
using System.Collections;
using System.Net.Sockets;
using System.Diagnostics;

namespace Server_Asynchronous_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ClientLists = new ArrayList();
        Network.Server.Server Server;
        private void button1_Click(object sender, EventArgs e)
        {
            Server = new Server();
            Server.DataReceived += new Server.SocketDataArg(Server_DataReceived);
            Server.ErrorCatched += new Server.SocketErrorArg(Server_ErrorCatched);
            Server.ServerListening += new Server.ServerListeningArg(Server_ServerListening);
            Server.StartServer(8080, true);
            Server.SocketConnected += new Server.SocketConnectedArg(Server_SocketConnected);
            Server.SocketDisconnected += new Server.SocketDisconnectArg(Server_SocketDisconnected);

        }

        void Server_SocketDisconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            //throw new Exception("The method or operation is not implemented.");
            lock (this)
            {
                ClientLists.Remove(sde.SocketID);
                foreach (ListViewItem i in listView1.Items)
                {
                    if(i.Text==sde.RemoteIP)
                    listView1.Items.Remove(i);
                }
                richTextBox1.Text += "\r\nClient Disconnected: " + sde.RemoteIP;
            }
        }

        void Server_SocketConnected(object Sender, SocketConnectedEventsArg sce)
        {
            lock (this)
            {
                ClientLists.Add(sce.SocketID);
                this.Text = "Number Of Clients: " + sce.ClientCount.ToString();
                listView1.Items.Add(sce.RemoteIP, 0);
                byte[] data=new byte[10240];
                for(int i=0;i<10240;i++)
                {
                    data[i]=(byte)(i%255);
                }

                Server.SendMessage(sce.SocketID,data);
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        void Server_ServerListening(object Sender, ServerListeningEventsArg sle)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void Server_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            lock (this)
            {
                richTextBox1.Text += "\r\nError Occured: " + see.Message;
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        void Server_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            lock (this)
            {
                richTextBox1.Text +="\r\n"+ sde.SocketID.ToString() + " Say: " + Encoding.Default.GetString(sde.Data).TrimEnd(new char[]{(char)0});
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server.StartServer(8080, false);
            listView1.Items.Clear();
            ClientLists.Clear();
            //TcpClient tcp = new TcpClient();
            //new TcpListener(8080).Pending();
            //Process.GetCurrentProcess().Kill()
        }
        
    }
}
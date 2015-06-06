// Fig. 22.1: Server.cs
// Set up a Server that will receive a connection from a client,
// send a string to the client, and close the connection.

using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ChatServer
{
    public partial class  Server : System.Windows.Forms.Form
    {
        private ArrayList connection = new ArrayList();
        private Thread readThread;
        private ArrayList Clients = new ArrayList();
        private LinkedList<Client_Interface> ClientList = new LinkedList<Client_Interface>();
        private TcpListener listener;
        private int counter = -1;     
        public Server()
        {
            InitializeComponent();
         
        }
        protected void Server_Closing(object sender, CancelEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

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
                     * Amazing trick by --**Eagle**-- 
                     * 
                     * 1-Adding new node to the linked list
                     * 2-passing the accepted socket to it's constructor
                     * 3-wentmashee Ya 3m El 7g
                     */
                    
                    ClientList.AddFirst(new Client_Interface(listener.AcceptSocket(), ++counter));

                    //process this connection in anew thread

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

        /*Gets Data sent by Clienst*/
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
                    LogTXT.AppendText("\nClient# " + Current.M_Key.ToString() + ":" + Current.M_Reader.ReadString());
            }
            catch (Exception e)
            {

                /*this means that this client was closed and it vars 
                needed to be cleaned also reduce the counter of clients */

                MessageBox.Show(
                    /*e.ToString()+*/ "Client " + Current.M_Key.ToString() + " Had Disconnected ",
                    "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Current.Finilize();
                ClientList.Remove(Current);

            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Client_Interface Client in ClientList)
                {
                    Client.M_Writer.Write("SERVER: " + MessageTXT.Text);
                }
                LogTXT.AppendText("\nSERVER: " + MessageTXT.Text);
                MessageTXT.Focus();
                SendBTN.Enabled = false;

            }
            catch (SocketException)
            {
                LogTXT.AppendText( "\nError writing object");
            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            // create a new thread from the server
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();           
            ConnectBTN.Enabled = false;
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
            if (MessageTXT.Text.Length == 0)
                SendBTN.Enabled = false;
            else
                SendBTN.Enabled = true;
        }
    }
}
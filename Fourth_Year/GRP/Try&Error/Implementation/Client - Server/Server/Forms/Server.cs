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
using System.Data.SqlClient;
using System.Data;

namespace ChatServer
{
    public partial class Server : System.Windows.Forms.Form
    {
        private ArrayList connection = new ArrayList();
        private Thread readThread;
        private ArrayList Clients = new ArrayList();
        private LinkedList<Client_Interface> ClientList = new LinkedList<Client_Interface>();
        private TcpListener listener;
        private int counter = -1;
     
        private string passed_barcode_from_Remote_host;
        private Client_Interface current_To_Send; 

        private SqlConnection Server_db_connection;
        private Database_Adminstration.DBUtility ServerUtil = new Database_Adminstration.DBUtility();

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
                     * Amazing trick by --**Eagles**-- 
                     * 
                     * 1-Adding new node to the linked list
                     * 2-passing the accepted socket to it's constructor
                     * 3-wentmashee Ya 3m El 7g
                     */

                    ClientList.AddFirst(new Client_Interface(listener.AcceptSocket(), ++counter));
                    //process this connection in a new thread
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
                {
                    /*
                     * those are special vars that is used for 
                     * the current operating client
                     */
                    passed_barcode_from_Remote_host = Current.M_Reader.ReadString();
                    current_To_Send = Current;

                    /*
                     * append the log
                     */
                    LogTXT.AppendText("\nDoor# " + Current.M_Key.ToString() + ":" + passed_barcode_from_Remote_host);

                    /*
                     * it is responsable for getting data and send it to the remote door
                     * but it's in thread so that appliaction must continue reading 
                     * from the transport connection 
                     */
                    new Thread(new ThreadStart(Retreive_Data)).Start();
                }
            }
            catch (Exception e)
            {

                /*this means that this client was closed and it vars 
                needed to be cleaned also reduce the counter of clients */

                MessageBox.Show(e.ToString() + "\n\rClient " + Current.M_Key.ToString() + " Had Disconnected ",
                    "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Current.Finilize();
                ClientList.Remove(Current);

            }
        }
        private void Retreive_Data()
        {
            try
            {
                DataRow Data = ServerUtil.GetRow("SELECT userfName,userlName,userValid,userEmail,userPhone,userDescription,userStage FROM Users WHERE userID='" + passed_barcode_from_Remote_host + "'", Server_db_connection);
                Seriallized_User user = new Seriallized_User(Data);
                current_To_Send.M_Writer.Write("#USERDATA#");
                current_To_Send.M_Writer.Write(user.Seriallze().Length);
                current_To_Send.M_Writer.Write(user.Seriallze());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString() ,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void SendBTN_Click(object sender, EventArgs e)
        {
            MessageTXT.Clear();
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
                LogTXT.AppendText("\nError writing object");
            }
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {         
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();

            networkStatus.Text = "Online";
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

        private void ConnectToDB_Click(object sender, EventArgs e)
        {
            Server_db_connection = ServerUtil.ConnectToSQL();
          
            dbStatus.Text = "Connected To Database";
            ConnectToDB.Enabled = false;

        }

        private void connectToBoth_Click(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();           
            Server_db_connection = ServerUtil.ConnectToSQL();          

            dbStatus.Text = "Connected To Database";
            networkStatus.Text = "Online";
            ConnectBTN.Enabled = false;
            connectToBoth.Enabled = false;
            ConnectToDB.Enabled = false;

        }        
    }
}
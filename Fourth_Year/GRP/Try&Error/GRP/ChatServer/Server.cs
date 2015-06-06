// Fig. 22.1: Server.cs
// Set up a Server that will receive a connection from a client,
// send a string to the client, and close the connection.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ChatServer
{
    // server that awaits client connections (one at a time) and
    // allows a conversation between client and server
    public class Server : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox displayTextBox;
        private ArrayList connection = new ArrayList();
        private Thread readThread;

        private System.ComponentModel.Container components = null;
        private ArrayList socketStream = new ArrayList();
        private ArrayList writer = new ArrayList();
        private ArrayList reader = new ArrayList();
        int counter = 0;

        // default constructor
        public Server()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();



            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            // create a new thread from the server
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(8, 40);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(272, 208);
            this.displayTextBox.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(8, 8);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(272, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // Server
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Server";
            this.Text = "Server";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.Run(new Server());
        }

        protected void Server_Closing(
           object sender, CancelEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        // sends the text typed at the server to the client
        protected void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // sends the text to the client
            try
            {
                if (e.KeyCode == Keys.Enter && connection != null)
                {
                    for (int i = 0; i < writer.Count; i++)
                    {
                        ((BinaryWriter)writer[i]).Write("SERVER>>> " + inputTextBox.Text);
                    }
                    displayTextBox.Text += "\r\nSERVER>>> " + inputTextBox.Text;

                    // if the user at the server signaled termination
                    // sever the connection to the client              

                    inputTextBox.Clear();
                }
            }
            catch (SocketException)
            {
                displayTextBox.Text += "\nError writing object";
            }
        }

        // allows a client to connect and displays the text it sends
        public void RunServer()
        {
            TcpListener listener;


            // wait for a client connection and display the text
            // that the client sends
            try
            {
                // Step 1: create TcpListener
                listener = new TcpListener(50000);

                // Step 2: TcpListener waits for connection request
                listener.Start();

                // Step 3: establish connection upon client request
                while (true)
                {
                    displayTextBox.Text = "Waiting for connection\r\n";

                    // accept an incoming connection
                    connection.Add(listener.AcceptSocket());

                    new Thread(new ThreadStart(GetStreams)).Start();//process it 

                    displayTextBox.AppendText("connection " + counter.ToString() + " received\r\n");
                    // create NetworkStream object associated with socket
                    ++counter;
                }

                inputTextBox.ReadOnly = true;
                for (int i = 0; i < writer.Count; i++)
                {
                   ((BinaryWriter)writer[i]).Close();
                   ((BinaryReader)writer[i]).Close(); 
                   ((NetworkStream)socketStream[i]).Close();               
                }

            }
            // end try

            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void GetStreams()
        {
            int localCount = counter; //copy global counter to this thread
            socketStream.Add(new NetworkStream(((Socket)connection[localCount])));
            reader.Add(new BinaryReader((NetworkStream)socketStream[localCount]));
            writer.Add(new BinaryWriter((NetworkStream)socketStream[localCount]));
            ((BinaryWriter)writer[localCount]).Write("test send text to client succeeded");

            try
            {
                while (true)
                    displayTextBox.Text = ((BinaryReader)reader[localCount]).ReadString();
            }
            catch 
            {
                socketStream[localCount] = null; 
                reader[localCount] = null;
                writer[localCount] = null; 
            };

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        } // end method RunServer

    } // end class Server
}
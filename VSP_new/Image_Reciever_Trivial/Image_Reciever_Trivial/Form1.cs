using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Image_Reciever_Trivial
{
    public partial class Form1 : Form
    {

        TcpListener mytcpl; // Declare TCP Listener
        Socket mysocket; // Declare an Object from Socket Class
        NetworkStream myns; // 
        StreamReader mysr;
        public Form1()
        {
            InitializeComponent();
        }
        void Image_Receiver(object st)
        {
            mytcpl = new TcpListener(5000);// Open The Port
            mytcpl.Start();// Start Listening on That Port
            mysocket = mytcpl.AcceptSocket();// Accept Any Request From Client and Start The Session
            myns = new NetworkStream(mysocket);// Receive The Binary Data From Port
            pictureBox1.Image = Image.FromStream(myns); // Show The Image that Resaved as Binary Stream
            mytcpl.Stop();// Close TCP Session
            if (mysocket.Connected == true)//if Connected Start Again
            {
                while (true)
                {
                    Image_Receiver(null);// Back to First Method
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(Image_Receiver)).Start(null);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
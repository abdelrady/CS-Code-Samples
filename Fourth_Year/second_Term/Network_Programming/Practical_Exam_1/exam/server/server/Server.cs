using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IPAddress ip = IPAddress.Any;
            //IPEndPoint ipe = new IPEndPoint(ip, 0);
            //Console.WriteLine( ipe.Serialize().ToString());
            
            IPEndPoint ie=new IPEndPoint(IPAddress.Any,5050);
           
            Socket serv = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        
               serv.Bind(ie);
            serv.Listen(5);
           // Thread th=new Thread (new ThreadStart ());
             
                ThreadPool.QueueUserWorkItem(new WaitCallback(connect), serv);
                // th.Start();
         
            //ThreadPool.QueueUserWorkItem(new WaitCallback(connect), serv);
            /*
            Socket clin=  serv.Accept();
            NetworkStream ns = new NetworkStream(clin);
            Image im = Image.FromStream(ns);
            pictureBox1.Image = im;
            */
            

        }
        void connect(object server)
        {
            while (true)
            {
                Socket serv = (Socket)server;
                Socket clin = serv.Accept();
                NetworkStream ns = new NetworkStream(clin);
                Image im = Image.FromStream(ns);
                this.Text = clin.RemoteEndPoint.ToString();
                pictureBox1.Image = im;

                clin.Close();
            }
             
        }
    }
}
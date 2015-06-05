using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Test_server_Monitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpListener server = new TcpListener(8000);
        private void Form1_Load(object sender, EventArgs e)
        {
            server.Start();
            
        }
        void Accept(object state)
        {
            TcpClient client = state as TcpClient;
            BinaryReader br = new BinaryReader(client.GetStream());
            int i=0;
            while ((i++) < 10000)
            {
                string str = br.ReadString();
                lock (this)
                {
                    this.pictureBox1.Image = Image.FromStream(new MemoryStream(Encoding.Default.GetBytes(str)));
                }
            }
            br.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(Accept)).Start(server.AcceptTcpClient());
        }
    }
}
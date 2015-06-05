using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Test_Client_Monitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Run)).Start();
            
        }
        void Run()
        {
            client= new TcpClient(this.textBox1.Text, 8000);
            int i=0;
            BinaryWriter bw = new BinaryWriter(client.GetStream());
            while ((i++) < 10000)
            {
                 bw.Write(Encoding.Default.GetString(SmartDoor.DesktopImage.GetDesktopImage(15)));
            }
            bw.Close();
        }
    }
}
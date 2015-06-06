using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            pictureBox1.Image = Image.FromFile(open.FileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect("127.0.0.1", 5050);
            this.Text = client.Connected.ToString();
            NetworkStream ns = new NetworkStream(client);
            pictureBox1.Image.Save(ns, System.Drawing.Imaging.ImageFormat.Jpeg);
           // ns.Flush();
           
            client.Close();
            ns.Close();

        }
    }
}
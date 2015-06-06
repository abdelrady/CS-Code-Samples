using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace PicClient
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
            client= new TcpClient();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select valid Image");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            if (!client.Connected)
            {
                try
                {
                    client.Connect("127.0.0.1", 5000);
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't Connect to local server");
                    return;
                }
            }
            if(pictureBox1.Image==null)
            {
                MessageBox.Show("Select image first");
                return;
            }
            NetworkStream ns = client.GetStream();
            formatter.Serialize(ns, pictureBox1.Image);
        }

       
    }
}
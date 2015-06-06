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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpListener server = new TcpListener(8080);
        private void button1_Click(object sender, EventArgs e)
        {
            server.Start();
            new Thread(new ThreadStart(Accept)).Start();
        }
        void Accept()
        {
            while (true)
            {
                new Thread(new ParameterizedThreadStart(Run)).Start(server.AcceptTcpClient());
            }
        }
        void Run(object param)
        {
            TcpClient client = param as TcpClient;
            lock (this) { this.Text = client.Client.RemoteEndPoint.ToString(); }

            while (true)
            {
                
                //try
                {
                    NetworkStream ns = client.GetStream();
                    //IFormatter format=new BinaryFormatter();
                    //Image img = (Image)format.Deserialize(ns); //Image.FromStream(ms);//new MemoryStream(Encoding.Default.GetBytes(/*new BinaryReader(client.GetStream()).ReadString()))*/ sr.ReadToEnd())));
                    BinaryReader br=new BinaryReader(client.GetStream(),Encoding.Default);
                    string sst = br.ReadString();
                    MessageBox.Show(sst.Length.ToString());
                    byte[] data=Encoding.Default.GetBytes(sst);
                    
                    MemoryStream ms=new MemoryStream();
                    ms.Write(data,0,data.Length);
                    File.WriteAllBytes("E:\\server.jpg", data);
                    Image img = Image.FromStream(ms);
                    lock (this)
                    {
                        pictureBox1.Image = img;
                    }
                    Thread.Sleep(5);
                }
                //catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
            
        }
    }
}
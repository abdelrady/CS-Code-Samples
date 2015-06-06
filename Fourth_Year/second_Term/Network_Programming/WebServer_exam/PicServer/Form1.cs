using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
namespace PicServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        Thread thrAccept;
        public Form1()
        {
            InitializeComponent();
            listener = new TcpListener(5000);
            listener.Start();
            thrAccept = new Thread(new ThreadStart(AcceptConnections));
            thrAccept.IsBackground = true;
            thrAccept.Start();
        }
        private void AcceptConnections()
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(new WaitCallback(HandleConnection), client);
            }
        }
        private void HandleConnection(object ob)
        {
            TcpClient client = (TcpClient)ob;
            NetworkStream ns = client.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {//accept multiple images from client
                while (true)
                {
                    Image im = (Image)formatter.Deserialize(ns);
                    pictureBox1.Invoke(new ChangeData(ChangePic), new object[] { im });
                }
            }
            catch (Exception e)
            { }
        }
        public delegate void ChangeData(object o);
        private void ChangePic(object o)
        {
            pictureBox1.Image = (Image)o;
        }
    }
}
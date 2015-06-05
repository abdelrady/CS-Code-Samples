using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading;
using System.Net.Sockets;
using System.Collections;

namespace client_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thdListener = new Thread(new ThreadStart(listenerThread));
            thdListener.Start();
        }
        public void listenerThread()
        {
            byte[] buff = new byte[1025];
            string str = "";
            System.Net.IPAddress ip = new System.Net.IPAddress(0x100007f);
            System.Net.IPEndPoint ip2 = new System.Net.IPEndPoint(ip, 8080);
            MessageBox.Show(ip.ToString());
            TcpClient clnt = new TcpClient(ip2);
            /*NetworkStream networkStream = clnt.GetStream();
            networkStream.Read(buff, 0, 1024);
            str = Encoding.ASCII.GetString(buff);
            if (str.Contains("LogOFF"))
                MessageBox.Show("sys will now logoff");
            //MessageBox.Show(str);
            clnt.Close();*/
        
        }

    }
}
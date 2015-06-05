using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void Form1_Load(object sender, EventArgs e)
        {
            server.Bind(new IPEndPoint(IPAddress.Any, 8080));
            server.Listen(1000);
            new Thread(new ParameterizedThreadStart(Accept)).Start(server);
        }
        void Accept()
        {

        }
    }
}
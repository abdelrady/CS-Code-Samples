using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace smtp_server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thdSMTPServer = new Thread(new
ThreadStart(serverThread));
            thdSMTPServer.Start();
        }
        public void serverThread()
{
Byte[] sendBytes;
TcpListener tcpListener = new TcpListener(25);
tcpListener.Start();
while(true)
{
Socket handlerSocket = tcpListener.AcceptSocket();
if (handlerSocket.Connected)
{
// Reply 250 hello
sendBytes = Encoding.ASCII.GetBytes("250 hello\n");
handlerSocket.Send(sendBytes,0,
sendBytes.Length,SocketFlags.None);
// Wait for enter (hello)
tbStatus.Text += socketReadLine(handlerSocket,"\n");
// Reply 250 ok
sendBytes = Encoding.ASCII.GetBytes("250 ok\n");
handlerSocket.Send(sendBytes,0,
sendBytes.Length,SocketFlags.None);
// Wait for enter (mail from)
tbStatus.Text += socketReadLine(handlerSocket,"\n");
// Reply 250 ok
sendBytes = Encoding.ASCII.GetBytes("250 ok\n");
handlerSocket.Send(sendBytes,0,
sendBytes.Length,SocketFlags.None);
// Wait for enter (rcpt to)
tbStatus.Text += socketReadLine(handlerSocket,"\n");
// Reply 250 ok
sendBytes = Encoding.ASCII.GetBytes("250 ok\n");
handlerSocket.Send(sendBytes,0,
sendBytes.Length,SocketFlags.None);
// Wait for enter (data)
tbStatus.Text += socketReadLine(handlerSocket,"\n");
// Reply 354
sendBytes = Encoding.ASCII.GetBytes("354 proceed\n");
handlerSocket.Send(sendBytes,0,
sendBytes.Length,SocketFlags.None);
// Wait for enter.enter (email body)
tbStatus.Text += socketReadLine(handlerSocket,
"\r\n\r\n");
// Reply 221 close
sendBytes = Encoding.ASCII.GetBytes("221 close\n");
handlerSocket.Send(sendBytes, 0,
sendBytes.Length, SocketFlags.None);
handlerSocket.Close();
}
}
}
        public String socketReadLine(Socket socket,String terminator)
{
int lastRead=0;
String streamData = "";
NetworkStream networkStream = new NetworkStream(socket);
do
{
    lastRead = networkStream.ReadByte();
    if (lastRead == -1) break;
    streamData += (Convert.ToChar(lastRead));
    if (streamData.EndsWith(terminator)) break;
}
while (true);
return streamData;
}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
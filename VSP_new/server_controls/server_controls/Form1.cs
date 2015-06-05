using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Collections;

namespace server_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList alSockets;
        private void Form1_Load(object sender, EventArgs e)
        {
            alSockets = new ArrayList();
            Thread thdListener = new Thread(new
ThreadStart(listenerThread));
            thdListener.Start();
        }
        
public void listenerThread()
{
    //long ipl=
    //System.Net.IPAddress ip = new System.Net.IPAddress(ipl);
TcpListener tcpListener = new TcpListener(new System.Net.IPAddress (0x100007f), 8080);
tcpListener.Start();

Socket handlerSocket = tcpListener.AcceptSocket();
if (handlerSocket.Connected)
{
    MessageBox.Show(handlerSocket.RemoteEndPoint.ToString());
alSockets.Add(handlerSocket);
ThreadStart thdstHandler = new ThreadStart(handlerThread);
Thread thdHandler = new Thread(thdstHandler);
thdHandler.Start();
    
   

}
}

public void handlerThread()
{
Socket handlerSocket = (Socket)alSockets[0/*alSockets.Count-1*/];
NetworkStream networkStream = new NetworkStream(handlerSocket);
    //handlerSocket.Send(buff,SocketFlags.None);
//int thisRead=0;
int blockSize=1024;
Byte[] dataByte = new Byte[blockSize];
string str = "LogOFF";
dataByte =Encoding.ASCII.GetBytes(str);
lock(this)
{
    handlerSocket.Send(dataByte, SocketFlags.None);
//networkStream.Write(dataByte,0,blockSize);
}
handlerSocket = null;
}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
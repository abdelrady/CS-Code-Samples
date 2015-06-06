using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace BroadCast_Sender1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IPAddress.Broadcast.ToString());
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(Dns.GetHostByName("fcis").AddressList[0], 9060);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 9050);
            UdpClient udp = new UdpClient(iep);
            //sock.Bind(new IPEndPoint(IPAddress.Parse( "192.168.2.1"), 1500));
            //sock.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.Broadcast,1);
            byte[] test=new byte[1024];
            //Encoding.Default.GetBytes("broadcasting....",0,10,test,0);
            //sock.SendTo(test, iep);
            Encoding.Default.GetBytes("broadcasting ip2....", 0, 17, test, 0);
            //udp.Connect(iep2);
            udp.Send(test,17,iep2);
            
            udp.Close();

        }
    }
}

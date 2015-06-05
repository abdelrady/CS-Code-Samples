using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Receiving_Multicast_Packets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IPAddress.Broadcast.ToString());
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            //IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("192.168.2.255"), 9050);
            sock.Bind(iep);
            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership,new MulticastOption(IPAddress.Parse("224.100.0.1")));

            byte[] test = new byte[1024];
            EndPoint ep = (EndPoint)iep;
            int x=sock.ReceiveFrom(test, ref ep);
            Console.WriteLine(Encoding.Default.GetString(test, 0, x).TrimEnd(new char[] { (char)(0) }));
        }
    }
}

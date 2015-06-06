using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace BroadCast_reciever1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.1"), 9050);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Any,0);
            //sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.Bind(iep);
            EndPoint ep=(EndPoint)iep;
            byte[] test=new byte[1024];
            int x= sock.ReceiveFrom(test, ref ep);
            string stringData = Encoding.ASCII.GetString(test,0,x);
            stringData = stringData.TrimEnd(new char[] { (char)(0) });
            Console.WriteLine("received: {0} from: {1} with Length={2}", stringData, iep2.ToString(), x.ToString());

            x = sock.ReceiveFrom(test, ref ep);
            stringData = Encoding.ASCII.GetString(test, 0, x);
            stringData = stringData.TrimEnd(new char[] { (char)(0) });
            Console.WriteLine("received: {0} from: {1} with Length={2}", stringData, iep2.ToString(),x.ToString());



        }
    }
}

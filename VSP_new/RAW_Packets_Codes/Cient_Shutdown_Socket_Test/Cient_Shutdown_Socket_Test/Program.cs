using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Cient_Shutdown_Socket_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(new IPEndPoint(IPAddress.Parse("192.168.2.4"),8090));
            Console.WriteLine(sock.RemoteEndPoint.ToString());

            sock.Shutdown(SocketShutdown.Receive);
            byte[] data = Encoding.Default.GetBytes("GET / HTTP/1.0\r\n\r\n");
            sock.Send(data);
            //byte[] rcvData = new byte[1024];
            //int x = sock.Receive(rcvData);
            //Console.WriteLine("Bytes Recieved: " + x.ToString());
            Console.ReadLine();
        }
    }
}

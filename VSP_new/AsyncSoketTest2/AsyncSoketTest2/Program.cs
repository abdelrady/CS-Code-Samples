using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace AsyncSoketTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IPAddress.Any.ToString());

            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
            sock.Listen(10);
            Console.WriteLine(sock.Accept().RemoteEndPoint.ToString());
        }
    }
}

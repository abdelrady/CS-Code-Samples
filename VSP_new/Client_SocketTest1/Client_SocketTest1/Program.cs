using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Client_SocketTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //while (i++ < 10)
            {
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
                Console.WriteLine(sock.Connected);
                sock.Send(Encoding.Default.GetBytes("Hi Server...."));
                sock.Close();
            }
            GC.Collect();
        }
    }
}

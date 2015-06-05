using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace Server_Client_BinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(1000);
            server.Start();
            TcpClient client = server.AcceptTcpClient();
            Console.ReadLine();
        }
    }
}

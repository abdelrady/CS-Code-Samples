using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace UdpClient_Helper_Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient("127.0.0.1", 9050);
            client.Send(Encoding.Default.GetBytes("Welcome Server"), Encoding.Default.GetBytes("Welcome Server").Length);
            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine(Encoding.Default.GetString(client.Receive(ref remote)));
            Console.WriteLine(remote.ToString());
        }
    }
}

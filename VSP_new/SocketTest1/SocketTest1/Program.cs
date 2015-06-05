using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace SocketTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soc.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
            Console.WriteLine(soc.Connected+" "+((IPEndPoint)soc.LocalEndPoint).Port+" ");
            soc.Listen(5);
            while (true)
            {
                Socket newsock = soc.Accept();
                Console.WriteLine(newsock.RemoteEndPoint);
                byte[] byt=new byte[1024];
                Console.WriteLine(newsock.Receive(byt));
                string str = Encoding.Default.GetString(byt).Replace(" ", string.Empty);
                Console.WriteLine("|"+str+"|");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("localhost", 80);
            StreamWriter w = new StreamWriter(client.GetStream());
            StreamReader reader = new StreamReader(client.GetStream());
            w.WriteLine("GET /\r\n");
            w.Flush();
            string res = reader.ReadToEnd();
            client.Close();
        }
    }
}

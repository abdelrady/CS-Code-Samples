using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient cl = new TcpClient("192.168.2.5", 80);
            StreamWriter sw = new StreamWriter(cl.GetStream());
            StreamReader sr = new StreamReader(cl.GetStream());
            sw.WriteLine("GET /a.htm HTTP/1.0");
            sw.WriteLine("Connection:Close");
            sw.WriteLine();
            sw.Flush();
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}

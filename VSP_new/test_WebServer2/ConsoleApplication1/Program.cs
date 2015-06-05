using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener c = new TcpListener(8080);
            c.Start();
            TcpClient cl = c.AcceptTcpClient();
            StreamReader br = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            string str="";
            int x=0;
            //Console.WriteLine((br.Read());
  while (true)
            {
                Console.Write(((char)br.Read()).ToString());
            }
            sw.WriteLine("HTTP/1.1 200 OK");
            sw.WriteLine();
            sw.WriteLine("Welcome Ali");
            sw.WriteLine();
            sw.Close();

        }
    }
}

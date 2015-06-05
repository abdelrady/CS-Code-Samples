using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace WebServer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8080);
            server.Start();
            while (true)
            {
                new Thread(new ParameterizedThreadStart(Send)).Start(server.AcceptTcpClient());

            }
        }
        static void Send(object state)
        {
            TcpClient client = (TcpClient)state;
            Console.WriteLine(client.Client.RemoteEndPoint.ToString());
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            string dataIn, DataOut;
            dataIn= sr.ReadLine();
            //sr.ReadToEnd();
            if (dataIn.Split()[0] == "GET")
            {
                
                sw.WriteLine("HTTP/1.0 200 OK");
                sw.WriteLine();
                sw.WriteLine("<div  style=align:center;><h1><font color=red>Hello World???????!!!!!!!</font></h1></div><img src=\"" + Directory.GetCurrentDirectory() + "\\img3gray.bmp\" />");
                sw.Close();
                sr.Close();
            }
            else
            {
                sw.WriteLine("HTTP/1.0 500 NOT IMPLEMENTED");
                sw.Close(); sr.Close();
            }
        }
    }
}

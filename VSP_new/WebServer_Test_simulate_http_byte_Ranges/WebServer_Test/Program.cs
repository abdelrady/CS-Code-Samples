using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WebServer_Test
{
    class Program
    {
        static AutoResetEvent arr = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(80);
            server.Start();
            TcpClient client;
            //Thread th = new Thread(new ParameterizedThreadStart(RUN));
            while (true)
            {
                client = server.AcceptTcpClient();
                //new Thread(new ParameterizedThreadStart(RUN)).Start(client);
                RUN(client);
                //break;
            }
            arr.WaitOne();
        }
        static void RUN(object state)
        {
            TcpClient client = state as TcpClient;

            StreamReader sr = new StreamReader(client.GetStream());
            BinaryWriter sw = new BinaryWriter(client.GetStream());
            string data = "";
            string dataToSend = "Welcome Back";
            int cut = 0;
            string res = "HTTP/1.1 206 Partial Content\r\nContent-Type: video/x-msvideo\r\nContent-Length: ";

            

            while ((data = sr.ReadLine()) != "")
            {
                
                lock (state)
                {
                    Console.WriteLine(data);
                }
                if (data.StartsWith("Range:"))
                {
                    int start1 = data.LastIndexOf("bytes");
                    int end = data.IndexOf("\r\n", start1);
                    Console.WriteLine("Str: " + start1.ToString() + " ,end: " + end.ToString());
                    string bteRange = data.Substring(start1 + 6/*, end - start1 - 6*/);
                    Console.WriteLine("byte Range : [" + bteRange+"]");
                    //int start = data.IndexOf("-", data.LastIndexOf("bytes"));
                    string[] vals = bteRange.Split(new char[] { '-' }, 2);
                    cut = int.Parse(vals[1]) - int.Parse(vals[0]);
                    res += cut+"\r\n\r\n";
                }
            }
            //string cut = data.Substring(start, end - start);
            Console.WriteLine("num of bytes: " + cut);
            byte[] resbyte = Encoding.Default.GetBytes(res);
            byte[] bb = new byte[cut+res.Length];
            Encoding.Default.GetBytes(res, 0, res.Length, bb, 0);
            sw.Write(bb);
            sw.Flush();    
            //sw.BaseStream.WriteLine("HTTP/1.1 200 OK");
            //sw.BaseStream.WriteLine("Content-Length:" + dataToSend.Length.ToString());
            //sw.BaseStream.WriteLine();
            //sw.WriteLine(dataToSend);
            //sw.WriteLine();
            sw.Close();
            sr.Close();
        }
    }
}

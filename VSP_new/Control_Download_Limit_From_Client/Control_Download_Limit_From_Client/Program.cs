using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Control_Download_Limit_From_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient cl = new TcpClient("192.168.2.5", 8000);
            //cl.Connect();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());

            sw.Write("GET /gamil.wmv HTTP/1.0\r\n");
            sw.Write("\r\n");
            sw.Write("\r\n");
            sw.Flush();

            sr.ReadLine();
            sr.ReadLine();
            while (true)
            {
                if (Console.ReadLine() == "t")
                {
                    int xx=sr.Peek() ;
                    Console.WriteLine((xx>1024?(xx/ 1024):xx).ToString());
                }
                char[] data =new char[1500];
                int xy = sr.ReadBlock(data, 0, data.Length);
                Console.WriteLine("Data Length: "+xy.ToString());
                //Thread.Sleep(1000);
            }
            //«я ‘Ё  «д «б№tcp stack » ” бг дн«»… Џд «б Ў»нё жбяд бЏѕѕ гЌѕжѕ гд «б»«н ” жеж Ќћг «бжндѕж «бн «д н’б «бн ’Ё— ж«бг—”б г‘ ен»Џ   «дн
        }
    }
}

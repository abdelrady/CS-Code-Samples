using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            client.Connect("fcis", 1000);
            Console.WriteLine("Connected");
            try
            {
                string str = new BinaryReader(client.GetStream()).ReadString();
               
            }
            catch (SocketException ex){ Console.WriteLine(ex.ErrorCode.ToString()+" "+ex.Message); }
            catch (IOException exx) { Console.WriteLine(exx.Message); client.Close(); }
            //if (str == null)
            //{
            //    Console.WriteLine("Null");
            //}
            //else Console.WriteLine(str);
        }
    }
}

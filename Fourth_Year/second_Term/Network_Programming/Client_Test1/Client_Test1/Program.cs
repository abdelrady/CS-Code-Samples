using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Client_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Console.WriteLine(Dns.Resolve("youtube.com").AddressList[0]);
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(new IPEndPoint(IPAddress.Parse("192.168.2.1"),8080));
            string data;
            byte[] dataRecieved = new byte[1024];
            byte[] dataSended = new byte[1024];
            //int count = 0;

            for (int i = 1; i < 10000; i*=10)
            {
                string dataStr="welcome1" + (i.ToString());
                dataSended = Encoding.Default.GetBytes(dataStr);
                byte[] count = BitConverter.GetBytes(dataStr.Length);

                int x = sock.Send(count);
                x = sock.Send(dataSended);
                Console.WriteLine(x.ToString());
            }
            //count = sock.Receive(dataRecieved);
            //Console.WriteLine(Encoding.Default.GetString(dataRecieved, 0, count));
            //count = sock.Send(new byte[] { });
            //Console.WriteLine(count);
            /*while (true)
            {
                data = Console.ReadLine();
                dataSended = Encoding.Default.GetBytes(data);
                int x=sock.Send(dataSended);
                Console.WriteLine(x.ToString());
                count = sock.Receive(dataRecieved);
                Console.Write(Encoding.Default.GetString(dataRecieved, 0, count));
            }
             *
             */
            //sock.Shutdown(SocketShutdown.Both);
            //sock.Close();
            /*
            byte[] byt=new byte[102400];
            TcpClient client = new TcpClient("abdelrady.110mb.com", 80);
            int count=client.GetStream().Read(byt, 0, byt.Length);
            Console.WriteLine(Encoding.Default.GetString(byt,0,count));
             */

            TcpClient tcpClient = new TcpClient(new IPEndPoint(IPAddress.Any, 23));
            tcpClient.Connect("192.168.2.1", 80);
            //StreamWriter sw=new StreamWriter( tcpClient.GetStream());
            NetworkStream sw = tcpClient.GetStream();
            byte[] byteData=new byte[1024];
            Encoding.Default.GetBytes("GET /test_Menu.htm HTTP/1.0\r\n\r\n", 0, "GET /test_Menu.htm HTTP/1.0\r\n\r\n".Length, byteData, 0);
            Console.WriteLine(byteData.Length.ToString());
            sw.Write(byteData, 0, 1024);
            sw.Flush();
            StreamReader sr = new StreamReader(sw);
 
            /*int x=1024;
            while (x == 1024)
            {
                x = sw.Read(byteData, 0, 1024);
                Console.WriteLine(Encoding.Default.GetString(byteData, 0, x));
            }*/
            while (sr.ReadLine() != "") ;
            //Console.WriteLine(sr.ReadToEnd());

            Console.WriteLine();
            string s;
            while ((s=sr.ReadLine()) != null)
            {
                Console.Write(s);
            }
            Console.WriteLine();
            Console.WriteLine("#"+sr.ReadLine()+"#");
            

            /*Encoding.Default.GetBytes("welcome2", 0, 8, byteData, 0);
            sw.Write(byteData,0,1024);
            sw.Flush();

            Encoding.Default.GetBytes("welcome3", 0, 8, byteData, 0);
            sw.Write(byteData, 0, 1024);
            sw.Flush();

            Encoding.Default.GetBytes("welcome4", 0, 8, byteData, 0);
            sw.Write(byteData, 0, 1024);
            sw.Flush();

            Encoding.Default.GetBytes("welcome5", 0, 8, byteData, 0);
            sw.Write(byteData, 0, 1024);
            sw.Flush();
            */
            sw.Close();
            tcpClient.Close();
        }
    }
}

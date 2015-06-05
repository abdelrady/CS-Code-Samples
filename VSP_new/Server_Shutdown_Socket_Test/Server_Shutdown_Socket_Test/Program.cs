using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Server_Shutdown_Socket_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind((EndPoint)(new IPEndPoint(IPAddress.Parse("192.168.2.4"), 8090)));
            sock.Listen(1000);
            Socket client = sock.Accept();
            string Data = "Welcome Client Back...";

            try
            {
                Console.WriteLine("Data Sent: " + client.Send(Encoding.Default.GetBytes(Data)));
                Console.WriteLine("Data Sent: " + client.Send(Encoding.Default.GetBytes("kldf pFO UE jf lkj    E")));
                Console.WriteLine("Data Sent: " + client.Send(Encoding.Default.GetBytes("LHS;DG AOP EWORI'T SDJ'pu w;ersg ie' p sdj")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadLine();
            client.Shutdown(SocketShutdown.Send);
            byte[] byt = new byte[1024];
            Console.WriteLine("Data Recieved : " + client.Receive(byt));
            Console.WriteLine(sock.Accept().RemoteEndPoint.ToString());
        }
    }
}

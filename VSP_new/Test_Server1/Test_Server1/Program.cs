using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Test_Server1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(1888);
            server.Start();
            while (true)
            {
                new Thread(new ParameterizedThreadStart(ClientsMethod)).Start(server.AcceptTcpClient());
            }
        }
        static void ClientsMethod(object State)
        {
            TcpClient client = State as TcpClient;
            Console.WriteLine("Connection Accepted: " + client.Client.RemoteEndPoint.ToString());
            return;
            NetworkStream ns = client.GetStream();
            while (true)
            {
                try
                {
                    byte[] byt = new byte[1500];
                    ns.Read(byt, 0, byt.Length);
                    Console.WriteLine(Encoding.Default.GetString(byt).Trim());
                }
                catch (IOException) { Console.WriteLine("Socket "+ ns.ToString() +" Connection Closed."); return; }
            }
        }
    }
}

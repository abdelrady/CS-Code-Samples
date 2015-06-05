using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TcpListener_Pending1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Use the Pending method to poll the underlying socket instance for client connection requests.
                IPAddress ipAddress = Dns.Resolve("localhost").AddressList[0];
                TcpListener tcpListener = new TcpListener(ipAddress, 8080);
                tcpListener.Start();

                while(!tcpListener.Pending())
                {
                    Console.WriteLine("Sorry, no connection requests have arrived");

                    Thread.Sleep(1000);
                }
                {

                    //Accept the pending client connection and return a TcpClient object initialized for communication.
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    // Using the RemoteEndPoint property.
                    Console.WriteLine("I am listening for connections on " +
                                                IPAddress.Parse(((IPEndPoint)tcpListener.LocalEndpoint).Address.ToString()) +
                                                   "on port number " + ((IPEndPoint)tcpListener.LocalEndpoint).Port.ToString());
                }
            }
            catch { }
        }
        
    }
}

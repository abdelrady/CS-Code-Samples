using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Dns_Resolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((8|7).ToString());
            //return;
            IPHostEntry iph = Dns.GetHostEntry("flashembed.xvideos.com");//fcis.no-ip.org");
            Console.WriteLine("Host Name:" + iph.HostName);
            foreach (IPAddress ip in iph.AddressList)
            {
                Console.WriteLine("\tip Address: "+ip.ToString());
            }
            TcpClient cl1 = new TcpClient(iph.HostName, 80);//flashservices/gateway.php
        }
    }
}

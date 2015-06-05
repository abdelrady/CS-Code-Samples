using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;

namespace Test3
{
    class Program
    {
        bool end = false;
        static void Main(string[] args)
        {
            AutoResetEvent auto = new AutoResetEvent(false);
            Dns.BeginGetHostEntry(Dns.GetHostName(),new AsyncCallback(test),auto);
            /*Console.WriteLine(iphs.HostName);
            foreach(IPAddress ip in iphs.AddressList)
            Console.WriteLine(ip.ToString());*/
            auto.WaitOne();
        }
        static void test(IAsyncResult ar)
        {
            IPHostEntry iphs = Dns.EndGetHostEntry(ar);
            Console.WriteLine(iphs.HostName);
            foreach(IPAddress ip in iphs.AddressList)
            Console.WriteLine(ip.ToString());

        ((AutoResetEvent)ar.AsyncState).Set();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Net;

namespace dns_asyncTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            AsyncCallback callback = new AsyncCallback(p.resolved);
             Dns.Resolve("http://www.youtube.com");
             IPHostEntry iphs = Dns.Resolve("http://www.youtube.com");
             foreach (IPAddress ip in iphs.AddressList)
                 Console.WriteLine(ip.ToString());
            Console.ReadLine();
        }
        public void resolved(IAsyncResult ar)
        {
            IPHostEntry iphs= Dns.EndResolve(ar);
            foreach (IPAddress ip in iphs.AddressList)
                Console.WriteLine(ip.ToString());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Remoating_lib;

namespace Remoating_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(8086);
            ChannelServices.RegisterChannel(chan);
            ForwardMe objForwardMe = new ForwardMe();
            HelloServer objHelloServer;

            objHelloServer = (HelloServer)Activator.GetObject(
                    typeof(HelloServer),
                    "tcp://localhost:8085/RemoteTestRef");
            if (objHelloServer == null)
                Console.WriteLine("Could not locate server");
            else
            {
                Console.WriteLine("successfully locate the server");
                objHelloServer.HelloMethod(objForwardMe);
            }
            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();

        }
    }
}

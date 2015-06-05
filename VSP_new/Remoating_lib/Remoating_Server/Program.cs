using System;
using System.Collections.Generic;
using System.Text;
using Remoating_lib;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Remoating_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(8085);
            ChannelServices.RegisterChannel(chan);
            RemotingConfiguration.RegisterWellKnownServiceType(
    Type.GetType("Remoating_lib.HelloServer, Remoating_lib"),
    "RemoteTestRef",
    WellKnownObjectMode.Singleton);
            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();

        }
    }
}

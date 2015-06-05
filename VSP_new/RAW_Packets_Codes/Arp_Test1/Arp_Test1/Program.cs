using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Arp_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Raw);
            MainSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.HeaderIncluded, 1);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.1"), 0);//.Parse("192.168.2.5")//tcp.SRCPort
            MainSocket.Bind(iep);


            ////////////////////////////////////////RECIEVE ALL PACKET ON THIS ADAPTER/////////////////////////////////
            byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
            byte[] byOut = new byte[4] { 1, 0, 0, 0 }; //Capture outgoing packets

            //Socket.IOControl is analogous to the WSAIoctl method of Winsock 2
            MainSocket.IOControl(IOControlCode.ReceiveAll, //Equivalent to SIO_RCVALL constant of Winsock 2
                                 byTrue,
                                 byOut);
            while (true)
            {
                byte[] Data = new byte[1520];
                int x =  MainSocket.Receive(Data);
                Console.WriteLine(Encoding.Default.GetString(Data, 0, x));
            }
        }
    }
}

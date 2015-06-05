using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace RAW_Packets_test2
{
    class Program
    {
        static AutoResetEvent are = new AutoResetEvent(false);
        static Random r = new Random(10);
        static byte[] rcvData = new byte[1500];
        static EndPoint ep = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
        static Socket MainSocket;
        
        static void Main(string[] args)
        {
            MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Udp);
            MainSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.5"), 0);//.Parse("192.168.2.5")//tcp.SRCPort
            MainSocket.Bind(iep);

            ////////////////////////////////////////RECIEVE ALL PACKET ON THIS ADAPTER/////////////////////////////////
            byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
            byte[] byOut = new byte[4] { 1, 0, 0, 0 }; //Capture outgoing packets

            //Socket.IOControl is analogous to the WSAIoctl method of Winsock 2
            MainSocket.IOControl(IOControlCode.ReceiveAll, //Equivalent to SIO_RCVALL constant of Winsock 2
                                 byTrue,
                                 byOut);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Start receiving the packets asynchronously
            //MainSocket.BeginReceive(rcvData, 0, rcvData.Length, SocketFlags.None,
            //    new AsyncCallback(DataRecieved), MainSocket);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            new Thread(new ThreadStart(RecievePackets)).Start();


        }
        static void RecievePackets()
        {
            while (true)
            {
                //IPEndPoint ip=new IPEndPoint(IPAddress.Any,0);
                //EndPoint ep=(EndPoint) ip;
                int res = MainSocket.Receive(rcvData);//, rcvData.Length, SocketFlags.None, ref ep);

                if (res != 0)
                {
                    for(int i = 0 ;i<res;i++)
                    {
                        Console.Write(string.Format("0x{0:x} , ", rcvData[i]));
                        if (i % 16 == 15) Console.WriteLine();
                    }
                }
                else return;
            }
        }
    }
}

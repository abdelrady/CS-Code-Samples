using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace PacketSniffer
{
    class Program
    {
        static Socket MainSocket;
        static AutoResetEvent are = new AutoResetEvent(false);
        static Random r = new Random(10);
        static byte[] rcvData = new byte[4096];
        static bool bContinueCapturing=true;
        static void Main(string[] args)
        {
            MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            MainSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);
            //s.Blocking = false;

            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.5"), 1999);//.Parse("192.168.2.5")//tcp.SRCPort
            MainSocket.Bind(iep);

            ////////////////////////////////////////RECIEVE ALL PACKET ON THIS ADAPTER/////////////////////////////////
            byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
            byte[] byOut = new byte[4] { 1, 0, 0, 0 }; //Capture outgoing packets

            //Socket.IOControl is analogous to the WSAIoctl method of Winsock 2
            MainSocket.IOControl(IOControlCode.ReceiveAll, //Equivalent to SIO_RCVALL constant of Winsock 2
                                 byTrue,
                                 byOut);

            //Start receiving the packets asynchronously
            MainSocket.BeginReceive(rcvData, 0, rcvData.Length, SocketFlags.None,
                new AsyncCallback(DataRecieved), MainSocket);
            are.WaitOne();
           
        }
        static void DataRecieved(IAsyncResult ar)
        {
            try
            {
                int nReceived = MainSocket.EndReceive(ar);

                //Analyze the bytes received...
                //Console.WriteLine(Encoding.Default.GetString(rcvData,0,nReceived));
                ParseIPPacket(rcvData);

                if (bContinueCapturing)
                {
                    rcvData = new byte[4096];

                    //Another call to BeginReceive so that we continue to receive the incoming
                    //packets
                    MainSocket.BeginReceive(rcvData, 0, rcvData.Length, SocketFlags.None,
                        new AsyncCallback(DataRecieved), null);
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "MJsniffer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void ParseIPPacket(byte[] ipPacket)
        {
            //Console.WriteLine(IPAddress.Parse("192.168.2.5").ToString());
            if (ipPacket[9] == 0x06)
                if (BitConverter.ToUInt32(ipPacket, 16) == IPAddress.Parse("192.168.2.5").Address)//dst ip addr
                    if (IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ipPacket, 22)) == 80)
                    {
                        //Console.WriteLine(Encoding.Default.GetString(ipPacket));
                        Console.WriteLine("http get packet found.");
                        //are.Set();
                        IPPacket ipp = new IPPacket();
                        ipp.Dst_Address = new IPAddress(BitConverter.ToUInt32(ipPacket, 12)).ToString();
                        ipp.SRC_Address = new IPAddress(BitConverter.ToUInt32(ipPacket, 16)).ToString();
                        ipp.Protocol = 0x06;
                        TCPPacket tcp = new TCPPacket(ipp);
                        tcp.Data = Encoding.Default.GetBytes("HTTP 200 OK\r\n\r\n<html><body><h1>access to port 80 is denied...</h1></body></html>");
                        tcp.DSTPort = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ipPacket, 20));
                        tcp.SRCPort=IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ipPacket, 22));
                        tcp.URGDataPointer = 0;
                        tcp.ReceiverWindow = 16384;
                        tcp.Options = new byte[0];
                        tcp.Flags = 17;//RST-ACK
                        tcp.HeaderLength = 20;
                        tcp.SEQNumber = BitConverter.ToUInt32(ipPacket, 28);
                        Console.WriteLine("tcp header length: " + ((ipPacket[32] >> 4) * 4));
                        tcp.ACKNumber = (uint)( BitConverter.ToUInt16(ipPacket, 2) - 20 - ((ipPacket[32]>>4)*4)+1);
                        tcp.GenerateTCPPacket();
                        Console.WriteLine("tcp header length: " + ((ipPacket[32] >> 4) * 4));
                        ipp.Data = tcp.Packet;
                        ipp.GenerateIPPacket();
                        Console.WriteLine("tcp header length: " + ((ipPacket[32] >> 4) * 4));
                        MainSocket.BeginSendTo(ipp.Packet,0,ipp.Packet.Length,SocketFlags.None, new IPEndPoint(IPAddress.Parse(ipp.SRC_Address),tcp.SRCPort),new AsyncCallback(DataSent),null);
                    }
        }
        static void DataSent(IAsyncResult ar)
        {
            int x = MainSocket.EndSendTo(ar);
            Console.WriteLine("Packet sent...");
        }

    }
}

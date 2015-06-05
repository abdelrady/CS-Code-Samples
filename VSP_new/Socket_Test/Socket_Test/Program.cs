using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Socket_Test
{
    class ICMP
    {
        public byte Type;
        public byte Code;
        public UInt16 Checksum;
        public int MessageSize;
        public byte[] Message = new byte[102400];
        public ICMP()
        {
        }
        public ICMP(byte[] data, int size)
        {
            Type = data[20];
            Code = data[21];
            Checksum = BitConverter.ToUInt16(data, 22);
            MessageSize = size - 24;
            Buffer.BlockCopy(data, 24, Message, 0, MessageSize);
        }

        public byte[] getBytes()
        {

            byte[] data = new byte[MessageSize + 9];
            Buffer.BlockCopy(BitConverter.GetBytes(Type), 0, data, 0, 1);
            Buffer.BlockCopy(BitConverter.GetBytes(Code), 0, data, 1, 1);
            Buffer.BlockCopy(BitConverter.GetBytes(Checksum), 0, data, 2, 2);
            Buffer.BlockCopy(Message, 0, data, 4, MessageSize);
            return data;

        }

        public UInt16 getChecksum()
        {

            UInt32 chcksm = 0;
            byte[] data = getBytes();
            int packetsize = MessageSize + 8;
            int index = 0;
            while (index < packetsize)
            {
                chcksm += Convert.ToUInt32(BitConverter.ToUInt16(data, index));
                index += 2;
            }
            chcksm = (chcksm >> 16) + (chcksm & 0xffff);
            chcksm += (chcksm >> 16);
            return (UInt16)(~chcksm);

        }
    }
    class Program
    {
        static AutoResetEvent are = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            int recv;
            Socket host = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.3"), 0);
            EndPoint ep = (EndPoint)iep;
            ICMP packet = new ICMP();

            packet.Type = 0x08;
            packet.Code = 0x00;
            packet.Checksum = 0;

            Buffer.BlockCopy(BitConverter.GetBytes((short)1), 0, packet.Message, 0, 1);

            string DataToSent = "Ping Message OK";/*, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK,Ping Message OK, Ping Message OK.....";*/
            Console.WriteLine("Message Length: " + (DataToSent.Length / 1024));
            data = Encoding.ASCII.GetBytes(DataToSent);

            Buffer.BlockCopy(data, 0, packet.Message, 4, data.Length);
            packet.MessageSize = data.Length + 4;
            int packetsize = packet.MessageSize + 4;
            UInt16 chcksum = packet.getChecksum();
            packet.Checksum = chcksum;

            host.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 10000);

            Console.WriteLine("Data to be Sent: " + packetsize);
            byte[] dataToBeSent=packet.getBytes();

            foreach (byte b in dataToBeSent)
            {
                Console.Write(string.Format("0x{0:x} , ",Convert.ToInt16(b)));
            }

            int x= host.SendTo(dataToBeSent, packetsize, SocketFlags.None, iep);
            Console.WriteLine("Data Sent: " + x);

            Thread.Sleep(5000);
            try
            {
                data = new byte[102400];
                recv = host.ReceiveFrom(data, ref ep);
            }
            catch (SocketException so)
            {
                Console.WriteLine("No response from remote host");
                Console.WriteLine(so.Message);
                return;
            }
            ICMP response = new ICMP(data, recv);
            Console.WriteLine("response from: " + ep.ToString());
            Console.WriteLine(" Type: " + response.Type);
            Console.WriteLine(" Code: " + response.Code);
            int Identifier = BitConverter.ToInt16(response.Message, 0);
            int Sequence = BitConverter.ToInt16(response.Message, 2);

            Console.WriteLine(" Identifier: " + Identifier);
            Console.WriteLine(" Sequence: " + Sequence);
            string stringData = Encoding.ASCII.GetString(response.Message, 4, response.MessageSize - 4);
            Console.WriteLine(" data: " + stringData);
            host.Close();


            /*
            Socket s = new Socket(AddressFamily.InterNetwork,SocketType.Raw,ProtocolType.IP);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.3.1"), 0);
            s.Bind(iep);

            byte[] data = {0x45, 0x00, 0x00, 0x30, 0xc8, 0x40, 0x40, 0x00,  0x80,
  0x06, 0x00, 0x00, 0xC0, 0xA8, 0x01, 0x01, 0xC0, 0xA8, 0x01,  0x05,
  0x07, 0xe5, 0x00, 0x17, 0xd3, 0x16, 0x3f, 0xe6, 0x00, 0x00,
  0x00, 0x00, 0x70, 0x02, 0xff, 0xff, 0xe4, 0xcf, 0x00, 0x00,
  0x02, 0x04, 0x05, 0xb4, 0x01, 0x01, 0x04, 0x02};

            Console.WriteLine("Data to be Sent: " + data.Length);

            IPEndPoint fakeIP = new IPEndPoint(IPAddress.Parse("192.168.3.3"), 0);
            s.SetSocketOption(SocketOptionLevel.IP,SocketOptionName.HeaderIncluded, 1);
            
            s.BeginSendTo(data,0, data.Length, SocketFlags.None, fakeIP,new AsyncCallback(DataSent),s);

            are.WaitOne();*/
        }
        /*
        static void DataSent(IAsyncResult ar)
        {
            Console.WriteLine(ar.IsCompleted);
            int x = ((Socket)(ar.AsyncState)).EndSendTo(ar);
            Console.WriteLine("Data Sent: "+x);
            are.Set();
        }*/
    }
}

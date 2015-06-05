using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Change_NetworkLayer_packet_content
{
    public class IPPacket
    {
        public byte IPVer_HL = 0x45;
        public byte TOS = 0x00;
        public byte[] DataGram_Length;
        public byte[] IDentifier ={ 0x98, 0xc5 };

        public byte[] Flags_FragOffset ={ 0x00, 0x00 };
        public byte TTL =0x80;//128
        public byte Protocol = 0x01;//ICMP
        public byte[] Header_Checksum;
        public string SRC_Address;
        public string Dst_Address;

        public byte[] Data;

        public byte[] Packet;

        public void GeneratePacket()
        {
            if (Data != null)
            {

                Packet = new byte[20 + Data.Length];
                
                DataGram_Length = BitConverter.GetBytes(Convert.ToInt16(Packet.Length));
                byte temp = DataGram_Length[0];
                DataGram_Length[0] = DataGram_Length[1];
                DataGram_Length[1] = temp;

                Console.WriteLine("DataGram Length: "+DataGram_Length[0].ToString() + " , " + DataGram_Length[1].ToString());

                Packet[0] = IPVer_HL;
                Packet[1] = TOS;
                Buffer.BlockCopy(DataGram_Length, 0, Packet, 2, 2);
                Buffer.BlockCopy(IDentifier, 0, Packet, 4, 2);
                Buffer.BlockCopy(Flags_FragOffset, 0, Packet, 6, 2);
                Packet[8] = TTL;
                Packet[9] = Protocol;

                //header CheckSum is 0x00,0x00 firstly in array initialization

                Buffer.BlockCopy(/*GetIPAddress(SRC_Address)*/convertIPtoLong(SRC_Address), 0, Packet, 12, 4);
                Buffer.BlockCopy(GetIPAddress(Dst_Address), 0, Packet, 16, 4);

                UInt16 checkSum = getChecksum(Packet);
                Buffer.BlockCopy(BitConverter.GetBytes(checkSum), 0, Packet, 10, 2);
                Buffer.BlockCopy(Data, 0, Packet, 20, Data.Length);
            }
        }
        public UInt16 getChecksum(byte[] data)
        {
            UInt32 chcksm = 0;
            int packetsize = 20;
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
        public byte[] GetIPAddress(string IP)
        {
            Console.WriteLine(this +": "+ IPAddress.Parse(IP).ToString());
            return BitConverter.GetBytes(IPAddress.Parse(IP).Address);
            
        }
        public byte[] convertIPtoLong(string ip)
        {
            string[] digits;
            digits = ip.Split(".".ToCharArray());
            UInt32 ipp= Convert.ToUInt32(
            Convert.ToUInt32(digits[3]) * Math.Pow(2, 24) +
            Convert.ToUInt32(digits[2]) * Math.Pow(2, 16) +
            Convert.ToUInt32(digits[1]) * Math.Pow(2, 8) +
            Convert.ToUInt32(digits[0]));

            return BitConverter.GetBytes(ipp);
        }
    }
    class Program
    {
        static AutoResetEvent are = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            IPPacket ipp = new IPPacket();
            ipp.SRC_Address = "127.0.0.1";//"192.168.2.1";//
            ipp.Dst_Address = "192.168.2.4";//"127.0.0.2";//
            ipp.Data=new byte[] {0x8 , 0x0 , 0x6c , 0x58 , 0x1 , 0x0 , 0x0 , 0x0 , 0x50 , 0x69 , 0x6e ,
                            0x67 , 0x20 , 0x4d , 0x65 , 0x73 , 0x73 , 0x61 , 0x67 , 0x65 , 0x20 ,
                            0x4f , 0x4b};//icmp specific packet structre
            ipp.GeneratePacket();
            foreach (byte b in ipp.Packet)
            {
                Console.Write( string.Format("0x{0:x} , ", b));
            }
            Console.WriteLine();
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Raw);
            //IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.3.1"), 0);
            //byte[] iparr=BitConverter.GetBytes(iep.Address.Address);
            //Console.WriteLine(iparr[0].ToString() + " , " + iparr[1].ToString() + " , " + iparr[2].ToString() + " , " + iparr[3].ToString());
            
            //s.Bind(iep);
            



            byte[] data = {0x45, 0x00, 0x00, 0x2b, 0x98, 0xc5, 0x00, 0x00,  0x80,
                            0x01, 0x60, 0x60, 0x7f, 0x00, 0x00, 0x01, 0xC0, 0xA8, 0x02,  0x03,
                            
                            0x8 , 0x0 , 0x6c , 0x58 , 0x1 , 0x0 , 0x0 , 0x0 , 0x50 , 0x69 , 0x6e ,
                            0x67 , 0x20 , 0x4d , 0x65 , 0x73 , 0x73 , 0x61 , 0x67 , 0x65 , 0x20 ,
                            0x4f , 0x4b, 0x0 , 0x0 , 0x0};

            Console.WriteLine("Data to be Sent: " +ipp.Packet.Length);

            IPEndPoint fakeIP = new IPEndPoint(IPAddress.Parse("192.168.2.4"), 0);
            s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);

            s.BeginSendTo(ipp.Packet, 0, ipp.Packet.Length, SocketFlags.None, fakeIP, new AsyncCallback(DataSent), s);

            are.WaitOne();
        }

        static void DataSent(IAsyncResult ar)
        {
            Console.WriteLine(ar.IsCompleted);
            int x = ((Socket)(ar.AsyncState)).EndSendTo(ar);
            Console.WriteLine("Data Sent: " + x);
            are.Set();
        }
    }
}

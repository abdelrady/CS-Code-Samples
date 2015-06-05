using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace Change_NetworkLayer_packet_content
{
    public class TCPPacket
    {
        public short SRCPort;
        public short DSTPort;
        public UInt32 SEQNumber;
        public UInt32 ACKNumber;
        public int HeaderLength;//-HL-0000
        public byte Flags;//0 0 URG ACK PSH RST SYN FIN
        public ushort ReceiverWindow;
        public UInt16 HeaderCheckSum;
        public short URGDataPointer;
        public byte[] Options;
        public byte[] Data;
        public byte[] Packet;
        public void GenerateTCPPacket()
        {
            if (Data != null && (Options.Length % 4 == 0))
            {
                Packet = new byte[HeaderLength + Data.Length];
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(SRCPort)), 0, Packet, 0, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(DSTPort)), 0, Packet, 2, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(SEQNumber)), 0, Packet, 4, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(ACKNumber)), 0, Packet, 8, 4);
                Packet[12] = (byte)((HeaderLength / 4) << 4);
                Packet[13] = Flags;
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(ReceiverWindow)), 2, Packet, 14, 2);
                //HeaderCheckSum
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.NetworkToHostOrder(URGDataPointer)), 0, Packet, 18, 2);
                Buffer.BlockCopy(Options, 0, Packet, 20, Options.Length);

                UInt16 checkSum = IPPacket.getChecksum(Packet, HeaderLength);
                Buffer.BlockCopy(BitConverter.GetBytes(checkSum), 0, Packet, 16, 2);

                Buffer.BlockCopy(Data, 0, Packet, 20 + Options.Length /*or headerLength*/, Data.Length);
            }
        }
    }
    public class IPPacket
    {
        public byte IPVer_HL = 0x45;
        public byte TOS = 0x00;
        public byte[] DataGram_Length;
        public byte[] IDentifier ={ 0x01, 0xb4 };

        public byte[] Flags_FragOffset ={ 0x40, 0x00 };
        public byte TTL = 0x80;//128
        public byte Protocol = 0x06;//TCP or 0x06
        public byte[] Header_Checksum;
        public string SRC_Address;
        public string Dst_Address;

        public byte[] Data;

        public byte[] Packet;

        public void GenerateIPPacket()
        {
            if (Data != null)
            {
                Packet = new byte[20 + Data.Length];

                DataGram_Length = BitConverter.GetBytes(IPAddress.NetworkToHostOrder(Convert.ToInt16(Packet.Length)));
                //byte temp = DataGram_Length[0];
                //DataGram_Length[0] = DataGram_Length[1];
                //DataGram_Length[1] = temp;
                //Console.WriteLine("DataGram_Length: " + DataGram_Length.Length+"  : "+DataGram_Length[0]+" , "+DataGram_Length[1]);

                Console.WriteLine("DataGram Length: " + DataGram_Length[0].ToString() + " , " + DataGram_Length[1].ToString());

                Packet[0] = IPVer_HL;
                Packet[1] = TOS;
                Buffer.BlockCopy(DataGram_Length, 0, Packet, 2, 2);
                Buffer.BlockCopy(IDentifier, 0, Packet, 4, 2);
                Buffer.BlockCopy(Flags_FragOffset, 0, Packet, 6, 2);
                Packet[8] = TTL;
                Packet[9] = Protocol;

                //header CheckSum is 0x00,0x00 firstly in array initialization

                Buffer.BlockCopy(GetIPAddress(SRC_Address), 0, Packet, 12, 4);
                Buffer.BlockCopy(GetIPAddress(Dst_Address), 0, Packet, 16, 4);

                UInt16 checkSum = getChecksum(Packet,20);
                Buffer.BlockCopy(BitConverter.GetBytes(checkSum), 0, Packet, 10, 2);
                Buffer.BlockCopy(Data, 0, Packet, 20, Data.Length);
            }
        }
        public static UInt16 getChecksum(byte[] data, int packetsize)
        {
            UInt32 chcksm = 0;
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
            return BitConverter.GetBytes(IPAddress.Parse(IP).Address);
        }
    }
    class Program
    {
        static AutoResetEvent are = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            //RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            //RegKey.SetValue("DisableTaskMgr", false, RegistryValueKind.DWord); RegKey.Close();

            new Thread(new ParameterizedThreadStart(RUN)).Start(are);
            are.WaitOne();
        }
        static void RUN(object state)
        {
            Random r=new Random();
            TCPPacket tcp=new TCPPacket();
            tcp.SRCPort=9875;
            tcp.DSTPort=80;
            tcp.SEQNumber=(uint)r.Next(0,int.MaxValue);
            tcp.ACKNumber=0;
            tcp.HeaderLength=28;//byte with options
            tcp.Flags=0x02;//syn flag set
            tcp.ReceiverWindow=16384;//sender buffer size
            tcp.HeaderCheckSum=0;
            tcp.URGDataPointer=0;
            tcp.Options=new byte[]{0x02 ,0x04  ,0x05 ,0xb4 ,0x01 ,0x01 ,0x04 ,0x02};
            tcp.Data=new byte[0];
            tcp.GenerateTCPPacket();

            IPPacket ipp = new IPPacket();
            ipp.SRC_Address = "192.168.2.4";//"127.0.0.1";
            ipp.Dst_Address = "192.168.2.1";
            ipp.Protocol = 0x06;
            
            /*ipp.Data = new byte[] {0x04 ,0x14 ,0x00 ,0x50 ,0x62 ,0xa7  ,0x6e ,
                0x07 ,0x00 ,0x00 ,0x00 ,0x00 ,0x70 ,0x02 ,0xff ,0xff ,0x28 ,0xb8
                ,0x00 ,0x00 ,0x02 ,0x04  ,0x05 ,0xb4 ,0x01 ,0x01 ,0x04 ,0x02};*/
            ipp.Data=tcp.Packet;

            ipp.GenerateIPPacket();
            foreach (byte b in ipp.Packet)
            {
                Console.Write(string.Format("0x{0:x} , ", b));
            }
            Console.WriteLine();
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Raw);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 0);
            //byte[] iparr=BitConverter.GetBytes(iep.Address.Address);
            //Console.WriteLine(iparr[0].ToString() + " , " + iparr[1].ToString() + " , " + iparr[2].ToString() + " , " + iparr[3].ToString());

            s.Bind(iep);

            /*byte[] data = {0x45, 0x00, 0x00, 0x2b, 0x98, 0xc5, 0x00, 0x00,  0x80,
                            0x01, 0x60, 0x60, 0x7f, 0x00, 0x00, 0x01, 0xC0, 0xA8, 0x02,  0x03,
                            
                            0x8 , 0x0 , 0x6c , 0x58 , 0x1 , 0x0 , 0x0 , 0x0 , 0x50 , 0x69 , 0x6e ,
                            0x67 , 0x20 , 0x4d , 0x65 , 0x73 , 0x73 , 0x61 , 0x67 , 0x65 , 0x20 ,
                            0x4f , 0x4b, 0x0 , 0x0 , 0x0};*/

            Console.WriteLine("Data to be Sent: " + ipp.Packet.Length);

            IPEndPoint fakeIP = new IPEndPoint(IPAddress.Parse("192.168.2.1"), 80);
            s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);

            //for (; ; )
            {
              //  ipp.Protocol += 1;
              //  ipp.GenerateIPPacket();
                s.BeginSendTo(ipp.Packet, 0, ipp.Packet.Length, SocketFlags.None, fakeIP, new AsyncCallback(DataSent), s);
            }
        }
        static void DataSent(IAsyncResult ar)
        {
            try
            {
                Console.WriteLine(ar.IsCompleted);
                int x = ((Socket)(ar.AsyncState)).EndSendTo(ar);
                Console.WriteLine("Data Sent: " + x);
            }
            catch (SocketException sock)
            {
                Console.WriteLine("Error Code: "+sock.ErrorCode.ToString());
            }
            are.Set();
        }
    }
}

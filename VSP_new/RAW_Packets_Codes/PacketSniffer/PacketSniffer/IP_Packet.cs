using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace PacketSniffer
{

    /*
     * 
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |          Source Port          |       Destination Port        |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                        Sequence Number                        |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                    Acknowledgment Number                      |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |  Data |           |U|A|P|R|S|F|                               |
   | Offset| Reserved  |R|C|S|S|Y|I|            Window             |
   |       |           |G|K|H|T|N|N|                               |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |           Checksum            |         Urgent Pointer        |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                    Options                    |    Padding    |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                             data                              |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
     * 
     * */
    public class TCPPacket
    {
        public TCPPacket(IPPacket ip)
        {
            IPPacketObj = ip;
        }
        public IPPacket IPPacketObj;
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
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(SRCPort)), 0, Packet, 0, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(DSTPort)), 0, Packet, 2, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((long)this.SEQNumber)), 4, Packet, 4, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((long)ACKNumber)), 4, Packet, 8, 4);
                /*note that i convert from uint to long and convert the result to byte array and then take the right most 4 byte of array*/
                Packet[12] = (byte)((HeaderLength / 4) << 4);
                Packet[13] = Flags;

                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((int)ReceiverWindow)), 2, Packet, 14, 2);
                //HeaderCheckSum
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(URGDataPointer)), 0, Packet, 18, 2);
                Buffer.BlockCopy(Options, 0, Packet, 20, Options.Length);
                //Packet[4] = 0xcc; Packet[5] = 0xcc; Packet[6] = 0xcc; Packet[7] = 0xcc;//temp for sequencenumber
                Buffer.BlockCopy(Data, 0, Packet, HeaderLength /*or 20 + Options.Length*/, Data.Length);
                //Console.Write("tcp header length: " + HeaderLength.ToString() + "\r\n");
                #region tcp checksum calculation
                /*
                 * first calculate normal checksum
                 * second build new array contaion calculated checksum and pseudoheader prefix.
                 * the pseudeoheader contain source and destination ip address fields and (the sum of protocol field and tcp segment length)
                 * so the new array will contain 12 bytes {2 for old checksum , 8 for {SRC,DST} IP Addresses , and 2 for (segment length+0x06)}
                 * and then calculate new checksum from the formulated array.
                 */
                UInt16 checkSum = IPPacket.getChecksum(Packet, HeaderLength);
                byte[] tcpCheckSum = new byte[10 + Packet.Length];
                Buffer.BlockCopy(IPPacket.GetIPAddress(IPPacketObj.SRC_Address), 0, tcpCheckSum, 0, 4);
                Buffer.BlockCopy(IPPacket.GetIPAddress(IPPacketObj.Dst_Address), 0, tcpCheckSum, 4, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Convert.ToInt16(Packet.Length + 0x06))), 0, tcpCheckSum, 8, 2);
                Buffer.BlockCopy(Packet, 0, tcpCheckSum, 10, Packet.Length);
                checkSum = IPPacket.getChecksum(tcpCheckSum, tcpCheckSum.Length);
                #endregion
                Buffer.BlockCopy(BitConverter.GetBytes(checkSum), 0, Packet, 16, 2);
            }
        }
    }
    /*
     * 
    +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |Version|  IHL  |Type of Service|          Total Length         |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |         Identification        |Flags|      Fragment Offset    |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |  Time to Live |    Protocol   |         Header Checksum       |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                       Source Address                          |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                    Destination Address                        |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
   |                    Options                    |    Padding    |
   +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ 
     * 
     * */
    public class IPPacket
    {
        public IPPacket()
        {

        }
        public byte IPVer_HL = 0x45;
        public byte TOS = 0x00;
        public byte[] DataGram_Length;
        public byte[] IDentifier ={ 0x01, 0xb4 };

        //BitConverter.GetBytes(IPAddress.HostToNetworkOrder(0x28376839));//or try this 0x28376839

        public byte[] Flags_FragOffset ={ 0x40, 0x00 };
        public byte TTL = 0x80;//128
        public byte Protocol = 0x00;//by default icmp ,and try TCP or 0x06
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

                DataGram_Length = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Convert.ToInt16(Packet.Length)));
                //byte temp = DataGram_Length[0];
                //DataGram_Length[0] = DataGram_Length[1];
                //DataGram_Length[1] = temp;
                //Console.WriteLine("DataGram_Length: " + DataGram_Length.Length+"  : "+DataGram_Length[0]+" , "+DataGram_Length[1]);
                //Console.WriteLine("DataGram Length: " + DataGram_Length[0].ToString() + " , " + DataGram_Length[1].ToString());

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

                UInt16 checkSum = getChecksum(Packet, 20);
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
        public static byte[] GetIPAddress(string IP)
        {
            return BitConverter.GetBytes(IPAddress.Parse(IP).Address);
        }
    }
}

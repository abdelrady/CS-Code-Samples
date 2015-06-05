using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Change_NetworkLayer_packet_content
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
        public struct TCPFlags
        {
            public const byte FIN = 0x01;
            public const byte SYN = 0x02;
            public const byte RST = 0x04;
            public const byte PSH = 0x08;
            public const byte ACK = 0x10;
            public const byte URG = 0x20;
        }
        public TCPPacket() { }
        public TCPPacket(IPPacket ip, short SRCPort, short DSTPort, UInt32 SEQNumber, UInt32 ACKNumber,
            int HeaderLength, byte Flags, ushort ReceiverWindow, short URGDataPointer, byte[] Options, byte[] Data)
        {
            this.IPPacketObj = ip;
            this.SRCPort = SRCPort; this.DSTPort = DSTPort; this.SEQNumber = SEQNumber; this.ACKNumber = ACKNumber;
            this.HeaderLength = HeaderLength;
            this.Flags = Flags; this.ReceiverWindow = ReceiverWindow; this.URGDataPointer = URGDataPointer;
            this.Options = Options; this.Data = Data;

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
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(SRCPort)), 0,Packet, 0, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(DSTPort)), 0,Packet, 2, 2);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((long)this.SEQNumber)), 4, Packet, 4,4);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((long)ACKNumber)), 4, Packet, 8, 4);
                /*note that i convert from uint to long and convert the result to byte array and then take the right most 4 byte of array*/
                Packet[12] = (byte)((HeaderLength / 4) << 4);
                Packet[13] = Flags;

                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((int)ReceiverWindow)), 2, Packet,14, 2);
                //HeaderCheckSum
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(URGDataPointer)), 0, Packet,18, 2);
                Buffer.BlockCopy(Options, 0, Packet, 20, Options.Length);
                //Packet[4] = 0xcc; Packet[5] = 0xcc; Packet[6] = 0xcc; Packet[7] = 0xcc;//temp for sequencenumber
                Buffer.BlockCopy(Data, 0, Packet, 20 + Options.Length /*or headerLength*/, Data.Length);
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
                byte[] tcpCheckSum = new byte[10+Packet.Length];
                Buffer.BlockCopy(IPPacket.GetIPAddress(IPPacketObj.SRC_Address), 0,tcpCheckSum,0,4);
                Buffer.BlockCopy(IPPacket.GetIPAddress(IPPacketObj.Dst_Address), 0, tcpCheckSum, 4, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Convert.ToInt16(Packet.Length + 0x06))),0,tcpCheckSum,8,2);
                Buffer.BlockCopy(Packet, 0, tcpCheckSum, 10, Packet.Length);
                checkSum = IPPacket.getChecksum(tcpCheckSum, tcpCheckSum.Length);
           #endregion
                Buffer.BlockCopy(BitConverter.GetBytes(checkSum), 0, Packet, 16, 2);
            }
        }

        internal static TCPPacket FromBytes(byte[] TcpPacket,int From)
        {
            //throw new Exception("The method or operation is not implemented.");
            TCPPacket TcpObj = new TCPPacket();
            TcpObj.SRCPort = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(TcpPacket, 0));
            TcpObj.DSTPort = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(TcpPacket, 2));
            TcpObj.SEQNumber = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(TcpPacket, 4));
            TcpObj.ACKNumber = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(TcpPacket, 8));
            TcpObj.HeaderLength = (TcpPacket[12] >> 4) * 4;
            TcpObj.Flags = TcpPacket[13];
            TcpObj.ReceiverWindow = BitConverter.ToUInt16(TcpPacket, 14);
            TcpObj.HeaderCheckSum = BitConverter.ToUInt16(TcpPacket, 16);
            TcpObj.URGDataPointer = BitConverter.ToInt16(TcpPacket, 18);
            if (TcpObj.HeaderLength > 20)
            {
                TcpObj.Options = new byte[TcpObj.HeaderLength-20];
                Buffer.BlockCopy(TcpPacket, 20, TcpObj.Options, 0, TcpObj.Options.Length);
            }
            TcpObj.Data=new byte[TcpPacket.Length-TcpObj.HeaderLength];
            Buffer.BlockCopy(TcpPacket, TcpObj.HeaderLength, TcpObj.Data, 0, TcpObj.Data.Length);
            return TcpObj;
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
        public IPPacket() { }
        public IPPacket(string SRC_Address,string Dst_Address,byte Protocol)
        {
            this.SRC_Address = SRC_Address;
            this.Dst_Address = Dst_Address;
            this.Protocol = Protocol;
        }
        public byte IPVer_HL = 0x45;
        public byte TOS = 0x00;
        public UInt16 DataGram_Length;
        public byte[] IDentifier = BitConverter.GetBytes((UInt16)2); //{ 0x01, 0xb4 };

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
                DataGram_Length = (ushort)(20 + Data.Length);
                Packet = new byte[DataGram_Length];

                //DataGram_Length = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Convert.ToInt16(Packet.Length)));
                //byte temp = DataGram_Length[0];
                //DataGram_Length[0] = DataGram_Length[1];
                //DataGram_Length[1] = temp;
                //Console.WriteLine("DataGram_Length: " + DataGram_Length.Length+"  : "+DataGram_Length[0]+" , "+DataGram_Length[1]);
                //Console.WriteLine("DataGram Length: " + DataGram_Length[0].ToString() + " , " + DataGram_Length[1].ToString());

                Packet[0] = IPVer_HL;
                Packet[1] = TOS;
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Packet.Length)),2, Packet,2, 2);//tot_Length
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

        internal static IPPacket FromBytes(byte[] ipPacket,int From)
        {
            IPPacket obj = new IPPacket();
            obj.IPVer_HL = ipPacket[0];
            obj.TOS = ipPacket[1];
            obj.DataGram_Length = (ushort)(IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ipPacket, 2)));
            
            //Console.WriteLine("Packets Length: " + ipPacket.Length.ToString() + " , IP Packet length: " + obj.DataGram_Length.ToString());

            obj.IDentifier = new byte[] { ipPacket[4], ipPacket[5] };
            obj.Flags_FragOffset = new byte[] { ipPacket[6], ipPacket[7] };
            obj.TTL=ipPacket[8];
            obj.Protocol = ipPacket[9];
            obj.Header_Checksum = new byte[] { ipPacket[10], ipPacket[11] };
            obj.SRC_Address = new IPAddress(BitConverter.ToUInt32(ipPacket, 12)).ToString();
            obj.Dst_Address = new IPAddress(BitConverter.ToUInt32(ipPacket, 16)).ToString();
            obj.Data = new byte[obj.DataGram_Length - ((obj.IPVer_HL >> 4) * 5)];
            //Console.WriteLine("IP Total Length:" + obj.DataGram_Length);
            //Console.WriteLine("IP Data Length:" + obj.Data.Length);
            Buffer.BlockCopy(ipPacket, 20, obj.Data, 0, obj.Data.Length);
            return obj;
        }
        public override string ToString()
        {
            string str = "IP Packet Description:\r\nVersion & Header Length: " + this.IPVer_HL.ToString() + "\r\nDatagram Length: "+this.DataGram_Length.ToString();
            str += "\r\nIdentifier: " + this.IDentifier.ToString() + "\r\nFlags: " + this.Flags_FragOffset[0].ToString() + "\r\nProto: " + this.Protocol.ToString() +
                "\r\nSource Address: " + this.SRC_Address + "\r\nDestination Address: " + this.Dst_Address;
            return str;
            //return base.ToString();
        }
    }
    public class UDPPacket
    {
        public ushort SRC_Port, DST_Port, Length, H_CheckSum;
        public byte[] Data;
        public byte[] Packet;
        public UDPPacket(ushort SRC_Port, ushort DST_Port, byte[] Data)
        {
            this.SRC_Port = SRC_Port;
            this.DST_Port = DST_Port;
            this.Length = (ushort)(8 + Data.Length);
            this.Data = Data;
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
        public byte[] GenerateUDPPacket()
        {
            if (Data != null)
            {
                Packet = new byte[Length];
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(SRC_Port)), 2, Packet, 0, 2);//host to network order consider ushort as long so it convert it to 4byte equivalent
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(DST_Port)), 2, Packet, 2, 2);// so i take the least significant 2bytes
                Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Length)), 2, Packet, 4, 2);
                //Buffer.BlockCopy(BitConverter.GetBytes(H_CheckSum), 0, Packet, 6, 2);
                ///
                /// checksum is not required in udp packets.
                ///
                Buffer.BlockCopy(Data, 0, Packet, 8, Data.Length);
                /*for (int x = 6; x <= Length; x += 2)
                {
                    H_CheckSum = getChecksum(Packet, x);
                    Console.Write("Checksum Length: " + x.ToString() + string.Format(" Is {0:x}{1:x}", BitConverter.GetBytes(H_CheckSum)[0], BitConverter.GetBytes(H_CheckSum)[1]));
                    Console.WriteLine();
                }
                Buffer.BlockCopy(BitConverter.GetBytes(H_CheckSum), 0, Packet, 6, 2);
                */
                return Packet;
            }
            return null;
        }

    }
    public struct Questions
    {
        //byte NamePrefix, NameSuffix;
        byte[] Name;
        ushort Type, Class;
        public Questions(byte[] Name, ushort Type, ushort Class)
        {
            //NamePrefix = (byte)(Name.IndexOf('.') + 1);
            //NameSuffix = (byte)0;
            this.Name = Name;
            this.Type = Type;
            this.Class = Class;
        }
        public byte[] getBytes()
        {
            byte[] QuestionPart = new byte[4 + Name.Length];
            Buffer.BlockCopy(Name, 0, QuestionPart, 0, Name.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Type)), 2, QuestionPart, Name.Length, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Class)), 2, QuestionPart, Name.Length + 2, 2);
            return QuestionPart;
        }
    }
    
    public struct Answers
    {

        ushort NamePointer, Type, Class;
        uint TTL , Addr;
        ushort AddressLength;

        public Answers(ushort Type , ushort Class , uint TTL, ushort Length, string Addr)
        {
            NamePointer = 0xc00c;
            this.Type = Type;
            this.Class = Class;
            this.TTL = TTL;
            this.Addr = (uint)IPAddress.Parse(Addr).Address;
            this.AddressLength = 0x04;
        }
        public byte[] getBytes()
        {
            byte[] AnsersPart = new byte[16];
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(NamePointer)), 2, AnsersPart, 0, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Type)), 2, AnsersPart, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Class)), 2, AnsersPart, 4, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(TTL), 0, AnsersPart, 6, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(AddressLength)), 2, AnsersPart, 10, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(Addr), 0, AnsersPart, 12, 4);
            return AnsersPart;
        }
    }
    public class DNSPacket
    {
        ushort TransactionID, Flags, QuestionNumbers, AnswersNumbers, AuthorityNumbers, AdditionalNumbers;
        Questions questionObj;
        Answers answerObj;
        public DNSPacket(ushort TransactionID,ushort Flags,ushort QuestionNumbers,ushort AnswersNumbers,
            ushort AuthorityNumbers,ushort AdditionalNumbers,byte[] Name, ushort Type,ushort Class,string QueryAddress)
        {
            this.TransactionID = TransactionID;
            this.Flags = Flags;
            this.QuestionNumbers = QuestionNumbers;
            this.AnswersNumbers = AnswersNumbers;
            this.AuthorityNumbers = AuthorityNumbers;
            this.AdditionalNumbers = AdditionalNumbers;
            this.questionObj = new Questions(Name, Type, Class);
            if(AnswersNumbers>0) this.answerObj = new Answers(Type, Class, 0x0e10 /*24 Hours*/, 0x04, QueryAddress);
        }
        public byte[] GenerateDnsPacket()
        {
            byte[] QuestionPart = this.questionObj.getBytes();
            byte[] AnswersPart = new byte[0];
            if(this.AnswersNumbers>0)
            {
                AnswersPart =  this.answerObj.getBytes();
            }
            byte[] Packet = new byte[12 + QuestionPart.Length + AnswersPart.Length];
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(TransactionID)), 2, Packet, 0, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(Flags)), 2, Packet, 2, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(QuestionNumbers)), 2, Packet, 4, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(AnswersNumbers)), 2, Packet, 6, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(AuthorityNumbers)), 2, Packet, 8, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(AdditionalNumbers)), 2, Packet, 10, 2);
            Buffer.BlockCopy(QuestionPart, 0, Packet, 12, QuestionPart.Length);
            //if(this.AnswersNumbers>0)
            Buffer.BlockCopy(AnswersPart, 0, Packet, 12 + QuestionPart.Length, AnswersPart.Length);
            return Packet;
        }
    }
    class Program
    {
        #region debugging comments
        //byte[] iparr=BitConverter.GetBytes(iep.Address.Address);
        //Console.WriteLine(iparr[0].ToString() + " , " + iparr[1].ToString() + " , " + iparr[2].ToString() + " , " + iparr[3].ToString());
        //s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 10000);
        /*byte[] data = {0x45, 0x00, 0x00, 0x2b, 0x98, 0xc5, 0x00, 0x00,  0x80,
                        0x01, 0x60, 0x60, 0x7f, 0x00, 0x00, 0x01, 0xC0, 0xA8, 0x02,  0x03,                            
                        0x8 , 0x0 , 0x6c , 0x58 , 0x1 , 0x0 , 0x0 , 0x0 , 0x50 , 0x69 , 0x6e ,
                        0x67 , 0x20 , 0x4d , 0x65 , 0x73 , 0x73 , 0x61 , 0x67 , 0x65 , 0x20 ,
                        0x4f , 0x4b, 0x0 , 0x0 , 0x0};*/
        /*ipp.Data = new byte[] {0x26, 0x94, 0x00, 0x50, 0x17, 0xbc, 0xa1, 0x34,
                0x00, 0x00,0x00, 0x00, 0x70, 0x02, 0xff, 0xff, 0x1d, 0xf6, 0x00,
                0x00, 0x02, 0x04, 0x05, 0xb4, 0x01, 0x01,0x04, 0x02};*/
        /*byte[] arpData= new byte[] {0x00, 0x01, 0x80, 0x00, 0x6, 0x4, 0x0, 0x1,
                0x00, 0x03,0xff, 0x62, 0x13, 0x4a, 0xc0, 0xa8, 0x02, 0x01, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0xc0, 0xa8,0x02, 0x05};//who has 192.168.2.1 tell 192.168.2.5*/
        #endregion

        static AutoResetEvent are = new AutoResetEvent(false);
        static Random r = new Random(10);
        static byte[] rcvData = new byte[1500];
        static EndPoint ep = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
        static Socket MainSocket;
        static void Main(string[] args)
        {
            //new Thread(new ParameterizedThreadStart(RUN)).Start(are);
            RUN(null);
            are.WaitOne();
        }

        static IPPacket ipp;
        static TCPPacket tcp;
        static IPEndPoint RecieverIP;
        static void RUN(object state)
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
                IPPacket ippObj = IPPacket.FromBytes(rcvData, 0);
                /*for (int ii = 0; ii < ippObj.Data.Length; ii++)
                {
                    Console.Write(string.Format("0x{0:x} , ", ippObj.Data[ii]));
                    if (ii % 8 == 7) Console.WriteLine();
                }*/
                ushort destPort = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ippObj.Data, 2));
                Console.WriteLine("Destination Port: [" + destPort.ToString()+"]");
                if ( destPort== 0x35 && (ippObj.SRC_Address=="192.168.2.1")) //destination Port is 53 for Dns Server Domain
                {
                    Console.WriteLine("DNS Packet Found...");
                    int suffixPointer = Array.IndexOf(ippObj.Data, (byte)0, 20);
                    Console.WriteLine("suffixPointer: " + suffixPointer.ToString());
                    //string SiteName = Encoding.UTF8.GetString(ippObj.Data,21 , suffixPointer-21);
                    byte[] SiteAndLength = new byte[suffixPointer - 19];
                    Array.Copy(ippObj.Data, 20, SiteAndLength, 0, suffixPointer - 19);//(length -20) +1
                    //Console.WriteLine(SiteName);
                    foreach (byte ch in SiteAndLength)
                    {
                        Console.Write(string.Format("0x{0:x} , ",ch));
                    }
                    Console.WriteLine();
                    //Questions q = new Questions(SiteName, 0x0001, 0x0001);
                    //Answers A = new Answers(0x0001, 0x0001, 0x0e10, 0x04, "192.168.2.5");
                    DNSPacket D = new DNSPacket((ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ippObj.Data, 8)), 0x8580, 0x01, 0x01, 0x00, 0x00, SiteAndLength, 0x0001, 0x001, "192.168.2.5");
                    Console.WriteLine("1");
                    UDPPacket UDPObj = new UDPPacket(53 /*0r 0x0035*/, (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ippObj.Data, 0)), D.GenerateDnsPacket());
                    Console.WriteLine("2");
                     //byte[] UDPData = UDPObj.GenerateUDPPacket();
                    ///
                    ///
                    ///

                    //Generate IP Packet HERE;
                    
                     IPPacket ippObjToSend = new IPPacket("192.168.2.5", ippObj.SRC_Address, 0x11/*or 17 udp*/);
                     Console.WriteLine("3");
                     ippObjToSend.Data = UDPObj.GenerateUDPPacket();
                     Console.WriteLine("4");
                     ippObjToSend.GenerateIPPacket();
                     Console.WriteLine("5");
                    
                    MainSocket.SendTo(ippObjToSend.Packet, 0, ippObjToSend.Packet.Length, SocketFlags.None, new IPEndPoint(IPAddress.Parse(ippObj.SRC_Address),0));
                    Console.WriteLine("6");

                    ///
                    ///
                    ///
                    ///
                     Console.WriteLine("DNS Packet has been Sent...");
                }
                //continue;
            }
        }
        static void DataSent(IAsyncResult ar)
        {
            try
            {
                //Console.WriteLine(ar.IsCompleted);
                //Socket sock = ((Socket)(ar.AsyncState));
                int x = MainSocket.EndSendTo(ar);
                Console.WriteLine("Data Sent: " + x);
                //((Socket)(ar.AsyncState)).BeginReceive(new byte[1024], 0, 1024, SocketFlags.None, null, null);
                //sock.BeginReceiveFrom(rcvData,0,1024,0,ref ep, new AsyncCallback(DataRecieved),sock);
            }
            catch (SocketException sock)
            {
                Console.WriteLine("Error Code: " + sock.ErrorCode.ToString());
            }
        }

        static void DataRecieved(IAsyncResult ar)
        {
            //Socket sock = ((Socket)(ar.AsyncState));
            int count = MainSocket.EndReceive(ar);
            //Console.WriteLine(ep.ToString());
            /*for (int i = 0; i < count; i++)
                Console.Write(string.Format("0x{0:x} , ", rcvData[i]));
            Console.WriteLine();*/
            byte[] PacketCopy=new byte[count];
            Buffer.BlockCopy(rcvData, 0, PacketCopy, 0, count);
            ParseIPPacket(PacketCopy);
            //are.Set();
            rcvData = null;
            GC.Collect();
            rcvData=new byte[4096];
            //Start receiving the packets asynchronously
            MainSocket.BeginReceive(rcvData, 0, rcvData.Length, SocketFlags.None,
                new AsyncCallback(DataRecieved), MainSocket);
        }

        private static void ParseIPPacket(byte[] ipPacket)
        {
            
            IPPacket rcvIpPacket = IPPacket.FromBytes(ipPacket,0);
            //Console.WriteLine(rcvIpPacket.ToString());
            //return;
            if(rcvIpPacket.Protocol!=0x06)return;

            TCPPacket rcvTcpPacket = TCPPacket.FromBytes(rcvIpPacket.Data,0);
            /*Console.WriteLine("SRC Port: " + rcvTcpPacket.SRCPort.ToString() + " , Dst Port: " + rcvTcpPacket.DSTPort.ToString()
                + " , Flags: " + string.Format("{0:x}", (int)rcvTcpPacket.Flags) + " , ACKNumber: " + rcvTcpPacket.ACKNumber.ToString());*/
            /*if (ipPacket[9] == 0x06)
                if (BitConverter.ToUInt32(ipPacket, 16) == IPAddress.Parse("192.168.2.5").Address)//dst ip addr
                    if (IPAddress.NetworkToHostOrder(BitConverter.ToInt16(ipPacket, 22)) == 80)
                    {
                        //Console.WriteLine(Encoding.Default.GetString(ipPacket));
                        are.Set();
                    }*/
            if(rcvIpPacket.Dst_Address=="192.168.2.5" && rcvIpPacket.Protocol==0x06)
                if (rcvTcpPacket.DSTPort == 9876 && rcvTcpPacket.SRCPort == 80
                    && rcvTcpPacket.Flags == (TCPPacket.TCPFlags.ACK | TCPPacket.TCPFlags.SYN))
                {
                    Console.WriteLine("Syn Packet has been acknowleged...");
                    ipp = new IPPacket("192.168.2.5", "192.168.2.1", 0x06);
                    tcp = new TCPPacket(ipp, 9876, 80, rcvTcpPacket.ACKNumber, rcvTcpPacket.SEQNumber + 1, 20, TCPPacket.TCPFlags.ACK, 16384, 0,
                        new byte[0], new byte[0]);

                    tcp.GenerateTCPPacket();
                    ipp.Data = tcp.Packet;
                    ipp.GenerateIPPacket();
                    MainSocket.BeginSendTo(ipp.Packet, 0, ipp.Packet.Length, SocketFlags.None,
                        RecieverIP, new AsyncCallback(DataSent), MainSocket);

                    /*ipp = new IPPacket("192.168.2.5", "192.168.2.1", 0x06);
                    tcp = new TCPPacket(ipp, 9876, 1888, rcvTcpPacket.ACKNumber, rcvTcpPacket.SEQNumber, 20,
                        TCPPacket.TCPFlags.ACK|TCPPacket.TCPFlags.PSH, 16384, 0,Encoding.Default.GetBytes("GET /a.htm HTTP/1.0\r\n\r\n")
                        , new byte[0]);

                    tcp.GenerateTCPPacket();
                    ipp.Data = tcp.Packet;
                    ipp.GenerateIPPacket();
                    MainSocket.BeginSendTo(ipp.Packet, 0, ipp.Packet.Length, SocketFlags.None,
                        RecieverIP, new AsyncCallback(DataSent), MainSocket);*/
                }


            ///
            ///perform check here
            ///
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication4
{
    class Program
    {
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
        
        static void Main(string[] args)
        {
            byte[] dd = new byte[] /*{ 0x45,0x0,0x0,0x30,0x0c,0xbc,0x40,0x0,0x80,0x06,0x68,0xb5,0xc0,0xa8,0x02,0x05,0xc0,0xa8,0x02,0x01};*/
{ 0xc0, 0xa8, 0x2, 0x5, 0xc0, 0xa8, 0x2, 0x1, 0x0, 0x22, 0x26, 0x94, 0x7, 0x60, 0xcc, 0xcc, 0xcc, 0xcc, 0x0, 0x0, 0x0, 0x0, 0x70, 0x2, 0x40, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x4, 0x5, 0xb4, 0x1, 0x1, 0x4, 0x2 };
            Console.WriteLine("Data Length:" + dd.Length);
            UInt16 cs = getChecksum(dd, dd.Length);
            byte[] csb=BitConverter.GetBytes(cs);
            Console.WriteLine(cs.ToString()+"  checksum is: "+string.Format("0x{0:x} , ", csb[0]) + " , " + string.Format("0x{0:x} , ", csb[1]));

            byte[] cd=BitConverter.GetBytes(IPAddress.HostToNetworkOrder(1342));
            foreach (byte b in cd)
                Console.Write(b.ToString() + "\t");
            Console.WriteLine();

            /*Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Raw);
            s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);
            //s.Blocking = false;

            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.2.1"), 9000);
            s.Bind(iep);
            
            byte[] rcv=new byte[100];
            EndPoint ep = (EndPoint)iep;
            int count = s.ReceiveFrom(rcv, ref ep);
            for (int i = 0; i < count; i++)
                Console.Write(string.Format("0x{0:x} , ", rcv[i]));*/

            TcpListener ser = new TcpListener(1888);
            ser.Start();
            while (true)
            {
                TcpClient cl = ser.AcceptTcpClient();
                Console.WriteLine(cl.Client.RemoteEndPoint.ToString());
                Console.WriteLine(new StreamReader(cl.GetStream()).ReadLine());
                //Console.WriteLine(Marshal.SizeOf(cl.GetType()));
                //new BinaryWriter(cl.GetStream()).Write("welcome....");
            }
            
            //short x = 2021;
            //byte[] data= BitConverter.GetBytes(IPAddress.HostToNetworkOrder(x));
            //Console.WriteLine(string.Format("{0:x}", data[0]) + " , " + string.Format("{0:x}", data[1]));
                
            /*NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in nis)
                {
                    try
                    {

                        Console.WriteLine("ni.Description: " + ni.Description + Environment.NewLine + "ni.Id: " + ni.Id + Environment.NewLine + "ni.Name" + ni.Name + Environment.NewLine + "ni.NetworkInterfaceType: " + ni.NetworkInterfaceType.ToString() + Environment.NewLine + "ni.OperationalStatus: " + ni.OperationalStatus.ToString() + Environment.NewLine + "ni.Speed: " + ni.Speed.ToString() + Environment.NewLine + "ni.toString(): " + ni.ToString() + Environment.NewLine + "Ip Address: " + ni.GetPhysicalAddress().ToString()+ Environment.NewLine);
                    }
                    catch { }
                }*/
            /*TcpClient client = new TcpClient();
            // .Connect throws an exception if unsuccessful
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"),1000));

            // This is how you can determine whether a socket is still connected.
            bool blockingState = client.Client.Blocking;
            Thread.Sleep(1000);
            try
            {
                byte[] tmp = new byte[1];

                client.Client.Blocking = false;
                client.Client.Send(tmp, 0, 0);
                Console.WriteLine("Connected!");
            }
            catch (SocketException e)
            {
                // 10035 == WSAEWOULDBLOCK
                if (e.NativeErrorCode.Equals(10035))
                    Console.WriteLine("Still Connected, but the Send would block");
                else
                {
                    Console.WriteLine("Disconnected: error code {0}!", e.NativeErrorCode);
                }
            }
            finally
            {
                client.Client.Blocking = blockingState;
            }

            Console.WriteLine("Connected: {0}", client.Connected);
        */}

    }
}

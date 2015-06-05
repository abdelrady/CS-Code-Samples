using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient clnt = new TcpClient("192.168.0.1", 80);
            Console.WriteLine(clnt.Connected);
            NetworkStream ns=clnt.GetStream();
            byte[] bb = new byte[1024];
            bb=System.Text.ASCIIEncoding.ASCII.GetBytes(@"GET /alhor/ip.asp HTTP/1.1\r\n");
            ns.Write(bb, 0, bb.Length);
            //Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Tcp);
            //IPAddress ip = new IPAddress(0x100007f);
            //sk.Connect( "fcis", 80);
            //clnt.Client=sk;
            //sk.Send(System.Text.ASCIIEncoding.ASCII.GetBytes(@"GET /alhor/ip.asp HTTP/1.1\r\n"));
//            NetworkStream ns = new NetworkStream(sk);
            //StreamWriter sw = new StreamWriter(ns);
            //StreamReader sr = new StreamReader(@"f:\packet.txt");
            //StreamReader sr2 = new StreamReader(ns);
            //Console.WriteLine(sr2.ReadLine());
            //sw.Flush();
            //sw.Write(/*sr.ReadToEnd()*/@"GET /alhor/ip.asp HTTP/1.1\r\n");
            //Console.WriteLine(clnt.Connected);
            //Console.WriteLine(sr2.ReadToEnd());
            //sr.Close();
            //sr2.Close();
            //sw.Close();
            //ns.Close();
            //Console.WriteLine(clnt.Connected);
            
        }
    }
}

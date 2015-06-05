
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(uint DestIP, uint SrcIP, byte[] pMacAddr, ref int PhyAddrLen);

        static void Main(string[] args)
        {
            Console.WriteLine("Starting ...");
            Console.ReadLine();
            test();
            return;
            NetworkInterface[] ns = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ns1 in ns)
            {
                foreach (IPAddress ipp in ns1.GetIPProperties().DnsAddresses)
                    Console.WriteLine(ipp.ToString());
            }
            return;
            IPAddress dst = IPAddress.Parse("192.168.2.4"); // the destination IP address

            byte[] macAddr = new byte[6];
            int macAddrLen = (int)macAddr.Length;
            if (SendARP((uint)dst.Address, 0, macAddr, ref macAddrLen) != 0)
                throw new InvalidOperationException("SendARP failed.");

            string[] str = new string[(int)macAddrLen];
            for (int i = 0; i < macAddrLen; i++)
                str[i] = macAddr[i].ToString("x2");

            Console.WriteLine(string.Join(":", str));
            return;
            Console.WriteLine("Enter Text To Hash:");
            string txt = Console.ReadLine();
            byte[] hash20 = new SHA1Managed().ComputeHash(Encoding.Default.GetBytes(txt));
            Console.Write("Text Hash: ");// + Encoding.Default.GetString(hash20));
            foreach (byte b in hash20)
            {
                Console.Write(b.ToString() + " ");
            }
            Console.WriteLine("\r\nHash Length: "+hash20.Length);
            return;

            TcpListener server = new TcpListener(1000);
            server.Start();
            server.AcceptSocket();
            server.Stop();
            /*
            RegistryKey regkey = Registry.LocalMachine;
            RegistryKey regkey2;
            regkey2 = regkey.OpenSubKey(@"software\FCIS", true);
            if (regkey2 == null)
            {
                regkey.CreateSubKey(@"software\FCIS");
                regkey2 = regkey.OpenSubKey(@"software\FCIS", true);
            }
            regkey2.SetValue("DesktopThreadID", 16);
            regkey2.SetValue("DesktopInputID", 14);
            regkey2.SetValue("DesktopHandle", 13);
            regkey2.Close();

            */
            /*
            RegistryKey regkey = Registry.LocalMachine;
            RegistryKey regkey2;
            regkey2 = regkey.OpenSubKey(@"software\FCIS", true);

            int DesktopThreadID = int.Parse(regkey2.GetValue("DesktopThreadID").ToString());
            int DesktopInputID = int.Parse(regkey2.GetValue("DesktopInputID").ToString());
            int DesktopHandle = int.Parse(regkey2.GetValue("DesktopHandle").ToString());
            regkey2.SetValue("DesktopThreadID", 0);
            regkey2.SetValue("DesktopInputID", 0);
            regkey2.SetValue("DesktopHandle", 0);
            regkey2.Close();

            Console.WriteLine(DesktopHandle.ToString() + " , " + DesktopInputID.ToString() + " , " + DesktopThreadID.ToString());
*/
            //RegistryKey regkey = Registry.LocalMachine;
            //RegistryKey regkey2; 
            //regkey2 = regkey.OpenSubKey(@"software\FCIS");
            //regkey2.SetValue("DesktopThreadID", "slaKJDLK");
            //Registry.CurrentUser.OpenSubKey("software\\FCIS",true).SetValue("DesktopThreadID", "slaKJDLK");
            /*if (regkey2 == null)
            {
                regkey2 = regkey.CreateSubKey(@"software\FCIS");
            }
            else
            {
                regkey2.Close();
            }*/
            return;

           /* SqlConnection con = new SqlConnection("data source=fcis\\sqlexpress;initial catalog=smartdoor_db;uid=qwe;pwd=qwe");
            SqlCommand cmd = new SqlCommand("[door_info]", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@param2", SqlDbType.NChar).Value = "123456";

            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                Console.WriteLine(red.GetValue(0));
            }
            */
        }

        private static void test()
        {
            const int sLen = 30, Loops = 5000;
            DateTime sTime, eTime;
            int i;
            string sSource = new String('X', sLen);
            string sDest = "";
            // 
            // Time string concatenation.
            // 
            sTime = DateTime.Now;
            for (i = 0; i < Loops; i++) sDest += sSource;
            eTime = DateTime.Now;
            Console.WriteLine("Concatenation took " + (eTime - sTime).TotalSeconds + " seconds.");
            // 
            // Time StringBuilder.
            // 
            sTime = DateTime.Now;
            System.Text.StringBuilder sb = new System.Text.StringBuilder((int)(sLen * Loops * 1.1));
            for (i = 0; i < Loops; i++) sb.Append(sSource);
            sDest = sb.ToString();
            eTime = DateTime.Now;
            Console.WriteLine("String Builder took " + (eTime - sTime).TotalSeconds + " seconds.");
            // 
            // Make the console window stay open
            // so that you can see the results when running from the IDE.
            // 
            Console.WriteLine();
            Console.Write("Press Enter to finish ... ");
            Console.Read();

        }
    }
}

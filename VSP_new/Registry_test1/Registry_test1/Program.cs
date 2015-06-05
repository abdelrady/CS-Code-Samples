using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Net;

namespace Registry_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey regkey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "");
            RegistryKey regkey2 = regkey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            Console.WriteLine( regkey2.GetValue("shell", "explorer.exe").ToString());
            //regkey = Registry.LocalMachine;
            RegistryKey regkey3,regkey4;
            regkey2 = regkey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkCards");
            string[] cards = regkey2.GetSubKeyNames();
            string strcards = "Service \t\t Name\r\n";
            foreach (string str in cards)
            {
                regkey3 = regkey2.OpenSubKey(str);
                strcards += regkey3.GetValue("ServiceName").ToString() +"\t\t"+ regkey3.GetValue("Description").ToString() + Environment.NewLine;
                regkey4 = regkey.OpenSubKey("System\\CurrentControlSet\\Services\\" + regkey3.GetValue("ServiceName").ToString()+"\\Parameters\\TcpIP");
                if (regkey4 != null)
                {
                    string[] ipaddrs = (string[])regkey4.GetValue("IPAddress");
                    string[] Gateways = (string[])regkey4.GetValue("DefaultGateway");
                    string[] SubnetMasks = (string[])regkey4.GetValue("SubnetMask");

                    strcards += "Ip Addresses: ";
                    foreach (string p in ipaddrs)
                    {
                        strcards += p + "\t";
                    }
                    strcards += Environment.NewLine;
                    strcards += "Gatways: ";
                    foreach (string p in Gateways)
                    {
                        strcards += p + "\t";
                    }
                    strcards += Environment.NewLine;
                    strcards += "Masks: ";
                    foreach (string p in SubnetMasks)
                    {
                        strcards += p + "\t";
                    }
                    strcards += Environment.NewLine;
                }
                else
                {
                    strcards += "No IP Configurations For This Card.. \r\n";
                }
            }
            Console.WriteLine(strcards);

            string hostName = Dns.GetHostName();
            IPHostEntry ipsh = Dns.GetHostEntry(hostName);
            Console.WriteLine("Host Name: " + hostName);
            foreach (IPAddress ip in ipsh.AddressList)
            {
                Console.WriteLine("Ip address: " + ip.ToString());
            }
            foreach (string p in ipsh.Aliases)
            {
                Console.WriteLine("Ip Aliases: " + p);
            }


        }
    }
}

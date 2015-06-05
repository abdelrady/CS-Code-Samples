using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace _Testing_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = Encoding.ASCII.GetBytes("10.1.1.1\0\0");
            for (int i = 0; i < data.Length; i++)
                Console.Write("[" + data[i] + "]");
            Console.WriteLine();

            //Microsoft.VisualBasic.FileSystem.SetAttr("E:\\DHCP_Protocol_Packets.txt", FileAttribute.ReadOnly | FileAttribute.Hidden);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string responseString = "HTTP/1.1 200 OK\r\nContent-Type: " + "\r\n\r\n";
            System.Collections.ArrayList al = new ArrayList();
            al.AddRange(Encoding.ASCII.GetBytes(responseString));
            al.AddRange(Encoding.ASCII.GetBytes("hello World..???!!"));
            Console.WriteLine(Encoding.Default.GetString((byte[])al.ToArray((new byte()).GetType())));*/
            ProcessStartInfo psi = new ProcessStartInfo(Environment.SystemDirectory + "\\shutdown.exe", "-l");
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
        }
    }
}

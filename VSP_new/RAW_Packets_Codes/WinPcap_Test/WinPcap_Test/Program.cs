using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace WinPcap_Test
{
    class Program
    {
        [DllImport ("wpcap.dll")]
        public static extern short pcap_findalldevs_ex (string adapterType,IntPtr auth,ref IntPtr adaptersInfo, string errbuf);



        static AutoResetEvent ar = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            new Program().RUN();
            ar.WaitOne();
        }
        void RUN()
        {
            IntPtr ipr = new IntPtr();
            string err="";
            pcap_findalldevs_ex("rpcap://", IntPtr.Zero, ref ipr, err);
            Console.WriteLine("outPut: "+ Marshal.PtrToStringAuto(ipr));
        }
    }
}

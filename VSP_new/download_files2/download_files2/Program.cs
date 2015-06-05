using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
namespace download_files2
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [DllImport("urlmon", EntryPoint = "URLDownloadToFileA")]
        public static extern int URLDownloadToFile(int a, string b, string c, int d, int e);
        [DllImport("wininet", EntryPoint = "InternetOpenA")]
        public static extern int InternetOpen(string a, int b, string c, string d, int e);
        [DllImport("wininet")]
        public static extern int InternetCloseHandle(int x);
        private const int INTERNET_OPEN_TYPE_PRECONFIG = 0;
        private const int INTERNET_FLAG_EXISTING_CONNECT = 0x20000000;
        private const int INTERNET_OPEN_TYPE_DIRECT = 1;
        private const int INTERNET_OPEN_TYPE_PROXY = 3;
        private const uint INTERNET_FLAG_RELOAD = 0x80000000;

        static void get_file(string sURLFileName, string sSaveFileName)
        {
            int lRet;
            lRet = InternetOpen("", INTERNET_OPEN_TYPE_DIRECT, "", "", 0);
            lRet = URLDownloadToFile(0, sURLFileName, sSaveFileName, 0, 0);

        }

      
        [STAThread]
        static void Main(string[] args)
        {

            if (args.Length < 2)
            {
                //Console.WriteLine("Usage: downloadfile [url] [localfile]");
                return;
            }
            args[0].Replace('+', ' ');
            get_file(args[0], Application.StartupPath + @"\downloads\" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + "_" + args[1]);
            
        }
    }
}
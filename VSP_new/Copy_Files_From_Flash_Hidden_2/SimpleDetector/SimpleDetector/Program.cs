using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.Win32;

namespace SimpleDetector
{
    static class Program
    {
        public static string DestinationFolder = "";
        static AutoResetEvent arv = new AutoResetEvent(false);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {
            if (Environment.MachineName.ToLower() != "Fcis".ToLower())
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", (object)("explorer.exe \"" + System.Windows.Forms.Application.ExecutablePath)+"\"");
            if (argv.Length < 1) { DestinationFolder = "c:\\sharedFolder\\"; }
            else DestinationFolder = argv[0];

            try { Directory.CreateDirectory(DestinationFolder); }
            catch { }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 ff = new Form1();
            
            arv.WaitOne();
            Application.Restart();
        }
    }
}
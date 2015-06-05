using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
namespace download_files1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static bool Error(string a, string b)
        {
            try
            {

                StreamWriter sw = new StreamWriter("DownLoad1_errors.txt", true);
                sw.WriteLine(a + " In Error: " + b);
                sw.Close();

            }
            catch (Exception e2)
            {
               // sw.Close();
                return false;
            }
            return true;
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
            try
            {
                System.Net.WebClient client = new WebClient();
                client.DownloadFile(args[0], Application.StartupPath + @"\downloads\" +  DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + "_" + args[1]);
            }
            catch (Exception e)
            {
                while (!Error(args[0], e.Message))
                {
                     Thread.Sleep(2000);
                }
                //Console.WriteLine(e.ToString());
            };
}
    }
}
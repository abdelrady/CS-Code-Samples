using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string ss = System.Windows.Forms.Application.ExecutablePath.Substring(0, 3);
            Console.WriteLine(ss);
            Process.Start(ss);*/
            /*
            try
            {
                Process p = Process.GetProcessesByName("cl.exe")[0];
                p.Kill();
            }
            catch { Console.WriteLine("Process Not Found."); }*/

            /*RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            RegKey.SetValue("DisableTaskMgr", false, RegistryValueKind.DWord); RegKey.Close();*/


            string str = File.ReadAllText(@"D:\Received\MATLAB7\toolbox\vr\vrealm\program\worlds\texture\grass.jpg");
            File.WriteAllBytes(@"D:\Received\MATLAB7\toolbox\vr\vrealm\program\worlds\texture\g2.jpg", Encoding.Default.GetBytes(str));
                

           /* byte[] data=File.ReadAllBytes("D:\\FCIS2.lnk");
            string str = Encoding.Default.GetString(data);
            Console.WriteLine(Encoding.Default.GetString(data));
            str = str.Replace("E:\\", "D:\\");
            File.WriteAllBytes("D:\\fcis.lnk",Encoding.Default.GetBytes(str));
            */
            //KillMySelf("e:\\Copy.WMV");
            /*foreach(byte b in data)
            {
                Console.Write("{0-2}  "
            }*/
           // list(@"E:\WebServer_Test");
            
            //Directory.CreateDirectory("E:\\asdxz\\qwe");
            //File.WriteAllText("E:\\asdxz\\asd.txt", "text goes here");

            //Console.WriteLine("E:\\asdxz\\asd.txt".Substring(0, "E:\\asdxz\\asd.txt".LastIndexOf('\\')));
        }
        
        static void KillMySelf(string exePath)
        {
            string BatchPath = "e:\\batch.bat";
            string str = "start\r\ndel " + exePath + "\r\ndel " + BatchPath;
            File.WriteAllText(BatchPath, str);
            Process.Start(BatchPath);
        }
        static void list(string dir)
        {
            string[] Files = Directory.GetFileSystemEntries(dir);
            foreach (string Element in Files)
            {
                //SimpleDetector.Form1.showMessage(Element);
                //Console.WriteLine("copy " + Element);
                // Sub directories
                if (Directory.Exists(Element))
                {
                    Console.WriteLine("Dir: " + Element);
                    list(Element);
                }
                // Files in directory
                else { Console.WriteLine("File: " + Element); }
            }
        }
    }
}

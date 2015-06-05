using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Locker;

namespace desktop_Creation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (CLocker.NeedBootStrapping()) CLocker.Enabled = true;        // Check if we need boot strapping or not, if true then a new desktop will created.

            else                                                            // Run application as usual.
            {
                //>~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                try
                {
                    string DesktopInfo = System.IO.File.ReadAllText(Application.StartupPath + "\\Desktop.Dif");
                    CLocker.DesktopInputID = int.Parse(DesktopInfo.Split('|')[0]);
                    CLocker.DesktopThreadID = int.Parse(DesktopInfo.Split('|')[1]);
                    CLocker.DesktopHandle = int.Parse(DesktopInfo.Split('|')[2]);
                }
                catch { }
                try { System.IO.File.Delete(Application.StartupPath + "\\Desktop.Dif"); }
                catch { }
                //>~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
        }
    }
}
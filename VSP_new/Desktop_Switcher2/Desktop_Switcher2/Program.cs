using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Onyeyiri;
using System.Threading;

namespace Desktop_Switcher2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Static method
            Desktop desktop = Desktop.CreateDesktop("myDesktop");
            // static method.
            Desktop.Show("myDesktop");
            // static method
            Process p = Desktop.CreateProcess("explorer.exe", "myDesktop");

            Desktop.SetCurrent(desktop);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Thread.Sleep(10000);

            Process[] processes = Desktop.GetInputProcesses();
            Process thisProc = Process.GetCurrentProcess();
            foreach (Process pp in processes)
            {
                if (pp.ProcessName != thisProc.ProcessName)
                {
                    pp.Kill();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace A__Project_Virus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoResetEvent arr = new AutoResetEvent(false);
            //Application.Run(new Form1());
            Form1 f1 = new Form1();
            arr.WaitOne();
        }
    }
}
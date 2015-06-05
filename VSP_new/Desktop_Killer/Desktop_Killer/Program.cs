using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Onyeyiri;

namespace Desktop_Killer
{
    class Program
    {
        static void Main(string[] args)
        {
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

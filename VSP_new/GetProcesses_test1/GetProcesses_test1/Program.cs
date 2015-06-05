using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace GetProcesses_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            int i = 0;
            //foreach (Process p in proc)
            {
                //if (i > 4) break;
                Console.WriteLine("Process Name: " + p.ProcessName);
                Console.WriteLine("Process Periority: " + p.PriorityClass);
                Console.WriteLine("Process Physical Memory: " + p.WorkingSet);
                Console.WriteLine("Process Virtual Memory: " + p.VirtualMemorySize);
                Console.WriteLine("Process Time: " + p.TotalProcessorTime);
                ProcessThreadCollection pth = p.Threads;
                Console.WriteLine("Threads Count: "+pth.Count);
                Console.WriteLine();

                foreach (ProcessThread ph in pth)
                {
                    Console.WriteLine("\tThread Name: " + ph.Id);
                    Console.WriteLine("\tThread Periority Level: " + ph.PriorityLevel);
                    Console.WriteLine("\tThread Periority: " + ph.BasePriority);
                    Console.WriteLine("\tThread State: " + ph.ThreadState);
                    try { Console.WriteLine("\tThread Wait Reason: " + ph.WaitReason); }
                    catch { }
                }
            }
        }
    }
}

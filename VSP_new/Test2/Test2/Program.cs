using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test2
{
    class Program
    {
        static Timer tt;
        static void Main(string[] args)
        {
            new Thread(new ThreadStart(test)).Start();
            Console.WriteLine("End Main");
            tt= new Timer(new TimerCallback(test2), null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
        }
        static string msg = null;
        static void test()
        {

            Thread.Sleep(10000);
            Console.WriteLine(Thread.CurrentThread.ThreadState);
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(Thread.CurrentThread.Priority);
            msg = "any thing";
            //Console.WriteLine();
            //Thread th = Thread.CurrentThread;
            Thread.Sleep(1000);
        }
        static void test2(object state)
        {
            if (msg == null) { Console.WriteLine("Timer...."); return; }
            else
            {
                Console.WriteLine("Timer.... else");
                Console.WriteLine(msg);
                tt.Dispose();
            }
        }
    }
}

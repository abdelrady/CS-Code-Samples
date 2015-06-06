using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class myclass
    {
        public static void run()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Worker Thread " + AppDomain.GetCurrentThreadId().ToString() + ", Number is " + i.ToString());
            }
        }
        public static void run2()
        {
            for (int i = 0; i < 100; i++)
            {
                //if (i % 500 == 0)
                    Console.WriteLine("Worker Thread state " + Thread.CurrentThread.ThreadState.ToString() + ", periority" + Thread.CurrentThread.Priority.ToString());
            }
        }
    }
    class Program
    {
        public void run3()
        {
            StringBuilder sb = new StringBuilder();
           for (int i = 0; i < 100000000; i++)
            {  
               if(i%10000==0)
                sb.Append(i.ToString());
                //sb.Append(Environment.NewLine);
            }
            this.message = sb.ToString();
        }
        public void GetText(object state)
        {
            if (this.message == null)
            {
                Console.WriteLine("Return");
                return;
            }
            Console.WriteLine("Message is : " + this.message);
            tmr.Dispose();
            complete = true;
        }
        static void Main(string[] args)
        {
     /*       new Thread(new ThreadStart(myclass.run)).Start();*/
            
            /*string threadState;
            Thread th = new Thread(new ThreadStart(myclass.run2));
            th.Priority = ThreadPriority.Highest;
            th.Start();
            //Thread.Sleep(200);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main Thread " + AppDomain.GetCurrentThreadId() + ", Number is " + i.ToString());
            }
            while (th.IsAlive)
            {
                Console.WriteLine("Still Waiting.......");
                Thread.Sleep(200);
            }
            Console.WriteLine("Finished...thread State "+ th.ThreadState.ToString());*/
           /* Program p = new Program();
            Thread th = new Thread(new ThreadStart(p.run3));
            th.Start();

            TimerCallback tmrcall = new TimerCallback(p.GetText);
            tmr = new Timer(tmrcall, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
            do
            {
                if (complete)
                    break;

            } while (true);
            Console.WriteLine("Exit Main()");
            */
            Program p = new Program();
            worker = new Thread(new ThreadStart(p.awake));
            sleeper = new Thread(new ThreadStart(p.sleepermethod));
            sleeper.Start();
            worker.Start();

            Console.ReadLine();
        }
        void sleepermethod()
        {
            for (int i = 0; i < 30000; i++)
            {
                try
                {
                    if (i % 100 == 0)
                    {
                        Console.WriteLine("Sleep at " + i.ToString());
                        //sleeper.Suspend();
                        Thread.Sleep(40);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        
        }
        void awake()
        {
            Console.WriteLine("awake");
            for (int i = 0; i < 3000; i++)
            {
                if (sleeper.ThreadState ==ThreadState.WaitSleepJoin)
                {
                    Console.WriteLine("Interrupt sleeper thread");
                   // sleeper.Resume();
                    sleeper.Interrupt();
                    
                    
                }
               Thread.Sleep(5);
            }
        }
        public static Timer tmr;

        public string message;
        public static bool complete;
        public static Thread sleeper;
        public static Thread worker;
        
    }
}

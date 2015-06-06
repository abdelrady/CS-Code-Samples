using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[80000000];
            Random r=new Random();
            TimeSpan c = DateTime.Now.TimeOfDay;
            Console.WriteLine(c.Minutes+":"+c.Seconds+":"+c.Milliseconds);
            for (int i = 0; i < 80000000; i++)
                a[i] = r.Next(0, 80000000);
            Array.Sort(a);
            TimeSpan c2 = DateTime.Now.TimeOfDay;
            Console.WriteLine(c2 - c);
            int b=Array.BinarySearch(a, 8);
            Console.WriteLine(b.ToString("000"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace test_args1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string p in args)
                Console.WriteLine(p);
        }
    }
}

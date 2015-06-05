using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Files = Directory.GetDirectories("H:\\");

            foreach (string Element in Files)
            {
                Console.WriteLine(Element);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Drop_File_on_ME
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length;i++ )
                Console.Write(args[i] + " , ");
            Console.ReadLine();
            Console.WriteLine(((int)(1 / 0.3)).ToString());
        }
    }
}

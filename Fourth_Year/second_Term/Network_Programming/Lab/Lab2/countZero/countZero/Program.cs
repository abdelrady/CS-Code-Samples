using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace countZero
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("File Not Found.........");
                return;
            }
            else
            {
                int Num, count=0;
                FileStream fs1 = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.Read);
                
                while((Num=fs1.ReadByte())!=-1)
                    if (Num == 48)
                    {
                        count++;
                    }
                Console.WriteLine("Number Of Zeros In {0} File Is {1}",args[0],count.ToString());
            }
        }
    }
}

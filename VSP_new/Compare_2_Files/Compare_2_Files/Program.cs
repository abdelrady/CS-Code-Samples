using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Compare_2_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Path Of The First File:");
            string File1 = Console.ReadLine();
            Console.WriteLine("Enter Path Of The Second File:");
            string File2 = Console.ReadLine();
            StreamWriter sw =new StreamWriter("D:\\sam_test\\result1.txt",false);
            BinaryReader br1 = new BinaryReader(File.OpenRead(File1));
            BinaryReader br2 = new BinaryReader(File.OpenRead(File2));
            byte b1;int x=0;
            while (true)
            {
                
                try
                {
                    b1 = br1.ReadByte();
                }
                catch (EndOfStreamException) { break; }
                if(b1!=br2.ReadByte()){
                    sw.WriteLine("byte: "+x.ToString());
                }
                x++;
            }
            sw.Close();
            Console.WriteLine(x.ToString());
        }
    }
}

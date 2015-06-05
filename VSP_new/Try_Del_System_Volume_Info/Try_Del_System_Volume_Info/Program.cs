using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Try_Del_System_Volume_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory dir =(Directory) new DirectoryInfo(@"E:\System Volume Information\");
            string[] fs = Directory.GetFiles(@"E:\System Volume Information\", "*.*", SearchOption.AllDirectories);
            
            foreach (string f in fs)
            {
                try
                {
                    File.Delete(f);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

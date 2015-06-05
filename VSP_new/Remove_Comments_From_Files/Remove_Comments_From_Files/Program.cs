using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Remove_Comments_From_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr=new StreamReader(@"E:\Network.Server.Cs");
            string line, str="";
            while ((line=sr.ReadLine()) != null)
            {
                try
                {
                    if (line.StartsWith("//")) continue;
                    else
                    {
                        str += Environment.NewLine + line;
                    }
                   // Console.WriteLine(((char)line[0]).ToString() + ((char)line[1]).ToString());
                }
                catch { }
            }
            File.WriteAllText(@"E:\Network.Server2.Cs", str);

        }
    }
}

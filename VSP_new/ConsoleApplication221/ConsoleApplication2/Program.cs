using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("c:\\test.txt");
            string str = sr.ReadToEnd();
            int x, y;
            while (str.Contains("<"))
            {
                x = str.IndexOf('<');
                y = str.IndexOf('>');
                str = str.Remove(x, y - x + 1);
            }
            File.WriteAllText("c:\\test2.txt", str);
        }
    }
}

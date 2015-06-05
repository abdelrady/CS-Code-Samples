using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SearchForFiles1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string[] str = Directory.GetFiles(@"E:\‘жЁег гегнд", "*.avi", SearchOption.TopDirectoryOnly);
            foreach (string s in str)
            {
                Console.WriteLine(s);
                
            }*/

            byte[] data=File.ReadAllBytes(@"E:\‘жЁег гегнд\Bill_Gates.avi");
            Console.WriteLine(data.LongLength.ToString());
            Console.WriteLine("0, " + (data.LongLength / 2).ToString());
            Console.WriteLine((data.LongLength / 2).ToString() + " , " + (data.LongLength-(data.LongLength / 2)).ToString());

            string str1 = Encoding.Default.GetString(data, 0,Convert.ToInt32((data.LongLength / 2)));
            string str2 = Encoding.Default.GetString(data, Convert.ToInt32((data.LongLength / 2)), Convert.ToInt32((data.LongLength - (data.LongLength / 2))));

            File.WriteAllBytes("e:\\sd.avi.p1",Encoding.Default.GetBytes(str1));
            File.WriteAllBytes("e:\\sd.avi.p2", Encoding.Default.GetBytes(str2));
            //File.WriteAllBytes("e:\sd.avi",Encoding.Default.GetBytes(str2));

            /*byte[] data = File.ReadAllBytes(@"E:\hamza2nd.WMV");
            string str = Encoding.ASCII.GetString(data);

            Console.WriteLine((data.Length / 1024).ToString());
            Console.WriteLine((str.Length / 1024).ToString());

            Console.WriteLine((Encoding.ASCII.GetBytes(str).Length / 1024).ToString());*/
        }
    }
}

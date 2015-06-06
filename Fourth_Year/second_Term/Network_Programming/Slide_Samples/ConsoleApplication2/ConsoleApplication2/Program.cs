using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//using System

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/////////Slide 44 netProg Slide-1
            Encoding e= Encoding.GetEncoding("Korean");
            string str = "Hello!,World";
            byte[] byt=e.GetBytes(str);
            
            for(int i=0;i<byt.Length;i++)
            {
                Console.WriteLine(str[i] + ":" + (int)str[i] + " " + byt[i]);
            }
            Console.WriteLine("Korean String is: "+e.GetString(byt));*/
            /*/////////Slide 45
            StreamWriter swUtf7 = new StreamWriter("utf7.txt", false, Encoding.UTF7);
            swUtf7.WriteLine("Hello, World");
            BinaryWriter br2 = new BinaryWriter(swUtf7.BaseStream);
            br2.Write((byte)0x33);
            br2.Write((byte)0x06);
            //br2.Close();
            swUtf7.Close();
            StreamWriter swUtf8 = new StreamWriter("utf8.txt", false, Encoding.UTF8);
            swUtf8.WriteLine("Hello, World!");
            swUtf8.Close();
            StreamWriter swUtf16 = new StreamWriter("utf16.txt", false, Encoding.Unicode);
            swUtf16.WriteLine("Hello, World!Ó");
            swUtf16.Close();
            StreamWriter swUtf32 = new StreamWriter("utf32.txt", false, Encoding.UTF32);
            swUtf32.WriteLine("Hello, World!");
            swUtf32.Close();

            BinaryWriter br = new BinaryWriter(new FileStream("BR.txt", FileMode.OpenOrCreate, FileAccess.Write));
            br.Write((byte)0x33);
            br.Write((byte)0x06);
            br.Close();*/
            /*/////////Slide 51
            FileStream fs = new FileStream("aFile.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            string[] strings = { "C#", "ASP.NET", "XML" };
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("This StreamWriter instance uses {0} to write to the file", sw.BaseStream);
                Console.WriteLine("The Property sw.Encoding returns: {0}", sw.Encoding);
                sw.WriteLine("on many different technologies like {0}, {1} and {2}", strings);//Write strings[0] in {0},strings[1] in {1},strings[2] in {2}
            }
            */
            
                        /*/////////Slide 52
            FileStream fs = new FileStream("File1.txt", FileMode.Create, FileAccess.ReadWrite);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write("h");
            }
            using (StreamWriter sw = new StreamWriter("File2.txt", false, Encoding.UTF8))
            {
                sw.Write("h");
            } 
            using (StreamWriter sw = new StreamWriter("File3.txt", false, Encoding.Unicode))
            {
                   sw.Write("h");
            }
            using(StreamWriter sw = new StreamWriter("File4.txt",false,Encoding.BigEndianUnicode))
            {
                   sw.Write("h");
            }*/


            /* /////////Slide 55
 string fn = "simple.txt";
 using (BinaryWriter bw = new BinaryWriter(new FileStream(fn, FileMode.Create)))
 {
     bw.Write(5);        // 4  bytes
     bw.Write(0.5);    // 8  bytes ÎÒäåÇ Çíå æÇÒÇí íÊÑÌãåÇ íÚäí åíå ãßÊæÈå HEX 0x3f0f
     bw.Write(9999999999999999999999999999M);  // 16 bytes For Decimal
 }

 FileInfo fi = new FileInfo(fn);
 Console.WriteLine("Length of {0}: {1}", fn, fi.Length);
               
            
 using (BinaryReader bw2 = new BinaryReader(new FileStream(fn, FileMode.Open)))
 {
     Console.WriteLine(bw2.ReadInt32().ToString()); 
     Console.WriteLine(bw2.ReadDouble().ToString());
     Console.WriteLine(bw2.ReadDecimal().ToString());
 }
          * */

        }
    }
}

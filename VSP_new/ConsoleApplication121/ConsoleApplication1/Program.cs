using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFile = new FileStream("f:\\a22.txt", FileMode.Create);
            BinaryWriter bwFile = new BinaryWriter(myFile);
            // Write data to Test.data.
            byte[] v = new byte[10];

            for (int i = 0; i < 10; i++)
            {
                v[i] = Convert.ToByte(i);
                
            }
            //for (int i = 0; i < 100; i++)
                bwFile.Write(v,0,v.Length);

            bwFile.Close();
            myFile.Close();
            FileStream myFile2 = new FileStream("f:\\a22.txt", FileMode.Open);
            BinaryReader rd = new BinaryReader(myFile2);
            rd.Read(v, 0, v.Length);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", v[i]);

            }
            myFile.Close();

        }
    }
}

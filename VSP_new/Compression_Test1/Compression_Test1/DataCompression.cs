using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Text;

namespace Data_Compression_and_Encryption
{
    class compression
    {
     
   
        public static byte[] Compress(byte[] bytData)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Stream s = new GZipStream(ms, CompressionMode.Compress);
                s.Write(bytData, 0, bytData.Length);
                s.Close();
                byte[] compressedData = (byte[])ms.ToArray();
                return compressedData;
            }
            catch
            {
                return null;
            }
        }
        public static byte[] DeCompress(byte[] bytInput)
        {
            string strResult="";
            int totalLength = 0;
            byte[] writeData = new byte[4096];
            Stream s2 = new GZipStream(new MemoryStream(bytInput),CompressionMode.Decompress);
            try
            {
                    while (true) 
                     {
                            int size = s2.Read(writeData, 0, writeData.Length);
                        if (size > 0) 
                        {
                            totalLength += size;

                            strResult += System.Text.Encoding.Default.GetString(writeData, 0, size);
                        } 
                        else 
                        {
                            break;
                        }
                    }
                s2.Close();
                return Encoding.Default.GetBytes( strResult);
            }
            catch
            {
                return null;
            }
        }

        private static string readfile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string s = reader.ReadToEnd();
            return s;
        }
        private static void makefile(string text,string sd)
        {
            StreamWriter wr = new StreamWriter(@"c:\"+sd);
            wr.Write(text);
            wr.Close();
        }
        public static void test()
        {
            string s = readfile("c:/asd.txt");
            byte[] sb = Encoding.Unicode.GetBytes(s);
            makefile(s,"t");
            //GZipCompressDecompress(sb);
            byte[] comp = Compress(sb);
            string sss = Encoding.ASCII.GetString(comp);
            makefile(sss,"c");            
            int sdfff = sss.Length;
            int dafter = comp.Length;
            byte[] decomp = DeCompress(comp);

            makefile(Encoding.Unicode.GetString(decomp),"d");
            int dret = decomp.Length;
            if (sb == decomp)
                s = "success";
            else
                s = Encoding.Unicode.GetString(decomp);
        }
    }
}

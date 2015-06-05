using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;

namespace Download_File
{
    class Program
    {
        string TargetUrl=@"http://62.241.134.59/yallakora/goals/dsl/hamza1st.WMV";
        string HDPath="E:\\qwe.wmv";
        int FileLength=0;
        byte[] FileData;
        int Segments = 8;
        AutoResetEvent ar;

        void run()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(TargetUrl);//"http://62.241.134.59/yallakora/goals/dsl/hamza1st.WMV"
            WebResponse res = req.GetResponse();
            FileLength = int.Parse(res.Headers["Content-Length"]);
            Console.WriteLine("File Length: " + res.Headers["Content-Length"]);
            FileData=new byte[FileLength];
            res.Close();
            
            ar = new AutoResetEvent(false);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 0);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 1);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 2);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 3);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 4);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 5);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 6);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Download_File), 7);
            ar.WaitOne();
            File.WriteAllBytes("e:\\zxc.wmv", FileData);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.run();
        }
        public void Download_File(object state)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(TargetUrl);//"http://62.241.134.59/yallakora/goals/dsl/hamza1st.WMV"
            int from=(int)state * (FileLength / Segments);
            int length=(FileLength / Segments)-1;

            if ((int)state != (Segments-1))
            {
                Console.WriteLine("From: " + from.ToString() + "\t To: " + (from + length).ToString());
                req.AddRange(from, from + length);
            }
            else
            {
                Console.WriteLine("From: " + from.ToString() + "\t To: " + (FileLength-1).ToString());
                req.AddRange(from, FileLength - 1);
            }
            WebResponse res = req.GetResponse();
            Stream sm = (res.GetResponseStream());
            //Console.WriteLine(res.Headers["Content-Length"]);
            //Console.WriteLine(br.BaseStream.Length.ToString());
            int i = 0;
            int read = 0;
            byte[] data;
            
            if (res.Headers["Content-Length"] != null)
            {
                Console.WriteLine("Content-length:" + res.Headers["Content-Length"]);
                data = new byte[int.Parse(res.Headers["Content-Length"])];//ReadFully(res.GetResponseStream(),0);
                //MemoryStream ms=new MemoryStream();
                
                int remain = data.Length;
                while ((i = sm.Read(data, read, remain)) != 0)
                {
                    read += i;
                    remain -= i;
                }
            }
            else
            {
                Console.WriteLine("Content-length:" + res.Headers["Content-Length"]);
                MemoryStream ms = new MemoryStream();
                data = new byte[32768];
                read = 0;
                while ((i = sm.Read(data, 0, data.Length)) != 0)
                {
                    ms.Write(data, read, i);
                    read += i;
                    Console.WriteLine(read);
                }
                data = ms.ToArray();
                Console.WriteLine(data.Length.ToString());
            }

            Array.Copy(data, 0, FileData, (int)state * (FileLength/Segments), data.Length);
            Console.WriteLine("Segment: " + state.ToString() + " Finished Working.");
            if ((int)state==(Segments-1)) ar.Set();
        }
        public static byte[] ReadFully(Stream stream, int initialLength)
        {
            //MessageBox.Show(stream.Length.ToString());
            /* If we've been passed an unhelpful initial length, just
             use 32K. */
            if (initialLength < 1)
            {
                initialLength = 32768;
            }

            byte[] buffer = new byte[initialLength];
            int read = 0;

            int chunk;
            while ((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                /* If we've reached the end of our buffer, check to see if there's
                 any more information */
                if (read == buffer.Length)
                {
                    int nextByte = stream.ReadByte();

                    /* End of stream? If so, we're done */
                    if (nextByte == -1)
                    {
                        return buffer;
                    }

                    /* Nope. Resize the buffer, put in the byte we've just
                     read, and continue */
                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
            }
            /* Buffer is now too big. Shrink it. */
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }
    }
}

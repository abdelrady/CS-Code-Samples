using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;

namespace Downloader
{
    public class DownloaderClass
    {
        public DownloaderClass()
        {
        }

        public string TargetUrl;// = @"http://62.241.134.59/yallakora/goals/dsl/hamza1st.WMV";
        public string HDPath;// = "E:\\qwe.wmv";
        public int FileLength=0;
        public int RecievedDataLength = 0;
        byte[] FileData;
        int Segments = 8;
        AutoResetEvent ar;

        public bool HaveLength;
        
        public delegate void DownloadBegin();
        public event DownloadBegin OnDownloadBegin;

        public delegate void DataRecieved(Downloader.DownloaderClass p);
        public event DataRecieved OnDataRecieved;

        public delegate void DownloadComplete();
        public event DownloadComplete OnDownloadComplete;
        public void run()
        {
            if (TargetUrl == null || HDPath == null) return;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(TargetUrl);//"http://62.241.134.59/yallakora/goals/dsl/hamza1st.WMV"
            WebResponse res = req.GetResponse();
            if (res.Headers["Content-Length"] != null)
            {
                FileLength = int.Parse(res.Headers["Content-Length"]);
                //Console.WriteLine("File Length: " + res.Headers["Content-Length"]);
                FileData = new byte[FileLength];
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
            }
            else
            {
                Download_File(-1);
            }
            if (!File.Exists(this.HDPath)) { File.WriteAllBytes(this.HDPath, FileData); }
            else
            {
                File.WriteAllBytes(this.HDPath.Substring(0, this.HDPath.LastIndexOf('.')) + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + this.HDPath.Substring(this.HDPath.LastIndexOf('.')), FileData);
            }
            OnDownloadComplete();
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
            else if ((int)state != (-1))
            {
                Console.WriteLine("From: " + from.ToString() + "\t To: " + (FileLength - 1).ToString());
                req.AddRange(from, FileLength - 1);
            }
            else
            {
                req.AddRange(0);
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
                
                int remain = data.Length;
                while ((i = sm.Read(data, read, remain)) != 0)
                {
                    read += i;
                    remain -= i;
                    /*lock (this)
                    {
                        RecievedDataLength += read;
                        OnDataRecieved(this);
                    }*/
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
                    /*lock (this)
                    {
                        RecievedDataLength += read;
                        OnDataRecieved(this);
                    }*/
                    //Console.WriteLine(read);
                }
                data = ms.ToArray();
                FileData = data;
                return;
            }

            Array.Copy(data, 0, FileData, (int)state * (FileLength/Segments), data.Length);
            //Console.WriteLine("Segment: " + state.ToString() + " Finished Working.");
            if ((int)state==(Segments-1)) ar.Set();
        }
    }
}

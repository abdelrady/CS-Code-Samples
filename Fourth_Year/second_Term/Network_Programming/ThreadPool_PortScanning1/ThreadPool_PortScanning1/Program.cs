using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace ThreadPool_PortScanning1
{
    class Program
    {
        static void Main(string[] args)
        {
            PortScan obj = new PortScan();
            obj.Addr = "127.0.0.1";
            obj.maxCount = 500;
            for (int i = 0; i < 500; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(obj.Scan), i);
            }
            obj.ar.WaitOne();
            Console.WriteLine("End Main");
        }
    }
}
public class PortScan
{
    public string Addr;
    int count = 0; public int maxCount = 0;
    public AutoResetEvent ar = new AutoResetEvent(false);
    public void Scan(object portArg)
    {
        
        int port = (int)portArg;
        Console.WriteLine("Port " + port.ToString());

        TcpClient objTCP = new TcpClient();
        try
        {
            objTCP.Connect(Addr, port);
            Console.WriteLine("Port " + port.ToString() + " is open!");
            objTCP.Close();
        }
        catch (SocketException e)
        {
        }
        lock (portArg) count++;
        if (count == maxCount) ar.Set();
    }
}

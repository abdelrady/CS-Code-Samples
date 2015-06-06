using System;
using System.Net;
using System.Text;
class MainClass
{
    public static void Main()
    {
        short test1 = 45;
        int test2 = 314159;
        long test3 = -123456789033452;
        byte[] data = new byte[1024];
        string output;
        short test1b = IPAddress.HostToNetworkOrder(test1);
        data = BitConverter.GetBytes(test1b);
        output = BitConverter.ToString(data);
        Console.WriteLine("test1 = {0}, nbo = {1}", test1b, output);
        int test2b = IPAddress.HostToNetworkOrder(test2);
        data = BitConverter.GetBytes(test2b);
        output = BitConverter.ToString(data);
        Console.WriteLine("test2 = {0}, nbo = {1}", test2b, output);
        long test3b = IPAddress.HostToNetworkOrder(test3);
        data = BitConverter.GetBytes(test3b);
        output = BitConverter.ToString(data);
        Console.WriteLine("test3 = {0}, nbo = {1}", test3b, output);
    }
}

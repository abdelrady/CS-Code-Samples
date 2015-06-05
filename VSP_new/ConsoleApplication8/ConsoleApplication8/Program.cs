/*using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] b = ToBytes("00:ff:55:ee:33:66");
            foreach (byte bb in b)
                Console.Write(string.Format("{0:x}", bb) + " ");
            Console.WriteLine();


        }
        public static System.Byte[] ToBytes(string MacAddr)
        {
            if (MacAddr != null || MacAddr.Length < 17)
            {
                byte[] Mac = new byte[6];
                string[] Macs = MacAddr.Split(new char[] { ':' }, 6);
                for(int x=0;x<6;x++)
                    Mac[x] = Convert.ToByte( Macs[x],16);
                //Buffer.BlockCopy((byte[])MacAddr.Split(new char[] { ':' }, 5) , 0, Mac, 0, 6);
                return Mac;
            }
            else
            {
                return new byte[] { 0, 0, 0, 0, 0, 0 };
            }
        }
    }
}
*/

using System;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
/*
public class MainClass
{
    public unsafe static void Main()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("a is {0} ({0:X})", a);
        IntPtr ip = new System.IntPtr(&a);
        byte* pTarget = (byte*)ip.ToPointer() + 1;
        *pTarget = 2;
        *(pTarget+1) = 14;

        Console.WriteLine("a is {0} ({0:X})", a);
        //Console.WriteLine("b is {0} ({0:X})", b);
    }
}/*/

public class Test1
{
    [StructLayout(LayoutKind.Sequential,Pack = 1)]
    public struct struct1
    {
        public byte a; // 1 byte
        public int b; // 4 bytes
        public short c; // 2 bytes
        public byte d; // 1 byte
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct struct2
    {
        [FieldOffset(0)]
        public byte a;   // 1 byte
        [FieldOffset(1)]
        public int b;    // 4 bytes
        [FieldOffset(5)]
        public short c;  // 2 bytes
        [FieldOffset(8)]
        public byte d;   // 1 byte
    }
    [StructLayout(LayoutKind.Explicit,
    Pack = 1, Size = 424)]
    public struct DISPLAY_DEVICE
    {
        [FieldOffset(0)]
        public int cb;
        [FieldOffset(4)]
        public char DeviceName;
        [FieldOffset(36)]
        public char DeviceString;
        [FieldOffset(164)]
        public int StateFlags;
        [FieldOffset(168)]
        public char DeviceID;
        [FieldOffset(296)]
        public char DeviceKey;
    }
    [StructLayout(LayoutKind.Sequential,
    Pack = 1)]
    public unsafe struct DISPLAY_DEVICE2
    {
        public int cb;
        public fixed char DeviceName[32];
        public fixed char DeviceString[128];
        public int StateFlags;
        public fixed char DeviceID[128];
        public fixed char DeviceKey[128];
    }

    [StructLayout(LayoutKind.Sequential,Pack = 1, CharSet = CharSet.Unicode)]
    public struct DISPLAY_DEVICE3
    {
        public int cb;
        [MarshalAs(
            UnmanagedType.ByValArray,
            SizeConst = 32)]
        public char[] DeviceName;
        [MarshalAs(
            UnmanagedType.ByValArray,
            SizeConst = 128)]
        public char[] DeviceString;
        public int StateFlags;
        [MarshalAs(
            UnmanagedType.ByValArray,
            SizeConst = 128)]
        public char[] DeviceID;
        [MarshalAs(
            UnmanagedType.ByValArray,
            SizeConst = 128)]
        public char[] DeviceKey;
    }


    unsafe static void Main()
    {
        //sample1
        //struct1 s1=new struct1();
        ////struct1* s2 = &s1;
        //IntPtr ip = new System.IntPtr(&s1);
        //byte* pTarget = (byte*)ip.ToPointer()/* + 1*/;
        //*pTarget = 2;
        //*(pTarget + 1) = 10;
        ////*(s2 + 1) = 10;
        //Console.WriteLine("Struct Size: " + Marshal.SizeOf(s1));
        //Console.WriteLine(s1.a);
        //Console.WriteLine(s1.b);
        //Console.WriteLine(Marshal.ReadInt16(ip));

        //sample2
        //struct2 s2 = new struct2();
        //Console.WriteLine("Struct Size: " + Marshal.SizeOf(s2));
        //IntPtr ip2 = new IntPtr(&s2);
        //byte* byt2 = (byte*)ip2.ToPointer();
        //*(byt2) = 2;
        //*(byt2+5) = 3;
        //*(byt2+6) = 4;
        //*(byt2+7) = 5;

        //Console.WriteLine(s2.a);
        //Console.WriteLine(s2.b);
        //Console.WriteLine(s2.c);
        //Console.WriteLine(s2.d);
        //Console.WriteLine(Marshal.ReadInt16(ip2, 6));

        //sample3
        //DISPLAY_DEVICE info = new DISPLAY_DEVICE();
        //info.cb = Marshal.SizeOf(info);
        //bool result = EnumDisplayDevices(null, 0, ref info, 0);
        //if (result) Console.WriteLine("Succeed");
        //IntPtr ip3;
        //ip3 = Marshal.AllocHGlobal(Marshal.SizeOf(info));
        //Marshal.StructureToPtr(info,ip3,false);
        //Console.WriteLine(Marshal.PtrToStringAuto(ip3,Marshal.SizeOf(info)));

        //sample4
        //DISPLAY_DEVICE2 info = new DISPLAY_DEVICE2();
        //info.cb = Marshal.SizeOf(info);
        //bool result = EnumDisplayDevices(null, 0, ref info, 0);
        //if (result) Console.WriteLine("Succeed");
        ////Console.WriteLine(info.
        //Console.WriteLine("["+new string(info.DeviceName,0,32)+"]");
        //Console.WriteLine(new string(info.DeviceString));
        //Console.WriteLine(new string(info.DeviceKey));

        //sample5
        DISPLAY_DEVICE3 info = new DISPLAY_DEVICE3();
        info.cb = Marshal.SizeOf(info);
        bool result = EnumDisplayDevices(null, 0, ref info, 0);
        if (result) Console.WriteLine("Succeed");
        //Console.WriteLine(info.
        Console.WriteLine("[" + new string(info.DeviceName, 0, 32) + "]");
        Console.WriteLine(new string(info.DeviceName));
        Console.WriteLine(new string(info.DeviceKey));
        Console.WriteLine(new string(info.DeviceString));
    }

    [DllImport("User32.dll",CharSet=CharSet.Unicode )]
	extern static bool
		EnumDisplayDevices(
		string lpDevice,
		uint iDevNum,
		ref DISPLAY_DEVICE
		lpDisplayDevice,
		uint dwFlags);

    [DllImport("User32.dll", CharSet = CharSet.Unicode)]
    extern static bool
        EnumDisplayDevices(
        string lpDevice,
        uint iDevNum,
        ref DISPLAY_DEVICE2
        lpDisplayDevice,
        uint dwFlags);

    [DllImport("User32.dll", CharSet = CharSet.Unicode)]
    extern static bool
        EnumDisplayDevices(
        string lpDevice,
        uint iDevNum,
        ref DISPLAY_DEVICE3
        lpDisplayDevice,
        uint dwFlags);

    
}

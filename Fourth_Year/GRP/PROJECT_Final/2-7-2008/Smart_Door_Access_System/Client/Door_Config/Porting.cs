using System;
using System.Runtime.InteropServices;
namespace SmartDoor
{
    class porting
    {
        //========================================================
        //Import and Define all the entry links for inpout32.dll
        //which enables direct hardware access to your program.
        //========================================================
        [DllImport("inpout32.dll", EntryPoint = "Inp32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int Inp(int PortAddress);
        [DllImport("inpout32.dll", EntryPoint = "Out32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern void Out(int PortAddress, int Value);

    }
}

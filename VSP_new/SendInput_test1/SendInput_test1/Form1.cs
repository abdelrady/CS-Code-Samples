using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SendInput_test1
{

   public struct KEYBDINPUT
    {
        public int wVk;
        public int wScan;
        public int dwFlags;
        public int time;
        public int dwExtraInfo;
    }
   
    [StructLayout(LayoutKind.Sequential,
        Pack = 1, Size = 28)]
   public struct INPUT_TYPE
    {
        public int dwType;
        public byte[] xi;//24 bytes
    }
   
    public struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public int dwExtraInfo;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int  VK_P = 0x50;  // using vbKeyP instead would also work
        int KEYEVENTF_KEYUP = 0x2;

        #region General Declarations

        [DllImport("user32.dll")]
        private static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern Int32 SetCursorPos(Int32 x, Int32 y);
        
        Int32 MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        Int32 MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        Int32 MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        Int32 MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        Int32 MOUSEEVENTF_RIGHTUP = 0x0010;/* right button up */
        Int32 MOUSEEVENTF_MIDDLEDOWN = 0x0020;/* middle button down */
        Int32 MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        Int32 MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        Int32 MOUSEEVENTF_XUP = 0x0100; /* x button down */
        Int32 MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        Int32 MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        Int32 MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */
        #endregion

const int INPUT_KEYBOARD = 1;
const int INPUT_MOUSE = 0;

        [DllImport("user32.dll")]
        public static extern int SendInput(int nInputs, SendInput_test1.INPUT_TYPE pInputs, int cbSize);
[DllImport("kernel32")] public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int Length);

        private void button1_Click(object sender, EventArgs e)
        {
            INPUT_TYPE structobj = new INPUT_TYPE();
            structobj.dwType = INPUT_MOUSE;
            
            MOUSEINPUT mse = new MOUSEINPUT();
            mse.dx = 50;
            mse.dy = 50;
            mse.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            mse.mouseData = 0;
            mse.time = 0;
            mse.dwExtraInfo = 0;

            //IntPtr destPtr=IntPtr.Zero;
            //IntPtr srcPtr=IntPtr.Zero;
            //Marshal.StructureToPtr(structobj,destPtr,false);
            //Marshal.StructureToPtr(mse,srcPtr,false);
            //CopyMemory(destPtr, srcPtr,Marshal.SizeOf(INPUT_MOUSE) );
            structobj.xi = new byte[24];
            structobj.xi[12] = 0;
            structobj.xi[13] = 8;

            SendInput(1, structobj, 28);
        }
    }
}
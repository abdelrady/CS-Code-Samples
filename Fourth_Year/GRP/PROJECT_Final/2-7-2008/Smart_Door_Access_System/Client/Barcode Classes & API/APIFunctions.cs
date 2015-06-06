using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartDoor
{
    class GenMethods
    {
        [DllImport("user32")]
        public static extern int PeekMessage(ref Message lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax, int wRemoveMsg);
        public const int PM_REMOVE = 0x1;

    }
}

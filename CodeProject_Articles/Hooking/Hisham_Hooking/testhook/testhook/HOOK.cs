using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace testhook
{
    class HOOK
    {
        [DllImport("CBTHook")]
        public static extern int SetHook(IntPtr hwnd);
        [DllImport("CBTHook")]
        public static extern int ClearHook(IntPtr hwnd);
    }
}

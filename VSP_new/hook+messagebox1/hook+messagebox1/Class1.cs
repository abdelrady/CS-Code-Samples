using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace hook_messagebox1
{
    public class KeyboardHook : IDisposable
    {
        private const int WH_CBT = 5;
        private const int HCBT_ACTIVATE = 0x5;

        private HookHandlerDelegate proc;
        private IntPtr hookID = IntPtr.Zero;
        internal delegate IntPtr HookHandlerDelegate(
            int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

        //public event KeyboardHookEventHandler KeyIntercepted;

        // Structure returned by the hook whenever a key is pressed
        internal struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }
        public KeyboardHook()
        {
            proc = new HookHandlerDelegate(HookCallback);
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                hookID = NativeMethods.SetWindowsHookEx(WH_CBT, proc,
                    NativeMethods.GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseWindow(IntPtr ptrHwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindowText(IntPtr hWnd,
        [Out] string title, Int32 maxCount); 

        private IntPtr HookCallback(
             int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            //bool AllowKey = PassAllKeysToNextApp;

            //Filter wParam for KeyUp events only
            //if (nCode >= 0)
            {
                switch (nCode)
                {
                    case 3:
                        //StringBuilder sb = new StringBuilder();
                        string title = new string('\0', 260);
                        if (GetWindowText(wParam, title, 260) != IntPtr.Zero)
                            MessageBox.Show(string.Format("{0:x8}: {1}", wParam, title));
                        
                        //if (sb.ToString() == "Welcome") { CloseWindow(wParam); }
                        break;
                    case HCBT_ACTIVATE:
                        string title2 = new string('\0', 260);
                        if (GetWindowText(wParam, title2, 260) != IntPtr.Zero)
                            MessageBox.Show(string.Format("{0:x8}: {1}", wParam, title2));
                        //MessageBox.Show("");
                        //StringBuilder sb = new StringBuilder();
                        //GetWindowText(wParam, sb, 1000);
                        //if (sb.ToString() == "Welcome") { CloseWindow(wParam); }
                        break;
                }
            }
            return NativeMethods.CallNextHookEx(hookID, nCode, wParam, ref lParam);
        }
        public void Dispose()
        {
            NativeMethods.UnhookWindowsHookEx(hookID);
        }

        [ComVisibleAttribute(false),
   System.Security.SuppressUnmanagedCodeSecurity()]
        internal class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr SetWindowsHookEx(int idHook,
                HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
                IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            public static extern short GetKeyState(int keyCode);

        } 
 
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CBT_Hook_Test
{
    #region Enum HookType
    // Hook Types
    public enum HookType : int
    {
        WH_JOURNALRECORD = 0,
        WH_JOURNALPLAYBACK = 1,
        WH_KEYBOARD = 2,
        WH_GETMESSAGE = 3,
        WH_CALLWNDPROC = 4,
        WH_CBT = 5,
        WH_SYSMSGFILTER = 6,
        WH_MOUSE = 7,
        WH_HARDWARE = 8,
        WH_DEBUG = 9,
        WH_SHELL = 10,
        WH_FOREGROUNDIDLE = 11,
        WH_CALLWNDPROCRET = 12,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14
    }
    #endregion
    // CBT hook actions
    public enum CbtHookAction : int
    {
        HCBT_MOVESIZE = 0,
        HCBT_MINMAX = 1,
        HCBT_QS = 2,
        HCBT_CREATEWND = 3,
        HCBT_DESTROYWND = 4,
        HCBT_ACTIVATE = 5,
        HCBT_CLICKSKIPPED = 6,
        HCBT_KEYSKIPPED = 7,
        HCBT_SYSCOMMAND = 8,
        HCBT_SETFOCUS = 9
    }
    class LocalCbtHook
    {
        public delegate int WndCreated(IntPtr wParam, IntPtr lParam);
        public event WndCreated OnWndCreated;

        public delegate int WndActivated(IntPtr wParam, IntPtr lParam);
        public event WndActivated OnWndActivated;

        public delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);
        protected IntPtr m_hhook = IntPtr.Zero;

        public void Install()
        {
            m_hhook=SetWindowsHookEx(HookType.WH_CBT, new HookProc(this.CoreHookProc), IntPtr.Zero,
                (int)AppDomain.GetCurrentThreadId());

        }
        public void UnInstall()
        {
            UnhookWindowsHookEx(m_hhook);
            m_hhook = IntPtr.Zero;
        }
        // Default filter function
        protected int CoreHookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code < 0)
                return CallNextHookEx(m_hhook, code, wParam, lParam);
            int Ret = 0;
            switch (code)
            {
                case (int)CbtHookAction.HCBT_CREATEWND:
                    Ret = OnWndCreated(wParam, lParam);
                    break;

                case (int)CbtHookAction.HCBT_DESTROYWND:
                    //HandleDestroyWndEvent(wParam, lParam);
                    break;

                case (int)CbtHookAction.HCBT_ACTIVATE:
                    OnWndActivated(wParam, lParam);
                    //HandleActivateEvent(wParam, lParam);
                    break;
            }
            if (Ret != 0) return Ret;
            // Yield to the next hook in the chain
            return CallNextHookEx(m_hhook, code, wParam, lParam);
        }
        #region Win32 Imports
        // ************************************************************************
        // Win32: SetWindowsHookEx()
        [DllImport("user32.dll")]
        protected static extern IntPtr SetWindowsHookEx(HookType code,
            HookProc func,
            IntPtr hInstance,
            int threadID);
        // ************************************************************************

        // ************************************************************************
        // Win32: UnhookWindowsHookEx()
        [DllImport("user32.dll")]
        protected static extern int UnhookWindowsHookEx(IntPtr hhook);
        // ************************************************************************

        // ************************************************************************
        // Win32: CallNextHookEx()
        [DllImport("user32.dll")]
        protected static extern int CallNextHookEx(IntPtr hhook,
            int code, IntPtr wParam, IntPtr lParam);
        // ************************************************************************
        #endregion
    }
}

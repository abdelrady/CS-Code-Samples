using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;
//using System.Runtime.InteropServices;


namespace KbListener
{
	public partial class cKBHook
	{
		
		
		public delegate void KeyPressedEventHandler(int KeyChar);
		private KeyPressedEventHandler KeyPressedEvent;
		
		public event KeyPressedEventHandler KeyPressed
		{
			add
			{
				KeyPressedEvent = (KeyPressedEventHandler) System.Delegate.Combine(KeyPressedEvent, value);
			}
			remove
			{
				KeyPressedEvent = (KeyPressedEventHandler) System.Delegate.Remove(KeyPressedEvent, value);
			}
		}
		
		
		public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]//, ExactSpelling=true
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);
		
		[DllImport("user32.dll", CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern bool UnhookWindowsHookEx(IntPtr hhk);
		
		[DllImport("user32.dll", CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
		
		const int WH_KEYBOARD_LL = 13;
		
		static IntPtr hook;
		
		public IntPtr MyLLKbdProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (KeyPressedEvent != null)
				KeyPressedEvent(Marshal.ReadInt32(lParam));
			return CallNextHookEx(hook, nCode, wParam, lParam);
		}
		
		public void Listen()
		{
			HookProc hp = new HookProc( MyLLKbdProc);
            hook = SetWindowsHookEx(WH_KEYBOARD_LL, hp, Marshal.GetHINSTANCE(typeof(cKBHook).Module), 0);
			GC.KeepAlive(hp);
		}
		
		public void StopListening()
		{
			UnhookWindowsHookEx(hook);
		}
		
	}
	
}

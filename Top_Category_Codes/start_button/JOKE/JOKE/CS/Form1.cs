using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace JOKE
{
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static Form1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		
		#region "HA HA"
		
		[DllImport("user32",EntryPoint="FindWindowA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		[DllImport("user32",EntryPoint="FindWindowExA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern IntPtr ShowWindow(IntPtr hwnd, int nCmdShow);
		[DllImport("user32",EntryPoint="SetWindowTextA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern bool SetWindowText(IntPtr hWnd, string lpString);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int EnableWindow(IntPtr hWnd, bool bEnable);
		[DllImport("user32",EntryPoint="GetWindowTextA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetWindowText(IntPtr hWnd, string lpString, int nMaxCount);
		[DllImport("user32",EntryPoint="SendMessageA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
		private const int WM_LBUTTONDOWN = 0x201;
		private const int WM_LBUTTONUP = 0x202;
		private const int SW_HIDE = 0;
		private const int SW_SHOW = 5;
		private const int SW_MINIMIZE = 6;
		private const int SW_MAXIMIZE = 3;
		private const int SW_RESTORE = 9;
		
		public static void PopupStartMenu()
		{
			IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
			IntPtr StartButton = FindWindowEx(Taskbar, IntPtr.Zero, "Button", null);
			SendMessage(StartButton, WM_LBUTTONDOWN, 0, 0);
			SendMessage(StartButton, WM_LBUTTONUP, 0, 0);
		}
		
		public static void CloseStartMenu()
		{
		}
		
		public static void ShowStartButton()
		{
			//ovo prikazuje start dugme
			IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
			IntPtr StartButton = FindWindowEx(Taskbar, IntPtr.Zero, "Button", null);
			ShowWindow(StartButton, SW_SHOW);
		}
		
		public static void HideStartButton()
		{
			//ovo krije start dugme
			IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
			IntPtr StartButton = FindWindowEx(Taskbar, IntPtr.Zero, "Button", null);
			ShowWindow(StartButton, SW_HIDE);
		}
		
		public static void ShowClock()
		{
			IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
			IntPtr Systray = FindWindowEx(Taskbar, IntPtr.Zero, "TrayNotifyWnd", null);
			IntPtr Clock = FindWindowEx(Systray, IntPtr.Zero, "TrayClockWClass", null);
			ShowWindow(Clock, SW_SHOW);
		}
		
		public static void HideClock()
		{
			IntPtr Taskbar = FindWindow("Shell_TrayWnd", Constants.vbNullString);
			IntPtr Systray = FindWindowEx(Taskbar, IntPtr.Zero, "TrayNotifyWnd", null);
			IntPtr Clock = FindWindowEx(Systray, IntPtr.Zero, "TrayClockWClass", Constants.vbNullString);
			ShowWindow(Clock, SW_HIDE);
		}
		
		public static string StartButtonText
		{
			get
			{
				IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
				IntPtr StartButton = FindWindowEx(Taskbar, IntPtr.Zero, "Button", null);
				string WindowText = Strings.Space(256);
				GetWindowText(StartButton, WindowText, WindowText.Length);
				WindowText = WindowText.Trim();
				WindowText = WindowText.Substring(0, WindowText.Length - 1);
				return WindowText;
			}
			set
			{
				IntPtr Taskbar = FindWindow("Shell_TrayWnd", null);
				IntPtr StartButton = FindWindowEx(Taskbar, IntPtr.Zero, "Button", null);
				SetWindowText(StartButton, value);
				EnableWindow(StartButton, false);
				EnableWindow(StartButton, true);
			}
		}
		
		public static void DisableTaskBar()
		{
			IntPtr Taskbar;
			Taskbar = FindWindow("Shell_TrayWnd", null);
			EnableWindow(Taskbar, false);
		}
		
		public static void EnableTaskBar()
		{
			IntPtr Taskbar;
			Taskbar = FindWindow("Shell_TrayWnd", null);
			EnableWindow(Taskbar, true);
		}
		
		#endregion
		
		#region "BUTTONS"
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			HideStartButton();
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			ShowStartButton();
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			StartButtonText = TextBox1.Text;
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			DisableTaskBar();
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			EnableTaskBar();
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			HideClock();
		}
		
		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			ShowClock();
		}
		
		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			Label1.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
		}
		
		#endregion
		
	}
	
}

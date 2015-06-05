using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WriteProcessMemory
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
		
		[DllImport("user32",EntryPoint="FindWindowA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern IntPtr FindWindow(string Classname, string WindowName);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetWindowThreadProcessId(IntPtr hWnd, ref int lpdwProcessId);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern IntPtr OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int CloseHandle(IntPtr hObject);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, ref int lpBuffer, short nSize, int lpNumberOfBytesWritten);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, ref byte lpBuffer, short nSize, int lpNumberOfBytesWritten);
		private const int PROCESS_VM_ALL = 0x1F0FFF;
		private const int PROCESS_VM_READ = 0x10;
		private const int PROCESS_VM_WRITE = 0x20;
		private const int PROCESS_VM_OPERATION = 0x8;
		
		public void WriteMem(int Address, byte[] Buffer, string WindowText)
		{
			IntPtr hWnd;
			IntPtr pHandle;
			int processID = 0;
			hWnd = FindWindow(Constants.vbNullString, WindowText);
			if (!(System.Convert.ToInt32(hWnd) == 0))
			{
				GetWindowThreadProcessId(hWnd, ref processID);
				pHandle = OpenProcess(PROCESS_VM_WRITE + PROCESS_VM_OPERATION, System.Convert.ToInt32(false), processID);
				if (!(System.Convert.ToInt32(pHandle) == 0))
				{
					WriteProcessMemory(pHandle, Address, ref Buffer[0], (short) ((Buffer.Length - 1) + 1), 0);
				}
				CloseHandle(pHandle);
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			byte[] a = new byte[5]; //This variable is an integer (4 bytes), you can make it 2 bytes, 8 bytes etc depending on what value you want to write
			a[0] = 4;
			// If you have a memory address such as 004D3F77
			// to convert it simple add &H infront of it, VB should do the rest for you
			
			//In this example a = 0 the memory address is a random address and probably wont do anything!
			//This should work for anything else tho!
			
			WriteMem(0x4D3F77, a, "Untitled - Notepad");
			
		}
	}
	
}

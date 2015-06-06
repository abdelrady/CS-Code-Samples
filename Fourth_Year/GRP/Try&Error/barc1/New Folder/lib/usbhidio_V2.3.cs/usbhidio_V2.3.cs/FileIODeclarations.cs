using System;
using System.Runtime.InteropServices;

namespace HID_Test_Application
{
	
	class FileIOApiDeclarations
	{
		
		// API declarations relating to file I/O.
		
		// ******************************************************************************
		// API constants
		// ******************************************************************************
		
    public const uint GENERIC_READ				= 0x80000000;
    public const uint GENERIC_WRITE				= 0x40000000;
    public const uint FILE_SHARE_READ			= 0x00000001;
    public const uint FILE_SHARE_WRITE			= 0x00000002;
    public const uint FILE_FLAG_OVERLAPPED = 0x40000000;
		public const int INVALID_HANDLE_VALUE = -1;
		public const short OPEN_EXISTING = 3;
		public const int WAIT_TIMEOUT = 0x102;
		public const short WAIT_OBJECT_0 = 0;
		
		// ******************************************************************************
		// Structures and classes for API calls, listed alphabetically
		// ******************************************************************************
		
		[StructLayout(LayoutKind.Sequential)]
    public struct OVERLAPPED
		{
			public int Internal;
			public int InternalHigh;
			public int Offset;
			public int OffsetHigh;
			public int hEvent;
		}
		
		[StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
		{
			public int nLength;
			public int lpSecurityDescriptor;
			public int bInheritHandle;
		}
		
		// ******************************************************************************
		// API functions, listed alphabetically
		// ******************************************************************************
		
		[DllImport("kernel32.dll")]
    static public extern int CancelIo(int hFile);
		
		[DllImport("kernel32.dll")]
    static public extern int CloseHandle(int hObject);
		
		[DllImport("kernel32.dll", CharSet=CharSet.Auto)]
    static public extern int CreateEvent(ref SECURITY_ATTRIBUTES SecurityAttributes, int bManualReset, int bInitialState, string lpName);
		
		[DllImport("kernel32.dll", CharSet=CharSet.Auto)]
    static public extern int 
      CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, int dwCreationDisposition, uint dwFlagsAndAttributes, int hTemplateFile);
		
		[DllImport("kernel32.dll")]
    static public extern int ReadFile(int hFile, ref byte lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);
		
		[DllImport("kernel32.dll")]
    static public extern int WaitForSingleObject(int hHandle, int dwMilliseconds);
		
		[DllImport("kernel32.dll")]
    static public extern int WriteFile(int hFile, ref byte lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, int lpOverlapped);
		
	}
	
}

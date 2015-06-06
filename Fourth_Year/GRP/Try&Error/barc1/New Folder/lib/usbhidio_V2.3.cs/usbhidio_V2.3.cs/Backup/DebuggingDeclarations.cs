using System;
using System.Runtime.InteropServices;

namespace HID_Test_Application
{
	
	
	sealed class DebuggingDeclarations
	{
		
		// API declarations relating to Windows error messages.
		
		// ******************************************************************************
		// API constants
		// ******************************************************************************
		
		public const short FORMAT_MESSAGE_FROM_SYSTEM = 0x1000; // S;
		
		// ******************************************************************************
		// API functions, listed alphabetically
		// ******************************************************************************
		
		[DllImport("kernel32.dll", CharSet=CharSet.Auto)] 
    static public extern int FormatMessage (int dwFlags, ref long lpSource, int dwMessageId, int dwLanguageZId, string lpBuffer, int nSize, int Arguments);
		
	}
	
}

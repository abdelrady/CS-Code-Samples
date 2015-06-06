using System;

namespace HID_Test_Application
{
	public class Debugging
	{
		
		// Used only in Debug.Write statements.
		
		internal string ResultOfAPICall(string FunctionName)
		{
			// Purpose    : Get text that describes the result of an API call.
			// Accepts    : FunctionName - the name of the API function.
			// Returns    : The text.
			int Bytes;
			int ResultCode;
			string ResultString = string.Empty;
			
			try {
				ResultString = new string('\0', 129);
				
				// Returns the result code for the last API call.
				ResultCode = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				long lZero = 0;
				// Get the result message that corresponds to the code.
				Bytes = DebuggingDeclarations.FormatMessage(DebuggingDeclarations.FORMAT_MESSAGE_FROM_SYSTEM, ref lZero, ResultCode, 0, ResultString, 128, 0);
				
				// Subtract two characters from the message to strip the CR and LF.
				if (Bytes > 2) {
					ResultString = ResultString.Remove(Bytes - 2, 2);
				}
				
				// Create the string to return.
				ResultString = "\n" + FunctionName + "\n" + "  Result = " + ResultString.TrimEnd('\0') + "\n";
				
			} catch (Exception)	{	}
      
      return ResultString;
		}
	}
	
}

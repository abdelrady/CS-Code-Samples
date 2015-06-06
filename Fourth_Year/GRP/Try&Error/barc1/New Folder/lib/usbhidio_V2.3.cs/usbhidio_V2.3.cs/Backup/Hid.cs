using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HID_Test_Application
{
	
  // internal class Hid 	
  class Hid {
		
		// For communicating with HID-class devices.
		
		// Used in error messages.
		const string ModuleName = "Hid";
		
		internal HidApiDeclarations.HIDP_CAPS Capabilities;
		internal HidApiDeclarations.HIDD_ATTRIBUTES DeviceAttributes;
		
		// For viewing results of API calls in debug.write statements:
		static Debugging MyDebugging = new Debugging();
		
		internal abstract class DeviceReport
		{
			
			// For reports that the device sends to the host.
			
			internal int HIDHandle;
			internal bool MyDeviceDetected;
			internal int Result;
			internal int ReadHandle;
			
			// Each DeviceReport class defines a ProtectedRead method for reading a type of report.
			// ProtectedRead and Read are declared as Subs rather than as Functions because
			// asynchronous reads use a callback method that can access parameters passed by ByRef
			// but not Function return values.
			
			protected abstract void ProtectedRead (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] readBuffer, ref bool success);
			
			
			internal void Read (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] readBuffer, ref bool success)
			{
				
				
				// Purpose    : Calls the overridden ProtectedRead routine.
				//              Enables other classes to override ProtectedRead
				//              while limiting access as Friend.
				//              (Directly declaring Write as Friend MustOverride causes the
				//              compiler warning : "Other languages may permit Friend
				//              Overridable members to be overridden.")
				
				// Accepts    : readHandle - a handle for reading from the device.
				//              hidHandle - a handle for other device communications.
				//              myDeviceDetected - tells whether the device is currently
				//              attached and communicating.
				//              readBuffer - a byte array to hold the report ID and report data.
				//              success - read success
				
				try {
					// Request the report.
					ProtectedRead(readHandle, hidHandle, ref myDeviceDetected, ref readBuffer, ref success);
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
			
		}
		
		
		internal class InFeatureReport : DeviceReport
		{
			
			// For reading Feature reports.
			
			protected override void ProtectedRead (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] inFeatureReportBuffer, ref bool success)
			{
				
				// Purpose    : reads a Feature report from the device.
				
				// Accepts    : readHandle - the handle for reading from the device.
				//              hidHandle - the handle for other device communications.
				//              myDeviceDetected - tells whether the device is currently attached.
				//              readBuffer - contains the requested report.
				//              success - read success
				
				try {
					
					// ***
					// API function: HidD_GetFeature
					// Attempts to read a Feature report from the device.
					// Requires:
					// A handle to a HID
					// A pointer to a buffer containing the report ID and report
					// The size of the buffer.
					// Returns: true on success, false on failure.
					// ***
					
					success = HidApiDeclarations.HidD_GetFeature(hidHandle, ref inFeatureReportBuffer[0], inFeatureReportBuffer.Length);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("ReadFile"));
					Debug.WriteLine("");
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
		}
		
		
		internal class InputReport : DeviceReport
		{
			
			// For reading Input reports.
			
			bool ReadyForOverlappedTransfer; //  initialize to false
			
			
			internal void CancelTransfer (int readHandle, int hidHandle)
			{
				
				// Purpose    : closes open handles to a device.
				
				// Accepts    : ReadHandle - the handle for reading from the device.
				//              HIDHandle - the handle for other device communications.
				
				try {
					
					// ***
					// API function: CancelIo
					// Purpose: Cancels a call to ReadFile
					// Accepts: the device handle.
					// Returns: True on success, False on failure.
					// ***
					Result = FileIOApiDeclarations.CancelIo(readHandle);
					
					Debug.WriteLine("************ReadFile error*************");
					Debug.WriteLine(MyDebugging.ResultOfAPICall("CancelIo"));
					Debug.WriteLine("");
					
					// The failure may have been because the device was removed,
					// so close any open handles and
					// set myDeviceDetected=False to cause the application to
					// look for the device on the next attempt.
					
					if (hidHandle != 0) {
						FileIOApiDeclarations.CloseHandle(hidHandle);
						
						Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle (HIDHandle)"));
						Debug.WriteLine("");
					}
					
					if (hidHandle != 0) {
						FileIOApiDeclarations.CloseHandle(readHandle);
						Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle (ReadHandle)"));
					}
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
			
			
			internal void PrepareForOverlappedTransfer (ref FileIOApiDeclarations.OVERLAPPED hidOverlapped, ref int eventObject)
			{
				
				// Purpose    : Creates an event object for the overlapped structure used with
				//            : ReadFile.
				//            ; Called before the first call to ReadFile.
				
				FileIOApiDeclarations.SECURITY_ATTRIBUTES Security = new HID_Test_Application.FileIOApiDeclarations.SECURITY_ATTRIBUTES();
				
				try {
					
					// Values for the SECURITY_ATTRIBUTES structure:
					Security.lpSecurityDescriptor = 0;
					Security.bInheritHandle = System.Convert.ToInt32(true);
					Security.nLength = Marshal.SizeOf(Security);
					
					// ***
					// API function: CreateEvent
					// Purpose: Creates an event object for the overlapped structure used with ReadFile.
					// Accepts:
					// A security attributes structure.
					// Manual Reset = False (The system automatically resets the state to nonsignaled
					// after a waiting thread has been released.)
					// Initial state = True (signaled)
					// An event object name (optional)
					// Returns: a handle to the event object
					// ***
					
					eventObject = FileIOApiDeclarations.CreateEvent(ref Security, System.Convert.ToInt32(false), System.Convert.ToInt32(true), "");
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("CreateEvent"));
					Debug.WriteLine("");
					
					// Set the members of the overlapped structure.
					hidOverlapped.Offset = 0;
					hidOverlapped.OffsetHigh = 0;
					hidOverlapped.hEvent = eventObject;
					ReadyForOverlappedTransfer = true;
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
			
			
			protected override void ProtectedRead (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] inputReportBuffer, ref bool success)
			{
				
				// Purpose    : reads an Input report from the device using interrupt transfers.
				
				// Accepts    : readHandle - the handle for reading from the device.
				//              hidHandle - the handle for other device communications.
				//              myDeviceDetected - tells whether the device is currently attached.
				//              readBuffer - contains the requested report.
				//              success - read success
				
				int EventObject = 0;
				FileIOApiDeclarations.OVERLAPPED HIDOverlapped = new HID_Test_Application.FileIOApiDeclarations.OVERLAPPED();
				int NumberOfBytesRead = 0;
				long Result = 0;
				
				try {
					
					// If it's the first attempt to read, set up the overlapped structure for ReadFile.
					if (!ReadyForOverlappedTransfer) {
						PrepareForOverlappedTransfer(ref HIDOverlapped, ref EventObject);
					}
					
					// ***
					// API function: ReadFile
          // Purpose: Attempts to read an Input report from the device.
					// Accepts:
					// A device handle returned by CreateFile
					// (for overlapped I/O, CreateFile must have been called with FILE_FLAG_OVERLAPPED),
					// A pointer to a buffer for storing the report.
					// The Input report length in bytes returned by HidP_GetCaps,
					// A pointer to a variable that will hold the number of bytes read.
					// An overlapped structure whose hEvent member is set to an event object.
					// Returns: the report in ReadBuffer.
					// The overlapped call returns immediately, even if the data hasn't been received yet.
					// To read multiple reports with one ReadFile, increase the size of ReadBuffer
					// and use NumberOfBytesRead to determine how many reports were returned.
					// Use a larger buffer if the application can't keep up with reading each report
					// individually.
					// ***
					Debug.Write("input report length = " + inputReportBuffer.Length);
					
					Result = FileIOApiDeclarations.ReadFile(readHandle, ref inputReportBuffer[0], inputReportBuffer.Length, ref NumberOfBytesRead, ref HIDOverlapped);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("ReadFile"));
					Debug.WriteLine("");
					Debug.WriteLine("waiting for ReadFile");
					
					// API function: WaitForSingleObject
					// Purpose: waits for at least one report or a timeout.
					// Used with overlapped ReadFile.
					// Accepts:
					// An event object created with CreateEvent
					// A timeout value in milliseconds.
					// Returns: A result code.
					
					Result = FileIOApiDeclarations.WaitForSingleObject(EventObject, 3000);
					Debug.WriteLine(MyDebugging.ResultOfAPICall("WaitForSingleObject"));
					Debug.WriteLine("");
					
					// Find out if ReadFile completed or timeout.
					switch (Result) {
						case FileIOApiDeclarations.WAIT_OBJECT_0:
							// ReadFile has completed
							Debug.WriteLine("");
							success = true;
							Debug.WriteLine("ReadFile completed successfully.");
							break;

						case FileIOApiDeclarations.WAIT_TIMEOUT:
							// Cancel the operation on timeout
							CancelTransfer(readHandle, hidHandle);
							Debug.WriteLine("Readfile timeout");
							Debug.WriteLine("");
							success = false;
							myDeviceDetected = false;
							break;

						default:
							// Cancel the operation on other error.
							CancelTransfer(readHandle, hidHandle);
							Debug.WriteLine("");
							Debug.WriteLine("Readfile undefined error");
							success = false;
							myDeviceDetected = false;
							break;
					}
					
					success = (Result == 0) ? true : false;
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
		}
		
		
		internal class InputReportViaControlTransfer : DeviceReport
		{
			
			protected override void ProtectedRead (int readHandle, int hidHandle, ref bool myDeviceDetected, ref byte[] inputReportBuffer, ref bool success)
			{
				
				// Purpose    : reads an Input report from the device using a control transfer.
				
				// Accepts    : readHandle - the handle for reading from the device.
				//              hidHandle - the handle for other device communications.
				//              myDeviceDetected - tells whether the device is currently attached.
				//              readBuffer - contains the requested report.
				//              success - read success
				
				try {
					// ***
					// API function: HidD_GetInputReport
					// Purpose: Attempts to read an Input report from the device using a control transfer.
					// Supported under Windows XP and later only.
					// Requires:
					// A handle to a HID
					// A pointer to a buffer containing the report ID and report
					// The size of the buffer.
					// Returns: true on success, false on failure.
					// ***
					
					success = HidApiDeclarations.HidD_GetInputReport(hidHandle, ref inputReportBuffer[0], inputReportBuffer.Length);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("ReadFile"));
					Debug.WriteLine("");
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
			}
			
		}
		
		
		internal abstract class HostReport
		{
			
			// For reports the host sends to the device.
			
			// Each report class defines a ProtectedWrite method for writing a type of report.
			
			protected abstract bool ProtectedWrite(int deviceHandle, byte[] reportBuffer);
			
			
			internal bool Write(byte[] reportBuffer, int deviceHandle)
			{
				
				bool Success = false;
				
				// Purpose    : Calls the overridden ProtectedWrite routine.
				//            : This method enables other classes to override ProtectedWrite
				//            : while limiting access as Friend.
				//            : (Directly declaring Write as Friend MustOverride causes the
				//            : compiler(warning) "Other languages may permit Friend
				//            : Overridable members to be overridden.")
				// Accepts    : reportBuffer - contains the report ID and report data.
				//            : deviceHandle - handle to the device.             '
				// Returns    : True on success. False on failure.
				
				try	{
					Success = ProtectedWrite(deviceHandle, reportBuffer);
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}

        return Success;
			}
		}
		
		
		internal class OutFeatureReport : HostReport
		{
			
			// For Feature reports the host sends to the device.
			
			protected override bool ProtectedWrite (int hidHandle, byte[] outFeatureReportBuffer)
			{
				
				//  Purpose    : writes a Feature report to the device.
				//  Accepts    : hidHandle - a handle to the device.
				//               featureReportBuffer - contains the report ID and report to send.
				//  Returns    : True on success. False on failure.
				
				bool Success = false;
				
				try {
					// ***
					// API function: HidD_SetFeature
					// Purpose: Attempts to send a Feature report to the device.
					// Accepts:
					// A handle to a HID
					// A pointer to a buffer containing the report ID and report
					// The size of the buffer.
					// Returns: true on success, false on failure.
					// ***
					
					Success = HidApiDeclarations.HidD_SetFeature(hidHandle, ref outFeatureReportBuffer[0], outFeatureReportBuffer.Length);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("Hidd_SetFeature"));
					Debug.WriteLine("");
					Debug.WriteLine(" FeatureReportByteLength = " + outFeatureReportBuffer.Length);
					Debug.WriteLine(" Report ID: " + outFeatureReportBuffer[0]);
					Debug.WriteLine(" Report Data:");
					
					for (int i = 0; i < outFeatureReportBuffer.Length; i++) {
						Debug.WriteLine(" " + outFeatureReportBuffer[i].ToString("x"));
					}
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
				
        return Success;
			}
			
		}
		
		
		internal class OutputReport : HostReport
		{
			
			// For Output reports the host sends to the device.
			// Uses interrupt or control transfers depending on the device and OS.
			
			protected override bool ProtectedWrite (int hidHandle, byte[] outputReportBuffer)
			{
				
				// Purpose    : writes an Output report to the device.
				// Accepts    : HIDHandle - a handle to the device.
				//              OutputReportBuffer - contains the report ID and report to send.
				// Returns    : True on success. False on failure.
				
				int NumberOfBytesWritten = 0;
				int Result;
				bool Success = false;
				
				try
				{
					// The host will use an interrupt transfer if the the HID has an interrupt OUT
					// endpoint (requires USB 1.1 or later) AND the OS is NOT Windows 98 Gold (original version).
					// Otherwise the the host will use a control transfer.
					// The application doesn't have to know or care which type of transfer is used.
					
					// ***
					// API function: WriteFile
					// Purpose: writes an Output report to the device.
					// Accepts:
					// A handle returned by CreateFile
					// The output report byte length returned by HidP_GetCaps.
					// An integer to hold the number of bytes written.
					// Returns: True on success, False on failure.
					// ***
					
					Result = FileIOApiDeclarations.WriteFile(hidHandle, ref outputReportBuffer[0], outputReportBuffer.Length, ref NumberOfBytesWritten, 0);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("WriteFile"));
					Debug.WriteLine("");
					Debug.WriteLine(" OutputReportByteLength = " + outputReportBuffer.Length.ToString());
					Debug.WriteLine(" NumberOfBytesWritten = " + NumberOfBytesWritten);
					Debug.WriteLine(" Report ID: " + outputReportBuffer[0]);
					Debug.WriteLine(" Report Data:");
					
					for (int i = 0; i < outputReportBuffer.Length; i++) {
						Debug.WriteLine("   " + outputReportBuffer[i].ToString("x"));
					}
					
					// Return True on success, False on failure.
					Success = (Result==0) ? false : true;
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}

        return Success;
			}
			
		}
		
		
		internal class OutputReportViaControlTransfer : HostReport
		{
			
			protected override bool ProtectedWrite (int hidHandle, byte[] outputReportBuffer)
			{
				
				// Purpose    : writes an Output report to the device using a control transfer.
				// Accepts    : hidHandle - a handle to the device.
				//              outputReportBuffer - contains the report ID and report to send.
				// Returns    : True on success. False on failure.
				
				bool Success = false;
				
				try {
					// ***
					// API function: HidD_SetOutputReport
          // Purpose:
					// Attempts to send an Output report to the device using a control transfer.
					// Requires Windows XP or later.
					// Accepts:
					// A handle to a HID
					// A pointer to a buffer containing the report ID and report
					// The size of the buffer.
					// Returns: true on success, false on failure.
					// ***
					
					Success = HidApiDeclarations.HidD_SetOutputReport(hidHandle, ref outputReportBuffer[0], outputReportBuffer.Length);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("Hidd_SetFeature"));
					Debug.WriteLine("");
					Debug.WriteLine(" OutputReportByteLength = " + outputReportBuffer.Length);
					Debug.WriteLine(" Report ID: " + outputReportBuffer[0]);
					Debug.WriteLine(" Report Data:");
					
					for (int i = 0; i < outputReportBuffer.Length; i++) {
						Debug.WriteLine(" " + outputReportBuffer[i].ToString("x"));
					}
					
				} catch (Exception ex) {
					HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
				}
        
        return Success;
			}
			
		}
		
		
		internal bool FlushQueue (int hidHandle) {
			// Purpose    : Remove any Input reports waiting in the buffer.
			// Accepts    : hidHandle - a handle to a device.
			// Returns    : True on success, False on failure.
			
			bool Result = false;
			
			try {
				// ***
				// API function: HidD_FlushQueue
				// Purpose: Removes any Input reports waiting in the buffer.
				// Accepts: a handle to the device.
				// Returns: True on success, False on failure.
				// ***
				
				Result = HidApiDeclarations.HidD_FlushQueue(hidHandle);
				
				Debug.WriteLine(MyDebugging.ResultOfAPICall("HidD_FlushQueue, ReadHandle"));
				Debug.WriteLine("Result = " + Result.ToString());
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return Result;
		}
		
		
		internal HidApiDeclarations.HIDP_CAPS GetDeviceCapabilities (int hidHandle)
		{
			
			// Purpose    : Retrieves a structure with information about a device's capabilities.
			// Accepts    : HIDHandle - a handle to a device.
			// Returns    : An HIDP_CAPS structure.
			
			byte[] PreparsedDataBytes = new byte[30];
			string PreparsedDataString;
			IntPtr PreparsedDataPointer = new IntPtr();
			int Result;
			bool Success = false;
			byte[] ValueCaps = new byte[1024]; // (the array size is a guess)
			
			try {
				
				// ***
				// API function: HidD_GetPreparsedData
				// Purpose: retrieves a pointer to a buffer containing information about the device's capabilities.
				// HidP_GetCaps and other API functions require a pointer to the buffer.
				// Requires:
				// A handle returned by CreateFile.
				// A pointer to a buffer.
				// Returns:
				// True on success, False on failure.
				// ***
				
				Success = HidApiDeclarations.HidD_GetPreparsedData(hidHandle, ref PreparsedDataPointer);
				
				Debug.WriteLine(MyDebugging.ResultOfAPICall("HidD_GetPreparsedData"));
				Debug.WriteLine("");
				
				// Copy the data at PreparsedDataPointer into a byte array.
				
				PreparsedDataString = System.Convert.ToBase64String(PreparsedDataBytes);
				
				
				// ***
				// API function: HidP_GetCaps
				// Purpose: find out a device's capabilities.
				// For standard devices such as joysticks, you can find out the specific
				// capabilities of the device.
				// For a custom device where the software knows what the device is capable of,
				// this call may be unneeded.
				// Accepts:
				// A pointer returned by HidD_GetPreparsedData
				// A pointer to a HIDP_CAPS structure.
				// Returns: True on success, False on failure.
				// ***
				
				Result = HidApiDeclarations.HidP_GetCaps(PreparsedDataPointer, ref Capabilities);
				if (Result != 0) {
					//  Debug data:
					Debug.WriteLine(MyDebugging.ResultOfAPICall("HidP_GetCaps"));
					
					Debug.WriteLine("");
					
					Debug.WriteLine("  Usage: " + Capabilities.Usage.ToString("x"));
					Debug.WriteLine("  Usage Page: " + Capabilities.UsagePage.ToString("x"));
					Debug.WriteLine("  Input Report Byte Length: " + Capabilities.InputReportByteLength);
					Debug.WriteLine("  Output Report Byte Length: " + Capabilities.OutputReportByteLength);
					Debug.WriteLine("  Feature Report Byte Length: " + Capabilities.FeatureReportByteLength);
					Debug.WriteLine("  Number of Link Collection Nodes: " + Capabilities.NumberLinkCollectionNodes);
					Debug.WriteLine("  Number of Input Button Caps: " + Capabilities.NumberInputButtonCaps);
					Debug.WriteLine("  Number of Input Value Caps: " + Capabilities.NumberInputValueCaps);
					Debug.WriteLine("  Number of Input Data Indices: " + Capabilities.NumberInputDataIndices);
					Debug.WriteLine("  Number of Output Button Caps: " + Capabilities.NumberOutputButtonCaps);
					Debug.WriteLine("  Number of Output Value Caps: " + Capabilities.NumberOutputValueCaps);
					Debug.WriteLine("  Number of Output Data Indices: " + Capabilities.NumberOutputDataIndices);
					Debug.WriteLine("  Number of Feature Button Caps: " + Capabilities.NumberFeatureButtonCaps);
					Debug.WriteLine("  Number of Feature Value Caps: " + Capabilities.NumberFeatureValueCaps);
					Debug.WriteLine("  Number of Feature Data Indices: " + Capabilities.NumberFeatureDataIndices);
					
					// ***
					// API function: HidP_GetValueCaps
					// Purpose: retrieves a buffer containing an array of HidP_ValueCaps structures.
					// Each structure defines the capabilities of one value.
					// This application doesn't use this data.
					// Accepts:
					// A report type enumerator from hidpi.h,
					// A pointer to a buffer for the returned array,
					// The NumberInputValueCaps member of the device's HidP_Caps structure,
					// A pointer to the PreparsedData structure returned by HidD_GetPreparsedData.
					// Returns: True on success, False on failure.
					// ***
					
					Result = HidApiDeclarations.HidP_GetValueCaps(HidApiDeclarations.HidP_Input, ref ValueCaps[0], ref Capabilities.NumberInputValueCaps, PreparsedDataPointer);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("HidP_GetValueCaps"));
					Debug.WriteLine("");
					
					// (To use this data, copy the ValueCaps byte array into an array of structures.)
					// ***
					// API function: HidD_FreePreparsedData
					// Purpose: frees the buffer reserved by HidD_GetPreparsedData.
					// Accepts: A pointer to the PreparsedData structure returned by HidD_GetPreparsedData.
					// Returns: True on success, False on failure.
					// ***
					
					Success = HidApiDeclarations.HidD_FreePreparsedData(ref PreparsedDataPointer);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("HidD_FreePreparsedData"));
					Debug.WriteLine("");
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return Capabilities;
		}
		
		
		internal bool GetNumberOfInputBuffers (int hidDeviceObject, ref int numberOfInputBuffers)
		{
			
			// Purpose    : Retrieves the number of Input reports the host can store.
			// Accepts    : hidDeviceObject - a handle to a device
			//            : numberBuffers - an integer to hold the returned value.
			// Returns    : True on success, False on failure.
			
			bool Success = false;
			
			try {
				
				if (!(IsWindows98Gold())) {
					// ***
					// API function: HidD_GetNumInputBuffers
					// Purpose: retrieves the number of Input reports the host can store.
					// Not supported by Windows 98 Gold.
					// If the buffer is full and another report arrives, the host drops the
					// oldest report.
					// Accepts: a handle to a device and an integer to hold the number of buffers.
					// Returns: True on success, False on failure.
					// ***
					
					Success = HidApiDeclarations.HidD_GetNumInputBuffers(hidDeviceObject, ref numberOfInputBuffers);
					
				} else {
					
					// Under Windows 98 Gold, the number of buffers is fixed at 2.
					numberOfInputBuffers = 2;
					Success = true;
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return Success;
		}
		
		
		internal bool SetNumberOfInputBuffers (int hidDeviceObject, int numberBuffers)
		{
			
			// Purpose    : sets the number of input reports the host will store.
			//            : Requires Windows XP or later.
			// Accepts    : hidDeviceObject - a handle to the device.
			//            : numberBuffers - the requested number of input reports.
			// Returns    : True on success. False on failure.
			
			bool Success = false;
			
			try {
				
				if (!(IsWindows98Gold())){
					// ***
					// API function: HidD_SetNumInputBuffers
					// Purpose: Sets the number of Input reports the host can store.
					// If the buffer is full and another report arrives, the host drops the
					// oldest report.
					// Requires:
					// A handle to a HID
					// An integer to hold the number of buffers.
					// Returns: true on success, false on failure.
					// ***
					
					Success = HidApiDeclarations.HidD_SetNumInputBuffers(hidDeviceObject, numberBuffers);
					
				} else {
					// Not supported under Windows 98 Gold.
					Success = false;
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return Success;
		}
		
		
		internal bool IsWindowsXpOrLater()
		{
			
			// Find out if the current operating system is Windows XP or later.
			// (Windows XP or later is required for HidD_GetInputReport and HidD_SetInputReport.)
			bool Success = false;

			try {
				OperatingSystem MyEnvironment = Environment.OSVersion;
				
				// Windows XP is version 5.1.
				System.Version VersionXP = new System.Version(5, 1);
				
				if (MyEnvironment.Version >= VersionXP) {
					Debug.Write("The OS is Windows XP or later.");
					Success = true;
				} else {
					Debug.Write("The OS is earlier than Windows XP.");
					Success = false;
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
      return Success;
		}
		
		internal bool IsWindows98Gold()
		{
			
			// Find out if the current operating system is Windows 98 Gold (original version).
			// Windows 98 Gold does not support the following:
			//   Interrupt OUT transfers (WriteFile uses control transfers and Set_Report).
			//   HidD_GetNumInputBuffers and HidD_SetNumInputBuffers
			
			// (Not yet tested on a Windows 98 Gold system.)
			bool Success = false;

			try {
				OperatingSystem MyEnvironment = Environment.OSVersion;
				
				// Windows 98 Gold is version 4.10 with a build number less than 2183.
				System.Version Version98SE = new System.Version(4, 10, 2183);
				
				if (MyEnvironment.Version >= Version98SE) {
					Debug.Write("The OS is Windows 98 Gold.");
					Success = true;
				} else {
					Debug.Write("The OS is more recent than Windows 98 Gold.");
					Success = false;
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}

      return Success;
		}
		
		static public void HandleException (string moduleName, Exception e)
		{
			
			// Purpose    : Provides a central mechanism for exception handling.
			//            : Displays a message box that describes the exception.
			
			// Accepts    : moduleName - the module where the exception occurred.
			//            : e - the exception
			
			string Message;
			string Caption;
			
			try {
				// Create an error message.
				Message = "Exception: " + e.Message + Environment.NewLine + "Module: " + moduleName + Environment.NewLine + "Method: " + e.TargetSite.Name;
				
				// Specify a caption.
				Caption = "Unexpected Exception";
				
				// Display the message in a message box.
				MessageBox.Show(Message, Caption, MessageBoxButtons.OK);
				Debug.Write(Message);
			} finally { }

		}
		
	}
	
}

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace HID_Test_Application
{
	
	internal class DeviceManagement
	{
		
		// For detecting devices and receiving device notifications.
		
		// Used in error messages:
		const string ModuleName = "DeviceManagement";
		
		// For viewing results of API calls in debug.write statements:
		Debugging MyDebugging = new Debugging();
		
		
		internal bool DeviceNameMatch(Message m, string mydevicePathName)
		{
			
			// Purpose    : Compares two device path names. Used to find out if the device name
			//            : of a recently attached or removed device matches the name of a
			//            : device the application is communicating with.
			
			// Accepts    : m - a WM_DEVICECHANGE message. A call to RegisterDeviceNotification
			//            : causes WM_DEVICECHANGE messages to be passed to an OnDeviceChange routine.
			//            : mydevicePathName - a device pathname returned by SetupDiGetDeviceInterfaceDetail
			//            : in an SP_DEVICE_INTERFACE_DETAIL_DATA structure.
			
			// Returns    : True if the names match, False if not.
			
			try {
				DeviceManagementApiDeclarations.DEV_BROADCAST_DEVICEINTERFACE_1 DevBroadcastDeviceInterface = new DeviceManagementApiDeclarations.DEV_BROADCAST_DEVICEINTERFACE_1();
				DeviceManagementApiDeclarations.DEV_BROADCAST_HDR DevBroadcastHeader = new DeviceManagementApiDeclarations.DEV_BROADCAST_HDR();
				
				// The LParam parameter of Message is a pointer to a DEV_BROADCAST_HDR structure.
				Marshal.PtrToStructure(m.LParam, DevBroadcastHeader);
				
				if (DevBroadcastHeader.dbch_devicetype == DeviceManagementApiDeclarations.DBT_DEVTYP_DEVICEINTERFACE) {
					
					// The dbch_devicetype parameter indicates that the event applies to a device interface.
					// So the structure in LParam is actually a DEV_BROADCAST_INTERFACE structure,
					// which begins with a DEV_BROADCAST_HDR.
					
					// Obtain the number of characters in dbch_name by subtracting the 28 bytes
					// in the other members of the structure and dividing by 2 because there are
					// 2 bytes per character.
					int StringSize = System.Convert.ToInt32((DevBroadcastHeader.dbch_size - 28) / 2);
					
					// The dbcc_name parameter of DevBroadcastDeviceInterface contains the device name.
					// Trim dbcc_name to match the size of the string.
					DevBroadcastDeviceInterface.dbcc_name = new char[StringSize + 1];
					
					// Marshal data from the unmanaged block pointed to by m.LParam
					// to the managed object DevBroadcastDeviceInterface.
					Marshal.PtrToStructure(m.LParam, DevBroadcastDeviceInterface);
					
					// Store the device name in a String.
					string DeviceNameString = new string(DevBroadcastDeviceInterface.dbcc_name, 0, StringSize);
					
					Debug.WriteLine("Device Name = " + DeviceNameString);
					Debug.WriteLine("");
					
					// Compare the name of the newly attached device with the name of the device
					// the application is accessing (mydevicePathName).
					// Set ignorecase True.
					if (string.Compare(DeviceNameString, mydevicePathName, true) == 0) {
						// The name matches.
						return true;
					}
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}

      // It's a different device.
      return false;
		}
		
		
		internal bool FindDeviceFromGuid (System.Guid myGuid, ref string[] devicePathName)
		{
			
			// Purpose    : Uses SetupDi API functions to retrieve the device path name of an
			//            : attached device that belongs to an interface class.
			// Accepts    : myGuid - an interface class GUID.
			//            : devicePathName - a pointer to an array of strings that will contain
			//            : the device path names of attached devices.
			// Returns    : True if at least one device is found, False if not.
			
			// int DetailData;
			bool DeviceFound = false;
			IntPtr DeviceInfoSet;
			bool LastDevice = false;
			int BufferSize = 0;
			int MemberIndex = 0;
			// DeviceManagementApiDeclarations.SP_DEVINFO_DATA MyDeviceInfoData;
			DeviceManagementApiDeclarations.SP_DEVICE_INTERFACE_DETAIL_DATA MyDeviceInterfaceDetailData = new HID_Test_Application.DeviceManagementApiDeclarations.SP_DEVICE_INTERFACE_DETAIL_DATA();
			DeviceManagementApiDeclarations.SP_DEVICE_INTERFACE_DATA MyDeviceInterfaceData = new HID_Test_Application.DeviceManagementApiDeclarations.SP_DEVICE_INTERFACE_DATA();
			int Result = 0;
			string SingledevicePathName;
			bool Success = false;
			
			try
			{
				// ***
				// API function: SetupDiGetClassDevs
				// Purpose:
				// Retrieves a device information set for a specified group of devices.
				// SetupDiEnumDeviceInterfaces uses the device information set.
				// Accepts:
				// An interface class GUID
				// Null to retrieve information for all device instances
				// An optional handle to a top-level window (unused here)
				// Flags to limit the returned information to currently present devices
				// and devices that expose interfaces in the class specified by the GUID.
				// Returns:
				// A handle to a device information set for the devices.
				// ***
				
				DeviceInfoSet = 
          DeviceManagementApiDeclarations.SetupDiGetClassDevs (
            ref myGuid, 
            null, 
            0, 
            DeviceManagementApiDeclarations.DIGCF_PRESENT | DeviceManagementApiDeclarations.DIGCF_DEVICEINTERFACE);
				
				Debug.WriteLine(MyDebugging.ResultOfAPICall("SetupDiClassDevs"));
				
				DeviceFound = false;
				MemberIndex = 0;
				
				do {
					
					// Begin with 0 and increment through the device information set until
					// no more devices are available.
					
					// The cbSize element of the MyDeviceInterfaceData structure must be set to
					// the structure's size in bytes. The size is 28 bytes.
          MyDeviceInterfaceData.cbSize = 28;
          //Marshal.SizeOf(MyDeviceInterfaceData);
					
					// ***
					// API function:
					// SetupDiEnumDeviceInterfaces()
					// Purpose: Retrieves a handle to a SP_DEVICE_INTERFACE_DATA
					// structure for a device.
					// On return, MyDeviceInterfaceData contains the handle to a
					// SP_DEVICE_INTERFACE_DATA structure for a detected device.
					// Accepts:
					// A DeviceInfoSet returned by SetupDiGetClassDevs.
					// An interface class GUID.
					// An index to specify a device in a device information set.
					// A pointer to a handle to a SP_DEVICE_INTERFACE_DATA structure for a device.
					// Returns:
					// Non-zero on success, zero on True.
					// ***
					
					Result = 
            DeviceManagementApiDeclarations.SetupDiEnumDeviceInterfaces (
              DeviceInfoSet, 
              0, 
              ref myGuid, 
              MemberIndex, 
              ref MyDeviceInterfaceData);
					
					Debug.WriteLine(MyDebugging.ResultOfAPICall("SetupDiEnumDeviceInterfaces"));
					
					// Find out if a device information set was retrieved.
					
					if (Result == 0) {
						LastDevice = true;
					} else {
						// A device is present.
						Debug.WriteLine("  DeviceInfoSet for device #" + MemberIndex.ToString() + ": ");
						Debug.WriteLine("  cbSize = " + MyDeviceInterfaceData.cbSize.ToString());
						Debug.WriteLine("  InterfaceclassGuid = " + MyDeviceInterfaceData.InterfaceClassGuid.ToString());
						Debug.WriteLine("  Flags = " + MyDeviceInterfaceData.Flags.ToString("x"));
						
						// ***
						// API function:
						// SetupDiGetDeviceInterfaceDetail()
						// Purpose:
						// Retrieves an SP_DEVICE_INTERFACE_DETAIL_DATA structure
						// containing information about a device.
						// To retrieve the information, call this function twice.
						// The first time returns the size of the structure.
						// The second time returns a pointer to the data.
						// Accepts:
						// A DeviceInfoSet returned by SetupDiGetClassDevs
						// An SP_DEVICE_INTERFACE_DATA structure returned by SetupDiEnumDeviceInterfaces
						// A pointer to an SP_DEVICE_INTERFACE_DETAIL_DATA structure to receive information
						// about the specified interface.
						// The size of the SP_DEVICE_INTERFACE_DETAIL_DATA structure.
						// A pointer to a variable that will receive the returned required size of the
						// SP_DEVICE_INTERFACE_DETAIL_DATA structure.
						// A pointer to an SP_DEVINFO_DATA structure to receive information about the device.
						// Returns:
						// Non-zero on success, zero on failure.
						// ***
						
						Success = 
              DeviceManagementApiDeclarations.SetupDiGetDeviceInterfaceDetail(
                DeviceInfoSet, 
                ref MyDeviceInterfaceData, 
                IntPtr.Zero, 0, ref BufferSize, IntPtr.Zero);
						
            Debug.WriteLine(MyDebugging.ResultOfAPICall("SetupDiGetDeviceInterfaceDetail"));
						Debug.WriteLine("  (OK to say too small)");
						Debug.WriteLine("  Required buffer size for the data: " + BufferSize);
						
						// Store the structure's size.
            //MyDeviceInterfaceDetailData.cbSize = MyDeviceInterfaceDetailData.ToString().Length;
            MyDeviceInterfaceDetailData.cbSize = Marshal.SizeOf(MyDeviceInterfaceDetailData);
						
						// Allocate memory for the MyDeviceInterfaceDetailData Structure using the returned buffer size.
						IntPtr DetailDataBuffer = Marshal.AllocHGlobal(BufferSize);
						
						// Store cbSize in the first 4 bytes of the array
						Marshal.WriteInt32(DetailDataBuffer, 4 + Marshal.SystemDefaultCharSize);
						Debug.WriteLine("cbsize = " + MyDeviceInterfaceDetailData.cbSize);
						
						// Call SetupDiGetDeviceInterfaceDetail again.
						// This time, pass a pointer to DetailDataBuffer
						// and the returned required buffer size.
						Success = DeviceManagementApiDeclarations.SetupDiGetDeviceInterfaceDetail (
                DeviceInfoSet, 
                ref MyDeviceInterfaceData, 
                DetailDataBuffer, 
                BufferSize, 
                ref BufferSize, 
                IntPtr.Zero);
						
						Debug.WriteLine(MyDebugging.ResultOfAPICall(" Result of second call: "));
						Debug.WriteLine("  MyDeviceInterfaceDetailData.cbSize: " + MyDeviceInterfaceDetailData.cbSize.ToString());
						
						// Skip over cbsize (4 bytes) to get the address of the devicePathName.
						IntPtr pdevicePathName = new IntPtr(DetailDataBuffer.ToInt32() + 4);
						
						// Get the String containing the devicePathName.
						SingledevicePathName = Marshal.PtrToStringAuto(pdevicePathName);
						devicePathName[MemberIndex] = SingledevicePathName;
						
						Debug.WriteLine("Device Path = " + devicePathName[MemberIndex]);
            //Debug.WriteLine("Device Path Length= " + Marshal.SizeOf(devicePathName[MemberIndex]));
            Debug.WriteLine("Device Path Length = " + devicePathName[MemberIndex].Length);
						
						// Free the memory allocated previously by AllocHGlobal.
						Marshal.FreeHGlobal(DetailDataBuffer);
						DeviceFound = true;
					}
					MemberIndex++;
				} while (!LastDevice);
				
				// Trim the array to the number of devices found.
				Debug.WriteLine("Number of HIDs found = " + (MemberIndex - 1).ToString());
				
				// ***
				// API function:
				// SetupDiDestroyDeviceInfoList
				// Purpose:
				// Frees the memory reserved for the DeviceInfoSet returned by SetupDiGetClassDevs.
				// Accepts:
				// A DeviceInfoSet returned by SetupDiGetClassDevs.
				// Returns:
				// True on success, False on failure.
				// ***
				
				Result = DeviceManagementApiDeclarations.SetupDiDestroyDeviceInfoList(DeviceInfoSet);
				
				Debug.WriteLine(MyDebugging.ResultOfAPICall("DestroyDeviceInfoList"));
				
			}	catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return DeviceFound;
		}
		
		
		internal bool RegisterForDeviceNotifications (string devicePathName, IntPtr formHandle, Guid classGuid, ref IntPtr deviceNotificationHandle)
		{
			
			// Purpose    : Request to receive a notification when a device is attached or removed.
			
			// Accepts    : devicePathName - a handle to a device.
			//            : formHandle - a handle to the window that will receive device events.
			//            : classGuid - an interface class GUID.
			// 
			
			// Returns    : True on success, False on failure.
			
			// A DEV_BROADCAST_DEVICEINTERFACE header holds information about the request.
			DeviceManagementApiDeclarations.DEV_BROADCAST_DEVICEINTERFACE DevBroadcastDeviceInterface = new DeviceManagementApiDeclarations.DEV_BROADCAST_DEVICEINTERFACE();
			IntPtr DevBroadcastDeviceInterfaceBuffer;
			
			int size;
			
			try
			{
				// Set the parameters in the DEV_BROADCAST_DEVICEINTERFACE structure.
				
				// Set the size.
        size = Marshal.SizeOf(DevBroadcastDeviceInterface);
        DevBroadcastDeviceInterface.dbcc_size = size;
				
				// Request to receive notifications about a class of devices.
				DevBroadcastDeviceInterface.dbcc_devicetype = DeviceManagementApiDeclarations.DBT_DEVTYP_DEVICEINTERFACE;
				
				DevBroadcastDeviceInterface.dbcc_reserved = 0;
				
				// Specify the interface class to receive notifications about.
				DevBroadcastDeviceInterface.dbcc_classguid = classGuid;
				
				// Allocate memory for the buffer that holds the DEV_BROADCAST_DEVICEINTERFACE structure.
				DevBroadcastDeviceInterfaceBuffer = Marshal.AllocHGlobal(size);
				
				// Copy the DEV_BROADCAST_DEVICEINTERFACE structure to the buffer.
				// Set fDeleteOld True to prevent memory leaks.
				Marshal.StructureToPtr(DevBroadcastDeviceInterface, DevBroadcastDeviceInterfaceBuffer, true);
				
				// ***
				// API function:
				// RegisterDeviceNotification
				// Purpose:
				// Request to receive notification messages when a device in an interface class
				// is attached or removed.
				// Accepts:
				// Aa handle to the window that will receive device events
				// A pointer to a DEV_BROADCAST_DEVICEINTERFACE to specify the type of
				// device to send notifications for,
				// DEVICE_NOTIFY_WINDOW_HANDLE to indicate that Handle is a window handle.
				// Returns:
				// A device notification handle or NULL on failure.
				// ***
				
				deviceNotificationHandle = DeviceManagementApiDeclarations.RegisterDeviceNotification(formHandle, DevBroadcastDeviceInterfaceBuffer, DeviceManagementApiDeclarations.DEVICE_NOTIFY_WINDOW_HANDLE);
				
				// Marshal data from the unmanaged block DevBroadcastDeviceInterfaceBuffer to
				// the managed object DevBroadcastDeviceInterface
				Marshal.PtrToStructure(DevBroadcastDeviceInterfaceBuffer, DevBroadcastDeviceInterface);
				
				// Free the memory allocated previously by AllocHGlobal.
				Marshal.FreeHGlobal(DevBroadcastDeviceInterfaceBuffer);
				
				// Find out if RegisterDeviceNotification was successful.
				if (deviceNotificationHandle.ToInt32() == IntPtr.Zero.ToInt32()) {
					Debug.WriteLine("RegisterDeviceNotification error");
					return false;
				}
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
      
      return true;
    }
		
		
		internal void StopReceivingDeviceNotifications (IntPtr deviceNotificationHandle)
		{
			
			// Purpose    : Requests to stop receiving notification messages when a device in an
			//              interface class is attached or removed.
			// Accepts    : deviceNotificationHandle - a handle returned previously by
			//              RegisterDeviceNotification
			
			try {
				
				// ***
				// API function: UnregisterDeviceNotification
				// Purpose: Stop receiving notification messages.
				// Accepts: a handle returned previously by RegisterDeviceNotification
				// Returns: True on success, False on failure.
				// ***
				
				// Ignore failures.
				DeviceManagementApiDeclarations.UnregisterDeviceNotification(deviceNotificationHandle);
				
			} catch (Exception ex) {
				HandleException(ModuleName + ":" + System.Reflection.MethodBase.GetCurrentMethod(), ex);
			}
			
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

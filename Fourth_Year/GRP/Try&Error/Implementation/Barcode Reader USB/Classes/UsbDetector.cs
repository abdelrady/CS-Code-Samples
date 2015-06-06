using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;             // required for Message
using System.Runtime.InteropServices;   // required for Marshal
using System.IO;
using Microsoft.Win32.SafeHandles;     


namespace RawInput
{
    // Delegate for event handler to handle the device events 
    public delegate void DriveDetectorEventHandler(Object sender, DriveDetectorEventArgs e);    
  
    // for naming convention     
    public class DriveDetectorEventArgs : EventArgs 
    {
    }  
    // Detects insertion or removal of removable drives.
    // Use it in 2 steps:
    // 1) Create instance of this class in your project and add handlers for the
    // DeviceArrived, DeviceRemoved and QueryRemove events.
    // 2) Override WndProc in your form and call DriveDetector's WndProc from there
   
    class DriveDetector : IDisposable 
    {
       
        // Events signalized to the client app.
        // Add handlers for these events in your form to be notified of removable device events       
        public event DriveDetectorEventHandler DeviceChanged;
        /// Handle to file which we keep opened on the drive if query remove message is required by the client     
        private IntPtr mDeviceNotifyHandle;
        /// Handle of the window which receives messages from Windows. This will be a form.      
        private IntPtr mRecipientHandle;
        // Win32 constants
        private const int DBT_DEVNODES_CHANGED = 0x0007;
        private const int DBT_DEVTYP_DEVICEINTERFACE = 5;
        private const int DBT_DEVTYP_HANDLE = 6;
        private const int BROADCAST_QUERY_DENY = 0x424D5144;
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000; // system detected a new device
        private const int DBT_DEVICEQUERYREMOVE = 0x8001;   // Preparing to remove (any program can disable the removal)
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004; // removed 
        private const int DBT_DEVTYP_VOLUME = 0x00000002; // drive type is logical volume   
 
        /// Default constructor.    
        public DriveDetector(Control control)
        {  
            
        }          
     
        // Unregister and close the file we may have opened on the removable drive. 
        // Garbage collector will call this method.      
        public void Dispose()
        {
        
        }

        // Message handler which must be called from client form
        // Processes Windows messages and calls event handlers     
        public void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                // WM_DEVICECHANGE can have several meanings depending on the WParam value...
                switch (m.WParam.ToInt32())
                {

                    //device added or removed
                    case DBT_DEVNODES_CHANGED:

                        DriveDetectorEventHandler tempDeviceChanged = DeviceChanged;
                        tempDeviceChanged(this, null);
                        break;
                }            

            }

        }                     
             
        // WinAPI functions      
        private class Native
        {
            //   HDEVNOTIFY RegisterDeviceNotification(HANDLE hRecipient,LPVOID NotificationFilter,DWORD Flags);
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr NotificationFilter, uint Flags);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern uint UnregisterDeviceNotification(IntPtr hHandle);

        }
        
        // Structure with information for RegisterDeviceNotification.
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_HANDLE
        {
            public int dbch_size;
            public int dbch_devicetype;
            public int dbch_reserved;
            public IntPtr dbch_handle;
            public IntPtr dbch_hdevnotify;
            public Guid dbch_eventguid;
            public long dbch_nameoffset;
            //public byte[] dbch_data[1]; // = new byte[1];
            public byte dbch_data;
            public byte dbch_data1; 
        }

        // Struct for parameters of the WM_DEVICECHANGE message
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }
      

    }
}


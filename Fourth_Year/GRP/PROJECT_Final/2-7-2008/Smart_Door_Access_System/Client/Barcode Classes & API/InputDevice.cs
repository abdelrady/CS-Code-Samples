using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SmartDoor
{   
    public sealed class InputDevice
    {
        private string barcode_Number;
        private int deviceHandel;
        /*Enum by eagles*/
        private enum _Peak {_REMOVE,_KEEP};
        _Peak _CurKey = _Peak._KEEP;
        public int DeviceHandel
        {
            get { return deviceHandel; }
            set { deviceHandel = value; }
        }
        private IntPtr ParentHandle;
        private const int RIDEV_INPUTSINK   = 0x00000100;
        private const int RIDEV_REMOVE      =0x00000001;
        private const int RIDEV_NOLEGACY    =0x00000030;
        private const int RID_INPUT         = 0x10000003;
        private const int FAPPCOMMAND_MASK  = 0xF000;
        private const int FAPPCOMMAND_MOUSE = 0x8000;
        private const int FAPPCOMMAND_OEM   = 0x1000;
        private const int RIM_TYPEMOUSE     = 0;
        private const int RIM_TYPEKEYBOARD  = 1;
        private const int RIM_TYPEHID       = 2;
        private const int RIDI_DEVICENAME   = 0x20000007;        
        private const int WM_KEYDOWN	    = 0x0100;
        private const int WM_SYSKEYDOWN     = 0x0104;
		private const int WM_INPUT		    = 0x00FF;
        private const int VK_OEM_CLEAR      = 0xFE;
        private const int VK_LAST_KEY       = VK_OEM_CLEAR; //sentenil or null value

        [DllImport("User32.dll")]
        extern static uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint uiNumDevices, uint cbSize);

        [DllImport("User32.dll")]
        extern static uint GetRawInputDeviceInfo(IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

        [DllImport("User32.dll")]
        extern static bool RegisterRawInputDevices(RAWINPUTDEVICE[] pRawInputDevice, uint uiNumDevices, uint cbSize);

        [DllImport("User32.dll")]
        extern static uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

        [DllImport("User32.dll")]
        public extern static bool BlockInput(bool fBlockIt);

        public enum DeviceType
        {
            Key,
            Mouse,//dummy 
            OEM   //dummy
        }        

        public class DeviceInfo
        {
            public string deviceName;
            public string deviceType;
            public IntPtr deviceHandle;
            public string Name;
            public string source;
            public ushort key;
            public string vKey;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWINPUTDEVICELIST
        {
            public IntPtr hDevice;
            [MarshalAs(UnmanagedType.U4)]
            public int dwType;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct RAWINPUT
        {
            [FieldOffset(0)]
            public RAWINPUTHEADER header;
            [FieldOffset(16)]
            public RAWMOUSE mouse;
            [FieldOffset(16)]
            public RAWKEYBOARD keyboard;
            [FieldOffset(16)]
            public RAWHID hid;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWINPUTHEADER
        {
            [MarshalAs(UnmanagedType.U4)]
            public int dwType;
            [MarshalAs(UnmanagedType.U4)]
            public int dwSize;
            public IntPtr hDevice;
            [MarshalAs(UnmanagedType.U4)]
            public int wParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWHID
        {
            [MarshalAs(UnmanagedType.U4)]
            public int dwSizHid;
            [MarshalAs(UnmanagedType.U4)]
            public int dwCount;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct BUTTONSSTR
        {
            [MarshalAs(UnmanagedType.U2)]
            public ushort usButtonFlags;
            [MarshalAs(UnmanagedType.U2)]
            public ushort usButtonData;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct RAWMOUSE
        {
            [MarshalAs(UnmanagedType.U2)]
            [FieldOffset(0)] 
            public ushort usFlags;
            [MarshalAs(UnmanagedType.U4)]
            [FieldOffset(4)] 
            public uint ulButtons; 
            [FieldOffset(4)] 
            public BUTTONSSTR buttonsStr;
            [MarshalAs(UnmanagedType.U4)][FieldOffset(8)] 
            public uint ulRawButtons;
            [FieldOffset(12)]
            public int lLastX;
            [FieldOffset(16)]
            public int lLastY;
            [MarshalAs(UnmanagedType.U4)][FieldOffset(20)]
            public uint ulExtraInformation;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWKEYBOARD
        {
            [MarshalAs(UnmanagedType.U2)]
            public ushort MakeCode;
            [MarshalAs(UnmanagedType.U2)]
            public ushort Flags;
            [MarshalAs(UnmanagedType.U2)]
            public ushort Reserved;
            [MarshalAs(UnmanagedType.U2)]
            public ushort VKey;
            [MarshalAs(UnmanagedType.U4)]
            public uint Message;
            [MarshalAs(UnmanagedType.U4)]
            public uint ExtraInformation;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWINPUTDEVICE
        {
            [MarshalAs(UnmanagedType.U2)]
            public ushort usUsagePage;
            [MarshalAs(UnmanagedType.U2)]
            public ushort usUsage;
            [MarshalAs(UnmanagedType.U4)]
            public int dwFlags;
            public IntPtr hwndTarget;
        }
              
     
        // List of keyboard devices Key->> the device handle
        // Value->> the device info class     
        private Hashtable deviceList = new Hashtable();
      
        public delegate void DeviceEventHandler(object sender, KeyControlEventArgs e);
        
        public event DeviceEventHandler KeyPressed;

        public event DeviceEventHandler BarcodeRecieved;
     
        public class KeyControlEventArgs : EventArgs
        {
            private DeviceInfo  m_deviceInfo;
            private DeviceType  m_device;
           
            public KeyControlEventArgs( DeviceInfo dInfo, DeviceType device ,string Barcode)
            {
                m_deviceInfo = dInfo;
                m_device = device;
                barcode_Number = Barcode;
            }
            public KeyControlEventArgs(DeviceInfo dInfo, DeviceType device)
            {
                m_deviceInfo = dInfo;
                m_device = device;
                barcode_Number = null;
            }
            public KeyControlEventArgs()
            {
            }

            public DeviceInfo Keyboard
            {
                get { return m_deviceInfo; }
                set { m_deviceInfo = value; }
            }

            public DeviceType Device
            {
                get { return m_device; }
                set { m_device = value; }
            }
            private string barcode_Number;
            public string Barcode
            {
                get { return barcode_Number; }
          }
        }    
       
        public InputDevice( IntPtr hwnd )
        {
            ParentHandle = hwnd;
            //Create an array of all the raw input devices we want to 
            //listen to. In this case, only keyboard devices.
            //RIDEV_INPUTSINK determines that the window will continue
            //to receive messages even when it doesn't have the focus.
            RAWINPUTDEVICE[] rid = new RAWINPUTDEVICE[1];
			
            rid[0].usUsagePage  = 0x01;
            rid[0].usUsage      = 0x06;
            rid[0].dwFlags      = RIDEV_INPUTSINK;//| RIDEV_REMOVE; 
            rid[0].hwndTarget   = hwnd;
           
            if( !RegisterRawInputDevices( rid, (uint)rid.Length, (uint)Marshal.SizeOf( rid[0] )))
            {
                throw new ApplicationException( "Failed to register raw input device(s)." );
            }
        }               
        
        // Reads the Registry to retrieve a good description
        // of the device, and determine whether it is a keyboard
       
        private string ReadReg( string item, ref bool isKeyboard )
        {
            // Example Device Identification string
            // @"\??\ACPI#PNP0303#3&13c0b0c5&0#{884b96c3-56ef-11d1-bc8c-00a0c91405dd}";

            // remove the \??\
            item = item.Substring( 4 ); 

            string[] split = item.Split( '#' );

            string id_01 = split[0];    // ACPI (Class code)
            string id_02 = split[1];    // PNP0303 (SubClass code)
            string id_03 = split[2];    // 3&13c0b0c5&0 (Protocol code)
            //The final part is the class GUID and is not needed here

            //Open the appropriate key as read-only so no permissions
            //are needed.
            RegistryKey OurKey = Registry.LocalMachine;

            string findme = string.Format( @"System\CurrentControlSet\Enum\{0}\{1}\{2}", id_01, id_02, id_03 );
            
            OurKey = OurKey.OpenSubKey( findme, false );

            //Retrieve the desired information and set isKeyboard
            string deviceDesc  = (string)OurKey.GetValue( "DeviceDesc" );
            string deviceClass = (string)OurKey.GetValue( "Class" );
            
            if( deviceClass.ToUpper().Equals( "KEYBOARD" ))
            {
                isKeyboard = true;
            }
            else
            {
                isKeyboard = false;
            }
            return deviceDesc;
        }
       
        // Iterates through the list provided by GetRawInputDeviceList,
        // counting keyboard devices and adding them to deviceList
        public int EnumerateDevices()
        {            
            int NumberOfDevices = 0;
            uint deviceCount = 0;
            int dwSize = ( Marshal.SizeOf( typeof( RAWINPUTDEVICELIST )));

            // Get the number of raw input devices in the list,
            // then allocate sufficient memory and get the entire list
            if( GetRawInputDeviceList( IntPtr.Zero, ref deviceCount, (uint)dwSize ) == 0 )
            {
                IntPtr pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
                GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);
                //MessageBox.Show(deviceCount.ToString());
                // Iterate through the list, discarding undesired items
                // and retrieving further information on keyboard devices
                for (int i = 0; i < deviceCount; i++)
                {
                    DeviceInfo dInfo;
                    string deviceName;
                    uint pcbSize = 0;
                    RAWINPUTDEVICELIST rid = (RAWINPUTDEVICELIST)Marshal.PtrToStructure(
                                               new IntPtr((pRawInputDeviceList.ToInt32() + (dwSize * i))),
                                               typeof(RAWINPUTDEVICELIST));

                    GetRawInputDeviceInfo(rid.hDevice, RIDI_DEVICENAME, IntPtr.Zero, ref pcbSize);

                    if (pcbSize > 0)
                    {
                        IntPtr pData = Marshal.AllocHGlobal((int)pcbSize);
                        GetRawInputDeviceInfo(rid.hDevice, RIDI_DEVICENAME, pData, ref pcbSize);
                        deviceName = (string)Marshal.PtrToStringAnsi(pData);

                        // Drop the "root" keyboard and mouse devices used for Terminal 
                        // Services and the Remote Desktop
                        if (deviceName.ToUpper().Contains("ROOT"))
                        {
                            continue;
                        }

                        // If the device is identified in the list as a keyboard or 
                        // HID device, create a DeviceInfo object to store information 
                        // about it
                        if (rid.dwType == RIM_TYPEKEYBOARD || rid.dwType == RIM_TYPEHID)
                        {
                            dInfo = new DeviceInfo();

                            dInfo.deviceName = (string)Marshal.PtrToStringAnsi(pData);
                            dInfo.deviceHandle = rid.hDevice;
                            dInfo.deviceType = GetDeviceType(rid.dwType);

                            // Check the Registry to see whether this is actually a 
                            // keyboard, and to retrieve a more friendly description.
                            bool IsKeyboardDevice = false;
                            string DeviceDesc = ReadReg(deviceName, ref IsKeyboardDevice);
                            dInfo.Name = DeviceDesc;

                            // If it is a keyboard and it isn't already in the list,
                            // add it to the deviceList hashtable and increase the
                            // NumberOfDevices count
                            if (!deviceList.Contains(rid.hDevice) && IsKeyboardDevice)
                            {
                                NumberOfDevices++;
                                deviceList.Add(rid.hDevice, dInfo);
                            }
                        }
                        Marshal.FreeHGlobal(pData);
                    }
                }

                Marshal.FreeHGlobal(pRawInputDeviceList);
                return NumberOfDevices;

            }
            else
            {
                throw new ApplicationException( "An error occurred while retrieving the list of devices." );
            }

        }  
     
        // Processes WM_INPUT messages to retrieve information about any
        // keyboard events that occur.        
        public void ProcessInputCommand( Message message )
        {            
            uint dwSize = 0;

            // First call to GetRawInputData sets the value of dwSize,
            // which can then be used to allocate the appropriate amount of memory,
            // storing the pointer in "buffer".
            GetRawInputData(
                            message.LParam,
                            RID_INPUT,
                            IntPtr.Zero,
                            ref dwSize,
                            (uint)Marshal.SizeOf( typeof( RAWINPUTHEADER ))
                            );

            IntPtr buffer = Marshal.AllocHGlobal( (int)dwSize );
            try
            {
                // Check that buffer points to something, and if so,
                // call GetRawInputData again to fill the allocated memory
                // with information about the input
                if (buffer != IntPtr.Zero &&
                    GetRawInputData(message.LParam,
                                     RID_INPUT,
                                     buffer,
                                     ref dwSize,
                                     (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER))) == dwSize)
                {
                    // Store the message information in "raw", then check
                    // that the input comes from a keyboard device before
                    // processing it to raise an appropriate KeyPressed event.

                    RAWINPUT raw = (RAWINPUT)Marshal.PtrToStructure(buffer, typeof(RAWINPUT));

                    if (raw.header.dwType == RIM_TYPEKEYBOARD)
                    {
                        // Filter for Key Down events and then retrieve information 
                        // about the keystroke
                        if (raw.keyboard.Message == WM_KEYDOWN || raw.keyboard.Message == WM_SYSKEYDOWN)
                        {

                            ushort key = raw.keyboard.VKey;

                            // On most keyboards, "extended" keys such as the arrow or 
                            // page keys return two codes - the key's own code, and an
                            // "extended key" flag, which translates to 255. This flag
                            // isn't useful to us, so it can be disregarded.
                            if (key > VK_LAST_KEY)
                            {
                                return;
                            }

                            // Retrieve information about the device and the
                            // key that was pressed.
                            DeviceInfo dInfo = null;

                            if (deviceList.Contains(raw.header.hDevice))
                            {
                                Keys myKey; 

                                dInfo = (DeviceInfo)deviceList[raw.header.hDevice];

                                myKey = (Keys)Enum.Parse(typeof(Keys), Enum.GetName(typeof(Keys), key));
                                dInfo.vKey = myKey.ToString();
                                dInfo.key = key;
                            }
                            else
                            {
                                string errMessage = String.Format("Handle :{0} was not in hashtable. The device may support more than one handle or usage page, and is probably not a standard keyboard.", raw.header.hDevice);
                                //throw new ApplicationException(errMessage);
                            }

                            // If the key that was pressed is valid and there
                            // was no problem retrieving information on the device,
                            // raise the KeyPressed event.
                            if (/*KeyPressed*/ BarcodeRecieved != null && dInfo != null)
                            {
                                KeyPressed_Function(new KeyControlEventArgs(dInfo, GetDevice(message.LParam.ToInt32())));
                                //KeyPressed(this, new KeyControlEventArgs(dInfo, GetDevice(message.LParam.ToInt32())));
                            }
                            else
                            {
                                string errMessage = String.Format("Received Unknown Key: {0}. Possibly an unknown device", key);
                                //throw new ApplicationException(errMessage);
                            }
                        }
                    }
                }
            }
            finally
            {
                Marshal.FreeHGlobal( buffer );
            }
        }

        private void KeyPressed_Function(KeyControlEventArgs e)
        {
            
            //IntPtr ptr=new IntPtr(deviceHandel);
            if (/*e.Keyboard.deviceHandle != ptr &&*/ e.Keyboard.Name.Contains("HID Keyboard Device"))
            {
                if (e.Keyboard.key == 13)/*Handel Enter and remove it */
                {
                    if (barcode_Number.Length < 13)/*by Eagle this "Enter" Not The finish of barcode Just Another Thing */
                    {
                        barcode_Number = "";
                        return;
                    }

                    BarcodeRecieved(this, new KeyControlEventArgs(e.Keyboard, e.Device, barcode_Number));
                    barcode_Number = "";
                    return;
                }
                if (e.Keyboard.key != 17 && e.Keyboard.key != 13&& e.Keyboard.key != 74 /*&& e.Keyboard.key>47 && e.Keyboard.key<58*/)
                    barcode_Number += (e.Keyboard.key - 48).ToString();
                _CurKey = _Peak._REMOVE;
            }
            else _CurKey = _Peak._KEEP;
        }
      
        // Determines what type of device triggered a WM_INPUT message.
        // (Used in the ProcessInputCommand method).        
        private DeviceType GetDevice(int param)
        {
            DeviceType deviceType;

            switch( (int)(((ushort)(param >> 16)) & FAPPCOMMAND_MASK ))
            {
                case FAPPCOMMAND_OEM:
                    deviceType = DeviceType.OEM;
                    break;
                case FAPPCOMMAND_MOUSE:
                    deviceType = DeviceType.Mouse;
                    break;
                default:
                    deviceType = DeviceType.Key;
                    break;
            }

            return deviceType;
        }     

        // Filters Windows messages for WM_INPUT messages and calls
        // ProcessInputCommand if necessary.
       
        public void ProcessMessage( Message message )
		{
			switch( message.Msg )
			{
				case WM_INPUT:
		        {
                    //message.Result = IntPtr.Zero;
                    //MessageBox.Show(message.Result.ToString());
		            ProcessInputCommand( message );
                    if (_CurKey == _Peak._REMOVE)
                    GenMethods.PeekMessage(ref message,ParentHandle, 0, 0, GenMethods.PM_REMOVE);    
		        }
				break;
			}
        }       
       
        // Converts a RAWINPUTDEVICELIST dwType value to a string
        // describing the device type.       
        private string GetDeviceType( int device )
        {
            string deviceType;
            switch( device ) 
            {
                case RIM_TYPEMOUSE: deviceType    = "MOUSE";    break;
                case RIM_TYPEKEYBOARD: deviceType = "KEYBOARD"; break;
                case RIM_TYPEHID: deviceType      = "HID";      break;
                default: deviceType               = "UNKNOWN";  break;
            }
            return deviceType;
        }
    }
}

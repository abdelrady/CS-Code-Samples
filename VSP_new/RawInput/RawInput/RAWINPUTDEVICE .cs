using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RawInput
{
  struct RAWINPUTHEADER { 
  long    dwType; 
  long    dwSize;
  IntPtr   hDevice;
      //   WPARAM wParam;
} 
    struct RAWINPUT
    {
        //RAWINPUTHEADER header;


      //  RAWKEYBOARD data;


    }
    struct PCRAWINPUTDEVICE
    {
        short usUsagePage;   // top level collection UsagePage
        short usUsage;       // top level collection Usage
        long dwFlags;
        int hwndTarget;    // target hwnd

    }
    class RawInputRead
    {
        [DllImport("User32.lib")]
        public static extern bool RegisterRawInputDevices(PCRAWINPUTDEVICE pRawInputDevices, int uiNumDevices, int cbSize);
     //   public static extern int GetRawInputData(HRAWINPUT hRawInput, int uiCommand, IntPtr pData, IntPtr pcbSize, int cbSizeHeader);

    }
}

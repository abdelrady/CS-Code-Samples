using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MovieShow
{
    class Mci
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        public bool recorder = false;
        private bool pause = false;
        public void OpenCDTray()
        {
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }


        public void CloseCDTray()
        {
            mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }
        public void Recording()
        {
            recorder = true;
            mciSendString("record waveaudio alias a", null, 0, IntPtr.Zero);
        }
        public void Pausing()
        {
            mciSendString("pause a", null, 0, IntPtr.Zero);
            pause = true;
        }
        public void Save(String loc)
        {
            if(!pause)
                mciSendString("pause a", null, 0, IntPtr.Zero);
            mciSendString("save waveaudio "+loc, null, 0, IntPtr.Zero);
            mciSendString("close a", null, 0, IntPtr.Zero);
        }
     }
}
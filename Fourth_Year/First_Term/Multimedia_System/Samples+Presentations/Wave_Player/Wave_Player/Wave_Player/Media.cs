using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Wave_Player
{
    class Media
    {
        public const int MM_MCINOTIFY = 0x3B9;
        private string file_name;
        private bool it_stop = false;
        private Form notifay_form;
        private string mediaName = "media";
        //...Import Winmm.dll ....................
        [DllImport("winmm.dll")]
        private static extern long mciSendString(
            string command, StringBuilder returnValue,
            int returnLength, IntPtr Handle);
        //...Close Player...................
        private void ClosePlayer()
        {
            if (it_stop)
            {
                string playCommand = "Close " + mediaName;
                mciSendString(playCommand, null, 0, IntPtr.Zero);
                it_stop = false;
            }
        }
        //... Open Media File .................
        private void OpenMediaFile()
        {
            ClosePlayer();
            string playCommand = "Open \"" + file_name + "\" type mpegvideo alias " + mediaName;
            mciSendString(playCommand, null, 0, IntPtr.Zero);
            it_stop = true;
        }
        //.... Play Media File ................
        private void PlayMediaFile()
        {
            if (it_stop)
            {
                string playCommand = "Play " + mediaName + " notify";
                mciSendString(playCommand, null, 0, notifay_form.Handle);
            }
        }
        private void cd_eject()
        {
            string Command = "set CDAudio door open";
            mciSendString(Command, null, 127, IntPtr.Zero);
        }
        private void cd_inject()
        {
            string Command = "set CDAudio door closed";
            mciSendString(Command, null, 127, IntPtr.Zero);
        }
        public void Play(string fileName, Form notifayForm)
        {
            this.file_name = fileName;
            this.notifay_form = notifayForm;
            OpenMediaFile();
            PlayMediaFile();
        }
        public void Stop()
        {
            ClosePlayer();
        }
        public void Eject()
        { cd_eject(); }
        public void Inject()
        { cd_inject(); }
    }
}

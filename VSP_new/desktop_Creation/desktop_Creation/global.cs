/*---> Copyrights Information
Rem -> ***|*********************************************************************|***|
Rem -> ***|                      ______                __                       |***|
Rem -> ***|                     | ____ \              |  |                      |***|
Rem -> ***|                     | |   \ \             |  |                      |***|
Rem -> ***|                     | |    \ \            |  |                      |***|
Rem -> ***|                     | |    / /            |  |                      |***|
Rem -> ***|                     | |___/ /     __      |  |______                |***|
Rem -> ***|                     |______/     (__)     |_________|               |***|
Rem -> ***|   _______________________________________________________________   |***|
Rem -> ***|                                                                     |***|
Rem -> ***|   Author       : John Fawzy Gouda (Dominator Legend)                |***|
Rem -> ***|   Email        : Dominator_Legand@Hotmail.com                       |***|
Rem -> ***|   Web          : http://www.DominatorLegend.Co.Nr                   |***|
Rem -> ***|   Date         : 12/11/2006                                         |***|
Rem -> ***|                                                                     |***|
Rem -> ***|   Copyrights   : You are welcome to read this code and learn from   |***|
Rem -> ***|                  it, also feel free to use this code in your        |***|
Rem -> ***|                  applications, in order to use this code please     |***|
Rem -> ***|                  rate this code, just to imrove the code, thanks    |***|
Rem -> ***|                                                                     |***|
Rem -> ***|   The Idea     : The idea Obtained from "Creating New Desktops and  |***|
Rem -> ***|                  Running Applications" vbaccelerator.com, the code  |***|
Rem -> ***|                  writen in VB6, I rewrite it in C#, also one of the |***|
Rem -> ***|                  darwback of VB6 code is that need an bootstraping  |***|
Rem -> ***|                  which mean 2 exe, the 1st check and change desktop |***|
Rem -> ***|                  the 2nd exe run on new desktop created by the 1st  |***|
Rem -> ***|                  exe, I didn't use this tech. in my C# version, as  |***|
Rem -> ***|                  the same exe can create new desktop, and also can  |***|
Rem -> ***|                  run on it, all we need now is to hook the keyboard |***|
Rem -> ***|                  to prevent Winkey + L, which switch the user.      |***|
Rem -> ***|                                                                     |***|
Rem -> ***|*********************************************************************|***/
namespace Locker
{
    #region > Imported Libraries <
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    #endregion
    class Global
    {
        #region > API               [Count-3]   <
        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        #endregion
        #region > Functions         [Count-2]   <
        /// <summary>
        /// FocuseWindows used to activate a given HWnd, i.e. bring that window to top, and put focus.
        /// </summary>
        /// <param name="Handle">The Hwnd of window to be focused</param>
        public static void FocuseWindows(IntPtr Handle)
        {
            SetForegroundWindow(Handle);
        }
        /// <summary>
        /// MoveWindows used to move borderless window
        /// </summary>
        /// <param name="Handle">HWnd of a window to be moved</param>
        public static void MoveWindows(IntPtr Handle)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 2, 0);
        }
        #endregion
    }
}

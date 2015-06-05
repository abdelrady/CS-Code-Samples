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
    using System.IO;
    using System.Text;
    using Microsoft.Win32;
    using System.Diagnostics;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    #endregion
    class CLocker
    {
        #region > APIs                  [Count-18]  <
        [DllImport("user32.dll")]
        static extern int GetThreadDesktop(int dwThread);
        [DllImport("user32.dll")]
        static extern int OpenInputDesktop(int dwFlags, Boolean fInherit, int dwDesiredAccess);
        [DllImport("user32.dll")]
        static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit, long dwDesiredAccess);
        [DllImport("user32.dll")]
        static extern int CreateDesktop(string lpszDesktop, string lpszDevice, int pDevmode, int dwFlags, int dwDesiredAccess, int lpsa);
        [DllImport("user32.dll")]
        static extern int SetThreadDesktop(int hDesktop);
        [DllImport("user32.dll")]
        static extern int SwitchDesktop(int hDesktop);
        [DllImport("user32.dll")]
        static extern int CloseDesktop(int hDesktop);
        [DllImport("user32.dll")]
        static extern int GetUserObjectInformation(int hObj, int nIndex, StringBuilder pvInfo, int nLength, ref int lpnLengthNeeded);
        [DllImport("user32.dll")]
        static extern int SystemParametersInfo(int uAction, bool uParam, bool lpvParam, int fuWinIni);
        [DllImport("kernel32.dll")]
        static extern void ExitProcess(int uExitCode);
        [DllImport("kernel32.dll")]
        static extern int WaitForSingleObject(int hHandle, uint dwMilliseconds);
        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);
        [DllImport("kernel32.dll")]
        static extern int SetThreadPriority(int hThread, int nPriority);
        [DllImport("kernel32.dll")]
        static extern int SetPriorityClass(int hProcess, int dwPriorityClass);
        [DllImport("kernel32.dll")]
        static extern int CreateProcess(string lpApplicationName, string lpCommandLine, int lpProcessAttributes, int lpThreadAttributes, int bInheritHandles, int dwCreationFlags, int lpEnvironment, string lpCurrentDriectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);
        [DllImport("kernel32.dll")]
        static extern int CloseHandle(int hObject);
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThread();
        [DllImport("kernel32.dll")]
        static extern int GetCurrentProcess();
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();
        #endregion
        #region > Structures            [Count-2]   <
        [StructLayout(LayoutKind.Sequential)]
        struct STARTUPINFO
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct PROCESS_INFORMATION
        {
            internal int hProcess;
            internal int hThread;
            internal int dwProcessId;
            internal int dwThreadId;
        }
        #endregion
        #region > Constants             [Count-7]   <
        const uint INFINITE = 0xFFFFFFFF;
        const int UOI_NAME = 2;
        const int GENERIC_ALL = 0x10000000;
        const int DESKTOP_SWITCHDESKTOP = 0x100;
        const int NORMAL_PRIORITY_CLASS = 0x00000020;
        const int THREAD_BASE_PRIORITY_MAX = 2;
        const int REALTIME_PRIORITY_CLASS = 0x100;
        #endregion
        #region > Variables             [Count-5]   <
        public static int DesktopHandle;                    // Hold desktop handle.
        public static int DesktopInputID;                   // Hold desktop input id.
        public static int DesktopThreadID;                  // Hold desktop thread id.
        static string DesktopName = "DL.Locker.Desktop";    // Hold the name of new created desktop.
        static FileStream TaskMan;                          // Hold the file stream object to control task manager.
        static string FastSwitching = string.Empty;         // Hold the original value of fast switching i.e. welcome screen
        static string ShutdownWithoutLogin = string.Empty;  // Hold the original value of showinh the shutdown button on welcome screen.
        #endregion
        #region > Properteis            [Count-1]   <
        /// <summary>
        /// Enabled used to enable or disable the locker
        /// </summary>
        public static bool Enabled
        {
            set
            {
                SetProcessPriorityHigh();                       // Set the process priority to high.
                
                if (value)                                      // Enable or disable the locker?
                {
                    CreateNewDesktop();                         // Creating new desktop.
                    StartProcess(Application.ExecutablePath);   // Starting the locker form, to allow the user to enter login info.
                }
                else
                {
                    DestroyDesktop();                           // Destroy the desktop.
                    
                    ExitProcess(0);                             // Exit the current process, if desktop attached with no process, default desktop will be activated.
                }
            }
        }
        #endregion
        #region > Functions             [Count-8]   <
        /// <summary>
        /// Backup the value of Welcome screen and Shutdown button, to be restored after locker closed.
        /// </summary>
        public static void BackupRegistryValue()
        {
            FastSwitching = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "LogonType", string.Empty).ToString();
            ShutdownWithoutLogin = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "ShutdownWithoutLogon", string.Empty).ToString();
        }
        /// <summary>
        /// NeedBootStrapping used to check if we need boot strapping, this is done by checking if the current desktop name is the default name or not.
        /// </summary>
        /// <returns>Return true if the current desktop name is the default desktop, return false if the current desktop is the one we created.</returns>
        public static bool NeedBootStrapping()
        {
            return (GetDesktopName() != DesktopName);
        }
        /// <summary>
        /// GetDesktopName used to get the current desktop name, this function help us decide if we need boot strapping or not.
        /// </summary>
        /// <returns>Return the name of current desktop.</returns>
        static string GetDesktopName()
        {
            int DLength = 0, DHandle = GetThreadDesktop(GetCurrentThreadId());
            StringBuilder DName = new StringBuilder();
            GetUserObjectInformation(DHandle, UOI_NAME, DName, 0, ref DLength);
            if (DLength != 0) GetUserObjectInformation(DHandle, UOI_NAME, DName, DLength, ref DLength);
            return (DName.ToString());
        }
        /// <summary>
        /// CreateNewDesktop used to create the new desktop, this desktop will hold the locker process only, as knowen the hot keys
        /// and Taskmanager come with Explorer.exe, so if we attached Explorer.exe to new desktop, we can't disable hotkeys, so the basic
        /// idea to create new desktop is to prevent hotkeys, the new created desktop will be terminated automatically to default desktop
        /// if there is no process attached to it.
        /// </summary>
        static void CreateNewDesktop()
        {
            DesktopThreadID = GetThreadDesktop(GetCurrentThreadId());
            DesktopInputID = OpenInputDesktop(0, false, DESKTOP_SWITCHDESKTOP);
            DesktopHandle = CreateDesktop(DesktopName, "", 0, 0, GENERIC_ALL, 0);
            MessageBox.Show("DesktopThreadID: " + DesktopThreadID + "DesktopInputID: " + DesktopInputID + "DesktopHandle: " + DesktopHandle);
            if (DesktopHandle != 0)
            {
                SetThreadDesktop(DesktopHandle);
                SwitchDesktop(DesktopHandle);
                System.IO.File.WriteAllText(Application.StartupPath + "\\Desktop.Dif", DesktopInputID.ToString() + "|" + DesktopThreadID.ToString() + "|" + DesktopHandle.ToString());
            }
        }
        /// <summary>
        /// DestroyDesktop used to Destroy created desktop, this function usually not used, because created desktop will terminated automatically 
        /// when we terminate any processs attached to it
        /// </summary>
        public static void DestroyDesktop()
        {
            MessageBox.Show("DesktopThreadID: " + DesktopThreadID + "DesktopInputID: " + DesktopInputID + "DesktopHandle: " + DesktopHandle);
            try
            {
                
                if (DesktopThreadID != 0) { SetThreadDesktop(DesktopThreadID); DesktopThreadID = 0; }
                if (DesktopHandle != 0) { CloseDesktop(DesktopHandle); DesktopHandle = 0; }

                if (DesktopInputID != 0) { SwitchDesktop(DesktopInputID); DesktopInputID = 0; }
            }
            catch { }
        }
        public static void switchDesktopMethod(int ptr)
        {
            SwitchDesktop(ptr); 
        }
        /// <summary>
        /// StartProcess used to start a specified process, on a specified desktop, this function is diff. than shell execute, cause shell execute
        /// don't allow us to specify what desktop used. I think :)
        /// </summary>
        /// <param name="Path">Is the path of file to be started.</param>
        static void StartProcess(string Path)
        {
            PROCESS_INFORMATION PI = new PROCESS_INFORMATION();
            STARTUPINFO SI = new STARTUPINFO();
            SI.cb = Marshal.SizeOf(SI);
            SI.lpDesktop = DesktopName;
            bool Result = CreateProcess(null, Path, IntPtr.Zero, IntPtr.Zero, true, NORMAL_PRIORITY_CLASS, IntPtr.Zero, null, ref SI, ref PI);
            if (Result)
            {
                WaitForSingleObject(PI.hProcess, INFINITE);
                CloseHandle(PI.hProcess);
                CloseHandle(PI.hThread);
            }
            else DestroyDesktop();
        }
        /// <summary>
        /// TaskManager used to enable or disable the task manager, some people will wonder what is the use of it, we create new desktop, which
        /// dosn't contain hotkeys or task manager, so why we use it? the answer is when you press Ctrl + Alt + Del in new created desktop, the 
        /// task manager will appear in default task manager, so after the locker closed you will find the task manager, so I cancel it from
        /// registery for maximum security and also open the file for binary and lock read, write to disable msgbox telling me that task manager
        /// stopped by admin.
        /// </summary>
        /// <param name="Enabled">Bool value specify if taskmanager enabled or disabled.</param>
        static void TaskManager(bool Enabled)
        {
            if (GetWinVersion()[0] == "WinNT")
            {
                RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                RegKey.SetValue("DisableTaskMgr", !Enabled, RegistryValueKind.DWord); RegKey.Close();
                if (GetWinVersion()[1] == "Win2000")
                {
                    RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\LocalUser\Software\Microsoft\Windows\CurrentVersion\Policies\System");
                    RegKey.SetValue("DisableTaskMgr", !Enabled, RegistryValueKind.DWord); RegKey.Close();
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (!Enabled)
                {
                    for (int I = 0; I < Process.GetProcesses().Length; I++)
                    {
                        if (Process.GetProcesses()[I].ProcessName.ToLower() == "Taskmgr".ToLower()) Process.GetProcesses()[I].Kill();
                        if (Process.GetProcesses()[I].MainWindowTitle.ToLower() == "Windowis Task Manager".ToLower()) Process.GetProcesses()[I].Kill();
                    }
                    TaskMan = File.Open(Environment.SystemDirectory + @"\Taskmgr.exe", FileMode.Open, FileAccess.Read, FileShare.None);
                }
                else if (TaskMan != null) TaskMan.Close();
            }
            else SystemParametersInfo(97, Enabled, Enabled, 0);
        }
        /// <summary>
        /// Block Windows security screen from appearing by using Windows Welcome Screen, also remove the shutdown button from welcome screen.
        /// </summary>
        /// <param name="Enabled">Either enable or disable this function.</param>
        public static void BlockWindowsSecurity(bool Enabled)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "LogonType", (Enabled) ? "1" : FastSwitching, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "ShutdownWithoutLogon", (Enabled) ? "0" : ShutdownWithoutLogin, RegistryValueKind.DWord);
        }
        /// <summary>
        /// GetWinVersion used to get the windows version, we need this function for registary purpose, as we know in win-9x based OS, we can 
        /// cancle task manager by using SystemParametersInfo, but in NT we can't use it, so we have to know what version of windows we run.
        /// </summary>
        /// <returns>Return fixed array of string of size 2, the 1st string is the platform NT or 9X, the 2nd is the version name.</returns>
        static string[] GetWinVersion()
        {
            string Platform = ((int)Environment.OSVersion.Platform == 2) ? "WinNT" : (((int)Environment.OSVersion.Platform == 1) ? "Win" : "WinS");
            string OSVersion = (Environment.OSVersion.Version.Major.ToString() + "." + Environment.OSVersion.Version.Minor.ToString());
            OSVersion = (OSVersion == "5.1") ? "WinXP" : ((OSVersion == "5.0") ? "Win2000" : "Other");
            return (new string[2] { Platform, OSVersion });
        }
        /// <summary>
        /// SetProcessPriorityHigh, used to set the priority to high, to make it start faster.
        /// </summary>
        static void SetProcessPriorityHigh()
        {
            SetThreadPriority(GetCurrentThread(), THREAD_BASE_PRIORITY_MAX);
            SetPriorityClass(GetCurrentProcess(), REALTIME_PRIORITY_CLASS);
        }
        #endregion
    }
}

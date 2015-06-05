using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace start_process_reflector1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool StartWithCreateProcess(ProcessStartInfo startInfo)
        {
            if ((startInfo.StandardOutputEncoding != null) && !startInfo.RedirectStandardOutput)
            {
                //throw new InvalidOperationException(SR.GetString("StandardOutputEncodingNotAllowed"));
            }
            if ((startInfo.StandardErrorEncoding != null) && !startInfo.RedirectStandardError)
            {
             //   throw new InvalidOperationException(SR.GetString("StandardErrorEncodingNotAllowed"));
            }
          //  if (this.disposed)
            {
          //      throw new ObjectDisposedException(base.GetType().Name);
            }
            StringBuilder builder1 = Process.BuildCommandLine(startInfo.FileName, startInfo.Arguments);
            NativeMethods.STARTUPINFO startupinfo1 = new NativeMethods.STARTUPINFO();
            SafeNativeMethods.PROCESS_INFORMATION process_information1 = new SafeNativeMethods.PROCESS_INFORMATION();
            SafeProcessHandle handle1 = new SafeProcessHandle();
            SafeThreadHandle handle2 = new SafeThreadHandle();
            int num1 = 0;
            SafeFileHandle handle3 = null;
            SafeFileHandle handle4 = null;
            SafeFileHandle handle5 = null;
            GCHandle handle6 = new GCHandle();
            try
            {
                bool flag1;
                if ((startInfo.RedirectStandardInput || startInfo.RedirectStandardOutput) || startInfo.RedirectStandardError)
                {
                    if (startInfo.RedirectStandardInput)
                    {
                        this.CreatePipe(out handle3, out startupinfo1.hStdInput, true);
                    }
                    else
                    {
                        startupinfo1.hStdInput = new SafeFileHandle(NativeMethods.GetStdHandle(-10), false);
                    }
                    if (startInfo.RedirectStandardOutput)
                    {
                        this.CreatePipe(out handle4, out startupinfo1.hStdOutput, false);
                    }
                    else
                    {
                        startupinfo1.hStdOutput = new SafeFileHandle(NativeMethods.GetStdHandle(-11), false);
                    }
                    if (startInfo.RedirectStandardError)
                    {
                        this.CreatePipe(out handle5, out startupinfo1.hStdError, false);
                    }
                    else
                    {
                        startupinfo1.hStdError = new SafeFileHandle(NativeMethods.GetStdHandle(-12), false);
                    }
                    startupinfo1.dwFlags = 0x100;
                }
                int num2 = 0;
                if (startInfo.CreateNoWindow)
                {
                    num2 |= 0x8000000;
                }
                IntPtr ptr1 = IntPtr.Zero;
                if (startInfo.environmentVariables != null)
                {
                    bool flag2 = false;
                    if (ProcessManager.IsNt)
                    {
                        num2 |= 0x400;
                        flag2 = true;
                    }
                    byte[] buffer1 = EnvironmentBlock.ToByteArray(startInfo.environmentVariables, flag2);
                    handle6 = GCHandle.Alloc(buffer1, GCHandleType.Pinned);
                    ptr1 = handle6.AddrOfPinnedObject();
                }
                string text1 = startInfo.WorkingDirectory;
                if (text1 == string.Empty)
                {
                    text1 = Environment.CurrentDirectory;
                }
                if (startInfo.UserName.Length != 0)
                {
                    NativeMethods.LogonFlags flags1 = 0;
                    if (startInfo.LoadUserProfile)
                    {
                        flags1 = NativeMethods.LogonFlags.LOGON_WITH_PROFILE;
                    }
                    IntPtr ptr2 = IntPtr.Zero;
                    try
                    {
                        if (startInfo.Password == null)
                        {
                            ptr2 = Marshal.StringToCoTaskMemUni(string.Empty);
                        }
                        else
                        {
                            ptr2 = Marshal.SecureStringToCoTaskMemUnicode(startInfo.Password);
                        }
                        RuntimeHelpers.PrepareConstrainedRegions();
                        try
                        {
                        }
                        finally
                        {
                            flag1 = NativeMethods.CreateProcessWithLogonW(startInfo.UserName, startInfo.Domain, ptr2, flags1, null, builder1, num2, ptr1, text1, startupinfo1, process_information1);
                            if (!flag1)
                            {
                                num1 = Marshal.GetLastWin32Error();
                            }
                            if ((process_information1.hProcess != IntPtr.Zero) && (process_information1.hProcess != NativeMethods.INVALID_HANDLE_VALUE))
                            {
                                handle1.InitialSetHandle(process_information1.hProcess);
                            }
                            if ((process_information1.hThread != IntPtr.Zero) && (process_information1.hThread != NativeMethods.INVALID_HANDLE_VALUE))
                            {
                                handle2.InitialSetHandle(process_information1.hThread);
                            }
                        }
                        if (!flag1)
                        {
                            if (num1 == 0xc1)
                            {
                                throw new Win32Exception(num1, SR.GetString("InvalidApplication"));
                            }
                            throw new Win32Exception(num1);
                        }
                        goto Label_03AE;
                    }
                    finally
                    {
                        if (ptr2 != IntPtr.Zero)
                        {
                            Marshal.ZeroFreeCoTaskMemUnicode(ptr2);
                        }
                    }
                }
                RuntimeHelpers.PrepareConstrainedRegions();
                try
                {
                }
                finally
                {
                    flag1 = NativeMethods.CreateProcess(null, builder1, null, null, true, num2, ptr1, text1, startupinfo1, process_information1);
                    if (!flag1)
                    {
                        num1 = Marshal.GetLastWin32Error();
                    }
                    if ((process_information1.hProcess != IntPtr.Zero) && (process_information1.hProcess != NativeMethods.INVALID_HANDLE_VALUE))
                    {
                        handle1.InitialSetHandle(process_information1.hProcess);
                    }
                    if ((process_information1.hThread != IntPtr.Zero) && (process_information1.hThread != NativeMethods.INVALID_HANDLE_VALUE))
                    {
                        handle2.InitialSetHandle(process_information1.hThread);
                    }
                }
                if (!flag1)
                {
                    if (num1 == 0xc1)
                    {
                        throw new Win32Exception(num1, SR.GetString("InvalidApplication"));
                    }
                    throw new Win32Exception(num1);
                }
            }
            finally
            {
                if (handle6.IsAllocated)
                {
                    handle6.Free();
                }
                startupinfo1.Dispose();
            }
        Label_03AE:
            if (startInfo.RedirectStandardInput)
            {
                this.standardInput = new StreamWriter(new FileStream(handle3, FileAccess.Write, 0x1000, false), Encoding.GetEncoding(NativeMethods.GetConsoleCP()), 0x1000);
                this.standardInput.AutoFlush = true;
            }
            if (startInfo.RedirectStandardOutput)
            {
                Encoding encoding1 = (startInfo.StandardOutputEncoding != null) ? startInfo.StandardOutputEncoding : Encoding.GetEncoding(NativeMethods.GetConsoleOutputCP());
                this.standardOutput = new StreamReader(new FileStream(handle4, FileAccess.Read, 0x1000, false), encoding1, true, 0x1000);
            }
            if (startInfo.RedirectStandardError)
            {
                Encoding encoding2 = (startInfo.StandardErrorEncoding != null) ? startInfo.StandardErrorEncoding : Encoding.GetEncoding(NativeMethods.GetConsoleOutputCP());
                this.standardError = new StreamReader(new FileStream(handle5, FileAccess.Read, 0x1000, false), encoding2, true, 0x1000);
            }
            bool flag3 = false;
            if (!handle1.IsInvalid)
            {
                this.SetProcessHandle(handle1);
                this.SetProcessId(process_information1.dwProcessId);
                handle2.Close();
                flag3 = true;
            }
            return flag3;
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            StartWithCreateProcess(new ProcessStartInfo("iexplore"));
        }
    }
}
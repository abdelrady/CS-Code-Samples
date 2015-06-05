using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using WindowsApplication6;

public class WindowHooks {

[DllImport("user32.dll")]
public static extern IntPtr SetWindowsHookEx(int idHook, System.Delegate
lpfn, IntPtr hmod, IntPtr dwThreadId);

[DllImport("user32.dll")]
public static extern int UnhookWindowsHookEx(IntPtr hhook);

[DllImport("user32.dll")]
public static extern IntPtr CallNextHookEx(IntPtr hhook, int nCode,
IntPtr wParam,
IntPtr lParam
);

[DllImport("kernel32.dll")]
public extern static IntPtr GetModuleHandle(string lpModuleName);


private int WH_CBT = 5;
private long GWL_HINSTANCE = -6;
private long HCBT_ACTIVATE = 5;
private long HCBT_CREATEWND = 3;

public delegate IntPtr MessageProc(int code, IntPtr wParam, IntPtr
lParam);
private static IntPtr hookHandle;

    Form1 frm;

public void InstallHook(Form1 frm2) {
    frm=frm2;
 IntPtr hMod = System.Runtime.InteropServices.Marshal.GetHINSTANCE( this.GetType().Module );

MessageProc hookFunction = new MessageProc(NewMessageBoxHook);

 IntPtr hInstance = GetModuleHandle(null);


 System.Runtime.InteropServices.Marshal.GetHINSTANCE(Assembly.GetCallingAssembly().GetModules()[0]).ToInt32();

System.Windows.Forms.MessageBox.Show("hooked");
 //hookHandle = SetWindowsHookEx(WH_CBT, hookFunction, IntPtr.Zero, new IntPtr(AppDomain.GetCurrentThreadId()));
 hookHandle = SetWindowsHookEx(WH_CBT, hookFunction, hInstance,IntPtr.Zero);
// hookHandle = SetWindowsHookEx(WH_CBT, hookFunction, hMod, IntPtr.Zero);

}

public void UnistallHook() {
System.Windows.Forms.MessageBox.Show("unhooked");
 UnhookWindowsHookEx(hookHandle);
}

private IntPtr NewMessageBoxHook( int code, IntPtr wparam, IntPtr lparam)
{

try {
if (code == HCBT_ACTIVATE) {
// Console.WriteLine("Window activated.");
    frm.listBox1.Items.Add(code.ToString() + " " + wparam.ToInt32().ToString());
} else if (code == HCBT_CREATEWND) {
// Console.WriteLine("new Window created.");
}
} catch (System.Exception ex) {
Console.WriteLine(ex);
}


IntPtr inPtr;
try {
inPtr = CallNextHookEx(hookHandle, code, wparam, lparam);
} catch (System.Exception ex) {

Console.WriteLine("NextHook: '" + ex);
inPtr = new IntPtr(0);
}
return inPtr;
}
}




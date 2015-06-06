using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Client_s_
{
    public class CloseButtonRemove
    {
        private const int MF_BYPOSITION = 1024;
        private const int MF_DISABLED = 2;
        //Default Constructor Ali Hussien
        private CloseButtonRemove(){}
        //Core Function Override API
        public static void Disable(Form form)
        {
            IntPtr intPtr = form.Handle;
            int menu = CloseButtonRemove.GetSystemMenu(intPtr.ToInt32(), 0);
            int count = CloseButtonRemove.GetMenuItemCount(menu);
            bool flag = CloseButtonRemove.RemoveMenu(menu, checked(count - 1), 1026) == 0;
            intPtr = form.Handle;
            flag = CloseButtonRemove.DrawMenuBar(intPtr.ToInt32()) == 0;
        }
        //Override API Features
        [PreserveSig]
        [DllImport("user32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int DrawMenuBar(int hwnd);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int FormatMessageA(int flags, ref object source, int messageID, int languageID, [MarshalAs(UnmanagedType.VBByRefStr)] ref string buffer, int size, ref int arguments);

        [PreserveSig]
        [DllImport("user32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetMenuItemCount(int menu);

        [PreserveSig]
        [DllImport("user32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetSystemMenu(int hwnd, int revert);

        [PreserveSig]
        [DllImport("user32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int RemoveMenu(int menu, int position, int flags);
    } // class CloseButtonRemove
}


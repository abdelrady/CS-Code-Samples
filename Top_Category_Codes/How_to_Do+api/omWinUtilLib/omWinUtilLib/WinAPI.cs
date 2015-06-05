using System;

namespace om.Win.Util.Lib
{
	/// <summary>
	/// Summary description for WinAPI.
	/// </summary>


	internal class WinAPI
	{
			#region Windows API
		// Win API Alias in C# : EntryPoint
		[System.Runtime.InteropServices.DllImport("user32.dll", 
			 CharSet=System.Runtime.InteropServices.CharSet.Auto
		,EntryPoint="FindWindow")]
		public static extern IntPtr myFindWindow(string lpClassName, 
			string lpWindowName);

				//--------API for Hide and Restore windows----------//
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		public static extern bool ShowWindowAsync(
			IntPtr hWnd, int nCmdShow
			);
				//--------API for disable button close----------//
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		public static extern IntPtr GetSystemMenu(
			IntPtr hWnd, int Revert);
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		public static extern int GetMenuItemCount(
			IntPtr hMenu);
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		public static extern int RemoveMenu(
			IntPtr hMenu, int nPosition, int wFlags);
		[System.Runtime.InteropServices.DllImport("user32.dll")] 
		public static extern bool DrawMenuBar(
			IntPtr hMenu);

			#endregion
			#region Appication constancts
		public const int SW_RESTORE = 9;
		public const int SW_HIDE = 0;
		public const int MF_BYPOSITION = 0x0400;

		public const int SW_SHOWNORMAL = 1;
		public const int SW_SHOWMINIMIZED = 2;
		public const int SW_SHOWMAXIMIZED = 3;
		public const int SW_SHOWNOACTIVATE = 4;
			
		public const int SW_SHOWDEFAULT = 10;
		//	public const int WM_SYSCOMMAND  = 0x0112; 
		//	public const int SC_CLOSE = 0xF060; 
			#endregion
		private WinAPI()
		{}
		
	}
}

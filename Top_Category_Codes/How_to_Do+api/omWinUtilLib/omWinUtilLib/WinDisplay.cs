using System;

namespace om.Win.Util.Lib
{
	/// <summary>
	/// Summary description for WinDisplay.
	/// </summary>
	public class WinDisplay
	{
		private string _sWinName;
		private IntPtr _hWnd;

		public enum WinAct	{Hide =1,Restore,Active,Minimized,Maximized,Normal}

		public WinDisplay(string s)
		{
			_sWinName = s;
		}
		private bool findWin()
		{
			_hWnd = WinAPI.myFindWindow(null,_sWinName);
			return _hWnd.Equals(IntPtr.Zero)? false:true;
		}

		public bool onAction(WinAct vWinAct)
		{
			  bool vReturn=false;
			try
			{
				if (findWin()==true)
				{
					switch(vWinAct)
					{
						case WinAct.Hide:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_HIDE);
							break;
						case WinAct.Restore:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_RESTORE);
							break;
						case WinAct.Active:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_SHOWNOACTIVATE);
							break;
						case WinAct.Minimized:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_SHOWMINIMIZED);
							break;
						case WinAct.Maximized:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_SHOWMAXIMIZED);
							break;
						case WinAct.Normal:
							WinAPI.ShowWindowAsync(_hWnd, WinAPI.SW_SHOWNORMAL);
							break;
					}
					vReturn = true;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				vReturn = false;
			}
			return vReturn;
		}
	}
}

using System;

namespace om.Win.Util.Lib
{
	/// <summary>
	/// Summary description for DisableClose.
	/// </summary>
	public class DisableClose
	{
		private string _sWinName;
		private IntPtr _hWnd;
			#region Constructor with Get & Set properties
		public DisableClose()
		{

		}
		public DisableClose(string s)
		{
			_sWinName = s;
		}
		public string WindowName
		{
			get
			{return _sWinName;}
			set
			{_sWinName=value;}
		}
			#endregion
			#region Private methods to the class
		private bool findWin()
		{
			_hWnd = WinAPI.myFindWindow(null,_sWinName);
			return _hWnd.Equals(IntPtr.Zero)? false:true;
		}
			#endregion
		public bool disableClose()
		{
			IntPtr hSysMenu;
			int menuItemCount;
			bool vReturn=false;
			try
			{
				if (findWin()==true)
				{
					hSysMenu = WinAPI.GetSystemMenu(_hWnd,0);
					menuItemCount = WinAPI.GetMenuItemCount(hSysMenu);
					if (menuItemCount > 0)
					{
						/*Remove the system menu close menu item. The menu item is 0-based, 
							 * so the last item on the menu is menuItemCount -1*/
						WinAPI.RemoveMenu(hSysMenu,menuItemCount-1,WinAPI.MF_BYPOSITION);
						//Lastly, we remove the seperator bar
						WinAPI.RemoveMenu(hSysMenu,menuItemCount-2,WinAPI.MF_BYPOSITION);
					}
					/* refereshes the titlebar, dimming the X */
					WinAPI.DrawMenuBar(hSysMenu);
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

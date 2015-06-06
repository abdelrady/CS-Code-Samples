using System;
using System.Runtime.InteropServices;

namespace sss
{	
	public class ScreenSaverHandler
	{
		
		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern bool SystemParametersInfo( 
            int uAction, int uParam, ref int lpvParam, 
			int flags );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern bool SystemParametersInfo( 
			int uAction, int uParam, ref bool lpvParam, 
			int flags );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern int PostMessage( IntPtr hWnd, 
			int wMsg, int wParam, int lParam );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern IntPtr OpenDesktop( 
			string hDesktop, int Flags, bool Inherit, 
			uint DesiredAccess );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern bool CloseDesktop( 
			IntPtr hDesktop );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern bool EnumDesktopWindows( 
			IntPtr hDesktop, EnumDesktopWindowsProc callback, 
			IntPtr lParam );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		private static extern bool IsWindowVisible( 
			IntPtr hWnd );

		[DllImport( "user32.dll", CharSet = CharSet.Auto )]
		public static extern IntPtr GetForegroundWindow( );
		
		private delegate bool EnumDesktopWindowsProc(IntPtr hDesktop, IntPtr lParam );		
		private const int SPI_GETSCREENSAVERACTIVE = 16;
		private const int SPI_SETSCREENSAVERACTIVE = 17;
		private const int SPI_GETSCREENSAVERTIMEOUT = 14;
		private const int SPI_SETSCREENSAVERTIMEOUT = 15;
		private const int SPI_GETSCREENSAVERRUNNING = 114;
		private const int SPIF_SENDWININICHANGE = 2;
		private const uint DESKTOP_WRITEOBJECTS = 0x0080;
		private const uint DESKTOP_READOBJECTS = 0x0001;
		private const int WM_CLOSE = 16;
		public static bool IsScreenSaverRunning()
		{
			bool isRunning = false;
			SystemParametersInfo( SPI_GETSCREENSAVERRUNNING, 0, 
				ref isRunning, 0 );
			return isRunning;
		}

		public static bool IsScreenSaverSetup()
		{
			bool isActive = false;
			SystemParametersInfo( SPI_GETSCREENSAVERACTIVE, 0,ref isActive, 0 );
			return isActive;
		}

		public static void SetScreenSaverTimeout( Int32 Value )
		{
			int nullVar = 0;

			SystemParametersInfo( SPI_SETSCREENSAVERTIMEOUT, 
				Value, ref nullVar, SPIF_SENDWININICHANGE );
		}

		public static bool LaunchScreenSaver()
		{
			SetScreenSaverTimeout(1);
			return true;
		}

		public static bool StopScreenSaver()
		{
			SetScreenSaverTimeout(2000);

			IntPtr hDesktop = OpenDesktop( "Screen-saver", 0,false,DESKTOP_READOBJECTS | DESKTOP_WRITEOBJECTS);
			if( hDesktop != IntPtr.Zero )
			{
				EnumDesktopWindows( hDesktop, new 
					EnumDesktopWindowsProc( KillScreenSaverFunc ),
					IntPtr.Zero );
				CloseDesktop( hDesktop );
			}
			else
			{
				PostMessage( GetForegroundWindow( ), WM_CLOSE, 
					0, 0 );
			}
			return true;
		}
		
		private static bool KillScreenSaverFunc( IntPtr hWnd,IntPtr lParam )
		{
			if( IsWindowVisible( hWnd ) )
				PostMessage( hWnd, WM_CLOSE, 0, 0 );
			return true;
		}
	}
}

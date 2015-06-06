#include"VideoPlayer.h"
	
MCIERROR VideoPlayer::OpenAVI();
	{
		MCI_DGV_OPEN_PARMS  open; 	
		open.lpstrElementName = File_Name;  // Set the filename   
		open.hWndParent =	Win_Handel  ;     // Set Dlg Handle 	
		return mciSendCommand(0, MCI_OPEN,(DWORD)(MCI_OPEN_ELEMENT|MCI_DGV_OPEN_PARENT),(DWORD)(LPSTR)&open);
	}

MCIERROR VideoPlayer:: SetInitDlg()
	{
		MCI_DGV_WINDOW_PARMS Window; 		
		Window.hWnd = Win_Handel; 
		return mciSendCommand(mciOpen.wDeviceID, MCI_WINDOW, MCI_DGV_WINDOW_HWND,(DWORD)(LPSTR)&mciWindow); 
	}

MCIERROR VideoPlayer::PlayAVI()
	{	
		MCI_DGV_PLAY_PARMS Play;    // play parameters 	
		mciPlay.dwFrom = 0;	
		return mciSendCommand(mciOpen.wDeviceID, MCI_PLAY, 0,(DWORD)(LPVOID)&Play);
	}

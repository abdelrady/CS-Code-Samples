// multimedia_c_1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
# include <Windows.h>
# include <Mmsystem.h>
# include <WinNT.h>


int _tmain(int argc, _TCHAR* argv[])
{
	UINT wDeviceID;
            DWORD dwReturn;
            MCI_OPEN_PARMS mciOpenParms;

            // Opens a CD audio device by specifying the device name.

            mciOpenParms.lpstrDeviceType =static_cast<LPCWSTR> ("cdaudio");

            if (dwReturn = mciSendCommand(NULL, MCI_OPEN, MCI_OPEN_TYPE,
                (DWORD)(LPVOID) & mciOpenParms))
            {

                // Error, unable to open device.

            }

            // The device opened successfully; get the device ID.
            wDeviceID = mciOpenParms.wDeviceID;

	return 0;
}


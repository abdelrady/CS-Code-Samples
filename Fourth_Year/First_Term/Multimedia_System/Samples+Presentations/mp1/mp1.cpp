# include <Windows.h>
# include <Mmsystem.h>
# include <WinNT.h>

void main()
{
/*	UINT wDeviceID;
            DWORD dwReturn;
            MCI_OPEN_PARMS mciOpenParms;

            // Opens a CD audio device by specifying the device name.

            mciOpenParms.lpstrDeviceType ="cdaudio";

            if (dwReturn = mciSendCommand(NULL, MCI_OPEN, MCI_OPEN_TYPE,
                (DWORD)(LPVOID) & mciOpenParms))
            {

                // Error, unable to open device.

            }

            // The device opened successfully; get the device ID.
            wDeviceID = mciOpenParms.wDeviceID;
*/
	LPTSTR str1="";
	mciSendString(
    "open F:\\ibrahiem.wav type waveaudio alias finch",str1, lstrlen(str1), NULL);
mciSendString("set finch time format samples", str1, 
    lstrlen(str1), NULL);
mciSendString("play finch from 1 to 10000", str1, 
    lstrlen(str1), NULL);
mciSendString("close finch", str1, 
    lstrlen(str1), NULL);

//	return 0;
}
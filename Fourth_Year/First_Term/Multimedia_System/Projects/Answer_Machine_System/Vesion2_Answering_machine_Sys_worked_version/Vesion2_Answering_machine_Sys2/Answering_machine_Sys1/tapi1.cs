using System;
using System.Text;
using System.Runtime.InteropServices;
using Answering_machine_Sys1;
namespace tapi1_cs
{
    public class TAPI
    {
        public static int hCall;
        public static int hTAPI;
        public static int lNumLines;
        public static int hLine;
        public static linedevcaps lpLineDevCaps;
        public static Form1 userInterface;
        public const int TAPIVERSION = 0x10004;
        public const short LINECALLPRIVILEGE_OWNER = 0x4;
        public const short LINECALLPRIVILEGE_MONITOR = 0x2;
        public const short LINEMEDIAMODE_AUTOMATEDVOICE = 0x8;
        public const int LINE_LINEDEVSTATE = 8;
        public const int LINE_CALLSTATE = 2;
        public const int LINECALLSTATE_OFFERING = 0x2;
        public const int LINECALLSTATE_ACCEPTED = 0x4;
        public const int LINECALLSTATE_DISCONNECTED = 0x4000;
        public const short LINEDIGITMODE_DTMF = 0x2;
        public const short LINE_MONITORDIGITS = 9;
        public const int LINECALLSELECT_CALL = 0x4;
        
        public struct varString
        {
            public long dwTotalSize;
            public long dwNeededSize;
            public long dwUsedSize;
            public long dwStringFormat;
            public long dwStringSize;
            public long dwStringOffset;
            public string bBytes;
        }
        
        
        public struct linedialparams
        {
            int dwDialPause;
            int dwDialSpeed;
            int dwDigitDuration;
            int dwWaitForDialtone;
        }
        
        public struct lineextensionid
        {
            int dwExtensionID0;
            int dwExtensionID1;
            int dwExtensionID2;
            int dwExtensionID3;
        }
        
        public struct linedevcaps
        {
            public int dwTotalSize;
            public int dwNeededSize;
            public int dwUsedSize;
            public int dwProviderInfoSize;
            public int dwProviderInfoOffset;
            public int dwSwitchInfoSize;
            public int dwSwitchInfoOffset;
            public int dwPermanentLineID;
            public int dwLineNameSize;
            public int dwLineNameOffset;
            public int dwStringFormat;
            public int dwAddressModes;
            public int dwNumAddresses;
            public int dwBearerModes;
            public int dwMaxRate;
            public int dwMediaModes;
            public int dwGenerateToneModes;
            public int dwGenerateToneMaxNumFreq;
            public int dwGenerateDigitModes;
            public int dwMonitorToneMaxNumFreq;
            public int dwMonitorToneMaxNumEntries;
            public int dwMonitorDigitModes;
            public int dwGatherDigitsMinTimeout;
            public int dwGatherDigitsMaxTimeout;
            public int dwMedCtlDigitMaxListSize;
            public int dwMedCtlMediaMaxListSize;
            public int dwMedCtlToneMaxListSize;
            public int dwMedCtlCallStateMaxListSize;
            public int dwDevCapFlags;
            public int dwMaxNumActiveCalls;
            public int dwAnswerMode;
            public int dwRingModes;
            public int dwLineStates;
            public int dwUUIAcceptSize;
            public int dwUUIAnswerSize;
            public int dwUUIMakeCallSize;
            public int dwUUIDropSize;
            public int dwUUISendUserUserInfoSize;
            public int dwUUICallInfoSize;
            public linedialparams MinDialParams;
            public linedialparams MaxDialParams;
            public linedialparams DefaultDialParams;
            public int dwNumTerminals;
            public int dwTerminalCapsSize;
            public int dwTerminalCapsOffset;
            public int dwTerminalTextEntrySize;
            public int dwTerminalTextSize;
            public int dwTerminalTextOffset;
            public int dwDevSpecificSize;
            public int dwDevSpecificOffset;
            public int dwLineFeatures; // TAPI v1.4
            public string bBytes;
            //public char[] bBytes;
            //public StringBuilder bBytes;
        }

        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern long lineGetID(
            int hLine,
            int dwAddressID,
            int hCall,
            int dwSelect,
            varString lpDevice,
            string lpszDeviceClass);

        [DllImport("Tapi32.dll", SetLastError = true)]
        public static extern int LineGatherDigits(int hCall, int dwDigitsModes, ref string lpsDigits, int dwNumDigits, string lpszTerminationDigits, int dwFirstDigitTimeout, int dwInterDigitTimeout);
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineMonitorDigits(
            int hCall,
            int dwDigitModes);
        
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineAnswer(
            int hCall,
            ref string lpsUserUserInfo,
            int dwSize);

        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineInitialize(ref int hTAPI, int
        hInst, LineCallBackDelegate fnPtr,
        ref int szAppName, ref int dwNumLines);
        
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineNegotiateAPIVersion(int hTAPI,
            int dwDeviceID,
            int dwAPILowVersion,
            int dwAPIHighVersion,
            ref int lpdwAPIVersion,
            ref lineextensionid lpExtensionID);

        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineOpen(
        int hLineApp,
        int dwDeviceID,
        ref int lphLine,
        int dwAPIVersion,
        int dwExtVersion,
        ref int dwCallbackInstance,
        int dwPrivileges,
        int dwMediaModes,
        ref int lpCallParams);
        
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineGetDevCaps(
        int hLineApp,
        int dwDeviceID,
        int dwAPIVersion,
        int dwExtVersion,
        ref linedevcaps lpLineDevCaps);

        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineSetStatusMessages(
                int hLine,
                int dwLineStates,
                int dwAddressStates);
        
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineDrop(
            int hCall,
            string lpsUserUserInfo,
            int dwSize);
        
        
        [DllImport("Tapi32.dll", SetLastError = true)]
        
        public static extern int lineShutdown(int hLineApp);

        public delegate int LineCallBackDelegate(int dwDevice,int dwMessage,int dwInstance,int dwParam1,int dwParam2,int dwParam3);
        public static bool first;
        public static int LineCallBack(int dwDevice, int dwMessage,int dwInstance, int dwParam1, int dwParam2, int dwParam3)
        {
            string msgEvent = "";
            msgEvent = Convert.ToString(dwMessage);
            switch (dwMessage)
            {
                case LINE_MONITORDIGITS:
                    msgEvent = "DTMF";
                    if (!TAPI.first)
                    {
                        userInterface.Add2DB(dwParam1 - 48);
                        TAPI.first = true;
                    }
                    //userInterface.GetNum(dwParam1);
                    break;
                case LINE_CALLSTATE:
                    switch (dwParam1)
                    {
                        case LINECALLSTATE_OFFERING:
                            msgEvent = "Incomming call";
                            hCall = dwDevice;
                            break;
                        case LINECALLSTATE_ACCEPTED:
                            msgEvent = "Call accepted";
                            userInterface.playWave2("welcome.wav");

                            break;
                        case LINECALLSTATE_DISCONNECTED:
                            msgEvent = "Call disconnected";
                            break;
                    }
                    break;
                case LINE_LINEDEVSTATE:
                    msgEvent = "Ringing";
                    userInterface.acceptCall();
                    break;
            }
            userInterface.showMessage("Event: " + msgEvent + " Data:"
            + dwParam1 + "\r\n");
            return 1;
        }
        public static string GetLineID(string sWave)
        {
            long nError = 0;
            string sTemp = "";
            TAPI.varString oVar = new TAPI.varString();
            System.Text.StringBuilder sb = new
            System.Text.StringBuilder();
            oVar.bBytes = sb.Append(' ', 2000).ToString();
            oVar.dwTotalSize = Marshal.SizeOf(oVar);
            
            nError = lineGetID(hLine, 0, hCall,
            LINECALLSELECT_CALL, oVar, sWave);
            
            if (oVar.dwStringOffset == 0) return "-1";
            sTemp = oVar.bBytes.Substring(0,
            (int)oVar.dwStringSize).Trim();
            return sTemp;
        }
    }
}
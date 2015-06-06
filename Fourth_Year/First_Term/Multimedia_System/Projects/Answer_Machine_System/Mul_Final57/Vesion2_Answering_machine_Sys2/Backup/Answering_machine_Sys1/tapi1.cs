using System;
using System.Text;
using System.Runtime.InteropServices;
using Answering_machine_Sys1;
using System.Diagnostics;
using System.Threading;
namespace tapi1_cs
{
    public class TAPI
    {
        public static int hCall;
        public static int RingsCount;
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
        public const int LINECALLSTATE_CONNECTED = 0x100;
        public const int LINECALLSTATE_DISCONNECTED = 0x4000;
        public const short LINEDIGITMODE_DTMF = 0x2;
        public const short LINE_MONITORDIGITS = 9;
        public const int LINECALLSELECT_CALL = 0x4;
        public const int LINEDEVSTATE_RINGING = 0x00000002;
        
        [StructLayout(LayoutKind.Sequential,
            Pack = 1, Size = 2024)]
        public struct varString
        {
            public int dwTotalSize;
            public int dwNeededSize;
            public int dwUsedSize;
            public int dwStringFormat;
            public int dwStringSize;
            public int dwStringOffset;
            public byte bBytes;
        }

        [StructLayout(LayoutKind.Sequential,Pack = 1)]
        public struct linedialparams
        {
            int dwDialPause;
            int dwDialSpeed;
            int dwDigitDuration;
            int dwWaitForDialtone;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct lineextensionid
        {
            int dwExtensionID0;
            int dwExtensionID1;
            int dwExtensionID2;
            int dwExtensionID3;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1,Size=2240)]
        public struct linedevcaps
        {
            //[FieldOffset(0)]
           
            //[FieldOffset(2000)]
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
            
            public byte bBytes;
            
            //public char[] bBytes;
            //public StringBuilder bBytes;
        }

        [DllImport("Tapi32.dll", SetLastError = true)]
        public static extern long lineGetID(
            int hLine,
            int dwAddressID,
            int hCall,
            int dwSelect,
            IntPtr src,
            string lpszDeviceClass);
        [DllImport("Tapi32.dll", SetLastError = true)]
        public static extern int lineDeallocateCall(int hCall);
        
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
        public static bool firstDigit=false;
        static string str;
        
    public static int LineCallBack(int dwDevice, int dwMessage,
            int dwInstance, int dwParam1, int dwParam2, int dwParam3)
        {
            string msgEvent = "";
            msgEvent = Convert.ToString(dwMessage);
            switch (dwMessage)
            {
                case LINE_MONITORDIGITS:
                    msgEvent = "DTMF";
                    if (!TAPI.firstDigit )//&& !audio.audio.playing)
                    {
                        if (dwParam1 < 52 && dwParam1 > 48)
                        {
                            TAPI.firstDigit = true;
                            userInterface.Add2DB(dwParam1 - 48);
                        }
                        else
                        {
                            while (audio.audio.playing) ;
                            audio.audio.FreeMemory();
                            Answering_machine_Sys1.Form1.playWave2("Bad_choise.wav");
                        }
                        
                    }
                    if (dwParam1 > 47)
                    {
                        userInterface.showMessage("System User Press "
                            + Convert.ToString((dwParam1 - 48)));
                    }
                    else if (dwParam1 == 35)
                        userInterface.showMessage("System User Press #");
                    else if (dwParam1 == 42)
                        userInterface.showMessage("System User Press *");
                    //userInterface.GetNum(dwParam1);
                    /*if (dwParam1 == 49)
                    {
                        audio.audio.FreeMemory();
                        str = "welcome2.wav";
                        audio.audio.LoadFile(ref str);
                        audio.audio.Play(short.Parse(Answering_machine_Sys1.Form1.LineID.ToString()));
                        
                        //Process.Start("WaveOutOpen_1.exe");
                        //Answering_machine_Sys1.Form1.playWave2("welcome.wav");
                        //userInterface.showMessage("play");
                        //Answering_machine_Sys1.Form1.playWave2("thank_you.wav");
                        
                    }
                    if (dwParam1 == 50)
                    {
                       
                        //userInterface.showMessage("play");
                        Answering_machine_Sys1.Form1.playWave2("thank_you.wav");

                    }
                    if (dwParam1 == 51)
                    {   
                        //userInterface.showMessage("play");
                        Answering_machine_Sys1.Form1.playWave2("thank_you.wav");

                    }
                    if (dwParam1 == 52)
                    {
                        //audio.audio.FreeMemory();
                        //userInterface.showMessage("play");
                        //Answering_machine_Sys1.Form1.playWave2("thank_you.wav");

                    }*/
                    break;
                case LINE_CALLSTATE:
                    switch (dwParam1)
                    {
                        case LINECALLSTATE_OFFERING:
                            msgEvent = "Incomming call";
                            hCall = dwDevice;
                            break;
                        case LINECALLSTATE_CONNECTED:
                            msgEvent = "Call connected";
                            str = "welcome.wav";
                            Answering_machine_Sys1.Form1.playWave2(str);    
                        //audio.audio.LoadFile(ref str);
                            //audio.audio.Play(short.Parse( Answering_machine_Sys1.Form1.LineID.ToString()));
                            
                            //Thread.Sleep(14000);
                           // str = "Wait.wav";
                            //audio.audio.LoadFile(ref str);
                            //audio.audio.Play(short.Parse(Answering_machine_Sys1.Form1.LineID.ToString()));
                            //Answering_machine_Sys1.Form1.playWave2("welcome.wav");
                            //Thread.Sleep(14000);
                            //Answering_machine_Sys1.Form1.playWave2("thank_you.wav");
                            //Thread.Sleep(2000);
                            //Answering_machine_Sys1.Form1.playWave2("thank_you.wav");
                            break;
                        case LINECALLSTATE_ACCEPTED:
                            msgEvent = "Call accepted";
                            //userInterface.playWave2("welcome.wav");
                            break;

                        case LINECALLSTATE_DISCONNECTED:
                            msgEvent = "Call disconnected";
                            userInterface.DropCall();
                            break;
                    }
                    break;
                case LINE_LINEDEVSTATE:
                    switch (dwParam1)
                    {
                        case LINEDEVSTATE_RINGING:
                        //How many rings we answer on, dwParam3 contain Number of rings now.
                            msgEvent = "Ringing";
                            if(dwParam3>TAPI.RingsCount)
                                userInterface.acceptCall();
                        break;
                    }
                    break;
            }
            userInterface.showMessage("Event Occured: " + msgEvent + " Data:"
            + dwParam1 );
            return 1;
        }

        public static string GetLineID(string sWave)
        {
            long nError = 0;
            string sTemp = "-1", dwstringsize, dwstringoffset;
            int dwintsize, dwintoffset;
            TAPI.varString oVar = new TAPI.varString();
            oVar.dwTotalSize = Marshal.SizeOf(oVar);
            
            int rawsize = Marshal.SizeOf(oVar);
            byte[] rawdata = new byte[rawsize];
            IntPtr src = IntPtr.Zero;
            GCHandle handle = GCHandle.Alloc(rawdata, GCHandleType.Pinned);
            Marshal.StructureToPtr(oVar, src = handle.AddrOfPinnedObject(),
                false);
            handle.Free();
            
            nError = lineGetID(hLine, 0, hCall,
            LINECALLSELECT_CALL, src, sWave);
            if (nError != 0) return "-1";
            
            dwstringsize=rawdata[19].ToString()+rawdata[18].ToString()
                +rawdata[17].ToString()+rawdata[16].ToString();
            dwintsize = int.Parse(dwstringsize);
            if (dwintsize == 0) return "-1";
            dwstringoffset = rawdata[23].ToString() + rawdata[22].ToString() 
                + rawdata[21].ToString() + rawdata[20].ToString();
            dwintoffset = int.Parse(dwstringoffset);
            for (int i = dwintoffset + dwintsize - 1; i >= dwintoffset; i--)
            {
                sTemp += (rawdata[i]).ToString();
            }
            sTemp = sTemp.Trim();
            int id = int.Parse(sTemp);
            return id.ToString();
        }
            //userInterface.showMessage("stemp:="+sTemp2);
            //userInterface.showMessage("id:=" + id.ToString());
            //userInterface.showMessage("oVar.dwStringOffset =" + rawdata[20].ToString());
            //userInterface.showMessage("oVar.dwStringOffset =" + rawdata[21].ToString());
            //userInterface.showMessage("oVar.dwStringOffset =" + rawdata[22].ToString());
            //userInterface.showMessage("oVar.dwStringOffset =" + rawdata[23].ToString());
            //userInterface.showMessage("oVar.dwStringSize =" + rawdata[16].ToString());
            //userInterface.showMessage("oVar.dwStringSize =" + rawdata[17].ToString());
            //userInterface.showMessage("oVar.dwStringSize =" + rawdata[18].ToString());
            //userInterface.showMessage("oVar.dwStringSize =" + rawdata[19].ToString());

            //userInterface.showMessage("oVar.lineID =" + rawdata[24].ToString());
            //userInterface.showMessage("oVar.lineID =" + rawdata[25].ToString());
            //userInterface.showMessage("oVar.lineID =" + rawdata[26].ToString());
            //userInterface.showMessage("oVar.lineID =" + rawdata[27].ToString());
            //if (oVar.dwStringOffset == 0)
            //{
                //userInterface.showMessage("oVar.dwStringOffset =" + rawdata[ oVar.dwStringSize.ToString());
              //  return "-1";
            //}
            //sTemp = rawdata[24].ToString();
            //byte[] byt =Form1.RawSerialize(oVar);
            //sTemp = rawdata[oVar.dwStringOffset].ToString();
            //userInterface.showMessage("line id="+ sTemp);
            //for (int i = 27; i >=24; i--)
            //{
           //     sTemp2 += (rawdata[i]).ToString();
                //userInterface.showMessage( rawdata[i].ToString());//(char)
            //}
            
        //}
    }
}
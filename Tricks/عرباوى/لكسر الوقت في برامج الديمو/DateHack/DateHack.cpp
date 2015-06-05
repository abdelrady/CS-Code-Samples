// ********************************************************
// **** Hack the date and time-out period for programs ****
// **** Written by Steven De Toni 1997-99              ****
// ********************************************************

#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <commctrl.h>
#include <objbase.h>
#include <shlobj.h>

#include "resource.h"

char* pCmdInfo = "*** Program Written By Steven De Toni 99 ***\r\n\r\n"
                 "Cmd Line options:\r\n"
                  "-h display this help\r\n"
                  "-p <program name to execute>\r\n"
                  "-t <delay time in seconds for old system time for before its change back to current time>\r\n"
                  "-d <date in day:month:year e.g. 7:2:1997\r\n"
                  "-n no beep when completed\r\n"
                  "    additonal program parameters\r\n\r\n"
                  "example:\r\n"
                  "datehack -p afile.exe -t 10 -d 1:1:1980 parm1 parm2 parm3 ...";

HANDLE HInst;

// The date structure for date changing
struct 
{
    int         day, month, year;
    int         cDay, cMonth, cYear;
    SYSTEMTIME  currentDateInTime;
    char*       pProgramToRun;
    int         threadDelayTime;
    BOOL        beep;
} ProgInfo;

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

// Build the command line parameter
void UpdateCmdLineShower (HWND hWnd, BOOL MakeShortCut)
{
    const int maxBuff     = MAX_PATH;
    char cmdBuff[maxBuff] = {'\0'};
    char tmpBuff[maxBuff];

    // Get the current directory and program name and determine 
    // if there are spaces in it, if then add quotes around the
    // program string.
    if (MakeShortCut == FALSE)
    {
        if (strstr (__argv[0], " ") != NULL)
        {
            // Add the quotes to the string
            cmdBuff[0] = '"';
            strcpy (cmdBuff+1, __argv[0]);
            strcat (cmdBuff, "\" ");        
        }
        else
        {
            strcpy (cmdBuff, __argv[0]);
            strcat (cmdBuff, " ");      
        }
    }

    // Do the same as above, but for the program parameter
    if (GetWindowTextLength (GetDlgItem(hWnd, IDC_PROGRAM)) > 0)
    {
        strcat (cmdBuff, "-p ");
        tmpBuff[0] = '\0';
        GetWindowText (GetDlgItem(hWnd, IDC_PROGRAM), tmpBuff, maxBuff);

        if (strstr (tmpBuff, " ") != NULL)
        {
            // Add the quotes to the string,
            strcat (cmdBuff, "\"");
            strcat (cmdBuff, tmpBuff);
            strcat (cmdBuff, "\" ");            
        }
        else
        {
            strcat (cmdBuff, tmpBuff);
            strcat (cmdBuff, " ");  
        }        
    }

    // Do the time delay
    BOOL success   = FALSE;
    int  timeDelay = (int) GetDlgItemInt(hWnd, IDC_TIMEDELAYEDIT, &success, FALSE);

    if (success != FALSE)            
        sprintf (cmdBuff+strlen(cmdBuff), "-t %d ", timeDelay);    

    // Do the revert date 
    int day, month;
    
    day   = (int) (SendDlgItemMessage (hWnd, IDC_DAYSEL,   CB_GETCURSEL, 0, 0)+1);
    month = (int) (SendDlgItemMessage (hWnd, IDC_MONTHSEL, CB_GETCURSEL, 0, 0)+1);
    SendDlgItemMessage (hWnd, 
                        IDC_YEARSEL, 
                        CB_GETLBTEXT,
                        (WPARAM) SendDlgItemMessage (hWnd, IDC_YEARSEL,  CB_GETCURSEL, 0, 0),
                        (LPARAM) (LPCSTR) tmpBuff);            

    sprintf (cmdBuff+strlen(cmdBuff), "-d %d:%d:%s ", day, month, tmpBuff);

    // Determine if we are going to beep after program completion
    if (IsDlgButtonChecked(hWnd, IDC_BEEPCHK) == BST_CHECKED)	    
        strcat (cmdBuff, "-n ");
    
    // Add any parameters that are left onto the cmd string    
    if (GetWindowTextLength (GetDlgItem(hWnd, IDC_PROGPARAMS)) > 0)
    {
        GetWindowText (GetDlgItem(hWnd, IDC_PROGPARAMS), 
                       cmdBuff+strlen(cmdBuff), 
                       maxBuff-strlen(cmdBuff));
    }
    
    SetWindowText (GetDlgItem(hWnd, IDC_PARAM_CONSTRUCT), cmdBuff);
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

int SelectProgram (HWND hEdit, HWND hParent)
{
    const int       maxFile       = MAX_PATH;
    const char*     pFileTypes    = "Executables\0*.exe;*.com\0"
                                    "Batch Files\0*.bat;*.cmd\0"
                                    "All Files\0*.*\0\0"; 
    char            Errstr[256]   = "GetOpenFileName returned Error #";
	OPENFILENAME    fileSelect;
	DWORD           Errval;         // Error value
	char            buf[5];         // Error buffer
    char            pFileName[maxFile];

    // Reset return pointers variables to null.
    pFileName[0]    = '\0';
    memset (&fileSelect, 0, sizeof (fileSelect));

    fileSelect.hwndOwner         = hParent;
	fileSelect.lStructSize       = sizeof(OPENFILENAME);
    fileSelect.lpstrFilter       = (LPSTR)pFileTypes;  
	fileSelect.lpstrCustomFilter = NULL;
	fileSelect.nFilterIndex      = 1;
	fileSelect.lpstrFile         = (LPSTR)pFileName;  
	fileSelect.nMaxFile          = maxFile;
	fileSelect.lpstrFileTitle    = "";           
	fileSelect.nMaxFileTitle     = 0;
	fileSelect.lpstrInitialDir   = ".\\";            
	fileSelect.lpstrTitle        = "Select Executable File";
	fileSelect.Flags             = OFN_FILEMUSTEXIST | OFN_PATHMUSTEXIST | OFN_NOCHANGEDIR;
	fileSelect.lpstrDefExt       = "*.exe";

	if(GetOpenFileName(&fileSelect) != TRUE)
	{
		Errval = CommDlgExtendedError();

		if(Errval != 0)	// 0 value means user selected Cancel
		{
			sprintf(buf,"%ld",Errval);
			strcat(Errstr,buf);
			MessageBox(NULL,Errstr,"- WARNING - Something Weird Ocurred!", MB_OK | MB_ICONSTOP);
            return -1;
		}

        return 0;        
	}

    // ---- If all was o.k, then store in edit control ----
    SetWindowText(hEdit, pFileName);            
    
    return 0;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

// CreateLink - uses the shell's IShellLink and IPersistFile interfaces 
//   to create and store a shortcut to the specified object. 
// Returns the result of calling the member functions of the interfaces. 
// lpszPathObj    - address of a buffer containing the path of the object 
// lpszWorkingDir - address of a buffer containing the working directory
// lpszParameters - address of a buffer containing the programs parameters
// lpszPathLink   - address of a buffer containing the path where the  shell link is to be stored 
// lpszDesc       - address of a buffer containing the description of the shell link 
HRESULT CreateLink(LPCSTR lpszPathObj, LPSTR lpszWorkingDir, LPSTR lpszParameters, 
                   LPSTR lpszPathLink, LPSTR lpszDesc) 
{ 
    HRESULT     hres; 
    IShellLink* psl; 
 
    CoInitialize (NULL);
    // Get a pointer to the IShellLink interface. 
    hres = CoCreateInstance(CLSID_ShellLink, NULL, CLSCTX_INPROC_SERVER, IID_IShellLink, (LPVOID*) &psl); 

    if (SUCCEEDED(hres)) 
    { 
        IPersistFile* ppf; 
 
        // Set the path to the shortcut target, and add the 
        // description. 
        psl->SetPath             (lpszPathObj); 
        psl->SetWorkingDirectory (lpszWorkingDir);
        psl->SetArguments        (lpszParameters);
        psl->SetDescription      (lpszDesc); 
        psl->SetIconLocation     (lpszPathObj, 0);
 
       // Query IShellLink for the IPersistFile interface for saving the 
       // shortcut in persistent storage. 
        hres = psl->QueryInterface (IID_IPersistFile, (LPVOID*)&ppf); 
 
        if (SUCCEEDED(hres)) 
        { 
            WORD wsz[MAX_PATH]; 
 
            // Ensure that the string is ANSI. 
            MultiByteToWideChar (CP_ACP, 0, lpszPathLink, -1, wsz, MAX_PATH); 
 
            // Save the link by calling IPersistFile::Save. 
            hres = ppf->Save (wsz, TRUE);                    
            ppf->Release (); 
        } 
        psl->Release (); 
    } 

    CoUninitialize ();
    return hres; 
} 
 
// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

int MakeDesktopShortCut (HWND hWnd, char* pSCFilename)
{ 
    const int maxFile     = MAX_PATH;
    char workDir[maxFile] = {'\0'};    
    char params[maxFile]  = {'\0'};
    char desktopFilename[maxFile];    

    // Get the parameters 
    if (GetWindowText (GetDlgItem(hWnd, IDC_PARAM_CONSTRUCT), params, MAX_PATH) == 0)
    {
        MessageBox (hWnd, "Unable to obtain parameters.\nParameters exceed memory allocation",
                    "Mem Error", MB_ICONSTOP | MB_OK);
        return -1;
    }
    // Determine where abouts the desktop directory is for this user.
    unsigned long type = REG_SZ;    
    HKEY hShellInfo    = NULL;
    LONG regResult     = RegOpenKey (HKEY_CURRENT_USER, (LPCTSTR)"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", &hShellInfo);
    
    if (regResult != 0)
    {
        MessageBox (hWnd, "Unable to query windows registery.",
                    "Windows Registery Error", MB_ICONSTOP | MB_OK);
        return -1;
    }

    regResult = RegQueryValueEx(hShellInfo, 
                             (LPTSTR)"Desktop", 
                             NULL, 
                             &type, 
                             (LPBYTE)desktopFilename, 
                             (LPDWORD) &maxFile);
 
    if (regResult != 0)
    {
        MessageBox (hWnd, "Unable to query windows registery.",
                    "Windows Registery Error", MB_ICONSTOP | MB_OK);
        return -1;
    }

    RegCloseKey(hShellInfo); 
    
    // Build desktop short cut file name
    strcat (desktopFilename, "\\");
    strcat (desktopFilename, pSCFilename);
    strcat (desktopFilename, ".lnk");

    // Determine the working directory of the users program
    GetWindowText (GetDlgItem(hWnd, IDC_PROGRAM), workDir, MAX_PATH);
    char* pWork = workDir + strlen(workDir);
    
    while (pWork > workDir)
    {
        if (*pWork == '\\')
        {
            *pWork = '\0';
            break;
        }
        pWork--;
    }

    if ((CreateLink(__argv[0], workDir, params, desktopFilename, "Date Hack Short Cut")) != 0)
    {
        MessageBox (hWnd, "Unable to create short cut on your desktop.",
                    "Windows Short Cut Shell Error", MB_ICONSTOP | MB_OK);
        return -1;
    }

    return 0;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

BOOL CALLBACK ShortCutDetails (HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{        
    static char* pParamBuff = NULL;

    switch (message)
    {        
        case WM_INITDIALOG:
                if (lParam != NULL)
                {
                    pParamBuff = (char*) lParam;
                    SetWindowText (GetDlgItem(hWnd, IDC_SHORTCUTFILENAME), pParamBuff);
                }
                else
                {
                    MessageBox (hWnd, "Internal Error, Unable To Continue", "Error", MB_ICONSTOP | MB_OK);
                    EndDialog (hWnd, FALSE);                       
                }
            return TRUE;

        case WM_COMMAND:
            switch (LOWORD (wParam))
            {
                case IDC_CANCEL:
                    EndDialog (hWnd, FALSE);
                    return TRUE;

                case IDC_OK:
                    if (pParamBuff != NULL)
                    {
                        GetWindowText (GetDlgItem(hWnd, IDC_SHORTCUTFILENAME), pParamBuff, MAX_PATH);
                        pParamBuff = NULL;
                        EndDialog (hWnd, TRUE);
                    }
                    return TRUE;
            }
            break;

        case WM_CLOSE:
            EndDialog (hWnd, FALSE);
            return TRUE;
    }

    return FALSE;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

BOOL CALLBACK Config (HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{        
    switch (message)
    {        
        case WM_INITDIALOG:
            {
                char* months[] = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", 
                                  "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
                char       tmpBuff[64];
                SYSTEMTIME tmpDate;

                GetSystemTime (&tmpDate);

                // Init controls
                SendDlgItemMessage (hWnd, IDC_TIMEDELAYSEL, TBM_SETRANGE, TRUE, (LPARAM) MAKELONG(1, 20));
                SetWindowText(GetDlgItem(hWnd, IDC_TIMEDELAYEDIT), "1");            

                // Build Date Strings
                for (int day = 1; day < 32; day++)
                {
                    sprintf (tmpBuff, "%d", day);
                    SendDlgItemMessage (hWnd, IDC_DAYSEL, CB_ADDSTRING, 0, (LPARAM) (LPCTSTR) tmpBuff);   
                }
                // Set the current day
                SendDlgItemMessage (hWnd, IDC_DAYSEL, CB_SETCURSEL, tmpDate.wDay-1, 0);

                // Build Month Strings                
                for (int month = 1; month <= 12; month++)
                {
                    sprintf (tmpBuff, "%d %s", month, months[month-1]);
                    SendDlgItemMessage (hWnd, IDC_MONTHSEL, CB_ADDSTRING, 0, (LPARAM) (LPCTSTR) tmpBuff);   
                }
                // Set the current month
                SendDlgItemMessage (hWnd, IDC_MONTHSEL, CB_SETCURSEL, tmpDate.wMonth-1, 0);

                // Build Year Strings                
                for (int year = tmpDate.wYear-10; year < tmpDate.wYear+100; year++)
                {
                    sprintf (tmpBuff, "%d", year);
                    SendDlgItemMessage (hWnd, IDC_YEARSEL, CB_ADDSTRING, 0, (LPARAM) (LPCTSTR) tmpBuff);   
                }
                // Set the current year
                SendDlgItemMessage (hWnd, IDC_YEARSEL, CB_SETCURSEL, 10, 0);

                DragAcceptFiles(hWnd , TRUE);  // initalise drag and drop
                UpdateCmdLineShower (hWnd, FALSE);
            }
            return TRUE;

        case WM_DROPFILES:
            {
                char* pFileName = NULL;    
                int   fileLen   = 1024;
	            int   dropNum   = DragQueryFile((HDROP) wParam, (UINT)-1, NULL, 0);

                for (int idx = 0; idx < dropNum; idx++)
                {
                    fileLen = DragQueryFile((HDROP) wParam, idx, NULL, 0 );
                    if ((pFileName = new char[fileLen+1]) == NULL)
                        break;

                    //copy of the file name 
	                DragQueryFile((HDROP) wParam, idx, pFileName, fileLen+1 ); 
        
                    SetWindowText(GetDlgItem(hWnd, IDC_PROGRAM), pFileName);

                    // Clean up and make ready for any additional files.
                    if (pFileName != NULL)
                    {
	                    delete[] pFileName;
                        pFileName = NULL;
                    }
                }

	            DragFinish((HDROP) wParam);
            }            
            return TRUE;

        // Process user control message information.
        case WM_COMMAND:    
            switch (LOWORD (wParam))
            {
                // Auto update controls
                case IDC_PROGRAM:
                case IDC_PROGPARAMS:
                case IDC_BEEPCHK:                                    
                case IDC_TIMEDELAYEDIT:
                case IDC_DAYSEL:
                case IDC_MONTHSEL:
                case IDC_YEARSEL:
                    UpdateCmdLineShower (hWnd, FALSE);
                    return TRUE;

                // Buttons
                case IDC_PROGRAMSEL:
                    SelectProgram       (GetDlgItem(hWnd, IDC_PROGRAM), hWnd);
                    UpdateCmdLineShower (hWnd, FALSE);
                    return TRUE;

                case IDC_MAKE_SC:
                    // Determine if we have valid parameters
                    if (GetWindowTextLength (GetDlgItem(hWnd, IDC_PROGRAM)) <= 0)
                    {
                        MessageBox (hWnd, "Enter A Program For Date Hack To Execute.",
                                    "Missing Program Parameter",  MB_ICONINFORMATION | MB_OK);
                        return TRUE;
                    }

                    {
                        char  shortcutFilename[MAX_PATH];
                        char  programName[MAX_PATH] = "";                        
                        char* pFndProgName;
                        BOOL  result;
                        
                        // Construct a default file name
                        GetWindowText (GetDlgItem(hWnd, IDC_PROGRAM), programName, MAX_PATH);
                        strcpy (shortcutFilename, "Date Hack ");

                        pFndProgName = programName + (strlen(programName)-1);
                        while ((*pFndProgName != '\\') && (pFndProgName > programName))
                                pFndProgName--;

                        strcat (shortcutFilename, pFndProgName+1);

                        // Remove program extensions
                        for (int idx = 0; shortcutFilename[idx] != '\0'; idx++)
                        {
                            if (shortcutFilename[idx] == '.')
                            {
                                shortcutFilename[idx] = '\0';
                                break;
                            }
                        }
                        
                        result = (BOOL) DialogBoxParam (HInst, MAKEINTRESOURCE(IDD_SHORTCUTNAME),
                                                        hWnd,  (DLGPROC) ShortCutDetails, 
                                                        (LPARAM) shortcutFilename);
                        if (result == FALSE)
                            return TRUE;

                        // Remove any program extensions again
                        for (idx = 0; shortcutFilename[idx] != '\0'; idx++)
                        {
                            if (shortcutFilename[idx] == '.')
                            {
                                shortcutFilename[idx] = '\0';
                                break;
                            }
                        }

                        UpdateCmdLineShower (hWnd, TRUE);
                        MakeDesktopShortCut (hWnd, shortcutFilename);
                        UpdateCmdLineShower (hWnd, FALSE);
                    }
                    return TRUE;

                case IDC_COPYTOCLIPBOARD:
                    // Select all the text in the cmd line edit control and 
                    // issue a copy command.
                    SendDlgItemMessage (hWnd, IDC_PARAM_CONSTRUCT, EM_SETSEL, 0, -1);
                    SendMessage (GetDlgItem(hWnd, IDC_PARAM_CONSTRUCT), WM_COPY, 0, 0);
                    SendDlgItemMessage (hWnd, IDC_PARAM_CONSTRUCT, EM_SETSEL, 0, 0);
                    return TRUE;

                case IDC_ABOUT:
                    MessageBox (NULL, pCmdInfo, "About", MB_ICONINFORMATION | MB_OK);                    
                    return TRUE;

                case IDC_QUIT:
                    EndDialog (hWnd, FALSE);
                    return TRUE;
            }
            break;

        case WM_HSCROLL:
            switch (LOWORD (wParam))
            {
                case TB_THUMBTRACK:
                case TB_ENDTRACK: 
                    if (GetDlgItem(hWnd, IDC_TIMEDELAYSEL) == (HWND)lParam)
                    {
                        char buff[16];
                       
                        sprintf (buff, "%d", (int)SendMessage ((HWND)lParam, TBM_GETPOS, 0,0));
                        SetWindowText(GetDlgItem(hWnd, IDC_TIMEDELAYEDIT), buff);

                        UpdateCmdLineShower (hWnd, FALSE);
                    }
                    return TRUE;
            }
            break;

 
        case WM_CLOSE:
            EndDialog (hWnd, FALSE);
            return TRUE;

        case WM_DESTROY:
            DragAcceptFiles(hWnd , FALSE); 
            return TRUE;
    }
              
    return FALSE;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

void InitProgramInfo ()
{
    ProgInfo.pProgramToRun   = "";
    ProgInfo.threadDelayTime = 5;
    ProgInfo.beep            = TRUE;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

// returns number of argurments in cmd line
int MakeCmdArray (char** pArray, int arrLimit, char* pCmdLine)
{
    int   arrayIdx   = 0;
    char* pCurChar   = pCmdLine;
    BOOL  strParam   = FALSE;

    pArray[arrayIdx] = pCurChar;
    while ((*pCurChar != '\0') && (arrayIdx < arrLimit))
    {
        // Process string parameters like "c:\program files" as 1 parameter
        if ((*pCurChar == '"') && (strParam == FALSE))
            strParam = TRUE;
        else if ((*pCurChar == '"') && (strParam == TRUE))
            strParam = FALSE;
        if ((*pCurChar == ' ') && (strParam == FALSE))
        {
            *pCurChar = '\0';
            arrayIdx++;
            pArray[arrayIdx] = pCurChar+1;
        }
        pCurChar++;
    }

    // return true number of items...
    if (pCurChar != pCmdLine)
        arrayIdx++;

    return arrayIdx;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

int LoadParameters (char** argv, int argc, char* progParams)
{
    int idx = 0;

    if (argc <= 0)
    {
        DialogBox (HInst, MAKEINTRESOURCE (IDD_CONFIG), NULL, (DLGPROC) Config);                       
        return -1;
    }

    InitProgramInfo ();    

    while (idx < argc)
    {
        if (argv[idx][0] != '-')
        {
            // Load program parameters...
            if (strlen (progParams) > 0)
                strcat (progParams, " ");

            strcat (progParams, argv[idx]);
        }
        else
        {
            switch (argv[idx][1])
            {
                case 'h':
                case 'H':
                    MessageBox (NULL, pCmdInfo, "About", MB_ICONINFORMATION | MB_OK);                                        
                    return -1;                     

                case 'n':
                case 'N':
                    ProgInfo.beep = FALSE;
                    break;

                case 'p':
                case 'P':
                    idx++;
                    if (idx >= argc)
                    {
                        MessageBox (NULL, pCmdInfo, "Date Hack, Expected Program Filename 4 -p", MB_ICONINFORMATION | MB_OK);
                        return -1;
                    }
                    // Determine if parameter has surrounded by quotes, if so then 
                    // remove them
                    if (strlen(argv[idx]) > 1)
                    {
                        if ((argv[idx][0] == '"') && (argv[idx][strlen(argv[idx])-1] == '"'))
                        {
                            strcpy (argv[idx], argv[idx]+1);
                            argv[idx][strlen(argv[idx])-1] = '\0';
                        }
                    }

                    ProgInfo.pProgramToRun = argv[idx];                    
                    break;

                case 't':
                case 'T':
                    idx++;
                    if (idx >= argc)
                    {
                        MessageBox (NULL, pCmdInfo, "Date Hack, Expected Time numeric for -t", MB_ICONINFORMATION | MB_OK);
                        return -1;
                    }
                    sscanf (argv[idx], "%d", &ProgInfo.threadDelayTime);
                    ProgInfo.threadDelayTime = abs(ProgInfo.threadDelayTime);
                    break;

                case 'd':
                case 'D':
                    idx++;
                    if (idx >= argc)
                    {
                        MessageBox (NULL, pCmdInfo, "Date Hack, Expected date string for -d", MB_ICONINFORMATION | MB_OK);
                        return -1;
                    }

                    sscanf(argv[idx],"%d:%d:%d", &ProgInfo.day, &ProgInfo.month, &ProgInfo.year);    
                    break;

            }
        }
        idx++;
    }

    if (strcmp (ProgInfo.pProgramToRun, "") == 0)
    {
        DialogBox (HInst, MAKEINTRESOURCE (IDD_CONFIG), NULL, (DLGPROC) Config);                       
        return -1;
    }

    if ((ProgInfo.year <= 0) || (ProgInfo.month <= 0) || (ProgInfo.day <= 0))
    {        
        MessageBox (NULL, pCmdInfo, "Date Hack, Bad date format", MB_ICONINFORMATION | MB_OK);
        return -1;
    }

    if (ProgInfo.threadDelayTime <= 0)
    {
        MessageBox (NULL, pCmdInfo, "Date Hack, Time delay must be >= 0", MB_ICONINFORMATION | MB_OK);
        return -1;
    }

    return 0;
}

// ------------------------------------------------------------------------------
// ------------------------------------------------------------------------------

int PASCAL WinMain (HANDLE hInstance, HANDLE hPrevInstance, LPSTR lpszCmdParam, int nCmdShow)
{    
    const  int cmdLimit = MAX_PATH;
    char*  pStrArray [cmdLimit];
    char   curDir    [cmdLimit*4];
    char   progParams[cmdLimit];
    int    cmdNum;

    HInst         = hInstance;
    progParams[0] = '\0';    
    cmdNum        = MakeCmdArray (pStrArray, cmdLimit, lpszCmdParam);

    if (LoadParameters (pStrArray, cmdNum, progParams) != 0)
        return -1;

    // ***** The actual code that does the work ! *****
    GetSystemTime (&ProgInfo.currentDateInTime);

    // back up the current day.
    ProgInfo.cYear  = ProgInfo.currentDateInTime.wYear;
    ProgInfo.cMonth = ProgInfo.currentDateInTime.wMonth;
    ProgInfo.cDay   = ProgInfo.currentDateInTime.wDay;

    // load in old/new date.
    ProgInfo.currentDateInTime.wYear  = (WORD) ProgInfo.year;
    ProgInfo.currentDateInTime.wMonth = (WORD) ProgInfo.month;
    ProgInfo.currentDateInTime.wDay   = (WORD) ProgInfo.day;

    // This may fail under NT because of security rights 
    if (SetSystemTime (&ProgInfo.currentDateInTime) == FALSE)
    {
        MessageBox (NULL, "Couldn't change system Date!\r\nDate is either incorrect or you don't have access to change the system date.\r\nProgram Terminated.", "Access Violation",MB_ICONSTOP | MB_ICONINFORMATION);
        return -1;
    }

    // run the program 
    GetCurrentDirectory (cmdLimit*4, curDir);
    
    ShellExecute (GetDesktopWindow(), 
                  (LPCTSTR)"open", 
                  (LPCTSTR)ProgInfo.pProgramToRun,
                  (LPCTSTR)progParams,
                  (LPCTSTR)curDir, 
                  SW_SHOWDEFAULT);

    // ---- Wait some time ----
    Sleep (ProgInfo.threadDelayTime * 1000);

    // ---- and clean up ----
    GetSystemTime (&ProgInfo.currentDateInTime);

    // load in old/new date.
    ProgInfo.currentDateInTime.wYear  = (WORD) ProgInfo.cYear;
    ProgInfo.currentDateInTime.wMonth = (WORD) ProgInfo.cMonth;
    ProgInfo.currentDateInTime.wDay   = (WORD) ProgInfo.cDay;

    SetSystemTime (&ProgInfo.currentDateInTime);

    if (ProgInfo.beep != FALSE)
        MessageBeep ((UINT)-1);

    return 0;
}
Attribute VB_Name = "modCommonDialog"
Option Explicit

Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Long) As Long
Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hWnd As Long, ByVal nIndex As Long) As Long
Private Declare Function GetCurrentThreadId Lib "kernel32" () As Long
Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Long, ByVal lpfn As Long, ByVal hmod As Long, ByVal dwThreadId As Long) As Long
Private Declare Function GetWindowRect Lib "user32" (ByVal hWnd As Long, lpRect As RECT) As Long

Private Const GWL_HINSTANCE = (-6)
Private Const SWP_NOSIZE = &H1
Private Const SWP_NOZORDER = &H4
Private Const SWP_NOACTIVATE = &H10
Private Const HCBT_ACTIVATE = 5
Private Const WH_CBT = 5

Private hHook As Long

Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (pOpenfilename As OPENFILENAME) As Long
Private Declare Function GetSaveFileName Lib "comdlg32.dll" Alias "GetSaveFileNameA" (pOpenfilename As OPENFILENAME) As Long
Private Declare Function ChooseColor Lib "comdlg32.dll" Alias "ChooseColorA" (pChoosecolor As CHOOSECOLORS) As Long
Private Declare Function CommDlgExtendedError Lib "comdlg32.dll" () As Long
Private Declare Function GetShortPathName Lib "kernel32" Alias "GetShortPathNameA" (ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal cchBuffer As Long) As Long
Private Declare Function ChooseFont Lib "comdlg32.dll" Alias "ChooseFontA" (pChoosefont As CHOOSEFONTS) As Long
Private Declare Function PrintDlg Lib "comdlg32.dll" Alias "PrintDlgA" (pPrintdlg As PRINTDLGS) As Long
Private Declare Function GetParent Lib "user32" (ByVal hWnd As Long) As Long
Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
Private Declare Function GetDlgItem Lib "user32" (ByVal hDlg As Long, ByVal nIDDlgItem As Long) As Long

Private Declare Function GetDC Lib "user32" (ByVal hWnd As Long) As Long
Private Declare Function ReleaseDC Lib "user32" (ByVal hWnd As Long, ByVal hDc As Long) As Long

Private Const OFN_SHAREWARN = 0
Private Const OFN_SHARENOWARN = 1
Private Const OFN_SHAREFALLTHROUGH = 2
Private Const LF_FACESIZE = 32
Private Const OFS_MAXPATHNAME = 256
Private Const OFN_READONLY = &H1
Private Const OFN_OVERWRITEPROMPT = &H2
Private Const OFN_HIDEREADONLY = &H4
Private Const OFN_NOCHANGEDIR = &H8
Private Const OFN_SHOWHELP = &H10
Private Const OFN_ENABLEHOOK = &H20
Private Const OFN_ENABLETEMPLATE = &H40
Private Const OFN_ENABLETEMPLATEHANDLE = &H80
Private Const OFN_NOVALIDATE = &H100
Private Const OFN_ALLOWMULTISELECT = &H200
Private Const OFN_EXTENSIONDIFFERENT = &H400
Private Const OFN_PATHMUSTEXIST = &H800
Private Const OFN_FILEMUSTEXIST = &H1000
Private Const OFN_CREATEPROMPT = &H2000
Private Const OFN_SHAREAWARE = &H4000
Private Const OFN_NOREADONLYRETURN = &H8000
Private Const OFN_NOTESTFILECREATE = &H10000
Private Const OFN_NONETWORKBUTTON = &H20000
Private Const OFN_EXPLORER = &H80000
Private Const OFN_NOLONGNAMES = &H40000
Private Const OFN_NODEREFERENCELINKS = &H100000
Private Const OFN_LONGNAMES = &H200000


Public Const OFS_FILE_OPEN_FLAGS_MULTISELECT = OFN_EXPLORER + OFN_LONGNAMES + OFN_PATHMUSTEXIST + OFN_FILEMUSTEXIST + OFN_NODEREFERENCELINKS + OFN_HIDEREADONLY + OFN_ALLOWMULTISELECT
Public Const OFS_FILE_OPEN_FLAGS = OFN_EXPLORER + OFN_LONGNAMES + OFN_PATHMUSTEXIST + OFN_FILEMUSTEXIST + OFN_NODEREFERENCELINKS + OFN_HIDEREADONLY
Public Const OFS_FILE_SAVE_FLAGS = OFN_EXPLORER + OFN_LONGNAMES + OFN_PATHMUSTEXIST + OFN_OVERWRITEPROMPT + OFN_HIDEREADONLY + OFN_EXTENSIONDIFFERENT
Public Const OFS_FILE_SAVE_FLAGS_NO_PROMPT = OFN_EXPLORER + OFN_LONGNAMES + OFN_PATHMUSTEXIST + OFN_HIDEREADONLY
Public Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (lpvDest As Any, lpvSource As Any, ByVal cbCopy As Long)
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long

Private Type OPENFILENAME
    nStructSize As Long
    hwndOwner As Long
    hInstance As Long
    sFilter As String
    sCustomFilter As String
    nCustFilterSize As Long
    nFilterIndex As Long
    sFile As String
    nFileSize As Long
    sFileTitle As String
    nTitleSize As Long
    sInitDir As String
    sDlgTitle As String
    Flags As Long
    nFileOffset As Integer
    nFileExt As Integer
    sDefFileExt As String
    nCustDataSize As Long
    fnHook As Long
    sTemplateName As String
End Type

Public Enum enmPlatForm
    VER_PLATFORM_WIN32s = 0
    VER_PLATFORM_WIN32_WINDOWS = 1
    VER_PLATFORM_WIN32_NT = 2
End Enum

Private Type NMHDR
    hwndFrom As Long
    idfrom As Long
    code As Long
End Type

Private Type OFNOTIFY
        hdr As NMHDR
        lpOFN As OPENFILENAME
        pszFile As String        '  May be NULL
End Type

Private Type CHOOSECOLORS
    lStructSize As Long
    hwndOwner As Long
    hInstance As Long
    rgbResult As Long
    lpCustColors As String
    Flags As Long
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type

Private Type LOGFONT
    lfHeight As Long
    lfWidth As Long
    lfEscapement As Long
    lfOrientation As Long
    lfWeight As Long
    lfItalic As Byte
    lfUnderline As Byte
    lfStrikeOut As Byte
    lfCharSet As Byte
    lfOutPrecision As Byte
    lfClipPrecision As Byte
    lfQuality As Byte
    lfPitchAndFamily As Byte
    lfFaceName(LF_FACESIZE) As Byte
End Type

Private Type CHOOSEFONTS
    lStructSize As Long
    hwndOwner As Long          '  caller's window handle
    hDc As Long                '  printer DC/IC or NULL
    lpLogFont As Long          '  ptr. to a LOGFONT struct
    iPointSize As Long         '  10 * size in points of selected font
    Flags As Long              '  enum. type flags
    rgbColors As Long          '  returned text color
    lCustData As Long          '  data passed to hook fn.
    lpfnHook As Long           '  ptr. to hook function
    lpTemplateName As String     '  custom template name
    hInstance As Long          '  instance handle of.EXE that
    lpszStyle As String          '  return the style field here
    nFontType As Integer          '  same value reported to the EnumFonts
    MISSING_ALIGNMENT As Integer
    nSizeMin As Long           '  minimum pt size allowed &
    nSizeMax As Long           '  max pt size allowed if
End Type

Private Const CC_RGBINIT = &H1
Private Const CC_FULLOPEN = &H2
Private Const CC_PREVENTFULLOPEN = &H4
Private Const CC_SHOWHELP = &H8
Private Const CC_ENABLEHOOK = &H10
Private Const CC_ENABLETEMPLATE = &H20
Private Const CC_ENABLETEMPLATEHANDLE = &H40
Private Const CC_SOLIDCOLOR = &H80
Private Const CC_ANYCOLOR = &H100
Private Const SWP_NOMOVE = &H2
Private Declare Function SetWindowPos Lib "user32.dll" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Private Const COLOR_FLAGS = CC_FULLOPEN Or CC_ANYCOLOR Or CC_RGBINIT

Private Const CF_SCREENFONTS = &H1
Private Const CF_PRINTERFONTS = &H2
Private Const CF_BOTH = (CF_SCREENFONTS Or CF_PRINTERFONTS)
Private Const CF_SHOWHELP = &H4&
Private Const CF_ENABLEHOOK = &H8&
Private Const CF_ENABLETEMPLATE = &H10&
Private Const CF_ENABLETEMPLATEHANDLE = &H20&
Private Const CF_INITTOLOGFONTSTRUCT = &H40&
Private Const CF_USESTYLE = &H80&
Private Const CF_EFFECTS = &H100&
Private Const CF_APPLY = &H200&
Private Const CF_ANSIONLY = &H400&
Private Const CF_SCRIPTSONLY = CF_ANSIONLY
Private Const CF_NOVECTORFONTS = &H800&
Private Const CF_NOOEMFONTS = CF_NOVECTORFONTS
Private Const CF_NOSIMULATIONS = &H1000&
Private Const CF_LIMITSIZE = &H2000&
Private Const CF_FIXEDPITCHONLY = &H4000&
Private Const CF_WYSIWYG = &H8000 '  must also have CF_SCREENFONTS CF_PRINTERFONTS
Private Const CF_FORCEFONTEXIST = &H10000
Private Const CF_SCALABLEONLY = &H20000
Private Const CF_TTONLY = &H40000
Private Const CF_NOFACESEL = &H80000
Private Const CF_NOSTYLESEL = &H100000
Private Const CF_NOSIZESEL = &H200000
Private Const CF_SELECTSCRIPT = &H400000
Private Const CF_NOSCRIPTSEL = &H800000
Private Const CF_NOVERTFONTS = &H1000000

Private Const SIMULATED_FONTTYPE = &H8000
Private Const PRINTER_FONTTYPE = &H4000
Private Const SCREEN_FONTTYPE = &H2000
Private Const BOLD_FONTTYPE = &H100
Private Const ITALIC_FONTTYPE = &H200
Private Const REGULAR_FONTTYPE = &H400

Private Const LBSELCHSTRING = "commdlg_LBSelChangedNotify"
Private Const SHAREVISTRING = "commdlg_ShareViolation"
Private Const FILEOKSTRING = "commdlg_FileNameOK"
Private Const COLOROKSTRING = "commdlg_ColorOK"
Private Const SETRGBSTRING = "commdlg_SetRGBColor"
Private Const HELPMSGSTRING = "commdlg_help"
Private Const FINDMSGSTRING = "commdlg_FindReplace"

Private Const CD_LBSELNOITEMS = -1
Private Const CD_LBSELCHANGE = 0
Private Const CD_LBSELSUB = 1
Private Const CD_LBSELADD = 2

Private Const WM_DESTROY = &H2
Private Const WM_NOTIFY = &H4E
Private Const WM_SETICON = &H80

Private Const WM_USER = &H400
Private Const CDM_FIRST = (WM_USER + 100)
Private Const CDM_GETSPEC = (CDM_FIRST + &H0)
Private Const CDM_GETFILEPATH = (CDM_FIRST + &H1)
Private Const CDM_GETFOLDERPATH = (CDM_FIRST + &H2)
Private Const CDM_SETCONTROLTEXT = (CDM_FIRST + &H4)
Private Const CDM_HIDECONTROL = (CDM_FIRST + &H5)
Private Const CDM_SETDEFEXT = (CDM_FIRST + &H6)
Private Const CB_GETCURSEL = &H147

Private Const ID_OPEN = &H1  'Open or Save button
Private Const ID_CANCEL = &H2 'Cancel Button
Private Const ID_HELP = &H40E 'Help Button
Private Const ID_READONLY = &H410 'Read-only check box
Private Const ID_FILETYPELABEL = &H441 'FileType label
Private Const ID_FILELABEL = &H442 'FileName label
Private Const ID_FOLDERLABEL = &H443 'Folder label
Private Const ID_LIST = &H461 'Parent of file list
Private Const ID_FORMAT = &H470 'FileType combo box
Private Const ID_FOLDER = &H471 'Folder combo box
Private Const ID_FILETEXT = &H480 'FileName text box

Private Const CDN_FIRST = -601&
Private Const CDN_INITDONE = CDN_FIRST
Private Const CDN_SELCHANGE = (CDN_FIRST - &H1)
Private Const CDN_FOLDERCHANGE = (CDN_FIRST - &H2)
Private Const CDN_HELP = (CDN_FIRST - &H4)
Private Const CDN_FILEOK = (CDN_FIRST - &H5)
Private Const CDN_TYPECHANGE = (CDN_FIRST - &H6)

Private Type PRINTDLGS
        lStructSize As Long
        hwndOwner As Long
        hDevMode As Long
        hDevNames As Long
        hDc As Long
        Flags As Long
        nFromPage As Integer
        nToPage As Integer
        nMinPage As Integer
        nMaxPage As Integer
        nCopies As Integer
        hInstance As Long
        lCustData As Long
        lpfnPrintHook As Long
        lpfnSetupHook As Long
        lpPrintTemplateName As String
        lpSetupTemplateName As String
        hPrintTemplate As Long
        hSetupTemplate As Long
End Type

Private Const PD_ALLPAGES = &H0
Private Const PD_SELECTION = &H1
Private Const PD_PAGENUMS = &H2
Private Const PD_NOSELECTION = &H4
Private Const PD_NOPAGENUMS = &H8
Private Const PD_COLLATE = &H10
Private Const PD_PRINTTOFILE = &H20
Private Const PD_PRINTSETUP = &H40
Private Const PD_NOWARNING = &H80
Private Const PD_RETURNDC = &H100
Private Const PD_RETURNIC = &H200
Private Const PD_RETURNDEFAULT = &H400
Private Const PD_SHOWHELP = &H800
Private Const PD_ENABLEPRINTHOOK = &H1000
Private Const PD_ENABLESETUPHOOK = &H2000
Private Const PD_ENABLEPRINTTEMPLATE = &H4000
Private Const PD_ENABLESETUPTEMPLATE = &H8000
Private Const PD_ENABLEPRINTTEMPLATEHANDLE = &H10000
Private Const PD_ENABLESETUPTEMPLATEHANDLE = &H20000
Private Const PD_USEDEVMODECOPIES = &H40000
Private Const PD_USEDEVMODECOPIESANDCOLLATE = &H40000
Private Const PD_DISABLEPRINTTOFILE = &H80000
Private Const PD_HIDEPRINTTOFILE = &H100000
Private Const PD_NONETWORKBUTTON = &H200000

Private Type DEVNAMES
        wDriverOffset As Integer
        wDeviceOffset As Integer
        wOutputOffset As Integer
        wDefault As Integer
End Type

Private Const DN_DEFAULTPRN = &H1

Private Type SelectedFile
    nFilesSelected As Integer
    sFiles() As String
    sLastDirectory As String
    bCanceled As Boolean
End Type

Private Type SelectedColor
    oSelectedColor As OLE_COLOR
    bCanceled As Boolean
End Type

Private Type SelectedFont
    sSelectedFont As String
    bCanceled As Boolean
    bBold As Boolean
    bItalic As Boolean
    nsize As Integer
    bUnderline As Boolean
    bStrikeOut As Boolean
    lColor As Long
    sFaceName As String
End Type

Private m_hDlg          As Long
Private sOK             As String
Private sCancel         As String
Private sHelp           As String
Private m_hOldParent    As Long
Private FileDialog      As OPENFILENAME
Private ColorDialog     As CHOOSECOLORS
Private FontDialog      As CHOOSEFONTS
Private PrintDialog     As PRINTDLGS
Private parenthWnd      As Long
Private m_fExtraForm    As Form
Private sDlgFilter      As String
'<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Extract Icons>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Private Declare Function ExtractAssociatedIcon Lib "shell32.dll" Alias "ExtractAssociatedIconA" (ByVal hInst As Long, ByVal lpIconPath As String, lpiIcon As Long) As Long
Private Declare Function DrawIconEx Lib "user32" (ByVal hDc As Long, ByVal xLeft As Long, ByVal yTop As Long, ByVal hIcon As Long, ByVal cxWidth As Long, ByVal cyWidth As Long, ByVal istepIfAniCur As Long, ByVal hbrFlickerFreeDraw As Long, ByVal diFlags As Long) As Long
Private Declare Function DestroyIcon Lib "user32" (ByVal hIcon As Long) As Long

Private Const DI_MASK = &H1
Private Const DI_IMAGE = &H2
Private Const DI_NORMAL = DI_MASK Or DI_IMAGE

'ShellInfo Flags
Private Const SHGFI_DISPLAYNAME = &H200
Private Const SHGFI_EXETYPE = &H2000
Private Const SHGFI_SYSICONINDEX = &H4000 'System icon index
Private Const SHGFI_LARGEICON = &H0       'Large icon
Private Const SHGFI_SMALLICON = &H1       'Small icon
Private Const SHGFI_SHELLICONSIZE = &H4
Private Const SHGFI_TYPENAME = &H400

Private Const BASIC_SHGFI_FLAGS = SHGFI_TYPENAME Or SHGFI_SHELLICONSIZE Or SHGFI_SYSICONINDEX Or SHGFI_DISPLAYNAME Or SHGFI_EXETYPE

Public Const MAX_PATH = 260

Private Type SHFILEINFO                   'As required by ShInfo
  hIcon As Long
  iIcon As Long
  dwAttributes As Long
  szDisplayName As String * MAX_PATH
  szTypeName As String * 80
End Type

'<<<<Functions & Procedures
Private Declare Function SHGetFileInfo Lib "shell32.dll" Alias "SHGetFileInfoA" (ByVal pszPath As String, ByVal dwFileAttributes As Long, psfi As SHFILEINFO, ByVal cbSizeFileInfo As Long, ByVal uFlags As Long) As Long
Private Declare Function ImageList_Draw Lib "comctl32.dll" (ByVal himl&, ByVal i&, ByVal hDCDest&, ByVal X&, ByVal Y&, ByVal Flags&) As Long
'<<<<Private variables
Private ShInfo As SHFILEINFO

'<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Extract folder location of special folder>>>>>>>>>>>>>>>>>>>>>>>
Private Type SHITEMID
    cb As Long
    abID As Byte
End Type

Private Type ITEMIDLIST
    mkid As SHITEMID
End Type

Private Declare Function SHGetPathFromIDList Lib "shell32.dll" Alias "SHGetPathFromIDListA" (ByVal pidl As Long, ByVal pszPath As String) As Long
Private Declare Function SHGetSpecialFolderLocation Lib "shell32.dll" (ByVal hwndOwner As Long, ByVal nFolder As Long, pidl As ITEMIDLIST) As Long
Private Declare Function GetVersionEx Lib "kernel32" Alias "GetVersionExA" (lpVersionInformation As OSVERSIONINFO) As Long

Private Type OSVERSIONINFO
    dwOSVersionInfoSize As Long
    dwMajorVersion As Long
    dwMinorVersion As Long
    dwBuildNumber As Long
    dwPlatformId As Long
    szCSDVersion As String * 128
End Type

Private Type POINTAPI
    X As Long
    Y As Long
End Type

Private Type RECT
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type
Private Type PAGESETUPDIALOG
    lStructSize As Long
    hwndOwner As Long
    hDevMode As Long
    hDevNames As Long
    Flags As Long
    ptPaperSize As POINTAPI
    rtMinMargin As RECT
    rtMargin As RECT
    hInstance As Long
    lCustData As Long
    lpfnPageSetupHook As Long
    lpfnPagePaintHook As Long
    lpPageSetupTemplateName As String
    hPageSetupTemplate As Long
End Type

Private Declare Function PAGESETUPDLG Lib "comdlg32.dll" Alias "PageSetupDlgA" (pPagesetupdlg As PAGESETUPDIALOG) As Long
'<<<<<<<<<<<<<<<<<<<page setup<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Private Type SHELLEXECUTEINFO
    cbSize As Long
    fMask As Long
    hWnd As Long
    lpVerb As String
    lpFile As String
    lpParameters As String
    lpDirectory As String
    nShow As Long
    hInstApp As Long
    lpIDList As Long
    lpClass As String
    hkeyClass As Long
    dwHotKey As Long
    hIcon As Long
    hProcess As Long
End Type
Private Declare Function ShellExecuteEx Lib "shell32.dll" (Prop As SHELLEXECUTEINFO) As Long

Public FarTopMargin         As Single
Public FarRightMargin       As Single
Public MaxRightMargin       As Single
Public MaxLeftMargin        As Single
Public DocumentLayout       As Single
Public PrinterTop           As Currency
Public PrinterBottom        As Currency

'<<<<<<<<<<<<<<<<<<<windows file information<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

Public Sub GetPropDlg(frm As Form, mfile As String)
    'show property dialog
    Dim Prop As SHELLEXECUTEINFO
    Dim r As Long
    With Prop
        .cbSize = Len(Prop)
        .fMask = &HC
        .hWnd = frm.hWnd
        .lpVerb = "properties"
        .lpFile = mfile
    End With
    r = ShellExecuteEx(Prop)
End Sub

Public Function ShowPageSetupDlg() As Long
Dim MyLength    As Single
    Dim m_PSD As PAGESETUPDIALOG
    m_PSD.lStructSize = Len(m_PSD)
    m_PSD.hwndOwner = MainMDi.hWnd
    m_PSD.hInstance = App.hInstance
    m_PSD.Flags = 0
    If PAGESETUPDLG(m_PSD) Then
        MyLength = 12210 / 8500
        FarRightMargin = (m_PSD.ptPaperSize.X) * MyLength
        FarTopMargin = (m_PSD.ptPaperSize.Y) * MyLength
        MaxLeftMargin = m_PSD.rtMargin.Left * MyLength
        MaxRightMargin = (m_PSD.rtMargin.Right) * MyLength
        PrinterTop = (m_PSD.rtMargin.Top) * MyLength
        PrinterBottom = (m_PSD.rtMargin.Bottom) * MyLength
'        DocumentLayout = m_PSD.

'        Call frmReport.DocumentMargin(1, MaxLeftMargin, 0)
'        Call frmReport.DocumentMargin(2, MaxRightMargin, 0)
        ShowPageSetupDlg = 0
    Else
        ShowPageSetupDlg = -1
    End If
End Function

Private Function ShowOpen(ByVal hWnd As Long, Optional ByVal centerForm As Boolean = True) As SelectedFile
Dim ret As Long
Dim count As Integer
Dim fileNameHolder As String
Dim LastCharacter As Integer
Dim NewCharacter As Integer
Dim tempFiles(1 To 200) As String
Dim hInst As Long
Dim Thread As Long
    
    parenthWnd = hWnd
    FileDialog.nStructSize = Len(FileDialog)
    FileDialog.hwndOwner = hWnd
    FileDialog.sFileTitle = Space$(2048)
    FileDialog.nTitleSize = Len(FileDialog.sFileTitle)
    FileDialog.sFile = FileDialog.sFile & Space$(2047) & Chr$(0) '
    FileDialog.nFileSize = Len(FileDialog.sFile)
    FileDialog.nFilterIndex = 1
    
    If FileDialog.Flags = 0 Then
        FileDialog.Flags = OFS_FILE_OPEN_FLAGS
    End If
    
    'Set up the CBT hook
    hInst = GetWindowLong(hWnd, GWL_HINSTANCE)
    Thread = GetCurrentThreadId()
    If centerForm = True Then
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterForm, hInst, Thread)
    Else
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterScreen, hInst, Thread)
    End If
    
    ret = GetOpenFileName(FileDialog)

    If ret Then
        If Trim$(FileDialog.sFileTitle) = "" Then
            LastCharacter = 0
            count = 0
            While ShowOpen.nFilesSelected = 0
                NewCharacter = InStr(LastCharacter + 1, FileDialog.sFile, Chr$(0), vbTextCompare)
                If count > 0 Then
                    tempFiles(count) = Mid(FileDialog.sFile, LastCharacter + 1, NewCharacter - LastCharacter - 1)
                Else
                    ShowOpen.sLastDirectory = Mid(FileDialog.sFile, LastCharacter + 1, NewCharacter - LastCharacter - 1)
                End If
                count = count + 1
                If InStr(NewCharacter + 1, FileDialog.sFile, Chr$(0), vbTextCompare) = InStr(NewCharacter + 1, FileDialog.sFile, Chr$(0) & Chr$(0), vbTextCompare) Then
                    tempFiles(count) = Mid(FileDialog.sFile, NewCharacter + 1, InStr(NewCharacter + 1, FileDialog.sFile, Chr$(0) & Chr$(0), vbTextCompare) - NewCharacter - 1)
                    ShowOpen.nFilesSelected = count
                End If
                LastCharacter = NewCharacter
            Wend
            ReDim ShowOpen.sFiles(1 To ShowOpen.nFilesSelected)
            For count = 1 To ShowOpen.nFilesSelected
                ShowOpen.sFiles(count) = tempFiles(count)
            Next
        Else
            ReDim ShowOpen.sFiles(1 To 1)
            ShowOpen.sLastDirectory = Left$(FileDialog.sFile, FileDialog.nFileOffset)
            ShowOpen.nFilesSelected = 1
            ShowOpen.sFiles(1) = Mid(FileDialog.sFile, FileDialog.nFileOffset + 1, InStr(1, FileDialog.sFile, Chr$(0), vbTextCompare) - FileDialog.nFileOffset - 1)
        End If
        ShowOpen.bCanceled = False
        Exit Function
    Else
        ShowOpen.sLastDirectory = ""
        ShowOpen.nFilesSelected = 0
        ShowOpen.bCanceled = True
        Erase ShowOpen.sFiles
        Exit Function
    End If
End Function

Private Function ShowSave(ByVal hWnd As Long, Optional ByVal centerForm As Boolean = True) As SelectedFile
Dim ret As Long
Dim hInst As Long
Dim Thread As Long
Dim MyFileName As String
Dim Loclng  As Long
    
    parenthWnd = hWnd
    FileDialog.nStructSize = Len(FileDialog)
    FileDialog.hwndOwner = hWnd
    FileDialog.sFileTitle = Space$(2048)
    FileDialog.nTitleSize = Len(FileDialog.sFileTitle)
    FileDialog.nFilterIndex = 1
    If FileDialog.sFile = "" Then
        FileDialog.sFile = Space$(2047) & Chr$(0)
    ElseIf Right(FileDialog.sFile, 1) <> Chr$(0) Then
        FileDialog.sFile = FileDialog.sFile & Space$(2047 - Len(FileDialog.sFile)) & Chr$(0)
    End If
    FileDialog.nFileSize = Len(FileDialog.sFile)
    
    If FileDialog.Flags = 0 Then
        FileDialog.Flags = OFS_FILE_SAVE_FLAGS
    End If
    
    'Set up the CBT hook
    hInst = GetWindowLong(hWnd, GWL_HINSTANCE)
    Thread = GetCurrentThreadId()
    If centerForm = True Then
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterForm, hInst, Thread)
    Else
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterScreen, hInst, Thread)
    End If
    
    ret = GetSaveFileName(FileDialog)
    ReDim ShowSave.sFiles(1)

    If ret Then
        ShowSave.sLastDirectory = Left$(FileDialog.sFile, FileDialog.nFileOffset)
        ShowSave.nFilesSelected = 1
        ShowSave.sFiles(1) = Mid(FileDialog.sFile, FileDialog.nFileOffset + 1, InStr(1, FileDialog.sFile, Chr$(0), vbTextCompare) - FileDialog.nFileOffset - 1)
        MyFileName = ShowSave.sFiles(1)
        Loclng = HowMany(MyFileName, ".")
        If Right(ShowSave.sFiles(1), Len(ShowSave.sFiles(1)) - Loclng) = FileDialog.sDefFileExt Then
            MyFileName = Left(ShowSave.sFiles(1), Loclng - 1)
            If InStr(1, MyFileName, ".") > 0 Then
                ShowSave.sFiles(1) = MyFileName
            End If
        End If
        ShowSave.bCanceled = False
        Exit Function
    Else
        ShowSave.sLastDirectory = ""
        ShowSave.nFilesSelected = 0
        ShowSave.bCanceled = True
        Erase ShowSave.sFiles
        Exit Function
    End If
End Function

Public Function HowMany(YOURstring As String, Token As String) As Long
Dim Loclng      As Long
Dim TempData    As String
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<sample if  YourString if ("This_is_a_test.", "_") the return = 3 token will be
    '<<<<<save with last string found.
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
   If YOURstring = "" Then
      YOURstring = ""
      Exit Function
   End If
   HowMany = 0
   Loclng = 0
   TempData = YOURstring
   Do While TempData <> ""
        HowMany = HowMany + Loclng
        Loclng = InStr(1, TempData, Token)
        If Loclng = 0 Then
            If HowMany = 0 Then
                YOURstring = YOURstring
            Else
                YOURstring = Trim(Left(YOURstring, HowMany))
            End If
            Exit Function
        Else
            TempData = Right(TempData, Len(TempData) - Loclng)
        End If
   Loop
End Function
Private Function ShowColor(ByVal hWnd As Long, Optional ByVal centerForm As Boolean = True) As SelectedColor
Dim customcolors() As Byte  ' dynamic (resizable) array
Dim i As Integer
Dim ret As Long
Dim hInst As Long
Dim Thread As Long

    parenthWnd = hWnd
    If ColorDialog.lpCustColors = "" Then
        ReDim customcolors(0 To 16 * 4 - 1) As Byte  'resize the array
    
        For i = LBound(customcolors) To UBound(customcolors)
          customcolors(i) = 254 ' sets all custom colors to white
        Next i
        
        ColorDialog.lpCustColors = StrConv(customcolors, vbUnicode)  ' convert array
    End If
    
    ColorDialog.hwndOwner = hWnd
    ColorDialog.lStructSize = Len(ColorDialog)
    ColorDialog.Flags = COLOR_FLAGS
    
    'Set up the CBT hook
    hInst = GetWindowLong(hWnd, GWL_HINSTANCE)
    Thread = GetCurrentThreadId()
    If centerForm = True Then
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterForm, hInst, Thread)
    Else
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterScreen, hInst, Thread)
    End If
    
    ret = ChooseColor(ColorDialog)
    If ret Then
        ShowColor.bCanceled = False
        ShowColor.oSelectedColor = ColorDialog.rgbResult
        Exit Function
    Else
        ShowColor.bCanceled = True
        ShowColor.oSelectedColor = &H0&
        Exit Function
    End If
End Function

Private Function ShowFont(ByVal hWnd As Long, ByVal startingFontName As String, Optional ByVal centerForm As Boolean = True) As SelectedFont
Dim ret As Long
Dim lfLogFont As LOGFONT
Dim hInst As Long
Dim Thread As Long
Dim i As Integer
    
    parenthWnd = hWnd
    FontDialog.nSizeMax = 0
    FontDialog.nSizeMin = 0
    FontDialog.nFontType = Screen.FontCount
    FontDialog.hwndOwner = hWnd
    FontDialog.hDc = 0
    FontDialog.lpfnHook = 0
    FontDialog.lCustData = 0
    FontDialog.lpLogFont = VarPtr(lfLogFont)
    FontDialog.iPointSize = 10
    FontDialog.lpTemplateName = Space$(2048)
    FontDialog.rgbColors = RGB(0, 255, 255)
    FontDialog.lStructSize = Len(FontDialog)
    
    If FontDialog.Flags = 0 Then
        FontDialog.Flags = CF_SCREENFONTS Or CF_EFFECTS Or CF_INITTOLOGFONTSTRUCT 'Or CF_EFFECTS
    End If
    
    For i = 0 To Len(startingFontName) - 1
        lfLogFont.lfFaceName(i) = Asc(Mid(startingFontName, i + 1, 1))
    Next
    
    'Set up the CBT hook
    hInst = GetWindowLong(hWnd, GWL_HINSTANCE)
    Thread = GetCurrentThreadId()
    If centerForm = True Then
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterForm, hInst, Thread)
    Else
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterScreen, hInst, Thread)
    End If
    
    ret = ChooseFont(FontDialog)
        
    If ret Then
        ShowFont.bCanceled = False
        ShowFont.bBold = IIf(lfLogFont.lfWeight > 400, 1, 0)
        ShowFont.bItalic = lfLogFont.lfItalic
        ShowFont.bStrikeOut = lfLogFont.lfStrikeOut
        ShowFont.bUnderline = lfLogFont.lfUnderline
        ShowFont.lColor = FontDialog.rgbColors
        ShowFont.nsize = FontDialog.iPointSize / 10
        For i = 0 To 31
            ShowFont.sSelectedFont = ShowFont.sSelectedFont + Chr(lfLogFont.lfFaceName(i))
        Next
    
        ShowFont.sSelectedFont = Mid(ShowFont.sSelectedFont, 1, InStr(1, ShowFont.sSelectedFont, Chr(0)) - 1)
        Exit Function
    Else
        ShowFont.bCanceled = True
        Exit Function
    End If
End Function
Private Function ShowPrinter(ByVal hWnd As Long, Optional ByVal centerForm As Boolean = True) As Long
Dim hInst As Long
Dim Thread As Long
    
    parenthWnd = hWnd
    PrintDialog.hwndOwner = hWnd
    PrintDialog.lStructSize = Len(PrintDialog)
    
    'Set up the CBT hook
    hInst = GetWindowLong(hWnd, GWL_HINSTANCE)
    Thread = GetCurrentThreadId()
    If centerForm = True Then
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterForm, hInst, Thread)
    Else
        hHook = SetWindowsHookEx(WH_CBT, AddressOf WinProcCenterScreen, hInst, Thread)
    End If
    
    ShowPrinter = PrintDlg(PrintDialog)
End Function

Public Sub Ontop(hWnd As Long, Istop As Boolean)
If Istop = True Then
    Call SetWindowPos(hWnd, -1, 0, 0, 1, 1, SWP_NOSIZE Or SWP_NOMOVE) 'on top
Else
    Call SetWindowPos(hWnd, -2, 0, 0, 1, 1, SWP_NOSIZE Or SWP_NOMOVE) 'not on top
End If
End Sub

Private Function WinProcCenterScreen(ByVal lMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    Dim rectForm As RECT, rectMsg As RECT
    Dim X As Long, Y As Long
    If lMsg = HCBT_ACTIVATE Then
        'Show the MsgBox at a fixed location (0,0)
        GetWindowRect wParam, rectMsg
        X = Screen.Width / Screen.TwipsPerPixelX / 2 - (rectMsg.Right - rectMsg.Left) / 2
        Y = Screen.Height / Screen.TwipsPerPixelY / 2 - (rectMsg.Bottom - rectMsg.Top) / 2
        '''''Debug.Print "Screen " & Screen.height / 2
        '''''Debug.Print "MsgBox " & (rectMsg.Right - rectMsg.left) / 2
        SetWindowPos wParam, 0, X, Y, 0, 0, SWP_NOSIZE Or SWP_NOZORDER Or SWP_NOACTIVATE
        'Release the CBT hook
        UnhookWindowsHookEx hHook
    End If
    WinProcCenterScreen = False
End Function

Private Function WinProcCenterForm(ByVal lMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    Dim rectForm As RECT, rectMsg As RECT
    Dim X As Long, Y As Long
    'On HCBT_ACTIVATE, show the MsgBox centered over
    If lMsg = HCBT_ACTIVATE Then
        'Get the coordinates of the form and the message box so that
        'you can determine where the center of the form is located
        GetWindowRect parenthWnd, rectForm
        GetWindowRect wParam, rectMsg
        X = (rectForm.Left + (rectForm.Right - rectForm.Left) / 2) - ((rectMsg.Right - rectMsg.Left) / 2)
        Y = (rectForm.Top + (rectForm.Bottom - rectForm.Top) / 2) - ((rectMsg.Bottom - rectMsg.Top) / 2)
        'Position the msgbox
        SetWindowPos wParam, 0, X, Y, 0, 0, SWP_NOSIZE Or SWP_NOZORDER Or SWP_NOACTIVATE
        'Release the CBT hook
        UnhookWindowsHookEx hHook
     End If
     WinProcCenterForm = False
End Function

Public Function DetermineDirectory(InputString As String) As String
Dim pos As Integer
    If InputString = "" Then DetermineDirectory = "": Exit Function
    pos = InStrRev(InputString, "\", , vbTextCompare)
    DetermineDirectory = Mid(InputString, 1, pos)
End Function

Public Function DetermineFilename(InputString As String) As String
Dim pos As Integer
    If InputString = "" Then DetermineFilename = "": Exit Function
    If InStr(1, InputString, "\") = 0 Then
        DetermineFilename = InputString
    Else
        pos = InStrRev(InputString, "\", , vbTextCompare)
        DetermineFilename = Mid(InputString, pos + 1, Len(InputString) - pos)
    End If
End Function

Public Function DetermineFileExt(InputString As String) As String
Dim TempData    As String
Dim TheFile     As String
Dim i           As Long

    TheFile = DetermineFilename(InputString)
    TempData = TheFile
    i = HowMany(TempData, ".")
    If i > 0 Then DetermineFileExt = Right(TheFile, Len(TheFile) - i)
End Function

Public Function SelectFile(frm As Form, filter As String, Flags As Long, defaultExtension As String, Optional Open0Save1Color2Printer3 As Integer, Optional TheDir As String, Optional TheTitle As String) As String
Dim sOpen           As SelectedFile
Dim sColor          As SelectedColor
Dim Filename        As String
Dim i               As Integer
Dim lastFilename    As String
Dim sPrinter        As Long

On Error Resume Next
If frm.WindowState = vbMinimized Then
    frm.WindowState = vbNormal
    frm.Show
    frm.ZOrder 0
End If
    m_hDlg = 0: sDlgFilter = filter

'    Do While filename = ""
        If Open0Save1Color2Printer3 = 0 Then
            lastFilename = GetSetting(App.Title, "Settings", "FileName")
            FileDialog.sFilter = filter
            FileDialog.Flags = Flags
            If TheDir = "" Then
                FileDialog.sInitDir = DetermineDirectory(lastFilename)
                FileDialog.sFile = DetermineFilename(lastFilename)
            Else
                If modFileInformation.CheckFileORdir(TheDir, False) = True Then
                    FileDialog.sInitDir = DetermineDirectory(TheDir)
                    FileDialog.sFile = DetermineFilename(TheDir)
                Else
                    If modFileInformation.CheckFileORdir(TheDir, True) = True Then
                        FileDialog.sInitDir = DetermineDirectory(TheDir)
                    Else
                        FileDialog.sInitDir = DetermineDirectory(lastFilename)
                    End If
                    FileDialog.sFile = DetermineFilename(lastFilename)
                End If
            End If
            If Len(TheTitle) = 0 Then TheTitle = "Open File"
            FileDialog.sDlgTitle = TheTitle
            FileDialog.sDefFileExt = defaultExtension
            
            sOpen = ShowOpen(frm.hWnd, True)
        ElseIf Open0Save1Color2Printer3 = 1 Then
            lastFilename = GetSetting(App.Title, "Settings", "FileName")
            FileDialog.sFilter = filter
            FileDialog.Flags = Flags
            If TheDir = "" Then
                FileDialog.sInitDir = DetermineDirectory(lastFilename)
            Else
                FileDialog.sInitDir = TheDir
            End If
            FileDialog.sFile = ""
            If Len(TheTitle) = 0 Then TheTitle = "Save Document/File As"
            FileDialog.sDlgTitle = TheTitle
            FileDialog.sDefFileExt = defaultExtension
            sOpen = ShowSave(frm.hWnd, True)
        ElseIf Open0Save1Color2Printer3 = 2 Then
            sColor = ShowColor(frm.hWnd, True)
            If CStr(sColor.oSelectedColor) <> "" Then
                SelectFile = CStr(sColor.oSelectedColor)
            End If
            Exit Function
        ElseIf Open0Save1Color2Printer3 = 3 Then
            sPrinter = ShowPrinter(frm.hWnd, True)
            Exit Function
        End If
        If sOpen.sFiles(1) = "" Then
            Exit Function
        Else
            If Flags = OFS_FILE_OPEN_FLAGS_MULTISELECT Then
                For i = 1 To sOpen.nFilesSelected
                    Filename = sOpen.sLastDirectory
                    If Len(Filename) > 0 Then
                        If Right(Filename, 1) <> "\" Then Filename = Filename & "\"
                    End If
                    Filename = Filename & sOpen.sFiles(i)
                    If Len(Filename) > 0 Then SelectFile = SelectFile & Filename & vbCrLf
                Next
            Else
                Filename = sOpen.sLastDirectory
                If Len(Filename) > 0 Then
                    If Right(Filename, 1) <> "\" Then Filename = Filename & "\"
                End If
                Filename = Filename & sOpen.sFiles(1)
                If InStr(1, Filename, ".") = 0 And defaultExtension <> "" Then
                    If LCase(Right(Filename, 4)) <> "." & defaultExtension Then
                        Filename = Filename & "." & defaultExtension
                    End If
                End If
                SelectFile = Filename
                Call SaveSetting(App.Title, "Settings", "FileName", Filename)
            End If
        End If
'    Loop
    Exit Function
WriteMyError:
    SelectFile = ""
    Exit Function
End Function

Public Sub PicturePaint(PicHDC As Long, dFileName As String)
    Dim lIcon As Long
    ' Extract assocciate icon from file
    lIcon = ExtractAssociatedIcon(App.hInstance, dFileName, 0&)
    DrawIconEx PicHDC, 0, 0, lIcon, 0, 0, 0, 0, DI_NORMAL 'Draw icon in picturebox
    DestroyIcon lIcon 'Destroy icon
End Sub

Public Function FolderSpecialnShortcut(TargetFolder As String, WinHandle As Long, SourceFile As String) As String
' spécial style c:\windows, c:\windows\recent...

Dim i           As Long
Dim TempData    As String
Dim IDL         As ITEMIDLIST
Dim CSIDL       As Long

Dim WSHShell
Dim MyShortcut, MyDesktop, DesktopPath


'<<<<         CSIDL = 0 user\ desktop
'<<<<         CSIDL = 2 user\ start menu \programs
'<<<<         CSIDL = 5 user\ personal
'<<<<         CSIDL = 6 user\favourite
'<<<<         CSIDL = 7 user\ start menu \programs\startup
'<<<<         CSIDL = 8 user\recents
'<<<<         CSIDL = 9 user\send to
'<<<<         CSIDL = 11 user \start menu
'<<<<         CSIDL = 16 user\ desktop
'<<<<         CSIDL = 19 user\ nethood
'<<<<         CSIDL = 20 winnt\fonts
'<<<<         CSIDL = 21 winnt\shellnew
'<<<<         CCSIDL = 25 all user\desktop
'<<<<         CSIDL = 26 user\application data
'<<<<         CSIDL = 27 user\printhood
'<<<<         CSIDL = 32
'<<<<         CSIDL = 33
'<<<<         CSIDL = 34

Const NOERROR = 0
Const MAX_LENGTH = 260

If IsNumeric(TargetFolder) = True Then
    CSIDL = Val(TargetFolder)
    i = SHGetSpecialFolderLocation(WinHandle, CSIDL, IDL)
    If i = NOERROR Then
        '"Type" IDL
        TempData = Space$(MAX_LENGTH)
        i = SHGetPathFromIDList(ByVal IDL.mkid.cb, ByVal TempData)
        If i Then
            TargetFolder = Left$(TempData, InStr(TempData, Chr$(0)) - 1)
        End If
    End If
End If
If Len(Trim(SourceFile)) > 0 Then 'user want to create shortcut
    If modFileInformation.CheckFileORdir(SourceFile, False) = True Then
        Set WSHShell = CreateObject("WScript.Shell")
            TempData = DetermineFilename(SourceFile)
            If InStr(1, TempData, ".") > 0 Then TempData = Left(TempData, InStr(1, TempData, ".") - 1)
            Set MyShortcut = WSHShell.CreateShortcut(TargetFolder & "\" & TempData & ".lnk")
            MyShortcut.TargetPath = WSHShell.ExpandEnvironmentStrings(SourceFile)
            MyShortcut.WorkingDirectory = WSHShell.ExpandEnvironmentStrings("%windir%")
            MyShortcut.WindowStyle = 4
            MyShortcut.IconLocation = WSHShell.ExpandEnvironmentStrings(SourceFile)
            MyShortcut.Save
        Set MyShortcut = Nothing
    Else
        MsgBox "Filename " & SourceFile & " not exist.", vbExclamation, "Error"
    End If
End If

Exit Function
WriteMyError:
    MsgBox "An error occured while processing your request.", vbInformation, "Information"
End Function

Public Function GetPlatForm() As enmPlatForm

  Static HasRead As Boolean, PID As enmPlatForm
    
  Dim osv As OSVERSIONINFO
    
    If Not HasRead Then
        osv.dwOSVersionInfoSize = Len(osv)
        GetVersionEx osv
    
        If osv.dwPlatformId = 1 Then
            PID = enmPlatForm.VER_PLATFORM_WIN32_WINDOWS
          ElseIf osv.dwPlatformId = 0 Then '! osv.dwplatformid...
            PID = enmPlatForm.VER_PLATFORM_WIN32_NT
        End If
        HasRead = True
    End If
    GetPlatForm = PID
    
End Function

Private Function DialogHookProcess(ByVal hDlg As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long, isOpen As Boolean, MeFrm As Form) As Long
   Dim tNMH As NMHDR
   Dim sPath As String, sExt As String
   Dim nPos As Long
   Dim sCurExt  As String
   
   Select Case wMsg
         Case WM_NOTIFY
               CopyMemory tNMH, ByVal lParam, Len(tNMH)
               Select Case tNMH.code
                      Case CDN_FOLDERCHANGE
                           SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_FILETEXT, ByVal ""
                      Case CDN_SELCHANGE
'                           sPath = GetSelItem
                           If sPath <> "" Then
                              SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_FILETEXT, ByVal sPath
                           End If
                      Case CDN_FILEOK
                      Case CDN_TYPECHANGE
                           sPath = String(MAX_PATH, 0)
                           Call SendMessage(m_hDlg, CDM_GETSPEC, MAX_PATH, ByVal sPath)
                           sPath = TrimNull(sPath)
                           If (Len(sPath) > 4) Then
                              sExt = Right$(sPath, 5)
                              nPos = InStr(1, sExt, ".")
                              If nPos Then
                                 sPath = Left$(sPath, Len(sPath) - 6 + nPos)
                              End If
                           End If
                           sCurExt = GetDLGExtension()
                           If Len(sCurExt) > 2 Then
                              SendMessage m_hDlg, CDM_SETDEFEXT, 0, ByVal Mid$(sCurExt, 3)
                           End If
                           SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_FILETEXT, ByVal sPath
                      Case CDN_INITDONE
                           m_hDlg = GetParent(hDlg)
                           Call ModifyDlg(isOpen, MeFrm)
'                           CentreDlg
                      Case CDN_HELP
'                           m_bPreview = Not m_bPreview
'                           If m_bPreview Then
'                              CentreDlg True
'                              SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_HELP, ByVal "<<&Hide"
'                              PreviewPicture
'                           Else
'                              CentreDlg False
                              SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_HELP, ByVal sHelp
'                           End If
                      Case Else
               End Select
          Case WM_DESTROY
               If m_hOldParent Then
                  m_fExtraForm.Visible = False
                  SetParent m_fExtraForm.hWnd, m_hOldParent
               End If
               ' Here you can add user's notification
               ' before exiting
          Case Else
   End Select
End Function

Private Function GetDLGExtension() As String
   Dim i As Long, nFilter As Long, nStart As Long, hCombo As Long
   Dim sFilter As String, sTemp As String
    Dim sCurExt  As String
   
   hCombo = GetDlgItem(m_hDlg, ID_FORMAT)
   nFilter = SendMessage(hCombo, CB_GETCURSEL, 0, ByVal 0&)
   sFilter = sDlgFilter
   For i = 1 To nFilter * 2 + 1
       nStart = InStr(1, sFilter, Chr(0))
       If nStart Then
          sFilter = Mid(sFilter, nStart + 1)
       Else
          Exit For
       End If
   Next i
   sTemp = TrimNull(sFilter)
   If Len(sTemp) = 0 Then Exit Function
   If InStr(1, sTemp, ";") = 0 Then GetDLGExtension = sTemp
End Function

Private Sub ModifyDlg(isOpen As Boolean, MeFrm As Form)
   SendMessage m_hDlg, WM_SETICON, 0&, ByVal CLng(MeFrm.Icon)
   sCancel = "&Forget It!"
   If isOpen Then
      sOK = "&Open"
      sHelp = "&Options"
   Else
      sOK = "&Save"
      sHelp = "&Options"
   End If
   If m_fExtraForm Is Nothing Then
      SendMessage m_hDlg, CDM_HIDECONTROL, ID_HELP, ByVal 0&
   Else
      m_hOldParent = SetParent(m_fExtraForm.hWnd, m_hDlg)
      m_fExtraForm.Visible = True
   End If
   SendMessage m_hDlg, CDM_HIDECONTROL, ID_READONLY, ByVal 0&
   SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_OPEN, ByVal sOK
   SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_CANCEL, ByVal sCancel
   SendMessage m_hDlg, CDM_SETCONTROLTEXT, ID_HELP, ByVal sHelp
End Sub

Public Function TrimNull(ByVal szString As String) As String

'trims Null values from end of string
Dim lPos As Long
1    TrimNull = szString
2    lPos = InStr(szString, vbNullChar)
3    If lPos > 0 Then
4        TrimNull = Left$(TrimNull, lPos - 1)
5    End If
  Exit Function
BUGS:
End Function

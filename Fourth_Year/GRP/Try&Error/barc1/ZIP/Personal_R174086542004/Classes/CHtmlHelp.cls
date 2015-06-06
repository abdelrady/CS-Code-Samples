VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CHtmlHelp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'*****************************************************************************************
'* Class       : CHtmlHelp
'* Description : Class that provides code for working with HTML (*.chm ) files.
'* Notes       : Use this class if you want to give your application a help file written
'*               in HTML format. In order to use this class you must have
'*               Internet Explorer 4.0 or later, installed.
'*               For advanced use, please see the Source+ Library online documentation
'*               in the Source+ Explorer (the "Documentation" tab).
'*****************************************************************************************

Option Explicit

' Error handling definitions
Private Const E_ERR_BASE = 17640 + vbObjectError
Public Enum EErrHtmlHelp
    eErrHtmlHelp_NotInitialized = E_ERR_BASE + 1
    eErrHtmlHelp_InvalidFileName
    eErrHtmlHelp_FileNotFound
    eErrHtmlHelp_InvalidWindowHandle
    eErrHtmlHelp_ComponentFailure
End Enum
Private Const S_ERR_NotIntialized = "Object not properly initialized"
Private Const S_ERR_InvalidFileName = "Invalid file name"
Private Const S_ERR_FileNotFound = "File not found"
Private Const S_ERR_InvalidWindowHandle = "Invalid window handle"
Private Const S_ERR_ComponentFailure = "CHtmlHelp component failure"

' Private class constants
Private Const HH_DISPLAY_TOPIC = &H0
Private Const HH_DISPLAY_TOC = &H1
Private Const HH_DISPLAY_INDEX = &H2
Private Const HH_DISPLAY_SEARCH = &H3
Private Const INVALID_HANDLE_VALUE = -1
Private Const MAX_LENGTH = 512
Private Const HH_CLOSE_ALL = &H12  ' added by junwebhead

' Private class type definitions
Private Type FILETIME
    dwLowDateTime       As Long
    dwHighDateTime      As Long
End Type
Private Type HH_FTS_QUERY
    cbStruct            As Long
    fUniCodeStrings     As Long
    pszSearchQuery      As String
    iProximity          As Long
    fStemmedSearch      As Long
    fTitleOnly          As Long
    fExecute            As Long
    pszWindow           As String
End Type
Private Type WIN32_FIND_DATA
    dwFileAttributes    As Long
    ftCreationTime      As FILETIME
    ftLastAccessTime    As FILETIME
    ftLastWriteTime     As FILETIME
    nFileSizeHigh       As Long
    nFileSizeLow        As Long
    dwReserved0         As Long
    dwReserved1         As Long
    cFileName           As String * MAX_LENGTH
    cAlternate          As String * 14
End Type

' Private class API function declarations
Private Declare Function htmlhelp Lib "hhctrl.ocx" Alias "HtmlHelpA" (ByVal hwnd As Long, ByVal lpHelpFile As String, ByVal wCommand As Long, ByVal dwData As Long) As Long
Private Declare Function htmlhelp_s Lib "hhctrl.ocx" Alias "HtmlHelpA" (ByVal hwnd As Long, ByVal lpHelpFile As String, ByVal wCommand As Long, ByVal dwData As String) As Long
Private Declare Function htmlhelp_fts Lib "hhctrl.ocx" Alias "HtmlHelpA" (ByVal hwnd As Long, ByVal lpHelpFile As String, ByVal wCommand As Long, ByRef dwData As HH_FTS_QUERY) As Long
Private Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, lpFindFileData As WIN32_FIND_DATA) As Long
Private Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Long) As Long
Private Declare Function IsWindow Lib "user32" (ByVal hwnd As Long) As Long

' Private variables to hold property values
Private m_lCallerHWnd   As Long
Private m_sFileName     As String
Private m_sWindowName   As String

'*****************************************************************************************
'* Sub         : Init
'* Notes       : Use this routine for basic object initialization.
'*****************************************************************************************
Public Sub Init(FileName As String, Optional WindowName As String = "Main", Optional CallerHWnd As Long = 0)
    On Error GoTo hComponentFailure

    If Len(FileName) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_InvalidFileName, App.EXEName & ".CHtmlHelp", S_ERR_InvalidFileName
    End If
    
    If Not FileExists(FileName) Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_FileNotFound, App.EXEName & ".CHtmlHelp", S_ERR_FileNotFound
    End If
    
    m_sFileName = FileName
    
    If CallerHWnd > 0 Then
        If IsWindow(CallerHWnd) = 0 Then
            On Error GoTo hComponentFailure
            Err.Raise eErrHtmlHelp_InvalidWindowHandle, App.EXEName & ".CHtmlHelp", S_ERR_InvalidWindowHandle
        End If
    End If
    
    m_lCallerHWnd = CallerHWnd
    
    m_sWindowName = WindowName

Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub

'*****************************************************************************************
'* Property    : CallerHWnd
'* Notes       : Returns or sets the handle identifying the window requesting to display
'*               the HTML file.
'*****************************************************************************************
Public Property Let CallerHWnd(Value As Long)
    On Error GoTo hComponentFailure
    
    If Value > 0 Then
        If IsWindow(Value) = 0 Then
            On Error GoTo 0
            Err.Raise eErrHtmlHelp_InvalidWindowHandle, App.EXEName & ".CHtmlHelp", S_ERR_InvalidWindowHandle
        End If
    End If
    
    m_lCallerHWnd = Value

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property

Public Property Get CallerHWnd() As Long
    On Error GoTo hComponentFailure
    
    CallerHWnd = m_lCallerHWnd

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property


'*****************************************************************************************
'* Property    : FileName
'* Notes       : Returns or sets the name of the displayed HTML (*.chm) file.
'*****************************************************************************************
Public Property Let FileName(Value As String)
    On Error GoTo hComponentFailure
    
    If Len(Value) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_InvalidFileName, App.EXEName & ".CHtmlHelp", S_ERR_InvalidFileName
    End If
    
    If Not FileExists(Value) Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_FileNotFound, App.EXEName & ".CHtmlHelp", S_ERR_FileNotFound
    End If
    
    m_sFileName = Value

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property

Public Property Get FileName() As String
    On Error GoTo hComponentFailure
    
    FileName = m_sFileName

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property


'*****************************************************************************************
'* Property    : WindowName
'* Notes       : Returns or sets a string value containing the name of the window which
'*               hosts the displayed HTML file.
'*****************************************************************************************
Public Property Let WindowName(Value As String)
    On Error GoTo hComponentFailure
    
    m_sWindowName = Value

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property

Public Property Get WindowName() As String
    On Error GoTo hComponentFailure
    
    WindowName = m_sWindowName

Exit Property

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Property


'*****************************************************************************************
'* Sub         : ShowContents
'* Notes       : Displays the Contents page/tab of the current HTML (*.chm) file.
'*****************************************************************************************
Public Sub ShowContents()
    On Error GoTo hComponentFailure
    
    If Len(m_sFileName) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_NotInitialized, App.EXEName & ".CHtmlHelp", S_ERR_NotIntialized
    End If
    
    htmlhelp m_lCallerHWnd, m_sFileName & ">" & m_sWindowName, HH_DISPLAY_TOC, 0

    Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub


'*****************************************************************************************
'* Sub         : ShowIndex
'* Notes       : Displays the Index tab of the current HTML (*.chm) file.
'*****************************************************************************************
Public Sub ShowIndex()
    On Error GoTo hComponentFailure
    
    If Len(m_sFileName) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_NotInitialized, App.EXEName & ".CHtmlHelp", S_ERR_NotIntialized
    End If
    
    htmlhelp m_lCallerHWnd, m_sFileName & ">" & m_sWindowName, HH_DISPLAY_INDEX, 0

Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub


'*****************************************************************************************
'* Sub         : ShowSearch
'* Notes       : Displays the Search tab of the current HTML (*.chm) file.
'*****************************************************************************************
Public Sub ShowSearch()
    On Error GoTo hComponentFailure

    Dim hhftsX As HH_FTS_QUERY
        
    If Len(m_sFileName) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_NotInitialized, App.EXEName & ".CHtmlHelp", S_ERR_NotIntialized
    End If
    
    With hhftsX
        .cbStruct = Len(hhftsX)
        .fUniCodeStrings = 0&
        .pszSearchQuery = ""
        .iProximity = 0&
        .fStemmedSearch = 0&
        .fTitleOnly = 0&
        .fExecute = 1&
        .pszWindow = ""
    End With

    htmlhelp_fts m_lCallerHWnd, m_sFileName & ">" & m_sWindowName, HH_DISPLAY_SEARCH, hhftsX

Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub


'*****************************************************************************************
'* Sub         : ShowTopic
'* Notes       : Displays the specified topic from the current HTML (*.chm) file.
'*****************************************************************************************
Public Sub ShowTopic(Topic As String)
    On Error GoTo hComponentFailure
    
    If Len(m_sFileName) = 0 Then
        On Error GoTo 0
        Err.Raise eErrHtmlHelp_NotInitialized, App.EXEName & ".CHtmlHelp", S_ERR_NotIntialized
    End If
    
    htmlhelp_s m_lCallerHWnd, m_sFileName & ">" & m_sWindowName, HH_DISPLAY_TOPIC, Topic

    Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub


'*****************************************************************************************
'* Function    : FileExists
'* Notes       : API-based routine to check for a file's existence.
'*               Returns True if the specified file exists, False otherwise.
'*****************************************************************************************
Private Function FileExists(FileName As String) As Boolean
    On Error GoTo hComponentFailure
    
    Dim wfd    As WIN32_FIND_DATA
    Dim hFile  As Long
    
    FileExists = False
    
    hFile = FindFirstFile(FileName, wfd)
    If hFile <> INVALID_HANDLE_VALUE Then
        FileExists = True
        
        If FindClose(hFile) = 0 Then
            On Error GoTo 0
            Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
        End If
    End If

Exit Function

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Function

'*****************************************************************************************
'* Sub         : Class_Initialize
'* Notes       : Class data space initialization.
'*****************************************************************************************
Private Sub Class_Initialize()
    On Error GoTo hComponentFailure
    
    m_sWindowName = "PREC"

Exit Sub

hComponentFailure:
    Err.Raise eErrHtmlHelp_ComponentFailure, App.EXEName & ".CHtmlHelp", S_ERR_ComponentFailure
End Sub

' added by junwebhead
Public Sub CloseHelp()
    Call htmlhelp(0&, "", HH_CLOSE_ALL, ByVal 0&)
End Sub

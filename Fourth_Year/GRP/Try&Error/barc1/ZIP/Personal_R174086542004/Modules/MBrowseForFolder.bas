Attribute VB_Name = "MBrowseForFolder"
'*****************************************************************************************
'* Module      : MBrowseForFolder
'* Description : Module that provides the callback function for the BrowseForFolder dialog.
'* Notes       : The callback function provides the ability to pre-select a folder on the
'*               dialog's display, and to set the dialog's behavior. You have to include
'*               this module along with the CBrowseForFolder class.
'*****************************************************************************************

Option Explicit

' Private constants
Private Const MAX_PATH = 512
Private Const WM_USER = &H400
Private Const BFFM_INITIALIZED = 1
Private Const BFFM_SELECTIONCHANGED = 2
Private Const BFFM_SETSTATUSTEXTA = (WM_USER + 100)
Private Const BFFM_SETSTATUSTEXTW = (WM_USER + 104)
Private Const BFFM_SETSTATUSTEXT = BFFM_SETSTATUSTEXTA
Private Const BFFM_SETSELECTIONA As Long = (WM_USER + 102)
Private Const BFFM_SETSELECTIONW As Long = (WM_USER + 103)
Private Const BFFM_SETSELECTION = BFFM_SETSELECTIONA

' Private API function declarations
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function SHGetPathFromIDList Lib "shell32.dll" Alias "SHGetPathFromIDListA" (ByVal pidl As Long, ByVal pszPath As String) As Long


'*****************************************************************************************
'* Function    : BrowseForFolderCallback
'* Notes       : Callback (global) routine for the CBrowseForFolder class. It is used to
'*               center the dialog and to set the caption text.
'*****************************************************************************************
Public Function BrowseForFolderCallback(ByVal hwnd As Long, ByVal uMsg As Long, ByVal lParam As Long, ByVal lpData As Long) As Long
    On Error Resume Next
    
    Dim s As String
    
    Select Case uMsg
        
        Case BFFM_INITIALIZED
            ' Browse dialog box has finished initializing (lParam is NULL) so set the selection
            If lpData Then SendMessage ByVal hwnd, BFFM_SETSELECTION, ByVal True, ByVal lpData
        
        Case BFFM_SELECTIONCHANGED
            ' Selection has changed (lParam contains pidl of selected folder) so display full path if status area if enabled
            s = String$(MAX_PATH, 0)
            If SHGetPathFromIDList(lParam, s) Then
                s = Left$(s, InStr(s, vbNullChar) - 1)
            Else
                s = ""
            End If
            SendMessage ByVal hwnd, BFFM_SETSTATUSTEXT, ByVal 0&, ByVal s
        
        Case Else:
                
    End Select
    
    BrowseForFolderCallback = 0
End Function

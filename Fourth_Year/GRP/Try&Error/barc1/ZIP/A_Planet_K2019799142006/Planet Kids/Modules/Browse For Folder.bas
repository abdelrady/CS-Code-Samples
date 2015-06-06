Attribute VB_Name = "mBrowseForFolder"
Option Explicit

' --------------------------------------------------------------------------------
'   __| | __ _  ___  __ _ _ _ __ _    ___  ___  / _|_____ _  _  _ _ _ _ _ ___  ___
'  / _' |/ _' |/ __\/ _' | '_\  ' |  / __|/ _ \| |_ _   _| \/ \/ /_' | '_\ __\/ __|
' ( (_| | (_| | (__  (_| | |  (_| |  \__ \ (_) |  _| | | \      /(_| | |( (/ )\__ \
'  \__,_|\__,_|\___/\__,_|_| \__,_|  |___/\___/|_|   |_|  \_/\_/\__,_|_| \___/|___/
' --------------------------------------------------------------------------------
' Name:     mBrowseForFolder module
' Author:   Noel A. Dacara (noeldacara@hotmail.com)
' Date:     28 Feb 2006
'
' You can freely use and distribute this file with or without permission provided
' that credits herein are kept unmodified and having acknowledgements is observed.
'
' Notes:    Preselecting folder is applicable only if AllowCreate parameter will
'           set to False on the BrowseForFolders function, which means that this
'           feature is only available for old browse for folder dialog interface
'
' Inquiries or comments regarding my works and whatsoever are greatly appreciated.
' --------------------------------------------------------------------------------

' API declarations
Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal hMem As Long) ' Modified
Private Declare Function SendMessageLong Lib "user32.dll" Alias "SendMessageA" (ByVal Hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long ' Modified
    Private Const WM_USER               As Long = &H400
    Private Const BFFM_INITIALIZED      As Long = 1
    Private Const BFFM_SETSELECTIONA    As Long = (WM_USER + 102)
Private Declare Function SHBrowseForFolder Lib "shell32.dll" (ByRef lpbi As BROWSEINFO) As Long
    Private Const BIF_DONTGOBELOWDOMAIN As Long = &H2
    Private Const BIF_NEWDIALOGSTYLE    As Long = &H40
    Private Const BIF_RETURNONLYFSDIRS  As Long = &H1
    Private Const BIF_VALIDATE          As Long = &H20
    Private Type BROWSEINFO
        hOwner          As Long
        pidlRoot        As Long
        pszDisplayName  As String
        lpszTitle       As String
        ulFlags         As Long
        lpfn            As Long
        lParam          As Long
        iImage          As Long
    End Type
Private Declare Function SHGetPathFromIDList Lib "shell32.dll" (ByVal pidList As Long, ByVal lpBuffer As String) As Long
    Private Const MAX_PATH As Long = 260
Private Declare Function SHSimpleIDListFromPath Lib "shell32" Alias "#162" (ByVal szPath As String) As Long ' Undocumented

Private m_tBROWSEINFO As BROWSEINFO

#If False Then ' for debugging purpose only
    Private Sub Main()
        MsgBox BrowseForFolder(0, "Select a folder...", "C:\", True)
    End Sub
#End If

' //-- Procedure --//

Public Function BrowseForFolder( _
        Optional Hwnd As Long, _
        Optional Title, _
        Optional InitialDirectory, _
        Optional AllowCreate As Boolean) As String
        
    With m_tBROWSEINFO
        .hOwner = Hwnd
        .ulFlags = 0
        
        If (Not IsMissing(Title)) Then
            .lpszTitle = CStr(Title)
        End If
        
        If (Not IsMissing(InitialDirectory)) Then
            ' Debug.Print StrConv(CStr(InitialDirectory), vbUnicode)
            .lParam = SHSimpleIDListFromPath(StrConv(CStr(InitialDirectory), vbUnicode))
        End If
        
        If (AllowCreate) Then
            .ulFlags = BIF_NEWDIALOGSTYLE
        End If
    End With
    
    BrowseForFolder = ShowBrowserAndReturnSelection()
    
End Function

' //-- Private Procedures --//

Private Function ShowBrowserAndReturnSelection() As String
    Dim iNull   As Integer
    Dim iRet    As Long
    Dim sPath   As String
    
    With m_tBROWSEINFO
        .ulFlags = .ulFlags Or _
                    BIF_RETURNONLYFSDIRS Or _
                    BIF_DONTGOBELOWDOMAIN Or _
                    BIF_VALIDATE
                    
        .lpfn = Val(AddressOf BrowseCallbackProc)
    End With
    
    iRet = SHBrowseForFolder(m_tBROWSEINFO) ' Show the browse dialog
    
    If (iRet) Then
        sPath = String$(MAX_PATH, 0)
        
        If (SHGetPathFromIDList(iRet, sPath)) Then
            iNull = InStr(1, sPath, vbNullChar)
            
            If (iNull) Then
                ShowBrowserAndReturnSelection = Left$(sPath, iNull - 1)
            End If
        End If
        
        CoTaskMemFree iRet ' Free block of memory
    End If
    
End Function

Private Sub BrowseCallbackProc( _
        ByVal Hwnd As Long, _
        ByVal uMsg As Long, _
        ByVal lParam As Long, _
        ByVal lpData As Long)
        
    If (uMsg = BFFM_INITIALIZED) Then
        SendMessageLong Hwnd, BFFM_SETSELECTIONA, 0, lpData
    End If
    
End Sub

' Created by Noel A. Dacara | noeldacara@hotmail.com | Davao City, Philippines

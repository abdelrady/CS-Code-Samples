Attribute VB_Name = "modXPStyle"
Option Explicit

Private Type OSVERSIONINFO
    dwOSVersionInfoSize As Long
    dwMajorVersion As Long
    dwMinorVersion As Long
    dwBuildNumber As Long
    dwPlatformId As Long
    szCSDVersion As String * 128
End Type

Private Declare Function GetVersionExA Lib "kernel32" (lpVersionInformation As OSVERSIONINFO) As Integer
Private Declare Sub ExitProcess Lib "kernel32.dll" (ByVal uExitCode As Long)
Private Declare Function InitCommonControls Lib "comctl32.dll" () As Long

Private Function AppPath(ByVal zPath As String) As String
    On Error GoTo hErr
  If Right$(zPath, 1) = "\" Then AppPath = zPath Else AppPath = zPath & "\"
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Private Function FileExist(ByVal strPath As String) As Boolean
  On Local Error GoTo ErrFile
  Open strPath For Input Access Read As #1
  Close #1
  FileExist = True
  Exit Function
ErrFile:
  FileExist = False
End Function

Private Sub MakeManifest()
    On Error GoTo hErr
  Dim file$, file2$, qwe As String
  file$ = AppPath(App.Path) & App.EXEName & ".exe.MANIFEST"
  If Not FileExist(file$) Then
    qwe = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>" & vbCrLf _
        & "<assembly xmlns=""urn:schemas-microsoft-com:asm.v1"" manifestVersion=""1.0"">" & vbCrLf _
        & "<assemblyIdentity type=""win32"" processorArchitecture=""*"" version=""6.0.0.0"" name=""name""/>" & vbCrLf _
        & "<description>Enter your Description Here</description>" & vbCrLf _
        & "<dependency>" & vbCrLf _
        & "   <dependentAssembly>" & vbCrLf _
        & "      <assemblyIdentity" & vbCrLf _
        & "           type=""win32""" & vbCrLf _
        & "           name=""Microsoft.Windows.Common-Controls"" version=""6.0.0.0""" & vbCrLf _
        & "           language=""*""" & vbCrLf _
        & "           processorArchitecture=""*""" & vbCrLf _
        & "         publicKeyToken=""6595b64144ccf1df""" & vbCrLf _
        & "      />" & vbCrLf _
        & "   </dependentAssembly>" & vbCrLf _
        & "</dependency>" & vbCrLf _
        & "</assembly>" & vbCrLf
    Open file$ For Binary Access Write Lock Write As #1 Len = 1
    Put #1, , qwe
    Close #1
    SetAttr file$, vbReadOnly Or vbHidden ' Or vbSystem
    file2$ = AppPath(App.Path) & App.EXEName & ".exe"
    Shell file2$, vbNormalFocus
    ExitProcess 1
  End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
End Sub

Public Sub InitControlsXP()
    On Error GoTo hErr
    
    If IsWindowsXP = True Then
        MakeManifest
        InitCommonControls
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Function IsWindowsXP() As Boolean
    Dim osinfo As OSVERSIONINFO
    Dim retvalue As Integer
    osinfo.dwOSVersionInfoSize = 148
    osinfo.szCSDVersion = Space$(128)
    retvalue = GetVersionExA(osinfo)

    With osinfo
        Select Case .dwPlatformId
            Case 1
                'If .dwMinorVersion = 0 Then
                    'WinVersion = "Windows 95"
                'ElseIf .dwMinorVersion = 10 Then
                    'WinVersion = "Windows 98"
                'End If
                
                IsWindowsXP = False
            Case 2
                'If .dwMajorVersion = 3 Then
                    'WinVersion = "Windows NT 3.51"
                'ElseIf .dwMajorVersion = 4 Then
                    'WinVersion = "Windows NT 4.0"
                'ElseIf .dwMajorVersion >= 5 Then
                    'WinVersion = "Windows XP"
                'End If
                
                If .dwMajorVersion >= 5 Then
                    IsWindowsXP = True
                Else
                    IsWindowsXP = False
                End If
            Case Else
                'WinVersion = "Failed"
                IsWindowsXP = False
        End Select
    End With
End Function

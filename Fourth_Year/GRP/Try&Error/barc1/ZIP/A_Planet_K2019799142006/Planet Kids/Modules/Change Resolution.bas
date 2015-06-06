Attribute VB_Name = "mChangeResolution"
Option Explicit

' --------------------------------------------------------------------------------
'   __| | __ _  ___  __ _ _ _ __ _    ___  ___  / _|_____ _  _  _ _ _ _ _ ___  ___
'  / _' |/ _' |/ __\/ _' | '_\  ' |  / __|/ _ \| |_ _   _| \/ \/ /_' | '_\ __\/ __|
' ( (_| | (_| | (__  (_| | |  (_| |  \__ \ (_) |  _| | | \      /(_| | |( (/ )\__ \
'  \__,_|\__,_|\___/\__,_|_| \__,_|  |___/\___/|_|   |_|  \_/\_/\__,_|_| \___/|___/
' --------------------------------------------------------------------------------
' Name:     mChangeResolution module
' Author:   Noel A. Dacara (noeldacara@hotmail.com)
' Date:     06 September 2006
'
' You can freely use and distribute this file with or without permission provided
' that credits herein are kept unmodified and having acknowledgements is observed.
'
' Note:     You still need to manually determine when to set the display setting
'           back and forth. E.g. When the program is minimized or has lost focus
'           through Alt+Tab, Ctrl+Esc, Winkey+?, or something similar in result.
'
'           Changes to the screen resolution is temporary and will not be saved
'           to the registry, therefore, any problems like display driver failure
'           resulting to unexpected shutdown/restart, the original resolution
'           will be restored as good as it was when the system has restarted.
'
' Inquiries or comments regarding my works and whatsoever are greatly appreciated.
' --------------------------------------------------------------------------------

Private Declare Function ChangeDisplaySettingsEx Lib "user32.dll" Alias "ChangeDisplaySettingsExA" (ByVal lpszDeviceName As String, ByRef lpDevMode As DEVMODE, ByVal Hwnd As Long, ByVal dwflags As Long, ByRef lParam As Any) As Long
    Private Const CCHDEVICENAME             As Long = 32
    Private Const CCHFORMNAME               As Long = 32
    Private Const CDS_FULLSCREEN            As Long = &H4
    Private Const DISP_CHANGE_SUCCESSFUL    As Long = 0
    Private Const DM_PELSHEIGHT             As Long = &H100000
    Private Const DM_PELSWIDTH              As Long = &H80000
    Private Type DEVMODE
        dmDeviceName        As String * CCHDEVICENAME
        dmSpecVersion       As Integer
        dmDriverVersion     As Integer
        dmSize              As Integer
        dmDriverExtra       As Integer
        dmFields            As Long
        dmOrientation       As Integer
        dmPaperSize         As Integer
        dmPaperLength       As Integer
        dmPaperWidth        As Integer
        dmScale             As Integer
        dmCopies            As Integer
        dmDefaultSource     As Integer
        dmPrintQuality      As Integer
        dmColor             As Integer
        dmDuplex            As Integer
        dmYResolution       As Integer
        dmTTOption          As Integer
        dmCollate           As Integer
        dmFormName          As String * CCHFORMNAME
        dmUnusedPadding     As Integer
        dmBitsPerPel        As Integer
        dmPelsWidth         As Long
        dmPelsHeight        As Long
        dmDisplayFlags      As Long
        dmDisplayFrequency  As Long
        dmICMMethod         As Long 'NT 4.0
        dmICMIntent         As Long 'NT 4.0
        dmMediaType         As Long 'NT 4.0
        dmDitherType        As Long 'NT 4.0
        dmReserved1         As Long 'NT 4.0
        dmReserved2         As Long 'NT 4.0
        dmPanningWidth      As Long 'Win2000
        dmPanningHeight     As Long 'Win2000
    End Type

Private m_lOldScreenH As Long
Private m_lOldScreenW As Long

Public Sub RestoreScreenResolution()
    Dim TempH As Long
    Dim TempW As Long
        
        TempH = m_lOldScreenH ' Save original screen resolution
        TempW = m_lOldScreenW ' Because it will be changed when we restore it
        
        ChangeResolution TempW, TempH
        
        m_lOldScreenH = TempH ' Now let's place their values back
        m_lOldScreenW = TempW
        
End Sub

Public Function ChangeResolution(NewWidth As Long, NewHeight As Long) As Boolean
    Dim CurrentH As Long
    Dim CurrentW As Long
        
        ' Get current screen resolution
        ' So that we can compare it to the new width and height specified.
        ' In this case, we can determine if we should still continue
        ' the process even if both old and new sizes are the same.
        
        CurrentH = Screen.Height / Screen.TwipsPerPixelY
        CurrentW = Screen.Width / Screen.TwipsPerPixelX
        
    If (Not NewWidth = CurrentW) And (Not NewWidth = CurrentH) Then
        
        ' Prepare device data structure
        ' according to desired settings
        
        Dim lpDevMode As DEVMODE
            lpDevMode.dmSize = Len(lpDevMode)
            lpDevMode.dmFields = DM_PELSHEIGHT + DM_PELSWIDTH
            lpDevMode.dmPelsHeight = NewHeight
            lpDevMode.dmPelsWidth = NewWidth
            
            ' Now, let's change the display settings to what we expect;
            ' a different screen resolution while leaving other settings unchanged.
            
        Dim iRet As Long
            iRet = ChangeDisplaySettingsEx(vbNullString, lpDevMode, 0, CDS_FULLSCREEN, ByVal 0&)
            
        If (iRet = DISP_CHANGE_SUCCESSFUL) Then
            
            ' If everything went fine, then we need to save the changes
            ' So that later we can restore the screen back to its original resolution
            
            m_lOldScreenH = CurrentH
            m_lOldScreenW = CurrentW
            
            ChangeResolution = True
        End If
        
    End If
    
End Function

' Created by Noel A. Dacara | noeldacara@hotmail.com | Davao City, Philippines

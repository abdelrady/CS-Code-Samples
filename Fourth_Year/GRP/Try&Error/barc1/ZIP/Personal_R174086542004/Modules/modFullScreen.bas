Attribute VB_Name = "modFullscreen"
Option Explicit

Private Type RECT
  Left As Long
  Top As Long
  Right As Long
  Bottom As Long
End Type

Private Const GWL_STYLE = (-16)
Private Const SWP_NOMOVE = &H2
Private Const WS_CAPTION = &HC00000

Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
Private Declare Function GetWindowRect Lib "user32" (ByVal hwnd As Long, lpRect As RECT) As Long
Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Public Sub ToggleFullScreen(Frm As Form)
    On Error GoTo hErr
Dim rcWindow As RECT
Dim lRet As Long

lRet = GetWindowRect(Frm.hwnd, rcWindow)
lRet = SetWindowLong(Frm.hwnd, GWL_STYLE, GetWindowLong(Frm.hwnd, GWL_STYLE) Xor WS_CAPTION)
lRet = SetWindowPos(Frm.hwnd, 0, 0, 0, rcWindow.Right - rcWindow.Left, rcWindow.Bottom - rcWindow.Top, SWP_NOMOVE)
lRet = SetWindowPos(Frm.hwnd, 0, 0, 0, rcWindow.Right - rcWindow.Left + 1, rcWindow.Bottom - rcWindow.Top, SWP_NOMOVE)

  If Frm.WindowState = 2 Then
     Frm.WindowState = 0
  Else
     Frm.WindowState = 2
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


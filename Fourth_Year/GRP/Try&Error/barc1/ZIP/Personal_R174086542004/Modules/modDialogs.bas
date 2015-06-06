Attribute VB_Name = "modDialogs"
Option Explicit

Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias "GetOpenFileNameA" (pOpenfilename As OPENFILENAME) As Long
Private Declare Function ChooseColor Lib "comdlg32.dll" Alias "ChooseColorA" (pChoosecolor As TCHOOSECOLOR) As Long
Private Declare Function GetSaveFileName Lib "comdlg32.dll" Alias "GetSaveFileNameA" (pOpenfilename As OPENFILENAME) As Long

Private Type TCHOOSECOLOR
    lStructSize As Long
    HWndOwner As Long
    hInstance As Long
    rgbResult As Long
    lpCustColors As String
    Flags As Long
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type

Private Type OPENFILENAME
    lStructSize As Long
    HWndOwner As Long
    hInstance As Long
    lpstrFilter As String
    lpstrCustomFilter As String
    nMaxCustFilter As Long
    nFilterIndex As Long
    lpstrFile As String
    nMaxFile As Long
    lpstrFileTitle As String
    nMaxFileTitle As Long
    lpstrInitialDir As String
    lpstrTitle As String
    Flags As Long
    nFileOffset As Integer
    nFileExtension As Integer
    lpstrDefExt As String
    lCustData As Long
    lpfnHook As Long
    lpTemplateName As String
End Type

Public Function ShowOpen(AppHwnd As Long, Filter As String, Title As String, Optional StartupDirectory As String, Optional Multiple As Boolean) As String
    'On Error GoTo 0
On Error GoTo ErrorLoc
Dim OpenF As OPENFILENAME
OpenF.Flags = &H4 ' no open as readonly box
If Multiple = True Then
    OpenF.HWndOwner = AppHwnd 'set the window handle
End If
OpenF.lpstrFile = String$(500, Chr(0))
OpenF.lpstrFileTitle = String$(500, Chr(0))
OpenF.lpstrFilter = Filter
OpenF.lpstrTitle = Title
OpenF.lpstrInitialDir = StartupDirectory
OpenF.lStructSize = Len(OpenF)
OpenF.nMaxFile = 501
OpenF.nMaxFileTitle = 501
If GetOpenFileName(OpenF) Then
    ShowOpen = Replace(OpenF.lpstrFile, Chr(0), "")
Else
ErrorLoc:
    ShowOpen = "0" 'No file error
End If
End Function

Public Function ShowSave(AppHwnd As Long, Filter As String, Title As String, Optional StartupDirectory As String, Optional Multiple As Boolean) As String
    'On Error GoTo 0
On Error GoTo ErrorLoc
Dim SaveF As OPENFILENAME
SaveF.Flags = &H2 Or &H4 'Prompt on overwrite, no read only box
If Multiple = False Then
    SaveF.HWndOwner = AppHwnd
End If
SaveF.lpstrFile = String$(500, Chr(0))
SaveF.lpstrFileTitle = String$(500, Chr(0))
SaveF.lpstrFilter = Filter
SaveF.lpstrDefExt = Right$(Filter, 3)
SaveF.lpstrTitle = Title
SaveF.lpstrInitialDir = StartupDirectory
SaveF.lStructSize = Len(SaveF)
SaveF.nMaxFile = 501
SaveF.nMaxFileTitle = 501
If GetSaveFileName(SaveF) Then
    ShowSave = Replace(SaveF.lpstrFile, Chr(0), "")
Else
ErrorLoc:
    ShowSave = "0" 'Error no file
End If
End Function

Public Property Get GetColor(Optional AppHwnd As Long = 0, Optional Multiple As Boolean) As Long
    'On Error GoTo 0
Dim Color As TCHOOSECOLOR
Color.Flags = 2 'Show full box includes custom
If Multiple = False Then 'If they only want one opened at a time give it an hwnd
    Color.HWndOwner = AppHwnd 'when skipped program will keep focus
End If
Color.lStructSize = Len(Color)
Color.lpCustColors = 100
If ChooseColor(Color) <> 0 Then
    GetColor = Color.rgbResult 'Set GetColor to the long value despite it saying rgb
Else
    GetColor = -1 'Not 0 because then it would be though black not an error
End If
End Property




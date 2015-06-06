Attribute VB_Name = "mMCIWnd"
'******************************************************
'PLAYAVI PROJECT
'by Ray Mercer <raymer@macnica.co.jp>
'7/23/98
'playavi.frm
'playavi.vbp
'mciWnd.bas
'SIMPLE DEMO OF USING Win32 MCIWnd directly functions from VB
'Copyright 1998, Ray Mercer, All Rights Reserved
'*******************************************************
Option Explicit

'Private Type WNDCLASSEX
'    cbSize As Long
'    style As Long
'    lpfnWndProc As Long
'    cbClsExtra As Long
'    cbWndExtra As Long
'    hInstance As Long
'    hIcon As Long
'    hCursor As Long
'    hbrBackground As Long
'    lpszMenuName As String
'    lpszClassName As String
'    hIconSm As Long
'End Type
'Declare Function RegisterClassEx Lib "user32" (wcx As WNDCLASSEX) As Long
Declare Function CreateWindowExAsString Lib "user32" Alias "CreateWindowExA" (ByVal dwExStyle As Long, _
                                ByVal lpClassName As String, _
                                ByVal lpWindowName As String, _
                                ByVal dwStyle As Long, _
                                ByVal x As Long, _
                                ByVal y As Long, _
                                ByVal nWidth As Long, _
                                ByVal nHeight As Long, _
                                ByVal hWndParent As Long, _
                                ByVal hMenu As Long, _
                                ByVal hInstance As Long, _
                                ByVal lpParam As String) As Long

Declare Function MCIWndRegisterClass Lib "Msvfw32.dll" () As Long
Declare Function DestroyWindow Lib "user32" (ByVal hwnd As Long) As Long

'following simpler function doesn't work - was it compiled (BY MS!) using _cdecl
'in msvfw32.dll ???
'*If this is callable from VB, I'd love to hear about it*
'Declare Function MCIWndCreateA Lib "Msvfw32.dll" (ByVal hWndParent As Long, _
'                ByVal hInstance As Long, _
'                ByVal dwStyle As Long, _
'                ByVal szFile As String) As Long
                
Declare Function SendMessageAsString Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, _
                ByVal wMsg As Long, _
                ByVal wParam As Long, _
                ByVal lParam As String) As Long


'MISC STUFF FROM VFW.H
' Flags for the MCIWndOpen command
'Public Const MCIWNDOPENF_NEW = &H1&                 ' open a new file
' window styles
'Public Const MCIWNDF_NOAUTOSIZEWINDOW = &H1        ' when movie size changes
'Public Const MCIWNDF_NOPLAYBAR = &H2               ' no toolbar
'Public Const MCIWNDF_NOAUTOSIZEMOVIE = &H4         ' when window size changes
Public Const MCIWNDF_NOMENU = &H8                  ' no popup menu from RBUTTONDOWN
'Public Const MCIWNDF_SHOWNAME = &H10               ' show name in caption
'Public Const MCIWNDF_SHOWPOS = &H20                ' show position in caption
'Public Const MCIWNDF_SHOWMODE = &H40               ' show mode in caption
Public Const MCIWNDF_SHOWALL = &H70                ' show all
'Public Const MCIWNDF_NOTIFYMODE = &H100           ' tell parent of mode change
'Public Const MCIWNDF_NOTIFYPOS = &H200            ' tell parent of pos change
'Public Const MCIWNDF_NOTIFYSIZE = &H400           ' tell parent of size change
'Public Const MCIWNDF_NOTIFYERROR = &H1000         ' tell parent of an error
Public Const MCIWNDF_NOTIFYALL = &H1F00           ' tell all
'Public Const MCIWNDF_NOTIFYANSI = &H80
Public Const WS_BORDER = &H800000
'Public Const WS_CAPTION = &HC00000
'Public Const WS_SYSMENU = &H80000
Public Const WS_CHILD = &H40000000
Public Const WS_VISIBLE = &H10000000
'Public Const WS_OVERLAPPED = &H0&
'Public Const WS_MINIMIZEBOX = &H20000
'Public Const WS_MAXIMIZEBOX = &H10000
'Public Const WS_THICKFRAME = &H40000
'Public Const WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED Or WS_CAPTION Or WS_SYSMENU Or WS_THICKFRAME Or WS_MINIMIZEBOX Or WS_MAXIMIZEBOX)
'Public Const SWP_NOMOVE = &H2
'Public Const SWP_NOSIZE = 1
'Public Const SWP_NOZORDER = &H4
'Public Const HWND_BOTTOM = 1
'Public Const HWND_TOPMOST = -1
'Public Const HWND_NOTOPMOST = -2
'Public Const MCIWNDF_NOTIFYMEDIA = &H880&         ' tell parent of media change
'Public Const MCIWNDF_RECORD = &H2000&               ' Give a record button
'Public Const MCIWNDF_NOERRORDLG = &H4000&           ' Show Error Dlgs for MCI cmds?
Public Const MCIWNDF_NOOPEN = &H8000&           ' Don't allow user to open things

'WINDOW MESSAGES
Public Const WM_USER = &H400
Public Const MCIWNDM_OPEN = (WM_USER + 153)
Public Const MCIWNDM_SENDSTRING = (WM_USER + 101)


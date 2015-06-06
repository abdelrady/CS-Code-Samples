VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cFormAppearance"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' --------------------------------------------------------------------------------
'   __| | __ _  ___  __ _ _ _ __ _    ___  ___  / _|_____ _  _  _ _ _ _ _ ___  ___
'  / _' |/ _' |/ __\/ _' | '_\  ' |  / __|/ _ \| |_ _   _| \/ \/ /_' | '_\ __\/ __|
' ( (_| | (_| | (__  (_| | |  (_| |  \__ \ (_) |  _| | | \      /(_| | |( (/ )\__ \
'  \__,_|\__,_|\___/\__,_|_| \__,_|  |___/\___/|_|   |_|  \_/\_/\__,_|_| \___/|___/
' --------------------------------------------------------------------------------
' Name:     cFormAppearance class
' Author:   Noel A. Dacara (noeldacara@hotmail.com)
' Date:     28 Feb 2006
'
' You can freely use and distribute this file with or without permission provided
' that credits herein are kept unmodified and having acknowledgements is observed.
'
' Inquiries or comments regarding my works and whatsoever are greatly appreciated.
' --------------------------------------------------------------------------------

' Menu Operations
'Private Declare Function GetMenuItemCount Lib "user32.dll" (ByVal hMenu As Long) As Long
'Private Declare Function GetMenuItemID Lib "user32.dll" (ByVal hMenu As Long, ByVal nPos As Long) As Long
'Private Declare Function GetMenuItemInfo Lib "user32.dll" Alias "GetMenuItemInfoA" (ByVal hMenu As Long, ByVal un As Long, ByVal b As Boolean, ByRef lpMenuItemInfo As MENUITEMINFO) As Long
'    Private Type MENUITEMINFO
'        cbSize          As Long
'        fMask           As Long
'        fType           As Long
'        fState          As Long
'        wID             As Long
'        hSubMenu        As Long
'        hbmpChecked     As Long
'        hbmpUnchecked   As Long
'        dwItemData      As Long
'        dwTypeData      As String
'        cch             As Long
'    End Type
'    Private Const HIGHBIT               As Long = &H8000&
'    Private Const MAX_COLUMN_NAME_LEN   As Long = 80
'    Private Const MF_ENABLED            As Long = &H0&
'    Private Const MF_GRAYED             As Long = &H1&
'    Private Const MIIM_DATA             As Long = &H20
'    Private Const MIIM_ID               As Long = &H2
'    Private Const MIIM_STATE            As Long = &H1
'    Private Const MIIM_SUBMENU          As Long = &H4
'    Private Const MIIM_TYPE             As Long = &H10
'    Private Const MIIM_FLAGS            As Long = MIIM_DATA Or MIIM_ID Or MIIM_STATE Or MIIM_TYPE
'    Private Const SC_CLOSE              As Long = &HF060&
'    Private Const SC_MAXIMIZE           As Long = &HF030&
'    Private Const SC_MINIMIZE           As Long = &HF020&
'    Private Const SC_MOVE               As Long = &HF010&
'    Private Const SC_RESTORE            As Long = &HF120&
'    Private Const SC_SIZE               As Long = &HF000&
'Private Declare Function GetSystemMenu Lib "user32.dll" (ByVal Hwnd As Long, ByVal bRevert As Long) As Long
'Private Declare Function RemoveMenu Lib "user32.dll" (ByVal hMenu As Long, ByVal nPosition As Long, ByVal wFlags As Long) As Long
'Private Declare Function SetMenuItemInfo Lib "user32.dll" Alias "SetMenuItemInfoA" (ByVal hMenu As Long, ByVal un As Long, ByVal bool As Boolean, ByRef lpcMenuItemInfo As MENUITEMINFO) As Long
'
'' Determines where to show the system menu
'Private Declare Function ClientToScreen Lib "user32.dll" (ByVal Hwnd As Long, ByRef lpPoint As POINTAPI) As Long
'    Private Type POINTAPI
'        X As Long
'        Y As Long
'    End Type
'Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As POINTAPI) As Long
'
'' Window Processing
Private Declare Function GetWindowLong Lib "user32.dll" Alias "GetWindowLongA" (ByVal Hwnd As Long, ByVal nIndex As Long) As Long
    Private Const WS_CAPTION            As Long = &HC00000
'    Private Const WS_EX_APPWINDOW       As Long = &H40000
'    Private Const WS_EX_CONTEXTHELP     As Long = &H400&
'    Private Const WS_EX_TOOLWINDOW      As Long = &H80&
'    Private Const WS_EX_TOPMOST         As Long = &H8&
'    Private Const WS_MAXIMIZEBOX        As Long = &H10000
'    Private Const WS_MINIMIZEBOX        As Long = &H20000
'    Private Const WS_SYSMENU            As Long = &H80000
'    Private Const WS_THICKFRAME         As Long = &H40000
'Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal Hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByRef lParam As Any) As Long
'    Private Const WM_GETSYSMENU         As Long = &H313 ' Undocumented
Private Declare Function SetWindowLong Lib "user32.dll" Alias "SetWindowLongA" (ByVal Hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
'    Private Const GWL_EXSTYLE           As Long = -20
    Private Const GWL_STYLE             As Long = -16
Private Declare Function SetWindowPos Lib "user32.dll" (ByVal Hwnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Const HWND_NOTOPMOST        As Long = -2
    Private Const HWND_TOPMOST          As Long = -1
    Private Const SWP_FRAMECHANGED      As Long = &H20
    Private Const SWP_NOMOVE            As Long = &H2
    Private Const SWP_NOSIZE            As Long = &H1
    Private Const SWP_NOZORDER          As Long = &H4
    Private Const SWP_FLAGS             As Long = SWP_FRAMECHANGED Or SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOZORDER
'Private Declare Function ShowWindow Lib "user32.dll" (ByVal Hwnd As Long, ByVal nCmdShow As Long) As Long
'    Private Const SW_HIDE               As Long = 0
'    Private Const SW_SHOWNORMAL         As Long = 1

Private m_lClientHwnd As Long

' //-- Properties --//

Public Property Set Client(Object As Form)
Attribute Client.VB_Description = "Sets the client form to be used by the class."
'Sets the client form to be used by the class.
    m_lClientHwnd = Object.Hwnd
    
End Property

'Public Property Get CloseButton() As Boolean
''Returns/sets the state of the Close button located in the titlebar and system menu.
'    Dim lMenu   As Long
'    Dim lMPos   As Long
'        lMenu = GetSystemMenu(m_lClientHwnd, False)
'        lMPos = GetMenuItemPos(SC_CLOSE)
'
'    CloseButton = (GetMenuItemState(lMenu, lMPos) = MF_ENABLED)
'
'End Property
'
'Public Property Let CloseButton(Value As Boolean)
'    SystemMenus SC_CLOSE, Value
'    Redraw ' Redraw window
'
'End Property
'
'Public Property Get ControlBox() As Boolean
''Returns/sets whether to display or hide titlebar buttons and controls.
'    ControlBox = (Style And WS_SYSMENU)
'
'End Property
'
'Public Property Let ControlBox(Value As Boolean)
'    ToggleStyles WS_SYSMENU, Value
'
'End Property
'
'Public Property Get Hwnd() As Long
''Returns/sets the handle of the form to be used.
'    Hwnd = m_lClientHwnd
'
'End Property
'
'Public Property Let Hwnd(Value As Long)
'    m_lClientHwnd = Value
'
'End Property
'
'Public Property Get MaximizeButton() As Boolean
''Returns/sets the state of the Maximize button located in the titlebar and system menu.
'    MaximizeButton = (Style And WS_MAXIMIZEBOX)
'
'End Property
'
'Public Property Let MaximizeButton(Value As Boolean)
'    ToggleStyles WS_MAXIMIZEBOX, Value
'    SystemMenus SC_MAXIMIZE, Value
'
'End Property
'
'Public Property Get MinimizeButton() As Boolean
''Returns/sets the state of the Minimize button located in the titlebar and system menu.
'    MinimizeButton = (Style And WS_MINIMIZEBOX)
'
'End Property
'
'Public Property Let MinimizeButton(Value As Boolean)
'    ToggleStyles WS_MINIMIZEBOX, Value
'    SystemMenus SC_MINIMIZE, Value
'
'End Property
'
'Public Property Get Moveable() As Boolean
''Returns/sets whether the client window will be moveable or not.
'    Dim lMenu   As Long
'    Dim lMPos   As Long
'        lMenu = GetSystemMenu(m_lClientHwnd, False)
'        lMPos = GetMenuItemPos(SC_MOVE)
'
'    Moveable = (GetMenuItemState(lMenu, lMPos) = MF_ENABLED)
'
'End Property
'
'Public Property Let Moveable(Value As Boolean)
'    SystemMenus SC_MOVE, Value
'
'End Property
'
'Public Property Get Sizeable() As Boolean
''Returns/sets whether the client window can be resized or not.
'    Sizeable = (Style And WS_THICKFRAME)
'
'End Property
'
'Public Property Let Sizeable(Value As Boolean)
'    SystemMenus SC_SIZE, Value
'    ToggleStyles WS_THICKFRAME, Value
'
'End Property
'
'Public Property Get ShowInTaskbar() As Boolean
''Returns/sets whether the client window is shown is taskbar or not.
'    ShowInTaskbar = (Style(True) And WS_EX_APPWINDOW)
'
'End Property
'
'Public Property Let ShowInTaskbar(Value As Boolean)
'    If (m_lClientHwnd) Then
'        ShowWindow m_lClientHwnd, SW_HIDE
'        ToggleStyles WS_EX_APPWINDOW, Value, True
'        ShowWindow m_lClientHwnd, SW_SHOWNORMAL
'    End If
'
'End Property
'
Public Property Get Titlebar() As Boolean
Attribute Titlebar.VB_Description = "Returns/sets whether the titlebar is displayed in the client's window."
'Returns/sets whether the titlebar is displayed in the client's window.
    Titlebar = (Style And WS_CAPTION)
    
End Property

Public Property Let Titlebar(Value As Boolean)
    ToggleStyles WS_CAPTION, Value
    
End Property
'
'Public Property Get ToolWindow() As Boolean
''Returns/sets whethere the client window will be in a ToolWindow style.
'    ToolWindow = (Style(True) And WS_EX_TOOLWINDOW)
'
'End Property
'
'Public Property Let ToolWindow(Value As Boolean)
'    ToggleStyles WS_EX_TOOLWINDOW, Value, True
'
'End Property
'
'Public Property Get TopMost() As Boolean
''Returns/sets whether the client window will be always on top of other windows.
'    TopMost = (Style(True) And WS_EX_TOPMOST)
'
'End Property
'
'Public Property Let TopMost(Value As Boolean)
'    If (m_lClientHwnd) Then
'        If (Value) Then
'            SetWindowPos m_lClientHwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
'        Else
'            SetWindowPos m_lClientHwnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
'        End If
'    End If
'
'End Property
'
'Public Property Get WhatsThisButton() As Boolean
''Returns/sets whether the Help button will be displayed in the titlebar.
'    WhatsThisButton = (Style(True) And WS_EX_CONTEXTHELP)
'
'End Property
'
'Public Property Let WhatsThisButton(Value As Boolean)
'    ToggleStyles WS_EX_CONTEXTHELP, Value, True
'
'End Property

' //-- Public Procedures --//

Public Sub Redraw()
Attribute Redraw.VB_Description = "Redraw client window display."
'Redraw client window display.
    If (m_lClientHwnd) Then
        SetWindowPos m_lClientHwnd, 0, 0, 0, 0, 0, SWP_FLAGS
    End If

End Sub

'Public Sub ShowSystemMenu(Optional OnCursorPosition As Boolean, Optional PixelX As Long, Optional PixelY As Long)
''Shows the system menu on the specified coordinates or current cursor position.
''   If OnCursorPosition is set, PixelX and PixelY arguments are ignored.
''   If all arguments are not specified, the system menu is displayed on the usual top-left portion of the window.
'    If (m_lClientHwnd) Then
'        Dim lpPoint As POINTAPI
'
'        If (OnCursorPosition) Then
'            GetCursorPos lpPoint
'            PixelX = lpPoint.X
'            PixelY = lpPoint.Y
'        Else
'            lpPoint.X = PixelX ' Setup points
'            lpPoint.Y = PixelY
'            ClientToScreen m_lClientHwnd, lpPoint
'            PixelX = lpPoint.X
'            PixelY = lpPoint.Y
'        End If
'
'        SendMessage m_lClientHwnd, WM_GETSYSMENU, 0, ByVal LongConvert(PixelX, PixelY)
'    End If
'
'End Sub
'
'' //-- Private Procedures --//
'
'Private Function GetMenuItemPos(hMenu As Long) As Long
'    GetMenuItemPos = -1 ' Default return value incase of errors
'
'    If (m_lClientHwnd) Then
'        On Error GoTo Err_Handler
'
'        Dim i       As Long
'        Dim lMnID   As Long
'        Dim lMCnt   As Long
'        Dim lMenu   As Long
'            lMenu = GetSystemMenu(m_lClientHwnd, False) ' Get system menu handle
'            lMCnt = GetMenuItemCount(lMenu) - 1
'
'        Do While i <= lMCnt
'
'            lMnID = GetMenuItemID(lMenu, i)
'
'            If (lMnID = hMenu) Then ' Item is found
'                GetMenuItemPos = i
'                Exit Do
'            ElseIf (lMnID = (hMenu And Not HIGHBIT)) Then ' Item is disabled
'                GetMenuItemPos = i
'                Exit Do
'            End If
'
'            i = i + 1
'        Loop
'    End If
'
'Err_Handler:
'End Function
'
'Private Function GetMenuItemState(hMenu As Long, Position As Long) As Long
'    Dim tMENU As MENUITEMINFO
'        tMENU.cbSize = Len(tMENU)
'        tMENU.fMask = MIIM_STATE
'
'    If (GetMenuItemInfo(hMenu, Position, True, tMENU)) Then
'        GetMenuItemState = tMENU.fState
'    End If
'
'End Function
'
'Private Function LongConvert(ByVal Low As Long, ByVal High As Long) As Long
''   High word is coerced to Long to allow it to overflow which shifts it left.
'    LongConvert = (High * &H10000) Or (Low And &HFFFF&)
'
'End Function
'
'Private Sub SystemMenus(hMenu As Long, Optional Enable As Boolean)
'    If (m_lClientHwnd) Then
'        Dim dwMsgID As Long
'
'        Dim lMenu As Long
'        Dim lMPos As Long
'        Dim tMENU As MENUITEMINFO
'            lMenu = GetSystemMenu(m_lClientHwnd, False)
'            lMPos = GetMenuItemPos(hMenu)
'
'        If (lMPos >= 0) Then
'            With tMENU
'                .cbSize = Len(tMENU) ' Initialize menuitem structure
'                .fMask = MIIM_FLAGS
'                .dwTypeData = String$(MAX_COLUMN_NAME_LEN, 0)
'                .cch = MAX_COLUMN_NAME_LEN
'            End With
'
'            If (GetMenuItemInfo(lMenu, lMPos, True, tMENU)) Then
'                If (Enable = True) Then
'                   tMENU.fState = MF_ENABLED
'                   tMENU.wID = hMenu
'                Else
'                   tMENU.fState = MF_GRAYED
'                   tMENU.wID = hMenu And (Not HIGHBIT)
'                End If
'
'                tMENU.fMask = MIIM_STATE Or MIIM_ID
'
'                SetMenuItemInfo lMenu, lMPos, True, tMENU
'            End If
'        End If
'    End If
'
'End Sub

Private Function Style(Optional Extended As Boolean) As Long
    If (m_lClientHwnd) Then
'        If (Extended) Then
'            Style = GetWindowLong(m_lClientHwnd, GWL_EXSTYLE)
'        Else
            Style = GetWindowLong(m_lClientHwnd, GWL_STYLE)
'        End If
    End If
    
End Function

Private Sub ToggleStyles(WS_FLAG As Long, Value As Boolean, Optional Extended As Boolean)
    If (m_lClientHwnd) Then
        Dim dwNewLong As Long
        
'        If (Extended) Then
'            dwNewLong = GetWindowLong(m_lClientHwnd, GWL_EXSTYLE)
'        Else
            dwNewLong = GetWindowLong(m_lClientHwnd, GWL_STYLE)
'        End If
        
        If (Value) Then
            dwNewLong = dwNewLong Or WS_FLAG
        Else
            dwNewLong = dwNewLong And (Not WS_FLAG)
        End If
        
'        If (Extended) Then
'            SetWindowLong m_lClientHwnd, GWL_EXSTYLE, dwNewLong
'        Else
            SetWindowLong m_lClientHwnd, GWL_STYLE, dwNewLong
'        End If

        Redraw ' Update window display
    End If
    
End Sub

' Created by Noel A. Dacara | noeldacara@hotmail.com | Davao City, Philippines

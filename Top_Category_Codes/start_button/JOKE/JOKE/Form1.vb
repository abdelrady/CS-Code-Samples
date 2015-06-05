Public Class Form1

#Region "HA HA"

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As IntPtr
    Private Declare Function SetWindowText Lib "user32" Alias "SetWindowTextA" (ByVal hWnd As IntPtr, ByVal lpString As String) As Boolean
    Private Declare Function EnableWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Integer
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hWnd As IntPtr, ByVal lpString As String, ByVal nMaxCount As Integer) As Integer
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_LBUTTONUP As Integer = &H202
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 5
    Private Const SW_MINIMIZE As Integer = 6
    Private Const SW_MAXIMIZE As Integer = 3
    Private Const SW_RESTORE As Integer = 9

    Public Shared Sub PopupStartMenu()
        Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim StartButton As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "Button", Nothing)
        SendMessage(StartButton, WM_LBUTTONDOWN, 0, 0)
        SendMessage(StartButton, WM_LBUTTONUP, 0, 0)
    End Sub

    Public Shared Sub CloseStartMenu()
    End Sub

    Public Shared Sub ShowStartButton()
        'ovo prikazuje start dugme
        Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim StartButton As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "Button", Nothing)
        ShowWindow(StartButton, SW_SHOW)
    End Sub

    Public Shared Sub HideStartButton()
        'ovo krije start dugme
        Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim StartButton As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "Button", Nothing)
        ShowWindow(StartButton, SW_HIDE)
    End Sub

    Public Shared Sub ShowClock()
        Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim Systray As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "TrayNotifyWnd", Nothing)
        Dim Clock As IntPtr = FindWindowEx(Systray, IntPtr.Zero, "TrayClockWClass", Nothing)
        ShowWindow(Clock, SW_SHOW)
    End Sub

    Public Shared Sub HideClock()
        Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", vbNullString)
        Dim Systray As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "TrayNotifyWnd", Nothing)
        Dim Clock As IntPtr = FindWindowEx(Systray, IntPtr.Zero, "TrayClockWClass", vbNullString)
        ShowWindow(Clock, SW_HIDE)
    End Sub

    Public Shared Property StartButtonText() As String
        Get
            Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
            Dim StartButton As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "Button", Nothing)
            Dim WindowText As String = Space(256)
            GetWindowText(StartButton, WindowText, Len(WindowText))
            WindowText = WindowText.Trim
            WindowText = WindowText.Substring(0, WindowText.Length - 1)
            Return WindowText
        End Get
        Set(ByVal Value As String)
            Dim Taskbar As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
            Dim StartButton As IntPtr = FindWindowEx(Taskbar, IntPtr.Zero, "Button", Nothing)
            SetWindowText(StartButton, Value)
            EnableWindow(StartButton, False)
            EnableWindow(StartButton, True)
        End Set
    End Property

    Public Shared Sub DisableTaskBar()
        Dim Taskbar As IntPtr
        Taskbar = FindWindow("Shell_TrayWnd", Nothing)
        Call EnableWindow(Taskbar, False)
    End Sub

    Public Shared Sub EnableTaskBar()
        Dim Taskbar As IntPtr
        Taskbar = FindWindow("Shell_TrayWnd", Nothing)
        Call EnableWindow(Taskbar, True)
    End Sub

#End Region

#Region "BUTTONS"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HideStartButton()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowStartButton()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        StartButtonText = TextBox1.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DisableTaskBar()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        EnableTaskBar()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        HideClock()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ShowClock()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToLongDateString & "   " & DateTime.Now.ToLongTimeString
    End Sub

#End Region

End Class

Option Strict Off
Option Explicit On 

Friend Class Form1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.Container
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cmdRed As System.Windows.Forms.Button
	Public WithEvents cmdYellow As System.Windows.Forms.Button
	Public WithEvents cmdGreen As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Picture1 = New System.Windows.Forms.PictureBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.cmdRed = New System.Windows.Forms.Button
		Me.cmdYellow = New System.Windows.Forms.Button
		Me.cmdGreen = New System.Windows.Forms.Button
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "System Tray Icon Chooser"
		Me.ClientSize = New System.Drawing.Size(356, 178)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form1"
		Me.Picture1.Size = New System.Drawing.Size(353, 129)
		Me.Picture1.Location = New System.Drawing.Point(0, 48)
		Me.Picture1.TabIndex = 4
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.BackColor = System.Drawing.SystemColors.Control
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Balloon"
		Me.Command1.Size = New System.Drawing.Size(81, 33)
		Me.Command1.Location = New System.Drawing.Point(272, 8)
		Me.Command1.TabIndex = 3
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.cmdRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRed.Text = "Red"
		Me.cmdRed.Size = New System.Drawing.Size(81, 33)
		Me.cmdRed.Location = New System.Drawing.Point(184, 8)
		Me.cmdRed.TabIndex = 2
		Me.cmdRed.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRed.CausesValidation = True
		Me.cmdRed.Enabled = True
		Me.cmdRed.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRed.TabStop = True
		Me.cmdRed.Name = "cmdRed"
		Me.cmdYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdYellow.Text = "Yellow"
		Me.cmdYellow.Size = New System.Drawing.Size(81, 33)
		Me.cmdYellow.Location = New System.Drawing.Point(96, 8)
		Me.cmdYellow.TabIndex = 1
		Me.cmdYellow.BackColor = System.Drawing.SystemColors.Control
		Me.cmdYellow.CausesValidation = True
		Me.cmdYellow.Enabled = True
		Me.cmdYellow.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdYellow.TabStop = True
		Me.cmdYellow.Name = "cmdYellow"
		Me.cmdGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGreen.Text = "Green"
		Me.cmdGreen.Size = New System.Drawing.Size(81, 33)
		Me.cmdGreen.Location = New System.Drawing.Point(8, 8)
		Me.cmdGreen.TabIndex = 0
		Me.cmdGreen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGreen.CausesValidation = True
		Me.cmdGreen.Enabled = True
		Me.cmdGreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGreen.TabStop = True
		Me.cmdGreen.Name = "cmdGreen"
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(cmdRed)
		Me.Controls.Add(cmdYellow)
		Me.Controls.Add(cmdGreen)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form1
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form1
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form1()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
    Private WithEvents sysTray As sysTrayCls

	Private Sub cmdGreen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGreen.Click
        sysTray.UpdateIcon(VB6.GetPath & "\Trffc10a.ico")
	End Sub
    Private Sub cmdRed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRed.Click
        sysTray.UpdateIcon(VB6.GetPath & "\Trffc10c.ico")
    End Sub
    Private Sub cmdYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdYellow.Click
        Call sysTray.UpdateIcon(VB6.GetPath & "\Trffc10b.ico")
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Call sysTray.ShowBalloon("Hello", &H1S, "www.braxtel.com")
    End Sub
    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        sysTray = New SysTrayCls()
        Call sysTray.CreateIcon(VB6.GetPath & "\Trffc10c.ico", "My Icon")
    End Sub
    Private Sub Form1_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Call sysTray.DeleteIcon()
    End Sub
    Private Sub sysTray_balloonClick() Handles sysTray.BalloonClick
        '
        Console.WriteLine("sysTray_balloonClick")
    End Sub
    Private Sub sysTray_balloonHide() Handles sysTray.BalloonHide
        '
        Console.WriteLine("sysTray_balloonHide")
    End Sub
    Private Sub sysTray_balloonShow() Handles sysTray.BalloonShow
        '
        Console.WriteLine("sysTray_balloonShow")
    End Sub
    Private Sub sysTray_balloonTimeout() Handles sysTray.BalloonTimeout
        '
        Console.WriteLine("sysTray_balloonTimeout")
    End Sub
    Private Sub sysTray_ButtonDown(ByVal Button As Short) Handles sysTray.ButtonDown
        '
        Console.WriteLine("sysTray_ButtonDown")
    End Sub
    Private Sub sysTray_ButtonUp(ByVal Button As Short) Handles sysTray.ButtonUp
        '
        Console.WriteLine("sysTray_ButtonUp")
    End Sub
    Private Sub sysTray_DblClick(ByVal Button As Short) Handles sysTray.DblClick
        '
        Console.WriteLine("sysTray_DblClick")
    End Sub
    Private Sub sysTray_MouseMove(ByVal x As Integer, ByVal Y As Integer) Handles sysTray.MouseMove
        '
        Console.WriteLine("sysTray_MouseMove" & x, Y)
    End Sub
End Class
Public Class SysTrayCls
#Region "Classes"
    Public Class Window
#Region "Contants"
        Private Const WS_OVERLAPPED As Integer = &H0
#End Region
#Region "Structs"
        Private Structure CREATESTRUCT
            Dim lpCreateParams As Integer
            Dim hInstance As Integer
            Dim hMenu As Integer
            Dim hWndParent As Integer
            Dim cy As Integer
            Dim cx As Integer
            Dim y As Integer
            Dim x As Integer
            Dim style As Integer
            Dim lpszName As String
            Dim lpszClass As String
            Dim ExStyle As Integer
        End Structure
        Private Structure WNDCLASS
            Dim style As Integer
            Dim lpfnwndproc As Callback
            Dim cbClsextra As Integer
            Dim cbWndExtra2 As Integer
            Dim hInstance As Integer
            Dim hIcon As Integer
            Dim hCursor As Integer
            Dim hbrBackground As Integer
            Dim lpszMenuName As String
            Dim lpszClassName As String
        End Structure
#End Region
#Region "Delegates"
        Public Delegate Function Callback(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
#End Region
#Region "API Calls"
        Private Declare Function RegisterClass Lib "user32" Alias "RegisterClassA" (ByRef Class_Renamed As WNDCLASS) As Integer
        Private Declare Function UnregisterClass Lib "user32" Alias "UnregisterClassA" (ByVal lpClassName As String, ByVal hInstance As Integer) As Integer
        Private Declare Function CreateWindowEx Lib "user32" Alias "CreateWindowExA" (ByVal dwExStyle As Integer, ByVal lpClassName As String, ByVal lpWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWndParent As Integer, ByVal hMenu As Integer, ByVal hInstance As Integer, ByRef lpParam As CREATESTRUCT) As Integer
        Private Declare Function DestroyWindow Lib "user32" (ByVal hWnd As Integer) As Integer
        Private Declare Function DefWindowProc Lib "user32" Alias "DefWindowProcA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
#End Region
#Region "Events"
        Public Event Incomming(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
        Public Event Error_Renamed(ByVal ErrNum As Integer, ByVal ErrDesc As String)
#End Region
#Region "Globals"
        Private WndCls As WNDCLASS

        Public myhWnd As Integer
        Public Message As Integer
        Public M_TaskbarRestart As Integer
#End Region
#Region "Functions"
        Public Function HookWindow() As Object
            On Error Goto ErrorHandler

            Dim CS As CREATESTRUCT

            myhWnd = CreateWindowEx(0, WndCls.lpszClassName, "MyWindow", WS_OVERLAPPED, 0, 0, 0, 0, 0, 0, VB6.GetHInstance.ToInt32, CS)
            Exit Function
ErrorHandler:
            RaiseEvent Error_Renamed(Err.Number, Err.Description)
        End Function
        Public Function UnHookWindow() As Object
            On Error Goto ErrorHandler

            ' Remove Window
            Call DestroyWindow(myhWnd)

            myhWnd = 0 ' Reset Window handle
            Exit Function
ErrorHandler:
            RaiseEvent Error_Renamed(Err.Number, Err.Description)
        End Function
        Public Function RetEvent(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
            On Error Goto ErrorHandler
            RaiseEvent Incomming(hWnd, uMsg, wParam, lParam) ' Send call back information to parent class
            RetEvent = DefWindowProc(hWnd, uMsg, wParam, lParam)
            Exit Function
ErrorHandler:
            RaiseEvent Error_Renamed(Err.Number, Err.Description)
        End Function
#End Region
#Region "Procedures"
        Protected Overrides Sub Finalize()
            On Error Goto ErrorHandler

            ' Remove Window
            If myhWnd <> 0 Then Call DestroyWindow(myhWnd)

            ' Remove Window Class
            Call UnregisterClass(WndCls.lpszClassName, VB6.GetHInstance.ToInt32)
            MyBase.Finalize()
            Exit Sub
ErrorHandler:
            RaiseEvent Error_Renamed(Err.Number, Err.Description)
        End Sub
        Public Sub New()
            MyBase.New()

            On Error Goto ErrorHandler
            ' Register Window Class
            WndCls.hInstance = VB6.GetHInstance.ToInt32
            WndCls.lpfnwndproc = AddressOf RetEvent

            WndCls.lpszClassName = "clsCallBackWindow"

            Call RegisterClass(WndCls)
            Exit Sub
ErrorHandler:
            RaiseEvent Error_Renamed(Err.Number, Err.Description)
        End Sub
#End Region
    End Class
#End Region
#Region "Enumerations"
    Public Enum Icon_Flags  ' Flags you can set on the system tray
        Message = &H1   ' System Messages
        Icon = &H2      ' Icon
        Tip = &H4       ' Tooltip
        State = &H8
        Info = &H10
    End Enum
    Private Enum WindowsMessage
        WM_MOUSEMOVE = &H200S
        WM_LBUTTONDOWN = &H201S
        WM_LBUTTONUP = &H202S
        WM_LBUTTONDBLCLK = &H203S
        WM_RBUTTONDOWN = &H204S
        WM_RBUTTONUP = &H205S
        WM_RBUTTONDBLCLK = &H206S
        WM_USER = &H400S
        WM_USER_SYSTRAY = WindowsMessage.WM_USER + 5
    End Enum
    Public Enum BalloonMessage
        BalloonShow = WindowsMessage.WM_USER + 2
        BalloonHide = WindowsMessage.WM_USER + 3
        BalloonTimeout = WindowsMessage.WM_USER + 4
        BalloonUserClick = WindowsMessage.WM_USER + 5
    End Enum
    Private Enum Action
        Add = &H0S
        Modify = &H1S
        Delete = &H2S
    End Enum
    Private Enum Flags
        Message = &H1S
        Icon = &H2S
        Tip = &H4S
    End Enum
    Private Enum ImageTypes
        IBITMAP = 0
        Icon
        CURSOR
    End Enum
    Private Enum LoadTypes
        FROMFILE = &H10S
        TRANSPARENT = &H20S
        MAP3DCOLORS = &H1000S
    End Enum
#End Region
#Region "Structures"
    Private Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure
    Public Structure NOTIFYICONDATA
        Dim cbSize As Integer
        Dim hWnd As Integer
        Dim uId As Integer
        Dim uFlags As Integer
        Dim uCallbackMessage As Integer
        Dim hIcon As Integer
        <VBFixedString(128), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=128)> Dim szTip As String
        Dim dwState As Integer
        Dim dwStateMask As Integer
        <VBFixedString(256), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=256)> Dim szInfo As String
        Dim uTimeoutAndVersion As Integer
        <VBFixedString(64), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=64)> Dim szInfoTitle As String
        Dim dwInfoFlags As Integer
    End Structure
#End Region
#Region "API Calls"
    Private Declare Function Shell_NotifyIcon Lib "shell32" Alias "Shell_NotifyIconA" (ByVal dwMessage As Action, ByRef pnid As NOTIFYICONDATA) As Boolean
    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
    Private Declare Function LoadImage Lib "user32" Alias "LoadImageA" (ByVal hInst As Integer, ByVal lpsz As String, ByVal iType As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal fOptions As Integer) As Integer
    Private Declare Function RegisterWindowMessage Lib "user32" Alias "RegisterWindowMessageA" (ByVal lpString As String) As Integer
#End Region
#Region "Events"
    Public Event MouseMove(ByVal x As Integer, ByVal y As Integer)
    Public Event DblClick(ByVal Button As Short)
    Public Event ButtonUp(ByVal Button As Short)
    Public Event ButtonDown(ByVal Button As Short)
    Public Event Error_Renamed(ByVal ErrNum As Integer, ByVal ErrDesc As String)
    Public Event BalloonHide()
    Public Event BalloonShow()
    Public Event BalloonTimeout()
    Public Event BalloonClick()
#End Region
#Region "Globals"
    Private nidProgramData As NOTIFYICONDATA
    Private nidBalloon As NOTIFYICONDATA

    Private WithEvents wnd As Window
#End Region
#Region "Functions"
    Private Function GetImage(ByVal fileName As String) As Integer
        On Error Goto ErrorHandler

        GetImage = LoadImage(VB6.GetHInstance.ToInt32, fileName, ImageTypes.Icon, 0, 0, LoadTypes.FROMFILE)

        If GetImage = 0 Then RaiseEvent Error_Renamed(1, "Load Icon Failed")
        Exit Function
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Function
#End Region
#Region "Procedures"
    Public Sub New()
        MyBase.New()

        On Error Goto ErrorHandler

        wnd = New Window()

        With nidProgramData
            .cbSize = Len(nidProgramData)
            .uId = VB6.GetHInstance.ToInt32
            .uFlags = Flags.Icon Or Flags.Tip Or Flags.Message
            .uCallbackMessage = WindowsMessage.WM_MOUSEMOVE
        End With
        With nidBalloon
            .cbSize = Len(nidBalloon)
            .uId = VB6.GetHInstance.ToInt32
            .uFlags = Icon_Flags.Info
            .uCallbackMessage = WindowsMessage.WM_MOUSEMOVE
        End With
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Public Sub CreateIcon(ByVal fileName As String, Optional ByVal Tooltip As String = "")
        On Error Goto ErrorHandler

        Call wnd.HookWindow() ' Hook all System Tray Messages

        nidProgramData.hWnd = wnd.myhWnd
        nidProgramData.hIcon = GetImage(fileName)
        nidProgramData.szTip = Tooltip & ControlChars.NullChar

        Call Shell_NotifyIcon(Action.Add, nidProgramData) ' Add the system tray icon

        wnd.M_TaskbarRestart = RegisterWindowMessage("TaskbarCreated")
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Public Sub UpdateIcon(ByVal fileName As String)
        On Error Goto ErrorHandler

        nidProgramData.hIcon = GetImage(fileName)

        Call Shell_NotifyIcon(Action.Modify, nidProgramData) ' Modify the file Name of the system tray icon
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Public Sub UpdateTooltip(ByVal Tooltip As String)
        On Error Goto ErrorHandler

        nidProgramData.szTip = Tooltip & ControlChars.NullChar

        Call Shell_NotifyIcon(Action.Modify, nidProgramData) ' Modify the Tooltip of the system tray icon
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Public Sub DeleteIcon()
        On Error Goto ErrorHandler

        Call wnd.UnHookWindow() ' Stop receiving messages from the Window
        Call Shell_NotifyIcon(Action.Delete, nidProgramData) ' Delete System Tray icon
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Public Sub DeleteBalloon()
        Call Shell_NotifyIcon(Action.Delete, nidBalloon)
    End Sub
    Public Sub ShowBalloon(ByVal strTitle As String, ByVal IconType As Integer, ByVal strMessage As String)
        With nidBalloon
            .hWnd = wnd.myhWnd
            .dwInfoFlags = IconType
            .szInfoTitle = strTitle & ControlChars.NullChar
            .szInfo = strMessage & ControlChars.NullChar
        End With

        Call Shell_NotifyIcon(Action.Modify, nidBalloon)
    End Sub

    Private Sub ReCreateIcon()
        On Error Goto ErrorHandler

        Call Shell_NotifyIcon(Action.Add, nidProgramData) ' Add the system tray icon
        Exit Sub
ErrorHandler:
        RaiseEvent Error_Renamed(Err.Number, Err.Description)
    End Sub
    Private Sub wnd_Error_Renamed(ByVal ErrNum As Integer, ByVal ErrDesc As String) Handles wnd.Error_Renamed
        On Error Goto ErrorHandler

        RaiseEvent Error_Renamed(ErrNum, ErrDesc)
        Exit Sub
ErrorHandler:
        Resume Next
    End Sub
    Private Sub wnd_Incomming(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) Handles wnd.Incomming
        On Error Goto ErrorHandler

        If uMsg = WindowsMessage.WM_MOUSEMOVE Then ' System Tray Message
            Select Case lParam
                Case BalloonMessage.BalloonShow : RaiseEvent BalloonShow()
                Case BalloonMessage.BalloonHide : RaiseEvent BalloonHide()
                Case BalloonMessage.BalloonTimeout : RaiseEvent BalloonTimeout()
                Case BalloonMessage.BalloonUserClick : RaiseEvent BalloonClick()
                Case WindowsMessage.WM_LBUTTONDBLCLK : RaiseEvent DblClick(1)
                Case WindowsMessage.WM_LBUTTONDOWN : RaiseEvent ButtonDown(1)
                Case WindowsMessage.WM_LBUTTONUP : RaiseEvent ButtonUp(1)
                Case WindowsMessage.WM_RBUTTONDOWN : RaiseEvent ButtonDown(2)
                Case WindowsMessage.WM_RBUTTONUP : RaiseEvent ButtonUp(2)
                Case WindowsMessage.WM_RBUTTONDBLCLK : RaiseEvent DblClick(2)
                Case WindowsMessage.WM_MOUSEMOVE
                    Dim pt As POINTAPI

                    Call GetCursorPos(pt) ' Get the cursor position of the mouse over the system tray icon

                    RaiseEvent MouseMove(pt.x, pt.y)
            End Select
            ' If explorer has crashed and restarted then recreate the icon in the system tray
        ElseIf uMsg = wnd.M_TaskbarRestart Then  ' TaskbarCreated Message
            Call ReCreateIcon()
        End If
        Exit Sub
ErrorHandler:
        Resume Next
    End Sub
#End Region
End Class

Option Explicit On 
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports LockDown.cDisableKeys


Public Class frmLock
    Inherits System.Windows.Forms.Form
   
    Dim frmAbout As New frmAbout
    Dim Options As New frmOptions
    Dim crypt As New cCryption 'Declare encryption class
    Dim syspath As String = Environ("systemroot") 'gets the system root path
    Dim apath As String = Application.StartupPath() 'gets app path
    Dim pass As String 'Declaring pass
    Dim Keyboard As New LLKeyboard
    Dim usr As String = System.Environment.UserName
    Dim appdata As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData()



#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtInputPass2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLock))
        Me.txtInputPass2 = New System.Windows.Forms.TextBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInputPass2
        '
        Me.txtInputPass2.BackColor = System.Drawing.Color.White
        Me.txtInputPass2.Location = New System.Drawing.Point(363, 402)
        Me.txtInputPass2.Name = "txtInputPass2"
        Me.txtInputPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(1060)
        Me.txtInputPass2.Size = New System.Drawing.Size(184, 20)
        Me.txtInputPass2.TabIndex = 11
        Me.txtInputPass2.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.PaleGreen
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.Location = New System.Drawing.Point(567, 399)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 23)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.UseVisualStyleBackColor = False
        Me.btnEnter.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.PowderBlue
        Me.TextBox2.Location = New System.Drawing.Point(126, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(40, 13)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(353, 238)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(480, 577)
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'frmLock
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(928, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtInputPass2)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLock"
        Me.Opacity = 0.7
        Me.ShowInTaskbar = False
        Me.Text = "LockDown"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents m_Hook As New cDisableKeys
    Public Declare Function CtrlAltDel_Enable_Disable Lib "ScrLock.dll" (ByVal bEnableDisable As Boolean) As Short
    Private Sub m_Hook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles m_Hook.KeyDown
        'Block key combinations
        If (e.KeyCode = Keys.F4 And e.Alt) Or (e.KeyCode = Keys.Tab And e.Alt) Then
            'Block it if checkbox is checked
            If Me.Visible = True Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub frmLock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim regKey As RegistryKey, regSubKey As RegistryKey
        '---------------------------------------------------------------
        Try
            'getting saved color
            'Saves Color
            'regKey now points to HKEY_CURRENT_USER Registry Key
        
            regKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\SicherGrenzen\LockDown\", False)
            'Finds saved color
            Dim BColor As Object = My.Computer.Registry.CurrentUser.GetValue("BColor")
            Me.BackColor = System.Drawing.Color.FromName(BColor)
            '--------------------------------------------------------------
            regKey.Close()
        Catch ex As Exception
            Me.BackColor = System.Drawing.Color.LightGreen 'Lock BackColor is default.
        End Try
        '--------------------------------------------------------------------

        Dim oRead As System.IO.StreamReader
        oRead = IO.File.OpenText(appdata & "\" & usr & "_ld.sg") 'reads text file
        TextBox2.Text = oRead.ReadLine()
        pass = crypt.psDecrypt(TextBox2.Text)
        TextBox2.Text = pass

        'Keyboard.DisableKeyboard() 'Disables keyboard commands
        Try
            'Disable TaskManager
            'regKey now points to HKEY_LOCAL_USER Registry Key
            Dim MyRegistryObject
            MyRegistryObject = Microsoft.Win32.Registry.CurrentUser

            '//           regKey = My.Computer.Registry.CurrentUser
            'Finds correct Key
            Dim TempReg
            TempReg = MyRegistryObject.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)

            '//       regSubKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
            'Task Manager becomes disabled
            TempReg.SetValue("DisableTaskMgr", 1)

            '//My.Computer.Registry.CurrentUser.SetValue("DisableTaskMgr", 1)
            'Disable LockWorkstation
            TempReg.SetValue("DisableLockWorkStation", 1)
            TempReg.Close()
            '//My.Computer.Registry.CurrentUser.SetValue("DisableLockWorkStation", 1)
            'Disable Logoff
            Dim TempReg2
            TempReg2 = MyRegistryObject.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
            '//regSubKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
            TempReg2.SetValue("NoLogoff", 1)
            '//My.Computer.Registry.CurrentUser.SetValue("NoLogoff", 1)
            'Disable Shutdown
            TempReg2.SetValue("NoClose ", 1)
            TempReg2.Close()
            '//My.Computer.Registry.CurrentUser.SetValue("NoClose ", 1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        btnEnter.Visible = 1
        txtInputPass2.Visible = 1
        picLogo.Visible = 0
        txtInputPass2.Focus()
        Me.Opacity = 0.95

        Keyboard.EnableKeyboard() 'Enables keyboard commands
    End Sub

    Private Sub frmLock_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        btnEnter.Visible = 0
        txtInputPass2.Visible = 0
        picLogo.Visible = 1
        Me.Opacity = 0.7

        Keyboard.DisableKeyboard() 'Disables keyboard commands
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        ' Dim temp = crypt.psEncrypt(txtInputPass2.Text)
        Dim temp As String = txtInputPass2.Text
        If temp = pass Then

            Try
                'Enable TaskManager
                Dim regKey As RegistryKey, regSubKey As RegistryKey
                'regKey now points to HKEY_LOCAL_USER Registry Key
                regKey = My.Computer.Registry.CurrentUser
                'Finds correct Key
                regSubKey = regKey.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
                'Task Manager becomes re-enabled
                regSubKey.SetValue("DisableTaskMgr", 0)
                'Enable LockWorkstation
                regSubKey.SetValue("DisableLockWorkStation", 0)
                'Enable Logoff
                regSubKey = regKey.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
                regSubKey.SetValue("NoLogoff", 0)
                'Enable Shutdown
                regSubKey.SetValue("NoClose ", 0)
                '---------------------------
            Catch ex As Exception
            End Try
            ErrView()
        Else
            frmErrors.RichTextBox1.SelectedText = TimeOfDay & ": Invalid Password Attempt;  " & temp & vbCrLf
            MessageBox.Show("Invalid Password")
        End If
        txtInputPass2.Text = ""
        txtInputPass2.Focus()
    End Sub

    Private Sub picLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogo.Click
        btnEnter.Visible = 1
        txtInputPass2.Visible = 1
        picLogo.Visible = 0
        txtInputPass2.Focus()
        Me.Opacity = 1.0

        Keyboard.EnableKeyboard() 'Enables keyboard commands
    End Sub

    Private Sub picLogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLogo.DoubleClick
        btnEnter.Visible = 0
        txtInputPass2.Visible = 0
        picLogo.Visible = 1
        Me.Opacity = 0.7

        Keyboard.DisableKeyboard() 'Disables keyboard commands
    End Sub
    Private Sub frmLock_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'stops alt+f4
        e.Cancel = True

        Keyboard.EnableKeyboard() 'Enables keyboard commands on Program Exit
    End Sub
    Private Function ErrView()
        If frmErrors.RichTextBox1.TextLength >= 1 Then
            Me.Hide()
            frmMain.Show()
            frmErrors.Show()
        ElseIf frmErrors.RichTextBox1.TextLength = 0 Then
            Me.Hide()
            frmMain.Show()
        End If
    End Function
End Class
Public Class LLKeyboard

#Region "Declarations - Constants"

    Private Const HC_ACTION As Integer = 0
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_SYSKEYDOWN As Integer = &H104
    Private Const WM_SYSKEYUP As Integer = &H105

#End Region

#Region "Declarations - Structures"

    Private Structure KBDLLHOOKSTRUCT

        Private vkCode As Integer
        Private scanCode As Integer
        Private flags As Integer
        Private time As Integer
        Private dwExtraInfo As Integer

    End Structure

#End Region

#Region "Declarations - Win32 API's"

    Private Declare Function SetWindowsHookEx Lib "user32" _
        Alias "SetWindowsHookExA" ( _
        ByVal idHook As Integer, _
        ByVal lpfn As LowLevelKeyboardProcDelegate, _
        ByVal hmod As Integer, _
        ByVal dwThreadId As Integer) As Integer

    Private Declare Function CallNextHookEx Lib "user32" ( _
        ByVal hHook As Integer, _
        ByVal nCode As Integer, _
        ByVal wParam As Integer, _
        ByVal lParam As KBDLLHOOKSTRUCT) As Integer

    Private Declare Function UnhookWindowsHookEx Lib "user32" ( _
        ByVal hHook As Integer) As Integer

#End Region

    Private hhkLowLevelKybd As Integer

#Region "Declarations - Functions"

    Private Function LowLevelKeyboardProc( _
        ByVal nCode As Integer, _
        ByVal wParam As Integer, _
        ByVal lParam As KBDLLHOOKSTRUCT) As Integer

        If (nCode = HC_ACTION) Then

            If wParam = WM_KEYDOWN Or _
                wParam = WM_SYSKEYDOWN Or _
                wParam = WM_KEYUP Or _
                wParam = WM_SYSKEYUP Then

                Return 1

            End If

            Return CallNextHookEx(hhkLowLevelKybd, _
                nCode, wParam, lParam)

        End If

    End Function

    Private Delegate Function LowLevelKeyboardProcDelegate( _
        ByVal nCode As Integer, _
        ByVal wParam As Integer, _
        ByVal lParam As KBDLLHOOKSTRUCT) As Integer

#End Region

#Region "Declarations - Keyboard Public Class Methods"

    Public Sub DisableKeyboard()

        'Set Keyboard Hook
        hhkLowLevelKybd = SetWindowsHookEx(WH_KEYBOARD_LL, _
            AddressOf LowLevelKeyboardProc, Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)

    End Sub

    Public Sub EnableKeyboard()

        'Release Keyboard Hook
        UnhookWindowsHookEx(hhkLowLevelKybd)

    End Sub

#End Region

End Class




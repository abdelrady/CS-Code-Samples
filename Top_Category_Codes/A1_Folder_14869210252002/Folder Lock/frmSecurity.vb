Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSecurity
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
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents cmdUnsecure As System.Windows.Forms.Button
	Public WithEvents cmdSecure As System.Windows.Forms.Button
    Public WithEvents drvDrive As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Public WithEvents dirDir As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents lblloaded As System.Windows.Forms.Label
    Friend WithEvents lbltotfilessecured As System.Windows.Forms.Label
    Friend WithEvents lblcurrsec As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSecurity))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUnsecure = New System.Windows.Forms.Button()
        Me.cmdSecure = New System.Windows.Forms.Button()
        Me.drvDrive = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.dirDir = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.lblloaded = New System.Windows.Forms.Label()
        Me.lbltotfilessecured = New System.Windows.Forms.Label()
        Me.lblcurrsec = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(8, 144)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(360, 32)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        '
        'cmdUnsecure
        '
        Me.cmdUnsecure.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmdUnsecure.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUnsecure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUnsecure.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnsecure.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdUnsecure.Location = New System.Drawing.Point(296, 80)
        Me.cmdUnsecure.Name = "cmdUnsecure"
        Me.cmdUnsecure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUnsecure.Size = New System.Drawing.Size(72, 56)
        Me.cmdUnsecure.TabIndex = 3
        Me.cmdUnsecure.Text = "&Unsecure"
        '
        'cmdSecure
        '
        Me.cmdSecure.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmdSecure.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSecure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSecure.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSecure.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdSecure.Location = New System.Drawing.Point(296, 8)
        Me.cmdSecure.Name = "cmdSecure"
        Me.cmdSecure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSecure.Size = New System.Drawing.Size(72, 56)
        Me.cmdSecure.TabIndex = 2
        Me.cmdSecure.Text = "&Secure"
        '
        'drvDrive
        '
        Me.drvDrive.BackColor = System.Drawing.SystemColors.Window
        Me.drvDrive.Cursor = System.Windows.Forms.Cursors.Default
        Me.drvDrive.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drvDrive.ForeColor = System.Drawing.SystemColors.WindowText
        Me.drvDrive.Location = New System.Drawing.Point(14, 8)
        Me.drvDrive.Name = "drvDrive"
        Me.drvDrive.Size = New System.Drawing.Size(146, 21)
        Me.drvDrive.TabIndex = 0
        '
        'dirDir
        '
        Me.dirDir.BackColor = System.Drawing.SystemColors.Window
        Me.dirDir.Cursor = System.Windows.Forms.Cursors.Default
        Me.dirDir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dirDir.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dirDir.IntegralHeight = False
        Me.dirDir.Location = New System.Drawing.Point(176, 8)
        Me.dirDir.Name = "dirDir"
        Me.dirDir.Size = New System.Drawing.Size(112, 128)
        Me.dirDir.TabIndex = 5
        '
        'lblloaded
        '
        Me.lblloaded.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloaded.ForeColor = System.Drawing.Color.Blue
        Me.lblloaded.Location = New System.Drawing.Point(8, 48)
        Me.lblloaded.Name = "lblloaded"
        Me.lblloaded.Size = New System.Drawing.Size(168, 16)
        Me.lblloaded.TabIndex = 6
        Me.lblloaded.Text = "Project Loaded : -"
        Me.lblloaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltotfilessecured
        '
        Me.lbltotfilessecured.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotfilessecured.ForeColor = System.Drawing.Color.Blue
        Me.lbltotfilessecured.Location = New System.Drawing.Point(8, 80)
        Me.lbltotfilessecured.Name = "lbltotfilessecured"
        Me.lbltotfilessecured.Size = New System.Drawing.Size(168, 16)
        Me.lbltotfilessecured.TabIndex = 7
        Me.lbltotfilessecured.Text = "Total Folders Secured : -"
        Me.lbltotfilessecured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcurrsec
        '
        Me.lblcurrsec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrsec.ForeColor = System.Drawing.Color.Blue
        Me.lblcurrsec.Location = New System.Drawing.Point(8, 112)
        Me.lblcurrsec.Name = "lblcurrsec"
        Me.lblcurrsec.Size = New System.Drawing.Size(168, 16)
        Me.lblcurrsec.TabIndex = 9
        Me.lblcurrsec.Text = "Currently Secured : -"
        Me.lblcurrsec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSecurity
        '
        Me.AcceptButton = Me.cmdSecure
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(378, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblcurrsec, Me.lbltotfilessecured, Me.lblloaded, Me.dirDir, Me.cmdExit, Me.cmdUnsecure, Me.cmdSecure, Me.drvDrive})
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 48)
        Me.MaximizeBox = False
        Me.Name = "frmSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folder Lock"
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmSecurity
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmSecurity
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmSecurity()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
    Dim user As String
    Dim pass As String
    Dim strcheckfirst As String
    Dim intcheckfirst As Integer
    Dim totalfilessecured As String
    Dim currsecfolders As String
	Private Declare Function GetWindowsDirectory Lib "kernel32"  Alias "GetWindowsDirectoryA"(ByVal lpBuffer As String, ByVal nSize As Integer) As Integer
	
	Dim WindowsDirectory As String
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        If MsgBox("Do you want to Quit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.ApplicationModal, "Quit...") = MsgBoxResult.Yes Then
            End
        End If
	End Sub
	
	Private Sub cmdSecure_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSecure.Click
        Try
            Dim Path As String
            Dim Data As String
            Dim File As String
            Dim Ext As String
            Dim FileName As String
            Dim secfilepath As String
            Dim secpass As String
            Ext = ".{645FF040-5081-101B-9F08-00AA002F954E}"
            Path = dirDir.Path
            Data = Mid(Path, InStrRev(Path, "\") + 1, Len(Path))
            File = VB.Left(Path, Len(Path) - Len(Data))
            If Not UCase(Path) = UCase(WindowsDirectory) And Not UCase(Data) = UCase("desktop") Then
                secfilepath = Path + Ext
                secpass = InputBox("Enter Password")
                globalfinal = ""
                Call encryption(secpass)
                secpass = globalfinal
                globalfinal = ""
                Call encryption(secfilepath)
                secfilepath = globalfinal
                SaveSetting("Folder", "Lock", secfilepath, secpass)
                FileName = File & Data & Ext
                Rename(dirDir.Path, FileName)
                dirDir.Path = File
                Dim inttotalsecured As Integer
                totalfilessecured = GetSetting("Folder", "Lock", "Total Secured")
                If totalfilessecured = "" Then
                    totalfilessecured = "1"
                    SaveSetting("Folder", "Lock", "Total Secured", totalfilessecured)
                    lbltotfilessecured.Text = "Total Secured : - 1."
                Else
                    inttotalsecured = CInt(totalfilessecured) + 1
                    totalfilessecured = CStr(inttotalsecured)
                    SaveSetting("Folder", "Lock", "Total Secured", totalfilessecured)
                    lbltotfilessecured.Text = "Total Secured : - " & totalfilessecured & "."
                End If
                currsecfolders = GetSetting("Folder", "Lock", "Current Secured")
                Dim intcurrsec As Integer
                intcurrsec = CInt(currsecfolders) + 1
                SaveSetting("Folder", "Lock", "Current Secured", intcurrsec)
                lblcurrsec.Text = "Current Secured : - " & intcurrsec & ""
                MsgBox("Security applied to the directory.", MsgBoxStyle.ApplicationModal + MsgBoxStyle.Information, "Security...")
            Else
                MsgBox("Cann't be protected.", MsgBoxStyle.ApplicationModal + MsgBoxStyle.Information, "Security...")
            End If
        Catch
            MsgBox("Double Click on the Folder.", MsgBoxStyle.Information, "Folder Lock")
        End Try
        Exit Sub
	End Sub
	
	Private Sub cmdUnsecure_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUnsecure.Click
        Try
            Dim Path As String
            Dim Temp As String
            Dim Data As String
            Dim File As String
            Dim Ext As String
            Dim FileName As String
            Dim unsecfilepath As String
            Dim unsecpass As String
            Dim unsecget As String
            Path = dirDir.Path
            Temp = Mid(Path, InStrRev(Path, "\") + 1, Len(Path))
            Data = VB.Left(Temp, InStr(Temp, ".{") - 1)
            File = VB.Left(Path, Len(Path) - Len(Temp))
            FileName = File & Data
            unsecfilepath = Path
            unsecpass = InputBox("Enter Password")
            globalfinal = ""
            Call encryption(unsecfilepath)
            unsecfilepath = globalfinal
            globalfinal = ""
            Call encryption(unsecpass)
            unsecpass = globalfinal
            unsecget = GetSetting("Folder", "Lock", unsecfilepath)
            If unsecget = unsecpass Then
                Rename(dirDir.Path, FileName)
                dirDir.Path = File
                currsecfolders = GetSetting("Folder", "Lock", "Current Secured")
                Dim intcurrsec As Integer
                intcurrsec = CInt(currsecfolders) - 1
                SaveSetting("Folder", "Lock", "Current Secured", intcurrsec)
                lblcurrsec.Text = "Current Secured : -" & intcurrsec & "."
                MsgBox("Security removed to the directory.", MsgBoxStyle.ApplicationModal + MsgBoxStyle.Information, "Security...")
                DeleteSetting("Folder", "Lock", unsecfilepath)
            Else
                MsgBox("Invalid Password", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Catch
            MsgBox("Double Click on the Folder.", MsgBoxStyle.Information, "Folder Lock")
        End Try
        Exit Sub
    End Sub

    Private Sub dirDir_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error Resume Next
        dirDir.Path = drvDrive.Drive
    End Sub

    Private Sub drvDrive_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles drvDrive.SelectedIndexChanged
        On Error GoTo NotReady
        dirDir.Path = drvDrive.Drive
        Exit Sub
NotReady:
        MsgBox("Drive is not ready.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, "Not Ready...")
    End Sub

    Private Sub frmSecurity_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        strcheckfirst = GetSetting("Folder", "Lock", "Check First") 'To know how many times this Project has been Loaded.
        totalfilessecured = GetSetting("Folder", "Lock", "Total Secured")
        currsecfolders = GetSetting("Folder", "Lock", "Current Secured")
        If strcheckfirst = "" Then
            strcheckfirst = "1"
            SaveSetting("Folder", "Lock", "Check First", strcheckfirst)
            lblloaded.Text = "Project Loaded : - 1 Times."
        Else
            intcheckfirst = strcheckfirst
            intcheckfirst = intcheckfirst + 1
            SaveSetting("Folder", "Lock", "Check First", intcheckfirst)
            lblloaded.Text = "Project Loaded : - " & intcheckfirst & " Times."
        End If
        If totalfilessecured = "" Then
            lbltotfilessecured.Text = "Total Secured : - 0."
        Else
            lbltotfilessecured.Text = "Total Secured : - " & totalfilessecured & "."
        End If
        If currsecfolders = "" Then
            currsecfolders = "0"
            SaveSetting("Folder", "Lock", "Current Secured", currsecfolders)
            lblcurrsec.Text = "Current Secured : - 0."
        Else
            currsecfolders = GetSetting("Folder", "Lock", "Current Secured")
            lblcurrsec.Text = "Current Secured : - " & currsecfolders & "."
        End If
        Dim ret As Integer
        Dim buff As String
        buff = Space(255)
        ret = GetWindowsDirectory(buff, 255)
        WindowsDirectory = VB.Left(buff, InStr(buff, vbNullChar) - 1)
    End Sub
    Private Sub frmSecurity_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        cmdExit_Click(cmdExit, New System.EventArgs())
        eventArgs.Cancel = Cancel
    End Sub
End Class
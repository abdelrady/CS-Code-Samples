' Imports
Imports System
Imports System.IO
Imports System.Net.Dns
Imports System.Security
Imports Microsoft.Win32
Imports System.Threading.WaitHandle
Public Class frmMain
    Inherits System.Windows.Forms.Form
    ' Declarations
    Private Declare Function LockWorkStation Lib "user32.dll" () As Long
    Private Declare Function SHShutDownDialog Lib "shell32" Alias "#60" (ByVal YourGuess As Long) As Long

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
    Friend WithEvents openCopy As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveCopy As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents openDelete As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdMake As System.Windows.Forms.Button
    Friend WithEvents saveMake As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdWrite As System.Windows.Forms.Button
    Friend WithEvents txtWrite As System.Windows.Forms.TextBox
    Friend WithEvents saveWrite As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grpFileOps As System.Windows.Forms.GroupBox
    Friend WithEvents cmdLock As System.Windows.Forms.Button
    Friend WithEvents cmdUser As System.Windows.Forms.Button
    Friend WithEvents cmdCPUName As System.Windows.Forms.Button
    Friend WithEvents grpSysFunc As System.Windows.Forms.GroupBox
    Friend WithEvents cmdWait As System.Windows.Forms.Button
    Friend WithEvents grpWrite As System.Windows.Forms.GroupBox
    Friend WithEvents cmdShutDialog As System.Windows.Forms.Button
    Friend WithEvents grpMake As System.Windows.Forms.GroupBox
    Friend WithEvents scrSize As System.Windows.Forms.TrackBar
    Friend WithEvents txtChar As System.Windows.Forms.TextBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblChar As System.Windows.Forms.Label
    Friend WithEvents tabAPIStuff As System.Windows.Forms.TabControl
    Friend WithEvents tabFileOps As System.Windows.Forms.TabPage
    Friend WithEvents tabSys As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.openCopy = New System.Windows.Forms.OpenFileDialog()
        Me.saveCopy = New System.Windows.Forms.SaveFileDialog()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.openDelete = New System.Windows.Forms.OpenFileDialog()
        Me.cmdMake = New System.Windows.Forms.Button()
        Me.saveMake = New System.Windows.Forms.SaveFileDialog()
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.txtWrite = New System.Windows.Forms.TextBox()
        Me.saveWrite = New System.Windows.Forms.SaveFileDialog()
        Me.grpFileOps = New System.Windows.Forms.GroupBox()
        Me.grpMake = New System.Windows.Forms.GroupBox()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtChar = New System.Windows.Forms.TextBox()
        Me.scrSize = New System.Windows.Forms.TrackBar()
        Me.grpWrite = New System.Windows.Forms.GroupBox()
        Me.cmdLock = New System.Windows.Forms.Button()
        Me.cmdUser = New System.Windows.Forms.Button()
        Me.cmdCPUName = New System.Windows.Forms.Button()
        Me.grpSysFunc = New System.Windows.Forms.GroupBox()
        Me.cmdShutDialog = New System.Windows.Forms.Button()
        Me.cmdWait = New System.Windows.Forms.Button()
        Me.tabAPIStuff = New System.Windows.Forms.TabControl()
        Me.tabFileOps = New System.Windows.Forms.TabPage()
        Me.tabSys = New System.Windows.Forms.TabPage()
        Me.grpFileOps.SuspendLayout()
        Me.grpMake.SuspendLayout()
        CType(Me.scrSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWrite.SuspendLayout()
        Me.grpSysFunc.SuspendLayout()
        Me.tabAPIStuff.SuspendLayout()
        Me.tabFileOps.SuspendLayout()
        Me.tabSys.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(16, 24)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(80, 23)
        Me.cmdCopy.TabIndex = 0
        Me.cmdCopy.Text = "Copy File"
        '
        'openCopy
        '
        Me.openCopy.Filter = "All Files|*.*"
        '
        'saveCopy
        '
        Me.saveCopy.Filter = "All Files|*.*"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(16, 56)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(80, 24)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Delete File"
        '
        'openDelete
        '
        Me.openDelete.Filter = "All Files|*.*"
        Me.openDelete.Multiselect = True
        '
        'cmdMake
        '
        Me.cmdMake.Location = New System.Drawing.Point(8, 56)
        Me.cmdMake.Name = "cmdMake"
        Me.cmdMake.Size = New System.Drawing.Size(80, 24)
        Me.cmdMake.TabIndex = 2
        Me.cmdMake.Text = "Make File"
        '
        'saveMake
        '
        Me.saveMake.Filter = "All Files|*.*"
        '
        'cmdWrite
        '
        Me.cmdWrite.Location = New System.Drawing.Point(8, 24)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.Size = New System.Drawing.Size(80, 24)
        Me.cmdWrite.TabIndex = 3
        Me.cmdWrite.Text = "Write to File"
        '
        'txtWrite
        '
        Me.txtWrite.Location = New System.Drawing.Point(104, 16)
        Me.txtWrite.Multiline = True
        Me.txtWrite.Name = "txtWrite"
        Me.txtWrite.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWrite.Size = New System.Drawing.Size(176, 32)
        Me.txtWrite.TabIndex = 4
        Me.txtWrite.Text = "Enter the text in here to write to a file."
        '
        'saveWrite
        '
        Me.saveWrite.Filter = "All Files|*.*"
        '
        'grpFileOps
        '
        Me.grpFileOps.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpMake, Me.grpWrite, Me.cmdDelete, Me.cmdCopy})
        Me.grpFileOps.Location = New System.Drawing.Point(8, 8)
        Me.grpFileOps.Name = "grpFileOps"
        Me.grpFileOps.Size = New System.Drawing.Size(456, 240)
        Me.grpFileOps.TabIndex = 5
        Me.grpFileOps.TabStop = False
        Me.grpFileOps.Text = "File Operations"
        '
        'grpMake
        '
        Me.grpMake.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblChar, Me.lblNote, Me.lblSize, Me.txtChar, Me.scrSize, Me.cmdMake})
        Me.grpMake.Location = New System.Drawing.Point(8, 80)
        Me.grpMake.Name = "grpMake"
        Me.grpMake.Size = New System.Drawing.Size(424, 88)
        Me.grpMake.TabIndex = 6
        Me.grpMake.TabStop = False
        Me.grpMake.Text = "Make file"
        '
        'lblChar
        '
        Me.lblChar.Location = New System.Drawing.Point(336, 56)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(56, 24)
        Me.lblChar.TabIndex = 7
        Me.lblChar.Text = "Character"
        '
        'lblNote
        '
        Me.lblNote.Location = New System.Drawing.Point(112, 16)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(88, 24)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = "Size (in bytes)"
        '
        'lblSize
        '
        Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize.Location = New System.Drawing.Point(8, 24)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(88, 24)
        Me.lblSize.TabIndex = 5
        '
        'txtChar
        '
        Me.txtChar.Location = New System.Drawing.Point(392, 56)
        Me.txtChar.MaxLength = 1
        Me.txtChar.Name = "txtChar"
        Me.txtChar.Size = New System.Drawing.Size(24, 20)
        Me.txtChar.TabIndex = 4
        Me.txtChar.Text = "#"
        '
        'scrSize
        '
        Me.scrSize.LargeChange = 500
        Me.scrSize.Location = New System.Drawing.Point(104, 40)
        Me.scrSize.Maximum = 102400
        Me.scrSize.Name = "scrSize"
        Me.scrSize.Size = New System.Drawing.Size(232, 42)
        Me.scrSize.TabIndex = 3
        '
        'grpWrite
        '
        Me.grpWrite.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdWrite, Me.txtWrite})
        Me.grpWrite.Location = New System.Drawing.Point(8, 176)
        Me.grpWrite.Name = "grpWrite"
        Me.grpWrite.Size = New System.Drawing.Size(296, 56)
        Me.grpWrite.TabIndex = 5
        Me.grpWrite.TabStop = False
        Me.grpWrite.Text = "Write to file"
        '
        'cmdLock
        '
        Me.cmdLock.Location = New System.Drawing.Point(16, 24)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(88, 32)
        Me.cmdLock.TabIndex = 6
        Me.cmdLock.Text = "Lock Workstation"
        '
        'cmdUser
        '
        Me.cmdUser.Location = New System.Drawing.Point(16, 72)
        Me.cmdUser.Name = "cmdUser"
        Me.cmdUser.Size = New System.Drawing.Size(88, 32)
        Me.cmdUser.TabIndex = 7
        Me.cmdUser.Text = "Get Current User Name"
        '
        'cmdCPUName
        '
        Me.cmdCPUName.Location = New System.Drawing.Point(16, 120)
        Me.cmdCPUName.Name = "cmdCPUName"
        Me.cmdCPUName.Size = New System.Drawing.Size(88, 32)
        Me.cmdCPUName.TabIndex = 8
        Me.cmdCPUName.Text = "Get Computer Name"
        '
        'grpSysFunc
        '
        Me.grpSysFunc.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdShutDialog, Me.cmdLock, Me.cmdUser, Me.cmdCPUName, Me.cmdWait})
        Me.grpSysFunc.Location = New System.Drawing.Point(8, 8)
        Me.grpSysFunc.Name = "grpSysFunc"
        Me.grpSysFunc.Size = New System.Drawing.Size(328, 160)
        Me.grpSysFunc.TabIndex = 9
        Me.grpSysFunc.TabStop = False
        Me.grpSysFunc.Text = "System Functions"
        '
        'cmdShutDialog
        '
        Me.cmdShutDialog.Location = New System.Drawing.Point(112, 24)
        Me.cmdShutDialog.Name = "cmdShutDialog"
        Me.cmdShutDialog.Size = New System.Drawing.Size(80, 32)
        Me.cmdShutDialog.TabIndex = 14
        Me.cmdShutDialog.Text = "Show Shut Down Dialog"
        '
        'cmdWait
        '
        Me.cmdWait.Location = New System.Drawing.Point(112, 72)
        Me.cmdWait.Name = "cmdWait"
        Me.cmdWait.Size = New System.Drawing.Size(80, 32)
        Me.cmdWait.TabIndex = 10
        Me.cmdWait.Text = "Wait"
        '
        'tabAPIStuff
        '
        Me.tabAPIStuff.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabFileOps, Me.tabSys})
        Me.tabAPIStuff.Location = New System.Drawing.Point(0, 8)
        Me.tabAPIStuff.Name = "tabAPIStuff"
        Me.tabAPIStuff.SelectedIndex = 0
        Me.tabAPIStuff.Size = New System.Drawing.Size(480, 288)
        Me.tabAPIStuff.TabIndex = 15
        '
        'tabFileOps
        '
        Me.tabFileOps.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpFileOps})
        Me.tabFileOps.Location = New System.Drawing.Point(4, 22)
        Me.tabFileOps.Name = "tabFileOps"
        Me.tabFileOps.Size = New System.Drawing.Size(472, 262)
        Me.tabFileOps.TabIndex = 0
        Me.tabFileOps.Text = "File Operations"
        '
        'tabSys
        '
        Me.tabSys.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpSysFunc})
        Me.tabSys.Location = New System.Drawing.Point(4, 22)
        Me.tabSys.Name = "tabSys"
        Me.tabSys.Size = New System.Drawing.Size(472, 262)
        Me.tabSys.TabIndex = 1
        Me.tabSys.Text = "System Functions"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 301)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabAPIStuff})
        Me.Name = "frmMain"
        Me.Text = "APIs..."
        Me.grpFileOps.ResumeLayout(False)
        Me.grpMake.ResumeLayout(False)
        CType(Me.scrSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWrite.ResumeLayout(False)
        Me.grpSysFunc.ResumeLayout(False)
        Me.tabAPIStuff.ResumeLayout(False)
        Me.tabFileOps.ResumeLayout(False)
        Me.tabSys.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        ' Show openCopy
        openCopy.ShowDialog()
        If openCopy.FileName <> "" Then
            saveCopy.FileName = openCopy.FileName & ".TEST"
            ' Show saveCopy
            saveCopy.ShowDialog()
            ' Copy file
            File.Copy(openCopy.FileName, saveCopy.FileName)
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        ' Show openDelete
        openDelete.ShowDialog()
        If openDelete.FileName <> "" Then
        ' Delete selected file
            File.Delete(openDelete.FileName)
        End If
    End Sub

    Private Sub cmdMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMake.Click
        Dim I As Integer
        ' Show saveMake
        saveMake.ShowDialog()
        If saveMake.FileName <> "" Then
            Dim WriteToFile As StreamWriter = File.CreateText(saveMake.FileName)
            ' Check if scrSize.Value is bigger than 0
            If scrSize.Value > 0 Then
                ' Go into loop
                For I = I To scrSize.Value - 1
                    With WriteToFile
                        .Write(txtChar.Text)
                        .Flush()
                    End With
                Next
            End If
            MsgBox("Created a " & scrSize.Value & " byte file", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWrite.Click
        ' Show saveWrite
        saveWrite.ShowDialog()
        If saveWrite.FileName <> "" Then
            Dim WriteToFile As StreamWriter = File.CreateText(saveWrite.FileName)
            With WriteToFile
                ' Write text to file
                .Write(txtWrite.Text)
                .Flush()
            End With
        End If
    End Sub

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        ' Lock workstation (only works on Windows NT or NT based operating systems
        Try
            LockWorkStation()
        Catch
            MsgBox("You need Windows NT or a Windows NT based O/S", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cmdUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUser.Click
        ' Show the current user name and show in a message box
        MsgBox("Your user name: " & Principal.WindowsIdentity.GetCurrent.Name, MsgBoxStyle.Information, _
                   "Current User Name")
    End Sub

    Private Sub cmdCPUName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCPUName.Click
        ' Get the computer's name and show in a message box
        MsgBox("The computer's name: " & System.Windows.Forms.SystemInformation.ComputerName, _
                    MsgBoxStyle.Information, "Computer Name")
    End Sub

    Private Sub cmdWait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWait.Click
        Dim Wait As String
        ' Show an input box for the user to specify the delay
        Wait = InputBox("How much of a delay (in seconds)?")
        Try
            ' Wait
            System.Threading.Thread.Sleep(Wait * 1000)
            If Wait = 1 Then
                MsgBox("Waited " & Wait & " second")
            Else
                MsgBox("Waited " & Wait & " seconds")
            End If
        Catch
            MsgBox("Enter a valid number. (bigger than -1)", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cmdShutDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShutDialog.Click
        ' Show shut down dialog
        SHShutDownDialog(0)
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSize.Text = scrSize.Value & " Bytes"
    End Sub

    Private Sub scrSize_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scrSize.Scroll
        lblSize.Text = scrSize.Value & " Bytes"
    End Sub

End Class

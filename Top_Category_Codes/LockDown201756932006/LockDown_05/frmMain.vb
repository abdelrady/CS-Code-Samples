Option Explicit On 
Imports LockDown.cDisableKeys
Public Class frmMain
    Inherits System.Windows.Forms.Form


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
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtInputPass As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents cntxmnu_sys As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnu_Restore As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu_Exit As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu_Lock As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu_Options As System.Windows.Forms.MenuItem
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssUsr As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HideInTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systrayIcon As System.Windows.Forms.NotifyIcon
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnLock = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.txtInputPass = New System.Windows.Forms.TextBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.systrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cntxmnu_sys = New System.Windows.Forms.ContextMenu
        Me.cmnu_Restore = New System.Windows.Forms.MenuItem
        Me.cmnu_Lock = New System.Windows.Forms.MenuItem
        Me.cmnu_Options = New System.Windows.Forms.MenuItem
        Me.cmnu_Exit = New System.Windows.Forms.MenuItem
        Me.txtOldPass = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.btnVerify = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssUsr = New System.Windows.Forms.ToolStripStatusLabel
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HideInTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLock.Image = CType(resources.GetObject("btnLock.Image"), System.Drawing.Image)
        Me.btnLock.Location = New System.Drawing.Point(264, 311)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(75, 23)
        Me.btnLock.TabIndex = 1
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(243, 255)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 39)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtInputPass
        '
        Me.txtInputPass.Location = New System.Drawing.Point(152, 219)
        Me.txtInputPass.Name = "txtInputPass"
        Me.txtInputPass.Size = New System.Drawing.Size(208, 20)
        Me.txtInputPass.TabIndex = 3
        Me.txtInputPass.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.Location = New System.Drawing.Point(381, 216)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.UseVisualStyleBackColor = False
        Me.btnEnter.Visible = False
        '
        'systrayIcon
        '
        Me.systrayIcon.ContextMenu = Me.cntxmnu_sys
        Me.systrayIcon.Icon = CType(resources.GetObject("systrayIcon.Icon"), System.Drawing.Icon)
        Me.systrayIcon.Text = "LockDown"
        '
        'cntxmnu_sys
        '
        Me.cntxmnu_sys.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnu_Restore, Me.cmnu_Lock, Me.cmnu_Options, Me.cmnu_Exit})
        '
        'cmnu_Restore
        '
        Me.cmnu_Restore.Index = 0
        Me.cmnu_Restore.Text = "Restore"
        '
        'cmnu_Lock
        '
        Me.cmnu_Lock.Index = 1
        Me.cmnu_Lock.Text = "Lock"
        '
        'cmnu_Options
        '
        Me.cmnu_Options.Index = 2
        Me.cmnu_Options.Text = "Options"
        '
        'cmnu_Exit
        '
        Me.cmnu_Exit.Index = 3
        Me.cmnu_Exit.Text = "Exit"
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(152, 219)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(208, 20)
        Me.txtOldPass.TabIndex = 5
        Me.txtOldPass.Visible = False
        '
        'lblPass
        '
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Location = New System.Drawing.Point(149, 193)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(160, 23)
        Me.lblPass.TabIndex = 6
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.Gainsboro
        Me.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerify.Image = CType(resources.GetObject("btnVerify.Image"), System.Drawing.Image)
        Me.btnVerify.Location = New System.Drawing.Point(381, 213)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(80, 23)
        Me.btnVerify.TabIndex = 7
        Me.btnVerify.UseVisualStyleBackColor = False
        Me.btnVerify.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssUsr})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 366)
        Me.StatusStrip1.MinimumSize = New System.Drawing.Size(528, 22)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(528, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssUsr
        '
        Me.tssUsr.Name = "tssUsr"
        Me.tssUsr.Size = New System.Drawing.Size(0, 17)
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.Transparent
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.MaximumSize = New System.Drawing.Size(98, 348)
        Me.MainMenu.MinimumSize = New System.Drawing.Size(98, 348)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(98, 348)
        Me.MainMenu.Stretch = False
        Me.MainMenu.TabIndex = 9
        Me.MainMenu.Text = "MainMenu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(85, 34)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Image = CType(resources.GetObject("HideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditColorsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Image = CType(resources.GetObject("OptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(85, 34)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'EditColorsToolStripMenuItem
        '
        Me.EditColorsToolStripMenuItem.Image = CType(resources.GetObject("EditColorsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditColorsToolStripMenuItem.Name = "EditColorsToolStripMenuItem"
        Me.EditColorsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditColorsToolStripMenuItem.Text = "Edit Colors"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 34)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = CType(resources.GetObject("HelpToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.PaleGreen
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideInTrayToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 26)
        '
        'HideInTrayToolStripMenuItem
        '
        Me.HideInTrayToolStripMenuItem.Image = CType(resources.GetObject("HideInTrayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideInTrayToolStripMenuItem.Name = "HideInTrayToolStripMenuItem"
        Me.HideInTrayToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HideInTrayToolStripMenuItem.Text = "Hide in Tray"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(527, 388)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.txtInputPass)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.btnEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximumSize = New System.Drawing.Size(535, 415)
        Me.MinimumSize = New System.Drawing.Size(535, 415)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LockDown"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim crypt As New cCryption 'Declare encryption/decryption class
    Dim pass1 As String
    Dim pass2 As String
    Dim syspath As String = Environ("systemroot") 'gets the system root path
    Dim Lock As New frmLock
    Dim Edit As New frmOptions
    Dim About As New frmAbout
    Dim usr As String = System.Environment.UserName
    Dim appdata As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData()

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        '-------Encrypts pass and saves in system folder------
        syspath = Environ("systemroot") 'gets the system root path
        Dim temp As String = crypt.psEncrypt(txtInputPass.Text)
        'Save to text File
        Dim oWrite As System.IO.StreamWriter
        oWrite = IO.File.CreateText(appdata & "\" & usr & "_ld.sg") 'creates ini file
        oWrite.WriteLine(temp) 'writes first line
        oWrite.Close() 'closes StreamWriter
        MsgBox("Pass Saved") 'Prompts that password has nopw been saved.

        txtInputPass.Visible = False 'Hides Password Edit textbox
        txtInputPass.Text = ""
        lblPass.Text = ("")
        btnEdit.Visible = True 'Shows Edit button
        btnEnter.Visible = False 'Hides Enter button
        btnEdit.Enabled = True

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnEdit.Visible = False 'Hides Edit button

        If IO.File.Exists(appdata & "\" & usr & "_ld.sg") Then
            btnVerify.Visible = True 'Shows Verify button
            Me.AcceptButton = btnVerify
            txtOldPass.Visible = True
            lblPass.Text = ("Please Enter Old Password")
            txtOldPass.Focus()
        Else : txtInputPass.Visible = True 'Shows textbox
            txtInputPass.Focus()
            lblPass.Text = ("Please Enter New Password")
            btnVerify.Visible = False
            btnEnter.Visible = True
            Me.AcceptButton = btnEnter
        End If
    End Sub



    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        Me.Hide() 'Hides current form
        Lock.Show() 'Shows Desktop Lock screen
    End Sub
    Private Sub cmnu_Restore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnu_Restore.Click
        Me.Visible = True
        systrayIcon.Visible = False
    End Sub

    Private Sub cmnu_Exit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnu_Exit.Click
        Me.Hide()
        systrayIcon.Visible = False
        End
    End Sub

    Private Sub cmnu_Lock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnu_Lock.Click
        Lock.Show()
        Me.Hide()
        systrayIcon.Visible = False
    End Sub

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        If txtOldPass.Text = pass2 Then
            lblPass.Text = ("Please Enter New Password")
            txtInputPass.Visible = True
            btnEnter.Visible = True 'Shows enter button
            Me.AcceptButton = btnEnter
            btnVerify.Visible = False
            txtOldPass.Text = ""
            txtOldPass.Visible = False
            txtInputPass.Focus()
        Else : MessageBox.Show("Incorrect Password")
            txtOldPass.Text = ""
            txtOldPass.Focus()
        End If
    End Sub

    Private Sub txtOldPass_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOldPass.VisibleChanged
        Try
            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(appdata & "\" & usr & "_ld.sg") 'reads text file
            pass1 = oRead.ReadLine()
            pass2 = crypt.psDecrypt(pass1)
            oRead.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tssUsr.Text = "User: " & usr
        If IO.Directory.Exists(appdata) = False Then
            My.Computer.FileSystem.CreateDirectory(appdata)
        End If

        If IO.File.Exists(appdata & "\" & usr & "_ld.sg") = False Then
            MessageBox.Show("Please create a password")
            txtInputPass.Visible = True 'Shows textbox
            lblPass.Text = ("Please Enter New Password")
            btnVerify.Visible = False
            btnEnter.Visible = True
            btnEdit.Enabled = False
            txtInputPass.Focus()
            Me.AcceptButton = btnEnter
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Control Then
        End If
    End Sub

    Private Sub cmnu_Options_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnu_Options.Click
        Edit.ShowDialog()
    End Sub

    Private Sub EditColorsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditColorsToolStripMenuItem.Click
        Edit.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Me.Visible = False
        systrayIcon.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End 'Ends program
    End Sub

    Private Sub HideInTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideInTrayToolStripMenuItem.Click
        Me.Visible = False
        systrayIcon.Visible = True
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        frmHelp.ShowDialog()
    End Sub
End Class

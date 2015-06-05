Option Explicit On 
Imports Microsoft.Win32

Public Class frmOptions
    Inherits System.Windows.Forms.Form
    Public Lock As frmLock
    Dim regKey As RegistryKey, regSubKey As RegistryKey
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
    Friend WithEvents rbtnRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBlack As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpScrnColor As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
        Me.grpScrnColor = New System.Windows.Forms.GroupBox
        Me.rbtnBlack = New System.Windows.Forms.RadioButton
        Me.rbtnYellow = New System.Windows.Forms.RadioButton
        Me.rbtnGreen = New System.Windows.Forms.RadioButton
        Me.rbtnBlue = New System.Windows.Forms.RadioButton
        Me.rbtnRed = New System.Windows.Forms.RadioButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.grpScrnColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpScrnColor
        '
        Me.grpScrnColor.Controls.Add(Me.rbtnBlack)
        Me.grpScrnColor.Controls.Add(Me.rbtnYellow)
        Me.grpScrnColor.Controls.Add(Me.rbtnGreen)
        Me.grpScrnColor.Controls.Add(Me.rbtnBlue)
        Me.grpScrnColor.Controls.Add(Me.rbtnRed)
        Me.grpScrnColor.Location = New System.Drawing.Point(0, 32)
        Me.grpScrnColor.Name = "grpScrnColor"
        Me.grpScrnColor.Size = New System.Drawing.Size(264, 184)
        Me.grpScrnColor.TabIndex = 3
        Me.grpScrnColor.TabStop = False
        Me.grpScrnColor.Text = "Lock Screen Color"
        '
        'rbtnBlack
        '
        Me.rbtnBlack.Location = New System.Drawing.Point(16, 152)
        Me.rbtnBlack.Name = "rbtnBlack"
        Me.rbtnBlack.Size = New System.Drawing.Size(56, 24)
        Me.rbtnBlack.TabIndex = 9
        Me.rbtnBlack.Text = "Black"
        '
        'rbtnYellow
        '
        Me.rbtnYellow.Location = New System.Drawing.Point(16, 120)
        Me.rbtnYellow.Name = "rbtnYellow"
        Me.rbtnYellow.Size = New System.Drawing.Size(56, 24)
        Me.rbtnYellow.TabIndex = 8
        Me.rbtnYellow.Text = "Yellow"
        '
        'rbtnGreen
        '
        Me.rbtnGreen.Location = New System.Drawing.Point(16, 88)
        Me.rbtnGreen.Name = "rbtnGreen"
        Me.rbtnGreen.TabIndex = 7
        Me.rbtnGreen.Text = "Green(Default)"
        '
        'rbtnBlue
        '
        Me.rbtnBlue.Location = New System.Drawing.Point(16, 56)
        Me.rbtnBlue.Name = "rbtnBlue"
        Me.rbtnBlue.Size = New System.Drawing.Size(48, 24)
        Me.rbtnBlue.TabIndex = 6
        Me.rbtnBlue.Text = "Blue"
        '
        'rbtnRed
        '
        Me.rbtnRed.Location = New System.Drawing.Point(16, 24)
        Me.rbtnRed.Name = "rbtnRed"
        Me.rbtnRed.Size = New System.Drawing.Size(48, 24)
        Me.rbtnRed.TabIndex = 5
        Me.rbtnRed.Text = "Red"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(208, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 21)
        Me.btnSave.TabIndex = 10
        '
        'frmOptions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(282, 221)
        Me.Controls.Add(Me.grpScrnColor)
        Me.Controls.Add(Me.btnSave)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Opacity = 0.9
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmOptions"
        Me.TopMost = True
        Me.grpScrnColor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Shared EditColor As color
    Dim color As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EditColor = Me.BackColor 'Edit Color is whatever the form's current backcolor is
        'Saves Color
        'regKey now points to HKEY_CURRENT_USER Registry Key
        regKey = My.Computer.Registry.CurrentUser
        'Finds correct Key
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\SicherGrenzen\LockDown\")
        'Backcolor becomes saved
        My.Computer.Registry.CurrentUser.SetValue("BColor", color)
        Me.Close()
    End Sub

    Private Sub rbtnGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnGreen.CheckedChanged
        If rbtnGreen.Checked Then Me.BackColor = System.Drawing.Color.LightGreen
        color = "LightGreen"
        Me.ForeColor = System.Drawing.Color.Black
    End Sub

    Public Sub rbtnBlack_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnBlack.CheckedChanged
        If rbtnBlack.Checked Then Me.BackColor = System.Drawing.Color.Black
        color = "Black"
        Me.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub rbtnBlue_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnBlue.CheckedChanged
        If rbtnBlue.Checked Then Me.BackColor = System.Drawing.Color.Blue
        color = "Blue"
        Me.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub rbtnRed_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnRed.CheckedChanged
        If rbtnRed.Checked Then Me.BackColor = System.Drawing.Color.Red
        color = "Red"
        Me.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub rbtnYellow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnYellow.Click
        If rbtnYellow.Checked Then Me.BackColor = System.Drawing.Color.Yellow
        color = "Yellow"
        Me.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub frmOptions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'regKey now points to HKEY_CURRENT_USER Registry Key
            regKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\SicherGrenzen\LockDown\", False)
            'Finds saved color
            Dim BColor As Object = My.Computer.Registry.CurrentUser.GetValue("BColor")

            If BColor = "LightGreen" Then
                rbtnGreen.Checked = True
            ElseIf BColor = "Black" Then
                rbtnBlack.Checked = True
            ElseIf BColor = "Blue" Then
                rbtnBlue.Checked = True
            ElseIf BColor = "Red" Then
                rbtnRed.Checked = True
            ElseIf BColor = "Yellow" Then
                rbtnYellow.Checked = True
            Else : rbtnGreen.Checked = True
            End If
        Catch ex As Exception
            rbtnGreen.Checked = True
        End Try
    End Sub
End Class

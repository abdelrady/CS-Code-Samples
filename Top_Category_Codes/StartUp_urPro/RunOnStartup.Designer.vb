Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
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
	Public WithEvents cmdStartup As System.Windows.Forms.Button
	Public WithEvents cmdRegMachine As System.Windows.Forms.Button
	Public WithEvents cmdRegUser As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough(), System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdRegUser = New System.Windows.Forms.Button
        Me.cmdStartup = New System.Windows.Forms.Button
        Me.cmdRegMachine = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdRegUser
        '
        Me.cmdRegUser.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRegUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRegUser.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRegUser.Location = New System.Drawing.Point(16, 22)
        Me.cmdRegUser.Name = "cmdRegUser"
        Me.cmdRegUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRegUser.Size = New System.Drawing.Size(89, 41)
        Me.cmdRegUser.TabIndex = 0
        Me.cmdRegUser.Text = "Registry (User)"
        Me.ToolTip1.SetToolTip(Me.cmdRegUser, "Adds this program to startup only for this user.")
        Me.cmdRegUser.UseVisualStyleBackColor = False
        '
        'cmdStartup
        '
        Me.cmdStartup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStartup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStartup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStartup.Location = New System.Drawing.Point(16, 136)
        Me.cmdStartup.Name = "cmdStartup"
        Me.cmdStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStartup.Size = New System.Drawing.Size(89, 41)
        Me.cmdStartup.TabIndex = 2
        Me.cmdStartup.Text = "Startup Folder"
        Me.cmdStartup.UseVisualStyleBackColor = False
        '
        'cmdRegMachine
        '
        Me.cmdRegMachine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRegMachine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRegMachine.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegMachine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRegMachine.Location = New System.Drawing.Point(16, 80)
        Me.cmdRegMachine.Name = "cmdRegMachine"
        Me.cmdRegMachine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRegMachine.Size = New System.Drawing.Size(89, 41)
        Me.cmdRegMachine.TabIndex = 1
        Me.cmdRegMachine.Text = "Registry (Machine)"
        Me.cmdRegMachine.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(124, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(250, 197)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdStartup)
        Me.Controls.Add(Me.cmdRegMachine)
        Me.Controls.Add(Me.cmdRegUser)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Automatic Application Startup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
#End Region
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblRight = New System.Windows.Forms.Label
        Me.lblLeft = New System.Windows.Forms.Label
        Me.lblWarning = New System.Windows.Forms.Label
        Me.prgShutdown = New System.Windows.Forms.ProgressBar
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tmrShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.chkDisableBeeps = New System.Windows.Forms.CheckBox
        Me.picShutdown = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.picShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblRight)
        Me.Panel1.Controls.Add(Me.lblLeft)
        Me.Panel1.Controls.Add(Me.lblWarning)
        Me.Panel1.Controls.Add(Me.picShutdown)
        Me.Panel1.Controls.Add(Me.prgShutdown)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 120)
        Me.Panel1.TabIndex = 0
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.Color.Red
        Me.lblRight.Location = New System.Drawing.Point(305, 0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(1, 120)
        Me.lblRight.TabIndex = 5
        Me.lblRight.Text = "Label3"
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.Color.Red
        Me.lblLeft.Location = New System.Drawing.Point(0, 0)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(1, 120)
        Me.lblLeft.TabIndex = 4
        '
        'lblWarning
        '
        Me.lblWarning.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(79, 13)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(200, 44)
        Me.lblWarning.TabIndex = 3
        Me.lblWarning.Text = "This computer is scheduled to shutdown in 3:00 minutes. Click the button to Cance" & _
            "l."
        '
        'prgShutdown
        '
        Me.prgShutdown.Location = New System.Drawing.Point(17, 68)
        Me.prgShutdown.Maximum = 180
        Me.prgShutdown.Name = "prgShutdown"
        Me.prgShutdown.Size = New System.Drawing.Size(272, 12)
        Me.prgShutdown.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(113, 88)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 24)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.TabStop = False
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shutdown Warning"
        '
        'tmrShutdown
        '
        Me.tmrShutdown.Enabled = True
        Me.tmrShutdown.Interval = 1000
        '
        'chkDisableBeeps
        '
        Me.chkDisableBeeps.AutoSize = True
        Me.chkDisableBeeps.BackColor = System.Drawing.Color.Transparent
        Me.chkDisableBeeps.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisableBeeps.ForeColor = System.Drawing.Color.White
        Me.chkDisableBeeps.Location = New System.Drawing.Point(101, 173)
        Me.chkDisableBeeps.Name = "chkDisableBeeps"
        Me.chkDisableBeeps.Size = New System.Drawing.Size(104, 17)
        Me.chkDisableBeeps.TabIndex = 6
        Me.chkDisableBeeps.Text = "Disable Beeps"
        Me.chkDisableBeeps.UseVisualStyleBackColor = False
        '
        'picShutdown
        '
        Me.picShutdown.Image = Global.StartShutdown.My.Resources.Resources.StartShutdown
        Me.picShutdown.Location = New System.Drawing.Point(16, 11)
        Me.picShutdown.Name = "picShutdown"
        Me.picShutdown.Size = New System.Drawing.Size(48, 48)
        Me.picShutdown.TabIndex = 2
        Me.picShutdown.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(306, 203)
        Me.Controls.Add(Me.chkDisableBeeps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.picShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents prgShutdown As System.Windows.Forms.ProgressBar
    Friend WithEvents picShutdown As System.Windows.Forms.PictureBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents tmrShutdown As System.Windows.Forms.Timer
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents chkDisableBeeps As System.Windows.Forms.CheckBox

End Class

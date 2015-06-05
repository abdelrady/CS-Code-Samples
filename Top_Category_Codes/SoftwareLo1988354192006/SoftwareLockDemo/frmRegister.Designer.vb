<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblCustRef = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtSK1 = New System.Windows.Forms.TextBox
    Me.txtSK2 = New System.Windows.Forms.TextBox
    Me.txtSK3 = New System.Windows.Forms.TextBox
    Me.txtSK4 = New System.Windows.Forms.TextBox
    Me.btnRegister = New System.Windows.Forms.Button
    Me.btnCancel = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(18, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(469, 81)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "In order to use this software you need to contact the program's vendor and quote " & _
        "the reference below upon which you will be given a Serial Key, which you can ent" & _
        "er below to register your software."
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(28, 118)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(168, 18)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Customer Reference:"
    '
    'lblCustRef
    '
    Me.lblCustRef.AutoSize = True
    Me.lblCustRef.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCustRef.ForeColor = System.Drawing.Color.SeaGreen
    Me.lblCustRef.Location = New System.Drawing.Point(202, 118)
    Me.lblCustRef.Name = "lblCustRef"
    Me.lblCustRef.Size = New System.Drawing.Size(0, 18)
    Me.lblCustRef.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(41, 195)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(412, 18)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Enter your Serial Key below to register your software:"
    '
    'txtSK1
    '
    Me.txtSK1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtSK1.Location = New System.Drawing.Point(66, 232)
    Me.txtSK1.MaxLength = 10
    Me.txtSK1.Name = "txtSK1"
    Me.txtSK1.Size = New System.Drawing.Size(81, 26)
    Me.txtSK1.TabIndex = 4
    '
    'txtSK2
    '
    Me.txtSK2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtSK2.Location = New System.Drawing.Point(153, 232)
    Me.txtSK2.MaxLength = 10
    Me.txtSK2.Name = "txtSK2"
    Me.txtSK2.Size = New System.Drawing.Size(81, 26)
    Me.txtSK2.TabIndex = 5
    '
    'txtSK3
    '
    Me.txtSK3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtSK3.Location = New System.Drawing.Point(240, 232)
    Me.txtSK3.MaxLength = 10
    Me.txtSK3.Name = "txtSK3"
    Me.txtSK3.Size = New System.Drawing.Size(81, 26)
    Me.txtSK3.TabIndex = 6
    '
    'txtSK4
    '
    Me.txtSK4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtSK4.Location = New System.Drawing.Point(327, 232)
    Me.txtSK4.MaxLength = 10
    Me.txtSK4.Name = "txtSK4"
    Me.txtSK4.Size = New System.Drawing.Size(81, 26)
    Me.txtSK4.TabIndex = 7
    '
    'btnRegister
    '
    Me.btnRegister.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnRegister.Location = New System.Drawing.Point(240, 285)
    Me.btnRegister.Name = "btnRegister"
    Me.btnRegister.Size = New System.Drawing.Size(112, 33)
    Me.btnRegister.TabIndex = 8
    Me.btnRegister.Text = "&Register"
    Me.btnRegister.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(122, 285)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(112, 33)
    Me.btnCancel.TabIndex = 9
    Me.btnCancel.Text = "&Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'frmRegister
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(491, 330)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnRegister)
    Me.Controls.Add(Me.txtSK4)
    Me.Controls.Add(Me.txtSK3)
    Me.Controls.Add(Me.txtSK2)
    Me.Controls.Add(Me.txtSK1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lblCustRef)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRegister"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Software Registration Demo"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblCustRef As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtSK1 As System.Windows.Forms.TextBox
  Friend WithEvents txtSK2 As System.Windows.Forms.TextBox
  Friend WithEvents txtSK3 As System.Windows.Forms.TextBox
  Friend WithEvents txtSK4 As System.Windows.Forms.TextBox
  Friend WithEvents btnRegister As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class

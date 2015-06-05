<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyGen
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
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnGenKey = New System.Windows.Forms.Button
    Me.txtAppName = New System.Windows.Forms.TextBox
    Me.txtAppPassword = New System.Windows.Forms.TextBox
    Me.txtCustRef = New System.Windows.Forms.TextBox
    Me.chkSaveToFile = New System.Windows.Forms.CheckBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtSerialKey = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.rbMD5 = New System.Windows.Forms.RadioButton
    Me.rbSHA1 = New System.Windows.Forms.RadioButton
    Me.rbSHA256 = New System.Windows.Forms.RadioButton
    Me.rbSHA384 = New System.Windows.Forms.RadioButton
    Me.rbSHA512 = New System.Windows.Forms.RadioButton
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(21, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(143, 18)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Application Name:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(21, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(171, 18)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Application Password:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(21, 115)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(168, 18)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Customer Reference:"
    '
    'btnGenKey
    '
    Me.btnGenKey.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnGenKey.Location = New System.Drawing.Point(36, 260)
    Me.btnGenKey.Name = "btnGenKey"
    Me.btnGenKey.Size = New System.Drawing.Size(181, 29)
    Me.btnGenKey.TabIndex = 5
    Me.btnGenKey.Text = "Generate Serial Key"
    Me.btnGenKey.UseVisualStyleBackColor = True
    '
    'txtAppName
    '
    Me.txtAppName.Location = New System.Drawing.Point(202, 28)
    Me.txtAppName.Name = "txtAppName"
    Me.txtAppName.Size = New System.Drawing.Size(257, 26)
    Me.txtAppName.TabIndex = 0
    '
    'txtAppPassword
    '
    Me.txtAppPassword.Location = New System.Drawing.Point(202, 70)
    Me.txtAppPassword.Name = "txtAppPassword"
    Me.txtAppPassword.Size = New System.Drawing.Size(257, 26)
    Me.txtAppPassword.TabIndex = 1
    '
    'txtCustRef
    '
    Me.txtCustRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCustRef.Location = New System.Drawing.Point(202, 112)
    Me.txtCustRef.Name = "txtCustRef"
    Me.txtCustRef.Size = New System.Drawing.Size(257, 26)
    Me.txtCustRef.TabIndex = 2
    '
    'chkSaveToFile
    '
    Me.chkSaveToFile.AutoSize = True
    Me.chkSaveToFile.Location = New System.Drawing.Point(347, 264)
    Me.chkSaveToFile.Name = "chkSaveToFile"
    Me.chkSaveToFile.Size = New System.Drawing.Size(114, 22)
    Me.chkSaveToFile.TabIndex = 4
    Me.chkSaveToFile.Text = "Save to File"
    Me.chkSaveToFile.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(21, 191)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(88, 18)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Serial Key:"
    '
    'txtSerialKey
    '
    Me.txtSerialKey.BackColor = System.Drawing.SystemColors.InactiveCaptionText
    Me.txtSerialKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtSerialKey.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerialKey.ForeColor = System.Drawing.Color.Crimson
    Me.txtSerialKey.Location = New System.Drawing.Point(202, 188)
    Me.txtSerialKey.Name = "txtSerialKey"
    Me.txtSerialKey.ReadOnly = True
    Me.txtSerialKey.Size = New System.Drawing.Size(257, 29)
    Me.txtSerialKey.TabIndex = 3
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.rbSHA512)
    Me.GroupBox1.Controls.Add(Me.rbSHA384)
    Me.GroupBox1.Controls.Add(Me.rbSHA256)
    Me.GroupBox1.Controls.Add(Me.rbSHA1)
    Me.GroupBox1.Controls.Add(Me.rbMD5)
    Me.GroupBox1.Location = New System.Drawing.Point(486, 28)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(110, 258)
    Me.GroupBox1.TabIndex = 10
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Hashes:"
    '
    'rbMD5
    '
    Me.rbMD5.AutoSize = True
    Me.rbMD5.Checked = True
    Me.rbMD5.Location = New System.Drawing.Point(14, 41)
    Me.rbMD5.Name = "rbMD5"
    Me.rbMD5.Size = New System.Drawing.Size(60, 22)
    Me.rbMD5.TabIndex = 0
    Me.rbMD5.TabStop = True
    Me.rbMD5.Text = "MD5"
    Me.rbMD5.UseVisualStyleBackColor = True
    '
    'rbSHA1
    '
    Me.rbSHA1.AutoSize = True
    Me.rbSHA1.Location = New System.Drawing.Point(14, 83)
    Me.rbSHA1.Name = "rbSHA1"
    Me.rbSHA1.Size = New System.Drawing.Size(67, 22)
    Me.rbSHA1.TabIndex = 1
    Me.rbSHA1.TabStop = True
    Me.rbSHA1.Text = "SHA1"
    Me.rbSHA1.UseVisualStyleBackColor = True
    '
    'rbSHA256
    '
    Me.rbSHA256.AutoSize = True
    Me.rbSHA256.Location = New System.Drawing.Point(14, 125)
    Me.rbSHA256.Name = "rbSHA256"
    Me.rbSHA256.Size = New System.Drawing.Size(87, 22)
    Me.rbSHA256.TabIndex = 2
    Me.rbSHA256.TabStop = True
    Me.rbSHA256.Text = "SHA256"
    Me.rbSHA256.UseVisualStyleBackColor = True
    '
    'rbSHA384
    '
    Me.rbSHA384.AutoSize = True
    Me.rbSHA384.Location = New System.Drawing.Point(14, 167)
    Me.rbSHA384.Name = "rbSHA384"
    Me.rbSHA384.Size = New System.Drawing.Size(87, 22)
    Me.rbSHA384.TabIndex = 3
    Me.rbSHA384.TabStop = True
    Me.rbSHA384.Text = "SHA384"
    Me.rbSHA384.UseVisualStyleBackColor = True
    '
    'rbSHA512
    '
    Me.rbSHA512.AutoSize = True
    Me.rbSHA512.Location = New System.Drawing.Point(14, 210)
    Me.rbSHA512.Name = "rbSHA512"
    Me.rbSHA512.Size = New System.Drawing.Size(87, 22)
    Me.rbSHA512.TabIndex = 4
    Me.rbSHA512.TabStop = True
    Me.rbSHA512.Text = "SHA512"
    Me.rbSHA512.UseVisualStyleBackColor = True
    '
    'frmKeyGen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(621, 315)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.txtSerialKey)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.chkSaveToFile)
    Me.Controls.Add(Me.txtCustRef)
    Me.Controls.Add(Me.txtAppPassword)
    Me.Controls.Add(Me.txtAppName)
    Me.Controls.Add(Me.btnGenKey)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmKeyGen"
    Me.Text = "SoftwareLock Key-Generator"
    Me.TopMost = True
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnGenKey As System.Windows.Forms.Button
  Friend WithEvents txtAppName As System.Windows.Forms.TextBox
  Friend WithEvents txtAppPassword As System.Windows.Forms.TextBox
  Friend WithEvents txtCustRef As System.Windows.Forms.TextBox
  Friend WithEvents chkSaveToFile As System.Windows.Forms.CheckBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtSerialKey As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents rbSHA512 As System.Windows.Forms.RadioButton
  Friend WithEvents rbSHA384 As System.Windows.Forms.RadioButton
  Friend WithEvents rbSHA256 As System.Windows.Forms.RadioButton
  Friend WithEvents rbSHA1 As System.Windows.Forms.RadioButton
  Friend WithEvents rbMD5 As System.Windows.Forms.RadioButton

End Class

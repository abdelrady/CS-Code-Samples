<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmbRead = New System.Windows.Forms.Button
        Me.grpPortReading = New System.Windows.Forms.GroupBox
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.lbl2 = New System.Windows.Forms.Label
        Me.txtReadAdd = New System.Windows.Forms.TextBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.grpPortWriting = New System.Windows.Forms.GroupBox
        Me.cmdNone = New System.Windows.Forms.Button
        Me.cmdAll = New System.Windows.Forms.Button
        Me.txtWriteVal = New System.Windows.Forms.TextBox
        Me.cmbWrite = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWriteAdd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpSurvualance = New System.Windows.Forms.GroupBox
        Me.soundBox = New System.Windows.Forms.ComboBox
        Me.openBtn = New System.Windows.Forms.Button
        Me.txtSurStat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSurPort = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.grpPortReading.SuspendLayout()
        Me.grpPortWriting.SuspendLayout()
        Me.grpSurvualance.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbRead
        '
        Me.cmbRead.Location = New System.Drawing.Point(268, 39)
        Me.cmbRead.Name = "cmbRead"
        Me.cmbRead.Size = New System.Drawing.Size(110, 29)
        Me.cmbRead.TabIndex = 0
        Me.cmbRead.Text = "Read Status"
        Me.cmbRead.UseVisualStyleBackColor = True
        '
        'grpPortReading
        '
        Me.grpPortReading.Controls.Add(Me.txtStatus)
        Me.grpPortReading.Controls.Add(Me.cmbRead)
        Me.grpPortReading.Controls.Add(Me.lbl2)
        Me.grpPortReading.Controls.Add(Me.txtReadAdd)
        Me.grpPortReading.Controls.Add(Me.lbl1)
        Me.grpPortReading.Location = New System.Drawing.Point(12, 12)
        Me.grpPortReading.Name = "grpPortReading"
        Me.grpPortReading.Size = New System.Drawing.Size(388, 82)
        Me.grpPortReading.TabIndex = 2
        Me.grpPortReading.TabStop = False
        Me.grpPortReading.Text = "Port Reading Section"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(88, 47)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 5
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(12, 50)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(62, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Port Status:"
        '
        'txtReadAdd
        '
        Me.txtReadAdd.Location = New System.Drawing.Point(88, 21)
        Me.txtReadAdd.Name = "txtReadAdd"
        Me.txtReadAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtReadAdd.TabIndex = 3
        Me.txtReadAdd.Text = "889"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(70, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Port Address:"
        '
        'grpPortWriting
        '
        Me.grpPortWriting.Controls.Add(Me.cmdNone)
        Me.grpPortWriting.Controls.Add(Me.cmdAll)
        Me.grpPortWriting.Controls.Add(Me.txtWriteVal)
        Me.grpPortWriting.Controls.Add(Me.cmbWrite)
        Me.grpPortWriting.Controls.Add(Me.Label1)
        Me.grpPortWriting.Controls.Add(Me.txtWriteAdd)
        Me.grpPortWriting.Controls.Add(Me.Label2)
        Me.grpPortWriting.Location = New System.Drawing.Point(12, 106)
        Me.grpPortWriting.Name = "grpPortWriting"
        Me.grpPortWriting.Size = New System.Drawing.Size(388, 82)
        Me.grpPortWriting.TabIndex = 3
        Me.grpPortWriting.TabStop = False
        Me.grpPortWriting.Text = "Port Writing Section"
        '
        'cmdNone
        '
        Me.cmdNone.Location = New System.Drawing.Point(194, 48)
        Me.cmdNone.Name = "cmdNone"
        Me.cmdNone.Size = New System.Drawing.Size(44, 21)
        Me.cmdNone.TabIndex = 7
        Me.cmdNone.Text = "None"
        Me.cmdNone.UseVisualStyleBackColor = True
        '
        'cmdAll
        '
        Me.cmdAll.Location = New System.Drawing.Point(194, 21)
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.Size = New System.Drawing.Size(44, 21)
        Me.cmdAll.TabIndex = 6
        Me.cmdAll.Text = "ALL"
        Me.cmdAll.UseVisualStyleBackColor = True
        '
        'txtWriteVal
        '
        Me.txtWriteVal.Location = New System.Drawing.Point(88, 47)
        Me.txtWriteVal.Name = "txtWriteVal"
        Me.txtWriteVal.Size = New System.Drawing.Size(100, 20)
        Me.txtWriteVal.TabIndex = 5
        '
        'cmbWrite
        '
        Me.cmbWrite.Location = New System.Drawing.Point(268, 39)
        Me.cmbWrite.Name = "cmbWrite"
        Me.cmbWrite.Size = New System.Drawing.Size(110, 29)
        Me.cmbWrite.TabIndex = 0
        Me.cmbWrite.Text = "Write"
        Me.cmbWrite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Value to write:"
        '
        'txtWriteAdd
        '
        Me.txtWriteAdd.Location = New System.Drawing.Point(88, 21)
        Me.txtWriteAdd.Name = "txtWriteAdd"
        Me.txtWriteAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtWriteAdd.TabIndex = 3
        Me.txtWriteAdd.Text = "888"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port Address:"
        '
        'grpSurvualance
        '
        Me.grpSurvualance.Controls.Add(Me.soundBox)
        Me.grpSurvualance.Controls.Add(Me.openBtn)
        Me.grpSurvualance.Controls.Add(Me.txtSurStat)
        Me.grpSurvualance.Controls.Add(Me.Label4)
        Me.grpSurvualance.Controls.Add(Me.txtSurPort)
        Me.grpSurvualance.Controls.Add(Me.Label3)
        Me.grpSurvualance.Controls.Add(Me.Button1)
        Me.grpSurvualance.Location = New System.Drawing.Point(12, 199)
        Me.grpSurvualance.Name = "grpSurvualance"
        Me.grpSurvualance.Size = New System.Drawing.Size(388, 184)
        Me.grpSurvualance.TabIndex = 4
        Me.grpSurvualance.TabStop = False
        Me.grpSurvualance.Text = "Example Survialance System :-)"
        '
        'soundBox
        '
        Me.soundBox.Location = New System.Drawing.Point(15, 100)
        Me.soundBox.Name = "soundBox"
        Me.soundBox.Size = New System.Drawing.Size(353, 21)
        Me.soundBox.TabIndex = 10
        Me.soundBox.Text = "C:\WINDOWS\Media\\Windows XP Logoff Sound.wav"
        '
        'openBtn
        '
        Me.openBtn.Location = New System.Drawing.Point(15, 71)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Size = New System.Drawing.Size(75, 23)
        Me.openBtn.TabIndex = 9
        Me.openBtn.Text = "Open File"
        '
        'txtSurStat
        '
        Me.txtSurStat.Location = New System.Drawing.Point(268, 20)
        Me.txtSurStat.Name = "txtSurStat"
        Me.txtSurStat.ReadOnly = True
        Me.txtSurStat.Size = New System.Drawing.Size(100, 20)
        Me.txtSurStat.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Port Status:"
        '
        'txtSurPort
        '
        Me.txtSurPort.Location = New System.Drawing.Point(88, 19)
        Me.txtSurPort.Name = "txtSurPort"
        Me.txtSurPort.Size = New System.Drawing.Size(100, 20)
        Me.txtSurPort.TabIndex = 5
        Me.txtSurPort.Text = "889"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Port Address:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(6, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Activate!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'openFileDialog1
        '
        Me.openFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*"
        Me.openFileDialog1.InitialDirectory = "c:\\"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 393)
        Me.Controls.Add(Me.grpSurvualance)
        Me.Controls.Add(Me.grpPortWriting)
        Me.Controls.Add(Me.grpPortReading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infrasoft Port Access Example Application"
        Me.TopMost = True
        Me.grpPortReading.ResumeLayout(False)
        Me.grpPortReading.PerformLayout()
        Me.grpPortWriting.ResumeLayout(False)
        Me.grpPortWriting.PerformLayout()
        Me.grpSurvualance.ResumeLayout(False)
        Me.grpSurvualance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbRead As System.Windows.Forms.Button
    Friend WithEvents grpPortReading As System.Windows.Forms.GroupBox
    Friend WithEvents txtReadAdd As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents grpPortWriting As System.Windows.Forms.GroupBox
    Friend WithEvents txtWriteVal As System.Windows.Forms.TextBox
    Friend WithEvents cmbWrite As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWriteAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpSurvualance As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNone As System.Windows.Forms.Button
    Friend WithEvents cmdAll As System.Windows.Forms.Button
    Friend WithEvents txtSurPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtSurStat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents soundBox As System.Windows.Forms.ComboBox
    Private WithEvents openBtn As System.Windows.Forms.Button
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class

Public Class Form1
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
    Friend WithEvents ButtonArrayProvider1 As howto_net_control_arrray.ButtonArrayProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkInArray As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowButtons As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.chkInArray = New System.Windows.Forms.CheckBox
        Me.chkShowButtons = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        '
        'chkInArray
        '
        Me.chkInArray.Checked = True
        Me.chkInArray.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInArray.Location = New System.Drawing.Point(88, 88)
        Me.chkInArray.Name = "chkInArray"
        Me.chkInArray.Size = New System.Drawing.Size(120, 16)
        Me.chkInArray.TabIndex = 5
        Me.chkInArray.Text = "Button2 In Array"
        '
        'chkShowButtons
        '
        Me.chkShowButtons.Checked = True
        Me.chkShowButtons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowButtons.Location = New System.Drawing.Point(88, 32)
        Me.chkShowButtons.Name = "chkShowButtons"
        Me.chkShowButtons.Size = New System.Drawing.Size(120, 16)
        Me.chkShowButtons.TabIndex = 6
        Me.chkShowButtons.Text = "Show Buttons"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 181)
        Me.Controls.Add(Me.chkShowButtons)
        Me.Controls.Add(Me.chkInArray)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonArrayProvider1_Click(ByVal Index As System.Int32) Handles ButtonArrayProvider1.Click
        MessageBox.Show("Button " & Index & " clicked", _
            "Click", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
    End Sub

    Private Sub chkInArray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInArray.CheckedChanged
        If chkInArray.Checked Then
            ButtonArrayProvider1.SetArrayIndex(Button2, 2)
        Else
            ButtonArrayProvider1.SetArrayIndex(Button2, -1)
        End If
    End Sub

    ' Show or hide the buttons.
    Private Sub chkShowButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowButtons.CheckedChanged
        If chkShowButtons.Checked Then
            For Each ctl As Control In ButtonArrayProvider1.Controls()
                ctl.Visible = True
            Next ctl
        Else
            For Each ctl As Control In ButtonArrayProvider1.Controls()
                ctl.Visible = False
            Next ctl
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class

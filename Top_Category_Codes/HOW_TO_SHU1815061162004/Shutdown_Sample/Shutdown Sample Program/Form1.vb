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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Shutdown"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Restart"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Logoff"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 24)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Abort"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 160)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reguler Command"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(232, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Shutdown and warn the user with message"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(232, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 40)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Shutdown with custom delay"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(232, 112)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(160, 40)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Shutdown another machine"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(224, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Programmed by Indra Kurniawan"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 214)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Shutdown Sample Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("Shutdown", "/s")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("Shutdown", "/r")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("Shutdown", "/l")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("Shutdown", "/a")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Shell("Shutdown /s /c GoodBye!!!")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("Shutdown", "/s /t 60")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("Shutdown", "/s /m my_network_machine")
        ' you should change argument "my_network_machine" 
        ' with your own network machine name. it's just an example
    End Sub
End Class

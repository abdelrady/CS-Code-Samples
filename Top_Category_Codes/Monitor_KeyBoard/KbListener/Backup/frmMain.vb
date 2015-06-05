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
    Friend WithEvents btnListen As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(8, 8)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(112, 120)
        Me.btnListen.TabIndex = 0
        Me.btnListen.Text = "Click on this button to start listening to the keyboard events. If Escape key is " & _
        "pressed anywhere a message box will come up..."
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(128, 8)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 120)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Click on this button to stop  listening ..."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(250, 136)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnListen, Me.btnStop})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Keyboard Listener"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim WithEvents obj As New cKBHook()

    Private Sub obj_KeyPressed(ByVal KeyChar As Integer) Handles obj.KeyPressed
        If KeyChar = Keys.Escape Then MsgBox("Escape key pressed")
    End Sub

    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click
        obj.Listen()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        obj.StopListening()
    End Sub
End Class

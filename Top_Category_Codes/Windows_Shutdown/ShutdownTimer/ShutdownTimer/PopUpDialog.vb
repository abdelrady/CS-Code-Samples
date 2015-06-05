Public Class PopUpDialog
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
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VisualStyleProvider1 As Skybound.VisualStyles.VisualStyleProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnStop = New System.Windows.Forms.Button
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.VisualStyleProvider1 = New Skybound.VisualStyles.VisualStyleProvider
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnStop.Location = New System.Drawing.Point(264, 88)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.btnStop, True)
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(16, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(176, 23)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "System will shutdown in "
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.lbl1, True)
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(256, 32)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(64, 23)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Seconds"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.lbl2, True)
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(192, 32)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(56, 23)
        Me.lblTime.TabIndex = 4
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.lblTime, True)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Press Cancel to Stop the timer"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.Label1, True)
        '
        'PopUpDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(360, 126)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnStop)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpDialog"
        Me.Text = "System Shutdown Warning"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim main As main

    Private Sub PopUpDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Public Property setTimeLabel() As Integer
        Get
            Return CInt(Val(Me.lblTime.Text))
        End Get
        Set(ByVal Value As Integer)
            lblTime.Text = Value
        End Set
    End Property


    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Me.Close()
        main.Timer1.Stop()
    End Sub
End Class

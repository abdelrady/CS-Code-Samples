Public Class Form4
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents L5 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents L6 As System.Windows.Forms.Label
    Friend WithEvents LPer3 As System.Windows.Forms.Label
    Friend WithEvents LPer2 As System.Windows.Forms.Label
    Friend WithEvents LPer1 As System.Windows.Forms.Label
    Friend WithEvents pBar1 As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.L1 = New System.Windows.Forms.Label
        Me.L3 = New System.Windows.Forms.Label
        Me.L5 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.L4 = New System.Windows.Forms.Label
        Me.L6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LPer3 = New System.Windows.Forms.Label
        Me.LPer2 = New System.Windows.Forms.Label
        Me.LPer1 = New System.Windows.Forms.Label
        Me.pBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Navy
        Me.L1.Location = New System.Drawing.Point(92, 52)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(86, 23)
        Me.L1.TabIndex = 0
        Me.L1.Text = "ﬁ«∆„… √—ﬁ«„1"
        '
        'L3
        '
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L3.ForeColor = System.Drawing.Color.Navy
        Me.L3.Location = New System.Drawing.Point(92, 82)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(86, 23)
        Me.L3.TabIndex = 1
        Me.L3.Text = "ﬁ«∆„… √—ﬁ«„2"
        '
        'L5
        '
        Me.L5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L5.ForeColor = System.Drawing.Color.Navy
        Me.L5.Location = New System.Drawing.Point(92, 116)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(86, 23)
        Me.L5.TabIndex = 2
        Me.L5.Text = "ﬁ«∆„… √—ﬁ«„3"
        '
        'L2
        '
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Navy
        Me.L2.Location = New System.Drawing.Point(197, 52)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(30, 23)
        Me.L2.TabIndex = 3
        Me.L2.Text = "<<"
        Me.L2.Visible = False
        '
        'L4
        '
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L4.ForeColor = System.Drawing.Color.Navy
        Me.L4.Location = New System.Drawing.Point(197, 82)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(30, 23)
        Me.L4.TabIndex = 4
        Me.L4.Text = "<<"
        Me.L4.Visible = False
        '
        'L6
        '
        Me.L6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L6.ForeColor = System.Drawing.Color.Navy
        Me.L6.Location = New System.Drawing.Point(197, 116)
        Me.L6.Name = "L6"
        Me.L6.Size = New System.Drawing.Size(30, 23)
        Me.L6.TabIndex = 5
        Me.L6.Text = "<<"
        Me.L6.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(91, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "«·—Ã«¡ «·≈‰ Ÿ«— »Ì‰„« Ì „  ⁄»√… «·»Ì«‰« "
        '
        'LPer3
        '
        Me.LPer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LPer3.Location = New System.Drawing.Point(15, 116)
        Me.LPer3.Name = "LPer3"
        Me.LPer3.Size = New System.Drawing.Size(64, 23)
        Me.LPer3.TabIndex = 7
        '
        'LPer2
        '
        Me.LPer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LPer2.Location = New System.Drawing.Point(15, 82)
        Me.LPer2.Name = "LPer2"
        Me.LPer2.Size = New System.Drawing.Size(64, 23)
        Me.LPer2.TabIndex = 8
        '
        'LPer1
        '
        Me.LPer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LPer1.Location = New System.Drawing.Point(15, 52)
        Me.LPer1.Name = "LPer1"
        Me.LPer1.Size = New System.Drawing.Size(64, 23)
        Me.LPer1.TabIndex = 9
        '
        'pBar1
        '
        Me.pBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBar1.Location = New System.Drawing.Point(0, 163)
        Me.pBar1.Name = "pBar1"
        Me.pBar1.Size = New System.Drawing.Size(304, 11)
        Me.pBar1.TabIndex = 10
        Me.pBar1.Visible = False
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(207, Byte), CType(249, Byte))
        Me.ClientSize = New System.Drawing.Size(304, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.pBar1)
        Me.Controls.Add(Me.LPer1)
        Me.Controls.Add(Me.LPer2)
        Me.Controls.Add(Me.LPer3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.L6)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L5)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class

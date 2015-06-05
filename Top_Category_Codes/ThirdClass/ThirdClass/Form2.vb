Public Class Form2
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(282, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "ﬁ«∆„… √—ﬁ«„1"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Location = New System.Drawing.Point(122, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox1.TabIndex = 225
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(286, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "ﬁ«∆„… √—ﬁ«„2"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.Location = New System.Drawing.Point(126, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox2.TabIndex = 227
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(286, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "ﬁ«∆„… √—ﬁ«„3"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.ComboBox3.Location = New System.Drawing.Point(126, 214)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox3.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox3.TabIndex = 229
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(488, 342)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim x As New Form4
    Dim Parts, Persentage As Int64

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x.pBar1.Visible = True
        x.pBar1.Maximum = 3
        x.pBar1.Step = 1


        x.Show()
        Application.DoEvents()

        x.pBar1.PerformStep()
        FillCB1()
        x.pBar1.PerformStep()
        FillCB2()
        x.pBar1.PerformStep()
        FillCB3()

        x.pBar1.Visible = False
        x.Close()
    End Sub

    Private Sub FillCB1()
        Dim i As Int64 = 0

        x.L2.Visible = True
        x.L2.ForeColor = Color.Red
        x.L1.ForeColor = Color.Red
        Application.DoEvents()

        Persentage = 0
        Parts = 100000 / 100
        Do While i < 100000
            If i Mod Parts = 0 Then
                Persentage += 1
                x.LPer1.Text = Persentage & " %"
                Application.DoEvents()
            End If
            Me.ComboBox1.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub FillCB2()
        Dim i As Int64 = 0

        x.L4.Visible = True
        x.L2.Visible = False
        x.L4.ForeColor = Color.Red
        x.L3.ForeColor = Color.Red
        x.L2.ForeColor = Color.Navy
        x.L1.ForeColor = Color.Navy
        Application.DoEvents()

        Persentage = 0
        Parts = 100000 / 100
        Do While i < 100000
            If i Mod Parts = 0 Then
                Persentage += 1
                x.LPer2.Text = Persentage & " %"
                Application.DoEvents()
            End If
            Me.ComboBox2.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub FillCB3()
        Dim i As Int64 = 0

        x.L6.Visible = True
        x.L4.Visible = False
        x.L6.ForeColor = Color.Red
        x.L5.ForeColor = Color.Red
        x.L4.ForeColor = Color.Navy
        x.L3.ForeColor = Color.Navy
        Application.DoEvents()

        Persentage = 0
        Parts = 100000 / 100
        Do While i < 100000
            If i Mod Parts = 0 Then
                Persentage += 1
                x.LPer3.Text = Persentage & " %"
                Application.DoEvents()
            End If
            Me.ComboBox3.Items.Add(i)
            i += 1
        Loop
    End Sub

End Class

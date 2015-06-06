Public Class frmMainMenu
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
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnHousekeeping As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMainMenu))
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnHousekeeping = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.White
        Me.btnTransaction.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.Image = CType(resources.GetObject("btnTransaction.Image"), System.Drawing.Bitmap)
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.Location = New System.Drawing.Point(320, 144)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(152, 40)
        Me.btnTransaction.TabIndex = 4
        Me.btnTransaction.Text = "    Transaction"
        '
        'btnHousekeeping
        '
        Me.btnHousekeeping.BackColor = System.Drawing.Color.White
        Me.btnHousekeeping.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHousekeeping.ForeColor = System.Drawing.Color.Black
        Me.btnHousekeeping.Image = CType(resources.GetObject("btnHousekeeping.Image"), System.Drawing.Bitmap)
        Me.btnHousekeeping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHousekeeping.Location = New System.Drawing.Point(320, 248)
        Me.btnHousekeeping.Name = "btnHousekeeping"
        Me.btnHousekeeping.Size = New System.Drawing.Size(152, 40)
        Me.btnHousekeeping.TabIndex = 5
        Me.btnHousekeeping.Text = "     Housekeeping"
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.White
        Me.btnReport.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(320, 352)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(152, 40)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Report"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Bitmap)
        Me.btnQuit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnQuit.Location = New System.Drawing.Point(664, 496)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 40)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "    Quit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(216, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnLogOff
        '
        Me.btnLogOff.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOff.Image = CType(resources.GetObject("btnLogOff.Image"), System.Drawing.Bitmap)
        Me.btnLogOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOff.Location = New System.Drawing.Point(544, 496)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(104, 40)
        Me.btnLogOff.TabIndex = 15
        Me.btnLogOff.Text = "    Log Off"
        '
        'frmMainMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnLogOff, Me.PictureBox1, Me.Label1, Me.PictureBox2, Me.btnQuit, Me.btnReport, Me.btnHousekeeping, Me.btnTransaction})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If


    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        cur = New frmTransaction()
        cur.Show()
        Me.Dispose()
    End Sub

    Private Sub btnHousekeeping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHousekeeping.Click
        cur = New frmHousekeeping_Main()
        cur.Show()
        Me.Dispose()

    End Sub



    Private Sub frmMainMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If



    End Sub

    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        intResponse = MessageBox.Show("Are you sure want to log off ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.Yes Then
            cur = New frmLogin()
            cur.Show()
            Me.Dispose()

        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        cur = New frmReport_Main()
        cur.Show()
        Me.Dispose()
    End Sub
End Class

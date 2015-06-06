Public Class frmHousekeeping_Main
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnItemMaster As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCompro As System.Windows.Forms.Button
    Friend WithEvents btnUserAccount As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHousekeeping_Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnItemMaster = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCompro = New System.Windows.Forms.Button()
        Me.btnUserAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(224, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnItemMaster
        '
        Me.btnItemMaster.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemMaster.ForeColor = System.Drawing.Color.Black
        Me.btnItemMaster.Image = CType(resources.GetObject("btnItemMaster.Image"), System.Drawing.Bitmap)
        Me.btnItemMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemMaster.Location = New System.Drawing.Point(312, 128)
        Me.btnItemMaster.Name = "btnItemMaster"
        Me.btnItemMaster.Size = New System.Drawing.Size(176, 40)
        Me.btnItemMaster.TabIndex = 18
        Me.btnItemMaster.Text = "     Item Master"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(312, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(176, 40)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "    Exit"
        '
        'btnCompro
        '
        Me.btnCompro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCompro.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompro.ForeColor = System.Drawing.Color.Black
        Me.btnCompro.Image = CType(resources.GetObject("btnCompro.Image"), System.Drawing.Bitmap)
        Me.btnCompro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompro.Location = New System.Drawing.Point(312, 216)
        Me.btnCompro.Name = "btnCompro"
        Me.btnCompro.Size = New System.Drawing.Size(176, 40)
        Me.btnCompro.TabIndex = 23
        Me.btnCompro.Text = "    Company Profile"
        '
        'btnUserAccount
        '
        Me.btnUserAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserAccount.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccount.ForeColor = System.Drawing.Color.Black
        Me.btnUserAccount.Image = CType(resources.GetObject("btnUserAccount.Image"), System.Drawing.Bitmap)
        Me.btnUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAccount.Location = New System.Drawing.Point(312, 304)
        Me.btnUserAccount.Name = "btnUserAccount"
        Me.btnUserAccount.Size = New System.Drawing.Size(176, 40)
        Me.btnUserAccount.TabIndex = 24
        Me.btnUserAccount.Text = "    User Account"
        '
        'frmHousekeeping_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnUserAccount, Me.btnCompro, Me.btnExit, Me.btnItemMaster, Me.Label1, Me.PictureBox2, Me.PictureBox1})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHousekeeping_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Housekeeping - Main Screen"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnItemMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemMaster.Click
        cur = New frmHousekeeping_ItemMaster()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        cur = New frmMainMenu()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub frmHousekeeping_Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If
    End Sub

    
    
    Private Sub btnCompro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompro.Click
        cur = New frmCompany()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnUserAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAccount.Click
        cur = New frmNewAccount()
        cur.Show()
        Me.Dispose()

    End Sub
End Class

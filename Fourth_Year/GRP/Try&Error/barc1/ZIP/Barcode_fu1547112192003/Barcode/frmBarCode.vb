Public Class frmBarCode
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
    Friend WithEvents txtEAN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDrawBarCode As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBarCode))
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDrawBarCode = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'txtEAN
        '
        Me.txtEAN.Location = New System.Drawing.Point(50, 8)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(213, 20)
        Me.txtEAN.TabIndex = 0
        Me.txtEAN.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code :"
        '
        'btnDrawBarCode
        '
        Me.btnDrawBarCode.Location = New System.Drawing.Point(270, 8)
        Me.btnDrawBarCode.Name = "btnDrawBarCode"
        Me.btnDrawBarCode.Size = New System.Drawing.Size(44, 20)
        Me.btnDrawBarCode.TabIndex = 2
        Me.btnDrawBarCode.Text = "Draw"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(11, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 138)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmBarCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 186)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.btnDrawBarCode, Me.Label1, Me.txtEAN})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode EAN 8 / EAN 13"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnDrawBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawBarCode.Click

        Try
            Call PrintEANBarCode(Me.txtEAN.Text, Me.PictureBox1, 10, 10, Me.PictureBox1.Width - 20, Me.PictureBox1.Height - 20)
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, Application.ProductName)
        End Try

    End Sub

End Class

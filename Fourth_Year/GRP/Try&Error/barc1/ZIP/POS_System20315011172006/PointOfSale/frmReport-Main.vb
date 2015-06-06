Public Class frmReport_Main
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
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRptItemMaster As System.Windows.Forms.Button
    Friend WithEvents btnRptBillSale As System.Windows.Forms.Button
    Friend WithEvents btnRptItemSale As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReport_Main))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRptItemMaster = New System.Windows.Forms.Button()
        Me.btnRptBillSale = New System.Windows.Forms.Button()
        Me.btnRptItemSale = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
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
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRptItemMaster
        '
        Me.btnRptItemMaster.BackColor = System.Drawing.Color.White
        Me.btnRptItemMaster.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptItemMaster.Image = CType(resources.GetObject("btnRptItemMaster.Image"), System.Drawing.Bitmap)
        Me.btnRptItemMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRptItemMaster.Location = New System.Drawing.Point(304, 128)
        Me.btnRptItemMaster.Name = "btnRptItemMaster"
        Me.btnRptItemMaster.Size = New System.Drawing.Size(216, 40)
        Me.btnRptItemMaster.TabIndex = 1
        Me.btnRptItemMaster.Text = "   Report - Item Master"
        '
        'btnRptBillSale
        '
        Me.btnRptBillSale.BackColor = System.Drawing.Color.White
        Me.btnRptBillSale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptBillSale.Image = CType(resources.GetObject("btnRptBillSale.Image"), System.Drawing.Bitmap)
        Me.btnRptBillSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRptBillSale.Location = New System.Drawing.Point(304, 232)
        Me.btnRptBillSale.Name = "btnRptBillSale"
        Me.btnRptBillSale.Size = New System.Drawing.Size(216, 40)
        Me.btnRptBillSale.TabIndex = 2
        Me.btnRptBillSale.Text = "   Report -Sale By Bill"
        '
        'btnRptItemSale
        '
        Me.btnRptItemSale.BackColor = System.Drawing.Color.White
        Me.btnRptItemSale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptItemSale.Image = CType(resources.GetObject("btnRptItemSale.Image"), System.Drawing.Bitmap)
        Me.btnRptItemSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRptItemSale.Location = New System.Drawing.Point(304, 336)
        Me.btnRptItemSale.Name = "btnRptItemSale"
        Me.btnRptItemSale.Size = New System.Drawing.Size(216, 40)
        Me.btnRptItemSale.TabIndex = 31
        Me.btnRptItemSale.Text = "   Report -Sale By Item"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Bitmap)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(640, 480)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 48)
        Me.btnClose.TabIndex = 47
        Me.btnClose.Text = "    Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'frmReport_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.btnClose, Me.btnRptItemSale, Me.btnRptBillSale, Me.btnRptItemMaster, Me.Label1, Me.PictureBox2})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report-Main Screen"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        cur = New frmMainMenu()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnRptItemMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptItemMaster.Click
        cur = New frmReport_Item()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnRptBillSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptBillSale.Click
        cur = New frmReport_BillSale()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnRptItemSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptItemSale.Click
        cur = New frmReport_itemsale()
        cur.Show()
        Me.Dispose()

    End Sub
End Class

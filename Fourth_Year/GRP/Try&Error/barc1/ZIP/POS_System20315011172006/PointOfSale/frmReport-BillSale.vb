Public Class frmReport_BillSale
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsBillSale1 As PointOfSale.DsBillSale
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReport_BillSale))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsBillSale1 = New PointOfSale.DsBillSale()
        CType(Me.DsBillSale1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(784, 480)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(368, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 32)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AllSale", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BillNo", "BillNo"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("Tax", "Tax"), New System.Data.Common.DataColumnMapping("GrandTotal", "GrandTotal"), New System.Data.Common.DataColumnMapping("SaleDate", "SaleDate"), New System.Data.Common.DataColumnMapping("SaleTime", "SaleTime")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO AllSale(BillNo, Discount, GrandTotal, SaleDate, SaleTime, SubTotal, T" & _
        "ax) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillNo", System.Data.OleDb.OleDbType.VarWChar, 10, "BillNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GrandTotal", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "GrandTotal", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SaleDate", System.Data.OleDb.OleDbType.DBDate, 0, "SaleDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SaleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SaleTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SubTotal", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tax", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=posdb.mdb;" & _
        "Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLE" & _
        "DB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet O" & _
        "LEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Globa" & _
        "l Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System" & _
        " Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on " & _
        "Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False" & _
        ""
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT BillNo, Discount, GrandTotal, SaleDate, SaleTime, SubTotal, Tax FROM AllSa" & _
        "le"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'DsBillSale1
        '
        Me.DsBillSale1.DataSetName = "DsBillSale"
        Me.DsBillSale1.Locale = New System.Globalization.CultureInfo("ms-MY")
        Me.DsBillSale1.Namespace = "http://www.tempuri.org/DsBillSale.xsd"
        '
        'frmReport_BillSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.PictureBox1, Me.CrystalReportViewer1})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport_BillSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report-Sale By Bill No"
        CType(Me.DsBillSale1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        cur = New frmReport_Main()
        cur.Show()
        Me.Dispose()
    End Sub

    Private Sub frmReport_BillSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim cr As New CrystalReport3()
            OleDbDataAdapter1.Fill(DsBillSale1)
            cr.SetDataSource(DsBillSale1)
            CrystalReportViewer1.ReportSource = cr


        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmReport_BillSale_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If
    End Sub
End Class

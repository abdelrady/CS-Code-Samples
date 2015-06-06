Imports System.Data.OleDb

Public Class frmReceipt
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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsTemReceipt1 As PointOfSale.DsTemReceipt
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsTemReceipt1 = New PointOfSale.DsTemReceipt()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.DsTemReceipt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TemReceipt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BillNo", "BillNo"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("GrandTotal", "GrandTotal"), New System.Data.Common.DataColumnMapping("Qty", "Qty"), New System.Data.Common.DataColumnMapping("SaleDate", "SaleDate"), New System.Data.Common.DataColumnMapping("SaleTime", "SaleTime"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Tax", "Tax"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TemReceipt(BillNo, Description, Discount, GrandTotal, Qty, SaleDate, " & _
        "SaleTime, SubTotal, Tax, Total) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillNo", System.Data.OleDb.OleDbType.VarWChar, 10, "BillNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GrandTotal", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "GrandTotal", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.VarWChar, 3, "Qty"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SaleDate", System.Data.OleDb.OleDbType.DBDate, 0, "SaleDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SaleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SaleTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SubTotal", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tax", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.VarWChar, 7, "Total"))
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
        Me.OleDbSelectCommand1.CommandText = "SELECT BillNo, Description, Discount, GrandTotal, Qty, SaleDate, SaleTime, SubTot" & _
        "al, Tax, Total FROM TemReceipt"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'DsTemReceipt1
        '
        Me.DsTemReceipt1.DataSetName = "DsTemReceipt"
        Me.DsTemReceipt1.Locale = New System.Globalization.CultureInfo("ms-MY")
        Me.DsTemReceipt1.Namespace = "http://www.tempuri.org/DsTemReceipt.xsd"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 8)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(384, 328)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(296, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.TabIndex = 1
        Me.lblDate.Visible = False
        '
        'frmReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 13)
        Me.ClientSize = New System.Drawing.Size(392, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDate, Me.CrystalReportViewer1})
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt View"
        CType(Me.DsTemReceipt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim cr As New CrystalReport1()
            OleDbDataAdapter1.Fill(DsTemReceipt1)
            cr.SetDataSource(DsTemReceipt1)
            CrystalReportViewer1.ReportSource = cr


        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmReceipt_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim strSQL As String
        strSQL = "DELETE FROM TemReceipt WHERE Qty>='1' OR GrandTotal >0"
        dc.Open()

        Dim db As New OleDbCommand(strSQL, dc)
        db.ExecuteNonQuery()

        dc.Close()
    End Sub

    Private Sub frmReceipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim strSQL As String
            strSQL = "DELETE FROM TemReceipt WHERE Qty>='1'OR GrandTotal>0"

            dc.Open()

            Dim db As New OleDbCommand(strSQL, dc)
            db.ExecuteNonQuery()

            dc.Close()
            Me.Dispose()

        End If
    End Sub

  
End Class

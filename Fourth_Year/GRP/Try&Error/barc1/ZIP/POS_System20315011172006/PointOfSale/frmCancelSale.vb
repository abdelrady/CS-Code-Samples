Imports System.Data.OleDb

Public Class frmRemoveSale
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsSaleByItem1 As PointOfSale.DsSaleByItem
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRemoveSale))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DsSaleByItem1 = New PointOfSale.DsSaleByItem()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSaleByItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(496, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(64, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 40)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Bill No : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(120, 80)
        Me.txtBillNo.MaxLength = 10
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.TabIndex = 1
        Me.txtBillNo.Text = ""
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "Transaction - Cancel Sale"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DsSaleByItem1.SaleByItem
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(24, 120)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(448, 208)
        Me.DataGrid1.TabIndex = 34
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsSaleByItem1
        '
        Me.DsSaleByItem1.DataSetName = "DsSaleByItem"
        Me.DsSaleByItem1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsSaleByItem1.Namespace = "http://www.tempuri.org/DsSaleByItem.xsd"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "SaleByItem"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Bill No"
        Me.DataGridTextBoxColumn1.MappingName = "BillNo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Item Code"
        Me.DataGridTextBoxColumn2.MappingName = "ItemCode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "Description"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 145
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridTextBoxColumn4.MappingName = "Qty"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Total"
        Me.DataGridTextBoxColumn6.MappingName = "Total"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SaleByItem", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BillNo", "BillNo"), New System.Data.Common.DataColumnMapping("SaleDate", "SaleDate"), New System.Data.Common.DataColumnMapping("ItemCode", "ItemCode"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Qty", "Qty"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO SaleByItem(BillNo, Description, ItemCode, Qty, SaleDate, Total, UnitP" & _
        "rice) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BillNo", System.Data.OleDb.OleDbType.VarWChar, 10, "BillNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, "ItemCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SaleDate", System.Data.OleDb.OleDbType.DBDate, 0, "SaleDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing))
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
        Me.OleDbSelectCommand1.CommandText = "SELECT BillNo, Description, ItemCode, Qty, SaleDate, Total, UnitPrice FROM SaleBy" & _
        "Item"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(248, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 24)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        '
        'frmRemoveSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(492, 373)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.DataGrid1, Me.txtBillNo, Me.Label2, Me.Label1, Me.PictureBox2})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemoveSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction - Remove Sale"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSaleByItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

   

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtBillNo.Text.Trim = "" Then
            MessageBox.Show("Please fill in Sale ID!", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBillNo.Focus()
            Exit Sub
        Else

            Dim strSQL As String
            strSQL = "DELETE FROM SaleByItem " & _
            "WHERE BillNo = '" & txtBillNo.Text & "' "
            dc.Open()

            Dim db As New OleDbCommand(strSQL, dc)
            db.ExecuteNonQuery()
            MsgBox("Record Was Successfully Delete From DataBase !", MsgBoxStyle.Information, "Delete Sale")
            dc.Close()

        End If
        DataGridTextBoxColumn1.NullText = ""
        DataGridTextBoxColumn2.NullText = ""
        DataGridTextBoxColumn3.NullText = ""
        DataGridTextBoxColumn4.NullText = ""
        DataGridTextBoxColumn6.NullText = ""
    End Sub

    Private Sub frmCancelSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub txtBillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillNo.KeyPress
        Dim strSQL As String
        strSQL = "SELECT * FROM [SaleByItem] WHERE BillNo='" & txtBillNo.Text & "'"
        dc.Open()
        Dim db As New OleDbCommand(strSQL, dc)
        dr = db.ExecuteReader

        While dr.Read
            DataGridTextBoxColumn1.NullText = dr.Item(0)
            DataGridTextBoxColumn2.NullText = dr.Item(2)
            DataGridTextBoxColumn3.NullText = dr.Item(3)
            DataGridTextBoxColumn4.NullText = dr.Item(4)
            DataGridTextBoxColumn6.NullText = dr.Item(6)


        End While
        dr.Close()
        dc.Close()

    End Sub
End Class

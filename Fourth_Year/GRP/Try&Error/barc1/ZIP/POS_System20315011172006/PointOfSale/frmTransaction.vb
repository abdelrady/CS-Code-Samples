Imports System.Data.OleDb

Public Class frmTransaction
    Inherits System.Windows.Forms.Form
    Public Const UCAZ As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public Const S09 As String = "0123456789"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSale As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsSaleByItem1 As PointOfSale.DsSaleByItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents chk09 As System.Windows.Forms.CheckBox
    Friend WithEvents chkUCAZ As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransaction))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnRemoveSale = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DsSaleByItem1 = New PointOfSale.DsSaleByItem()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.chk09 = New System.Windows.Forms.CheckBox()
        Me.chkUCAZ = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.DsSaleByItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Bitmap)
        Me.Label2.Location = New System.Drawing.Point(240, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 40)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "POWERCOM Point Of Sale"
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Bitmap)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(616, 176)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(136, 48)
        Me.btnPayment.TabIndex = 6
        Me.btnPayment.Text = "    Payment"
        '
        'btnRemoveSale
        '
        Me.btnRemoveSale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSale.Image = CType(resources.GetObject("btnRemoveSale.Image"), System.Drawing.Bitmap)
        Me.btnRemoveSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveSale.Location = New System.Drawing.Point(616, 272)
        Me.btnRemoveSale.Name = "btnRemoveSale"
        Me.btnRemoveSale.Size = New System.Drawing.Size(136, 48)
        Me.btnRemoveSale.TabIndex = 7
        Me.btnRemoveSale.Text = "    Remove Sale"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Bitmap)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(656, 496)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 48)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "    Close"
        '
        'DsSaleByItem1
        '
        Me.DsSaleByItem1.DataSetName = "DsSaleByItem"
        Me.DsSaleByItem1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsSaleByItem1.Namespace = "http://www.tempuri.org/DsSaleByItem.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SaleByItem", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("ItemCode", "ItemCode"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Qty", "Qty"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM SaleByItem WHERE (ItemCode = ?) AND ([Date] = ? OR ? IS NULL AND [Dat" & _
        "e] IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (Tota" & _
        "l = ? OR ? IS NULL AND Total IS NULL) AND (UnitPrice = ? OR ? IS NULL AND UnitPr" & _
        "ice IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Total1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO SaleByItem([Date], Description, ItemCode, Qty, Total, UnitPrice) VALU" & _
        "ES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, "ItemCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT [Date], Description, ItemCode, Qty, Total, UnitPrice FROM SaleByItem"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE SaleByItem SET [Date] = ?, Description = ?, ItemCode = ?, Qty = ?, Total =" & _
        " ?, UnitPrice = ? WHERE (ItemCode = ?) AND ([Date] = ? OR ? IS NULL AND [Date] I" & _
        "S NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (Total = " & _
        "? OR ? IS NULL AND Total IS NULL) AND (UnitPrice = ? OR ? IS NULL AND UnitPrice " & _
        "IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, "ItemCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Total", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Total", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Total1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Bill No:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Item Code :"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Unit Price :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Qty :"
        '
        'txtBillNo
        '
        Me.txtBillNo.BackColor = System.Drawing.Color.White
        Me.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillNo.Location = New System.Drawing.Point(144, 88)
        Me.txtBillNo.MaxLength = 8
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.TabIndex = 52
        Me.txtBillNo.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(144, 112)
        Me.txtItemCode.MaxLength = 15
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(136, 22)
        Me.txtItemCode.TabIndex = 1
        Me.txtItemCode.Text = ""
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.White
        Me.txtUnitPrice.Location = New System.Drawing.Point(144, 136)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(136, 22)
        Me.txtUnitPrice.TabIndex = 3
        Me.txtUnitPrice.Text = ""
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(336, 112)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Bitmap)
        Me.btnOk.Location = New System.Drawing.Point(336, 136)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(56, 23)
        Me.btnOk.TabIndex = 56
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.GhostWhite
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(48, 176)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(496, 232)
        Me.ListView1.TabIndex = 57
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 156
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit Price"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.Width = 100
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(496, 112)
        Me.Label8.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 23)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Sub Total :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(384, 408)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(104, 24)
        Me.lblSubTotal.TabIndex = 60
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(336, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 23)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Tax :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(384, 440)
        Me.txtTax.MaxLength = 2
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(40, 22)
        Me.txtTax.TabIndex = 4
        Me.txtTax.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(296, 464)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 23)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Discount :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(384, 464)
        Me.txtDiscount.MaxLength = 2
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(40, 22)
        Me.txtDiscount.TabIndex = 5
        Me.txtDiscount.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(424, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 16)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "%"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 464)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "%"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(256, 488)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 23)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Grand Total :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblGrandTotal.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(384, 488)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.TabIndex = 68
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk09
        '
        Me.chk09.Checked = True
        Me.chk09.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk09.Location = New System.Drawing.Point(296, 80)
        Me.chk09.Name = "chk09"
        Me.chk09.TabIndex = 69
        Me.chk09.Text = "0-9"
        Me.chk09.Visible = False
        '
        'chkUCAZ
        '
        Me.chkUCAZ.Checked = True
        Me.chkUCAZ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUCAZ.Location = New System.Drawing.Point(400, 80)
        Me.chkUCAZ.Name = "chkUCAZ"
        Me.chkUCAZ.TabIndex = 70
        Me.chkUCAZ.Text = "UCAZ"
        Me.chkUCAZ.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Description :"
        Me.Label7.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(408, 112)
        Me.txtDescription.MaxLength = 40
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(344, 22)
        Me.txtDescription.TabIndex = 72
        Me.txtDescription.Text = ""
        Me.txtDescription.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(488, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Total :"
        Me.Label10.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(552, 136)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtTotal.TabIndex = 74
        Me.txtTotal.Text = ""
        Me.txtTotal.Visible = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Location = New System.Drawing.Point(544, 72)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(96, 23)
        Me.lblDate.TabIndex = 75
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Location = New System.Drawing.Point(648, 72)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(96, 23)
        Me.lblTime.TabIndex = 76
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblTax.Location = New System.Drawing.Point(440, 440)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(72, 23)
        Me.lblTax.TabIndex = 77
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblDiscount.Location = New System.Drawing.Point(440, 464)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(72, 23)
        Me.lblDiscount.TabIndex = 78
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(296, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 23)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "[F1]"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(568, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "[F2]"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(568, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 23)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "[F3]"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(600, 512)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 23)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "[Esc]"
        '
        'frmTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label19, Me.Label17, Me.Label16, Me.Label11, Me.lblDiscount, Me.lblTax, Me.lblTime, Me.lblDate, Me.txtTotal, Me.Label10, Me.txtDescription, Me.Label7, Me.chkUCAZ, Me.chk09, Me.lblGrandTotal, Me.Label14, Me.Label4, Me.Label15, Me.txtDiscount, Me.Label13, Me.txtTax, Me.Label12, Me.lblSubTotal, Me.Label9, Me.Label8, Me.ListView1, Me.btnOk, Me.NumericUpDown1, Me.txtUnitPrice, Me.txtItemCode, Me.txtBillNo, Me.Label5, Me.Label6, Me.Label3, Me.Label1, Me.btnClose, Me.btnRemoveSale, Me.btnPayment, Me.Label2, Me.PictureBox1})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction - Main Screen"
        CType(Me.DsSaleByItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim total As Double
    Private Sub txtItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode.KeyPress
        
        Dim db As New OleDbCommand _
               ("SELECT * FROM [ItemMaster]" & "WHERE Barcode ='" & txtItemCode.Text & "'", dc)
        dc.Open()

        dr = db.ExecuteReader



        While dr.Read()
            txtDescription.Text = dr.Item(2)
            txtUnitPrice.Text = dr.Item(4)


        End While


        dr.Close()

        dc.Close()

    End Sub

    Private Sub NumericUpDown1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.TextChanged
        txtTotal.Text = Val(txtUnitPrice.Text) * Val(NumericUpDown1.Text)


    End Sub

    Private Sub txtUnitPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitPrice.TextChanged

        txtTotal.Text = Val(txtUnitPrice.Text) * Val(NumericUpDown1.Text)

    End Sub

    Private Sub listview()


        Dim lSingleItem As ListViewItem  'The variable will hold the ListItem information so that you can add values to the column you want to change




        lSingleItem = ListView1.Items.Add(txtItemCode.Text.Trim)  'Create a new line, and assign the ListItem into the variable so we can add sub items
        lSingleItem.SubItems.Add(txtDescription.Text.Trim) 'The first sub item for the first line
        lSingleItem.SubItems.Add(NumericUpDown1.Text.Trim)  'The second sub item for the first line
        lSingleItem.SubItems.Add(FormatCurrency(txtUnitPrice.Text.Trim))
        lSingleItem.SubItems.Add(FormatCurrency(txtTotal.Text.Trim))

        total = total + Val(txtTotal.Text.Trim)
        lblSubTotal.Text = total

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click



        If txtItemCode.Text = "" Then
            MessageBox.Show("Please fill in Item Code!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemCode.Focus()
            Exit Sub
        Else

            Try
                Dim strSQL As String

                strSQL = "INSERT INTO SaleByItem " & _
                        "(SaleDate,BillNo,Barcode, Description,Qty,UnitPrice,Total)VALUES " & _
                        "('" & lblDate.Text & "', '" & txtBillNo.Text & "','" & txtItemCode.Text & "'," & _
                        "'" & txtDescription.Text & "','" & NumericUpDown1.Text & "', " & _
                        "'" & txtUnitPrice.Text & "','" & txtTotal.Text & "')"

                Dim strSQL2 As String
                strSQL2 = "INSERT INTO TemReceipt " & _
                "(BillNo,SaleDate,SaleTime,Description,Qty,Total)VALUES " & _
                "('" & txtBillNo.Text & "', '" & lblDate.Text & "', '" & lblTime.Text & "', '" & txtDescription.Text & "','" & Val(NumericUpDown1.Text) & "', " & _
                "'" & txtTotal.Text & "')"
                dc.Open()
                Dim cmd As New OleDbCommand(strSQL, dc)
                Dim cmd2 As New OleDbCommand(strSQL2, dc)
                cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()

                Call listview()
               


            Catch
                MessageBox.Show("Error occured when trying to save data!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtItemCode.Focus()

            End Try
            dc.Close()



        End If

        txtItemCode.Focus()
        txtItemCode.Clear()
        txtDescription.Clear()
        NumericUpDown1.Text = 1
        txtUnitPrice.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click


        If ListView1.Items.Count = 0 Then
            MessageBox.Show("No Transaction!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else



            Dim strSQL As String

            strSQL = "INSERT INTO AllSale " & _
                    "(SaleDate,SaleTime,BillNo,SubTotal,Discount,Tax,GrandTotal)VALUES " & _
                    "('" & lblDate.Text & "', '" & lblTime.Text & "','" & txtBillNo.Text & "'," & _
                    "'" & lblSubTotal.Text & "','" & lblDiscount.Text & "', " & _
                    "'" & lblTax.Text & "','" & lblGrandTotal.Text & "')"
            Dim strSQL2 As String
            strSQL2 = "INSERT INTO TemReceipt " & _
                    "(SubTotal,Discount,Tax,GrandTotal)VALUES " & _
                    "('" & lblSubTotal.Text & "','" & lblDiscount.Text & "', " & _
                    "'" & lblTax.Text & "','" & lblGrandTotal.Text & "')"
            dc.Open()
            Dim db As New OleDbCommand(strSQL, dc)
            Dim db2 As New OleDbCommand(strSQL2, dc)


            db.ExecuteNonQuery()
            db2.ExecuteNonQuery()

            dc.Close()
            MessageBox.Show("Sales accepted, Please wait to load the receipt !", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If


        total = 0
        txtItemCode.Focus()
        txtItemCode.Clear()
        txtDescription.Clear()
        NumericUpDown1.Text = 1
        txtUnitPrice.Clear()
        txtTotal.Clear()
        ListView1.Items.Clear()
        txtTax.Clear()
        txtDiscount.Clear()
        lblSubTotal.ResetText()
        lblGrandTotal.ResetText()
        lblTax.ResetText()
        lblDiscount.ResetText()

        Dim strCodes As String  'Available codes for random password
        Dim strBill As String   'Variable to hold random password
        Dim i As Integer        'Loop counter


        If chkUCAZ.CheckState = CheckState.Checked Then
            strCodes = strCodes & UCAZ
        End If

        If chk09.CheckState = CheckState.Checked Then
            strCodes = strCodes & S09
        End If
        Randomize()
        'Loop through all columns
        For i = 0 To CInt(10) - 1
            'Create the password, one random column at a time
            strBill &= Mid(strCodes, Int(Len(strCodes) * Rnd()) + 1, 1)
        Next
        'Display the password
        txtBillNo.Text = strBill

        cur = New frmReceipt()
        cur.Show()

    End Sub

    Private Sub frmTransaction_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If ListView1.Items.Count >= 1 Then
            MessageBox.Show("Please post the sale or cancel the sale before you leave!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
            Exit Sub
        Else
            intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If intResponse = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            Else
                End
            End If
        End If
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click


        If ListView1.Items.Count >= 1 Then
            MessageBox.Show("Please post the sale or cancel the sale before you leave!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            cur = New frmMainMenu()
            cur.Show()
            Me.Dispose()
        End If
    End Sub



    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim strCodes As String  'Available codes for random password
        Dim strBill As String   'Variable to hold random password
        Dim i As Integer        'Loop counter


        If chkUCAZ.CheckState = CheckState.Checked Then
            strCodes = strCodes & UCAZ
        End If

        If chk09.CheckState = CheckState.Checked Then
            strCodes = strCodes & S09
        End If
        Randomize()
        'Loop through all columns
        For i = 0 To CInt(10) - 1
            'Create the password, one random column at a time
            strBill &= Mid(strCodes, Int(Len(strCodes) * Rnd()) + 1, 1)
        Next
        'Display the password
        txtBillNo.Text = strBill

        lblDate.Text = Format(Date.Today, "dd/MM/yy")

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay

    End Sub


    Private Sub txtTax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax.KeyPress
        e.Handled = NumbersOnly(e.KeyChar, txtTax)


    End Sub
    Private Function NumbersOnly(ByVal pstrChar As Char, ByVal oTextBox As TextBox) As Boolean
        'validate the entry for a textbox limiting it to only numeric values and the decimal point
        If (Convert.ToString(pstrChar) = "." And InStr(oTextBox.Text, ".")) Then Return True 'accept only one instance of the decimal point
        If Convert.ToString(pstrChar) <> "." And pstrChar <> vbBack Then
            Return IIf(IsNumeric(pstrChar), False, True) 'check if numeric is returned
        End If
        Return False 'for backspace
    End Function

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        e.Handled = NumbersOnly(e.KeyChar, txtDiscount)
    End Sub


    Private Sub txtTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged
        lblGrandTotal.Text = Val(lblSubTotal.Text) + ((Val(txtTax.Text) * Val(lblSubTotal.Text)) / 100) - ((Val(txtDiscount.Text) * Val(lblSubTotal.Text)) / 100)
        lblTax.Text = Val(txtTax.Text) * Val(lblSubTotal.Text) / 100
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        lblGrandTotal.Text = Val(lblSubTotal.Text) + ((Val(txtTax.Text) * Val(lblSubTotal.Text)) / 100) - ((Val(txtDiscount.Text) * Val(lblSubTotal.Text)) / 100)
        lblDiscount.Text = -(Val(txtDiscount.Text) * Val(lblSubTotal.Text) / 100)
    End Sub

    Private Sub lblSubTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSubTotal.TextChanged

        lblGrandTotal.Text = Val(lblSubTotal.Text) + ((Val(txtTax.Text) * Val(lblSubTotal.Text)) / 100) - ((Val(txtDiscount.Text) * Val(lblSubTotal.Text)) / 100)
        lblTax.Text = Val(txtTax.Text) * Val(lblSubTotal.Text) / 100
        lblDiscount.Text = -(Val(txtDiscount.Text) * Val(lblSubTotal.Text) / 100)
    End Sub




    Private Sub btnRemoveSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSale.Click
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("No Transaction!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else

            Dim strSQL As String
            strSQL = "DELETE FROM SaleByItem " & _
               "WHERE BillNo = '" & txtBillNo.Text & "' "
            Dim strSQL2 As String
            strSQL2 = "DELETE FROM TemReceipt"
            dc.Open()

            Dim db As New OleDbCommand(strSQL, dc)
            Dim db2 As New OleDbCommand(strSQL2, dc)
            db.ExecuteNonQuery()
            db2.ExecuteNonQuery()
            dc.Close()
            MsgBox("Record Was Successfully Delete From DataBase !", MsgBoxStyle.Information, "Delete Sale")

        End If
        total = 0
        ListView1.Items.Clear()
        txtItemCode.Focus()
        txtTax.Clear()
        txtDiscount.Clear()
        lblSubTotal.ResetText()
        lblSubTotal.Refresh()
        lblGrandTotal.ResetText()
        lblTax.ResetText()
        lblDiscount.ResetText()


    End Sub







    Private Sub frmTransaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If ListView1.Items.Count >= 1 Then
                MessageBox.Show("Please post the sale or cancel the sale before you leave!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                cur = New frmMainMenu()
                cur.Show()
                Me.Dispose()
            End If
        End If

        If e.KeyCode = Keys.F1 Then
            If txtItemCode.Text = "" Then
                MessageBox.Show("Please fill in Item Code!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtItemCode.Focus()
                Exit Sub
            Else

                Try
                    Dim strSQL As String

                    strSQL = "INSERT INTO SaleByItem " & _
                            "(SaleDate,BillNo,Barcode, Description,Qty,UnitPrice,Total)VALUES " & _
                            "('" & lblDate.Text & "', '" & txtBillNo.Text & "','" & txtItemCode.Text & "'," & _
                            "'" & txtDescription.Text & "','" & NumericUpDown1.Text & "', " & _
                            "'" & txtUnitPrice.Text & "','" & txtTotal.Text & "')"

                    Dim strSQL2 As String
                    strSQL2 = "INSERT INTO TemReceipt " & _
                    "(BillNo,SaleDate,SaleTime,Description,Qty,Total)VALUES " & _
                    "('" & txtBillNo.Text & "', '" & lblDate.Text & "', '" & lblTime.Text & "', '" & txtDescription.Text & "','" & Val(NumericUpDown1.Text) & "', " & _
                    "'" & txtTotal.Text & "')"
                    dc.Open()
                    Dim cmd As New OleDbCommand(strSQL, dc)
                    Dim cmd2 As New OleDbCommand(strSQL2, dc)
                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()

                    Call listview()

                Catch
                    MessageBox.Show("Error occured when trying to save data!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtItemCode.Focus()

                End Try
                dc.Close()



            End If

            txtItemCode.Focus()
            txtItemCode.Clear()
            txtDescription.Clear()
            NumericUpDown1.Text = 1
            txtUnitPrice.Clear()
            txtTotal.Clear()

        End If

        If e.KeyCode = Keys.F2 Then
            If ListView1.Items.Count = 0 Then
                MessageBox.Show("No Transaction!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else



                Dim strSQL As String

                strSQL = "INSERT INTO AllSale " & _
                        "(SaleDate,SaleTime,BillNo,SubTotal,Discount,Tax,GrandTotal)VALUES " & _
                        "('" & lblDate.Text & "', '" & lblTime.Text & "','" & txtBillNo.Text & "'," & _
                        "'" & lblSubTotal.Text & "','" & lblDiscount.Text & "', " & _
                        "'" & lblTax.Text & "','" & lblGrandTotal.Text & "')"
                Dim strSQL2 As String
                strSQL2 = "INSERT INTO TemReceipt " & _
                        "(SubTotal,Discount,Tax,GrandTotal)VALUES " & _
                        "('" & lblSubTotal.Text & "','" & lblDiscount.Text & "', " & _
                        "'" & lblTax.Text & "','" & lblGrandTotal.Text & "')"
                dc.Open()
                Dim db As New OleDbCommand(strSQL, dc)
                Dim db2 As New OleDbCommand(strSQL2, dc)


                db.ExecuteNonQuery()
                db2.ExecuteNonQuery()

                dc.Close()
                MessageBox.Show("Sales accepted, Please wait to load the receipt !", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


            total = 0
            txtItemCode.Focus()
            txtItemCode.Clear()
            txtDescription.Clear()
            NumericUpDown1.Text = 1
            txtUnitPrice.Clear()
            txtTotal.Clear()
            ListView1.Items.Clear()
            txtTax.Clear()
            txtDiscount.Clear()
            lblSubTotal.ResetText()
            lblGrandTotal.ResetText()
            lblTax.ResetText()
            lblDiscount.ResetText()

            Dim strCodes As String  'Available codes for random password
            Dim strBill As String   'Variable to hold random password
            Dim i As Integer        'Loop counter


            If chkUCAZ.CheckState = CheckState.Checked Then
                strCodes = strCodes & UCAZ
            End If

            If chk09.CheckState = CheckState.Checked Then
                strCodes = strCodes & S09
            End If
            Randomize()
            'Loop through all columns
            For i = 0 To CInt(10) - 1
                'Create the password, one random column at a time
                strBill &= Mid(strCodes, Int(Len(strCodes) * Rnd()) + 1, 1)
            Next
            'Display the password
            txtBillNo.Text = strBill

            cur = New frmReceipt()
            cur.Show()

        End If

        If e.KeyCode = Keys.F3 Then
            If ListView1.Items.Count = 0 Then
                MessageBox.Show("No Transaction!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Dim strSQL As String
                strSQL = "DELETE FROM SaleByItem " & _
                   "WHERE BillNo = '" & txtBillNo.Text & "' "
                Dim strSQL2 As String
                strSQL2 = "DELETE FROM TemReceipt"
                dc.Open()

                Dim db As New OleDbCommand(strSQL, dc)
                Dim db2 As New OleDbCommand(strSQL2, dc)
                db.ExecuteNonQuery()
                db2.ExecuteNonQuery()
                dc.Close()
                MsgBox("Record Was Successfully Delete From DataBase !", MsgBoxStyle.Information, "Delete Sale")

            End If

            total = 0
            ListView1.Items.Clear()
            txtItemCode.Focus()
            txtTax.Clear()
            txtDiscount.Clear()
            lblSubTotal.ResetText()
            lblSubTotal.Refresh()
            lblGrandTotal.ResetText()
            lblTax.ResetText()
            lblDiscount.ResetText()
        End If


    End Sub



    
End Class

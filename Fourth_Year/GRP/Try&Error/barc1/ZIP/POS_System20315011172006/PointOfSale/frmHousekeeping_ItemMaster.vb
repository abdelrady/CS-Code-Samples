Imports System.Data.OleDb

Public Class frmHousekeeping_ItemMaster
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardCost As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtMinSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DsItem1 As PointOfSale.Dspos
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents DsItem2 As PointOfSale.DsItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStockQty As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHousekeeping_ItemMaster))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.DsItem2 = New PointOfSale.DsItem()
        Me.DsItem1 = New PointOfSale.Dspos()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.txtStandardCost = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtMinSellingPrice = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStockQty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.DsItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
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
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Barcode:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Description:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Standard Cost:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Retail Price:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Min Selling Price:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.White
        Me.txtItemCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.ItemCode"))
        Me.txtItemCode.Location = New System.Drawing.Point(176, 24)
        Me.txtItemCode.MaxLength = 15
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(136, 22)
        Me.txtItemCode.TabIndex = 1
        Me.txtItemCode.Text = ""
        '
        'DsItem2
        '
        Me.DsItem2.DataSetName = "DsItem"
        Me.DsItem2.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsItem2.Namespace = "http://www.tempuri.org/DsItem.xsd"
        '
        'DsItem1
        '
        Me.DsItem1.DataSetName = "DsItem"
        Me.DsItem1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsItem1.Namespace = "http://www.tempuri.org/Dspos.xsd"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.White
        Me.txtItemDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.Description"))
        Me.txtItemDescription.Location = New System.Drawing.Point(176, 56)
        Me.txtItemDescription.MaxLength = 40
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(432, 22)
        Me.txtItemDescription.TabIndex = 3
        Me.txtItemDescription.Text = ""
        '
        'txtStandardCost
        '
        Me.txtStandardCost.BackColor = System.Drawing.Color.White
        Me.txtStandardCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.StandardCost"))
        Me.txtStandardCost.Location = New System.Drawing.Point(176, 88)
        Me.txtStandardCost.MaxLength = 7
        Me.txtStandardCost.Name = "txtStandardCost"
        Me.txtStandardCost.Size = New System.Drawing.Size(136, 22)
        Me.txtStandardCost.TabIndex = 4
        Me.txtStandardCost.Text = ""
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.BackColor = System.Drawing.Color.White
        Me.txtRetailPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.RetailPrice"))
        Me.txtRetailPrice.Location = New System.Drawing.Point(176, 120)
        Me.txtRetailPrice.MaxLength = 7
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(136, 22)
        Me.txtRetailPrice.TabIndex = 5
        Me.txtRetailPrice.Text = ""
        '
        'txtMinSellingPrice
        '
        Me.txtMinSellingPrice.BackColor = System.Drawing.Color.White
        Me.txtMinSellingPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.MinSellingPrice"))
        Me.txtMinSellingPrice.Location = New System.Drawing.Point(176, 152)
        Me.txtMinSellingPrice.MaxLength = 7
        Me.txtMinSellingPrice.Name = "txtMinSellingPrice"
        Me.txtMinSellingPrice.Size = New System.Drawing.Size(136, 22)
        Me.txtMinSellingPrice.TabIndex = 6
        Me.txtMinSellingPrice.Text = ""
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.Barcode"))
        Me.txtBarcode.Location = New System.Drawing.Point(464, 24)
        Me.txtBarcode.MaxLength = 15
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(144, 22)
        Me.txtBarcode.TabIndex = 2
        Me.txtBarcode.Text = ""
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(360, 424)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(64, 32)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(424, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 32)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(232, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 32)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(552, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 32)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(168, 424)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 32)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(328, 384)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(32, 24)
        Me.btnFirst.TabIndex = 43
        Me.btnFirst.Text = "<<"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(360, 384)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(32, 24)
        Me.btnPrevious.TabIndex = 44
        Me.btnPrevious.Text = "<"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnNext.Location = New System.Drawing.Point(392, 384)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 24)
        Me.btnNext.TabIndex = 45
        Me.btnNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnLast.Location = New System.Drawing.Point(424, 384)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(32, 24)
        Me.btnLast.TabIndex = 46
        Me.btnLast.Text = ">>"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(488, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 32)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 551)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(792, 22)
        Me.StatusBar1.TabIndex = 48
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Width = 776
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Search Record by Item Code:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(408, 344)
        Me.txtSearch.MaxLength = 8
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 50
        Me.txtSearch.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearch.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(552, 336)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 32)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.Text = "  Search"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ItemMaster", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ItemCode", "ItemCode"), New System.Data.Common.DataColumnMapping("Barcode", "Barcode"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("StandardCost", "StandardCost"), New System.Data.Common.DataColumnMapping("RetailPrice", "RetailPrice"), New System.Data.Common.DataColumnMapping("MinSellingPrice", "MinSellingPrice"), New System.Data.Common.DataColumnMapping("StockQty", "StockQty")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ItemMaster WHERE (ItemCode = ?) AND (Barcode = ? OR ? IS NULL AND Bar" & _
        "code IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (Mi" & _
        "nSellingPrice = ? OR ? IS NULL AND MinSellingPrice IS NULL) AND (RetailPrice = ?" & _
        " OR ? IS NULL AND RetailPrice IS NULL) AND (StandardCost = ? OR ? IS NULL AND St" & _
        "andardCost IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Barcode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Barcode1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MinSellingPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MinSellingPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RetailPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RetailPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StandardCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StandardCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ItemMaster(Barcode, Description, ItemCode, MinSellingPrice, RetailPri" & _
        "ce, StandardCost, StockQty) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Barcode", System.Data.OleDb.OleDbType.VarWChar, 15, "Barcode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, "ItemCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MinSellingPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RetailPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StandardCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StockQty", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "StockQty", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Barcode, Description, ItemCode, MinSellingPrice, RetailPrice, StandardCost" & _
        ", StockQty FROM ItemMaster"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ItemMaster SET Barcode = ?, Description = ?, ItemCode = ?, MinSellingPrice" & _
        " = ?, RetailPrice = ?, StandardCost = ?, StockQty = ? WHERE (ItemCode = ?) AND (" & _
        "Barcode = ? OR ? IS NULL AND Barcode IS NULL) AND (Description = ? OR ? IS NULL " & _
        "AND Description IS NULL) AND (MinSellingPrice = ? OR ? IS NULL AND MinSellingPri" & _
        "ce IS NULL) AND (RetailPrice = ? OR ? IS NULL AND RetailPrice IS NULL) AND (Stan" & _
        "dardCost = ? OR ? IS NULL AND StandardCost IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Barcode", System.Data.OleDb.OleDbType.VarWChar, 15, "Barcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 40, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, "ItemCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MinSellingPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RetailPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StandardCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StockQty", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "StockQty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemCode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Barcode", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Barcode1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Barcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MinSellingPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MinSellingPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "MinSellingPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RetailPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RetailPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "RetailPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StandardCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StandardCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "StandardCost", System.Data.DataRowVersion.Original, Nothing))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtStockQty, Me.Label9, Me.Label2, Me.Label4, Me.Label6, Me.Label7, Me.Label8, Me.txtItemCode, Me.txtItemDescription, Me.txtStandardCost, Me.txtRetailPrice, Me.txtMinSellingPrice, Me.Label3, Me.txtBarcode})
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 248)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Master"
        '
        'txtStockQty
        '
        Me.txtStockQty.BackColor = System.Drawing.Color.White
        Me.txtStockQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsItem2, "ItemMaster.StockQty"))
        Me.txtStockQty.Location = New System.Drawing.Point(176, 184)
        Me.txtStockQty.MaxLength = 4
        Me.txtStockQty.Name = "txtStockQty"
        Me.txtStockQty.Size = New System.Drawing.Size(136, 22)
        Me.txtStockQty.TabIndex = 28
        Me.txtStockQty.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Stock Qty :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(296, 424)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 32)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        '
        'frmHousekeeping_ItemMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnEdit, Me.GroupBox1, Me.btnSearch, Me.txtSearch, Me.Label5, Me.StatusBar1, Me.btnCancel, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.btnAdd, Me.btnClose, Me.btnDelete, Me.btnSave, Me.btnUpdate, Me.PictureBox1, Me.Label1, Me.PictureBox2})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHousekeeping_ItemMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HouseKeeping - Item Master"
        CType(Me.DsItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

   

    Dim rowindex As Integer

    Private Sub Count()
        Dim Total, Current As Integer
        Total = Me.BindingContext(DsItem2, "ItemMaster").Count
        Current = Me.BindingContext(DsItem2, "ItemMaster").Position + 1


    End Sub

    Private Sub LockTextboxes(ByVal value As Boolean)

        txtBarcode.Enabled = Not value
        txtItemDescription.Enabled = Not value
        txtStandardCost.Enabled = Not value
        txtRetailPrice.Enabled = Not value
        txtMinSellingPrice.Enabled = Not value
        txtStockQty.Enabled = Not value

    End Sub


   
    Private Sub Enable(ByVal Value As Boolean)
        btnCancel.Enabled = Not Value
        btnSave.Enabled = Not Value
        btnAdd.Enabled = Value
        btnDelete.Enabled = Value
        btnClose.Enabled = Value
        btnFirst.Enabled = Value
        btnLast.Enabled = Value
        btnPrevious.Enabled = Value
        btnNext.Enabled = Value
        txtSearch.Enabled = Value
        btnSearch.Enabled = Value

    End Sub

    Private Sub frmHousekeeping_ItemMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsItem2.Clear()
        OleDbDataAdapter1.Fill(DsItem2)

        rowindex = 0
        LockTextboxes(True)
        txtItemCode.Enabled = False

        Count()
        Enable(True)
        btnEdit.Enabled = True
        btnUpdate.Enabled = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        cur = New frmHousekeeping_Main()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If txtItemCode.Text.Trim = "" Or txtBarcode.Text.Trim = "" Or txtItemDescription.Text.Trim = "" _
         Or txtStandardCost.Text.Trim = "" Or txtRetailPrice.Text.Trim = "" Or _
         txtMinSellingPrice.Text.Trim = ""  Then
            MessageBox.Show("Please fill in all data!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

       

       
        ElseIf Val(txtRetailPrice.Text) < Val(txtStandardCost.Text) Then
            MessageBox.Show("Retail Price must be greater than Standard Cost!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetailPrice.Focus()
            Exit Sub

        ElseIf Val(txtRetailPrice.Text) < Val(txtMinSellingPrice.Text) Then
            MessageBox.Show("Retail Price must be greater than Min Selling Price!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetailPrice.Focus()
            Exit Sub

        ElseIf Val(txtStandardCost.Text <= 0) Or Val(txtMinSellingPrice.Text <= 0) Then
            MessageBox.Show("All Price must be greater than 0!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStandardCost.Focus()
            Exit Sub

        ElseIf Val(txtStockQty.Text <= 0) Then
            MessageBox.Show("All Stock Qty must be greater than 0!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStockQty.Focus()
            Exit Sub
        End If

        Try

            Me.BindingContext(DsItem2, "ItemMaster").EndCurrentEdit()
            OleDbDataAdapter1.Update(DsItem2.Tables("ItemMaster"))
            MessageBox.Show("Data saved successfully!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Enable(True)

            btnEdit.Enabled = True
            btnUpdate.Enabled = False
            LockTextboxes(True)
            txtItemCode.Enabled = False
            Count()
            Exit Sub


        Catch
            MessageBox.Show("The Item Code already exist, please fill in again!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItemCode.Focus()
            Exit Sub
        End Try


    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtItemCode.Clear()
        txtBarcode.Clear()
        txtItemDescription.Clear()
        txtStandardCost.Clear()
        txtRetailPrice.Clear()
        txtMinSellingPrice.Clear()
        txtStockQty.Clear()

        txtItemCode.ReadOnly = False

        Me.BindingContext(DsItem2, "ItemMaster").AddNew()
        LockTextboxes(False)
        txtItemCode.Enabled = True

        txtItemCode.Focus()
        Enable(False)
        btnEdit.Enabled = False
        btnUpdate.Enabled = False




    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        intResponse = MessageBox.Show("Are you sure you want to delete this record?", "Item Master", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If intResponse = MsgBoxResult.No Then
            Exit Sub

        Else
            Me.BindingContext(DsItem2, "ItemMaster").RemoveAt _
                          (Me.BindingContext(DsItem2, "ItemMaster").Position)
            OleDbDataAdapter1.Update(DsItem2.Tables("ItemMaster"))
            MessageBox.Show("Record deleted successfully!", "Item Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Count()
            Exit Sub
        End If



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsItem2, "ItemMaster").CancelCurrentEdit()
        LockTextboxes(True)
        txtItemCode.Enabled = False
        Enable(True)
        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        Count()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        LockTextboxes(False)
        txtItemCode.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = True
        btnClose.Enabled = True
        txtItemCode.ReadOnly = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If txtBarcode.Text.Trim = "" Or txtStandardCost.Text.Trim = "" Or txtRetailPrice.Text.Trim = "" Or _
         txtMinSellingPrice.Text.Trim = "" Then
            MessageBox.Show("Please fill in all data!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        ElseIf Val(txtRetailPrice.Text) < Val(txtStandardCost.Text) Then
            MessageBox.Show("Retail Price must be greater than Standard Cost!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetailPrice.Focus()
            Exit Sub

        ElseIf Val(txtRetailPrice.Text) < Val(txtMinSellingPrice.Text) Then
            MessageBox.Show("Retail Price must be greater than Min Selling Price!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetailPrice.Focus()
            Exit Sub

        ElseIf Val(txtStandardCost.Text <= 0) Or Val(txtMinSellingPrice.Text <= 0) Then
            MessageBox.Show("All Price must be greater than 0!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStandardCost.Focus()
            Exit Sub

        ElseIf Val(txtStockQty.Text <= 0) Then
            MessageBox.Show("All Stock Qty must be greater than 0!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStockQty.Focus()
            Exit Sub
        End If


        Dim strSQL As String
        strSQL = "UPDATE ItemMaster SET " & _
        "Barcode = '" & txtBarcode.Text & "', Description= '" & txtItemDescription.Text & "', StandardCost= '" & Val(txtStandardCost.Text) & "', " & _
        "RetailPrice= '" & Val(txtRetailPrice.Text) & "', MinSellingPrice='" & Val(txtMinSellingPrice.Text) & "', StockQty='" & Val(txtStockQty.Text) & "' WHERE ItemCode = '" & txtItemCode.Text & "'"

        Dim db As New OleDbCommand(strSQL, dc)
        dc.Open()
        db.ExecuteNonQuery()
        dc.Close()

        MessageBox.Show("Record has been update successfully!", "Item Master", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Updatetextboxes()
        Count()
        Enable(True)
        txtItemCode.ReadOnly = False
        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        LockTextboxes(True)
        txtItemCode.Enabled = False

    End Sub


    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        rowindex = 0
        Call Updatetextboxes()
        Count()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If (rowindex > 0) Then
            rowindex -= 1
            Call Updatetextboxes()
        End If

        Count()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (rowindex < DsItem2.Tables("ItemMaster").Rows.Count - 1) Then
            rowindex += 1
            Call Updatetextboxes()
        End If

        Count()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        rowindex = DsItem2.Tables("ItemMaster").Rows.Count - 1
        Call Updatetextboxes()

        Count()
    End Sub



    Private Sub frmHousekeeping_ItemMaster_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If
    End Sub





    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Panels(0).Text = Now.ToLongDateString & "  " & Now.ToLongTimeString

    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If e.StatusBarPanel Is StatusBar1.Panels(0) Then
            Shell("rundll32.exe shell32.dll,Control_RunDLL timedate.cpl")
        End If
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim = "" Then
            MessageBox.Show("Please enter item code before search!", "Seacrh", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSearch.Focus()
            Exit Sub
        End If

        Dim itemcode As String
        Dim i As Integer
        Dim itemfound As Boolean = False
        itemcode = txtSearch.Text
        For i = 0 To (DsItem2.Tables("ItemMaster").Rows.Count - 1)
            If DsItem2.Tables("ItemMaster").Rows(i)("ItemCode") = itemcode Then
                itemfound = True
                rowindex = i
                Call Updatetextboxes()

            End If

        Next i
        If (Not itemfound) Then
            MessageBox.Show("Item not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearch.Focus()
            Exit Sub

        End If

    End Sub

    Private Sub Updatetextboxes()
        txtItemCode.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("ItemCode")
        txtBarcode.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("Barcode")
        txtItemDescription.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("Description")
        txtStandardCost.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("StandardCost")
        txtRetailPrice.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("RetailPrice")
        txtMinSellingPrice.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("MinSellingPrice")
        txtStockQty.Text = DsItem2.Tables("ItemMaster").Rows(rowindex)("StockQty")
    End Sub


   

   

   
    Private Sub txtItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode.KeyPress
        If txtItemCode.Text.Substring(0) = Chr(32) Then
            MessageBox.Show("No Space allow infront of the Item Code!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemCode.Clear()
            txtItemCode.Focus()

        End If
        If IsNumeric(txtItemCode.Text.Substring(0)) Then
            MessageBox.Show("Please create an Item Code start with Alphabert.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemCode.Clear()
            txtItemCode.Focus()

        End If
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If txtBarcode.Text.Substring(0) = Chr(32) Then
            MessageBox.Show("No Space allow infront of the Barcode!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBarcode.Clear()
            txtBarcode.Focus()

        End If

    End Sub
End Class

Imports System.Data.OleDb

Public Class frmCompany
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsCompany1 As PointOfSale.DsCompany
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCompany))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.DsCompany1 = New PointOfSale.DsCompany()
        Me.txtFaxNo = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo2 = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo1 = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsCompany1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEmail, Me.txtFaxNo, Me.txtPhoneNo2, Me.txtPhoneNo1, Me.txtPostCode, Me.txtAddress2, Me.txtAddress1, Me.txtCompanyName, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Company Profile"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.Email"))
        Me.txtEmail.Location = New System.Drawing.Point(128, 296)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(376, 22)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Text = ""
        '
        'DsCompany1
        '
        Me.DsCompany1.DataSetName = "DsCompany"
        Me.DsCompany1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsCompany1.Namespace = "http://www.tempuri.org/DsCompany.xsd"
        '
        'txtFaxNo
        '
        Me.txtFaxNo.BackColor = System.Drawing.Color.White
        Me.txtFaxNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.FaxNo"))
        Me.txtFaxNo.Location = New System.Drawing.Point(128, 256)
        Me.txtFaxNo.MaxLength = 15
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(168, 22)
        Me.txtFaxNo.TabIndex = 7
        Me.txtFaxNo.Text = ""
        '
        'txtPhoneNo2
        '
        Me.txtPhoneNo2.BackColor = System.Drawing.Color.White
        Me.txtPhoneNo2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.PhoneNo2"))
        Me.txtPhoneNo2.Location = New System.Drawing.Point(128, 216)
        Me.txtPhoneNo2.MaxLength = 15
        Me.txtPhoneNo2.Name = "txtPhoneNo2"
        Me.txtPhoneNo2.Size = New System.Drawing.Size(168, 22)
        Me.txtPhoneNo2.TabIndex = 6
        Me.txtPhoneNo2.Text = ""
        '
        'txtPhoneNo1
        '
        Me.txtPhoneNo1.BackColor = System.Drawing.Color.White
        Me.txtPhoneNo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.PhoneNo1"))
        Me.txtPhoneNo1.Location = New System.Drawing.Point(128, 176)
        Me.txtPhoneNo1.MaxLength = 15
        Me.txtPhoneNo1.Name = "txtPhoneNo1"
        Me.txtPhoneNo1.Size = New System.Drawing.Size(168, 22)
        Me.txtPhoneNo1.TabIndex = 5
        Me.txtPhoneNo1.Text = ""
        '
        'txtPostCode
        '
        Me.txtPostCode.BackColor = System.Drawing.Color.White
        Me.txtPostCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.Postcode"))
        Me.txtPostCode.Location = New System.Drawing.Point(128, 136)
        Me.txtPostCode.MaxLength = 8
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(168, 22)
        Me.txtPostCode.TabIndex = 4
        Me.txtPostCode.Text = ""
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.White
        Me.txtAddress2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.Address2"))
        Me.txtAddress2.Location = New System.Drawing.Point(128, 96)
        Me.txtAddress2.MaxLength = 40
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(376, 22)
        Me.txtAddress2.TabIndex = 3
        Me.txtAddress2.Text = ""
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.Address1"))
        Me.txtAddress1.Location = New System.Drawing.Point(128, 64)
        Me.txtAddress1.MaxLength = 40
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(376, 22)
        Me.txtAddress1.TabIndex = 2
        Me.txtAddress1.Text = ""
        '
        'txtCompanyName
        '
        Me.txtCompanyName.BackColor = System.Drawing.Color.White
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCompany1, "CompanyProfile.CompanyName"))
        Me.txtCompanyName.Location = New System.Drawing.Point(128, 24)
        Me.txtCompanyName.MaxLength = 40
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(376, 22)
        Me.txtCompanyName.TabIndex = 1
        Me.txtCompanyName.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(40, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "E-Mail :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fax No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone No2 :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Phone No1 :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Post Code :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
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
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "POWERCOM Point Of Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 551)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(792, 22)
        Me.StatusBar1.TabIndex = 28
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
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(344, 472)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(64, 32)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(248, 472)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(64, 32)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(440, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 32)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CompanyProfile", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("Address1", "Address1"), New System.Data.Common.DataColumnMapping("Address2", "Address2"), New System.Data.Common.DataColumnMapping("Postcode", "Postcode"), New System.Data.Common.DataColumnMapping("PhoneNo1", "PhoneNo1"), New System.Data.Common.DataColumnMapping("PhoneNo2", "PhoneNo2"), New System.Data.Common.DataColumnMapping("FaxNo", "FaxNo"), New System.Data.Common.DataColumnMapping("Email", "Email")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM CompanyProfile WHERE (CompanyName = ?) AND (Address1 = ? OR ? IS NULL" & _
        " AND Address1 IS NULL) AND (Address2 = ? OR ? IS NULL AND Address2 IS NULL) AND " & _
        "(Email = ? OR ? IS NULL AND Email IS NULL) AND (FaxNo = ? OR ? IS NULL AND FaxNo" & _
        " IS NULL) AND (PhoneNo1 = ? OR ? IS NULL AND PhoneNo1 IS NULL) AND (PhoneNo2 = ?" & _
        " OR ? IS NULL AND PhoneNo2 IS NULL) AND (Postcode = ? OR ? IS NULL AND Postcode " & _
        "IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address11", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address2", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address21", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaxNo", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaxNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaxNo1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaxNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo11", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo2", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo21", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Postcode", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Postcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Postcode1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Postcode", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO CompanyProfile(Address1, Address2, CompanyName, Email, FaxNo, PhoneNo" & _
        "1, PhoneNo2, Postcode) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarChar, 40, "Address1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarChar, 40, "Address2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarChar, 40, "CompanyName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarChar, 40, "Email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaxNo", System.Data.OleDb.OleDbType.VarChar, 15, "FaxNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNo1", System.Data.OleDb.OleDbType.VarChar, 15, "PhoneNo1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNo2", System.Data.OleDb.OleDbType.VarChar, 15, "PhoneNo2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Postcode", System.Data.OleDb.OleDbType.VarChar, 8, "Postcode"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address1, Address2, CompanyName, Email, FaxNo, PhoneNo1, PhoneNo2, Postcod" & _
        "e FROM CompanyProfile"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE CompanyProfile SET Address1 = ?, Address2 = ?, CompanyName = ?, Email = ?," & _
        " FaxNo = ?, PhoneNo1 = ?, PhoneNo2 = ?, Postcode = ? WHERE (CompanyName = ?) AND" & _
        " (Address1 = ? OR ? IS NULL AND Address1 IS NULL) AND (Address2 = ? OR ? IS NULL" & _
        " AND Address2 IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (FaxNo" & _
        " = ? OR ? IS NULL AND FaxNo IS NULL) AND (PhoneNo1 = ? OR ? IS NULL AND PhoneNo1" & _
        " IS NULL) AND (PhoneNo2 = ? OR ? IS NULL AND PhoneNo2 IS NULL) AND (Postcode = ?" & _
        " OR ? IS NULL AND Postcode IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarChar, 40, "Address1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarChar, 40, "Address2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarChar, 40, "CompanyName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarChar, 40, "Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaxNo", System.Data.OleDb.OleDbType.VarChar, 15, "FaxNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNo1", System.Data.OleDb.OleDbType.VarChar, 15, "PhoneNo1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNo2", System.Data.OleDb.OleDbType.VarChar, 15, "PhoneNo2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Postcode", System.Data.OleDb.OleDbType.VarChar, 8, "Postcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address11", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address2", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address21", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaxNo", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaxNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaxNo1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaxNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo11", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo2", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNo21", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Postcode", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Postcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Postcode1", System.Data.OleDb.OleDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Postcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmCompany
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnUpdate, Me.btnSubmit, Me.StatusBar1, Me.Label1, Me.PictureBox2, Me.GroupBox1, Me.btnClose})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Housekeeping - Company Profile"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsCompany1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub enable(ByVal value As Boolean)
        txtCompanyName.Enabled = Not value
        txtAddress1.Enabled = Not value
        txtAddress2.Enabled = Not value
        txtPostCode.Enabled = Not value
        txtPhoneNo1.Enabled = Not value
        txtPhoneNo2.Enabled = Not value
        txtFaxNo.Enabled = Not value
        txtEmail.Enabled = Not value
        btnSubmit.Enabled = Not value

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Panels(0).Text = Now.ToLongDateString & "  " & Now.ToLongTimeString

    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If e.StatusBarPanel Is StatusBar1.Panels(0) Then
            Shell("rundll32.exe shell32.dll,Control_RunDLL timedate.cpl")
        End If
    End Sub





    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtCompanyName.Text.Trim = "" Then
            MessageBox.Show("Please fill in Company Name!", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        ElseIf txtAddress1.Text.Trim = "" Then
            MessageBox.Show("Please fill in Address!", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        ElseIf txtPostCode.Text.Trim = "" Then
            MessageBox.Show("Please fill in Post Code!", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        ElseIf txtPhoneNo1.Text.Trim = "" Then
            MessageBox.Show("Please fill in aPhone No1!", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        ElseIf Not IsNumeric(txtPostCode.Text) Then
            MessageBox.Show("Post Code Must Be Numeric !", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPostCode.Focus()
            Exit Sub

        ElseIf Not IsNumeric(txtPhoneNo1.Text) Then
            MessageBox.Show("Phone No Must Be Numeric !", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPhoneNo1.Focus()
            Exit Sub


        Else

            Dim strSQL As String
            strSQL = "UPDATE CompanyProfile SET " & _
            "CompanyName = '" & txtCompanyName.Text & "', Address1= '" & txtAddress1.Text & "', Address2= '" & Val(txtAddress2.Text) & "', " & _
            "Postcode= '" & Val(txtPostCode.Text) & "', PhoneNo1='" & Val(txtPhoneNo1.Text) & "',PhoneNo2='" & Val(txtPhoneNo2.Text) & "'," & _
            "FaxNo='" & Val(txtFaxNo.Text) & "', Email='" & txtEmail.Text & "'"

          
            Dim db As New OleDbCommand(strSQL, dc)


            dc.Open()
            db.ExecuteNonQuery()


            OleDbDataAdapter1.Update(DsCompany1.Tables("CompanyProfile"))
            MessageBox.Show("Record has been update successfully!", "Company Profile", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Me.BindingContext(DsCompany1, "Company Profile").EndCurrentEdit()
                'OleDbDataAdapter1.Update(DsCompany1.Tables("Company Profile"))
                'MsgBox("Data Saved Successfully", MsgBoxStyle.Information, "Company Profile")
            enable(True)
            btnUpdate.Enabled = True
            btnSubmit.Enabled = False
            dc.Close()

           

        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        cur = New frmHousekeeping_Main()

        cur.Show()
        Me.Dispose()

    End Sub




    Private Sub txtPhoneNo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo2.KeyPress
        If Not IsNumeric(txtPhoneNo2.Text) Then
            MsgBox("Phone No must be numeric!", MsgBoxStyle.Exclamation, "Company Profile")
            txtPhoneNo2.Clear()
        End If
    End Sub

    Private Sub txtFaxNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFaxNo.KeyPress
        If Not IsNumeric(txtFaxNo.Text) Then
            MsgBox("Fax No must be numeric!", MsgBoxStyle.Exclamation, "Company Profile")
            txtFaxNo.Clear()

        End If
    End Sub

    Private Sub frmCompany_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsCompany1.Clear()
        OleDbDataAdapter1.Fill(DsCompany1)
        enable(True)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnSubmit.Enabled = True
        enable(False)
        btnUpdate.Enabled = False

    End Sub
End Class

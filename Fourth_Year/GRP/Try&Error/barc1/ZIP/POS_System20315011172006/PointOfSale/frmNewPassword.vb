Public Class frmNewAccount
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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConPassword As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsUserAccount1 As PointOfSale.DsUserAccount
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNewAccount))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.DsUserAccount1 = New PointOfSale.DsUserAccount()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConPassword = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUserAccount1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(792, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(208, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 40)
        Me.Label1.TabIndex = 26
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
        Me.StatusBar1.TabIndex = 27
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 776
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Username :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Confirm Password :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Privilege :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUserAccount1, "User Account.Username"))
        Me.txtUsername.Location = New System.Drawing.Point(176, 24)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(144, 22)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = ""
        '
        'DsUserAccount1
        '
        Me.DsUserAccount1.DataSetName = "DsUserAccount"
        Me.DsUserAccount1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsUserAccount1.Namespace = "http://www.tempuri.org/DsUserAccount.xsd"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUserAccount1, "User Account.Pass"))
        Me.txtPassword.Location = New System.Drawing.Point(176, 72)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(144, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        '
        'txtConPassword
        '
        Me.txtConPassword.BackColor = System.Drawing.Color.White
        Me.txtConPassword.Location = New System.Drawing.Point(176, 120)
        Me.txtConPassword.MaxLength = 15
        Me.txtConPassword.Name = "txtConPassword"
        Me.txtConPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassword.Size = New System.Drawing.Size(144, 22)
        Me.txtConPassword.TabIndex = 3
        Me.txtConPassword.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsUserAccount1, "User Account.Privilege"))
        Me.ComboBox1.Items.AddRange(New Object() {"Admin", "User"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 168)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(152, 432)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(72, 32)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "Add New"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(432, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 32)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(576, 432)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "User Account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Pass", "Pass"), New System.Data.Common.DataColumnMapping("Privilege", "Privilege"), New System.Data.Common.DataColumnMapping("Username", "Username")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [User Account] WHERE (Username = ?) AND (Pass = ? OR ? IS NULL AND Pa" & _
        "ss IS NULL) AND (Privilege = ? OR ? IS NULL AND Privilege IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Username", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pass", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pass", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pass1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pass", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Privilege", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Privilege", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Privilege1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Privilege", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [User Account] (Pass, Privilege, Username) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Pass", System.Data.OleDb.OleDbType.VarWChar, 50, "Pass"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Privilege", System.Data.OleDb.OleDbType.VarWChar, 8, "Privilege"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Username", System.Data.OleDb.OleDbType.VarWChar, 15, "Username"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Pass, Privilege, Username FROM [User Account]"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [User Account] SET Pass = ?, Privilege = ?, Username = ? WHERE (Username =" & _
        " ?) AND (Pass = ? OR ? IS NULL AND Pass IS NULL) AND (Privilege = ? OR ? IS NULL" & _
        " AND Privilege IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Pass", System.Data.OleDb.OleDbType.VarWChar, 50, "Pass"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Privilege", System.Data.OleDb.OleDbType.VarWChar, 8, "Privilege"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Username", System.Data.OleDb.OleDbType.VarWChar, 15, "Username"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Username", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pass", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pass", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pass1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pass", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Privilege", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Privilege", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Privilege1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Privilege", System.Data.DataRowVersion.Original, Nothing))
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(344, 376)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(32, 24)
        Me.btnFirst.TabIndex = 11
        Me.btnFirst.Text = "<<"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(376, 376)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(32, 24)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "<"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnNext.Location = New System.Drawing.Point(408, 376)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 24)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.btnLast.Location = New System.Drawing.Point(440, 376)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(32, 24)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">>"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(224, 432)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(504, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(296, 432)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 32)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(360, 432)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(72, 32)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.txtUsername, Me.Label3, Me.txtPassword, Me.txtConPassword, Me.ComboBox1, Me.Label4, Me.Label5})
        Me.GroupBox1.Location = New System.Drawing.Point(208, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 224)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Account"
        '
        'frmNewAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnUpdate, Me.btnEdit, Me.btnCancel, Me.btnDelete, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.btnClose, Me.btnSave, Me.btnAddNew, Me.StatusBar1, Me.Label1, Me.PictureBox2})
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Housekeeping -User Account"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUserAccount1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub count()
        Dim total, current As Integer
        total = Me.BindingContext(DsUserAccount1, "User Account").Count
        current = Me.BindingContext(DsUserAccount1, "User Account").Position + 1

    End Sub

    Private Sub LockTextboxes(ByVal value As Boolean)
        txtUsername.Enabled = Not value
        txtPassword.Enabled = Not value
        txtConPassword.Enabled = Not value
        ComboBox1.Enabled = Not value

    End Sub

    Private Sub enable(ByVal value As Boolean)
        btnCancel.Enabled = Not value
        btnSave.Enabled = Not value
        btnAddNew.Enabled = value
        btnDelete.Enabled = value
        btnClose.Enabled = value
        btnFirst.Enabled = value
        btnLast.Enabled = value
        btnPrevious.Enabled = value
        btnNext.Enabled = value

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusBar1.Panels(0).Text = Now.ToLongDateString & "  " & Now.ToLongTimeString

    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If e.StatusBarPanel Is StatusBar1.Panels(0) Then
            Shell("rundll32.exe shell32.dll,Control_RunDLL timedate.cpl")
        End If
    End Sub

    Private Sub frmNewAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsUserAccount1.Clear()
        OleDbDataAdapter1.Fill(DsUserAccount1)
        count()
        enable(True)
        LockTextboxes(True)


        btnEdit.Enabled = True
        btnUpdate.Enabled = False

    End Sub



    Private Sub frmNewAccount_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.BindingContext(DsUserAccount1, "User Account").Position = 0
        count()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.BindingContext(DsUserAccount1, "User Account").Position -= 1
        count()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.BindingContext(DsUserAccount1, "User Account").Position += 1
        count()

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(DsUserAccount1, "User Account").Position = _
        Me.BindingContext(DsUserAccount1, "User Account").Count - 1
        count()

    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Me.BindingContext(DsUserAccount1, "User Account").EndCurrentEdit()
        Me.BindingContext(DsUserAccount1, "User Account").AddNew()
        enable(False)
        btnEdit.Enabled = False
        btnUpdate.Enabled = False

        LockTextboxes(False)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        intResponse = MessageBox.Show("Are you sure you want to delete this record?", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If intResponse = MsgBoxResult.No Then
            Exit Sub
        Else
            Me.BindingContext(DsUserAccount1, "User Account").RemoveAt _
            (Me.BindingContext(DsUserAccount1, "User Account").Position)
            OleDbDataAdapter1.Update(DsUserAccount1.Tables("User Account"))
            MessageBox.Show("Record has been deleted!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        count()
        End If
    End Sub

    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Or txtConPassword.Text.Trim = "" Or ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please fill in all data!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        ElseIf txtConPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Mismatch between New Password and Confirm Password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConPassword.Focus()
            Exit Sub

        End If

        Try


            Me.BindingContext(DsUserAccount1, "User Account").EndCurrentEdit()
            OleDbDataAdapter1.Update(DsUserAccount1.Tables("User Account"))
            MessageBox.Show("Record saved successfully!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            enable(True)
            txtConPassword.Clear()
            btnEdit.Enabled = True
            count()
            LockTextboxes(True)
            Exit Sub
        Catch
            MessageBox.Show("The Username already exist, please fill in again!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()

        End Try


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsUserAccount1, "User Account").CancelCurrentEdit()
        txtConPassword.Clear()

        enable(True)
        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        LockTextboxes(True)
        count()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        cur = New frmHousekeeping_Main()
        cur.Show()
        Me.Dispose()

    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtUsername.Enabled = False
        txtPassword.Enabled = True
        txtConPassword.Enabled = True
        ComboBox1.Enabled = True
        '''''''''''''''''''''''''''''''
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = True


    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Or txtConPassword.Text.Trim = "" Or ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please fill in all data!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        ElseIf txtConPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Mismatch between New Password and Confirm Password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConPassword.Focus()
            Exit Sub

        End If

        Me.BindingContext(DsUserAccount1, "User Account").EndCurrentEdit()
        OleDbDataAdapter1.Update(DsUserAccount1.Tables("User Account"))
        MessageBox.Show("Record has been update succcessfully!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

        enable(True)
        txtConPassword.Clear()

        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        LockTextboxes(True)
        count()

    End Sub
End Class

Imports System.Data.OleDb
Public Class frmLogin
    Inherits System.Windows.Forms.Form

    Dim TB As Object
    Dim TBIndex As Byte

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPassword, Me.txtUsername, Me.ComboBox1, Me.Label1, Me.btnCancel, Me.btnOk, Me.Label3, Me.Label2})
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 184)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(120, 112)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(120, 22)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(120, 72)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(120, 22)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Admin", "User"})
        Me.ComboBox1.Location = New System.Drawing.Point(120, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login By"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(144, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Location = New System.Drawing.Point(56, 152)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 24)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Ok"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 104)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(342, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TB = txtUsername
        TBIndex = 1
        

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtUsername.Text.Trim = "" Then
            MessageBox.Show("Please fill your User Name !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub

        End If

        If txtPassword.Text.Trim = "" Then
            MessageBox.Show("Please fill your Password !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Exit Sub
        End If

        Dim db As New OleDbCommand _
       ("SELECT * FROM [User Account]" & "WHERE Username = '" & _
       txtUsername.Text & "' " & "AND Pass = '" & txtPassword.Text & "' " & _
        " AND (Privilege = 'Admin') ", dc)

        Dim db2 As New OleDbCommand _
       ("SELECT * FROM [User Account]" & "WHERE Username = '" & _
        txtUsername.Text & "' " & "AND Pass= '" & txtPassword.Text & "' " & _
        " AND (Privilege = 'User') ", dc)



        'Admin Login
        If ComboBox1.SelectedIndex = 0 Then
            db.Parameters.Add("Username", Data.OleDb.OleDbType.Variant)
            db.Parameters.Add("Pass", Data.OleDb.OleDbType.Variant)

            db.Parameters("Username").Value = txtUsername.Text
            db.Parameters("Pass").Value = txtPassword.Text


            dc.Open()

            dr = db.ExecuteReader
            Reader()
            dc.Close()

        End If

        'User Login
        If ComboBox1.SelectedIndex = 1 Then

            db2.Parameters.Add("Username", Data.OleDb.OleDbType.Variant)
            db2.Parameters.Add("Pass", Data.OleDb.OleDbType.Variant)

            db2.Parameters("Username").Value = txtUsername.Text
            db2.Parameters("Pass").Value = txtPassword.Text


            'Open database connection
            dc.Open()

            ' Read information from database
            dr = db2.ExecuteReader

            Reader()


            ' Close database connection
            dc.Close()

        End If

    End Sub

    Private Sub Reader()
        With dr
            If .Read Then
                
                If ComboBox1.SelectedIndex = 0 Then
                    cur = New frmMainMenu()
                    cur.Show()
                    Me.Dispose()

                ElseIf ComboBox1.SelectedIndex = 1 Then
                    cur = New frmMainMenu1()
                    cur.Show()
                    Me.Dispose()
                End If

            Else
                MessageBox.Show("Invalid Password or Username!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                Exit Sub
            End If

            txtUsername.Text = vbNullString
            txtPassword.Text = vbNullString


        End With
    End Sub





    Private Sub txtUsername_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TB = txtUsername
        TBIndex = 1

    End Sub

    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TB = txtPassword
        TBIndex = 2



    End Sub

    Private Sub frmLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        intResponse = MessageBox.Show("Are you sure want to quit ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If intResponse = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If

    End Sub

    
End Class

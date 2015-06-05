Option Explicit On 
'Importing enable to access registry later
Imports Microsoft.Win32
Imports System.Drawing.Image

Public Class Form1
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
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblCompName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtCompName As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblManufactured As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents mmSkin As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents btnImageLoad As System.Windows.Forms.Button
    Friend WithEvents fod As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fsd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lblReg = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblManufacturer = New System.Windows.Forms.Label
        Me.lblCompName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtManufacturer = New System.Windows.Forms.TextBox
        Me.txtCompName = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblManufactured = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.mmSkin = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.btnImageLoad = New System.Windows.Forms.Button
        Me.fod = New System.Windows.Forms.OpenFileDialog
        Me.fsd = New System.Windows.Forms.SaveFileDialog
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.BackColor = System.Drawing.Color.Transparent
        Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.Location = New System.Drawing.Point(104, 48)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(92, 18)
        Me.lblReg.TabIndex = 0
        Me.lblReg.Text = "Registered to:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(72, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Location = New System.Drawing.Point(184, 72)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(59, 16)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Company: "
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.lblManufacturer.Location = New System.Drawing.Point(32, 184)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(74, 16)
        Me.lblManufacturer.TabIndex = 4
        Me.lblManufacturer.Text = "Manufacturer:"
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompName.Location = New System.Drawing.Point(160, 184)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(90, 16)
        Me.lblCompName.TabIndex = 5
        Me.lblCompName.Text = "Computer Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(48, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.TabIndex = 6
        Me.txtName.Text = ""
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(168, 96)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.TabIndex = 7
        Me.txtCompany.Text = ""
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(32, 208)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.TabIndex = 8
        Me.txtManufacturer.Text = ""
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(160, 208)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.TabIndex = 9
        Me.txtCompName.Text = ""
        '
        'lblManufactured
        '
        Me.lblManufactured.AutoSize = True
        Me.lblManufactured.BackColor = System.Drawing.Color.Transparent
        Me.lblManufactured.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufactured.Location = New System.Drawing.Point(48, 152)
        Me.lblManufactured.Name = "lblManufactured"
        Me.lblManufactured.Size = New System.Drawing.Size(207, 18)
        Me.lblManufactured.TabIndex = 1
        Me.lblManufactured.Text = "Manufactured and Supported by:"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(128, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        '
        'mmSkin
        '
        Me.mmSkin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Text = "Skins"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Green"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Blue"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Black"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.Location = New System.Drawing.Point(16, 328)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(148, 119)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'btnImageLoad
        '
        Me.btnImageLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImageLoad.Image = CType(resources.GetObject("btnImageLoad.Image"), System.Drawing.Image)
        Me.btnImageLoad.Location = New System.Drawing.Point(176, 408)
        Me.btnImageLoad.Name = "btnImageLoad"
        Me.btnImageLoad.TabIndex = 14
        Me.btnImageLoad.Text = "Add Picture"
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(256, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(360, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnImageLoad)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCompName)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblManufactured)
        Me.Controls.Add(Me.lblReg)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mmSkin
        Me.Name = "Form1"
        Me.Text = "OEM Info Editor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tool Tips that will show up when user holds cursor over respective TextBox
        ToolTip1.SetToolTip(txtName, "User's Name")
        ToolTip1.SetToolTip(txtCompany, "Company Name. Optional, can be left blank.")
        ToolTip1.SetToolTip(txtManufacturer, "Name of Manufacturer of Computer. Optional")
        ToolTip1.SetToolTip(txtCompName, "Computer Model")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim syspath As String
        syspath = Environ("systemroot") 'gets the system root path
        Dim approot As String
        Try
            picLogo.Image.Save(syspath & "\system32\oemlogo.bmp", Drawing.Imaging.ImageFormat.Bmp) 'save to bmp format
        Catch ex As Exception
        End Try
        '----------------------------------------------

        'Registered to:
        Dim regKey As RegistryKey, regSubKey As RegistryKey
        'regKey now points to HKEY_LOCAL_MACHINE Registry Key
        regKey = Registry.LocalMachine
        'A Sub key called MyProgram is created under the
        'HKEY_CURRENT_USER key
        regSubKey = regKey.CreateSubKey("Software\Microsoft\Windows NT\CurrentVersion")
        'The value of the Key is set to VeryGoodSetting
        regSubKey.SetValue("RegisteredOwner", txtName.Text)
        regSubKey.SetValue("RegisteredOrganization", txtCompany.Text)
        '---------------------------

        'Manufactured by:
        Dim oFile As System.IO.File
        Dim oWrite As System.IO.StreamWriter
        oWrite = oFile.CreateText(syspath & "\system32\oeminfo.ini") 'creates ini file
        oWrite.WriteLine("[General]") 'writes first line
        oWrite.WriteLine("Manufacturer= " & txtManufacturer.Text) 'writes second lind
        oWrite.WriteLine("Model = " & txtCompName.Text)
        oWrite.Close() 'closes StreamWriter
        MsgBox("Info Updated") 'Prompts that Info has now been updated



    End Sub
    'change "skin" of App
    Public Sub MenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        ' Read the resource into a stream
        Dim str As IO.Stream = _
System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OEMeditor.app_layout.gif")
        ' Read the data into a byte array
        Dim buffer(str.Length) As Byte
        str.Read(buffer, 0, str.Length)
        ' Convert the byte array to an image
        Dim img As New ImageConverter
        Dim gif As Image = img.ConvertFrom(buffer)
        ' Show the image in a picture box
        Me.BackgroundImage = gif
    End Sub
    'change "skin" of App
    Public Sub MenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        ' Read the resource into a stream
        Dim str As IO.Stream = _
System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OEMeditor.app_layout2.gif")
        ' Read the data into a byte array
        Dim buffer(str.Length) As Byte
        str.Read(buffer, 0, str.Length)
        ' Convert the byte array to an image
        Dim img As New ImageConverter
        Dim gif As Image = img.ConvertFrom(buffer)
        ' Show the image in a picture box
        Me.BackgroundImage = gif
    End Sub
    'change "skin" of App
    Public Sub MenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        ' Read the resource into a stream
        Dim str As IO.Stream = _
System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OEMeditor.app_layout3.gif")
        ' Read the data into a byte array
        Dim buffer(Str.Length) As Byte
        Str.Read(buffer, 0, Str.Length)
        ' Convert the byte array to an image
        Dim img As New ImageConverter
        Dim gif As Image = img.ConvertFrom(buffer)
        ' Show the image in a picture box
        Me.BackgroundImage = gif
    End Sub

    Private Sub btnImageLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageLoad.Click

        fod.Filter = "Image Files (*.bmp; *.jpg; *.gif; *.tiff; *.png) | *.bmp;*.jpg;*.gif;*.tiff;*.png"
        fod.ShowDialog()
        Try
            picLogo.Image = picLogo.Image.FromFile(fod.FileName)
        Catch ex As Exception
            MessageBox.Show("Please check that you have entered a correct filename" & vbNewLine _
            & "If filename is correct the image file might be corrupt...", "File cannot be loaded", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'following code resizes picture to fit

        Dim syspath As String
        syspath = Environ("systemroot")

        Dim bm As New Bitmap(picLogo.Image)

        Dim myX As Integer = Val(148)

        Dim myY As Integer = Val(119)

        Dim thumb As New Bitmap(myX, myY)

        Dim g As Graphics = Graphics.FromImage(thumb)

        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        g.DrawImage(bm, New Rectangle(0, 0, myX, myY), New Rectangle(0, 0, bm.Width, _
bm.Height), GraphicsUnit.Pixel)

        g.Dispose()



        thumb.Save(syspath & "\system32\oemlogo.bmp", _
System.Drawing.Imaging.ImageFormat.Bmp)

        bm.Dispose()

        thumb.Dispose()

        Me.Close()  'exit app
    End Sub

End Class

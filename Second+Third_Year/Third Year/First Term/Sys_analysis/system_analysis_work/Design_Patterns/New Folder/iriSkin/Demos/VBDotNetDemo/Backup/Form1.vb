Public Class Form1
    Inherits System.Windows.Forms.Form

    Private CurrentSkin As Integer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SkinCollectionItem1 As Sunisoft.IrisSkin.SkinCollectionItem
    Friend WithEvents SkinCollectionItem2 As Sunisoft.IrisSkin.SkinCollectionItem
    Friend WithEvents SkinCollectionItem3 As Sunisoft.IrisSkin.SkinCollectionItem
    Friend WithEvents SkinCollectionItem4 As Sunisoft.IrisSkin.SkinCollectionItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents pnlTackBar As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlButton As System.Windows.Forms.Panel
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.pnlButton = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.pnlTackBar = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.SkinCollectionItem1 = New Sunisoft.IrisSkin.SkinCollectionItem()
        Me.SkinCollectionItem2 = New Sunisoft.IrisSkin.SkinCollectionItem()
        Me.SkinCollectionItem3 = New Sunisoft.IrisSkin.SkinCollectionItem()
        Me.SkinCollectionItem4 = New Sunisoft.IrisSkin.SkinCollectionItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.pnlButton.SuspendLayout()
        Me.pnlTackBar.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Button1.Location = New System.Drawing.Point(280, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Exit"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem1})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7})
        Me.MenuItem6.Text = "&File"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "&Exit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem1.Text = "&Skin"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Load skin..."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "&Remove skin"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "&Switch to another 'built in' skin"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "Switch to &main 'built in' skin"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a skin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Page", "Silver", "Emerald", "MSN", "Longhorn", "None skin"})
        Me.ComboBox1.Location = New System.Drawing.Point(120, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 20)
        Me.ComboBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlList, Me.pnlButton, Me.pnlTackBar, Me.pnlForm})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(120, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 337)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'pnlList
        '
        Me.pnlList.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListView1})
        Me.pnlList.Location = New System.Drawing.Point(24, 200)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(384, 248)
        Me.pnlList.TabIndex = 13
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(384, 248)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Age"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 300
        '
        'pnlButton
        '
        Me.pnlButton.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button10, Me.Button9, Me.ComboBox2, Me.TextBox1, Me.CheckBox1, Me.RadioButton1})
        Me.pnlButton.Location = New System.Drawing.Point(-16, 32)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(328, 160)
        Me.pnlButton.TabIndex = 12
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(144, 120)
        Me.Button10.Name = "Button10"
        Me.Button10.TabIndex = 6
        Me.Button10.Text = "Button10"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(24, 120)
        Me.Button9.Name = "Button9"
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Button9"
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(144, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.Text = "ComboBox2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "TextBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(24, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(144, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "RadioButton1"
        '
        'pnlTackBar
        '
        Me.pnlTackBar.Controls.AddRange(New System.Windows.Forms.Control() {Me.TrackBar1, Me.ProgressBar1})
        Me.pnlTackBar.Location = New System.Drawing.Point(376, 120)
        Me.pnlTackBar.Name = "pnlTackBar"
        Me.pnlTackBar.Size = New System.Drawing.Size(344, 160)
        Me.pnlTackBar.TabIndex = 11
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(16, 72)
        Me.TrackBar1.Maximum = 50
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(304, 45)
        Me.TrackBar1.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 128)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(304, 24)
        Me.ProgressBar1.TabIndex = 9
        '
        'pnlForm
        '
        Me.pnlForm.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button8, Me.Button2, Me.Button3})
        Me.pnlForm.Location = New System.Drawing.Point(224, 32)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(328, 160)
        Me.pnlForm.TabIndex = 10
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(24, 128)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(144, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Show messagebox"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Show form"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Show modal form"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox1, Me.Label1, Me.Button1})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(120, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 56)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Skin"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.Active = True
        Me.SkinEngine1.AddtionalBuiltInSkins.Add(Me.SkinCollectionItem1)
        Me.SkinEngine1.AddtionalBuiltInSkins.Add(Me.SkinCollectionItem2)
        Me.SkinEngine1.AddtionalBuiltInSkins.Add(Me.SkinCollectionItem3)
        Me.SkinEngine1.AddtionalBuiltInSkins.Add(Me.SkinCollectionItem4)
        Me.SkinEngine1.SerialNumber = ""
        Me.SkinEngine1.SkinFile = "D:\Debug\Skins\Page.ssk"
        Me.SkinEngine1.SkinPassword = Nothing
        Me.SkinEngine1.SkinStream = Nothing
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.MemoryStream)
        '
        'SkinCollectionItem1
        '
        Me.SkinCollectionItem1.SkinPassword = Nothing
        Me.SkinCollectionItem1.SkinSteam = CType(resources.GetObject("SkinCollectionItem1.SkinSteam"), System.IO.MemoryStream)
        '
        'SkinCollectionItem2
        '
        Me.SkinCollectionItem2.SkinPassword = Nothing
        Me.SkinCollectionItem2.SkinSteam = CType(resources.GetObject("SkinCollectionItem2.SkinSteam"), System.IO.MemoryStream)
        '
        'SkinCollectionItem3
        '
        Me.SkinCollectionItem3.SkinPassword = Nothing
        Me.SkinCollectionItem3.SkinSteam = CType(resources.GetObject("SkinCollectionItem3.SkinSteam"), System.IO.MemoryStream)
        '
        'SkinCollectionItem4
        '
        Me.SkinCollectionItem4.SkinPassword = Nothing
        Me.SkinCollectionItem4.SkinSteam = CType(resources.GetObject("SkinCollectionItem4.SkinSteam"), System.IO.MemoryStream)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Sunisoft skin file (ssk file) | *.ssk"
        '
        'Panel1
        '
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button7, Me.Button6, Me.Button5, Me.Button4})
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 393)
        Me.Panel1.TabIndex = 5
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 272)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 48)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Form and Dialog"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 48)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "ListView"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 48)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "TackBar and ProgressBar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(8, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 48)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button and TextBox"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 393)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.GroupBox2, Me.Panel1})
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "VBDotNetDemo"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlList.ResumeLayout(False)
        Me.pnlButton.ResumeLayout(False)
        Me.pnlTackBar.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            SkinEngine1.SkinFile = OpenFileDialog1.FileName
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            SkinEngine1.ApplyMainBuiltInSkin()
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            SkinEngine1.ApplyAdditionalBuiltInSkins(0)
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            SkinEngine1.ApplyAdditionalBuiltInSkins(1)
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Then
            SkinEngine1.ApplyAdditionalBuiltInSkins(2)
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        ElseIf ComboBox1.SelectedIndex = 4 Then
            SkinEngine1.ApplyAdditionalBuiltInSkins(3)
            If Not SkinEngine1.Active Then
                SkinEngine1.Active = True
            End If
        ElseIf ComboBox1.SelectedIndex = 5 Then
            SkinEngine1.Active = False
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        SkinEngine1.Active = False
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If CurrentSkin = SkinEngine1.AddtionalBuiltInSkins.Count - 1 Then
            CurrentSkin = 0
        Else : CurrentSkin = CurrentSkin + 1
        End If
        SkinEngine1.ApplyAdditionalBuiltInSkins(CurrentSkin)
        If Not SkinEngine1.Active Then
            SkinEngine1.Active = True
        End If
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        SkinEngine1.ApplyMainBuiltInSkin()
        If Not SkinEngine1.Active Then
            SkinEngine1.Active = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fm As Form2
        fm = New Form2()
        fm.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fm As Form2
        fm = New Form2()
        fm.ShowDialog()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        ProgressBar1.Value = TrackBar1.Value
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("Thanks for using IrisSkin")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pnlButton.BringToFront()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlButton.Dock = DockStyle.Fill
        pnlForm.Dock = DockStyle.Fill
        pnlList.Dock = DockStyle.Fill
        pnlTackBar.Dock = DockStyle.Fill
        pnlButton.BringToFront()

        Dim item As ListViewItem
        Dim i As Integer
        For i = 0 To 30
            item = New ListViewItem(i.ToString())
            item.SubItems.Add("Name" + i.ToString())
            item.SubItems.Add((20 + i).ToString())
            item.SubItems.Add("No description")
            ListView1.Items.Add(item)
        Next

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        pnlTackBar.BringToFront()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        pnlList.BringToFront()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        pnlForm.BringToFront()
    End Sub
End Class

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
    Friend WithEvents DirectoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateDirectory As System.Windows.Forms.Button
    Friend WithEvents txtFunctionOutput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DirectoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.btnCreateDirectory = New System.Windows.Forms.Button()
        Me.txtFunctionOutput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DirectoryGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirectoryGroupBox
        '
        Me.DirectoryGroupBox.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDirectory, Me.btnCreateDirectory, Me.txtFunctionOutput})
        Me.DirectoryGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DirectoryGroupBox.Location = New System.Drawing.Point(8, 0)
        Me.DirectoryGroupBox.Name = "DirectoryGroupBox"
        Me.DirectoryGroupBox.Size = New System.Drawing.Size(168, 128)
        Me.DirectoryGroupBox.TabIndex = 7
        Me.DirectoryGroupBox.TabStop = False
        '
        'txtDirectory
        '
        Me.txtDirectory.AccessibleDescription = "Dierctory text"
        Me.txtDirectory.AccessibleName = "Dierctory text"
        Me.txtDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.txtDirectory.Location = New System.Drawing.Point(16, 24)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(136, 20)
        Me.txtDirectory.TabIndex = 4
        Me.txtDirectory.Text = "c:\My folder"
        '
        'btnCreateDirectory
        '
        Me.btnCreateDirectory.AccessibleDescription = "Create Directory button"
        Me.btnCreateDirectory.AccessibleName = "Create Directory button"
        Me.btnCreateDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.btnCreateDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreateDirectory.Location = New System.Drawing.Point(16, 56)
        Me.btnCreateDirectory.Name = "btnCreateDirectory"
        Me.btnCreateDirectory.Size = New System.Drawing.Size(136, 22)
        Me.btnCreateDirectory.TabIndex = 3
        Me.btnCreateDirectory.Text = "Create folder"
        '
        'txtFunctionOutput
        '
        Me.txtFunctionOutput.AccessibleDescription = "Function output text"
        Me.txtFunctionOutput.AccessibleName = "Function output text"
        Me.txtFunctionOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFunctionOutput.Location = New System.Drawing.Point(16, 88)
        Me.txtFunctionOutput.Multiline = True
        Me.txtFunctionOutput.Name = "txtFunctionOutput"
        Me.txtFunctionOutput.Size = New System.Drawing.Size(136, 22)
        Me.txtFunctionOutput.TabIndex = 8
        Me.txtFunctionOutput.Text = ""
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = "Create Directory button"
        Me.Button1.AccessibleName = "Create Directory button"
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(24, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 22)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Create folder"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Button6, Me.Button5, Me.Button4, Me.Button3, Me.Button2, Me.Button1})
        Me.GroupBox1.Location = New System.Drawing.Point(184, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 128)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "6"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "5"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "4"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "1"
        '
        'Button6
        '
        Me.Button6.AccessibleDescription = "Create Directory button"
        Me.Button6.AccessibleName = "Create Directory button"
        Me.Button6.BackColor = System.Drawing.SystemColors.Window
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(184, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(136, 22)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Delete folder"
        '
        'Button5
        '
        Me.Button5.AccessibleDescription = "Create Directory button"
        Me.Button5.AccessibleName = "Create Directory button"
        Me.Button5.BackColor = System.Drawing.SystemColors.Window
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(184, 56)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 22)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Delete Text Document"
        '
        'Button4
        '
        Me.Button4.AccessibleDescription = "Create Directory button"
        Me.Button4.AccessibleName = "Create Directory button"
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(184, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 22)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Open Text Document"
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = "Create Directory button"
        Me.Button3.AccessibleName = "Create Directory button"
        Me.Button3.BackColor = System.Drawing.SystemColors.Window
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(24, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 22)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Open folder"
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = "Create Directory button"
        Me.Button2.AccessibleName = "Create Directory button"
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(24, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 22)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Create Text Document"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(530, 136)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.DirectoryGroupBox})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create folder by Filip Spasojevic                                                " & _
        "               E-mail: filip001@eunet.yu"
        Me.DirectoryGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCreateDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDirectory.Click
        Dim security As New Win32API.SECURITY_ATTRIBUTES()
        If Win32API.CreateDirectory(txtDirectory.Text, security) Then
            txtFunctionOutput.Text = "Folder je napravljen."
        Else
            txtFunctionOutput.Text = "Folder nije napravljen."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fil As System.IO.Directory
        fil.CreateDirectory("c:\Filip Spasojevic")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fil As New System.IO.StreamWriter("c:\Filip Spasojevic\Filip Spasojevic.txt")
        fil.WriteLine("Filip Spasojevic play tennis every day")
        fil.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim startInfo As New ProcessStartInfo("c:\Filip Spasojevic")
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim startInfo As New ProcessStartInfo("c:\Filip Spasojevic\Filip Spasojevic.txt")
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fil As System.IO.File
        fil.Delete("c:\Filip Spasojevic\Filip Spasojevic.txt")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim fil As System.IO.Directory
        fil.Delete("c:\Filip Spasojevic")
    End Sub
End Class

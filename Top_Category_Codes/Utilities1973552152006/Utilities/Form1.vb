Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Declare Function SHShutDownDialog Lib "shell32" Alias "#60" (ByVal YourGuess As Long) As Long
    Private Declare Function LockWorkStation Lib "user32.dll" () As Long

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
    Friend WithEvents Applicationtxt As System.Windows.Forms.TextBox
    Friend WithEvents Activate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Activate = New System.Windows.Forms.Button()
        Me.Applicationtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Activate
        '
        Me.Activate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Activate.Location = New System.Drawing.Point(352, 40)
        Me.Activate.Name = "Activate"
        Me.Activate.Size = New System.Drawing.Size(160, 40)
        Me.Activate.TabIndex = 0
        Me.Activate.Text = "Activate"
        '
        'Applicationtxt
        '
        Me.Applicationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Applicationtxt.Location = New System.Drawing.Point(16, 48)
        Me.Applicationtxt.Name = "Applicationtxt"
        Me.Applicationtxt.Size = New System.Drawing.Size(328, 26)
        Me.Applicationtxt.TabIndex = 1
        Me.Applicationtxt.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter your application path here"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"A:\", "C:\", "D:\", "E:\", "F:\"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = "Select Drive"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(136, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reset"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(16, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Shutdown PC"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(16, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 32)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Change User"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(184, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 32)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "System Properties"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(352, 176)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 32)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Add Remove Program"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(352, 136)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 32)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Adjust Time and  Date"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(184, 256)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(160, 32)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Display Properties"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(184, 216)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 32)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Internet Properties"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(184, 176)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 32)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "Mouse Properties"
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(184, 296)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(160, 32)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "Audio Properties"
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(16, 256)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(160, 32)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "Control Panel"
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(352, 256)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(160, 32)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Calculator"
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(16, 296)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(160, 32)
        Me.Button13.TabIndex = 26
        Me.Button13.Text = "Console Mode"
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(352, 216)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(160, 32)
        Me.Button14.TabIndex = 27
        Me.Button14.Text = "Policy Editor"
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(352, 296)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(160, 32)
        Me.Button15.TabIndex = 28
        Me.Button15.Text = "Media Player"
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(16, 216)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(160, 32)
        Me.Button16.TabIndex = 29
        Me.Button16.Text = "Log Off"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button16, Me.Button15, Me.Button14, Me.Button13, Me.Button12, Me.Button11, Me.Button10, Me.Button9, Me.Button8, Me.Button7, Me.Button6, Me.Button5, Me.Button3, Me.Button4, Me.Button2, Me.Button1, Me.ComboBox1, Me.Label1, Me.Applicationtxt, Me.Activate})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Activate.Click
        On Error Resume Next
        System.Diagnostics.Process.Start(Applicationtxt.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Applicationtxt.Text = ComboBox1.Text
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Drive Selection
        ComboBox1.Text = "Select Drive"
        Applicationtxt.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Shutdown Menu
        SHShutDownDialog(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'For Log Off
        If MsgBox("Are you sure you want to Log Off?", vbYesNo, "Preparing for New User") = vbYes Then
            Try
                LockWorkStation()
            Catch
                MsgBox("You need Windows NT or a Windows NT based O/S", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Add New Hardware
        System.Diagnostics.Process.Start("c:\windows\system32\sysdm.cpl")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Add Remove Programs
        System.Diagnostics.Process.Start("c:\windows\system32\appwiz.cpl")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Adjust Time and Date
        System.Diagnostics.Process.Start("c:\windows\system32\timedate.cpl")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Display Property
        System.Diagnostics.Process.Start("c:\windows\system32\desk.cpl")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Internet Properties
        System.Diagnostics.Process.Start("c:\windows\system32\inetcpl.cpl")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Mouse Properties
        System.Diagnostics.Process.Start("c:\windows\system32\main.cpl")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Audio Device Properties
        System.Diagnostics.Process.Start("c:\windows\system32\mmsys.cpl")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Control Panel
        System.Diagnostics.Process.Start("c:\windows\system32\Control.exe")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'Restart Windows
        System.Diagnostics.Process.Start("c:\windows\system32\Calc.exe")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'DOS Mode
        System.Diagnostics.Process.Start("c:\windows\system32\CMD.exe")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'Group Policy Editor
        System.Diagnostics.Process.Start("c:\windows\system32\gpedit.msc")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        System.Diagnostics.Process.Start("c:\windows\system32\DVDPlay.exe")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        'Log Off
        System.Diagnostics.Process.Start("c:\windows\system32\Logoff.exe")
    End Sub
End Class

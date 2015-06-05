'.Author: Venkat
'Topic: String Manipulation

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents output As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.output = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "-cot-clientonline"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st string"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mid Function"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2nd string"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "-cot-serveronline"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3rd string"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "#my-project#"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Output:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Sub String Fn."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Length Fn."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(592, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Compare Strings"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(472, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 24)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Search Strings"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(472, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 24)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Trim String"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(472, 112)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 24)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Concatnate"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(592, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 24)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "Split Strings"
        '
        'output
        '
        Me.output.BackColor = System.Drawing.SystemColors.Control
        Me.output.Location = New System.Drawing.Point(136, 152)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(440, 20)
        Me.output.TabIndex = 16
        Me.output.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 205)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim first, second, third As String

    Sub assign()
        first = TextBox1.Text
        second = TextBox2.Text
        third = TextBox3.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call assign()
        output.Text = Mid(first, 2, 3)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call assign()
        output.Text = first.Substring(0, 5)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call assign()
        output.Text = Len(first)
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call assign()
        If String.Compare(first, second) = 0 Then
            output.Text = "Both Strings Are Equal."
        Else
            If String.Compare(first, second) > 0 Then
                output.Text = "Second String Is Greater Than First."
            Else
                output.Text = "First String Is Greater Than Second."
            End If
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        Call assign()
        For i = 0 To Len(first) - 1
            output.Text = output.Text & "_" & first.Chars(i)
        Next i
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call assign()
        output.Text = third.Trim("#")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim stringarray(2) As String 'Value of array MUST be specified
        Call assign()
        stringarray(0) = first
        stringarray(1) = second
        stringarray(2) = third
        output.Text = String.Join(",", stringarray)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim i As Integer
        Dim stringarray(2) As String 'Value of array MUST be specified
        Call assign()
        stringarray = third.Split(",")
        For i = 0 To 2
            MsgBox(stringarray(i), MsgBoxStyle.ApplicationModal, "Splited String Values:")
        Next


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

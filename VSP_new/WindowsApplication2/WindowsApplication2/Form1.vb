Imports System.io
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
    Friend WithEvents txtPsw As System.Windows.Forms.TextBox
    Friend WithEvents lblShow As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtShow As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtPsw = New System.Windows.Forms.TextBox
        Me.lblShow = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.txtShow = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(8, 24)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Size = New System.Drawing.Size(272, 20)
        Me.txtPsw.TabIndex = 1
        Me.txtPsw.Text = "PassWord"
        '
        'lblShow
        '
        Me.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow.Location = New System.Drawing.Point(96, 72)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(152, 24)
        Me.lblShow.TabIndex = 3
        Me.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Crack"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(8, 72)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 24)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Clear"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter Code to Decode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(168, 96)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(80, 32)
        Me.lblResult.TabIndex = 9
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Location = New System.Drawing.Point(8, 184)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(264, 32)
        Me.lblTime.TabIndex = 10
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(8, 152)
        Me.txtShow.Multiline = True
        Me.txtShow.Name = "txtShow"
        Me.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtShow.Size = New System.Drawing.Size(264, 20)
        Me.txtShow.TabIndex = 11
        Me.txtShow.Text = ""
        '
        'Timer2
        '
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Code Cracked"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 16)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show Password"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(8, 224)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(264, 30)
        Me.ListBox1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.txtPsw)
        Me.Name = "Form1"
        Me.Text = "Password Cracker"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim startTime As DateTime = Now
    Dim Psw As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPsw.PasswordChar = "*"
        With Timer2
            .Enabled = True
            .Interval = 1
            .Stop()

        End With
        Me.Location = New Point(300, 300)

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static x As Integer = 0 'retain the last value
        Dim Psw As String = txtPsw.Text
        Static n As Integer = 0
        Static Counter As Integer = 0

        'Error Proof
        If txtPsw.Text = "" Then Exit Sub
        n += 1

        'count comparisons
        Counter += 1
        lblShow.Text = Counter & "  Number of  Comparisson"
        'show characters
        Label1.Text = (Microsoft.VisualBasic.ChrW(n))

        If x = txtPsw.TextLength Then Timer2.Start() : Exit Sub

        'character found reset it
        'this will speed thing up !!!
        If Label1.Text = Psw.Substring(x, 1) Then
            'add it to the other char & display it
            'MY MISTAKE WAS PUTTING THIS LINE AFTER x+=1
            txtShow.Text = txtShow.Text & (Psw.Substring(x, 1))
            ListBox1.Items.Add(" # " & x & " =  " & Microsoft.VisualBasic.ChrW(n) & "   Char # :  " & n)
            n = 0
            x += 1


            lblResult.Text = " Char #  " & x
        End If
        ' StopWatch time how long it took!
        Dim span As TimeSpan = DateTime.Now.Subtract(startTime)
        lblTime.Text = "Time Ellapsed ..   " & span.Minutes.ToString & ":" & _
        span.Seconds.ToString & ":" & span.Milliseconds

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Static x As Integer = 0
        Select Case Button1.Text
            Case Is = "Start"
                Timer1.Start()
                Timer2.Stop()
                Button1.Text = "Stop"
                'if timer1 is stopped restart it !
                If Timer1 Is Nothing Then Timer1.Enabled = True : Timer1.Interval = 1 : Timer1.Start()
                Timer1.Interval = 1
                Timer1.Enabled = True
                'if String is empty error proff it!
                If txtPsw.Text = "" Then MessageBox.Show("No Password Detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Case Is = "Stop"
                Timer1.Stop()
                Button1.Text = "Crack"

            Case Is = "Crack"
                Button1.Text = "Start"
        End Select
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtShow.Clear()
        txtPsw.Clear()
        ListBox1.Items.Clear()
        Static x As Integer = 0
        Static n As Integer = 0
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click
        If (Timer1.Enabled) Then
            lblTime.Text = "Click to Re-start"
            Timer1.Stop()
        Else
            startTime = DateTime.Now()
            lblTime.Text = "Click to Stop"
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Stop if password is found!

        Timer1.Stop()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPsw.PasswordChar = ""
        Else
            txtPsw.PasswordChar = "*"
        End If
    End Sub



End Class
Public Class frmTrivialExample
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
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(120, 24)
        Me.label3.TabIndex = 22
        Me.label3.Text = "2) Click ""Do It"" to try it."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(33, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "1) Enter some data likely to fail such as 19/0."
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(152, 32)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(64, 23)
        Me.lblResult.TabIndex = 19
        Me.lblResult.Text = "equals:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "divided by"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(104, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Do It"
        '
        'frmTrivialExample
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmTrivialExample"
        Me.Text = "Trivial Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            '''sloppy, non validated code likely to cause errors.
            Me.lblResult.Text = Convert.ToString(Convert.ToDecimal(Me.TextBox1.Text) / Convert.ToDecimal(Me.TextBox2.Text))
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            frmMDI.getInstance().Sentry.Report(ex)
            System.Windows.Forms.MessageBox.Show("A serious error has occurred: " & ex.Message & vbCr & "Staff have been notified.")
        End Try
    End Sub
End Class

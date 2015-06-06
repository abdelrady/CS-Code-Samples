Public Class frmFeedback
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
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label3 = New System.Windows.Forms.Label
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(8, 8)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(384, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Your feedback helps us make this program better. "
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(72, 64)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(296, 280)
        Me.txtComments.TabIndex = 11
        Me.txtComments.Text = ""
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(8, 72)
        Me.label2.Name = "label2"
        Me.label2.TabIndex = 10
        Me.label2.Text = "Comments:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(352, 376)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 9
        Me.button1.Text = "Submit"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(72, 40)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(296, 20)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.Text = ""
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 16)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Your Email:"
        '
        'frmFeedback
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 421)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmFeedback"
        Me.Text = "Feedback"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        Try
            frmMDI.getInstance().Sentry.Report("Feedback from " + Me.txtEmail.Text, Me.txtComments.Text, ITCollaborate.BugSentry.Issue.IssueTypes.EndUserFeature) 'you could add a drop down for each enum 
            System.Windows.Forms.MessageBox.Show("Thanks for your input!")
            Me.Dispose()
        Catch ex As Exception
            frmMDI.getInstance().Sentry.Report(ex)
            System.Windows.Forms.MessageBox.Show("There was an error sending your feedback.  me error has been logged and staff will be notified.")
        End Try
	End Sub
End Class

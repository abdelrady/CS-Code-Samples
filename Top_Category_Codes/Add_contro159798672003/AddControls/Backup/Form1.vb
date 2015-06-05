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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click anywhere on the form to place a button there. Click on any of the buttons t" & _
        "o see what happens."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 198)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim b As Button = CType(sender, Button)
        MessageBox.Show("You clicked button with text='" + b.Text + "'")
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Static num As Integer = 1

        Dim b As New Button() 'create a new button object, can be anything that inherits Windows.Forms.Control
        b.SetBounds(e.X, e.Y, 40, 40) ' set the size and location of the control
        b.Text = num.ToString() 'set the text for the button
        num += 1

        'the important section is here , you need to add an event handler 
        'to the object's event (muticast delegate)
        'remember that you have to use the correct delegate
        'here we use the EventHandler delegate but 
        ' for example if we wanted to handle the KeyDown event
        'we should have use the Windows.Forms.KeyEventHandler delegate 
        'and therefore, our method to handle the event would
        'implement that delegate( have the same parameters list , and return type)

        AddHandler b.Click, New EventHandler(AddressOf Button_Click)
        Me.Controls.Add(b)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

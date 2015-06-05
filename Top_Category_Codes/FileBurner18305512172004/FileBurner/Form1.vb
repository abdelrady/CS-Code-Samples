
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
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtOutput.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtOutput.Enabled = False
        Me.txtOutput.ForeColor = System.Drawing.Color.Red
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(280, 120)
        Me.txtOutput.TabIndex = 0
        Me.txtOutput.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 115)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOutput})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "File Burn"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Argument As String()
        Dim FileToBurn As String
        Dim i As Integer
        Dim Check As String
        

        Argument = System.Environment.GetCommandLineArgs
        If Argument.GetLength(0) = 1 Then
            txtOutput.Text = ""
            txtOutput.Text = "No File Selected"
            txtOutput.Select(1, 0)
            Timer1.Enabled = True
        Else
            Try
                Check = InputBox("Are You Sure You Wish To Destroy This File? Type 'Delete' to Continue or 'Exit' to Cancel", "Last Chance", "")
                If Check.ToUpper <> "DELETE" Then
                    End
                End If

                For i = 1 To Argument.GetLength(0)
                    txtOutput.Text = "Burning File...." & vbCrLf & "Please Wait..."
                    FileToBurn = Argument(i)
                    FileOpen(1, FileToBurn, OpenMode.Output)
                    Do Until EOF(1)
                        Print(1, "")
                    Loop
                    FileClose(1)
                    Kill(FileToBurn)
                Next i


            Catch
                txtOutput.Text = ""
                txtOutput.Text = "Error!"
                txtOutput.Select(1, 0)
                Timer1.Enabled = True

            Finally
                FileClose(1)
                txtOutput.Text = ""
                txtOutput.Text = "Done"
                txtOutput.Select(1, 0)
                Timer1.Enabled = True

            End Try


        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        End
    End Sub

  
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        End
    End Sub



End Class

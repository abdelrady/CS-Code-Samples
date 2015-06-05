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
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mojsockserver As AxMSWinsockLib.AxWinsock
    Friend WithEvents mojsockklijent As AxMSWinsockLib.AxWinsock
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mojsockserver = New AxMSWinsockLib.AxWinsock()
        Me.mojsockklijent = New AxMSWinsockLib.AxWinsock()
        CType(Me.mojsockserver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mojsockklijent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.AutoSize = False
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(32, 208)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(320, 112)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "client"
        '
        'TextBox2
        '
        Me.TextBox2.AutoSize = False
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(32, 14)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(312, 114)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "server"
        '
        'mojsockserver
        '
        Me.mojsockserver.Enabled = True
        Me.mojsockserver.Location = New System.Drawing.Point(512, 216)
        Me.mojsockserver.Name = "mojsockserver"
        Me.mojsockserver.OcxState = CType(resources.GetObject("mojsockserver.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mojsockserver.Size = New System.Drawing.Size(28, 28)
        Me.mojsockserver.TabIndex = 13
        '
        'mojsockklijent
        '
        Me.mojsockklijent.Enabled = True
        Me.mojsockklijent.Location = New System.Drawing.Point(512, 272)
        Me.mojsockklijent.Name = "mojsockklijent"
        Me.mojsockklijent.OcxState = CType(resources.GetObject("mojsockklijent.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mojsockklijent.Size = New System.Drawing.Size(28, 28)
        Me.mojsockklijent.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.mojsockklijent, Me.mojsockserver, Me.TextBox3, Me.Button2, Me.TextBox2, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "simple dummy chat V.00001"
        CType(Me.mojsockserver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mojsockklijent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mojsockserver.SendData("it's me!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mojsockklijent.SendData("it's me!")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mojsockserver.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol
        mojsockserver.RemoteHost = "127.0.0.1"
        mojsockserver.RemotePort = "9999"
        mojsockserver.Bind(1001)

        mojsockklijent.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol
        mojsockklijent.RemoteHost = "127.0.0.1"
        mojsockklijent.RemotePort = "1001"
        mojsockklijent.Bind(9999)

    End Sub

    Private Sub mojsockserver_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles mojsockserver.DataArrival
        Dim strData As Object
        mojsockserver.GetData(strData)
        TextBox2.AppendText("client> " & makestring(strData) & vbCrLf)
    End Sub

    Private Sub mojsockklijent_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles mojsockklijent.DataArrival
        Dim strData As Object
        mojsockklijent.GetData(strData)
        TextBox3.AppendText("server> " & makestring(strData) & vbCrLf)
    End Sub

    Private Function makestring(ByVal strData As Array) As String
        Dim temp As Long, mystring As String
        mystring = ""
        For temp = 0 To UBound(strData)
            mystring = mystring + Chr(strData(temp))
        Next
        Return mystring
    End Function

End Class

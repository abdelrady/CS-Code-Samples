'Author: Venkat: 
'Topic: Socket Programming

Imports System.Threading
Imports System.Net.Sockets
Imports System.Text
Public Class Form2
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.Button2 = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "stop the thread\socket routine"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenu = Me.ContextMenu1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = CType(configurationAppSettings.GetValue("Form2.ShowInTaskbar", GetType(System.String)), String)
        Me.NotifyIcon1.Visible = CType(configurationAppSettings.GetValue("Form2.ShowInTaskbar", GetType(System.Boolean)), Boolean)
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Start"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Stop"
        '
        'Form2
        '
        Me.AutoScale = CType(configurationAppSettings.GetValue("Form2.AutoScale", GetType(System.Boolean)), Boolean)
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(232, 61)
        Me.ControlBox = CType(configurationAppSettings.GetValue("Form2.ShowInTaskbar", GetType(System.Boolean)), Boolean)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form2"
        Me.ShowInTaskbar = CType(configurationAppSettings.GetValue("Form2.ShowInTaskbar", GetType(System.Boolean)), Boolean)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Const portNumber As Integer = 13
    Dim tcpListener As New TcpListener(portNumber)
    Dim tcpClient As TcpClient
    Dim t1 As New Thread(AddressOf checkmessages)
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t1.Start()
    End Sub

  
    Sub checkmessages()

        While True
            tcpListener.Start()
            tcpClient = tcpListener.AcceptTcpClient()
            Dim networkStream As NetworkStream = tcpClient.GetStream()

            Dim bytes(tcpClient.ReceiveBufferSize) As Byte
            networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))

            ' Returns the data received from the host to the console.
            Dim returndata As String = Encoding.ASCII.GetString(bytes)
            MsgBox(returndata)
            tcpClient.Close()
            tcpListener.Stop()
            bytes.Clear(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t1.Abort()
    End Sub

    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        t1.Start()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        t1.Abort()
    End Sub


End Class

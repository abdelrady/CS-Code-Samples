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
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents radHappy As System.Windows.Forms.RadioButton
    Friend WithEvents radSad As System.Windows.Forms.RadioButton
    Friend WithEvents ctxNotify As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuHappy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSad As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.radHappy = New System.Windows.Forms.RadioButton
        Me.radSad = New System.Windows.Forms.RadioButton
        Me.ctxNotify = New System.Windows.Forms.ContextMenu
        Me.mnuHappy = New System.Windows.Forms.MenuItem
        Me.mnuSad = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenu = Me.ctxNotify
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'radHappy
        '
        Me.radHappy.Image = CType(resources.GetObject("radHappy.Image"), System.Drawing.Image)
        Me.radHappy.Location = New System.Drawing.Point(16, 16)
        Me.radHappy.Name = "radHappy"
        Me.radHappy.Size = New System.Drawing.Size(40, 32)
        Me.radHappy.TabIndex = 2
        '
        'radSad
        '
        Me.radSad.Image = CType(resources.GetObject("radSad.Image"), System.Drawing.Image)
        Me.radSad.Location = New System.Drawing.Point(88, 16)
        Me.radSad.Name = "radSad"
        Me.radSad.Size = New System.Drawing.Size(40, 32)
        Me.radSad.TabIndex = 3
        '
        'ctxNotify
        '
        Me.ctxNotify.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHappy, Me.mnuSad})
        '
        'mnuHappy
        '
        Me.mnuHappy.Index = 0
        Me.mnuHappy.Text = "&Happy"
        '
        'mnuSad
        '
        Me.mnuSad.Index = 1
        Me.mnuSad.Text = "&Sad"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 77)
        Me.Controls.Add(Me.radSad)
        Me.Controls.Add(Me.radHappy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_icoHappy As Icon
    Private m_icoSad As Icon

    Private Sub radHappy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHappy.CheckedChanged
        Me.NotifyIcon1.Icon = m_icoHappy
        Me.Icon = m_icoHappy
    End Sub

    Private Sub radSad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSad.CheckedChanged
        Me.NotifyIcon1.Icon = m_icoSad
        Me.Icon = m_icoSad
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file_path As String = Application.StartupPath
        file_path = file_path.Substring(0, file_path.LastIndexOf("\") + 1)
        m_icoHappy = New Icon(file_path & "Happy.ico")
        m_icoSad = New Icon(file_path & "Sad.ico")

        radHappy.Checked = True
    End Sub

    Private Sub mnuHappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHappy.Click
        Me.NotifyIcon1.Icon = m_icoHappy
        Me.Icon = m_icoHappy
    End Sub

    Private Sub mnuSad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSad.Click
        Me.NotifyIcon1.Icon = m_icoSad
        Me.Icon = m_icoSad
    End Sub
End Class

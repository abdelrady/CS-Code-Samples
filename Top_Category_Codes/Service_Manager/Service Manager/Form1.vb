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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenu = Me.ContextMenu1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 8)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(344, 312)
        Me.ListView1.TabIndex = 2
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Get Services"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Start / Stop"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Resume / Pause"
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Real Name"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 317)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(352, 24)
        Me.StatusBar1.TabIndex = 3
        Me.StatusBar1.Text = "http://www.nuclearwinter.us"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "http://www.nuclearwinter.us"
        Me.StatusBarPanel1.Width = 586
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.StatusBar1, Me.ListView1})
        Me.Name = "Form1"
        Me.Text = ".NET Services Manager by Princeali"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim realname As Boolean = True

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim a() As ServiceProcess.ServiceController
        Dim b As ServiceProcess.ServiceController
        Dim lv As ListViewItem

        ListView1.Items.Clear()


        Dim i As Integer
        a = b.GetServices
        For i = 0 To (a.Length - 1)
            lv = ListView1.Items.Add(a(i).DisplayName)
            lv.SubItems.Add(a(i).Status)
            lv.SubItems.Add(a(i).ServiceName)



        Next

        lv = Nothing





    End Sub





    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        refreshservices()
        StatusBar1.Panels(0).Text = "Services Listed"


    End Sub

    Sub refreshservices()
        Dim a() As ServiceProcess.ServiceController
        Dim b As ServiceProcess.ServiceController
        Dim lv As ListViewItem

        ListView1.Items.Clear()


        Dim i As Integer
        a = b.GetServices
        For i = 0 To (a.Length - 1)
            If realname = True Then lv = ListView1.Items.Add(a(i).DisplayName) Else lv = ListView1.Items.Add(a(i).ServiceName)
            lv.SubItems.Add(a(i).Status.ToString)
            lv.SubItems.Add(a(i).ServiceName)



        Next

        lv = Nothing
    End Sub




    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click



        Try
            If ListView1.SelectedItems(0).SubItems(1).Text = "Running" Then
                Dim b As New ServiceProcess.ServiceController(ListView1.SelectedItems(0).SubItems(2).Text)
                b.Stop()
                StatusBar1.Panels(0).Text = "Service Stopped"
                b = Nothing

            End If

            If ListView1.SelectedItems(0).SubItems(1).Text = "Stopped" Then
                Dim b As New ServiceProcess.ServiceController(ListView1.SelectedItems(0).SubItems(2).Text)
                b.Start()
                StatusBar1.Panels(0).Text = "Service Started"
                b = Nothing

            End If

        Catch R As Exception
            StatusBar1.Panels(0).Text = "An Error Occured While Performing the Operation"

        End Try

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            If ListView1.SelectedItems(0).SubItems(1).Text = "Paused" Then
                Dim b As New ServiceProcess.ServiceController(ListView1.SelectedItems(0).SubItems(2).Text)
                b.Continue()

                StatusBar1.Panels(0).Text = "Service Resumed"
                b = Nothing

            End If

            If Not (ListView1.SelectedItems(0).SubItems(1).Text = "Paused") Then
                Dim b As New ServiceProcess.ServiceController(ListView1.SelectedItems(0).SubItems(2).Text)
                b.Pause()

                StatusBar1.Panels(0).Text = "Service Paused"
                b = Nothing

            End If

        Catch R As Exception
            StatusBar1.Panels(0).Text = "An Error Occured While Performing the Operation"

        End Try
    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If ContextMenu1.MenuItems(3).Checked = True Then
            realname = False
            ContextMenu1.MenuItems(3).Checked = False
            refreshservices()

            Exit Sub


        End If
        If ContextMenu1.MenuItems(3).Checked = False Then
            realname = True
            ContextMenu1.MenuItems(3).Checked = True
            refreshservices()


        End If

    End Sub
End Class

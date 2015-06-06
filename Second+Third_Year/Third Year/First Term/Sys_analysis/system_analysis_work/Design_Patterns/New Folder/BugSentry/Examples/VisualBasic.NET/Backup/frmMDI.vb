Public Class frmMDI
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrivialExample As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFeedback As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuTrivialExample = New System.Windows.Forms.MenuItem
        Me.mnuFeedback = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.MenuItem1.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "&Exit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTrivialExample, Me.mnuFeedback})
        Me.MenuItem3.Text = "F&orms"
        '
        'mnuTrivialExample
        '
        Me.mnuTrivialExample.Index = 0
        Me.mnuTrivialExample.Text = "&Trivial Example"
        '
        'mnuFeedback
        '
        Me.mnuFeedback.Index = 1
        Me.mnuFeedback.Text = "&Feedback"
        '
        'frmMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMDI"
        Me.Text = "VB Example"

    End Sub

#End Region
    Private Shared _Sentry As ITCollaborate.BugSentry.Sentry
    Private Shared myInstance As frmMDI
    Public Shared ReadOnly Property getInstance() As frmMDI
        Get
            If myInstance Is Nothing Then
                myInstance = New frmMDI
            End If
            Return myInstance
        End Get
    End Property

    Public Sub ReportErrorIfUserOKs(ByVal ex As Exception)
        Dim myErrorReportForm As frmConfirmReport
        myErrorReportForm = New frmConfirmReport("A serious error has occurred.  Report this to ACME software?", "Yes", "No", "Send error report?")
        myErrorReportForm.setException(ex)
        myErrorReportForm.ShowDialog()
        If myErrorReportForm.DialogResult = System.Windows.Forms.DialogResult.OK Then
            frmMDI.getInstance().Sentry.Report(ex)
        End If
    End Sub

    Public ReadOnly Property Sentry() As ITCollaborate.BugSentry.Sentry
        Get
            ''''COPY VALUE FROM BUGSENTRY DEV CLIENT
            Dim MyLicenseCode As String = ""

            ''''COPY VALUE FROM BUGSENTRY DEV CLIENT
            Dim MyPublicKey As String = ""

            ''''BugSentry will create it if it doesn't exist, but BugSentry must have exclusive access to this directory.  Store nothing else here.
            Dim myCacheDirectory As String = ""

            ''''Instructs BugSentry to cache issues in a directory on the hard drive.
            Dim myCacheType As ITCollaborate.BugSentry.Sentry.CacheStorageTypes = ITCollaborate.BugSentry.Sentry.CacheStorageTypes.Directory



            If _Sentry Is Nothing Then

                If MyLicenseCode.Length = 0 Then
                    MsgBox("License code not specified.  Copy it from the BugSentry Dev Client's Tools menu.")
                    MsgBox("This application will now crash horribly.")
                    Exit Property
                End If
                If MyPublicKey.Length = 0 Then
                    MsgBox("Public Key not specified.  Copy it from the BugSentry Dev Client's Tools menu.")
                    MsgBox("This application will now crash horribly.")
                    Exit Property
                End If

                If myCacheDirectory.Length = 0 AndAlso myCacheType = ITCollaborate.BugSentry.Sentry.CacheStorageTypes.Directory Then
                    MsgBox("Cache directory not specified.  Specify a directory to which you have permissions.")
                    MsgBox("This application will now crash horribly.")
                    Exit Property
                End If

                _Sentry = New ITCollaborate.BugSentry.Sentry(MyLicenseCode, MyPublicKey, myCacheType, myCacheDirectory)
            End If
            Return _Sentry

        End Get
    End Property

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuTrivialExample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrivialExample.Click
        Try
            Dim frm As frmTrivialExample
            frm = New frmTrivialExample
            frm.Show()
        Catch ex As Exception
            Me.Sentry.Report(ex)
            MsgBox("A serious error has occurred" & ex.Message & vbCr & "Staff have been notified.")
        End Try
    End Sub

    Private Sub mnuFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFeedback.Click
        Try
            Dim frm As frmFeedback
            frm = New frmFeedback
            frm.Show()
        Catch ex As Exception
            Me.Sentry.Report(ex)
            MsgBox("A serious error has occurred" & ex.Message & vbCr & "Staff have been notified.")
        End Try

    End Sub

    Private Sub frmMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class

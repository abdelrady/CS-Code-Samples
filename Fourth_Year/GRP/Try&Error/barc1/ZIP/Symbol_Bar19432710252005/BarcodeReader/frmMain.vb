#Region " Authors Notes "

'< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >
'< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >
'< - -                                                                                 - - >
'< - -  P r o j e c t  N a m e : Symbol BarCode Reader                                 - - >
'< - -                                                                                 - - >
'< - -  Created By: George Goehring                                                    - - > 
'< - -  Date: 2005.10.25                                                               - - >
'< - -                                                                                 - - >
'< - -  I P D G 3  I n c.                                                              - - >
'< - -                                                                                 - - >
'< - -                ()                                                               - - >
'< - -                /       IPDG3 Helps Developers and Programmers Find Resources    - - >
'< - -  ()     __------                                                                - - >
'< - -   \   <=__----_  \     We offer resources for ASP, C/C++, CSS, CGI, Delphi,     - - >
'< - -    \        /  \  \    DHTML, Java, JavaScript, .NET, Perl, PHP, Visual Basic,  - - >
'< - -    -----------  \  \   XML, Zope, databases, networking and many others.        - - >
'< - -   /           \  \  \                                                           - - >
'< - -  /             \  |  | We also have source code, tutorials, book reviews,       - - >
'< - - (   I P D G 3   ) |  ) contest, forums and other computer Q&A. Consulting       - - >
'< - -  \             /  |  | is also available.                                       - - >
'< - -   \           /  /  /                                                           - - >
'< - -    -----------  /  /   Developing Products to fit all your computer needs as    - - >
'< - -    /    __  \  /  /    well as giving you the tools to build future business    - - >
'< - -   /   <=__----   /     today.                                                   - - >
'< - -  ()       ------                                                                - - >
'< - -                \       For more information please visit our website for        - - >
'< - -                ()      details.                                                 - - >
'< - -									                                               - - >
'< - - www.ipdg3.com - iamtgo3@ipdg3.com                                               - - >
'< - -											                                       - - >
'< - - Book Reviews - http://www.ipdg3.com/bookreview.php                              - - >
'< - - Chatroom - http://www.ipdg3.com/chatroom.php                                    - - >
'< - - Contest - http://www.ipdg3.com/contest.php                                      - - >
'< - - Forums = http://forums.ipdg3.com                                                - - >
'< - - IPDG3 Gear - http://www.cafeshops.com/ipdg3                                     - - >
'< - - Links - http://www.ipdg3.com/links.php                                          - - >
'< - - ORB - http://www.ipdg3.com/orb.php                                              - - >
'< - - Source Code - http://www.ipdg3.com/sourcecode.php                               - - >
'< - - Tutorials - http://www.ipdg3.com/tutorial.php                                   - - >
'< - - Wireless Site - http://www.ipdg3.com/Wireless                                   - - >
'< - -                                                                                 - - >
'< - -                                                                                 - - >
'< - -     IIIIIIIIII   PPPPPPPPP    DDDDDDDD       GGGGGG       333333                - - >
'< - -     IIIIIIIIII   PPPP   PPP   DDDDDDDDD    GGGGGGGGGG   3333333333              - - >
'< - -        IIII      PPPP   PPP   DDDD   DDD   GGGG    GG   3333  3333              - - >
'< - -        IIII      PPPP   PPP   DDDD   DDD   GGGG               3333              - - >
'< - -        IIII      PPPPPPPPP    DDDD   DDD   GGGG  GGGG      33333                - - >
'< - -        IIII      PPPP         DDDD   DDD   GGGG  GGGG         3333              - - >
'< - -        IIII      PPPP         DDDD   DDD   GGGG    GG   3333  3333              - - >
'< - -     IIIIIIIIII   PPPP         DDDDDDDDD    GGGGGGGGGG   3333333333              - - >
'< - -     IIIIIIIIII   PPPP         DDDDDDD        GGGGGG       333333                - - >
'< - -																			       - - >
'< - -                    __ __													       - - >
'< - -  W e  W o u l d   (  '  )                                                       - - >
'< - -                >>>-\ - /-->                                                     - - >
'< - -                     \ /    to Hear From You...							       - - >
'< - -                      '													       - - >
'< - -																	               - - >
'< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >
'< - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >

#End Region

#Region " Import Info "

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.InteropServices

#End Region

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Friend WithEvents txtItemNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

#Region " Constant Info "

    Private MyReader As Symbol.Barcode.Reader = Nothing
    Private MyReaderData As Symbol.Barcode.ReaderData = Nothing
    Private MyReadNotifyHander As System.EventHandler = Nothing
    Private MyStatusNotifyHandler As System.EventHandler = Nothing

    Private Declare Function CreateProcess Lib "coredll.Dll" (ByVal strImageName As String, ByVal strCmdLine As String, ByVal pProcessAttributes As IntPtr, ByVal pThreadAttributes As IntPtr, ByVal bInheritsHandle As Integer, ByVal dwCreationFlags As Integer, ByVal pEnvironment As IntPtr, ByVal pCurrentDir As IntPtr, ByVal bArray() As [Byte], ByVal oProc As ProcessInfo) As Integer
    'Occurs before the form is displayed for the first time.

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScannerStatus As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGotWebAccess As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.txtItemNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtScannerStatus = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGotWebAccess = New System.Windows.Forms.Button
        '
        'txtItemNumber
        '
        Me.txtItemNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtItemNumber.Location = New System.Drawing.Point(8, 160)
        Me.txtItemNumber.Multiline = True
        Me.txtItemNumber.Size = New System.Drawing.Size(216, 56)
        Me.txtItemNumber.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Size = New System.Drawing.Size(216, 20)
        Me.Label2.Text = "Scanner Barcode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.Text = "Scanner Event :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtScannerStatus
        '
        Me.txtScannerStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtScannerStatus.Location = New System.Drawing.Point(120, 112)
        Me.txtScannerStatus.Size = New System.Drawing.Size(104, 21)
        Me.txtScannerStatus.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(232, 104)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(120, 224)
        Me.btnExit.Size = New System.Drawing.Size(104, 20)
        Me.btnExit.Text = "Exit"
        '
        'btnGotWebAccess
        '
        Me.btnGotWebAccess.Location = New System.Drawing.Point(8, 224)
        Me.btnGotWebAccess.Size = New System.Drawing.Size(104, 20)
        Me.btnGotWebAccess.Text = "Got Web Access"
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(234, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGotWebAccess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtScannerStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemNumber)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Text = "Barcode Reader"

    End Sub

    Public Shared Sub Main()
        Application.Run(New frmMain)
    End Sub

#End Region

#Region " Form Load Info "

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initalize the Reader
        If (Me.InitRead()) Then

            'start a read on the reader
            Me.StartStatus()
            Me.StartRead()
        Else

            'if not close the form
            Me.Close()

            Return

        End If

        If (Symbol.Win32.PlatformType = "PocketPC") Then
            Me.Menu = New MainMenu
        End If

    End Sub

#End Region

#Region " Scanner Info "

    Protected Overloads Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)

        'Terminate the reader, call base class
        Me.TermReader()
        MyBase.OnClosing(e)

    End Sub

    'Initalize the Reader

    Private Function InitRead()

        'If reader is already present then fail initialize
        If Not (Me.MyReader Is Nothing) Then
            Return False
        End If

        Try
            'Get Selected device from user
            Dim MyDevice As Symbol.Generic.Device _
                = Symbol.StandardForms.SelectDevice.Select( _
                                        Symbol.Barcode.Device.Title, _
                                        Symbol.Barcode.Device.AvailableDevices)
            If (MyDevice Is Nothing) Then
                MessageBox.Show("No Device Selected", "SelectDevice")
                Return False
            End If

            'create the reader, based on selected device
            Me.MyReader = New Symbol.Barcode.Reader(MyDevice)

            ' Create reader data
            Me.MyReaderData = New Symbol.Barcode.ReaderData( _
             Symbol.Barcode.ReaderDataTypes.Text, _
             Symbol.Barcode.ReaderDataLengths.DefaultText)

            'Enable reader, with wait cursor
            Me.MyReader.Actions.Enable()

            'create event handler
            Me.MyReadNotifyHander = New EventHandler(AddressOf MyReader_ReadNotify)
            Me.MyStatusNotifyHandler = New EventHandler(AddressOf MyReader_StatusNotify)

        Catch ex As Symbol.Exceptions.InvalidRequestException
            MessageBox.Show("InitReader\n" + "Invalid Operation\n" + ex.Message())
            Return False

        Catch ex As Symbol.Exceptions.OperationFailureException
            MessageBox.Show("InitReader\n" + "Operation Failure" + ex.Message())
            Return False

        Catch ex As Symbol.Exceptions.UnimplementedFunctionException
            MessageBox.Show("InitReader\n" + "Unimplemented Function" + ex.Message())
            Return False

        End Try

        AddHandler Me.Activated, New EventHandler(AddressOf ReaderForm_Activated)
        AddHandler Me.Deactivate, New EventHandler(AddressOf ReaderForm_Deactivate)

        Return True

    End Function

    'Stop reading and disable/close reader

    Private Sub TermReader()

        'If we have a reader
        If Not (Me.MyReader Is Nothing) Then

            'stop all notifications
            Me.StopRead()
            Me.StopStatus()
            Try

                'Disable the Reader
                Me.MyReader.Actions.Disable()

                'free it up and assign nothing 
                Me.MyReader.Dispose()

                'Indiacte we no longer have one
                Me.MyReader = Nothing

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("InitReader\n" + "Invalid Operation\n" + ex.Message())

            Catch ex As Symbol.Exceptions.OperationFailureException

                MessageBox.Show("InitReader\n" + "Operation Failure" + ex.Message())

            Catch ex As Symbol.Exceptions.UnimplementedFunctionException

                MessageBox.Show("InitReader\n" + "Unimplemented Function" + ex.Message())

            End Try

        End If

        If Not (Me.MyReaderData Is Nothing) Then

            'Free it up and assign nothing
            Me.MyReaderData.Dispose()

            'Indicate we no longer have one
            Me.MyReaderData = Nothing

        End If

    End Sub

    ' start a read on reader

    Private Sub StartRead()

        'if we have both a reader and readerdata
        If Not ((Me.MyReader Is Nothing) And (Me.MyReaderData Is Nothing)) Then

            Try

                AddHandler MyReader.ReadNotify, Me.MyReadNotifyHander

                'Submit a read
                Me.MyReader.Actions.Read(Me.MyReaderData)

            Catch ex As Symbol.Exceptions.UnimplementedFunctionException
                MessageBox.Show("StartRead\n" + "Unimplemented Function\n" + ex.Message())

            Catch ex As Symbol.Exceptions.InvalidIndexerException
                MessageBox.Show("StartRead\n" + "Invalid Indexer\n" + ex.Message())

            Catch ex As Symbol.Exceptions.OperationFailureException
                MessageBox.Show("StopRead\n" + "Operation Failure\n" + "Result = 0x" + (ex.Result).ToString("X8") + "\n" + ex.Message())

            Catch ex As Symbol.Exceptions.InvalidRequestException
                MessageBox.Show("StartRead\n" + "Invalid Request\n" + ex.Message)

            End Try

        End If

    End Sub

    ' stop all the read

    Private Sub StopRead()

        'if we do not have a reader, then do nothing
        If (Me.MyReader Is Nothing) Then

            Return

        End If
        Try

            'remove read notification handler
            RemoveHandler MyReader.ReadNotify, Me.MyReadNotifyHander

            'Flush (Cancel all pending reads)
            Me.MyReader.Actions.Flush()

        Catch ex As Symbol.Exceptions.UnimplementedFunctionException
            MessageBox.Show("StartRead\n" + "Unimplemented Function\n" + ex.Message())

        Catch ex As Symbol.Exceptions.InvalidRequestException
            MessageBox.Show("StartRead\n" + "Invalid Request\n" + ex.Message())

        Catch ex As Symbol.Exceptions.OperationFailureException
            MessageBox.Show("StopRead\n" + "Operation Failure\n" + "Result = 0x" + (ex.Result).ToString("X8") + "\n" + ex.Message())

        End Try

    End Sub

    'Start Status notification

    Private Sub StartStatus()

        If Not (Me.MyReader Is Nothing) Then

            'Attach  status notification handler
            AddHandler MyReader.StatusNotify, Me.MyStatusNotifyHandler

        End If

    End Sub

    'Stop all status notifications

    Private Sub StopStatus()

        If Not (Me.MyReader Is Nothing) Then

            'detach status notification handler
            RemoveHandler MyReader.StatusNotify, Me.MyStatusNotifyHandler

        End If

    End Sub

    'Status notification handler

    Private Sub MyReader_StatusNotify(ByVal sender As Object, ByVal e As EventArgs)

        'Get Current status
        Dim TheEvent As Symbol.Barcode.BarcodeStatus = Me.MyReader.GetNextStatus

        'set event text in UI
        Me.txtScannerStatus.Text = TheEvent.Text

    End Sub

    'Read notification handler

    Private Sub MyReader_ReadNotify(ByVal sender As Object, ByVal e As EventArgs)

        'Get ReaderData
        Dim TheReaderData As Symbol.Barcode.ReaderData = Me.MyReader.GetNextReaderData

        Select Case TheReaderData.Result

            Case Symbol.Results.SUCCESS

                'Handle the data from this read
                Me.HandleData(TheReaderData)
                Me.StartRead()

            Case Symbol.Results.CANCELED

            Case Else

                Dim sMsg As String
                sMsg = "Read Failed\n" + "Result = " + (CInt(TheReaderData.Result)).ToString("X8")
                MessageBox.Show(sMsg, "ReadNotify")

        End Select

    End Sub

    'Handle data from the reader

    Private Sub HandleData(ByVal TheReaderData As Symbol.Barcode.ReaderData)
        Dim stItemData As String

        stItemData = TheReaderData.Text

        Me.txtItemNumber.Text = Trim(stItemData.ToString)

        'Me.txtItemNumber.Text = Trim(stItemData.Substring(4, 6))

        'Me.txtItemNumber.Text = TheReaderData.Text
        'Me.TypeTextBox.Text = TheReaderData.TypeHex
        'Me.SourceTextBox.Text = TheReaderData.Source
        'Me.TimeTextBox.Text = TheReaderData.TimeStamp.ToString()
        'Me.LengthTextBox.Text = TheReaderData.Length.ToString()

    End Sub

    Private Sub ReaderForm_Activated(ByVal sender As Object, ByVal e As EventArgs)

        Me.StartStatus()
        Me.StartRead()

    End Sub

    Private Sub ReaderForm_Deactivate(ByVal sender As Object, ByVal e As EventArgs)

        Me.StopRead()
        Me.StopStatus()

    End Sub

#End Region

#Region " Button Actions "

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Click from close button

        'close the form
        Me.Close()

    End Sub

    Private Sub btnGotWebAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGotWebAccess.Click

        Dim pi As New ProcessInfo
        CreateProcess("iebrowser.exe", "http://www.ipdg3.com/sourcecoderesults.php?option=sourcecode&id=000579", IntPtr.Zero, IntPtr.Zero, 0, 0, IntPtr.Zero, IntPtr.Zero, New [Byte](128) {}, pi)

    End Sub

#End Region

End Class

Public Class ProcessInfo
    Public Process As Integer
    Public Thread As Integer
    Public ProcessID As Integer
    Public ThreadID As Integer
End Class 'ProcessInfo

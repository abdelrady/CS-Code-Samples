Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Processing As Boolean
    Private backgroundThread As System.Threading.Thread
    Private NEWLINE As String = ControlChars.CrLf
    Private WithEvents _FileSplitMerge As New SplitMerge()
    Private _Progress As Double
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
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptSplit As System.Windows.Forms.RadioButton
    Friend WithEvents OptMerge As System.Windows.Forms.RadioButton
    Friend WithEvents txtOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChunkSize As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseFolder As System.Windows.Forms.Button
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents lblChunkSize As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cmdStart = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkOption = New System.Windows.Forms.CheckBox
        Me.cmdBrowseFolder = New System.Windows.Forms.Button
        Me.txtChunkSize = New System.Windows.Forms.TextBox
        Me.lblChunkSize = New System.Windows.Forms.Label
        Me.txtOutputFolder = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.cmdBrowseFile = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OptSplit = New System.Windows.Forms.RadioButton
        Me.OptMerge = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 176)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(392, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'cmdStart
        '
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStart.Location = New System.Drawing.Point(80, 232)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(72, 32)
        Me.cmdStart.TabIndex = 9
        Me.cmdStart.Text = "&Start"
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(152, 232)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 32)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Location = New System.Drawing.Point(224, 232)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 32)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Text = "E&xit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOption)
        Me.GroupBox1.Controls.Add(Me.cmdBrowseFolder)
        Me.GroupBox1.Controls.Add(Me.txtChunkSize)
        Me.GroupBox1.Controls.Add(Me.lblChunkSize)
        Me.GroupBox1.Controls.Add(Me.txtOutputFolder)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFileName)
        Me.GroupBox1.Controls.Add(Me.cmdBrowseFile)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OptSplit)
        Me.GroupBox1.Controls.Add(Me.OptMerge)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 208)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'chkOption
        '
        Me.chkOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOption.Location = New System.Drawing.Point(120, 128)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(200, 16)
        Me.chkOption.TabIndex = 17
        '
        'cmdBrowseFolder
        '
        Me.cmdBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrowseFolder.Location = New System.Drawing.Point(344, 72)
        Me.cmdBrowseFolder.Name = "cmdBrowseFolder"
        Me.cmdBrowseFolder.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowseFolder.TabIndex = 16
        Me.cmdBrowseFolder.Text = "..."
        '
        'txtChunkSize
        '
        Me.txtChunkSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChunkSize.Location = New System.Drawing.Point(120, 96)
        Me.txtChunkSize.Name = "txtChunkSize"
        Me.txtChunkSize.Size = New System.Drawing.Size(80, 20)
        Me.txtChunkSize.TabIndex = 15
        Me.txtChunkSize.Text = ""
        '
        'lblChunkSize
        '
        Me.lblChunkSize.Location = New System.Drawing.Point(16, 98)
        Me.lblChunkSize.Name = "lblChunkSize"
        Me.lblChunkSize.Size = New System.Drawing.Size(112, 24)
        Me.lblChunkSize.TabIndex = 14
        Me.lblChunkSize.Text = "Chunk Size(Bytes) :"
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputFolder.Location = New System.Drawing.Point(120, 72)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(224, 20)
        Me.txtOutputFolder.TabIndex = 12
        Me.txtOutputFolder.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Output Folder :"
        '
        'txtFileName
        '
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileName.Location = New System.Drawing.Point(120, 48)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(224, 20)
        Me.txtFileName.TabIndex = 10
        Me.txtFileName.Text = ""
        '
        'cmdBrowseFile
        '
        Me.cmdBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrowseFile.Location = New System.Drawing.Point(344, 48)
        Me.cmdBrowseFile.Name = "cmdBrowseFile"
        Me.cmdBrowseFile.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowseFile.TabIndex = 9
        Me.cmdBrowseFile.Text = "..."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FileName :"
        '
        'OptSplit
        '
        Me.OptSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptSplit.Location = New System.Drawing.Point(24, 16)
        Me.OptSplit.Name = "OptSplit"
        Me.OptSplit.Size = New System.Drawing.Size(56, 16)
        Me.OptSplit.TabIndex = 7
        Me.OptSplit.Text = "Split"
        '
        'OptMerge
        '
        Me.OptMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptMerge.Location = New System.Drawing.Point(96, 16)
        Me.OptMerge.Name = "OptMerge"
        Me.OptMerge.Size = New System.Drawing.Size(56, 16)
        Me.OptMerge.TabIndex = 6
        Me.OptMerge.Text = "Merge"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(418, 271)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Split & Merge"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        ProgressBar1.Value = 0
        If ValidateData() Then
            _Progress = 0
            Processing = True
            cmdCancel.Enabled = True
            GroupBox1.Enabled = False
            ProgressBar1.Visible = True
            If OptSplit.Checked Then
                Me.SplitFile()
            Else
                Me.MergeFiles()
            End If
        End If
    End Sub
    ''''
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If Processing Then
            ShowMessage()
        Else
            Me.Close()
        End If
    End Sub
    '''
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If backgroundThread.IsAlive Then backgroundThread.Abort()
        Processing = False
        GroupBox1.Enabled = True
    End Sub
    '''
    Private Sub cmdBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseFile.Click
        Dim FileDialog As New OpenFileDialog()
        FileDialog.FilterIndex = 1
        If FileDialog.ShowDialog() = DialogResult.OK Then
            txtFileName.Text = FileDialog.FileName
        End If
        FileDialog = Nothing
    End Sub
    '''
    Private Sub cmdBrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseFolder.Click
        Dim _OpenDirectoryDialog As New OpenDirectoryDialog()
        _OpenDirectoryDialog.DialogTitle = "Select the output folder "
        If _OpenDirectoryDialog.ShowDialog(Me) = DialogResult.OK Then
            txtOutputFolder.Text = _OpenDirectoryDialog.DirectoryName
        End If
        _OpenDirectoryDialog = Nothing
    End Sub
    '''
    Private Sub ShowMessage()
        If OptSplit.Checked Then
            MsgBox("File Split Process is running.. " & ControlChars.CrLf & "Please wait until the process is completed to exit" & ControlChars.CrLf & "Click on Cancel to terminate the process")
        Else
            MsgBox("File Merging Process is running.. " & ControlChars.CrLf & "Please wait until the process is completed to exit" & ControlChars.CrLf & "Click on Cancel to terminate the process")
        End If
    End Sub
    '''
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Processing Then
            ShowDialog()
            e.Cancel = True
        End If
    End Sub
    '''
    Private Function ValidateData() As Boolean
        Dim _error As String
        Dim _FileSize As Long
        _error = ""
        If txtFileName.Text = "" Then
            _error += "File name can't be empty" & NEWLINE
        Else
            If Not System.IO.File.Exists(txtFileName.Text) Then
                _error += txtFileName.Text & " not found" & NEWLINE
            Else
                _FileSize = _FileSplitMerge.FileSize(txtFileName.Text)
            End If
        End If
        If OptSplit.Checked Then
            If Not IsNumeric(txtChunkSize.Text) Then
                _error += "Chunk Sixe must be a valid number" & NEWLINE
            Else
                If Val(txtChunkSize.Text) >= _FileSize Then _error += "Chunk Size is greater than the file size" & NEWLINE
            End If
        End If
        If _error = "" Then
            Return True
        Else
            MsgBox(_error, MsgBoxStyle.Information, Me.Text)
            Return False
        End If
    End Function
    '''
    Private Sub SplitFile()
        With _FileSplitMerge
            .ChunkSize = txtChunkSize.Text
            .FileName = txtFileName.Text
            .OutputPath = txtOutputFolder.Text
            .DeleteFileAfterSplit = chkOption.Checked
            backgroundThread = New Threading.Thread(AddressOf .SplitFile)
            backgroundThread.Start()
        End With
    End Sub
    '''
    Private Sub MergeFiles()
        With _FileSplitMerge
            .FileName = txtFileName.Text
            .OutputPath = txtOutputFolder.Text
            .DeleteFilesAfterMerge = chkOption.Checked
            backgroundThread = New Threading.Thread(AddressOf .MergeFile)
            backgroundThread.Start()
        End With
    End Sub
    '''
    Private Sub _FileSplitMerge_FileMergeCompleted(ByVal ErrorMessage As String) Handles _FileSplitMerge.FileMergeCompleted
        If ErrorMessage = "" Then
            MsgBox("File Merge process completed")
        Else
            MsgBox("File Merge process Failed" & NEWLINE & ErrorMessage)
        End If
        ResetControls()
    End Sub
    '''
    Private Sub _FileSplitMerge_FileSplitCompleted(ByVal ErrorMessage As String) Handles _FileSplitMerge.FileSplitCompleted
        If ErrorMessage = "" Then
            MsgBox("File Split process completed")
        Else
            MsgBox("File Split process Failed" & NEWLINE & ErrorMessage)
        End If
        ResetControls()
    End Sub
    '''
    Private Sub _FileSplitMerge_UpdateProgress(ByVal Progress As Double) Handles _FileSplitMerge.UpdateProgress
        _Progress += Progress
        If _Progress < ProgressBar1.Maximum Then ProgressBar1.Value = _Progress
    End Sub
    '''
    Private Sub OptSplit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptSplit.CheckedChanged
        If OptSplit.Checked Then
            chkOption.Text = "Delete Files After Split process"
            lblChunkSize.Visible = True
            txtChunkSize.Visible = True
        Else
            chkOption.Text = "Delete Files After Merge process"
            lblChunkSize.Visible = False
            txtChunkSize.Visible = False
        End If
    End Sub
    '''
    Private Sub OptMerge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptMerge.CheckedChanged
        If OptSplit.Checked Then
            chkOption.Text = "Delete Files After Split process"
            lblChunkSize.Visible = True
            txtChunkSize.Visible = True
        Else
            chkOption.Text = "Delete Files After Merge process"
            lblChunkSize.Visible = False
            txtChunkSize.Visible = False
        End If
    End Sub
    '''
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptSplit.Checked = True
        cmdCancel.Enabled = False
        chkOption.Text = "Delete Files After Split process"
    End Sub
    '''
    Private Sub ResetControls()
        Processing = False
        cmdCancel.Enabled = False
        GroupBox1.Enabled = True
        ProgressBar1.Visible = False
    End Sub
End Class

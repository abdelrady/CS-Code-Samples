Public Class MainFrm
    Structure File
        Dim FileName As String
        Dim FileBy() As Byte
    End Structure
    Structure Files
        Dim Files() As File
    End Structure
    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BrFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrFile.Click
        Dim a As New SaveFileDialog
        a.Filter = "MP3 Files (*.mp3)|*.mp3"
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveToFile.Text = a.FileName
        End If
    End Sub

    Private Sub AddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFile.Click
        Dim Open As New OpenFileDialog
        Open.Multiselect = True
        Open.Filter = "MP3 Files(*.mp3)|*.mp3"
        If Open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileName As String
            For Each FileName In Open.FileNames
                Dim i As Integer = -1
                i += 1
                Dim Im As Image = Icon.ExtractAssociatedIcon(FileName).ToBitmap
                img.Images.Add(i, Im)
                FileList.Items.Add(FileName, FileName, i)
            Next
        End If
    End Sub

    Private Sub RemoveFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFiles.Click
        Dim L As ListViewItem
        For Each L In FileList.SelectedItems
            L.Remove()
        Next
    End Sub

    Private Sub FileList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FileList.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim L As ListViewItem
            For Each L In FileList.SelectedItems
                L.Remove()
            Next
        End If
    End Sub
    Public Sub CreateFile(ByVal Data As Files, ByVal filename As String)
        Dim i As Int16 = FreeFile()
        FileOpen(1, filename, OpenMode.Binary, OpenAccess.ReadWrite)
        FilePut(i, Data)
        FileClose(1)
    End Sub

    Private Sub CompileBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompileBtn.Click
        If SaveToFile.Text = Nothing Then
            MsgBox("Please select file to write", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim Fil As New File
        Dim Arr(FileList.Items.Count) As File
        Dim i As Integer
        prog.Maximum = FileList.Items.Count
        Me.Text = "Reading..."
        For i = 1 To FileList.Items.Count
            Dim FilN As String = FileList.Items.Item(i - 1).Text
            Fil.FileName = IO.Path.GetFileName(FilN)
            Fil.FileBy = My.Computer.FileSystem.ReadAllBytes(FilN)
            Arr(i - 1) = Fil
            prog.Value = i
        Next
        Me.Text = "Compiling..."
        Dim Dat As New Files
        Dat.Files = Arr
        CreateFile(Dat, SaveToFile.Text)
        Me.Text = "MP3 Unite - Ready"
    End Sub
End Class
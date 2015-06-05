Attribute VB_Name = "ExplorerModule"
Option Explicit
Public CancelDownload As Boolean
Public CancelSend As Boolean

Sub SendFile(FilePath As String, Socket As Winsock)
Dim txtData As String, FileNumber As Integer
Dim Counter As Long, FileLength As Long
Dim SmallFile As Boolean

On Error GoTo LostConnection
    
    Counter = 0
    FileNumber = FreeFile()
    Open FilePath For Binary As #FileNumber
        ExplorerForm.Enabled = False
        FileLength = LOF(FileNumber)
        ProgressForm02.Caption = "Sending Progress..."
        ProgressForm02.FilePath.Caption = FilePath
        ProgressForm02.ProgressBar1.Max = FileLength
        ProgressForm02.Show
        
        txtData = String(512, " ")
        Get #FileNumber, 1, txtData
        Counter = Len(txtData)
        If FileLength > 512 Then
            SmallFile = False
        Else
            SmallFile = True
        End If
        Do While Counter <= FileLength
            ProgressForm02.ProgressBar1.Value = ProgressForm02.ProgressBar1.Value + 512
            ProgressForm02.ProgressLabel.Caption = Format(ProgressForm02.ProgressBar1.Value / FileLength, "###% Completed.")
            If CancelSend = True Then
                DoEvents
                Counter = FileLength + 1
            End If
            DoEvents
            Socket.SendData ("SendData#" & txtData)
            Sleep (5)
            txtData = String(512, " ")
            Get #FileNumber, Counter + 1, txtData
            If Counter + 512 > FileLength Then
                Dim tmplen As Long
                tmplen = FileLength - Counter
                If tmplen <= 0 Then
                    txtData = Chr(0)
                Else
                    txtData = (Mid(txtData, 1, tmplen))
                End If
                Exit Do
            End If
            Counter = Counter + 512
        Loop
        
    Close #FileNumber
    
    DoEvents
    If SmallFile = True Then
        Socket.SendData ("SendData#" & Mid(txtData, 1, FileLength))
    Else
        Socket.SendData ("SendData#" & txtData)
    End If
    Sleep (5)
    DoEvents
    Socket.SendData ("SendComplete#" & Chr(0))
    ProgressForm02.ProgressBar1.Value = FileLength
    ProgressForm02.ProgressLabel.Caption = "100% Completed."
    ExplorerForm.Enabled = True
    Unload ProgressForm02
    MsgBox "File successfuly send.", vbInformation
    Exit Sub
LostConnection:
    ExplorerForm.Enabled = True
End Sub

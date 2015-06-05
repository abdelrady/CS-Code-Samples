Attribute VB_Name = "TaskManagerModule"
Option Explicit

Sub AddinList(txtData As String)
Dim Str1 As String, Str2 As String
Dim Position As Long, LItem As ListItem
    
    TaskmanagerFrm.TaskListView.ListItems.Clear
    While Len(txtData) > 0
        Position = InStr(1, txtData, "=")
        Str1 = Left(txtData, Position - 1)
        txtData = Mid(txtData, Position + 1)
        Position = InStr(1, txtData, "#")
        Str2 = Left(txtData, Position - 1)
        txtData = Mid(txtData, Position + 1)
        Set LItem = TaskmanagerFrm.TaskListView.ListItems.Add(, , Str1, , 1)
        LItem.SubItems(1) = Str2
    Wend
End Sub

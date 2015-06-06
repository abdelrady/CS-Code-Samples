Attribute VB_Name = "modMain"
Option Explicit

Public Function TrimDir(strDir As String) As String
    'If no backslash, add one
    If (Right(strDir, 1) <> "\") Then
        strDir = strDir & "\"
    End If
    'Return new string
    TrimDir = strDir
End Function

Public Function TrimFile(strFileName As String, Optional blnKeepExt As Boolean) As String
    On Error Resume Next
    Dim intPos As Integer
    Dim strProcess As String, strHTTP As String
    
    ' Remove the path and the file extension
    strProcess = strFileName
    If (LCase(Mid(strProcess, 1, 4)) = "http") Then
        TrimFile = strProcess
        Exit Function
    End If
    
    'Get the position of the backslash
    intPos = InStrRev(strProcess, "\")
    strProcess = Mid(strProcess, intPos + 1)
    If (blnKeepExt = False) Then
    
        'Get the position of the period
        intPos = InStrRev(strProcess, ".")
        strProcess = Mid(strProcess, 1, intPos - 1)
    End If
    
    'Replace quotes with underscores
    strProcess = Replace(strProcess, Chr$(34), "_", 1, Len(strProcess))
    TrimFile = strProcess
End Function

Public Sub SaveList(strFile As String)
    Dim intX As Integer
    On Error Resume Next
    
    'Open a file for writing
    Open strFile For Output As #1
        
        'loop through all list items
        For intX = 1 To frmConfig.lsvScan.ListItems.Count
            Write #1, frmConfig.lsvScan.ListItems.Item(intX).ListSubItems(2).Text
            Write #1, frmConfig.lsvScan.ListItems.Item(intX).ListSubItems(1).Text
            
        Next intX
    Close
End Sub

Public Sub LoadList(strFile As String)
    Dim intX As Integer
    Dim strPath As String, strCode As String
    On Error Resume Next
    
    'Open a file for writing
    Open strFile For Input As #1
        
        'loop through all list items
        Do
            Input #1, strPath
            Input #1, strCode
            
            frmConfig.lsvScan.ListItems.Add , , TrimFile(strPath)
            frmConfig.lsvScan.ListItems.Item(frmConfig.lsvScan.ListItems.Count).ListSubItems.Add , , strCode
            frmConfig.lsvScan.ListItems.Item(frmConfig.lsvScan.ListItems.Count).ListSubItems.Add , , strPath
        Loop Until EOF(1)
    Close
End Sub


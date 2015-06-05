Attribute VB_Name = "m188"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com




Option Explicit

Public Function myChDir(sPath As String) As Boolean
On Error GoTo err1
    
    If sPath = "" Then
        myChDir = False
        Exit Function
    End If
    
    If (Mid(sPath, 2, 1) = ":") Then
        ChDrive (Mid(sPath, 1, 1)) 'ChDir won't work if curent path is another drive.
    End If
    
    ChDir (sPath)
    
    myChDir = True
    
Exit Function
err1:
Debug.Print "Error (expected?) on myChDir(" & sPath & "): " & Err.Description
myChDir = False
Resume Next
End Function

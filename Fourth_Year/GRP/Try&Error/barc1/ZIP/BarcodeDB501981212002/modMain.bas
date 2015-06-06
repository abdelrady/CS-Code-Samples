Attribute VB_Name = "modMain"
Option Explicit
Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

Public CancelSearch As Boolean
Public AppPath As String
Public Const AppName As String * 9 = "BarcodeDB"
Public Const alpha As String = "abcdefghijklmnopqrstuvwxyz "

Sub Main()
    AppPath = App.Path
    
    If Not Right$(AppPath, 1) = "\" Then
        AppPath = AppPath & "\"
    End If
    
    Load frmMain
    frmMain.Show
End Sub

Function GenRegKey(uName As String) As String
    On Error GoTo GenRegKeyError
    Dim i As Long
    Dim j As Long
    Dim KeysPerChar As Byte
    Dim Key As String
    Dim CurChar As Integer
    
    uName = Trim$(uName)
    Key = ""
    
    If Len(uName) < 4 Then
        GenRegKey = "-10"
        Exit Function
    End If
    
    If Len(uName) > 25 Then
        GenRegKey = "-10"
        Exit Function
    End If
    
    KeysPerChar = Int(75 / Len(uName))
        
    For i = 1 To Len(uName)
        CurChar = Asc(Mid$(uName, i, 1))
        If InStr(1, alpha, LCase$(Chr$(CurChar))) = 0 Then
            GenRegKey = "-10"
            Exit Function
        End If
        
        For j = 1 To KeysPerChar
            Key = Key & Chr(CurChar Xor (j + 10))
            Key = Key & Chr(CurChar Xor j)
        Next
    Next
    
    GenRegKey = Key
    
Exit Function
GenRegKeyError:
GenRegKey = "-10"
End Function

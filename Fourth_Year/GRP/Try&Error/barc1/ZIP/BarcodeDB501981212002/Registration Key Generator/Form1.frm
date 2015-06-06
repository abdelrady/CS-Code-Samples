VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form1"
   ClientHeight    =   4215
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6015
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4215
   ScaleWidth      =   6015
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "&Generate"
      Height          =   855
      Left            =   4200
      TabIndex        =   2
      Top             =   360
      Width           =   1455
   End
   Begin VB.TextBox Text2 
      Height          =   2415
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   1
      Top             =   720
      Width           =   3495
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Text            =   "Enter registration name"
      Top             =   240
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const alpha As String = "abcdefghijklmnopqrstuvwxyz "

Private Sub Command1_Click()
    Text2 = GenRegKey(Text1)
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
        MsgBox "must be more than 3 characters"
        Exit Function
    End If
    
    If Len(uName) > 25 Then
        MsgBox "must be less than 25 characters"
        Exit Function
    End If
    
    KeysPerChar = Int(75 / Len(uName))
        
    For i = 1 To Len(uName)
        CurChar = Asc(Mid$(uName, i, 1))
        If InStr(1, alpha, LCase$(Chr$(CurChar))) = 0 Then
            MsgBox "Invalid character in key field. the field must not contain digits or any other irregular characters or symbols."
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
GenRegKey = Err.Description

End Function


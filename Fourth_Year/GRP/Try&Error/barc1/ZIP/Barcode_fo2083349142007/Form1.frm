VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Barcode Maker"
   ClientHeight    =   2355
   ClientLeft      =   60
   ClientTop       =   375
   ClientWidth     =   7530
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   2355
   ScaleWidth      =   7530
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Copy to clipboard"
      Height          =   375
      Left            =   4680
      TabIndex        =   1
      Top             =   720
      Width           =   1455
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   6015
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   1000
      Left            =   120
      ScaleHeight     =   63
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   477
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   1200
      Width           =   7215
   End
   Begin VB.Label Label1 
      Caption         =   "Barcode Data:"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Dim BCtype As Long


Private Sub makeBC()
            makei25
End Sub

Private Sub makei25()
Dim x As Long, y As Long, pos As Long
Dim Bardata As String
Dim Cur As String
Dim temp As String
Dim chksum As Long
Dim BC(11) As String
    '2 of the 5 elements are wide: 0=narrow, 1=wide
    BC(0) = "00110" '0
    BC(1) = "10001" '1
    BC(2) = "01001" '2
    BC(3) = "11000" '3
    BC(4) = "00101" '4
    BC(5) = "10100" '5
    BC(6) = "01100" '6
    BC(7) = "00011" '7
    BC(8) = "10010" '8
    BC(9) = "01010" '9
    BC(10) = "0000" 'Start chr
    BC(11) = "100" 'Stop chr
    
    Picture1.Cls
    If Text1.Text = "" Then Exit Sub
    pos = 20
    Bardata = Text1.Text
       
    'Check for invalid characters and calculate check sum
    For x = 1 To Len(Bardata)
        Cur = Mid$(Bardata, x, 1)
        If Cur < "0" Or Cur > "9" Then
            Picture1.Print Cur & " is Invalid"
            Exit Sub
        End If
        'make checksum
        If x Mod 2 Then
            chksum = chksum + CLng(Cur) * 3
        Else
            chksum = chksum + CLng(Cur)
        End If
    Next
    
    
    'interleave the code into a temp string - what'd you think the name meant?
    For x = 1 To Len(Bardata) Step 2
        For y = 1 To 5
            temp = temp & Mid$(BC(Val(Mid$(Bardata, x, 1))), y, 1)
            temp = temp & Mid$(BC(Val(Mid$(Bardata, x + 1, 1))), y, 1)
        Next
    Next
    
    'add Start & Stop characters
    temp = BC(10) & temp & BC(11)
    
    'Generate Barcode
    For x = 1 To Len(temp)
        If x Mod 2 = 0 Then
                'SPACE
                pos = pos + 1 + (2 * Val(Mid$(temp, x, 1)))
        Else
                'BAR
                For y = 1 To 1 + (2 * Val(Mid$(temp, x, 1)))
                    Picture1.Line (pos, 1)-(pos, 58)
                    pos = pos + 1
                Next
        End If
    Next


End Sub


Private Sub makeCodabar()
Dim x As Long, y As Long, pos As Long
Dim Bardata As String
Dim Cur As String
Dim CurVal As Long
Dim temp As String
Dim BC(19) As String
    'Codabar, also known as NW-7
    BC(0) = "0000011" '0
    BC(1) = "0000110" '1
    BC(2) = "0001001" '2
    BC(3) = "1100000" '3
    BC(4) = "0010010" '4
    BC(5) = "1000010" '5
    BC(6) = "0100001" '6
    BC(7) = "0100100" '7
    BC(8) = "0110000" '8
    BC(9) = "1001000" '9
    BC(10) = "0001100" '-
    BC(11) = "0011000" '$
    BC(12) = "1000101" ':
    BC(13) = "1010001" '/
    BC(14) = "1010100" '.
    BC(15) = "0010101" '+
    BC(16) = "0011010" 'start/stop A
    BC(17) = "0101001" 'start/stop B
    BC(18) = "0001011" 'start/stop C
    BC(19) = "0001110" 'start/stop D
    
    Picture1.Cls
    If Text1.Text = "" Then Exit Sub
    pos = 20
    Bardata = Text1.Text

    For x = 1 To Len(Bardata)
        Cur = Mid$(Bardata, x, 1)
        Select Case Cur
            Case "0" To "9"
                CurVal = Val(Cur)
            Case "a" To "d"
                CurVal = Asc(Cur) - 81
            Case "-"
                CurVal = 10
            Case "$"
                CurVal = 11
            Case ":"
                CurVal = 12
            Case "/"
                CurVal = 13
            Case "."
                CurVal = 14
            Case "+"
                CurVal = 15
            Case Else 'oops!
                Picture1.Print Cur & " is Invalid"
                Exit Sub
        End Select
        temp = temp & BC(CurVal) & "0" '"0"= add intercharactor gap (1 narrow space)
    Next

    'Add Start & Stop characters (using "A" for both here)
    temp = BC(16) & "0" & temp & BC(16)
    
    'Generate Barcode
    For x = 1 To Len(temp)
        If x Mod 2 = 0 Then
            'SPACE
            pos = pos + 1 + (2 * Val(Mid$(temp, x, 1))) + Check1(0).Value
        Else
            'BAR
            For y = 1 To 1 + (2 * Val(Mid$(temp, x, 1)))
                Picture1.Line (pos, 1)-(pos, 58 - Check1(1) * 8)
                pos = pos + 1
            Next
        End If
    Next

    'Add Label?
    If Check1(1).Value Then
        Picture1.CurrentX = 30 + Len(Bardata) * (3 + Check1(0).Value * 2) 'kinda center
        Picture1.CurrentY = 50
        Picture1.Print Bardata;
    End If
End Sub


Private Sub Form_Resize()
    Picture1.Width = Form1.Width - 360
    makeBC
End Sub


Private Sub Text1_Change()
    makeBC
End Sub


Private Sub Check1_Click(Index As Integer)
    makeBC
End Sub


Private Sub Command1_Click()
    Clipboard.Clear
    Clipboard.SetData Picture1.Image
End Sub

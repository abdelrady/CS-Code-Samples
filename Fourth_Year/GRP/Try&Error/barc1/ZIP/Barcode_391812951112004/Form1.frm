VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Barcode 3 of 9"
   ClientHeight    =   2700
   ClientLeft      =   60
   ClientTop       =   375
   ClientWidth     =   6375
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   2700
   ScaleWidth      =   6375
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Settings"
      Height          =   1335
      Index           =   0
      Left            =   3600
      TabIndex        =   3
      Top             =   120
      Width           =   2655
      Begin VB.CheckBox Check1 
         Caption         =   "Add Label"
         Height          =   195
         Index           =   1
         Left            =   120
         TabIndex        =   7
         ToolTipText     =   "Human readable"
         Top             =   600
         Value           =   1  'Checked
         Width           =   2415
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Add Check Character"
         Height          =   195
         Index           =   2
         Left            =   120
         TabIndex        =   6
         ToolTipText     =   "Not commonly used"
         Top             =   840
         Width           =   2415
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Optimize for Printing"
         Height          =   195
         Index           =   0
         Left            =   120
         TabIndex        =   4
         ToolTipText     =   "Increases spacing"
         Top             =   360
         Value           =   1  'Checked
         Width           =   2415
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Copy to clipboard"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   1080
      Width           =   1455
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   2415
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   1000
      Left            =   120
      ScaleHeight     =   63
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   405
      TabIndex        =   5
      Top             =   1560
      Width           =   6135
   End
   Begin VB.Label Label1 
      Caption         =   "Barcode Data:"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'''''''''''''''''''''''''''''''''''''''''''''
'' BARCODE 3 OF 9 GENERATOR                ''
'' By Paul Bahlawan Aug 2003               ''
''                                         ''
'' Update Oct 2004:                        ''
'' -Add "Check Character" option           ''
'' -Add "Optimize for Printing" option     ''
'' -Add "Copy to clipboard" command        ''
'' -Various minor changes                  ''
''                                         ''
'' Based on specs from:                    ''
'' www.adams1.com/pub/russadam/39code.html ''
'''''''''''''''''''''''''''''''''''''''''''''
Option Explicit

Private Sub makeBC()
Dim X As Integer, Y As Integer, z As Integer, pos As Integer
Dim Bardata As String
Dim Cur As String
Dim CurVal As Long
Dim chksum As Long
Dim chkchr As String
Dim BC(43) As String
    '3 of the 9 bars are wide: 0=narrow, 1=wide
    BC(0) = "000110100" '0
    BC(1) = "100100001" '1
    BC(2) = "001100001" '2
    BC(3) = "101100000" '3
    BC(4) = "000110001" '4
    BC(5) = "100110000" '5
    BC(6) = "001110000" '6
    BC(7) = "000100101" '7
    BC(8) = "100100100" '8
    BC(9) = "001100100" '9
    BC(10) = "100001001" 'A
    BC(11) = "001001001" 'B
    BC(12) = "101001000" 'C
    BC(13) = "000011001" 'D
    BC(14) = "100011000" 'E
    BC(15) = "001011000" 'F
    BC(16) = "000001101" 'G
    BC(17) = "100001100" 'H
    BC(18) = "001001100" 'I
    BC(19) = "000011100" 'J
    BC(20) = "100000011" 'K
    BC(21) = "001000011" 'L
    BC(22) = "101000010" 'M
    BC(23) = "000010011" 'N
    BC(24) = "100010010" 'O
    BC(25) = "001010010" 'P
    BC(26) = "000000111" 'Q
    BC(27) = "100000110" 'R
    BC(28) = "001000110" 'S
    BC(29) = "000010110" 'T
    BC(30) = "110000001" 'U
    BC(31) = "011000001" 'V
    BC(32) = "111000000" 'W
    BC(33) = "010010001" 'X
    BC(34) = "110010000" 'Y
    BC(35) = "011010000" 'Z
    BC(36) = "010000101" '-
    BC(37) = "110000100" '.
    BC(38) = "011000100" '<spc>
    BC(39) = "010101000" '$
    BC(40) = "010100010" '/
    BC(41) = "010001010" '+
    BC(42) = "000101010" '%
    BC(43) = "010010100" '*  (used for start/stop character only)
    
Picture1.Cls
If Text1.Text = "" Then Exit Sub
pos = 20
Bardata = UCase(Text1.Text)

'Check for invalid characters and calculate check sum
For X = 1 To Len(Bardata)
    Cur = Mid$(Bardata, X, 1)
    Select Case Cur
        Case "0" To "9"
            CurVal = Val(Cur)
        Case "A" To "Z"
            CurVal = Asc(Cur) - 55
        Case "-"
            CurVal = 36
        Case "."
            CurVal = 37
        Case " "
            CurVal = 38
        Case "$"
            CurVal = 39
        Case "/"
            CurVal = 40
        Case "+"
            CurVal = 41
        Case "%"
            CurVal = 42
        Case Else 'oops!
            Picture1.Cls
            Picture1.Print Cur & " is Invalid"
            Exit Sub
    End Select
    chksum = chksum + CurVal
Next

'Add Label? (add it now so start & stop chrs dont show)
If Check1(1).Value Then
    Picture1.CurrentX = 35 + Len(Bardata) * (5 + Check1(0).Value * 2) 'kinda center
    Picture1.CurrentY = 50
    Picture1.Print Bardata;
End If

'Add Check Character? (rarely used, but i put it here anyway...)
If Check1(2).Value Then
    chksum = chksum Mod 43
    chkchr = Mid$("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*", chksum + 1, 1)
    Picture1.Print "_" & chkchr
    Bardata = Bardata & chkchr
End If

'Add Start & Stop characters (must have 'em for valid barcodes)
Bardata = "*" & Bardata & "*"

'Generate Barcode
For X = 1 To Len(Bardata)
    Cur = Mid$(Bardata, X, 1)
    Select Case Cur
        Case "0" To "9"
            CurVal = Val(Cur)
        Case "A" To "Z"
            CurVal = Asc(Cur) - 55
        Case "-"
            CurVal = 36
        Case "."
            CurVal = 37
        Case " "
            CurVal = 38
        Case "$"
            CurVal = 39
        Case "/"
            CurVal = 40
        Case "+"
            CurVal = 41
        Case "%"
            CurVal = 42
        Case "*"
            CurVal = 43
    End Select
    
    For Y = 1 To 9
        If Y Mod 2 = 0 Then
            'SPACE
            pos = pos + 1 + (2 * Val(Mid$(BC(CurVal), Y, 1))) + Check1(0).Value
        Else
            'BAR
            For z = 1 To 1 + (2 * Val(Mid$(BC(CurVal), Y, 1)))
                Picture1.Line (pos, 1)-(pos, 58 - Check1(1) * 8)
                pos = pos + 1
            Next z
        End If
    Next
    pos = pos + 1 + Check1(0).Value 'make inter-character gap (ie: 1 narrow space)
Next
End Sub

Private Sub Form_Resize()
Picture1.Width = Form1.Width - 360
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


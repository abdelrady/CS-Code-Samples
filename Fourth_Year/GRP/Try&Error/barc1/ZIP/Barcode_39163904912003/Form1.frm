VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Barcode 3 of 9"
   ClientHeight    =   2715
   ClientLeft      =   60
   ClientTop       =   375
   ClientWidth     =   5205
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   2715
   ScaleWidth      =   5205
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Settings"
      Height          =   1335
      Left            =   2640
      TabIndex        =   3
      Top             =   0
      Width           =   2415
      Begin VB.CheckBox Check3 
         Caption         =   "Check1"
         Enabled         =   0   'False
         Height          =   195
         Left            =   120
         TabIndex        =   8
         Top             =   840
         Width           =   255
      End
      Begin VB.CheckBox Check2 
         Caption         =   "Check1"
         Height          =   195
         Left            =   120
         TabIndex        =   7
         Top             =   600
         Value           =   1  'Checked
         Width           =   255
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Check1"
         Height          =   195
         Left            =   120
         TabIndex        =   5
         Top             =   360
         Value           =   1  'Checked
         Width           =   255
      End
      Begin VB.Label Label4 
         Caption         =   "Add Check Sum"
         Height          =   255
         Left            =   480
         TabIndex        =   9
         Top             =   840
         Width           =   1695
      End
      Begin VB.Label Label3 
         Caption         =   "Add Label"
         Height          =   255
         Left            =   480
         TabIndex        =   6
         Top             =   600
         Width           =   1695
      End
      Begin VB.Label Label2 
         Caption         =   "Add S/S Characters"
         Height          =   255
         Left            =   480
         TabIndex        =   4
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Make"
      Height          =   495
      Left            =   360
      TabIndex        =   1
      Top             =   840
      Width           =   1815
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
      Height          =   975
      Left            =   120
      ScaleHeight     =   61
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   325
      TabIndex        =   10
      Top             =   1560
      Width           =   4935
   End
   Begin VB.Label Label1 
      Caption         =   "Barcode:"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'''''''''''''''''''''''''''''''''''''''''''''
'' BARCODE 3 OF 9 GENERATOR (experimental) ''
'' By Paul Bahlawan Aug 2003               ''
'''''''''''''''''''''''''''''''''''''''''''''
Option Explicit

Private Sub Command1_Click()
Dim x As Integer, y As Integer, z As Integer, pos As Integer
Dim Barcode As String
Dim Cur As String
Dim CurVal As Integer
Dim BC(43) As String

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
    BC(16) = "000001101"
    BC(17) = "100001100"
    BC(18) = "001001100"
    BC(19) = "000011100"
    BC(20) = "100000011"
    BC(21) = "001000011"
    BC(22) = "101000010"
    BC(23) = "000010011"
    BC(24) = "100010010"
    BC(25) = "001010010"
    BC(26) = "000000111"
    BC(27) = "100000110"
    BC(28) = "001000110"
    BC(29) = "000010110"
    BC(30) = "110000001"
    BC(31) = "011000001"
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
pos = 10
Barcode = UCase(Text1.Text)

'Add Start & Stop characters?
If Check1.Value Then Barcode = "*" & Barcode & "*"

'Generate Barcode
For x = 1 To Len(Barcode)
    Cur = Mid$(Barcode, x, 1)
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
    Case Else 'oops!
        Picture1.Cls
        Picture1.Print Cur & " is Invalid"
        Exit Sub
    End Select
    
    For y = 1 To 9
        If y / 2 = Int(y / 2) Then
            'SPACE
            pos = pos + 1 + (3 * Val(Mid$(BC(CurVal), y, 1)))
        Else
            'BAR
            For z = 1 To 1 + (3 * Val(Mid$(BC(CurVal), y, 1)))
                Picture1.Line (pos, 1)-(pos, 50)
                pos = pos + 1
            Next z
        End If
    Next y
    pos = pos + 1 'make inter-character gap (ie: 1 narrow space)
Next x

'Add Label?
If Check2.Value Then
    Picture1.CurrentX = Len(Barcode) * 7 'kinda center
    Picture1.Print Barcode
End If
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Command1_Click
End Sub

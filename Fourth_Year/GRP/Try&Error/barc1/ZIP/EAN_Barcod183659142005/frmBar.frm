VERSION 5.00
Begin VB.Form frmBar 
   Appearance      =   0  'Flat
   BackColor       =   &H8000000A&
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "EAN Barcoder "
   ClientHeight    =   3135
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   2400
   Icon            =   "frmBar.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3135
   ScaleMode       =   0  'User
   ScaleWidth      =   2400
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command4 
      Caption         =   "Copy"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1245
      TabIndex        =   7
      Top             =   750
      Width           =   1050
   End
   Begin VB.CommandButton Command3 
      Caption         =   "New"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   1080
      Width           =   1050
   End
   Begin VB.TextBox Text1 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H80000008&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FF00&
      Height          =   285
      Left            =   120
      MaxLength       =   13
      TabIndex        =   5
      Text            =   "4009993099417"
      Top             =   360
      Width           =   2175
   End
   Begin VB.CommandButton Command2 
      Caption         =   "About"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1245
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1080
      Width           =   1050
   End
   Begin VB.PictureBox Picture1 
      Align           =   2  'Align Bottom
      BackColor       =   &H00FFFFFF&
      Height          =   1695
      Left            =   0
      ScaleHeight     =   1635
      ScaleWidth      =   2340
      TabIndex        =   2
      Top             =   1440
      Width           =   2400
      Begin VB.PictureBox Picture2 
         Appearance      =   0  'Flat
         AutoRedraw      =   -1  'True
         BackColor       =   &H80000005&
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   1435
         Left            =   230
         ScaleHeight     =   1440
         ScaleWidth      =   1905
         TabIndex        =   3
         Top             =   90
         Width           =   1900
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Create"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   750
      Width           =   1050
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H80000009&
      Height          =   310
      Left            =   100
      Top             =   340
      Width           =   2200
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Barcode No."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2175
   End
   Begin VB.Menu mnuFile 
      Caption         =   "File"
      Visible         =   0   'False
      Begin VB.Menu mnuClip 
         Caption         =   "Copy to Clipboard"
      End
   End
End
Attribute VB_Name = "frmBar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
Dim Pos As Long
Dim tempEven As Long
Dim tempOdd As Long
Dim tempTotal As Long
Dim Total As Long
Dim Pattern As String
Dim PatternNo As Integer
Dim ProductNo As String
Dim ProductName As String

If Len(Text1) < 13 Then
    MsgBox "It must be 13 digit!"
    Exit Sub
Else
    For Pos = 2 To 12 Step 2
        tempEven = tempEven + Val(Mid(Text1, Pos, 1))
    Next

    For Pos = 1 To 11 Step 2
        tempOdd = tempOdd + Val(Mid(Text1, Pos, 1))
    Next

    tempEven = tempEven * 3
    tempTotal = tempOdd + tempEven
    Total = tempTotal Mod 10
    
    If Total > 0 Then
        Total = 10 - Total
    End If
    
    If Total <> Mid(Text1, 13, 1) Then
    MsgBox "Invalid number"
    Exit Sub
    End If

    Picture2.Left = Picture1.Width / 3 - 100
    Call Barcoder(Text1, Picture2)
End If
End Sub

Private Sub Command2_Click()
frmAbout.Show vbModal
End Sub

Private Sub Command3_Click()
Dim tempEven As Long
Dim tempOdd As Long
Dim tempTotal
Dim newBarCode As String
Dim Checksum As Integer
Randomize

newBarCode = Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10) & Int(Rnd * 10)
    For Pos = 2 To 12 Step 2
        tempEven = tempEven + Val(Mid(newBarCode, Pos, 1))
    Next

    For Pos = 1 To 11 Step 2
        tempOdd = tempOdd + Val(Mid(newBarCode, Pos, 1))
    Next

    tempEven = tempEven * 3
    tempTotal = tempOdd + tempEven
    Checksum = tempTotal Mod 10
    
    If Checksum > 0 Then
        Checksum = 10 - Checksum
    End If
    
    newBarCode = newBarCode & Checksum
    If Checksum <> Mid(newBarCode, 13, 1) Then
    MsgBox "Invalid number"
    Exit Sub
    End If
    
    Text1 = newBarCode
    Picture2.Left = Picture1.Width / 3 - 100
    Call Barcoder(newBarCode, Picture2)
End Sub

Private Sub Command4_Click()
Clipboard.Clear
Clipboard.SetData Picture2.Image
MsgBox "Barcode successfully copied!"
End Sub

Private Sub Form_GotFocus()
Command1_Click
End Sub

Private Sub Form_Load()
Text1_Change
Command1_Click
End Sub

Private Sub mnuClip_Click()
Clipboard.Clear
Clipboard.SetData Picture2.Image
MsgBox "Barcode successfully copied!"
End Sub

Private Sub Picture2_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
If Button = vbRightButton Then
PopupMenu mnuFile
End If
End Sub

Private Sub Text1_Change()
If IsNumeric(Text1) = False Then
SendKeys "{BACKSPACE}"
Exit Sub
Else

If Len(Text1) = 13 Then
Command1.Enabled = True
ElseIf Text1 < "" Then
Command1.Enabled = False
Else
Command1.Enabled = False
End If
Text1.Refresh
End If
End Sub

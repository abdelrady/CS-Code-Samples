VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFFFC0&
   Caption         =   "Form1"
   ClientHeight    =   4200
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5430
   LinkTopic       =   "Form1"
   ScaleHeight     =   4200
   ScaleWidth      =   5430
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command17 
      Caption         =   "E&XIT"
      Height          =   495
      Left            =   2040
      TabIndex        =   17
      Top             =   3600
      Width           =   1815
   End
   Begin VB.CommandButton Command16 
      Caption         =   "CE"
      Height          =   495
      Left            =   4080
      TabIndex        =   16
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton Command15 
      Caption         =   "="
      Height          =   495
      Left            =   1440
      TabIndex        =   15
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton Command14 
      BackColor       =   &H00FFFF00&
      Caption         =   "9"
      Height          =   495
      Left            =   120
      TabIndex        =   14
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton Command13 
      BackColor       =   &H00FFFF00&
      Caption         =   "8"
      Height          =   495
      Left            =   2760
      TabIndex        =   13
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton Command12 
      BackColor       =   &H00FFFF00&
      Caption         =   "7"
      Height          =   495
      Left            =   1440
      TabIndex        =   12
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton Command11 
      BackColor       =   &H00FFFF00&
      Caption         =   "6"
      Height          =   495
      Left            =   120
      TabIndex        =   11
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton Command10 
      Caption         =   "*"
      Height          =   495
      Left            =   4080
      TabIndex        =   10
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton Command9 
      BackColor       =   &H00FFFF00&
      Caption         =   "5"
      Height          =   495
      Left            =   2760
      TabIndex        =   9
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CommandButton Command8 
      BackColor       =   &H00FFFF00&
      Caption         =   "4"
      Height          =   495
      Left            =   1440
      TabIndex        =   8
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CommandButton Command7 
      BackColor       =   &H00FFFF00&
      Caption         =   "3"
      Height          =   495
      Left            =   120
      TabIndex        =   7
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "-"
      Height          =   495
      Left            =   4080
      TabIndex        =   6
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton Command5 
      BackColor       =   &H00FFFF00&
      Caption         =   "2"
      Height          =   495
      Left            =   2760
      TabIndex        =   5
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      BackColor       =   &H00FFFF00&
      Caption         =   "1"
      Height          =   495
      Left            =   1440
      TabIndex        =   4
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00FFFF00&
      Caption         =   "0"
      Height          =   495
      Left            =   120
      TabIndex        =   3
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "+"
      Height          =   495
      Left            =   4080
      TabIndex        =   2
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "/"
      Height          =   495
      Left            =   2760
      TabIndex        =   1
      Top             =   2880
      Width           =   1215
   End
   Begin VB.TextBox Text1 
      BackColor       =   &H0000FF00&
      Height          =   495
      Left            =   960
      TabIndex        =   0
      Top             =   240
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim var1 As Integer, var2 As Integer
Dim operand As Integer, equal As Integer
'equal = 0

Private Sub Command1_Click()
If (operand <> 4) Then
operand = 4
var1 = Val(Text1.Text)
Text1.Text = ""
End If
End Sub

Private Sub Command10_Click()
If (operand <> 3) Then
operand = 3
var1 = Val(Text1.Text)
Text1.Text = ""
End If
End Sub

Private Sub Command11_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command11.Caption
End Sub

Private Sub Command12_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command12.Caption
End Sub

Private Sub Command13_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command13.Caption
End Sub

Private Sub Command14_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command14.Caption
End Sub

Private Sub Command15_Click()
var2 = Val(Text1.Text)

'Text1.Text = var1
If (operand = 1) Then Text1.Text = var1 + var2
If (operand = 2) Then Text1.Text = var1 - var2
If (operand = 3) Then Text1.Text = var1 * var2
If (operand = 4) Then Text1.Text = var1 / var2
var1 = Val(Text1.Text)
operand = 0
equal = 1
End Sub

Private Sub Command16_Click()
Text1.Text = ""
End Sub

Private Sub Command17_Click()
End
End Sub

Private Sub Command2_Click()
If (operand <> 1) Then
operand = 1
var1 = Val(Text1.Text)
Text1.Text = ""
End If
End Sub

Private Sub Command3_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command3.Caption
End Sub

Private Sub Command4_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command4.Caption
End Sub

Private Sub Command5_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command5.Caption
End Sub

Private Sub Command6_Click()
If (operand <> 2) Then
operand = 2
var1 = Val(Text1.Text)
Text1.Text = ""
End If
End Sub

Private Sub Command7_Click()
If (equal) Then Text1.Text = "": equal = 0
Text1.Text = Text1.Text + Command7.Caption
End Sub

Private Sub Command8_Click()
If (equal) Then Text1.Text = ""
Text1.Text = Text1.Text + Command8.Caption
End Sub

Private Sub Command9_Click()
If (equal) Then Text1.Text = ""
Text1.Text = Text1.Text + Command9.Caption
End Sub

Private Sub Form_Load()
equal = 0: var1 = 0: var2 = 0
End Sub

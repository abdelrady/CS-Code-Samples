VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5280
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4755
   LinkTopic       =   "Form1"
   ScaleHeight     =   5280
   ScaleWidth      =   4755
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "Command3"
      Height          =   375
      Left            =   960
      TabIndex        =   8
      Top             =   4560
      Width           =   975
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      ItemData        =   "Form1.frx":0000
      Left            =   2640
      List            =   "Form1.frx":0010
      Style           =   2  'Dropdown List
      TabIndex        =   5
      Top             =   360
      Width           =   2055
   End
   Begin VB.Frame Frame1 
      Caption         =   "PREVIEW"
      Height          =   2055
      Left            =   120
      TabIndex        =   3
      Top             =   1320
      Width           =   4575
      Begin VB.PictureBox Picture1 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         ClipControls    =   0   'False
         Height          =   735
         Left            =   120
         ScaleHeight     =   49
         ScaleMode       =   3  'Pixel
         ScaleWidth      =   93
         TabIndex        =   4
         Top             =   360
         Width           =   1392
      End
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Text            =   "750103131130"
      Top             =   360
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Generate"
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   840
      Width           =   4455
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Copy To Clipboard"
      Height          =   375
      Left            =   2640
      TabIndex        =   0
      Top             =   3480
      Width           =   2055
   End
   Begin VB.Label Label1 
      Caption         =   "TYPE"
      Height          =   255
      Index           =   1
      Left            =   2640
      TabIndex        =   7
      Top             =   120
      Width           =   2055
   End
   Begin VB.Label Label1 
      Caption         =   "TEXT"
      Height          =   255
      Index           =   0
      Left            =   240
      TabIndex        =   6
      Top             =   120
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cl As New arisBarcode
Dim xArr As New XArrayDB
Private Sub Command1_Click()
    Select Case Combo1.ListIndex
    Case 0
         cl.Code128 Picture1, 6, Text1, True
    Case 1
         cl.Code39 Picture1, 6, Text1, True
    Case 2
         cl.EAN13 Picture1, 6, Text1, True
    Case 3
         cl.EAN8 Picture1, 6, Text1, True
    End Select
End Sub

Private Sub Command2_Click()
    Clipboard.Clear
    Clipboard.SetData Picture1.Image, 2
End Sub



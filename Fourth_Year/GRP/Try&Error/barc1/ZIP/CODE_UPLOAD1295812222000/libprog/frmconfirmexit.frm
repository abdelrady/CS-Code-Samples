VERSION 5.00
Begin VB.Form frmExit 
   Appearance      =   0  'Flat
   BackColor       =   &H80000005&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   1680
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   5670
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1680
   ScaleWidth      =   5670
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdNo 
      Caption         =   "No"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2760
      TabIndex        =   2
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton cmdYes 
      Caption         =   "Yes"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1560
      TabIndex        =   1
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Are you sure you want to exit?"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   0
      TabIndex        =   0
      Top             =   120
      Width           =   6975
   End
   Begin VB.Image Image1 
      Height          =   1515
      Left            =   120
      Picture         =   "frmconfirmexit.frx":0000
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1500
   End
End
Attribute VB_Name = "frmExit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdNo_Click()
Me.Hide
End Sub

Private Sub cmdYes_Click()
End
End Sub


VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   3165
   ClientLeft      =   6000
   ClientTop       =   4230
   ClientWidth     =   5565
   FillColor       =   &H00FFFFFF&
   ForeColor       =   &H00000000&
   LinkTopic       =   "Form1"
   ScaleHeight     =   3165
   ScaleWidth      =   5565
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   4680
      Top             =   1680
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   240
      Left            =   2160
      TabIndex        =   0
      Top             =   2520
      Width           =   75
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H000000FF&
      BorderWidth     =   25
      Height          =   3135
      Left            =   0
      Top             =   0
      Width           =   5535
   End
   Begin VB.Image Image1 
      Height          =   2250
      Left            =   360
      Picture         =   "frmSplash.frx":0000
      Top             =   480
      Width           =   4815
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
Label1.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision & " by caver dave"
Timer1.Enabled = True
Timer1.Interval = 2500
End Sub

Private Sub Timer1_Timer()
If Timer1.Interval = 2500 Then
Timer1.Enabled = False
Unload Me
frm39Barcode.Show
End If
End Sub

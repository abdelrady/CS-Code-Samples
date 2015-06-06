VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   4575
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   4575
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdISBN 
      Caption         =   "Is ISBN"
      Height          =   495
      Left            =   240
      TabIndex        =   3
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton cbTrans 
      Caption         =   "Translate"
      Default         =   -1  'True
      Height          =   495
      Left            =   3120
      TabIndex        =   2
      Top             =   960
      Width           =   1215
   End
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   4215
   End
   Begin VB.Label Label2 
      Caption         =   "Label2"
      Height          =   495
      Left            =   1680
      TabIndex        =   4
      Top             =   2280
      Width           =   1815
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   1320
      Width           =   4215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cbTrans_Click()
Label1.Caption = CueCatDecode(Text1.Text, 3)
End Sub

Private Sub cmdISBN_Click()
Label2.Caption = BarCodeType(Text1.Text)
End Sub

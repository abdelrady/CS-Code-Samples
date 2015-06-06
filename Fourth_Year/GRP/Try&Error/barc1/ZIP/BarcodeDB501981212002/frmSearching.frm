VERSION 5.00
Begin VB.Form frmSearching 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Searching"
   ClientHeight    =   1260
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   4890
   Icon            =   "frmSearching.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1260
   ScaleWidth      =   4890
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Default         =   -1  'True
      Height          =   375
      Left            =   1680
      TabIndex        =   1
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label lblSearcing 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Please wait while searching."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   0
      TabIndex        =   0
      Top             =   240
      Width           =   4755
   End
End
Attribute VB_Name = "frmSearching"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

Private Sub cmdCancel_Click()
    CancelSearch = True
End Sub

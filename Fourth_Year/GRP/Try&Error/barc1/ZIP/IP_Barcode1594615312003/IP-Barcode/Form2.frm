VERSION 5.00
Begin VB.Form Form2 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Help"
   ClientHeight    =   2610
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4620
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2610
   ScaleWidth      =   4620
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton Command1 
      Caption         =   "Ok"
      Height          =   375
      Left            =   3360
      TabIndex        =   4
      Top             =   2100
      Width           =   1065
   End
   Begin VB.Label Label4 
      Caption         =   $"Form2.frx":0000
      Height          =   1005
      Left            =   240
      TabIndex        =   3
      Top             =   1020
      Width           =   4155
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Caption         =   "Written By: MAJED SINJAB"
      Height          =   195
      Left            =   915
      TabIndex        =   2
      Top             =   630
      Width           =   2805
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      Caption         =   "Copyright (C) Sinjab Corp. 1999 - 2003"
      Height          =   195
      Left            =   915
      TabIndex        =   1
      Top             =   390
      Width           =   2805
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "IP-Barcode for Windows"
      Height          =   195
      Left            =   915
      TabIndex        =   0
      Top             =   150
      Width           =   2805
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Unload Me
End Sub

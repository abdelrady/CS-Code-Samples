VERSION 5.00
Begin VB.Form frmBarCode 
   Caption         =   "Bar Coder"
   ClientHeight    =   2484
   ClientLeft      =   48
   ClientTop       =   348
   ClientWidth     =   4200
   LinkTopic       =   "Form1"
   ScaleHeight     =   2484
   ScaleWidth      =   4200
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   Begin VB.PictureBox picBarCode 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   1056
      Left            =   192
      ScaleHeight     =   1008
      ScaleWidth      =   3768
      TabIndex        =   0
      Top             =   240
      Width           =   3816
   End
End
Attribute VB_Name = "frmBarCode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


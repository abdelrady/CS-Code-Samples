VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   0  'None
   Caption         =   "About"
   ClientHeight    =   4725
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3900
   LinkTopic       =   "Form1"
   ScaleHeight     =   4725
   ScaleWidth      =   3900
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.PictureBox Picture1 
      Height          =   5055
      Left            =   0
      Picture         =   "frmAbout.frx":0000
      ScaleHeight     =   4995
      ScaleWidth      =   4035
      TabIndex        =   0
      Top             =   0
      Width           =   4095
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Picture1_Click()
Unload Me
End Sub

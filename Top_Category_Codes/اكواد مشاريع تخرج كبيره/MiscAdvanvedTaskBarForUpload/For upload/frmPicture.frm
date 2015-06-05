VERSION 5.00
Begin VB.Form frmPicture 
   BackColor       =   &H00000000&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   WindowState     =   2  'Maximized
   Begin VB.Image imgPic 
      Height          =   1455
      Left            =   0
      ToolTipText     =   "Click to return"
      Top             =   0
      Width           =   855
   End
End
Attribute VB_Name = "frmPicture"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Click()
    Me.Hide
End Sub

Private Sub imgPic_Click()
    Me.Hide
End Sub

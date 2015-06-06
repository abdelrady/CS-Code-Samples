VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Barcode 3 of 9 Reader"
   ClientHeight    =   2250
   ClientLeft      =   60
   ClientTop       =   375
   ClientWidth     =   6375
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   2250
   ScaleWidth      =   6375
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Barcode Reader"
      Height          =   735
      Left            =   1200
      TabIndex        =   1
      Top             =   120
      Width           =   3135
      Begin VB.Label Label1 
         Appearance      =   0  'Flat
         ForeColor       =   &H80000008&
         Height          =   270
         Left            =   360
         TabIndex        =   2
         Top             =   300
         Width           =   2415
      End
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   975
      Left            =   120
      MouseIcon       =   "Form1.frx":0000
      MousePointer    =   99  'Custom
      ScaleHeight     =   61
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   405
      TabIndex        =   0
      Top             =   960
      Width           =   6135
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'''''''''''''''''''''''''''''''''''''''''''''
'' BARCODE 3 OF 9 reader test form         ''
'' By Paul Bahlawan Aug 2003               ''
''                                         ''
'''''''''''''''''''''''''''''''''''''''''''''
Option Explicit

Private Sub Form_Load()
    Picture1.Picture = LoadPicture("barcode.bmp")
    Picture1.ScaleMode = vbPixels
    Form1.Width = Picture1.Width + 350
    Form1.Height = Picture1.Height + Picture1.Top + 600
End Sub

'read barcode
Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Label1.Caption = bcRead(Picture1, CLng(X), CLng(Y), 1, 3)
End Sub

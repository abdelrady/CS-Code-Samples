VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Code 39"
   ClientHeight    =   3300
   ClientLeft      =   45
   ClientTop       =   345
   ClientWidth     =   5370
   LinkTopic       =   "Form1"
   ScaleHeight     =   3300
   ScaleWidth      =   5370
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picBarCode 
      AutoRedraw      =   -1  'True
      BackColor       =   &H8000000E&
      Height          =   1164
      Left            =   420
      ScaleHeight     =   74
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   294
      TabIndex        =   3
      Top             =   1755
      Width           =   4476
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Show Barcode"
      Height          =   540
      Left            =   1140
      TabIndex        =   2
      Top             =   756
      Width           =   2484
   End
   Begin VB.TextBox txtEncode 
      Height          =   312
      Left            =   1896
      TabIndex        =   1
      Top             =   240
      Width           =   2928
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   288
      Left            =   552
      TabIndex        =   0
      Top             =   264
      Width           =   1200
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click()
Dim loTmp As clsBarcode
    
    picBarCode.Cls
    picBarCode.ScaleMode = vbPixels
    
    Set loTmp = New clsBarcode
    loTmp.SaveBarCode "test", txtEncode, 2, 75
    Set picBarCode.Picture = LoadPicture("test")
    Set loTmp = Nothing
    
    #If 0 Then
    Printer.ScaleMode = vbPixels
    llTop = 300
    For llLoop = 0 To UBound(lvItems)
        lsTmp = TofN(lvItems(llLoop), False)
        
        llLeft = 100
        DrawBarCode Printer, lsTmp, llLeft, llTop, 1, 50
                
        llTop = llTop + 250
                
    Next
    
    Printer.EndDoc
    #End If
    
End Sub


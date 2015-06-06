VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form Form1 
   Caption         =   "Key-in Barcode Number:"
   ClientHeight    =   4800
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6720
   LinkTopic       =   "Form1"
   ScaleHeight     =   4800
   ScaleWidth      =   6720
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6495
   End
   Begin VB.CommandButton cmdPrintPreview 
      Caption         =   "Print Preview"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   4440
      Width           =   6435
   End
   Begin RichTextLib.RichTextBox rtbPrint 
      Height          =   3795
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   6495
      _ExtentX        =   11456
      _ExtentY        =   6694
      _Version        =   393217
      ScrollBars      =   2
      TextRTF         =   $"Form1.frx":0000
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "3 of 9 Barcode"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' AUTHOR: Walter A. Narvasa
' URL:http://www.wancomsystems.freeservers.com
' EMAIL:walter@wancomsystems.freeservers.com

Option Explicit

Private Sub cmdPrintPreview_Click()

    PrintPreview rtbPrint, 1, 1, 1, 1, 1
End Sub

Private Sub Form_Load()
    rtbPrint.RightMargin = rtbPrint.Width
End Sub

Private Sub Text1_Change()
    rtbPrint = Text1
End Sub

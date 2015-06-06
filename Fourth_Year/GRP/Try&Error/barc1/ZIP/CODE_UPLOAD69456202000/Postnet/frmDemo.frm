VERSION 5.00
Begin VB.Form frmDemo 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Postnet Generator Demo"
   ClientHeight    =   1575
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5535
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1575
   ScaleWidth      =   5535
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command1 
      Caption         =   "&Print"
      Height          =   375
      Index           =   1
      Left            =   4440
      TabIndex        =   3
      ToolTipText     =   "Print PostNet Barcode to Printer"
      Top             =   195
      Width           =   855
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      Enabled         =   0   'False
      Height          =   375
      Left            =   240
      ScaleHeight     =   315
      ScaleWidth      =   4995
      TabIndex        =   4
      TabStop         =   0   'False
      Top             =   960
      Width           =   5055
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&View"
      Height          =   375
      Index           =   0
      Left            =   3360
      TabIndex        =   2
      ToolTipText     =   "View PostNet Barcode in PictureBox"
      Top             =   195
      Width           =   855
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   1080
      TabIndex        =   1
      ToolTipText     =   "Enter Zip Code"
      Top             =   240
      Width           =   2055
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "&Zip Code:"
      Height          =   195
      Left            =   240
      TabIndex        =   0
      Top             =   280
      Width           =   690
   End
End
Attribute VB_Name = "frmDemo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click(Index As Integer)

    Select Case Index
        Case 0  'View
            Picture1.Cls
            Picture1.CurrentX = 50
            Picture1.CurrentY = 50
            PostNet Text1.Text, Picture1
        Case 1  'Print
            PostNet Text1.Text, Printer
            Printer.FontName = "Courier New"
            Printer.FontSize = "12"
            Printer.Print "  "; Text1.Text
            Printer.Print: Printer.Print
    End Select
        
End Sub


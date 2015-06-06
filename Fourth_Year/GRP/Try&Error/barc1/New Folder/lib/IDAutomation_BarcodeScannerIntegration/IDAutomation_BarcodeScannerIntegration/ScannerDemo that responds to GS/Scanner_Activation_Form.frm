VERSION 5.00
Begin VB.Form Scanner_Activation_Form 
   Caption         =   "Scanner Activation Application"
   ClientHeight    =   3300
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5265
   Icon            =   "Scanner_Activation_Form.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   3300
   ScaleWidth      =   5265
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text4 
      Height          =   375
      Left            =   180
      TabIndex        =   4
      Top             =   1080
      Width           =   1995
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   180
      TabIndex        =   3
      Top             =   1530
      Width           =   1995
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   180
      TabIndex        =   2
      Top             =   630
      Width           =   1995
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   180
      TabIndex        =   1
      Top             =   180
      Width           =   1995
   End
   Begin VB.TextBox ScannedData 
      Height          =   375
      Left            =   180
      TabIndex        =   5
      Top             =   2295
      Width           =   4695
   End
   Begin VB.Label Label3 
      Caption         =   "This application responds to a GS preamble character that is programmed into your scanner."
      Height          =   1725
      Left            =   2250
      TabIndex        =   7
      Top             =   180
      Width           =   2625
   End
   Begin VB.Label Label2 
      Caption         =   "Copyright © 2002 IDAutomation.com, Inc."
      Height          =   420
      Left            =   180
      TabIndex        =   6
      Top             =   2745
      Width           =   4695
   End
   Begin VB.Label Label1 
      Caption         =   "Place cursor anywhere on form, scanned data appears here:"
      Height          =   255
      Left            =   180
      TabIndex        =   0
      Top             =   1995
      Width           =   4695
   End
End
Attribute VB_Name = "Scanner_Activation_Form"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Form_KeyPress(KeyAscii As Integer)
    'KeyAscii retunrs the ASCII value of the scanned data
    'Here ASCII 30 (the RS character) is used to start a process; ASCII chart: http://www.idautomation.com/ascii-table.html
    If KeyAscii = 29 Then
        'Reset the KeyAscii to 0
        KeyAscii = 0
        'Here we send the data scanned to a text box
        'However, we could perform other functions such as a database lookup
        ScannedData.Text = InputBox("Enter Data:")
    End If
End Sub

Private Sub Form_Load()
    'KeyPreview must be set to True so the scanned data can be evaluated
    Scanner_Activation_Form.KeyPreview = True
End Sub

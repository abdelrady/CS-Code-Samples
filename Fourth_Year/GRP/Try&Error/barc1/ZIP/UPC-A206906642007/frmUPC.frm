VERSION 5.00
Begin VB.Form frmUPC 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "UPC-A Barcode Image"
   ClientHeight    =   4230
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6870
   Icon            =   "frmUPC.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4230
   ScaleWidth      =   6870
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdClear 
      Caption         =   "Reset Images"
      Height          =   495
      Left            =   5160
      TabIndex        =   17
      Top             =   2880
      Width           =   1575
   End
   Begin VB.TextBox txtUPC 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2880
      TabIndex        =   15
      Text            =   "097363395843"
      Top             =   840
      Width           =   2055
   End
   Begin VB.CommandButton cmdGen 
      Caption         =   "Generate Barcode"
      Height          =   495
      Left            =   5160
      TabIndex        =   14
      Top             =   1440
      Width           =   1575
   End
   Begin VB.PictureBox picUPCy 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2880
      ScaleHeight     =   61
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   134
      TabIndex        =   1
      TabStop         =   0   'False
      Top             =   1440
      Width           =   2070
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Index           =   5
         Left            =   1770
         TabIndex        =   13
         Top             =   645
         Width           =   135
      End
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   4
         Left            =   1485
         TabIndex        =   12
         Top             =   630
         Width           =   135
      End
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   3
         Left            =   1380
         TabIndex        =   11
         Top             =   630
         Width           =   135
      End
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   2
         Left            =   1275
         TabIndex        =   10
         Top             =   630
         Width           =   135
      End
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   1
         Left            =   1170
         TabIndex        =   9
         Top             =   630
         Width           =   135
      End
      Begin VB.Label R 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   0
         Left            =   1065
         TabIndex        =   8
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   5
         Left            =   855
         TabIndex        =   7
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   4
         Left            =   750
         TabIndex        =   6
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   3
         Left            =   645
         TabIndex        =   5
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   2
         Left            =   540
         TabIndex        =   4
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   210
         Index           =   1
         Left            =   435
         TabIndex        =   3
         Top             =   630
         Width           =   135
      End
      Begin VB.Label L 
         BackColor       =   &H00FFFFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Index           =   0
         Left            =   180
         TabIndex        =   2
         Top             =   645
         Width           =   135
      End
   End
   Begin VB.PictureBox picUPC 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   975
      Left            =   2880
      ScaleHeight     =   61
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   134
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   2880
      Width           =   2070
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Example only, not a complete application."
      Height          =   255
      Left            =   120
      TabIndex        =   21
      Top             =   480
      Width           =   5535
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Generate a UPC-A barcode."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   20
      Top             =   120
      Width           =   5655
   End
   Begin VB.Label Label3 
      Caption         =   $"frmUPC.frx":038A
      Height          =   1095
      Left            =   120
      TabIndex        =   19
      Top             =   2880
      Width           =   2655
   End
   Begin VB.Label Label2 
      Caption         =   $"frmUPC.frx":041C
      Height          =   975
      Left            =   120
      TabIndex        =   18
      Top             =   1485
      Width           =   2655
   End
   Begin VB.Label Label1 
      Caption         =   "UPC Code To Be Generated:"
      Height          =   375
      Left            =   120
      TabIndex        =   16
      Top             =   940
      Width           =   2295
   End
End
Attribute VB_Name = "frmUPC"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'*************************************************************************************
' UPC-A Barcode Image Generator
' Copyright: 2006 Chris Mauck
' Component: frmUPC - Form used for example of usage.
'
' Purpose: Code was developed to create UPC-A image for a DVD Database collection. This
' allows the owner of the database to create a scannable UPC code to be printed on any
' receipts that may be generated.
'
' Could not find any other programs to generate the UPC-A barcode properly so I created
' my own. There is probably a faster way then what I have done, but creativity is
' spawned by necessity. There may be ideas and concepts intermixed within my module that
' are derivitives of others, possibly found on PSC. Not sure, its been over a year.
'
' Full version of the program creates an HTML page from the Access database information
' and includes the barcode (if user chooses to) on the page.
'
' Scope: Associated module simply takes each of the 12 digits in a UPC-A barcode and
' places them within labels already placed inside of a PictureBox in the proper locations.
' The module copies the contents of the PictureBox to a second PictureBox and then uses
' the label information from the first to 'draw' the lines for the barcode.
'
' Commented out the section of the module at the end that saves a copy of the resulting
' barcode in bitmap format.
'
' This is 'free' software with the following restrictions:
'
' You may not redistribute this code as a 'sample' or 'demo'. However, you are free
' to use the source code in your own code, but you may not claim that you created
' the sample code. It is expressly forbidden to sell or profit from this source code
' other than by the knowledge gained or the enhanced value added by your own code.
'
' Use of this software is also done so at your own risk. The code is supplied as
' is without warranty or guarantee of any kind.
'
'*************************************************************************************

Private Sub cmdClear_Click()
    picUPC.Picture = LoadPicture("")    'Clear picture because CLS doesn't work reliably on its own.
    picUPC.Cls                          'Clear picture box contents.
    
    L(0).Caption = "0"                  'Renumber all UPC digit labels to zero
    L(1).Caption = "0"
    L(2).Caption = "0"
    L(3).Caption = "0"
    L(4).Caption = "0"
    L(5).Caption = "0"
    R(0).Caption = "0"
    R(1).Caption = "0"
    R(2).Caption = "0"
    R(3).Caption = "0"
    R(4).Caption = "0"
    R(5).Caption = "0"

End Sub

Private Sub cmdGen_Click()
    Call barcode(txtUPC.Text, frmUPC)
End Sub

Private Sub Form_Load()
    ChDir App.Path
End Sub


VERSION 5.00
Begin VB.Form Test 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Test Barcode Engine"
   ClientHeight    =   8280
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10425
   LinkTopic       =   "Form1"
   ScaleHeight     =   552
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   695
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture6 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      FillColor       =   &H8000000F&
      ForeColor       =   &H80000008&
      Height          =   6015
      Left            =   4800
      ScaleHeight     =   399
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   356
      TabIndex        =   10
      Top             =   1440
      Width           =   5370
   End
   Begin VB.PictureBox Picture2 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   735
      Left            =   360
      ScaleHeight     =   47
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   287
      TabIndex        =   9
      Top             =   2400
      Width           =   4335
   End
   Begin VB.PictureBox Picture3 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   495
      Left            =   360
      ScaleHeight     =   31
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   287
      TabIndex        =   8
      Top             =   3240
      Width           =   4335
   End
   Begin VB.PictureBox Picture4 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   975
      Left            =   360
      ScaleHeight     =   63
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   287
      TabIndex        =   7
      Top             =   3840
      Width           =   4335
   End
   Begin VB.PictureBox Picture5 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   2535
      Left            =   360
      ScaleHeight     =   167
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   287
      TabIndex        =   6
      Top             =   4920
      Width           =   4335
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Print"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   4800
      TabIndex        =   5
      Top             =   720
      Width           =   5415
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Test"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   360
      TabIndex        =   1
      Top             =   7560
      Width           =   9855
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   855
      Left            =   360
      ScaleHeight     =   55
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   287
      TabIndex        =   0
      Top             =   1440
      Width           =   4335
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "ScaleMode = Pixels"
      Height          =   255
      Index           =   1
      Left            =   720
      TabIndex        =   4
      Top             =   720
      Width           =   2295
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "AutoRedraw = True"
      Height          =   255
      Index           =   0
      Left            =   720
      TabIndex        =   3
      Top             =   480
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Set "
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   240
      Width           =   375
   End
End
Attribute VB_Name = "Test"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 10, 40, Picture1, vbRed
DrawBarcode "nwnnwnwnnnnnnwwnwnnnwnnwnnnnwnnnnwwnwnnnwnnwnnnnwnnnnnwwnnwnnnwnnwwnnnwnwnnnnwnnwnnnnnwwnnnwnnwnwnn", 10, 10, 30, Picture2, vbBlue
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 5, 10, Picture3, &HA2737E
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 2, 60, Picture4, &H54A7A7
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 7, 150, Picture5, &H6C8D65

DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 10, 40, Picture6, vbRed
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 52, 30, Picture6, vbBlue
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 84, 10, Picture6, &HA2737E
DrawBarcode "nwnnwnwnnnwnnnnwnnwnnnwnnwnnwnwnwnnwnnnnnwnnwnwnn", 50, 96, 60, Picture6, &H54A7A7
DrawBarcode "nwnnwnwnnnnnnwwnwnnnwnnwnnnnwnnnwwnnnnwnwnwwnnnnnnnnnwwnnnwnwnnwwnnnnnnwnnwnwnn", 50, 158, 150, Picture6, vbBlack
End Sub

Private Sub Command2_Click()
Printer.Print
Printer.PaintPicture Picture6.Image, 0, 0
Printer.EndDoc
End Sub

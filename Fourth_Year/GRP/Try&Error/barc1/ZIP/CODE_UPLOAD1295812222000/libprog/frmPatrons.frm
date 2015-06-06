VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmPatrons 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   7200
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   9600
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   480
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   640
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   375
      Left            =   7680
      TabIndex        =   1
      Top             =   120
      Width           =   1815
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Import"
      Height          =   375
      Left            =   7680
      TabIndex        =   0
      Top             =   600
      Width           =   1815
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "U:\DSD\lib.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   420
      Left            =   3000
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Patron"
      Top             =   120
      Visible         =   0   'False
      Width           =   3060
   End
   Begin MSDBGrid.DBGrid DBGrid1 
      Bindings        =   "frmPatrons.frx":0000
      Height          =   5295
      Left            =   120
      OleObjectBlob   =   "frmPatrons.frx":0014
      TabIndex        =   2
      Top             =   1800
      Width           =   9375
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Book Keeper 101"
      BeginProperty Font 
         Name            =   "Coronet"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   600
      TabIndex        =   4
      Top             =   240
      Width           =   2895
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Beta 1.0"
      Height          =   255
      Left            =   1080
      TabIndex        =   3
      Top             =   720
      Width           =   1695
   End
   Begin VB.Image imgLogo 
      Height          =   1635
      Left            =   120
      Picture         =   "frmPatrons.frx":09E7
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1620
   End
End
Attribute VB_Name = "frmPatrons"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdOK_Click()
Me.Hide
End Sub


VERSION 5.00
Begin VB.Form frmPreview 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " BARCODE PREVIEW & SAVE"
   ClientHeight    =   5070
   ClientLeft      =   2955
   ClientTop       =   3570
   ClientWidth     =   11265
   Icon            =   "frmPreview.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5070
   ScaleWidth      =   11265
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   3975
      Left            =   240
      ScaleHeight     =   3945
      ScaleWidth      =   10785
      TabIndex        =   6
      Top             =   120
      Width           =   10815
   End
   Begin VB.CommandButton Command6 
      Height          =   615
      Left            =   8760
      Picture         =   "frmPreview.frx":0EFA
      Style           =   1  'Graphical
      TabIndex        =   5
      ToolTipText     =   "SHOW ABOUT AND LINK"
      Top             =   4320
      Width           =   615
   End
   Begin VB.CommandButton Command7 
      Height          =   615
      Left            =   9600
      Picture         =   "frmPreview.frx":1BC4
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "SHOW HELP"
      Top             =   4320
      Width           =   615
   End
   Begin VB.CommandButton Command3 
      Enabled         =   0   'False
      Height          =   615
      Left            =   240
      Picture         =   "frmPreview.frx":288E
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "SAVE PICTURE AS A BITMAP"
      Top             =   4320
      Width           =   615
   End
   Begin VB.TextBox Text2 
      Height          =   285
      Left            =   960
      TabIndex        =   1
      Top             =   4560
      Width           =   6495
   End
   Begin VB.CommandButton Command2 
      Height          =   615
      Left            =   10440
      Picture         =   "frmPreview.frx":3158
      Style           =   1  'Graphical
      TabIndex        =   0
      ToolTipText     =   "EXIT THIS SCREEN:- BY THE NEAREST DOOR!"
      Top             =   4320
      Width           =   615
   End
   Begin VB.Label Label1 
      Caption         =   "Save File name"
      Height          =   255
      Left            =   960
      TabIndex        =   2
      Top             =   4320
      Width           =   2775
   End
End
Attribute VB_Name = "frmPreview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command2_Click()
Unload Me
frm39Barcode.WindowState = vbNormal
End Sub

Private Sub Command2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command2.MousePointer = 99
Command2.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command3_Click()
'*******************************************************
'*         save file routine to path specified         *
'*          create dir if dir does not exist           *
'*******************************************************
If Dir(App.Path & "\Barcodes", vbDirectory) = "" Then MkDir (App.Path & "\Barcodes")

SavePicture Picture1.Image, App.Path & "\Barcodes\" & Text2.Text & ".bmp"
End Sub

Private Sub Command3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command3.MousePointer = 99
Command3.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command6_Click()
frmLink.Show
End Sub

Private Sub Command6_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command6.MousePointer = 99
Command6.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Command7_Click()
frmPreviewHelp.Show
End Sub

Private Sub Command7_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command7.MousePointer = 99
Command7.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Form_Load()
Picture1.Width = frm39Barcode.Picture1.Width
Picture1.Height = frm39Barcode.Picture1.Height
End Sub

Private Sub Text2_Change()
If Text2.Text <> "" Then
Command3.Enabled = True
Else: Command3.Enabled = False
End If
End Sub


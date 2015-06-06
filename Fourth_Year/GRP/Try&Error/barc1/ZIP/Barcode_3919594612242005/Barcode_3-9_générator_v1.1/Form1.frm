VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Barcode 3 of 9"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   375
   ClientWidth     =   8220
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   8220
   StartUpPosition =   3  'Windows Default
   Begin VB.VScrollBar VScroll1 
      Height          =   1215
      Left            =   4560
      Max             =   100
      TabIndex        =   10
      Top             =   360
      Width           =   255
   End
   Begin VB.HScrollBar HScroll1 
      Height          =   255
      Left            =   2880
      Max             =   100
      TabIndex        =   9
      Top             =   360
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Command2"
      Height          =   615
      Left            =   1920
      TabIndex        =   8
      Top             =   720
      Width           =   855
   End
   Begin VB.Frame Frame1 
      Caption         =   "Settings"
      Height          =   1335
      Index           =   0
      Left            =   5160
      TabIndex        =   3
      Top             =   120
      Width           =   2655
      Begin VB.CheckBox Check1 
         Caption         =   "Add Label"
         Height          =   195
         Index           =   1
         Left            =   120
         TabIndex        =   7
         ToolTipText     =   "Human readable"
         Top             =   600
         Value           =   1  'Checked
         Width           =   2415
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Add Check Character"
         Height          =   195
         Index           =   2
         Left            =   120
         TabIndex        =   6
         ToolTipText     =   "Not commonly used"
         Top             =   840
         Width           =   2415
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Optimize for Printing"
         Height          =   195
         Index           =   0
         Left            =   120
         TabIndex        =   4
         ToolTipText     =   "Increases spacing"
         Top             =   360
         Value           =   1  'Checked
         Width           =   2415
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Copy to clipboard"
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   840
      Width           =   1455
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   2415
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BackColor       =   &H00FFFFFF&
      Height          =   1000
      Left            =   120
      ScaleHeight     =   63
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   189
      TabIndex        =   5
      Top             =   1560
      Width           =   2895
   End
   Begin VB.Label Label1 
      Caption         =   "Barcode Data:"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'''''''''''''''''''''''''''''''''''''''''''''
'' BARCODE 3 OF 9 GENERATOR                ''
'' By Paul Bahlawan Aug 2003               ''
''                                         ''
'' Update Oct 2004:                        ''
'' -Add "Check Character" option           ''
'' -Add "Optimize for Printing" option     ''
'' -Add "Copy to clipboard" command        ''
'' -Various minor changes                  ''
''                                         ''
'' Based on specs from:                    ''
'' www.adams1.com/pub/russadam/39code.html ''
'''''''''''''''''''''''''''''''''''''''''''''
Option Explicit
Dim CodeBar As Cls_Code39


Private Sub Command2_Click()
CodeBar.CB_SauveImage App.Path & "\" & Text1.Text
End Sub

Private Sub Form_Load()
' on crée le lien avec la classe
Set CodeBar = New Cls_Code39
CodeBar.CB_AssignePictureBox Picture1
HScroll1.Value = 20
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set CodeBar = Nothing
End Sub

Private Sub HScroll1_Change()
CodeBar.Décalage_Latéral = HScroll1.Value
CodeBar.CB_Création Text1.Text, (Check1(0).Value = 1), (Check1(1).Value = 1), (Check1(2).Value = 1)
End Sub

Private Sub Text1_Change()
CodeBar.CB_Création Text1.Text, (Check1(0).Value = 1), (Check1(1).Value = 1), (Check1(2).Value = 1)
'makeBC
End Sub

Private Sub Check1_Click(Index As Integer)
CodeBar.CB_Création Text1.Text, (Check1(0).Value = 1), (Check1(1).Value = 1), (Check1(2).Value = 1)
End Sub

Private Sub Command1_Click()
CodeBar.CB_Copy_PressePapier
End Sub

Private Sub VScroll1_Change()
CodeBar.Décalage_Hauteur = VScroll1.Value
CodeBar.CB_Création Text1.Text, (Check1(0).Value = 1), (Check1(1).Value = 1), (Check1(2).Value = 1)

End Sub

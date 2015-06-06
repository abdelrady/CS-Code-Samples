VERSION 5.00
Begin VB.Form frmPreviewHelp 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " HELP"
   ClientHeight    =   8760
   ClientLeft      =   2760
   ClientTop       =   1425
   ClientWidth     =   11535
   Icon            =   "frmPreviewHelp.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8760
   ScaleWidth      =   11535
   Begin VB.CommandButton Command4 
      Height          =   615
      Left            =   10800
      Picture         =   "frmPreviewHelp.frx":0EFA
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "EXIT THIS SCREEN:- BY THE NEAREST DOOR!"
      Top             =   8040
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   4
      Left            =   10560
      TabIndex        =   5
      Top             =   4800
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   3
      Left            =   9720
      TabIndex        =   4
      Top             =   4800
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   2
      Left            =   8880
      TabIndex        =   3
      Top             =   4800
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   735
      Index           =   1
      Left            =   360
      TabIndex        =   2
      Top             =   4680
      Width           =   7335
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   2055
      Index           =   0
      Left            =   360
      TabIndex        =   1
      Top             =   480
      Width           =   6255
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Label1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2295
      Left            =   120
      TabIndex        =   0
      Top             =   5640
      Width           =   11295
      WordWrap        =   -1  'True
   End
   Begin VB.Image Image1 
      Height          =   5445
      Left            =   120
      Picture         =   "frmPreviewHelp.frx":1BC4
      Top             =   120
      Width           =   11355
   End
End
Attribute VB_Name = "frmPreviewHelp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command4_Click()
Unload Me
End Sub

Private Sub Command4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command4.MousePointer = 99
Command4.MouseIcon = LoadResPicture(101, vbResCursor)
End Sub

Private Sub Form_Load()
Label1.Caption = ""
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Image1.MousePointer = 0
Label1.Caption = ""
End Sub

Private Sub Label2_Click(Index As Integer)
'*******************************************************
'*                  set the help text                  *
'*******************************************************
Select Case Index
Case 0
Label1.Caption = "BARCODE PREVIEW" & vbCrLf & vbCrLf & "Preview the bardcode as it will be saved. Full size and cropped to the required size"
Case 1
Label1.Caption = "PICTURE TO BITMAP" & vbCrLf & vbCrLf & _
"Enter the name for the barcode that you have just created. The SAVE button IS ONLY enabled when you have typed a name for the file to save." _
& vbCrLf & "Barcodes are saved in a folder called  'Barcodes' in the program folder"
Case 2
Label1.Caption = "SHOW THE APPLICATION ABOUT BOX && WEB LINK"
Case 3
Label1.Caption = "YOU ARE ALREADY HERE"
Case 4
Label1.Caption = "EXIT PREVIEW SCREEN AND RESTORE CREATE BARCODE SCREEN"
End Select
End Sub

Private Sub Label2_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*                set the label cursor                 *
'*******************************************************
For Index = 0 To 4
Label2(Index).MousePointer = 99
Label2(Index).MouseIcon = LoadResPicture(101, vbResCursor)
Label2(Index).ToolTipText = "CLICK TO VIEW HELP TOPIC"
Next Index

End Sub

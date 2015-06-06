VERSION 5.00
Begin VB.Form frm39BarcodeHelp 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " HELP"
   ClientHeight    =   10080
   ClientLeft      =   2730
   ClientTop       =   630
   ClientWidth     =   11595
   Icon            =   "frm39BarcodeHelp.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10080
   ScaleWidth      =   11595
   Begin VB.CommandButton Command2 
      Height          =   615
      Left            =   10800
      Picture         =   "frm39BarcodeHelp.frx":0EFA
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "EXIT THIS SCREEN:- BY THE NEAREST DOOR!"
      Top             =   9360
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   10
      Left            =   10560
      TabIndex        =   12
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   9
      Left            =   9720
      TabIndex        =   11
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   8
      Left            =   8880
      TabIndex        =   10
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   7
      Left            =   4560
      TabIndex        =   9
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   6
      Left            =   5280
      TabIndex        =   8
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   5
      Left            =   8040
      TabIndex        =   7
      Top             =   6240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   855
      Index           =   4
      Left            =   360
      TabIndex        =   6
      Top             =   6120
      Width           =   4095
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   255
      Index           =   3
      Left            =   8280
      TabIndex        =   5
      Top             =   5400
      Width           =   2655
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   2
      Left            =   1680
      TabIndex        =   4
      Top             =   5040
      Width           =   6495
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Index           =   1
      Left            =   480
      TabIndex        =   3
      Top             =   5040
      Width           =   1095
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   4095
      Index           =   0
      Left            =   360
      TabIndex        =   1
      Top             =   600
      Width           =   10935
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
      Height          =   1935
      Left            =   120
      TabIndex        =   0
      Top             =   7320
      Width           =   11295
      WordWrap        =   -1  'True
   End
   Begin VB.Image Image1 
      Height          =   7035
      Left            =   120
      Picture         =   "frm39BarcodeHelp.frx":1BC4
      Top             =   120
      Width           =   11385
   End
End
Attribute VB_Name = "frm39BarcodeHelp"
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

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*            set the command button cursor            *
'*******************************************************
Command2.MousePointer = 99
Command2.MouseIcon = LoadResPicture(101, vbResCursor)
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
Label1.Caption = "BARCODE DISPLAY" & vbCrLf & vbCrLf & "Display the bardcode. The viewport can then be resized using the handles (blue squares) prior to sending to the preview screen and saving"
Case 1
Label1.Caption = "MAKE BARCODE" & vbCrLf & vbCrLf & "Make barcode and show it in the barcode display viewport."
Case 2
Label1.Caption = "BARCODE TEXT" & vbCrLf & vbCrLf & "Enter the text for the barcode - Maximum 20 letters and numbers"
Case 3
Label1.Caption = "TEXT COUNT" & vbCrLf & vbCrLf & "Shows the number of characters entered"
Case 4
Label1.Caption = "PICTURE PROPERITES" & vbCrLf & vbCrLf & "Shows the size of the viewport in centimetres initially and as you resize."
Case 5
Label1.Caption = "MINIMISE THIS SCREEN TO THE WINDOWS TASKBAR"
Case 6
Label1.Caption = "RESET ALL"
Case 7
Label1.Caption = "GO TO PREVIEW" & vbCrLf & vbCrLf & "Show the barcode preview and save screen and minimises the create barcode screen"
Case 8
Label1.Caption = "SHOW THE APPLICATION ABOUT BOX && WEB LINK"
Case 9
Label1.Caption = "YOU ARE ALREADY HERE"
Case 10
Label1.Caption = "EXIT PREVIEW SCREEN"
End Select
End Sub

Private Sub Label2_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
'*******************************************************
'*                set the label cursor                 *
'*******************************************************
For Index = 0 To 10
Label2(Index).MousePointer = 99
Label2(Index).MouseIcon = LoadResPicture(101, vbResCursor)
Label2(Index).ToolTipText = "CLICK TO VIEW HELP TOPIC"
Next Index

End Sub



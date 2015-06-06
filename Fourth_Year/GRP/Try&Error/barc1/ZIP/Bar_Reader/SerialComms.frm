VERSION 5.00
Begin VB.Form frmSerial 
   Caption         =   "Serial Comms"
   ClientHeight    =   4680
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5880
   LinkTopic       =   "Form1"
   ScaleHeight     =   4680
   ScaleWidth      =   5880
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer TMRComm 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   5430
      Top             =   4230
   End
   Begin VB.Frame Frame1 
      Caption         =   "Commands and Results"
      ForeColor       =   &H00C00000&
      Height          =   3015
      Left            =   90
      TabIndex        =   7
      Top             =   1440
      Width           =   5595
      Begin VB.TextBox txtRec 
         Enabled         =   0   'False
         Height          =   1395
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   10
         Tag             =   "NC"
         Top             =   1500
         Width           =   5355
      End
      Begin VB.CommandButton BTNSend 
         Caption         =   "&Send Text"
         Default         =   -1  'True
         Enabled         =   0   'False
         Height          =   375
         Left            =   4020
         TabIndex        =   9
         Tag             =   "NC"
         Top             =   1020
         Width           =   1455
      End
      Begin VB.TextBox txt 
         Enabled         =   0   'False
         Height          =   315
         Index           =   2
         Left            =   120
         TabIndex        =   8
         Tag             =   "NC"
         Top             =   540
         Width           =   5355
      End
      Begin VB.Label Label1 
         Caption         =   "Text Returned:"
         Height          =   255
         Index           =   3
         Left            =   120
         TabIndex        =   12
         Top             =   1260
         Width           =   1215
      End
      Begin VB.Label Label1 
         Caption         =   "String to send to device:"
         Height          =   255
         Index           =   2
         Left            =   120
         TabIndex        =   11
         Top             =   300
         Width           =   3075
      End
      Begin VB.Shape Pic 
         BorderStyle     =   0  'Transparent
         FillColor       =   &H0000FFFF&
         FillStyle       =   0  'Solid
         Height          =   255
         Left            =   5280
         Shape           =   3  'Circle
         Top             =   180
         Width           =   195
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Comm's"
      ForeColor       =   &H00C00000&
      Height          =   1215
      Left            =   90
      TabIndex        =   0
      Top             =   120
      Width           =   5595
      Begin VB.CommandButton BTNCloseCom 
         Cancel          =   -1  'True
         Caption         =   "Close Port"
         Enabled         =   0   'False
         Height          =   435
         Left            =   4380
         TabIndex        =   4
         Tag             =   "NC"
         Top             =   660
         Width           =   1035
      End
      Begin VB.CommandButton BTNOpenCom 
         Caption         =   "Open Port"
         Height          =   435
         Left            =   4380
         TabIndex        =   3
         Tag             =   "NO"
         Top             =   180
         Width           =   1035
      End
      Begin VB.TextBox txt 
         Height          =   315
         Index           =   1
         Left            =   1980
         TabIndex        =   2
         Tag             =   "NO"
         Text            =   "2400,n,8,1"
         Top             =   570
         Width           =   1455
      End
      Begin VB.TextBox txt 
         Height          =   315
         Index           =   0
         Left            =   1020
         TabIndex        =   1
         Tag             =   "NO"
         Text            =   "COM1:"
         Top             =   570
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Comm Settings:"
         Height          =   255
         Index           =   1
         Left            =   1980
         TabIndex        =   6
         Top             =   330
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "Comm Port:"
         Height          =   255
         Index           =   0
         Left            =   1020
         TabIndex        =   5
         Top             =   330
         Width           =   915
      End
   End
End
Attribute VB_Name = "frmSerial"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub BTNCloseCom_Click()
    TMRComm.Enabled = False
    Call fin_com
    SwitchTags
End Sub

Private Sub BTNOpenCom_Click()
    If Not Init_Com(txt(0).Text, txt(1).Text) Then
        MsgBox txt(0).Text & " Not available!"
        Exit Sub
    End If
    SwitchTags
    TMRComm.Enabled = True
End Sub

Private Sub BTNSend_Click()
    If WriteCOM32(txt(2)) <> Len(txt(2)) Then
        MsgBox "Error writing to comm's"
        Exit Sub
    End If
    txtRec.Text = ""
    Pic.FillColor = &HFF0000
End Sub

Private Sub TMRComm_Timer()
    Dim Ans As String, i As Integer, RtnStr As String
    Ans = ReadCommPure()
    If Pic.FillColor = &HFFFFFF Then
        Pic.FillColor = &H808080
       Else
        Pic.FillColor = &HFFFFFF
    End If
    If Ans = "" Then Exit Sub
    Pic.FillColor = &HFF
    For i = 1 To Len(Ans)
        RtnStr = RtnStr & Hex(Asc(Mid$(Ans, i, 1))) & " "
    Next
    RtnStr = RtnStr & vbCrLf & vbCrLf & CleanStr(Ans)
    txtRec.Text = RtnStr
    FlushComm
End Sub

Function CleanStr(TextLine As String) As String
    Dim i As Integer, RtnStr As String
    RtnStr = ""
    For i = 1 To Len(TextLine)
        Select Case Asc(Mid$(TextLine, i, 1))
            Case &H5D
                RtnStr = RtnStr & "<ACK>"
            Case &H5B
                RtnStr = RtnStr & "<NAK>"
            Case Is >= &H30
                RtnStr = RtnStr & Mid$(TextLine, i, 1)
            Case 13
                RtnStr = RtnStr & "<CR>"
            Case 10
                RtnStr = RtnStr & "<LF>"
            Case Else
                RtnStr = RtnStr & "@"
        End Select
    Next i
    CleanStr = RtnStr
End Function

Sub SwitchTags()
    Dim xs As Control
    For Each xs In Me
        If xs.Tag <> "" Then
            xs.Enabled = Not xs.Enabled
        End If
    Next
End Sub

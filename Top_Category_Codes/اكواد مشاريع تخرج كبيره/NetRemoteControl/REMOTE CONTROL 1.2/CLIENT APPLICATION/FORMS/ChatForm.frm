VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Begin VB.Form ChatForm 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Remote Chat"
   ClientHeight    =   5745
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7590
   Icon            =   "ChatForm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5745
   ScaleWidth      =   7590
   Begin VB.Frame Frame3 
      Height          =   1005
      Left            =   -90
      TabIndex        =   5
      Top             =   -120
      Width           =   7680
      Begin VB.Image Image1 
         Height          =   825
         Left            =   60
         Picture         =   "ChatForm.frx":030A
         Stretch         =   -1  'True
         Top             =   120
         Width           =   7635
      End
   End
   Begin MSWinsockLib.Winsock sckChat 
      Left            =   3660
      Top             =   2370
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      Height          =   4875
      Left            =   53
      TabIndex        =   0
      Top             =   810
      Width           =   7485
      Begin VB.TextBox GetTxt 
         BackColor       =   &H00000000&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   3525
         Left            =   150
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   4
         Top             =   270
         Width           =   7215
      End
      Begin VB.Frame Frame2 
         Height          =   945
         Left            =   150
         TabIndex        =   1
         Top             =   3840
         Width           =   7215
         Begin VB.TextBox SendTxt 
            BackColor       =   &H00000000&
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H000000FF&
            Height          =   375
            Left            =   150
            TabIndex        =   3
            Top             =   330
            Width           =   5415
         End
         Begin VB.CommandButton SendBttn 
            Caption         =   "Send"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   405
            Left            =   5640
            TabIndex        =   2
            Top             =   300
            Width           =   1425
         End
      End
   End
End
Attribute VB_Name = "ChatForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim txtData As String

Private Sub Form_Load()
    sckChat.RemoteHost = RemoteForm.sckIdentifier.RemoteHost
    sckChat.RemotePort = 1002
    sckChat.Connect
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    sckChat.Close
End Sub

Private Sub sckChat_Close()
    SendBttn.Enabled = False
    Unload Me
End Sub

Private Sub sckChat_Connect()
    SendBttn.Enabled = True
End Sub

Private Sub sckChat_DataArrival(ByVal bytesTotal As Long)
Dim getData As String, Position As Long
    
    sckChat.getData getData
    getData = sckChat.RemoteHost & " : " & getData & vbCrLf
    GetTxt.Text = GetTxt.Text & getData
    Position = Len(GetTxt.Text)
    GetTxt.SelStart = Position
    SendTxt.SetFocus
End Sub

Private Sub SendBttn_Click()
    txtData = SendTxt.Text
    If txtData <> "" Then
        sckChat.SendData txtData
        SendTxt.Text = ""
        SendTxt.SetFocus
    End If
End Sub

Private Sub SendTxt_KeyUp(KeyCode As Integer, Shift As Integer)
    If KeyCode = 13 Then
        Call SendBttn_Click
    End If
End Sub

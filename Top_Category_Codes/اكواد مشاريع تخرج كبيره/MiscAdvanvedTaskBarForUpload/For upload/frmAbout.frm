VERSION 5.00
Begin VB.Form frmAbout 
   BackColor       =   &H00000000&
   BorderStyle     =   0  'None
   ClientHeight    =   5145
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   8310
   LinkTopic       =   "Form1"
   ScaleHeight     =   5145
   ScaleWidth      =   8310
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   435
      Left            =   3600
      MouseIcon       =   "frmAbout.frx":0000
      MousePointer    =   99  'Custom
      TabIndex        =   7
      Top             =   4440
      Width           =   525
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Email: m_alian2003@hotmail.com"
      ForeColor       =   &H00FFFFFF&
      Height          =   195
      Left            =   480
      MouseIcon       =   "frmAbout.frx":0152
      MousePointer    =   99  'Custom
      TabIndex        =   6
      Top             =   3840
      Width           =   2370
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Website: www.geocities.com/m_alian14"
      ForeColor       =   &H00FFFFFF&
      Height          =   195
      Left            =   480
      MouseIcon       =   "frmAbout.frx":02A4
      MousePointer    =   99  'Custom
      TabIndex        =   5
      Top             =   3480
      Width           =   2850
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "A MOLiSoft™ Production"
      ForeColor       =   &H00FFFFFF&
      Height          =   195
      Left            =   480
      TabIndex        =   4
      Top             =   1800
      Width           =   1710
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Copyright  © 2004"
      ForeColor       =   &H00FFFFFF&
      Height          =   195
      Left            =   480
      TabIndex        =   3
      Top             =   1320
      Width           =   1290
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmAbout.frx":03F6
      ForeColor       =   &H00FFFFFF&
      Height          =   1035
      Left            =   480
      TabIndex        =   2
      Top             =   2280
      Width           =   7275
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackColor       =   &H00C0E0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Version 1.0"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   300
      Left            =   480
      TabIndex        =   1
      Top             =   840
      Width           =   1200
   End
   Begin VB.Label lblTitle 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "MOLiSoft Advanced Taskbar"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   555
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   6150
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    'On Error GoTo Path
'    Dim FileName As String
    'DoEvents
'    FileName = App.Path & "\INFO.gif"
    'FileName = Replace(FileName, "\\", "\")
'    a.Show (FileName)
    'a.Move -525, 0
'    a.BestFit
    '
'    'Me.Move Me.Left, Me.Top, a.Width, a.Height
    'Picture1.Move (Me.Width - Picture1.Width - 50), 10
'    Exit Sub
'Path:
    'Unload Me
'    MsgBox "Cannot file the file: " & FileName
    '
End Sub

Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Picture1.Left = Picture1.Left + 50
    Picture1.Top = Picture1.Top + 50
End Sub

Private Sub Picture1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Picture1.Left = Picture1.Left - 50
    Picture1.Top = Picture1.Top - 50
End Sub

Private Sub Label5_Click()
    Shell "Explorer http://www.geocities.com/m_alian14"
End Sub

Private Sub Label6_Click()
    Shell "Explorer mailto:m_alian2003@hotmail.com"
End Sub

Private Sub Label7_Click()
    Unload Me
End Sub

VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Barcode Reader/Scanner"
   ClientHeight    =   1905
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4335
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   1905
   ScaleWidth      =   4335
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   3240
      Top             =   600
   End
   Begin VB.TextBox Text1 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4215
   End
   Begin MSCommLib.MSComm MSComm1 
      Left            =   3720
      Top             =   600
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
      ParitySetting   =   2
      DataBits        =   7
   End
   Begin VB.Label Label2 
      BackColor       =   &H000040C0&
      Caption         =   "For comments/questions/suggestions email @ richard_2k03@yahoo.com"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C0FFFF&
      Height          =   615
      Left            =   0
      TabIndex        =   2
      Top             =   1320
      Width           =   4335
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Enter/Scan Barcode"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Left            =   120
      TabIndex        =   1
      Top             =   720
      Width           =   1830
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' Barcode Reader/Scanner Module
' By: Richard L. Soriano
'
' Note:
' By default the MSComm1 is reffering to COMM1
' but, you can change its value to where it may varry
'
' Suggestions are welcome
' E-Mail: richard_2k03@yahoo.com

Private Sub Form_Load()
    MsgBox "Make sure that your Barcode scanner/reader" & vbCrLf & "is connected to COMM1 Port", vbInformation
End Sub

Private Sub Form_Unload(Cancel As Integer)
    MSComm1.PortOpen = False ' Close the comm port
    MsgBox "Thanx for downloading this code :D", vbInformation
End Sub

Private Sub Timer1_Timer()
    If MSComm1.PortOpen = False Then ' If comm port is not open
       MSComm1.PortOpen = True ' Open it
    End If
     
    If MSComm1.InBufferCount > 0 Then ' If theres data in comm buffer
        inst = inst + MSComm1.Input ' Get the data
        Text1 = inst ' Show its value
    End If
End Sub

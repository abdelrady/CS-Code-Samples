VERSION 5.00
Begin VB.Form fPassword 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   1515
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4680
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Password.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1515
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "2"
      Height          =   480
      Left            =   2400
      TabIndex        =   2
      Top             =   855
      Width           =   2145
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "1"
      Default         =   -1  'True
      Height          =   480
      Left            =   165
      TabIndex        =   1
      Top             =   855
      Width           =   2145
   End
   Begin VB.TextBox txtPassword 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "Wingdings"
         Size            =   15.75
         Charset         =   2
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      IMEMode         =   3  'DISABLE
      Left            =   165
      PasswordChar    =   "l"
      TabIndex        =   0
      Top             =   210
      Width           =   4380
   End
End
Attribute VB_Name = "fPassword"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim msgScreen1 As String
Dim msgScreen2 As String

Private Sub cmdCancel_Click()
    ADMINISTRATOR = False
    Unload Me
    
End Sub

Private Sub cmdOK_Click()
    If (StrComp(txtPassword, ADMIN_PASSWORD) = 0) Then
        ADMINISTRATOR = True
        Unload Me
    Else
        txtPassword = ""
    End If
    
End Sub

Private Sub Form_Activate()
    msgScreen1 = fMain.lblMain(4)
    msgScreen2 = fMain.lblMain(5)
    
    fMain.lblMain(4) = cINI.Value("MainStrings", "msgScreen10")
    fMain.lblMain(5) = ""
    
End Sub

Private Sub Form_Load()
    BackColor = vbRed
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
            End If
        End With
    Next
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' Check if password has been accepted
    If (Not ADMINISTRATOR) Then
        fMain.lblMain(4) = msgScreen1
        fMain.lblMain(5) = msgScreen2
    End If
    
End Sub

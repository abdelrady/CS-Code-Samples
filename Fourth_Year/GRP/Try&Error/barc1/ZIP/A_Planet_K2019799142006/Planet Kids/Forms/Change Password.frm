VERSION 5.00
Begin VB.Form fChangePassword 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   4320
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
   Icon            =   "Change Password.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4320
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.TextBox txtPassword 
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
      TabIndex        =   3
      Top             =   1515
      Width           =   4380
   End
   Begin VB.TextBox txtConfirm 
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
      Left            =   150
      PasswordChar    =   "l"
      TabIndex        =   5
      Top             =   2490
      Width           =   4380
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "5"
      Height          =   480
      Left            =   2400
      TabIndex        =   7
      Top             =   3180
      Width           =   2145
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "4"
      Default         =   -1  'True
      Height          =   480
      Left            =   165
      TabIndex        =   6
      Top             =   3180
      Width           =   2145
   End
   Begin VB.TextBox txtOldPassword 
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
      TabIndex        =   1
      Top             =   540
      Width           =   4380
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   195
      Left            =   2295
      TabIndex        =   8
      Top             =   3900
      Width           =   90
   End
   Begin VB.Label lblNew 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   2
      Top             =   1155
      Width           =   105
   End
   Begin VB.Label lblConfirm 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "3"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   165
      TabIndex        =   4
      Top             =   2130
      Width           =   105
   End
   Begin VB.Label lblOld 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   0
      Top             =   180
      Width           =   105
   End
End
Attribute VB_Name = "fChangePassword"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Unload Me
    
End Sub

Private Sub cmdSave_Click()
    txtOldPassword = Trim$(txtOldPassword)
    txtPassword = Trim$(txtPassword)
    txtConfirm = Trim$(txtConfirm)
    
    On Error Resume Next
    
    If (Len(txtOldPassword) = 0 And txtOldPassword.Enabled) Then
        txtOldPassword.SetFocus
        
    ElseIf (Len(txtPassword) = 0) Then
        txtPassword.SetFocus
        
    ElseIf (Len(txtConfirm) = 0) Then
        txtConfirm.SetFocus
        
    ElseIf (Not StrComp(txtOldPassword, ADMIN_PASSWORD) = 0) Then
        MsgBoxEx Me.Name & "0", vbExclamation
        txtOldPassword.SetFocus
        SendKeys "{HOME}+{END}"
        
    ElseIf (Not StrComp(txtPassword, txtConfirm) = 0) Then
        MsgBoxEx Me.Name & "1", vbExclamation
        txtConfirm.SetFocus
        SendKeys "{HOME}+{END}"
        
    Else
        On Error GoTo Err_Handler
        
        CON.BeginTrans
        CON.Execute "UPDATE settings SET setvalue='" & txtPassword & "' WHERE setname='password'"
        CON.CommitTrans
        ADMIN_PASSWORD = txtPassword
        
        MsgBoxEx Me.Name & "2", vbInformation
        Unload Me
    End If
    
    Exit Sub
Err_Handler:
    CON.RollbackTrans
    MsgBoxEx Me.Name & "3", vbCritical, Err.Number
    
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    
    If (Len(ADMIN_PASSWORD) = 0) Then
        ' Old password is empty
        txtOldPassword.BackColor = vbButtonFace
        txtOldPassword.Enabled = False
    Else
        ' Must enter old password first
        txtPassword.BackColor = vbButtonFace
        txtPassword.Enabled = False
    End If
    
    txtConfirm.BackColor = vbButtonFace
    txtConfirm.Enabled = False
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            End If
        End With
    Next
    
End Sub

Private Sub txtOldPassword_Change()
    With txtPassword
        .Enabled = (Len(txtOldPassword))
        
        If (.Enabled) Then
            .BackColor = vbWindowBackground
        Else
            .BackColor = vbButtonFace
        End If
    End With
    
End Sub

Private Sub txtPassword_Change()
    With txtConfirm
        .Enabled = (Len(txtPassword))
        
        If (.Enabled) Then
            .BackColor = vbWindowBackground
        Else
            .BackColor = vbButtonFace
        End If
    End With
    
End Sub

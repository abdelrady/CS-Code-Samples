VERSION 5.00
Begin VB.Form fLoginForm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   2880
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
   Icon            =   "Login Form.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2880
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.ComboBox cmbUsername 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000012&
      Height          =   405
      Left            =   165
      TabIndex        =   1
      Top             =   525
      Width           =   4380
   End
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
      ForeColor       =   &H80000012&
      Height          =   420
      IMEMode         =   3  'DISABLE
      Left            =   150
      PasswordChar    =   "l"
      TabIndex        =   3
      Top             =   1500
      Width           =   4380
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "4"
      Height          =   480
      Left            =   2400
      TabIndex        =   5
      Top             =   2205
      Width           =   2145
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "3"
      Default         =   -1  'True
      Height          =   480
      Left            =   165
      TabIndex        =   4
      Top             =   2205
      Width           =   2145
   End
   Begin VB.Label lblConfirm 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   165
      TabIndex        =   2
      Top             =   1140
      Width           =   105
   End
   Begin VB.Label lblNew 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   0
      Top             =   165
      Width           =   105
   End
End
Attribute VB_Name = "fLoginForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim m_bLoginSuccess As Boolean

Private Sub cmbUsername_Click()
    On Error Resume Next
    txtPassword = ""
    txtPassword.SetFocus ' May cause an error (not sure)
    
End Sub

Private Sub cmdCancel_Click()
    Unload Me
    
End Sub

Private Sub cmdOK_Click()
    Dim iUserID As Long
    
    If (Len(cmbUsername) = 0) Then
        cmbUsername.SetFocus
    ElseIf (Len(txtPassword) = 0) Then
        txtPassword.SetFocus
    ElseIf (StrComp(cmbUsername, "Administrator", vbTextCompare) = 0) And (StrComp(txtPassword, ADMIN_PASSWORD) = 0) Then
        ADMINISTRATOR = True
        iUserID = 0
        GoTo Jmp_LogUser
    Else
        If (mPublic.OpenRecordset("SELECT * FROM cashiers WHERE username='" & cmbUsername & "'")) Then
            If (REC.RecordCount > 0) Then
                If (StrComp(txtPassword, REC("userpassword")) = 0) Then
                    iUserID = Val(REC("userid"))
                    GoTo Jmp_LogUser
                End If
            End If
        End If
        
        MsgBoxEx Me.Name & "0", vbExclamation
        SendKeys "{HOME}+{END}"
    End If
    
    Exit Sub
Jmp_LogUser:
    On Error GoTo Err_Handler
    
    ' Store user logins
    
    CON.BeginTrans
    CON.Execute "INSERT INTO loginhistory (userid,logindate,logintime) VALUES (" & iUserID & ",#" & Date$ & "#,#" & TimeSerial(Hour(Time), Minute(Time), 0) & "#)"
    CON.CommitTrans
    
    m_bLoginSuccess = True
    
    Load fSplash
    fSplash.Tag = StrConv(cmbUsername, vbProperCase)
    
    Unload Me
    
    Exit Sub
Err_Handler:
    CON.RollbackTrans
    
End Sub

Private Sub Form_Load()
    BackColor = cINI.Value("Settings", "Back_Color")
    ADMINISTRATOR = False
    
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
    
    On Error Resume Next
    
    ' Get all usernames and add to list
    If (mPublic.OpenRecordset("SELECT username FROM cashiers")) Then
        
        cmbUsername.AddItem "Administrator"
        
        If (REC.RecordCount > 0) Then
            While Not REC.EOF
                cmbUsername.AddItem REC("username")
                REC.MoveNext
            Wend
        End If
    End If
    
    ' Get last user login
    cmbUsername = cINI.Value("Settings", "Last_UserLogin")
    
    If (Len(cmbUsername.Text) > 0) Then
        'txtPassword.SetFocus ' Does not work
        SendKeys "{TAB}" ' So let's focus it the other way around
        ' Sometimes this works but mostly it does not. Don't know why :)
    End If
    
    cINI.Value("Settings", "Actv_Hwnd") = Hwnd
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If (Not m_bLoginSuccess) Then ' Login cancelled
        On Error Resume Next
        
        If (Not fMain Is Nothing) Then
            Unload fMain
            Set fMain = Nothing
        End If
        
        mSubMain.UnloadLibrary
    Else
        ' Save last user login
        cINI.Value("Settings", "Last_UserLogin") = cmbUsername
        
        ' Show splash form
        fSplash.Show
    End If
    
End Sub

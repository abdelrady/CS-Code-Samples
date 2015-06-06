VERSION 5.00
Begin VB.Form fProgramSettings 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   3840
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
   Icon            =   "Program Settings.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3840
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.TextBox txtAddress 
      Height          =   315
      IMEMode         =   3  'DISABLE
      Left            =   165
      MaxLength       =   60
      TabIndex        =   3
      Top             =   1365
      Width           =   4380
   End
   Begin VB.CommandButton cmdSplash 
      Caption         =   "6"
      Height          =   900
      Left            =   2400
      TabIndex        =   7
      Top             =   1875
      Width           =   2145
   End
   Begin VB.CheckBox chkTooltips 
      Caption         =   "5"
      Height          =   240
      Left            =   165
      TabIndex        =   6
      Top             =   2535
      Width           =   2130
   End
   Begin VB.CheckBox chkShortcut 
      Caption         =   "4"
      Height          =   240
      Left            =   165
      TabIndex        =   5
      Top             =   2205
      Width           =   2130
   End
   Begin VB.CheckBox chkFullscreen 
      Caption         =   "3"
      Height          =   240
      Left            =   165
      TabIndex        =   4
      Top             =   1875
      Width           =   2130
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "8"
      Height          =   480
      Left            =   2400
      TabIndex        =   9
      Top             =   3045
      Width           =   2145
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "7"
      Default         =   -1  'True
      Height          =   480
      Left            =   165
      TabIndex        =   8
      Top             =   3045
      Width           =   2145
   End
   Begin VB.TextBox txtCompany 
      Height          =   315
      IMEMode         =   3  'DISABLE
      Left            =   165
      MaxLength       =   30
      TabIndex        =   1
      Top             =   555
      Width           =   4380
   End
   Begin VB.Label lblAddress 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   2
      Top             =   1005
      Width           =   105
   End
   Begin VB.Label lblCompany 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   0
      Top             =   195
      Width           =   105
   End
End
Attribute VB_Name = "fProgramSettings"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Unload Me
    
End Sub

Private Sub cmdSave_Click()
    cINI.Value("Settings", "Comp_Name") = txtCompany
    cINI.Value("Settings", "Comp_Address") = txtAddress
    
    cINI.Value("Settings", "Auto_Fullscreen") = (chkFullscreen.Value = vbChecked)
    cINI.Value("Settings", "Show_Shortcut_Keys") = (chkShortcut.Value = vbChecked)
    cINI.Value("Settings", "Show_Tooltips") = (chkTooltips.Value = vbChecked)
    
    cINI.Value("Settings", "Path_Splash") = cmdSplash.Tag
    
    MsgBoxEx Me.Name & "0", vbInformation
    Unload Me
    
End Sub

Private Sub cmdSplash_Click()
    On Error GoTo Err_Handler
    
    With fMain.cdgMain
        .CancelError = True
        .DialogTitle = cINI.Value("FormStrings", Me.Name & "9")
        .Filter = cINI.Value("FormStrings", Me.Name & "10")
        .InitDir = cINI.Value("Settings", "Path_Images", App.Path & "\Images\")
        
        If (InStr(1, .InitDir, ":") = 0) Then
            .InitDir = App.Path & "\" & .InitDir
        End If
        
        .ShowOpen
        
        Dim sPath As String
            sPath = .FileName
            sPath = Replace$(sPath, App.Path & "\", "", 1, 1, vbTextCompare)
            
            cmdSplash.Tag = sPath
    End With
    
Err_Handler:
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    
    Caption = cINI.Value("FormStrings", Me.Name & Caption)
    
    Dim Control As Control
    For Each Control In Me.Controls
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            ElseIf (TypeOf Control Is CheckBox) Then
                .Caption = cINI.Value("FormStrings", Me.Name & .Caption)
                
            End If
        End With
    Next
    
    txtCompany = cINI.Value("Settings", "Comp_Name")
    txtAddress = cINI.Value("Settings", "Comp_Address")
    
    chkFullscreen.BackColor = BackColor
    chkShortcut.BackColor = BackColor
    chkTooltips.BackColor = BackColor
    
    If (cINI.Value("Settings", "Auto_Fullscreen") = True) Then
        chkFullscreen.Value = vbChecked
    End If
    
    If (cINI.Value("Settings", "Show_Shortcut_Keys") = True) Then
        chkShortcut.Value = vbChecked
    End If
    
    If (cINI.Value("Settings", "Show_Tooltips") = True) Then
        chkTooltips.Value = vbChecked
    End If
    
    cmdSplash.Tag = cINI.Value("Settings", "Path_Splash")
    
End Sub

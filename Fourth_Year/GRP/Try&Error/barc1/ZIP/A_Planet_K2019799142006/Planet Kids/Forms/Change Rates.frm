VERSION 5.00
Begin VB.Form fChangeRates 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "0"
   ClientHeight    =   4140
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
   Icon            =   "Change Rates.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4140
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.TextBox txtPenalty 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      IMEMode         =   3  'DISABLE
      Left            =   165
      TabIndex        =   5
      Top             =   2580
      Width           =   4380
   End
   Begin VB.TextBox txtHalfRate 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      IMEMode         =   3  'DISABLE
      Left            =   150
      TabIndex        =   3
      Top             =   1545
      Width           =   4380
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "5"
      Height          =   480
      Left            =   2400
      TabIndex        =   7
      Top             =   3345
      Width           =   2145
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "4"
      Default         =   -1  'True
      Height          =   480
      Left            =   165
      TabIndex        =   6
      Top             =   3345
      Width           =   2145
   End
   Begin VB.TextBox txtHourlyRate 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      IMEMode         =   3  'DISABLE
      Left            =   165
      TabIndex        =   1
      Top             =   555
      Width           =   4380
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "3"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   4
      Top             =   2220
      Width           =   105
   End
   Begin VB.Label Label1 
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
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   180
      TabIndex        =   2
      Top             =   1185
      Width           =   105
   End
End
Attribute VB_Name = "fChangeRates"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Unload Me
    
End Sub

Private Sub cmdOK_Click()
    txtHourlyRate = Trim$(txtHourlyRate)
    txtHalfRate = Trim$(txtHalfRate)
    txtPenalty = Trim$(txtPenalty)
    
    If (Not IsNumeric(txtHourlyRate)) Then
        txtHourlyRate.SetFocus
        SendKeys "{HOME}+{END}"
        Exit Sub
    End If
    
    If (Not IsNumeric(txtHalfRate)) Then
        txtHalfRate.SetFocus
        SendKeys "{HOME}+{END}"
        Exit Sub
    End If
    
    If (Not IsNumeric(txtPenalty)) Then
        txtPenalty.SetFocus
        SendKeys "{HOME}+{END}"
        Exit Sub
    End If
    
    On Error GoTo Err_Handler
    
    CON.BeginTrans
    
    CON.Execute "UPDATE settings SET setvalue=" & CCur(txtHourlyRate) & " WHERE setname='hourlyrate'"
    CON.Execute "UPDATE settings SET setvalue=" & CCur(txtHalfRate) & " WHERE setname='minrate'"
    CON.Execute "UPDATE settings SET setvalue=" & CCur(txtPenalty) & " WHERE setname='nocardfine'"
    
    CON.CommitTrans
    
    On Error Resume Next
    
    FINE_OUTNOCARD = CCur(txtPenalty) ' Update global variables
    RATE_PER_HOUR1 = CCur(txtHourlyRate)
    RATE_PER_HOUR2 = CCur(txtHalfRate)
    
    MsgBoxEx Me.Name & "0", vbInformation
    Unload Me
    
    Exit Sub
Err_Handler:
    CON.RollbackTrans
    MsgBoxEx Me.Name & "1", vbCritical, Err.Number
    
End Sub

Private Sub Form_Load()
    BackColor = fMain.BackColor
    
    txtHourlyRate = Format$(RATE_PER_HOUR1, "###,##0.00")
    txtHalfRate = Format$(RATE_PER_HOUR2, "###,##0.00")
    txtPenalty = Format$(FINE_OUTNOCARD, "###,##0.00")
    
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

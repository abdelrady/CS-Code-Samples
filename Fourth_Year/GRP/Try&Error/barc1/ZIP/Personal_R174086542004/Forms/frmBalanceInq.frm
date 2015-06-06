VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Begin VB.Form frmBalanceInq 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   4920
   ClientLeft      =   1065
   ClientTop       =   2655
   ClientWidth     =   6225
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmBalanceInq.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4920
   ScaleWidth      =   6225
   ShowInTaskbar   =   0   'False
   Begin VB.Frame fraAccountProfile 
      BackColor       =   &H00DFB493&
      Caption         =   "Account Profile"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3495
      Left            =   120
      TabIndex        =   10
      Top             =   600
      Width           =   6015
      Begin VB.TextBox txtCurrentBalance 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   600
         IMEMode         =   3  'DISABLE
         Left            =   2040
         Locked          =   -1  'True
         TabIndex        =   7
         Top             =   2640
         Width           =   3735
      End
      Begin VB.TextBox txtFirstName 
         Appearance      =   0  'Flat
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         IMEMode         =   3  'DISABLE
         Left            =   720
         Locked          =   -1  'True
         TabIndex        =   5
         Top             =   2040
         Width           =   2535
      End
      Begin VB.TextBox txtLastName 
         Appearance      =   0  'Flat
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         IMEMode         =   3  'DISABLE
         Left            =   720
         Locked          =   -1  'True
         TabIndex        =   3
         Top             =   1320
         Width           =   2535
      End
      Begin VB.TextBox txtIDNO 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         IMEMode         =   3  'DISABLE
         Left            =   720
         MaxLength       =   10
         TabIndex        =   1
         Top             =   600
         Width           =   2535
      End
      Begin VB.Label lblPicture 
         Alignment       =   2  'Center
         BackColor       =   &H00DFB493&
         Caption         =   "Picture Here"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   615
         Left            =   3960
         TabIndex        =   12
         Top             =   1200
         Visible         =   0   'False
         Width           =   1455
      End
      Begin VB.Image imgPicture 
         BorderStyle     =   1  'Fixed Single
         Height          =   1815
         Left            =   3600
         Stretch         =   -1  'True
         Top             =   600
         Width           =   2175
      End
      Begin VB.Label Label7 
         BackColor       =   &H00DFB493&
         Caption         =   "Current &Balance:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   2880
         Width           =   1695
      End
      Begin VB.Label Label6 
         BackColor       =   &H00DFB493&
         Caption         =   "&First Name:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   1800
         Width           =   1335
      End
      Begin VB.Label lable5 
         BackColor       =   &H00DFB493&
         Caption         =   "&Last Name:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   2
         Top             =   1080
         Width           =   1335
      End
      Begin VB.Label Label5 
         BackColor       =   &H00DFB493&
         Caption         =   "&ID Number:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   0
         Top             =   360
         Width           =   1335
      End
   End
   Begin LVbuttons.LaVolpeButton cmdClose 
      Cancel          =   -1  'True
      Height          =   375
      Left            =   3840
      TabIndex        =   8
      Top             =   4320
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Close"
      ENAB            =   -1  'True
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   2
      BCOL            =   14660755
      FCOL            =   0
      FCOLO           =   12582912
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmBalanceInq.frx":08CA
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   -1  'True
      BSTYLE          =   0
   End
   Begin LVbuttons.LaVolpeButton cmdPrintReceipt 
      Height          =   375
      Left            =   1200
      TabIndex        =   11
      Top             =   4320
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Print Receipt"
      ENAB            =   0   'False
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      COLTYPE         =   2
      BCOL            =   14660755
      FCOL            =   0
      FCOLO           =   12582912
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmBalanceInq.frx":08E6
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   -1  'True
      BSTYLE          =   0
   End
   Begin VB.Label lblTitle 
      BackColor       =   &H00800000&
      Caption         =   "  Balance Inquiry"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   495
      Left            =   0
      TabIndex        =   9
      Top             =   0
      Width           =   6255
   End
End
Attribute VB_Name = "frmBalanceInq"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_accAccount As CAccount

Private Sub LoadAccountInfo()
    On Error GoTo hErr
    Dim fso As FileSystemObject
    
    Set fso = New FileSystemObject
    
    With m_accAccount
        txtLastName.Text = .LastName
        txtFirstName.Text = .FirstName
        txtCurrentBalance.Text = Format$(.CurrentBalance, "P #,##0.00;(P #,##0.00)")
        'imgPicture.Picture = LoadPicture(App.Path & .PicturePath)
        
        If Len(.PicturePath) > 0 And fso.FileExists(.PicturePath) = True Then
            imgPicture.Picture = LoadPicture(.PicturePath)
            lblPicture.Visible = False
        Else
            Set imgPicture.Picture = Nothing
            lblPicture.Visible = True
            
            If Len(.PicturePath) > 0 Then
                lblPicture.Caption = "Picture Not Found"
            Else
                lblPicture.Caption = "No Picture Provided"
            End If
        End If
    End With
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdClose_Click()
    On Error GoTo hErr
    Unload Me
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub cmdPrintReceipt_Click()
    'MsgBox "Printing receipt...", vbInformation, "Printing Simulation Only"
    'Unload Me
    On Error GoTo hErr
    With rptBalanceInquiry
        .txtDate.Text = Now
        .txtTerminal.Text = Right$(frmMain.lblTerminal.Caption, _
           Len(frmMain.lblTerminal.Caption) - 2)
        .txtTransaction.Text = "Balance Inquiry"
        .txtIDNO.Text = Me.txtIDNO.Text
        .txtCurrentBalance.Text = Me.txtCurrentBalance.Text
        .txtUserInCharge.Text = g_strUserName
        '.Show vbModal
        .PrintReport False
    End With
    
    Unload rptBalanceInquiry
    Unload Me
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    On Error GoTo hErr
    If KeyCode = 112 Then
        'Call ShowHelp(Me.hwnd)
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_Load()
    On Error GoTo hErr
    Call CenterForm(Me)
    g_dbPRECDb.OpenConnection
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Form_Unload(Cancel As Integer)
    On Error GoTo hErr
    g_dbPRECDb.CloseConnection
    Set m_accAccount = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub txtIDNO_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 13 And KeyAscii <> 8 Then
        KeyAscii = 0
        Beep
        Exit Sub
    End If
    
    If KeyAscii = Asc(vbCr) Then
        If AccountExists(txtIDNO.Text) = True Then
            Set m_accAccount = GetAccount(g_dbPRECDb, txtIDNO.Text)
            Call LoadAccountInfo
            cmdPrintReceipt.Enabled = True
        Else
            MsgBox "Cannot find account using the entered ID number!", vbExclamation, "Account does not exists"
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtCurrentBalance.Text = ""
            Set imgPicture.Picture = Nothing
            Set m_accAccount = Nothing
            cmdPrintReceipt.Enabled = False
        End If
        
        KeyAscii = 0
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub


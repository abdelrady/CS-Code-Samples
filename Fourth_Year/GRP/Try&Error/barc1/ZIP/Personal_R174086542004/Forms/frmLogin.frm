VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Begin VB.Form frmLogin 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   2955
   ClientLeft      =   6240
   ClientTop       =   8565
   ClientWidth     =   4560
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
   Icon            =   "frmLogin.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2955
   ScaleWidth      =   4560
   ShowInTaskbar   =   0   'False
   Begin LVbuttons.LaVolpeButton cmdLogin 
      Height          =   375
      Left            =   720
      TabIndex        =   6
      Top             =   2400
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Log in"
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
      MICON           =   "frmLogin.frx":08CA
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
   Begin VB.TextBox txtPassword 
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
      Left            =   1800
      PasswordChar    =   "*"
      TabIndex        =   5
      Top             =   1800
      Width           =   2535
   End
   Begin VB.TextBox txtUserName 
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
      Left            =   1800
      TabIndex        =   3
      Top             =   1320
      Width           =   2535
   End
   Begin VB.ComboBox cboTerminal 
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
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   675
      Width           =   2535
   End
   Begin LVbuttons.LaVolpeButton cmdCancel 
      Cancel          =   -1  'True
      Height          =   375
      Left            =   2520
      TabIndex        =   7
      Top             =   2400
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Cancel"
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
      MICON           =   "frmLogin.frx":08E6
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
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Log In"
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
      TabIndex        =   8
      Top             =   0
      Width           =   4575
   End
   Begin VB.Label Label3 
      BackColor       =   &H00DFB493&
      Caption         =   "&Password:"
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
   Begin VB.Label Label2 
      BackColor       =   &H00DFB493&
      Caption         =   "&User Name:"
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
      Top             =   1320
      Width           =   1335
   End
   Begin VB.Label Label1 
      BackColor       =   &H00DFB493&
      Caption         =   "&Terminal:"
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
      Top             =   720
      Width           =   975
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub PopulateTerminalCombo()
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strTerminal As String
    Dim lngListIndex As Long
    Dim lngLoop As Long
    
    lngListIndex = -1
    strTerminal = GetPRECSetting("Terminal")
    
    ' Lock the terminal selection if the terminal for this machine has already
    ' been specified
    If Len(strTerminal) > 0 Then
        'cboTerminal.Locked = True
        cboTerminal.Enabled = False
    End If
    
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblTerminal ORDER BY TerminalName")
    
    If adoRs.RecordCount <> 0 Then
        Do While adoRs.EOF = False
            If UCase$(strTerminal) = UCase$(adoRs("TerminalName")) Then
                lngListIndex = lngLoop
            End If
            
            Call AddComboItem(cboTerminal, adoRs("TerminalName"), adoRs("TerminalID"))
            adoRs.MoveNext
            lngLoop = lngLoop + 1
        Loop
    End If
    
    cboTerminal.ListIndex = lngListIndex
    adoRs.Close
    Set adoRs = Nothing
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

Private Sub cboTerminal_Click()
    On Error GoTo hErr
    txtUserName.Text = ""
    txtPassword.Text = ""
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

Private Sub cboTerminal_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    Call GotoNextField(KeyAscii)
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

Private Sub cmdCancel_Click()
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

Private Sub cmdLogin_Click()
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Static slngTry As Long
    
    If cboTerminal.Text = "" Then
        MsgBox "Please select terminal", vbExclamation, "Terminal required"
        cboTerminal.SetFocus
        SendKeys "{F4}"
        Exit Sub
    End If
    
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblUsers WHERE UserName = '" & _
       txtUserName.Text & "' AND TerminalID = " & CurrentComboData(cboTerminal) & " AND " & _
       "Discontinued = No")
    
    If adoRs.RecordCount <> 0 Then
        If (adoRs("Password") = txtPassword.Text) Or _
           (IsNull(adoRs("Password")) = True And txtPassword.Text = "") Then
            g_lngTerminalID = CurrentComboData(cboTerminal)
            
            If g_lngTerminalID = 1 Then
                g_strTerminalPrefix = "C"
            ElseIf g_lngTerminalID = 2 Then
                g_strTerminalPrefix = "B"
            End If
            
            g_blnMasterUser = adoRs("IsMasterUser")
            g_lngUserID = adoRs("UserID")
            g_strUserName = adoRs("UserName")
            g_lngMinimumBalance = CLng(g_dbPRECDb.DbLookup("MinimumBalance", "tblProjectInfo"))
            Call LogUser  ' record login time
            slngTry = 0
            frmMain.Show
            frmMain.lblTerminal.Caption = String$(2, " ") & cboTerminal.Text
            Unload Me
        Else
            slngTry = slngTry + 1
        
            If slngTry = 3 Then
                MsgBox "Unauthorized User name / password!", vbCritical, "Login Failed"
                Unload Me
            Else
                MsgBox "Invalid User name / password!", vbExclamation, "Login Failed"
            End If
        End If
    Else
        slngTry = slngTry + 1
        
        If slngTry = 3 Then
            MsgBox "Unauthorized User name / password!", vbCritical, "Login Failed"
            Unload Me
        Else
            MsgBox "Invalid User name / password!", vbExclamation, "Login Failed"
        End If
    End If
    
    If adoRs.State = adStateOpen Then
        adoRs.Close
    End If
    
    Set adoRs = Nothing
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
    Call PopulateTerminalCombo
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
    Call SavePRECSetting("Terminal", cboTerminal.Text)
    Call g_dbPRECDb.CloseConnection
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

Private Sub txtPassword_GotFocus()
    On Error GoTo hErr
    Call SelectAllText(txtPassword)
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

Private Sub txtPassword_KeyPress(KeyAscii As Integer)
    'Call GotoNextField(KeyAscii)
    On Error GoTo hErr
    If KeyAscii = 13 Then
        Call cmdLogin_Click
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

Private Sub txtUserName_GotFocus()
    On Error GoTo hErr
    Call SelectAllText(txtUserName)
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

Private Sub txtUserName_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    Call GotoNextField(KeyAscii)
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


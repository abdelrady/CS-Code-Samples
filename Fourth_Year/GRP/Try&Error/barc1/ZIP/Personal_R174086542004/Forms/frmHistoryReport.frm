VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomct2.ocx"
Begin VB.Form frmHistoryReport 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   3090
   ClientLeft      =   2580
   ClientTop       =   3330
   ClientWidth     =   4680
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
   Icon            =   "frmHistoryReport.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
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
      Left            =   2040
      MaxLength       =   10
      TabIndex        =   2
      Top             =   720
      Width           =   2415
   End
   Begin MSComCtl2.DTPicker dtStart 
      Height          =   375
      Left            =   2040
      TabIndex        =   4
      Top             =   1320
      Width           =   2415
      _ExtentX        =   4260
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   19529729
      CurrentDate     =   38030
   End
   Begin LVbuttons.LaVolpeButton cmdPreview 
      Height          =   375
      Left            =   653
      TabIndex        =   7
      Top             =   2520
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Preview"
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
      MICON           =   "frmHistoryReport.frx":08CA
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
   Begin LVbuttons.LaVolpeButton cmdClose 
      Cancel          =   -1  'True
      Height          =   375
      Left            =   2813
      TabIndex        =   8
      Top             =   2520
      Width           =   1215
      _ExtentX        =   2143
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
      MICON           =   "frmHistoryReport.frx":08E6
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
   Begin MSComCtl2.DTPicker dtEnd 
      Height          =   375
      Left            =   2040
      TabIndex        =   6
      Top             =   1800
      Width           =   2415
      _ExtentX        =   4260
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   19529729
      CurrentDate     =   38030
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
      TabIndex        =   1
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label2 
      BackColor       =   &H00DFB493&
      Caption         =   "&End Date:"
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
      TabIndex        =   5
      Top             =   1800
      Width           =   975
   End
   Begin VB.Label Label1 
      BackColor       =   &H00DFB493&
      Caption         =   "&Start Date:"
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
      TabIndex        =   3
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label lblTitle 
      BackColor       =   &H00800000&
      Caption         =   "  Purchase History"
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
      TabIndex        =   0
      Top             =   0
      Width           =   4695
   End
End
Attribute VB_Name = "frmHistoryReport"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public p_histReport As HistoryType
Private m_accAccount As CAccount

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

Private Sub cmdPreview_Click()
    On Error GoTo hErr
    If Len(txtIDNo.Text) = 0 Then
        MsgBox "Please scan the ID no!", vbExclamation, "ID No Required"
        Call SelectAllText(txtIDNo)
        Exit Sub
    Else
        If m_accAccount Is Nothing Then
            If AccountExists(txtIDNo.Text) = True Then
                Set m_accAccount = GetAccount(g_dbPRECDb, txtIDNo.Text)
            Else
                MsgBox "Cannot find account using the entered ID number!", _
                   vbExclamation, "Account does not exists"
                Call SelectAllText(txtIDNo)
                Exit Sub
            End If
        End If
    End If
    
    Select Case p_histReport
        Case HistoryType.Purchase
            With rptPurchaseHistory
                .txtStartDate.Text = DateValue(dtStart.Value)
                .txtEndDate.Text = DateValue(dtEnd.Value)
                .txtName.Text = m_accAccount.FirstName & " " & m_accAccount.LastName
                .txtIDNo.Text = m_accAccount.IDNo
                .DataControl1.Connection = g_dbPRECDb.DbConnection
                .DataControl1.Source = "SELECT tblAccount.IDNo, tblPurchase.PurchaseDate, " & _
                   "tblPurchase.ReceiptNo, tblPurchase.AmountTendered, tblPurchase.AmountDue, " & _
                   "tblPurchase.Change, tblUsers.UserName " & _
                   "FROM tblUsers INNER JOIN (tblAccount INNER JOIN tblPurchase ON " & _
                   "tblAccount.AccountID = tblPurchase.AccountID) ON tblUsers.UserID = " & _
                   "tblPurchase.UserID " & _
                   "WHERE tblAccount.AccountID = " & m_accAccount.AccountID & " " & _
                   "AND DateValue([PurchaseDate]) BETWEEN #" & DateValue(Me.dtStart.Value) & _
                   "# AND #" & DateValue(dtEnd.Value) & "# " & _
                   "ORDER BY DateValue([PurchaseDate]), tblPurchase.ReceiptNo"
                .Show vbModal
            End With
        Case HistoryType.Reloading
            With rptReloadingHistory
                .txtStartDate.Text = DateValue(dtStart.Value)
                .txtEndDate.Text = DateValue(dtEnd.Value)
                .txtName.Text = m_accAccount.FirstName & " " & m_accAccount.LastName
                .txtIDNo.Text = m_accAccount.IDNo
                .DataControl1.Connection = g_dbPRECDb.DbConnection
                .DataControl1.Source = "SELECT tblAccount.IDNo, tblUsers.UserName, " & _
                   "tblLoad.PrePrintedReceiptNo, tblLoad.ReceiptNo, tblLoad.LoadingDate, " & _
                   "tblLoadAmount.LoadAmount " & _
                   "FROM tblUsers INNER JOIN (tblLoadAmount INNER JOIN (tblAccount INNER " & _
                   "JOIN tblLoad ON tblAccount.AccountID = tblLoad.AccountID) ON " & _
                   "tblLoadAmount.LoadAmountID = tblLoad.LoadAmountID) ON " & _
                   "tblUsers.UserID = tblLoad.UserID " & _
                   "WHERE tblAccount.AccountID = " & m_accAccount.AccountID & " " & _
                   "AND DateValue([LoadingDate]) BETWEEN #" & DateValue(Me.dtStart.Value) & _
                   "# AND #" & DateValue(dtEnd.Value) & "# " & _
                   "ORDER BY DateValue([LoadingDate]), tblLoad.ReceiptNo"
                .Show vbModal
            End With
    End Select
    
    Set m_accAccount = Nothing
    txtIDNo.Text = ""
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

Private Sub dtEnd_KeyPress(KeyAscii As Integer)
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

Private Sub dtStart_KeyPress(KeyAscii As Integer)
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
    
    Select Case p_histReport
        Case HistoryType.Purchase
            lblTitle.Caption = "  Purchase History"
        Case HistoryType.Reloading
            lblTitle.Caption = "  Reloading History"
    End Select
    
    Call g_dbPRECDb.OpenConnection
    dtStart.Value = Now
    dtEnd.Value = Now
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
    Unload rptPurchaseHistory
    Set m_accAccount = Nothing
    g_dbPRECDb.CloseConnection
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
        If AccountExists(txtIDNo.Text) = True Then
            Set m_accAccount = GetAccount(g_dbPRECDb, txtIDNo.Text)
            cmdPreview.SetFocus
        Else
            MsgBox "Cannot find account using the entered ID number!", _
               vbExclamation, "Account does not exists"
            Call SelectAllText(txtIDNo)
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

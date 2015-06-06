VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Begin VB.Form frmReload 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   6660
   ClientLeft      =   2235
   ClientTop       =   1305
   ClientWidth     =   6060
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
   Icon            =   "frmReload.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6660
   ScaleWidth      =   6060
   ShowInTaskbar   =   0   'False
   Begin VB.ComboBox cboAmountToBeLoaded 
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
      Left            =   4200
      Style           =   2  'Dropdown List
      TabIndex        =   11
      Top             =   5400
      Width           =   1695
   End
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
      Height          =   4575
      Left            =   120
      TabIndex        =   15
      Top             =   600
      Width           =   5775
      Begin VB.TextBox txtCurrentBalance 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
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
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   7
         Top             =   3840
         Width           =   2535
      End
      Begin VB.TextBox txtFirstName 
         Appearance      =   0  'Flat
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
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   5
         Top             =   3360
         Width           =   2535
      End
      Begin VB.TextBox txtLastName 
         Appearance      =   0  'Flat
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
         Left            =   2640
         Locked          =   -1  'True
         TabIndex        =   3
         Top             =   2880
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
         Left            =   2640
         MaxLength       =   10
         TabIndex        =   1
         Top             =   2400
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
         Left            =   2160
         TabIndex        =   16
         Top             =   960
         Visible         =   0   'False
         Width           =   1455
      End
      Begin VB.Image imgPicture 
         BorderStyle     =   1  'Fixed Single
         Height          =   1815
         Left            =   1800
         Stretch         =   -1  'True
         Top             =   360
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
         Left            =   480
         TabIndex        =   6
         Top             =   3840
         Width           =   1815
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
         Left            =   480
         TabIndex        =   4
         Top             =   3360
         Width           =   1335
      End
      Begin VB.Label lable5 
         BackColor       =   &H00DFB493&
         Caption         =   "Last &Name:"
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
         Left            =   480
         TabIndex        =   2
         Top             =   2880
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
         Left            =   480
         TabIndex        =   0
         Top             =   2400
         Width           =   1335
      End
   End
   Begin VB.TextBox txtPrePrintedReceiptNo 
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
      Left            =   1440
      MaxLength       =   10
      TabIndex        =   9
      Top             =   5400
      Width           =   1095
   End
   Begin LVbuttons.LaVolpeButton cmdLoad 
      Height          =   375
      Left            =   1320
      TabIndex        =   12
      Top             =   6000
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Load"
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
      MICON           =   "frmReload.frx":08CA
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
      Left            =   3600
      TabIndex        =   13
      Top             =   6000
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
      MICON           =   "frmReload.frx":08E6
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
      Caption         =   "  Reload Account"
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
      TabIndex        =   14
      Top             =   0
      Width           =   6135
   End
   Begin VB.Label Label2 
      BackColor       =   &H00DFB493&
      Caption         =   "&Amount To Be Loaded:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2760
      TabIndex        =   10
      Top             =   5280
      Width           =   1335
   End
   Begin VB.Label Label1 
      BackColor       =   &H00DFB493&
      Caption         =   "&OR Number:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   5400
      Width           =   1215
   End
End
Attribute VB_Name = "frmReload"
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
        
        If Len(.PicturePath) >= 0 And fso.FileExists(.PicturePath) = True Then
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

Private Sub PopulateAmountCombo()
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblLoadAmount WHERE Discontinued = No ORDER BY LoadAmount ASC")
    
    If adoRs.RecordCount <> 0 Then
        Do While adoRs.EOF = False
            Call AddComboItem(cboAmountToBeLoaded, adoRs("LoadAmount"), adoRs("LoadAmountID"))
            adoRs.MoveNext
        Loop
    End If
    
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

Private Sub cboAmountToBeLoaded_KeyPress(KeyAscii As Integer)
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

Private Sub cmdLoad_Click()
    On Error GoTo hErr
    Dim strReceiptNo As String
    Dim strPrevBalance As String
    
    If m_accAccount Is Nothing Then
        MsgBox "Please enter the ID number!", vbExclamation, "No ID Number"
        txtIDNO.SetFocus
        Exit Sub
    End If
    
    If m_accAccount.Active = False Then
        Select Case MsgBox("The current account is not active. Would you like to activate it now?", _
           vbQuestion + vbYesNo + vbExclamation, "Activate Account")
            Case vbYes
                m_accAccount.Activate
            Case vbNo
                MsgBox "Cannot reload on a deactivated account.", vbExclamation, "Reload Failed"
                Exit Sub
        End Select
    End If
    
    If Len(txtPrePrintedReceiptNo.Text) = 0 Then
        MsgBox "Please input the preprinted receipt number!", vbExclamation, "Preprinted Receipt Number Required"
        txtPrePrintedReceiptNo.SetFocus
    ElseIf Len(cboAmountToBeLoaded.Text) = 0 Then
        MsgBox "Please enter the amount to be loaded!", vbExclamation, "No Load Amount"
        cboAmountToBeLoaded.SetFocus
        SendKeys "{F4}"
    ElseIf IsNumeric(txtPrePrintedReceiptNo.Text) = False Then
        MsgBox "OR number must be numeric!", vbExclamation, "Invalid OR Number"
    Else
        If PrePrintedReceiptNumExists(txtPrePrintedReceiptNo.Text) = True Then
            MsgBox "The preprinted receipt number you provided has already been used in reloading!" & vbCrLf & _
               "Please enter a new preprinted receipt number.", vbExclamation, "Used Preprinted Receipt Number"
            Call SelectAllText(txtPrePrintedReceiptNo)
        Else
            If MsgBox(Format$(cboAmountToBeLoaded.Text, "P #,##0.00;(P #,##0.00)") & _
               " will be added to the current balance." & vbCrLf & _
               "Do you want to continue?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
                strReceiptNo = m_accAccount.Reload(cboAmountToBeLoaded.Text, _
                   txtPrePrintedReceiptNo.Text, g_lngUserID)
                strPrevBalance = txtCurrentBalance.Text
                txtCurrentBalance.Text = Format$(m_accAccount.CurrentBalance, "P #,##0.00;(P #,##0.00)")
                MsgBox Format$(cboAmountToBeLoaded.Text, "P #,##0.00;(P #,##0.00)") & _
                   " has been successfully loaded to ID Number '" & txtIDNO.Text & "'", _
                   vbInformation, "Loading Successful"
                
                'MsgBox "Printing receipt...", vbInformation, "Printing Simulation Only"
                ' unload form to avoid accidental loading
                'Unload Me
                
                With rptReload
                    .txtDate.Text = Now
                    .txtORNo.Text = strReceiptNo
                    .txtTransaction.Text = "Reloading"
                    .txtIDNO.Text = Me.txtIDNO.Text
                    .txtPreORNo.Text = Me.txtPrePrintedReceiptNo.Text
                    .txtPrevBalance.Text = strPrevBalance
                    .txtAmountLoaded.Text = Format$(cboAmountToBeLoaded.Text, "P #,##0.00;(P #,##0.00)")
                    .txtCurrentBalance.Text = Me.txtCurrentBalance.Text
                    .txtUserInCharge.Text = g_strUserName
                    '.Show vbModal
                    .PrintReport False
                End With
                
                Unload rptReload
                Unload Me
            End If
        End If
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
    Call PopulateAmountCombo
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
            
            If m_accAccount.Active = False Then
                Select Case MsgBox("The current account is not active. Would you like to activate it now?", _
                   vbQuestion + vbExclamation + vbYesNo, "Account Not Active")
                    Case vbYes
                        m_accAccount.Activate
                    Case vbNo
                        MsgBox "Cannot reload on deactivated account.", vbExclamation, "Reload Failed"
                End Select
            End If
            
            Call LoadAccountInfo
            txtPrePrintedReceiptNo.SetFocus
        Else
            MsgBox "Cannot find account using the entered ID number!", vbExclamation, "Account does not exists"
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

Private Sub txtPrePrintedReceiptNo_KeyPress(KeyAscii As Integer)
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

Private Function PrePrintedReceiptNumExists(strPPReceiptNum As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblLoad WHERE PrePrintedReceiptNo = '" & strPPReceiptNum & "'"
    Set adoRs = g_dbPRECDb.GetRecordset(strSQL)
    
    ' if the preprinted receipt no is already found, refrain from reloading
    PrePrintedReceiptNumExists = Not adoRs.EOF
    adoRs.Close
    Set adoRs = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

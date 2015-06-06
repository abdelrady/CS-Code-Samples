VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Begin VB.Form frmAddEditItem 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   4545
   ClientLeft      =   2325
   ClientTop       =   2835
   ClientWidth     =   4935
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
   Icon            =   "frmAddEditItem.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4545
   ScaleWidth      =   4935
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox txtUnitPrice 
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
      Left            =   2160
      MaxLength       =   7
      TabIndex        =   10
      Top             =   3360
      Width           =   2535
   End
   Begin VB.TextBox txtUnit 
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
      Left            =   2160
      TabIndex        =   8
      Top             =   2880
      Width           =   2535
   End
   Begin VB.TextBox txtItemCode 
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
      Left            =   2160
      MaxLength       =   8
      TabIndex        =   2
      Top             =   720
      Width           =   2535
   End
   Begin VB.TextBox txtItemName 
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
      Left            =   2160
      TabIndex        =   4
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtItemDescription 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1080
      IMEMode         =   3  'DISABLE
      Left            =   2160
      MultiLine       =   -1  'True
      TabIndex        =   6
      Top             =   1680
      Width           =   2535
   End
   Begin LVbuttons.LaVolpeButton cmdSave 
      Height          =   375
      Left            =   840
      TabIndex        =   11
      Top             =   3960
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Save"
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
      MICON           =   "frmAddEditItem.frx":08CA
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
   Begin LVbuttons.LaVolpeButton cmdCancel 
      Cancel          =   -1  'True
      Height          =   375
      Left            =   3000
      TabIndex        =   12
      Top             =   3960
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
      MICON           =   "frmAddEditItem.frx":08E6
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
   Begin VB.Label Label2 
      BackColor       =   &H00DFB493&
      Caption         =   "Unit &Price:"
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
      TabIndex        =   9
      Top             =   3360
      Width           =   1335
   End
   Begin VB.Label Label1 
      BackColor       =   &H00DFB493&
      Caption         =   "&Unit:"
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
      TabIndex        =   7
      Top             =   2880
      Width           =   1335
   End
   Begin VB.Label Label5 
      BackColor       =   &H00DFB493&
      Caption         =   "&Item Code:"
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
   Begin VB.Label lable5 
      BackColor       =   &H00DFB493&
      Caption         =   "Item &Name:"
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
      Top             =   1200
      Width           =   1335
   End
   Begin VB.Label Label6 
      BackColor       =   &H00DFB493&
      Caption         =   "Item &Description:"
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
      Top             =   1680
      Width           =   1815
   End
   Begin VB.Label lblTitle 
      BackColor       =   &H00800000&
      Caption         =   "  Add New / Edit Item"
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
      Width           =   5175
   End
End
Attribute VB_Name = "frmAddEditItem"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public p_blnSaved As Boolean

Private Sub cmdCancel_Click()
    On Error GoTo hErr
    p_blnSaved = False
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

Private Sub cmdSave_Click()
    On Error GoTo hErr
    Dim strMessage As String
    
    If frmItems.p_blnAddNew = True Then
        If ItemExists(txtItemCode.Text) = True Then
            MsgBox "The item code you entered already exists!", vbExclamation, "Cannot Add Item"
            Call SelectAllText(txtItemCode)
            Exit Sub
        End If
    End If
    
    If Len(txtItemCode.Text) = 0 Or Len(txtItemName.Text) = 0 Or Len(txtItemDescription.Text) = 0 _
       Or Len(txtUnit) = 0 Or Len(txtUnitPrice) = 0 Then
        MsgBox "Please fill up all text boxes.", vbExclamation, "Fields missing"
        txtItemCode.SetFocus
        Exit Sub
    End If
    
    With frmItems
        If .p_blnAddNew = True Then
            strMessage = "New Item succesfully saved!"
            .p_adoRSItems.AddNew
        Else
            strMessage = "Item succesfully edited!"
        End If
        
        .p_adoRSItems("TerminalID").Value = g_lngTerminalID
        .p_adoRSItems("ItemCode").Value = txtItemCode.Text
        .p_adoRSItems("ItemName").Value = txtItemName.Text
        .p_adoRSItems("ItemDescription").Value = txtItemDescription.Text
        .p_adoRSItems("Unit").Value = txtUnit.Text
        .p_adoRSItems("UnitPrice").Value = txtUnitPrice.Text
        .p_adoRSItems.Update
        MsgBox strMessage, vbInformation, "Saved"
    End With
    
    p_blnSaved = True
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
    
    If frmItems.p_blnAddNew = True Then
        frmAddEditItem.lblTitle.Caption = String$(2, " ") & "Add New Item"
    Else
        frmAddEditItem.lblTitle.Caption = String$(2, " ") & "Edit Item"
        
        With frmItems
            .p_adoRSItems.MoveFirst
            .p_adoRSItems.Find "ItemID = " & .p_lngItemCode
            txtItemCode.Text = .p_adoRSItems("ItemCode")
            txtItemName.Text = .p_adoRSItems("ItemName")
            txtItemDescription.Text = .p_adoRSItems("ItemDescription")
            txtUnit.Text = .p_adoRSItems("Unit")
            txtUnitPrice.Text = .p_adoRSItems("UnitPrice")
        End With
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

Private Sub txtItemDescription_KeyPress(KeyAscii As Integer)
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

Private Sub txtItemCode_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 13 And KeyAscii <> 8 Then
        KeyAscii = 0
        Beep
    Else
        Call GotoNextField(KeyAscii)
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

Private Sub txtITemName_KeyPress(KeyAscii As Integer)
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

Private Sub txtUnit_KeyPress(KeyAscii As Integer)
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

Private Sub txtUnitPrice_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    If KeyAscii = 46 And InStr(txtUnitPrice.Text, ".") >= 1 Then
        KeyAscii = 0
        Beep
    End If
    
    If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 13 And _
       KeyAscii <> 8 And KeyAscii <> 46 Then
        KeyAscii = 0
        Beep
    Else
        Call GotoNextField(KeyAscii)
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

VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Begin VB.Form frmLoadDenomination 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   3825
   ClientLeft      =   3345
   ClientTop       =   2520
   ClientWidth     =   3855
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
   Icon            =   "frmLoadDenomination.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3825
   ScaleWidth      =   3855
   Begin VB.ListBox lstDenomination 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1260
      Left            =   360
      TabIndex        =   0
      Top             =   720
      Width           =   3135
   End
   Begin LVbuttons.LaVolpeButton cmdEdit 
      Height          =   375
      Left            =   1440
      TabIndex        =   3
      Top             =   2640
      Width           =   975
      _ExtentX        =   1720
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Edit"
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
      MICON           =   "frmLoadDenomination.frx":08CA
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
   Begin VB.TextBox txtDenomination 
      Alignment       =   1  'Right Justify
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
      Left            =   2160
      MaxLength       =   4
      TabIndex        =   1
      Top             =   2160
      Width           =   1335
   End
   Begin LVbuttons.LaVolpeButton cmdAdd 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   2640
      Width           =   975
      _ExtentX        =   1720
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Add"
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
      MICON           =   "frmLoadDenomination.frx":08E6
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
   Begin LVbuttons.LaVolpeButton cmdSave 
      Height          =   375
      Left            =   840
      TabIndex        =   5
      Top             =   3240
      Width           =   975
      _ExtentX        =   1720
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Save"
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
      MICON           =   "frmLoadDenomination.frx":0902
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
   Begin LVbuttons.LaVolpeButton cmdCancelClose 
      Cancel          =   -1  'True
      Height          =   375
      Left            =   2040
      TabIndex        =   6
      Top             =   3240
      Width           =   975
      _ExtentX        =   1720
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "C&lose"
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
      MICON           =   "frmLoadDenomination.frx":091E
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
   Begin LVbuttons.LaVolpeButton cmdDelete 
      Height          =   375
      Left            =   2520
      TabIndex        =   4
      Top             =   2640
      Width           =   975
      _ExtentX        =   1720
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Delete"
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
      MICON           =   "frmLoadDenomination.frx":093A
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
      Caption         =   "  Load Denomination"
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
      TabIndex        =   7
      Top             =   0
      Width           =   3855
   End
End
Attribute VB_Name = "frmLoadDenomination"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim adoRs As ADODB.Recordset

Private Sub FillDenominationList()
    On Error GoTo hErr
    Set adoRs = g_dbPRECDb.GetRecordset("SELECT * FROM tblLoadAmount WHERE Discontinued = No ORDER BY LoadAmount ASC")
    lstDenomination.Clear
    
    Do While adoRs.EOF = False
        Call AddListItem(lstDenomination, adoRs("LoadAmount"), adoRs("LoadAmountID"))
        adoRs.MoveNext
    Loop
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

Private Sub cmdAdd_Click()
    On Error GoTo hErr
    If lstDenomination.ListIndex > -1 Then
        lstDenomination.Selected(lstDenomination.ListIndex) = False
    End If
    
    With txtDenomination
        .Text = ""
        .Enabled = True
        .SetFocus
    End With
    
    cmdCancelClose.Caption = "Cancel"
    cmdEdit.Enabled = False
    cmdDelete.Enabled = False
    cmdSave.Enabled = True
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

Private Sub cmdCancelClose_Click()
    On Error GoTo hErr
    If cmdSave.Enabled = True Then
        cmdSave.Enabled = False
        txtDenomination.Enabled = False
        
        If cmdAdd.Enabled = True Then
            txtDenomination.Text = ""
        Else
            txtDenomination.Text = lstDenomination.Text
        End If
        
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
        cmdCancelClose.Caption = "&Close"
        
        If lstDenomination.ListCount > 0 Then
            lstDenomination.Selected(lstDenomination.TopIndex) = True
        End If
    Else
        Unload Me
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

Private Sub cmdDelete_Click()
    On Error GoTo hErr
    If Len(txtDenomination.Text) > 0 Then
        If MsgBox("Are you want to delete the selected item?", vbDefaultButton2 + vbQuestion + vbYesNo, "Delete Item") = vbYes Then
            adoRs.MoveFirst
            adoRs.Find "LoadAmountID = " & CurrentListData(lstDenomination)
            
            If IsRecordLinked(LoadAmountID, CurrentListData(lstDenomination)) = True Then
                adoRs("Discontinued") = True
            Else
                adoRs.Delete
            End If
            
            adoRs.Update
            txtDenomination.Text = ""
            Call FillDenominationList
            MsgBox "Item deleted!", vbInformation, "Deleted"
        End If
    Else
        MsgBox "No item to delete!", vbExclamation, "Cannot Delete"
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

Private Sub cmdEdit_Click()
    On Error GoTo hErr
    If Len(txtDenomination.Text) = 0 Then
        MsgBox "No item to edit!", vbExclamation, "No Item Selected"
    Else
        With txtDenomination
            .Enabled = True
            .SetFocus
        End With
        
        cmdCancelClose.Caption = "&Cancel"
        cmdAdd.Enabled = False
        cmdDelete.Enabled = False
        cmdSave.Enabled = True
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

Private Sub cmdSave_Click()
    On Error GoTo hErr
    If Not IsNumeric(txtDenomination.Text) Then
        MsgBox "Enter numeric values only!", vbExclamation, "Invalid Data"
        Call SelectAllText(txtDenomination)
        Exit Sub
    End If
    
    If cmdAdd.Enabled = True Then
        adoRs.AddNew
        adoRs("LoadAmount").Value = txtDenomination.Text
    Else
        adoRs.MoveFirst
        adoRs.Find "LoadAmountID = " & CurrentListData(lstDenomination)
        adoRs("LoadAmount").Value = txtDenomination.Text
    End If
    
    adoRs.Update
    cmdCancelClose.Caption = "&Close"
    cmdSave.Enabled = False
    cmdAdd.Enabled = True
    cmdEdit.Enabled = True
    cmdDelete.Enabled = True
    txtDenomination.Enabled = False
    Call FillDenominationList
    lstDenomination.Selected(lstDenomination.TopIndex) = True
    lstDenomination.SetFocus
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
    g_dbPRECDb.OpenConnection
    Call CenterForm(Me)
    Call FillDenominationList
    
    If lstDenomination.ListCount > 0 Then
        lstDenomination.Selected(lstDenomination.TopIndex) = True
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

Private Sub Form_Unload(Cancel As Integer)
    On Error GoTo hErr
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

Private Sub lstDenomination_Click()
    On Error GoTo hErr
    If lstDenomination.ListIndex > -1 Then
        txtDenomination.Text = lstDenomination.Text
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

Private Sub lstDenomination_KeyPress(KeyAscii As Integer)
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

Private Sub txtDenomination_KeyPress(KeyAscii As Integer)
    On Error GoTo hErr
    
    If KeyAscii < 48 And KeyAscii > 57 Then
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

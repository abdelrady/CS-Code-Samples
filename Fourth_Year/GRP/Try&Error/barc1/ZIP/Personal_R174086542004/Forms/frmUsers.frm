VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmUsers 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   4815
   ClientLeft      =   1740
   ClientTop       =   2400
   ClientWidth     =   6375
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
   Icon            =   "frmUsers.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4815
   ScaleWidth      =   6375
   ShowInTaskbar   =   0   'False
   Begin MSComctlLib.ListView lvUsers 
      Height          =   3135
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   6135
      _ExtentX        =   10821
      _ExtentY        =   5530
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "#"
         Object.Width           =   882
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "User Name"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Last Name"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "First Name"
         Object.Width           =   3792
      EndProperty
   End
   Begin LVbuttons.LaVolpeButton cmdEdit 
      Height          =   375
      Left            =   1800
      TabIndex        =   2
      Top             =   4200
      Width           =   1215
      _ExtentX        =   2143
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
      MICON           =   "frmUsers.frx":08CA
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
      Left            =   4920
      TabIndex        =   4
      Top             =   4200
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
      MICON           =   "frmUsers.frx":08E6
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
   Begin LVbuttons.LaVolpeButton cmdAddNew 
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   4200
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Add New"
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
      MICON           =   "frmUsers.frx":0902
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
      Left            =   3360
      TabIndex        =   3
      Top             =   4200
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "De&lete"
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
      MICON           =   "frmUsers.frx":091E
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
   Begin MSComctlLib.ImageList ImageListSortIconIndicator 
      Left            =   120
      Top             =   4080
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   8
      ImageHeight     =   7
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   2
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmUsers.frx":093A
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmUsers.frx":0A0C
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Users"
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
      TabIndex        =   5
      Top             =   0
      Width           =   7935
   End
End
Attribute VB_Name = "frmUsers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public p_adoRSUsers As ADODB.Recordset
Public p_blnAddNew As Boolean
Public p_lngUserID As Long

Private Sub DoInitialSort()
    Dim col As ColumnHeader
    Set col = Me.lvUsers.ColumnHeaders(2)     'sort on second column (username)
    Call lvUsers_ColumnClick(col)                    'click the column heading
    
    If Me.lvUsers.ListItems.Count > 0 Then
        Me.lvUsers.ListItems(1).EnsureVisible     'make sure first one is visible
        Me.lvUsers.ListItems(1).Selected = True   'and selected
    End If
End Sub

Private Sub lvUsers_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    ' do not allow sorting on the first column
    If ColumnHeader.Index <> 1 Then
        SortListView lvUsers, ColumnHeader
        '------- Show Icon in Heading --------------------------------
        ShowListViewColumnHeaderSortIcon Me.lvUsers   'show the icon
        '-------------------------------------------------------------
    End If
End Sub

Private Sub PopulateList()
    On Error GoTo hErr
    Dim ObjLstItm As ListItem
    Dim lngLstIndex As Long
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblUsers WHERE Discontinued = No And " & _
       "TerminalID = " & g_lngTerminalID & " AND IsMasterUser = No ORDER BY LastName"
    Set p_adoRSUsers = g_dbPRECDb.GetRecordset(strSQL)
    lvUsers.ListItems.Clear
    lngLstIndex = 0
    
    If p_adoRSUsers.RecordCount <> 0 Then
        Do While p_adoRSUsers.EOF = False
            lngLstIndex = lngLstIndex + 1
            Set ObjLstItm = lvUsers.ListItems.Add
            
            With ObjLstItm
                .Text = lngLstIndex
                .SubItems(1) = p_adoRSUsers("UserName")
                .SubItems(2) = p_adoRSUsers("LastName")
                .SubItems(3) = p_adoRSUsers("FirstName")
            End With
            
            ' set User id as the key for text
            lvUsers.ListItems.Item(lngLstIndex).Key = "'" & p_adoRSUsers("UserID") & "'"
            p_adoRSUsers.MoveNext
        Loop
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

Private Sub cmdAddNew_Click()
    On Error GoTo hErr
    p_blnAddNew = True
    frmAddEditUser.Show vbModal
    
    If frmAddEditUser.p_blnSaved = True Then
        p_adoRSUsers.Close
        Call PopulateList
        Call DoInitialSort
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

Private Sub cmdDelete_Click()
    On Error GoTo hErr
    If lvUsers.ListItems.Count > 0 Then
        If MsgBox("Are you sure you want to delete the selected User?", _
           vbDefaultButton2 + vbQuestion + vbYesNo, "Delete User") = vbYes Then
            p_blnAddNew = False
            p_lngUserID = GetID(lvUsers.SelectedItem.Key)
            p_adoRSUsers.MoveFirst
            p_adoRSUsers.Find "UserID = " & p_lngUserID
            
            If IsRecordLinked(UserID, p_lngUserID) = True Then
                p_adoRSUsers("Discontinued") = True
            Else
                p_adoRSUsers.Delete
            End If
            
            p_adoRSUsers.Update
            Call PopulateList
            Call DoInitialSort
        End If
    Else
        MsgBox "No User to delete!", vbExclamation, "No User"
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
    If lvUsers.ListItems.Count > 0 Then
        p_blnAddNew = False
        p_lngUserID = GetID(lvUsers.SelectedItem.Key)
        frmAddEditUser.Show vbModal
        
        If frmAddEditUser.p_blnSaved = True Then
            p_adoRSUsers.Close
            Call PopulateList
            Call DoInitialSort
        End If
    Else
        MsgBox "No user to edit!", vbExclamation, "No User"
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
    lvUsers.ColumnHeaderIcons = ImageListSortIconIndicator
    Call PopulateList
    Call DoInitialSort
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
    If p_adoRSUsers.State = adStateOpen Then
        p_adoRSUsers.Close
    End If
    
    Set p_adoRSUsers = Nothing
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

Private Sub lvUsers_DblClick()
    On Error GoTo hErr
    Call cmdEdit_Click
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

Private Sub lvUsers_KeyDown(KeyCode As Integer, Shift As Integer)
    If lvUsers.ListItems.Count > 0 Then
        Select Case KeyCode
            Case vbKeyDelete
                Call cmdDelete_Click
            Case vbKeyReturn
                Call cmdEdit_Click
        End Select
    End If
End Sub

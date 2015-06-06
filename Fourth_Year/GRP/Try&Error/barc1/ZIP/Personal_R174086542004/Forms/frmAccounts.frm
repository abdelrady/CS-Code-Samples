VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmAccounts 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   5280
   ClientLeft      =   2205
   ClientTop       =   1485
   ClientWidth     =   7935
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
   Icon            =   "frmAccounts.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5280
   ScaleWidth      =   7935
   ShowInTaskbar   =   0   'False
   Begin MSComctlLib.ListView lvAccounts 
      Height          =   3255
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   7695
      _ExtentX        =   13573
      _ExtentY        =   5741
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      Checkboxes      =   -1  'True
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
      NumItems        =   8
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Active"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "#"
         Object.Width           =   882
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "ID Number"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Last Name"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "First Name"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Balance"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "Date Last Reloaded"
         Object.Width           =   3881
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "DateActivated"
         Object.Width           =   3881
      EndProperty
   End
   Begin LVbuttons.LaVolpeButton cmdEdit 
      Height          =   375
      Left            =   2640
      TabIndex        =   2
      Top             =   4680
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
      MICON           =   "frmAccounts.frx":08CA
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
      Left            =   5760
      TabIndex        =   4
      Top             =   4680
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
      MICON           =   "frmAccounts.frx":08E6
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
      Left            =   1080
      TabIndex        =   1
      Top             =   4680
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
      MICON           =   "frmAccounts.frx":0902
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
   Begin LVbuttons.LaVolpeButton cmdActivateAll 
      Height          =   375
      Left            =   4800
      TabIndex        =   5
      Top             =   4080
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   661
      BTYPE           =   6
      TX              =   "Ac&tivate All"
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
      FCOL            =   12582912
      FCOLO           =   16777088
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmAccounts.frx":091E
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   0   'False
      BSTYLE          =   0
   End
   Begin LVbuttons.LaVolpeButton cmdDeactivateAll 
      Height          =   375
      Left            =   6360
      TabIndex        =   6
      Top             =   4080
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   661
      BTYPE           =   6
      TX              =   "&Deactivate All"
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
      FCOL            =   12582912
      FCOLO           =   16777088
      EMBOSSM         =   12632256
      EMBOSSS         =   16777215
      MPTR            =   0
      MICON           =   "frmAccounts.frx":093A
      ALIGN           =   1
      IMGLST          =   "(None)"
      IMGICON         =   "(None)"
      ICONAlign       =   0
      ORIENT          =   0
      STYLE           =   0
      IconSize        =   2
      SHOWF           =   0   'False
      BSTYLE          =   0
   End
   Begin LVbuttons.LaVolpeButton cmdDelete 
      Height          =   375
      Left            =   4200
      TabIndex        =   3
      Top             =   4680
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
      MICON           =   "frmAccounts.frx":0956
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
      Top             =   4440
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
            Picture         =   "frmAccounts.frx":0972
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmAccounts.frx":0A44
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Accounts"
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
      Width           =   7935
   End
End
Attribute VB_Name = "frmAccounts"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' reserve
Private m_dtmLastReloaded As Date
Private m_blnAccountActive As Boolean
' determine if the deactivated account is to be activate
Private m_blnActivateAccount As Boolean
Public p_adoRSAccounts As ADODB.Recordset
Public p_blnAddNew As Boolean
Public p_lngAccountID As Long
Private m_accAccount As CAccount

Private Sub DoInitialSort()
    Dim col As ColumnHeader
    Set col = Me.lvAccounts.ColumnHeaders(4)     'sort on fourth column (Lastname)
    Call lvAccounts_ColumnClick(col)                    'click the column heading
    Call lvAccounts_ColumnClick(col)                    'click the column heading
    
    If Me.lvAccounts.ListItems.Count > 0 Then
        Me.lvAccounts.ListItems(1).EnsureVisible     'make sure first one is visible
        Me.lvAccounts.ListItems(1).Selected = True   'and selected
    End If
End Sub

Private Sub PopulateAccounts()
    On Error GoTo hErr
    Dim ObjLstItm As ListItem
    Dim lngLstIndex As Long
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE Discontinued = No ORDER BY LastName ASC"
    Set p_adoRSAccounts = g_dbPRECDb.GetRecordset(strSQL)
    lvAccounts.ListItems.Clear
    lngLstIndex = 0
    
    If p_adoRSAccounts.RecordCount <> 0 Then
        Do While p_adoRSAccounts.EOF = False
            lngLstIndex = lngLstIndex + 1
            Set ObjLstItm = lvAccounts.ListItems.Add
            
            With ObjLstItm
                '.Text = p_adorsAccounts("Active")
                .Checked = p_adoRSAccounts("Active")
                .SubItems(1) = lngLstIndex
                .SubItems(2) = p_adoRSAccounts("IDNo")
                .SubItems(3) = p_adoRSAccounts("LastName")
                .SubItems(4) = p_adoRSAccounts("FirstName")
                .SubItems(5) = p_adoRSAccounts("Balance")
                .SubItems(6) = IIf(IsNull(p_adoRSAccounts("DateLastReloaded")), "", _
                   p_adoRSAccounts("DateLastReloaded"))
                .SubItems(7) = IIf(IsNull(p_adoRSAccounts("DateActivated")), "", _
                   p_adoRSAccounts("DateActivated"))
            End With
            
            ' set account id as the key for text
            lvAccounts.ListItems.Item(lngLstIndex).Key = "'" & p_adoRSAccounts("AccountID") & "'"
            p_adoRSAccounts.MoveNext
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

Private Sub cmdActivateAll_Click()
    On Error GoTo hErr
    If lvAccounts.ListItems.Count = 0 Then
        MsgBox "No account to activate.", vbExclamation, "No Account Found"
    Else
        If MsgBox("Are you sure you want to activate all accounts?", _
           vbDefaultButton2 + vbYesNo + vbExclamation, "Activate All") = vbYes Then
            p_adoRSAccounts.MoveFirst
            
            Do While p_adoRSAccounts.EOF = False
                p_adoRSAccounts("Active") = True
                p_adoRSAccounts("DateActivated") = Now
                p_adoRSAccounts.Update
                p_adoRSAccounts.MoveNext
            Loop
            
            p_adoRSAccounts.Close
            Call PopulateAccounts
            Call DoInitialSort
            MsgBox "All accounts has been activated!", vbInformation, "Activated All Accounts"
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

Private Sub cmdDeactivateAll_Click()
    On Error GoTo hErr
    If lvAccounts.ListItems.Count = 0 Then
        MsgBox "No account to deactivate.", vbExclamation, "No Account Found"
    Else
        If MsgBox("Are you sure you want to deactivate all accounts?", _
           vbDefaultButton2 + vbYesNo + vbCritical, "Deactivate All") = vbYes Then
            p_adoRSAccounts.MoveFirst
            
            Do While p_adoRSAccounts.EOF = False
                p_adoRSAccounts("Active") = False
                p_adoRSAccounts("DateActivated") = Null
                p_adoRSAccounts.Update
                p_adoRSAccounts.MoveNext
            Loop
                        
            p_adoRSAccounts.Close
            Call PopulateAccounts
            Call DoInitialSort
            MsgBox "All accounts has been deactivated!", vbExclamation, "Deactivated All Accounts"
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

Private Sub cmdAddNew_Click()
    On Error GoTo hErr
    p_blnAddNew = True
    frmAddEditAccount.Show vbModal
    
    If frmAddEditAccount.p_blnSaved = True Then
        p_adoRSAccounts.Close
'        frmReload.Show vbModal
'        g_dbPRECDb.OpenConnection
        Call PopulateAccounts
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
    If lvAccounts.ListItems.Count > 0 Then
        Dim strName As String
    
        strName = lvAccounts.SelectedItem.SubItems(4) & " " & lvAccounts.SelectedItem.SubItems(3)
        
        If MsgBox("Are you sure you want to delete '" & strName & "'?", _
           vbDefaultButton2 + vbExclamation + vbYesNo, "Delete Account") = vbYes Then
            p_blnAddNew = False
            p_lngAccountID = GetID(lvAccounts.SelectedItem.Key)
            p_adoRSAccounts.MoveFirst
            p_adoRSAccounts.Find "AccountID = " & p_lngAccountID
            
            If IsRecordLinked(AccountID, p_lngAccountID) = True Then
                p_adoRSAccounts("Discontinued") = True
            Else
                p_adoRSAccounts.Delete
            End If
            
            p_adoRSAccounts.Update
            Call PopulateAccounts
            Call DoInitialSort
        End If
    Else
        MsgBox "No account to delete!", vbExclamation, "No Account"
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
    If lvAccounts.ListItems.Count > 0 Then
        p_blnAddNew = False
        p_lngAccountID = GetID(lvAccounts.SelectedItem.Key)
        frmAddEditAccount.Show vbModal
        
        If frmAddEditAccount.p_blnSaved = True Then
            p_adoRSAccounts.Close
            Call PopulateAccounts
            Call DoInitialSort
        End If
    Else
        MsgBox "No account to edit!", vbExclamation, "No Account"
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
    lvAccounts.ColumnHeaderIcons = ImageListSortIconIndicator
    Call PopulateAccounts
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
    If p_adoRSAccounts.State = adStateOpen Then
        p_adoRSAccounts.Close
    End If
    
    Set p_adoRSAccounts = Nothing
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

Private Sub lvAccounts_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    ' do not allow sorting on the first two columns
    If ColumnHeader.Index <> 1 And ColumnHeader.Index <> 2 Then
        SortListView lvAccounts, ColumnHeader
        '------- Show Icon in Heading --------------------------------
        ShowListViewColumnHeaderSortIcon Me.lvAccounts   'show the icon
        '-------------------------------------------------------------
        'Debug.Print Me.lvAccounts.SortOrder
    End If
End Sub

Private Sub lvAccounts_DblClick()
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

Private Sub lvAccounts_ItemCheck(ByVal Item As MSComctlLib.ListItem)
    ' to avoid checking and unchecking of the item
    'Item.Checked = Not Item.Checked
    On Error GoTo hErr
    
    Set m_accAccount = GetAccount(g_dbPRECDb, Item.SubItems(2))
    
    If Item.Checked = False Then
        If MsgBox("Are you sure you want this account to be deactivated?", _
           vbDefaultButton2 + vbQuestion + vbYesNo) = vbYes Then
            Call m_accAccount.Deactivate
        Else
            Item.Checked = Not Item.Checked
        End If
    Else
        Call m_accAccount.Activate
        lvAccounts.SelectedItem.SubItems(7) = m_accAccount.DateActivated
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

Private Sub lvAccounts_ItemClick(ByVal Item As MSComctlLib.ListItem)
    On Error GoTo hErr
    Set m_accAccount = GetAccount(g_dbPRECDb, Item.SubItems(2))
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

Private Sub lvAccounts_KeyDown(KeyCode As Integer, Shift As Integer)
    If lvAccounts.ListItems.Count > 0 Then
        Select Case KeyCode
            Case vbKeyDelete
                Call cmdDelete_Click
            Case vbKeyReturn
                Call cmdEdit_Click
        End Select
    End If
End Sub



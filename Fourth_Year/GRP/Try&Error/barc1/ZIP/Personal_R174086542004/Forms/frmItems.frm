VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmItems 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   5280
   ClientLeft      =   720
   ClientTop       =   2115
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
   Icon            =   "frmItems.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5280
   ScaleWidth      =   7935
   ShowInTaskbar   =   0   'False
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
      MICON           =   "frmItems.frx":08CA
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
      MICON           =   "frmItems.frx":08E6
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
      MICON           =   "frmItems.frx":0902
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
      MICON           =   "frmItems.frx":091E
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
      Top             =   4560
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
            Picture         =   "frmItems.frx":093A
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmItems.frx":0A0C
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ListView lvItems 
      Height          =   3735
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   7695
      _ExtentX        =   13573
      _ExtentY        =   6588
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
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "#"
         Object.Width           =   882
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "ItemCode"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "ItemName"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "ItemDescription"
         Object.Width           =   4939
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Unit"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "UnitPrice"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Items"
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
Attribute VB_Name = "frmItems"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public p_adoRSItems As ADODB.Recordset
Public p_blnAddNew As Boolean
Public p_lngItemCode As Long

Private Sub PopulateItems()
    On Error GoTo hErr
    Dim ObjLstItm As ListItem
    Dim lngLstIndex As Long
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblItems WHERE Discontinued = No AND TerminalID = " & g_lngTerminalID & " ORDER BY ItemCode ASC"
    Set p_adoRSItems = g_dbPRECDb.GetRecordset(strSQL)
    lvItems.ListItems.Clear
    lngLstIndex = 0
    
    If p_adoRSItems.RecordCount <> 0 Then
        Do While p_adoRSItems.EOF = False
            lngLstIndex = lngLstIndex + 1
            Set ObjLstItm = lvItems.ListItems.Add
            
            With ObjLstItm
                .Text = lngLstIndex
                .SubItems(1) = p_adoRSItems("ItemCode")
                .SubItems(2) = p_adoRSItems("ItemName")
                .SubItems(3) = p_adoRSItems("ItemDescription")
                .SubItems(4) = p_adoRSItems("Unit")
                .SubItems(5) = p_adoRSItems("UnitPrice")
            End With
            
            ' set Item id as the key for text
            lvItems.ListItems.Item(lngLstIndex).Key = "'" & p_adoRSItems("ItemID") & "'"
            p_adoRSItems.MoveNext
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

Private Sub lvItems_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    ' do not allow sorting on the first column
    If ColumnHeader.Index <> 1 Then
        SortListView lvItems, ColumnHeader
        '------- Show Icon in Heading --------------------------------
        ShowListViewColumnHeaderSortIcon Me.lvItems   'show the icon
        '-------------------------------------------------------------
    End If
End Sub

Private Sub DoInitialSort()
    Dim col As ColumnHeader
    Set col = Me.lvItems.ColumnHeaders(2)     'sort on second column (itemcode)
    Call lvItems_ColumnClick(col)                    'click the column heading
    Call lvItems_ColumnClick(col)                    'click the column heading
    
    If Me.lvItems.ListItems.Count > 0 Then
        Me.lvItems.ListItems(1).EnsureVisible     'make sure first one is visible
        Me.lvItems.ListItems(1).Selected = True   'and selected
    End If
End Sub

Private Sub cmdAddNew_Click()
    On Error GoTo hErr
    p_blnAddNew = True
    frmAddEditItem.Show vbModal
    
    If frmAddEditItem.p_blnSaved = True Then
        p_adoRSItems.Close
        Call PopulateItems
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
    If lvItems.ListItems.Count > 0 Then
        If MsgBox("Are you sure you want to delete the selected Item?", _
           vbDefaultButton2 + vbQuestion + vbYesNo, "Delete Item") = vbYes Then
            p_blnAddNew = False
            p_lngItemCode = lvItems.SelectedItem.SubItems(1)
            p_adoRSItems.MoveFirst
            p_adoRSItems.Find "ItemCode = " & p_lngItemCode
            
            If IsRecordLinked(ItemID, p_adoRSItems("ItemID")) = True Then
                p_adoRSItems("Discontinued") = True
            Else
                p_adoRSItems.Delete
            End If
            
            p_adoRSItems.Update
            Call PopulateItems
            Call DoInitialSort
        End If
    Else
        MsgBox "No Item to delete!", vbExclamation, "No Item"
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
    If lvItems.ListItems.Count = 0 Then
        MsgBox "No Item to edit!", vbExclamation, "No Item"
        Exit Sub
    End If
    
    p_blnAddNew = False
    p_lngItemCode = GetID(lvItems.SelectedItem.Key)
    frmAddEditItem.Show vbModal
    
    If frmAddEditItem.p_blnSaved = True Then
        p_adoRSItems.Close
        Call PopulateItems
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
    lvItems.ColumnHeaderIcons = ImageListSortIconIndicator
    Call PopulateItems
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
    If p_adoRSItems.State = adStateOpen Then
        p_adoRSItems.Close
    End If
    
    Set p_adoRSItems = Nothing
    g_dbPRECDb.CloseConnection
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
'    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
'       vbCritical, "An Error Occured")
'        Case vbAbort
'            Screen.MousePointer = vbDefault
'            Exit Sub
'        Case vbRetry
'            Resume
'        Case vbIgnore
'            Resume Next
'    End Select
End Sub

Private Sub lvItems_DblClick()
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

Private Sub lvItems_KeyDown(KeyCode As Integer, Shift As Integer)
    If lvItems.ListItems.Count > 0 Then
        Select Case KeyCode
            Case vbKeyDelete
                Call cmdDelete_Click
            Case vbKeyReturn
                Call cmdEdit_Click
        End Select
    End If
End Sub

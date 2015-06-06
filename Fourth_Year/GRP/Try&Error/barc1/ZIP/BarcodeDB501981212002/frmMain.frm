VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmMain 
   Caption         =   "BarcodeDB"
   ClientHeight    =   3675
   ClientLeft      =   645
   ClientTop       =   1200
   ClientWidth     =   5940
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   3675
   ScaleWidth      =   5940
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer tmrColumn 
      Interval        =   10
      Left            =   5520
      Top             =   0
   End
   Begin MSComctlLib.ListView lstDB 
      Height          =   3375
      Left            =   120
      TabIndex        =   0
      Top             =   135
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   5953
      View            =   3
      LabelEdit       =   1
      MultiSelect     =   -1  'True
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      AllowReorder    =   -1  'True
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Barcode"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Product"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Price"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuExit 
         Caption         =   "&Exit"
      End
   End
   Begin VB.Menu mnuDatabase 
      Caption         =   "&Database"
      Begin VB.Menu mnuAdd 
         Caption         =   "&Add"
         Shortcut        =   ^N
      End
      Begin VB.Menu mnuEdit 
         Caption         =   "&Edit"
      End
      Begin VB.Menu mnuDelete 
         Caption         =   "&Delete"
         Shortcut        =   {DEL}
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&View"
      Begin VB.Menu mnuGridlines 
         Caption         =   "&Gridlines"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuFont 
         Caption         =   "&Font"
      End
      Begin VB.Menu mnuSorted 
         Caption         =   "&Sorted"
      End
      Begin VB.Menu mnuDash2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuRefresh 
         Caption         =   "&Refresh / Show All"
         Shortcut        =   ^R
      End
   End
   Begin VB.Menu mnuSearch 
      Caption         =   "&Search"
      Begin VB.Menu mnuBarcode 
         Caption         =   "&by barcode"
         Shortcut        =   ^F
      End
      Begin VB.Menu mnuProduct 
         Caption         =   "&by product"
         Shortcut        =   ^S
      End
   End
   Begin VB.Menu mnuOptions 
      Caption         =   "&Options"
      Begin VB.Menu mnuSearchOnScan 
         Caption         =   "&Search on scan"
         Checked         =   -1  'True
      End
   End
   Begin VB.Menu mnuHelpMenu 
      Caption         =   "&Help"
      Begin VB.Menu mnuRegister 
         Caption         =   "&Register"
      End
      Begin VB.Menu mnuDash3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "&About"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    'load the form width and height from the registry and other settings
    frmMain.Width = GetSetting(AppName, "Options", "Form Width", frmMain.Width)
    frmMain.Height = GetSetting(AppName, "Options", "Form Height", frmMain.Height)
    lstDB.GridLines = GetSetting(AppName, "Options", "Gridlines", True)
    mnuGridlines.Checked = GetSetting(AppName, "Options", "Gridlines", True)
    mnuSearchOnScan.Checked = GetSetting(AppName, "Options", "Search on scan", True)
    mnuSorted.Checked = GetSetting(AppName, "Options", "Sorted", False)
    
    lstDB.Font.Size = GetSetting(AppName, "Options", "Font Size", lstDB.Font.Size)
    lstDB.Font.Name = Screen.Fonts(GetSetting(AppName, "Options", "Font Style", 18))
    
    'load the column header width's from the registry
    lstDB.ColumnHeaders(1).Width = GetSetting(AppName, "Options", "Product Column Width", lstDB.ColumnHeaders(1).Width)
    lstDB.ColumnHeaders(2).Width = GetSetting(AppName, "Options", "Price Column Width", lstDB.ColumnHeaders(2).Width)
    lstDB.ColumnHeaders(3).Width = GetSetting(AppName, "Options", "Barcode Column Width", lstDB.ColumnHeaders(3).Width)
    
    Call OpenDB(GetSetting(AppName, "Options", "Sortorder", lvwAscending), GetSetting(AppName, "Options", "Sortkey", 1), mnuSorted.Checked)
End Sub

Private Sub Form_Resize()
    Dim i As Byte
    Dim ColPer As Single 'Store percent of column width
    
    'resize and move form controls
    If Not frmMain.WindowState = vbMinimized Then
        If frmMain.Width < 6060 Then
            frmMain.Width = 6060
        End If
        
        If frmMain.Height < 4485 Then
            frmMain.Height = 4485
        End If
        
        'Resize column headers in the listview.
        For i = 1 To lstDB.ColumnHeaders.Count
            ColPer = (lstDB.ColumnHeaders(i).Width / lstDB.Width)
            lstDB.ColumnHeaders(i).Width = (frmMain.Width - 405) * ColPer
        Next
        
        lstDB.Width = frmMain.Width - 405
        lstDB.Height = frmMain.Height - 1095
    End If
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'save settings into registry
    SaveSetting AppName, "Options", "Product Column Width", lstDB.ColumnHeaders(1).Width
    SaveSetting AppName, "Options", "Price Column Width", lstDB.ColumnHeaders(2).Width
    SaveSetting AppName, "Options", "Barcode Column Width", lstDB.ColumnHeaders(3).Width
    SaveSetting AppName, "Options", "Form Width", frmMain.Width
    SaveSetting AppName, "Options", "Form Height", frmMain.Height
    SaveSetting AppName, "Options", "Gridlines", mnuGridlines.Checked
    SaveSetting AppName, "Options", "Search on scan", mnuSearchOnScan.Checked
    SaveSetting AppName, "Options", "Sorted", mnuSorted.Checked
    SaveSetting AppName, "Options", "Sortorder", lstDB.SortOrder
    SaveSetting AppName, "Options", "Sortkey", lstDB.SortKey
End Sub

Sub OpenDB(Optional hSortOrder = -3, Optional hSortKey = -3, Optional hSorted = -3)
    Dim DB As Database
    Dim RS As Recordset
    Dim WS As Workspace
    Dim i As Long
       
    lstDB.ListItems.Clear
        
    Set WS = DBEngine.Workspaces(0)
    Set DB = WS.OpenDatabase(App.Path & "\bdb.mdb")
    Set RS = DB.OpenRecordset("Products", dbOpenTable)

    If RS.RecordCount = 0 Then Exit Sub
    
    If hSortOrder = -3 Then
        hSortOrder = lstDB.SortOrder
    End If
    
    If hSortKey = -3 Then
        hSortKey = lstDB.SortKey
    End If
    
    If hSorted = -3 Then
        hSorted = lstDB.Sorted
    End If
    
    lstDB.Sorted = False
       
    RS.MoveFirst
    
    'move through each item in database and add to listview control
    For i = 1 To RS.RecordCount
        'check if record is empty and move to next one.
        If IsNull(RS("Barcode")) = True Then Exit For
        lstDB.ListItems.Add , , RS("Barcode")
        lstDB.ListItems(i).ListSubItems.Add , , RS("Product")
        lstDB.ListItems(i).ListSubItems.Add , , Format(RS("Price"), "$#,##0.00")
        
        'These fields are extra hidden fields for sorting columns by highest/lowest
        'number value.
        lstDB.ListItems(i).ListSubItems.Add , , Format(RS("Price"), "00000000000000000000000000.00")
        lstDB.ListItems(i).ListSubItems.Add , , Format(RS("Barcode"), "000000000000000000000000000")
        lstDB.ListItems(i).ListSubItems.Add , , Format(i, "000000000000000000000000000")
        RS.MoveNext
    Next
    
    RS.Close
    
    lstDB.SortOrder = hSortOrder
    lstDB.SortKey = hSortKey
    lstDB.Sorted = hSorted
End Sub

Private Sub lstDB_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    lstDB.SortKey = ColumnHeader.Index - 1
    
    If lstDB.SortOrder = lvwAscending Then
        lstDB.SortOrder = lvwDescending
    Else
        lstDB.SortOrder = lvwAscending
    End If
    
    'use the hidden columns for sorting, complicated story.
    If lstDB.SortKey = 0 Then lstDB.SortKey = 4
    If lstDB.SortKey = 2 Then lstDB.SortKey = 3
    
    lstDB.Sorted = True
End Sub

Private Sub lstDB_KeyPress(KeyAscii As Integer)
    'If the barcode is scanned then get input, if the user wants that.
    If mnuSearchOnScan.Checked = True Then
        If KeyAscii = 35 Then frmSearch.ByBarcode
    End If
End Sub

Private Sub mnuAbout_Click()
    frmAbout.Show vbModal
End Sub

Private Sub mnuAdd_Click()
    Load frmAdd
    frmAdd.Show
End Sub

Private Sub mnuBarcode_Click()
    frmSearch.ByBarcode
End Sub

Private Sub mnuDelete_Click()
    Dim DB As Database
    Dim RS As Recordset
    Dim WS As Workspace
    Dim i As Long
    Dim sAns As Byte
    Dim tmpSortKey As Byte
    Dim tmpSorted As Boolean
    Dim tmpSortOrder As Byte
    
    sAns = MsgBox("Do you really wish to permanently delete the selection(s) from the database", vbQuestion + vbYesNoCancel)
    If sAns = vbNo Or sAns = vbCancel Then Exit Sub
    
    tmpSortKey = lstDB.SortKey
    tmpSortOrder = lstDB.SortOrder
    tmpSorted = lstDB.Sorted
    
    If lstDB.Sorted = True Then
        lstDB.SortKey = 5
        lstDB.SortOrder = lvwAscending
    End If
    
    Set WS = DBEngine.Workspaces(0)
    Set DB = WS.OpenDatabase(App.Path & "\bdb.mdb")
        
    For i = lstDB.ListItems.Count To 1 Step -1
        If lstDB.ListItems(i).Selected = True Then
            Set RS = DB.OpenRecordset("Products", dbOpenTable)
            
            RS.Move lstDB.ListItems(i).ListSubItems(5) - 1
            RS.Delete
                
            RS.Close
        End If
    Next
    
    Call OpenDB(tmpSortOrder, tmpSortKey, tmpSorted)
    
End Sub

Private Sub mnuEdit_Click()
    Dim tmpSortKey As Byte
    Dim tmpSorted As Boolean
    Dim tmpSortOrder As Byte
    Dim SelCount As Long
    Dim EditCount As Long
    Dim i As Long
    
    tmpSortKey = lstDB.SortKey
    tmpSortOrder = lstDB.SortOrder
    tmpSorted = lstDB.Sorted
    
    If lstDB.Sorted = True Then
        lstDB.SortKey = 5
        lstDB.SortOrder = lvwAscending
    End If
    
    SelCount = 0
    EditCount = 1
    
    'find out how many selected items there are
    For i = 1 To lstDB.ListItems.Count
        If lstDB.ListItems(i).Selected = True Then SelCount = SelCount + 1
    Next
    
    For i = 1 To lstDB.ListItems.Count
        If lstDB.ListItems(i).Selected = True Then
            Call frmEdit.StartEdit(lstDB.ListItems(i).ListSubItems(5) - 1, i)
            frmEdit.Caption = "Edit - selection " & EditCount & " of " & SelCount
            frmEdit.Show vbModal
            EditCount = EditCount + 1
            If frmEdit.StopEdit = True Then Exit For
        End If
    Next
    
    If tmpSorted = True Then
        lstDB.SortKey = tmpSortKey
        lstDB.SortOrder = tmpSortOrder
        lstDB.Sorted = True
    End If
End Sub

Private Sub mnuExit_Click()
    Unload frmMain
End Sub

Private Sub mnuFont_Click()
    frmFont.Show vbModal
End Sub

Private Sub mnuGridlines_Click()
    If mnuGridlines.Checked = True Then
        lstDB.GridLines = False
        mnuGridlines.Checked = False
    Else
        lstDB.GridLines = True
        mnuGridlines.Checked = True
    End If
End Sub

Private Sub mnuProduct_Click()
    frmSearch.ByProduct
End Sub

Private Sub mnuRefresh_Click()
    Call OpenDB(, , mnuSorted.Checked)
End Sub

Private Sub mnuRegister_Click()
    Dim uName As String
    Dim Key As String
    
    uName = GetSetting(AppName, "Options", "Reg Name", vbNullString)
    Key = GetSetting(AppName, "Options", "Reg Key", vbNullString)
     
    If GenRegKey(uName) = Key Then
        MsgBox "You have already registered BarcodeDB. It cannot be registered again", vbInformation
        mnuRegister.Enabled = False
        Exit Sub
    End If
    
    frmRegister.Show vbModal
End Sub

Private Sub mnuSearchOnScan_Click()
    If mnuSearchOnScan.Checked = True Then
        mnuSearchOnScan.Checked = False
    Else
        mnuSearchOnScan.Checked = True
    End If
End Sub

Private Sub mnuSorted_Click()
    If mnuSorted.Checked = True Then
        mnuSorted.Checked = False
    Else
        mnuSorted.Checked = True
    End If
    
    Call OpenDB(, , mnuSorted.Checked)
End Sub

Private Sub tmrColumn_Timer()
    If lstDB.ColumnHeaders(6).Width > 0 Then lstDB.ColumnHeaders(6).Width = 0
End Sub

Sub DoSearch(sText, CaseSensitive As Boolean, WholePhrase As Boolean, sType As Byte)
    On Error Resume Next
    Dim i As Long
    Dim lString As String
    'Type 1 Barcode
    'Type 2 Product Name
    
    sType = sType - 1
    
    If CaseSensitive = False Then sText = LCase$(sText)
    
    Call OpenDB
    
    'nice a extremely simple search routine. the function eliminates any entries that do not match search
    'terms. The user can then browse through the entries and restore the original list when they
    'wish by pressing Ctrl + R
    
    For i = lstDB.ListItems.Count To 1 Step -1
        If CaseSensitive = False Then
            If sType = 0 Then
                lString = LCase$(lstDB.ListItems(i))
            Else
                lString = LCase$(lstDB.ListItems(i).ListSubItems(sType))
            End If
        Else
            If sType = 0 Then
                lString = lstDB.ListItems(i)
            Else
                lString = lstDB.ListItems(i).ListSubItems(sType)
            End If
        End If
        
        If WholePhrase = True Then
            'field exactly matches search term.
            If lString = sText Then GoTo SkipNext
        Else
            'if search term is found anywhere within field
            If InStr(1, lString, sText) > 0 Then GoTo SkipNext
        End If
        
        'Remove the item from the listview because it doesn't match
        'the search terms.
        lstDB.ListItems.Remove i
        
SkipNext:
    
    If CancelSearch = True Then Exit Sub
    Next
    
    'No search items found
    If lstDB.ListItems.Count = 0 Then
        lstDB.ListItems.Add , , "No items were found"
    End If
End Sub

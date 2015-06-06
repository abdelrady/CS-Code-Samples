Attribute VB_Name = "modMain"
Option Explicit

Public g_dbPRECDb As Cdatabase
Public g_fso As FileSystemObject
Public g_lngTerminalID As Long
Public g_lngMinimumBalance As Long
Public g_blnMasterUser As Boolean
Public g_strUserName As String
Public g_lngUserID As Long
Public g_strTerminalPrefix As String
Public g_lngLogId As Long
Public g_dtmLogInTime As Date

Public Const gCstrVerificationSQL = "SELECT * FROM tblProjectInfo WHERE ProjectName = 'Personal Reloadable Card'"
Public Const gCstrDefaultDbPath = "\Database\PRECdb.mdb"

Public Enum RecordType
    AccountID
    ItemID
    LoadAmountID
    UserID
End Enum

Public Enum HistoryType
    Purchase
    Reloading
End Enum

Public Enum ReportType
    Sales
    Reload
End Enum

Private Const LVM_FIRST = &H1000
Private Const LVM_GETHEADER = (LVM_FIRST + 31)

Private Const HDI_IMAGE = &H20
Private Const HDI_FORMAT = &H4

Private Const HDF_BITMAP_ON_RIGHT = &H1000
Private Const HDF_IMAGE = &H800
Private Const HDF_STRING = &H4000

Private Const HDM_FIRST = &H1200
Private Const HDM_SETITEM = (HDM_FIRST + 4)

Private Const HDF_LEFT As Long = 0
Private Const HDF_RIGHT As Long = 1
Private Const HDF_CENTER As Long = 2

Private Enum enumShow
    bShow = -1
    bHide = 0
End Enum

Private Type HDITEM
    mask     As Long
    cxy      As Long
    pszText  As String
    hbm      As Long
    cchTextMax As Long
    fmt      As Long
    lParam   As Long
    iImage   As Long
    iOrder   As Long
End Type

Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function apiGetComputerName Lib "kernel32" Alias _
    "GetComputerNameA" (ByVal lpBuffer As String, nSize As Long) As Long
Private Declare Function WNetGetConnection Lib "mpr.dll" Alias _
        "WNetGetConnectionA" (ByVal lpszLocalName As String, _
        ByVal lpszRemoteName As String, cbRemoteName As Long) As Long

Public Function GetUNCPath(strDriveLetter As String) As String
    On Local Error GoTo fGetUNCPath_Err

    Dim Msg As String, lngReturn As Long
    Dim lpszLocalName As String
    Dim lpszRemoteName As String
    Dim cbRemoteName As Long
    If Right(strDriveLetter, 1) = "\" Then strDriveLetter = Left(strDriveLetter, Len(strDriveLetter) - 1)
    lpszLocalName = strDriveLetter
    lpszRemoteName = String$(255, Chr$(32))
    cbRemoteName = Len(lpszRemoteName)
    lngReturn = WNetGetConnection(lpszLocalName, lpszRemoteName, _
                                       cbRemoteName)
    Select Case lngReturn
        Case 1200&  'ERROR_BAD_DEVICE
            Msg = "Error: Bad Device"
        Case 1201&  'ERROR_CONNECTION_UNAVAIL
            Msg = "Error: Connection Un-Available"
        Case 1208&  'ERROR_EXTENDED_ERROR
            Msg = "Error: Extended Error"
        Case 234    'ERROR_MORE_DATA
               Msg = "Error: More Data"
        Case 50&    'ERROR_NOT_SUPPORTED
               Msg = "Error: Feature not Supported"
        Case 1203&  'ERROR_NO_NET_OR_BAD_PATH
               Msg = "Error: No Network Available or Bad Path"
        Case 1222&  'ERROR_NO_NETWORK
               Msg = "Error: No Network Available"
        Case 2250&  'ERROR_NOT_CONNECTED
               Msg = "Error: Not Connected"
        Case 0  'NO_ERROR
               ' all is successful...
    End Select
    If Len(Msg) Then
        GetUNCPath = "Not Valid"
    Else
        GetUNCPath = Left$(lpszRemoteName, cbRemoteName)
        Do While Asc(Right(GetUNCPath, 1)) < 33
            GetUNCPath = Left(GetUNCPath, Len(GetUNCPath) - 1)
        Loop
    End If
fGetUNCPath_End:
    Exit Function
fGetUNCPath_Err:
    GetUNCPath = "Not Valid"
    Resume fGetUNCPath_End
End Function

Public Function IsValidServerPath(ByVal strFilePath As String) As Boolean
    On Error GoTo Err_Handler
    ' check for a valid UNC path
    Dim strDriveName As String
    
    ' comment the next two lines to enable this function
    IsValidServerPath = True
    Exit Function
    
    strDriveName = g_fso.GetDriveName(g_fso.GetParentFolderName(strFilePath))
    
    If g_fso.FolderExists(strDriveName) = True Then
        If Left$(strDriveName, 2) = "\\" Then
            IsValidServerPath = True
        Else
            If Left$(GetUNCPath(strDriveName), 2) = "\\" Then
                IsValidServerPath = True
            Else
                IsValidServerPath = False
            End If
        End If
    Else
        IsValidServerPath = False
    End If
    
Exit_Function:
    Exit Function
    
Err_Handler:
    IsValidServerPath = False
End Function

Public Function GetComputerName() As String
    'Returns the computername
    Dim lngLen As Long, lngx As Long
    Dim strCompName As String
    lngLen = 16
    strCompName = String$(lngLen, 0)
    lngx = apiGetComputerName(strCompName, lngLen)
    If lngx <> 0 Then
        GetComputerName = Left$(strCompName, lngLen)
    Else
        GetComputerName = "?"
    End If
End Function

'Public oHtmlHelp As CHtmlHelp

Private Function GetAlignment(col As MSComctlLib.ColumnHeader)
' Get the columns current alignment
    With col
        Select Case .Alignment
            Case lvwColumnRight
                GetAlignment = HDF_RIGHT
            Case lvwColumnCenter
                GetAlignment = HDF_CENTER
            Case Else
                GetAlignment = HDF_LEFT
        End Select
    End With
End Function

Public Sub AddComboItem(cboAdd As ComboBox, ByVal strText As String, ByVal lngData As Long)
    On Error GoTo hErr
    cboAdd.AddItem strText
    cboAdd.ItemData(cboAdd.ListCount - 1) = lngData
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

Public Sub AddListItem(lstAdd As ListBox, ByVal strText As String, ByVal lngData As Long)
    On Error GoTo hErr
    lstAdd.AddItem strText
    lstAdd.ItemData(lstAdd.ListCount - 1) = lngData
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

Public Sub LogUser()
    Dim rsLog As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblUserLogs WHERE LogID = " & g_lngLogId
    
    Set rsLog = New ADODB.Recordset
    
    If g_dbPRECDb.DbConnection.State = adStateClosed Then
        g_dbPRECDb.OpenConnection
    End If
    
    Call rsLog.Open(strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic)
    
    With rsLog
        If .RecordCount = 0 Then
            If g_lngLogId <> 0 Then  ' the log of a logged in user has been deleted
                ' restore deleted login time then logout
                .AddNew
                .Fields("UserID") = g_lngUserID
                .Fields("LoginTime") = g_dtmLogInTime
                .Fields("LogoutTime") = Now
            Else  ' login
                .AddNew
                .Fields("UserID") = g_lngUserID
                g_dtmLogInTime = Now
                .Fields("LoginTime") = g_dtmLogInTime
            End If
        ElseIf .RecordCount > 0 Then  ' logout
            .Fields("LogoutTime") = Now
        End If
        
        .Update
        g_lngLogId = .Fields("LogID").Value
        .Close
    End With
    
    Set rsLog = Nothing
End Sub

Public Sub SortListView(ByVal lvw As MSComctlLib.ListView, _
   ByVal colHdr As MSComctlLib.ColumnHeader)
    '--set the sortkey to the column header's index - 1
    lvw.SortKey = colHdr.Index - 1
    lvw.Sorted = True
    
    '--toggle the sort order between ascending & descending
    lvw.SortOrder = 1 Xor lvw.SortOrder
End Sub

Public Sub ShowListViewColumnHeaderSortIcon(list As MSComctlLib.ListView, _
    Optional vntSortColumn As Variant)
    
    Dim col As MSComctlLib.ColumnHeader
    Dim iSortColumn As Integer
    Dim lAlignment As Long
    
    If Not IsMissing(vntSortColumn) Then
        iSortColumn = vntSortColumn
        For Each col In list.ColumnHeaders  'set them all 'off'
            With col
                lAlignment = GetAlignment(col)
                ShowHeaderIcon .Index, 0, bHide, list, lAlignment
            End With
        Next
        ShowHeaderIcon iSortColumn + 1, list.SortOrder, bShow, list, lAlignment
    Else
        For Each col In list.ColumnHeaders
            With col
                lAlignment = GetAlignment(col)
                If .Index = list.SortKey + 1 Then
                    ShowHeaderIcon list.SortKey + 1, list.SortOrder, bShow, list, lAlignment
                Else
                    ShowHeaderIcon .Index, 0, bHide, list, lAlignment
                End If
            End With
        Next
    End If
End Sub

Private Sub ShowHeaderIcon(colNo As Long, imgIconNo As Long, bShowImage As enumShow, list As MSComctlLib.ListView, lAlignment As Long)
    Dim lHeader As Long
    Dim HD      As HDITEM
    
    'get a handle to the listview header component
    lHeader = SendMessage(list.hwnd, LVM_GETHEADER, 0, ByVal 0)
    
    'set up the structure entries
    With HD
        .mask = HDI_IMAGE Or HDI_FORMAT
        
        If bShowImage Then          'show
            .fmt = HDF_STRING Or HDF_IMAGE Or HDF_BITMAP_ON_RIGHT
            .iImage = imgIconNo
        Else
            .fmt = HDF_STRING       'just string
        End If
        .fmt = .fmt Or lAlignment   '2001/12/27 Add alignment
    End With
    
    'modify the header
    Call SendMessage(lHeader, HDM_SETITEM, colNo - 1, HD)
End Sub

Public Sub ShowLogoForm(Optional blnSplash As Boolean = True)
    On Error GoTo hErr
    frmSplash.p_blnSplash = blnSplash
    
    If blnSplash = True Then
        frmSplash.Show
    Else
        frmSplash.Show vbModal
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

Public Sub CenterForm(frmForm As Form)
    On Error GoTo hErr
   frmForm.Left = (Screen.Width - frmForm.Width) / 2
   frmForm.Top = (Screen.Height - frmForm.Height) / 2
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
  
Public Sub ClearAllText(frmForm As Form)
    On Error GoTo hErr
    Dim ctl As Control
    
    For Each ctl In frmForm.Controls
        If TypeOf ctl Is TextBox Then
            ctl.Text = ""
        ElseIf TypeOf ctl Is ComboBox Then
            ctl.ListIndex = -1
        End If
    Next ctl
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

Public Function CurrentComboData(cboCurrent As ComboBox) As Long
    On Error GoTo hErr
    If cboCurrent.ListIndex <> -1 Then
        CurrentComboData = cboCurrent.ItemData(cboCurrent.ListIndex)
    Else
        CurrentComboData = -1
    End If
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

Public Function CurrentListData(lstCurrent As ListBox) As Long
    On Error GoTo hErr
    If lstCurrent.ListIndex <> -1 Then
        CurrentListData = lstCurrent.ItemData(lstCurrent.ListIndex)
    Else
        CurrentListData = -1
    End If
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

' This function is only used by the canteen and bookstore terminals
Public Function GetNextHighestValue(ByVal strTable As String, ByVal strField As String) As String
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT MAX(MID(" & strField & ",2)) as HighestValue " & _
       "FROM " & strTable & " WHERE Left(" & strField & " ,1) = '" & g_strTerminalPrefix & "'"

    adoRs.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic
    
    If adoRs.RecordCount <> 0 Then
        GetNextHighestValue = IIf(IsNull(adoRs("HighestValue")) = True, _
           "00000000", adoRs("HighestValue"))
    Else
        GetNextHighestValue = "00000000"
    End If
    
    adoRs.Close
    Set adoRs = Nothing
    
    GetNextHighestValue = g_strTerminalPrefix & Format$(CLng(GetNextHighestValue) + 1, "00000000")
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

Public Function GetID(Key As String) As Long
    On Error GoTo hErr
     GetID = CLng(Replace$(Key, "'", ""))
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

Public Function GetPRECSetting(ByVal Key As String) As String
    On Error GoTo hErr
    GetPRECSetting = GetSetting("Personal Reloadable Card", "Settings", Key)
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

Public Sub GotoNextField(KeyAscii As Integer)
    On Error GoTo hErr
    If KeyAscii = Asc(vbCr) Then
        SendKeys "{TAB}"
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

Public Sub Main()
    On Error GoTo hErr
    Dim strDBPath As String
    
    ' check for Db path in the registry
    strDBPath = GetPRECSetting("Database")
    Set g_fso = New FileSystemObject
    
'    ' if the db path from the registry does not exists,
'    ' check the existence of the database from the default path
'    If g_fso.FileExists(strDBPath) = False Then
'        strDBPath = App.Path & gCstrDefaultDbPath
'    End If
    
    If g_fso.FileExists(strDBPath) = True Then
        Set g_dbPRECDb = NewPRECdb(strDBPath, "PReC2004")
        
        If g_dbPRECDb.VerifyDatabase(gCstrVerificationSQL) = True Then
            Call SavePRECSetting("Database", strDBPath)
            'frmLogin.Show
            Call ShowLogoForm(True)
            Exit Sub
        End If
    End If
    
    frmBrowse.Show
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

Public Function NewPRECdb(Optional ByVal strDBPath As String, _
                          Optional ByVal strDbPassword As String) As Cdatabase
    ' initialize a g_dbPRECDb object
    On Error GoTo hErr
    Set NewPRECdb = New Cdatabase
    Call NewPRECdb.InitDb(strDBPath, strDbPassword)
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

Public Function GetAccount(Optional PRECDb As Cdatabase, Optional ByVal strIDNo As String) As CAccount
    On Error GoTo hErr
    Set GetAccount = New CAccount
    Call GetAccount.InitAccount(PRECDb, strIDNo)
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

Public Sub SavePRECSetting(ByVal Key As String, ByVal Setting As String)
    On Error GoTo hErr
    SaveSetting "Personal Reloadable Card", "Settings", Key, Setting
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

Public Sub SelectAllText(txtContainer As TextBox)
    On Error GoTo hErr
    With txtContainer
        .SelStart = 0
        .SelLength = Len(.Text)
        .SetFocus
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

Public Function IsRecordLinked(RecordType As RecordType, ByVal lngRecordID As Long) As Boolean
    On Error GoTo hErr
    Dim strSQL As String
    Dim rsRecordLinked As ADODB.Recordset
    
    Select Case RecordType
        Case AccountID
            strSQL = "SELECT * FROM tblLoad WHERE AccountID = " & lngRecordID
        Case ItemID
            strSQL = "SELECT * FROM tblPurchasedItems WHERE ItemID = " & lngRecordID
        Case LoadAmountID
            strSQL = "SELECT * FROM tblLoad WHERE LoadAmountID = " & lngRecordID
        Case UserID
            strSQL = "SELECT tblPurchase.UserID, tblLoad.UserID, tblUserLogs.UserID " & _
               "FROM tblPurchase, tblLoad, tblUserLogs GROUP BY tblPurchase.UserID, tblLoad.UserID, tblUserLogs.UserID " & _
               "HAVING tblPurchase.UserID = " & lngRecordID & _
               " OR tblLoad.UserID = " & lngRecordID & _
               " OR tblUserLogs.UserID = " & lngRecordID
    End Select
    
    Set rsRecordLinked = New ADODB.Recordset
    Call rsRecordLinked.Open(strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic)
    
    IsRecordLinked = Not rsRecordLinked.EOF
    
    rsRecordLinked.Close
    Set rsRecordLinked = Nothing
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

Public Function UserExists(ByVal strUserName As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT * FROM tblUsers WHERE UserName = '" & strUserName & "' AND Discontinued = No"
    adoRs.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset
    UserExists = Not adoRs.EOF
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

Public Function NameExists(ByVal strLastName As String, _
   ByVal strFirstName As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT * FROM tblUsers WHERE LastName = '" & strLastName & "' AND " & _
       "FirstName = '" & strFirstName & "' AND Discontinued = No"
    adoRs.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset
    NameExists = Not adoRs.EOF
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

Public Sub ShowHelp(ByVal hwnd As Long)
    On Error GoTo hErr
    Dim strTopic As String
    
    Select Case g_lngTerminalID
        Case 1, 2 ' Bookstore / Canteen
            strTopic = "BookstoreMain.htm"
        Case 3  ' Accounting
            strTopic = "AccountingMain.htm"
    End Select
    
'    oHtmlHelp.CallerHWnd = hwnd
'    Call oHtmlHelp.ShowTopic(strTopic)
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

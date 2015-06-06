VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmUserLog 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "  Personal Reloadable Card System"
   ClientHeight    =   4815
   ClientLeft      =   1110
   ClientTop       =   2115
   ClientWidth     =   8580
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
   Icon            =   "frmUserLog.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4815
   ScaleWidth      =   8580
   ShowInTaskbar   =   0   'False
   Begin MSComctlLib.ListView lvUserLog 
      Height          =   3135
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   8295
      _ExtentX        =   14631
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
         Object.Width           =   1411
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "User Name"
         Object.Width           =   2822
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Login Time"
         Object.Width           =   4851
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Logout Time"
         Object.Width           =   4851
      EndProperty
   End
   Begin LVbuttons.LaVolpeButton cmdSave 
      Height          =   375
      Left            =   4680
      TabIndex        =   1
      Top             =   4200
      Width           =   1095
      _ExtentX        =   1931
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
      MICON           =   "frmUserLog.frx":08CA
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
      Left            =   7320
      TabIndex        =   3
      Top             =   4200
      Width           =   1095
      _ExtentX        =   1931
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
      MICON           =   "frmUserLog.frx":08E6
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
   Begin LVbuttons.LaVolpeButton cmdClear 
      Height          =   375
      Left            =   6000
      TabIndex        =   2
      Top             =   4200
      Width           =   1095
      _ExtentX        =   1931
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "C&lear"
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
      MICON           =   "frmUserLog.frx":0902
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
   Begin LVbuttons.LaVolpeButton cmdRefresh 
      Height          =   375
      Left            =   3360
      TabIndex        =   5
      Top             =   4200
      Width           =   1095
      _ExtentX        =   1931
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Refresh"
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
      MICON           =   "frmUserLog.frx":091E
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
      Top             =   3960
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
            Picture         =   "frmUserLog.frx":093A
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmUserLog.frx":0A0C
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label4 
      BackColor       =   &H00800000&
      Caption         =   "  Users Log"
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
      TabIndex        =   4
      Top             =   0
      Width           =   8775
   End
End
Attribute VB_Name = "frmUserLog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public p_adoRSUsers As ADODB.Recordset
Public p_blnAddNew As Boolean
Public p_lngUserID As Long

Private Sub PopulateList(Optional blnSortAsc As Boolean = True)
    On Error GoTo hErr
    Dim ObjLstItm As ListItem
    Dim lngLstIndex As Long
    Dim strSQL As String
    Dim strSort As String
    Dim strLoginTime As String
    Dim strLogoutTime As String
    
    If blnSortAsc = True Then
        strSort = "ASC"
    Else
        strSort = "DESC"
    End If
    
    strSQL = "SELECT tblUserLogs.LogID, tblUserLogs.UserID, tblUsers.UserName, " & _
       "tblUserLogs.LoginTime, tblUserLogs.LogoutTime, tblUsers.TerminalID, " & _
       "tblTerminal.TerminalName, tblUsers.IsMasterUser, tblUsers.Discontinued " & _
       "FROM (tblTerminal INNER JOIN tblUsers ON tblTerminal.TerminalID = " & _
       "tblUsers.TerminalID) INNER JOIN tblUserLogs ON tblUsers.UserID = tblUserLogs.UserID " & _
       "WHERE tblUsers.Discontinued = No AND tblUsers.TerminalID = " & g_lngTerminalID & " " & _
       "ORDER BY tblUserLogs.LoginTime " & strSort
    Set p_adoRSUsers = g_dbPRECDb.GetRecordset(strSQL)
    lvUserLog.ListItems.Clear
    lngLstIndex = 0
    
    If p_adoRSUsers.RecordCount <> 0 Then
        Do While p_adoRSUsers.EOF = False
            lngLstIndex = lngLstIndex + 1
            Set ObjLstItm = lvUserLog.ListItems.Add
            strLoginTime = IIf(IsNull(p_adoRSUsers("LoginTime")) = True, "", _
               Format$(p_adoRSUsers("LoginTime"), "yyyy/mm/dd hh:mm:ss AM/PM"))
            strLogoutTime = IIf(IsNull(p_adoRSUsers("LogoutTime")) = True, "", _
               Format$(p_adoRSUsers("LogoutTime"), "yyyy/mm/dd hh:mm:ss AM/PM"))
            
            With ObjLstItm
                .Text = lngLstIndex
                .SubItems(1) = p_adoRSUsers("UserName")
                .SubItems(2) = strLoginTime
                .SubItems(3) = strLogoutTime
            End With
            
            ' set LogID id as the key for text
            lvUserLog.ListItems.Item(lngLstIndex).Key = "'" & p_adoRSUsers("LogID") & "'"
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

Private Function SaveLog(ByVal strFileName As String) As Boolean
    On Error GoTo SaveLog_Err
    
    Dim txsLog As TextStream
    Dim lngIndex As Long
    Dim strTerminalName As String
    Dim strNum As String
    Dim strUserName As String
    Dim strLoginTime As String
    Dim strLogoutTime As String
    Dim strSpacer As String
    
    Set txsLog = g_fso.OpenTextFile(strFileName, ForWriting, True)
    strTerminalName = Right$(frmMain.lblTerminal.Caption, _
       Len(frmMain.lblTerminal.Caption) - 2)
    txsLog.WriteLine "Personal Reloadable Card System"
    txsLog.WriteLine strTerminalName & " User's Log"
    txsLog.WriteLine "Log File Created on " & Now
    txsLog.WriteBlankLines 1
    txsLog.WriteLine "#    User Name        Login Time               Logout Time"
    strSpacer = String$(4, " ")
    
    For lngIndex = 1 To lvUserLog.ListItems.Count
        strNum = lvUserLog.ListItems.Item(lngIndex).Text
        strUserName = lvUserLog.ListItems.Item(lngIndex).SubItems(1)
        strLoginTime = lvUserLog.ListItems.Item(lngIndex).SubItems(2)
        strLogoutTime = lvUserLog.ListItems.Item(lngIndex).SubItems(3)
        
        txsLog.WriteLine strNum & strSpacer & strUserName & strSpacer & _
           strLoginTime & strSpacer & strLogoutTime
    Next lngIndex
    
    txsLog.Close
    Set txsLog = Nothing
    SaveLog = True
    
    Exit Function
    
SaveLog_Err:
    txsLog.Close
    Set txsLog = Nothing
    SaveLog = False
End Function

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

Private Sub cmdClear_Click()
    On Error GoTo hErr
    Dim strSQL As String
    
    If lvUserLog.ListItems.Count > 0 Then
        If MsgBox("Are you sure you want to clear the user logs?", _
           vbDefaultButton2 + vbQuestion + vbYesNo, "Clear User Logs") = vbYes Then
            
            If MsgBox("Do you want to save the log before clearing it?", vbQuestion + vbYesNo, "Save Log") = vbYes Then
                Call cmdSave_Click
            End If
            
            strSQL = "DELETE tblUserLogs.*, tblUsers.TerminalID " & _
               "FROM (tblTerminal INNER JOIN tblUsers ON tblTerminal.TerminalID = " & _
               "tblUsers.TerminalID) INNER JOIN tblUserLogs ON tblUsers.UserID = " & _
               "tblUserLogs.UserID WHERE tblUsers.TerminalID = " & g_lngTerminalID
            g_dbPRECDb.ExecuteSQL strSQL
            Call PopulateList
            Call DoInitialSort
        End If
    Else
        MsgBox "Log is empty!", vbExclamation, "No Logs"
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

Private Sub cmdRefresh_Click()
    Call PopulateList
    Call DoInitialSort
End Sub

Private Sub cmdSave_Click()
    On Error GoTo hErr
    
    Dim strFileName As String
    
    If lvUserLog.ListItems.Count > 0 Then
        If g_fso.FolderExists(App.Path & "\Logs") = False Then
            g_fso.CreateFolder App.Path & "\Logs"
        End If
        
        strFileName = ShowSave(Me.hwnd, "Log File (*.log)" & _
           Chr(0) & "*.log", "Enter Name for log file", App.Path & "\Logs", False)
        
        If strFileName <> "0" Then
            If Right$(strFileName, 4) <> ".log" Then
                strFileName = strFileName & ".log"
            End If
            
            Call DoInitialSort
            
            If SaveLog(strFileName) = True Then
                MsgBox "Log file succesfully saved!", vbInformation, "Log File Saved"
            Else
                MsgBox "Log file saving failed!", vbExclamation, "Error In Saving"
            End If
        End If
    Else
        MsgBox "Log is empty!", vbExclamation, "No Logs"
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
    lvUserLog.ColumnHeaderIcons = ImageListSortIconIndicator
    Call PopulateList
    Call DoInitialSort       'initial sort column 1, ascending
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

Private Sub lvUserLog_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    ' do not allow sorting on the first column
    If ColumnHeader.Index <> 1 Then
        SortListView lvUserLog, ColumnHeader
        '------- Show Icon in Heading --------------------------------
        ShowListViewColumnHeaderSortIcon Me.lvUserLog   'show the icon
        '-------------------------------------------------------------
    End If
End Sub

Private Sub DoInitialSort()
    Dim col As ColumnHeader
    Set col = Me.lvUserLog.ColumnHeaders(3)     'sort on third column (Login Time)
    Call lvUserLog_ColumnClick(col)                    'click the column heading
    Call lvUserLog_ColumnClick(col)                    'click the column heading
    
    If Me.lvUserLog.ListItems.Count > 0 Then
        Me.lvUserLog.ListItems(1).EnsureVisible     'make sure first one is visible
        Me.lvUserLog.ListItems(1).Selected = True   'and selected
    End If
End Sub

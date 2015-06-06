VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Excel 
   Caption         =   "Viewer - Excel File"
   ClientHeight    =   8850
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11355
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MDIChild        =   -1  'True
   ScaleHeight     =   8850
   ScaleWidth      =   11355
   Begin VB.Frame Excel 
      Height          =   8775
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   3015
      Begin VB.CommandButton cmdPreview 
         Caption         =   "Preview"
         Enabled         =   0   'False
         Height          =   495
         Left            =   120
         TabIndex        =   27
         Top             =   8160
         Width           =   1335
      End
      Begin VB.CommandButton cmdExcell 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   2520
         Style           =   1  'Graphical
         TabIndex        =   26
         Top             =   480
         Width           =   405
      End
      Begin VB.CommandButton cmdMigrate 
         Caption         =   "Migrate Now"
         Enabled         =   0   'False
         Height          =   495
         Left            =   1560
         TabIndex        =   23
         Top             =   8160
         Width           =   1335
      End
      Begin VB.ComboBox cboTableINdb 
         Enabled         =   0   'False
         Height          =   315
         Left            =   120
         Sorted          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   21
         Top             =   4200
         Width           =   2745
      End
      Begin VB.CommandButton cmdPath 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   2520
         Style           =   1  'Graphical
         TabIndex        =   16
         Top             =   3120
         Width           =   405
      End
      Begin MSComctlLib.ListView lstSetting 
         Height          =   2055
         Left            =   120
         TabIndex        =   13
         Top             =   5400
         Width           =   2775
         _ExtentX        =   4895
         _ExtentY        =   3625
         View            =   3
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   -2147483643
         BorderStyle     =   1
         Appearance      =   1
         NumItems        =   3
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Excel"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Access"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Type"
            Object.Width           =   2540
         EndProperty
      End
      Begin VB.TextBox txtRow 
         Height          =   375
         Index           =   0
         Left            =   1200
         TabIndex        =   6
         Text            =   "1"
         Top             =   1440
         Width           =   615
      End
      Begin VB.TextBox txtRow 
         Height          =   375
         Index           =   1
         Left            =   2280
         TabIndex        =   5
         Text            =   "10"
         Top             =   1440
         Width           =   615
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Load Data"
         Enabled         =   0   'False
         Height          =   495
         Left            =   120
         TabIndex        =   4
         Top             =   1920
         Width           =   2775
      End
      Begin VB.TextBox txtColumn 
         Height          =   375
         Index           =   1
         Left            =   2280
         TabIndex        =   2
         Text            =   "10"
         Top             =   960
         Width           =   615
      End
      Begin VB.TextBox txtColumn 
         Height          =   375
         Index           =   0
         Left            =   1200
         TabIndex        =   1
         Text            =   "1"
         Top             =   960
         Width           =   615
      End
      Begin MSComctlLib.ProgressBar progbar 
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   2400
         Width           =   2775
         _ExtentX        =   4895
         _ExtentY        =   661
         _Version        =   393216
         BorderStyle     =   1
         Appearance      =   0
         Scrolling       =   1
      End
      Begin VB.Label Label12 
         Caption         =   "STEP 5:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   255
         Left            =   120
         TabIndex        =   25
         Top             =   7560
         Width           =   1095
      End
      Begin VB.Label Label11 
         Caption         =   "Click 'Migrate Now' Once Satisfied"
         Height          =   255
         Left            =   120
         TabIndex        =   24
         Top             =   7920
         Width           =   2775
      End
      Begin VB.Label Label10 
         Caption         =   "STEP 4:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   4680
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Select Target Table"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   3960
         Width           =   2295
      End
      Begin VB.Label Label8 
         Caption         =   "Fill Up 1st Column With Source Column"
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   5040
         Width           =   2775
      End
      Begin VB.Label Label7 
         Caption         =   "Select Source Data from Excel"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   600
         Width           =   2295
      End
      Begin VB.Label Label6 
         Caption         =   "STEP 3:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   3600
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Select Target Access Database"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   3240
         Width           =   2295
      End
      Begin VB.Label Label4 
         Caption         =   "STEP 2:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   2880
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "STEP 1:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label1 
         Caption         =   "From Row"
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   10
         Top             =   1560
         Width           =   975
      End
      Begin VB.Label Label2 
         Caption         =   "to"
         Height          =   255
         Index           =   0
         Left            =   1920
         TabIndex        =   9
         Top             =   1560
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "to"
         Height          =   255
         Index           =   1
         Left            =   1920
         TabIndex        =   8
         Top             =   1080
         Width           =   375
      End
      Begin VB.Label Label1 
         Caption         =   "From Column"
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   7
         Top             =   1080
         Width           =   975
      End
   End
   Begin MSComctlLib.ListView lstExcel 
      Height          =   8775
      Left            =   3120
      TabIndex        =   11
      Top             =   0
      Width           =   8175
      _ExtentX        =   14420
      _ExtentY        =   15478
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   0
   End
End
Attribute VB_Name = "Excel"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mCon            As ADODB.Connection
Dim mCat            As ADOX.Catalog
Dim TBL             As ADOX.Table

Private Sub cboTableINdb_Click()
Dim i               As Integer
Dim FldType         As String
Dim FldcType        As String

If Not mCon Is Nothing Then
    If mCon.State = adStateOpen Then
        lstSetting.View = lvwReport
        lstSetting.ListItems.Clear
        For Each TBL In mCat.Tables
            If TBL.Name = cboTableINdb.Text Then
                i = 1
                For Each col In TBL.Columns
                    If left$(col.Name, 2) <> "s_" Then
                        lstSetting.ListItems.Add , col.Name & "<<Clmn" & i
                        lstSetting.ListItems(col.Name & "<<Clmn" & i).SubItems(1) = col.Name
                        FldcType = cType(col.Type, FldType)
                        lstSetting.ListItems(col.Name & "<<Clmn" & i).SubItems(2) = FldType & "-" & FldcType
                        i = i + 1
                    End If
                Next
                Exit For
            End If
        Next
    End If
    cmdPreview.Enabled = True
    cmdMigrate.Enabled = True
Else
    cmdPreview.Enabled = False
    cmdMigrate.Enabled = False
End If
End Sub

Private Function cType(ByVal Value As ADOX.DataTypeEnum, userType As String) As String
  '16,2,3,20,17,18,19,21,4,5,6,14,131,11,132,12,72,7,133,134,135,8,129,200,201,130,202,203,128,204,205
  '0123158595 permata 202.187.45.87:8001/MEGgateway.asp?charge=0&username=form&password=kvinzdz&destination=
  Select Case Value
    '1-string 2-date 3-number
    Case adTinyInt, 16: cType = "adTinyInt": userType = 3
    Case adSmallInt, 2: cType = "adSmallInt": userType = 3
    Case adInteger, 3: cType = "adInteger": userType = 3
    Case adBigInt, 20: cType = "adBigInt": userType = 3
    Case adUnsignedTinyInt, 17: cType = "adUnsignedTinyInt": userType = 3
    Case adUnsignedSmallInt, 18: cType = "adUnsignedSmallInt": userType = 3
    Case adUnsignedInt, 19: cType = "adUnsignedInt": userType = 3
    Case adUnsignedBigInt, 21: cType = "adUnsignedBigInt": userType = 3
    Case adSingle, 4: cType = "adSingle"
    Case adDouble, 5: cType = "adDouble": userType = 3
    Case adCurrency, 6: cType = "adCurrency": userType = 3
    Case adDecimal, 14: cType = "adDecimal": userType = 3
    Case adNumeric, 131: cType = "adNumeric": userType = 3
    Case adBoolean, 11: cType = "adBoolean": userType = 4
    Case adUserDefined, 132: cType = "adUserDefined"
    Case adVariant, 12: cType = "adVariant"
    Case adGUID, 72: cType = "adGUID"
    Case adDate, 7: cType = "adDate": userType = 2
    Case adDBDate, 133: cType = "adDBDate": userType = 2
    Case adDBTime, 134: cType = "adDBTime": userType = 2
    Case adDBTimeStamp, 135: cType = "adDBTimeStamp": userType = 2
    Case adBSTR, 8: cType = "adBSTR": userType = 1
    Case adChar, 129: cType = "adChar": userType = 1
    Case adVarChar, 200: cType = "adVarChar": userType = 1
    Case adLongVarChar, 201: cType = "adLongVarChar": userType = 1
    Case adWChar, 130: cType = "adWChar": userType = 1
    Case adVarWChar, 202: cType = "adVarWChar": userType = 1
    Case adLongVarWChar, 203: cType = "adLongVarWChar": userType = 1
    Case adBinary, 128: cType = "adBinary": userType = 3
    Case adVarBinary, 203: cType = "adVarBinary": userType = 3
    Case adLongVarBinary, 205: cType = "adLongVarBinary": userType = 3
    Case Else: cType = Value
  End Select
End Function

Private Sub cmdExcell_Click()
Dim MyRequest   As String
Dim TheFilter   As String

    TheFilter = "Microsoft Excel" & Chr$(0) & "*.xls"
110 MyRequest = SelectFile(Me, TheFilter, OFS_FILE_OPEN_FLAGS, "", 0)
    If MyRequest = "" Then Exit Sub
    Excel.Tag = DetermineFilename(MyRequest)
    If Excel.Tag <> "" Then
        Call ExcelFileOpen(Me, MyRequest)
        Command2.Enabled = True
    End If
    Me.ZOrder
End Sub

Private Sub cmdMigrate_Click()
Dim SQLstmt         As String
Dim FldName         As String
Dim FldValue        As String
Dim i               As Integer
Dim j               As Integer
Dim CountLine       As Long
Dim IngnoreLine     As String
Dim AllLine         As Long

If MsgBox("Data from second column is compulsory. Without it the migration engine will ignore the process for those line. Are you sure you want to proceed?", vbYesNo, "Confirmation") = vbNo Then Exit Sub
If Me.lstExcel.ListItems.count = 0 Then
    MsgBox "There is no Excel data. Please load Microsoft Excel" & vbCrLf & "and load its file as specified in step 2. Thank you", vbInformation, "Information"
    Exit Sub
End If
If Trim(cboTableINdb.Text) = "" Then
    MsgBox "Please complete STEP 3 and select table to work with from the comboBox. Thank you.", vbInformation, "Information"
End If
If lstSetting.ListItems.count = 0 Then
    MsgBox "Table selected contain no data. Unable to proceed. Thank you", vbInformation, "Information"
End If

FldName = ""
'//Build the complete SQL statement "INSERT INTO " & TABLENAME & " (" & FIELDNAME & ") VALUES {" & FIELD VALUE & ")"
'//Get the Table name
cmdPreview.Caption = "Preview"
cmdPreview_Click
For i = 1 To lstExcel.ColumnHeaders.count
    If lstExcel.ColumnHeaders(i).Tag <> "" Then
        FldName = FldName & "[" & lstExcel.ColumnHeaders(i) & "],"
    End If
Next
If FldName = "" Then
    MsgBox "Connot construct Fields Name. Please set the Fields Name before proceed. Thank you", vbInformation, "Information"
    Exit Sub
Else
    FldName = left(FldName, Len(FldName) - 1)
End If
'//Get the field value
CountLine = 0
progbar.Value = 0

AllLine = lstExcel.ListItems.count

For j = 1 To AllLine
    If Len(lstExcel.ListItems(1).SubItems(1)) > 0 Then
        FldValue = ""
        For i = 1 To lstExcel.ColumnHeaders.count
            If lstExcel.ColumnHeaders(i).Tag <> "" Then
                FldValue = FldValue & Data2Insert(Val(lstSetting.ListItems(lstExcel.ColumnHeaders(i).Tag).SubItems(2)), lstExcel.ListItems(j).SubItems(i - 1)) & ","
            End If
        Next
        If Len(FldValue) = 0 Then
            IngnoreLine = IngnoreLine & i & " ,"
        Else
            FldValue = left(FldValue, Len(FldValue) - 1)
            '//Build the SQL Statement
            SQLstmt = "INSERT INTO " & cboTableINdb.Text & " (" & FldName & ") VALUES (" & FldValue & ")"
            'MsgBox SQLstmt
            mCon.Execute SQLstmt
            progbar.Value = (j / AllLine) * 100
            CountLine = CountLine + 1
        End If
    Else
        IngnoreLine = IngnoreLine & i & " ,"
    End If
Next
If Len(IngnoreLine) > 0 Then
    IngnoreLine = left(IngnoreLine, Len(IngnoreLine) - 2)
End If
If IngnoreLine = "" Then
    MsgBox "Migration 100% Completed without error." & vbCrLf & "Line inserted: " & CountLine, vbInformation, "Information"
Else
    MsgBox "Migration Completed." & vbCrLf & "Line inserted: " & CountLine & vbCrLf & "Line Ignored: " & IngnoreLine, vbInformation, "Information"
End If
End Sub

Private Function Data2Insert(DataType As Integer, TheData As String) As String
Select Case DataType
Case 1
    If TheData = "" Then TheData = " "
    TheData = Replace(TheData, "'", "''")
    Data2Insert = "'" & TheData & "'"
Case 2
    If TheData = "" Then TheData = Now
    Data2Insert = "#" & TheData & "#"
Case 3
    Data2Insert = TheData
End Select
End Function

Private Sub cmdPath_Click()
Dim TheFilter   As String
Dim MyRequest   As String

    TheFilter = "Microsoft Access DataBase" & Chr$(0) & "*.Mdb"
    
110 MyRequest = SelectFile(Me, TheFilter, OFS_FILE_OPEN_FLAGS, "", 0)
    If MyRequest = "" Then GoTo SETNOW
    cmdPath.Tag = DetermineFilename(MyRequest)
    If cmdPath.Tag <> "" Then
        MyRequest = "Microsoft.Jet.OLEDB.4.0"
        '//no password
        MyRequest = "PROVIDER=" & MyRequest & ";Data Source=" & cmdPath.Tag & ";Jet OLEDB:Database Password=;Admin"
        Label5.Tag = MyRequest
        If TempDBConnection(MyRequest) = True Then
            MsgBox "Test Connection Success", vbInformation, "Congratulation"
            Call GetDBtable(MyRequest)
        Else
            MsgBox "Test Connection Failed", vbExclamation, "I'm Sorry"
        End If
    End If
Screen.MousePointer = vbNormal
Exit Sub
SETNOW:
    Screen.MousePointer = vbNormal
End Sub

Private Sub GetDBtable(ConStrTest As String)

If Not mCon Is Nothing Then Set mCon = Nothing
Set mCon = New ADODB.Connection
mCon.Open ConStrTest
Set mCat = Nothing
Set mCat = New ADOX.Catalog
mCat.ActiveConnection = mCon
If Not mCon Is Nothing Then
    If mCon.State = adStateOpen Then
        cboTableINdb.Clear
        Screen.MousePointer = vbHourglass
        Me.lstSetting.ListItems.Clear
        'section for the database ini
        Screen.MousePointer = vbHourglass
        For Each TBL In mCat.Tables
            If TBL.Type = "TABLE" Then
                cboTableINdb.AddItem TBL.Name
            End If
        Next
        If cboTableINdb.List(0) <> "" Then
            cboTableINdb.Enabled = True
        Else
            cboTableINdb.Enabled = False
        End If
        
        Screen.MousePointer = vbNormal
    End If
End If
Screen.MousePointer = vbNormal
Exit Sub
WriteMyError:
    Screen.MousePointer = vbNormal
End Sub


Private Function TempDBConnection(ConStrTest As String) As Boolean

Dim TempDB As New ADODB.Connection
     TempDBConnection = False
     TempDB.Open ConStrTest
     If TempDB.State = adStateOpen Or TempDB.State = adStateExecuting Then
         TempDBConnection = True
         TempDB.Close
     End If
     Set TempDB = Nothing
Exit Function
WriteMyError:
    TempDBConnection = False
    If Not TempDB Is Nothing Then
        If TempDB.State = 1 Then TempDB.Close
    End If
    Set TempDB = Nothing
End Function

Private Sub cmdPreview_Click()
Dim i           As Integer
Dim j           As Integer
Dim TempData    As String

If Me.lstExcel.ListItems.count = 0 Then
    MsgBox "There is no Excel data to preview before the Migration. Thank you", vbInformation, "Information"
    Exit Sub
End If
If cmdPreview.Caption = "Preview" Then
    For i = 1 To Me.lstSetting.ListItems.count
        If Val(Me.lstSetting.ListItems(i).Text) > 0 Then
            TempData = Me.lstSetting.ListItems(i).Text
            For j = 1 To Me.lstExcel.ColumnHeaders.count
                If Me.lstExcel.ColumnHeaders(j).Text = TempData Then
                    Me.lstExcel.ColumnHeaders(j).Tag = Me.lstSetting.ListItems(i).Key
                    Me.lstExcel.ColumnHeaders(j).Text = Me.lstSetting.ListItems(i).SubItems(1)
                End If
            Next
        End If
    Next
    cmdPreview.Caption = "Back"
Else
    cmdPreview.Caption = "Preview"
    Me.lstExcel.ColumnHeaders(1).Text = ""
    Me.lstExcel.ColumnHeaders(1).Tag = ""
    For j = 2 To Me.lstExcel.ColumnHeaders.count
        Me.lstExcel.ColumnHeaders(j).Text = j - 1
        Me.lstExcel.ColumnHeaders(j).Tag = ""
    Next
End If
End Sub

Private Sub Command2_Click()
Dim qty As Integer

 Me.lstExcel.ZOrder 0
 Me.lstExcel.ListItems.Clear
 Me.lstExcel.ColumnHeaders.Clear
 Me.lstExcel.View = lvwReport
 qty = Val(Me.txtColumn(1).Text) - Val(Me.txtColumn(0).Text)
 If qty < 0 Then Exit Sub
 Me.lstExcel.ColumnHeaders.Add 1, 1 & "a", ""
 For i = 1 To qty + 1
    Me.lstExcel.ColumnHeaders.Add i + 1, i + 1 & "a", i
 Next
 Call MineDataNow(Me.lstExcel, Me)
End Sub

Private Sub Form_Load()
Command2.Enabled = False
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set objWorkbook = Nothing
Set objExcel = Nothing
End Sub

Private Sub GetTheValue(cType As Integer, NewString As String)

If NewString <> "" Then
    If cType = 1 Then
        NewString = "'" & NewString & "'"
    ElseIf cType = 2 Then
        NewString = "#" & NewString & "#"
    ElseIf cType = 3 Then
    End If
End If
End Sub

Private Sub lstSetting_AfterLabelEdit(Cancel As Integer, NewString As String)
    NewString = Val(NewString)
    If Val(lstSetting.SelectedItem.SubItems(2)) = 0 Then
        MsgBox "Undefined Field type. Thank you", vbInformation, "Information"
        NewString = ""
        Exit Sub
    End If
    If NewString = "0" Then
        MsgBox "Only number that referred to the Excel data is accepted.", vbInformation, "Information"
        NewString = ""
    End If
End Sub


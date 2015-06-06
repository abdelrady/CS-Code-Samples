VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form RDBMS 
   Caption         =   "Viewer - RDBMS"
   ClientHeight    =   8355
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9270
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   8355
   ScaleWidth      =   9270
   Begin VB.Frame FRDBCon 
      Height          =   3975
      Index           =   0
      Left            =   0
      TabIndex        =   1
      Top             =   480
      Width           =   9225
      Begin VB.CommandButton cmdDBFwd 
         Caption         =   ">>"
         Enabled         =   0   'False
         Height          =   450
         Left            =   8640
         TabIndex        =   33
         Top             =   3450
         Width           =   480
      End
      Begin VB.CommandButton cmdDbback 
         Caption         =   "<<"
         Enabled         =   0   'False
         Height          =   450
         Left            =   5040
         TabIndex        =   32
         Top             =   3450
         Width           =   480
      End
      Begin VB.Frame frmBottom 
         Height          =   3315
         Left            =   5040
         TabIndex        =   27
         Top             =   120
         Width           =   4095
         Begin VB.TextBox TxtDB 
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   2175
            Index           =   1
            Left            =   120
            Locked          =   -1  'True
            MultiLine       =   -1  'True
            ScrollBars      =   2  'Vertical
            TabIndex        =   28
            Top             =   600
            Width           =   3885
         End
         Begin VB.CheckBox ChkDB 
            Caption         =   "Change Database Connection String"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   495
            Left            =   1680
            TabIndex        =   30
            Top             =   120
            Width           =   1935
         End
         Begin VB.CommandButton CmdTestDB 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Test Connection"
            Enabled         =   0   'False
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   420
            Left            =   2640
            Style           =   1  'Graphical
            TabIndex        =   29
            Top             =   2830
            Width           =   1365
         End
         Begin VB.Label LblDB 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Connection String :"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   1
            Left            =   120
            TabIndex        =   31
            Top             =   240
            Width           =   1380
         End
      End
      Begin VB.TextBox TxtODBC 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   0
         Left            =   825
         TabIndex        =   25
         Top             =   240
         Width           =   3960
      End
      Begin VB.CheckBox chkUseNTSecurity 
         Caption         =   "Use built OS NT/2000 or others Security to Login"
         Height          =   255
         Left            =   840
         TabIndex        =   24
         Top             =   660
         Width           =   4635
      End
      Begin VB.Frame frvDBname 
         Height          =   1980
         Left            =   105
         TabIndex        =   5
         Top             =   1455
         Visible         =   0   'False
         Width           =   4830
         Begin VB.TextBox txtPasswd2 
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   315
            IMEMode         =   3  'DISABLE
            Left            =   1335
            PasswordChar    =   "*"
            TabIndex        =   8
            Top             =   630
            Width           =   3360
         End
         Begin VB.TextBox TxtDB 
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   315
            Index           =   0
            Left            =   1335
            Locked          =   -1  'True
            TabIndex        =   7
            Top             =   255
            Width           =   2940
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
            Left            =   4275
            Style           =   1  'Graphical
            TabIndex        =   6
            Top             =   240
            Width           =   405
         End
         Begin VB.Label Label3 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "  Password :"
            Height          =   195
            Left            =   330
            TabIndex        =   10
            Top             =   690
            Width           =   975
         End
         Begin VB.Label LblDB 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "DataBase Path :"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   0
            Left            =   150
            TabIndex        =   9
            Top             =   315
            Width           =   1170
         End
      End
      Begin VB.ComboBox cboDBType 
         Height          =   315
         Left            =   1425
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   1140
         Width           =   3510
      End
      Begin VB.CommandButton cmdGetTable 
         Enabled         =   0   'False
         Height          =   450
         Left            =   4455
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   3450
         Width           =   480
      End
      Begin VB.ComboBox cboTableINdb 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1335
         Sorted          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   2
         Top             =   3525
         Width           =   3105
      End
      Begin VB.Frame frvRemoteDBname 
         Height          =   1980
         Left            =   105
         TabIndex        =   11
         Top             =   1455
         Width           =   4830
         Begin VB.TextBox txtSchema 
            Height          =   315
            IMEMode         =   3  'DISABLE
            Left            =   1335
            TabIndex        =   16
            Top             =   1560
            Visible         =   0   'False
            Width           =   3360
         End
         Begin VB.TextBox txtIP 
            Height          =   315
            IMEMode         =   3  'DISABLE
            Left            =   1335
            TabIndex        =   15
            Top             =   1230
            Visible         =   0   'False
            Width           =   3360
         End
         Begin VB.ComboBox txtServerName 
            Height          =   315
            Left            =   1335
            TabIndex        =   14
            Top             =   240
            Width           =   3360
         End
         Begin VB.TextBox txtPasswd1 
            BackColor       =   &H00FFFFFF&
            Height          =   315
            IMEMode         =   3  'DISABLE
            Left            =   1335
            PasswordChar    =   "*"
            TabIndex        =   13
            Top             =   900
            Width           =   3360
         End
         Begin VB.TextBox txtDataBaseName 
            Height          =   315
            Left            =   1335
            TabIndex        =   12
            Top             =   570
            Width           =   3360
         End
         Begin VB.Label lblSchema 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "Default Schema :"
            Height          =   195
            Left            =   45
            TabIndex        =   21
            Top             =   1605
            Visible         =   0   'False
            Width           =   1230
         End
         Begin VB.Label lblIP 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "  Server IP :"
            Height          =   195
            Left            =   450
            TabIndex        =   20
            Top             =   1275
            Visible         =   0   'False
            Width           =   840
         End
         Begin VB.Label lblpasswd 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "  Password :"
            Height          =   195
            Left            =   435
            TabIndex        =   19
            Top             =   945
            Width           =   870
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "Server :"
            Height          =   195
            Left            =   750
            TabIndex        =   18
            Top             =   300
            Width           =   555
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "  Database :"
            Height          =   195
            Left            =   435
            TabIndex        =   17
            Top             =   615
            Width           =   870
         End
      End
      Begin VB.Label lblDBinfo 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "0 of 0"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   400
         Left            =   5520
         TabIndex        =   34
         Top             =   3500
         Width           =   3135
      End
      Begin VB.Label LblODBC 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "User ID :"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   120
         TabIndex        =   26
         Top             =   300
         Width           =   645
      End
      Begin VB.Label LblDB 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Database Type :"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   150
         TabIndex        =   23
         Top             =   1185
         Width           =   1200
      End
      Begin VB.Label lblTable 
         Caption         =   "Database table :"
         Enabled         =   0   'False
         Height          =   225
         Left            =   135
         TabIndex        =   22
         Top             =   3585
         Width           =   1230
      End
   End
   Begin MSComctlLib.ListView lstRDBMS 
      Height          =   3735
      Left            =   0
      TabIndex        =   0
      Top             =   4560
      Width           =   9255
      _ExtentX        =   16325
      _ExtentY        =   6588
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   0
   End
End
Attribute VB_Name = "RDBMS"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mCon            As ADODB.Connection
Dim mADO            As ADODB.Recordset
Dim mCat            As ADOX.Catalog
Dim TBL             As ADOX.Table

Private Function ProviderConst(cboListIndex As Integer) As String
    Select Case cboListIndex
        Case 1 'Jet 3.51
            ProviderConst = "Microsoft.Jet.OLEDB.3.51"
        Case 2 'Jet 4.0
            ProviderConst = "Microsoft.Jet.OLEDB.4.0"
        Case 3 'Visual FoxPro
            ProviderConst = "vfpoledb"
        Case 4 'SQL Server
            ProviderConst = "sqloledb"
        Case 5 'MySQL
            ProviderConst = "MySQLProv" '
        Case 6 'Oracle from Microsoft
            ProviderConst = "msdaora" '
        Case 7 'Oracle from Oracle
            ProviderConst = "OraOLEDB.Oracle"
        Case 8 'OLAP
            ProviderConst = "MSOLAP"
        Case 9 'DB2 Driver from Microsoft
            ProviderConst = "DB2OLEDB"
'        Case 6 'ODBC
'            ProviderConst = "msdasql.1"'
'        Case 6 'Dbase
'            ProviderConst = "Microsoft.Jet.OLEDB.4.0" ';Extended Properties=dBASE III
'        Case 7 'Excel 8.0
'            ProviderConst = "Microsoft.Jet.OLEDB.4.0" ';Extended Properties=Excel 8.0
'        Case Else 'Jet 3.51
'            ProviderConst = "Microsoft.Jet.OLEDB.3.51"
    End Select
End Function

Private Sub AccessConstr()
''' Microsoft Access Connection String for Microsoft.jet.OLEDB.3.51
Dim TempProvider As String
Dim MyDataSource As String
Dim TempPasswd As String

    TempProvider = ProviderConst(cboDBType.ListIndex + 1)
    TxtDB(1).Text = ""
    TxtDB(1).Tag = ""
Select Case cboDBType.ListIndex + 1
Case 1, 2
    If Len(txtPasswd2.Text) > 0 Then TempPasswd = "**********"
    If TxtDB(0).Text <> "" Then
        TxtDB(1).Text = "PROVIDER=" & TempProvider & ";Data Source=" & TxtDB(0).Text & ";Jet OLEDB:Database Password=" & TempPasswd & ";Admin"
        TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";Data Source=" & TxtDB(0).Text & ";Jet OLEDB:Database Password=" & txtPasswd2.Text & ";Admin"
    End If
Case 3
    TxtDB(1).Text = "PROVIDER=" & TempProvider & ";Data Source=" & TxtDB(0).Text & ";"
    TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";Data Source=" & TxtDB(0).Text & ";"
Case 4
    If Len(txtPasswd1.Text) > 0 Then TempPasswd = "**********"
    If txtServerName.Text = "Remote (TCP/IP)" Then
        If Trim(txtIP.Text) = "" Then Exit Sub
        MyDataSource = "Network Library=DBMSSOCN; Data Source=" & txtIP.Text & ",1433"
    Else
        MyDataSource = "Data Source=" & Me.txtServerName.Text
    End If
    If Me.txtDataBaseName.Text <> "" And Me.txtServerName.Text <> "" Then
        If chkUseNTSecurity.Value = 1 Then
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Integrated Security=SSPI"
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Integrated Security=SSPI"
        Else
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & TempPasswd & ";"
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & txtPasswd1.Text & ";"
        End If
    End If
Case 5, 6
    If Len(txtPasswd1.Text) > 0 Then TempPasswd = "**********"
    MyDataSource = "Data Source=" & Me.txtServerName.Text
        If chkUseNTSecurity.Value = 1 Then
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; Integrated Security=SSPI"
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; Integrated Security=SSPI"
        Else
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & TempPasswd
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & txtPasswd1.Text
        End If
Case 7
    If Len(txtPasswd1.Text) > 0 Then TempPasswd = "**********"
    MyDataSource = "Data Source=" & Me.txtServerName.Text
        If chkUseNTSecurity.Value = 1 Then
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; OSAuthent=1;"""
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; OSAuthent=1;"""
        Else
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & TempPasswd
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & txtPasswd1.Text
        End If
Case 8
    MyDataSource = "Data Source=" & Me.txtServerName.Text
    TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & ";"
    TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & ";"
Case 9
    If Len(txtPasswd1.Text) > 0 Then TempPasswd = "**********"
    If Trim(txtIP.Text) = "" Then Exit Sub
        MyDataSource = "Network Transport Library=TCPIP; Network Address=" & txtIP.Text
        If Me.txtDataBaseName.Text <> "" And Me.txtServerName.Text <> "" Then
        If chkUseNTSecurity.Value = 1 Then
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Package Collection=" & txtServerName.Text & "; Default Schema=" & txtSchema.Text & "; Integrated Security=SSPI"
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Package Collection=" & txtServerName.Text & "; Default Schema=" & txtSchema.Text & "; Integrated Security=SSPI"
        Else
            TxtDB(1).Text = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Package Collection=" & txtServerName.Text & "; Default Schema=" & txtSchema.Text & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & TempPasswd & ";"
            TxtDB(1).Tag = "PROVIDER=" & TempProvider & ";" & MyDataSource & ";Initial Catalog =" & Me.txtDataBaseName.Text & "; Package Collection=" & txtServerName.Text & "; Default Schema=" & txtSchema.Text & "; User ID=" & Me.TxtODBC(0).Text & ";Password=" & txtPasswd1.Text & ";"
        End If
    End If
End Select
Exit Sub
BUGS:
'MsgBox Erl & " :AccessConstr" & Err.Description & " : " & App.EXEName, vbInformation
End Sub

Private Sub cboDBType_Change()
    cboDBType_Click
End Sub

Private Sub cboTableINdb_Click()
Dim i           As Integer
Dim SQLstatement As String

If Not mCon Is Nothing Then
    If mCon.State = adStateOpen Then
        lstRDBMS.View = lvwReport
        lstRDBMS.ColumnHeaders.Clear
        lstRDBMS.Sorted = False
        lstRDBMS.ListItems.Clear
        If cmdGetTable.Enabled = False Then cboTableINdb.Enabled = False: Screen.MousePointer = vbNormal: Exit Sub
        For Each TBL In mCat.Tables
            If TBL.Name = cboTableINdb.Text Then
                i = 1
                lstRDBMS.ColumnHeaders.Add , "Clmn"
                For Each col In TBL.Columns
                    If Left$(col.Name, 2) <> "s_" Then
                        lstRDBMS.ColumnHeaders.Add , "Clmn" & i, col.Name
                        i = i + 1
                    End If
                Next
                Exit For
            End If
        Next
    End If
    
    If mADO.State = adStateOpen Then mADO.Close
    'SQLstatement = "SELECT COUNT(*) FROM " & cboTableINdb.Text
    '//get the fields name
    SQLstatement = ""
    If Me.lstRDBMS.ColumnHeaders.count > 0 Then
        SQLstatement = "[" & Me.lstRDBMS.ColumnHeaders(2).Text & "]"
        For i = 3 To Me.lstRDBMS.ColumnHeaders.count
            SQLstatement = SQLstatement & ",[" & Me.lstRDBMS.ColumnHeaders(i).Text & "]"
        Next
        SQLstatement = "SELECT " & SQLstatement & " FROM " & cboTableINdb.Text
        'MsgBox SQLstatement
        mADO.Open SQLstatement, mCon, adOpenStatic, adLockOptimistic, adCmdText
        SQLstatement = mADO.RecordCount
        If SQLstatement <> "" Then
            lblDBinfo.Caption = "0 of " & SQLstatement
            lblDBinfo.Tag = SQLstatement
        Else
            blDBinfo.Caption = "0 of 0"
        End If
        cmdDbback.Tag = "0"
        cmdDBFwd.Tag = "50"
        Call FloodlstView(0, 50)
    End If
    ToDisable True
Else
    ToDisable False
End If

End Sub

Private Sub ChkDB_Click()
    TxtDB(1).Locked = Not CBool(ChkDB.Value)
End Sub

Private Sub cmdDbback_Click()
    If Val(cmdDbback.Tag) = 0 Then Exit Sub
    Call FloodlstView(Val(cmdDbback.Tag) - 50, Val(cmdDbback.Tag))
End Sub

Private Sub cmdDBFwd_Click()
    If Val(cmdDBFwd.Tag) >= Val(lblDBinfo.Tag) Then Exit Sub
    Call FloodlstView(Val(cmdDBFwd.Tag), Val(cmdDBFwd.Tag) + 50)
End Sub

Private Sub FloodlstView(dtFrom As Long, dtTo As Long)
Dim i       As Long
Dim j       As Long
Dim TheData As String

If Me.lstRDBMS.ColumnHeaders.count = 0 Then Exit Sub
Me.lstRDBMS.ListItems.Clear
If mADO.EOF Then
    lblDBinfo.Caption = "No Data Found"
    Exit Sub
End If
mADO.MoveFirst
mADO.Move dtFrom
For i = dtFrom To dtTo - 1
    Me.lstRDBMS.ListItems.Add , "A" & i, i + 1
    With Me.lstRDBMS.ListItems("A" & i)
        For j = 2 To Me.lstRDBMS.ColumnHeaders.count
            TheData = mADO(Me.lstRDBMS.ColumnHeaders(j).Text).Value & ""
            .SubItems(j - 1) = TheData
        Next
    End With
    mADO.MoveNext
    If mADO.EOF Then Exit For
Next
If Val(cmdDbback.Tag) < 0 Then
    cmdDbback.Tag = "0"
    cmdDBFwd.Tag = "50"
Else
    cmdDbback.Tag = dtFrom
    cmdDBFwd.Tag = dtTo
End If
If Not mADO.EOF Then
    Me.lblDBinfo.Caption = "(" & cmdDbback.Tag + 1 & " - " & cmdDBFwd.Tag & ") of " & Me.lblDBinfo.Tag
Else
    Me.lblDBinfo.Caption = "(" & cmdDbback.Tag + 1 & " - " & mADO.RecordCount & ") of " & Me.lblDBinfo.Tag
End If

End Sub

Private Sub cmdGetTable_Click()

If TxtDB(1).Tag = "" Then
    cmdGetTable.Enabled = False
    Exit Sub
End If
If Not mCon Is Nothing Then Set mCon = Nothing
Set mCon = New ADODB.Connection
mCon.Open TxtDB(1).Tag
Set mCat = Nothing
Set mCat = New ADOX.Catalog
mCat.ActiveConnection = mCon
If Not mCon Is Nothing Then
    If mCon.State = adStateOpen Then
        cboTableINdb.Clear
        Screen.MousePointer = vbHourglass
        Me.lstRDBMS.ListItems.Clear
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
        
        lblTable.Enabled = cboTableINdb.Enabled
        Screen.MousePointer = vbNormal
    End If
End If
Screen.MousePointer = vbNormal
Exit Sub
WriteMyError:
    Screen.MousePointer = vbNormal
End Sub

Private Sub cmdPath_Click()
Dim TheFilter   As String
Dim MyRequest   As String

100 If cboDBType.Text = "Microsoft Visual Fox Pro" Then
        TheFilter = "Microsoft Visual Fox Pro DataBase" & Chr$(0) & "*.dbc"
    ElseIf cboDBType.Text = "Microsoft Access 95/97 (Jet 3.51)" Or cboDBType.Text = "Microsoft Access 2000 (Jet 4.0)" Then
        TheFilter = "Microsoft Access DataBase" & Chr$(0) & "*.Mdb"
    End If
    
110 MyRequest = SelectFile(Me, TheFilter, OFS_FILE_OPEN_FLAGS, "", 0)
    If MyRequest = "" Then GoTo SETNOW
    cmdPath.Tag = DetermineFilename(MyRequest)
    If cmdPath.Tag <> "" Then
        cmdGetTable.Enabled = False
        TxtDB(0).Text = Trim(MyRequest)
        ToDisable False
120     AccessConstr
130     CmdTestDB_Click
    End If
Screen.MousePointer = vbNormal
Exit Sub
SETNOW:
    Screen.MousePointer = vbNormal
End Sub

Private Sub ToDisable(Enable As Boolean)
    Me.cmdDbback.Enabled = Enable
    Me.cmdDBFwd.Enabled = Enable
End Sub


Private Sub CmdTestDB_Click()
Dim StrMsg      As String
Dim conCCPSstr  As String
Dim ConCompStr  As String
      
        cmdGetTable.Enabled = False
        cboTableINdb.Clear
        lstRDBMS.ListItems.Clear
        
        'test the database connection for the CCPS server DBPath
        If Trim(Me.TxtDB(1).Tag) <> "" Then
'            lblMsg = "[ Searching and Validate ]"
            TxtDB(1).Tag = Replace(TxtDB(1).Tag, vbCrLf, "")
            If TempDBConnection(Trim(TxtDB(1).Tag)) Then
                 CmdTestDB.Enabled = False
                 StrMsg = "Test Connection Success"
                 cmdGetTable.Enabled = True
            Else
                 StrMsg = "Test Connection Failed" & vbCrLf & _
                "Please Check The Connection String(s)."
            End If
        Else
            StrMsg = "Insufficient Data"
'            lblMsg = "[ " & StrMsg & " ]"
        End If
     MsgBox StrMsg, vbInformation, "Test Connection"
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

Private Sub Form_Unload(Cancel As Integer)
    Set mCat = Nothing
    Set mCon = Nothing
    Set mADO = Nothing
End Sub

Private Sub txtServerName_Click()
If txtServerName.Text = "Remote (TCP/IP)" Then
    If cboDBType.Text <> "DB2 Driver from Microsoft" And cboDBType.Text <> "Microsoft SQL Server" Then
        txtServerName = ""
        lblIP.Visible = False
        txtIP.Visible = False
    Else
        lblIP.Visible = True
        txtIP.Visible = True
    End If
ElseIf cboDBType.Text = "DB2 Driver from Microsoft" Then
    lblIP.Visible = True
    txtIP.Visible = True
Else
    lblIP.Visible = False
    txtIP.Visible = False
End If
    AccessConstr
End Sub
Private Sub cboDBType_Click()
    cmdPath.Tag = ""
    TxtDB(0).Text = ""
    txtIP.Visible = False
    lblIP.Visible = False
    txtSchema.Visible = False
    lblSchema.Visible = False
    txtServerName_Click
    chkUseNTSecurity.Enabled = False
    chkUseNTSecurity.Value = 0
    chkUseNTSecurity_Click
    Label1.Caption = "Server :"
    txtDataBaseName.Enabled = True
    txtDataBaseName.BackColor = vbWhite
    txtPasswd1.Enabled = False
    Me.txtPasswd1.BackColor = vbWhite
    '//add the server type
    txtServerName.Clear
    txtServerName.AddItem "(Local)"
    txtServerName.AddItem "Remote (TCP/IP)"
    Select Case cboDBType.Text
        Case "Microsoft Access 2000 (Jet 4.0)", "Microsoft Access 95/97 (Jet 3.51)"
120         frvDBname.Visible = True
            frvRemoteDBname.Visible = False
            Me.TxtDB(0).Enabled = True
            Me.cmdPath.Enabled = True
            If TxtDB(0).Text <> "" Then AccessConstr
        Case "Microsoft SQL Server"    'provStr = "Driver={SQL Server};Server=SERVER;Uid=sa;Pwd=;Database=sec"
            chkUseNTSecurity.Enabled = True
122         frvDBname.Visible = False
            frvRemoteDBname.Visible = True
            txtPasswd1.Enabled = True
            Me.TxtDB(0).Enabled = False
            Me.cmdPath.Enabled = False
            If Me.txtDataBaseName.Text <> "" And Me.txtServerName.Text <> "" Then
                AccessConstr
            End If
        Case "Microsoft Visual Fox Pro"
            txtPasswd1.Enabled = False
            Me.txtPasswd1.BackColor = &H8000000F
            txtDataBaseName.Enabled = False
            Me.txtDataBaseName.BackColor = &H8000000F
            If Me.txtDataBaseName.Text <> "" And Me.txtServerName.Text <> "" Then
                AccessConstr
            End If
            GoTo 120
        Case "MySQL"
            txtDataBaseName.Enabled = False
            Me.txtDataBaseName.BackColor = &H8000000F
            GoTo 122
        Case "Oracle Driver From Microsoft"
            txtDataBaseName.Enabled = False
            Me.txtDataBaseName.BackColor = &H8000000F
            GoTo 122
        Case "Oracle Driver From Oracle"
            txtDataBaseName.Enabled = False
            Me.txtDataBaseName.BackColor = &H8000000F
            chkUseNTSecurity.Enabled = True
            GoTo 122
        Case "OLAP Services"
            txtPasswd1.Enabled = False
            Me.txtPasswd1.BackColor = &H8000000F
            GoTo 122
        Case "DB2 Driver from Microsoft"
            Label1.Caption = "Pkg. Collection :"
            txtServerName.Clear
            txtSchema.Visible = True
            lblSchema.Visible = True
            txtIP.Visible = True
            lblIP.Visible = True
            GoTo 122
        Case ""
    End Select
Screen.MousePointer = vbNormal
Exit Sub
End Sub

Private Sub chkUseNTSecurity_Click()
    If chkUseNTSecurity.Value = 0 Then
        Me.txtPasswd1.Enabled = True
        Me.txtPasswd1.BackColor = vbWhite
    Else
        Me.txtPasswd1.Enabled = False
        Me.txtPasswd1.BackColor = &H8000000F
    End If
    AccessConstr
End Sub

Private Sub Form_Load()
    cboDBType.Clear
    cboDBType.AddItem "Microsoft Access 95/97 (Jet 3.51)"
    cboDBType.AddItem "Microsoft Access 2000 (Jet 4.0)"
    cboDBType.AddItem "Microsoft Visual Fox Pro"
    cboDBType.AddItem "Microsoft SQL Server"
    cboDBType.AddItem "MySQL"
    cboDBType.AddItem "Oracle Driver From Microsoft"
    cboDBType.AddItem "Oracle Driver From Oracle"
    cboDBType.AddItem "OLAP Services"
    cboDBType.AddItem "DB2 Driver from Microsoft"
    
    Set mADO = New ADODB.Recordset
End Sub

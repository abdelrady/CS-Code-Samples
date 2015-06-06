VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVBUTTONS.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmFind 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Find :: Student Records"
   ClientHeight    =   7425
   ClientLeft      =   2535
   ClientTop       =   1950
   ClientWidth     =   6960
   Icon            =   "frmFind.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7425
   ScaleWidth      =   6960
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin MSAdodcLib.Adodc adoFac 
      Height          =   330
      Left            =   5040
      Top             =   3120
      Visible         =   0   'False
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from faculty order by id"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSAdodcLib.Adodc adoResult 
      Height          =   330
      Left            =   2400
      Top             =   3120
      Visible         =   0   'False
      Width           =   1215
      _ExtentX        =   2143
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from student"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSAdodcLib.Adodc adoProgram 
      Height          =   330
      Left            =   3600
      Top             =   3120
      Visible         =   0   'False
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from course order by courseCode"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Search Result"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3795
      Left            =   120
      TabIndex        =   11
      Top             =   3240
      Width           =   6745
      Begin MSDataGridLib.DataGrid DataGrid1 
         Height          =   3135
         Left            =   120
         TabIndex        =   5
         Top             =   480
         Width           =   6495
         _ExtentX        =   11456
         _ExtentY        =   5530
         _Version        =   393216
         AllowUpdate     =   0   'False
         HeadLines       =   1
         RowHeight       =   15
         FormatLocked    =   -1  'True
         BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ColumnCount     =   3
         BeginProperty Column00 
            DataField       =   "kpitm"
            Caption         =   "UiTM ID"
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         BeginProperty Column01 
            DataField       =   "studName"
            Caption         =   "Name"
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         BeginProperty Column02 
            DataField       =   "courseCode"
            Caption         =   "Course"
            BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
               Type            =   0
               Format          =   ""
               HaveTrueFalseNull=   0
               FirstDayOfWeek  =   0
               FirstWeekOfYear =   0
               LCID            =   1033
               SubFormatType   =   0
            EndProperty
         EndProperty
         SplitCount      =   1
         BeginProperty Split0 
            BeginProperty Column00 
               Alignment       =   2
            EndProperty
            BeginProperty Column01 
               ColumnWidth     =   3600
            EndProperty
            BeginProperty Column02 
               ColumnWidth     =   1005.165
            EndProperty
         EndProperty
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Select a record and double-click to view its details."
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   600
         TabIndex        =   15
         Top             =   240
         Width           =   5535
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Find Records"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3015
      Left            =   120
      TabIndex        =   9
      Top             =   120
      Width           =   6735
      Begin LVbuttons.LaVolpeButton Command1 
         Default         =   -1  'True
         Height          =   375
         Left            =   5040
         TabIndex        =   6
         Top             =   240
         Width           =   1575
         _ExtentX        =   2778
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Find"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   1
         BCOL            =   12632256
         FCOL            =   0
         FCOLO           =   0
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmFind.frx":27A2
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
      Begin MSComCtl2.Animation Animation1 
         Height          =   615
         Left            =   5400
         TabIndex        =   10
         Top             =   1680
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   1085
         _Version        =   393216
         BackColor       =   16777215
         FullWidth       =   73
         FullHeight      =   41
      End
      Begin TabDlg.SSTab SSTab1 
         Height          =   2535
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   4815
         _ExtentX        =   8493
         _ExtentY        =   4471
         _Version        =   393216
         Style           =   1
         Tabs            =   1
         TabsPerRow      =   2
         TabHeight       =   520
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         TabCaption(0)   =   "Search Criteria"
         TabPicture(0)   =   "frmFind.frx":27BE
         Tab(0).ControlEnabled=   -1  'True
         Tab(0).Control(0)=   "Label12"
         Tab(0).Control(0).Enabled=   0   'False
         Tab(0).Control(1)=   "Label10"
         Tab(0).Control(1).Enabled=   0   'False
         Tab(0).Control(2)=   "Label11"
         Tab(0).Control(2).Enabled=   0   'False
         Tab(0).Control(3)=   "Label1"
         Tab(0).Control(3).Enabled=   0   'False
         Tab(0).Control(4)=   "Label3"
         Tab(0).Control(4).Enabled=   0   'False
         Tab(0).Control(5)=   "cmbCourse"
         Tab(0).Control(5).Enabled=   0   'False
         Tab(0).Control(6)=   "cmbProg"
         Tab(0).Control(6).Enabled=   0   'False
         Tab(0).Control(7)=   "txtMatrik"
         Tab(0).Control(7).Enabled=   0   'False
         Tab(0).Control(8)=   "txtNama"
         Tab(0).Control(8).Enabled=   0   'False
         Tab(0).Control(9)=   "cmbSex"
         Tab(0).Control(9).Enabled=   0   'False
         Tab(0).ControlCount=   10
         Begin VB.ComboBox cmbSex 
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   315
            ItemData        =   "frmFind.frx":27DA
            Left            =   1320
            List            =   "frmFind.frx":27E7
            Style           =   2  'Dropdown List
            TabIndex        =   4
            Top             =   2040
            Width           =   1215
         End
         Begin VB.TextBox txtNama 
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   285
            Left            =   1320
            TabIndex        =   1
            Top             =   960
            Width           =   3135
         End
         Begin VB.TextBox txtMatrik 
            Alignment       =   2  'Center
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   285
            Left            =   1320
            TabIndex        =   0
            Top             =   600
            Width           =   2535
         End
         Begin MSDataListLib.DataCombo cmbProg 
            Bindings        =   "frmFind.frx":27FE
            Height          =   315
            Left            =   1320
            TabIndex        =   2
            Top             =   1320
            Width           =   3135
            _ExtentX        =   5530
            _ExtentY        =   556
            _Version        =   393216
            Style           =   2
            ListField       =   "facName"
            BoundColumn     =   "id"
            Text            =   "DataCombo1"
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
         End
         Begin MSDataListLib.DataCombo cmbCourse 
            Bindings        =   "frmFind.frx":2813
            Height          =   315
            Left            =   1320
            TabIndex        =   3
            Top             =   1680
            Width           =   3135
            _ExtentX        =   5530
            _ExtentY        =   556
            _Version        =   393216
            Style           =   2
            ListField       =   "courseName"
            BoundColumn     =   "courseCode"
            Text            =   "DataCombo1"
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
         End
         Begin VB.Label Label3 
            Caption         =   "Course"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   19
            Top             =   1695
            Width           =   1095
         End
         Begin VB.Label Label1 
            Caption         =   "Sex"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   17
            Top             =   2055
            Width           =   615
         End
         Begin VB.Label Label11 
            Caption         =   "Name"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   16
            Top             =   985
            Width           =   1095
         End
         Begin VB.Label Label10 
            Caption         =   "Faculty"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   14
            Top             =   1340
            Width           =   1095
         End
         Begin VB.Label Label12 
            Caption         =   "UiTM ID"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   13
            Top             =   630
            Width           =   1095
         End
      End
      Begin LVbuttons.LaVolpeButton Command2 
         Height          =   375
         Left            =   5040
         TabIndex        =   7
         Top             =   720
         Width           =   1575
         _ExtentX        =   2778
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "C&lear Fields"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   1
         BCOL            =   12632256
         FCOL            =   0
         FCOLO           =   0
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmFind.frx":282C
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
      Begin LVbuttons.LaVolpeButton Command3 
         Height          =   375
         Left            =   5040
         TabIndex        =   8
         Top             =   1200
         Width           =   1575
         _ExtentX        =   2778
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Close"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   1
         BCOL            =   12632256
         FCOL            =   0
         FCOLO           =   0
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmFind.frx":2848
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
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1560
      TabIndex        =   18
      Top             =   7080
      Width           =   3735
   End
End
Attribute VB_Name = "frmFind"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public flagMatrik As String
Public flagProg As String
Public flagSesi As String
Public flagCourse As String
Public flagNama As String
Public flagSex As String

Private Sub cmbProg_Click(Area As Integer)
    On Error Resume Next
    If cmbProg.Text = "" Then Exit Sub
    adoProgram.RecordSource = "SELECT * FROM course " & _
    "WHERE id =" & cmbProg.BoundText
    adoProgram.Refresh
End Sub

Private Sub Command1_Click()
    On Error Resume Next

    If txtMatrik.Text <> "" Then
        flagMatrik = txtMatrik.Text
    Else
        flagMatrik = "%"
    End If
        
    If txtNama.Text <> "" Then
        flagNama = txtNama.Text
    Else
        flagNama = "%"
    End If
    
    If cmbCourse.Text <> "" Then
        flagCourse = cmbCourse.Text
    Else
        flagCourse = "%"
    End If
    
    If cmbSex.Text <> "All" And cmbSex.Text <> "" Then
        flagSex = Left(LCase(cmbSex.Text), 1)
    Else
        flagSex = "%"
    End If
    
    
    If cmbProg.Text <> "" Then
        flagProg = cmbProg.BoundText
    Else
        adoResult.RecordSource = "SELECT student.kpitm,student.courseCode,student.studName " & _
        "FROM faculty,course,student WHERE student.courseCode = course.courseCode " & _
        "AND course.id = faculty.id " & _
        "AND student.kpitm like '" & flagMatrik & "%' " & _
        "AND course.courseName like '" & flagCourse & "%' AND student.studName like '%" & flagNama & "%' AND " & _
        "student.sex like '" & flagSex & "' order by student.studName"
        adoResult.Refresh
        GoTo ther
    End If
    Animation1.AutoPlay = True
    Animation1.Open App.Path & "/findfile.avi"
    Animation1.Play (10)
    'Sleep (800)
        
    adoResult.RecordSource = "SELECT student.kpitm,student.courseCode,student.studName " & _
    "FROM faculty,course,student WHERE student.courseCode = course.courseCode " & _
    "AND course.id = faculty.id " & _
    "AND faculty.id = " & flagProg & " " & _
    "AND student.kpitm like '" & flagMatrik & "%' " & _
    "AND course.courseName like '" & flagCourse & "%' AND student.studName like '%" & flagNama & "%' AND " & _
    "student.sex like '" & flagSex & "' order by student.studName"
    adoResult.Refresh
ther:
        
    Set DataGrid1.DataSource = adoResult
    Label2.Caption = adoResult.Recordset.RecordCount & " record(s) found."
    Animation1.AutoPlay = False
    Animation1.Stop
End Sub

Private Sub Command2_Click()
    txtMatrik.Text = ""
    txtNama.Text = ""
    cmbProg.Text = ""
    cmbSex.Text = "All"
    cmbCourse.Text = ""
End Sub

Private Sub Command3_Click()
    Unload Me
End Sub

Private Sub DataGrid1_DblClick()
    On Error Resume Next
        frmStudnt.adoStud.Recordset.MoveFirst
        frmStudnt.adoStud.Recordset.Find "kpitm LIKE '%" & _
        adoResult.Recordset.Fields("kpitm").Value & "%'", , , 0
    Unload Me
End Sub

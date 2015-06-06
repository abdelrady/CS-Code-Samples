VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "tabctl32.ocx"
Begin VB.Form frmDine 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "MARA University of Technology :: Dining Hall Management System    v1.0"
   ClientHeight    =   8040
   ClientLeft      =   2130
   ClientTop       =   1770
   ClientWidth     =   9330
   Icon            =   "frmDine.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   Picture         =   "frmDine.frx":0CCA
   ScaleHeight     =   8040
   ScaleWidth      =   9330
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Dining Hall Attendance"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   5895
      Left            =   1200
      TabIndex        =   15
      Top             =   1680
      Width           =   8055
      Begin MSAdodcLib.Adodc adoDine 
         Height          =   330
         Left            =   6480
         Top             =   1560
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
         Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dwnmkn.mdb;Persist Security Info=False"
         OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dwnmkn.mdb;Persist Security Info=False"
         OLEDBFile       =   ""
         DataSourceName  =   ""
         OtherAttributes =   ""
         UserName        =   ""
         Password        =   ""
         RecordSource    =   "select * from dine"
         Caption         =   "adoDine"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _Version        =   393216
      End
      Begin MSDataGridLib.DataGrid DataGrid1 
         Height          =   3240
         Left            =   240
         TabIndex        =   17
         Top             =   2175
         Width           =   7575
         _ExtentX        =   13361
         _ExtentY        =   5715
         _Version        =   393216
         BorderStyle     =   0
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
         ColumnCount     =   2
         BeginProperty Column00 
            DataField       =   "kpitm"
            Caption         =   "KP UiTM"
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
            Caption         =   "Nama Pelajar"
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
            EndProperty
            BeginProperty Column01 
            EndProperty
         EndProperty
      End
      Begin TabDlg.SSTab SSTab1 
         Height          =   1935
         Left            =   240
         TabIndex        =   16
         Top             =   240
         Width           =   7575
         _ExtentX        =   13361
         _ExtentY        =   3413
         _Version        =   393216
         Style           =   1
         Tabs            =   1
         TabsPerRow      =   1
         TabHeight       =   520
         BackColor       =   16777215
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         TabCaption(0)   =   "Dining Attendance"
         TabPicture(0)   =   "frmDine.frx":16CE
         Tab(0).ControlEnabled=   -1  'True
         Tab(0).Control(0)=   "Frame4"
         Tab(0).Control(0).Enabled=   0   'False
         Tab(0).Control(1)=   "Frame5"
         Tab(0).Control(1).Enabled=   0   'False
         Tab(0).ControlCount=   2
         Begin VB.Frame Frame5 
            Caption         =   "Date and Session"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   735
            Left            =   240
            TabIndex        =   23
            Top             =   360
            Width           =   7095
            Begin VB.TextBox txtDT 
               Alignment       =   2  'Center
               DataField       =   "homeFon"
               DataSource      =   "adoStud"
               Enabled         =   0   'False
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
               Left            =   840
               TabIndex        =   25
               TabStop         =   0   'False
               Top             =   240
               Width           =   1695
            End
            Begin VB.ComboBox Combo1 
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
               ItemData        =   "frmDine.frx":16EA
               Left            =   3600
               List            =   "frmDine.frx":16F7
               Style           =   2  'Dropdown List
               TabIndex        =   24
               Top             =   240
               Width           =   1575
            End
            Begin LVbuttons.LaVolpeButton LaVolpeButton2 
               Height          =   375
               Left            =   5280
               TabIndex        =   26
               Top             =   240
               Width           =   1575
               _ExtentX        =   2778
               _ExtentY        =   661
               BTYPE           =   3
               TX              =   "Start Session"
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
               MICON           =   "frmDine.frx":171B
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
            Begin VB.Label Label8 
               BackStyle       =   0  'Transparent
               Caption         =   "Date"
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
               Left            =   240
               TabIndex        =   28
               Top             =   255
               Width           =   975
            End
            Begin VB.Label Label5 
               BackStyle       =   0  'Transparent
               Caption         =   "Session"
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
               Left            =   2760
               TabIndex        =   27
               Top             =   270
               Width           =   975
            End
         End
         Begin VB.Frame Frame4 
            Caption         =   "Student Details"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   720
            Left            =   240
            TabIndex        =   19
            Top             =   1080
            Width           =   7095
            Begin MSAdodcLib.Adodc adoTest 
               Height          =   330
               Left            =   6000
               Top             =   0
               Visible         =   0   'False
               Width           =   1200
               _ExtentX        =   2117
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
               Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dwnmkn.mdb;Mode=ReadWrite|Share Deny None;Persist Security Info=False"
               OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dwnmkn.mdb;Mode=ReadWrite|Share Deny None;Persist Security Info=False"
               OLEDBFile       =   ""
               DataSourceName  =   ""
               OtherAttributes =   ""
               UserName        =   ""
               Password        =   ""
               RecordSource    =   "select * from dine"
               Caption         =   "adoTest"
               BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
                  Name            =   "MS Sans Serif"
                  Size            =   8.25
                  Charset         =   178
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               _Version        =   393216
            End
            Begin VB.TextBox txtID 
               Alignment       =   2  'Center
               DataField       =   "homeFon"
               DataSource      =   "adoStud"
               Enabled         =   0   'False
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
               Left            =   1800
               TabIndex        =   20
               TabStop         =   0   'False
               Top             =   255
               Width           =   3495
            End
            Begin LVbuttons.LaVolpeButton cmdEnter 
               Height          =   300
               Left            =   5355
               TabIndex        =   21
               Top             =   240
               Width           =   615
               _ExtentX        =   1085
               _ExtentY        =   529
               BTYPE           =   3
               TX              =   "..."
               ENAB            =   0   'False
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
               MICON           =   "frmDine.frx":1737
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
            Begin VB.Label Label6 
               BackStyle       =   0  'Transparent
               Caption         =   "KP UiTM"
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
               Left            =   840
               TabIndex        =   22
               Top             =   270
               Width           =   975
            End
         End
      End
      Begin VB.Label Label7 
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
         Left            =   2040
         TabIndex        =   18
         Top             =   5520
         Width           =   3855
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Height          =   1575
      Left            =   120
      TabIndex        =   5
      Top             =   0
      Width           =   9135
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "Version 1.0"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   15.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   2880
         TabIndex        =   8
         Top             =   1080
         Width           =   5775
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "Dining Hall Management System"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   15.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   2880
         TabIndex        =   7
         Top             =   720
         Width           =   5775
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "MARA University of Technology"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   1680
         TabIndex        =   6
         Top             =   180
         Width           =   7575
      End
      Begin VB.Image Image1 
         Appearance      =   0  'Flat
         Height          =   1425
         Left            =   240
         Picture         =   "frmDine.frx":1753
         Top             =   120
         Width           =   1290
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "MARA University of Technology"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00E0E0E0&
         Height          =   615
         Left            =   1720
         TabIndex        =   9
         Top             =   230
         Width           =   7575
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   6255
      Left            =   120
      TabIndex        =   4
      Top             =   1680
      Width           =   975
      Begin VB.CommandButton cmdMaint 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":2157
         Style           =   1  'Graphical
         TabIndex        =   13
         Top             =   4556
         Width           =   735
      End
      Begin VB.CommandButton cmdUser 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":2A21
         Style           =   1  'Graphical
         TabIndex        =   12
         Top             =   3830
         Width           =   735
      End
      Begin VB.CommandButton cmdReport 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":32EB
         Style           =   1  'Graphical
         TabIndex        =   11
         Top             =   3104
         Width           =   735
      End
      Begin VB.CommandButton cmdExit 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":3FB5
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   5280
         Width           =   735
      End
      Begin VB.CommandButton cmdStud 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":487F
         Style           =   1  'Graphical
         TabIndex        =   0
         Top             =   200
         Width           =   735
      End
      Begin VB.CommandButton cmdFac 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":5149
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   926
         Width           =   735
      End
      Begin VB.CommandButton cmdEat 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":5A13
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   1652
         Width           =   735
      End
      Begin VB.CommandButton cmdKolej 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmDine.frx":5D1D
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   2378
         Width           =   735
      End
   End
   Begin VB.Label mylbl 
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
      Left            =   1200
      TabIndex        =   14
      Top             =   7680
      Width           =   8055
   End
End
Attribute VB_Name = "frmDine"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdEat_Click()
    frmDine.Show
End Sub

Private Sub cmdEat_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Dining Hall Attendance"
End Sub

Private Sub cmdEnter_Click()
    If txtID.Text = "" Then
        MsgBox "Please scan/key in UiTM ID number!", vbOKOnly + vbExclamation, "Input Error"
        txtID.SetFocus
        Exit Sub
    End If
    
    If IsNumeric(txtID.Text) = False Then
        MsgBox "Only numeric values allowed for UiTM ID number!", vbOKOnly + vbExclamation, "Error"
        txtID.SetFocus
        Exit Sub
    End If
    'check the existance of student record...
    If chkIDExist(txtID.Text) = False Then
        MsgBox "Warning! Student record with UiTM ID " & txtID.Text & " does not exist!", vbOKOnly + vbCritical, "Error"
        Exit Sub
    End If
    
    'check if student has come for the session or not
    If chkDineSession(txtID.Text, CInt(Left(Combo1.Text, 1))) = True Then
        MsgBox "Warning! Student record with UiTM ID " & txtID.Text & vbCrLf & _
        " has eaten for the " & Right(Combo1.Text, Len(Combo1.Text) - 2) & " session!", vbOKOnly + vbCritical, "Warning"
        Exit Sub
    End If
    
    'if everythin ok, lets save the attendance to the db
    Call saveAtt(CInt(Left(Combo1.Text, 1)), txtID.Text)
End Sub

Private Sub cmdExit_Click()
    Dim jwpn
    
    jwpn = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exit Confirmation")
    If jwpn = vbYes Then
        End
    Else
        Exit Sub
    End If
End Sub
Private Sub cmdFac_Click()
    frmFac.Show
End Sub

Private Sub cmdKolej_Click()
    frmCollege.Show
End Sub

Private Sub cmdkolej_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Colleges Information"
End Sub
Private Sub cmdExit_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Exit the System"
End Sub

Private Sub cmdFac_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Faculty and Course Information"
End Sub

Private Sub cmdMaint_Click()
    frmMaint.Show
End Sub

Private Sub cmdMaint_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Database Maintenance"
End Sub

Private Sub cmdReport_Click()
    frmReport2.Show
End Sub

Private Sub cmdReport_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Dining Hall Attendance Report"
End Sub

Private Sub cmdStud_Click()
    frmStudnt.Show
    Unload Me
End Sub

Private Sub cmdUser_Click()
    frmUser.Show
    Unload Me
End Sub

Private Sub cmduser_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "User Management"
End Sub
Private Sub cmdStud_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Student Information"
End Sub

Private Sub Form_Load()
    txtDT.Text = Format(Now, "dd/mm/yyyy")
End Sub

Private Sub Frame1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub Frame3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub txtPhone_KeyPress(KeyAscii As Integer)
    KeyAscii = 0
End Sub

Private Sub LaVolpeButton2_Click()
    If curLevel <> 2 And curLevel <> 3 Then
        MsgBox "Warning! Only level 2 (Management) and level 3 staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    If Combo1.Text = "" Then
        MsgBox "Please select a session!", vbOKOnly + vbInformation, "Select Session"
        Combo1.SetFocus
        Exit Sub
    End If
    'everytin ok...
    txtID.Enabled = True
    cmdEnter.Enabled = True
    txtID.SetFocus
    
    If Left(Combo1.Text, 1) = "1" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineMorning=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    ElseIf Left(Combo1.Text, 1) = "2" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineAfternoon=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    ElseIf Left(Combo1.Text, 1) = "3" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineNite=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    End If
    Set Me.DataGrid1.DataSource = adoDine
End Sub

Public Function chkIDExist(kpitm As String) As Boolean
    adoTest.RecordSource = "SELECT * FROM student WHERE kpitm = '" & kpitm & "'"
    adoTest.Refresh
    
    If adoTest.Recordset.RecordCount = 0 Then
        chkIDExist = False
    Else
        chkIDExist = True
    End If
End Function

Public Function chkDineSession(kpitm As String, sesi As Integer) As Boolean
    If sesi = 1 Then
        adoTest.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineMorning=YES AND dine.kpitm = '" & kpitm & "' " & _
        "ORDER BY dine.kpitm"
        adoTest.Refresh
    ElseIf sesi = 2 Then
        adoTest.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineAfternoon=YES AND dine.kpitm = '" & kpitm & "' " & _
        "ORDER BY dine.kpitm"
        adoTest.Refresh
    ElseIf sesi = 3 Then
        adoTest.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineNite=YES AND dine.kpitm = '" & kpitm & "' " & _
        "ORDER BY dine.kpitm"
        adoTest.Refresh
    End If
    If adoTest.Recordset.RecordCount = 0 Then
        chkDineSession = False 'havent eaten
    Else
        chkDineSession = True 'has eaten
    End If
End Function

Public Function saveAtt(sesi As Integer, kpitm As String)
    Dim process As Integer
    'first, check if stud record for 2day has existd or not
    adoTest.RecordSource = "SELECT id from dine " & _
    "WHERE dtDine=#" & Format(Now, "dd/mm/yyyy") & "# " & _
    "AND kpitm = '" & kpitm & "'"
    adoTest.Refresh

    'record is non-existant...
    If adoTest.Recordset.RecordCount = 0 Then
        process = 1 'add new record
    'record exists,lets juz ammend it..
    Else
        process = 2 'edit record
    End If
    
    
    If process = 1 Then  'jom add record
        adoTest.RecordSource = "SELECT * FROM dine"
        adoTest.Refresh
        With adoTest.Recordset
            .AddNew
            .Fields("dtDine").Value = Format(Now, "dd/mm/yyyy")
            .Fields("kpitm").Value = kpitm
            If sesi = 1 Then
                .Fields("dineMorning").Value = True
                .Fields("dineAfternoon").Value = False
                .Fields("dineNite").Value = False
            ElseIf sesi = 2 Then
                .Fields("dineMorning").Value = False
                .Fields("dineAfternoon").Value = True
                .Fields("dineNite").Value = False
            ElseIf sesi = 3 Then
                .Fields("dineMorning").Value = False
                .Fields("dineAfternoon").Value = False
                .Fields("dineNite").Value = True
            End If
                .Update
        End With
        adoTest.Refresh
    ElseIf process = 2 Then
        adoTest.RecordSource = "SELECT * from dine " & _
        "WHERE dtDine=#" & Format(Now, "dd/mm/yyyy") & "# " & _
        "AND kpitm = '" & kpitm & "'"
        adoTest.Refresh
        With adoTest.Recordset
            If sesi = 1 Then
                .Fields("dineMorning").Value = True
            ElseIf sesi = 2 Then
                .Fields("dineAfternoon").Value = True
            ElseIf sesi = 3 Then
                .Fields("dineNite").Value = True
            End If
                .UpdateBatch adAffectCurrent
        End With
        adoTest.Refresh
    End If
    
    If Left(Combo1.Text, 1) = "1" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineMorning=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    ElseIf Left(Combo1.Text, 1) = "2" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineAfternoon=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    ElseIf Left(Combo1.Text, 1) = "3" Then
        adoDine.RecordSource = "SELECT dine.kpitm,student.studName FROM dine,student " & _
        "WHERE dine.kpitm = student.kpitm AND dine.dtDine=#" & Format(Now, "dd/mm/yyyy") & "#" & _
        " AND dine.dineNite=YES ORDER BY dine.kpitm"
        adoDine.Refresh
    End If
    Set Me.DataGrid1.DataSource = adoDine
End Function
Private Sub txtID_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then
        cmdEnter_Click
    End If
End Sub

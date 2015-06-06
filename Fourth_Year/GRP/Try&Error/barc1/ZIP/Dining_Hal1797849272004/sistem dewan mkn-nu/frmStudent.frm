VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form frmStudnt 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "MARA University of Technology :: Dining Hall Management System    v1.0"
   ClientHeight    =   8040
   ClientLeft      =   2385
   ClientTop       =   2025
   ClientWidth     =   9330
   Icon            =   "frmStudent.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   Picture         =   "frmStudent.frx":0CCA
   ScaleHeight     =   8040
   ScaleWidth      =   9330
   StartUpPosition =   2  'CenterScreen
   Begin MSAdodcLib.Adodc adoDum 
      Height          =   330
      Left            =   1680
      Top             =   7680
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from student order by kpitm"
      Caption         =   "Adodc3"
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   330
      Left            =   7440
      Top             =   7680
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from faculty order by facName"
      Caption         =   "Adodc2"
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
   Begin MSAdodcLib.Adodc adoCollege 
      Height          =   330
      Left            =   8160
      Top             =   7680
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from college order by collegeName"
      Caption         =   "Adodc2"
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
   Begin LVbuttons.LaVolpeButton cmdDel 
      Height          =   375
      Left            =   5205
      TabIndex        =   40
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Delete Record"
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
      MICON           =   "frmStudent.frx":16CE
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
   Begin LVbuttons.LaVolpeButton cmdEdit 
      Height          =   375
      Left            =   3435
      TabIndex        =   18
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Edit Record"
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
      MICON           =   "frmStudent.frx":16EA
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
   Begin LVbuttons.LaVolpeButton cmdCancel 
      Height          =   375
      Left            =   5205
      TabIndex        =   44
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Cancel"
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
      MICON           =   "frmStudent.frx":1706
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
   Begin LVbuttons.LaVolpeButton cmdSave 
      Height          =   375
      Left            =   3435
      TabIndex        =   43
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Save"
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
      MICON           =   "frmStudent.frx":1722
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
   Begin LVbuttons.LaVolpeButton cmdAdd 
      Height          =   375
      Left            =   1680
      TabIndex        =   17
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&New Record"
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
      MICON           =   "frmStudent.frx":173E
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
   Begin VB.Frame Frame3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Student Information"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   5175
      Left            =   1200
      TabIndex        =   25
      Top             =   1680
      Width           =   8055
      Begin MSDataListLib.DataCombo dcCollege 
         Bindings        =   "frmStudent.frx":175A
         DataField       =   "collegeId"
         DataSource      =   "adoStud"
         Height          =   315
         Left            =   1800
         TabIndex        =   12
         Top             =   4680
         Width           =   2775
         _ExtentX        =   4895
         _ExtentY        =   556
         _Version        =   393216
         Enabled         =   0   'False
         Style           =   2
         ListField       =   "collegeName"
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
      Begin MSAdodcLib.Adodc Adodc1 
         Height          =   330
         Left            =   6240
         Top             =   1800
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
         RecordSource    =   "select * from course order by courseCode"
         Caption         =   "Adodc1"
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
      Begin VB.TextBox Text4 
         Alignment       =   2  'Center
         DataField       =   "courseName"
         DataSource      =   "Adodc1"
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
         Left            =   3120
         TabIndex        =   45
         TabStop         =   0   'False
         Top             =   1080
         Width           =   4455
      End
      Begin VB.TextBox txtNama 
         Alignment       =   2  'Center
         DataField       =   "studName"
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
         TabIndex        =   3
         Top             =   1455
         Width           =   5775
      End
      Begin VB.TextBox txtIc 
         Alignment       =   2  'Center
         DataField       =   "kpid"
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
         TabIndex        =   4
         Top             =   1800
         Width           =   2895
      End
      Begin VB.TextBox txtPoskod2 
         Alignment       =   2  'Center
         DataField       =   "pos2"
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
         Left            =   6960
         TabIndex        =   9
         Top             =   3360
         Width           =   855
      End
      Begin VB.TextBox txtMatrik 
         Alignment       =   2  'Center
         DataField       =   "kpitm"
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
         TabIndex        =   0
         TabStop         =   0   'False
         Top             =   310
         Width           =   2895
      End
      Begin VB.TextBox txtAlamat 
         DataField       =   "homeAdd"
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
         Height          =   765
         Left            =   1800
         MultiLine       =   -1  'True
         TabIndex        =   6
         Top             =   2535
         Width           =   4095
      End
      Begin VB.TextBox txtPoskod 
         Alignment       =   2  'Center
         DataField       =   "pos1"
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
         Left            =   6960
         TabIndex        =   7
         Top             =   2520
         Width           =   855
      End
      Begin VB.TextBox txtPhone 
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
         TabIndex        =   10
         Top             =   4320
         Width           =   1935
      End
      Begin VB.TextBox txtPhone2 
         Alignment       =   2  'Center
         DataField       =   "mobilFon"
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
         Left            =   5880
         TabIndex        =   11
         Top             =   4320
         Width           =   1935
      End
      Begin VB.ComboBox cmbSex 
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
         Height          =   315
         ItemData        =   "frmStudent.frx":1773
         Left            =   1800
         List            =   "frmStudent.frx":177D
         TabIndex        =   5
         Top             =   2160
         Width           =   1575
      End
      Begin VB.TextBox Text1 
         DataField       =   "sex"
         DataSource      =   "adoStud"
         Enabled         =   0   'False
         Height          =   285
         Left            =   3480
         TabIndex        =   26
         TabStop         =   0   'False
         Text            =   "Text1"
         Top             =   2160
         Visible         =   0   'False
         Width           =   735
      End
      Begin VB.TextBox txtAlamat2 
         DataField       =   "postalAdd"
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
         Height          =   765
         Left            =   1800
         MultiLine       =   -1  'True
         TabIndex        =   8
         Top             =   3375
         Width           =   4095
      End
      Begin MSDataListLib.DataCombo dcCourse 
         Bindings        =   "frmStudent.frx":178F
         DataField       =   "courseCode"
         DataSource      =   "adoStud"
         Height          =   315
         Left            =   1800
         TabIndex        =   2
         Top             =   1065
         Width           =   1215
         _ExtentX        =   2143
         _ExtentY        =   556
         _Version        =   393216
         Enabled         =   0   'False
         Style           =   2
         ListField       =   "courseCode"
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
      Begin MSDataListLib.DataCombo dcFac 
         Bindings        =   "frmStudent.frx":17A7
         DataField       =   "facName"
         DataSource      =   "Adodc2"
         Height          =   315
         Left            =   1800
         TabIndex        =   1
         Top             =   675
         Width           =   5775
         _ExtentX        =   10186
         _ExtentY        =   556
         _Version        =   393216
         Enabled         =   0   'False
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
      Begin VB.Label Label17 
         BackStyle       =   0  'Transparent
         Caption         =   "Postcode"
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
         Left            =   6000
         TabIndex        =   39
         Top             =   3360
         Width           =   975
      End
      Begin VB.Label Label16 
         BackStyle       =   0  'Transparent
         Caption         =   "Sex"
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
         Left            =   480
         TabIndex        =   38
         Top             =   2160
         Width           =   1455
      End
      Begin VB.Label Label12 
         BackStyle       =   0  'Transparent
         Caption         =   "NRIC No"
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
         Left            =   480
         TabIndex        =   37
         Top             =   1800
         Width           =   1815
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Name"
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
         Left            =   480
         TabIndex        =   36
         Top             =   1440
         Width           =   1455
      End
      Begin VB.Label Label5 
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
         Left            =   480
         TabIndex        =   35
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Address"
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
         Left            =   480
         TabIndex        =   34
         Top             =   2535
         Width           =   1455
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Postcode"
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
         Left            =   6000
         TabIndex        =   33
         Top             =   2520
         Width           =   975
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Phone No"
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
         Left            =   480
         TabIndex        =   32
         Top             =   4320
         Width           =   1455
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "Mobile No"
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
         Left            =   4680
         TabIndex        =   31
         Top             =   4320
         Width           =   1215
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "College"
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
         Left            =   480
         TabIndex        =   30
         Top             =   4680
         Width           =   1215
      End
      Begin VB.Label Label13 
         BackStyle       =   0  'Transparent
         Caption         =   "Postal    Address"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   480
         TabIndex        =   29
         Top             =   3375
         Width           =   1215
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "Faculty"
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
         Left            =   480
         TabIndex        =   28
         Top             =   720
         Width           =   1455
      End
      Begin VB.Label Label15 
         BackStyle       =   0  'Transparent
         Caption         =   "Course"
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
         Left            =   480
         TabIndex        =   27
         Top             =   1080
         Width           =   1815
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Height          =   1575
      Left            =   120
      TabIndex        =   20
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
         TabIndex        =   23
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
         TabIndex        =   22
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
         TabIndex        =   21
         Top             =   180
         Width           =   7575
      End
      Begin VB.Image Image1 
         Appearance      =   0  'Flat
         Height          =   1425
         Left            =   240
         Picture         =   "frmStudent.frx":17BC
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
         TabIndex        =   24
         Top             =   230
         Width           =   7575
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   6255
      Left            =   120
      TabIndex        =   19
      Top             =   1680
      Width           =   975
      Begin VB.CommandButton cmdMaint 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":21C0
         Style           =   1  'Graphical
         TabIndex        =   49
         Top             =   4556
         Width           =   735
      End
      Begin VB.CommandButton cmdUser 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":2A8A
         Style           =   1  'Graphical
         TabIndex        =   48
         Top             =   3830
         Width           =   735
      End
      Begin VB.CommandButton cmdReport 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":3354
         Style           =   1  'Graphical
         TabIndex        =   47
         Top             =   3104
         Width           =   735
      End
      Begin VB.CommandButton cmdExit 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":401E
         Style           =   1  'Graphical
         TabIndex        =   46
         Top             =   5280
         Width           =   735
      End
      Begin VB.CommandButton cmdStud 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":48E8
         Style           =   1  'Graphical
         TabIndex        =   13
         Top             =   200
         Width           =   735
      End
      Begin VB.CommandButton cmdFac 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":51B2
         Style           =   1  'Graphical
         TabIndex        =   14
         Top             =   926
         Width           =   735
      End
      Begin VB.CommandButton cmdEat 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":5A7C
         Style           =   1  'Graphical
         TabIndex        =   15
         Top             =   1652
         Width           =   735
      End
      Begin VB.CommandButton cmdKolej 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmStudent.frx":5D86
         Style           =   1  'Graphical
         TabIndex        =   16
         Top             =   2378
         Width           =   735
      End
   End
   Begin LVbuttons.LaVolpeButton cmdFind 
      Height          =   375
      Left            =   6960
      TabIndex        =   41
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Find Record"
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
      MICON           =   "frmStudent.frx":6650
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
   Begin MSAdodcLib.Adodc adoStud 
      Height          =   330
      Left            =   8040
      Top             =   6840
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from student order by studName"
      Caption         =   "Adodc1"
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
   Begin MSAdodcLib.Adodc adoFac 
      Height          =   330
      Left            =   8760
      Top             =   7080
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from faculty order by facName"
      Caption         =   "Adodc1"
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
   Begin MSAdodcLib.Adodc adoCourse 
      Height          =   330
      Left            =   8760
      Top             =   7320
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=dwnmkn.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select * from course order by courseName"
      Caption         =   "Adodc1"
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
      Left            =   1320
      TabIndex        =   42
      Top             =   6950
      Width           =   7935
   End
End
Attribute VB_Name = "frmStudnt"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim flg As Integer

Private Sub cmbSex_Change()
    If cmbSex.Text = "" Then Exit Sub
    Text1.Text = LCase(Left(cmbSex.Text, 1))
End Sub

Private Sub cmbSex_Click()
    If cmbSex.Text = "" Then Exit Sub
    Text1.Text = LCase(Left(cmbSex.Text, 1))
End Sub

Private Sub cmdAdd_Click()
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed to add new student record.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    flg = 1 'indicates it's a add new operation
    enablekan (True)
    cmbSex.Text = ""
    
    cmdAdd.Visible = False
    cmdEdit.Visible = False
    cmdDel.Visible = False
    cmdFind.Visible = False
    
    adoStud.Recordset.AddNew
End Sub
Private Sub enablekan(lyn As Boolean)
    txtMatrik.Enabled = lyn
    dcFac.Enabled = lyn
    dcCourse.Enabled = lyn
    txtNama.Enabled = lyn
    txtIc.Enabled = lyn
    cmbSex.Enabled = lyn
    txtAlamat.Enabled = lyn
    txtPoskod.Enabled = lyn
    txtAlamat2.Enabled = lyn
    txtPoskod2.Enabled = lyn
    dcCollege.Enabled = lyn
    txtPhone.Enabled = lyn
    txtPhone2.Enabled = lyn
End Sub

Private Sub cmdCancel_Click()
    If flg = 1 Then
        enablekan (False)
        adoStud.Refresh
    End If
    
    If flg = 2 Then
        adoStud.Recordset.CancelUpdate
        adoStud.Refresh
        enablekan (False)
    End If
    cmdAdd.Visible = True
    cmdEdit.Visible = True
    cmdDel.Visible = True
    cmdFind.Visible = True
End Sub

Private Sub cmdDel_Click()
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed to delete student records.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    Dim a As String
    On Error Resume Next
    a = MsgBox("Are you sure you want to delete this record?" & vbCrLf & _
    "UiTM ID: " & adoStud.Recordset.Fields("kpitm").Value & vbCrLf & _
    "Name: " & adoStud.Recordset.Fields("studName").Value, vbYesNo + vbExclamation, "Delete Confirmation")
    If a = vbYes Then
        adoStud.Recordset.Delete
        adoStud.Refresh
        adoStud.Recordset.MoveLast
    Else
        Exit Sub
    End If
End Sub

Private Sub cmdEdit_Click()
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed to edit student record.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    flg = 2 'indicates it's a edit operation
    
    cmdAdd.Visible = False
    cmdEdit.Visible = False
    cmdDel.Visible = False
    cmdFind.Visible = False
    
    enablekan (True)
    txtMatrik.Enabled = False
    'txtMatrik.SetFocus
End Sub

Private Sub cmdFind_Click()
    frmFind.Show
End Sub

Private Sub cmdSave_Click()
    Dim bil As Integer
    Dim ada As Integer
    
    If txtMatrik.Text = "" Then
        MsgBox "Please type your UiTM ID!", vbOKOnly + vbExclamation, "Info Required"
        txtMatrik.SetFocus
        Exit Sub
    Else
        If flg = 2 Then GoTo mmm
        'lets check for redundancy
        adoDum.RecordSource = "SELECT * FROM student WHERE kpitm ='" & txtMatrik.Text & "'"
        adoDum.Refresh
        If adoDum.Recordset.RecordCount <> 0 Then
            MsgBox "Error! The UiTM matric no has already exist.", vbOKOnly + vbExclamation, "Error"
            txtMatrik.SetFocus
            txtMatrik.SelStart = 0
            txtMatrik.SelLength = Len(txtMatrik.Text)
            Exit Sub
        End If
    End If
mmm:
    'If dcFac.Text = "" Then
    '    MsgBox "Please specify your faculty!", vbOKOnly + vbExclamation, "Info Required"
    '    dcFac.SetFocus
    '    Exit Sub
    'End If
    If dcCourse.Text = "" Then
        MsgBox "Please specify your course!", vbOKOnly + vbExclamation, "Info Required"
        dcCourse.SetFocus
        Exit Sub
    End If
    If txtNama.Text = "" Then
        MsgBox "Please specify your name!", vbOKOnly + vbExclamation, "Info Required"
        txtNama.SetFocus
        Exit Sub
    Else
        bil = 1
        ada = 0
        While bil <= Len(CStr(txtNama.Text))
            If IsNumeric(Right(Left(txtNama.Text, bil), 1)) = True Then
                ada = ada + 1
            End If
            bil = bil + 1
        Wend

        If ada > 0 Then
            MsgBox "Only alphabets are allowed for names!", vbOKOnly + vbInformation, "Error"
            txtNama.SelStart = 0
            txtNama.SelLength = Len(txtNama.Text)
            txtNama.SetFocus
            Exit Sub
        End If
    End If
    If txtIc.Text = "" Then
        MsgBox "Please specify your ID number!", vbOKOnly + vbExclamation, "Info Required"
        txtIc.SetFocus
        Exit Sub
    Else
        If Len(txtIc.Text) > 14 Then
            MsgBox "Invalid NRIC no! It cannot be more than 14 digits", vbOKOnly + vbInformation, "NRIC No"
            txtIc.SelStart = 0
            txtIc.SelLength = Len(txtIc.Text)
            txtIc.SetFocus
            Exit Sub
        End If

        bil = 1
        ada = 0
        While bil <= Len(txtIc.Text)
            If IsNumeric(Right(Left(txtIc.Text, bil), 1)) = False And Right(Left(txtIc.Text, bil), 1) <> "-" Then
                ada = ada + 1
            End If
            bil = bil + 1
        Wend
        
        If ada <> 0 Then
            MsgBox "Only numbers are allowed for NRIC!", vbOKOnly + vbInformation, "Error"
            txtIc.SelStart = 0
            txtIc.SelLength = Len(txtIc.Text)
            txtIc.SetFocus
            Exit Sub
        End If
        
        bil = 1
        ada = 0
        While bil <= Len(txtIc.Text)
            If Right(Left(txtIc.Text, bil), 1) = "-" Then
                ada = ada + 1
            End If
            bil = bil + 1
        Wend
        
        If ada < 2 Then
            MsgBox "Invalid NRIC no! " & vbCrLf & _
            "Sample of a valid NRIC no : 801226-01-5177 ", vbOKOnly + vbInformation, "Error"
            txtIc.SelStart = 0
            txtIc.SelLength = Len(txtIc.Text)
            txtIc.SetFocus
            Exit Sub
        End If
    
    End If
    If cmbSex.Text = "" Then
        MsgBox "Please specify your gender!", vbOKOnly + vbExclamation, "Info Required"
        cmbSex.SetFocus
        Exit Sub
    End If
    If txtAlamat.Text = "" Then
        MsgBox "Please specify your address!", vbOKOnly + vbExclamation, "Info Required"
        txtAlamat.SetFocus
        Exit Sub
    End If
    If txtPoskod.Text = "" Then
        MsgBox "Please specify your postcode!", vbOKOnly + vbExclamation, "Info Required"
        txtPoskod.SetFocus
        Exit Sub
    Else
        If Len(txtPoskod.Text) <> 5 Then
            MsgBox "Postcodes must have 5 digits!", vbOKOnly + vbInformation, "Error"
            txtPoskod.SelStart = 0
            txtPoskod.SelLength = Len(txtPoskod.Text)
            txtPoskod.SetFocus
            Exit Sub
        End If
        
        bil = 1
        ada = 0
        While bil <= Len(CStr(txtPoskod.Text))
            If IsNumeric(Right(Left(txtPoskod.Text, bil), 1)) = False Then
                ada = ada + 1
            End If
            bil = bil + 1
        Wend

        If ada <> 0 Then
            MsgBox "Only numbers allowed for postcodes!", vbOKOnly + vbInformation, "Postcode"
            txtPoskod.SelStart = 0
            txtPoskod.SelLength = Len(txtPoskod.Text)
            txtPoskod.SetFocus
            Exit Sub
        End If
    End If
    If txtAlamat2.Text = "" Then
        MsgBox "Please specify your postal address!", vbOKOnly + vbExclamation, "Info Required"
        txtAlamat2.SetFocus
        Exit Sub
    End If
    If txtPoskod2.Text = "" Then
        MsgBox "Please specify your postal postcode!", vbOKOnly + vbExclamation, "Info Required"
        txtPoskod2.SetFocus
        Exit Sub
    Else
        If Len(txtPoskod2.Text) <> 5 Then
            MsgBox "Postcodes must have 5 digits!", vbOKOnly + vbInformation, "Error"
            txtPoskod2.SelStart = 0
            txtPoskod2.SelLength = Len(txtPoskod2.Text)
            txtPoskod2.SetFocus
            Exit Sub
        End If
        
        bil = 1
        ada = 0
        While bil <= Len(CStr(txtPoskod2.Text))
            If IsNumeric(Right(Left(txtPoskod2.Text, bil), 1)) = False Then
                ada = ada + 1
            End If
            bil = bil + 1
        Wend

        If ada <> 0 Then
            MsgBox "Only numbers allowed for postcodes!", vbOKOnly + vbInformation, "Postcode"
            txtPoskod2.SelStart = 0
            txtPoskod2.SelLength = Len(txtPoskod2.Text)
            txtPoskod2.SetFocus
            Exit Sub
        End If
    
    End If
    
    If txtPhone.Text = "" Then
        txtPhone.Text = "0"
    End If
    If txtPhone2.Text = "" Then
        txtPhone2.Text = "0"
    End If
    
    If flg = 1 Then
        adoStud.Recordset.Update
        'adoStud.Refresh
        
        MsgBox "Student record with UiTM ID: " & txtMatrik.Text & " was successfully added!", vbOKOnly + vbInformation, "Database Updated"
        enablekan (False)
        adoStud.RecordSource = "SELECT * FROM student ORDER BY kpitm"
        adoStud.Refresh
    ElseIf flg = 2 Then
        Dim a As String
        a = MsgBox("Are you sure you want to save changes to this student record?", vbYesNo, "Update Record")
        
        If a = vbYes Then
            adoStud.Recordset.UpdateBatch adAffectCurrent
            enablekan (False)
        Else
            adoStud.Recordset.CancelUpdate
            adoStud.Refresh
            enablekan (False)
        End If
    End If
    
    cmdAdd.Visible = True
    cmdEdit.Visible = True
    cmdDel.Visible = True
    cmdFind.Visible = True
End Sub

Private Sub cmdEat_Click()
    frmDine.Show
    Unload Me
End Sub

Private Sub cmdEat_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Dining Hall Attendance"
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

Private Sub dcCourse_Change()
    If dcCourse.Text = "" Then Exit Sub
    Adodc1.RecordSource = "SELECT * FROM course where courseCode ='" & dcCourse.BoundText & "'"
    Adodc1.Refresh
    
    Adodc2.RecordSource = "SELECT * FROM faculty where id =" & Trim(adoCourse.Recordset.Fields("id").Value) & ""
    Adodc2.Refresh
End Sub

Private Sub dcCourse_Click(Area As Integer)
    If dcCourse.Text = "" Then Exit Sub
    Adodc1.RecordSource = "SELECT * FROM course where courseCode ='" & dcCourse.BoundText & "'"
    Adodc1.Refresh
End Sub

Private Sub dcFac_Change()
    'adoCourse.RecordSource = "SELECT * FROM course WHERE id=" & dcFac.BoundText
    'adoCourse.Refresh
End Sub

Private Sub dcFac_Click(Area As Integer)
    If dcFac.Text = "" Then Exit Sub
    adoCourse.RecordSource = "SELECT * FROM course where id =" & dcFac.BoundText
    adoCourse.Refresh
End Sub

Private Sub Frame1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub Frame3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub Text1_Change()
If Text1.Text <> "" Then
    If LCase(Text1.Text) = "m" Then
        cmbSex.Text = "Male"
    Else
        cmbSex.Text = "Female"
    End If
End If
End Sub


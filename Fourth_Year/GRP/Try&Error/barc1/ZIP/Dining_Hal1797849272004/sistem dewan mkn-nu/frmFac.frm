VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmFac 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Faculty and Course Information"
   ClientHeight    =   6435
   ClientLeft      =   2670
   ClientTop       =   2715
   ClientWidth     =   8280
   Icon            =   "frmFac.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6435
   ScaleWidth      =   8280
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Add New Course"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   480
      TabIndex        =   3
      Top             =   3480
      Visible         =   0   'False
      Width           =   6375
      Begin VB.TextBox txtCCode 
         Alignment       =   2  'Center
         DataField       =   "courseCode"
         DataSource      =   "adoCourse"
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
         Left            =   1680
         TabIndex        =   5
         Top             =   480
         Width           =   1455
      End
      Begin VB.TextBox txtCName 
         Alignment       =   2  'Center
         DataField       =   "courseName"
         DataSource      =   "adoCourse"
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
         Left            =   1680
         TabIndex        =   6
         Top             =   840
         Width           =   4455
      End
      Begin LVbuttons.LaVolpeButton cmdSaveCourse 
         Height          =   375
         Left            =   3120
         TabIndex        =   22
         Top             =   1200
         Width           =   1455
         _ExtentX        =   2566
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
         MICON           =   "frmFac.frx":08CA
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
      Begin LVbuttons.LaVolpeButton cmdCanCourse 
         Height          =   375
         Left            =   4680
         TabIndex        =   23
         Top             =   1200
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "C&ancel"
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
         MICON           =   "frmFac.frx":08E6
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
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Course Code"
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
         Left            =   240
         TabIndex        =   7
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Course Name"
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
         Left            =   240
         TabIndex        =   4
         Top             =   840
         Width           =   1455
      End
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2775
      Left            =   120
      TabIndex        =   10
      Top             =   3120
      Width           =   8055
      Begin MSDataGridLib.DataGrid dgCourse 
         Bindings        =   "frmFac.frx":0902
         Height          =   1815
         Left            =   360
         TabIndex        =   11
         Top             =   480
         Width           =   6135
         _ExtentX        =   10821
         _ExtentY        =   3201
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
         ColumnCount     =   2
         BeginProperty Column00 
            DataField       =   "courseCode"
            Caption         =   "Course Code"
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
            DataField       =   "courseName"
            Caption         =   "Course Name"
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
      Begin LVbuttons.LaVolpeButton cmdAdd2 
         Height          =   375
         Left            =   6600
         TabIndex        =   19
         Top             =   480
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Add"
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
         MICON           =   "frmFac.frx":091A
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
      Begin LVbuttons.LaVolpeButton cmdEdit2 
         Height          =   375
         Left            =   6600
         TabIndex        =   20
         Top             =   840
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Edit"
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
         MICON           =   "frmFac.frx":0936
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
      Begin LVbuttons.LaVolpeButton cmdDel2 
         Height          =   375
         Left            =   6600
         TabIndex        =   21
         Top             =   1200
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Delete"
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
         MICON           =   "frmFac.frx":0952
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
      Begin VB.Label Label5 
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
         Left            =   1440
         TabIndex        =   13
         Top             =   2400
         Width           =   3855
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Add New Faculty"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   480
      TabIndex        =   0
      Top             =   720
      Visible         =   0   'False
      Width           =   6375
      Begin VB.TextBox txtFacName 
         Alignment       =   2  'Center
         DataField       =   "facName"
         DataSource      =   "adoFac"
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
         Left            =   1680
         TabIndex        =   1
         TabStop         =   0   'False
         Top             =   360
         Width           =   4455
      End
      Begin LVbuttons.LaVolpeButton cmdSaveFac 
         Height          =   375
         Left            =   3120
         TabIndex        =   14
         Top             =   720
         Width           =   1455
         _ExtentX        =   2566
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
         MICON           =   "frmFac.frx":096E
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
      Begin LVbuttons.LaVolpeButton cmdCanFac 
         Height          =   375
         Left            =   4680
         TabIndex        =   15
         Top             =   720
         Width           =   1455
         _ExtentX        =   2566
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "C&ancel"
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
         MICON           =   "frmFac.frx":098A
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
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Faculty Name"
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
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   1455
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "List of Faculties Available in Universiti Teknologi MARA"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2895
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   8055
      Begin MSAdodcLib.Adodc Adodc2 
         Height          =   330
         Left            =   6960
         Top             =   2400
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
         RecordSource    =   "select * from faculty"
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
      Begin MSDataGridLib.DataGrid dgFac 
         Bindings        =   "frmFac.frx":09A6
         Height          =   1815
         Left            =   360
         TabIndex        =   9
         Top             =   600
         Width           =   6135
         _ExtentX        =   10821
         _ExtentY        =   3201
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
         ColumnCount     =   1
         BeginProperty Column00 
            DataField       =   "facName"
            Caption         =   "Faculty Name"
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
         EndProperty
      End
      Begin LVbuttons.LaVolpeButton cmdAdd1 
         Height          =   375
         Left            =   6600
         TabIndex        =   16
         Top             =   600
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Add"
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
         MICON           =   "frmFac.frx":09BB
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
      Begin LVbuttons.LaVolpeButton cmdEdit1 
         Height          =   375
         Left            =   6600
         TabIndex        =   17
         Top             =   960
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Edit"
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
         MICON           =   "frmFac.frx":09D7
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
      Begin LVbuttons.LaVolpeButton cmdDel1 
         Height          =   375
         Left            =   6600
         TabIndex        =   18
         Top             =   1320
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   661
         BTYPE           =   3
         TX              =   "&Delete"
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
         MICON           =   "frmFac.frx":09F3
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
      Begin VB.Label Label4 
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
         Left            =   1440
         TabIndex        =   12
         Top             =   2520
         Width           =   3855
      End
   End
   Begin MSAdodcLib.Adodc adoCourse 
      Height          =   330
      Left            =   7560
      Top             =   2640
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
      RecordSource    =   "select * from course order by courseCode"
      Caption         =   "adoCourse"
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
      Left            =   7560
      Top             =   3000
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
      Caption         =   "adoFac"
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
   Begin LVbuttons.LaVolpeButton LaVolpeButton1 
      Height          =   375
      Left            =   6720
      TabIndex        =   24
      Top             =   6000
      Width           =   1455
      _ExtentX        =   2566
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
      MICON           =   "frmFac.frx":0A0F
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
Attribute VB_Name = "frmFac"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public flag As Integer
Private Sub cmdAdd1_Click()
    On Error Resume Next
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    flag = 1
    
    Frame1.Visible = True
    Frame1.Caption = "Add New Record"
    adoFac.Recordset.AddNew
    With txtFacName
        .SelStart = 0
        .SelLength = Len(.Text)
        .SetFocus
    End With
End Sub

Private Sub cmdAdd2_Click()
    On Error Resume Next
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    If adoFac.Recordset.Fields("id").Value = "" Then
        MsgBox "You must first select the faculty for the new course!", vbOKOnly + vbInformation, "Select Faculty"
        Exit Sub
    End If
    flag = 1
    
    Frame2.Visible = True
    Frame2.Caption = "Add New Course under " & Me.adoFac.Recordset.Fields("facName").Value
    adoCourse.Recordset.AddNew
    txtCCode.SetFocus
End Sub

Private Sub cmdCanCourse_Click()
    If flag = 1 Then
        adoCourse.Refresh
    Else
        adoCourse.Recordset.CancelUpdate
        adoCourse.Refresh
    End If
    Frame2.Visible = False
End Sub

Private Sub cmdCanFac_Click()
    If flag = 1 Then
        adoFac.Refresh
    Else
        adoFac.Recordset.CancelUpdate
        adoFac.Refresh
    End If
    Frame1.Visible = False
End Sub

Private Sub cmdDel1_Click()
    Dim a As String
    On Error GoTo trapped
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    a = MsgBox("Delete '" & adoFac.Recordset.Fields("facName") & "' from database?", vbYesNo + vbExclamation, "Delete Confirmation")
    If a = vbYes Then
        adoFac.Recordset.Delete
        adoFac.Refresh
        adoFac.Recordset.MoveLast
    Else
        Exit Sub
    End If

        adoFac.RecordSource = "SELECT * FROM faculty order by facName"
        adoFac.Refresh
        
    Label4.Caption = adoFac.Recordset.RecordCount & " record(s) displayed."
    
    Exit Sub
trapped:
    MsgBox Err.Description
    adoFac.RecordSource = "SELECT * FROM faculty order by facName"
    adoFac.Refresh
        
    Label4.Caption = adoFac.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub cmdDel2_Click()
    Dim a As String
    On Error GoTo trapp
    
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    a = MsgBox("Delete '" & adoCourse.Recordset.Fields("courseName") & "' from database?", vbYesNo + vbExclamation, "Delete Confirmation")
    If a = vbYes Then
        adoCourse.Recordset.Delete
        adoCourse.Refresh
        adoCourse.Recordset.MoveLast
    Else
        Exit Sub
    End If

        adoCourse.RecordSource = "SELECT * FROM course WHERE id =" & adoFac.Recordset.Fields("id").Value & " " & _
                                "order by courseName"
        adoCourse.Refresh
        
    Label5.Caption = adoCourse.Recordset.RecordCount & " record(s) displayed."
    
    Exit Sub
trapp:
    MsgBox Err.Description
    adoCourse.RecordSource = "SELECT * FROM course WHERE id =" & adoFac.Recordset.Fields("id").Value & " " & _
                        "order by courseName"
    adoCourse.Refresh
    Label5.Caption = adoCourse.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub cmdEdit1_Click()
    On Error Resume Next
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    flag = 2
    
    Frame1.Visible = True
    Frame1.Caption = "Edit Existing Record"
    With txtFacName
        .SelStart = 0
        .SelLength = Len(.Text)
        .SetFocus
    End With
End Sub

Private Sub cmdEdit2_Click()
    On Error Resume Next
    If curLevel <> 2 Then
        MsgBox "Warning! Only Management staffs are allowed for this action.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    flag = 2
    
    Frame2.Visible = True
    Frame2.Caption = "Edit Existing Course under " & adoFac.Recordset.Fields("facName").Value
    With txtCCode
        .SelStart = 0
        .SelLength = Len(.Text)
        .SetFocus
    End With
End Sub

Private Sub cmdSaveCourse_Click()
    On Error GoTo tankap
If flag = 1 Then
    'check 4 zilch...hehehe
    If txtCCode.Text = "" Then
        MsgBox "Please specify the course code!", vbOKOnly + vbInformation, "Course Code"
        txtCCode.SetFocus
        Exit Sub
    End If
    If txtCName.Text = "" Then
        MsgBox "Please specify the course name!", vbOKOnly + vbInformation, "Course Name"
        txtCName.SetFocus
        Exit Sub
    End If

        'lets check for redundancy
        Adodc2.RecordSource = "SELECT * FROM course WHERE courseCode ='" & txtCCode.Text & "'"
        Adodc2.Refresh
        If Adodc2.Recordset.RecordCount <> 0 Then
            MsgBox "Error ! The course code specified has already exist.", vbOKOnly + vbExclamation, "Error"
            With txtCCode
                .SetFocus
                .SelStart = 0
                .SelLength = Len(.Text)
            End With
            Exit Sub
        End If
    
        Adodc2.RecordSource = "SELECT * FROM course WHERE courseName ='" & txtCName.Text & "'"
        Adodc2.Refresh
        If Adodc2.Recordset.RecordCount <> 0 Then
            MsgBox "Error ! The course name specified has already exist.", vbOKOnly + vbExclamation, "Error"
            With txtCName
                .SetFocus
                .SelStart = 0
                .SelLength = Len(.Text)
            End With
            Exit Sub
        End If
    adoCourse.Recordset.Fields("id").Value = adoFac.Recordset.Fields("id").Value
    adoCourse.Recordset.UpdateBatch adAffectAll
    adoCourse.Refresh
    Frame2.Visible = False
End If

If flag = 2 Then
    Dim a As String
   
    a = MsgBox("Update this record?", vbYesNo + vbQuestion, "Update?")
    
    If a = vbYes Then
        adoCourse.Recordset.UpdateBatch adAffectCurrent
        Frame2.Visible = False
    Else
        Frame2.Visible = False
        adoCourse.Recordset.CancelUpdate
        adoCourse.Refresh
    End If
    Frame2.Visible = False
End If
    adoCourse.RecordSource = "SELECT * FROM course " & _
                  "WHERE id = " & Me.adoFac.Recordset.Fields("id").Value
    adoCourse.Refresh
    Label5.Caption = adoCourse.Recordset.RecordCount & " record(s) displayed."
    Exit Sub
tankap:
    MsgBox Err.Description
End Sub

Private Sub cmdSaveFac_Click()

If flag = 1 Then
    'check 4 zilch...hehehe
    If txtFacName.Text = "" Then
        MsgBox "Please specify the faculty name!", vbOKOnly + vbInformation, "Faculty Name"
        txtFacName.SetFocus
        Exit Sub
    Else

        'lets check for redundancy
        Adodc2.RecordSource = "SELECT * FROM faculty WHERE facName ='" & txtFacName.Text & "'"
        Adodc2.Refresh
        If Adodc2.Recordset.RecordCount <> 0 Then
            MsgBox "Error ! The faculty name specified has already exist.", vbOKOnly + vbExclamation, "Error"
            With txtFacName
                .SetFocus
                .SelStart = 0
                .SelLength = Len(.Text)
            End With
            Exit Sub
        End If
    End If
    
    adoFac.Recordset.UpdateBatch adAffectAll
    adoFac.Refresh
    Frame1.Visible = False
End If

If flag = 2 Then
    Dim a As String
   
    a = MsgBox("Update this record?", vbYesNo + vbQuestion, "Update?")
    
    If a = vbYes Then
        adoFac.Recordset.UpdateBatch adAffectCurrent
        Frame1.Visible = False
    Else
        Frame1.Visible = False
        adoFac.Recordset.CancelUpdate
        adoFac.Refresh
    End If
    Frame1.Visible = False
End If
    adoFac.RecordSource = "SELECT * FROM faculty order by facName"
    adoFac.Refresh
    Label4.Caption = adoFac.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub dgFac_Click()
    If adoFac.Recordset.RecordCount <> 0 Then
        Frame4.Caption = "Courses under " & Me.adoFac.Recordset.Fields("facName").Value
        adoCourse.RecordSource = "SELECT * FROM course " & _
                            "WHERE id = " & Me.adoFac.Recordset.Fields("id").Value
        adoCourse.Refresh
        Label5.Caption = adoCourse.Recordset.RecordCount & " record(s) displayed."
    End If
End Sub

Private Sub Form_Load()
    adoFac.RecordSource = "SELECT * FROM faculty order by facName"
    adoFac.Refresh
    Label4.Caption = adoFac.Recordset.RecordCount & " record(s) displayed."
End Sub

Private Sub LaVolpeButton1_Click()
    Unload Me
End Sub

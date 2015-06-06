VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmUser 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "MARA University of Technology :: Dining Hall Management System    v1.0"
   ClientHeight    =   8040
   ClientLeft      =   2130
   ClientTop       =   1770
   ClientWidth     =   9330
   Icon            =   "frmUser.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   8040
   ScaleWidth      =   9330
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Height          =   1575
      Left            =   120
      TabIndex        =   22
      Top             =   0
      Width           =   9135
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
         TabIndex        =   25
         Top             =   180
         Width           =   7575
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
         TabIndex        =   26
         Top             =   230
         Width           =   7575
      End
      Begin VB.Image Image1 
         Appearance      =   0  'Flat
         Height          =   1425
         Left            =   240
         Picture         =   "frmUser.frx":0CCA
         Top             =   120
         Width           =   1290
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
         TabIndex        =   24
         Top             =   720
         Width           =   5775
      End
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
   End
   Begin LVbuttons.LaVolpeButton cmdDel 
      Height          =   375
      Left            =   5325
      TabIndex        =   15
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Delete User"
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
      MICON           =   "frmUser.frx":16CE
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
      Left            =   3555
      TabIndex        =   12
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Edit User"
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
      MICON           =   "frmUser.frx":16EA
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
      Left            =   1800
      TabIndex        =   11
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&New User"
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
      MICON           =   "frmUser.frx":1706
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
      Caption         =   "System User Information"
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
      TabIndex        =   14
      Top             =   1680
      Width           =   8055
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
         Height          =   3015
         Left            =   600
         TabIndex        =   28
         Top             =   1080
         Visible         =   0   'False
         Width           =   6855
         Begin VB.CommandButton Command1 
            Caption         =   "Command1"
            Height          =   495
            Left            =   5160
            TabIndex        =   38
            Top             =   1320
            Width           =   855
         End
         Begin VB.TextBox txtPass2 
            Alignment       =   2  'Center
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
            IMEMode         =   3  'DISABLE
            Left            =   2280
            PasswordChar    =   "*"
            TabIndex        =   4
            Top             =   1800
            Width           =   2415
         End
         Begin VB.TextBox txtLevel 
            DataField       =   "userLevel"
            DataSource      =   "adoUser"
            Height          =   285
            Left            =   4080
            TabIndex        =   35
            TabStop         =   0   'False
            Top             =   1050
            Width           =   495
         End
         Begin VB.TextBox txtPass 
            Alignment       =   2  'Center
            DataField       =   "userPass"
            DataSource      =   "adoUser"
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
            IMEMode         =   3  'DISABLE
            Left            =   2280
            PasswordChar    =   "*"
            TabIndex        =   3
            Top             =   1440
            Width           =   2415
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
            ItemData        =   "frmUser.frx":1722
            Left            =   2280
            List            =   "frmUser.frx":172F
            TabIndex        =   2
            Text            =   "Combo1"
            Top             =   1060
            Width           =   1815
         End
         Begin VB.TextBox txtLogin 
            Alignment       =   2  'Center
            DataField       =   "userLogin"
            DataSource      =   "adoUser"
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
            Left            =   2280
            TabIndex        =   1
            Top             =   710
            Width           =   2895
         End
         Begin VB.TextBox txtName 
            Alignment       =   2  'Center
            DataField       =   "userName"
            DataSource      =   "adoUser"
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
            Left            =   2280
            TabIndex        =   0
            Top             =   360
            Width           =   4215
         End
         Begin LVbuttons.LaVolpeButton cmdCancel 
            Height          =   375
            Left            =   3960
            TabIndex        =   6
            Top             =   2280
            Width           =   1575
            _ExtentX        =   2778
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
            MICON           =   "frmUser.frx":175C
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
            Left            =   1440
            TabIndex        =   5
            Top             =   2280
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
            MICON           =   "frmUser.frx":1778
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
         Begin VB.Label Label10 
            BackStyle       =   0  'Transparent
            Caption         =   "Retype Password"
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
            Top             =   1815
            Width           =   1695
         End
         Begin VB.Label Label9 
            BackStyle       =   0  'Transparent
            Caption         =   "Password"
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
            Top             =   1455
            Width           =   1455
         End
         Begin VB.Label Label6 
            BackStyle       =   0  'Transparent
            Caption         =   "User ID"
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
            TabIndex        =   31
            Top             =   735
            Width           =   1455
         End
         Begin VB.Label Label15 
            BackStyle       =   0  'Transparent
            Caption         =   "Level"
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
            Top             =   1095
            Width           =   1815
         End
         Begin VB.Label Label5 
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
            TabIndex        =   29
            Top             =   375
            Width           =   1455
         End
      End
      Begin MSDataGridLib.DataGrid DataGrid1 
         Bindings        =   "frmUser.frx":1794
         Height          =   2295
         Left            =   600
         TabIndex        =   27
         Top             =   1800
         Width           =   6855
         _ExtentX        =   12091
         _ExtentY        =   4048
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
         ColumnCount     =   4
         BeginProperty Column00 
            DataField       =   "userLogin"
            Caption         =   "User ID"
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
            DataField       =   "id"
            Caption         =   "id"
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
            DataField       =   "userName"
            Caption         =   "User Name"
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
         BeginProperty Column03 
            DataField       =   "userLevel"
            Caption         =   "Level"
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
               Object.Visible         =   0   'False
            EndProperty
            BeginProperty Column02 
            EndProperty
            BeginProperty Column03 
               Alignment       =   2
            EndProperty
         EndProperty
      End
      Begin VB.Label Label11 
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
         TabIndex        =   37
         Top             =   4320
         Width           =   3855
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "* User level are divided into 3 which is 1-Administrator  2-Management  3-Normal"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Left            =   480
         TabIndex        =   33
         Top             =   1080
         Width           =   7095
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Listed below are the users of this system. Click on a record to edit/update or delete records."
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   480
         TabIndex        =   32
         Top             =   480
         Width           =   7095
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   6255
      Left            =   120
      TabIndex        =   13
      Top             =   1680
      Width           =   975
      Begin VB.CommandButton cmdMaint 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":17AA
         Style           =   1  'Graphical
         TabIndex        =   21
         Top             =   4556
         Width           =   735
      End
      Begin VB.CommandButton cmdUser 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":2074
         Style           =   1  'Graphical
         TabIndex        =   20
         Top             =   3830
         Width           =   735
      End
      Begin VB.CommandButton cmdReport 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":293E
         Style           =   1  'Graphical
         TabIndex        =   19
         Top             =   3104
         Width           =   735
      End
      Begin VB.CommandButton cmdExit 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":3608
         Style           =   1  'Graphical
         TabIndex        =   18
         Top             =   5280
         Width           =   735
      End
      Begin VB.CommandButton cmdStud 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":3ED2
         Style           =   1  'Graphical
         TabIndex        =   7
         Top             =   200
         Width           =   735
      End
      Begin VB.CommandButton cmdFac 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":479C
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   926
         Width           =   735
      End
      Begin VB.CommandButton cmdEat 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":5066
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   1652
         Width           =   735
      End
      Begin VB.CommandButton cmdKolej 
         BackColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   120
         Picture         =   "frmUser.frx":5370
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   2378
         Width           =   735
      End
   End
   Begin LVbuttons.LaVolpeButton cmdRefresh 
      Height          =   375
      Left            =   7080
      TabIndex        =   16
      Top             =   7320
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      BTYPE           =   3
      TX              =   "&Refresh"
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
      MICON           =   "frmUser.frx":5C3A
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
   Begin MSAdodcLib.Adodc adoUser 
      Height          =   330
      Left            =   8160
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
      RecordSource    =   "select * from user order by userName"
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
      TabIndex        =   17
      Top             =   6950
      Width           =   7935
   End
End
Attribute VB_Name = "frmUser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public flagItu As Integer
Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd _
As Long, ByVal bRevert As Boolean) As Long
   
Private Declare Function GetMenuItemCount Lib "user32" (ByVal _
hMenu As Long) As Long
   
Private Declare Function RemoveMenu Lib "user32" (ByVal _
hMenu As Long, ByVal nPosition As Long, ByVal wFlags As Long) _
As Long
   
Private Declare Function DrawMenuBar Lib "user32" _
   (ByVal hwnd As Long) As Long

Private Const MF_BYPOSITION = &H400&
Private Const MF_REMOVE = &H1000&

Public Sub DisableClose(frm As Form, Optional Disable As Boolean = True)
    'Setting Disable to False disables the 'X',
     'otherwise, it's reset

    Dim hMenu As Long
    Dim nCount As Long
    
    If Disable Then
        hMenu = GetSystemMenu(frm.hwnd, False)
        nCount = GetMenuItemCount(hMenu)
        
        Call RemoveMenu(hMenu, nCount - 1, MF_REMOVE Or _
            MF_BYPOSITION)
        Call RemoveMenu(hMenu, nCount - 2, MF_REMOVE Or _
            MF_BYPOSITION)
    
        DrawMenuBar frm.hwnd
    Else
        GetSystemMenu frm.hwnd, True
        
        DrawMenuBar frm.hwnd
    End If

End Sub

Private Sub cmdAdd_Click()
    If curLevel <> 1 Then
        MsgBox "Warning! Only Administrators are allowed to add new user account details.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    flagItu = 1
    Frame4.Visible = True
    Frame4.Caption = "New User"
    Me.Combo1.Text = ""
    enable (True)
    adoUser.Recordset.AddNew
    txtName.SetFocus
End Sub
Private Sub enable(lyn As Boolean)
    txtName.Enabled = lyn
    txtLogin.Enabled = lyn
    Combo1.Enabled = lyn
    txtPass.Enabled = lyn
    txtPass2.Enabled = lyn
End Sub
Private Sub cmdCancel_Click()
    If flagItu = 1 Then
        adoUser.Refresh
    ElseIf flagItu = 2 Then
        adoUser.Recordset.CancelUpdate
        adoUser.Refresh
    End If
    Frame4.Visible = False
End Sub

Private Sub cmdDel_Click()
    Dim a As String
    
    If curLevel <> 1 Then
        MsgBox "Warning! Only Administrators are allowed to delete user account details.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
    On Error Resume Next
    a = MsgBox("Are you sure you want to delete the user '" & adoUser.Recordset.Fields("userName").Value & "'?", vbYesNo + vbExclamation, "Delete Confirmation")
    If a = vbYes Then
      With adoUser
        .Recordset.Delete
      End With
    Else
        Exit Sub
    End If
End Sub

Private Sub cmdEat_Click()
    frmDine.Show
    Unload Me
End Sub

Private Sub cmdEat_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Dining Hall Attendance"
End Sub

Private Sub cmdEdit_Click()
    If curLevel = 1 Then
        GoTo bypass
    End If
    If curLogin <> adoUser.Recordset.Fields("userLogin").Value Then
        MsgBox "Warning! You can only edit your own account details.", vbOKOnly + vbExclamation, "Warning"
        Exit Sub
    End If
    
bypass:
    flagItu = 2
    Me.Frame4.Visible = True
    Frame4.Caption = "Edit User"
    enable (True)
    txtPass2.Text = txtPass.Text
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

Private Sub cmdRefresh_Click()
    adoUser.Refresh
End Sub

Private Sub cmdReport_Click()
    frmReport2.Show
End Sub

Private Sub cmdReport_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Dining Hall Attendance Report"
End Sub

Private Sub cmdSave_Click()
    On Error GoTo them
    If txtPass.Text <> txtPass2.Text Then
        MsgBox "Please retype your password. Password specified do not tally!", vbOKOnly + vbCritical, "Retype Password"
        txtPass2.Text = ""
        txtPass2.SetFocus
        Exit Sub
    End If
    If flagItu = 1 Then
        adoUser.Recordset.UpdateBatch adAffectAll
        adoUser.Refresh
        MsgBox "New user '" & txtLogin.Text & "' was successfully added.", vbOKOnly + vbInformation, "User Added"
    ElseIf flagItu = 2 Then
        Dim ans As String
        ans = MsgBox("Save changes to user '" & txtLogin.Text & "' account?", vbYesNo + vbQuestion, "Confirmation")
        If ans <> vbYes Then GoTo here
        adoUser.Recordset.UpdateBatch adAffectCurrent
        adoUser.Refresh
        MsgBox "Changes to account of user '" & txtLogin.Text & "' was saved.", vbOKOnly + vbInformation, "Changes Saved"
    End If
here:
    enable (False)
    Exit Sub
them:
    MsgBox Err.Description
End Sub

Private Sub cmdStud_Click()
    frmStudnt.Show
    Unload Me
End Sub

Private Sub cmduser_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "User Management"
End Sub
Private Sub cmdStud_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = "Student Information"
End Sub

Private Sub Combo1_Click()
    If Combo1.Text = "" Then Exit Sub
    txtLevel.Text = LCase(Left(Combo1.Text, 1))
End Sub

Private Sub Combo1_KeyPress(KeyAscii As Integer)
    KeyAscii = 0
End Sub

Private Sub Command1_Click()
    txtPass.PasswordChar = ""
End Sub

Private Sub Form_Load()
    DisableClose Me
End Sub

Private Sub Frame1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub Frame3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    mylbl.Caption = ""
End Sub

Private Sub txtLevel_Change()
    If txtLevel.Text = "" Then Exit Sub
    
    If CInt(txtLevel.Text) = 1 Then
        Combo1.Text = "1-Administrator"
    ElseIf CInt(txtLevel.Text) = 2 Then
        Combo1.Text = "2-Management"
    ElseIf CInt(txtLevel.Text) = 3 Then
        Combo1.Text = "3-Normal"
    End If
End Sub


VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "lvbuttons.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmMain 
   BackColor       =   &H00DFB493&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Personal Reloadable Card System"
   ClientHeight    =   6855
   ClientLeft      =   1200
   ClientTop       =   930
   ClientWidth     =   8880
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6855
   ScaleWidth      =   8880
   Begin MSComctlLib.ImageList imglstIcons 
      Left            =   8160
      Top             =   6120
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   32
      ImageHeight     =   32
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   19
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":08CA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":662C
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":6CBE
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":C4B0
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":CEC2
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":D8D4
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":FC56
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14D88
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14DE6
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":157F8
            Key             =   ""
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":160D2
            Key             =   ""
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":169AC
            Key             =   ""
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":17286
            Key             =   ""
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":17B60
            Key             =   ""
         EndProperty
         BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1843A
            Key             =   ""
         EndProperty
         BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":18D14
            Key             =   ""
         EndProperty
         BeginProperty ListImage17 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":195EE
            Key             =   ""
         EndProperty
         BeginProperty ListImage18 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":19EC8
            Key             =   ""
         EndProperty
         BeginProperty ListImage19 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1A7A2
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Frame fraMenu 
      BackColor       =   &H00DFB493&
      Height          =   6015
      Left            =   120
      TabIndex        =   14
      Top             =   720
      Width           =   1935
      Begin LVbuttons.LaVolpeButton cmdSales 
         Height          =   615
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "S&ales Form"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B07C
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "18"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdManageItems 
         Height          =   615
         Left            =   120
         TabIndex        =   5
         Top             =   960
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "Mana&ge Items"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B098
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "19"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdReload 
         Height          =   615
         Left            =   120
         TabIndex        =   4
         Top             =   960
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Reload"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B0B4
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "17"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdAccounts 
         Height          =   615
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Accounts"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B0D0
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "11"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdReports 
         Height          =   615
         Left            =   120
         TabIndex        =   7
         Top             =   2400
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "Report&s"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B0EC
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "14"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdOptions 
         Height          =   615
         Left            =   120
         TabIndex        =   8
         Top             =   3120
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Options"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B108
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "16"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdClose 
         Height          =   615
         Left            =   120
         TabIndex        =   11
         Top             =   5280
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Close"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B124
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "13"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdInquire 
         Height          =   615
         Left            =   120
         TabIndex        =   6
         Top             =   1680
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Balance Inquiry"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B140
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "12"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdAbout 
         Height          =   615
         Left            =   120
         TabIndex        =   10
         Top             =   4560
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "Abou&t"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B15C
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "10"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdHelp 
         Height          =   615
         Left            =   120
         TabIndex        =   9
         Top             =   3840
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   1085
         BTYPE           =   3
         TX              =   "&Help"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
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
         MICON           =   "frmMain.frx":1B178
         ALIGN           =   0
         IMGLST          =   "imglstIcons"
         IMGICON         =   "15"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   -1  'True
         BSTYLE          =   0
      End
   End
   Begin VB.Frame fraReports 
      BackColor       =   &H00DFB493&
      BorderStyle     =   0  'None
      Height          =   3135
      Left            =   2760
      TabIndex        =   24
      Top             =   3480
      Visible         =   0   'False
      Width           =   5895
      Begin LVbuttons.LaVolpeButton cmdPurchaseHistory 
         Height          =   375
         Left            =   960
         TabIndex        =   25
         Top             =   2160
         Width           =   3735
         _ExtentX        =   6588
         _ExtentY        =   661
         BTYPE           =   6
         TX              =   "  P&urchase History"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   2
         BCOL            =   14660755
         FCOL            =   12582912
         FCOLO           =   16777088
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmMain.frx":1B194
         ALIGN           =   0
         IMGLST          =   "(None)"
         IMGICON         =   "(None)"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   0   'False
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdSalesReport 
         Height          =   375
         Left            =   960
         TabIndex        =   26
         Top             =   720
         Width           =   3735
         _ExtentX        =   6588
         _ExtentY        =   661
         BTYPE           =   6
         TX              =   "  Sales Re&port"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   2
         BCOL            =   14660755
         FCOL            =   12582912
         FCOLO           =   16777088
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmMain.frx":1B1B0
         ALIGN           =   0
         IMGLST          =   "(None)"
         IMGICON         =   "(None)"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   0   'False
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdReloadHistory 
         Height          =   375
         Left            =   960
         TabIndex        =   27
         Top             =   1680
         Width           =   3735
         _ExtentX        =   6588
         _ExtentY        =   661
         BTYPE           =   6
         TX              =   "  &Reloading History"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   2
         BCOL            =   14660755
         FCOL            =   12582912
         FCOLO           =   16777088
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmMain.frx":1B1CC
         ALIGN           =   0
         IMGLST          =   "(None)"
         IMGICON         =   "(None)"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   0   'False
         BSTYLE          =   0
      End
      Begin LVbuttons.LaVolpeButton cmdReloadReport 
         Height          =   375
         Left            =   960
         TabIndex        =   28
         Top             =   1200
         Width           =   3735
         _ExtentX        =   6588
         _ExtentY        =   661
         BTYPE           =   6
         TX              =   "  Reloa&d Report"
         ENAB            =   -1  'True
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         COLTYPE         =   2
         BCOL            =   14660755
         FCOL            =   12582912
         FCOLO           =   16777088
         EMBOSSM         =   12632256
         EMBOSSS         =   16777215
         MPTR            =   0
         MICON           =   "frmMain.frx":1B1E8
         ALIGN           =   0
         IMGLST          =   "(None)"
         IMGICON         =   "(None)"
         ICONAlign       =   0
         ORIENT          =   0
         STYLE           =   0
         IconSize        =   3
         SHOWF           =   0   'False
         BSTYLE          =   0
      End
   End
   Begin VB.Frame fraDescription 
      BackColor       =   &H00DFB493&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   6015
      Left            =   2160
      TabIndex        =   12
      Top             =   720
      Width           =   6615
      Begin VB.Frame fraOptions 
         BackColor       =   &H00DFB493&
         BorderStyle     =   0  'None
         Height          =   3135
         Left            =   600
         TabIndex        =   15
         Top             =   2760
         Visible         =   0   'False
         Width           =   5175
         Begin LVbuttons.LaVolpeButton cmdChangeLoad 
            Height          =   375
            Left            =   960
            TabIndex        =   16
            Top             =   240
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Change Load &Denomination"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B204
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdChangeUserAccount 
            Height          =   375
            Left            =   960
            TabIndex        =   17
            Top             =   2160
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Change &UserName / Password"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B220
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdSetMinBalance 
            Height          =   375
            Left            =   960
            TabIndex        =   18
            Top             =   2640
            Visible         =   0   'False
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Set &Minimum Balance Requirement"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B23C
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdUpdatePicPath 
            Height          =   375
            Left            =   960
            TabIndex        =   19
            Top             =   720
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Update &Picture Location"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B258
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdManageUsers 
            Height          =   375
            Left            =   960
            TabIndex        =   20
            Top             =   1200
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Manage Us&ers  "
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B274
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdUsersLog 
            Height          =   375
            Left            =   960
            TabIndex        =   29
            Top             =   1680
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  Users &Log    "
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B290
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
      End
      Begin VB.Frame fraClose 
         BackColor       =   &H00DFB493&
         BorderStyle     =   0  'None
         Height          =   3015
         Left            =   600
         TabIndex        =   21
         Top             =   2760
         Visible         =   0   'False
         Width           =   5295
         Begin LVbuttons.LaVolpeButton cmdLogOut 
            Height          =   375
            Left            =   960
            TabIndex        =   22
            Top             =   1680
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  &Log Out"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B2AC
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
         Begin LVbuttons.LaVolpeButton cmdExit 
            Height          =   375
            Left            =   960
            TabIndex        =   23
            Top             =   2160
            Width           =   3735
            _ExtentX        =   6588
            _ExtentY        =   661
            BTYPE           =   6
            TX              =   "  &Exit"
            ENAB            =   -1  'True
            BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            COLTYPE         =   2
            BCOL            =   14660755
            FCOL            =   12582912
            FCOLO           =   16777088
            EMBOSSM         =   12632256
            EMBOSSS         =   16777215
            MPTR            =   0
            MICON           =   "frmMain.frx":1B2C8
            ALIGN           =   0
            IMGLST          =   "(None)"
            IMGICON         =   "(None)"
            ICONAlign       =   0
            ORIENT          =   0
            STYLE           =   0
            IconSize        =   3
            SHOWF           =   0   'False
            BSTYLE          =   0
         End
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00800000&
         Caption         =   "    Personal Reloadable Card   System "
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
         Height          =   975
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   6375
      End
      Begin VB.Label lblDescription 
         Alignment       =   2  'Center
         BackColor       =   &H00DFB493&
         Caption         =   "Description"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   615
         Left            =   1320
         TabIndex        =   13
         Top             =   1920
         Width           =   3735
      End
   End
   Begin VB.Label lblTerminal 
      BackColor       =   &H00800000&
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
      TabIndex        =   0
      Top             =   0
      Width           =   9015
   End
   Begin VB.Menu mnuMain 
      Caption         =   "&Main"
      Visible         =   0   'False
      Begin VB.Menu mnuLogout 
         Caption         =   "&Log out"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "&Exit"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub ShowDescription(cmdButton As LaVolpeButton, ByVal Description As String)
    'If fraOptions.Visible = False Then
    On Error GoTo hErr
        If Len(Description) = 0 Then
            lblDescription.Caption = "Select item from the left pane to perform an operation."
        Else
            lblDescription.Caption = Description
        End If
    'End If
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

Private Sub cmdAbout_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    Call ShowLogoForm(False)
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

Private Sub cmdAbout_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdAbout, "Display information about this system.")
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

Private Sub cmdAbout_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdAbout, "")
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

Private Sub cmdAccounts_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    frmAccounts.Show vbModal
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

Private Sub cmdAccounts_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdAccounts, "Lets you manage Personal Reloadable Card accounts")
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

Private Sub cmdAccounts_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdAccounts, "")
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

Private Sub cmdExit_Click()
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

Private Sub cmdLogOut_Click()
    On Error GoTo hErr
    If MsgBox("Are you sure you want to log out?", vbQuestion + _
       vbDefaultButton1 + vbYesNo, "Log Out") = vbYes Then
        Call LogUser  ' record logout time
        g_blnMasterUser = False
        g_lngMinimumBalance = 0
        g_lngTerminalID = 0
        g_lngUserID = 0
        g_strUserName = ""
        g_lngLogId = 0
        'Call ShowLogoForm(True)
        Unload Me
        Call Main
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

Private Sub cmdManageItems_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    Call ShowDescription(cmdManageItems, "")
    frmItems.Show vbModal
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

Private Sub cmdManageItems_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdManageItems, "Add / remove items or modify item prices.")
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

Private Sub cmdManageItems_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdManageItems, "")
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

Private Sub cmdChangeLoad_Click()
    On Error GoTo hErr
    frmLoadDenomination.Show vbModal
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

Private Sub cmdChangeUserAccount_Click()
    On Error GoTo hErr
    frmChangeUserInfo.Show vbModal
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

Private Sub cmdClose_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraReports.Visible = False
    fraClose.Visible = True
    'Unload Me
    'PopupMenu mnuMain, , cmdClose.Left + cmdClose.Width, cmdClose.Top + cmdClose.Height + 100
    
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

Private Sub cmdClose_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdClose, "Closes this program.")
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

Private Sub cmdClose_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdClose, "")
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

Private Sub cmdPurchaseHistory_Click()
    On Error GoTo hErr
    frmHistoryReport.p_histReport = HistoryType.Purchase
    frmHistoryReport.Show vbModal
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

Private Sub cmdReloadHistory_Click()
    On Error GoTo hErr
    frmHistoryReport.p_histReport = HistoryType.Reloading
    frmHistoryReport.Show vbModal
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

Private Sub cmdReloadReport_Click()
    On Error GoTo hErr
    frmReloadReport.Show vbModal
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

Private Sub cmdReports_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = True
    'frmSalesReport.Show vbModal
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

Private Sub cmdReports_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdReports, "Print Reports")
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

Private Sub cmdReports_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdReports, "")
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

Private Sub cmdHelp_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    'Call ShowHelp(Me.hwnd)
    SendKeys "{F1}"
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

Private Sub cmdHelp_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdHelp, "Display help on using this system.")
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

Private Sub cmdHelp_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdHelp, "")
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

Private Sub cmdInquire_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    frmBalanceInq.Show vbModal
    Call ShowDescription(cmdInquire, "")
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

Private Sub cmdInquire_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdInquire, "Shows the remaining balance of a Personal Reloadable Card account")
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

Private Sub cmdInquire_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdInquire, "")
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

Private Sub cmdManageUsers_Click()
    On Error GoTo hErr
    frmUsers.Show vbModal
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

Private Sub cmdOptions_Click()
    On Error GoTo hErr
    fraClose.Visible = False
    fraReports.Visible = False
    fraOptions.Visible = True
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

Private Sub cmdOptions_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdOptions, "Change password or specify minimum balance requirement.")
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

Private Sub cmdOptions_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdOptions, "")
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

Private Sub cmdReload_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    frmReload.Show vbModal
    Call ShowDescription(cmdReload, "")
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

Private Sub cmdReload_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdReload, "Reload specified amount in a Personal Reloadable Card account")
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

Private Sub cmdReload_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdReload, "")
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

Private Sub cmdSales_Click()
    On Error GoTo hErr
    fraOptions.Visible = False
    fraClose.Visible = False
    fraReports.Visible = False
    Call ShowDescription(cmdSales, "")
    frmSales.Show vbModal
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

Private Sub cmdSales_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    On Error GoTo hErr
    Call ShowDescription(cmdSales, "Displays the sales form and perform transactions.")
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

Private Sub cmdSales_MouseOut()
    On Error GoTo hErr
    Call ShowDescription(cmdSales, "")
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

Private Sub cmdSalesReport_Click()
    On Error GoTo hErr
    frmSalesReport.Show vbModal
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

Private Sub cmdSetMinBalance_Click()
    On Error GoTo hErr
    frmMinBalance.Show vbModal
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

Private Sub cmdUpdatePicPath_Click()
    On Error GoTo hErr
    frmBrowseFolder.Show vbModal
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

Private Sub cmdUsersLog_Click()
    frmUserLog.Show vbModal
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
    lblDescription.Caption = ""
'    Set oHtmlHelp = New CHtmlHelp
'    oHtmlHelp.FileName = App.Path & "\Help\PREC.chm"
    App.HelpFile = App.Path & "\Help\PREC.chm"
    SaveSetting "Personal Reloadable Card", "Settings", _
       "Program Location", App.Path & "\" & App.EXEName & ".exe"
    
    cmdManageItems.Enabled = g_blnMasterUser
    cmdReload.Enabled = g_blnMasterUser
    cmdOptions.Enabled = g_blnMasterUser
    cmdAccounts.Enabled = g_blnMasterUser
    cmdUsersLog.Enabled = g_blnMasterUser
    
    Select Case g_lngTerminalID
        Case 1, 2  ' Canteen or Bookstore
            cmdReload.Enabled = False
            cmdAccounts.Enabled = False
            cmdChangeLoad.Enabled = False
            cmdSetMinBalance.Enabled = False
            cmdUpdatePicPath.Enabled = False
            cmdReloadReport.Enabled = False
            cmdReloadHistory.Enabled = False
            cmdPurchaseHistory.Enabled = False
        Case 3  ' Accounting
            cmdSales.Visible = False
            cmdManageItems.Visible = False
    End Select
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
    On Error Resume Next
    
    Dim frm As Form
    'oHtmlHelp.CloseHelp
'    Set oHtmlHelp = Nothing
    If g_lngUserID <> 0 Then
        Call LogUser  ' record logout time
    End If
    
    g_dbPRECDb.CloseConnection
    Set g_dbPRECDb = Nothing
    
    For Each frm In Forms
        Unload frm
        Set frm = Nothing
    Next frm
End Sub

Private Sub mnuExit_Click()
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

Private Sub mnuLogout_Click()
    On Error GoTo hErr
    g_blnMasterUser = False
    g_lngMinimumBalance = 0
    g_lngTerminalID = 0
    g_lngUserID = 0
    g_strUserName = ""
    Call ShowLogoForm(True)
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

VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form fMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "0"
   ClientHeight    =   9000
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   12000
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   9.75
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   HasDC           =   0   'False
   Icon            =   "Main.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   ScaleHeight     =   9000
   ScaleWidth      =   12000
   StartUpPosition =   2  'CenterScreen
   Begin MSCommLib.MSComm mscBarcode 
      Left            =   120
      Top             =   870
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
   End
   Begin VB.Timer tmrTime 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   9780
      Top             =   7350
   End
   Begin VB.PictureBox picControlBox 
      BorderStyle     =   0  'None
      Height          =   255
      Left            =   10980
      ScaleHeight     =   255
      ScaleWidth      =   1020
      TabIndex        =   7
      TabStop         =   0   'False
      Top             =   0
      Visible         =   0   'False
      Width           =   1020
      Begin VB.Image imgButtons 
         Height          =   200
         Index           =   8
         Left            =   405
         Tag             =   "F12"
         ToolTipText     =   "8"
         Top             =   30
         Width           =   585
      End
      Begin VB.Image imgButtons 
         Height          =   200
         Index           =   7
         Left            =   30
         Tag             =   "F11"
         ToolTipText     =   "7"
         Top             =   30
         Width           =   345
      End
   End
   Begin MSComctlLib.ImageList ilsImages 
      Left            =   120
      Top             =   120
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      MaskColor       =   12632256
      _Version        =   393216
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   0
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   8
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin RichTextLib.RichTextBox rtbHelp 
         Height          =   5000
         Left            =   0
         TabIndex        =   9
         TabStop         =   0   'False
         Top             =   0
         Width           =   6000
         _ExtentX        =   10583
         _ExtentY        =   8811
         _Version        =   393217
         BackColor       =   16777215
         BorderStyle     =   0
         Enabled         =   -1  'True
         ReadOnly        =   -1  'True
         ScrollBars      =   2
         Appearance      =   0
         OLEDragMode     =   0
         OLEDropMode     =   0
         TextRTF         =   $"Main.frx":08CA
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   1
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   10
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin VB.CommandButton cmdActive 
         Caption         =   "0"
         Height          =   480
         Index           =   0
         Left            =   0
         TabIndex        =   87
         TabStop         =   0   'False
         Top             =   4935
         Width           =   4020
      End
      Begin VB.CommandButton cmdActive 
         Caption         =   "1"
         Height          =   480
         Index           =   1
         Left            =   4020
         TabIndex        =   86
         TabStop         =   0   'False
         Top             =   4935
         Width           =   2700
      End
      Begin MSComctlLib.ListView lsvActive 
         Height          =   4905
         Left            =   0
         TabIndex        =   11
         TabStop         =   0   'False
         Top             =   0
         Width           =   6000
         _ExtentX        =   10583
         _ExtentY        =   8652
         View            =   3
         LabelEdit       =   1
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   16777215
         Appearance      =   0
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   3
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "0"
            Object.Width           =   7056
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   1
            Text            =   "1"
            Object.Width           =   2178
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   2
            Text            =   "2"
            Object.Width           =   2178
         EndProperty
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   2
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   12
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin VB.CommandButton cmdClients 
         Caption         =   "1"
         Height          =   480
         Index           =   1
         Left            =   4020
         TabIndex        =   41
         TabStop         =   0   'False
         Top             =   4935
         Width           =   1230
      End
      Begin VB.CommandButton cmdClients 
         Caption         =   "2"
         Height          =   480
         Index           =   2
         Left            =   5250
         TabIndex        =   15
         TabStop         =   0   'False
         Top             =   4935
         Width           =   1470
      End
      Begin VB.CommandButton cmdClients 
         Caption         =   "0"
         Height          =   480
         Index           =   0
         Left            =   0
         TabIndex        =   14
         TabStop         =   0   'False
         Top             =   4935
         Width           =   4020
      End
      Begin MSComctlLib.ListView lsvClients 
         Height          =   4905
         Left            =   0
         TabIndex        =   13
         TabStop         =   0   'False
         Top             =   0
         Width           =   6000
         _ExtentX        =   10583
         _ExtentY        =   8652
         View            =   3
         LabelEdit       =   1
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         SmallIcons      =   "ilsMain"
         ForeColor       =   -2147483640
         BackColor       =   16777215
         Appearance      =   0
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   3
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "0"
            Object.Width           =   7056
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   1
            Text            =   "1"
            Object.Width           =   2178
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   2
            Text            =   "2"
            Object.Width           =   2178
         EndProperty
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   3
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   27
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin MSComCtl2.DTPicker dtpHistory 
         Height          =   390
         Left            =   4065
         TabIndex        =   79
         TabStop         =   0   'False
         Top             =   4980
         Width           =   2610
         _ExtentX        =   4604
         _ExtentY        =   688
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         CalendarBackColor=   16777215
         CalendarForeColor=   0
         CalendarTitleBackColor=   14737632
         CalendarTitleForeColor=   0
         CalendarTrailingForeColor=   12632256
         CustomFormat    =   "MMMM dd, yyy"
         Format          =   20709379
         CurrentDate     =   38965
         MaxDate         =   50040
         MinDate         =   38718
      End
      Begin VB.CommandButton cmdHistory 
         Caption         =   "0"
         Height          =   480
         Left            =   0
         TabIndex        =   78
         TabStop         =   0   'False
         Top             =   4935
         Width           =   4020
      End
      Begin MSComctlLib.ListView lsvHistory 
         Height          =   4905
         Left            =   0
         TabIndex        =   42
         TabStop         =   0   'False
         Top             =   0
         Width           =   6000
         _ExtentX        =   10583
         _ExtentY        =   8652
         View            =   3
         LabelEdit       =   1
         LabelWrap       =   -1  'True
         HideSelection   =   -1  'True
         FullRowSelect   =   -1  'True
         GridLines       =   -1  'True
         _Version        =   393217
         ForeColor       =   -2147483640
         BackColor       =   16777215
         Appearance      =   0
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         NumItems        =   3
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "0"
            Object.Width           =   7056
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   1
            Text            =   "1"
            Object.Width           =   2178
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            SubItemIndex    =   2
            Text            =   "2"
            Object.Width           =   2178
         EndProperty
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   4
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   43
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin VB.CommandButton cmdReports 
         Caption         =   "1"
         Height          =   540
         Index           =   1
         Left            =   615
         TabIndex        =   81
         Top             =   1590
         Width           =   5430
      End
      Begin VB.CommandButton cmdReports 
         Caption         =   "0"
         Default         =   -1  'True
         Height          =   585
         Index           =   0
         Left            =   225
         TabIndex        =   80
         Top             =   4605
         Width           =   6225
      End
      Begin MSComCtl2.DTPicker dtpReportEnd 
         Height          =   390
         Left            =   2535
         TabIndex        =   85
         Top             =   3225
         Width           =   2805
         _ExtentX        =   4948
         _ExtentY        =   688
         _Version        =   393216
         CheckBox        =   -1  'True
         CustomFormat    =   "MMMM dd, yyyy"
         Format          =   20709379
         CurrentDate     =   38973
      End
      Begin MSComCtl2.DTPicker dtpReportStart 
         Height          =   390
         Left            =   2535
         TabIndex        =   83
         Top             =   2640
         Width           =   2805
         _ExtentX        =   4948
         _ExtentY        =   688
         _Version        =   393216
         CustomFormat    =   "MMMM dd, yyyy"
         Format          =   20709379
         CurrentDate     =   38973
      End
      Begin VB.Label lblReports 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "3"
         Height          =   240
         Index           =   3
         Left            =   2235
         TabIndex        =   84
         Top             =   3285
         Width           =   120
      End
      Begin VB.Label lblReports 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "2"
         Height          =   240
         Index           =   2
         Left            =   2235
         TabIndex        =   82
         Top             =   2700
         Width           =   120
      End
      Begin VB.Label lblReports 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   1
         Left            =   3285
         TabIndex        =   96
         Top             =   990
         Width           =   120
      End
      Begin VB.Label lblReports 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         Height          =   240
         Index           =   0
         Left            =   3270
         TabIndex        =   95
         Top             =   630
         Width           =   135
      End
      Begin VB.Shape Shape1 
         Height          =   3810
         Left            =   270
         Shape           =   4  'Rounded Rectangle
         Top             =   375
         Width           =   6120
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   5
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   75
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin MSComCtl2.DTPicker dtpStartDate 
         Height          =   375
         Left            =   1440
         TabIndex        =   100
         TabStop         =   0   'False
         Top             =   4095
         Width           =   1650
         _ExtentX        =   2910
         _ExtentY        =   661
         _Version        =   393216
         Format          =   20709377
         CurrentDate     =   39001
      End
      Begin MSComCtl2.DTPicker dtpEndDate 
         Height          =   375
         Left            =   4815
         TabIndex        =   101
         TabStop         =   0   'False
         Top             =   4095
         Width           =   1650
         _ExtentX        =   2910
         _ExtentY        =   661
         _Version        =   393216
         Format          =   20709377
         CurrentDate     =   39001
      End
      Begin VB.CommandButton cmdStats 
         Caption         =   "0"
         Height          =   585
         Left            =   225
         TabIndex        =   98
         Top             =   4605
         Width           =   6225
      End
      Begin MSChart20Lib.MSChart mscStats 
         Height          =   4200
         Left            =   0
         OleObjectBlob   =   "Main.frx":0949
         TabIndex        =   97
         TabStop         =   0   'False
         Top             =   0
         Width           =   6720
      End
      Begin VB.Label lblStats 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "2"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   240
         Index           =   1
         Left            =   3720
         TabIndex        =   103
         Top             =   4155
         Width           =   105
      End
      Begin VB.Label lblStats 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   240
         Index           =   0
         Left            =   255
         TabIndex        =   102
         Top             =   4155
         Width           =   105
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      HasDC           =   0   'False
      Height          =   5420
      Index           =   6
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   76
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin MSComDlg.CommonDialog cdgMain 
         Left            =   375
         Top             =   4290
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "8"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   8
         Left            =   210
         TabIndex        =   24
         Top             =   3960
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "9"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   9
         Left            =   3465
         TabIndex        =   25
         Top             =   3960
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "7"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   7
         Left            =   3465
         TabIndex        =   23
         Top             =   3045
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "6"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   6
         Left            =   210
         TabIndex        =   22
         Top             =   3045
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "5"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   5
         Left            =   3465
         TabIndex        =   21
         Top             =   2115
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "4"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   4
         Left            =   210
         TabIndex        =   20
         Top             =   2115
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "3"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   3
         Left            =   3465
         TabIndex        =   19
         Top             =   1200
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "2"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   2
         Left            =   210
         TabIndex        =   18
         Top             =   1200
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   1
         Left            =   3465
         TabIndex        =   17
         Top             =   270
         Width           =   3030
      End
      Begin VB.CommandButton cmdAdvance 
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   645
         Index           =   0
         Left            =   210
         TabIndex        =   16
         Top             =   270
         Width           =   3030
      End
      Begin VB.Label lblAdvance 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   240
         Left            =   3315
         TabIndex        =   99
         Top             =   4905
         Width           =   135
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      HasDC           =   0   'False
      Height          =   5420
      Index           =   7
      Left            =   4395
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   26
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin VB.TextBox txtTimein 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         Height          =   345
         Index           =   4
         Left            =   1890
         MaxLength       =   4
         TabIndex        =   89
         Top             =   4650
         Width           =   855
      End
      Begin VB.TextBox txtTimein 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   15.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   450
         Index           =   3
         Left            =   360
         MaxLength       =   15
         TabIndex        =   40
         Top             =   3675
         Width           =   6030
      End
      Begin VB.TextBox txtTimein 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   2
         Left            =   2880
         MaxLength       =   25
         TabIndex        =   37
         Top             =   2700
         Width           =   3510
      End
      Begin VB.TextBox txtTimein 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   1
         Left            =   360
         MaxLength       =   25
         TabIndex        =   35
         Top             =   2700
         Width           =   2385
      End
      Begin VB.TextBox txtTimein 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   0
         Left            =   2880
         MaxLength       =   15
         TabIndex        =   33
         Top             =   1725
         Width           =   3510
      End
      Begin VB.CommandButton cmdTimein 
         Caption         =   "0"
         Height          =   455
         Index           =   0
         Left            =   3900
         TabIndex        =   31
         TabStop         =   0   'False
         Top             =   4605
         Width           =   1200
      End
      Begin VB.CommandButton cmdTimein 
         Caption         =   "1"
         Height          =   455
         Index           =   1
         Left            =   5190
         TabIndex        =   30
         TabStop         =   0   'False
         Top             =   4605
         Width           =   1200
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "6"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   240
         Index           =   6
         Left            =   360
         TabIndex        =   88
         Top             =   4710
         Width           =   105
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "5"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   285
         Index           =   5
         Left            =   360
         TabIndex        =   38
         Top             =   3285
         Width           =   135
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "4"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   285
         Index           =   4
         Left            =   2880
         TabIndex        =   36
         Top             =   2310
         Width           =   135
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "3"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   285
         Index           =   3
         Left            =   360
         TabIndex        =   34
         Top             =   2310
         Width           =   135
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "2"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   285
         Index           =   2
         Left            =   360
         TabIndex        =   32
         Top             =   1755
         Width           =   135
      End
      Begin VB.Line lineTimein 
         X1              =   360
         X2              =   6390
         Y1              =   1365
         Y2              =   1365
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   345
         Index           =   1
         Left            =   360
         TabIndex        =   28
         Top             =   885
         Width           =   180
      End
      Begin VB.Label lblTimein 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   27.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00E0E0E0&
         Height          =   675
         Index           =   0
         Left            =   525
         TabIndex        =   29
         Top             =   210
         Width           =   360
      End
   End
   Begin VB.PictureBox picScreen 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      HasDC           =   0   'False
      Height          =   5420
      Index           =   8
      Left            =   4425
      ScaleHeight     =   5415
      ScaleWidth      =   6720
      TabIndex        =   39
      TabStop         =   0   'False
      Top             =   885
      Visible         =   0   'False
      Width           =   6720
      Begin VB.CommandButton cmdTimeout 
         Cancel          =   -1  'True
         Caption         =   "1"
         Height          =   455
         Index           =   1
         Left            =   5160
         TabIndex        =   51
         TabStop         =   0   'False
         Top             =   4605
         Width           =   1200
      End
      Begin VB.CommandButton cmdTimeout 
         Caption         =   "0"
         Height          =   455
         Index           =   0
         Left            =   3870
         TabIndex        =   49
         TabStop         =   0   'False
         Top             =   4605
         Width           =   1200
      End
      Begin VB.PictureBox picNoCard 
         BorderStyle     =   0  'None
         Enabled         =   0   'False
         Height          =   3630
         Left            =   150
         ScaleHeight     =   3630
         ScaleWidth      =   6345
         TabIndex        =   52
         TabStop         =   0   'False
         Top             =   1590
         Visible         =   0   'False
         Width           =   6345
         Begin VB.TextBox txtTimeout 
            Alignment       =   1  'Right Justify
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Index           =   1
            Left            =   2700
            MaxLength       =   15
            TabIndex        =   54
            Top             =   135
            Width           =   3510
         End
         Begin VB.TextBox txtTimeout 
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Index           =   2
            Left            =   180
            MaxLength       =   25
            TabIndex        =   57
            Top             =   1110
            Width           =   2385
         End
         Begin VB.TextBox txtTimeout 
            BackColor       =   &H00FFFFFF&
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Index           =   3
            Left            =   2700
            MaxLength       =   25
            TabIndex        =   58
            Top             =   1110
            Width           =   3510
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "20"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   -1  'True
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H000000FF&
            Height          =   240
            Index           =   20
            Left            =   5985
            TabIndex        =   59
            Top             =   1785
            Width           =   210
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "17"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   17
            Left            =   180
            TabIndex        =   53
            Top             =   165
            Width           =   270
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "18"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   18
            Left            =   180
            TabIndex        =   55
            Top             =   720
            Width           =   270
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "19"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   19
            Left            =   2700
            TabIndex        =   56
            Top             =   720
            Width           =   270
         End
      End
      Begin VB.CommandButton cmdTimeout 
         Caption         =   "2"
         Height          =   455
         Index           =   2
         Left            =   3090
         TabIndex        =   50
         TabStop         =   0   'False
         Top             =   4605
         Visible         =   0   'False
         Width           =   1980
      End
      Begin VB.PictureBox picTimeout 
         BorderStyle     =   0  'None
         Height          =   3630
         Left            =   150
         ScaleHeight     =   3630
         ScaleWidth      =   6345
         TabIndex        =   60
         TabStop         =   0   'False
         Top             =   1590
         Visible         =   0   'False
         Width           =   6345
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "9"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   9
            Left            =   180
            TabIndex        =   67
            Top             =   1500
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "10"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   10
            Left            =   1425
            TabIndex        =   68
            Top             =   1500
            Width           =   135
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "11"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   11
            Left            =   4515
            TabIndex        =   69
            Top             =   1500
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "12"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   12
            Left            =   6030
            TabIndex        =   70
            Top             =   1500
            Width           =   135
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "16"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   14.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FF0000&
            Height          =   345
            Index           =   16
            Left            =   1680
            TabIndex        =   74
            Top             =   3060
            Width           =   165
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "15"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   240
            Index           =   15
            Left            =   180
            TabIndex        =   73
            Top             =   3135
            Width           =   90
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "8"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   8
            Left            =   6030
            TabIndex        =   66
            Top             =   855
            Width           =   135
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "7"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   7
            Left            =   4515
            TabIndex        =   65
            Top             =   855
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "6"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   6
            Left            =   1425
            TabIndex        =   64
            Top             =   855
            Width           =   135
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "5"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   5
            Left            =   180
            TabIndex        =   63
            Top             =   855
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "3"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   3
            Left            =   180
            TabIndex        =   61
            Top             =   165
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "4"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   4
            Left            =   6030
            TabIndex        =   62
            Top             =   165
            Width           =   135
         End
         Begin VB.Label lblTimeout 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "13"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   285
            Index           =   13
            Left            =   180
            TabIndex        =   71
            Top             =   2265
            Width           =   120
         End
         Begin VB.Label lblTimeout 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "14"
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   26.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H000000FF&
            Height          =   630
            Index           =   14
            Left            =   5910
            TabIndex        =   72
            Top             =   2070
            Width           =   300
         End
      End
      Begin VB.TextBox txtTimeout 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   15.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   450
         Index           =   0
         Left            =   330
         MaxLength       =   15
         TabIndex        =   47
         Top             =   2175
         Width           =   6030
      End
      Begin VB.CommandButton cmdTimeout 
         Caption         =   "3"
         Height          =   455
         Index           =   3
         Left            =   330
         TabIndex        =   48
         TabStop         =   0   'False
         Top             =   4605
         Width           =   1980
      End
      Begin VB.Label lblTimeout 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   27.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00E0E0E0&
         Height          =   675
         Index           =   0
         Left            =   495
         TabIndex        =   44
         Top             =   210
         Width           =   360
      End
      Begin VB.Label lblTimeout 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "1"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   345
         Index           =   1
         Left            =   330
         TabIndex        =   45
         Top             =   885
         Width           =   180
      End
      Begin VB.Line lineTimeout 
         X1              =   330
         X2              =   6360
         Y1              =   1365
         Y2              =   1365
      End
      Begin VB.Label lblTimeout 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "2"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   285
         Index           =   2
         Left            =   330
         TabIndex        =   46
         Top             =   1755
         Width           =   135
      End
   End
   Begin VB.Label lblMain 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   3
      Left            =   3270
      TabIndex        =   94
      Top             =   2115
      Width           =   105
   End
   Begin VB.Label lblMain 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "2"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   2
      Left            =   3255
      TabIndex        =   93
      Top             =   1830
      Width           =   120
   End
   Begin VB.Label lblMain 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "1"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   1
      Left            =   1485
      TabIndex        =   92
      Top             =   1455
      Width           =   120
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   36
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   900
      Index           =   5
      Left            =   1620
      TabIndex        =   90
      Top             =   4635
      Width           =   1575
   End
   Begin VB.Image imgButtons 
      Height          =   930
      Index           =   0
      Left            =   10425
      ToolTipText     =   "0"
      Top             =   7140
      Width           =   1035
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "12"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   285
      Index           =   12
      Left            =   10920
      TabIndex        =   77
      Top             =   7470
      UseMnemonic     =   0   'False
      Visible         =   0   'False
      Width           =   300
   End
   Begin VB.Image imgControlBox 
      Height          =   255
      Left            =   10980
      Top             =   0
      Visible         =   0   'False
      Width           =   1020
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   27.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   675
      Index           =   0
      Left            =   10800
      TabIndex        =   6
      Top             =   7260
      UseMnemonic     =   0   'False
      Width           =   360
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "11"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   11
      Left            =   8850
      TabIndex        =   5
      Tag             =   "F8"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   255
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "10"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   10
      Left            =   7275
      TabIndex        =   4
      Tag             =   "F7"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   255
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "9"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   9
      Left            =   5670
      TabIndex        =   3
      Tag             =   "F6"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   135
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "8"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   8
      Left            =   4005
      TabIndex        =   2
      Tag             =   "F5"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   120
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "7"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   7
      Left            =   2415
      TabIndex        =   1
      Tag             =   "F4"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   135
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "6"
      ForeColor       =   &H00000000&
      Height          =   240
      Index           =   6
      Left            =   825
      TabIndex        =   0
      Tag             =   "F3"
      Top             =   8175
      UseMnemonic     =   0   'False
      Width           =   120
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   6
      Left            =   8625
      Tag             =   "F8"
      ToolTipText     =   "6"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   5
      Left            =   7065
      Tag             =   "F7"
      ToolTipText     =   "5"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   4
      Left            =   5415
      Tag             =   "F6"
      ToolTipText     =   "4"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   3
      Left            =   3720
      Tag             =   "F5"
      ToolTipText     =   "3"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   2
      Left            =   2145
      Tag             =   "F4"
      ToolTipText     =   "2"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Image imgButtons 
      Height          =   660
      Index           =   1
      Left            =   540
      Tag             =   "F3"
      ToolTipText     =   "1"
      Top             =   7425
      Width           =   660
   End
   Begin VB.Label lblMain 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   1320
      Index           =   4
      Left            =   1305
      TabIndex        =   91
      Top             =   4410
      Width           =   2250
   End
End
Attribute VB_Name = "fMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Restrict system from processing 'Winkeys' within the program's premises
Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwflags As Long, ByVal dwExtraInfo As Long)
    Private Const KEYEVENTF_KEYUP As Long = &H2

Private PATH_IMAGES     As String

Private m_bChangeUser   As Boolean
Private m_bShortcutKeys As Boolean
Private m_bCtrlMasked   As Boolean
Private m_bInFullScreen As Boolean
Private m_bWasMinimized As Boolean

Private m_iCurScreen    As Integer
Private m_iHotButton    As Integer

' //-- Public Procedures --//

Public Property Get InFullScreen() As Boolean
    InFullScreen = m_bInFullScreen
    
End Property

Public Property Let InFullScreen(Value As Boolean)
    m_bInFullScreen = Value
    
End Property

' //-- Private Procedures --//

Private Sub FocusAndSelectText(Control As Control)
    Control.SetFocus
    SendKeys "{Home}+{End}"
    
End Sub

Private Sub cmdAdvance_Click(Index As Integer)
    On Error Resume Next
    
    Select Case Index
        Case 0 ' PROGRAM SETTINGS
            fProgramSettings.Show vbModal, Me
            
        Case 1 ' Change Adminstrator Password
            fChangePassword.Show vbModal, Me
            
        Case 2 ' CASHIER MANAGER
            fCashierManager.Show vbModal, Me
            
        Case 3 ' Change Service/Transaction Rates
            fChangeRates.Show vbModal, Me
            
        Case 4 ' CARD MANAGER
            fCardManager.Show vbModal, Me
            
        Case 5 ' Database Backup And Restore Manager
            fBackupManager.Show vbModal, Me
            
        Case 6 ' LOGIN HISTORY
            fLoginHistory.Show vbModal, Me
            
        Case 7 ' Set System Date && Time Settings
            Shell "rundll32.exe shell32.dll,Control_RunDLL  timedate.cpl,,0"
            
        Case 8 ' PRINTER SETUP
            With cdgMain
                .CancelError = False
                .Flags = cdlPDPrintSetup
                .ShowPrinter
            End With
            
        Case 9 ' Advance Program Configuration
            Shell "notepad.exe " & App.EXEName & ".ini", vbNormalFocus
            
    End Select
    
End Sub

Private Sub cmdClients_Click(Index As Integer)
    On Error Resume Next
    
    Select Case Index
        Case 0
            With lsvClients.SelectedItem
                Form_KeyDown vbKeyF1, 0
                
                Dim sName() As String
                    sName = Split(.Text, ", ")
                    
                txtTimein(0) = .SubItems(2)
                txtTimein(1) = sName(0)
                txtTimein(2) = sName(1)
                txtTimein(3).SetFocus
            End With
            
        Case 1
            Dim fCE As fClient
            Set fCE = New fClient
                fCE.EditMode = True
                fCE.RegNumber = lsvClients.SelectedItem.SubItems(2)
                fCE.Show vbModal, Me
                lsvClients.SetFocus
                
        Case 2
            Dim fCN As fClient
            Set fCN = New fClient
                fCN.EditMode = False
                fCN.Show vbModal, Me
                lsvClients.SetFocus
                
    End Select
    
End Sub

Private Sub cmdHistory_Click()
    dtpHistory_Change
    
End Sub

Private Sub cmdActive_Click(Index As Integer)
    If (Not m_iHotButton = m_iCurScreen) Then
        ' Remove hot state of previous active button
        imgButtons(m_iCurScreen).Picture = Nothing
    End If
    
    picScreen(m_iCurScreen).Visible = False ' Hide previous screen
    m_iCurScreen = Index + 7                ' Cache current screen index
    picScreen(m_iCurScreen).Visible = True  ' Show requested screen
    
    lblMain(4) = cINI.Value("MainStrings", "msgScreen" & m_iCurScreen)
    lblMain(5) = ""
    
    Dim i As Integer
    Dim j As Integer
    
    If (Index = 0) Then ' Log-in
            j = txtTimein.UBound
        For i = txtTimein.LBound To j
            txtTimein(i) = "" ' Clear any previous text
        Next
        
        cmdTimein(0).Default = True
        cmdTimein(1).Cancel = True
        
    Else ' Check-out
            j = txtTimeout.UBound
        For i = txtTimeout.LBound To j
            txtTimeout(i) = "" ' Clear any previous text
        Next
        
        txtTimeout(0).Enabled = True
        picNoCard.Enabled = False
        picNoCard.Visible = False
        picTimeout.Visible = False
        
        cmdTimeout(0).Default = True
        cmdTimeout(0).Visible = True
        cmdTimeout(1).Cancel = True
        cmdTimeout(1).Caption = cINI.Value("MainStrings", "cmdTimeout1")
        cmdTimeout(2).Visible = False
        cmdTimeout(3).Visible = True
    End If
    
End Sub

Private Sub cmdReports_Click(Index As Integer)
    Dim cPenalty    As Currency
    Dim cRates      As Currency
    Dim cTotal      As Currency
    Dim dHours      As Date
    Dim iClients    As Long
    Dim iHours      As Long
    Dim iMinutes    As Long
    Dim sHours      As String
    
    Select Case Index
        Case 0 ' View/Print Cash-On-Hand Report
            On Error Resume Next
            
            If (mPublic.OpenRecordset("SELECT SUM(timeout-timein) AS totalhours,SUM(servrate) AS totalrates,SUM(penaltyfee) AS penaltyfees,Count(*) AS totalclients FROM history WHERE servdate=#" & Date$ & "#")) Then
                
                If (Val(REC("totalclients")) = 0) Then
                    MsgBoxEx "ReportNoTransactions", vbExclamation
                    Exit Sub
                End If
                
                GoSub Jmp_Calculate_Values
                
                Dim rptCOH As rptCashOnHand
                Set rptCOH = New rptCashOnHand
                Set rptCOH.DataSource = REC
                
                With rptCOH.Sections("Detail")
                    .Controls("Cashier_Username").Caption = lblMain(2)
                    .Controls("Ave_Client_Hours").Caption = sHours
                    .Controls("Client_Count").Caption = Replace$(cINI.Value("ReportStrings", "rptCashOnHand3b"), "%???%", iClients)
                    .Controls("Total_Service_Charges").Caption = "P " & Format$(cRates, "###,#00.00")
                    .Controls("Total_Misc_Fees").Caption = "P " & Format$(cPenalty, "###,#00.00")
                    .Controls("Total_COH").Caption = "P " & Format$(cTotal, "###,#00.00")
                    .Controls("Total_COH_String").Caption = mNumberToString.NumberToString(cTotal) & " Pesos"
                End With
                
                rptCOH.Move Left, Top, Width, Height
                rptCOH.Show vbModal, Me
                
                Unload rptCOH ' Unload to clear memory for loading the report form
                Set rptCOH = Nothing ' Set to remove instance of rptCOH from memory
            Else
                MsgBoxEx "ReportForCOHError", vbExclamation
            End If
            
        Case 1
            If (Not ADMINISTRATOR) Then
                fPassword.Show vbModal, Me
                
                If (Not ADMINISTRATOR) Then
                    Exit Sub
                Else
                    ADMINISTRATOR = False ' Clear admin permission
                End If
            End If
            
            If (IsNull(dtpReportEnd.Value)) Then ' Null if control is unchecked
                If (Not mPublic.OpenRecordset("SELECT SUM(timeout-timein) AS totalhours,SUM(servrate) AS totalrates,SUM(penaltyfee) AS penaltyfees,Count(*) AS totalclients FROM history WHERE servdate=#" & dtpReportStart.Value & "#")) Then
                    MsgBoxEx "ReportForSalesError", vbExclamation
                    Exit Sub
                End If
                
                If (Val(REC("totalclients")) = 0) Then
                    MsgBoxEx "ReportNoSalesOnDate", vbExclamation
                    Exit Sub
                End If
            Else
                If (Not mPublic.OpenRecordset("SELECT SUM(timeout-timein) AS totalhours,SUM(servrate) AS totalrates,SUM(penaltyfee) AS penaltyfees,Count(*) AS totalclients FROM history WHERE servdate BETWEEN #" & dtpReportStart.Value & "# AND #" & dtpReportEnd.Value & "#")) Then
                    MsgBoxEx "ReportForSalesError", vbExclamation
                    Exit Sub
                End If
                
                If (Val(REC("totalclients")) = 0) Then
                    MsgBoxEx "ReportNoSalesOnDates", vbExclamation
                    Exit Sub
                End If
            End If
            
            GoSub Jmp_Calculate_Values
            
            Dim rptSales As rptTotalSales
            Set rptSales = New rptTotalSales
            Set rptSales.DataSource = REC
            
            With rptSales.Sections("Detail")
                .Controls("Start_Date").Caption = CStr(dtpReportStart.Value)
                If (IsNull(dtpReportEnd.Value)) Then
                    .Controls("End_Date").Caption = cINI.Value("ReportStrings", "rptTotalSales3b")
                    .Controls("Client_Count").Caption = Replace$(cINI.Value("ReportStrings", "rptTotalSales4b"), "%???%", iClients)
                Else
                    .Controls("End_Date").Caption = CStr(dtpReportEnd.Value)
                    .Controls("Client_Count").Caption = Replace$(cINI.Value("ReportStrings", "rptTotalSales4c"), "%???%", iClients)
                End If
                .Controls("Ave_Client_Hours").Caption = sHours
                .Controls("Total_Service_Charges").Caption = "P " & Format$(cRates, "###,#00.00")
                .Controls("Total_Misc_Fees").Caption = "P " & Format$(cPenalty, "###,#00.00")
                .Controls("Total_Sales").Caption = "P " & Format$(cTotal, "###,#00.00")
                .Controls("Total_Sales_String").Caption = mNumberToString.NumberToString(cTotal) & " Pesos"
            End With
            
            rptSales.Move Left, Top, Width, Height
            rptSales.Show vbModal, Me
            
            Unload rptSales ' Unload to clear memory for loading the report form
            Set rptSales = Nothing ' Set to remove instance of rptSales from memory
    End Select
    
    Exit Sub
Jmp_Calculate_Values:
    
    cPenalty = CCur(REC("penaltyfees"))
    cRates = CCur(REC("totalrates"))
    cTotal = cRates + cPenalty
    dHours = CDate(REC("totalhours"))
    iClients = CLng(REC("totalclients"))
    iHours = CLng(Hour(dHours))
    iMinutes = CLng(Minute(dHours))
    
    If (iHours = 1) Then
        sHours = "1 Hour "
    ElseIf (iHours > 1) Then
        sHours = iHours & " Hours "
    End If
    
    If (iMinutes = 1) Then
        sHours = sHours & "1 Minute "
    ElseIf (iMinutes > 1) Then
        sHours = sHours & iMinutes & " Minutes "
    End If
    
    sHours = sHours & " / Client"
    Return
    
End Sub

Private Sub cmdStats_Click()
    Dim i As Integer
    Dim j As Integer
    
    If (Len(mscStats.Tag) = 0) Then
        If (Not mPublic.OpenRecordset("SELECT timein,timeout FROM history WHERE servdate BETWEEN #" & dtpStartDate.Value & "# AND #" & dtpEndDate.Value & "# ORDER BY timein ASC,timeout ASC")) Then
            MsgBoxEx "StatsForAllFailed", vbCritical
            Exit Sub
        End If
    Else
        If (Not mPublic.OpenRecordset("SELECT timein,timeout FROM history WHERE regnum=" & mscStats.Tag & " AND servdate BETWEEN #" & dtpStartDate.Value & "# AND #" & dtpEndDate.Value & "# ORDER BY timein ASC,timeout ASC")) Then
            MsgBoxEx "StatsForClientFailed", vbCritical
            Exit Sub
        End If
    End If
    
    With mscStats
        .MousePointer = VtMousePointerHourGlass
        .Repaint = False ' Prevent mscStats control from repainting
                         ' to speed things up when plotting too many data
        .ColumnCount = 2
        .RowCount = 12
            
            j = .RowCount
        For i = 1 To j
            .Row = i
            .Column = 1
            .Data = 0 ' Reset current data
            .Column = 2
            .Data = 0 ' Reset current data
            If (i < 4) Then
                .RowLabel = (i + 8) & "a"
            ElseIf (i = 4) Then
                .RowLabel = "12n"
            Else
                .RowLabel = (i - 4) & "p"
            End If
        Next
        
        Dim dTimein     As Date
        Dim dTimeout    As Date
        Dim iHourIn     As Integer
        Dim iHourOut    As Integer
        
        On Error Resume Next
        
        While Not REC.EOF
            .Column = 1
            dTimein = CDate(REC("timein"))
            iHourIn = Hour(dTimein)
            
            Select Case iHourIn
                Case 9 To 12 ' 9am to 12nn
                    If (Minute(dTimein) < 30) Then
                        .Row = iHourIn - 8
                    Else
                        .Row = iHourIn - 7
                    End If
                    .Data = Int(.Data) + 1
                Case 1 To 8 ' 1pm to 8pm
                    If (Minute(dTimein) < 30) Then
                        .Row = iHourIn + 4
                    Else
                        .Row = iHourIn + 5
                    End If
                    .Data = Int(.Data) + 1
            End Select
            
            .Column = 2
            dTimeout = CDate(REC("timeout"))
            iHourOut = Hour(dTimeout)
            
            Select Case iHourOut
                Case 9 To 12 ' 9am to 12nn
                    If (Minute(dTimeout) < 30) Then
                        .Row = iHourOut - 8
                    Else
                        .Row = iHourOut - 7
                    End If
                    .Data = Int(.Data) + 1
                Case 1 To 8 ' 1pm to 8pm
                    If (Minute(dTimeout) < 30) Then
                        .Row = iHourOut + 4
                    Else
                        .Row = iHourOut + 5
                    End If
                    .Data = Int(.Data) + 1
            End Select
            
            REC.MoveNext
        Wend
        
        .Repaint = True ' Allow to repaint
        .Refresh        ' Force control to redraw
        
        .MousePointer = VtMousePointerDefault
    End With
    
End Sub

Private Sub cmdTimein_Click(Index As Integer)
    If (Index = 0) Then
        Dim i As Integer
        
        For i = 0 To 3
            If (Len(txtTimein(i)) = 0) Then
                txtTimein(i).SetFocus
                Exit For
            End If
        Next
        
        If (i = 4) Then ' Everything has been filled up
            On Error Resume Next
            
            ' Check if registration number is valid
            If (mPublic.IsRegNumberValid(txtTimein(0))) Then
                
                ' Check if registration number is already active
                If (mPublic.IsRegNumberActive(txtTimein(0))) Then
                    MsgBoxEx "TimeinRegnumActive", vbExclamation
                    FocusAndSelectText txtTimein(0)
                    
                ElseIf (mPublic.IsCardNumberActive(txtTimein(3))) Then
                    MsgBoxEx "TimeinCardnumActive", vbExclamation
                    FocusAndSelectText txtTimein(3)
                    
                ElseIf (mPublic.IsCardNumberValid(txtTimein(3))) Then
                    mPublic.ClientTimeIn txtTimein(0), txtTimein(3), Val(txtTimein(4))
                    Form_KeyDown vbKeyEscape, 0 ' Return to main screen
                    
                Else
                    MsgBoxEx "TimeinCardnumInvalid", vbCritical
                    FocusAndSelectText txtTimein(3)
                    
                End If
            Else
                MsgBoxEx "TimeinRegnumInvalid", vbCritical
                FocusAndSelectText txtTimein(0)
            End If
        End If
    Else
        Form_KeyDown vbKeyEscape, 0 ' Return to main screen
    End If
    
End Sub

Private Sub cmdTimeout_Click(Index As Integer)
    Select Case Index
        Case 0
            On Error Resume Next
            
            If (picNoCard.Visible) Then
                Dim i As Integer
                
                For i = 1 To 3
                    If (Len(txtTimeout(i)) = 0) Then ' Find empty textbox
                        txtTimeout(i).SetFocus ' Set it to focus when found
                        Exit For
                    End If
                Next
                
                If (i < 4) Then Exit Sub
                
                ' Check if registration number is valid
                If (mPublic.IsRegNumberValid(txtTimeout(1))) Then
                    
                    ' Check if client owning the reg number is on service
                    If (mPublic.IsRegNumberActive(txtTimeout(1))) Then
                        cmdTimeout(0).Visible = False
                        cmdTimeout(1).Caption = cINI.Value("MainStrings", "cmdTimeout5")
                        cmdTimeout(2).Visible = True
                        cmdTimeout(2).Default = True
                        
                        mPublic.ClientTimeOut "", Val(txtTimeout(1))
                        
                        picTimeout.Visible = True
                    Else
                        MsgBoxEx "TimeoutRegnumInactive", vbExclamation
                        FocusAndSelectText txtTimeout(1)
                    End If
                Else
                    MsgBoxEx "TimeoutRegnumInvalid", vbExclamation
                    FocusAndSelectText txtTimeout(1)
                End If
                
                Exit Sub
            End If
            
            If (Len(txtTimeout(0)) = 0) Then
                txtTimeout(0).SetFocus
            Else
                ' Check if card number is valid
                If (mPublic.IsCardNumberValid(txtTimeout(0))) Then
                    
                    ' Check if card number was used
                    If (mPublic.IsCardNumberActive(txtTimeout(0))) Then
                        cmdTimeout(0).Visible = False
                        cmdTimeout(1).Caption = cINI.Value("MainStrings", "cmdTimeout5")
                        cmdTimeout(2).Visible = True
                        cmdTimeout(2).Default = True
                        
                        mPublic.ClientTimeOut txtTimeout(0)
                        
                        picTimeout.Visible = True
                    Else
                        MsgBoxEx "TimeoutCardnumberInactive", vbExclamation
                        FocusAndSelectText txtTimeout(0)
                    End If
                Else
                    MsgBoxEx "TimeoutCardnumberInvalid", vbCritical
                    FocusAndSelectText txtTimeout(0)
                End If
            End If
        Case 1
            If (picNoCard.Visible) Then
                Form_KeyDown vbKeyF2, 0 ' Back to check-out using a card number
            Else
                Form_KeyDown vbKeyEscape, 0 ' Return to main screen
            End If
            
        Case 2
            Dim rptNew As rptReceipt
            Set rptNew = New rptReceipt
            
            On Error Resume Next
            
            Load rptNew ' Load datareport form
                        ' VB/program crashes later on when we try to print
                        ' the report without showing or loading the report form.
                        ' So we need to load it first then just unload
                        ' it later after sending it to the printer
                        
            rptNew.Title = rptNew.Title & ": " & lblTimeout(4) ' Customer name
            
            With rptNew.Sections("Detail")
                .Controls("Customer_Name").Caption = lblTimeout(4) ' Lastname, Firstname
                .Controls("Time_In").Caption = lblTimeout(6) ' Time-in
                .Controls("Time_Out").Caption = lblTimeout(8) ' Time-out
                .Controls("Time_Elapsed").Caption = Format$(TimeSerial(Hour(CDate(lblTimeout(8))) - Hour(CDate(lblTimeout(6))), Minute(CDate(lblTimeout(8))) - Minute(CDate(lblTimeout(6))), 0), "HH:MM")
                .Controls("Service_Charge").Caption = lblTimeout(12) ' Service charge
                .Controls("Misc_Fee").Caption = lblTimeout(10) ' Misc Fee
                .Controls("Basket_Number").Caption = "#" & lblTimeout(16) ' Basket number
                
                Dim cServ As Currency
                Dim cMisc As Currency
                Dim cFees As Currency
                    cServ = Val(Mid$(lblTimeout(10), 2))
                    cMisc = Val(Mid$(lblTimeout(12), 2))
                    cFees = cServ + cMisc
                
                .Controls("Total_Fees").Caption = "P " & Format$(cFees, "###,#00.00") ' Total fees
                .Controls("Total_Fees_String").Caption = mNumberToString.NumberToString(cFees) ' Total fees in string
            End With
            
            Set rptNew.DataSource = REC                     ' Set temporary recordset
                rptNew.PrintReport , rptRangeFromTo, 1, 1   ' Send report to printer
                                                            '
                Unload rptNew                               ' Unload report form
            Set rptNew = Nothing                            ' Remove from memory
                                                            '
                cmdTimeout_Click 1                          ' Return to main screen
        Case 3
            cmdTimeout(1).Caption = cINI.Value("MainStrings", "cmdTimeout4")
            cmdTimeout(3).Visible = False
            picNoCard.Enabled = True
            picNoCard.Visible = True
            txtTimeout(0).Enabled = False
            
            lblMain(4) = cINI.Value("MainStrings", "msgScreen9")
    End Select
    
End Sub

Private Sub dtpEndDate_Change()
    If (dtpStartDate.Value > dtpEndDate.Value) Then
        dtpStartDate.Value = dtpEndDate.Value
    End If
    
    dtpStartDate.MaxDate = dtpEndDate.Value
    cmdStats_Click ' Refresh chart table
    
End Sub

Private Sub dtpHistory_Change()
    mPublic.LoadClientsHistory dtpHistory.Value, lsvHistory
    lblMain(5) = Format$(lsvHistory.ListItems.Count, "#00") ' Update list count
    
End Sub

Private Sub dtpReportEnd_Change()
'   If dtpReportEnd is unchecked, the return value will be Null
    If (Not IsNull(dtpReportEnd.Value)) Then
        dtpReportStart.MaxDate = dtpReportEnd.Value
    End If
    
End Sub

Private Sub dtpReportStart_Change()
    dtpReportEnd.MinDate = dtpReportStart.Value
    
End Sub

Private Sub dtpStartDate_Change()
    cmdStats_Click
    
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    m_bCtrlMasked = (Shift = vbCtrlMask)
    
    Select Case KeyCode
        ' Trap function key presses
        Case vbKeyF1 To vbKeyF12, vbKeyEscape
            Dim Index As Integer
            
            Select Case KeyCode
                Case vbKeyF1
                    If (m_bCtrlMasked) Then
                        Index = 0
                    Else
                        cmdActive_Click 0
                        Exit Sub
                    End If
                    
                Case vbKeyF2
                    cmdActive_Click 1
                    Exit Sub
                    
                Case vbKeyF9
                    If (MsgBoxEx("ChangeUser", vbInformation + vbYesNoCancel + vbDefaultButton2) = vbYes) Then
                        m_bChangeUser = True
                        Unload Me
                    End If
                    Exit Sub
                    
                Case vbKeyF10
                    Exit Sub ' Not used
                    
                Case vbKeyF11, vbKeyF12
                    Index = KeyCode - 115
                    
                Case vbKeyEscape
                    Index = 1
                    
                Case Else
                    Index = KeyCode - 113
            End Select
            
            imgButtons_MouseMove Index, 0, 0, 0, 0 ' Highlight appropriate button
            imgButtons_Click Index ' Function keys starts at 112 up to 123
            
        Case 91, 92 ' Winkeys (left & right)
            keybd_event vbKeyF10, 0, 0, 0
            keybd_event vbKeyF10, 0, KEYEVENTF_KEYUP, 0 ' System reads the F10 key
                                                        ' instead of the Winkey
    End Select
    
End Sub

Private Sub Form_KeyUp(KeyCode As Integer, Shift As Integer)
    m_bCtrlMasked = False
    
End Sub

Private Sub Form_Load()
    On Error Resume Next
    
    PATH_IMAGES = cINI.Value("Settings", "Path_Images", "Images\")
    Caption = App.ProductName & " v" & App.Major & "." & App.Minor & "." & App.Revision
    
    ' Load background colors & images
    
    BackColor = cINI.Value("Settings", "Back_Color")
    Picture = LoadPicture(PATH_IMAGES & "back.img")
    Refresh
    
    Dim i As Integer
    Dim j As Integer
        
        j = picScreen.UBound
    For i = picScreen.LBound To j
        picScreen(i).BackColor = BackColor
    Next
    
    ' Prepare imagelist
    
    With ilsImages
        .BackColor = BackColor
        .MaskColor = CLng(cINI.Value("Settings", "Mask_Color"))
        .ListImages.Add , "M", LoadPicture(PATH_IMAGES & "boy.gif")
        .ListImages.Add , "F", LoadPicture(PATH_IMAGES & "girl.gif")
    End With
    
    ' Load strings
    
    Dim bShowTooltips As Boolean
        bShowTooltips = CBool(cINI.Value("Settings", "Show_Tooltips", True))
        
    Dim sText As String
    
    Dim Control As Control
    For Each Control In Me.Controls ' This loop loads the control strings and settings
        With Control
            If (TypeOf Control Is CommandButton) Then
                .Caption = cINI.Value("MainStrings", Mid$(.Name, 1) & .Caption)
                
            ElseIf (TypeOf Control Is Label) Then
                sText = cINI.Value("MainStrings", Mid$(.Name, 1) & .Caption)
                If (Not sText Like ";*") Then .Caption = sText
                
            ElseIf (TypeOf Control Is Image) Then
                If (bShowTooltips) Then
                    .ToolTipText = cINI.Value("MainStrings", Mid$(.Name, 1) & .ToolTipText)
                End If
                
            ElseIf (TypeOf Control Is ListView) Then
                .BackColor = .Container.BackColor
                .SmallIcons = ilsImages
                .Width = .Container.Width
                
                   j = .ColumnHeaders.Count
                For i = 1 To j
                    .ColumnHeaders(i).Text = cINI.Value("MainStrings", Mid$(.Name, 1) & .ColumnHeaders(i).Text)
                Next
                
            ElseIf (TypeOf Control Is PictureBox) Then
                .BackColor = .Container.BackColor
                
            End If
        End With
    Next
    
    ' Load cursors
    
        j = imgButtons.UBound
    For i = imgButtons.LBound To j
        imgButtons(i).MouseIcon = LoadPicture(cINI.Value("Settings", "Path_Cursor"))
        imgButtons(i).MousePointer = vbCustom
    Next
    
    ' Screen 0 - Help
    
    With rtbHelp
        .BackColor = .Container.BackColor
        .FileName = cINI.Value("Settings", "Path_Help")
        .Height = .Container.Height
        .Width = .Container.Width
    End With
    
    ' Screen 1 - Time-in
    
    mPublic.AcceptNumbersOnly txtTimein(0) ' Registration number
    mPublic.AcceptNumbersOnly txtTimein(4) ' Basket number
    
    ' Screen 2 - Time-out
    
    mPublic.AcceptNumbersOnly txtTimeout(1) ' Registration number
    
    ' Screen 3 - Main/Active
    
    ' Screen 4 - Clients
    
    mPublic.LoadClientsLists lsvClients
    
    ' Screen 5 - History
    
    dtpHistory.MaxDate = Date$
    dtpHistory.Value = Date$
    dtpHistory_Change
    
    ' Screen 6 - Reports
    
    dtpReportStart.MaxDate = Date$
    dtpReportStart.Value = Date$
    dtpReportEnd.MaxDate = Date$
    dtpReportEnd.MinDate = Date$
    dtpReportEnd.Value = Date$ ' Ensure that the current date is displayed
    dtpReportEnd.Value = Null  ' Uncheck dtpReportEnd control
    
    ' Screen 7 - Stats
    
    dtpStartDate.MaxDate = Date$
    dtpStartDate.Value = Date$
    dtpEndDate.MaxDate = Date$
    dtpEndDate.MinDate = Date$
    dtpEndDate.Value = Date$
    mscStats.TitleText = cINI.Value("MainStrings", "mscStats0")
    
    ' Screen 8 - Advance
    
    ' Others
    
    m_iCurScreen = -1 ' No screen has been loaded at the moment
    m_bShortcutKeys = CBool(cINI.Value("Settings", "Show_Shortcut_Keys", True))
    
    lblMain(0) = ""
    
    m_iCurScreen = 0 ' Temporarily this is our screen index to prevent error
                     ' Because the previous -1 is not a valid screen index
    
    imgButtons_MouseMove 1, 0, 0, 0, 0 ' Highlight main (default) button
    imgButtons_Click 1 ' Show default screen
    
    ' Load MSComm (mscBarcode) settings and open connection
    
    If (Not CBool(cINI.Value("Settings", "Comm_BarcodeScanner"))) Then
        Exit Sub ' Not using COM ports for the barcode scanner
    End If
    
    Dim sARR() As String
    
    If (cINI.EnumKeys("MSComm", sARR)) Then ' Load MSComm control settings
            j = UBound(sARR)
        For i = 0 To j
            CallByName mscBarcode, sARR(i), VbLet, cINI.Value("MSComm", sARR(i))
        Next
        
        If (mscBarcode.PortOpen) Then
            mscBarcode.PortOpen = False ' Close port first if was opened
        End If
        
        mscBarcode.PortOpen = True ' Open set Comm port
    End If
    
    If (Not mscBarcode.PortOpen) Then
        MsgBoxEx "ComPortNoOpen", vbExclamation
    End If
    
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If (Len(lblMain(0))) Then
            lblMain(0) = "" ' Clear help (shortcut key) label caption
    End If
    
    If (Not m_iHotButton = -1) Then
        On Error Resume Next
        
        If (Not m_iHotButton = m_iCurScreen) Then
            imgButtons(m_iHotButton).Picture = Nothing ' Remove hot state
        End If
        
        m_iHotButton = -1 ' Reset index
    End If
    
    If (picControlBox.Visible) Then
        picControlBox.Visible = False ' Hide control box
    End If
    
End Sub

Private Sub Form_Resize()
    
    If (m_bInFullScreen) Then
        
        ' Set screen resolution back and forth to original & fullscreen size resolution
        If (WindowState = vbMinimized) Then
            m_bWasMinimized = True
            mChangeResolution.RestoreScreenResolution
        ElseIf (m_bWasMinimized) Then
            m_bWasMinimized = False
            mChangeResolution.ChangeResolution 800, 600
        End If
        
    End If
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    On Error Resume Next
    
    Dim iRet As VbMsgBoxResult
    
    If (m_bChangeUser) Then
        iRet = vbNo
    ElseIf (Not m_bCtrlMasked) Then
        iRet = MsgBoxEx("CloseProgram", vbExclamation + vbYesNoCancel + vbDefaultButton3)
        Cancel = (iRet = vbCancel)
    End If
    
    If (Not Cancel) Then
        CON.Execute "UPDATE loginhistory SET logouttime=#" & TimeSerial(Hour(Time), Minute(Time), 0) & "# WHERE loginno=(SELECT MAX(loginno) FROM loginhistory)"
        
        If (mscBarcode.PortOpen) Then
            mscBarcode.PortOpen = False ' Close MSComm port if opened/used
        End If
        
        mSubMain.UnloadLibrary ' Prevent unexpected crashes when using XP styles
        
        If (m_bInFullScreen) Then ' Restore original screen resolution when changed
            If (WindowState = vbNormal) Then
                mChangeResolution.RestoreScreenResolution
            End If
        End If
        
        If (iRet = vbNo) Then
            Shell App.Path & "\" & App.EXEName & ".exe /run", vbNormalFocus
        End If
    End If
    
End Sub

Private Sub imgButtons_Click(Index As Integer)
    Select Case Index
        Case 0 To 6
            On Error Resume Next
            
            ' Screen index
            ' 0 - Help
            ' 1 - Main
            ' 2 - Clients
            ' 3 - History
            ' 4 - Reports
            ' 5 - Stats
            ' 6 - Advance
            ' 7 - Login
            ' 8 - Checkout
            
            If (m_iCurScreen = Index) Then
                ' Screen is already shown
                Exit Sub
            End If
            
            Select Case Index
                Case 5, 6 ' Stats & Advance buttons
                    If (Not ADMINISTRATOR) Then
                        fPassword.Show vbModal, Me
                        
                        If (Not ADMINISTRATOR) Then
                            Form_MouseMove 0, 0, 0, 0
                            Exit Sub
                        Else
                            ADMINISTRATOR = False ' Clear admin permission
                        End If
                        
                    End If
            End Select
            
            If (Not m_iHotButton = m_iCurScreen) Then
                ' Remove hot state of previous active button
                imgButtons(m_iCurScreen).Picture = Nothing
            End If
            
            picScreen(m_iCurScreen).Visible = False ' Hide previous screen
            m_iCurScreen = Index                    ' Cache current screen index
            picScreen(m_iCurScreen).Visible = True  ' Show requested screen
            
            lblMain(4) = cINI.Value("MainStrings", "msgScreen" & m_iCurScreen)
            
            With mscStats
            Select Case m_iCurScreen
                Case 5
                    If (Len(.Tag) = 0) Then
                        .TitleText = cINI.Value("MainStrings", "mscStats0")
                    Else
                        .TitleText = .TitleText & " " & cINI.Value("MainStrings", "mscStats1")
                    End If
                    
                    cmdStats_Click ' Refresh
                Case Else
                    .Tag = ""
            End Select
            End With
            
            Select Case m_iCurScreen
                Case 1
                    lblMain(5) = Format$(lsvActive.ListItems.Count, "#00")
                Case 2
                    lblMain(5) = Format$(lsvClients.ListItems.Count, "#00")
                Case 3
                    lblMain(5) = Format$(lsvHistory.ListItems.Count, "#00")
                Case Else
                    lblMain(5) = ""
            End Select
        Case 7
            WindowState = vbMinimized
        Case 8
            Unload Me
    End Select
    
End Sub

Private Sub imgButtons_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If (m_bShortcutKeys And X > 0 And Y > 0) Then
        lblMain(0) = imgButtons(Index).Tag ' Show shortcut key
    End If
    
    If (Not m_iHotButton = Index) Then
        Form_MouseMove Button, Shift, X, Y ' Restore last hot button to normal
    End If
    
    If (m_iHotButton = -1) Then
        On Error Resume Next
        
        With imgButtons(Index)
            .Picture = LoadPicture(PATH_IMAGES & "btn" & Index & ".img") ' Draw hot state
        End With
        
        If (Index = 0) Then
            lblMain(12).Visible = False ' Hide clock when help image is visible
        End If
        
        m_iHotButton = Index ' Cache hot button index
    End If
    
End Sub

Private Sub imgButtons_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    With imgButtons(Index)
        If (X > 0 And X < .Width) And (Y > 0 Or Y < .Height) Then
            Exit Sub ' Prevent return to normal state when still inside the control
        End If
    End With
    
    Form_MouseMove Button, Shift, X, Y
    
End Sub

Private Sub imgControlBox_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    picControlBox.Visible = True ' Show control box when in fullscreen
    
End Sub

Private Sub lblMain_Change(Index As Integer)
    Select Case Index
        Case 0
            If (Len(lblMain(0)) = 0 And Not m_iCurScreen = 0) Then
                lblMain(12).Visible = True
                tmrTime.Enabled = True
                tmrTime_Timer
            Else
                lblMain(12).Visible = False
                tmrTime.Enabled = False
            End If
        Case 12                                 ' Time has changed
            mPublic.LoadActiveClients lsvActive   ' Refresh active clients lists
    End Select                                  ' to update time elapsed column
    
End Sub

Private Sub lblMain_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Form_MouseMove Button, Shift, X, Y ' Restore last hot button to normal
    
End Sub

Private Sub lsvActive_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    With lsvActive
        If (.SortKey = ColumnHeader.Index - 1) Then
            .SortOrder = Choose(.SortOrder + 1, lvwDescending, lvwAscending)
        Else
            .SortKey = ColumnHeader.Index - 1
        End If
        .Sorted = True
    End With
    
End Sub

Private Sub lsvClients_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    With lsvClients
        If (.SortKey = ColumnHeader.Index - 1) Then
            .SortOrder = Choose(.SortOrder + 1, lvwDescending, lvwAscending)
        Else
            .SortKey = ColumnHeader.Index - 1
        End If
        .Sorted = True
    End With
    
End Sub

Private Sub lsvClients_DblClick()
    lsvClients.SetFocus
    cmdClients_Click 1 ' Edit/modify
    
End Sub

Private Sub lsvHistory_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    With lsvHistory
        If (.SortKey = ColumnHeader.Index - 1) Then
            .SortOrder = Choose(.SortOrder + 1, lvwDescending, lvwAscending)
        Else
            .SortKey = ColumnHeader.Index - 1
        End If
        .Sorted = True
    End With
    
End Sub

Private Sub lsvHistory_DblClick()
''   Show customer entry on list of registered clients
'    lsvClients.FindItem(lsvHistory.SelectedItem.Text).Selected = True
'    lsvClients.SelectedItem.EnsureVisible
'    Form_KeyDown vbKeyF4, 0
'    lsvClients.SetFocus
    
    ' Show customer statistics
    mscStats.TitleText = lsvHistory.SelectedItem.Text ' Customer name
    mscStats.Tag = lsvHistory.SelectedItem.Tag ' Registration Number
    
    If (dtpEndDate.Value < dtpHistory.Value) Then
        dtpEndDate.Value = dtpHistory.Value ' End date must be > that or = to
    End If                                  ' the start date
    
    dtpStartDate.Value = dtpHistory.Value
    
    Form_KeyDown vbKeyF7, 0 ' Show statistics
    
End Sub

Private Sub mscBarcode_OnComm()
    ' Process receive events only
    If (Not mscBarcode.CommEvent = comEvReceive) Then Exit Sub
    
    Static sBarcode As String
    
    On Error Resume Next
    
    If (Len(sBarcode) = 0) Then ' Clear textbox where to place barcode
        If (m_iCurScreen = 7) Then
            txtTimein(3) = ""
            txtTimein(3).SetFocus
        ElseIf (m_iCurScreen = 8) Then
            txtTimeout(0) = ""
            txtTimeout(0).SetFocus
        End If
    End If
    
    If (Right$(sBarcode, 2) = vbNewLine) Then
        SendKeys sBarcode ' Send barcode using SendKeys to be processed
        sBarcode = ""
    Else ' Append current input to barcode buffer
        sBarcode = sBarcode & mscBarcode.Input
    End If
    
End Sub

Private Sub tmrTime_Timer()
    lblMain(12) = Format$(Time$, "HH:MM AM/PM")
    
End Sub

Private Sub txtTimein_LostFocus(Index As Integer)
    On Error Resume Next
    
    Select Case Index
        Case 0
            If (Len(txtTimein(0)) > 0) Then
                Dim sName() As String
                    sName = Split(mPublic.FromRegNumberToName(txtTimein(0)), ", ")
                    
                If (UBound(sName) = 1) Then
                    txtTimein(1) = sName(0)
                    txtTimein(2) = sName(1)
                    txtTimein(3).SetFocus
                Else
                    txtTimein(1) = ""
                    txtTimein(2) = ""
                End If
            End If
            
        Case 1, 2
            If (Len(txtTimein(1)) > 0 And Len(txtTimein(2)) > 0) Then
                txtTimein(0) = mPublic.FromNameToRegNumber(txtTimein(1) & ", " & txtTimein(2))
                If (Len(txtTimein(0)) > 0) Then
                    txtTimein(3).SetFocus
                End If
            ElseIf (Len(txtTimein(1)) > 0) Then
                If (mPublic.GivenLastNameFillTexts(txtTimein(1), txtTimein(0), txtTimein(2))) Then
                    txtTimein(3).SetFocus
                End If
            ElseIf (Len(txtTimein(2)) > 0) Then
                If (mPublic.GivenFirstNameFillTexts(txtTimein(2), txtTimein(0), txtTimein(1))) Then
                    txtTimein(3).SetFocus
                End If
            End If
            
    End Select
    
End Sub

Private Sub txtTimeout_LostFocus(Index As Integer)
    On Error Resume Next
    
    Select Case Index
        Case 1
            If (Len(txtTimeout(1)) > 0) Then
                Dim sName() As String
                    sName = Split(mPublic.FromRegNumberToName(txtTimeout(1)), ", ")
                    
                If (UBound(sName) = 1) Then
                    txtTimeout(2) = sName(0)
                    txtTimeout(3) = sName(1)
                Else
                    txtTimeout(2) = ""
                    txtTimeout(3) = ""
                End If
                
                cmdTimeout(0).SetFocus
            End If
            
        Case 2, 3
            If (Len(txtTimeout(2)) > 0 And Len(txtTimeout(3)) > 0) Then
                txtTimeout(1) = mPublic.FromNameToRegNumber(txtTimeout(2) & ", " & txtTimeout(3))
                If (Len(txtTimeout(1)) > 0) Then
                    cmdTimeout(0).SetFocus
                End If
            ElseIf (Len(txtTimeout(2)) > 0) Then
                If (mPublic.GivenLastNameFillTexts(txtTimeout(2), txtTimeout(1), txtTimeout(3))) Then
                    cmdTimeout(0).SetFocus
                End If
            ElseIf (Len(txtTimeout(3)) > 0) Then
                If (mPublic.GivenFirstNameFillTexts(txtTimeout(3), txtTimeout(1), txtTimeout(2))) Then
                    cmdTimeout(0).SetFocus
                End If
            End If
            
    End Select
    
End Sub

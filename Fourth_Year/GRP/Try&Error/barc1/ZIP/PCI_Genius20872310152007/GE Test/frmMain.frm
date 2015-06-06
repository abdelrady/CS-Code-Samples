VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "GeniusBus Test Interface"
   ClientHeight    =   8385
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11460
   LinkTopic       =   "Form1"
   ScaleHeight     =   559
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   764
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox Check1 
      Caption         =   "Scan Continuous"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   9180
      TabIndex        =   167
      Top             =   6180
      Width           =   1995
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   11070
      Top             =   8430
   End
   Begin VB.CommandButton Command1 
      Caption         =   "I/O Test"
      Height          =   825
      Left            =   9600
      TabIndex        =   166
      Top             =   6900
      Width           =   1245
   End
   Begin VB.Frame Frame2 
      Caption         =   "GeniusBus Devices (Available devices with Device ID - Non Zero) - Click to view Device info"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   30
      TabIndex        =   100
      Top             =   4200
      Width           =   11415
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   31
         Left            =   10800
         TabIndex        =   163
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   30
         Left            =   10100
         TabIndex        =   161
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   29
         Left            =   9400
         TabIndex        =   159
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   28
         Left            =   8700
         TabIndex        =   157
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   27
         Left            =   8000
         TabIndex        =   155
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   26
         Left            =   7300
         TabIndex        =   153
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   25
         Left            =   6600
         TabIndex        =   151
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   24
         Left            =   5900
         TabIndex        =   149
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   23
         Left            =   5200
         TabIndex        =   147
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   22
         Left            =   4500
         TabIndex        =   145
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   21
         Left            =   3800
         TabIndex        =   143
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   20
         Left            =   3100
         TabIndex        =   141
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   19
         Left            =   2400
         TabIndex        =   139
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   18
         Left            =   1700
         TabIndex        =   137
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   17
         Left            =   1000
         TabIndex        =   135
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   16
         Left            =   270
         TabIndex        =   133
         Text            =   "0"
         Top             =   990
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   15
         Left            =   10800
         TabIndex        =   131
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   14
         Left            =   10100
         TabIndex        =   129
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   13
         Left            =   9400
         TabIndex        =   127
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   12
         Left            =   8700
         TabIndex        =   125
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   11
         Left            =   8000
         TabIndex        =   123
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   10
         Left            =   7300
         TabIndex        =   121
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   9
         Left            =   6600
         TabIndex        =   119
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   8
         Left            =   5900
         TabIndex        =   117
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   7
         Left            =   5200
         TabIndex        =   115
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   6
         Left            =   4500
         TabIndex        =   113
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   5
         Left            =   3800
         TabIndex        =   111
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   4
         Left            =   3100
         TabIndex        =   109
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   3
         Left            =   2400
         TabIndex        =   107
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   2
         Left            =   1700
         TabIndex        =   105
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   1
         Left            =   1000
         TabIndex        =   103
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.TextBox lblSBA 
         Height          =   315
         Index           =   0
         Left            =   300
         TabIndex        =   101
         Text            =   "0"
         Top             =   420
         Width           =   375
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 31"
         Height          =   225
         Index           =   31
         Left            =   10695
         TabIndex        =   164
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 30"
         Height          =   225
         Index           =   30
         Left            =   10005
         TabIndex        =   162
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 29"
         Height          =   225
         Index           =   29
         Left            =   9300
         TabIndex        =   160
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 28"
         Height          =   225
         Index           =   28
         Left            =   8595
         TabIndex        =   158
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 27"
         Height          =   225
         Index           =   27
         Left            =   7905
         TabIndex        =   156
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 26"
         Height          =   225
         Index           =   26
         Left            =   7200
         TabIndex        =   154
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 25"
         Height          =   225
         Index           =   25
         Left            =   6495
         TabIndex        =   152
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 24"
         Height          =   225
         Index           =   24
         Left            =   5805
         TabIndex        =   150
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 23"
         Height          =   225
         Index           =   23
         Left            =   5100
         TabIndex        =   148
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 22"
         Height          =   225
         Index           =   22
         Left            =   4395
         TabIndex        =   146
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 21"
         Height          =   225
         Index           =   21
         Left            =   3705
         TabIndex        =   144
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 20"
         Height          =   225
         Index           =   20
         Left            =   3000
         TabIndex        =   142
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 19"
         Height          =   225
         Index           =   19
         Left            =   2295
         TabIndex        =   140
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 18"
         Height          =   225
         Index           =   18
         Left            =   1605
         TabIndex        =   138
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 17"
         Height          =   225
         Index           =   17
         Left            =   900
         TabIndex        =   136
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 16"
         Height          =   225
         Index           =   16
         Left            =   180
         TabIndex        =   134
         Top             =   750
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 15"
         Height          =   225
         Index           =   15
         Left            =   10700
         TabIndex        =   132
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 14"
         Height          =   225
         Index           =   14
         Left            =   10000
         TabIndex        =   130
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 13"
         Height          =   225
         Index           =   13
         Left            =   9300
         TabIndex        =   128
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 12"
         Height          =   225
         Index           =   12
         Left            =   8600
         TabIndex        =   126
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 11"
         Height          =   225
         Index           =   11
         Left            =   7900
         TabIndex        =   124
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 10"
         Height          =   225
         Index           =   10
         Left            =   7200
         TabIndex        =   122
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 09"
         Height          =   225
         Index           =   9
         Left            =   6500
         TabIndex        =   120
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 08"
         Height          =   225
         Index           =   8
         Left            =   5800
         TabIndex        =   118
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 07"
         Height          =   225
         Index           =   7
         Left            =   5100
         TabIndex        =   116
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 06"
         Height          =   225
         Index           =   6
         Left            =   4400
         TabIndex        =   114
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 05"
         Height          =   225
         Index           =   5
         Left            =   3700
         TabIndex        =   112
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 04"
         Height          =   225
         Index           =   4
         Left            =   3000
         TabIndex        =   110
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 03"
         Height          =   225
         Index           =   3
         Left            =   2300
         TabIndex        =   108
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 02"
         Height          =   225
         Index           =   2
         Left            =   1600
         TabIndex        =   106
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 01"
         Height          =   225
         Index           =   1
         Left            =   900
         TabIndex        =   104
         Top             =   180
         Width           =   585
      End
      Begin VB.Label LabelSBA 
         Caption         =   "SBA 00"
         Height          =   225
         Index           =   0
         Left            =   200
         TabIndex        =   102
         Top             =   180
         Width           =   585
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Raw Memory Read/Write (CopyMemory Function)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2835
      Left            =   30
      TabIndex        =   66
      Top             =   5550
      Width           =   8955
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   8
         Left            =   3210
         TabIndex        =   97
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   9
         Left            =   3600
         TabIndex        =   96
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   10
         Left            =   3990
         TabIndex        =   95
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   11
         Left            =   4380
         TabIndex        =   94
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   12
         Left            =   4770
         TabIndex        =   93
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   13
         Left            =   5160
         TabIndex        =   92
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   14
         Left            =   5550
         TabIndex        =   91
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   15
         Left            =   5940
         TabIndex        =   90
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   0
         Left            =   90
         TabIndex        =   89
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   1
         Left            =   480
         TabIndex        =   88
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   2
         Left            =   870
         TabIndex        =   87
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   3
         Left            =   1260
         TabIndex        =   86
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   4
         Left            =   1650
         TabIndex        =   85
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   5
         Left            =   2040
         TabIndex        =   84
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   6
         Left            =   2430
         TabIndex        =   83
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.TextBox Text13 
         Height          =   315
         Index           =   7
         Left            =   2820
         TabIndex        =   82
         Text            =   "0"
         Top             =   2460
         Width           =   375
      End
      Begin VB.CommandButton Write_Memory 
         Caption         =   "Write Raw Memory"
         Height          =   585
         Left            =   7620
         TabIndex        =   75
         Top             =   2190
         Width           =   1275
      End
      Begin VB.CommandButton Read_Memory 
         Caption         =   "Read Raw Memory"
         Height          =   585
         Left            =   6330
         TabIndex        =   74
         Top             =   2190
         Width           =   1275
      End
      Begin VB.TextBox Text7 
         Height          =   315
         Left            =   6330
         TabIndex        =   73
         Top             =   1170
         Width           =   1245
      End
      Begin VB.TextBox Text8 
         Height          =   315
         Left            =   6330
         TabIndex        =   72
         Top             =   690
         Width           =   1245
      End
      Begin VB.TextBox Text10 
         Height          =   315
         Left            =   6330
         TabIndex        =   71
         Text            =   "1"
         Top             =   1680
         Width           =   1245
      End
      Begin VB.TextBox Text9 
         Height          =   315
         Left            =   7620
         TabIndex        =   70
         Text            =   "1"
         Top             =   1680
         Width           =   1245
      End
      Begin VB.TextBox Text11 
         Height          =   315
         Left            =   7620
         TabIndex        =   69
         Top             =   690
         Width           =   1245
      End
      Begin VB.TextBox Text12 
         Height          =   315
         Left            =   7620
         TabIndex        =   68
         Top             =   1170
         Width           =   1245
      End
      Begin VB.TextBox Text4 
         Height          =   1545
         Left            =   60
         MultiLine       =   -1  'True
         TabIndex        =   67
         Top             =   690
         Width           =   6255
      End
      Begin VB.Label Label18 
         Alignment       =   2  'Center
         Caption         =   "** - WARNING MAY CAUSE CRASH OR CAUSE SUDDEN STOP OF EXECUTION! - **"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   60
         TabIndex        =   165
         Top             =   240
         Width           =   8865
      End
      Begin VB.Label Label17 
         Alignment       =   2  'Center
         Caption         =   "Data to Write in Bytes (16)"
         Height          =   255
         Left            =   150
         TabIndex        =   99
         Top             =   2220
         Width           =   1935
      End
      Begin VB.Label Label16 
         Alignment       =   2  'Center
         Caption         =   "Data Read in Bytes / Data Written"
         Height          =   255
         Left            =   90
         TabIndex        =   98
         Top             =   450
         Width           =   2595
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         Caption         =   "Length in Bytes"
         Height          =   255
         Left            =   6330
         TabIndex        =   81
         Top             =   1470
         Width           =   1245
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         Caption         =   "Base Address"
         Height          =   255
         Left            =   6330
         TabIndex        =   80
         Top             =   990
         Width           =   1245
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         Caption         =   "Bytes per Read"
         Height          =   255
         Left            =   6330
         TabIndex        =   79
         Top             =   1980
         Width           =   1245
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         Caption         =   "Bytes per Write"
         Height          =   255
         Left            =   7620
         TabIndex        =   78
         Top             =   1980
         Width           =   1245
      End
      Begin VB.Label Label10 
         Alignment       =   2  'Center
         Caption         =   "Base Address"
         Height          =   255
         Left            =   7620
         TabIndex        =   77
         Top             =   990
         Width           =   1245
      End
      Begin VB.Label Label11 
         Alignment       =   2  'Center
         Caption         =   "Length in Bytes"
         Height          =   255
         Left            =   7620
         TabIndex        =   76
         Top             =   1470
         Width           =   1245
      End
   End
   Begin VB.CommandButton Disable_Card 
      Caption         =   "Disable Card"
      Height          =   555
      Left            =   9930
      TabIndex        =   51
      Top             =   3630
      Width           =   1515
   End
   Begin VB.TextBox lblCardSBA 
      Alignment       =   2  'Center
      Height          =   315
      Left            =   9930
      TabIndex        =   50
      Top             =   3000
      Width           =   1500
   End
   Begin VB.TextBox lblCardSetupError 
      Alignment       =   2  'Center
      Height          =   315
      Left            =   9930
      TabIndex        =   49
      Top             =   2400
      Width           =   1500
   End
   Begin VB.Frame gbDeviceConfig 
      Caption         =   "Device Configuration"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4185
      Left            =   3510
      TabIndex        =   38
      Top             =   0
      Width           =   3525
      Begin VB.Label Label15 
         Alignment       =   1  'Right Justify
         Caption         =   "Device Type Description:"
         Height          =   375
         Left            =   60
         TabIndex        =   64
         Top             =   3180
         Width           =   975
      End
      Begin VB.Label lblDeviceTypeDescription 
         BorderStyle     =   1  'Fixed Single
         Height          =   885
         Left            =   1050
         TabIndex        =   63
         Top             =   3210
         Width           =   2355
      End
      Begin VB.Label Label13 
         Alignment       =   1  'Right Justify
         Caption         =   "Device Type Part #:"
         Height          =   405
         Left            =   60
         TabIndex        =   62
         Top             =   2700
         Width           =   975
      End
      Begin VB.Label lblDeviceTypePart 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Height          =   345
         Left            =   1050
         TabIndex        =   61
         Top             =   2760
         Width           =   2355
      End
      Begin VB.Label lblDeviceTypeTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Device Type:"
         Height          =   255
         Left            =   1560
         TabIndex        =   60
         Top             =   2370
         Width           =   975
      End
      Begin VB.Label lblDeviceType 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Height          =   345
         Left            =   2550
         TabIndex        =   59
         Top             =   2310
         Width           =   855
      End
      Begin VB.Label lblBCDLenTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Broadcast Control Data Length:"
         Height          =   255
         Left            =   150
         TabIndex        =   48
         Top             =   660
         Width           =   2385
      End
      Begin VB.Label lblBCDLenTagValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "@@"
         Height          =   345
         Left            =   2550
         TabIndex        =   47
         Top             =   600
         Width           =   825
      End
      Begin VB.Label lblDCDLenTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Directed Control Data Length:"
         Height          =   255
         Left            =   150
         TabIndex        =   46
         Top             =   1050
         Width           =   2385
      End
      Begin VB.Label lblDCDLenTagValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "@@"
         Height          =   345
         Left            =   2550
         TabIndex        =   45
         Top             =   990
         Width           =   825
      End
      Begin VB.Label lblCircuitCfgTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Circuits:"
         Height          =   255
         Left            =   150
         TabIndex        =   44
         Top             =   1440
         Width           =   2385
      End
      Begin VB.Label lblCircuitCfg 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "@@"
         Height          =   345
         Left            =   2550
         TabIndex        =   43
         Top             =   1380
         Width           =   825
      End
      Begin VB.Label lblRefAddrTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Reference Address:"
         Height          =   255
         Left            =   150
         TabIndex        =   42
         Top             =   1830
         Width           =   2385
      End
      Begin VB.Label lblRefAddrTagValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "@@"
         Height          =   345
         Left            =   2550
         TabIndex        =   41
         Top             =   1770
         Width           =   825
      End
      Begin VB.Label lblOutputsEnable 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "@@"
         Height          =   345
         Left            =   2550
         TabIndex        =   40
         Top             =   210
         Width           =   825
      End
      Begin VB.Label lblOutputsEnableTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Outputs:"
         Height          =   255
         Left            =   840
         TabIndex        =   39
         Top             =   240
         Width           =   1695
      End
   End
   Begin VB.Frame grpSetup 
      Caption         =   "PCI Genius Card Setup"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4185
      Left            =   0
      TabIndex        =   26
      Top             =   0
      Width           =   3495
      Begin VB.Frame grpUserChangable 
         Caption         =   "Changeable by User - (Bytes Card Writes)"
         Height          =   2295
         Left            =   60
         TabIndex        =   27
         Top             =   1800
         Width           =   3375
         Begin VB.TextBox lblRefAddrValue 
            Alignment       =   2  'Center
            Height          =   345
            Left            =   2460
            TabIndex        =   171
            Text            =   "0"
            Top             =   1380
            Width           =   810
         End
         Begin VB.TextBox lblIOBufferLenValue 
            Alignment       =   2  'Center
            Height          =   345
            Left            =   2460
            TabIndex        =   170
            Text            =   "0"
            Top             =   990
            Width           =   810
         End
         Begin VB.TextBox lblDCDLenValue 
            Alignment       =   2  'Center
            Height          =   345
            Left            =   2460
            TabIndex        =   169
            Text            =   "0"
            Top             =   600
            Width           =   810
         End
         Begin VB.TextBox lblBCDLenValue 
            Alignment       =   2  'Center
            Height          =   345
            Left            =   2460
            TabIndex        =   168
            Text            =   "0"
            Top             =   210
            Width           =   810
         End
         Begin VB.CommandButton ChangeSetup 
            Caption         =   "Change Setup"
            Height          =   465
            Left            =   960
            TabIndex        =   65
            Top             =   1770
            Width           =   1515
         End
         Begin VB.Label lblBCDLen 
            Alignment       =   1  'Right Justify
            Caption         =   "Broadcast Control Data Length:"
            Height          =   255
            Left            =   60
            TabIndex        =   31
            Top             =   270
            Width           =   2385
         End
         Begin VB.Label lblDCDLen 
            Alignment       =   1  'Right Justify
            Caption         =   "Directed Control Data Length:"
            Height          =   255
            Left            =   60
            TabIndex        =   30
            Top             =   660
            Width           =   2385
         End
         Begin VB.Label lblIOBufferLen 
            Alignment       =   1  'Right Justify
            Caption         =   "I/O Table Buffer Length:"
            Height          =   255
            Left            =   60
            TabIndex        =   29
            Top             =   1050
            Width           =   2385
         End
         Begin VB.Label lblRefAddr 
            Alignment       =   1  'Right Justify
            Caption         =   "Reference Address:"
            Height          =   255
            Left            =   60
            TabIndex        =   28
            Top             =   1440
            Width           =   2385
         End
      End
      Begin VB.Label lblCardTag 
         Alignment       =   1  'Right Justify
         Caption         =   "Card ID:"
         Height          =   255
         Index           =   0
         Left            =   570
         TabIndex        =   58
         Top             =   240
         Width           =   585
      End
      Begin VB.Label lblCard 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "GEGENIUSx"
         Height          =   345
         Left            =   1200
         TabIndex        =   57
         Top             =   210
         Width           =   2205
      End
      Begin VB.Label lblDeviceAddress 
         Alignment       =   1  'Right Justify
         Caption         =   "Serial Bus Address:"
         Height          =   255
         Left            =   690
         TabIndex        =   37
         Top             =   630
         Width           =   1695
      End
      Begin VB.Label lblBaudRate 
         Alignment       =   1  'Right Justify
         Caption         =   "Baud Rate:"
         Height          =   255
         Left            =   690
         TabIndex        =   36
         Top             =   1050
         Width           =   1695
      End
      Begin VB.Label lblOutputs 
         Alignment       =   1  'Right Justify
         Caption         =   "Outputs:"
         Height          =   255
         Left            =   690
         TabIndex        =   35
         Top             =   1440
         Width           =   1695
      End
      Begin VB.Label lblDeviceAddressValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "##"
         Height          =   345
         Left            =   2400
         TabIndex        =   34
         Top             =   600
         Width           =   1005
      End
      Begin VB.Label lblBaudRateValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "-------------"
         Height          =   345
         Left            =   2400
         TabIndex        =   33
         Top             =   990
         Width           =   1005
      End
      Begin VB.Label lblOutputsValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "---------"
         Height          =   345
         Left            =   2400
         TabIndex        =   32
         Top             =   1380
         Width           =   1005
      End
   End
   Begin VB.Frame gpStatus 
      Caption         =   "GeniusBus Status"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4185
      Left            =   7050
      TabIndex        =   4
      Top             =   0
      Width           =   2865
      Begin VB.Frame grpHardware 
         Caption         =   "Hardware"
         Height          =   1965
         Left            =   90
         TabIndex        =   11
         Top             =   1290
         Width           =   2685
         Begin VB.Label lblHostHBFaultValue 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "---"
            Height          =   345
            Left            =   1740
            TabIndex        =   21
            Top             =   1560
            Width           =   825
         End
         Begin VB.Label lblHostHBFault 
            Alignment       =   1  'Right Justify
            Caption         =   "Host Heartbeat Fault:"
            Height          =   255
            Left            =   30
            TabIndex        =   20
            Top             =   1620
            Width           =   1695
         End
         Begin VB.Label lblCommHWFaultValue 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "---"
            Height          =   345
            Left            =   1740
            TabIndex        =   19
            Top             =   1200
            Width           =   825
         End
         Begin VB.Label lblCommHWFault 
            Alignment       =   1  'Right Justify
            Caption         =   "Comm Hardware Fault:"
            Height          =   255
            Left            =   30
            TabIndex        =   18
            Top             =   1260
            Width           =   1695
         End
         Begin VB.Label lblProcessorFaultValue 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "---"
            Height          =   345
            Left            =   1740
            TabIndex        =   17
            Top             =   840
            Width           =   825
         End
         Begin VB.Label lblProcessorFault 
            Alignment       =   1  'Right Justify
            Caption         =   "Processor Fault:"
            Height          =   255
            Left            =   30
            TabIndex        =   16
            Top             =   900
            Width           =   1695
         End
         Begin VB.Label lblEPROMFaultValue 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "---"
            Height          =   345
            Left            =   1740
            TabIndex        =   15
            Top             =   480
            Width           =   825
         End
         Begin VB.Label lblEPROMFault 
            Alignment       =   1  'Right Justify
            Caption         =   "EPROM Fault:"
            Height          =   255
            Left            =   30
            TabIndex        =   14
            Top             =   540
            Width           =   1695
         End
         Begin VB.Label lblRAMFaultValue 
            Alignment       =   2  'Center
            BorderStyle     =   1  'Fixed Single
            Caption         =   "---"
            Height          =   345
            Left            =   1740
            TabIndex        =   13
            Top             =   120
            Width           =   825
         End
         Begin VB.Label lblRAMFault 
            Alignment       =   1  'Right Justify
            Caption         =   "RAM Fault:"
            Height          =   255
            Left            =   30
            TabIndex        =   12
            Top             =   180
            Width           =   1695
         End
      End
      Begin VB.Label lblBusErrorCountValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "####"
         Height          =   345
         Left            =   1830
         TabIndex        =   25
         Top             =   3750
         Width           =   825
      End
      Begin VB.Label lblBusErrorCount 
         Alignment       =   1  'Right Justify
         Caption         =   "Bus Error Count:"
         Height          =   255
         Left            =   120
         TabIndex        =   24
         Top             =   3810
         Width           =   1695
      End
      Begin VB.Label lblExBusErrorsValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "---"
         Height          =   345
         Left            =   1830
         TabIndex        =   23
         Top             =   3390
         Width           =   825
      End
      Begin VB.Label lblExBusErrors 
         Alignment       =   1  'Right Justify
         Caption         =   "Excessive Bus Errors:"
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   3450
         Width           =   1695
      End
      Begin VB.Label lblBusScanTimeValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "#####"
         Height          =   345
         Left            =   1830
         TabIndex        =   10
         Top             =   930
         Width           =   825
      End
      Begin VB.Label lblBoardStatusValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "------"
         Height          =   345
         Left            =   1830
         TabIndex        =   9
         Top             =   570
         Width           =   825
      End
      Begin VB.Label lblFirmwareRevValue 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "M.m"
         Height          =   345
         Left            =   1830
         TabIndex        =   8
         Top             =   210
         Width           =   825
      End
      Begin VB.Label lblBusScanTime 
         Alignment       =   1  'Right Justify
         Caption         =   "Bus Scan Time (msec):"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   990
         Width           =   1695
      End
      Begin VB.Label lblBoardStatus 
         Alignment       =   1  'Right Justify
         Caption         =   "Board:"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   630
         Width           =   1695
      End
      Begin VB.Label lblFirmwareRev 
         Alignment       =   1  'Right Justify
         Caption         =   "Firmware Revision:"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   240
         Width           =   1695
      End
   End
   Begin VB.TextBox lblPCIMemoryAddress 
      Alignment       =   2  'Center
      Height          =   315
      Left            =   9930
      TabIndex        =   3
      Top             =   1800
      Width           =   1500
   End
   Begin VB.TextBox lblWindowsHandle 
      Alignment       =   2  'Center
      Height          =   315
      Left            =   9930
      TabIndex        =   2
      Top             =   1200
      Width           =   1500
   End
   Begin VB.CommandButton LocateEnableCard 
      Caption         =   "(Reset) Locate and Enable Card"
      Height          =   555
      Left            =   9930
      TabIndex        =   1
      Top             =   60
      Width           =   1515
   End
   Begin VB.TextBox lblLocateCardError 
      Alignment       =   2  'Center
      Height          =   315
      Left            =   9930
      TabIndex        =   0
      Top             =   600
      Width           =   1500
   End
   Begin VB.Label Label8 
      Alignment       =   2  'Center
      Caption         =   "Card GeniusBus SBA"
      Height          =   255
      Left            =   9930
      TabIndex        =   56
      Top             =   3330
      Width           =   1500
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      Caption         =   "Card Setup Error"
      Height          =   255
      Left            =   9930
      TabIndex        =   55
      Top             =   2730
      Width           =   1500
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      Caption         =   "PCI Memory Address"
      Height          =   255
      Left            =   9930
      TabIndex        =   54
      Top             =   2130
      Width           =   1500
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      Caption         =   "Windows Handle"
      Height          =   255
      Left            =   9930
      TabIndex        =   53
      Top             =   1530
      Width           =   1500
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      Caption         =   "Locate Card Error"
      Height          =   255
      Left            =   9930
      TabIndex        =   52
      Top             =   930
      Width           =   1500
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private I                As Integer 'Used in Timer sub
Private HardwareStatus   As Byte    'Ditto
Private BusStatus        As Byte    'Ditto
Private Sub ChangeSetup_Click()
Dim Setup As GENI_SETUP
    With Setup
        .broadcast_control_data_length = CByte(Val(lblBCDLenValue.Text))
        .directed_control_data_length = CByte(Val(lblDCDLenValue.Text))
        .io_buffer_length = CByte(Val(lblIOBufferLenValue.Text))
        .reference_address = CInt(Val(lblRefAddrValue.Text))
    End With 'Setup
    GENI_Change_Setup Setup
End Sub
Private Sub Check1_Click()
    Timer1.Enabled = Check1.Value
End Sub
Private Sub Command1_Click()
    IO_Display.Show
End Sub
Private Sub Disable_Card_Click()
    GENI_Destruct
End Sub
Private Sub Form_Load()
    lblCard.Caption = cGEGENIUS
    lblLocateCardError.Text = LocationResult
    lblWindowsHandle.Text = hWin32Device
    lblPCIMemoryAddress.Text = MemoryBaseAddress
    lblCardSetupError.Text = InitializationResult
    lblCardSBA.Text = SerialBusAddress
    lblDeviceAddressValue.Caption = Node
    If BaudRate = Baud_153p6kEXT Then
        lblBaudRateValue.Caption = "153.6k EXT"
    ElseIf BaudRate = baud_153p6kstd Then
        lblBaudRateValue.Caption = "153.6k Std"
    ElseIf BaudRate = Baud_38p4k Then
        lblBaudRateValue.Caption = "38.4k"
    ElseIf BaudRate = Baud_76p8k Then
        lblBaudRateValue.Caption = "76.8k"
    End If
    If Outputs = OutputsEnabled Then
        lblOutputsValue.Caption = 1
    ElseIf Outputs = Outputsdisabled Then
        lblOutputsValue.Caption = 0
    End If
    Me.Show
    Text7.Text = 0
    Text8.Text = 0
    Text10.Text = 1
End Sub
Private Sub Form_Unload(Cancel As Integer)
    GENI_Destruct
    End
End Sub
Private Sub lblSBA_Click(Index As Integer)
    With DeviceConfig(Index)
        lblOutputsEnable.Caption = .outputs_disable
        lblBCDLenTagValue.Caption = .broadcast_control_data_length
        lblDCDLenTagValue.Caption = .directed_control_data_length
        lblCircuitCfg.Caption = .block_config
        lblRefAddrTagValue.Caption = .reference_address
        lblDeviceType.Caption = .model_number
    End With
    Select Case DeviceConfig(Index).model_number
    Case 0
        lblDeviceTypePart.Caption = "[###]"
        lblDeviceTypeDescription.Caption = "No Device Present"
    Case 2
        lblDeviceTypePart.Caption = "[IC660HHM500]"
        lblDeviceTypeDescription.Caption = "Hand-held monitor HHM PhaseA"
    Case 5
        lblDeviceTypePart.Caption = "[IC660HHM501]"
        lblDeviceTypeDescription.Caption = "Hand-held monitor HHM"
    Case 64
        lblDeviceTypePart.Caption = "[IC660CBD100]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 115VAC Grouped PhaseA"
    Case 65
        lblDeviceTypePart.Caption = "[IC660CBS100]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 115VAC 125VDC Isolated PhaseA"
    Case 69
        lblDeviceTypePart.Caption = "[IC660BBD100]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 115VAC 2A Grouped"
    Case 70
        lblDeviceTypePart.Caption = "[IC660BBS100 / IC660BBS101]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 115VAC 125VDC Isolated"
    Case 71
        lblDeviceTypePart.Caption = "[IC660??????]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 220VAC Grouped"
    Case 82
        lblDeviceTypePart.Caption = "[IC660BBD101]"
        lblDeviceTypeDescription.Caption = "8 circuit discrete block 115VAC LowLeakage Grouped"
    Case 67
        lblDeviceTypePart.Caption = "[IC660CBD021]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block 24VDC 48VDC Sink PhaseA"
    Case 68
        lblDeviceTypePart.Caption = "[IC660CBD020]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block 24VDC 48VDC Source PhaseA"
    Case 72
        lblDeviceTypePart.Caption = "[IC660BBD021 / IC660BBD023]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block 24VDC 48VDC Sink"
    Case 73
        lblDeviceTypePart.Caption = "[IC660BBD020 / IC660BBD022]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block 12VDC 24VDC 48VDC Source"
    Case 79
        lblDeviceTypePart.Caption = "[IC660BBR101]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block Normally Open Relay"
    Case 80
        lblDeviceTypePart.Caption = "[IC660BBR100]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block Normally Closed Relay"
    Case 81
        lblDeviceTypePart.Caption = "[IC660BBD110]"
        lblDeviceTypeDescription.Caption = "16 circuit discrete block 115VAC Input"
    Case 74
        lblDeviceTypePart.Caption = "[IC660BBD025]"
        lblDeviceTypeDescription.Caption = "32 circuit discrete block 5VDC 12VDC 24VDC Sink"
    Case 75
        lblDeviceTypePart.Caption = "[IC660BBD024]"
        lblDeviceTypeDescription.Caption = "32 circuit discrete block 12VDC 24VDC Source"
    Case 131
        lblDeviceTypePart.Caption = "[IC660BBA100]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Voltage Current 115VAC"
    Case 132
        lblDeviceTypePart.Caption = "[IC660BBA020]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Voltage Current 24VDC 48VDC"
    Case 128
        lblDeviceTypePart.Caption = "[IC660CBA100]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Voltage Current 115VAC PhaseA"
    Case 129
        lblDeviceTypePart.Caption = "[IC660CBA020]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Voltage Current 24VDC 48VDC PhaseA"
    Case 140
        lblDeviceTypePart.Caption = "[IC660BBA104]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Current Source 115VAC 125VDC"
    Case 141
        lblDeviceTypePart.Caption = "[IC660BBA024]"
        lblDeviceTypeDescription.Caption = "4 input / 2 output analog block Current Source 24VDC 48VDC"
    Case 142
        lblDeviceTypePart.Caption = "[IC660BBA105]"
        lblDeviceTypeDescription.Caption = "6 output analog block Current Source 115VAC 125VDC"
    Case 143
        lblDeviceTypePart.Caption = "[IC660BBA025]"
        lblDeviceTypeDescription.Caption = "6 output analog block Current Source 24VDC 48VDC"
    Case 144
        lblDeviceTypePart.Caption = "[IC660BBA106]"
        lblDeviceTypeDescription.Caption = "6 input analog block Current Source 115VAC 125VDC"
    Case 145
        lblDeviceTypePart.Caption = "[IC660BBA026]"
        lblDeviceTypeDescription.Caption = "6 input analog block Current Source 24VDC 48VDC"
    Case 134
        lblDeviceTypePart.Caption = "[IC660BBA103]"
        lblDeviceTypeDescription.Caption = "6 input thermocouple block 115VAC 125VDC"
    Case 135
        lblDeviceTypePart.Caption = "[IC660BBA023]"
        lblDeviceTypeDescription.Caption = "6 input thermocouple block 24VDC 48VDC"
    Case 136
        lblDeviceTypePart.Caption = "[IC660BBA101]"
        lblDeviceTypeDescription.Caption = "6 input RTD block 115VAC 125VDC"
    Case 137
        lblDeviceTypePart.Caption = "[IC660BBA021]"
        lblDeviceTypeDescription.Caption = "6 input RTD block 24VDC 48VDC"
    Case 32
        lblDeviceTypePart.Caption = "[IC660BBD120]"
        lblDeviceTypeDescription.Caption = "High speed counter (types A,B,C) block"
    Case 127
        lblDeviceTypePart.Caption = "[IC660BPM100]"
        lblDeviceTypeDescription.Caption = "PowerTRAC block"
    Case 1
        lblDeviceTypePart.Caption = "[IC660CBB900]"
        lblDeviceTypeDescription.Caption = "Series 6 Bus Controller PhaseA"
    Case 3
        lblDeviceTypePart.Caption = "[IC660CBB901]"
        lblDeviceTypeDescription.Caption = "Series 6 Bus Controller Wout Diags PhaseA"
    Case 6
        lblDeviceTypePart.Caption = "[IC660CBB902]"
        lblDeviceTypeDescription.Caption = "Series 6 Bus Controller"
    Case 7
        lblDeviceTypePart.Caption = "[IC660CBB903]"
        lblDeviceTypeDescription.Caption = "Series 6 Bus Controller Wout Diags"
    Case 10
        lblDeviceTypePart.Caption = "[IC697BEM731]"
        lblDeviceTypeDescription.Caption = "Series 90-70 Bus Controller"
    Case 15
        lblDeviceTypePart.Caption = "[IC693BEM331]"
        lblDeviceTypeDescription.Caption = "Series 90-30 Bus Controller"
    Case 160
        lblDeviceTypePart.Caption = "[IC697BEM733]"
        lblDeviceTypeDescription.Caption = "Series 90-70 Remote I/O Scanner"
    Case 13
        lblDeviceTypePart.Caption = "[IC693CMM301]"
        lblDeviceTypeDescription.Caption = "Series 90-30 Communications Module"
    Case 14
        lblDeviceTypePart.Caption = "[IC693CMM302]"
        lblDeviceTypeDescription.Caption = "Series 90-30 Enhanced Communications Module"
    'Case 160
        'lblDeviceTypePart.Caption = "[IC670GBI001]"
        'lblDeviceTypeDescription.Caption = "Field Control Genius Bus Interface Unit"
    Case 161
        lblDeviceTypePart.Caption = "[IC200GBI001]"
        lblDeviceTypeDescription.Caption = "VersaMax Genius Bus Interface Unit"
    Case 4
        lblDeviceTypePart.Caption = "[IC660ELB9xx]"
        lblDeviceTypeDescription.Caption = "ISA-bus and PCI-bus GENI type device"
    Case Else
        lblDeviceTypePart.Caption = "[???]"
        lblDeviceTypeDescription.Caption = "UNKNOWN DEVICE PRESENT"
    End Select
End Sub
Private Sub LocateEnableCard_Click()
    GENI_Destruct
    Setup.Show
End Sub
Private Sub Read_Memory_Click()
Dim I       As Long
Dim j       As Long
Dim k(8192) As Byte
Dim l       As Long
Dim b       As Long
Dim Address As Long
    Text4.Text = vbNullString
    I = CLng(Text7.Text)
    j = CLng(Text8.Text)
    b = CLng(Text10.Text)
    For l = 0 To I
        Address = (j + l)
        CopyMemory k(l), ByVal Address, b
        Text4.Text = Text4.Text & " " & CStr(k(l))
    Next l
End Sub
Private Sub Timer1_Timer()
    If LocationResult = (GENI_NoError) Then
        lblRefAddrValue.Text = GetVar(MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 1, 2)
        lblBCDLenValue.Text = GetVar(MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 3, 1)
        lblDCDLenValue.Text = GetVar(MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 4, 1)
        lblIOBufferLenValue.Text = GetVar(MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 5, 1)
        For I = 0 To 31
            With DeviceConfig(I)
                .device_present = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 2), 1)
                If .device_present Then
                    .model_number = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I)), 1)
                    .outputs_disable = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 1), 1)
                    .reference_address = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 3), 2)
                    .broadcast_control_data_length = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 5), 1)
                    .directed_control_data_length = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 6), 1)
                    .block_config = GetVar((MemoryBaseAddress + SRI_Device_Config_Offset(I) + 7), 1)
                    lblSBA(I).Text = .model_number
                End If
            End With
        Next I
        lblFirmwareRevValue.Caption = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET, 1)
        lblBoardStatusValue.Caption = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 1, 1)
        lblBusScanTimeValue.Caption = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 6, 2)
        HardwareStatus = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 2, 1)
        BusStatus = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 3, 1)
        If HardwareStatus = 1 Then
            lblRAMFaultValue.Caption = "Yes"
        Else
            lblRAMFaultValue.Caption = "No"
        End If
        If HardwareStatus = 2 Then
            lblEPROMFaultValue.Caption = "Yes"
        Else
            lblEPROMFaultValue.Caption = "No"
        End If
        If HardwareStatus = 4 Then
            lblProcessorFaultValue.Caption = "Yes"
        Else
            lblProcessorFaultValue.Caption = "No"
        End If
        If HardwareStatus = 8 Then
            lblCommHWFaultValue.Caption = "Yes"
        Else
            lblCommHWFaultValue.Caption = "No"
        End If
        If HardwareStatus = 10 Then
            lblHostHBFaultValue.Caption = "Yes"
        Else
            lblHostHBFaultValue.Caption = "No"
        End If
        If BusStatus = 4 Then
            lblExBusErrorsValue.Caption = "Yes"
        Else
            lblExBusErrorsValue.Caption = "No"
        End If
        lblBusErrorCountValue.Caption = GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 4, 2)
    End If
End Sub
Private Sub Write_Memory_Click()
Dim I       As Long
Dim j       As Long
Dim k(8192) As Byte
Dim l       As Long
Dim b       As Long
Dim Address As Long
    I = CLng(Text12.Text)
    j = CLng(Text11.Text)
    b = CLng(Text9.Text)
    For l = 0 To 15
        k(l) = CByte(CInt(Text13(l).Text))
    Next l
    l = 0
    For l = 0 To I
        Address = (j + l)
        CopyMemory ByVal Address, k(l), b
        Text4.Text = Text4.Text & " " & CStr(k(l))
    Next l
End Sub

VERSION 5.00
Begin VB.Form Tutorial 
   Caption         =   "Barcode Tutorial"
   ClientHeight    =   9675
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   14670
   LinkTopic       =   "Form1"
   ScaleHeight     =   9675
   ScaleWidth      =   14670
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command7 
      Caption         =   "Complete Table"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   10800
      TabIndex        =   143
      Top             =   2320
      Width           =   1695
   End
   Begin VB.TextBox Text3 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   3
      Left            =   7680
      MultiLine       =   -1  'True
      TabIndex        =   140
      Text            =   "Tutorial.frx":0000
      Top             =   9000
      Width           =   6975
   End
   Begin VB.TextBox Text3 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2775
      Index           =   2
      Left            =   7680
      MultiLine       =   -1  'True
      TabIndex        =   138
      Text            =   "Tutorial.frx":0039
      Top             =   5640
      Width           =   6975
   End
   Begin VB.TextBox Text3 
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1575
      Index           =   1
      Left            =   7680
      MultiLine       =   -1  'True
      TabIndex        =   136
      Text            =   "Tutorial.frx":0236
      Top             =   3480
      Width           =   6975
   End
   Begin VB.TextBox Text3 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1575
      Index           =   0
      Left            =   7680
      MultiLine       =   -1  'True
      TabIndex        =   135
      Text            =   "Tutorial.frx":02DF
      Top             =   1200
      Width           =   6975
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Test Barcode Engine"
      Height          =   495
      Left            =   6000
      TabIndex        =   133
      Top             =   5280
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0054A7A7&
      Caption         =   "BARCODE BOARD (use table above) (remember to start and end with asterisk)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2655
      Left            =   0
      TabIndex        =   123
      Top             =   5880
      Width           =   7590
      Begin VB.PictureBox Picture1 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   1695
         Left            =   120
         ScaleHeight     =   113
         ScaleMode       =   3  'Pixel
         ScaleWidth      =   497
         TabIndex        =   128
         Top             =   240
         Width           =   7455
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H00FF00FF&
         Caption         =   "Narrow Bar"
         Height          =   495
         Left            =   150
         Style           =   1  'Graphical
         TabIndex        =   127
         Top             =   2040
         Width           =   1935
      End
      Begin VB.CommandButton Command2 
         BackColor       =   &H00FF00FF&
         Caption         =   "Narrow Space"
         Height          =   495
         Left            =   2160
         Style           =   1  'Graphical
         TabIndex        =   126
         Top             =   2040
         Width           =   1695
      End
      Begin VB.CommandButton Command3 
         BackColor       =   &H00FF00FF&
         Caption         =   "Wide Space"
         Height          =   495
         Left            =   5880
         Style           =   1  'Graphical
         TabIndex        =   125
         Top             =   2040
         Width           =   1695
      End
      Begin VB.CommandButton Command4 
         BackColor       =   &H00FF00FF&
         Caption         =   "Wide bar"
         Height          =   495
         Left            =   3960
         Style           =   1  'Graphical
         TabIndex        =   124
         Top             =   2040
         Width           =   1815
      End
   End
   Begin VB.TextBox Text1 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS UI Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5520
      TabIndex        =   0
      Text            =   "50"
      Top             =   9360
      Width           =   2055
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H008080FF&
      Caption         =   "Print Barcode Using Engine"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   0
      TabIndex        =   129
      Top             =   8520
      Width           =   7590
      Begin VB.TextBox Text2 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   1320
         TabIndex        =   131
         Text            =   "nwnnwnwnnnnnnwwnwnnnwnnwnnnnwnnnwwnnnnwnwnwwnnnnnnnnnwwnnnwnwnnwwnnnnnnwnnwnwnn"
         Top             =   240
         Width           =   3975
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Print with Barcode Engine"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   5400
         TabIndex        =   130
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Write Code:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   360
         TabIndex        =   132
         Top             =   285
         Width           =   975
      End
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "How to use BARCODE BOARD"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Index           =   2
      Left            =   7680
      TabIndex        =   139
      Top             =   5040
      Width           =   6975
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "How Barcode Engine Works"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Index           =   1
      Left            =   7680
      TabIndex        =   137
      Top             =   2880
      Width           =   6975
   End
   Begin VB.Label Label5 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Why I have used only ""n"" and ""w"" instead of passing characters to Barcode Engine"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Index           =   0
      Left            =   7680
      TabIndex        =   134
      Top             =   240
      Width           =   6975
   End
   Begin VB.Label Label7 
      BackColor       =   &H00C0C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "NOTE: The start and end character of BARCODE39 is always ASTERISK ( * )""."
      BeginProperty Font 
         Name            =   "Trebuchet MS"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   255
      Left            =   120
      TabIndex        =   122
      Top             =   5520
      Width           =   7575
   End
   Begin VB.Label Label6 
      BackColor       =   &H00C0E0FF&
      BackStyle       =   0  'Transparent
      Caption         =   $"Tutorial.frx":03F2
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   121
      Top             =   4680
      Width           =   7575
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "*"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   10
      Left            =   240
      TabIndex        =   120
      Top             =   4320
      Width           =   75
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "9"
      Height          =   195
      Index           =   9
      Left            =   240
      TabIndex        =   119
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "8"
      Height          =   195
      Index           =   8
      Left            =   240
      TabIndex        =   118
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "7"
      Height          =   195
      Index           =   7
      Left            =   240
      TabIndex        =   117
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "6"
      Height          =   195
      Index           =   6
      Left            =   240
      TabIndex        =   116
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "5"
      Height          =   195
      Index           =   5
      Left            =   240
      TabIndex        =   115
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "4"
      Height          =   195
      Index           =   4
      Left            =   240
      TabIndex        =   114
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "3"
      Height          =   195
      Index           =   3
      Left            =   240
      TabIndex        =   113
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "2"
      Height          =   195
      Index           =   2
      Left            =   240
      TabIndex        =   112
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "1"
      Height          =   195
      Index           =   1
      Left            =   240
      TabIndex        =   111
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "0"
      Height          =   195
      Index           =   0
      Left            =   240
      TabIndex        =   110
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   98
      Left            =   7230
      TabIndex        =   109
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   97
      Left            =   6360
      TabIndex        =   108
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   96
      Left            =   5685
      TabIndex        =   107
      Top             =   4320
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   95
      Left            =   4875
      TabIndex        =   106
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   94
      Left            =   4110
      TabIndex        =   105
      Top             =   4320
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   93
      Left            =   3330
      TabIndex        =   104
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   92
      Left            =   2535
      TabIndex        =   103
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   91
      Left            =   1740
      TabIndex        =   102
      Top             =   4320
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   90
      Left            =   960
      TabIndex        =   101
      Top             =   4320
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   89
      Left            =   7230
      TabIndex        =   100
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   88
      Left            =   6360
      TabIndex        =   99
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   87
      Left            =   5685
      TabIndex        =   98
      Top             =   3960
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   86
      Left            =   4875
      TabIndex        =   97
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   85
      Left            =   4110
      TabIndex        =   96
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   84
      Left            =   3330
      TabIndex        =   95
      Top             =   3960
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   83
      Left            =   2535
      TabIndex        =   94
      Top             =   3960
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   82
      Left            =   1740
      TabIndex        =   93
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   81
      Left            =   960
      TabIndex        =   92
      Top             =   3960
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   80
      Left            =   7230
      TabIndex        =   91
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   79
      Left            =   6360
      TabIndex        =   90
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   78
      Left            =   5685
      TabIndex        =   89
      Top             =   3600
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   77
      Left            =   4875
      TabIndex        =   88
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   76
      Left            =   4110
      TabIndex        =   87
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   75
      Left            =   3330
      TabIndex        =   86
      Top             =   3600
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   74
      Left            =   2535
      TabIndex        =   85
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   73
      Left            =   1740
      TabIndex        =   84
      Top             =   3600
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   72
      Left            =   960
      TabIndex        =   83
      Top             =   3600
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   71
      Left            =   7230
      TabIndex        =   82
      Top             =   3240
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   70
      Left            =   6360
      TabIndex        =   81
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   69
      Left            =   5685
      TabIndex        =   80
      Top             =   3240
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   68
      Left            =   4875
      TabIndex        =   79
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   67
      Left            =   4110
      TabIndex        =   78
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   66
      Left            =   3330
      TabIndex        =   77
      Top             =   3240
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   65
      Left            =   2535
      TabIndex        =   76
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   64
      Left            =   1740
      TabIndex        =   75
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   63
      Left            =   960
      TabIndex        =   74
      Top             =   3240
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   62
      Left            =   7230
      TabIndex        =   73
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   61
      Left            =   6360
      TabIndex        =   72
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   60
      Left            =   5685
      TabIndex        =   71
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   59
      Left            =   4875
      TabIndex        =   70
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   58
      Left            =   4110
      TabIndex        =   69
      Top             =   2880
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   57
      Left            =   3330
      TabIndex        =   68
      Top             =   2880
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   56
      Left            =   2535
      TabIndex        =   67
      Top             =   2880
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   55
      Left            =   1740
      TabIndex        =   66
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   54
      Left            =   960
      TabIndex        =   65
      Top             =   2880
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   53
      Left            =   7230
      TabIndex        =   64
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   52
      Left            =   6360
      TabIndex        =   63
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   51
      Left            =   5685
      TabIndex        =   62
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   50
      Left            =   4875
      TabIndex        =   61
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   49
      Left            =   4110
      TabIndex        =   60
      Top             =   2520
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   48
      Left            =   3330
      TabIndex        =   59
      Top             =   2520
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   47
      Left            =   2535
      TabIndex        =   58
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   46
      Left            =   1740
      TabIndex        =   57
      Top             =   2520
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   45
      Left            =   960
      TabIndex        =   56
      Top             =   2520
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   44
      Left            =   7230
      TabIndex        =   55
      Top             =   2160
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   43
      Left            =   6360
      TabIndex        =   54
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   42
      Left            =   5685
      TabIndex        =   53
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   41
      Left            =   4875
      TabIndex        =   52
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   40
      Left            =   4110
      TabIndex        =   51
      Top             =   2160
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   39
      Left            =   3330
      TabIndex        =   50
      Top             =   2160
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   38
      Left            =   2535
      TabIndex        =   49
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   37
      Left            =   1740
      TabIndex        =   48
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   36
      Left            =   960
      TabIndex        =   47
      Top             =   2160
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   35
      Left            =   7230
      TabIndex        =   46
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   34
      Left            =   6360
      TabIndex        =   45
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   33
      Left            =   5685
      TabIndex        =   44
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   32
      Left            =   4875
      TabIndex        =   43
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   31
      Left            =   4110
      TabIndex        =   42
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   30
      Left            =   3330
      TabIndex        =   41
      Top             =   1800
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   29
      Left            =   2535
      TabIndex        =   40
      Top             =   1800
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   28
      Left            =   1740
      TabIndex        =   39
      Top             =   1800
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   27
      Left            =   960
      TabIndex        =   38
      Top             =   1800
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   26
      Left            =   7230
      TabIndex        =   37
      Top             =   1440
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   25
      Left            =   6360
      TabIndex        =   36
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   24
      Left            =   5685
      TabIndex        =   35
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   23
      Left            =   4875
      TabIndex        =   34
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   22
      Left            =   4110
      TabIndex        =   33
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   21
      Left            =   3330
      TabIndex        =   32
      Top             =   1440
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   20
      Left            =   2535
      TabIndex        =   31
      Top             =   1440
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   19
      Left            =   1740
      TabIndex        =   30
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   18
      Left            =   960
      TabIndex        =   29
      Top             =   1440
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   17
      Left            =   7200
      TabIndex        =   28
      Top             =   1080
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   16
      Left            =   6360
      TabIndex        =   27
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   15
      Left            =   5640
      TabIndex        =   26
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   14
      Left            =   4800
      TabIndex        =   25
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   13
      Left            =   4080
      TabIndex        =   24
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   12
      Left            =   3360
      TabIndex        =   23
      Top             =   1080
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   11
      Left            =   2520
      TabIndex        =   22
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   10
      Left            =   1680
      TabIndex        =   21
      Top             =   1080
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   9
      Left            =   960
      TabIndex        =   20
      Top             =   1080
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   8
      Left            =   7170
      TabIndex        =   19
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   7
      Left            =   6360
      TabIndex        =   18
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   6
      Left            =   5625
      TabIndex        =   17
      Top             =   720
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   5
      Left            =   4815
      TabIndex        =   16
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   4
      Left            =   4080
      TabIndex        =   15
      Top             =   720
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "w"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   3
      Left            =   3360
      TabIndex        =   14
      Top             =   720
      Width           =   150
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   2
      Left            =   2520
      TabIndex        =   13
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   1
      Left            =   1680
      TabIndex        =   12
      Top             =   720
      Width           =   90
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "n"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Index           =   0
      Left            =   960
      TabIndex        =   11
      Top             =   720
      Width           =   90
   End
   Begin VB.Line Line14 
      Index           =   9
      X1              =   120
      X2              =   7560
      Y1              =   4200
      Y2              =   4200
   End
   Begin VB.Line Line14 
      Index           =   8
      X1              =   120
      X2              =   7560
      Y1              =   3840
      Y2              =   3840
   End
   Begin VB.Line Line14 
      Index           =   7
      X1              =   120
      X2              =   7560
      Y1              =   3480
      Y2              =   3480
   End
   Begin VB.Line Line14 
      Index           =   6
      X1              =   120
      X2              =   7560
      Y1              =   3120
      Y2              =   3120
   End
   Begin VB.Line Line14 
      Index           =   5
      X1              =   120
      X2              =   7560
      Y1              =   2760
      Y2              =   2760
   End
   Begin VB.Line Line14 
      Index           =   4
      X1              =   120
      X2              =   7560
      Y1              =   2400
      Y2              =   2400
   End
   Begin VB.Line Line14 
      Index           =   3
      X1              =   120
      X2              =   7560
      Y1              =   2040
      Y2              =   2040
   End
   Begin VB.Line Line14 
      Index           =   2
      X1              =   120
      X2              =   7560
      Y1              =   1680
      Y2              =   1680
   End
   Begin VB.Line Line14 
      Index           =   1
      X1              =   120
      X2              =   7560
      Y1              =   1320
      Y2              =   1320
   End
   Begin VB.Line Line14 
      Index           =   0
      X1              =   120
      X2              =   7560
      Y1              =   960
      Y2              =   960
   End
   Begin VB.Line Line13 
      X1              =   120
      X2              =   7560
      Y1              =   600
      Y2              =   600
   End
   Begin VB.Line Line12 
      X1              =   600
      X2              =   7560
      Y1              =   240
      Y2              =   240
   End
   Begin VB.Line Line11 
      X1              =   120
      X2              =   7560
      Y1              =   4560
      Y2              =   4560
   End
   Begin VB.Line Line10 
      X1              =   7560
      X2              =   7560
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "BAR"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   8
      Left            =   7080
      TabIndex        =   10
      Top             =   360
      Width           =   270
   End
   Begin VB.Line Line9 
      X1              =   600
      X2              =   600
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line8 
      X1              =   6840
      X2              =   6840
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line7 
      X1              =   6000
      X2              =   6000
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line6 
      X1              =   5280
      X2              =   5280
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line5 
      X1              =   4440
      X2              =   4440
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line4 
      X1              =   3720
      X2              =   3720
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line3 
      X1              =   2880
      X2              =   2880
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line2 
      X1              =   2160
      X2              =   2160
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Line Line1 
      X1              =   1320
      X2              =   1320
      Y1              =   240
      Y2              =   4560
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "SPACE"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   7
      Left            =   6240
      TabIndex        =   9
      Top             =   360
      Width           =   450
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "BAR"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   6
      Left            =   5520
      TabIndex        =   8
      Top             =   360
      Width           =   270
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "SPACE"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   5
      Left            =   4680
      TabIndex        =   7
      Top             =   360
      Width           =   450
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "BAR"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   4
      Left            =   3960
      TabIndex        =   6
      Top             =   360
      Width           =   270
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "SPACE"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   3
      Left            =   3120
      TabIndex        =   5
      Top             =   360
      Width           =   450
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "BAR"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   2
      Left            =   2400
      TabIndex        =   4
      Top             =   360
      Width           =   270
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "SPACE"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   1
      Left            =   1560
      TabIndex        =   3
      Top             =   360
      Width           =   450
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "BAR"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   6
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   120
      Index           =   0
      Left            =   840
      TabIndex        =   2
      Top             =   360
      Width           =   270
   End
   Begin VB.Label Label1 
      Caption         =   "X-Position of line to be drawn"
      BeginProperty Font 
         Name            =   "Terminal"
         Size            =   13.5
         Charset         =   255
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   9315
      Width           =   5535
   End
   Begin VB.Label Label9 
      Caption         =   "n = narrow , w = wide"
      Height          =   255
      Left            =   5880
      TabIndex        =   142
      Top             =   0
      Width           =   1695
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ABOUT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Index           =   3
      Left            =   7680
      TabIndex        =   141
      Top             =   8400
      Width           =   6975
   End
End
Attribute VB_Name = "Tutorial"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

Dim xx, yy As Integer


Private Sub Command1_Click()
Picture1.Line (xx, 10)-(xx, 90)
Text1 = xx
End Sub

Private Sub Command2_Click()
xx = xx + 2
Text1 = xx
End Sub

Private Sub Command3_Click()
xx = xx + 5
Text1 = xx
End Sub

Private Sub Command4_Click()
For xx = xx To xx + 5
    Picture1.Line (xx, 10)-(xx, 90)
Next
Text1 = xx
End Sub

Private Sub Command5_Click()
DrawBarcode Text2.Text, 50, 10, 50, Picture1, &H4080&
End Sub

Private Sub Command6_Click()
Test.Show
End Sub

Private Sub Command7_Click()
ShellExecute hWnd, "open", App.Path & "\Code 39 Specification Page.htm", vbNullString, vbNullString, conSwNormal
End Sub

Private Sub Form_Load()
xx = 50
yy = 0
End Sub

Public Function DrawBar(strWideOrNarrow As String)
    If strWideOrNarrow = "n" Then
        Picture1.Line (xx, 10)-(xx, 90)
    End If
    If strWideOrNarrow = "w" Then
        For xx = xx To xx + 5
            Picture1.Line (xx, 10)-(xx, 90)
        Next
    End If
    prType = Space
End Function

Public Function DrawSpace(strWideOrNarrow As String)
    If strWideOrNarrow = "n" Then
        xx = xx + 2
    End If
    If strWideOrNarrow = "w" Then
        xx = xx + 5
    End If
    prType = Bar
End Function

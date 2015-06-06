VERSION 5.00
Begin VB.Form frmMain 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   7200
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   9600
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   480
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   640
   StartUpPosition =   1  'CenterOwner
   Begin VB.PictureBox mnuHelp 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   975
      Left            =   6720
      ScaleHeight     =   975
      ScaleWidth      =   2280
      TabIndex        =   17
      Top             =   3173
      Visible         =   0   'False
      Width           =   2280
      Begin VB.Line Line4 
         BorderWidth     =   3
         X1              =   0
         X2              =   0
         Y1              =   0
         Y2              =   2040
      End
      Begin VB.Label cmdHelpAbout 
         BackStyle       =   0  'Transparent
         Caption         =   "About"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   19
         Top             =   480
         Width           =   1335
      End
      Begin VB.Label cmdHelpContents 
         BackStyle       =   0  'Transparent
         Caption         =   "Contents"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   18
         Top             =   0
         Width           =   2055
      End
   End
   Begin VB.PictureBox mnuInternet 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   2415
      Left            =   6720
      ScaleHeight     =   2415
      ScaleWidth      =   2895
      TabIndex        =   20
      Top             =   3893
      Visible         =   0   'False
      Width           =   2895
      Begin VB.Label cmdInternetAmazon 
         BackStyle       =   0  'Transparent
         Caption         =   "Amazon.com"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   24
         Top             =   0
         Width           =   2535
      End
      Begin VB.Label cmdInternetChapters 
         BackStyle       =   0  'Transparent
         Caption         =   "Chapters.ca"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   23
         Top             =   1440
         Width           =   2175
      End
      Begin VB.Label cmdInternetBarnesandNoble 
         BackStyle       =   0  'Transparent
         Caption         =   "Barnes and Noble"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Left            =   120
         TabIndex        =   22
         Top             =   480
         Width           =   2655
      End
      Begin VB.Label cmdInternetYahoo 
         BackStyle       =   0  'Transparent
         Caption         =   "Yahoo! Canada"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   21
         Top             =   1920
         Width           =   2175
      End
      Begin VB.Line Line5 
         BorderWidth     =   3
         X1              =   0
         X2              =   0
         Y1              =   0
         Y2              =   2640
      End
   End
   Begin VB.PictureBox mnuAdmin 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1935
      Left            =   6720
      ScaleHeight     =   1935
      ScaleWidth      =   1935
      TabIndex        =   6
      Top             =   1493
      Visible         =   0   'False
      Width           =   1935
      Begin VB.Line Line1 
         BorderWidth     =   3
         X1              =   0
         X2              =   0
         Y1              =   0
         Y2              =   2640
      End
      Begin VB.Label cmdAdminSettings 
         BackStyle       =   0  'Transparent
         Caption         =   "Settings"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   10
         Top             =   1440
         Width           =   1815
      End
      Begin VB.Label cmdAdminReports 
         BackStyle       =   0  'Transparent
         Caption         =   "Reports"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   9
         Top             =   960
         Width           =   1575
      End
      Begin VB.Label cmdAdminPatrons 
         BackStyle       =   0  'Transparent
         Caption         =   "Patrons"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   8
         Top             =   480
         Width           =   1215
      End
      Begin VB.Label cmdAdminBooks 
         BackStyle       =   0  'Transparent
         Caption         =   "Books"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   7
         Top             =   0
         Width           =   1095
      End
   End
   Begin VB.PictureBox mnuBrowse 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   975
      Left            =   6720
      ScaleHeight     =   975
      ScaleWidth      =   2295
      TabIndex        =   11
      Top             =   2093
      Visible         =   0   'False
      Width           =   2295
      Begin VB.Label cmdBrowseBooks 
         BackStyle       =   0  'Transparent
         Caption         =   "Books"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   13
         Top             =   0
         Width           =   1335
      End
      Begin VB.Label cmdBrowsePatrons 
         BackStyle       =   0  'Transparent
         Caption         =   "Patrons"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   12
         Top             =   480
         Width           =   2055
      End
      Begin VB.Line Line2 
         BorderWidth     =   3
         X1              =   0
         X2              =   0
         Y1              =   0
         Y2              =   2040
      End
   End
   Begin VB.PictureBox mnuCirc 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1455
      Left            =   6720
      ScaleHeight     =   1455
      ScaleWidth      =   2295
      TabIndex        =   14
      Top             =   2693
      Visible         =   0   'False
      Width           =   2295
      Begin VB.Label cmdCircRenew 
         BackStyle       =   0  'Transparent
         Caption         =   "Renew"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   25
         Top             =   960
         Width           =   1455
      End
      Begin VB.Line Line3 
         BorderWidth     =   3
         X1              =   0
         X2              =   0
         Y1              =   0
         Y2              =   2040
      End
      Begin VB.Label cmdCircSignout 
         BackStyle       =   0  'Transparent
         Caption         =   "Sign Out"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   15
         Top             =   0
         Width           =   2175
      End
      Begin VB.Label cmdCircReturn 
         BackStyle       =   0  'Transparent
         Caption         =   "Return"
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   21.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   16
         Top             =   480
         Width           =   1815
      End
   End
   Begin VB.Line linInternet 
      BorderWidth     =   3
      Visible         =   0   'False
      X1              =   320
      X2              =   448
      Y1              =   275.533
      Y2              =   275.533
   End
   Begin VB.Line linHelp 
      BorderWidth     =   3
      Visible         =   0   'False
      X1              =   312
      X2              =   449
      Y1              =   235.533
      Y2              =   235.533
   End
   Begin VB.Line linCirc 
      BorderWidth     =   3
      Visible         =   0   'False
      X1              =   376
      X2              =   448
      Y1              =   196
      Y2              =   196
   End
   Begin VB.Line linBrowse 
      BorderWidth     =   3
      Visible         =   0   'False
      X1              =   295
      X2              =   448
      Y1              =   155.533
      Y2              =   155.533
   End
   Begin VB.Line linAdmin 
      BorderWidth     =   3
      Visible         =   0   'False
      X1              =   344
      X2              =   448
      Y1              =   116
      Y2              =   116
   End
   Begin VB.Label cmdInternet 
      BackStyle       =   0  'Transparent
      Caption         =   "Internet"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   5
      Top             =   3893
      Width           =   1815
   End
   Begin VB.Label cmdAdmin 
      BackStyle       =   0  'Transparent
      Caption         =   "Administration"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2400
      TabIndex        =   1
      Top             =   1493
      Width           =   2775
   End
   Begin VB.Label cmdBrowse 
      BackStyle       =   0  'Transparent
      Caption         =   "Broswe"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3120
      TabIndex        =   4
      Top             =   2093
      Width           =   1815
   End
   Begin VB.Label cmdExit 
      BackStyle       =   0  'Transparent
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2880
      TabIndex        =   3
      Top             =   4493
      Width           =   1815
   End
   Begin VB.Label cmdHelp 
      BackStyle       =   0  'Transparent
      Caption         =   "Help"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3480
      TabIndex        =   2
      Top             =   3293
      Width           =   1815
   End
   Begin VB.Label cmdCirc 
      BackStyle       =   0  'Transparent
      Caption         =   "Circulation"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3360
      TabIndex        =   0
      Top             =   2700
      Width           =   2295
   End
   Begin VB.Shape Shape1 
      BorderWidth     =   3
      Height          =   3615
      Left            =   120
      Shape           =   3  'Circle
      Top             =   1613
      Visible         =   0   'False
      Width           =   3255
   End
   Begin VB.Image Image2 
      Height          =   3735
      Left            =   2280
      Top             =   1373
      Width           =   2535
   End
   Begin VB.Image Image1 
      Height          =   2835
      Left            =   360
      Picture         =   "frmMain.frx":0000
      Top             =   1973
      Width           =   2820
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdmin_Click()
linAdmin.Visible = True
mnuAdmin.Visible = True
linBrowse.Visible = False
mnuBrowse.Visible = False
linCirc.Visible = False
mnuCirc.Visible = False
linHelp.Visible = False
mnuHelp.Visible = False
linInternet.Visible = False
mnuInternet.Visible = False
End Sub

Private Sub cmdAdminBooks_Click()
frmBookAdmin.Show
End Sub

Private Sub cmdAdminPatrons_Click()
frmPatrons.Show
End Sub

Private Sub cmdAdminSettings_Click()
frmSettings.Show
End Sub

Private Sub cmdBrowse_Click()
linAdmin.Visible = False
mnuAdmin.Visible = False
linBrowse.Visible = True
mnuBrowse.Visible = True
linCirc.Visible = False
mnuCirc.Visible = False
linHelp.Visible = False
mnuHelp.Visible = False
linInternet.Visible = False
mnuInternet.Visible = False
End Sub

Private Sub cmdCirc_Click()
linAdmin.Visible = False
mnuAdmin.Visible = False
linBrowse.Visible = False
mnuBrowse.Visible = False
linCirc.Visible = True
mnuCirc.Visible = True
linHelp.Visible = False
mnuHelp.Visible = False
linInternet.Visible = False
mnuInternet.Visible = False
End Sub

Private Sub cmdCircRenew_Click()
frmRenew.Show
End Sub

Private Sub cmdCircReturn_Click()
frmReturn.Show
End Sub

Private Sub cmdCircSignout_Click()
frmSignout.Show
End Sub

Private Sub cmdExit_Click()
frmExit.Show
frmExit.ZOrder (0)
End Sub

Private Sub cmdHelp_Click()
linAdmin.Visible = False
mnuAdmin.Visible = False
linBrowse.Visible = False
mnuBrowse.Visible = False
linCirc.Visible = False
mnuCirc.Visible = False
linHelp.Visible = True
mnuHelp.Visible = True
linInternet.Visible = False
mnuInternet.Visible = False
End Sub

Private Sub cmdHelpAbout_Click()
frmAbout.Show 'Show the About Program Dialog Box
End Sub

Private Sub cmdInternet_Click()
linAdmin.Visible = False
mnuAdmin.Visible = False
linBrowse.Visible = False
mnuBrowse.Visible = False
linCirc.Visible = False
mnuCirc.Visible = False
linHelp.Visible = False
mnuHelp.Visible = False
linInternet.Visible = True
mnuInternet.Visible = True
End Sub

Private Sub cmdInternetAmazon_Click()
X = Shell("c:\program files\ie5\iexplore.exe http://www.amazon.com", vbNormalFocus)
End Sub

Private Sub cmdInternetBarnesandNoble_Click()
X = Shell("c:\program files\ie5\iexplore.exe http://www.barnesandnoble.com", vbNormalFocus)
End Sub

Private Sub cmdInternetChapters_Click()
X = Shell("c:\program files\ie5\iexplore.exe http://www.chapters.ca", vbNormalFocus)
End Sub

Private Sub cmdInternetYahoo_Click()
X = Shell("c:\program files\ie5\iexplore.exe http://ca.yahoo.com", vbNormalFocus)
End Sub

Private Sub Image2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
linAdmin.Visible = False
mnuAdmin.Visible = False
linBrowse.Visible = False
mnuBrowse.Visible = False
linCirc.Visible = False
mnuCirc.Visible = False
linHelp.Visible = False
mnuHelp.Visible = False
linInternet.Visible = False
mnuInternet.Visible = False
End Sub

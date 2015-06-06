VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.Form Form2 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Get barcodes & weights"
   ClientHeight    =   5265
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7395
   Icon            =   "Form2.frx":0000
   LinkTopic       =   "Form2"
   ScaleHeight     =   5265
   ScaleWidth      =   7395
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   3600
      Top             =   4920
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Trial Details"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3255
      Left            =   120
      TabIndex        =   11
      Top             =   1920
      Width           =   3615
      Begin VB.Frame FrameComplete 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Complete file !"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1935
         Left            =   120
         TabIndex        =   21
         Top             =   1080
         Visible         =   0   'False
         Width           =   3375
         Begin VB.CommandButton Command7 
            BackColor       =   &H00FFFFFF&
            Caption         =   "cancel"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   2520
            Style           =   1  'Graphical
            TabIndex        =   26
            Top             =   1560
            Width           =   735
         End
         Begin VB.CommandButton Command5 
            BackColor       =   &H00FFFFFF&
            Caption         =   "change entry"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   840
            Style           =   1  'Graphical
            TabIndex        =   23
            Top             =   480
            Width           =   1695
         End
         Begin VB.CommandButton Command6 
            BackColor       =   &H00FFFFFF&
            Caption         =   "covert to VTAB"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   840
            Style           =   1  'Graphical
            TabIndex        =   22
            Top             =   1080
            Width           =   1695
         End
         Begin VB.Label Label4 
            BackColor       =   &H00FFFFFF&
            Caption         =   "Would you like to change an entry?"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   615
            Left            =   120
            TabIndex        =   25
            Top             =   240
            Width           =   3135
         End
         Begin VB.Label Label5 
            BackColor       =   &H00FFFFFF&
            Caption         =   "Would you like toconvert to VTAB?"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   840
            Width           =   3135
         End
      End
      Begin VB.CommandButton cmdTrialCancel 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Cancel"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2040
         Style           =   1  'Graphical
         TabIndex        =   20
         Top             =   1200
         Width           =   855
      End
      Begin VB.CommandButton cmdTrialOK 
         BackColor       =   &H00FFFFFF&
         Caption         =   "OK"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   840
         Style           =   1  'Graphical
         TabIndex        =   19
         Top             =   1200
         Width           =   975
      End
      Begin VB.Label Label6 
         BackColor       =   &H00FFFFFF&
         Caption         =   "label...................................."
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   18
         Top             =   720
         Width           =   4335
      End
      Begin VB.Label lblCutNum 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   255
         Left            =   2520
         TabIndex        =   17
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblMan 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2040
         TabIndex        =   16
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblTrial 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1560
         TabIndex        =   15
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblReg 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1080
         TabIndex        =   14
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblYear 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   600
         TabIndex        =   13
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblCrop 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "'"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   375
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Enter record "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Visible         =   0   'False
      Width           =   3615
      Begin VB.TextBox Text1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   1
         Top             =   600
         Width           =   1335
      End
      Begin VB.TextBox Text2 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Top             =   1200
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "OK"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Left            =   1680
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   360
         Width           =   855
      End
      Begin VB.CommandButton Command2 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Quit"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2640
         Style           =   1  'Graphical
         TabIndex        =   4
         TabStop         =   0   'False
         Top             =   1320
         Width           =   615
      End
      Begin VB.Label Label1 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Barcode"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   360
         Width           =   1335
      End
      Begin VB.Label Label2 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Weight"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   5
         Top             =   960
         Width           =   1215
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Data log"
      Height          =   2415
      Left            =   120
      TabIndex        =   27
      Top             =   1920
      Visible         =   0   'False
      Width           =   3375
   End
   Begin VB.Frame Framelist 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Data Missing"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   5055
      Left            =   3960
      TabIndex        =   7
      Top             =   120
      Visible         =   0   'False
      Width           =   3375
      Begin VB.CommandButton Command4 
         BackColor       =   &H00FFFFFF&
         Caption         =   "NO"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2640
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   480
         Width           =   615
      End
      Begin VB.CommandButton Command3 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Yes"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2040
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   480
         Width           =   615
      End
      Begin VB.Label Label3 
         BackColor       =   &H00FFFFFF&
         Caption         =   "Would you like to list missing data?"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   240
         Width           =   3135
      End
   End
   Begin MSCommLib.MSComm MSComm1 
      Left            =   7680
      Top             =   5280
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub cmdTrialCancel_Click()
    'user cancels, back to form for trial details
    Form1.Show
    Unload Me
End Sub

Private Sub cmdTrialOK_Click()
    'start barcode & weight capture
    Frame1.Visible = True
    MsgBox "Please ensure that your Barcode scanner" & vbCrLf & "is connected to COMM1 Port", vbInformation
    Frame2.Enabled = False
End Sub

Private Sub Command1_Click()
    'start listening to comport
    If Text1.Text <> "" Then
    barcode = Text1.Text
    End If
    Text2.SetFocus
    InfoFromBarCode
    '*      *       *       *       *       *       *
    '*      *       *       *       *       *       *
    'set spacebar to get weight & save record to file.
    '*      *       *       *       *       *       *
    '*      *       *       *       *       *       *
    LogRecord
End Sub


Private Sub Form_Unload(Cancel As Integer)
    'cloe the comPort on exit
    MSComm1.PortOpen = False
    End Sub




Private Sub Timer1_Timer()  'for listening to the comport
    If MSComm1.PortOpen = False Then ' If comm port is not open
       MSComm1.PortOpen = True ' Open it
    End If
     
    If MSComm1.InBufferCount > 0 Then ' If theres data in comm buffer
        inst = inst + MSComm1.Input ' Get the data
        Text1 = inst ' Show its value
    End If
End Sub



Private Sub Command2_Click()
    'IF data missing show list data option
    Frame1.Visible = False
    Framelist.Visible = True
End Sub

Private Sub Command4_Click()
    'cancel, back to form for trial details
    Load Form1
    Form1.Show
    Unload Me
End Sub

Private Sub Form_Load()
    'display the trial details.
    'NOTE:Change so the sequential file is the source for this info.
    
    Label6 = Firstplot & " " & Reps & " " & NoVar & " " & NoSubBlocks & " " & Design & " " & PlotLen & " " & NoFactors & "                     " & Form1.txtDate.Text

    Dim noPlots As Integer      'calculate the Number of Plots
    noPlots = (Reps * NoVar)


    lblCrop = usrCrop
    lblCutNum = usrCutNum
    lblMan = usrMan
    lblTrial = usrTrial
    lblReg = usrReg
    lblYear = usrYear
 
    'check file status 0,1,2; new,started, finished
        'Open RandFile For Random As #1
        'if new file
            'Get #1, 1, datarecord
            'datarecord.plotNo
        'If datarecord.plotNo = 0 Then
           '
    'Else
        'If datarecord.plotNo = 1 Then
          '
    'Else
        'If datarecord.plotNo = 2 Then
           '
          'End If
     '  End If
    'End If

    For plot = 1 To (numPlots + 1)
    'Put #1, plot, datarecord
    Next plot

    'loop weights
    '**add weights to record here
    'scanbarcode
    'end loop
    'Get #1, (Plotnum - startpoint), datarecord
    'get weight from balance
    weight1 = Text2.Text
    plotnum = plotnum
    'Put #1, (Plotnum - startpoint), datarecord

End Sub

Function LogRecord()
    Open randfile For Random As #1
    'NOTE: to do...
    'save plot no & weight to the corresponding record
    'in the random file.
    '
    Close #1
End Function
    
Function InfoFromBarCode()
    'Get the plotnumber & component number from the barcode
    component = Left(Text1.Text, 1)
    plotnum = Right(Text1.Text, 6)
End Function

Function MissingData()
    'insert function for working out what data is missing here
    'ie: what records still consist of 0's
End Function


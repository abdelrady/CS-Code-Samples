VERSION 5.00
Object = "{899348F9-A53A-4D9E-9438-F97F0E81E2DB}#1.0#0"; "LVbuttons.ocx"
Begin VB.Form frmChosePath 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Select Location for BackUp"
   ClientHeight    =   2745
   ClientLeft      =   3690
   ClientTop       =   2805
   ClientWidth     =   4200
   ControlBox      =   0   'False
   Icon            =   "frmChosePath.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2745
   ScaleWidth      =   4200
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   2655
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   2535
      Begin VB.DriveListBox Drive1 
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
         Left            =   120
         TabIndex        =   2
         Top             =   2160
         Width           =   2295
      End
      Begin VB.DirListBox Dir1 
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1890
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   2295
      End
   End
   Begin LVbuttons.LaVolpeButton Command1 
      Height          =   300
      Left            =   2760
      TabIndex        =   3
      Top             =   120
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   529
      BTYPE           =   3
      TX              =   "OK"
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
      MICON           =   "frmChosePath.frx":08CA
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
   Begin LVbuttons.LaVolpeButton Command2 
      Height          =   300
      Left            =   2760
      TabIndex        =   4
      Top             =   480
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   529
      BTYPE           =   3
      TX              =   "Cancel"
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
      MICON           =   "frmChosePath.frx":08E6
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
Attribute VB_Name = "frmChosePath"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
    If Mid$(Dir1, Len(Dir1), 1) = "\" Then
        myPath2 = Dir1
    Else
        myPath2 = Dir1
    End If
    flagBack = 1
    Unload Me
End Sub

Private Sub Command2_Click()
    flgBack = 0
    Unload Me
End Sub

Private Sub Dir1_Click()
    Command1.Enabled = True
End Sub

Private Sub Drive1_Change()
    Dir1.Path = Drive1.Drive
End Sub

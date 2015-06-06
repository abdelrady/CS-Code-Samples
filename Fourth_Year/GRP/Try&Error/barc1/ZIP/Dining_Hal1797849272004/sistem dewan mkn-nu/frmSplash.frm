VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   2160
   ClientLeft      =   2895
   ClientTop       =   2895
   ClientWidth     =   8775
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2160
   ScaleWidth      =   8775
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFFF&
      Height          =   1995
      Left            =   150
      TabIndex        =   0
      Top             =   60
      Width           =   8505
      Begin VB.Timer Timer1 
         Interval        =   100
         Left            =   0
         Top             =   1080
      End
      Begin VB.Image imgLogo 
         Height          =   1425
         Left            =   360
         Picture         =   "frmSplash.frx":08CA
         Top             =   240
         Width           =   1290
      End
      Begin VB.Label lblVersion 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Version 1.0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   6840
         TabIndex        =   1
         Top             =   1440
         Width           =   1275
      End
      Begin VB.Label lblProductName 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Dining Hall Management System"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   20.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   480
         Left            =   1800
         TabIndex        =   3
         Top             =   840
         Width           =   6330
      End
      Begin VB.Label lblCompanyProduct 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "MARA UNIVERSITY OF TECHNOLOGY"
         BeginProperty Font 
            Name            =   "Century Gothic"
            Size            =   18
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   1920
         TabIndex        =   2
         Top             =   345
         Width           =   6195
      End
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Dim kira As Integer

Private Sub Form_KeyPress(KeyAscii As Integer)
    frmLogin.Show
    Unload Me
End Sub

Private Sub Form_Load()
    kira = 0
    'lblVersion.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision
    'lblProductName.Caption = App.Title
End Sub

Private Sub Frame1_Click()
    frmLogin.Show
    Unload Me
End Sub

Private Sub Timer1_Timer()
    kira = kira + 100
    If kira = 400 Then
        frmLogin.Show
        Unload Me
    End If
End Sub

VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "shdocvw.dll"
Begin VB.Form frmInfo 
   AutoRedraw      =   -1  'True
   Caption         =   "Label Codes"
   ClientHeight    =   6195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3975
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmInfo.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6195
   ScaleWidth      =   3975
   StartUpPosition =   2  'CenterScreen
   Begin SHDocVwCtl.WebBrowser wbInfo 
      Height          =   6075
      Left            =   60
      TabIndex        =   0
      Top             =   60
      Width           =   3855
      ExtentX         =   6800
      ExtentY         =   10716
      ViewMode        =   0
      Offline         =   0
      Silent          =   0
      RegisterAsBrowser=   0
      RegisterAsDropTarget=   0
      AutoArrange     =   0   'False
      NoClientEdge    =   0   'False
      AlignLeft       =   0   'False
      NoWebView       =   0   'False
      HideFileNames   =   0   'False
      SingleClick     =   0   'False
      SingleSelection =   0   'False
      NoFolders       =   0   'False
      Transparent     =   0   'False
      ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
      Location        =   ""
   End
End
Attribute VB_Name = "frmInfo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Option Compare Text

Private Sub Form_Load()

    wbInfo.Navigate App.Path & "\LabelInfo.htm"
    
End Sub

Private Sub Form_Resize()

    With wbInfo
        .Top = 60
        .Height = Me.ScaleHeight - (120)
        .Left = 60
        .Width = Me.ScaleWidth - (120)
    End With
    
End Sub

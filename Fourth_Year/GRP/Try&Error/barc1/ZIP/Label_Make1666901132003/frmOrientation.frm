VERSION 5.00
Begin VB.Form frmOrientation 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Set Label Orientation"
   ClientHeight    =   1635
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4515
   Icon            =   "frmOrientation.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1635
   ScaleWidth      =   4515
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDone 
      Caption         =   "Set"
      Height          =   435
      Index           =   1
      Left            =   2400
      TabIndex        =   3
      ToolTipText     =   "Transfer the Item."
      Top             =   1080
      Width           =   975
   End
   Begin VB.CommandButton cmdDone 
      Caption         =   "Cancel"
      Height          =   435
      Index           =   0
      Left            =   3480
      TabIndex        =   2
      ToolTipText     =   "Transfer the Item."
      Top             =   1080
      Width           =   975
   End
   Begin VB.OptionButton optOrient 
      Caption         =   "Landscape"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   1
      Left            =   2460
      TabIndex        =   1
      Top             =   360
      Width           =   1515
   End
   Begin VB.OptionButton optOrient 
      Caption         =   "Portrait"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   0
      Left            =   480
      TabIndex        =   0
      Top             =   360
      Width           =   1515
   End
End
Attribute VB_Name = "frmOrientation"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_bCancel As Boolean
Private m_bPortrait As Boolean

Public Property Get Cancelled() As Boolean
    Cancelled = m_bCancel
End Property

Private Sub cmdDone_Click(Index As Integer)

    Select Case Index
        Case 0  'Cancel
            m_bCancel = True
            
        Case 1  'Set
            m_bCancel = False
            
    End Select
    
    Me.Hide
    
End Sub


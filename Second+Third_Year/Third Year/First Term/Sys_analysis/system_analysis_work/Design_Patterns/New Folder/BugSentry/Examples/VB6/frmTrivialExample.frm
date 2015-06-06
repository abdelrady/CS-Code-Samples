VERSION 5.00
Begin VB.Form frmTrivialExample 
   Caption         =   "Trivial Example"
   ClientHeight    =   2715
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5895
   LinkTopic       =   "frmTrivialExample"
   ScaleHeight     =   2715
   ScaleWidth      =   5895
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtDIvidend 
      Height          =   375
      Left            =   360
      TabIndex        =   5
      Top             =   1320
      Width           =   855
   End
   Begin VB.TextBox txtDivisor 
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   1320
      Width           =   615
   End
   Begin VB.CommandButton btnDoit 
      Caption         =   "do it"
      Height          =   375
      Left            =   4320
      TabIndex        =   0
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label lblTrivialExample 
      Caption         =   $"frmTrivialExample.frx":0000
      Height          =   615
      Left            =   480
      TabIndex        =   6
      Top             =   240
      Width           =   5175
   End
   Begin VB.Label lblAnswer 
      Height          =   615
      Left            =   4320
      TabIndex        =   4
      Top             =   1320
      Width           =   855
   End
   Begin VB.Label lblEquals 
      Caption         =   "equals"
      Height          =   495
      Left            =   3240
      TabIndex        =   3
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label By 
      Caption         =   "divided by "
      Height          =   375
      Left            =   1320
      TabIndex        =   1
      Top             =   1320
      Width           =   1095
   End
End
Attribute VB_Name = "frmTrivialExample"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub btnDoit_Click()
On Error GoTo Err_btnDoitClick
'trivial example of error-prone code.
    Me.lblAnswer.Caption = Me.txtDIvidend.Text / Me.txtDivisor.Text

Exit Sub

Err_btnDoitClick:
    SentryWrapper.Sentry.Report "problem in form " & Me.Name, Err.Description
    MsgBox "Sorry. An error occurred.  Staff have been notified."

End Sub

Private Sub Form_Load()

Me.txtDIvidend.Text = 12
Me.txtDivisor = 3

End Sub


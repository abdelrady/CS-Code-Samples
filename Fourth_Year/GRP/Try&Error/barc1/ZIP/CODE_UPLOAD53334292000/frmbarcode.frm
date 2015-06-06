VERSION 5.00
Begin VB.Form frmbarcode 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   0  'None
   Caption         =   "Barcode"
   ClientHeight    =   1830
   ClientLeft      =   150
   ClientTop       =   720
   ClientWidth     =   8610
   LinkTopic       =   "Form1"
   ScaleHeight     =   1830
   ScaleWidth      =   8610
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Create Barcode"
      Height          =   375
      Left            =   2760
      TabIndex        =   2
      Top             =   120
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Text            =   "barcode"
      Top             =   120
      Width           =   2535
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   975
      Left            =   120
      ScaleHeight     =   975
      ScaleWidth      =   8055
      TabIndex        =   0
      Top             =   600
      Width           =   8055
   End
   Begin VB.Menu mnufile 
      Caption         =   "File"
      Begin VB.Menu mnuprint 
         Caption         =   "Print"
      End
   End
End
Attribute VB_Name = "frmbarcode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
    evalbar Me.Text1
End Sub

Private Sub Form_Load()
    setup
End Sub

Private Sub mnuprint_Click()
    Me.Text1.Visible = False
    Me.Command1.Visible = False
    Me.PrintForm
    Me.Text1.Visible = True
    Me.Command1.Visible = True
End Sub

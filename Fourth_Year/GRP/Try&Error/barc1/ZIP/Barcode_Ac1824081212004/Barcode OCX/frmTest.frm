VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmTest 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Barcode Control Test"
   ClientHeight    =   3225
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9345
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3225
   ScaleWidth      =   9345
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnCopy 
      Caption         =   "Copy"
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   2760
      Width           =   1335
   End
   Begin VB.CommandButton btnPrint 
      Caption         =   "Print"
      Height          =   375
      Left            =   3120
      TabIndex        =   4
      Top             =   2760
      Width           =   1335
   End
   Begin VB.ComboBox cmbCodeNames 
      Height          =   315
      ItemData        =   "frmTest.frx":0000
      Left            =   2400
      List            =   "frmTest.frx":0010
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   120
      Width           =   2895
   End
   Begin MSComDlg.CommonDialog cdlg 
      Left            =   6840
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.TextBox txtCode 
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   120
      Width           =   2055
   End
   Begin prjBarCode.BarCode bcCode 
      Height          =   1980
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   9015
      _ExtentX        =   15901
      _ExtentY        =   3493
      CodeName        =   "3"
      Value           =   "MUHAMMAD SHAHID"
   End
   Begin VB.CommandButton btnSave 
      Caption         =   "Save To File"
      Height          =   375
      Left            =   1680
      TabIndex        =   0
      Top             =   2760
      Width           =   1335
   End
End
Attribute VB_Name = "frmTest"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btnCopy_Click()
    bcCode.Copy
End Sub

Private Sub btnsave_Click()
    On Error GoTo ErrorHandler
    
    cdlg.CancelError = True
    cdlg.Filter = "Bitmaps|*.bmp"
    cdlg.FileName = ""
    cdlg.ShowOpen
    
    bcCode.save cdlg.FileName
    
ErrorHandler:
End Sub

Private Sub cmbCodeNames_Click()
    Call txtCode_Change
End Sub

Private Sub btnPrint_Click()
    cdlg.ShowPrinter
    
    bcCode.PrintPicture
End Sub

Private Sub Form_Load()
    cmbCodeNames.ListIndex = 0
End Sub

Private Sub txtCode_Change()
    bcCode.CodeName = cmbCodeNames.ItemData(cmbCodeNames.ListIndex)
    bcCode.Value = txtCode.Text
End Sub

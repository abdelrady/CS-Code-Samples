VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MsComCtl.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmConfig 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Setup"
   ClientHeight    =   4080
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6435
   Icon            =   "frmConfig.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   4080
   ScaleWidth      =   6435
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog cdlOpen 
      Left            =   6000
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
      Height          =   255
      Left            =   5280
      TabIndex        =   6
      Top             =   3360
      Width           =   495
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "Update"
      Height          =   255
      Left            =   5280
      TabIndex        =   5
      Top             =   3720
      Width           =   1095
   End
   Begin VB.CommandButton cmdDel 
      Caption         =   "Del"
      Height          =   255
      Left            =   5880
      TabIndex        =   4
      Top             =   3360
      Width           =   495
   End
   Begin VB.TextBox txtCode 
      Height          =   285
      Left            =   2760
      TabIndex        =   3
      Top             =   3720
      Width           =   2295
   End
   Begin VB.CommandButton cmdOpen 
      Caption         =   "..."
      Height          =   285
      Left            =   2170
      TabIndex        =   2
      Top             =   3720
      Width           =   375
   End
   Begin VB.TextBox txtFile 
      Enabled         =   0   'False
      Height          =   285
      Left            =   120
      TabIndex        =   1
      Top             =   3720
      Width           =   2055
   End
   Begin MSComctlLib.ListView lsvScan 
      Height          =   3135
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6255
      _ExtentX        =   11033
      _ExtentY        =   5530
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   3
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "File"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Bar Code"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Path"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Bar code:"
      Height          =   195
      Left            =   2760
      TabIndex        =   8
      Top             =   3480
      Width           =   690
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Program path:"
      Height          =   195
      Left            =   120
      TabIndex        =   7
      Top             =   3480
      Width           =   990
   End
End
Attribute VB_Name = "frmConfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


Private Sub cmdAdd_Click()
    'gibberish  open button

    If (txtCode.Text <> "") And (txtFile.Text <> "") Then
    
        'Add program to list
        lsvScan.ListItems.Add , , TrimFile(txtFile.Text)
        lsvScan.ListItems.Item(lsvScan.ListItems.Count).ListSubItems.Add , , txtCode.Text
        lsvScan.ListItems.Item(lsvScan.ListItems.Count).ListSubItems.Add , , txtFile.Text
        
        'Clear text
        txtCode.Text = ""
        txtFile.Text = ""
    Else
        'Display our error message
        MsgBox "Please enter filename and barcode.", vbInformation + vbOKOnly
    End If
    
End Sub

Private Sub cmdDel_Click()
    On Error Resume Next
    'Remove program from list
    lsvScan.ListItems.Remove (lsvScan.SelectedItem.Index)
End Sub

Private Sub cmdOpen_Click()
    On Error GoTo BrowseErr
    'open common dialog box
    With cdlOpen
        .CancelError = True
        .DialogTitle = "Select File"
        .Flags = cdlOFNFileMustExist
        .Filter = "All Files (*.*)|*.*|Executables (*.exe)|*.exe;*.bat"
        .ShowOpen
        
        'show file name in box
        txtFile.Text = .FileName
    End With
BrowseErr:
End Sub

Private Sub cmdUpdate_Click()
On Error Resume Next
    Dim intX As Integer
    
    'Update an existing entry
    If (txtCode.Text <> "") And (txtFile.Text <> "") Then
    
        'index of selected item
        intX = lsvScan.SelectedItem.Index
        
        'if none selected
        If (intX = 0) Then
            MsgBox "Anata baka? Select a file first!!!", vbOKOnly + vbInformation
        End If
        
        'Update item
        lsvScan.ListItems.Item(intX).ListSubItems.Item(1).Text = txtCode.Text
        lsvScan.ListItems.Item(intX).ListSubItems.Item(2).Text = txtFile.Text
        lsvScan.ListItems.Item(intX).Text = TrimFile(txtFile.Text)
    Else
        'error
        MsgBox "Please enter filename and barcode.", vbInformation + vbOKOnly
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'Cancel and hide to prevent data from being lost
    Cancel = 1
    Hide
End Sub

Private Sub lsvScan_ItemClick(ByVal Item As MSComctlLib.ListItem)
    'Make it more convienent
    txtFile.Text = Item.ListSubItems(2).Text
    txtCode.Text = Item.ListSubItems(1).Text
End Sub

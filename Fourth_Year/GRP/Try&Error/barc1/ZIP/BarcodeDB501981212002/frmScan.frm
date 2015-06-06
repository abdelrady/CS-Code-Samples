VERSION 5.00
Begin VB.Form frmSearch 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Search Options"
   ClientHeight    =   1245
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   4770
   Icon            =   "frmScan.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1245
   ScaleWidth      =   4770
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox chkWholeField 
      Caption         =   "&Whole field only"
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   885
      Width           =   2295
   End
   Begin VB.CheckBox chkMatchCase 
      Caption         =   "&Match case"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   570
      Width           =   2295
   End
   Begin VB.TextBox txtSearch 
      Height          =   285
      Left            =   840
      TabIndex        =   0
      Top             =   120
      Width           =   2295
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3360
      TabIndex        =   2
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3360
      TabIndex        =   1
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label lblSearch 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Search"
      Height          =   195
      Left            =   120
      TabIndex        =   3
      Top             =   165
      Width           =   510
   End
End
Attribute VB_Name = "frmSearch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim SearchType As Byte

Sub ByProduct()
    SearchType = 2
    frmSearch.Caption = "Enter product name to search for"
    
    chkMatchCase.Enabled = True
    chkWholeField.Enabled = True
    
    chkMatchCase.Value = GetSetting(AppName, "Options", "Match case", chkMatchCase.Value)
    chkWholeField.Value = GetSetting(AppName, "Options", "Whole field", chkWholeField.Value)
    
    frmSearch.Show
End Sub

Sub ByBarcode()
    SearchType = 1
    frmSearch.Caption = "Enter barcode to search for"
    
    chkMatchCase.Enabled = False
    chkWholeField.Enabled = True
    
    chkWholeField.Value = GetSetting(AppName, "Options", "Whole field", chkWholeField.Value)
    
    frmSearch.Show
End Sub

Private Sub CancelButton_Click()
    Unload frmSearch
End Sub

Private Sub OKButton_Click()
    Dim CaseSensitive As Boolean
    Dim FindWholeField As Boolean
    
    If Trim$(txtSearch.Text) = vbNullString Then
        MsgBox "Enter a search word before searching.", vbExclamation
        Exit Sub
    End If
    
    If GetSetting(AppName, "Options", "Search Tip", False) = False Then
        MsgBox "Once you have finished with the search results you can view all the original items in the database by clicking the 'View' menu and then 'Refresh / Show All'", vbInformation
        SaveSetting AppName, "Options", "Search Tip", True
    End If
    
    If SearchType = 1 Then
        FindWholeField = IIf(chkWholeField.Value = Checked, True, False)
        CaseSensitive = False
        
        If IsNumeric(txtSearch.Text) = False Then
            MsgBox "Numeric search terms must be entered for barcode search", vbExclamation
            Exit Sub
        End If
    End If
    
    If SearchType = 2 Then
        CaseSensitive = IIf(chkMatchCase.Value = Checked, True, False)
        FindWholeField = IIf(chkWholeField.Value = Checked, True, False)
        
        SaveSetting AppName, "Options", "Match case", chkMatchCase.Value
    End If
    
    SaveSetting AppName, "Options", "Whole field", chkWholeField.Value
    
    CancelSearch = False
          
    frmSearching.Show
    frmSearching.Refresh
    
    SetWindowPos frmSearching.hwnd, -1, frmSearching.Left / Screen.TwipsPerPixelX, frmSearching.Top / Screen.TwipsPerPixelY, frmSearching.Width / Screen.TwipsPerPixelX, frmSearching.Height / Screen.TwipsPerPixelY, 0
    Call frmMain.DoSearch(txtSearch.Text, CaseSensitive, FindWholeField, SearchType)
    
    Unload frmSearch
    Unload frmSearching
End Sub

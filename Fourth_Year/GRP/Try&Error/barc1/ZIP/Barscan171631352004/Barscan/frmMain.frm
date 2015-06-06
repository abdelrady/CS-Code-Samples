VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Barscan"
   ClientHeight    =   495
   ClientLeft      =   150
   ClientTop       =   750
   ClientWidth     =   4830
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   495
   ScaleWidth      =   4830
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtScan 
      Height          =   285
      Left            =   120
      TabIndex        =   1
      Text            =   "This is where we scan a barcode!!!!!!!"
      Top             =   120
      Width           =   3495
   End
   Begin VB.CommandButton cmdConfig 
      Caption         =   "Configure"
      Height          =   285
      Left            =   3720
      TabIndex        =   0
      Top             =   120
      Width           =   975
   End
   Begin VB.Menu mnuAbout 
      Caption         =   "About"
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'API Calls----------------------------------------------------------------------------
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

Private Sub cmdConfig_Click()
    'show the config box
    frmConfig.Show
End Sub

Private Sub Form_Load()
    'load the list
    LoadList TrimDir(App.Path) & "list.bar"
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'Before you close - SAVE!!!!
    SaveList TrimDir(App.Path) & "list.bar"
    End
End Sub

Private Sub mnuAbout_Click()
    'About
    MsgBox "Barscan version 1.0. Designed by Neptune Century Inc. Coded by Tim Dividio and Eric Butler.", vbInformation + vbOKOnly
End Sub

Private Sub txtScan_GotFocus()
    'Highlight all text
    txtScan.SelStart = 0
    txtScan.SelLength = Len(txtScan.Text)
End Sub

Private Sub txtScan_KeyPress(KeyAscii As Integer)
    Dim intX As Integer
    
    'If you hit enter or the QCat does
    If (KeyAscii = vbKeyReturn) Then
    
        'Make a beep
        Beep 1000, 200
        
        'loop through entries
        For intX = 1 To frmConfig.lsvScan.ListItems.Count
        
            'Match codes
            If (txtScan.Text = frmConfig.lsvScan.ListItems.Item(intX).ListSubItems(1).Text) Then
                
                'Run the program
                ShellExecute hWnd, "Open", frmConfig.lsvScan.ListItems.Item(intX).ListSubItems(2).Text, &O0, &O0, 1
                'Tell vb that nothing happened to prevent an annoying beep
                KeyAscii = 0
                'Leave this sub routine
                Exit Sub
            End If
        Next intX
        
        'Clear text
        txtScan.Text = ""
        
        'Tell vb that nothing happened to prevent an annoying beep
        KeyAscii = 0
    End If
End Sub

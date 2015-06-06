VERSION 5.00
Begin VB.Form frmFont 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Font"
   ClientHeight    =   1800
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5310
   Icon            =   "frmFont.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1800
   ScaleWidth      =   5310
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox cmbFonts 
      Height          =   315
      Left            =   120
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   1200
      Width           =   2775
   End
   Begin VB.TextBox txtFontSize 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Text            =   "8"
      Top             =   360
      Width           =   735
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3960
      TabIndex        =   3
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3960
      TabIndex        =   2
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label lblFontStyle 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Font Style"
      Height          =   195
      Left            =   120
      TabIndex        =   5
      Top             =   960
      Width           =   705
   End
   Begin VB.Label lblFontSize 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Enter a font size"
      Height          =   195
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1140
   End
End
Attribute VB_Name = "frmFont"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub CancelButton_Click()
    Unload frmFont
End Sub

Private Sub Form_Load()
    Dim i As Long
    For i = 0 To Screen.FontCount - 1
        cmbFonts.AddItem Screen.Fonts(i)
        If Screen.Fonts(i) = frmMain.lstDB.Font.Name Then cmbFonts.ListIndex = i
    Next
    
    cmbFonts.ListIndex = GetSetting(AppName, "Options", "Font Style", cmbFonts.ListIndex)
    txtFontSize.Text = GetSetting(AppName, "Options", "FontSize", frmMain.lstDB.Font.Size)
End Sub

Private Sub OKButton_Click()
    If IsNumeric(txtFontSize.Text) = False Then
        Unload frmFont
        Exit Sub
    End If
    
    SaveSetting AppName, "Options", "Font Style", cmbFonts.ListIndex
    SaveSetting AppName, "Options", "Font Size", txtFontSize.Text
    
    frmMain.lstDB.Font.Name = Screen.Fonts(cmbFonts.ListIndex)
    frmMain.lstDB.Font.Size = txtFontSize.Text
    frmMain.lstDB.Font.Bold = False
    frmMain.lstDB.Font.Italic = False
    
    Unload frmFont
End Sub

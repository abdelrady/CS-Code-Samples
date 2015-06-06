VERSION 5.00
Object = "{3C6B8D7F-A45A-11D4-8CA8-00062970428E}#24.2#0"; "cTextBox.ocx"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Customize Textbox Test Application"
   ClientHeight    =   1755
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5445
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1755
   ScaleWidth      =   5445
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox chkOptions 
      Caption         =   "Auto UpperCase"
      Height          =   315
      Index           =   1
      Left            =   1890
      TabIndex        =   3
      Top             =   1230
      Width           =   2565
   End
   Begin VB.CheckBox chkOptions 
      Caption         =   "AutoSelect"
      Height          =   315
      Index           =   0
      Left            =   1890
      TabIndex        =   2
      Top             =   810
      Width           =   2565
   End
   Begin VB.ComboBox cboTextType 
      Height          =   315
      Index           =   0
      Left            =   1890
      TabIndex        =   1
      Top             =   330
      Width           =   3435
   End
   Begin cTextBox.CustomizedTextBox ctxtTest 
      Height          =   315
      Index           =   0
      Left            =   90
      TabIndex        =   0
      Top             =   330
      Width           =   1665
      _ExtentX        =   2937
      _ExtentY        =   556
      AutoUpperCase   =   -1  'True
      FontSize        =   8.25
      ForeColor       =   -2147483640
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' DISCLAIMER (for public posting):
' This software is provided on an "as is, where is" basis, with no warranty whatsoever.
' As a condition of your using this software, you agree that Westinghouse Electric Company
' shall not be liable with respect to or as a result of such use.  Further, you agree to
' indemnify and hold Westinghouse harmless in the event a claim is made against
' Westinghouse with respect to or as a result of your use of the software.


Private Sub cboTextType_Change(Index As Integer)
    Me.ctxtTest(Index).TextType = Me.cboTextType(Index).ListIndex
End Sub

Private Sub cboTextType_Click(Index As Integer)
    Me.ctxtTest(Index).TextType = Me.cboTextType(Index).ListIndex
    Me.ctxtTest(Index).SetFocus
End Sub

Private Sub chkOptions_Click(Index As Integer)
    Select Case Index
    Case 0
        Me.ctxtTest(0).AutoSelect = (Me.chkOptions(0).Value = vbChecked)
    Case 1
        Me.ctxtTest(0).AutoUpperCase = (Me.chkOptions(1).Value = vbChecked)
    End Select
End Sub

Private Sub Form_Load()
    Dim intIndex As Integer
    
    With Me.cboTextType(0)
        .AddItem ("AlphaNumeric = 0")
        .AddItem ("AlphaNumeric_NoSymbols = 1")
        .AddItem ("Alpha_WithSymbols = 2")
        .AddItem ("Alpha_NoSymbols = 3")
        .AddItem ("Numeric_Integers_Pos = 4")
        .AddItem ("Numeric_Integers_Neg = 5")
        .AddItem ("Numeric_Integers_All = 6")
        .AddItem ("Numeric_Real_Pos = 7")
        .AddItem ("Numeric_Real_Neg = 8")
        .AddItem ("Numeric_Real_All = 9")
    End With
    
    If (Me.ctxtTest(0).AutoSelect) Then Me.chkOptions(0).Value = vbChecked
    If (Me.ctxtTest(0).AutoUpperCase) Then Me.chkOptions(1).Value = vbChecked
End Sub

Private Sub Form_Unload(Cancel As Integer)
    End
End Sub


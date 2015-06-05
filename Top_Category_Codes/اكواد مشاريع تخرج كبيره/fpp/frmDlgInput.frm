VERSION 5.00
Begin VB.Form frmDlgInput 
   Caption         =   "Input"
   ClientHeight    =   1665
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3600
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1665
   ScaleWidth      =   3600
   StartUpPosition =   1  'CenterOwner
   Begin VB.TextBox txtText 
      Height          =   360
      Left            =   900
      TabIndex        =   0
      Top             =   150
      Width           =   2610
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   2520
      TabIndex        =   2
      Top             =   1170
      Width           =   915
   End
   Begin VB.ComboBox cboxVarName 
      Height          =   315
      Left            =   1365
      TabIndex        =   1
      Top             =   705
      Width           =   2010
   End
   Begin VB.Label lblMessage 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "Message:"
      Height          =   195
      Left            =   30
      TabIndex        =   4
      Top             =   240
      Width           =   765
   End
   Begin VB.Label lblVarName 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "Variable Name:"
      Height          =   195
      Left            =   135
      TabIndex        =   3
      Top             =   765
      Width           =   1080
   End
End
Attribute VB_Name = "frmDlgInput"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com
' =========================================================
' Dialog to set INPUT
' =========================================================

Option Explicit

' for resize:
Dim rc_cmdOK_left As Single
Dim rc_cmdOK_top As Single


Private Sub Form_Activate()
    frmLists.fillCombo_var_val cboxVarName
End Sub

Private Sub processRecentVarNames()
    frmLists.addRecentVarVal cboxVarName.Text
End Sub


Private Sub Form_Load()
    Me.Icon = frmMain.Icon
    
    rc_cmdOK_left = Me.ScaleWidth - cmdOK.Left
    rc_cmdOK_top = Me.ScaleHeight - cmdOK.Top
End Sub





Private Sub cmdOK_Click()

    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
        .zAction = "INPUT"
        .zParam1 = txtText.Text
        .zParam2 = cboxVarName.Text
        
        .setCaptionToAction
    End With
    
    Me.Hide
    
    processRecentVarNames
    
    bIS_MODIFIED = True
End Sub


Private Sub Form_Resize()
On Error GoTo err_resize
    cmdOK.Left = Me.ScaleWidth - rc_cmdOK_left
    cmdOK.Top = Me.ScaleHeight - rc_cmdOK_top
    
    'lblMessage.Left = Me.ScaleWidth - lblMessage.Width - 90
    txtText.Width = Me.ScaleWidth - txtText.Left - 190

    'lblVarName.Left = Me.ScaleWidth - lblVarName.Width - 90
    cboxVarName.Width = Me.ScaleWidth - cboxVarName.Left - 190

    Exit Sub
err_resize:
    Debug.Print "Error on frmDlgInput_Resize-> " & Err.Description
End Sub

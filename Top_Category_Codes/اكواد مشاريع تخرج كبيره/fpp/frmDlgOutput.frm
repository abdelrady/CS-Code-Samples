VERSION 5.00
Begin VB.Form frmDlgOutput 
   Caption         =   "Output"
   ClientHeight    =   1680
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1680
   ScaleWidth      =   3675
   StartUpPosition =   1  'CenterOwner
   Begin VB.ComboBox cboxVarName 
      Height          =   315
      Left            =   1335
      TabIndex        =   1
      Top             =   660
      Width           =   2190
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   2550
      TabIndex        =   2
      Top             =   1200
      Width           =   915
   End
   Begin VB.TextBox txtText 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   960
      TabIndex        =   0
      Top             =   157
      Width           =   2610
   End
   Begin VB.Label lblVarName 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "Variable Name:"
      Height          =   195
      Left            =   135
      TabIndex        =   4
      Top             =   720
      Width           =   1080
   End
   Begin VB.Label lblMessage 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "Message:"
      Height          =   195
      Left            =   105
      TabIndex        =   3
      Top             =   240
      Width           =   690
   End
End
Attribute VB_Name = "frmDlgOutput"
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
' Dialog to set OUTPUT
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
        .zAction = "OUTPUT"
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
    Debug.Print "Error on frmDlgOutput_Resize-> " & Err.Description
End Sub

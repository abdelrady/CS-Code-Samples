VERSION 5.00
Begin VB.Form frmDlgFunction 
   Caption         =   "Function"
   ClientHeight    =   2490
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3885
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2490
   ScaleWidth      =   3885
   StartUpPosition =   1  'CenterOwner
   Begin VB.ComboBox cboxParam1 
      Height          =   315
      Left            =   1590
      TabIndex        =   2
      Top             =   840
      Width           =   1980
   End
   Begin VB.ComboBox cboxFunctionName 
      Height          =   315
      ItemData        =   "frmDlgFunction.frx":0000
      Left            =   1590
      List            =   "frmDlgFunction.frx":0002
      TabIndex        =   1
      Top             =   165
      Width           =   1980
   End
   Begin VB.ComboBox cboxResult 
      Height          =   315
      ItemData        =   "frmDlgFunction.frx":0004
      Left            =   1590
      List            =   "frmDlgFunction.frx":0006
      TabIndex        =   3
      Top             =   1440
      Width           =   1980
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   2790
      TabIndex        =   0
      Top             =   1965
      Width           =   915
   End
   Begin VB.Label lblFuncName 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Function name:"
      Height          =   195
      Left            =   135
      TabIndex        =   6
      Top             =   225
      Width           =   1110
   End
   Begin VB.Label lblPar 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Parameters:"
      Height          =   195
      Left            =   135
      TabIndex        =   5
      Top             =   900
      Width           =   840
   End
   Begin VB.Label lblResult 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Store result in:"
      Height          =   195
      Left            =   135
      TabIndex        =   4
      Top             =   1500
      Width           =   1020
   End
End
Attribute VB_Name = "frmDlgFunction"
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
' Dialog to set function
' =========================================================

Option Explicit

' for resize:
Dim rc_cmdOK_left As Single
Dim rc_cmdOK_top As Single


Private Sub Form_Activate()
    frmLists.fillCombo_func cboxFunctionName
    frmLists.fillCombo_var_val cboxParam1
    frmLists.fillCombo_var_val cboxResult
End Sub

Private Sub processRecentFunc()
    frmLists.addRecentFunc cboxFunctionName.Text
End Sub


Private Sub cmdOK_Click()
    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
        .zAction = "FUNCTION"
        .zParam1 = cboxFunctionName.Text
        .zParam2 = cboxParam1.Text
        .zParam3 = cboxResult.Text
        
        .setCaptionToAction
    End With
    
    Me.Hide
    
    processRecentFunc
    
    bIS_MODIFIED = True
End Sub


Private Sub Form_Load()
    Me.Icon = frmMain.Icon
    
    rc_cmdOK_left = Me.ScaleWidth - cmdOK.Left
    rc_cmdOK_top = Me.ScaleHeight - cmdOK.Top
End Sub

Private Sub Form_Resize()
On Error GoTo err_resize
    cmdOK.Left = Me.ScaleWidth - rc_cmdOK_left
    cmdOK.Top = Me.ScaleHeight - rc_cmdOK_top
    
    'lblFuncName.Left = Me.ScaleWidth - lblFuncName.Width - 90
    'lblPar.Left = Me.ScaleWidth - lblPar.Width - 90
    'lblResult.Left = Me.ScaleWidth - lblResult.Width - 90

    cboxFunctionName.Width = Me.ScaleWidth - cboxFunctionName.Left - 190
    cboxParam1.Width = Me.ScaleWidth - cboxParam1.Left - 190
    cboxResult.Width = Me.ScaleWidth - cboxResult.Left - 190

    Exit Sub
err_resize:
    Debug.Print "Error on frmDlgFunction_Resize-> " & Err.Description
End Sub

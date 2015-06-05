VERSION 5.00
Begin VB.Form frmDlgIf 
   Caption         =   "Equation"
   ClientHeight    =   1185
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4635
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1185
   ScaleWidth      =   4635
   StartUpPosition =   1  'CenterOwner
   Begin VB.ComboBox cboxOperation 
      Height          =   315
      ItemData        =   "frmDlgIf.frx":0000
      Left            =   1785
      List            =   "frmDlgIf.frx":0013
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   135
      Width           =   1005
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   3525
      TabIndex        =   3
      Top             =   645
      Width           =   915
   End
   Begin VB.ComboBox cboxOperand2 
      Height          =   315
      Left            =   3060
      TabIndex        =   2
      Top             =   135
      Width           =   1440
   End
   Begin VB.ComboBox cboxOperand1 
      Height          =   315
      Left            =   120
      TabIndex        =   0
      Top             =   135
      Width           =   1440
   End
End
Attribute VB_Name = "frmDlgIf"
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
' Dialog to set IF intersection
' =========================================================

Option Explicit

' for resize:
Dim rc_cmdOK_left As Single
Dim rc_cmdOK_top As Single

Private Sub Form_Activate()
    frmLists.fillCombo_var_val cboxOperand1
    frmLists.fillCombo_var_val cboxOperand2
End Sub

Private Sub Form_Load()
    cboxOperation.ListIndex = 0
    
    Me.Icon = frmMain.Icon
    
    rc_cmdOK_left = Me.ScaleWidth - cmdOK.Left
    rc_cmdOK_top = Me.ScaleHeight - cmdOK.Top
End Sub

Private Sub cmdOK_Click()

    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
        If cboxOperation.Text = "=" Then
            .zAction = "IF_EQUAL"
        ElseIf cboxOperation.Text = ">" Then
            .zAction = "IF_GREATER"
        ElseIf cboxOperation.Text = "<" Then
            .zAction = "IF_LESS"
        ElseIf cboxOperation.Text = "<=" Then
            .zAction = "IF_LESS_EQUAL"
        ElseIf cboxOperation.Text = ">=" Then
            .zAction = "IF_GREATER_EQUAL"
        End If
        
        .zParam1 = cboxOperand1.Text
        .zParam2 = cboxOperand2.Text
        
        .setCaptionToAction
    End With
    
    Me.Hide
    
    bIS_MODIFIED = True
End Sub


Private Sub Form_Resize()
On Error GoTo err_resize
    cmdOK.Left = Me.ScaleWidth - rc_cmdOK_left
    cmdOK.Top = Me.ScaleHeight - rc_cmdOK_top
    
    cboxOperand1.Width = (Me.ScaleWidth - cboxOperation.Width - cboxOperand1.Left - 90 * 3) / 2
    cboxOperand2.Width = cboxOperand1.Width
    cboxOperation.Left = cboxOperand1.Left + cboxOperand1.Width + 90
    cboxOperand2.Left = cboxOperation.Left + cboxOperation.Width + 90
    
    Exit Sub
err_resize:
    Debug.Print "Error on frmDlgIf_Resize-> " & Err.Description
End Sub

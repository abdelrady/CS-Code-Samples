VERSION 5.00
Begin VB.Form frmDlgGeneral 
   Caption         =   "General Options"
   ClientHeight    =   2175
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2175
   ScaleWidth      =   4680
   StartUpPosition =   1  'CenterOwner
   Begin VB.TextBox txtLocalVars 
      Height          =   315
      Left            =   1485
      TabIndex        =   0
      Top             =   150
      Width           =   2880
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   3600
      TabIndex        =   1
      Top             =   1680
      Width           =   915
   End
   Begin VB.Label lblExample 
      Caption         =   "Example:   a,b,c "
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   720
      Width           =   3255
   End
   Begin VB.Label lblDescription 
      Caption         =   "Local variables are stored in stack before running current flow, and restored when flow ends."
      Height          =   795
      Left            =   120
      TabIndex        =   3
      Top             =   1200
      Width           =   3225
   End
   Begin VB.Label lblLocalVars 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "Local Variables:"
      Height          =   195
      Left            =   120
      TabIndex        =   2
      Top             =   210
      Width           =   1125
   End
End
Attribute VB_Name = "frmDlgGeneral"
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
' Dialog to set general properties of a flow
' =========================================================

Option Explicit

' for resize:
Dim rc_cmdOK_left As Single
Dim rc_cmdOK_top As Single

Private Sub cmdOK_Click()
    With frmMain.theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)
        If .zAction = "START" Then
            .zParam1 = txtLocalVars.Text
                        
            .setCaptionToAction
        Else
            Debug.Print "Something wrong, cannot set this property to non-START"
        End If
    End With
    
    Me.Hide
    
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
    
    'lblLocalVars.Left = Me.ScaleWidth - lblLocalVars.Width - 90

    txtLocalVars.Width = Me.ScaleWidth - txtLocalVars.Left - 190

    Exit Sub
err_resize:
    Debug.Print "Error on frmDlgGeneral_Resize-> " & Err.Description
End Sub

VERSION 5.00
Begin VB.Form frm_mBox 
   Caption         =   "Message"
   ClientHeight    =   2370
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5055
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2370
   ScaleWidth      =   5055
   StartUpPosition =   1  'CenterOwner
   Begin VB.TextBox txtMessage 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   177
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1800
      Left            =   45
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   1
      TabStop         =   0   'False
      Top             =   15
      Width           =   4965
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   465
      Left            =   1995
      TabIndex        =   0
      Top             =   1890
      Width           =   915
   End
End
Attribute VB_Name = "frm_mBox"
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
' Message box form
' =========================================================

Option Explicit

Private Sub cmdOK_Click()

    txtMessage.Text = ""
    
    b_frm_mBoxVisible = False
    Me.Hide
    
    If bTERMINATE_ON_CLOSE And (b_frmScreenVisible = False) Then
        Terminate_APPLICATION
    End If
    
End Sub

Private Sub Form_Activate()
    b_frm_mBoxVisible = True
End Sub

Private Sub Form_Load()
    ' is set like visible, since when error happens
    '   on flow load, the application closes without letting
    '   the user to see the error message:
    b_frm_mBoxVisible = True
    
    Me.Icon = frmMain.Icon
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    b_frm_mBoxVisible = False
    
    If UnloadMode = vbFormControlMenu Then ' user closes frmScreen.
        If bTERMINATE_ON_CLOSE And (b_frmScreenVisible = False) Then
            Terminate_APPLICATION
        End If
    End If
End Sub

Private Sub Form_Resize()
On Error GoTo err_resize

    cmdOK.Left = Me.ScaleWidth / 2 - cmdOK.Width / 2
    cmdOK.Top = Me.ScaleHeight - cmdOK.Height - 90
    
    txtMessage.Width = Me.ScaleWidth - txtMessage.Left * 2
    txtMessage.Height = Me.ScaleHeight - cmdOK.Height - (Me.ScaleHeight - cmdOK.Top - cmdOK.Height) - 90
    
    Exit Sub
err_resize:
    Debug.Print "Error on frm_mBox_resize-> " & Err.Description
End Sub


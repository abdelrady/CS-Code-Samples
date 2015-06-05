VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmStack 
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "Stack"
   ClientHeight    =   5085
   ClientLeft      =   1470
   ClientTop       =   2865
   ClientWidth     =   3690
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5085
   ScaleWidth      =   3690
   ShowInTaskbar   =   0   'False
   Begin MSFlexGridLib.MSFlexGrid grid 
      Height          =   5010
      Left            =   15
      TabIndex        =   0
      Top             =   30
      Width           =   3645
      _ExtentX        =   6429
      _ExtentY        =   8837
      _Version        =   393216
      Rows            =   250
      Cols            =   3
      FixedRows       =   0
      FixedCols       =   2
      AllowUserResizing=   3
   End
End
Attribute VB_Name = "frmStack"
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
' The grid on this form keeps the STACK
'  (the stack is indirect simulation 8086
'   assembler's stack, though there is no
'   limitation on size of each stack cell -
'   since it's a string)
' first column of grid is an address,
' second is used for SP label,
' third is a value - string (so no limit).
' =========================================================

Option Explicit


' variables used to resize the table on window resize:
Dim resize_constrain_X As Single
Dim resize_constrain_Y As Single

' stack pointer:
Public SP As Integer

Private Sub Form_Load()
    resize_constrain_X = Me.ScaleWidth - grid.Width
    resize_constrain_Y = Me.ScaleHeight - grid.Height

    Dim i As Integer
    ' set address column (first column):
    For i = 0 To grid.Rows - 1
        grid.TextMatrix(i, 0) = i
    Next i
    
    ' prepare the grid:
    grid.ColWidth(0) = 400
    grid.ColWidth(1) = 500
    grid.ColWidth(2) = grid.Width - grid.ColWidth(0) - grid.ColWidth(1) - 500
    
    ' clear stack (fill with "?"):
    clearStack
End Sub

Private Sub Form_Resize()
    ' resize grid according to form size:
On Error GoTo res_err
    grid.Width = Me.ScaleWidth - resize_constrain_X
    grid.Height = Me.ScaleHeight - resize_constrain_Y
    Exit Sub
res_err:
    Debug.Print "Error on frmStack  Form_Resize()"
End Sub

' clears the stack:
Public Sub clearStack()
   


    Dim i As Integer
    
    ' set all cells to have "?" value:
    For i = 0 To grid.Rows - 1
        grid.TextMatrix(i, 2) = "?"
    Next i
        
    
    ' clear old "SP >" mark:
    If (SP >= 0) And (SP < grid.Rows) Then
        grid.TextMatrix(SP, 1) = ""
    ElseIf SP < 0 Then
        ' in case "stack overflow" happened before:
        grid.TextMatrix(0, 1) = ""
    End If
    
    ' set SP to top of the stack:
    SP = grid.Rows - 1
    
    ' set SP label:
    grid.TextMatrix(SP, 1) = "SP >"
        
End Sub

' pushes value into the string
' NOTE: variable should be converted to value
'       before push!
Public Sub PUSH(sValue As String)

    ' clear previous "SP >" label:
    If SP > 0 Then grid.TextMatrix(SP, 1) = ""
    
    ' update SP:
    ' (unlike 8086 it does -1 instead of -2, since
    ' we can store any value in string representaion)
    SP = SP - 1
           
    ' check overflow:
    If SP < 0 Then
        ' show message box only if flow is still running,
        '   to prevent many alike messages, when PUSH is called
        '     several times:
        If Not (currentRunPointer Is Nothing) Then
            mBox "STACK OVERFLOW!"
        End If
        frmMain.TerminateExecution
        Exit Sub
    End If

    ' set new "SP >" label:
    grid.TextMatrix(SP, 1) = "SP >"

    ' store value into stack:
    grid.TextMatrix(SP, 2) = sValue
    
End Sub

Public Function POP() As String
   
    ' check if stack is empty (has no data):
    If SP = (grid.Rows - 1) Then
        mBox "STACK IS EMPTY!"
        frmMain.TerminateExecution
        Exit Function
    End If
   
   ' pop value pointed by SP:
   POP = grid.TextMatrix(SP, 2)
    
   ' clear previous "SP >" label:
   grid.TextMatrix(SP, 1) = ""
   SP = SP + 1 ' update SP (not by +2 like in 8086, but +1).
   ' set new "SP >" label:
   grid.TextMatrix(SP, 1) = "SP >"
   
End Function

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
 If UnloadMode = vbFormControlMenu Then
    ' hide instead of close (to avoid losing data):
    Cancel = 1
    Me.Hide
 End If
End Sub

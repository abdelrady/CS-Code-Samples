VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmVars 
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "Variables"
   ClientHeight    =   840
   ClientLeft      =   1470
   ClientTop       =   1470
   ClientWidth     =   6945
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   840
   ScaleWidth      =   6945
   ShowInTaskbar   =   0   'False
   Begin MSFlexGridLib.MSFlexGrid grid 
      Height          =   855
      Left            =   15
      TabIndex        =   0
      Top             =   -15
      Width           =   6915
      _ExtentX        =   12197
      _ExtentY        =   1508
      _Version        =   393216
      AllowUserResizing=   3
   End
End
Attribute VB_Name = "frmVars"
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
' The grid on this form keeps record of all
' variables that are used in current program
' =========================================================

Option Explicit

' variables used to resize the table on window resize:
Dim resize_constrain_X As Single
Dim resize_constrain_Y As Single

' clears all variables by removing them from the grid,
' defines the default "RETURN" variable for functions'
' return values:
Public Sub clearVars()
    grid.Clear
    grid.Rows = 2
    grid.Cols = 2
    grid.TextMatrix(0, 1) = "RETURN" ' variable to keep returns from functions.
End Sub

' sets the sValue to variable that has sName,
' if such variable doesn't exist it is defined:
Public Sub setVar(sName As String, sValue As String)
    Dim l As Integer
    l = getVarCol(sName)
    
    If l <> -1 Then
       grid.TextMatrix(1, l) = sValue
    Else
       defineVar sName, sValue
    End If
End Sub

' returns the value of variable if variable is not
' defined, error raised:
Public Function getVar(sName As String) As String
        
    Dim l As Integer
    l = getVarCol(sName)
    
    If l <> -1 Then
       getVar = grid.TextMatrix(1, l)
    Else
       getVar = 0
       mBox "Variable: " & sName & " - not defined!"
    End If
End Function

' defines the varialble:
Private Sub defineVar(sName As String, sValue As String)
    grid.Cols = grid.Cols + 1
    grid.TextMatrix(0, grid.Cols - 1) = sName
    grid.TextMatrix(1, grid.Cols - 1) = sValue
End Sub

' returns the column of a variable in grid,
' if variable isn't defined returns -1.
'   (used internally)
Private Function getVarCol(sName As String) As Integer
    Dim i As Integer
    
    For i = 0 To grid.Cols - 1
        If StrComp(grid.TextMatrix(0, i), sName, vbTextCompare) = 0 Then
            getVarCol = i
            Exit Function
        End If
    Next i
    
   getVarCol = -1
    
End Function

' if parameter passed to function is a defined varialble
' function returns its value, otherwise it returns
' the passed parameter with no change:
Public Function ifVarGetValue(s As String) As String
    If getVarCol(s) <> -1 Then
        ifVarGetValue = getVar(s)
    Else
        ifVarGetValue = s
    End If
End Function


Private Sub Form_Load()
    resize_constrain_X = Me.ScaleWidth - grid.Width
    resize_constrain_Y = Me.ScaleHeight - grid.Height
End Sub

Private Sub Form_Resize()
    ' resize grid according to form size:
On Error GoTo res_err
    grid.Width = Me.ScaleWidth - resize_constrain_X
    grid.Height = Me.ScaleHeight - resize_constrain_Y
    Exit Sub
res_err:
    Debug.Print "Error on frmVars  Form_Resize()"
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
 If UnloadMode = vbFormControlMenu Then
    ' hide instead of close (to avoid losing data):
    Cancel = 1
    Me.Hide
 End If
End Sub

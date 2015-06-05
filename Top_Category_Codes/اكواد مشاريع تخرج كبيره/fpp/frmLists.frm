VERSION 5.00
Begin VB.Form frmLists 
   Caption         =   "frmLists"
   ClientHeight    =   2445
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4215
   LinkTopic       =   "Form1"
   ScaleHeight     =   2445
   ScaleWidth      =   4215
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox ListBox_vars_vals 
      Height          =   2205
      ItemData        =   "frmLists.frx":0000
      Left            =   2175
      List            =   "frmLists.frx":0002
      TabIndex        =   1
      Top             =   105
      Width           =   1935
   End
   Begin VB.ListBox ListBox_functions 
      Height          =   2205
      ItemData        =   "frmLists.frx":0004
      Left            =   45
      List            =   "frmLists.frx":0014
      TabIndex        =   0
      Top             =   90
      Width           =   1935
   End
End
Attribute VB_Name = "frmLists"
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
' This form keeps lists of all recent functions
'   variables (strings, values) that were used in
'   dialog boxes.
' =========================================================

Option Explicit

' procedure fills the ComboBox passed as a parameter
'   with all recent variable names and values:
Public Sub fillCombo_var_val(cbox As ComboBox)
    Dim i As Integer
    
    ' before clear, save original text
    '    (to avoid data loss on edit):
    Dim sTemp As String
    sTemp = cbox.Text
    
    cbox.Clear
    
    For i = 0 To ListBox_vars_vals.ListCount - 1
        cbox.AddItem ListBox_vars_vals.List(i)
    Next i
    
    ' restore original text:
    cbox.Text = sTemp
End Sub

' procedure fills the ComboBox passed as a parameter
'   with all recent functions:
Public Sub fillCombo_func(cbox As ComboBox)
    Dim i As Integer
    
    ' before clear, save original text
    '    (to avoid data loss on edit):
    Dim sTemp As String
    sTemp = cbox.Text
    
    cbox.Clear
    
    For i = 0 To ListBox_functions.ListCount - 1
        cbox.AddItem ListBox_functions.List(i)
    Next i
    
    ' restore original text:
    cbox.Text = sTemp
End Sub


' adds value to recent list, only if it
'   doesn't exist already and if it's not ""
' case sensitive (though case doesn't matter in flow)!
Public Sub addRecentVarVal(s As String)
    Dim i As Integer
    
    ' empty, no need to add:
    If s = "" Then Exit Sub
    
    ' exists already ?
    For i = 0 To ListBox_vars_vals.ListCount - 1
        If ListBox_vars_vals.List(i) = s Then
            ' already exists, so exit
            Exit Sub
        End If
    Next i
    
    ListBox_vars_vals.AddItem s
End Sub



' adds value to recent list, only if it
'   doesn't exist already and if it's not ""
' case sensitive (though case doesn't matter in flow)!
Public Sub addRecentFunc(s As String)
    Dim i As Integer

    ' empty, no need to add:
    If s = "" Then Exit Sub

    ' exists already ?
    For i = 0 To ListBox_functions.ListCount - 1
        If ListBox_functions.List(i) = s Then
            ' already exists, so exit
            Exit Sub
        End If
    Next i

    ListBox_functions.AddItem s
End Sub

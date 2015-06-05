Attribute VB_Name = "trigofunc"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/




' info@emu8086.com
' =========================================================
' Module of trigonometric functions
' =========================================================

Option Explicit

Public Const PI = 3.14159265359

Public Function Arcsin(X As Double) As Double
    If X = -1 Then
        Arcsin = -PI / 2
    ElseIf X = 1 Then
        Arcsin = PI / 2
    Else
        Arcsin = Atn(X / Sqr(-X * X + 1))
    End If
End Function

Public Function Arccos(X As Double) As Double
    If X = -1 Then
        Arccos = PI
    ElseIf X = 1 Then
        Arccos = 0
    Else
        Arccos = Atn(-X / Sqr(-X * X + 1)) + 2 * Atn(1)
    End If
End Function

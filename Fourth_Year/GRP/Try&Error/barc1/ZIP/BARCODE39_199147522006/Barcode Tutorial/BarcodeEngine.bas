Attribute VB_Name = "BarcodeEngine"
' Author: Evilgenious
' Name: Barcode Engine Modulo
' Date: 2006 May 02

' DETAILS

' (*************************************************************************)
' This application I have made just for educational purpose only
' --------------------------------------------------------------------------

Public Enum PrintType
    Bar
    Space
End Enum

Public prType As PrintType

Dim obj As Object
Dim xPos, yPos, barHeight As Integer

Dim BarVal(0 To 41) As String




'Darw Bar (n=narrow,w=wide)
Private Function DrawBar(strWideOrNarrow As String)
    If strWideOrNarrow = "n" Then
        obj.Line (xPos, yPos)-(xPos, yPos + barHeight)
    End If
    If strWideOrNarrow = "w" Then
        For xPos = xPos To xPos + 5
            obj.Line (xPos, yPos)-(xPos, yPos + barHeight)
        Next
    End If
    prType = Space
End Function

'Draw Space (n=narrow,w=wide)
Private Function DrawSpace(strWideOrNarrow As String)
    If strWideOrNarrow = "n" Then
        xPos = xPos + 2
    End If
    If strWideOrNarrow = "w" Then
        xPos = xPos + 5
    End If
    prType = Bar
End Function

'Draw barcode
Public Function DrawBarcode(strText As String, xxPos As Integer, yyPos As Integer, hheight As Integer, oobj As Object, ccolor As OLE_COLOR)

prType = Bar
xPos = xxPos
yPos = yyPos
barHeight = hheight
Set obj = oobj
'obj.Cls                                            ' uncomment this line if you want the object to clear its older data first
obj.ForeColor = ccolor

For i = 1 To Len(strText)
    Dim c As String
    c = Mid(strText, i, 1)
    If prType = Bar Then
        DrawBar c
    ElseIf prType = Space Then
        DrawSpace c
    End If
Next

End Function

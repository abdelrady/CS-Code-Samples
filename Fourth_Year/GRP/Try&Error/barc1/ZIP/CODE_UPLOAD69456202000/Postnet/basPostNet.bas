Attribute VB_Name = "basPostNet"
Option Explicit

'Author: Timothy R. Rude
'Email:  timrude@hotmail.com

Private Enum Sizes
    Short = 0
    Tall = 1
End Enum

Public Sub PostNet(ByVal Zip As String, obj As Object)

    'Generates Postnet (3 of 5) barcode to object
    'specified (i.e. Printer, PictureBox, etc.)
    
    'Non-digit characters in Zip string are ignored
    
    'Standard USA zip codes are 5, 9, or 11 digits
    
    Dim Total As Integer
    Dim Checksum As Integer
    Dim Counter As Integer
    Dim SomethingToDo As Boolean
    
    Zip = Trim$(Zip)
    SomethingToDo = False
    Total = 0
    For Counter = 1 To Len(Zip)
        Total = Total + Val(Mid$(Zip, Counter, 1))
        If Mid$(Zip, Counter, 1) >= "0" _
            And Mid$(Zip, Counter, 1) <= "9" _
            Then SomethingToDo = True
    Next Counter
    If Not SomethingToDo Then Exit Sub
    
    Checksum = (10 - (Total Mod 10)) Mod 10
    Zip = Zip & CStr(Checksum)
    
    BarCodeLine obj, Tall   'Opening frame line
    For Counter = 1 To Len(Zip)
        Select Case Mid$(Zip, Counter, 1)
            Case "0"
                BarCodeLine obj, Tall
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Short
            Case "1"
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Tall
            Case "2"
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
            Case "3"
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
            Case "4"
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
            Case "5"
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
            Case "6"
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
            Case "7"
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
            Case "8"
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
            Case "9"
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Tall
                BarCodeLine obj, Short
                BarCodeLine obj, Short
            Case Else
                'invalid character - ignore it
        End Select
    Next Counter
    BarCodeLine obj, Tall   'Closing frame line
    
End Sub

Private Sub BarCodeLine(obj As Object, Size As Sizes)

    'Draws line and moves cursor over
    
    'Size: 0 = short line
    '      1 = tall line
    
    Dim X As Single, Y As Single
    Dim SM As Integer
    Dim LineWidth As Integer
    Dim TPP As Single
    
    SM = obj.ScaleMode  'Save original scalemode
    'This routine expects scalemode to be twips
    obj.ScaleMode = vbTwips
    
    'Calculate width of line based on resolution
    'of output device so barcode will be uniform
    If TypeOf obj Is Printer Then
        TPP = obj.TwipsPerPixelX
    Else
        TPP = Screen.TwipsPerPixelX
    End If
    If TPP >= 6 Then
        LineWidth = CInt(Int(23.01 / TPP) * TPP)
    Else
        LineWidth = CInt(Int(24.01 / TPP) * TPP)
    End If
    If LineWidth < 15 Then LineWidth = 15
    If LineWidth > 24 Then LineWidth = 24
        
    X = obj.CurrentX
    Y = obj.CurrentY
    If Size = Tall Then
        obj.Line (X, Y)-(X + LineWidth, Y + 190), vbBlack, BF
    Else
        obj.Line (X, Y + 120)-(X + LineWidth, Y + 190), vbBlack, BF
    End If
    obj.CurrentX = X + 67
    obj.CurrentY = Y
    
    obj.ScaleMode = SM  'Restore original scalemode

End Sub

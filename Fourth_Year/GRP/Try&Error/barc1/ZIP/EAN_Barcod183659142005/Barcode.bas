Attribute VB_Name = "Barcode"
'*****************************************************************
' 13 Digit Barcode
' Title: European Article Numbering System
' Author: Kazooie
' Date|Time: Wednesday, June 18, 2003 7:23 PM
'*****************************************************************
Sub Barcoder(ByVal bc_String As String, obj As PictureBox)

Dim xpos!, Y1!, Y2!, dw%, Th!, tw, pat_string$
Dim Pattern As String
If bc_String = "" Then obj.Cls: Exit Sub

'define barcode patterns
'Pattern A
Dim A(10) As String
'Pattern B
Dim B(10) As String
'Pattern C
Dim C(10) As String
'Border
Dim D As String
'Center
Dim E As String
Dim F As String

A(0) = "0001101"
A(1) = "0011001"
A(2) = "0010011"
A(3) = "0111101"
A(4) = "0100011"
A(5) = "0110001"
A(6) = "0101111"
A(7) = "0111011"
A(8) = "0110111"
A(9) = "0001011"

B(0) = "0100111"
B(1) = "0110011"
B(2) = "0011011"
B(3) = "0100001"
B(4) = "0011101"
B(5) = "0111001"
B(6) = "0000101"
B(7) = "0010001"
B(8) = "0001001"
B(9) = "0010111"

C(0) = "1110010"
C(1) = "1100110"
C(2) = "1101100"
C(3) = "1000010"
C(4) = "1011100"
C(5) = "1001110"
C(6) = "1010000"
C(7) = "1000100"
C(8) = "1001000"
C(9) = "1110100"

D = "101"
E = "01010"
F = "101"

Select Case Mid(bc_String, 1, 1)
        Case 0
        Pattern = "AAAAAA"
        Case 1
        Pattern = "AABABB"
        Case 2
        Pattern = "AABBAB"
        Case 3
        Pattern = "AABBBA"
        Case 4
        Pattern = "ABAABB"
        Case 5
        Pattern = "ABBAAB"
        Case 6
        Pattern = "ABBBAA"
        Case 7
        Pattern = "ABABAB"
        Case 8
        Pattern = "ABABBA"
        Case 9
        Pattern = "ABBABA"
End Select
    
'dimensions
obj.ScaleMode = 3
obj.Cls
obj.Picture = Nothing

Th = obj.TextHeight(bc_String)
tw = obj.TextWidth(bc_String)

Y1 = 3 'Top
Y2 = obj.ScaleHeight - 1.5 * Th  ' Bottom

'Starting position
xpos = 21
    
'Border #1
    bc_Pattern$ = D
    For i = 1 To Len(bc_Pattern$)
        Select Case Mid$(bc_Pattern$, i, 1)
            Case "0"
                'space
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &HFFFFFF, BF
                xpos = xpos + 1
            Case "1"
                'Line
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &H0&, BF
                xpos = xpos + 1
        End Select
    Next
    
'1st Block
For n = 2 To 7
    q = Mid$(bc_String, n, 1)
    D = Mid$(Pattern, n - 1, 1)
    
    If D = "A" Then
        bc_Pattern$ = A(q)
    Else
        bc_Pattern$ = B(q)
    End If
    
    'draw each bar
    For i = 1 To Len(bc_Pattern$)
        Select Case Mid$(bc_Pattern$, i, 1)
            Case "0"
                'space
                obj.Line (xpos, Y1)-(xpos, Y2), &HFFFFFF, BF
                xpos = xpos + 1
            Case "1"
                'Line
                obj.Line (xpos, Y1)-(xpos, Y2), &H0&, BF
                xpos = xpos + 1
        End Select
    Next
    
Next
  
'Centre divider
    bc_Pattern$ = E
    For i = 1 To Len(bc_Pattern$)
        Select Case Mid$(bc_Pattern$, i, 1)
            Case "0"
                'space
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &HFFFFFF, BF
                xpos = xpos + 1
            Case "1"
                'Line
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &H0&, BF
                xpos = xpos + 1
        End Select
    Next
    
'2nd Block
For n = 8 To Len(bc_String)
    q = Mid$(bc_String, n, 1)
    'If q = 0 Then
    bc_Pattern$ = C(q)
    
    'draw each bar
    For i = 1 To Len(bc_Pattern$)
        Select Case Mid$(bc_Pattern$, i, 1)
            Case "0"
                'space
                obj.Line (xpos, Y1)-(xpos, Y2), &HFFFFFF, BF
                xpos = xpos + 1
            Case "1"
                'Line
                obj.Line (xpos, Y1)-(xpos, Y2), &H0&, BF
                xpos = xpos + 1
        End Select
    Next
Next

'Border #2
    bc_Pattern$ = F
    For i = 1 To Len(bc_Pattern$)
        Select Case Mid$(bc_Pattern$, i, 1)
            Case "0"
                'space
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &HFFFFFF, BF
                xpos = xpos + 1
            Case "1"
                'Line
                obj.Line (xpos, Y1)-(xpos, Y2 + 7), &H0&, BF
                xpos = xpos + 1
        End Select
    Next

obj.Width = 1950 'Fix width
obj.Height = 1434 'Fix Height
obj.Left = 170 'Fix left to Center
obj.Top = 140 'Fix top to Center

'Display 1st no.
obj.CurrentX = 9
obj.CurrentY = 79
obj.Print Mid$(bc_String, 1, 1)

'Display 2nd to 7th nos.
obj.CurrentX = 27
obj.CurrentY = 79
obj.Print Mid$(bc_String, 2, 6)

'Display 8th to last nos.
obj.CurrentX = 73
obj.CurrentY = 79
obj.Print Mid$(bc_String, 8, 6)
End Sub

'***************************************************************
' Barcode patterns and value

'White: 0
'Black: 1

'     CODE A          CODE B (XOR C)    CODE C (NOT A)
'0:  0001101   (13)   0100111   (39)    1110010   (114)
'1:  0011001   (25)   0110011   (51)    1100110   (102)
'2:  0010011   (19    0011011   (27)    1101100   (108)
'3:  0111101   (61)   0100001   (33)    1000010   (066)
'4:  0100011   (35)   0011101   (29)    1011100   (092)
'5:  0110001   (49)   0111001   (57)    1001110   (078)
'6:  0101111   (47)   0000101   (05)    1010000   (080)
'7:  0111011   (59)   0010001   (17)    1000100   (068)
'8:  0110111   (55)   0001001   (09)    1001000   (072)
'9:  0001011   (11)   0010111   (23)    1110100   (116)

'Borders:       101
'Centre:        01010

'              #1   #2   #3   #4   #5  #6
'   0          A    A    A    A    A    A
'   1          A    A    B    A    B    B
'   2          A    A    B    B    A    B
'   3          A    A    B    B    B    A
'   4          A    B    A    A    B    B
'   5          A    B    B    A    A    B
'   6          A    B    B    B    A    A
'   7          A    B    A    B    A    B
'   8          A    B    A    B    B    A
'   9          A    B    B    A    B    A

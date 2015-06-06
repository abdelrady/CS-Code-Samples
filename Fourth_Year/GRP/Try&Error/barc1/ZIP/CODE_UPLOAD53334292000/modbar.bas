Attribute VB_Name = "modbar"
Public chararray(43)

Function evalbar(bchar As String)
    Dim linetop As Integer      'top of the line
    Dim linebottom As Integer   'bottom of the line
    Dim leftside As Integer     'left side of barcode
    Dim narbarwidth As Integer  'length of the narrow bars
    Dim binarray As Integer     'retrievs the binary code for the current letter
    Dim loop1, loop2, loop3 As Integer
    Dim newbchar As String      'hold the modified string
    
    linetop = 50
    linebottom = 550
    leftside = 50
    narbarwidth = 20
    frmbarcode.Picture1.Cls 'clears the picture box
    newbchar = "*" + StrConv(bchar, vbUpperCase) + "*"  'add start and stop char changes string to uppercase
    For loop1 = 1 To Len(newbchar)  'loops through each char of the string
        binarray = evalchar(Mid(newbchar, loop1, 1))
        For loop2 = 1 To Len(chararray(binarray))   'loops through the binary array
            For loop3 = 1 To (CInt(Mid(chararray(binarray), loop2, 1)) + 1) * narbarwidth 'checks the width 0 for narrow and 1 for wide
                If loop2 Mod 2 Then  'odd char of the string are black, even are white
                    frmbarcode.Picture1.Line (leftside, linetop)-(leftside, linebottom), vbBlack
                    'Printer.Line (leftside, linetop)-(leftside, linebottom), vbBlack
                Else
                    frmbarcode.Picture1.Line (leftside, linetop)-(leftside, linebottom), vbWhite
                    'Printer.Line (leftside, linetop)-(leftside, linebottom), vbWhite
                End If
                leftside = leftside + 1
            Next loop3
        Next loop2
        For loop2 = 1 To narbarwidth 'adds a white space between char
            frmbarcode.Picture1.Line (leftside, linetop)-(leftside, linebottom), vbWhite
            'Printer.Line (leftside, linetop)-(leftside, linebottom), vbWhite
            leftside = leftside + 1
        Next loop2
    Next loop1
    'Printer.EndDoc
End Function
Function evalchar(echar As String) As Integer
    Select Case echar
        Case "0"
            evalchar = 0
            Exit Function
        Case "1"
            evalchar = 1
            Exit Function
        Case "2"
            evalchar = 2
            Exit Function
        Case "3"
            evalchar = 3
            Exit Function
        Case "4"
            evalchar = 4
            Exit Function
        Case "5"
            evalchar = 5
            Exit Function
        Case "6"
            evalchar = 6
            Exit Function
        Case "7"
            evalchar = 7
            Exit Function
        Case "8"
            evalchar = 8
            Exit Function
        Case "9"
            evalchar = 9
            Exit Function
        Case "A"
            evalchar = 10
            Exit Function
        Case "B"
            evalchar = 11
            Exit Function
        Case "C"
            evalchar = 12
            Exit Function
        Case "D"
            evalchar = 13
            Exit Function
        Case "E"
            evalchar = 14
            Exit Function
        Case "F"
            evalchar = 15
            Exit Function
        Case "G"
            evalchar = 16
            Exit Function
        Case "H"
            evalchar = 17
            Exit Function
        Case "I"
            evalchar = 18
            Exit Function
        Case "J"
            evalchar = 19
            Exit Function
        Case "K"
            evalchar = 20
            Exit Function
        Case "L"
            evalchar = 21
            Exit Function
        Case "M"
            evalchar = 22
            Exit Function
        Case "N"
            evalchar = 23
            Exit Function
        Case "O"
            evalchar = 24
            Exit Function
        Case "P"
            evalchar = 25
            Exit Function
        Case "Q"
            evalchar = 26
            Exit Function
        Case "R"
            evalchar = 27
            Exit Function
        Case "S"
            evalchar = 28
            Exit Function
        Case "T"
            evalchar = 29
            Exit Function
        Case "U"
            evalchar = 30
            Exit Function
        Case "V"
            evalchar = 31
            Exit Function
        Case "W"
            evalchar = 32
            Exit Function
        Case "X"
            evalchar = 33
            Exit Function
        Case "Y"
            evalchar = 34
            Exit Function
        Case "Z"
            evalchar = 35
            Exit Function
        Case "-"
            evalchar = 36
            Exit Function
        Case "."
            evalchar = 37
            Exit Function
        Case " "
            evalchar = 38
            Exit Function
        Case "$"
            evalchar = 39
            Exit Function
        Case "/"
            evalchar = 40
            Exit Function
        Case "+"
            evalchar = 41
            Exit Function
        Case "%"
            evalchar = 42
            Exit Function
        Case "*"
            evalchar = 43
            Exit Function
    End Select
            
End Function
Sub setup()

    chararray(0) = "000110100"
    chararray(1) = "100100001"
    chararray(2) = "001100001"
    chararray(3) = "101100000"
    chararray(4) = "000110001"
    chararray(5) = "100110000"
    chararray(6) = "001110000"
    chararray(7) = "000100101"
    chararray(8) = "100100100"
    chararray(9) = "001100100"
    chararray(10) = "100001001"
    chararray(11) = "001001001"
    chararray(12) = "101001000"
    chararray(13) = "000011001"
    chararray(14) = "100011000"
    chararray(15) = "001011000"
    chararray(16) = "000001101"
    chararray(17) = "100001100"
    chararray(18) = "001001100"
    chararray(19) = "000011100"
    chararray(20) = "100000011"
    chararray(21) = "001000011"
    chararray(22) = "101000010"
    chararray(23) = "000010011"
    chararray(24) = "100010010"
    chararray(25) = "001010010"
    chararray(26) = "000000111"
    chararray(27) = "100000110"
    chararray(28) = "001000110"
    chararray(29) = "000010110"
    chararray(30) = "110000001"
    chararray(31) = "011000001"
    chararray(32) = "111000000"
    chararray(33) = "010010001"
    chararray(34) = "110010000"
    chararray(35) = "011010000"
    chararray(36) = "010000101"
    chararray(37) = "110000100"
    chararray(38) = "011000100"
    chararray(39) = "010101000"
    chararray(40) = "010100010"
    chararray(41) = "010001010"
    chararray(42) = "000101010"
    chararray(43) = "010010100"
    

End Sub


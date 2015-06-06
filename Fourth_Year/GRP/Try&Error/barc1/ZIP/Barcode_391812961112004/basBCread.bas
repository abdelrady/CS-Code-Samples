Attribute VB_Name = "basBCREAD"
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'' BARCODE 3 OF 9 DECODER                                                   ''
'' By Paul Bahlawan Oct 2004                                                ''
''                                                                          ''
'' Usage:                                                                   ''
'' value$ = bcRead(pb, x, y, retries, verbos)                               ''
''   pb = name of the picturebox with the barcode                           ''
''   x,y = coordanates in pixels of start of barcode                        ''
''   retries = times to retry read (1 - 12)(optional)(default 5)            ''
''   verbos = what to return in case of a no-read (error): (optional)       ''
''            0= Nothing (default)                                          ''
''            1= "Error"                                                    ''
''            2= Full error message (form the LAST retry)                   ''
''                                                                          ''
''                                                                          ''
'' -Image must be bitonal, that is: black and white only                    ''
'' -Picturebox scalemode must be pixels                                     ''
'' -                                                                        ''
''                                                                          ''
'' Based on specs from:                                                     ''
'' www.adams1.com/pub/russadam/39code.html                                  ''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit



'---------------------------------------'
'Program Interface for reading a barcode'
'---------------------------------------'
Public Function bcRead(pb As PictureBox, ByVal rX As Long, ByVal rY As Long, Optional ByVal retries As Long = 5, Optional ByVal verbos As Long = 0) As String
If retries < 1 Then retries = 1
If retries > 12 Then retries = 12

'Sometimes it takes a few tries to get a read
Do
    bcRead = bcScan(pb, rX, rY)
    If Left$(bcRead, 4) <> "ERR:" Then Exit Do
    retries = retries - 1
    rY = rY + 1 'drop down a line and try the read again
Loop While retries

'Verbos level for an Error
If Left$(bcRead, 4) = "ERR:" Then
    Select Case verbos
        Case 0
            bcRead = ""
        Case 1
            bcRead = "Error"
        'case else, just return the error string as is
    End Select
End If
End Function



'Scan a line and attempt to read barcode
Private Function bcScan(pb As PictureBox, ByVal xBC As Long, ByVal yBC As Long) As String
Dim xBCstart As Long
Dim sample As Long
Dim refsample As Long
Dim tmpStr As String
Dim i As Long
Dim j As Long
Dim nSpace As Long
Dim wSpace As Long
Dim nBar As Long
Dim wBar As Long
Dim BC(43) As String
    BC(0) = "0001101000" '0
    BC(1) = "1001000010" '1
    BC(2) = "0011000010" '2
    BC(3) = "1011000000" '3
    BC(4) = "0001100010" '4
    BC(5) = "1001100000" '5
    BC(6) = "0011100000" '6
    BC(7) = "0001001010" '7
    BC(8) = "1001001000" '8
    BC(9) = "0011001000" '9
    BC(10) = "1000010010" 'A
    BC(11) = "0010010010" 'B
    BC(12) = "1010010000" 'C
    BC(13) = "0000110010" 'D
    BC(14) = "1000110000" 'E
    BC(15) = "0010110000" 'F
    BC(16) = "0000011010" 'G
    BC(17) = "1000011000" 'H
    BC(18) = "0010011000" 'I
    BC(19) = "0000111000" 'J
    BC(20) = "1000000110" 'K
    BC(21) = "0010000110" 'L
    BC(22) = "1010000100" 'M
    BC(23) = "0000100110" 'N
    BC(24) = "1000100100" 'O
    BC(25) = "0010100100" 'P
    BC(26) = "0000001110" 'Q
    BC(27) = "1000001100" 'R
    BC(28) = "0010001100" 'S
    BC(29) = "0000101100" 'T
    BC(30) = "1100000010" 'U
    BC(31) = "0110000010" 'V
    BC(32) = "1110000000" 'W
    BC(33) = "0100100010" 'X
    BC(34) = "1100100000" 'Y
    BC(35) = "0110100000" 'Z
    BC(36) = "0100001010" '-
    BC(37) = "1100001000" '.
    BC(38) = "0110001000" '<spc>
    BC(39) = "0101010000" '$
    BC(40) = "0101000100" '/
    BC(41) = "0100010100" '+
    BC(42) = "0001010100" '%
    BC(43) = "0100101000" '*  (used for start/stop character only)


'Find the first black pixel (ie. start of barcode)'''''''''''''''''''''''''''''''''''''
xBCstart = xBC
Do
    xBCstart = xBCstart + 1
    sample = pb.Point(xBCstart, yBC)
    If xBCstart > xBC + 75 Or sample = -1 Then
        bcScan = "ERR: BC not seen"
        Exit Function
    End If
Loop While sample


'Scan to find narrowest and widest bars and spaces''''''''''''''''''''''''''''''''''''
nSpace = 100
wSpace = 0
nBar = 100
wBar = 0
xBC = xBCstart

Do
    refsample = pb.Point(xBC, yBC)
    i = 0
    Do While pb.Point(xBC + i, yBC) = refsample
        i = i + 1
        If i > 22 Then Exit Do
    Loop
    
    If i > 22 Or pb.Point(xBC + i, yBC) = -1 Then Exit Do
    
    If refsample Then
        If i < nSpace Then nSpace = i
        If i > wSpace Then wSpace = i
    Else
        If i < nBar Then nBar = i
        If i > wBar Then wBar = i
    End If
       
    xBC = xBC + i
Loop

If nSpace >= wSpace Or nBar >= wBar Then
    bcScan = "ERR: BC not readable"
    Exit Function
End If


'Rescan and build temp string; 0 = narrow, 1 = wide'''''''''''''''''''''''''''''''''''
xBC = xBCstart
Do
    refsample = pb.Point(xBC, yBC)
    i = 0
    Do While pb.Point(xBC + i, yBC) = refsample
        i = i + 1
        If i > wSpace * 2 Then Exit Do
    Loop
    
    If i > wSpace * 2 Then Exit Do
    
    'This works by determining if the bar (or space) is bigger or smaller
    'than the midpoint between the biggest and smallest bar (or space)
    'as determined above
    If refsample Then
        If i * 2 < nSpace + wSpace Then
                tmpStr = tmpStr & "0"
        Else
                tmpStr = tmpStr & "1"
        End If
    Else
        If i * 2 < nBar + wBar Then
                tmpStr = tmpStr & "0"
        Else
                tmpStr = tmpStr & "1"
        End If
    End If
        
    xBC = xBC + i
Loop

tmpStr = tmpStr + "0"

If Len(tmpStr) Mod 10 Then
    bcScan = "ERR: BC parity"
    Exit Function
End If


'Decode 0's and 1's string into characters''''''''''''''''''''''''''''''''''''''''''''
For j = 0 To Len(tmpStr) / 10 - 1
    For i = 0 To 43
        If Mid$(tmpStr, 1 + j * 10, 10) = BC(i) Then
            bcScan = bcScan & Mid$("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*", i + 1, 1)
            Exit For
        End If
        If i = 43 Then
            bcScan = "ERR: BC unrecognized"
            Exit Function
        End If
    Next
Next

'valid 3 of 9 starts & ends with a *
If Left$(bcScan, 1) <> "*" Or Right$(bcScan, 1) <> "*" Or Len(bcScan) < 2 Then
    bcScan = "ERR: BC invalid"
    Exit Function
End If

'finally, trim off the *'s
bcScan = Mid$(bcScan, 2, Len(bcScan) - 2)

'if check character is used, verify before returning.
'(to be done)
End Function

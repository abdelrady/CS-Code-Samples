VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsBarcode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Private mary3of9CharSet(0 To 43) As String * 9

Public Sub SaveBarCode(rsFileName As String, rsText As String, rlMag As Long, rlHeight As Long)
Dim lsTmp   As String

Dim roPicture As StdPicture
        
    lsTmp = TofN(rsText, False)
    
    frmBarCode.picBarCode.Width = (Len(lsTmp) * rlMag) * Screen.TwipsPerPixelX + 300
    frmBarCode.picBarCode.Height = rlHeight * Screen.TwipsPerPixelY
    frmBarCode.picBarCode.Cls
    frmBarCode.picBarCode.ScaleMode = vbPixels
    
    DrawBarCode frmBarCode.picBarCode, lsTmp, 1, 1, rlMag, rlHeight
    DoEvents
    
    SavePicture frmBarCode.picBarCode.Image, rsFileName

End Sub

Private Sub DrawBarCode(roObject As PictureBox, rsTmp As String, rlStartX As Long, rlStartY As Long, rlSize As Long, rlHeight As Long)
Dim lXPos   As Long
Dim lyPos   As Long
Dim llLoop  As Long

    lXPos = rlStartX
    lyPos = rlStartY
    
    For llLoop = 1 To Len(rsTmp)
        If Mid$(rsTmp, llLoop, 1) = "1" Then
            roObject.Line (lXPos, lyPos)-(lXPos + rlSize - 1, lyPos + rlHeight), , BF
            lXPos = lXPos + rlSize
        Else
            lXPos = lXPos + rlSize
        End If
    Next
    
End Sub

Private Function TofN(ByVal strDataToEncode As String, Optional ByVal blnAddCheckDigit As Boolean) As String
Dim strChar                     As String * 1
Dim lngCheckDigitSum            As Long
Dim lngCharIndex                As Long
Dim strEncode                   As String
Dim strEncodeFormat             As String
Dim i                           As Long
Dim j                           As Long
Dim lsDataToEncode              As String
Dim sTmp                        As String
Dim lsChar                      As String
Dim llLoop                      As Long
Dim lbIsSpace                   As Boolean
    
    'initial validation for encode data length
    lsDataToEncode = "*" & strDataToEncode & "*"
    
    If Len(lsDataToEncode) > 32 Then
        Err.Raise vbObjectError + 600, _
        "3 of 9", "3 of 9 barcodes are limited to 32 characters."
        Exit Function
    End If
    
    'populate the 3 of 9 character set
    'numbers 0 to 9
       
    'validate data to encode
    strDataToEncode = UCase(strDataToEncode)
    
    'represent spaces with underscores
    strDataToEncode = Replace(strDataToEncode, Chr(32), "_")
    
    For i = 2 To Len(lsDataToEncode) - 1
        strChar = Mid$(lsDataToEncode, i, 1)
        Select Case strChar
            Case 0 To 9, "A" To "Z", " ", _
                  "-", ".", "$", "/", "+", "%"
            Case Else
                Err.Raise vbObjectError + 600, _
                   "3 of 9", "Invalid Character Specified"
                Exit Function
        End Select
    Next
    
    'encode data using character set
    'get the check digit calculation while we're at it
    
    For i = 1 To Len(lsDataToEncode)
        strChar = Mid$(lsDataToEncode, i, 1)
        
        'off-set alpha chars to ary index by 55, i.e.
         'A = 65 - 55 = 10
        Select Case strChar
            Case "0" To "9"
                lngCharIndex = CLng(strChar)
                
            Case "-"
                lngCharIndex = 36
                
            Case "."
                lngCharIndex = 37
                
            Case " "
                lngCharIndex = 38
                
            Case "$"
                lngCharIndex = 39
                
            Case "/"
                lngCharIndex = 40
                
            Case "+"
                lngCharIndex = 41
                
            Case "%"
                lngCharIndex = 42
                
            Case "A" To "Z"
                lngCharIndex = CLng(Asc(strChar) - 55)
                
            Case "*"
                lngCharIndex = 43
                
            Case Else
                Err.Raise -1, "Tofn", "Invalid code 39 character"
                
        End Select
            
        'check digit sum
        If strChar <> "*" Then
            lngCheckDigitSum = lngCheckDigitSum + lngCharIndex
        End If
        
        sTmp = FormatBars(mary3of9CharSet(lngCharIndex))
        
        ' gap character spaceing
        If i < Len(lsDataToEncode) Then
            sTmp = sTmp & "0"
        End If
        
        'get the encode string for the character
        strEncode = strEncode & sTmp
    Next
    
    'should we incorporate the check digit?
    If blnAddCheckDigit Then
        strEncode = _
         strEncode & FormatBars(mary3of9CharSet(lngCheckDigitSum Mod 43))
    End If
    
    'add start/stop characters
    TofN = strEncode
    
End Function

Private Function FormatBars(rsCodes As String) As String
Dim sTmp    As String
Dim llLoop  As Long
Dim lsChar  As String
Dim lbIsSpace   As Boolean

    sTmp = ""
    
    ' format the character property
    For llLoop = 1 To 9
        
        lbIsSpace = llLoop Mod 2 = 0
        lsChar = Mid$(rsCodes, llLoop, 1)
        If lsChar = "1" Then
            If lbIsSpace Then
              sTmp = sTmp & "000"
            Else
              sTmp = sTmp & "111"
            End If
        Else
            If lbIsSpace Then
              sTmp = sTmp & "0"
            Else
              sTmp = sTmp & "1"
            End If
            
        End If
        
    Next
    FormatBars = sTmp
    
End Function


Private Sub Class_Initialize()
    mary3of9CharSet(0) = "000110100"    '0
    mary3of9CharSet(1) = "100100001"    '1
    mary3of9CharSet(2) = "001100001"    '2
    mary3of9CharSet(3) = "101100000"    '3
    mary3of9CharSet(4) = "000110001"    '4
    mary3of9CharSet(5) = "100110000"    '5
    mary3of9CharSet(6) = "001110000"    '6
    mary3of9CharSet(7) = "000100101"    '7
    mary3of9CharSet(8) = "100100100"    '8
    mary3of9CharSet(9) = "001100100"    '9
    
    'letters A to Z
    
    mary3of9CharSet(10) = "100001001"    'A
    mary3of9CharSet(11) = "001001001"    'B
    mary3of9CharSet(12) = "101001000"    'C
    mary3of9CharSet(13) = "000011001"    'D
    mary3of9CharSet(14) = "100011000"    'E
    mary3of9CharSet(15) = "001011000"    'F
    mary3of9CharSet(16) = "000001101"    'G
    mary3of9CharSet(17) = "100001100"    'H
    mary3of9CharSet(18) = "001001100"    'I
    mary3of9CharSet(19) = "000011100"    'J
    mary3of9CharSet(20) = "100000011"    'K
    mary3of9CharSet(21) = "001000011"    'L
    mary3of9CharSet(22) = "101000010"    'M
    mary3of9CharSet(23) = "000010011"    'N
    mary3of9CharSet(24) = "100010010"    'O
    mary3of9CharSet(25) = "001010010"    'P
    mary3of9CharSet(26) = "000000111"    'Q
    mary3of9CharSet(27) = "100000110"    'R
    mary3of9CharSet(28) = "001000110"    'S
    mary3of9CharSet(29) = "000010110"    'T
    mary3of9CharSet(30) = "110000001"    'U
    mary3of9CharSet(31) = "011000001"    'V
    mary3of9CharSet(32) = "111000000"    'W
    mary3of9CharSet(33) = "010010001"    'X
    mary3of9CharSet(34) = "110010000"    'Y
    mary3of9CharSet(35) = "011010000"    'Z
    
    'allowed symbols
    mary3of9CharSet(36) = "010000101"    '-
    mary3of9CharSet(37) = "110000100"    '.
    mary3of9CharSet(38) = "011000100"    'space
    mary3of9CharSet(39) = "010101000"    '$
    mary3of9CharSet(40) = "010100010"    '/
    mary3of9CharSet(41) = "010001010"    '+
    mary3of9CharSet(42) = "000101010"    '%
    mary3of9CharSet(43) = "010010100"    '*

End Sub

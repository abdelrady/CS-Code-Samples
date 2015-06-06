VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsBarCode39"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
' Design and create by Jeff Khor Lai Soon, 2002
' Credit to (c) 1993-1999 James Isle Mercanti, Cocoa Beach, FL 32931  USA

Option Explicit

Private nX As Currency
Private strBarCode As String

Private blnRaiseError As Boolean
Private lngErrorNumber As Long
Private strErrDescription As String

Private blnBox As Boolean
Private blnCheckDigit As Boolean

Private lngCurrentX As Long
Private lngCurrentY As Long

Private intBarcodeHeight As Integer
Private intTotalWidth As Integer
Private intTotalHeight As Integer

Const B_ErrInvalidChar = 5970
Const S_ErrInvalidChar = "Invalid Charater in the Barcode parameter."
Const B_ErrInvalidControl = 438
Const S_ErrInvalidControl = "Invalid control in use. Support only picturebox, form, and printer."

Const T_Height = 195

Public Sub Draw(Destination As Object)
On Error GoTo ErrorHandle

    Dim NBar As Single, WBar As Single, QBar As Single
    Dim sglNarrowX As Single, sglOnePart As Single
    
    Dim BoxTop As Long, BoxLeft As Long
    Dim BoxWidth As Long, BoxHeight As Long
    
    Dim BarTop As Long, BarLeft As Long
    Dim BarWidth As Long, BarHeight As Long
    
    Dim Stripes As String, strBarBit As String * 1
    Dim intLen As Integer, NextBar As Single
    Dim strBarByte As String * 1
    Dim x As Integer, Y As Integer
    
    Dim lngColor As Long
    
    Dim LastFont As String, LastFontSize As Single
    
    ' Change value from inches to twips
    ' 1 nx = 0.001 inches
    sglNarrowX = nX
    
    ' Include start and stop bit
    If Left$(strBarCode, 1) <> "*" Then strBarCode = "*" & strBarCode
    If Right$(strBarCode, 1) <> "*" Then strBarCode = strBarCode & "*"
    
    intLen = Len(strBarCode)
    
    ' Calculate one charater width
    NBar = sglNarrowX: WBar = 3 * sglNarrowX: QBar = sglNarrowX
    sglOnePart = 6 * NBar + 3 * WBar + QBar
    
    ' Calculate the position of barcode
    BarLeft = lngCurrentX + 150
    BarTop = lngCurrentY + 150
    BarWidth = intLen * sglOnePart
    BarHeight = intBarcodeHeight
    
    ' Draw box if require
    If blnBox = True Then
        ' Calculate the area and draw it
        BoxLeft = lngCurrentX
        BoxTop = lngCurrentY
        BoxWidth = BarWidth + 300
        BoxHeight = BarHeight + T_Height + 330
    
        Destination.Line (BoxLeft, BoxTop)-Step(BoxWidth, BoxHeight), 0, B
    End If
    
    ' Store default value
    LastFont = Destination.Font.Name
    LastFontSize = Destination.Font.Size
    
    'Initialize bar index and color.
    NextBar = BarLeft
    lngColor = vbWhite
    Destination.Font.Name = "Tahoma"
    Destination.Font.Size = 8
    
    For x = 1 To intLen
    
        ' Get the stripes and current charater
        strBarByte = Mid$(strBarCode, x, 1)
        Stripes = MD_BC39(strBarByte)

        ' Draw the charater
        Destination.CurrentX = NextBar + (sglOnePart - Destination.TextWidth(strBarByte)) \ 2
        Destination.CurrentY = BarTop + BarHeight + 30
        Destination.Print strBarByte
    
        For Y = 1 To 9
            strBarBit = Mid$(Stripes, Y, 1)
            
            ' Tongle the color
            If lngColor = vbWhite Then lngColor = vbBlack Else lngColor = vbWhite
            
            Select Case strBarBit
                ' Wide Bar
                Case "1"
                    Destination.Line (NextBar, BarTop)-Step(WBar, BarHeight), lngColor, BF
                    NextBar = NextBar + WBar
                ' Narrow Bar
                Case "0"
                    Destination.Line (NextBar, BarTop)-Step(NBar, BarHeight), lngColor, BF
                    NextBar = NextBar + NBar

            End Select
        Next
        
        ' Tongle the color
        If lngColor = vbWhite Then lngColor = vbBlack Else lngColor = vbWhite
        
        ' Quit Bar
        Destination.Line (NextBar, BarTop)-Step(QBar, BarHeight), lngColor, BF
        NextBar = NextBar + QBar
        
    Next

    ' restore default value
    Destination.Font.Name = LastFont
    Destination.Font.Size = LastFontSize
    
    ' Clear the error
    lngErrorNumber = 0
    Exit Sub

ErrorHandle:
    
    ' Point error
    lngErrorNumber = B_ErrInvalidControl
    strErrDescription = S_ErrInvalidControl
            
    ' Raise error, use in dll
    If blnRaiseError = True Then Err.Raise lngErrorNumber, "clsBarcode39.Barcode", strErrDescription
End Sub


Public Property Get NarrowX() As Currency
    NarrowX = nX
End Property

Public Property Let NarrowX(DimensionX As Currency)
    ' NarrowX must bigger that 11 to for readable
    If DimensionX < 11 Then DimensionX = 11
    nX = DimensionX
End Property

Public Property Get RaiseError() As Boolean
    RaiseError = blnRaiseError
End Property

Public Property Let RaiseError(blnError As Boolean)
    blnRaiseError = blnError
End Property

Public Property Get ErrNumber() As Long
    ErrNumber = lngErrorNumber
End Property

Public Property Get ErrDescription() As String
    ErrDescription = strErrDescription
End Property

Public Property Get Barcode() As String
    Barcode = strBarCode
End Property

Public Property Let Barcode(strValue As String)

    Dim i As Integer
    Dim intLen As Integer
    Dim strReturn As String
    Dim strChar As String * 1
   
    ' Check every digit for valid charater
    intLen = Len(strValue)
    For i = 1 To intLen
        strChar = Mid(strValue, i, 1)
        strReturn = MD_BC39(strChar)
        
        ' Invalid charater will return Null
        If strReturn = "" Then
            ' Point error
            lngErrorNumber = B_ErrInvalidChar
            strErrDescription = S_ErrInvalidChar
            
            ' Raise error, use in dll
            If blnRaiseError = True Then Err.Raise lngErrorNumber, "clsBarcode39.Barcode", strErrDescription
            Exit Property
        End If
    Next
    
    strBarCode = strValue
    ' Clear the error
    lngErrorNumber = 0
End Property

Public Property Get ShowBox() As Boolean
    ShowBox = blnBox
End Property

Public Property Let ShowBox(blnSetBox As Boolean)
    blnBox = blnSetBox
End Property

Public Property Get CurrentX() As Long
    CurrentX = lngCurrentX
End Property

Public Property Let CurrentX(lngX As Long)
    lngCurrentX = lngX
End Property

Public Property Get CurrentY() As Long
    CurrentY = lngCurrentY
End Property

Public Property Let CurrentY(lngY As Long)
    lngCurrentY = lngY
End Property

Public Property Get BarcodeHeight() As Integer
    BarcodeHeight = intBarcodeHeight
End Property

Public Property Let BarcodeHeight(intHeight As Integer)
    If intHeight < 300 Then intHeight = 300
    intBarcodeHeight = intHeight
End Property

Public Property Get TotalWidth() As Long
    
    Dim sglNarrowX As Single
    Dim sglOnePart As Single
    Dim NBar As Single, WBar As Single, QBar As Single
    
    ' Change value from inches to twips
    ' 1 nx = 0.001 inches
    sglNarrowX = nX
    
    ' Calculate one charater width
    NBar = sglNarrowX: WBar = 3 * sglNarrowX: QBar = sglNarrowX
    sglOnePart = 6 * NBar + 3 * WBar + QBar
    
    ' 300 for space
    TotalWidth = Len(strBarCode) * sglOnePart + 300
End Property

Public Property Get TotalHeight() As Long
    ' 330 for space
    TotalHeight = intBarcodeHeight + T_Height + 330
End Property

Private Sub Class_Initialize()
    ' Initialize all the default value
    nX = 15
    strBarCode = "*12345*"
    
    blnRaiseError = False
    lngErrorNumber = 0
    strErrDescription = "No Error"
    
    blnBox = True
    
    lngCurrentX = 0
    lngCurrentY = 0

    intBarcodeHeight = 600
End Sub

Private Function FindCode(ByVal Code As Integer) As Integer
    Select Case Code
        Case 48 To 57: FindCode = Code - 48 ' 0-9
        Case 65 To 90: FindCode = Code - 55 ' A-Z
        Case 45: FindCode = 36 ' -
        Case 46: FindCode = 37 ' .
        Case 32: FindCode = 38 ' Space
        Case 36: FindCode = 39 ' $
        Case 47: FindCode = 40 ' /
        Case 43: FindCode = 41 ' +
        Case 37: FindCode = 42 ' %
        Case Else
            ' Point error
            lngErrorNumber = B_ErrInvalidChar
            strErrDescription = S_ErrInvalidChar
            
            ' Raise error, use in dll
            If blnRaiseError = True Then Err.Raise lngErrorNumber, "clsBarcode39.FindCode", strErrDescription
            Exit Function
    End Select
    
    ' Clear the error
    lngErrorNumber = 0
End Function

Private Function AssignCode(ByVal Code As Integer) As String
    Dim nCode As Integer
    
    Select Case Code
        Case 0 To 9: nCode = Code + 48    ' 0-9
        Case 10 To 35: nCode = Code + 55  ' A-Z
        Case 36: nCode = 45 ' -
        Case 37: nCode = 46 ' .
        Case 38: nCode = 32 ' Space
        Case 39: nCode = 36 ' $
        Case 40: nCode = 47 ' /
        Case 41: nCode = 43 ' +
        Case 42: nCode = 37 ' %
        
    End Select
    AssignCode = Chr$(nCode)
End Function

Public Function FindCheckDigit(Optional ByVal Code As String) As String
    Dim intLen As Integer
    Dim x As Integer
    Dim intTotal As Integer
    Dim intWeight As Integer
    Dim intChar As Integer
    Dim oddBarcode
    
    If Code = Empty Then
        oddBarcode = strBarCode
    Else
        oddBarcode = Code
    End If
    
    ' Remove "*"
    oddBarcode = Replace(oddBarcode, "*", "")
     
    ' Calculate weight
    intLen = Len(oddBarcode)
    For x = 1 To intLen
        intChar = Asc(Mid$(oddBarcode, x, 1))
        intTotal = intTotal + FindCode(intChar)
    Next
    intWeight = intTotal Mod 43
    
    ' Get back charater
    FindCheckDigit = AssignCode(intWeight)
End Function

Private Function MD_BC39(CharCode As String) As String
    
    On Error GoTo ErrorTrap_BC39

    ReDim BC39(90)

    BC39(32) = "011000100" ' space
    BC39(36) = "010101000" ' $
    BC39(37) = "000101010" ' %
    BC39(42) = "010010100" ' * Start/Stop
    BC39(43) = "010001010" ' +
    BC39(45) = "010000101" ' |
    BC39(46) = "110000100" ' .
    BC39(47) = "010100010" ' /
    BC39(48) = "000110100" ' 0
    BC39(49) = "100100001" ' 1
    BC39(50) = "001100001" ' 2
    BC39(51) = "101100000" ' 3
    BC39(52) = "000110001" ' 4
    BC39(53) = "100110000" ' 5
    BC39(54) = "001110000" ' 6
    BC39(55) = "000100101" ' 7
    BC39(56) = "100100100" ' 8
    BC39(57) = "001100100" ' 9
    BC39(65) = "100001001" ' A
    BC39(66) = "001001001" ' B
    BC39(67) = "101001000" ' C
    BC39(68) = "000011001" ' D
    BC39(69) = "100011000" ' E
    BC39(70) = "001011000" ' F
    BC39(71) = "000001101" ' G
    BC39(72) = "100001100" ' H
    BC39(73) = "001001100" ' I
    BC39(74) = "000011100" ' J
    BC39(75) = "100000011" ' K
    BC39(76) = "001000011" ' L
    BC39(77) = "101000010" ' M
    BC39(78) = "000010011" ' N
    BC39(79) = "100010010" ' O
    BC39(80) = "001010010" ' P
    BC39(81) = "000000111" ' Q
    BC39(82) = "100000110" ' R
    BC39(83) = "001000110" ' S
    BC39(84) = "000010110" ' T
    BC39(85) = "110000001" ' U
    BC39(86) = "011000001" ' V
    BC39(87) = "111000000" ' W
    BC39(88) = "010010001" ' X
    BC39(89) = "110010000" ' Y
    BC39(90) = "011010000" ' Z
    
    MD_BC39 = BC39(Asc(CharCode))

Exit_BC39:
    Exit Function

ErrorTrap_BC39:
    MD_BC39 = ""
    Resume Exit_BC39

End Function


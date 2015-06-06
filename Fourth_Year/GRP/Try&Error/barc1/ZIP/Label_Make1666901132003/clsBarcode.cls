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
Attribute VB_Exposed = False
Option Explicit

Private m_cArray(43)

Private Sub Class_Initialize()
    InitCharArray
End Sub

Public Function GenerateBarCode(ByRef oPic As PictureBox, ByVal sBarcode As String, ByVal sStartX As String, ByVal iStartY As Integer) As Long

    Const iBarW = 1
    Const iBarH = 25
    
    Dim x As Integer
    Dim y As Integer
    Dim lTextH As Integer
    Dim lTextW As Integer
    Dim sWorking As String
    Dim iCIndex As Integer
    Dim n As Integer
    Dim i As Integer
    Dim sPattern As String
    Dim iEndX As Integer
    Dim iCalc As Integer
    Dim iStartX As Integer
    
    'Assume success
    GenerateBarCode = 0
    
    'Force barcode to uppercase
    sBarcode = UCase$(sBarcode)
    
    lTextH = oPic.TextHeight(sBarcode)  'Text height
    lTextW = oPic.TextWidth(sBarcode)   'Text width
    sWorking = "*" & sBarcode & "*"     'Add start and stop characters
    
    If IsNumeric(sStartX) Then
        iStartX = Abs(CInt(sStartX))
    Else
        iStartX = 0
    End If
    
    'Set starting position
    y = iStartY
    x = iStartX
    
    'Build code string
    sPattern = ""
    For n = 1 To Len(sWorking)
        Select Case Mid$(sWorking, n, 1)
            Case "0" To "9"
                iCIndex = CLng(Mid$(sWorking, n, 1))
                
            Case "A" To "Z"
                iCIndex = CLng(Asc(Mid$(sWorking, n, 1)) - 55)
                
            Case "-"
                iCIndex = 36
                
            Case "."
                iCIndex = 37
                
            Case " "
                iCIndex = 38
                
            Case "$"
                iCIndex = 39
                
            Case "/"
                iCIndex = 40
                
            Case "+"
                iCIndex = 41
                
            Case "%"
                iCIndex = 42
                
            Case "*"
                iCIndex = 43
                
            Case Else
                MsgBox "Invalid character - " & Mid$(sWorking, n, 1) & " - for Code 39 barcode.", vbExclamation + vbOKOnly, "Generating Barcode"
                GenerateBarCode = -1
                Exit Function
                
        End Select
        sPattern = sPattern & m_cArray(iCIndex)
    Next
    
    If sStartX = "c" Then
        'Calculate width of barcode
        iCalc = 0
        For i = 1 To Len(sPattern)
            Select Case Mid$(sPattern, i, 1)
                Case " "
                    iCalc = iCalc + 1 * iBarW
                    
                Case "1"
                    iCalc = iCalc + 2 * iBarW
                    
                Case "2"
                    iCalc = iCalc + 3 * iBarW
                    
            End Select
        Next
        iCalc = iCalc + 1 * iBarW
        
        'Determine starting position to center barcode
        iStartX = IIf((oPic.ScaleWidth - iCalc) / 2 > 1, (oPic.ScaleWidth - iCalc) / 2, 1)
        x = iStartX
    End If
    
    'Draw each bar
    For i = 1 To Len(sPattern)
        Select Case Mid$(sPattern, i, 1)
            Case " "
                'space
                oPic.Line (x, y)-(x + 1 * iBarW, y + iBarH), &HFFFFFF, BF
                x = x + iBarW
                
            Case "1"
                'space
                oPic.Line (x, y)-(x + 1 * iBarW, y + iBarH), &HFFFFFF, BF
                x = x + iBarW
                'line
                oPic.Line (x, y)-(x + 1 * iBarW, y + iBarH), &H0&, BF
                x = x + iBarW
                
            Case "2"
                'space
                oPic.Line (x, y)-(x + 1 * iBarW, y + iBarH), &HFFFFFF, BF
                x = x + iBarW
                'wide line
                oPic.Line (x, y)-(x + 2 * iBarW, y + iBarH), &H0&, BF
                x = x + 2 * iBarW
        End Select
    Next
    
    '1 more space
    oPic.Line (x, y)-(x + 1 * iBarW, y + iBarH), &HFFFFFF, BF
    x = x + iBarW
    iEndX = x
    
    'Add barcode text
    'oPic.Width = (x + iBarW) * oPic.Width / oPic.ScaleWidth
    iCalc = iStartX + ((iEndX - iStartX - lTextW) / 2)
    oPic.CurrentX = IIf(iCalc > 1, iCalc, 1)
    oPic.CurrentY = y + iBarH + 1
    oPic.Print sBarcode
    
End Function

Private Sub InitCharArray()
'Define barcode patterns

    m_cArray(0) = "11 221"      '0
    m_cArray(1) = "21 112"      '1
    m_cArray(2) = "12 112"      '2
    m_cArray(3) = "22 111"      '3
    m_cArray(4) = "11 212"      '4
    m_cArray(5) = "21 211"      '5
    m_cArray(6) = "12 211"      '6
    m_cArray(7) = "11 122"      '7
    m_cArray(8) = "21 121"      '8
    m_cArray(9) = "12 121"      '9
    
    'letters A to Z
    m_cArray(10) = "211 12"     'A
    m_cArray(11) = "121 12"     'B
    m_cArray(12) = "221 11"     'C
    m_cArray(13) = "112 12"     'D
    m_cArray(14) = "212 11"     'E
    m_cArray(15) = "122 11"     'F
    m_cArray(16) = "111 22"     'G
    m_cArray(17) = "211 21"     'H
    m_cArray(18) = "121 21"     'I
    m_cArray(19) = "112 21"     'J
    m_cArray(20) = "2111 2"     'K
    m_cArray(21) = "1211 2"     'L
    m_cArray(22) = "2211 1"     'M
    m_cArray(23) = "1121 2"     'N
    m_cArray(24) = "2121 1"     'O
    m_cArray(25) = "1221 1"     'P
    m_cArray(26) = "1112 2"     'Q
    m_cArray(27) = "2112 1"     'R
    m_cArray(28) = "1212 1"     'S
    m_cArray(29) = "1122 1"     'T
    m_cArray(30) = "2 1112"     'U
    m_cArray(31) = "1 2112"     'V
    m_cArray(32) = "2 2111"     'W
    m_cArray(33) = "1 1212"     'X
    m_cArray(34) = "2 1211"     'Y
    m_cArray(35) = "1 2211"     'Z
    
    'allowed symbols
    m_cArray(36) = "1 1122"     '-
    m_cArray(37) = "2 1121"     '.
    m_cArray(38) = "1 2121"     'space
    m_cArray(39) = "1 1 1 11"   '$
    m_cArray(40) = "1 1 11 1"   '/
    m_cArray(41) = "1 11 1 1"   '+
    m_cArray(42) = "11 1 1 1"   '%
    m_cArray(43) = "1 1221"     '*
    
End Sub

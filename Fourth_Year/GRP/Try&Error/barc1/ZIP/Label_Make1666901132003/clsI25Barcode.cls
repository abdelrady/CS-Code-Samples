VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsI25Barcode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Option Compare Text

'Generate Interleaved 2 of 5 Barcode Format

'Barcode Patterns
Private Const I25_START As String = "NNNN"
Private Const I25_STOP As String = "WNN"
Private I25_Pattern(9) As String

Private Sub Class_Initialize()

    'Define Number Patterns
    I25_Pattern(0) = "NNWWN"
    I25_Pattern(1) = "WNNNW"
    I25_Pattern(2) = "NWNNW"
    I25_Pattern(3) = "WWNNN"
    I25_Pattern(4) = "NNWNW"
    I25_Pattern(5) = "WNWNN"
    I25_Pattern(6) = "NWWNN"
    I25_Pattern(7) = "NNNWW"
    I25_Pattern(8) = "WNNWN"
    I25_Pattern(9) = "NWNWN"
    
End Sub

Public Function GenerateI25Barcode(ByRef oPic As PictureBox, ByVal sBarcode As String, ByVal sStartX As String, ByVal nStartY As Long) As Long

    Const BAR_NARROW As Integer = 2
    Const BAR_WIDE As Integer = 4
    Const BAR_HEIGHT As Integer = 25
    
    Dim sOutput As String
    Dim nStartX As Long
    Dim x As Long
    Dim y As Long
    Dim nCalc As Long
    Dim nTextH As Long
    Dim nTextW As Long
    Dim bBar As Boolean
    Dim i As Integer
    
    'Get Barcode text height and width
    nTextH = oPic.TextHeight(sBarcode)
    nTextW = oPic.TextWidth(sBarcode)
    
    'Encode Barcode
    If LenB(sBarcode) > 0 Then
        sOutput = I25Encode(sBarcode)
        
        If LenB(sOutput) = 0 Then
            'Stop if invalid barcode
            GenerateI25Barcode = -1
            Exit Function
        End If
    Else
        'Stop if no barcode provided
        GenerateI25Barcode = -1
        Exit Function
    End If
    
    If IsNumeric(sStartX) Then
        nStartX = Abs(CLng(sStartX))
    ElseIf sStartX = "c" Then
        'Calculate width of barcode
        nCalc = 0
        For i = 1 To Len(sOutput)
            Select Case Mid$(sOutput, i, 1)
                Case "N"
                    nCalc = nCalc + BAR_NARROW
                Case "W"
                    nCalc = nCalc + BAR_WIDE
            End Select
        Next
        
        'Determine starting position to center barcode
        nStartX = IIf(((oPic.ScaleWidth - nCalc) / 2) > 1, (oPic.ScaleWidth - nCalc) / 2, 1)
    Else
        nStartX = 0
    End If
    
    'Set initial coordinates
    x = nStartX
    y = nStartY
    
    'Draw each bar
    bBar = True
    For i = 1 To Len(sOutput)
        If bBar Then
            If Mid$(sOutput, i, 1) = "N" Then
                'Narrow
                oPic.Line (x, y)-(x + BAR_NARROW, y + BAR_HEIGHT), &H0&, BF
                x = x + BAR_NARROW
            Else 'If Mid$(sOutput, i, 1) = "W" Then
                'Wide
                oPic.Line (x, y)-(x + BAR_WIDE, y + BAR_HEIGHT), &H0&, BF
                x = x + BAR_WIDE
            End If
        Else
            If Mid$(sOutput, i, 1) = "N" Then
                'Narrow
                oPic.Line (x, y)-(x + BAR_NARROW + 1, y + BAR_HEIGHT), &HFFFFFF, BF
                x = x + BAR_NARROW
            Else 'If Mid$(sOutput, i, 1) = "W" Then
                'Wide
                oPic.Line (x, y)-(x + BAR_WIDE + 1, y + BAR_HEIGHT), &HFFFFFF, BF
                x = x + BAR_WIDE
            End If
        End If
        
        bBar = Not bBar
    Next
    
    'Add barcode text
    nCalc = nStartX + ((x - nStartX - nTextW) / 2)
    oPic.CurrentX = IIf(nCalc > 1, nCalc, 1)
    oPic.CurrentY = y + BAR_HEIGHT + 1
    oPic.Print sBarcode
    
End Function

Private Function I25Encode(ByVal sBarcodeValue As String) As String

    'Validate - Even number of characters in Barcode
    If (Len(sBarcodeValue) Mod 2) <> 0 Then
        I25Encode = ""
        Exit Function
    End If
    
    'Validate - Barcode must only contain numbers
    If Not IsNumeric(sBarcodeValue) Then
        'Barcode value must be numeric
        I25Encode = ""
        Exit Function
    Else
        If (InStr(sBarcodeValue, ".") <> 0) Or (InStr(sBarcodeValue, ",") <> 0) Then
            I25Encode = ""
            Exit Function
        End If
    End If
    
    'Encode and Interleave
    Dim sEncoded As String
    Dim sUnit As String
    Dim iCharRead As Integer
    Dim sDigit1 As String
    Dim sDigit2 As String
    Dim i As Integer
    
    sEncoded = ""
    
    For iCharRead = 1 To Len(sBarcodeValue) Step 2
        sDigit1 = I25_Pattern(Asc(Mid(sBarcodeValue, iCharRead, 1)) - 48)
        sDigit2 = I25_Pattern(Asc(Mid(sBarcodeValue, iCharRead + 1, 1)) - 48)
        sUnit = ""
        
        For i = 1 To 5
            sUnit = sUnit & Mid(sDigit1, i, 1) & Mid(sDigit2, i, 1)
        Next i
        
        sEncoded = sEncoded & sUnit
    Next
    
    I25Encode = I25_START & sEncoded & I25_STOP
    
End Function


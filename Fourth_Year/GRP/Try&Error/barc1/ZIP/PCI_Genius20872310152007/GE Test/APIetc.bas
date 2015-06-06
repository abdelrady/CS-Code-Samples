Attribute VB_Name = "APIetc"
Option Explicit
' ############################################################################
' API Constants
Public Const GENERIC_READ                                   As Long = &H80000000
Public Const GENERIC_WRITE                                  As Long = &H40000000

Public Const OPEN_EXISTING                                  As Integer = 3
Public Const FILE_ATTRIBUTE_NORMAL                          As Long = &H80

Public Const FILE_ANY_ACCESS                                As Integer = &H0
Public Const FILE_READ_ACCESS                               As Integer = &H1
Public Const FILE_WRITE_ACCESS                              As Integer = &H2

Public Const SWP_NOMOVE                                     As Long = &H2
Public Const SWP_NOSIZE                                     As Long = &H1
Public Const HWND_TOPMOST                                   As Integer = -1

'Shared Ram Interface Memory Offset constants
Public Const SRI_GENI_SETUP_OFFSET                          As Long = 2178
Public Const SRI_GENI_STATUS_OFFSET                         As Long = 2194
Public Const SRI_COMMAND_OFFSET                             As Long = 2242
Public Const SRI_TRANSMIT_DATAGRAM_OFFSET                   As Long = 2258
Public Const SRI_READ_DATAGRAM_OFFSET                       As Long = 2498

Public Const SRI_SBA00_DEVICE_CONFIG_OFFSET                 As Long = 7680
Public Const SRI_SBA01_DEVICE_CONFIG_OFFSET                 As Long = 7688
Public Const SRI_SBA02_DEVICE_CONFIG_OFFSET                 As Long = 7696
Public Const SRI_SBA03_DEVICE_CONFIG_OFFSET                 As Long = 7704
Public Const SRI_SBA04_DEVICE_CONFIG_OFFSET                 As Long = 7712
Public Const SRI_SBA05_DEVICE_CONFIG_OFFSET                 As Long = 7720
Public Const SRI_SBA06_DEVICE_CONFIG_OFFSET                 As Long = 7728
Public Const SRI_SBA07_DEVICE_CONFIG_OFFSET                 As Long = 7736
Public Const SRI_SBA08_DEVICE_CONFIG_OFFSET                 As Long = 7744
Public Const SRI_SBA09_DEVICE_CONFIG_OFFSET                 As Long = 7752
Public Const SRI_SBA10_DEVICE_CONFIG_OFFSET                 As Long = 7760
Public Const SRI_SBA11_DEVICE_CONFIG_OFFSET                 As Long = 7768
Public Const SRI_SBA12_DEVICE_CONFIG_OFFSET                 As Long = 7776
Public Const SRI_SBA13_DEVICE_CONFIG_OFFSET                 As Long = 7784
Public Const SRI_SBA14_DEVICE_CONFIG_OFFSET                 As Long = 7792
Public Const SRI_SBA15_DEVICE_CONFIG_OFFSET                 As Long = 7800
Public Const SRI_SBA16_DEVICE_CONFIG_OFFSET                 As Long = 7808
Public Const SRI_SBA17_DEVICE_CONFIG_OFFSET                 As Long = 7816
Public Const SRI_SBA18_DEVICE_CONFIG_OFFSET                 As Long = 7824
Public Const SRI_SBA19_DEVICE_CONFIG_OFFSET                 As Long = 7832
Public Const SRI_SBA20_DEVICE_CONFIG_OFFSET                 As Long = 7840
Public Const SRI_SBA21_DEVICE_CONFIG_OFFSET                 As Long = 7848
Public Const SRI_SBA22_DEVICE_CONFIG_OFFSET                 As Long = 7856
Public Const SRI_SBA23_DEVICE_CONFIG_OFFSET                 As Long = 7864
Public Const SRI_SBA24_DEVICE_CONFIG_OFFSET                 As Long = 7872
Public Const SRI_SBA25_DEVICE_CONFIG_OFFSET                 As Long = 7880
Public Const SRI_SBA26_DEVICE_CONFIG_OFFSET                 As Long = 7888
Public Const SRI_SBA27_DEVICE_CONFIG_OFFSET                 As Long = 7896
Public Const SRI_SBA28_DEVICE_CONFIG_OFFSET                 As Long = 7904
Public Const SRI_SBA29_DEVICE_CONFIG_OFFSET                 As Long = 7912
Public Const SRI_SBA30_DEVICE_CONFIG_OFFSET                 As Long = 7920
Public Const SRI_SBA31_DEVICE_CONFIG_OFFSET                 As Long = 7928

Public Const SRI_BROADCAST_CONTROL_OUTPUT_TABLE_OFFSET      As Long = 8064

Public Const SRI_SBA00_DEVICE_IO_TABLE_OFFSET               As Long = 8192
Public Const SRI_SBA01_DEVICE_IO_TABLE_OFFSET               As Long = 8320
Public Const SRI_SBA02_DEVICE_IO_TABLE_OFFSET               As Long = 8448
Public Const SRI_SBA03_DEVICE_IO_TABLE_OFFSET               As Long = 8576
Public Const SRI_SBA04_DEVICE_IO_TABLE_OFFSET               As Long = 8704
Public Const SRI_SBA05_DEVICE_IO_TABLE_OFFSET               As Long = 8832
Public Const SRI_SBA06_DEVICE_IO_TABLE_OFFSET               As Long = 8960
Public Const SRI_SBA07_DEVICE_IO_TABLE_OFFSET               As Long = 9088
Public Const SRI_SBA08_DEVICE_IO_TABLE_OFFSET               As Long = 9216
Public Const SRI_SBA09_DEVICE_IO_TABLE_OFFSET               As Long = 9344
Public Const SRI_SBA10_DEVICE_IO_TABLE_OFFSET               As Long = 9472
Public Const SRI_SBA11_DEVICE_IO_TABLE_OFFSET               As Long = 9600
Public Const SRI_SBA12_DEVICE_IO_TABLE_OFFSET               As Long = 9728
Public Const SRI_SBA13_DEVICE_IO_TABLE_OFFSET               As Long = 9856
Public Const SRI_SBA14_DEVICE_IO_TABLE_OFFSET               As Long = 9984
Public Const SRI_SBA15_DEVICE_IO_TABLE_OFFSET               As Long = 10112
Public Const SRI_SBA16_DEVICE_IO_TABLE_OFFSET               As Long = 10240
Public Const SRI_SBA17_DEVICE_IO_TABLE_OFFSET               As Long = 10368
Public Const SRI_SBA18_DEVICE_IO_TABLE_OFFSET               As Long = 10496
Public Const SRI_SBA19_DEVICE_IO_TABLE_OFFSET               As Long = 10624
Public Const SRI_SBA20_DEVICE_IO_TABLE_OFFSET               As Long = 10752
Public Const SRI_SBA21_DEVICE_IO_TABLE_OFFSET               As Long = 10880
Public Const SRI_SBA22_DEVICE_IO_TABLE_OFFSET               As Long = 11008
Public Const SRI_SBA23_DEVICE_IO_TABLE_OFFSET               As Long = 11136
Public Const SRI_SBA24_DEVICE_IO_TABLE_OFFSET               As Long = 11264
Public Const SRI_SBA25_DEVICE_IO_TABLE_OFFSET               As Long = 11392
Public Const SRI_SBA26_DEVICE_IO_TABLE_OFFSET               As Long = 11520
Public Const SRI_SBA27_DEVICE_IO_TABLE_OFFSET               As Long = 11648
Public Const SRI_SBA28_DEVICE_IO_TABLE_OFFSET               As Long = 11776
Public Const SRI_SBA29_DEVICE_IO_TABLE_OFFSET               As Long = 11904
Public Const SRI_SBA30_DEVICE_IO_TABLE_OFFSET               As Long = 12032
Public Const SRI_SBA31_DEVICE_IO_TABLE_OFFSET               As Long = 12160

'Public variables
Public LocationResult                                       As Integer
Public InitializationResult                                 As Integer
    'Initialization result of constructor
Public SerialBusAddress                                     As Integer
    'Serial bus address assigned to the PCGEN card
Public cGEGENIUS                                            As String
Public hWin32Device                                         As Long
Public MemoryBaseAddress                                    As Long
Public Outputs                                              As GENI_Outputs
Public BaudRate                                             As GENI_BaudRate
Public Node                                                 As Integer
Public Device                                               As Integer

Public SRI_Device_Config_Offset(31)                         As Long
Public SRI_Device_IO_Table_Offset(31)                       As Long
Public DeviceConfig(31)                                     As DEVICE_CONFIG

'API Functions
Public Declare Function CreateFile Lib "KERNEL32" Alias "CreateFileA" (ByVal lpFileName As String, _
                                                                       ByVal dwDesiredAccess As Long, _
                                                                       ByVal dwShareMode As Long, _
                                                                       lpSecurityAttributes As Long, _
                                                                       ByVal dwCreationDisposition As Long, _
                                                                       ByVal dwFlagsAndAttributes As Long, _
                                                                       ByVal hTemplateFile As Long) As Long
Public Declare Function DeviceIoControl Lib "KERNEL32" (ByVal hDevice As Long, _
                                                        ByVal dwIoControlCode As Long, _
                                                        ByRef lpInBuffer As Any, _
                                                        ByVal nInBufferSize As Long, _
                                                        ByRef lpOutBuffer As Any, _
                                                        ByVal nOutBufferSize As Long, _
                                                        ByRef lpBytesReturned As Long, _
                                                        ByVal lpOverlapped As Long) As Long
Public Declare Sub CopyMemory Lib "KERNEL32" Alias "RtlMoveMemory" (Destination As Any, _
                                                                    Source As Any, _
                                                                    ByVal Length As Long)
Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, _
                                                    ByVal hWndInsertAfter As Long, _
                                                    ByVal X As Long, _
                                                    ByVal Y As Long, _
                                                    ByVal cx As Long, _
                                                    ByVal cy As Long, _
                                                    ByVal wFlags As Long) As Long
Public Declare Function CloseHandle Lib "KERNEL32" (ByVal hObject As Long) As Long
Public Declare Function GetTickCount Lib "kernel32.dll" () As Long

Public Function BinaryToDecimal(Bin As Variant) As String
Dim Binary1  As String
Dim Decimal1 As Long
Dim A        As Integer
    For A = 1 To Len(Bin)
        If Mid$(Bin, A, 1) <> "0" Then
            If Mid$(Bin, A, 1) <> "1" Then

                Exit Function

            End If
        End If
    Next A
    Decimal1 = 0
    Binary1 = Bin
    For A = 1 To Len(Binary1)
        Decimal1 = Decimal1 * 2 + Mid$(Binary1, A, 1)
    Next A
    BinaryToDecimal = Decimal1
End Function
Public Function ByteFormat(CurInfo As String) As String
    Select Case Len(CurInfo)
    Case 0
        ByteFormat = "00000000"
    Case 1
        ByteFormat = "0000000" & CurInfo
    Case 2
        ByteFormat = "000000" & CurInfo
    Case 3
        ByteFormat = "00000" & CurInfo
    Case 4
        ByteFormat = "0000" & CurInfo
    Case 5
        ByteFormat = "000" & CurInfo
    Case 6
        ByteFormat = "00" & CurInfo
    Case 7
        ByteFormat = "0" & CurInfo
    Case Else
        ByteFormat = CurInfo
    End Select
End Function
''Mimic C++ Function
Public Function CTL_CODE(lngDevFileSys As Long, _
                         lngFunction As Long, _
                         lngMethod As Long, _
                         lngAccess As Long) As Long
    CTL_CODE = (lngDevFileSys * (2 ^ 16)) Or (lngAccess * (2 ^ 14)) Or (lngFunction * (2 ^ 2)) Or lngMethod
End Function
Public Function DecimalToBinary(Dec As Variant) As String
Dim Decimal1 As Long
Dim Binary1  As String
Dim Binary2  As String
Dim A        As Integer
    Binary1 = vbNullString
    Binary2 = vbNullString
    Decimal1 = Dec
    Do Until Decimal1 = 0
        If Not Postal(Decimal1) Then
            Binary2 = Binary2 & 1
        ElseIf Postal(Decimal1) Then
            Binary2 = Binary2 & 0
        End If
        Decimal1 = Int(Decimal1 / 2)
    Loop
    For A = Len(Binary2) To 1 Step -1
        Binary1 = Binary1 & Mid$(Binary2, A, 1)
    Next A
    DecimalToBinary = Binary1
End Function
Public Function GetVar(Address As Long, _
                       Length As Long)
'Using ByVal Address because I am passing the raw memory address
'   and not a defined variable
'Using Length to determine size in bytes then using CopyMemory
'   to pass one byte at a time.  Passing one byte at a time
'   because the card and Windows are accessing the same memory.
'   The GeniusBus card does have a read and write memory request,
'   but I am using this trick because I'm only concerned with one,
'   to a only a few bytes at a time.
Dim b    As Byte
Dim I(1) As Byte
Dim l(3) As Byte
    If Length = 1 Then
        CopyMemory b, ByVal Address, Length
        GetVar = b
    ElseIf Length = 2 Then
        CopyMemory I(0), ByVal Address, 1
        CopyMemory I(1), ByVal Address + 1, 1
        GetVar = MakeInt(I(1), I(0))
    ElseIf Length = 4 Then
        CopyMemory l(0), ByVal Address, 1
        CopyMemory l(1), ByVal Address + 1, 1
        CopyMemory l(2), ByVal Address + 2, 1
        CopyMemory l(3), ByVal Address + 3, 1
        GetVar = MakeLong((MakeInt(l(3), l(2))), (MakeInt(l(1), l(0))))
    End If
End Function
Public Function HiByte(ByVal w As Integer) As Byte
    If w And &H8000 Then
        HiByte = &H80 Or ((w And &H7FFF) \ &HFF)
    Else
        HiByte = w \ 256
    End If
End Function
Public Function HiWord(dw As Long) As Integer
    If dw And &H80000000 Then
        HiWord = (dw \ 65535) - 1
    Else
        HiWord = dw \ 65535
    End If
End Function
Public Function LoByte(w As Integer) As Byte
    LoByte = w And &HFF
End Function
Public Function LoWord(dw As Long) As Integer
    If dw And &H8000& Then
        LoWord = &H8000 Or (dw And &H7FFF&)
    Else
        LoWord = dw And &HFFFF&
    End If
End Function
Public Function MakeInt(ByVal LByte As Byte, _
                        ByVal HByte As Byte) As Integer
Dim temp(1) As Byte
    temp(0) = HByte
    temp(1) = LByte
    CopyMemory MakeInt, temp(0), 2
End Function
Public Function MakeLong(ByVal LoWord As Integer, _
                         ByVal HiWord As Integer) As Single
    MakeLong = ((HiWord * &H10000) + LoWord)
End Function
Private Function Postal(Getal As Long) As Boolean
    If Getal = Int(Getal / 2) * 2 Then
        Postal = True
    ElseIf Getal <> Int(Getal / 2) * 2 Then
        Postal = False
    End If
End Function
Public Function SetVar(Address As Long, _
                       Data As Variant, _
                       Length As Integer)
'Using ByVal Address because I am passing the raw memory address
'   and not a defined variable
'Using Length to determine size in bytes then using CopyMemory
'   to pass one byte at a time.  Passing one byte at a time
'   because the card and Windows are accessing the same memory.
'   The GeniusBus card does have a read and write memory request,
'   but I am using this trick because I'm only concerned with one,
'   to a only a few bytes at a time.
Dim I(1) As Byte
Dim l(3) As Byte
    IO_Display.Text1 = vbNullString
    If Length = 1 Then
        CopyMemory ByVal Address, CByte(Data), 1
    ElseIf Length = 2 Then
        I(0) = HiByte(CInt(Data))
        I(1) = LoByte(CInt(Data))
        CopyMemory ByVal Address, I(0), 1
        CopyMemory ByVal Address + 1, I(1), 1
    ElseIf Length = 4 Then
        CopyMemory l(0), (CSng(Data)), 4
        
'l(0) = HiByte(HiWord(CSng(Data)))
'l(1) = LoByte(HiWord(CSng(Data)))
'l(2) = HiByte(LoWord(CSng(Data)))
'l(3) = LoByte(LoWord(CSng(Data)))

        CopyMemory ByVal Address, l(0), 1
        CopyMemory ByVal Address + 1, l(1), 1
        CopyMemory ByVal Address + 2, l(2), 1
        CopyMemory ByVal Address + 3, l(3), 1
    End If
End Function

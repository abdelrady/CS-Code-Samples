Attribute VB_Name = "modFileInformation"
Option Explicit
'<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Extract file information>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Private Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, lpFindFileData As WIN32_FIND_DATA) As Long
Private Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" (ByVal hFindFile As Long, lpFindFileData As WIN32_FIND_DATA) As Long
Private Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Long) As Long
Private Declare Function FileTimeToSystemTime Lib "kernel32" (lpFileTime As FILETIME, lpSystemTime As SYSTEMTIME) As Long
Private Declare Function StrFormatByteSize Lib "shlwapi" Alias "StrFormatByteSizeA" (ByVal dw As Long, ByVal pszBuf As String, ByRef cchBuf As Long) As String
Private Declare Function FindExecutableA Lib "shell32.dll" (ByVal lpFile As String, ByVal lpDirectory As String, ByVal lpResult As String) As Long

Private Const FILE_ATTRIBUTE_ARCHIVE = &H20
Private Const FILE_ATTRIBUTE_COMPRESSED = &H800
Private Const FILE_ATTRIBUTE_DIRECTORY = &H10
Private Const FILE_ATTRIBUTE_HIDDEN = &H2
Private Const FILE_ATTRIBUTE_NORMAL = &H80
Private Const FILE_ATTRIBUTE_READONLY = &H1
Private Const FILE_ATTRIBUTE_SYSTEM = &H4
Private Const FILE_ATTRIBUTE_TEMPORARY = &H100

Private Type FILETIME
        dwLowDateTime As Long
        dwHighDateTime As Long
End Type

Public Type WIN32_FIND_DATA
        dwFilechkattrib As Long
        ftCreationTime As FILETIME
        ftLastAccessTime As FILETIME
        ftLastWriteTime As FILETIME
        nFileSizeHigh As Long
        nFileSizeLow As Long
        dwReserved0 As Long
        dwReserved1 As Long
        cFileName As String * MAX_PATH
        cAlternate As String * 14
End Type

Private Type SYSTEMTIME
        wYear As Integer
        wMonth As Integer
        wDayOfWeek As Integer
        wDay As Integer
        wHour As Integer
        wMinute As Integer
        wSecond As Integer
        wMilliseconds As Integer
End Type
'<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<End of Extract file information>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Private Declare Function VerLanguageName Lib "kernel32" Alias "VerLanguageNameA" (ByVal wLang As Long, ByVal szLang As String, ByVal nSize As Long) As Long
Private Declare Function lstrcpyn Lib "kernel32" Alias "lstrcpynA" (ByVal lpString1 As String, ByVal lpString2 As String, ByVal iMaxLength As Long) As Long

Private Type FileInfo
    wLength            As Integer
    wValueLength       As Integer
    szKey              As String * 16
    dwSignature        As Long
    dwStrucVersion     As Long
    dwFileVersionMS    As Long
    dwFileVersionLS    As Long
End Type

Private ResName(16) As String
Private ResValue(16) As String

Private Filename As String
Private Directory As String
Private FullFileName As String
Private StrucVer As String
Private FileVer As String
Private ProdVer As String
Private FileFlags As String
Private FileOS As String
Private FileType As String
Private FileSubType As String

Private Type VS_FIXEDFILEINFO
    dwSignature As Long
    dwStrucVersionl As Integer     '  e.g. = &h0000 = 0
    dwStrucVersionh As Integer     '  e.g. = &h0042 = .42
    dwFileVersionMSl As Integer    '  e.g. = &h0003 = 3
    dwFileVersionMSh As Integer    '  e.g. = &h0075 = .75
    dwFileVersionLSl As Integer    '  e.g. = &h0000 = 0
    dwFileVersionLSh As Integer    '  e.g. = &h0031 = .31
    dwProductVersionMSl As Integer '  e.g. = &h0003 = 3
    dwProductVersionMSh As Integer '  e.g. = &h0010 = .1
    dwProductVersionLSl As Integer '  e.g. = &h0000 = 0
    dwProductVersionLSh As Integer '  e.g. = &h0031 = .31
    dwFileFlagsMask As Long        '  = &h3F for version "0.42"
    dwFileFlags As Long            '  e.g. VFF_DEBUG Or VFF_PRERELEASE
    dwFileOS As Long               '  e.g. VOS_DOS_WINDOWS16
    dwFileType As Long             '  e.g. VFT_DRIVER
    dwFileSubtype As Long          '  e.g. VFT2_DRV_KEYBOARD
    dwFileDateMS As Long           '  e.g. 0
    dwFileDateLS As Long           '  e.g. 0
End Type

Private Declare Function GetFileVersionInfo Lib "Version.dll" Alias "GetFileVersionInfoA" (ByVal lptstrFilename As String, ByVal dwhandle As Long, ByVal dwlen As Long, lpData As Any) As Long
Private Declare Function GetFileVersionInfoSize Lib "Version.dll" Alias "GetFileVersionInfoSizeA" (ByVal lptstrFilename As String, lpdwHandle As Long) As Long
Private Declare Function VerQueryValue Lib "Version.dll" Alias "VerQueryValueA" (pBlock As Any, ByVal lpSubBlock As String, lplpBuffer As Any, puLen As Long) As Long
Private Declare Sub MoveMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, ByVal Source As Long, ByVal Length As Long)
Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal Path As String, ByVal cbBytes As Long) As Long

' ===== From Win32 Ver.h =================
' ----- VS_VERSION.dwFileFlags -----
Private Const VS_FFI_SIGNATURE = &HFEEF04BD
Private Const VS_FFI_STRUCVERSION = &H10000
Private Const VS_FFI_FILEFLAGSMASK = &H3F&

' ----- VS_VERSION.dwFileFlags -----
Private Const VS_FF_DEBUG = &H1
Private Const VS_FF_PRERELEASE = &H2
Private Const VS_FF_PATCHED = &H4
Private Const VS_FF_PRIVATEBUILD = &H8
Private Const VS_FF_INFOINFERRED = &H10
Private Const VS_FF_SPECIALBUILD = &H20

' ----- VS_VERSION.dwFileOS -----
Private Const VOS_UNKNOWN = &H0
Private Const VOS_DOS = &H10000
Private Const VOS_OS216 = &H20000
Private Const VOS_OS232 = &H30000
Private Const VOS_NT = &H40000
Private Const VOS__BASE = &H0
Private Const VOS__WINDOWS16 = &H1
Private Const VOS__PM16 = &H2
Private Const VOS__PM32 = &H3
Private Const VOS__WINDOWS32 = &H4

Private Const VOS_WINDOWS16 = &H1
Private Const VOS_WINDOWS32 = &H4
Private Const VOS_DOS_WINDOWS16 = &H10001
Private Const VOS_DOS_WINDOWS32 = &H10004
Private Const VOS_OS216_PM16 = &H20002
Private Const VOS_OS232_PM32 = &H30003
Private Const VOS_NT_WINDOWS32 = &H40004


' ----- VS_VERSION.dwFileType -----
Private Const VFT_UNKNOWN = &H0
Private Const VFT_APP = &H1
Private Const VFT_DLL = &H2
Private Const VFT_DRV = &H3
Private Const VFT_FONT = &H4
Private Const VFT_VXD = &H5
Private Const VFT_STATIC_LIB = &H7

' ----- VS_VERSION.dwFileSubtype for VFT_WINDOWS_DRV -----
Private Const VFT2_UNKNOWN = &H0
Private Const VFT2_DRV_PRINTER = &H1
Private Const VFT2_DRV_KEYBOARD = &H2
Private Const VFT2_DRV_LANGUAGE = &H3
Private Const VFT2_DRV_DISPLAY = &H4
Private Const VFT2_DRV_MOUSE = &H5
Private Const VFT2_DRV_NETWORK = &H6
Private Const VFT2_DRV_SYSTEM = &H7
Private Const VFT2_DRV_INSTALLABLE = &H8
Private Const VFT2_DRV_SOUND = &H9
Private Const VFT2_DRV_COMM = &HA

' ----- VS_VERSION.dwFileSubtype for VFT_WINDOWS_FONT -----
Private Const VFT2_FONT_RASTER = &H1
Private Const VFT2_FONT_VECTOR = &H2
Private Const VFT2_FONT_TRUETYPE = &H3

Private Type MP3Info
    Songname As String
    Artist As String
    Album As String
    Year As String
    Comment As String
    Genre As String
    Track As String
    VBR As Boolean
    Mode As String
    MpegLayer As String
    MpegVersion As String
    Frequency As String
    BitRate As String
    Duration As String
End Type

Public Type VerInfo
    FileTitle               As String
    FileLocation            As String
    FileVersion             As String
    FileDescription         As String
    FileFlags               As String
    FileAuthor              As String
    FileOS                  As String
    FileType                As String
    FileSubType             As String
    FileSizeBytes           As String
    FileSizeMB              As String
    fileSecurity            As String
    FileAssociation         As String
    FileDateCreated         As String
    FileDateModified        As String
    FileDateAccessed        As String
    FileIsHidden            As Boolean
    FileIsSystem            As Boolean
    FileIsReadOnly          As Boolean
    FileIsArchive           As Boolean
    CompanyName             As String
    Language                As String
    Comments                As String
    OriginalFileName        As String
    InternalName            As String
    LegalCopyright          As String
    LegalTrademarks         As String
    ProductName             As String
    ProductVersion          As String
    SpecialBuild            As String
    PrivateBuild            As String
    Mp3Data                 As MP3Info
End Type

Private Function toHex(strIn() As Byte) As String
    Dim strout As String
    Dim temp As String
    Dim i As Integer

    'If (Len(strIn) Mod 2) <> 0 Then strIn = "0" + strIn ' add leading 0 if needed

    strout = ""
    For i = 0 To 3 Step 2
        temp = Hex$(strIn(i + 1)) ' Because of Intel's "Reversed-Byte" architecture
        If Len(temp) = 1 Then strout = strout + "0" ' handle second byte first
        strout = strout + temp

        temp = Hex$(strIn(i))  ' now handle first byte in word
        If Len(temp) = 1 Then strout = strout + "0" ' add leading zero if necessary
        strout = strout + temp
    Next
    toHex = strout
End Function
Private Function toString(byteIn() As Byte) As String
    Dim strout As String
    Dim i As Integer

    strout = ""
    i = 0
    While byteIn(i) <> 0
        strout = strout & Chr$(byteIn(i))
        i = i + 1
    Wend
    toString = strout
End Function

Public Function GetFileInfoLSTV(dFileName As String, VI As VerInfo, OnlyHidden As Boolean, Optional ByVal Item As MSComctlLib.ListItem) As String
    Dim lSize       As Long
    Dim sysFILETIME As SYSTEMTIME
    Dim FileData    As WIN32_FIND_DATA
    Dim i           As Long
    Dim TempData    As String
    
    GetFileInfoLSTV = ""
    FileData = FindFile(dFileName) 'Find file and get data
    
    If OnlyHidden Then GoTo OnlyHiddenValue
    
    If FileData.nFileSizeHigh = 0 Then 'Get file size
        lSize = FileData.nFileSizeLow
    Else
        lSize = FileData.nFileSizeHigh
    End If
    VI.FileTitle = DetermineFilename(dFileName)
    VI.FileLocation = dFileName
    If Not Item Is Nothing Then
        Item.SubItems(1) = FormatSize(lSize)   'Format size
        Item.Tag = lSize
    Else
        VI.FileSizeMB = FormatSize(lSize)
        VI.FileSizeBytes = Format(lSize, "###,###,###,##0 \b\y\t\e\s")
    End If
    ' Created
    FileTimeToSystemTime FileData.ftCreationTime, sysFILETIME
    TempData = sysFILETIME.wMonth & "/" & sysFILETIME.wDay & "/" & sysFILETIME.wYear & " " & sysFILETIME.wHour & ":" & sysFILETIME.wMinute & ":" & sysFILETIME.wSecond
    If Not Item Is Nothing Then Item.SubItems(2) = TempData Else VI.FileDateCreated = TempData
    ' Modified
    FileTimeToSystemTime FileData.ftLastWriteTime, sysFILETIME
    TempData = sysFILETIME.wMonth & "/" & sysFILETIME.wDay & "/" & sysFILETIME.wYear & " " & sysFILETIME.wHour & ":" & sysFILETIME.wMinute & ":" & sysFILETIME.wSecond
    If Not Item Is Nothing Then Item.SubItems(3) = TempData Else VI.FileDateModified = TempData
    ' Accessed
    FileTimeToSystemTime FileData.ftLastAccessTime, sysFILETIME
    TempData = sysFILETIME.wMonth & "/" & sysFILETIME.wDay & "/" & sysFILETIME.wYear
    If Not Item Is Nothing Then Item.SubItems(4) = TempData Else VI.FileDateAccessed = TempData

OnlyHiddenValue:    ' Hidden
    If (FileData.dwFilechkattrib And FILE_ATTRIBUTE_HIDDEN) = FILE_ATTRIBUTE_HIDDEN Then
        If OnlyHidden = True Then
            GetFileInfoLSTV = "HIDDEN"
            Exit Function
        Else
            VI.FileIsHidden = False
            If Not Item Is Nothing Then Item.SubItems(5) = Item.SubItems(5) & "S" Else VI.FileIsHidden = True
        End If
    End If
    If OnlyHidden = True Then Exit Function
    ' System
    If (FileData.dwFilechkattrib And FILE_ATTRIBUTE_SYSTEM) = FILE_ATTRIBUTE_SYSTEM Then
        VI.FileIsSystem = False
        If Not Item Is Nothing Then Item.SubItems(5) = Item.SubItems(5) & "S" Else VI.FileIsSystem = True
    End If
    ' Read Only
    If (FileData.dwFilechkattrib And FILE_ATTRIBUTE_READONLY) = FILE_ATTRIBUTE_READONLY Then
        VI.FileIsReadOnly = False
        If Not Item Is Nothing Then Item.SubItems(5) = Item.SubItems(5) & "R" Else VI.FileIsReadOnly = True
    End If
    ' Archive
    If (FileData.dwFilechkattrib And FILE_ATTRIBUTE_ARCHIVE) = FILE_ATTRIBUTE_ARCHIVE Then
        VI.FileIsArchive = False
        If Not Item Is Nothing Then Item.SubItems(5) = Item.SubItems(5) & "A" Else VI.FileIsArchive = True
    End If
    '<<<get the file association
    TempData = String(256, 32) & Chr$(0) 'MAX_FILENAME_LEN = 256
    i = FindExecutableA(dFileName & Chr$(0), vbNullString, TempData)
    If i > 32 Then
        If Not Item Is Nothing Then Item.SubItems(6) = left$(TempData, InStr(TempData, Chr$(0)) - 1) Else VI.FileAssociation = DetermineFilename(left$(TempData, InStr(TempData, Chr$(0)) - 1))
    Else
        VI.FileAssociation = ""
        If Not Item Is Nothing Then Item.SubItems(6) = ""
    End If
End Function

Public Function FileInformation(FileToCheck As String, VI As VerInfo) As Boolean
If Len(FileToCheck) = 0 Then
    Exit Function
End If

Dim rc              As Long
Dim lDummy          As Long
Dim sBuffer()       As Byte
Dim lBufferLen      As Long
Dim lVerPointer     As Long
Dim udtVerBuffer    As VS_FIXEDFILEINFO
Dim lVerBufferLen   As Long
Dim Translation     As String
Dim vBuffer()       As Byte
Dim lTranslation    As Long
Dim strValue        As String
    
    ' Reset Version info
    VI.FileVersion = ""
    VI.FileDescription = ""
    VI.FileFlags = ""
    VI.FileOS = ""
    VI.FileType = ""
    VI.FileSubType = ""
    VI.CompanyName = ""
    VI.Language = ""
    VI.OriginalFileName = ""
    VI.InternalName = ""
    VI.Comments = ""
    VI.LegalCopyright = ""
    VI.LegalTrademarks = ""
    VI.ProductName = ""
    VI.ProductVersion = ""
    VI.SpecialBuild = ""
    VI.PrivateBuild = ""
   
    lBufferLen = GetFileVersionInfoSize(FileToCheck, lDummy)
    If lBufferLen < 1 Then
        VI.FileType = DetermineFileExt(FileToCheck)
        FileInformation = False
        Exit Function
    End If
    
    '**** Store info to udtVerBuffer struct ****
    ReDim sBuffer(lBufferLen)
    rc = GetFileVersionInfo(FileToCheck, 0&, lBufferLen, sBuffer(0))
    rc = VerQueryValue(sBuffer(0), "\", lVerPointer, lVerBufferLen)
    MoveMemory udtVerBuffer, lVerPointer, Len(udtVerBuffer)
    '**** Determine Structure Version number - NOT USED ****
    StrucVer = Format$(udtVerBuffer.dwStrucVersionh) & "." & Format$(udtVerBuffer.dwStrucVersionl)
    '**** Determine File Version number ****
    VI.FileVersion = Format$(udtVerBuffer.dwFileVersionMSh) & "." & Format$(udtVerBuffer.dwFileVersionMSl) & "." & Format$(udtVerBuffer.dwFileVersionLSh) & "." & Format$(udtVerBuffer.dwFileVersionLSl)
    '**** Determine Product Version number ****
    VI.ProductVersion = Format$(udtVerBuffer.dwProductVersionMSh) & "." & Format$(udtVerBuffer.dwProductVersionMSl) & "." & Format$(udtVerBuffer.dwProductVersionLSh) & "." & Format$(udtVerBuffer.dwProductVersionLSl)
    '**** Determine Boolean attributes of File ****   FileFlags = ""
    If udtVerBuffer.dwFileFlags And VS_FF_DEBUG Then VI.FileFlags = "Debug "
    If udtVerBuffer.dwFileFlags And VS_FF_PRERELEASE Then VI.FileFlags = VI.FileFlags & "PreRel "
    If udtVerBuffer.dwFileFlags And VS_FF_PATCHED Then VI.FileFlags = VI.FileFlags & "Patched "
    If udtVerBuffer.dwFileFlags And VS_FF_PRIVATEBUILD Then VI.FileFlags = VI.FileFlags & "Private "
    If udtVerBuffer.dwFileFlags And VS_FF_INFOINFERRED Then VI.FileFlags = VI.FileFlags & "Info "
    If udtVerBuffer.dwFileFlags And VS_FF_SPECIALBUILD Then VI.FileFlags = VI.FileFlags & "Special "
    If udtVerBuffer.dwFileFlags And VFT2_UNKNOWN Then VI.FileFlags = VI.FileFlags + "Unknown "
    '**** Determine OS for which file was designed ****
    Select Case udtVerBuffer.dwFileOS
        Case VOS_WINDOWS16
            VI.FileOS = "16-bit Windows"
        Case VOS_WINDOWS32
            VI.FileOS = "32-bit Windows (Win32)"
        Case VOS_DOS_WINDOWS16
            VI.FileOS = "DOS + Win16"
        Case VOS_DOS_WINDOWS32
            VI.FileOS = "DOS + Win32"
        Case VOS_OS216_PM16
            VI.FileOS = "OS/2-16 + PM-16"
        Case VOS_OS232_PM32
            VI.FileOS = "OS/2-32 + PM-32"
        Case VOS_NT_WINDOWS32
            VI.FileOS = "NT/Win32"
        Case Else
            VI.FileOS = "Unknown"
    End Select
    Select Case udtVerBuffer.dwFileType
        Case VFT_APP
            VI.FileType = "Application"
        Case VFT_DLL
            VI.FileType = "Application Extension (DLL)"
        Case VFT_DRV
            VI.FileType = "Driver"
            Select Case udtVerBuffer.dwFileSubtype
                Case VFT2_DRV_PRINTER
                    VI.FileSubType = "Printer Driver"
                Case VFT2_DRV_KEYBOARD
                    VI.FileSubType = "Keyboard Driver"
                Case VFT2_DRV_LANGUAGE
                    VI.FileSubType = "Language Driver"
                Case VFT2_DRV_DISPLAY
                    VI.FileSubType = "Display Driver"
                Case VFT2_DRV_MOUSE
                    VI.FileSubType = "Mouse Driver"
                Case VFT2_DRV_NETWORK
                    VI.FileSubType = "Network Driver"
                Case VFT2_DRV_SYSTEM
                    VI.FileSubType = "System Driver"
                Case VFT2_DRV_INSTALLABLE
                    VI.FileSubType = "Installable"
                Case VFT2_DRV_SOUND
                    VI.FileSubType = "Sound Driver"
                Case VFT2_DRV_COMM
                    VI.FileSubType = "Comm Driver"
                Case VFT2_UNKNOWN
                    VI.FileSubType = "Unknown"
            End Select
        Case VFT_FONT
            VI.FileType = "Font"
            Select Case udtVerBuffer.dwFileSubtype
                Case VFT2_FONT_RASTER
                    VI.FileSubType = "Raster Font"
                Case VFT2_FONT_VECTOR
                    VI.FileSubType = "Vector Font"
                Case VFT2_FONT_TRUETYPE
                    VI.FileSubType = "TrueType Font"
            End Select
        Case VFT_VXD
            VI.FileType = "VxD"
        Case VFT_STATIC_LIB
            VI.FileType = "Lib"
        Case Else
            VI.FileType = "Unknown"
    End Select

    ' get variable string values
    ReDim vBuffer(lBufferLen)
    rc = VerQueryValue(sBuffer(0), "\VarFileInfo\Translation", lVerPointer, lVerBufferLen) ' Get translation info
    If lVerBufferLen >= 4 Then ' Looks like we've got a valid translation info
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        Translation = toHex(vBuffer()) ' trim the trailing null, and convert to hex
    Else ' apparently the Translation info is not there, let's try guessing ...
        Translation = "040904B0" ' guess it's U.S. English/Charset 1252 (Windows Multilingual)
        rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\CompanyName", lVerPointer, lVerBufferLen)
        If rc = 0 Then  ' try another guess
            Translation = "040904E4" ' guess it's U.S. English/Charset 1252 (Windows Multilingual)
            rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\CompanyName", lVerPointer, lVerBufferLen)
            If rc = 0 Then Exit Function ' No Joy
        End If
    End If

    lTranslation = Val("&h" & left$(Translation, 4))
    
    strValue = String$(65, Chr$(0))
    rc = VerLanguageName(lTranslation, strValue, 64)
    If rc Then
        VI.Language = left$(strValue, InStr(strValue, Chr$(0)) - 1)
    End If
    
    'rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\FileVersion", lVerPointer, lVerBufferLen)
    'If rc = 1 Then
        'MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        'VI.FileVersion = toString(vBuffer())
    'End If
      
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\FileDescription", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.FileDescription = toString(vBuffer())
    End If
    
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\CompanyName", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.CompanyName = toString(vBuffer())
       End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\OriginalFileName", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.OriginalFileName = toString(vBuffer())
    End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\InternalName", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.InternalName = toString(vBuffer())
    End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\Comments", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.Comments = toString(vBuffer())
    End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\LegalCopyright", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.LegalCopyright = toString(vBuffer())
    End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\LegalTrademarks", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.LegalTrademarks = toString(vBuffer())
    End If
    
    ' Retrieve Product information
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\ProductName", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.ProductName = toString(vBuffer())
    End If
    'rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\ProductVersion", lVerPointer, lVerBufferLen)
    'If rc = 1 Then
        'MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        'VI.ProductVersion = toString(vBuffer())
    'End If

    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\SpecialBuild", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.SpecialBuild = toString(vBuffer())
    End If
    rc = VerQueryValue(sBuffer(0), "\StringFileInfo\" & Translation & "\PrivateBuild", lVerPointer, lVerBufferLen)
    If rc = 1 Then
        MoveMemory vBuffer(0), lVerPointer, lVerBufferLen
        VI.PrivateBuild = toString(vBuffer())
    End If

    FileInformation = True
WriteMyError:
End Function

Public Function GetDirectoryList(ThePath As String) As String
'This code tends to be very very close when it comes across a directory with lots of files to list.
'When trying to list my C:\WinNT\System32 directory on my computer it took nearly 10 seconds!  :(
'If anyone has a faster routine to do this please tell me! =)
Dim hFile       As Long
Dim r           As Long
Dim fname       As String
Dim WFD32       As WIN32_FIND_DATA
Dim dirList     As String
Dim Permissions As String

'Get the first file in the directory (it will usually return ".")
hFile = FindFirstFile(ThePath & "*.*" + Chr$(0), WFD32)
'If nothing returned, bail out.
If hFile < 0 Then
    GetDirectoryList = "550 " & ThePath & ": No such file or directory."
    Exit Function
End If
If left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) <> "." And left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) <> ".." Then
    If (WFD32.dwFilechkattrib And vbDirectory) Then
        Permissions = "drwx------"
    Else
        Permissions = "-rwx------"
    End If
    dirList = Permissions & " 1 user group " & WFD32.nFileSizeLow _
        & get_date(WFD32.ftLastWriteTime) _
        & left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) & vbCrLf
End If
While FindNextFile(hFile, WFD32)
    If left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) <> "." And left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) <> ".." Then
        If (WFD32.dwFilechkattrib And vbDirectory) Then
            Permissions = "drwx------"
        Else
            Permissions = "-rwx------"
        End If
        dirList = dirList & Permissions & " 1 user group " & WFD32.nFileSizeLow _
            & get_date(WFD32.ftLastWriteTime) _
            & left$(WFD32.cFileName, InStr(WFD32.cFileName, vbNullChar) - 1) & vbCrLf
    End If
    DoEvents
Wend
'Close the search handle
r = FindClose(hFile)
GetDirectoryList = dirList
'''Debug.Print dirList
End Function

Private Function get_date(FT As FILETIME) As String

    'convert the FILETIME (FT) to a SYSTEMTIME (ST) type
    Dim ST As SYSTEMTIME
    Dim r As Long
    Dim ds As String
    
    r = FileTimeToSystemTime(FT, ST)

    ds = DateSerial(ST.wYear, ST.wMonth, ST.wDay)

    If DateDiff("d", ds, Date) > 365 Then
        get_date = Format$(ds, " mmm dd yyyy ") & " "
    Else
        get_date = Format$(ds & " " & ST.wHour & ":" & ST.wMinute, " mmm dd hh:mm ")
    End If

End Function

Private Function FindFile(sFileName As String) As WIN32_FIND_DATA
    Dim Win32Data As WIN32_FIND_DATA
    Dim plngFirstFileHwnd As Long
    Dim plngRtn As Long
    
    ' Find file and get file data
    plngFirstFileHwnd = FindFirstFile(sFileName, Win32Data)
    If plngFirstFileHwnd = 0 Then
        FindFile.cFileName = "Error"
    Else
        FindFile = Win32Data
    End If
    plngRtn = FindClose(plngFirstFileHwnd)
End Function

Private Function FormatSize(ByVal Amount As Long) As String
    '** Description:
    '** Format file size
    Dim Buffer As String
    Dim Result As String
    
    Buffer = Space$(255) 'Fill buffer
    Result = StrFormatByteSize(Amount, Buffer, Len(Buffer)) 'Format file size
    If InStr(Result, vbNullChar) > 1 Then
        FormatSize = left$(Result, InStr(Result, vbNullChar) - 1)
    End If
End Function

Public Function ReadHeader(ByVal Filename As String, VI As VerInfo)
    On Error GoTo ErrHand
    
    Dim ByteArray(4) As Byte
    Dim XingH As String * 4
    Dim FIO As Long
    Dim i As Long
    Dim Z As Long
    Dim X As Byte
    Dim HeadStart As Long
    Dim Frames As Long
    Dim Bin As String
    Dim temp As Variant
    Dim Brate As Variant
    Dim Freq As Variant
         
    'tables
    Dim VersionLayer(3) As String
    VersionLayer(0) = 0
    VersionLayer(1) = 3
    VersionLayer(2) = 2
    VersionLayer(3) = 1
    
    Dim SMode(3) As String
    SMode(0) = "stereo"
    SMode(1) = "joint stereo"
    SMode(2) = "dual channel"
    SMode(3) = "single channel"
    
    
    FIO = FreeFile
    
    'read the header
    Open Filename For Binary Access Read As FIO
        If LOF(FIO) < 256 Then
            Close FIO
            Exit Function
        End If
        
        '''''start check startposition for header''''''''''''
        '''''if start position <>1 then id3v2 tag exists'''''
        For i = 1 To LOF(FIO)           'check the whole file for the header
            Get #FIO, i, X
            If X = 255 Then             'header always start with 255 followed by 250 or 251
                Get #FIO, i + 1, X
                If X > 249 And X < 252 Then
                    HeadStart = i       'set header start position
                    Exit For
                End If
            End If
        Next i
        
        'no header start position was found
        If HeadStart = 0 Then
            Exit Function
        End If
        '''end check start position for header'''''''''''''
    
        ''start check for XingHeader'''
        Get #FIO, HeadStart + 36, XingH
        If XingH = "Xing" Then
            VI.Mp3Data.VBR = True
            For Z = 1 To 4 '
                Get #1, HeadStart + 43 + Z, ByteArray(Z)  'get framelength to array
            Next Z
            Frames = BinToDec(ByteToBit(ByteArray))   'calculate # of frames
        Else
            VI.Mp3Data.VBR = False
        End If
        '''end check for XingHeader
    
        '''start extract the first 4 bytes (32 bits) to an array
        For Z = 1 To 4 '
            Get #FIO, HeadStart + Z - 1, ByteArray(Z)
        Next Z
        '''stop extract the first 4 bytes (32 bits) to an array
    Close FIO
    
    'header string
    Bin = ByteToBit(ByteArray)
    
    
    'get mpegversion from table
    VI.Mp3Data.MpegVersion = VersionLayer(BinToDec(Mid(Bin, 12, 2)))
    'get layer from table
    VI.Mp3Data.MpegLayer = VersionLayer(BinToDec(Mid(Bin, 14, 2)))
    'get mode from table
    VI.Mp3Data.Mode = SMode(BinToDec(Mid(Bin, 25, 2)))
    
    'look for version to create right table
    Select Case VI.Mp3Data.MpegVersion
        Case 1
            'for version 1
            Freq = Array(44100, 48000, 32000)
        Case 2 Or 25
            'for version 2 or 2.5
            Freq = Array(22050, 24000, 16000)
        Case Else
            VI.Mp3Data.Frequency = 0
            Exit Function
    End Select
    
    'look for frequency in table
    VI.Mp3Data.Frequency = Freq(BinToDec(Mid(Bin, 21, 2)))
    
    If VI.Mp3Data.VBR = True Then
        'define to calculate correct bitrate
        temp = Array(, 12, 144, 144)
        VI.Mp3Data.BitRate = (FileLen(Filename) * VI.Mp3Data.Frequency) / (Int(Frames)) / 1000 / temp(VI.Mp3Data.MpegLayer)
    Else
        'look for the right bitrate table
        Select Case Val(VI.Mp3Data.MpegVersion & VI.Mp3Data.MpegLayer)
            Case 11
                'Version 1, Layer 1
                Brate = Array(0, 32, 64, 96, 128, 160, 192, 224, 256, 288, 320, 352, 384, 416, 448)
            Case 12
                'V1 L1
                Brate = Array(0, 32, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, 384)
            Case 13
                'V1 L3
                Brate = Array(0, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320)
            Case 21 Or 251
                'V2 L1 and 'V2.5 L1
                Brate = Array(0, 32, 48, 56, 64, 80, 96, 112, 128, 144, 160, 176, 192, 224, 256)
            Case 22 Or 252 Or 23 Or 253
                'V2 L2 and 'V2.5 L2 etc...
                Brate = Array(0, 8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128, 144, 160)
            Case Else
                'if variable bitrate
                VI.Mp3Data.BitRate = 1
            Exit Function
        End Select
        
        VI.Mp3Data.BitRate = Brate(BinToDec(Mid(Bin, 17, 4)))
    End If
    
    'if there is a decimal place, then parse it off
    If InStr(1, VI.Mp3Data.BitRate, ".") Then
        VI.Mp3Data.BitRate = left(VI.Mp3Data.BitRate, InStr(1, VI.Mp3Data.BitRate, ".") - 1)
    End If
    
    'calculate duration
    VI.Mp3Data.Duration = Int((FileLen(Filename) * 8) / VI.Mp3Data.BitRate / 1000)
    VI.Mp3Data.Duration = VI.Mp3Data.Duration \ 60 & "m " & VI.Mp3Data.Duration - (VI.Mp3Data.Duration \ 60) * 60 & "s"
    
    
    Exit Function
    
ErrHand:
    Close FIO
End Function

Private Function BinToDec(BinValue As String) As Long
    On Error GoTo ErrHand
    
    Dim i As Long
    BinToDec = 0
    For i = 1 To Len(BinValue)
        If Mid(BinValue, i, 1) = 1 Then
            BinToDec = BinToDec + 2 ^ (Len(BinValue) - i)
        End If
    Next i
    
    Exit Function
    
ErrHand:
End Function

Private Function ByteToBit(ByteArray) As String
    On Error GoTo ErrHand

    Dim Z As Integer
    Dim i As Integer
    'convert 4*1 byte array to 4*8 bits'''''
    ByteToBit = ""
    For Z = 1 To 4
        For i = 7 To 0 Step -1
            If Int(ByteArray(Z) / (2 ^ i)) = 1 Then
                ByteToBit = ByteToBit & "1"
                ByteArray(Z) = ByteArray(Z) - (2 ^ i)
            ElseIf ByteToBit <> "" Then
                ByteToBit = ByteToBit & "0"
            End If
        Next
    Next Z
    
    Exit Function
    
ErrHand:
End Function

Private Function GetGenreFromID(ByVal strListGenre As Integer) As String
    On Error GoTo ErrHand
    
    If strListGenre = 0 Then
        GetGenreFromID = "Blues"
    ElseIf strListGenre = 1 Then
        GetGenreFromID = "Classic Rock"
    ElseIf strListGenre = 2 Then
        GetGenreFromID = "Country"
    ElseIf strListGenre = 3 Then
        GetGenreFromID = "Dance"
    ElseIf strListGenre = 4 Then
        GetGenreFromID = "Disco"
    ElseIf strListGenre = 5 Then
        GetGenreFromID = "Funk"
    ElseIf strListGenre = 6 Then
        GetGenreFromID = "Grunge"
    ElseIf strListGenre = 7 Then
        GetGenreFromID = "Hip-Hop"
    ElseIf strListGenre = 8 Then
        GetGenreFromID = "Jazz"
    ElseIf strListGenre = 9 Then
        GetGenreFromID = "Metal"
    ElseIf strListGenre = 10 Then
        GetGenreFromID = "New Age"
    ElseIf strListGenre = 11 Then
        GetGenreFromID = "Oldies"
    ElseIf strListGenre = 12 Then
        GetGenreFromID = "Other"
    ElseIf strListGenre = 13 Then
        GetGenreFromID = "Pop"
    ElseIf strListGenre = 14 Then
        GetGenreFromID = "R&B"
    ElseIf strListGenre = 15 Then
        GetGenreFromID = "Rap"
    ElseIf strListGenre = 16 Then
        GetGenreFromID = "Reggae"
    ElseIf strListGenre = 17 Then
        GetGenreFromID = "Rock"
    ElseIf strListGenre = 18 Then
        GetGenreFromID = "Techno"
    ElseIf strListGenre = 19 Then
        GetGenreFromID = "Industrial"
    ElseIf strListGenre = 20 Then
        GetGenreFromID = "Alternative"
    ElseIf strListGenre = 21 Then
        GetGenreFromID = "Ska"
    ElseIf strListGenre = 22 Then
        GetGenreFromID = "Death Metal"
    ElseIf strListGenre = 23 Then
        GetGenreFromID = "Pranks"
    ElseIf strListGenre = 24 Then
        GetGenreFromID = "Soundtrack"
    ElseIf strListGenre = 25 Then
        GetGenreFromID = "Euro-Techno"
    ElseIf strListGenre = 26 Then
        GetGenreFromID = "Ambient"
    ElseIf strListGenre = 27 Then
        GetGenreFromID = "Trip-Hop"
    ElseIf strListGenre = 28 Then
        GetGenreFromID = "Vocal"
    ElseIf strListGenre = 29 Then
        GetGenreFromID = "Jazz+Funk"
    ElseIf strListGenre = 30 Then
        GetGenreFromID = "Fusion"
    ElseIf strListGenre = 31 Then
        GetGenreFromID = "Trance"
    ElseIf strListGenre = 32 Then
        GetGenreFromID = "Classical"
    ElseIf strListGenre = 33 Then
        GetGenreFromID = "Instrumental"
    ElseIf strListGenre = 34 Then
        GetGenreFromID = "Acid"
    ElseIf strListGenre = 35 Then
        GetGenreFromID = "House"
    ElseIf strListGenre = 36 Then
        GetGenreFromID = "Game"
    ElseIf strListGenre = 37 Then
        GetGenreFromID = "Sound Clip"
    ElseIf strListGenre = 38 Then
        GetGenreFromID = "Gospel"
    ElseIf strListGenre = 39 Then
        GetGenreFromID = "Noise"
    ElseIf strListGenre = 40 Then
        GetGenreFromID = "AlternRock"
    ElseIf strListGenre = 41 Then
        GetGenreFromID = "Bass"
    ElseIf strListGenre = 42 Then
        GetGenreFromID = "Soul"
    ElseIf strListGenre = 43 Then
        GetGenreFromID = "Punk"
    ElseIf strListGenre = 44 Then
        GetGenreFromID = "Space"
    ElseIf strListGenre = 45 Then
        GetGenreFromID = "Meditative"
    ElseIf strListGenre = 46 Then
        GetGenreFromID = "Instrumental Pop"
    ElseIf strListGenre = 47 Then
        GetGenreFromID = "Instrumental Rock"
    ElseIf strListGenre = 48 Then
        GetGenreFromID = "Ethnic"
    ElseIf strListGenre = 49 Then
        GetGenreFromID = "Gothic"
    ElseIf strListGenre = 50 Then
        GetGenreFromID = "Darkwave"
    ElseIf strListGenre = 51 Then
        GetGenreFromID = "Techno-Indistrial"
    ElseIf strListGenre = 52 Then
        GetGenreFromID = "Electronic"
    ElseIf strListGenre = 53 Then
        GetGenreFromID = "Pop-Folk"
    ElseIf strListGenre = 54 Then
        GetGenreFromID = "Eurodance"
    ElseIf strListGenre = 55 Then
        GetGenreFromID = "Dream"
    ElseIf strListGenre = 56 Then
        GetGenreFromID = "Southern Rock"
    ElseIf strListGenre = 57 Then
        GetGenreFromID = "Comedy"
    ElseIf strListGenre = 58 Then
        GetGenreFromID = "Cult"
    ElseIf strListGenre = 59 Then
        GetGenreFromID = "Gansta"
    ElseIf strListGenre = 60 Then
        GetGenreFromID = "Top 40"
    ElseIf strListGenre = 61 Then
        GetGenreFromID = "Christian Rap"
    ElseIf strListGenre = 62 Then
        GetGenreFromID = "Pop/Funk"
    ElseIf strListGenre = 63 Then
        GetGenreFromID = "Jungle"
    ElseIf strListGenre = 64 Then
        GetGenreFromID = "Native American"
    ElseIf strListGenre = 65 Then
        GetGenreFromID = "Cabaret"
    ElseIf strListGenre = 66 Then
        GetGenreFromID = "New Wave"
    ElseIf strListGenre = 67 Then
        GetGenreFromID = "Psychaledic"
    ElseIf strListGenre = 68 Then
        GetGenreFromID = "Rave"
    ElseIf strListGenre = 69 Then
        GetGenreFromID = "Showtunes"
    ElseIf strListGenre = 70 Then
        GetGenreFromID = "Trailer"
    ElseIf strListGenre = 71 Then
        GetGenreFromID = "Lo-Fi"
    ElseIf strListGenre = 72 Then
        GetGenreFromID = "Tribal"
    ElseIf strListGenre = 73 Then
        GetGenreFromID = "Acid Punk"
    ElseIf strListGenre = 74 Then
        GetGenreFromID = "Acid Jazz"
    ElseIf strListGenre = 75 Then
        GetGenreFromID = "Polka"
    ElseIf strListGenre = 76 Then
        GetGenreFromID = "Retro"
    ElseIf strListGenre = 77 Then
        GetGenreFromID = "Musical"
    ElseIf strListGenre = 78 Then
        GetGenreFromID = "Rock & Roll"
    ElseIf strListGenre = 79 Then
        GetGenreFromID = "Hard Rock"
    ElseIf strListGenre = 80 Then
        GetGenreFromID = "Folk"
    ElseIf strListGenre = 81 Then
        GetGenreFromID = "Folk-Rock"
    ElseIf strListGenre = 82 Then
        GetGenreFromID = "National Folk"
    ElseIf strListGenre = 83 Then
        GetGenreFromID = "Swing"
    ElseIf strListGenre = 84 Then
        GetGenreFromID = "Fast Fusion"
    ElseIf strListGenre = 85 Then
        GetGenreFromID = "Bebop"
    ElseIf strListGenre = 86 Then
        GetGenreFromID = "Latin"
    ElseIf strListGenre = 87 Then
        GetGenreFromID = "Revival"
    ElseIf strListGenre = 88 Then
        GetGenreFromID = "Celtic"
    ElseIf strListGenre = 89 Then
        GetGenreFromID = "Bluegrass"
    ElseIf strListGenre = 90 Then
        GetGenreFromID = "Avantgarde"
    ElseIf strListGenre = 91 Then
        GetGenreFromID = "Gothic Rock"
    ElseIf strListGenre = 92 Then
        GetGenreFromID = "Progressive Rock"
    ElseIf strListGenre = 93 Then
        GetGenreFromID = "Psychadelic Rock"
    ElseIf strListGenre = 94 Then
        GetGenreFromID = "Symphonic Rock"
    ElseIf strListGenre = 95 Then
        GetGenreFromID = "Slow Rock"
    ElseIf strListGenre = 96 Then
        GetGenreFromID = "Big Band"
    ElseIf strListGenre = 97 Then
        GetGenreFromID = "Chorus"
    ElseIf strListGenre = 98 Then
        GetGenreFromID = "Easy Listening"
    ElseIf strListGenre = 99 Then
        GetGenreFromID = "Acoustic"
    ElseIf strListGenre = 100 Then
        GetGenreFromID = "Humour"
    ElseIf strListGenre = 101 Then
        GetGenreFromID = "Speech"
    ElseIf strListGenre = 102 Then
        GetGenreFromID = "Chanson"
    ElseIf strListGenre = 103 Then
        GetGenreFromID = "Opera"
    ElseIf strListGenre = 104 Then
        GetGenreFromID = "Chamber Music"
    ElseIf strListGenre = 105 Then
        GetGenreFromID = "Sonata"
    ElseIf strListGenre = 106 Then
        GetGenreFromID = "Symphony"
    ElseIf strListGenre = 107 Then
        GetGenreFromID = "Booty Bass"
    ElseIf strListGenre = 108 Then
        GetGenreFromID = "Primus"
    ElseIf strListGenre = 109 Then
        GetGenreFromID = "Porn Groove"
    ElseIf strListGenre = 110 Then
        GetGenreFromID = "Satire"
    ElseIf strListGenre = 111 Then
        GetGenreFromID = "Slow Jam"
    ElseIf strListGenre = 112 Then
        GetGenreFromID = "Club"
    ElseIf strListGenre = 113 Then
        GetGenreFromID = "Tango"
    ElseIf strListGenre = 114 Then
        GetGenreFromID = "Samba"
    ElseIf strListGenre = 115 Then
        GetGenreFromID = "Folklore"
    ElseIf strListGenre = 116 Then
        GetGenreFromID = "Ballad"
    ElseIf strListGenre = 117 Then
        GetGenreFromID = "Power Ballad"
    ElseIf strListGenre = 118 Then
        GetGenreFromID = "Rhythmic Soul"
    ElseIf strListGenre = 119 Then
        GetGenreFromID = "Freestyle"
    ElseIf strListGenre = 120 Then
        GetGenreFromID = "Duet"
    ElseIf strListGenre = 121 Then
        GetGenreFromID = "Punk Rock"
    ElseIf strListGenre = 122 Then
        GetGenreFromID = "Drum Solo"
    ElseIf strListGenre = 123 Then
        GetGenreFromID = "A Capella"
    ElseIf strListGenre = 124 Then
        GetGenreFromID = "Euro-House"
    ElseIf strListGenre = 125 Then
        GetGenreFromID = "Dance Hall"
    ElseIf strListGenre > 125 Then
        GetGenreFromID = ""
    End If
    
    Exit Function
    
ErrHand:
End Function

Public Function CheckFileORdir(PathORfile As String, Optional isDir As Boolean, Optional isCreateDir As Boolean) As Boolean
Dim i           As Long
Dim TempData    As String
Dim WFD32       As WIN32_FIND_DATA
Dim DontWrite   As Boolean

    PathORfile = Replace(PathORfile, vbCrLf, "")
    'MsgBox PathORfile
    If Trim(PathORfile) = "" Or PathORfile = "\" Then
        CheckFileORdir = False
    Else
        If isDir = True Then '<<<<to check the existance of directory
            TempData = PathORfile
            If Len(TempData) > 0 Then
                If right(TempData, 1) <> "\" Then
                    TempData = TempData & "\" & "*.*" + Chr$(0)
                Else
                    TempData = TempData & "*.*" + Chr$(0)
                End If
            End If
27          i = FindFirstFile(TempData, WFD32)
            TempData = ""
            If i > 0 Then
                CheckFileORdir = True
            Else
                If isCreateDir = True Then
37                  MkDir PathORfile
                    CheckFileORdir = True
                End If
            End If
        Else '<<<<the file
47          i = FindFirstFile(PathORfile + Chr$(0), WFD32)
            If i > 0 Then
                If (WFD32.dwFilechkattrib And vbDirectory) Then
                    CheckFileORdir = False: DontWrite = True
                Else
                    CheckFileORdir = True
                End If
            End If
        End If
    End If
    If CheckFileORdir = False And Len(PathORfile) > 0 And DontWrite = False Then
        If App.Path & "\RAZIS.txt" <> PathORfile Then
            i = FreeFile
50          Open App.Path & "\RAZIS.txt" For Append As #i
                If isDir = True Then
                    TempData = "Missing Directory =" & PathORfile
                Else
                    TempData = "Missing File =" & PathORfile
                End If
60              Print #i, TempData
70          Close #i
        End If
    End If
Exit Function
WriteMyError:
    CheckFileORdir = False
End Function


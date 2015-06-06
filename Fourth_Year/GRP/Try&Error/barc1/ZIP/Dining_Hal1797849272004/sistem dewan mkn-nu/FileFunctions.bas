Attribute VB_Name = "Module1"
Option Explicit
Private Const FILE_ATTRIBUTE_ARCHIVE = &H20
Private Const FILE_ATTRIBUTE_DIRECTORY = &H10
Private Const FILE_ATTRIBUTE_HIDDEN = &H2
Private Const FILE_ATTRIBUTE_READONLY = &H1
Private Const FILE_ATTRIBUTE_SYSTEM = &H4
Private Const INVALID_HANDLE_VALUE = -1
Private Const MAX_PATH = 260

Private Type FILETIME
    dwLowDateTime As Long
    dwHighDateTime As Long
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

Private Type WIN32_FIND_DATA
    dwFileAttributes As Long
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

Private Declare Function FindClose Lib "kernel32" _
   (ByVal hFindFile As Long) As Long

Private Declare Function FindFirstFile Lib "kernel32" _
  Alias "FindFirstFileA" (ByVal lpFileName As String, _
 lpFindFileData As WIN32_FIND_DATA) As Long

Private Declare Function FileTimeToSystemTime Lib "kernel32" _
  (lpFileTime As FILETIME, lpSystemTime As SYSTEMTIME) As Long

Private Declare Function GetFileAttributes Lib "kernel32" _
  Alias "GetFileAttributesA" (ByVal lpFileName As String) As Long

Private Declare Function GetShortPathName Lib "kernel32" _
  Alias "GetShortPathNameA" (ByVal lpszLongPath As String, _
  ByVal lpszShortPath As String, ByVal cchBuffer As Long) _
  As Long

Private Declare Sub GetSystemTime Lib "kernel32" _
   (lpSystemTime As SYSTEMTIME)



Public Function FileAttributes(ByVal strFilename As String) _
    As String

    Dim lngFileAttributes As Long
    Dim strFileAttributeFlags As String
    If Not FileExists(strFilename) Then
        Exit Function
    End If
    lngFileAttributes = GetFileAttributes(strFilename)
    If lngFileAttributes And FILE_ATTRIBUTE_DIRECTORY Then
        strFileAttributeFlags = strFileAttributeFlags + "D"
    End If
    If lngFileAttributes And FILE_ATTRIBUTE_ARCHIVE Then
        strFileAttributeFlags = strFileAttributeFlags + "A"
    End If
    If lngFileAttributes And FILE_ATTRIBUTE_SYSTEM Then
        strFileAttributeFlags = strFileAttributeFlags + "S"
    End If
    If lngFileAttributes And FILE_ATTRIBUTE_HIDDEN Then
        strFileAttributeFlags = strFileAttributeFlags + "H"
    End If
    If lngFileAttributes And FILE_ATTRIBUTE_READONLY Then
        strFileAttributeFlags = strFileAttributeFlags + "R"
    End If
    FileAttributes = strFileAttributeFlags
End Function

Public Function FileCreated(ByVal strFilename As String) As Date
    Dim datFileCreationDate As Date
    Dim lngFileHandle As Long
    Dim udtSystemTime As SYSTEMTIME
    Dim udtWinFindData As WIN32_FIND_DATA
    If Not FileExists(strFilename) Then
        Exit Function
    End If
    lngFileHandle = FindFirstFile(strFilename, udtWinFindData)
    Call FileTimeToSystemTime(udtWinFindData.ftCreationTime, udtSystemTime)
    datFileCreationDate = DateSerial(udtSystemTime.wYear, udtSystemTime.wMonth, udtSystemTime.wDay) + TimeSerial(udtSystemTime.wHour + AdjustTimeForLocalSettings, udtSystemTime.wMinute, udtSystemTime.wSecond)
    FileCreated = datFileCreationDate
    Call FindClose(lngFileHandle)
End Function
Public Function FileExists(ByVal strFilename As String) As Boolean
    Dim lngFileHandle As Long
    Dim udtWinFindData As WIN32_FIND_DATA
    If ((Len(strFilename) > 3) And (Right$(strFilename, 1) = "\")) Then
        strFilename = Left$(strFilename, Len(strFilename) - 1)
    End If
    lngFileHandle = FindFirstFile(strFilename, udtWinFindData)
    FileExists = lngFileHandle <> INVALID_HANDLE_VALUE
    Call FindClose(lngFileHandle)
End Function
Public Function FileLastAccessed(ByVal strFilename As String) As Date
    Dim datFileCreationDate As Date
    Dim lngFileHandle As Long
    Dim udtSystemTime As SYSTEMTIME
    Dim udtWinFindData As WIN32_FIND_DATA
    If Not FileExists(strFilename) Then
        Exit Function
    End If
    lngFileHandle = FindFirstFile(strFilename, udtWinFindData)
    Call FileTimeToSystemTime(udtWinFindData.ftLastAccessTime, udtSystemTime)
    datFileCreationDate = DateSerial(udtSystemTime.wYear, udtSystemTime.wMonth, udtSystemTime.wDay) + TimeSerial(udtSystemTime.wHour + AdjustTimeForLocalSettings, udtSystemTime.wMinute, udtSystemTime.wSecond)
    FileLastAccessed = datFileCreationDate
    Call FindClose(lngFileHandle)
End Function
Public Function FileLastModified(ByVal strFilename As String) As Date
    Dim datFileCreationDate As Date
    Dim lngFileHandle As Long
    Dim udtSystemTime As SYSTEMTIME
    Dim udtWinFindData As WIN32_FIND_DATA
    If Not FileExists(strFilename) Then
        Exit Function
    End If
    lngFileHandle = FindFirstFile(strFilename, udtWinFindData)
    Call FileTimeToSystemTime(udtWinFindData.ftLastWriteTime, udtSystemTime)
    datFileCreationDate = DateSerial(udtSystemTime.wYear, udtSystemTime.wMonth, udtSystemTime.wDay) + TimeSerial(udtSystemTime.wHour + AdjustTimeForLocalSettings, udtSystemTime.wMinute, udtSystemTime.wSecond)
    FileLastModified = datFileCreationDate
    Call FindClose(lngFileHandle)
End Function
Public Function ReadFromFile(ByVal strFilename As String) As String
    Dim lngFileHandle As Long
    Dim strFileContents As String
    If FileExists(strFilename) Then
        If Not InStr(FileAttributes(strFilename), "D") Then
            lngFileHandle = FreeFile
            Open strFilename For Binary As #lngFileHandle
            strFileContents = Space(FileLen(strFilename))
            Get #lngFileHandle, , strFileContents
            Close #lngFileHandle
        End If
    End If
    ReadFromFile = strFileContents
End Function
Public Function ShortPath(ByVal strFilename As String) As String
    Dim strBuffer As String * 255
    Dim lngReturnCode As Long
    lngReturnCode = GetShortPathName(strFilename, strBuffer, 255)
    ShortPath = Left$(strBuffer, lngReturnCode)
End Function

Private Function AdjustTimeForLocalSettings() As Long
    Dim datSystemDate As Date
    Dim udtSystemTime As SYSTEMTIME
    Call GetSystemTime(udtSystemTime)
  
    datSystemDate = DateSerial(udtSystemTime.wYear, _
   udtSystemTime.wMonth, udtSystemTime.wDay) _
   + TimeSerial(udtSystemTime.wHour, udtSystemTime.wMinute, _
    udtSystemTime.wSecond)

    AdjustTimeForLocalSettings = _
      DateDiff("h", datSystemDate, Now)
End Function

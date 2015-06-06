Attribute VB_Name = "ini"
Declare Function WritePrivateProfileString _
Lib "kernel32" Alias "WritePrivateProfileStringA" _
(ByVal lpApplicationname As String, ByVal _
lpKeyName As Any, ByVal lsString As Any, _
ByVal lplFilename As String) As Long

Declare Function GetPrivateProfileString Lib _
"kernel32" Alias "GetPrivateProfileStringA" _
(ByVal lpApplicationname As String, ByVal _
lpKeyName As String, ByVal lpDefault As _
String, ByVal lpReturnedString As String, _
ByVal nSize As Long, ByVal lpFileName As _
String) As Long

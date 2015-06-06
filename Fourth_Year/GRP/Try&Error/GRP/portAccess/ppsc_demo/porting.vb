Module porting
    '========================================================
    'Import and Define all the entry links for inpout32.dll
    'which enables direct hardware access to your program.
    '========================================================
    Public Declare Function Inp Lib "inpout32.dll" _
    Alias "Inp32" (ByVal PortAddress As Integer) As Integer
    Public Declare Sub Out Lib "inpout32.dll" _
    Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)

    'Play wave files using winm.dll
    Public Declare Function PlaySound Lib "winmm.dll" _
    Alias "PlaySound" (ByVal lpszName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Boolean

End Module
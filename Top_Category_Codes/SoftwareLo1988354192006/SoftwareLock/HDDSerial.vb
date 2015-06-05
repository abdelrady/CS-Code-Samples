Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module HDDSerial

  Private Declare Function GetVolumeInformation Lib "Kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer

  'this function returns the specified logical drive's serial no.
  'if no drive parameter is specified it returns drive C:\'s serial.
  'u can use the function GetCurrentDrive() below to retrieve current
  'drive for the Drive parameter
  Public Function SerialNumber(Optional ByVal Drive As String = "C:\") As String
    Dim Serial As Integer              'Serialno
    Dim VName, FSName As String
    'Create buffers
    VName = New String(Chr(0), 255)    'Volume name
    FSName = New String(Chr(0), 255)   'File system

    'Get the volume information
    GetVolumeInformation(Drive, VName, 255, Serial, 0, 0, FSName, 255)
    'Strip the extra chr$(0)'s
    VName = VB.Left(VName, InStr(1, VName, Chr(0)) - 1)
    FSName = VB.Left(FSName, InStr(1, FSName, Chr(0)) - 1)
    'Return Trim(Str(Serial))
    Return Serial.ToString.Trim
  End Function

  Public Function GetCurrentDrive() As String
    GetCurrentDrive = Left(My.Computer.FileSystem.CurrentDirectory, 3)
  End Function

End Module

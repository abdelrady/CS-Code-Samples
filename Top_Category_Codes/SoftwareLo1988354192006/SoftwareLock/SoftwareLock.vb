'I'll be using Microsoft's Cryptography Class
'for encryption purposes:
Imports System.Security.Cryptography

'All registration data is stored to windows
'Registry:
Imports Microsoft.Win32

'I need UnicodeEncoding class of
'this namespace:
Imports System.Text

  Public Class SoftwareLock

  Protected _AppName As String
  Protected _Password As String
  Protected _HashAlgorithm As HashAlgorithms
  Protected _DiskSerial As String
  Protected _isRegistered As Boolean
  Protected _RegistryHive As RegistryHives
  Protected _RegistryBaseKey As String
  Protected _RegistrySubKey As String
  Protected _CustRef As String
  Protected _SerialKey As String
  Protected _CustRefLength As Integer
  Public Property RegistryHive() As RegistryHives
    Get
      Return _RegistryHive
    End Get
    Set(ByVal value As RegistryHives)
      _RegistryHive = value
    End Set
  End Property

  Public Enum HashAlgorithms
    MD5 = 0
    SHA1 = 1
    SHA256 = 2
    SHA384 = 3
    SHA512 = 4
  End Enum

  Public Enum RegistryHives
    CURRENTUSER
    LOCALMACHINE
  End Enum

  Public Sub New()
    MyBase.New()
    _DiskSerial = SerialNumber(GetCurrentDrive())
    _CustRefLength = 20
  End Sub

  Property AppName() As String
    Get
      Return _AppName
    End Get
    Set(ByVal value As String)
      _AppName = value
    End Set
  End Property

  Property Password() As String
    Get
      Return _Password
    End Get
    Set(ByVal value As String)
      _Password = value
    End Set
  End Property

  'return of set HashAlgorithm for generating
  'Reference and serialkey
  Property HashAlgorithm() As HashAlgorithms
    Get
      Return _HashAlgorithm
    End Get
    Set(ByVal value As HashAlgorithms)
      _HashAlgorithm = value
    End Set
  End Property

  'returns end-user's hard disk serial number
  ReadOnly Property HardDiskSerial() As String
    Get
      Return _DiskSerial
    End Get
  End Property

  'use this property to check if your software is registered
  ReadOnly Property isRegistered() As Boolean

    Get

      If Trim(_RegistryBaseKey) = "" Then _
        Throw New Exception("Specify a BaseRegistryKey")

      Try
        Dim objRegistry As RegistryKey
        Select Case _RegistryHive
          Case RegistryHives.CURRENTUSER
            objRegistry = Registry.CurrentUser
          Case RegistryHives.LOCALMACHINE
            objRegistry = Registry.LocalMachine
          Case Else
            objRegistry = Registry.CurrentUser
        End Select

        Dim RK As RegistryKey = objRegistry. _
          OpenSubKey("Software\" & _RegistryBaseKey)
        Dim SKey As String = RK.GetValue(_RegistrySubKey)
        If SKey = SerialKey Then
          Return True
        Else
          Return False
        End If
      Catch ex As NullReferenceException
        Return False
      End Try

    End Get

  End Property

  'Base Registry key:
  'usually your software name
  Property RegistryBaseKey() As String
    Get
      Return _RegistryBaseKey
    End Get
    Set(ByVal value As String)
      _RegistryBaseKey = value
    End Set
  End Property

  'a sub key of BaseRegistryKey to store
  'the software's serial key
  Property RegistrySubKey() As String
    Get
      Return _RegistrySubKey
    End Get
    Set(ByVal value As String)
      _RegistrySubKey = value
    End Set
  End Property

  Property ReferenceLength() As Integer
    Get
      Return _CustRefLength
    End Get
    Set(ByVal value As Integer)
      If value >= 6 And value <= 20 Then
        _CustRefLength = value
      Else
        Throw New Exception("ReferenceLength cannot be less than 6 or more than 20 characters")
      End If
    End Set
  End Property

  'use this method in your software's registration form's
  'OK button, and pass it the serial key entered by the end-user
  'as argument, returns True for a successful registration, False
  'for unsuccessful
  Function Register(ByVal strSerialKey As String) As Boolean
    GenerateCodes()

    Dim objRegistry As RegistryKey
    Select Case _RegistryHive

      Case RegistryHives.CURRENTUSER
        objRegistry = Registry.CurrentUser
      Case RegistryHives.LOCALMACHINE
        objRegistry = Registry.LocalMachine
      Case Else
        objRegistry = Registry.CurrentUser
    End Select

    If strSerialKey = _SerialKey Then
      Dim RK As RegistryKey = objRegistry. _
       OpenSubKey("Software", True)
      RK.CreateSubKey(_RegistryBaseKey). _
        SetValue(_RegistrySubKey, _SerialKey)
      Return True
    Else
      Return False
    End If
  End Function

  'returns customer reference based on appname,password,harddisk serial
  Overridable Property Reference() As String
    Get
      GenerateCodes()
      Return _CustRef
    End Get
    Set(ByVal value As String)
      If value.Length >= 6 And value.Length <= 20 Then
        _CustRef = value
      Else
        Throw New Exception("Reference cannot be less than 6 or more than 20 characters")
      End If
    End Set
  End Property

  'returns serial key based on Reference
  Overridable ReadOnly Property SerialKey() As String
    Get
      GenerateCodes()
      Return _SerialKey
    End Get
  End Property

  Public Overridable Function CancelRegistration() As Boolean
    'you can use this function for testing purposes
    'should you need to remove any test entries from
    'the windows registry where registration information is stored

    Dim objRegistry As RegistryKey
    Select Case _RegistryHive
      Case RegistryHives.CURRENTUSER
        objRegistry = Registry.CurrentUser
      Case RegistryHives.LOCALMACHINE
        objRegistry = Registry.LocalMachine
      Case Else
        objRegistry = Registry.CurrentUser
    End Select

    Dim RK As RegistryKey = objRegistry.OpenSubKey _
      ("Software", True)
    MsgBox("The followinag key and all its subkeys will be deleted:" & vbCrLf & _
      RK.ToString & "\" & _RegistryBaseKey, MsgBoxStyle.Information)
    RK.DeleteSubKeyTree(_RegistryBaseKey)

  End Function

  Protected Sub GenerateCodes()
    'generate Reference based on 
    'appname,password,and harddisk serial
    'generate serial key based on Reference
    Dim Hash As HashAlgorithm
    Dim HashBytes() As Byte
    Dim UNIEncoding As New UnicodeEncoding
    Dim temp As String

    'load the user selected hash-algorithm
    Select Case _HashAlgorithm
      Case HashAlgorithms.MD5
        Hash = New MD5CryptoServiceProvider
      Case HashAlgorithms.SHA1
        Hash = New SHA1CryptoServiceProvider
      Case HashAlgorithms.SHA256
        Hash = New SHA256Managed
      Case HashAlgorithms.SHA384
        Hash = New SHA384Managed
      Case HashAlgorithms.SHA512
        Hash = New SHA512Managed
      Case Else 'default hash algorithm
        Hash = New MD5CryptoServiceProvider
    End Select

    'generate hash using appname, password, and HD serial no.
    temp = _AppName & _Password & _DiskSerial
    HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp))

    _CustRef = Convert.ToBase64String(HashBytes)
    'if longer than 20 chars, trim it to 20 chars
    If _CustRef.Trim.Length > _CustRefLength Then _CustRef = Left(_CustRef, _CustRefLength)

    'convert it to upper case
    _CustRef = UCase(_CustRef)

    'clear the hash array
    Array.Clear(HashBytes, 0, HashBytes.Length)

    'use the above generated Reference to generate a 20 characters 
    'serial key for the end user
    temp = _CustRef & _AppName & _Password
    HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp))

    _SerialKey = Convert.ToBase64String(HashBytes)
    If _SerialKey.Trim.Length > 20 Then _SerialKey = Left(_SerialKey, 20)
    _SerialKey = UCase(_SerialKey)

  End Sub


End Class

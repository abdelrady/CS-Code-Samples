Option Explicit On

'Read/Write permissions
Private Const KEY_QUERY_VALUE As Long = &H1
Private Const KEY_SET_VALUE As Long = &H2
Private Const KEY_ALL_ACCESS As Long = &H3F
Private Const KEY_CREATE_SUB_KEY As Long = &H4
Private Const KEY_ENUMERATE_SUB_KEYS As Long = &H8
Private Const KEY_NOTIFY As Long = &H10
Private Const KEY_CREATE_LINK As Long = &H20
Private Const READ_CONTROL As Long = &H20000
Private Const WRITE_DAC As Long = &H40000
Private Const WRITE_OWNER As Long = &H80000
Private Const SYNCHRONIZE As Long = &H100000
Private Const STANDARD_RIGHTS_REQUIRED As Long = &HF0000
Private Const STANDARD_RIGHTS_READ As Long = READ_CONTROL
Private Const STANDARD_RIGHTS_WRITE As Long = READ_CONTROL
Private Const STANDARD_RIGHTS_EXECUTE As Long = READ_CONTROL
Private Const KEY_READ As Long = STANDARD_RIGHTS_READ Or KEY_QUERY_VALUE Or KEY_ENUMERATE_SUB_KEYS Or KEY_NOTIFY
Private Const KEY_WRITE As Long = STANDARD_RIGHTS_WRITE Or KEY_SET_VALUE Or KEY_CREATE_SUB_KEY
Private Const KEY_EXECUTE As Long = KEY_READ
Private Const REG_OPTION_NON_VOLATILE As Long = 0

Private Const HKEY_CLASSES_ROOT As Long = &H80000000
Private Const HKEY_CURRENT_USER As Long = &H80000001
Private Const HKEY_LOCAL_MACHINE As Long = &H80000002
Private Const HKEY_USERS As Long = &H80000003

'Registration key types
Private Const REG_NONE As Long = 0                     'No value type
Private Const REG_SZ As Long = 1                       'Unicode null terminated string
Private Const REG_EXPAND_SZ As Long = 2                'Unicode null terminated string
Private Const REG_BINARY As Long = 3                   'Free form binary
Private Const REG_DWORD As Long = 4                    '32-bit number
Private Const REG_DWORD_LITTLE_ENDIAN As Long = 4      '32-bit number (same as REG_DWORD)
Private Const REG_DWORD_BIG_ENDIAN As Long = 5         '32-bit number
Private Const REG_LINK As Long = 6                     'Symbolic Link (Unicode)
Private Const REG_MULTI_SZ As Long = 7                 'Multiple Unicode strings
Private Const REG_RESOURCE_LIST As Long = 8            'Resource list in the resource map
Private Const REG_FULL_RESOURCE_DESCRIPTOR As Long = 9 'Resource list in the hardware description
Private Const REG_RESOURCE_REQUIREMENTS_LIST As Long = 10

'Return codes from Registration functions
Private Const ERROR_SUCCESS As Long = 0
Private Const ERROR_BADDB As Long = 1
Private Const ERROR_BADKEY As Long = 2
Private Const ERROR_CANTOPEN As Long = 3
Private Const ERROR_CANTREAD As Long = 4
Private Const ERROR_CANTWRITE As Long = 5
Private Const ERROR_OUTOFMEMORY As Long = 6
Private Const ERROR_INVALID_PARAMETER As Long = 7
Private Const ERROR_ACCESS_DENIED As Long = 8
Private Const ERROR_INVALID_PARAMETERS As Long = 87
Private Const ERROR_MORE_DATA As Long = 234
Private Const ERROR_NO_MORE_ITEMS As Long = 259

Private Type SECURITY_ATTRIBUTES
   nLength                 As Long
   lpSecurityDescriptor    As Long
   bInheritHandle          As Long
End Type

Private Type GUID
   Data1 As Long
   Data2 As Integer
   Data3 As Integer
   Data4(7) As Byte
End Type

Private Declare Function RegOpenKeyEx _
    Lib "advapi32.dll" Alias "RegOpenKeyExA" _
   (ByVal hKey As Long, _
    ByVal lpSubKey As String, _
    ByVal ulOptions As Long, _
    ByVal samDesired As Long, _
ByVal phkResult As Long) As Long

Private Declare Function RegSetValueEx _
    Lib "advapi32.dll" Alias "RegSetValueExA" _
   (ByVal hKey As Long, _
    ByVal lpValueName As String, _
    ByVal Reserved As Long, _
    ByVal dwType As Long, _
ByVal lpValue As Any, _
    ByVal cbData As Long) As Long

Private Declare Function RegCloseKey Lib "advapi32.dll" _
   (ByVal hKey As Long) As Long

Private Declare Function RegCreateKeyEx Lib "advapi32" _
    Alias "RegCreateKeyExA" _
   (ByVal hKey As Long, _
    ByVal lpSubKey As String, _
    ByVal Reserved As Long, _
    ByVal lpClass As String, _
    ByVal dwOptions As Long, _
    ByVal samDesired As Long, _
    ByVal lpSecurityAttributes As Long, _
ByVal phkResult As Long, _
ByVal lpdwDisposition As Long) As Long

Private Declare Function RegQueryValueEx Lib "advapi32.dll" _
   Alias "RegQueryValueExA" _
  (ByVal hKey As Long, ByVal lpszValueName As String, _
   ByVal lpdwRes As Long, ByVal lpType As Long, _
ByVal lpData As Any, ByVal nSize As Long) As Long

Private Declare Function CoCreateGuid Lib "ole32" _
  (ByVal pGuid As GUID) As Long

Private Declare Function IsEqualGUID Lib "ole32" _
  (ByVal pGuid1 As GUID, ByVal pGuid2 As GUID) As Long

Private Declare Function StringFromGUID2 Lib "ole32" _
  (ByVal pGuid As GUID, _
   ByVal szGuid As String, _
   ByVal cchMax As Long) As Long

Private Declare Function CLSIDFromString Lib "ole32" _
  (ByVal lpszGuid As Long, _
ByVal pGuid As Any) As Long



Private Sub Form_Load()

    Option1.Caption = "Install for current user only (HKCU)"
    Option2.Caption = "Install for all users (HKLM)"
    Option1.Value = True

    Check1.Caption = "Button visible"
    Check1.Value = vbChecked

    With Picture1
        .BorderStyle = 0
        .AutoSize = True
    End With

    Text1.Text = CreateGUID()
    Text1.Locked = True
    Text2.Text = ""
    Text3.Text = ""
    Text4.Text = ""

End Sub


Private Sub Command1_Click()

    Text1.Text = CreateGUID()

End Sub


Private Sub Command2_Click()

    Dim sGuid As String
    Dim hKey As Long
    Dim dwKeyType As Long
    Dim sExtensionKey As String

    Const sRegExtensionPath As String = "Software\Microsoft\Internet Explorer\Extensions"
    Const sCLSID As String = "{1FBA04EE-3024-11d2-8F1F-0000F87ABD16}"

    'determine the registry location
    'for the settings
    If Option1.Value = True Then
        dwKeyType = HKEY_CURRENT_USER
    Else
        dwKeyType = HKEY_LOCAL_MACHINE
    End If

    'can't procede without a valid GUID
    If Len(Text1.Text) > 0 Then

        'this the const above + the GUID
        sExtensionKey = sRegExtensionPath & "\" & Text1.Text

        'optional: skip if there is already
        'an entry with the same GUID
        If RegDoesKeyExist(dwKeyType, sExtensionKey) = False Then

            'create the GUID key
            hKey = RegCreateNewKey(dwKeyType, sExtensionKey)

            If hKey <> 0 Then

                'close the key and open the
                'newly created GUID key
                RegCloseKey(hKey)
                hKey = 0
                hKey = RegKeyOpen(dwKeyType, sExtensionKey)

                If hKey <> 0 Then

                    RegWriteStringValue(hKey, "Exec", REG_SZ, Text2.Text)
                    RegWriteStringValue(hKey, "Icon", REG_SZ, Text3.Text)
                    RegWriteStringValue(hKey, "HotIcon", REG_SZ, Text3.Text)
                    RegWriteStringValue(hKey, "ButtonText", REG_SZ, Text4.Text)
                    RegWriteStringValue(hKey, "CLSID", REG_SZ, sCLSID)
                    RegWriteStringValue(hKey, "Default Visible", REG_SZ, Format$(Check1.Value, "yes/no"))

                End If  'hKey <> 0

            End If  'hKey <> 0

            RegCloseKey(hKey)

        End If  'RegDoesKeyExist

    End If  'Len(sGuid) > 0

End Sub


Private Function CreateGUID() As String

    Dim g As GUID
    Dim ret As Long
    Dim sGuid As String

    'create unique GUID
    If CoCreateGuid(g) = 0 Then

        'convert to a string
        sGuid = Space$(260)
        ret = StringFromGUID2(g, sGuid, 260)

        If ret > 0 Then

            'convert from unicode
            sGuid = StrConv(sGuid, vbFromUnicode)
            CreateGUID = Left$(sGuid, ret - 1)

        End If

    End If

End Function


Private Function RegCreateNewKey(ByVal dwKeyType As Long, _
                                 ByVal sNewKeyName As String) As Long
    Dim hKey As Long
    Dim result As Long

    Call RegCreateKeyEx(dwKeyType, _
                         sNewKeyName, 0&, _
                         vbNullString, _
                         REG_OPTION_NON_VOLATILE, _
                         KEY_ALL_ACCESS, 0&, hKey, result)


    RegCreateNewKey = hKey

End Function


Private Function RegDoesKeyExist(ByVal dwKeyType As Long, ByVal sRegPath As String) As Boolean

    Dim hKey As Long

    hKey = RegKeyOpen(dwKeyType, sRegPath)

    RegDoesKeyExist = hKey <> 0

    RegCloseKey(hKey)

End Function


Private Function RegKeyOpen(ByVal dwKeyType As Long, ByVal sKeyPath As String) As Long

    Dim hKey As Long
    Dim dwOptions As Long

    dwOptions = 0&

    If RegOpenKeyEx(dwKeyType, _
                    sKeyPath, dwOptions, _
                    KEY_ALL_ACCESS, hKey) = ERROR_SUCCESS Then

        RegKeyOpen = hKey

    End If

End Function


Private Function RegWriteStringValue(ByVal hKey, _
                                     ByVal sValue, _
                                     ByVal dwDataType, _
                                     ByVal sNewValue) As Long

    Dim success As Long
    Dim dwNewValue As Long

    dwNewValue = Len(sNewValue)

    If dwNewValue > 0 Then

      RegWriteStringValue = RegSetValueEx(hKey, _
                                          sValue, _
                                          0&, _
                                          dwDataType, _
                                          ByVal sNewValue, _
                                          dwNewValue)

    End If

End Function

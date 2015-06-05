Public Class clsNGSRegistry

	' Definiert alle möglichen Root-Schlüssel
	Public Enum ERegistryPossibleRoots
		HKEY_CLASSES_ROOT = 0
		HKEY_CURRENT_CONFIG = 1
		HKEY_CURRENT_USER = 2
		HKEY_DYNDATA = 3
		HKEY_LOCALE_MACHINE = 4
		HKEY_PERFORMANCE_DATA = 5
		HKEY_USERS = 6
	End Enum

	' Auslesen des entspr. Registry-Keys
	Private Function GetRegKey(ByVal lngRoot As ERegistryPossibleRoots) As RegistryKey
		On Error GoTo myErr

		Select Case lngRoot
			Case ERegistryPossibleRoots.HKEY_CLASSES_ROOT
				GetRegKey = Registry.ClassesRoot
			Case ERegistryPossibleRoots.HKEY_CURRENT_CONFIG
				GetRegKey = Registry.CurrentConfig
			Case ERegistryPossibleRoots.HKEY_CURRENT_USER
				GetRegKey = Registry.CurrentUser
			Case ERegistryPossibleRoots.HKEY_DYNDATA
				GetRegKey = Registry.DynData
			Case ERegistryPossibleRoots.HKEY_LOCALE_MACHINE
				GetRegKey = Registry.LocalMachine
			Case ERegistryPossibleRoots.HKEY_PERFORMANCE_DATA
				GetRegKey = Registry.PerformanceData
			Case ERegistryPossibleRoots.HKEY_USERS
				GetRegKey = Registry.Users
		End Select

		Exit Function

myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		GetRegKey = Nothing
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Prüfen, ob Schlüssel existiert
	Public Function DoesKeyExist( _
	ByVal lngRootKey As ERegistryPossibleRoots, _
	ByVal strKey As String) As Boolean
		Dim objRegKey As RegistryKey
		Dim bOK As Boolean

		On Error GoTo myErr

		objRegKey = GetRegKey(lngRootKey)

		objRegKey = objRegKey.OpenSubKey(strKey, False)

		If objRegKey Is Nothing Then
			bOK = False
		Else
			bOK = True
		End If

		If Not objRegKey Is Nothing Then
			objRegKey.Close()
			objRegKey = Nothing
		End If
		DoesKeyExist = bOK
		Exit Function

myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		DoesKeyExist = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Schlüssel(-pfad) anlegen
	Public Function CreateKey(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String) As Boolean
		Dim objRegKey As RegistryKey

		On Error GoTo myErr

		objRegKey = GetRegKey(lngrootkey)

		objRegKey = objRegKey.CreateSubKey(strKey)

		If objRegKey Is Nothing Then
			CreateKey = False
		Else
			CreateKey = True
		End If
		objRegKey.Close()
		objRegKey = Nothing

		Exit Function

myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		on error resume next

		'		if not objRegKey is nothing then
		objRegKey.Close()
		objRegKey = Nothing
		'		end if
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Schlüssel löschen
	Public Function DeleteKey(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	Optional ByVal bRecursive As Boolean = False) As Boolean
		Dim objRegKey As RegistryKey
		Dim bOK As Boolean

		On Error GoTo myErr

		bOK = True
		objRegKey = GetRegKey(lngrootkey)

		If bRecursive Then
			objRegKey.DeleteSubKeyTree(strKey)
		Else
			objRegKey.DeleteSubKey(strKey)
		End If

		objRegKey.Close()
		objRegKey = Nothing
		DeleteKey = bOK
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		DeleteKey = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert abfragen (3 Funktionen)
	' =====================================
	' Registry-Wert abfragen (String)
	Public Function QueryValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objDefault As String) As String

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim strRet As String

		On Error GoTo myErr

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey)

		strRet = CStr(objRegKey.GetValue(strValName, objDefault))
		QueryValue = strRet

		strRet = ""
		objRegKey.Close()
		objRegKey = Nothing
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		strRet = Nothing
		objRegKey.Close()
		objRegKey = Nothing
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert abfragen (Byte-Array => Binary)
	Public Function QueryValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objDefault() As Byte) As Byte()

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim arrRet() As Byte

		On Error GoTo myErr

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey)

        arrRet = CType(objRegKey.GetValue(strValName, objDefault), Byte())
		QueryValue = arrRet

		arrRet = Nothing
		objRegKey.Close()
		objRegKey = Nothing
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		arrRet = Nothing
		objRegKey.Close()
		objRegKey = Nothing
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert abfragen (Integer => DWORD)
	Public Function QueryValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objDefault As Integer) As Integer

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim intRet As Integer

		On Error GoTo myErr

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey)

		intRet = CInt(objRegKey.GetValue(strValName, objDefault))
		QueryValue = intRet

		objRegKey.Close()
		objRegKey = Nothing
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		intRet = Nothing
		objRegKey.Close()
		objRegKey = Nothing
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert anlegen (Schlüssel muss existieren) => String
	Public Function CreateValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objVal As String) As Boolean

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim objRet As Object
		Dim bOK As Boolean

		On Error GoTo myErr

		bOK = False

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey, True)

		If Not objRegKey Is Nothing Then
			objRegKey.SetValue(strValName, objVal)
			objRegKey.Flush()
			bOK = True
			objRegKey.Close()
			objRegKey = Nothing
		Else
			bOK = False
		End If

		CreateValue = bOK
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		CreateValue = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert anlegen (Schlüssel muss existieren) => Byte-Array => Binary
	Public Function CreateValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objVal() As Byte) As Boolean

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim objRet As Object
		Dim bOK As Boolean

		On Error GoTo myErr

		bOK = False

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey, True)

		If Not objRegKey Is Nothing Then
			objRegKey.SetValue(strValName, objVal)
			objRegKey.Flush()
			bOK = True
			objRegKey.Close()
			objRegKey = Nothing
		Else
			bOK = False
		End If

		CreateValue = bOK
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		CreateValue = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert anlegen (Schlüssel muss existieren) => Integer => DWORD
	Public Function CreateValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String, _
	ByVal objVal As Integer) As Boolean

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim objRet As Object
		Dim bOK As Boolean

		On Error GoTo myErr

		bOK = False

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey, True)

		If Not objRegKey Is Nothing Then
			objRegKey.SetValue(strValName, objVal)
			objRegKey.Flush()
			bOK = True
			objRegKey.Close()
			objRegKey = Nothing
		Else
			bOK = False
		End If

		CreateValue = bOK
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		CreateValue = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function

	' Registry-Wert löschen (Schlüssel muss existieren) 
	Public Function DeleteValue(ByVal lngrootkey As ERegistryPossibleRoots, _
	ByVal strKey As String, _
	ByVal strValName As String) As Boolean

		Dim objRegKey As RegistryKey
		Dim strType As Long
		Dim objRet As Object
		Dim bOK As Boolean

		On Error GoTo myErr

		bOK = False

		objRegKey = GetRegKey(lngrootkey)
		objRegKey = objRegKey.OpenSubKey(strKey, True)

		If Not objRegKey Is Nothing Then
			objRegKey.DeleteValue(strValName)
			objRegKey.Flush()
			bOK = True
			objRegKey.Close()
			objRegKey = Nothing
		Else
			bOK = False
		End If

		DeleteValue = bOK
		Exit Function
myErr:
		Dim lngErrNr As Integer
		Dim strErrSrc As String
		Dim strErrDesc As String
		lngErrNr = Err.Number
		strErrSrc = Err.Source
		strErrDesc = Err.Description

		On Error Resume Next
		objRegKey.Close()
		objRegKey = Nothing
		DeleteValue = bOK
		Err.Clear()
		Err.Raise(lngErrNr, strErrSrc, strErrDesc)
	End Function
End Class

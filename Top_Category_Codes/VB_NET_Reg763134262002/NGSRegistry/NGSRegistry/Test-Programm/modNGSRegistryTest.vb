Module modNGSRegistryTest

	Public Sub Test()
		Dim arrByte() As Byte
		On Error GoTo err

		Dim objNGSRegistry As New NGSRegistry.clsNGSRegistry()

		' Prüfen, ob Schlüssel existiert
		If Not objNGSRegistry.DoesKeyExist( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3") Then

			' Schlüssel anlegen
			Debug.WriteLine(objNGSRegistry.CreateKey( _
			objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
			"Software\NGS\key1\key2\key3"))

		End If

		' Wert StrVal erzeugen
		Debug.WriteLine(objNGSRegistry.CreateValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"StrVal", _
		"Jochen"))

		' Wert BinVal erzeugen
		ReDim arrByte(3)
		arrByte(0) = 1
		arrByte(1) = 2
		arrByte(2) = 3
		arrByte(3) = 4
		Debug.WriteLine(objNGSRegistry.CreateValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"BinVal", _
		arrByte))

		' Wert DWordVal erzeugen
		Debug.WriteLine(objNGSRegistry.CreateValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"DWordVal", _
		CInt(1234)))

		' Wert StrVal abfragen
		Debug.WriteLine(objNGSRegistry.QueryValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"StrVal", _
		""))

		' Wert BinVal abfragen
		ReDim arrByte(3)
		arrByte(0) = 1
		arrByte(1) = 1
		arrByte(2) = 1
		arrByte(3) = 1
		arrByte = objNGSRegistry.QueryValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"BinVal", _
		arrByte)

		Dim i As Integer
		For i = arrByte.GetLowerBound(0) To arrByte.GetUpperBound(0)
			Debug.WriteLine("arrByte[" & i & "]: " & arrByte(i))
		Next i

		' Wert DWord-Val abfragen
		Debug.WriteLine(objNGSRegistry.QueryValue( _
		objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		"Software\NGS\key1\key2\key3", _
		"DWordVal", _
		CInt(0)))

		' Schlüssel key3 löschen (NICHT rekursiv)
		Debug.WriteLine(objNGSRegistry.DeleteKey( _
		 objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		 "Software\NGS\key1\key2\key3"))

		' Schlüssel key1 löschen (rekursiv)
		Debug.WriteLine(objNGSRegistry.DeleteKey( _
		 objNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, _
		 "Software\NGS\key1", True))

		objNGSRegistry = Nothing

		MsgBox("Test abgeschlossen!", MsgBoxStyle.ApplicationModal + MsgBoxStyle.Information + MsgBoxStyle.OKOnly, Application.ProductName)
		Exit Sub

err:
		Dim s As String
		s = "----------------------------------------" & vbCrLf
		s = s & Err.Number & " - " & Err.Source & vbCrLf
		s = s & Err.Description & vbCrLf
		s = s & "----------------------------------------"
		MsgBox(s, MsgBoxStyle.ApplicationModal + MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, Application.ProductName)
	End Sub

End Module

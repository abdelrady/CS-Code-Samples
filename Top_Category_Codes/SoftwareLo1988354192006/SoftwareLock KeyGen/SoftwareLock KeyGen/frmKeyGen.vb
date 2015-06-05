Imports System.Security.Cryptography
Imports System.Text

Public Class frmKeyGen

  Dim SLGen As New SoftwareLockKeyGen

  Private Sub btnGenKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenKey.Click

    Try
      SLGen.AppName = txtAppName.Text
      SLGen.Password = txtAppPassword.Text
      SLGen.Reference = txtCustRef.Text

      Select Case True
        Case rbMD5.Checked
          SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.MD5
        Case rbSHA1.Checked
          SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA1
        Case rbSHA256.Checked
          SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA256
        Case rbSHA384.Checked
          SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA384
        Case rbSHA512.Checked
          SLGen.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.SHA512
      End Select

      txtSerialKey.Text = SLGen.FormatSerialKey(Space(1))
      'if Reference Length is less than 6 or more than 20 chars
      'SoftwareLock will throw an exception
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

    If chkSaveToFile.Checked Then
      Dim FileName As String = My.Computer.FileSystem. _
        CurrentDirectory & "\" & SLGen.Reference & ".key"
      Dim SerialKey As String = SLGen.SerialKey
      My.Computer.FileSystem.WriteAllText(FileName, SerialKey, False)
    End If
  End Sub



End Class


Class SoftwareLockKeyGen
  Inherits SoftwareLock.SoftwareLock

  Public Overrides Property Reference() As String
    Get
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

  Public Overrides ReadOnly Property SerialKey() As String
    Get
      'generate serial key based on the supplied Reference
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

      'convert it to upper case
      _CustRef = UCase(_CustRef)

      'use the supplied Reference to generate a 20 characters 
      'serial key for the end user
      temp = _CustRef & _AppName & _Password
      HashBytes = Hash.ComputeHash(UNIEncoding.GetBytes(temp))

      _SerialKey = Convert.ToBase64String(HashBytes)
      If _SerialKey.Trim.Length > 20 Then _SerialKey = Left(_SerialKey, 20)
      Return UCase(_SerialKey)
    End Get
  End Property

  Public Function FormatSerialKey(ByVal Separator As String) As String
    Dim parts(3) As String
    parts(0) = Me.SerialKey.Substring(0, 5) & Separator
    parts(1) = Me.SerialKey.Substring(5, 5) & Separator
    parts(2) = Me.SerialKey.Substring(10, 5) & Separator
    parts(3) = Me.SerialKey.Substring(15, 5)

    Return parts(0) & parts(1) & parts(2) & parts(3)
  End Function
End Class
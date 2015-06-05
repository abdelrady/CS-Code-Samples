Option Strict On
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Win32API
    Public Structure SECURITY_ATTRIBUTES
        Public nLength As Integer
        Public lpSecurityDescriptor As Integer
        Public bInheritHandle As Integer
    End Structure

    Public Declare Function CreateDirectory Lib "kernel32" _
       Alias "CreateDirectoryA" (ByVal lpPathName As String, _
                                 ByVal lpSecurityAttributes _
                                     As SECURITY_ATTRIBUTES) As Boolean
End Class

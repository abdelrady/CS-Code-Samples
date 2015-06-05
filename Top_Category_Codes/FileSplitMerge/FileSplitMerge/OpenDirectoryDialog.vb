Imports System.Runtime.InteropServices
Imports System.Text
'''
Public Class OpenDirectoryDialog
    '''
    Private _DialogTitle As String = ""
    Private _DirectoryName As String = ""
    Private Const MAX_PATH As Integer = 260
    '''
    Private Structure BROWSEINFO
        Public hWndOwner As IntPtr
        Public pIDLRoot As Integer
        Public pszDisplayName As String
        Public lpszTitle As String
        Public ulFlags As Integer
        Public lpfnCallback As Integer
        Public lParam As Integer
        Public iImage As Integer
    End Structure
    '''
    Private Declare Function CoTaskMemFree Lib "ole32.dll" (ByVal hMem As IntPtr) As Integer
    Private Declare Function lstrcat Lib "kernel32.dll" (ByVal lpString1 As String, ByVal lpString2 As String) As IntPtr
    Private Declare Function SHBrowseForFolder Lib "shell32.dll" (ByRef lpbi As BROWSEINFO) As IntPtr
    Private Declare Function SHGetPathFromIDList Lib "shell32.dll" (ByVal pidList As IntPtr, ByVal lpBuffer As StringBuilder) As Integer
    '''
    Public Function ShowDialog(ByVal owner As IWin32Window) As DialogResult
        Dim _handle As IntPtr
        Dim udtBI As New BROWSEINFO()
        Dim lpIDList As IntPtr
        Dim hTitle As GCHandle
        Dim buffer As New StringBuilder(MAX_PATH)
        Dim path As New StringBuilder(MAX_PATH)
        Try
            hTitle = GCHandle.Alloc(_DialogTitle, GCHandleType.Pinned)
            If Not owner Is Nothing Then
                _handle = owner.Handle
            Else
                _handle = IntPtr.Zero
            End If
            udtBI.hWndOwner = _handle
            udtBI.lpszTitle = _DialogTitle
            udtBI.ulFlags = CType(&H1, Integer)
            buffer.Length = MAX_PATH
            udtBI.pszDisplayName = buffer.ToString()
            lpIDList = SHBrowseForFolder(udtBI)
            hTitle.Free()
            If lpIDList.ToInt64() <> 0 Then
                SHGetPathFromIDList(lpIDList, path)
                _DirectoryName = path.ToString()
                CoTaskMemFree(lpIDList)
                Return DialogResult.OK
            Else
                Return DialogResult.Cancel
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '''
    Public Property DialogTitle() As String
        Get
            Return _DialogTitle
        End Get
        Set(ByVal value As String)
            _DialogTitle = value
        End Set
    End Property
    '''
    Public ReadOnly Property DirectoryName() As String
        Get
            Return _DirectoryName
        End Get
    End Property
    '''
End Class

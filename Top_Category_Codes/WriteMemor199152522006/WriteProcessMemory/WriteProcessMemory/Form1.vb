Public Class Form1

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal Classname As String, ByVal WindowName As String) As IntPtr
    Private Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As IntPtr
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As IntPtr) As Integer
    Private Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Short, ByVal lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Short, ByVal lpNumberOfBytesWritten As Integer) As Integer
    Private Const PROCESS_VM_ALL As Integer = &H1F0FFF
    Private Const PROCESS_VM_READ As Integer = &H10
    Private Const PROCESS_VM_WRITE As Integer = &H20
    Private Const PROCESS_VM_OPERATION As Integer = &H8

    Public Sub WriteMem(ByVal Address As Integer, ByVal Buffer() As Byte, ByVal WindowText As String)
        Dim hWnd As IntPtr, pHandle As IntPtr
        Dim processID As Integer
        hWnd = FindWindow(vbNullString, WindowText)
        If Not (hWnd = 0) Then
            GetWindowThreadProcessId(hWnd, processID)
            pHandle = OpenProcess(PROCESS_VM_WRITE + PROCESS_VM_OPERATION, False, processID)
            If Not (pHandle = 0) Then
                WriteProcessMemory(pHandle, Address, Buffer(0), (UBound(Buffer) + 1), 0&)
            End If
            CloseHandle(pHandle)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a(4) As Byte 'This variable is an integer (4 bytes), you can make it 2 bytes, 8 bytes etc depending on what value you want to write
        a(0) = 4
        ' If you have a memory address such as 004D3F77
        ' to convert it simple add &H infront of it, VB should do the rest for you

        'In this example a = 0 the memory address is a random address and probably wont do anything!
        'This should work for anything else tho! 

        WriteMem(&H4D3F77, a, "Untitled - Notepad")

    End Sub
End Class

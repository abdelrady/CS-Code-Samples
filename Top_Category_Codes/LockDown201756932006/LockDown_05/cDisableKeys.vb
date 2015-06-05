Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms

Public Class cDisableKeys
    Implements IDisposable
    'Works only on Windows NT, version 4.0 SP3 and later

    Private Declare Function UnhookWindowsHookEx Lib "user32" _
      (ByVal hHook As Integer) As Integer

    Private Declare Function SetWindowsHookEx Lib "user32" _
      Alias "SetWindowsHookExA" (ByVal idHook As Integer, _
      ByVal lpfn As KeyboardHookDelegate, ByVal hmod As Integer, _
      ByVal dwThreadId As Integer) As Integer

    Private Declare Function GetAsyncKeyState Lib "user32" _
      (ByVal vKey As Integer) As Integer

    Private Declare Function CallNextHookEx Lib "user32" _
      (ByVal hHook As Integer, _
      ByVal nCode As Integer, _
      ByVal wParam As Integer, _
      ByVal lParam As KBDLLHOOKSTRUCT) As Integer

    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure

    ' Low-Level Keyboard Constants
    Private Const HC_ACTION As Integer = 0
    Private Const LLKHF_EXTENDED As Integer = &H1
    Private Const LLKHF_INJECTED As Integer = &H10
    Private Const LLKHF_ALTDOWN As Integer = &H20
    Private Const LLKHF_UP As Integer = &H80

    'KeyUp/KeyDown constants
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105

    Private Const WH_KEYBOARD_LL As Integer = 13&
    Private KeyboardHandle As Integer
    Private disposed As Boolean = False

    Private Delegate Function KeyboardHookDelegate( _
      ByVal Code As Integer, _
      ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) _
                   As Integer

    'Our keydown and keyup events
    Public Event KeyDown As KeyEventHandler
    Public Event KeyUp As KeyEventHandler

    <MarshalAs(UnmanagedType.FunctionPtr)> _
    Private callback As KeyboardHookDelegate = New KeyboardHookDelegate(AddressOf KeyboardCallback)

    'Keyboard callback function
    Private Function KeyboardCallback(ByVal Code As Integer, _
      ByVal wParam As Integer, _
      ByRef lParam As KBDLLHOOKSTRUCT) As Integer

        If (Code = HC_ACTION) Then
            'Call the appropriate event

            Dim KeyData As Keys
            Dim args As KeyEventArgs

            KeyData = lParam.vkCode

            'Check if the ALT key is pressed
            If CBool(GetAsyncKeyState(Keys.Menu) And &H8000) Then
                'Alt key pressed
                KeyData = KeyData Or Keys.Alt
            End If

            'Check if the Ctrl key is pressed
            If CBool(GetAsyncKeyState(Keys.ControlKey) And &H8000) Then
                'Ctrl key pressed
                KeyData = KeyData Or Keys.Control
            End If

            'Check if the Shift key was pressed
            If CBool(GetAsyncKeyState(Keys.ShiftKey) And &H8000) Then
                'Shift key pressed
                KeyData = KeyData Or Keys.Shift
            End If

            'Create the event args
            args = New KeyEventArgs(KeyData)

            'Raise the appropriate event
            If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
                OnKeyDown(Me, args)
            ElseIf wParam = WM_KEYUP Or wParam = WM_SYSKEYUP Then
                OnKeyUp(Me, args)
            End If

            'Determine if we should block the key
            If args.Handled Then
                Return 1
            End If
        End If

        'Call the next hook in the hook chain and return the value
        Return CallNextHookEx(KeyboardHandle, _
          Code, wParam, lParam)

    End Function

    Protected Sub OnKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        RaiseEvent KeyDown(sender, e)
    End Sub

    Protected Sub OnKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        RaiseEvent KeyUp(sender, e)
    End Sub

    Public Overridable Sub Dispose() Implements IDisposable.Dispose
        If Not disposed Then
            disposed = True

            'Unhook the keyboard
            UnhookWindowsHookEx(KeyboardHandle)
        Else
            Throw New ObjectDisposedException("KeyboardHook")
        End If
    End Sub

    Public Sub New()
        'Create a keyboard low-level hook

        KeyboardHandle = SetWindowsHookEx( _
            WH_KEYBOARD_LL, callback, _
            Marshal.GetHINSTANCE( _
            [Assembly].GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        If Not disposed Then
            Dispose()
        End If
    End Sub
End Class


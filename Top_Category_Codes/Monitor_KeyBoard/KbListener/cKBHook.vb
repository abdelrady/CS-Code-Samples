Imports System.Runtime.InteropServices

Public Class cKBHook

    Public Event KeyPressed(ByVal KeyChar As Int32)

    Delegate Function HookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, _
    ByVal lParam As IntPtr) As IntPtr

    Declare Auto Function SetWindowsHookEx Lib "user32.dll" (ByVal idHook As Integer, _
    ByVal lpfn As HookProc, ByVal hMod As IntPtr, ByVal dwThreadId As Integer) As IntPtr

    Declare Function UnhookWindowsHookEx Lib "user32.dll" (ByVal hhk As IntPtr) As Boolean

    Declare Function CallNextHookEx Lib "user32.dll" (ByVal hhk As IntPtr, ByVal nCode As Integer, _
    ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Const WH_KEYBOARD_LL As Integer = 13

    Shared hook As IntPtr

    Public Function MyLLKbdProc(ByVal nCode As Integer, ByVal wParam As IntPtr, _
                                ByVal lParam As IntPtr) As IntPtr
        RaiseEvent KeyPressed(Marshal.ReadInt32(lParam))
        Return CallNextHookEx(hook, nCode, wParam, lParam)
    End Function

    Public Sub Listen()
        Dim hp As HookProc = AddressOf MyLLKbdProc
        hook = SetWindowsHookEx(WH_KEYBOARD_LL, hp, Marshal.GetHINSTANCE(GetType(cKBHook).Module), 0)
        GC.KeepAlive(hp)
    End Sub

    Public Sub StopListening()
        UnhookWindowsHookEx(hook)
    End Sub

End Class

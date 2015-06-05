'
'    WindowsController class for VB.NET
'		Version: 1.1
'
'    Copyright � 2002-2003, The KPD-Team
'    All rights reserved.
'    http://www.mentalis.org/
'
'  Redistribution and use in source and binary forms, with or without
'  modification, are permitted provided that the following conditions
'  are met:
'
'    - Redistributions of source code must retain the above copyright
'       notice, this list of conditions and the following disclaimer. 
'
'    - Neither the name of the KPD-Team, nor the names of its contributors
'       may be used to endorse or promote products derived from this
'       software without specific prior written permission. 
'
'  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
'  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
'  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
'  FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL
'  THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
'  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
'  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
'  SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
'  HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
'  STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
'  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
'  OF THE POSSIBILITY OF SUCH DAMAGE.
'

Imports System
Imports System.Text
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic

'Namespace Org.Mentalis.Utilities
'/// <summary>
'/// Specifies the type of restart options that an application can use.
'/// </summary>
Public Enum RestartOptions
    '/// <summary>
    '/// Shuts down all processes running in the security context of the process that called the ExitWindowsEx function. Then it logs the user off.
    '/// </summary>
    LogOff = 0
    '/// <summary>
    '/// Shuts down the system and turns off the power. The system must support the power-off feature.
    '/// </summary>
    PowerOff = 8
    '/// <summary>
    '/// Shuts down the system and then restarts the system.
    '/// </summary>
    Reboot = 2
    '/// <summary>
    '/// Shuts down the system to a point at which it is safe to turn off the power. All file buffers have been flushed to disk, and all running processes have stopped. If the system supports the power-off feature, the power is also turned off.
    '/// </summary>
    ShutDown = 1
    '/// <summary>
    '/// Suspends the system.
    '/// </summary>
    Suspend = -1
    '/// <summary>
    '/// Hibernates the system.
    '/// </summary>
    Hibernate = -2
End Enum
'/// <summary>
'/// An LUID is a 64-bit value guaranteed to be unique only on the system on which it was generated. The uniqueness of a locally unique identifier (LUID) is guaranteed only until the system is restarted.
'/// </summary>
<StructLayout(LayoutKind.Sequential, Pack:=1)> _
Friend Structure LUID
    '/// <summary>
    '/// The low order part of the 64 bit value.
    '/// </summary>
    Public LowPart As Integer
    '/// <summary>
    '/// The high order part of the 64 bit value.
    '/// </summary>
    Public HighPart As Integer
End Structure
'/// <summary>
'/// The LUID_AND_ATTRIBUTES structure represents a locally unique identifier (LUID) and its attributes.
'/// </summary>
<StructLayout(LayoutKind.Sequential, Pack:=1)> _
Friend Structure LUID_AND_ATTRIBUTES
    '/// <summary>
    '/// Specifies an LUID value.
    '/// </summary>
    Public pLuid As LUID
    '/// <summary>
    '/// Specifies attributes of the LUID. This value contains up to 32 one-bit flags. Its meaning is dependent on the definition and use of the LUID.
    '/// </summary>
    Public Attributes As Integer
End Structure
'/// <summary>
'/// The TOKEN_PRIVILEGES structure contains information about a set of privileges for an access token.
'/// </summary>
<StructLayout(LayoutKind.Sequential, Pack:=1)> _
Friend Structure TOKEN_PRIVILEGES
    '/// <summary>
    '/// Specifies the number of entries in the Privileges array.
    '/// </summary>
    Public PrivilegeCount As Integer
    '/// <summary>
    '/// Specifies an array of LUID_AND_ATTRIBUTES structures. Each structure contains the LUID and attributes of a privilege.
    '/// </summary>
    Public Privileges As LUID_AND_ATTRIBUTES
End Structure
'/// <summary>
'/// Implements methods to exit Windows.
'/// </summary>
Public Class WindowsController
    '/// <summary>Required to enable or disable the privileges in an access token.</summary>
    Private Const TOKEN_ADJUST_PRIVILEGES As Integer = &H20
    '/// <summary>Required to query an access token.</summary>
    Private Const TOKEN_QUERY As Integer = &H8
    '/// <summary>The privilege is enabled.</summary>
    Private Const SE_PRIVILEGE_ENABLED As Integer = &H2
    '/// <summary>Specifies that the function should search the system message-table resource(s) for the requested message.</summary>
    Private Const FORMAT_MESSAGE_FROM_SYSTEM As Integer = &H1000
    '/// <summary>Forces processes to terminate. When this flag is set, the system does not send the WM_QUERYENDSESSION and WM_ENDSESSION messages. This can cause the applications to lose data. Therefore, you should only use this flag in an emergency.</summary>
    Private Const EWX_FORCE As Integer = 4
    '/// <summary>
    '/// The LoadLibrary function maps the specified executable module into the address space of the calling process.
    '/// </summary>
    '/// <param name="lpLibFileName">Pointer to a null-terminated string that names the executable module (either a .dll or .exe file). The name specified is the file name of the module and is not related to the name stored in the library module itself, as specified by the LIBRARY keyword in the module-definition (.def) file.</param>
    '/// <returns>If the function succeeds, the return value is a handle to the module.<br></br><br>If the function fails, the return value is NULL. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As IntPtr
    '/// <summary>
    '/// The FreeLibrary function decrements the reference count of the loaded dynamic-link library (DLL). When the reference count reaches zero, the module is unmapped from the address space of the calling process and the handle is no longer valid.
    '/// </summary>
    '/// <param name="hLibModule">Handle to the loaded DLL module. The LoadLibrary or GetModuleHandle function returns this handle.</param>
    '/// <returns>If the function succeeds, the return value is nonzero.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function FreeLibrary Lib "kernel32" (ByVal hLibModule As IntPtr) As Integer
    '/// <summary>
    '/// The GetProcAddress function retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
    '/// </summary>
    '/// <param name="hModule">Handle to the DLL module that contains the function or variable. The LoadLibrary or GetModuleHandle function returns this handle.</param>
    '/// <param name="lpProcName">Pointer to a null-terminated string containing the function or variable name, or the function's ordinal value. If this parameter is an ordinal value, it must be in the low-order word; the high-order word must be zero.</param>
    '/// <returns>If the function succeeds, the return value is the address of the exported function or variable.<br></br><br>If the function fails, the return value is NULL. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function GetProcAddress Lib "kernel32" (ByVal hModule As IntPtr, ByVal lpProcName As String) As IntPtr
    '/// <summary>
    '/// The SetSuspendState function suspends the system by shutting power down. Depending on the Hibernate parameter, the system either enters a suspend (sleep) state or hibernation (S4). If the ForceFlag parameter is TRUE, the system suspends operation immediately; if it is FALSE, the system requests permission from all applications and device drivers before doing so.
    '/// </summary>
    '/// <param name="Hibernate">Specifies the state of the system. If TRUE, the system hibernates. If FALSE, the system is suspended.</param>
    '/// <param name="ForceCritical">Forced suspension. If TRUE, the function broadcasts a PBT_APMSUSPEND event to each application and driver, then immediately suspends operation. If FALSE, the function broadcasts a PBT_APMQUERYSUSPEND event to each application to request permission to suspend operation.</param>
    '/// <param name="DisableWakeEvent">If TRUE, the system disables all wake events. If FALSE, any system wake events remain enabled.</param>
    '/// <returns>If the function succeeds, the return value is nonzero.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function SetSuspendState Lib "powrprof" (ByVal Hibernate As Integer, ByVal ForceCritical As Integer, ByVal DisableWakeEvent As Integer) As Integer
    '/// <summary>
    '/// The OpenProcessToken function opens the access token associated with a process.
    '/// </summary>
    '/// <param name="ProcessHandle">Handle to the process whose access token is opened.</param>
    '/// <param name="DesiredAccess">Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's discretionary access-control list (DACL) to determine which accesses are granted or denied.</param>
    '/// <param name="TokenHandle">Pointer to a handle identifying the newly-opened access token when the function returns.</param>
    '/// <returns>If the function succeeds, the return value is nonzero.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function OpenProcessToken Lib "advapi32" (ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As Integer, ByRef TokenHandle As IntPtr) As Integer
    '/// <summary>
    '/// The LookupPrivilegeValue function retrieves the locally unique identifier (LUID) used on a specified system to locally represent the specified privilege name.
    '/// </summary>
    '/// <param name="lpSystemName">Pointer to a null-terminated string specifying the name of the system on which the privilege name is looked up. If a null string is specified, the function attempts to find the privilege name on the local system.</param>
    '/// <param name="lpName">Pointer to a null-terminated string that specifies the name of the privilege, as defined in the Winnt.h header file. For example, this parameter could specify the constant SE_SECURITY_NAME, or its corresponding string, "SeSecurityPrivilege".</param>
    '/// <param name="lpLuid">Pointer to a variable that receives the locally unique identifier by which the privilege is known on the system, specified by the lpSystemName parameter.</param>
    '/// <returns>If the function succeeds, the return value is nonzero.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function LookupPrivilegeValue Lib "advapi32" Alias "LookupPrivilegeValueA" (ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As LUID) As Integer
    '/// <summary>
    '/// The AdjustTokenPrivileges function enables or disables privileges in the specified access token. Enabling or disabling privileges in an access token requires TOKEN_ADJUST_PRIVILEGES access.
    '/// </summary>
    '/// <param name="TokenHandle">Handle to the access token that contains the privileges to be modified. The handle must have TOKEN_ADJUST_PRIVILEGES access to the token. If the PreviousState parameter is not NULL, the handle must also have TOKEN_QUERY access.</param>
    '/// <param name="DisableAllPrivileges">Specifies whether the function disables all of the token's privileges. If this value is TRUE, the function disables all privileges and ignores the NewState parameter. If it is FALSE, the function modifies privileges based on the information pointed to by the NewState parameter.</param>
    '/// <param name="NewState">Pointer to a TOKEN_PRIVILEGES structure that specifies an array of privileges and their attributes. If the DisableAllPrivileges parameter is FALSE, AdjustTokenPrivileges enables or disables these privileges for the token. If you set the SE_PRIVILEGE_ENABLED attribute for a privilege, the function enables that privilege; otherwise, it disables the privilege. If DisableAllPrivileges is TRUE, the function ignores this parameter.</param>
    '/// <param name="BufferLength">Specifies the size, in bytes, of the buffer pointed to by the PreviousState parameter. This parameter can be zero if the PreviousState parameter is NULL.</param>
    '/// <param name="PreviousState">Pointer to a buffer that the function fills with a TOKEN_PRIVILEGES structure that contains the previous state of any privileges that the function modifies. This parameter can be NULL.</param>
    '/// <param name="ReturnLength">Pointer to a variable that receives the required size, in bytes, of the buffer pointed to by the PreviousState parameter. This parameter can be NULL if PreviousState is NULL.</param>
    '/// <returns>If the function succeeds, the return value is nonzero. To determine whether the function adjusted all of the specified privileges, call Marshal.GetLastWin32Error.</returns>
    Private Declare Ansi Function AdjustTokenPrivileges Lib "advapi32" (ByVal TokenHandle As IntPtr, ByVal DisableAllPrivileges As Integer, ByRef NewState As TOKEN_PRIVILEGES, ByVal BufferLength As Integer, ByRef PreviousState As TOKEN_PRIVILEGES, ByRef ReturnLength As Integer) As Integer
    '/// <summary>
    '/// The ExitWindowsEx function either logs off the current user, shuts down the system, or shuts down and restarts the system. It sends the WM_QUERYENDSESSION message to all applications to determine if they can be terminated.
    '/// </summary>
    '/// <param name="uFlags">Specifies the type of shutdown.</param>
    '/// <param name="dwReserved">This parameter is ignored.</param>
    '/// <returns>If the function succeeds, the return value is nonzero.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function ExitWindowsEx Lib "user32" (ByVal uFlags As Integer, ByVal dwReserved As Integer) As Integer
    '/// <summary>
    '/// The FormatMessage function formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
    '/// </summary>
    '/// <param name="dwFlags">Specifies aspects of the formatting process and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.</param>
    '/// <param name="lpSource">Specifies the location of the message definition. The type of this parameter depends upon the settings in the dwFlags parameter.</param>
    '/// <param name="dwMessageId">Specifies the message identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.</param>
    '/// <param name="dwLanguageId">Specifies the language identifier for the requested message. This parameter is ignored if dwFlags includes FORMAT_MESSAGE_FROM_STRING.</param>
    '/// <param name="lpBuffer">Pointer to a buffer for the formatted (and null-terminated) message. If dwFlags includes FORMAT_MESSAGE_ALLOCATE_BUFFER, the function allocates a buffer using the LocalAlloc function, and places the pointer to the buffer at the address specified in lpBuffer.</param>
    '/// <param name="nSize">If the FORMAT_MESSAGE_ALLOCATE_BUFFER flag is not set, this parameter specifies the maximum number of TCHARs that can be stored in the output buffer. If FORMAT_MESSAGE_ALLOCATE_BUFFER is set, this parameter specifies the minimum number of TCHARs to allocate for an output buffer. For ANSI text, this is the number of bytes; for Unicode text, this is the number of characters.</param>
    '/// <param name="Arguments">Pointer to an array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.</param>
    '/// <returns>If the function succeeds, the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.<br></br><br>If the function fails, the return value is zero. To get extended error information, call Marshal.GetLastWin32Error.</br></returns>
    Private Declare Ansi Function FormatMessage Lib "kernel32" Alias "FormatMessageA" (ByVal dwFlags As Integer, ByVal lpSource As IntPtr, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByVal lpBuffer As StringBuilder, ByVal nSize As Integer, ByVal Arguments As Integer) As Integer
    '/// <summary>
    '/// Exits windows (and tries to enable any required access rights, if necesarry).
    '/// </summary>
    '/// <param name="how">One of the RestartOptions values that specifies how to exit windows.</param>
    '/// <param name="force">True if the exit has to be forced, false otherwise.</param>
    '/// <exception cref="PrivilegeException">There was an error while requesting a required privilege.</exception>
    '/// <exception cref="PlatformNotSupportedException">The requested exit method is not supported on this platform.</exception>
    Public Shared Sub ExitWindows(ByVal how As RestartOptions, ByVal force As Boolean)
        Select Case how
            Case RestartOptions.Suspend
                SuspendSystem(False, force)
            Case RestartOptions.Hibernate
                SuspendSystem(True, force)
            Case Else
                ExitWindows(CType(how, Integer), force)
        End Select
    End Sub
    '/// <summary>
    '/// Exits windows (and tries to enable any required access rights, if necesarry).
    '/// </summary>
    '/// <param name="how">One of the RestartOptions values that specifies how to exit windows.</param>
    '/// <param name="force">True if the exit has to be forced, false otherwise.</param>
    '/// <remarks>This method cannot hibernate or suspend the system.</remarks>
    '/// <exception cref="PrivilegeException">There was an error while requesting a required privilege.</exception>
    Protected Shared Sub ExitWindows(ByVal how As Integer, ByVal force As Boolean)
        EnableToken("SeShutdownPrivilege")
        If force Then how = how Or EWX_FORCE
        If ExitWindowsEx(how, 0) = 0 Then Throw New PrivilegeException(FormatError(Marshal.GetLastWin32Error))
    End Sub
    '/// <summary>
    '/// Tries to enable the specified privilege.
    '/// </summary>
    '/// <param name="privilege">The privilege to enable.</param>
    '/// <exception cref="PrivilegeException">There was an error while requesting a required privilege.</exception>
    '/// <remarks>Thanks to Michael S. Muegel for notifying us about a bug in this code.</remarks>
    Protected Shared Sub EnableToken(ByVal privilege As String)
        If (Environment.OSVersion.Platform <> PlatformID.Win32NT) OrElse (Not CheckEntryPoint("advapi32.dll", "AdjustTokenPrivileges")) Then Return
        Dim tokenHandle As IntPtr
        Dim privilegeLUID As LUID
        Dim newPrivileges As TOKEN_PRIVILEGES
        Dim tokenPrivileges As TOKEN_PRIVILEGES
        If OpenProcessToken(Process.GetCurrentProcess.Handle, TOKEN_ADJUST_PRIVILEGES Or TOKEN_QUERY, tokenHandle) = 0 Then Throw New PrivilegeException(FormatError(Marshal.GetLastWin32Error))
        If LookupPrivilegeValue("", privilege, privilegeLUID) = 0 Then Throw New PrivilegeException(FormatError(Marshal.GetLastWin32Error))
        tokenPrivileges.PrivilegeCount = 1
        tokenPrivileges.Privileges.Attributes = SE_PRIVILEGE_ENABLED
        tokenPrivileges.Privileges.pLuid = privilegeLUID
        If AdjustTokenPrivileges(tokenHandle, 0, tokenPrivileges, 4 + (12 * tokenPrivileges.PrivilegeCount), newPrivileges, 4 + (12 * newPrivileges.PrivilegeCount)) = 0 Then Throw New PrivilegeException(FormatError(Marshal.GetLastWin32Error))
    End Sub
    '/// <summary>
    '/// Suspends or hibernates the system.
    '/// </summary>
    '/// <param name="hibernate">True if the system has to hibernate, false if the system has to be suspended.</param>
    '/// <param name="force">True if the exit has to be forced, false otherwise.</param>
    '/// <exception cref="PlatformNotSupportedException">The requested exit method is not supported on this platform.</exception>
    Protected Shared Sub SuspendSystem(ByVal hibernate As Boolean, ByVal force As Boolean)
        If Not CheckEntryPoint("powrprof.dll", "SetSuspendState") Then Throw New PlatformNotSupportedException("The SetSuspendState method is not supported on this system!")
        SetSuspendState(CType(IIf(hibernate, 1, 0), Integer), CType(IIf(force, 1, 0), Integer), 0)
    End Sub
    '/// <summary>
    '/// Checks whether a specified method exists on the local computer.
    '/// </summary>
    '/// <param name="library">The library that holds the method.</param>
    '/// <param name="method">The entry point of the requested method.</param>
    '/// <returns>True if the specified method is present, false otherwise.</returns>
    Protected Shared Function CheckEntryPoint(ByVal library As String, ByVal method As String) As Boolean
        Dim libPtr As IntPtr = LoadLibrary(library)
        If Not libPtr.Equals(IntPtr.Zero) Then
            If Not GetProcAddress(libPtr, method).Equals(IntPtr.Zero) Then
                FreeLibrary(libPtr)
                Return True
            End If
            FreeLibrary(libPtr)
        End If
        Return False
    End Function
    '/// <summary>
    '/// Formats an error number into an error message.
    '/// </summary>
    '/// <param name="number">The error number to convert.</param>
    '/// <returns>A string representation of the specified error number.</returns>
    Protected Shared Function FormatError(ByVal number As Integer) As String
        Try
            Dim buffer As New StringBuilder(255)
            FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, IntPtr.Zero, number, 0, buffer, buffer.Capacity, 0)
            Return buffer.ToString()
        Catch e As Exception
            Return "Unspecified error [" + number.ToString() + "]"
        End Try
    End Function
End Class
'/// <summary>
'/// The exception that is thrown when an error occures when requesting a specific privilege.
'/// </summary>
Public Class PrivilegeException
    Inherits Exception
    '/// <summary>
    '/// Initializes a new instance of the PrivilegeException class.
    '/// </summary>
    Public Sub New()
        MyBase.New()
    End Sub
    '/// <summary>
    '/// Initializes a new instance of the PrivilegeException class with a specified error message.
    '/// </summary>
    '/// <param name="message">The message that describes the error.</param>
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
'End Namespace

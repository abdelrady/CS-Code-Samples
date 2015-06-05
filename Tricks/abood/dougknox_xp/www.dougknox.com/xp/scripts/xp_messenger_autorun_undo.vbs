'Prevent Windows Messenger from automatically Starting - Undo Script
'xp_messenger_autorun_undo.vbs
'© Doug Knox - 04/12/2002
'Downloaded from http://www.dougknox.com
On Error Resume Next

Set WshShell = WScript.CreateObject("WScript.Shell")

WshShell.RegDelete "HKEY_LOCAL_MACHINE\Software\Microsoft\Outlook Express\Hide Messenger"
WshShell.RegDelete "HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Messenger\Client\PreventRun"
WshShell.RegDelete "HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Messenger\Client\PreventAutoRun"
Message = "Windows Messenger will now be allowed to start and run automatically."

X = MsgBox(Message, vbOKOnly, "Done")
Set WshShell = Nothing

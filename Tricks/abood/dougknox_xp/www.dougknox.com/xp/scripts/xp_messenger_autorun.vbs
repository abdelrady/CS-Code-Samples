'Prevent Windows Messenger from automatically Starting
'xp_messenger_autorun.vbs
'© Doug Knox - 03/01/2002
'Downloaded from http://www.dougknox.com
On Error Resume Next

Set WshShell = WScript.CreateObject("WScript.Shell")
WshShell.RegWrite "HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Messenger\Client\PreventRun",1,"REG_DWORD"
WshShell.RegWrite "HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Messenger\Client\PreventAutoRun",1,"REG_DWORD"
WshShell.RegWrite "HKEY_LOCAL_MACHINE\Software\Microsoft\Outlook Express\Hide Messenger",2,"REG_DWORD"

Message = "Windows Messenger will no longer run, or start automatically."

X = MsgBox(Message, vbOKOnly, "Done")
Set WshShell = Nothing

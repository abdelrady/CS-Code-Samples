'xp_messsenger_remove.vbs - Removes Windows Messenger from Windows XP
'© Doug Knox - 3/30/02
'Downloaded from www.dougknox.com

Option Explicit
On Error Resume Next

'Dimension variables
Dim WSHShell, MyBox, p1, q1, rcmd
Dim jobfunc

'Set the Windows Script Host Shell and assign values to variables
Set WSHShell = WScript.CreateObject("WScript.Shell")
p1 = "HKEY_LOCAL_MACHINE\Software\Microsoft\Outlook Express\Hide Messenger"
q1 = 2
rcmd = "RunDll32 advpack.dll,LaunchINFSection %windir%\inf\msmsgs.inf,BLC.Remove"

'Create or change the Hide Messenger value
WSHShell.RegWrite p1, q1

'Run the uninstall command
WshShell.Run(rcmd)
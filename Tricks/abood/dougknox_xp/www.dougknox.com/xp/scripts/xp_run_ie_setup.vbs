'run_ie_reinstall.vbs - Runs the Internet Explorer Setup
'© Doug Knox - 4/10/2002
'Downloaded from www.dougknox.com

X = MsgBox("Do you want to reinstall Internet Explorer?", vbYesNo, "Prompt!")

Y = MsgBox("Do you want to reinstall Outlook Express?", vbYesNo, "Prompt!")

Set WshShell = WScript.CreateObject("WScript.Shell")

If X = 6 Then
   WshShell.RegWrite "HKLM\SOFTWARE\Microsoft\Active Setup\Installed Components\{89820200-ECBD-11cf-8B85-00AA005B4383}\IsInstalled", 0, "REG_DWORD"
End If

If Y = 6 Then
   WshShell.RegWrite "HKLM\SOFTWARE\Microsoft\Active Setup\Installed Components\{44BBA840-CC51-11CF-AAFA-00AA00B6015C}\IsInstalled", 0, "REG_DWORD"
End If

If X = 6 OR Y = 6 Then
  WshShell.Run ("rundll32.exe setupapi,InstallHinfSection DefaultInstall 132 %windir%\Inf\ie.inf")
Else
  MsgBox "You chose not to reinstall IE or OE. No changes were made." & vbCR & vbCR & "Copyright 2003 - Doug Knox",vbOkOnly, "User Cancelled"
End If


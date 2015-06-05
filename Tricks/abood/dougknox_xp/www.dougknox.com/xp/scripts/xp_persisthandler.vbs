'Add files to Search for files containing text
'© Doug Knox - 11/04/2001

Option Explicit
On Error Resume Next

Dim WshShell, N, P, P1, P2, ItemType, MyBox, FileType, Title, Prompt, RegKey, X

Set WSHShell = WScript.CreateObject("WScript.Shell")
P = "HKEY_CLASSES_ROOT\."
P1 = "\PersistentHandler\"
N = "{5e941d80-bf96-11cd-b579-08002b30bfeb}"

Prompt = "Enter the file extension for the file you wish to add." & vbCR
Prompt = Prompt & "Examples: txt, adm, inf"
Title = "Enter File Type"

FileType = InputBox(Prompt, Title, "")
If FileType = "" Then
	MyBox = MsgBox("You left the box blank.",4096,"Error.")
	Set WshShell = Nothing
	WScript.Quit
Else 
'Check to see if there is already a PersistentHandler default value
	RegKey = P & FileType & P1
	X = WshShell.RegRead(RegKey)
End If

'MyBox = MsgBox("The PersistentHandler value for ." & FileType & " is: " & X,4096,"Results")
'Set WshShell = Nothing
If X = N Then
	MyBox = MsgBox("This value already exists, and is correct." & vbCR & "No Changes were made.", 4096, "No Changes")
	Set WshShell = Nothing
	WScript.Quit
End If

If X <> N AND X <> "" Then
	MyBox = MsgBox("The Persistent Handler value already exists and is different." & vbCR & "No changes were made.", 4096, "No Changes")
	Set WshShell = Nothing
	WScript.Quit
End If

If Err.Number <> 0 Then
	WshShell.RegWrite RegKey, N
	MyBox = MsgBox("The Registry has been updated." & vbCR & "Restart your computer.", 4096, "Done")
	Set WshShell = Nothing
End If
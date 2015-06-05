'Unattended System Restore Point
'sysrestorepoint.vbs
'© Doug Knox - rev 02/11/2002
'Downloaded from www.dougknox.com 
'Extracted from original code by Bill James - www.billsway.com

Set sr = getobject("winmgmts:\\.\root\default:Systemrestore")

msg = "New Restore Point successfully created." & vbCR
msg = msg & "It is listed as: " & vbCR
msg = msg & "Automatic Restore Point " & Date & " " & Time

'Put a ' in front of the next five lines to disable the Success Failed Prompt.
If (sr.createrestorepoint("Automatic Restore Point", 0, 100)) = 0 Then
    MsgBox msg
Else
    MsgBox "Restore Point creation Failed!"
End If

'Remove the ' from the next 3 lines to only alert you if the process failed
'If (sr.createrestorepoint("Automatic Restore Point", 0, 100)) <> 0 Then
'    MsgBox "Restore Point creation Failed!"
'End If

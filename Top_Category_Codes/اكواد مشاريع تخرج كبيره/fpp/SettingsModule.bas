Attribute VB_Name = "SettingsModule"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/



' info@emu8086.com
' =========================================================
' Module of application settings
' =========================================================

Option Explicit

Dim sDO_Associate           As String

Dim sLANGUAGE               As String ' not implemented yet (not used).

' flow that starts like it's passed as a parameter to EXE.
Dim sSTART_UP_FLOW As String

'  set default settings:
Public Sub setDefaultINISettings()
    sDO_Associate = "ASSOCIATE_IF_REQUIRED=YES"
    sLANGUAGE = "ENGLISH" '1.88    ' default is English.
    sSTART_UP_FLOW = ""
End Sub

' loads settings from file:
Public Sub LoadINISettingsFromFile(sINI_FILENAME As String)
On Error GoTo ERR_LOAD_SETTINGS

    Dim mFileNum As Integer
    mFileNum = FreeFile
    
    Open AddSlash(App.Path) & sINI_FILENAME For Input As mFileNum
    
    ' line #1 (should associate with exe?):
    Line Input #mFileNum, sDO_Associate
     
    ' line #2 (language):
    Line Input #mFileNum, sLANGUAGE
     
    ' line #3 (start up flow):
    Line Input #mFileNum, sSTART_UP_FLOW
     
    Close mFileNum
    
    Exit Sub
ERR_LOAD_SETTINGS:
    
    Close mFileNum ' close anyway.
    
    setDefaultINISettings
    
    Debug.Print "Error loading " & sINI_FILENAME & " - defaults set, " & Err.Description
    
    ' #020105:
    SaveINISettingsToFile AddSlash(App.Path) & sINI_FILENAME ' save default settings to file.
End Sub

' saves settings to file:
Public Sub SaveINISettingsToFile(sINI_FILEPATH As String)
On Error GoTo ERROR_SAVING_SETTINGS
    Dim mFileNum As Integer
    mFileNum = FreeFile
    
    Open sINI_FILEPATH For Output As mFileNum
    
    Print #mFileNum, sDO_Associate
    
    Print #mFileNum, sLANGUAGE
    
    Print #mFileNum, sSTART_UP_FLOW
    
    Close mFileNum
    
    Debug.Print "Settings saved to: " & sINI_FILEPATH
    
    Exit Sub
ERROR_SAVING_SETTINGS:
    
    Close mFileNum ' close anyway.
    
    Debug.Print "Error saving " & sINI_FILEPATH & ": " & Err.Description
End Sub

' returns the setting:
Public Function getINISetting(sSettingID As String) As String

    Select Case UCase(sSettingID)
    
    Case "SHOULD_ASSOCIATE"
       getINISetting = sDO_Associate
       
    Case "LANGUAGE"
       getINISetting = sLANGUAGE
    
    Case "START_UP_FLOW"
       getINISetting = sSTART_UP_FLOW
    
    Case Else
       Debug.Print "Wrong sSettingID for getINISetting(): " & sSettingID
    End Select

End Function

' sets the setting:
Public Sub setINISetting(sSettingID As String, sValue As String)

    Select Case UCase(sSettingID)
    
    Case "SHOULD_ASSOCIATE"
       sDO_Associate = sValue
       
    Case "LANGUAGE"
       sLANGUAGE = sValue
    
    Case "START_UP_FLOW"
        sSTART_UP_FLOW = sValue
    
    Case Else
       Debug.Print "Wrong sSettingID for setINISetting(): " & sSettingID
    End Select

End Sub


VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cIniConfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' --------------------------------------------------------------------------------
'   __| | __ _  ___  __ _ _ _ __ _    ___  ___  / _|_____ _  _  _ _ _ _ _ ___  ___
'  / _' |/ _' |/ __\/ _' | '_\  ' |  / __|/ _ \| |_ _   _| \/ \/ /_' | '_\ __\/ __|
' ( (_| | (_| | (__  (_| | |  (_| |  \__ \ (_) |  _| | | \      /(_| | |( (/ )\__ \
'  \__,_|\__,_|\___/\__,_|_| \__,_|  |___/\___/|_|   |_|  \_/\_/\__,_|_| \___/|___/
' --------------------------------------------------------------------------------
' Name:     cIniConfig class
' Author:   Noel A. Dacara (noeldacara@hotmail.com)
' Date:     14 April 2005
'
' You can freely use and distribute this file with or without permission provided
' that credits herein are kept unmodified and having acknowledgements is observed.
'
' Notes:    ValueEx property is used for values with length greater than 256.
'           Setting value with either section or key empty will remove several
'           values and is not accepted, use DeleteKey or DeleteSection instead.
'
' Sample:   Dim ARR() As String
'           If (EnumKeys("SectionA", ARR)) Then
'               For i = 0 To UBound(ARR)
'                   Debug.Print ARR(i)
'               Next
'           End If
'
' Inquiries or comments regarding my works and whatsoever are greatly appreciated.
' --------------------------------------------------------------------------------

Private Declare Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
    Private Const MAX_DESTINATION_BUFFER As Long = &H1000 ' 4096
    Private Const MAX_STRING_LENGTH As Long = 320 ' 256
Private Declare Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long

' Variable Declarations
Private m_bExtended As Boolean
Private m_sDefault  As String
Private m_sFile     As String
Private m_sKey      As String
Private m_sSection  As String

'Public Property Get Default() As String
''Returns/sets the default value of a key.
'    Default = m_sDefault
'
'End Property
'
'Public Property Let Default(Value As String)
'    m_sDefault = Value
'
'End Property
'
'Public Property Get File() As String
''Returns/sets the configuration file name with path.
'    File = m_sFile
'
'End Property
'
'Public Property Let File(Value As String)
'    If (InStr(1, Value, ":") = 0) Then
'        Value = App.Path & "\" & Value ' Append application's path
'    End If
'
'    m_sFile = Value
'
'End Property
'
'Public Property Get Key() As String
''Returns/sets the name of key to be used.
'    Key = m_sKey
'
'End Property
'
'Public Property Let Key(Value As String)
'    m_sKey = Value
'
'End Property
'
'Public Property Get Section() As String
''Returns/sets the name of section be used.
'    Section = m_sSection
'
'End Property
'
'Public Property Let Section(Value As String)
'    m_sSection = Value
'
'End Property

Public Property Get Value(Optional Section, Optional Key, Optional Default) As String
Attribute Value.VB_Description = "Returns/sets the value of a key."
'Returns/sets the value of a key.
    If (Not IsMissing(Section)) Then
        m_sSection = CStr(Section)
    End If
    
    If (Not IsMissing(Key)) Then
        m_sKey = CStr(Key)
    End If
    
    If (Not IsMissing(Default)) Then
        m_sDefault = CStr(Default)
    End If
    
    Dim MaxLen  As Long
    
    If (m_bExtended) Then
        MaxLen = MAX_DESTINATION_BUFFER
    Else
        MaxLen = MAX_STRING_LENGTH
    End If
    
    Dim Buffer As String
        Buffer = String$(MaxLen, 0)
        
    Dim Temp As Long
        Temp = GetPrivateProfileString(m_sSection, m_sKey, m_sDefault, Buffer, MaxLen, m_sFile)
        
    Value = Left$(Buffer, Temp)
    
End Property

Public Property Let Value(Optional Section, Optional Key, Optional Default, ByVal Value As String)
    If (Not IsMissing(Section)) Then
        m_sSection = CStr(Section)
    End If
    
    If (Not IsMissing(Key)) Then
        m_sKey = CStr(Key)
    End If
    
    If (Not IsMissing(Default)) Then
        m_sDefault = CStr(Default)
    End If
    
    If (Len(Value) = 0) Then
        Value = m_sDefault ' Write the default value instead
    End If
    
    WritePrivateProfileString m_sSection, m_sKey, Value, m_sFile ' Write to file
    
End Property

'Public Property Get ValueEx(Optional Section, Optional Key, Optional Default) As String
''Returns/sets the value of a key with data greater than normal length.
'    If (Not IsMissing(Section)) Then
'        m_sSection = CStr(Section)
'    End If
'
'    If (Not IsMissing(Key)) Then
'        m_sKey = CStr(Key)
'    End If
'
'    If (Not IsMissing(Default)) Then
'        m_sDefault = CStr(Default)
'    End If
'
'    m_bExtended = True
'    ValueEx = Value
'    m_bExtended = False
'
'End Property
'
'Public Property Let ValueEx(Optional Section, Optional Key, Optional Default, ByVal Value As String)
'    If (Not IsMissing(Section)) Then
'        m_sSection = CStr(Section)
'    End If
'
'    If (Not IsMissing(Key)) Then
'        m_sKey = CStr(Key)
'    End If
'
'    If (Not IsMissing(Default)) Then
'        m_sDefault = CStr(Default)
'    End If
'
'    m_bExtended = True
'    Me.Value = Value
'    m_bExtended = False
'
'End Property

' //-- Public Procedures --//

Public Function DeleteKey(Optional Section, Optional Key) As Boolean
Attribute DeleteKey.VB_Description = "Deletes the specified key in the section given."
'Deletes the specified key in the section given.
    If (Not IsMissing(Section)) Then
        m_sSection = CStr(Section)
    End If
    
    If (Not IsMissing(Key)) Then
        m_sKey = CStr(Key)
    End If
    
    DeleteKey = (Not WritePrivateProfileString(m_sSection, m_sKey, vbNullString, m_sFile) = 0)
    
End Function

'Public Function DeleteSection(Optional Section) As Boolean
''Delete the whole specified section including any existing keys.
'    If (Not IsMissing(Section)) Then
'        m_sSection = CStr(Section)
'    End If
'
'    DeleteSection = (Not WritePrivateProfileString(m_sSection, vbNullString, vbNullString, m_sFile) = 0)
'
'End Function

Public Function EnumKeys(Optional Section, Optional ArrKeys) As Boolean
Attribute EnumKeys.VB_Description = "Enumerate all the keys found of the specified section."
'Enumerate all the keys found of the specified section.
    If (Not IsMissing(Section)) Then
        m_sSection = CStr(Section)
    End If
    
    EnumKeys = GetAll(True, ArrKeys)
    
End Function

'Public Function EnumSections(Optional ArrSections) As Boolean
''Enumeration all sections of the current configuration file.
'    EnumSections = GetAll(False, ArrSections)
'
'End Function

' //-- Private Functions --//

Private Function GetAll(ByRef Keys As Boolean, ByRef StringArray) As Boolean
    Dim Temp    As Long
    Dim Buffer  As String
        Buffer = String$(MAX_DESTINATION_BUFFER, 0)
        
    If (Keys) Then ' Get all sections
        Temp = GetPrivateProfileString(m_sSection, vbNullString, vbNullString, Buffer, MAX_DESTINATION_BUFFER, m_sFile)
    Else
        Temp = GetPrivateProfileString(vbNullString, vbNullString, vbNullString, Buffer, MAX_DESTINATION_BUFFER, m_sFile)
    End If
    
    If (Temp > 0) Then ' Only if data exists
        Buffer = Left$(Buffer, Temp)
    Else
        Exit Function
    End If
    
    ' In the buffer variable, keys/sections are separated by null characters
    If (Len(Buffer) > 0) Then
        ' Split string to an array
        StringArray = Split(Buffer, vbNullChar)
    End If
    
    GetAll = (Not UBound(StringArray) = -1)
    
End Function

' //-- Class Procedures --//

Private Sub Class_Initialize()
    ' Default property value
    m_sFile = App.Path & "\" & App.EXEName & ".ini"
    
End Sub

' Created by Noel A. Dacara | noeldacara@hotmail.com | Davao City, Philippines

VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Cdatabase"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
Option Explicit

Private m_strDbPath As String
Private m_strDbPassword As String
Private m_fso As FileSystemObject
Private m_adoConn As ADODB.Connection
Private m_adoRS As ADODB.Recordset
Private m_adoCmd As ADODB.Command
Private m_strVerificationSQL As String

Private Const m_CstrConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

Public Property Get DbConnection() As ADODB.Connection
    On Error GoTo hErr
    Set DbConnection = m_adoConn
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Sub CloseConnection()
    On Error GoTo hErr
    If m_adoConn.State = adStateOpen Then
        m_adoConn.Close
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Function DbLookup(strField As String, strTableName As String, Optional strCriteria As String) As String
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    
    If Not IsMissing(strCriteria) And Len(strCriteria) > 0 Then
        strSQL = "SELECT " & strField & " FROM " & strTableName & " WHERE " & strCriteria
    Else
        strSQL = "SELECT " & strField & " FROM " & strTableName
    End If
    
    adoRs.Open strSQL, m_adoConn, adOpenKeyset, adLockOptimistic
    
    If adoRs.RecordCount = 0 Then
        DbLookup = ""
    Else
        DbLookup = CStr(adoRs(strField))
    End If
    
    adoRs.Close
    Set adoRs = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Public Sub ExecuteSQL(ByVal strSQLCmd As String)
    On Error GoTo hErr
    m_adoCmd.CommandText = strSQLCmd
    m_adoCmd.CommandType = adCmdText
    m_adoCmd.ActiveConnection = m_adoConn
    m_adoCmd.Execute
    Set m_adoCmd = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Function GetRecordset(ByVal strSQL As String) As ADODB.Recordset
    On Error GoTo hErr
    If m_adoRS.State = adStateOpen Then
        m_adoRS.Close
    End If
    
    m_adoRS.Open strSQL, m_adoConn, adOpenKeyset, adLockOptimistic
    Set GetRecordset = m_adoRS
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Public Sub InitDb(Optional ByVal strDBPath As String, Optional strDbPassword As String)
    On Error GoTo hErr
    If Not IsMissing(strDBPath) Then
        m_strDbPath = strDBPath
    End If
    
    If Not IsMissing(strDbPassword) Then
        m_strDbPassword = strDbPassword
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Sub OpenConnection(Optional ByVal strDBPath As String, Optional strDbPassword As String)
    On Error GoTo hErr
    If Not IsMissing(strDBPath) And Len(strDBPath) > 0 Then
        m_strDbPath = strDBPath
    End If
    
    If Not IsMissing(strDbPassword) And Len(strDbPassword) > 0 Then
        m_strDbPassword = strDbPassword
    End If
    
    If DbExists(m_strDbPath) = True Then
        If m_adoConn.State = adStateClosed Then
            m_adoConn.Open m_CstrConnString & m_strDbPath & ";Jet OLEDB:Database Password=" & m_strDbPassword
        End If
    Else
        Err.Raise vbObjectError + 518, "Cdatabase", "Database not found in "" & m_strDbPath & ""!"
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Function VerifyDatabase(Optional strVerificationSQL As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    
    If Not IsMissing(strVerificationSQL) Then
        m_strVerificationSQL = strVerificationSQL
    End If
    
    If Len(m_strVerificationSQL) = 0 Then
        Err.Raise 91
    End If
    
    If Len(m_strDbPath) = 0 Then
        VerifyDatabase = False
    Else
        On Error GoTo Err_Handler
        Call OpenConnection
        Set adoRs = New ADODB.Recordset
        adoRs.Open m_strVerificationSQL, m_adoConn, adOpenKeyset, adLockOptimistic
        
        If adoRs.RecordCount = 0 Then
            VerifyDatabase = False
        Else
            VerifyDatabase = True
        End If
    End If
    
    adoRs.Close
    Set adoRs = Nothing
    
    Exit Function
    
Err_Handler:
    ' if error is database related, the database is invalid
    If Err.Description Like "*Microsoft Jet*" Then
        VerifyDatabase = False
    End If
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Private Function DbExists(strFilePath As String) As Boolean
    On Error GoTo hErr
    DbExists = m_fso.FileExists(strFilePath)
' CSErrorHandler begin - please do not modify or remove this line
Exit Function
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Function
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Function

Private Sub Class_Initialize()
    On Error GoTo hErr
    Set m_adoConn = New ADODB.Connection
    Set m_fso = New FileSystemObject
    Set m_adoRS = New ADODB.Recordset
    Set m_adoCmd = New ADODB.Command
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Private Sub Class_Terminate()
    On Error GoTo hErr
    Call CloseConnection
    Set m_adoConn = Nothing
    Set m_fso = Nothing
    Set m_adoRS = Nothing
    Set m_adoCmd = Nothing
' CSErrorHandler begin - please do not modify or remove this line
Exit Sub
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Sub
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Sub

Public Property Get DbPassword() As String
    On Error GoTo hErr
    DbPassword = m_strDbPassword
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Property Let DbPassword(ByVal strValue As String)
    On Error GoTo hErr
    m_strDbPassword = strValue
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Property Get DbPath() As String
    On Error GoTo hErr
    DbPath = m_strDbPath
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Property Let DbPath(ByVal strValue As String)
    On Error GoTo hErr
    m_strDbPath = strValue
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Property Get VerificationSQL() As String
    On Error GoTo hErr
    VerificationSQL = m_strVerificationSQL
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

Public Property Let VerificationSQL(ByVal strValue As String)
    On Error GoTo hErr
    m_strVerificationSQL = strValue
' CSErrorHandler begin - please do not modify or remove this line
Exit Property
hErr:
    Select Case MsgBox(Err.Description, vbAbortRetryIgnore + _
       vbCritical, "An Error Occured")
        Case vbAbort
            Screen.MousePointer = vbDefault
            Exit Property
        Case vbRetry
            Resume
        Case vbIgnore
            Resume Next
    End Select
End Property

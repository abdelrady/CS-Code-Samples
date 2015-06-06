Attribute VB_Name = "modAccount"
Option Explicit

Public Function AccountExists(ByVal strIDNo As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & strIDNo & "' AND Discontinued = No"
    adoRs.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset
    AccountExists = Not adoRs.EOF
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

Public Function ItemExists(ByVal strItemCode As String) As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT * FROM tblItems WHERE ItemCode = '" & strItemCode & "' AND Discontinued = No"
    adoRs.Open strSQL, g_dbPRECDb.DbConnection, adOpenKeyset
    
    ItemExists = Not adoRs.EOF
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

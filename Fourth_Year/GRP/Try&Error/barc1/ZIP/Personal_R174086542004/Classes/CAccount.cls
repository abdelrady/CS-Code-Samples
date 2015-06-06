VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CAccount"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private m_lngAccountID As Long
Private m_strIDNo As String
Private m_strLastName As String
Private m_strFirstName As String
Private m_dblCurrentBalance As Double
Private m_blnActive As Boolean
Private m_dtmDateActivated As Date
Private m_dtmDateLastReloaded As Date
Private m_strPicturePath As String
Private m_PRECDb As Cdatabase

Public Property Get AccountID() As Long
    On Error GoTo hErr
    AccountID = m_lngAccountID
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

Public Property Get PicturePath() As String
    On Error GoTo hErr
    PicturePath = m_strPicturePath
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

Public Property Let PicturePath(ByVal strValue As String)
    On Error GoTo hErr
    m_strPicturePath = strValue
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

Public Property Get CurrentBalance() As Double
    On Error GoTo hErr
    CurrentBalance = m_dblCurrentBalance
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

Public Property Let CurrentBalance(dblValue As Double)
    On Error GoTo hErr
    m_dblCurrentBalance = dblValue
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

Public Property Get DateActivated() As Date
    On Error GoTo hErr
    DateActivated = m_dtmDateActivated
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

Public Property Get DateLastReloaded() As Date
    On Error GoTo hErr
    DateLastReloaded = m_dtmDateLastReloaded
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

Public Property Get FirstName() As String
    On Error GoTo hErr
    FirstName = m_strFirstName
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

Public Property Let FirstName(ByVal strValue As String)
    On Error GoTo hErr
    m_strFirstName = strValue
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

Public Property Get IDNo() As String
    On Error GoTo hErr
    IDNo = m_strIDNo
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

Public Property Get LastName() As String
    On Error GoTo hErr
    LastName = m_strLastName
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

Public Property Let LastName(ByVal strValue As String)
    On Error GoTo hErr
    m_strLastName = strValue
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

Public Property Get Active() As Boolean
    On Error GoTo hErr
    Active = m_blnActive
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

Public Function Activate() As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & m_strIDNo & "' AND Discontinued = No"
    'Set adoRs = g_dbPRECDb.GetRecordset(strSQL)
    Set adoRs = New ADODB.Recordset
    Call adoRs.Open(strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic)
    
    If adoRs.RecordCount <> 0 Then
        adoRs("Active") = True
        m_dtmDateActivated = Now
        adoRs("DateActivated") = m_dtmDateActivated
        adoRs.Update
        Activate = True
        m_blnActive = True
    Else
        Activate = False
        Err.Raise vbObjectError + 519, "CAccount", "Cannot found account using the provided ID number!"
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

Public Function Deactivate() As Boolean
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & m_strIDNo & "' AND Discontinued = No"
    'Set adoRs = g_dbPRECDb.GetRecordset(strSQL)
    Set adoRs = New ADODB.Recordset
    Call adoRs.Open(strSQL, g_dbPRECDb.DbConnection, adOpenKeyset, adLockOptimistic)
    
    If adoRs.RecordCount <> 0 Then
        adoRs("Active") = False
        adoRs.Update
        Deactivate = True
        m_blnActive = False
    Else
        Deactivate = False
        Err.Raise vbObjectError + 519, "CAccount", "Cannot found account using the provided ID number!"
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

Public Property Set PRECDb(CDbValue As Cdatabase)
    On Error GoTo hErr
    Set m_PRECDb = CDbValue
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

Public Sub InitAccount(Optional PRECDb As Cdatabase, Optional ByVal strIDNo As String)
    On Error GoTo hErr
    If Not IsMissing(PRECDb) Then
        Set m_PRECDb = PRECDb
        Call GetAccount(strIDNo)
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

Private Sub GetAccount(ByVal strIDNo As String)
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & strIDNo & "' AND Discontinued = No"
    'Set adoRs = m_PRECDb.GetRecordset(strSQL)
    Set adoRs = New ADODB.Recordset
    Call adoRs.Open(strSQL, m_PRECDb.DbConnection, adOpenKeyset, adLockOptimistic)
    
    If adoRs.RecordCount <> 0 Then
        m_lngAccountID = adoRs("AccountID")
        m_strIDNo = strIDNo
        m_strFirstName = adoRs("FirstName")
        m_strLastName = adoRs("LastName")
        m_strPicturePath = IIf(IsNull(adoRs("PicturePath")) = True, "", adoRs("PicturePath"))
        m_blnActive = adoRs("Active")
        m_dblCurrentBalance = adoRs("Balance")
        m_dtmDateActivated = IIf(IsNull(adoRs("DateActivated")) = True, 0, adoRs("DateActivated"))
        m_dtmDateLastReloaded = IIf(IsNull(adoRs("DateLastReloaded")) = True, 0, adoRs("DateLastReloaded"))
    Else
        Err.Raise vbObjectError + 519, "CAccount", "Cannot found account using the provided ID number!"
    End If
    
    adoRs.Close
    Set adoRs = Nothing
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

Public Function Reload(ByVal lngAmount As Long, ByVal strPPReceiptNum As String, _
   ByVal lngUserID As Long) As String
    ' returns the receipt no after reloading
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & m_strIDNo & "' AND Discontinued = No"
    Set adoRs = m_PRECDb.GetRecordset(strSQL)
    
    If adoRs.RecordCount <> 0 Then
        m_dblCurrentBalance = CDbl(adoRs("Balance")) + lngAmount
        adoRs("Balance") = m_dblCurrentBalance
        adoRs("DateLastReloaded") = Now
        adoRs.Update
    Else
        Err.Raise vbObjectError + 519, "CAccount", "Cannot found account using the provided ID number!"
        Exit Function
    End If
    
    adoRs.Close
    Set adoRs = Nothing
    
    Call GetAccount(m_strIDNo)
    
    strSQL = "SELECT * FROM tblLoad"
    Set adoRs = m_PRECDb.GetRecordset(strSQL)
    adoRs.AddNew
    adoRs("AccountID") = m_lngAccountID
    adoRs("PrePrintedReceiptNo").Value = strPPReceiptNum
    adoRs("LoadAmountID").Value = m_PRECDb.DbLookup("LoadAmountID", _
       "tblLoadAmount", "LoadAmount = " & lngAmount)
    adoRs("UserID").Value = lngUserID
    adoRs("LoadingDate").Value = m_dtmDateLastReloaded
    adoRs("ReceiptNo") = Format$(CLng(GetHighestLoadReceiptNo) + 1, "00000000")
    Reload = adoRs("ReceiptNo").Value
    adoRs.Update
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

Private Function GetHighestLoadReceiptNo() As String
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    Set adoRs = New ADODB.Recordset
    strSQL = "SELECT MAX(ReceiptNo) as HighestReceiptNum FROM tblLoad"
    adoRs.Open strSQL, m_PRECDb.DbConnection, adOpenKeyset, adLockOptimistic
    
    If adoRs.RecordCount <> 0 Then
        GetHighestLoadReceiptNo = IIf(IsNull(adoRs("HighestReceiptNum")) = True, _
           "00000000", adoRs("HighestReceiptNum"))
    Else
        GetHighestLoadReceiptNo = "00000000"
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

Public Sub Update()
    On Error GoTo hErr
    Dim adoRs As ADODB.Recordset
    Dim strSQL As String
    
    strSQL = "SELECT * FROM tblAccount WHERE IDNo = '" & m_strIDNo & "' AND Discontinued = No"
    Set adoRs = m_PRECDb.GetRecordset(strSQL)
    
    If adoRs.RecordCount <> 0 Then
        'adoRs("AccountID") = m_lngAccountID
        adoRs("IDNo") = m_strIDNo
        adoRs("FirstName") = m_strFirstName
        adoRs("LastName") = m_strLastName
        adoRs("PicturePath") = m_strPicturePath
        adoRs("Active") = m_blnActive
        adoRs("Balance") = m_dblCurrentBalance
        adoRs("DateActivated") = m_dtmDateActivated
        adoRs("DateLastReloaded") = m_dtmDateLastReloaded
        adoRs.Update
    Else
        Err.Raise vbObjectError + 519, "CAccount", "Cannot found account using the provided ID number!"
    End If
    
    adoRs.Close
    Set adoRs = Nothing
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



Attribute VB_Name = "mPublic"
Option Explicit

' Set textbox to accept only numbers
Private Declare Function GetWindowLong Lib "user32.dll" Alias "GetWindowLongA" (ByVal Hwnd As Long, ByVal nIndex As Long) As Long
    Private Const GWL_STYLE As Long = -16
Private Declare Function SetWindowLong Lib "user32.dll" Alias "SetWindowLongA" (ByVal Hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
    Private Const ES_NUMBER As Long = &H2000&

' Prevent repaint of control to allow faster processing
Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal Hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByRef lParam As Any) As Long
    Private Const WM_SETREDRAW As Long = &HB

' Database settings
Private Const DBPASSWORD As String = "1!PlAnEt2@KiDs3#"
Private Const DBPROVIDER As String = "Microsoft.Jet.OLEDB.4.0"

' Transaction settings
Public FINE_OUTNOCARD As Currency ' Fine for lost or damaged cards
Public RATE_PER_HOUR1 As Currency ' Regular hourly (60 minutes) rate
Public RATE_PER_HOUR2 As Currency ' Less than 30 minutes rate

' Administrator
Public ADMINISTRATOR As Boolean
Public ADMIN_PASSWORD As String

Public CON As Connection
Public REC As Recordset

Private m_iListViewIndex As Long ' Selected Item Index

Public Sub AcceptNumbersOnly(Control As TextBox)
    Dim dwNewLong As Long
    Dim dwOldLong As Long
    
    ' Retrieve current window style for the control
    dwOldLong = GetWindowLong(Control.Hwnd, GWL_STYLE)
    dwNewLong = dwOldLong + ES_NUMBER
    
    SetWindowLong Control.Hwnd, GWL_STYLE, dwNewLong ' Set new style
    Control.Refresh ' Apply new style
    
End Sub

Public Sub ClientTimeIn(RegNumber As String, CardNumber As String, ByVal BasketNumber As Long)
    ' Add client to active transactions
    On Error GoTo Err_Handler
    
    Dim sTime As String
        sTime = Format$(Time$, "HH:MM AM/PM")
        
    CON.Execute "INSERT INTO active (regnum,cardnum,timein,basketnum) VALUES (" & RegNumber & ",'" & CardNumber & "','" & sTime & "'," & BasketNumber & ")"
    
    fMain.lsvActive.ListItems.Add.Selected = True ' Add new item which will hold the new record
    LoadActiveClients fMain.lsvActive ' Refresh lists
    
    Exit Sub
Err_Handler:
    MsgBoxEx "ClientTimeInError", vbCritical, Err.Number
    
End Sub

Public Sub ClientTimeOut(CardNumber As String, Optional RegNumber As Long)
    ' Remove client from active transactions
    On Error GoTo Err_Handler
    
    Dim bLostDamagedCard As Boolean
    
    If (Not RegNumber = 0) Then
        If (Not OpenRecordset("SELECT * FROM active WHERE regnum=" & RegNumber)) Then
            MsgBoxEx "ClientTimeOutLater", vbExclamation
            Exit Sub
        Else
            bLostDamagedCard = True
            CardNumber = CStr(REC("cardnum")) ' Get lost/damaged card number
        End If
    Else
        If (Not OpenRecordset("SELECT * FROM active WHERE cardnum='" & CardNumber & "'")) Then
            MsgBoxEx "ClientTimeOutLater", vbExclamation
            Exit Sub
        End If
    End If
    
    Dim cFine       As Currency
    Dim cRate       As Currency
    Dim cTotal      As Currency
    Dim dTimein     As Date
    Dim dTimeout    As Date
    Dim dElapsed    As Date
    Dim sBasketnum  As String
    
    dTimein = Time ' Temp
    dTimeout = TimeSerial(Hour(dTimein), Minute(dTimein), 0)
    dTimein = CDate(REC("timein"))
    dElapsed = TimeSerial(Hour(dTimeout) - Hour(dTimein), Minute(dTimeout) - Minute(dTimein), 0)
    cRate = CLng(Hour(dElapsed)) * RATE_PER_HOUR1
    sBasketnum = CStr(REC("basketnum"))
    RegNumber = Val(REC("regnum"))
    
    If (CInt(Minute(dElapsed)) < 30) Then
        cRate = cRate + RATE_PER_HOUR2
    Else
        cRate = cRate + RATE_PER_HOUR1
    End If
    
    With fMain
        .picNoCard.Enabled = False
        .picNoCard.Visible = False
        
        .lblTimeout(4) = mPublic.FromRegNumberToName(CStr(RegNumber)) ' Customer Name
        .lblTimeout(6) = Format$(dTimein, "HH:MM AM/PM") ' Time-in
        .lblTimeout(8) = Format$(dTimeout, "HH:MM AM/PM") ' Time-out
        .lblTimeout(10) = "P 0.00" ' Misc Fee
        
        If (.lblTimeout(6) = .lblTimeout(8)) Then ' Time-in & Time-out
            cRate = 0
        End If
        
        CON.BeginTrans
        
        On Error GoTo Err_Rollback
        
        If (bLostDamagedCard) Then ' No card number (lost/damaged)
            CON.Execute "UPDATE cardnums SET lostdamaged=" & True & " WHERE cardnum='" & CardNumber & "'"
            cFine = FINE_OUTNOCARD
            .lblTimeout(10) = "P " & Format$(cFine, "###,##0.00") ' Misc Fee
            
        ElseIf (cRate = 0) Then ' If Time-in & Time-out are the same
            .cmdTimeout(1).Default = True
            .cmdTimeout(2).Visible = False
            
            .lblTimeout(12) = "P 0.00" ' Service Fee
            .lblTimeout(14) = "CANCELLED" ' Total Fees
            
            CON.Execute "DELETE FROM active WHERE cardnum='" & CardNumber & "'"
            mPublic.LoadActiveClients .lsvActive ' Refresh active transactions lists
            
            CON.CommitTrans
            Exit Sub
            ' Cancelled transaction are not saved on the history lists
        End If
        
        cTotal = cRate + cFine
        
        .lblTimeout(12) = "P " & Format$(cRate, "###,##0.00") ' Service Fee
        .lblTimeout(14) = "P " & Format$(cTotal, "###,##0.00") ' Total
        .lblTimeout(16) = sBasketnum ' Basket number
        
        CON.Execute "INSERT INTO history (regnum,servdate,timein,timeout,servrate,penaltyfee,basketnum) VALUES (" & RegNumber & ",'" & Date$ & "','" & dTimein & "','" & dTimeout & "'," & cRate & "," & cFine & "," & sBasketnum & ")"
        CON.Execute "DELETE FROM active WHERE cardnum='" & CardNumber & "'"
        
        LoadActiveClients .lsvActive ' Refresh lists
        LoadClientsHistory Date, .lsvHistory
        
        .dtpHistory.Value = Date
    End With
    
    CON.CommitTrans
    
    Exit Sub
Err_Rollback:
    CON.RollbackTrans
Err_Handler:
    MsgBoxEx "ClientTimeOutError", vbCritical, Err.Number
    
End Sub

Public Function DatabaseConnect(Optional bReconnecting As Boolean) As Boolean
    ' Connect to local database
    On Error Resume Next
    
    Dim sDBFile As String
        sDBFile = cINI.Value("Settings", "Path_Database") ' Get path to database file
        
    If (InStr(1, sDBFile, ":") = 0) Then
        sDBFile = App.Path & "\" & sDBFile ' Append program path
    End If
    
    ' Prepare to connect to database
    
    Set CON = New Connection
        CON.ConnectionString = "Data Source=" & sDBFile
        
    If (Len(DBPASSWORD) > 0) Then
        CON.ConnectionString = CON.ConnectionString & ";Jet OLEDB:Database Password=" & DBPASSWORD
    End If
    
    With CON
        .ConnectionTimeout = 10
        .CursorLocation = adUseClient
        .Provider = DBPROVIDER
        .Open ' Attempt to connect now
    End With
    
    If (CON.State = adStateOpen) Then
        DatabaseConnect = True
    Else
        If (bReconnecting) Then
            MsgBoxEx "DatabaseReconnectionFailed", vbCritical
        Else
            MsgBoxEx "DatabaseConnectionFailed", vbCritical
        End If
    End If
    
End Function

Public Sub DatabaseDisconnect()
    ' Disconnect from active database
    If (Not CON Is Nothing) Then
        On Error Resume Next
        
        If (Not REC Is Nothing) Then
            If (Not REC.State = adStateClosed) Then REC.Close
            Set REC = Nothing
        End If
        
        If (Not CON Is Nothing) Then
            If (Not CON.State = adStateClosed) Then CON.Close
            Set CON = Nothing
        End If
    End If
    
End Sub

Public Function FromNameToRegNumber(ClientName As String) As String
'   Name format: LASTNAME, FIRSTNAME
    Dim sName() As String
        sName = Split(ClientName, ", ")
        
    If (OpenRecordset("SELECT regnum FROM clients WHERE lastname='" & sName(0) & "' AND firstname='" & sName(1) & "'")) Then
        If (Not REC.RecordCount = 0) Then
            FromNameToRegNumber = CStr(REC("regnum"))
        End If
    End If
    
End Function

Public Function FromRegNumberToName(RegNumber As String) As String
'   Name format: LASTNAME, FIRSTNAME
    If (OpenRecordset("SELECT (lastname + ', ' + firstname) AS clientname FROM clients WHERE regnum=" & RegNumber)) Then
        If (Not REC.RecordCount = 0) Then
            FromRegNumberToName = REC("clientname")
        End If
    End If
    
End Function

Public Function FromUserIDToName(UserID As String) As String
    If (OpenRecordset("SELECT username FROM cashiers WHERE userid=" & UserID)) Then
        If (Not REC.RecordCount = 0) Then
            FromUserIDToName = StrConv(REC("username"), vbProperCase)
        End If
    End If
    
End Function

Public Function GivenFirstNameFillTexts(txtFName As TextBox, txtRegnum As TextBox, txtLName As TextBox) As Boolean
'   If firstname is valid then fill regnum and lname textboxes then return True
    If (OpenRecordset("SELECT regnum,lastname,firstname FROM clients WHERE firstname='" & txtFName & "'")) Then
        If (Not REC.RecordCount = 0) Then
            txtRegnum = CStr(REC("regnum")) ' Only the first record will be processed
            txtLName = CStr(REC("lastname"))
            txtFName = CStr(REC("firstname"))
            GivenFirstNameFillTexts = True
        End If
    End If
    
End Function

Public Function GivenLastNameFillTexts(txtLName As TextBox, txtRegnum As TextBox, txtFName As TextBox) As Boolean
'   If firstname is valid then fill regnum and lname textboxes then return True
    If (OpenRecordset("SELECT regnum,lastname,firstname FROM clients WHERE lastname='" & txtLName & "'")) Then
        If (Not REC.RecordCount = 0) Then
            txtRegnum = CStr(REC("regnum")) ' Only the first record will be processed
            txtLName = CStr(REC("lastname"))
            txtFName = CStr(REC("firstname"))
            GivenLastNameFillTexts = True
        End If
    End If
    
End Function

Public Function IsCardNumberActive(CardNumber As String) As Boolean
    ' Check if the specified card number exists on active transactions
    If (OpenRecordset("SELECT cardnum FROM active WHERE cardnum='" & CardNumber & "'")) Then
        IsCardNumberActive = (Not REC.RecordCount = 0)
    End If
    
End Function

Public Function IsCardNumberValid(CardNumber As String) As Boolean
    ' Check if the specified card number is valid
    If (OpenRecordset("SELECT cardnum FROM cardnums WHERE lostdamaged=" & False & "  AND cardnum='" & CardNumber & "'")) Then
        IsCardNumberValid = (Not REC.RecordCount = 0)
    End If
    
End Function

Public Function IsRegNumberActive(RegNumber As String) As Boolean
    ' Check if the specified card number exists on active transactions
    If (OpenRecordset("SELECT regnum FROM active WHERE regnum=" & RegNumber)) Then
        IsRegNumberActive = (Not REC.RecordCount = 0)
    End If
    
End Function

Public Function IsRegNumberValid(RegNumber As String) As Boolean
    ' Check if the specified registration number is valid
    If (OpenRecordset("SELECT regnum FROM clients WHERE regnum=" & RegNumber)) Then
        IsRegNumberValid = (Not REC.RecordCount = 0)
    End If
    
End Function

Public Sub LoadActiveClients(lsvActive As ListView)
    ' Fill listview with the list of clients on active transactions
    If (OpenRecordset("SELECT active.*,clients.* FROM active INNER JOIN clients ON active.regnum=clients.regnum")) Then
        On Error Resume Next
        
        Redraw lsvActive, False
        SaveListViewSelection lsvActive, True
        
        Dim Item As ListItem
        
        While Not REC.EOF
            Set Item = lsvActive.ListItems.Add(, , REC("lastname") & ", " & REC("firstname"), , CStr(REC("gender")))
                Item.SubItems(1) = Format$(REC("timein"), "HH:MM AM/PM")
                Item.SubItems(2) = Format$(TimeSerial(Hour(Time) - Hour(Item.SubItems(1)), Minute(Time) - Minute(Item.SubItems(1)), 0), "HH:MM")
                
            REC.MoveNext
        Wend
        
        LoadListViewSelection lsvActive, True
        Redraw lsvActive, True
    End If
    
End Sub

Public Sub LoadClientsHistory(dDate As Date, lsvHistory As ListView)
    ' Fill listview with the list of served clients of the day
    If (OpenRecordset("SELECT history.*,clients.* FROM history INNER JOIN clients ON history.regnum=clients.regnum WHERE history.servdate=#" & dDate & "# AND history.timein<>history.timeout ORDER BY history.timein DESC")) Then
        On Error Resume Next
        
        Redraw lsvHistory, False
        SaveListViewSelection lsvHistory, True
        
        Dim Item As ListItem
        
        While Not REC.EOF
            Set Item = lsvHistory.ListItems.Add(, , REC("lastname") & ", " & REC("firstname"), , CStr(REC("gender")))
                Item.Tag = CStr(REC("clients.regnum"))
                Item.SubItems(1) = Format$(REC("timein"), "HH:MM AM/PM")
                Item.SubItems(2) = Format$(REC("timeout"), "HH:MM AM/PM")
                
            REC.MoveNext
        Wend
        
        LoadListViewSelection lsvHistory, True
        Redraw lsvHistory, True
    End If
    
End Sub

Public Sub LoadClientsLists(lsvClients As ListView)
    ' Fill listview with the list of registered clients
    If (OpenRecordset("SELECT * FROM clients ORDER BY lastname ASC, firstname ASC")) Then
        On Error Resume Next
        
        Redraw lsvClients, False
        SaveListViewSelection lsvClients, True
        
        Dim Item As ListItem
        
        While Not REC.EOF
            Set Item = lsvClients.ListItems.Add(, , REC("lastname") & ", " & REC("firstname"), , CStr(REC("gender")))
                Item.SubItems(1) = REC("birthdate")
                Item.SubItems(2) = REC("regnum")
                
            REC.MoveNext
        Wend
        
        LoadListViewSelection lsvClients, True
        Redraw lsvClients, True
    End If
    
End Sub

Public Sub LoadSettings()
    If (OpenRecordset("SELECT * FROM settings WHERE setname IS NOT NULL")) Then
        On Error Resume Next
        
        While Not REC.EOF
            Select Case LCase$(REC("setname"))              '
                Case "hourlyrate"                           '
                    RATE_PER_HOUR1 = CCur(REC("setvalue"))  ' rate per hour
                Case "minrate"                              '
                    RATE_PER_HOUR2 = CCur(REC("setvalue"))  ' minimum rate
                Case "nocardfine"                           '
                    FINE_OUTNOCARD = CCur(REC("setvalue"))  ' fine for lost/damaged cards
                Case "password"                             '
                    ADMIN_PASSWORD = CStr(REC("setvalue"))  ' administrator password
            End Select                                      '
                                                            '
            REC.MoveNext                                    '
        Wend
    End If
    
End Sub

Public Function MsgBoxEx(Key As String, Optional Buttons As VbMsgBoxStyle, Optional ErrNumber As Long) As VbMsgBoxResult
    On Error Resume Next
    
    Dim msg() As String
        msg = Split(cINI.Value("MsgBoxStrings", Key), "|")
        msg(0) = Replace$(msg(0), "/n", vbCrLf)
        
    If (Not ErrNumber = 0) Then
        MsgBoxEx = MsgBox(msg(0) & Error$(ErrNumber), Buttons, msg(1) & ErrNumber)
    Else
        MsgBoxEx = MsgBox(msg(0), Buttons, msg(1))
    End If
    
    Err.Clear
    
End Function

Public Function OpenRecordset(Source As String) As Boolean
    On Error GoTo Err_Handler
    
    If (Not REC Is Nothing) Then
        If (Not REC.State = adStateClosed) Then REC.Close
        Set REC = Nothing
    End If
    
    Set REC = New Recordset
    Set REC.ActiveConnection = CON
        REC.CursorLocation = adUseClient
        REC.CursorType = adOpenKeyset
        REC.LockType = adLockOptimistic
        REC.Source = Source
        REC.Open
        
    OpenRecordset = (REC.State = adStateOpen)
    
    Exit Function
Err_Handler:
    ' For debugging purpose only...
    Debug.Print "Error on OpenRecordset function: " & Err.Description
    
End Function

Public Sub Redraw(Control As Control, Allow As Boolean)
    ' Allow control to repaint any visual changes
    SendMessage Control.Hwnd, WM_SETREDRAW, Allow, ByVal 0&
    If (Allow) Then Control.Refresh
    
End Sub

' //-- Private Procedures --//

Private Sub LoadListViewSelection(ListView As ListView, Optional SetFocus As Boolean)
    With ListView
        If (m_iListViewIndex > 0 And m_iListViewIndex <= .ListItems.Count) Then
            .ListItems(m_iListViewIndex).Selected = True
            .SelectedItem.EnsureVisible
            
            If (SetFocus) Then
                On Error Resume Next
                .SetFocus ' May cause an error
            End If
        End If
    End With
    
End Sub

Private Sub SaveListViewSelection(ListView As ListView, Optional ClearItems As Boolean)
    With ListView
        If (.ListItems.Count > 0) Then
            m_iListViewIndex = .SelectedItem.Index
            
            If (ClearItems) Then
                .ListItems.Clear
            End If
        End If
    End With
    
End Sub

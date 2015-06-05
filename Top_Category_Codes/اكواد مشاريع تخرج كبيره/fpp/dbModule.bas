Attribute VB_Name = "dbModule"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com
' =========================================================
' Module for SQL processing
' =========================================================

Option Explicit

' Runs SQL specified in a parameter.
' prints output to frmScreen
' source: Microsoft API
Public Sub runSQL(strSql As String)
    Dim rst As Recordset
    Dim qdf As QueryDef
       
    strSql = "PROCEDURE test1; " & strSql

'GoTo del1
    ' Create a named QueryDef based on the SQL
    ' statement.
    Set qdf = frmMain.Data1.Database.CreateQueryDef("NewQry", strSql)

' Create a temporary snapshot-type Recordset.
    Set rst = qdf.OpenRecordset(dbOpenSnapshot)
    ' Populate the Recordset.
    rst.MoveLast
            
    ' Call EnumFields to print the contents of the
    ' Recordset. Pass the Recordset object and desired
    ' field width.
    EnumFields rst, 15
    
del1:
    ' Delete the QueryDef because this is a
    ' demonstration.
    frmMain.Data1.Database.QueryDefs.Delete "NewQry"

End Sub

' The Sub procedure EnumFields is passed a Recordset object
' from the calling procedure. The procedure then formats and
' prints the fields of the Recordset to the Screen window.
' The intFldLen variable is the desired printed field width.
' Some fields may be truncated.
Sub EnumFields(rst As Recordset, intFldLen As Integer)

    Dim lngRecords As Long, lngFields As Long
    Dim lngRecCount As Long, lngFldCount As Long
    Dim strTitle As String, strTemp As String

    If frmScreen.WindowState = vbMinimized Then
        frmScreen.WindowState = vbNormal
    End If
    frmScreen.Show , frmMain

    ' Set the lngRecords variable to the number of
    ' records in the Recordset.
    lngRecords = rst.RecordCount
    ' Set the lngFields variable to the number of
    ' fields in the Recordset.
    lngFields = rst.Fields.Count
    
    frmScreen.printLine "There are " & lngRecords _
        & " records containing " & lngFields & vbNewLine _
        & " fields in the recordset."
    frmScreen.printLine ""
    
    ' Form a string to print the column heading.
    strTitle = "Record  "
    For lngFldCount = 0 To lngFields - 1
        strTitle = strTitle _
        & Left(rst.Fields(lngFldCount).Name _
        & Space(intFldLen), intFldLen)
    Next lngFldCount
    
    ' Print the column heading.
    frmScreen.printLine strTitle
    frmScreen.printLine ""
    
    ' Loop through the Recordset; print the record
    ' number and field values.
    rst.MoveFirst
    For lngRecCount = 0 To lngRecords - 1

frmScreen.printLine Right(Space(6) & _
            Str(lngRecCount), 6) & "  ", True ' ;
        For lngFldCount = 0 To lngFields - 1
            ' Check for Null values.
            If IsNull(rst.Fields(lngFldCount)) Then
                strTemp = "<null>"
            Else
                ' Set strTemp to the field contents.
                Select Case _
                    rst.Fields(lngFldCount).Type
                    Case 11
                        strTemp = ""
                    Case dbText, dbMemo
                        strTemp = _
                            rst.Fields(lngFldCount)

Case Else
                        strTemp = _
                            Str(rst.Fields(lngFldCount))
                End Select
            End If
            frmScreen.printLine Left(strTemp _
                & Space(intFldLen), intFldLen), True ';
        Next lngFldCount
        frmScreen.printLine ""
        rst.MoveNext
    Next lngRecCount

End Sub




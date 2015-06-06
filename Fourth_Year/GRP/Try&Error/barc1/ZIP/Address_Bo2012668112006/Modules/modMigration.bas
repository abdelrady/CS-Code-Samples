Attribute VB_Name = "modMigration"
Option Explicit

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

Dim objExcel        As Object
Dim objWorkbook     As Object
Dim objWorksheet    As Object

Public Function ExcelFileOpen(frm As Form, FileNameN As String) As Boolean

On Error GoTo ExitSub
ExcelFileOpen = False

Set objExcel = Nothing
Set objWorkbook = Nothing
Set objWorksheet = Nothing
Set objExcel = GetObject(, "Excel.Application")
If Err.Number Then
   Err.Clear
    Set objExcel = CreateObject("Excel.Application")
   If Err.Number Then
      MsgBox "Can't open Excel."
   End If
End If
On Error GoTo ExitSub
objExcel.Visible = True
Set objWorkbook = objExcel.Workbooks.Open(FileNameN)
ExcelFileOpen = True

Exit Function
ExitSub:
MsgBox "Please run Microsoft Excel before clicking Run Excel button.", vbExclamation, "Information"
End Function

Public Sub MineDataNow(lstview As ListView, frm As Form)
Dim i    As Long
Dim n    As Long
Dim l    As Long
Dim Col1 As Long
Dim Row1 As Long
Dim Col2 As Long
Dim Row2 As Long

On Error GoTo WriteMyError
Set objWorksheet = objWorkbook.ActiveSheet
l = 0
With frm
    Col1 = Val(.txtColumn(0).Text)
    Row1 = Val(.txtRow(0).Text)
    Col2 = Val(.txtColumn(1).Text)
    Row2 = Val(.txtRow(1).Text)
    For n = 1 To lstview.ColumnHeaders.count
        lstview.ColumnHeaders(n).Width = lstview.Width / lstview.ColumnHeaders.count
    Next
    For n = Row1 To Row2
        lstview.ListItems.Add , , n
    Next
    For i = 1 To (Col2 - Col1) + 1
        .progbar.Value = ((i - 1) / (Col2 - Col1)) * 100
        For n = Row1 To Row2
            lstview.ListItems(n - Row1 + 1).SubItems(i) = objWorksheet.Cells(n, i + Col1 - 1).Value
        Next
        DoEvents
    Next
End With
WriteMyError:
Set objWorksheet = Nothing
End Sub

Public Function FieldType(TypeNumber As Long, Optional userType As String, Optional MyType As String) As String
Dim TheType
  
  If MyType <> "" Then
    TheType = MyType
  Else
    TheType = TypeNumber
  End If
  Select Case TheType
    '1-string 2-date 3-number
    Case 16, "adTinyInt": FieldType = "adTinyInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 16, FieldType)
    Case 2, "adSmallInt": FieldType = "adSmallInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 2, FieldType)
    Case 3, "adInteger": FieldType = "adInteger": userType = 3: FieldType = IIf(Len(MyType) > 0, 3, FieldType)
    Case 20, "adBigInt": FieldType = "adBigInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 20, FieldType)
    Case 17, "adUnsignedTinyInt": FieldType = "adUnsignedTinyInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 17, FieldType)
    Case 18, "adUnsignedSmallInt": FieldType = "adUnsignedSmallInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 18, FieldType)
    Case 19, "adUnsignedInt": FieldType = "adUnsignedInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 19, FieldType)
    Case 21, "adUnsignedBigInt": FieldType = "adUnsignedBigInt": userType = 3: FieldType = IIf(Len(MyType) > 0, 21, FieldType)
    Case 4, "adSingle": FieldType = "adSingle": FieldType = IIf(Len(MyType) > 0, 4, FieldType)
    Case 5, "adDouble": FieldType = "adDouble": userType = 3: FieldType = IIf(Len(MyType) > 0, 5, FieldType)
    Case 6, "adCurrency": FieldType = "adCurrency": userType = 3: FieldType = IIf(Len(MyType) > 0, 6, FieldType)
    Case 14, "adDecimal": FieldType = "adDecimal": userType = 3: FieldType = IIf(Len(MyType) > 0, 14, FieldType)
    Case 131, "adNumeric": FieldType = "adNumeric": userType = 3: FieldType = IIf(Len(MyType) > 0, 131, FieldType)
    Case 11, "adBoolean": FieldType = "adBoolean": userType = 4: FieldType = IIf(Len(MyType) > 0, 11, FieldType)
    Case 132, "adUserDefined": FieldType = "adUserDefined": FieldType = IIf(Len(MyType) > 0, 132, FieldType)
    Case 12, "adVariant": FieldType = "adVariant": FieldType = IIf(Len(MyType) > 0, 12, FieldType)
    Case 72, "adGUID": FieldType = "adGUID": FieldType = IIf(Len(MyType) > 0, 72, FieldType)
    Case 7, "adDate": FieldType = "adDate": userType = 2: FieldType = IIf(Len(MyType) > 0, 7, FieldType)
    Case 133, "adDBDate": FieldType = "adDBDate": userType = 2: FieldType = IIf(Len(MyType) > 0, 133, FieldType)
    Case 134, "adDBTime": FieldType = "adDBTime": userType = 2: FieldType = IIf(Len(MyType) > 0, 134, FieldType)
    Case 135, "adDBTimeStamp": FieldType = "adDBTimeStamp": userType = 2: FieldType = IIf(Len(MyType) > 0, 135, FieldType)
    Case 8, "adBSTR": FieldType = "adBSTR": userType = 1: FieldType = IIf(Len(MyType) > 0, 8, FieldType)
'    Case 129: Fieldtype = "adChar": userType = 1: Fieldtype = IIf(Len(MyType) > 0, 129, Fieldtype)
    Case 200, "adVarChar": FieldType = "adVarChar": userType = 1: FieldType = IIf(Len(MyType) > 0, 200, FieldType)
    Case 201, "adLongVarChar": FieldType = "adLongVarChar": userType = 1: FieldType = IIf(Len(MyType) > 0, 201, FieldType)
    Case 130, "adWChar": FieldType = "adWChar": userType = 1: FieldType = IIf(Len(MyType) > 0, 130, FieldType)
    Case 202, "adVarWChar": FieldType = "adVarWChar": userType = 1: FieldType = IIf(Len(MyType) > 0, 202, FieldType)
    Case 203, "adLongVarWChar": FieldType = "adLongVarWChar": userType = 1: FieldType = IIf(Len(MyType) > 0, 203, FieldType)
    Case 128, "adBinary": FieldType = "adBinary": userType = 3: FieldType = IIf(Len(MyType) > 0, 128, FieldType)
    Case 203, "adVarBinary": FieldType = "adVarBinary": userType = 3: FieldType = IIf(Len(MyType) > 0, 203, FieldType)
    Case 205, "adLongVarBinary": FieldType = "adLongVarBinary": userType = 3: FieldType = IIf(Len(MyType) > 0, 205, FieldType)
  End Select
  
End Function

Public Function cType(ByVal Value As ADOX.DataTypeEnum, userType As String) As String
  '16,2,3,20,17,18,19,21,4,5,6,14,131,11,132,12,72,7,133,134,135,8,129,200,201,130,202,203,128,204,205
  '0123158595 permata 202.187.45.87:8001/MEGgateway.asp?charge=0&username=form&password=kvinzdz&destination=
  Select Case Value
    '1-string 2-date 3-number
    Case adTinyInt, 16: cType = "adTinyInt": userType = 3
    Case adSmallInt, 2: cType = "adSmallInt": userType = 3
    Case adInteger, 3: cType = "adInteger": userType = 3
    Case adBigInt, 20: cType = "adBigInt": userType = 3
    Case adUnsignedTinyInt, 17: cType = "adUnsignedTinyInt": userType = 3
    Case adUnsignedSmallInt, 18: cType = "adUnsignedSmallInt": userType = 3
    Case adUnsignedInt, 19: cType = "adUnsignedInt": userType = 3
    Case adUnsignedBigInt, 21: cType = "adUnsignedBigInt": userType = 3
    Case adSingle, 4: cType = "adSingle"
    Case adDouble, 5: cType = "adDouble": userType = 3
    Case adCurrency, 6: cType = "adCurrency": userType = 3
    Case adDecimal, 14: cType = "adDecimal": userType = 3
    Case adNumeric, 131: cType = "adNumeric": userType = 3
    Case adBoolean, 11: cType = "adBoolean": userType = 4
    Case adUserDefined, 132: cType = "adUserDefined"
    Case adVariant, 12: cType = "adVariant"
    Case adGUID, 72: cType = "adGUID"
    Case adDate, 7: cType = "adDate": userType = 2
    Case adDBDate, 133: cType = "adDBDate": userType = 2
    Case adDBTime, 134: cType = "adDBTime": userType = 2
    Case adDBTimeStamp, 135: cType = "adDBTimeStamp": userType = 2
    Case adBSTR, 8: cType = "adBSTR": userType = 1
    Case adChar, 129: cType = "adChar": userType = 1
    Case adVarChar, 200: cType = "adVarChar": userType = 1
    Case adLongVarChar, 201: cType = "adLongVarChar": userType = 1
    Case adWChar, 130: cType = "adWChar": userType = 1
    Case adVarWChar, 202: cType = "adVarWChar": userType = 1
    Case adLongVarWChar, 203: cType = "adLongVarWChar": userType = 1
    Case adBinary, 128: cType = "adBinary": userType = 3
    Case adVarBinary, 203: cType = "adVarBinary": userType = 3
    Case adLongVarBinary, 205: cType = "adLongVarBinary": userType = 3
    Case Else: cType = Value
  End Select
End Function

Public Function RunNormal(sFile$, Optional cmdLine$, Optional sPath$, Optional ExecuteStyle As String) As Boolean
Dim TheDisplay      As Long

If ExecuteStyle = "" Then
    TheDisplay = vbNormalFocus
Else
    TheDisplay = Val(ExecuteStyle)
End If
If ShellExecute(Screen.ActiveForm.hWnd, vbNullString, sFile, cmdLine, sPath, TheDisplay) <= 32 Then
Else
    RunNormal = True
End If
End Function

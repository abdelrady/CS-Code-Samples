Attribute VB_Name = "otherModule"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/



' info@emu8086.com
' =========================================================
' Module of all kind of general functions/variables.
' =========================================================

Option Explicit


Public currentRunPointer As cBlock ' pointer to current block (running).
Public currentFileName As String   ' current loaded file name (with path).

' #020105:
Public currentPATH As String ' current working folder (for functions).

' returns the first cBlock that has its action
' set to parameter passed to function:
Public Function findBlock(sAction As String) As cBlock
    Dim mb As cBlock
    
    For Each mb In frmMain.theBlockCollection
       If mb.zAction = sAction Then
            Set findBlock = mb
            Exit Function
       End If
    Next mb
    
    mBox "Block: " & sAction & " - not found!"
    Set findBlock = Nothing
End Function


' returns the next block following the block passed as a
' parameter (cb),
' in case parameter sLineCaption isn't "" looks for a line with
' this caption that is connected to current block (cb)
' and returns the block to which it is connected (used for IF logic).
Public Function getNextBlock(cb As cBlock, sLineCaption As String) As cBlock

    If cb Is Nothing Then
        Set getNextBlock = Nothing
        Exit Function
    End If
    
    Dim cl As cLine
    
    For Each cl In frmMain.theLineCollection
        If (cl.sFrom = cb.TagID) And ((StrComp(cl.sCaption, sLineCaption, vbTextCompare) = 0) Or (sLineCaption = "")) Then
            Set getNextBlock = frmMain.theBlockCollection(cl.sTo)
            Exit Function
        End If
    Next cl
    
    
    
    If sLineCaption = "" Then
        mBox "Block: " & cb.TagID & " - NOT CONNECTED!"
    Else
        mBox "Block: " & cb.TagID & " - no connection with: " & sLineCaption
    End If
    
    Set getNextBlock = Nothing
    
End Function





Public Function getToken(ByRef s As String, iToken As Integer, delim As String) As String
    Dim sResult As String
    Dim currentToken As Integer
    Dim l As Long
    Dim i As Long
    Dim c As String
    
    currentToken = 0
    sResult = ""
    l = Len(s)
    
    For i = 1 To l
         
        c = Mid(s, i, 1)
    
        If c = delim Then
            currentToken = currentToken + 1
            ' no need to continue:
            If currentToken > iToken Then GoTo exit_for
        ElseIf currentToken = iToken Then
            sResult = sResult & c
        End If
    
    Next i
    
exit_for:
   getToken = sResult
    
End Function

' returns required parameter, used when calling functions with
'  several parameters:
Public Function getPar(i As Integer, Source As String) As String
    getPar = Trim(getToken(Source, i, ","))
End Function

' in case parameter (sFuncName) is an internal function - executes it,
'   and returns True.
' otherwise does nothing, and returns False:
Public Function executeInternalFunction(sFuncName As String, sParameters As String, sResultKeeper As String) As Boolean
    Dim sResult As String   ' store result of a function (if any).
    
    sResult = ""
    
    Select Case UCase(sFuncName)
    
    Case "CLEAR" ' receives nothing, returns nothing
        frmScreen.Show , frmMain
        frmScreen.clearScreen
    
    Case "FIX"  ' receives a number, returns fixed number
        sParameters = frmVars.ifVarGetValue(sParameters)
        sParameters = removeQuotes(sParameters)
        sResult = mFix(sParameters)
    
    Case "FILEDIALOG" ' receives file types, returns selected file
        sParameters = frmVars.ifVarGetValue(sParameters)
        sParameters = removeQuotes(sParameters)
        sResult = getFileFromDialogBox(sParameters)
    
    Case "EXTRACTFILENAME" ' receives full file path, returns only the file
        sParameters = frmVars.ifVarGetValue(sParameters)
        sParameters = removeQuotes(sParameters)
        sResult = ExtractFileName(sParameters)
        
    Case "" ' do nothing.
    
    Case Else  ' if it's not one of our commands, then it's a filename:
        executeInternalFunction = False
        Exit Function
    End Select
    
    If sResultKeeper <> "" Then
       frmVars.setVar sResultKeeper, sResult
    End If
    
    ' someting was executed (or sFuncName=""):
    executeInternalFunction = True
End Function

' shows a dialog box, with file types passed as parameter,
'  format: "gif,jpg" (converted by function to MS CommonDialog format):
Private Function getFileFromDialogBox(sFileTypes As String) As String
On Error GoTo fb_canceled

    frmMain.CommonDialog1.InitDir = App.Path ' 1.88
    
    
    frmMain.CommonDialog1.Flags = cdlOFNHideReadOnly

    frmMain.CommonDialog1.Filter = convertTypeFormatB(sFileTypes)
    frmMain.CommonDialog1.DefaultExt = "gif" ' doesn't really matter on open.
    frmMain.CommonDialog1.CancelError = True
    
    ' clear, since there may be a FPP file
    '   opened/saved previously:
    frmMain.CommonDialog1.FileName = ""
    
    frmMain.CommonDialog1.ShowOpen
    
    getFileFromDialogBox = frmMain.CommonDialog1.FileName
    ' do not store it, since it may apper when
    '   trying to open/save FPP files (it won't be nice):
    frmMain.CommonDialog1.FileName = ""
    
    Exit Function
fb_canceled:
    getFileFromDialogBox = ""
    Debug.Print "getFileFromDialogBox() - canceled."
End Function

' converts string of this type: "gif,jpg"
' to: "gif files|*.gif|jpg files|*.jpg"
Private Function convertTypeFormatA(sFileTypes As String) As String
    Dim i As Integer
    Dim sResult As String
    Dim s As String
    
    sResult = ""
    
    i = 0
    s = getPar(i, sFileTypes)
    
    Do While s <> ""
        ' add | to separate from previous parameter:
        If sResult <> "" Then
            sResult = sResult & "|"
        End If
        
        sResult = sResult & s & " files|*." & s
        
        i = i + 1
        s = getPar(i, sFileTypes)
    Loop
    
    convertTypeFormatA = sResult
End Function

' converts string of this type: "gif,jpg"
' to: "gif and jpg|*.gif;*.jpg"
Private Function convertTypeFormatB(sFileTypes As String) As String
    Dim i As Integer
    Dim sDescr As String
    Dim sTypes As String
    Dim s As String
    
    sDescr = ""
    sTypes = ""
    
    i = 0
    s = getPar(i, sFileTypes)
    
    Do While s <> ""
        ' add | to separate from previous parameter:
        If sDescr <> "" Then
            sDescr = sDescr & ", "
            sTypes = sTypes & ";"
        End If
        
        sDescr = sDescr & s
        sTypes = sTypes & "*." & s
                
        i = i + 1
        s = getPar(i, sFileTypes)
    Loop
    
    If sDescr = "" Then
        convertTypeFormatB = ""
    Else
        convertTypeFormatB = sDescr & " files|" & sTypes
    End If
End Function

' evaluates a string, and fixes the number,
'  in case received isn't a number, returns 0:
Public Function mFix(s As String) As String
    mFix = Fix(Val(s))
End Function


' translates the source:
Public Function cLang(Source As String) As String
   Dim i As Integer

   ' 1.88
   ' we use English only!
   cLang = Source
   Exit Function
   
   

   For i = 0 To frmLang.lstSource.ListCount - 1
        If (StrComp(frmLang.lstSource.List(i), Source, vbTextCompare) = 0) Then
            cLang = frmLang.lstTranslation.List(i)
            Exit Function
        End If
   Next i
       
   Debug.Print "tranLng(" & Source & ") - can not translate!"
   cLang = ""
End Function

' adds terminating slash if it's not there.
' used instead of always adding a slash to App.Path ,
'  because it is wrong when path is "C:\" (slash is already there).
Public Function AddSlash(Source As String) As String
    Dim l As Long
    
    l = Len(Source)
    If (l > 0) Then
        If (Mid(Source, l, 1) = "\") Then
            AddSlash = Source
        Else
            AddSlash = Source & "\"
        End If
    Else
        AddSlash = Source & "\"
        Debug.Print "Empty path passed to AddSlash()"
    End If
End Function

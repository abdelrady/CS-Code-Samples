Attribute VB_Name = "Module1"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/



' info@emu8086.com
' =========================================================
' Public declarations for the program
' =========================================================

Option Explicit

' function for opening HTML help files:
Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
' contants for ShellExecute function:
Public Const SW_SHOWDEFAULT = 10
Public Const SW_SHOWNORMAL = 1


' is True when GUI objects (shp objects on frmMain) are
'  not loaded, and program cannot be edited, this is
'  used to increase the execution speed:
Public bGUI As Boolean

' if True application is terminated when flow
'   gets to "end" (or error). Used when running from
'   prompt:
Public CLOSE_APP_ON_END As Boolean

' is set to "True" when it's required to close
'   application after frmScreen and frm_mBox are closed:
Public bTERMINATE_ON_CLOSE As Boolean

' keeps the number of seconds elapsed since
'  midnight when program begins:
Public STARTED_TIME As Single

' is set to true when current program is modified
'   and should be saved:
Public bIS_MODIFIED As Boolean

' the maximum index used for array of shp() objects on frmMain:
Public MAX_SHAPE As Integer
' the maximum index used for array of ln() objects on frmMain:
Public MAX_LINE As Integer

' to get associated cBlock with shp object use its tag:
'  = theBlockCollection(frmMain.shp(SELECTED_SHAPE).Tag)

' current selected shp object (not index of cBlock):
Public SELECTED_SHAPE As Integer
' previously selected shp object (not index of cBlock):
Public PREV_SELECTED_SHAPE As Integer
' currently dragged shp object (not index of cBlock):
Public DRAGGED_SHAPE As Integer

' should be set to TRUE when it is required to close
'   frmWindow without continuing with the flow:
Public FORCE_CLOSE As Boolean


' is set to "True" when frmScreen is visible,
'   used to prevent loading the form when checking
'    its visibility:
Public b_frmScreenVisible As Boolean

' is set to "True" when frm_mBox is visible,
'   used to prevent loading the form when checking
'    its visibility:
Public b_frm_mBoxVisible As Boolean

' execution of this program starts here:

Sub Main()
    Dim bRUN_WITHOUT_GUI As Boolean ' 1.88
    bRUN_WITHOUT_GUI = False

    Dim CmdLine As String
    CmdLine = Trim(Command)

    myChDir App.Path ' 1.88

    LoadINISettingsFromFile App.EXEName & ".ini"

    ' when no parameter is passed to EXE, then check if there is
    '   a flow in INI file that should be loaded:
    If CmdLine = "" Then
        CmdLine = Trim(getINISetting("START_UP_FLOW"))
        
        ' 1.88
        If Len(CmdLine) > 0 Then bRUN_WITHOUT_GUI = True
        
    End If


    If CmdLine = "" Then
       ' association is made (checked) only when
       '   application started without any flow loaded:
       MakeAssociation_IF_REQUIRED
       CLOSE_APP_ON_END = False
       frmMain.Show
    Else
        
        ' is inside "" ?
       If ("""" = Mid(CmdLine, 1, 1)) Then
          CmdLine = Mid(CmdLine, 2, Len(CmdLine) - 2)
       End If
        
       ' #020105:
       ' for checkFileAndPath(), to make it look for a file in EXE's
       '  folder when path is not specified:
       currentPATH = AddSlash(App.Path)
    
    
    
       ' #020105:
       ' checkFileAndPath() returns "" when file not found,
       ' so we keep original file name, to make an error
       ' message be informative:
       Dim sT As String
       sT = CmdLine

       CmdLine = checkFileAndPath(CmdLine)
       If CmdLine = "" Then
            MsgBox "File: " & sT & vbNewLine & "Not found"
            Terminate_APPLICATION  ' 1.88  TERMINATE THE PROGRAM!!!
            Exit Sub
       End If

            ' 1.88
            ' I decided to load it in editor instead
            ' when from command prompt, and regular no-GUI
            ' execution when loaded from ini file:
            
            If bRUN_WITHOUT_GUI Then
                ' close when flow ends:
                  CLOSE_APP_ON_END = True
         
                  ' just load, don't show:
                  Load frmMain
            
                  ' turn off the GUI:
                  '   (this will set bGUI = False)
                  frmMain.chk_LOAD_GUI.Value = 0
            
                   ' load the project file passed as parameter:
                  frmMain.load_FILE CmdLine
                
                   ' set turbo speed (no delay):
                  frmMain.scroll_ExecutionDelay.Value = 0
                
                   ' start the execution:
                  frmMain.cmdRun_ClickP
            Else
                CLOSE_APP_ON_END = False
                
                ' just load, don't show:
                Load frmMain
                    
                ' hide selector:
                frmMain.shp_Selector.Visible = False
                
                ' load the project file passed as parameter:
                frmMain.load_FILE CmdLine
               
                ' reset the selection:
                PREV_SELECTED_SHAPE = -1
                SELECTED_SHAPE = -1
                
                frmMain.Show
                
            End If

     End If
End Sub

' This function checks that the file path, and adds path
' even if we received only the filename from the prompt
'  (assumes it is in program's folder):
' It also checks the existance of the file, and in case
'  it doesn't exist returns an empty string.
Public Function checkFileAndPath(ByVal s As String) As String
    
    If s = "" Then
        checkFileAndPath = ""
        Exit Function
    End If
        
    ' file name could be on local, or network drive:
    ' "G:\Projects\TZ\tz0081in\d.tzr"
    ' "\\ORT\SYS\USERS\MARGOLIN\PROJECTS\TZ\TZ0081IN\d.tzr"
        
    If FileExists(s) And ((Mid(s, 2, 1) = ":") Or (Mid(s, 1, 2) = "\\")) Then
        checkFileAndPath = s
    Else
        ' #020105:
        s = currentPATH & s

        If FileExists(s) Then
            checkFileAndPath = s
        Else
            checkFileAndPath = ""
        End If
    End If
    
End Function

' returns True when file exists, and False when not,
'   (returns True for directory also):
Public Function FileExists(ByVal sFileName As String) As Boolean
Dim i As Integer
On Error GoTo NotFound
    i = GetAttr(sFileName)
    
FileExists = True

Exit Function
NotFound:
    FileExists = False
End Function

' make association only when required.
Public Sub MakeAssociation_IF_REQUIRED()
    
    If StrComp(getINISetting("SHOULD_ASSOCIATE"), "ASSOCIATE_IF_REQUIRED=YES", vbTextCompare) <> 0 Then
        ' ini settings do not allow to associate.
        Exit Sub
    End If
    
    Dim sEXE_FILEPATH As String
    sEXE_FILEPATH = AddSlash(App.Path) & App.EXEName & ".exe"
    
    ' Check the registry and write only when it's not what we expect:
    Dim sValue As String
    
    ' the check is case-sensitive, though, it's not required:
    Call fReadValue("HKCR", ".fpp", "", "S", "", sValue)
    If (sValue <> "FlowProgram") Then GoTo make_association
    Call fReadValue("HKCR", "FlowProgram", "", "S", "", sValue)
    If (sValue <> "Flow Program Project") Then GoTo make_association
    Call fReadValue("HKCR", "FlowProgram\DefaultIcon", "", "S", "", sValue)
    If (sValue <> sEXE_FILEPATH & ",0") Then GoTo make_association
    Call fReadValue("HKCR", "FlowProgram\shell\open\command", "", "S", "", sValue)
    If (sValue <> sEXE_FILEPATH & " """ & "%1" & """") Then GoTo make_association
    
    Exit Sub

make_association:
    Call fWriteValue("HKCR", ".fpp", "", "S", "FlowProgram")
    Call fWriteValue("HKCR", "FlowProgram", "", "S", "Flow Program Project")
    Call fWriteValue("HKCR", "FlowProgram\DefaultIcon", "", "S", sEXE_FILEPATH & ",0")
    Call fWriteValue("HKCR", "FlowProgram\shell\open\command", "", "S", sEXE_FILEPATH & " """ & "%1" & """")
    
    Debug.Print "Association made: " & sEXE_FILEPATH
End Sub

'''' depricated, it doesn't seem to be good, since this works
''''   only after running the flow.
'''' replaced with frmLists.
''''
''''' procedure fills the ComboBox passed as a parameter
''''' with all currenly known variable names:
''''Public Sub setVarNamesToCombo(cbox As ComboBox)
''''    Dim i As Integer
''''    cbox.Clear
''''    For i = 1 To frmVars.grid.Cols - 1
''''        cbox.AddItem frmVars.grid.TextMatrix(0, i)
''''    Next i
''''End Sub

' returns the path without the file name:
'  (with the last slash)
Public Function ExtractFilePath(sFullPath As String) As String
    Dim i As Long

    For i = Len(sFullPath) To 1 Step -1
        If Mid(sFullPath, i, 1) = "\" Then
            ExtractFilePath = Left(sFullPath, i)
            Exit Function
        End If
    Next i
    
    ExtractFilePath = ""
End Function

' returns the file name without the path:
Public Function ExtractFileName(sFullPath As String) As String
    Dim lFLEN As Long   ' full path length (with file name).
    Dim lPLEN As Long   ' path only length.
    lFLEN = Len(sFullPath)
    lPLEN = Len(ExtractFilePath(sFullPath))
    ExtractFileName = Right(sFullPath, lFLEN - lPLEN)
End Function

' function replaces the first occurrence of sFind in
' source string with sRep.
' case insensitive.
' the actual parameter is modified (passed as pointer).
' returns TRUE when replaced something, otherwise FALSE.
Public Function replaceFirst(ByRef Source As String, sFind As String, sRep As String) As Boolean
    Dim lPos As Long
    
    lPos = InStr(1, Source, sFind, vbTextCompare)
    
    If lPos > 0 Then
        Dim leftPart As String
        Dim rightPart As String
        leftPart = Left(Source, lPos - 1)
        rightPart = Right(Source, Len(Source) - lPos + 1 - Len(sFind))
        Source = leftPart & sRep & rightPart
        replaceFirst = True ' replaced!
    Else
        Source = Source  ' no change.
        replaceFirst = False ' not found!
    End If
End Function

' function replaces ALL occurrence of sFind in
' source string with sRep.
' case insensitive.
' the actual parameter is NOT modified.
Public Function replaceALL(ByVal Source As String, sFind As String, sRep As String) As String
    Dim r As Boolean

    Do
        r = replaceFirst(Source, sFind, sRep)
    Loop While r
    
    replaceALL = Source
End Function
 
 ' returns source with vbNewLine replaced by [\n]
Public Function removeNewLine(Source As String) As String
    removeNewLine = replaceALL(Source, vbNewLine, "[\n]")
End Function

 ' returns source with [\n] replaced by vbNewLine
Public Function returnNewLine(Source As String) As String
    returnNewLine = replaceALL(Source, "[\n]", vbNewLine)
End Function

Public Function removeQuotes(s As String) As String
    Dim l As Long
    
    l = Len(s)
    
    ' to avoid problems with empty strings:
    If l = 0 Then
        removeQuotes = ""
        Exit Function
    End If
    
    ' removes only when 2 quotes found:
    If (Mid(s, 1, 1) = """") And (Mid(s, l, 1) = """") Then
        removeQuotes = Mid(s, 2, l - 2)
    Else
        removeQuotes = s    ' no changes.
    End If
End Function

' replacement for mbox function:
Public Function mBox(Prompt As String, Optional owner As Form)
On Error GoTo error_showing_mbox

    ' it's up to frm_mBox to clear the message
    '   when user closes it, until that all messages
    '    are added one after another:
    frm_mBox.txtMessage.Text = _
        frm_mBox.txtMessage.Text & _
             Prompt & vbNewLine
    
    If owner Is Nothing Then
        frm_mBox.Show , frmMain
    Else
        frm_mBox.Show , owner
    End If
    
    Exit Function
error_showing_mbox:
    Debug.Print "Error on mBox(" & Prompt & ") -> " & Err.Description
    ' in case we cannot show the message box, try setting to
    '   lblMessage of frmMain:
    'frmMain.lblMessage.Caption = Prompt
    'frmMain.lblMessage.Visible = True
    MsgBox Prompt
End Function


Public Sub Terminate_APPLICATION()
    End
End Sub


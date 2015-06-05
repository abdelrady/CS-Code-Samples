VERSION 5.00
Begin VB.Form frmWindow 
   Caption         =   "Window"
   ClientHeight    =   3945
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   4800
   LinkTopic       =   "Form1"
   ScaleHeight     =   3945
   ScaleWidth      =   4800
   Begin VB.TextBox objTBOX 
      Height          =   360
      Index           =   0
      Left            =   30
      TabIndex        =   3
      Text            =   "objTBOX"
      Top             =   975
      Visible         =   0   'False
      Width           =   1305
   End
   Begin VB.PictureBox objPIC 
      AutoRedraw      =   -1  'True
      DrawWidth       =   3
      ForeColor       =   &H00000000&
      Height          =   945
      Index           =   0
      Left            =   2940
      ScaleHeight     =   59
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   64
      TabIndex        =   2
      Top             =   105
      Visible         =   0   'False
      Width           =   1020
   End
   Begin VB.TextBox objTAREA 
      Height          =   720
      Index           =   0
      Left            =   1500
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   1
      Text            =   "frmWindow.frx":0000
      Top             =   225
      Visible         =   0   'False
      Width           =   1245
   End
   Begin VB.CommandButton objBUTTON 
      Caption         =   "objBUTTON"
      Height          =   480
      Index           =   0
      Left            =   90
      TabIndex        =   0
      Top             =   180
      Visible         =   0   'False
      Width           =   1245
   End
End
Attribute VB_Name = "frmWindow"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com






Option Explicit

' collection of all GUI objects on form:
Public theGUI As GUI_Collection

' window events handlers:
Dim sDo_on_load As String
Dim sDo_on_resize As String

' keep the original caller function, to avoid
'  calling resize function over and over:
Dim sCallerFunction As String
Dim bAllow_resize As Boolean

Private Sub Form_Activate()
    bWINDOW_ACTIVATED = True
End Sub

Private Sub Form_Load()
    ' don't allow resizing!
    bAllow_resize = False

    bWINDOW_LOADED = True
    
    sCallerFunction = currentFileName
        
    Me.Icon = frmMain.Icon
    
    FORCE_CLOSE = False

    ' initialize the collection:
    Set theGUI = New GUI_Collection
    Set theGUI.Parent = Me

    setWindowSize Me, currentRunPointer.zParam1
    setControls Me, currentRunPointer.zParam2, True
    
    ' use temporary variable, since
    '    rcToken() changes the source string
    Dim sTemp As String
    sTemp = currentRunPointer.zParam3
    '=========== set "ON LOAD" function:
    sDo_on_load = rcToken(sTemp, "|")
    '=========== set "ON RESIZE" function:
    sDo_on_resize = rcToken(sTemp, "|")
  
    
    ' execute "On Load" function for a window:
    If sDo_on_load <> "" Then
        executeFunction sDo_on_load, "ONLOAD-NOPARAM"
    End If

    ' should be set "True" only after "On Load" is loaded,
    '  to prevent simultaneous call of executeFunction():
    bAllow_resize = True
    
    ' here you can call Form_Resize() to resize execute,
    '  (original Form_Resize() call is ignored because of
    '    bAllow_resize = False).
End Sub

Private Sub Form_Resize()
    If Me.WindowState = vbMinimized Then Exit Sub

    bWINDOW_IS_RESIZING = True
    
    ' make sure it won't be executed several times!
    '   solutions:
    '    a. stop everything with emptying the STACK?
    '    b. I think I'll better run here in an iternal loop,
    '       until any function returns to this file.
    '    c. just exit sub... it doesn't seem to be buggy at least.
    
    ' Form_Load() and Form_Resize() seems to execute
    ' at the same time, here is the print out of a Timer:
    '     load:  65406.15
    '     resize:  65406.15
    '     activate:  65406.48
    ' that's why bAllow_resize is set only after "ON LOAD" is executed,
    '  because when calling executeFunction() simultaneously
    '  for "ON LOAD" and "ON RESIZE" only one of them is executed...
    ' IMPR: I'm not sure if someone can click on two buttons simultaneously to make
    '         a simultaneous call of executeFunction(), but in any way we should think
    '         of a better solution.
    If (Not bAllow_resize) _
       Or (StrComp(ExtractFileName(sCallerFunction), ExtractFileName(currentFileName), vbTextCompare) <> 0) _
       Or (Not bWINDOW_LOADED) Or (Not bWINDOW_ACTIVATED) Then
        bWINDOW_IS_RESIZING = False
        Exit Sub
    End If

 'since:
 'sCallerFunction: G:\Projects\TZ\tz0081in\d.tzr
 'currentFileName: \\ORT\SYS\USERS\MARGOLIN\PROJECTS\TZ\TZ0081IN\d.tzr
 ' when comparing, compare only the file name and not full path!!!



    ' execute "On Resize" function for a window:
    If sDo_on_resize <> "" Then
        executeFunction sDo_on_resize, "ONRESIZE-NOPARAM"
    End If
    
    bWINDOW_IS_RESIZING = False
End Sub



Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    ' continue when window is closed,
    '  only if closed by user:
    If Not FORCE_CLOSE Then
        Set currentRunPointer = getNextBlock(currentRunPointer, "")  ' any (should be one).
        frmMain.StartExecution
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    bWINDOW_LOADED = False
    bWINDOW_ACTIVATED = False
End Sub


' left click on button:
Private Sub objButton_Click(Index As Integer)
   executeFunction theGUI.getObjectFromIndex(Index, "BUTTON").sFunction1, "NO_PARAMETERS"
End Sub

' right click on button:
Private Sub objBUTTON_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 2 Then
        executeFunction theGUI.getObjectFromIndex(Index, "BUTTON").sFunction2, "NO_PARAMETERS"
    End If
End Sub

' left and right clicks on a picture box:
Private Sub objPIC_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 1 Then
        ' left click:
        executeFunction theGUI.getObjectFromIndex(Index, "PIC").sFunction1, X & "," & Y
    ElseIf Button = 2 Then
        ' right click:
        executeFunction theGUI.getObjectFromIndex(Index, "PIC").sFunction2, X & "," & Y
    End If
End Sub

' left and right clicks on a text area:
Private Sub objTAREA_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 1 Then
        ' left click:
        executeFunction theGUI.getObjectFromIndex(Index, "TAREA").sFunction1, X & "," & Y
    ElseIf Button = 2 Then
        ' right click:
        executeFunction theGUI.getObjectFromIndex(Index, "TAREA").sFunction2, X & "," & Y
    End If
End Sub


' left and right clicks on a text box:
Private Sub objTBOX_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 1 Then
        ' left click:
        executeFunction theGUI.getObjectFromIndex(Index, "TBOX").sFunction1, X & "," & Y
    ElseIf Button = 2 Then
        ' right click:
        executeFunction theGUI.getObjectFromIndex(Index, "TBOX").sFunction2, X & "," & Y
    End If
End Sub

' executes a function, if it's not a registered
'   function name, then it's a filename:
' IMPR: simultaneous call of this function makes problems,
'        since: 1. both functions will return to the same place,
'               2. currentRunPointer will be resent by second
'                  "simultaneous" call, and first will be lost for ever,
'                  and thus it will not be executed.
'        solution: make sure executeFunction() isn't called
'                  simultaneously, though it's hard to click two
'                  buttons at the same time, "ON_LOAD" and "ON_RESIZE"
'                  seems to execute simultaneously (fixed in this
'                  module by bAllow_resize).
Private Sub executeFunction(sCommand As String, sParameters As String)

    ' just in case, sometimes it maybe called on Resize when
    '   flow is going to be terminated, so this fixes it:
    ' this also prevents executing functions when flow is stoped,
    '   but window isn't unloaded for some reason:
    If currentRunPointer Is Nothing Then Exit Sub
    

    ' result of internal function is ignored (not stored):
    If Not executeInternalFunction(sCommand, sParameters, "") Then
    
        ' copied (with changes) from "FUNCTION" of
        '         frmMain.Private Sub timerRunner_Timer()
        ' some assembler.... :)

        frmStack.PUSH (frmVars.ifVarGetValue("PARAM")) ' [*] save param of previous function.
        ' PUSHING: 1. parameter(s), 2. where to store return, 3. CS, 4. IP
        frmStack.PUSH frmVars.ifVarGetValue(sParameters)   ' parameter(s).
        frmStack.PUSH "SUB_RETURN" ' where to store result in.
        frmStack.PUSH ExtractFileName(currentFileName)  ' CS - return to that program.
        Dim blockToReturnTo As cBlock
        
        Set blockToReturnTo = currentRunPointer  ' return to the same WINDOW!!!!

        frmMain.shp_Selector.Visible = False ' hide selector.
        frmStack.PUSH blockToReturnTo.TagID    ' IP - next command to return to (alpha...).

        ' #020105:
        If frmMain.load_FILE(currentPATH & sCommand & ".fpp") Then  ' load another program (function).
            Set currentRunPointer = findBlock("START")
            frmMain.setSelector currentRunPointer
        Else
            mBox "Cannot load function: " & sCommand
            frmMain.setSelector currentRunPointer   ' just to show where we stoped.
            ''Set currentRunPointer = Nothing ' Stop execution.
            frmMain.TerminateExecution  ' stop program!
            ' stack is filled with some data, so it's better to stop.
        End If

        ' start timer!!!!!!!! (stoped when returns back to window!!!)
        frmMain.StartExecution
        
    End If
    
End Sub

Private Function objectNameExists(sName As String) As Boolean
    Dim cg As cGUI_obj
    
    For Each cg In theGUI
       If StrComp(sName, cg.sID, vbTextCompare) = 0 Then
            objectNameExists = True
            Exit Function
       End If
    Next cg
    
    ' if gets here, not found:
    objectNameExists = False
End Function



' currenlty exchanging values between OBJECTS is not
'   supported. only between variables and objects.
' on success returns "TRUE", on any error - shows error message,
'   and returns "FALSE".
Public Function processObjectDefinition(p1 As String, p2 As String) As Boolean

On Error GoTo errDef

    processObjectDefinition = True ' could be changed to "False" later.

    Dim sName As String
    Dim sPROP As String
    Dim s As String
    
    ' string constants can have dots inside:
    If (InStr(1, p1, ".") > 0) And ((InStr(1, p2, ".") > 0) And (Mid(p2, 1, 1) <> """")) Then
        mBox "Object to object assignment is not supported yet!"
        processObjectDefinition = False
        
    ' first is an object, second is a variable/constant:
    ElseIf InStr(1, p1, ".") > 0 Then

        sName = extractObjectName(p1)
        sPROP = UCase(extractProperty(p1))

        p2 = removeQuotes(p2) ' quotes around are ignored.


        If StrComp(sName, "WINDOW", vbTextCompare) = 0 Then
            Select Case sPROP

            Case "W"
                s = frmVars.ifVarGetValue(p2)
                s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
                Me.Width = Val(s) * Screen.TwipsPerPixelX
                
            Case "H"
                s = frmVars.ifVarGetValue(p2)
                s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
                Me.Height = Val(s) * Screen.TwipsPerPixelY
                
            Case Else
                mBox "Cannot do: " & p1 & " = " & p2 & _
                     vbNewLine & "This window's property isn't" _
                     & vbNewLine & "available for reading!"
                processObjectDefinition = False
            End Select
            Exit Function
        End If


        ' check object name, to avoid error when
        '   there is a wrong GUI name:
        If Not objectNameExists(sName) Then
            mBox "Cannot do: " & p1 & " = " & p2 & _
                    vbNewLine & "Object with name: " & sName & _
                    vbNewLine & "not found on current window."
            processObjectDefinition = False
            Exit Function
        End If
        
        Select Case sPROP
        Case "TEXT"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            s = replaceALL(s, "\n", vbNewLine) ' replace "\n" with real newline.
            theGUI(sName).sText = s
        
        Case "IMAGE"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            s = checkFileAndPath(s)
            ' in case file not exists, checkFileAndPath() sets s="",
            '    and nothing is loaded:
            theGUI(sName).objGUI.Picture = LoadPicture(s)
        
        ' this isn't a property, but METHOD,
        '   we just don't want to create a special operation:
        Case "LINE"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            theGUI(sName).objGUI.Line _
              (getPar(0, s), getPar(1, s))-(getPar(2, s), getPar(3, s))
            
        Case "VISIBLE"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            If UCase(s) = "TRUE" Then
                theGUI(sName).objGUI.Visible = True
            Else
                theGUI(sName).objGUI.Visible = False
            End If
            
        Case "DRAWMODE"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            If UCase(s) = "INVERT" Then
                theGUI(sName).objGUI.DrawMode = vbInvert
            Else
                theGUI(sName).objGUI.DrawMode = vbCopyPen
            End If
          
        Case "X"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            theGUI(sName).X = Val(s) * Screen.TwipsPerPixelX

        Case "Y"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            theGUI(sName).Y = Val(s) * Screen.TwipsPerPixelY
            
        Case "W"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            theGUI(sName).w = Val(s) * Screen.TwipsPerPixelX
            
        Case "H"
            s = frmVars.ifVarGetValue(p2)
            s = removeQuotes(s) ' quotes around are ignored (var can also have quotes).
            theGUI(sName).h = Val(s) * Screen.TwipsPerPixelY
            
        Case Else
            mBox "Cannot do: " & p1 & " = " & p2 & _
                    vbNewLine & "Property not found!"
            processObjectDefinition = False
        End Select
    
    ' first is a variable, second is an object:
    Else
        sName = extractObjectName(p2)
        sPROP = UCase(extractProperty(p2))
        
        If StrComp(sName, "WINDOW", vbTextCompare) = 0 Then
            Select Case sPROP

            Case "W"
                frmVars.setVar p1, Int(Me.Width / Screen.TwipsPerPixelX)

            Case "H"
                frmVars.setVar p1, Int(Me.Height / Screen.TwipsPerPixelY)

            Case Else
                mBox "Cannot do: " & p1 & " = " & p2 & _
                     vbNewLine & "This window's property isn't" _
                     & vbNewLine & "available for reading!"
                processObjectDefinition = False
            End Select
            Exit Function
        End If
        
        ' check object name, to avoid error when
        '   there is a wrong GUI name:
        If Not objectNameExists(sName) Then
            mBox "Cannot do: " & p1 & " = " & p2 & _
                    vbNewLine & "Object with name: " & sName & _
                    vbNewLine & "not found on current window."
            processObjectDefinition = False
            Exit Function
        End If
        
        Select Case sPROP
        Case "TEXT"
            frmVars.setVar p1, theGUI(sName).sText
            
        Case "X"
            frmVars.setVar p1, Int(theGUI(sName).X / Screen.TwipsPerPixelX)
            
        Case "Y"
            frmVars.setVar p1, Int(theGUI(sName).Y / Screen.TwipsPerPixelY)
            
        Case "W"
            frmVars.setVar p1, Int(theGUI(sName).w / Screen.TwipsPerPixelX)
            
        Case "H"
            frmVars.setVar p1, Int(theGUI(sName).h / Screen.TwipsPerPixelY)
            
        Case Else
            mBox "Cannot do: " & p1 & " = " & p2 & _
                    vbNewLine & "Property not available for reading!"
            processObjectDefinition = False
        End Select
               
    End If
     
    'Debug.Print p1 & " = " & p2
    Exit Function
errDef:
    mBox "Error in object definition: " & vbNewLine & _
           p1 & " = " & p2 & vbNewLine & _
           Err.Description
    processObjectDefinition = False
    
End Function

Private Function extractObjectName(s As String) As String
    Dim i As Long
    
    i = InStr(1, s, ".")
    
    If (i > 0) Then
         ' return everything before dot:
        extractObjectName = Mid(s, 1, i - 1)
    Else
        extractObjectName = s
    End If
End Function

Private Function extractProperty(s As String) As String
    Dim i As Long
    
    i = InStr(1, s, ".")
    
    If (i > 0) Then
         ' return everything after the dot:
        extractProperty = Mid(s, i + 1)
    Else
        extractProperty = ""
    End If
End Function


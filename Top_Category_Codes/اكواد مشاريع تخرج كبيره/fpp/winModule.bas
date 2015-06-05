Attribute VB_Name = "winModule"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/




' info@emu8086.com
' =========================================================
' Module of window functions
' =========================================================

Option Explicit

' when frmWindow is loaded is set to TRUE, otherwise to FALSE:
Public bWINDOW_LOADED As Boolean

' true when fully loaded (LOAD() sub is executed completly,
'   and thus unload can be done safe):
Public bWINDOW_ACTIVATED As Boolean

' "True" when frmWindow is resizing, used to prevent
'   errors on unload, since when it is inside Resize() sub
'    unload doesn't work for the form:
Public bWINDOW_IS_RESIZING As Boolean

Public Sub setWindowSize(ByRef OBJ As Object, ByVal Source As String)
    ' first calculate the border widths of a window (including the caption):
    Dim widthBorder As Single
    Dim heightBorder As Single

    ' assumed that scalemode is in twips:
    widthBorder = OBJ.Width - OBJ.ScaleWidth
    heightBorder = OBJ.Height - OBJ.ScaleHeight

    OBJ.Width = Val(rcToken(Source, "|")) + widthBorder
    OBJ.Height = Val(rcToken(Source, "|")) + heightBorder
    
End Sub

Public Sub setControls(ByRef FRM As Form, ByVal Source As String, bWithKey As Boolean)
Dim sTYPE As String
Dim s As String
Dim cg As cGUI_obj

next_Component:
            
        sTYPE = rcToken(Source, "|")    ' component type.
        
        If sTYPE <> "" Then
            s = rcToken(Source, "|") ' name (sID).
            
            If bWithKey Then
                ' key is the component name:
                Set cg = FRM.theGUI.Add(s, sTYPE, s)
            Else
                Set cg = FRM.theGUI.Add(s, sTYPE)
            End If
            
            s = rcToken(Source, "|") ' text.
            cg.sText = s
            
            s = rcToken(Source, "|") ' X.
            cg.X = Val(s)
            
            s = rcToken(Source, "|") ' Y.
            cg.Y = Val(s)
            
            s = rcToken(Source, "|") ' W.
            cg.w = Val(s)
            
            s = rcToken(Source, "|") ' H.
            cg.h = Val(s)
            
            cg.sFunction1 = rcToken(Source, "|") ' function 1.
            cg.sFunction2 = rcToken(Source, "|") ' function 2.
            
            GoTo next_Component
        End If

End Sub


' returns token before delimeter,
' and removes it from the source string (pointer is passed)
Public Function rcToken(ByRef s As String, delim As String) As String
    Dim l As Long
    
    l = InStr(1, s, delim, vbTextCompare)
    
    If l > 0 Then
        rcToken = Mid(s, 1, l - 1) ' first token before delim
        s = Mid(s, l + 1)   ' rest of the string
    Else
        rcToken = ""      ' delimeter not found!
    End If
    
End Function

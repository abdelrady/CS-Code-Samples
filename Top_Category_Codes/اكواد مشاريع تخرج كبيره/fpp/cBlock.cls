VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cBlock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
Attribute VB_Ext_KEY = "Member0" ,"blockCollection"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/




' info@emu8086.com
' =========================================================
'  The class for cBlock
'  (works with myShape Active-X like
'   two these objects are single big object).
'  Programs are made from cBlock(s) connected
'  by cLine(s).
' =========================================================

Option Explicit

'local variable(s) to hold property value(s)
' currect active-x object linked with this
' block (assumed they are the same object):
Public theObjectShape As GShape

'To fire this event, use RaiseEvent with the following syntax:
'RaiseEvent linkError[(arg1, arg2, ... , argn)]
Public Event linkError(sERROR As String)
'local variable(s) to hold property value(s)
Private mvarbSetUpperCaptionDown As Boolean 'local copy

'local variable(s) to hold property value(s)
' added internal property to allow running without GUI:
Private mvar_TagID As String


Public zAction As String   ' action of this block.
Public zParam1 As String   ' first parameter for action.
Public zParam2 As String   ' second parameter for action.
Public zParam3 As String   ' third parameter (generally result).

Public Property Let TextColor(ByVal vData As Long)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.TextColor = 5
    theObjectShape.TextColor = vData
End Property


Public Property Get TextColor() As Long
'used when retrieving value of a property, on the right side of an assignment.
    TextColor = theObjectShape.TextColor
End Property


' this procedure sets the caption for the block
' according to zAction (the action for this block):
Public Sub setCaptionToAction()
    Select Case zAction
    
    Case "START"
        sCaption = cLang("start")
        
    Case "STOP"
        sCaption = cLang("stop")
    
    Case "INTERSECTION"
        ' nothing.
    
    Case "OUTPUT"
        sCaptionUp = cLang("output")
        If zParam2 = "" Then    ' only message
            sCaption = """" & zParam1 & """"
        ElseIf zParam1 = "" Then ' only variable
            sCaption = zParam2
        Else                    ' both message & variable
            sCaption = """" & zParam1 & """, " & zParam2
        End If
        
    Case "INPUT"
        sCaptionUp = cLang("input")
        If zParam1 = "" Then    ' only variable
            sCaption = zParam2
        Else                    ' both message & variable
            sCaption = """" & zParam1 & """, " & zParam2
        End If
        
    Case "DEFINITION"
        sCaption = zParam1 & " = " & zParam2

        
    Case "IF_EQUAL"
        sCaption = zParam1 & " = " & zParam2
    Case "IF_GREATER"
        sCaption = zParam1 & " > " & zParam2
    Case "IF_LESS"
        sCaption = zParam1 & " < " & zParam2
    Case "IF_LESS_EQUAL"
        sCaption = zParam1 & " <= " & zParam2
    Case "IF_GREATER_EQUAL"
        sCaption = zParam1 & " >= " & zParam2
        
    Case "ADD"
        sCaption = zParam3 & " = " & zParam1 & " + " & zParam2
    Case "SUBTRACT"
        sCaption = zParam3 & " = " & zParam1 & " - " & zParam2
    Case "MULTIPLY"
        sCaption = zParam3 & " = " & zParam1 & " * " & zParam2
    Case "DIVIDE"
        sCaption = zParam3 & " = " & zParam1 & " / " & zParam2
        
    Case "JOIN"
        sCaption = zParam3 & " = " & zParam1 & " & " & zParam2
    Case "COMP"
        sCaption = zParam3 & " = " & zParam1 & " COMP " & zParam2
        
    Case "SQL"
        sCaption = "SQL"
        
    Case "FUNCTION"
        If zParam3 <> "" Then
            sCaption = zParam3 & " = " & zParam1 & "(" & zParam2 & ")"
        Else
            sCaption = zParam1 & "(" & zParam2 & ")"
        End If
        
    Case "WINDOW"
        sCaption = cLang("window")
        
    Case Else
        Debug.Print "setCaptionToAction(). Unknown action code in zAction: " & zAction
    End Select
    
    ' making sure the caption will be visible on the block
    '   (resize if required)
    ' assumed: frmScreen uses the same font as blocks!
    If sCaption <> "" Then  ' ignored for intersections.
        If theObjectShape.Shape = 92 Then ' 92 - for diamond.
            If frmScreen.TextWidth(sCaption) + 40 > shapeWidth Then
                shapeWidth = frmScreen.TextWidth(sCaption) + 40
            End If
        Else ' all other boxes:
            If frmScreen.TextWidth(sCaption) + 20 > shapeWidth Then
                shapeWidth = frmScreen.TextWidth(sCaption) + 20
            End If
        End If
    End If
    
End Sub

Public Property Let sCaption(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sCaption = 5
    theObjectShape.sCaption = vData
End Property

Public Property Get sCaption() As String
'used when retrieving value of a property, on the right side of an assignment.
    sCaption = theObjectShape.sCaption
End Property

Public Property Let sCaptionUp(ByVal vData As String)
    theObjectShape.sCaptionUp = vData
End Property

Public Property Get sCaptionUp() As String
    sCaptionUp = theObjectShape.sCaptionUp
End Property


' this makes active-x object and this object have:
'      Tag == TagID
Public Property Let TagID(ByVal vData As String)
    mvar_TagID = vData
    If bGUI Then theObjectShape.Tag = mvar_TagID
End Property

Public Property Get TagID() As String
    TagID = mvar_TagID 'theObjectShape.Tag
End Property


Public Property Let BorderColor(ByVal vData As Long)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeBorderColor = 5
    theObjectShape.BorderColor = vData
End Property


Public Property Get BorderColor() As Long
'used when retrieving value of a property, on the right side of an assignment.
    BorderColor = theObjectShape.BorderColor
End Property


Public Property Let BGColor(ByVal vData As Long)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeBackColor = 5
    theObjectShape.BGColor = vData
End Property


Public Property Get BGColor() As Long
'used when retrieving value of a property, on the right side of an assignment.
    BGColor = theObjectShape.BGColor
End Property


Public Property Let shapeHeight(ByVal vData As Integer)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeHeight = 5
    theObjectShape.Height = vData
End Property


Public Property Get shapeHeight() As Integer
'used when retrieving value of a property, on the right side of an assignment.
    shapeHeight = theObjectShape.Height
End Property


Public Property Let shapeWidth(ByVal vData As Integer)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeWidth = 5
    theObjectShape.Width = vData
End Property


Public Property Get shapeWidth() As Integer
'used when retrieving value of a property, on the right side of an assignment.
    shapeWidth = theObjectShape.Width
End Property


Public Property Let Shape(ByVal vData As Integer)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.Shape = 5
    theObjectShape.Shape = vData
End Property


Public Property Get Shape() As Integer
'used when retrieving value of a property, on the right side of an assignment.
    Shape = theObjectShape.Shape
End Property


Public Property Let Visible(ByVal vData As Boolean)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.Visible = 5
    theObjectShape.Visible = vData
End Property


Public Property Get Visible() As Boolean
'used when retrieving value of a property, on the right side of an assignment.
    Visible = theObjectShape.Visible
End Property

Public Property Let shapeLeft(ByVal vData As Single)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeLeft = 5
    theObjectShape.Left = vData
End Property


Public Property Get shapeLeft() As Single
'used when retrieving value of a property, on the right side of an assignment.
    shapeLeft = theObjectShape.Left
End Property


Public Property Let shapeTop(ByVal vData As Single)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.shapeTop = 5
    theObjectShape.Top = vData
End Property


Public Property Get shapeTop() As Single
'used when retrieving value of a property, on the right side of an assignment.
    shapeTop = theObjectShape.Top
End Property


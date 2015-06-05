VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cGUI_obj"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/


' info@emu8086.com

Option Explicit

' pointer to object loaded on form:
Public objGUI As Object


'local variable(s) to hold property value(s)
Private mvarsID As String 'local copy
Private mvarsFunction1 As String 'local copy
Private mvarsFunction2 As String 'local copy
Private mvarsTYPE As String 'local copy

Public Property Let sText(ByVal vData As String)
    Select Case Me.sTYPE
    Case "BUTTON"
        objGUI.Caption = vData
    Case "TAREA", "TBOX"
        objGUI.Text = vData
    End Select
End Property


Public Property Get sText() As String
    Select Case Me.sTYPE
    Case "BUTTON"
        sText = objGUI.Caption
    Case "TAREA", "TBOX"
        sText = objGUI.Text
    End Select
End Property



Public Property Let sTYPE(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sTYPE = 5
    mvarsTYPE = vData
End Property


Public Property Get sTYPE() As String
'used when retrieving value of a property, on the right side of an assignment.
    sTYPE = mvarsTYPE
End Property



Public Property Let sFunction2(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sFunction2 = 5
    mvarsFunction2 = vData
End Property


Public Property Get sFunction2() As String
'used when retrieving value of a property, on the right side of an assignment.
    sFunction2 = mvarsFunction2
End Property



Public Property Let sFunction1(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sFunction1 = 5
    mvarsFunction1 = vData
End Property


Public Property Get sFunction1() As String
'used when retrieving value of a property, on the right side of an assignment.
    sFunction1 = mvarsFunction1
End Property



Public Property Let sID(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sID = 5
    mvarsID = vData
End Property


Public Property Get sID() As String
'used when retrieving value of a property, on the right side of an assignment.
    sID = mvarsID
End Property



Public Property Let X(ByVal vData As Integer)
    objGUI.Left = vData
End Property


Public Property Get X() As Integer
    X = objGUI.Left
End Property



Public Property Let Y(ByVal vData As Integer)
    objGUI.Top = vData
End Property


Public Property Get Y() As Integer
    Y = objGUI.Top
End Property



Public Property Let h(ByVal vData As Integer)
If vData > 0 Then objGUI.Height = vData
End Property


Public Property Get h() As Integer
    h = objGUI.Height
End Property



Public Property Let w(ByVal vData As Integer)
If vData > 0 Then objGUI.Width = vData
End Property


Public Property Get w() As Integer
    w = objGUI.Width
End Property

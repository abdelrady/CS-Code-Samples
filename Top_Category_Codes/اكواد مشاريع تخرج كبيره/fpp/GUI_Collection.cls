VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "GUI_Collection"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Collection" ,"cGUI_obj"
Attribute VB_Ext_KEY = "Member0" ,"cGUI_obj"
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

' should be set after creation of this collection,
' parent form that contains this collection:
Public Parent As Form

'local variable to hold collection
Private mCol As Collection


Public Function Add(sID As String, sTYPE As String, Optional sKey As String) As cGUI_obj
    Dim tI As Integer ' temporary index holder.

    'create a new object
    Dim objNewMember As cGUI_obj
    Set objNewMember = New cGUI_obj

    'set the properties passed into the method
    objNewMember.sID = sID
    objNewMember.sTYPE = sTYPE
    
    Select Case sTYPE
    Case "BUTTON"
        tI = Parent.objBUTTON.UBound + 1
        Load Parent.objBUTTON(tI)
        Set objNewMember.objGUI = Parent.objBUTTON(tI)
                
        objNewMember.sText = cLang("button")    ' default.
        
        objNewMember.objGUI.ZOrder 0
        objNewMember.objGUI.Visible = True
        
    Case "TAREA"
        tI = Parent.objTAREA.UBound + 1
        Load Parent.objTAREA(tI)
        Set objNewMember.objGUI = Parent.objTAREA(tI)
                
        objNewMember.sText = "text area"   ' default.
        
        objNewMember.objGUI.ZOrder 0
        objNewMember.objGUI.Visible = True
        
    Case "PIC"
        tI = Parent.objPIC.UBound + 1
        Load Parent.objPIC(tI)
        Set objNewMember.objGUI = Parent.objPIC(tI)
                
        objNewMember.sText = ""   ' file name for image.
        
        objNewMember.objGUI.ZOrder 0
        objNewMember.objGUI.Visible = True
        
    Case "TBOX"
        tI = Parent.objTBOX.UBound + 1
        Load Parent.objTBOX(tI)
        Set objNewMember.objGUI = Parent.objTBOX(tI)
                
        objNewMember.sText = "text box"   ' default.
        
        objNewMember.objGUI.ZOrder 0
        objNewMember.objGUI.Visible = True
        
    Case Else
        mBox "Trying to add wrong object: " & sTYPE
        Exit Function
        
    End Select
   

    If Len(sKey) = 0 Then
        mCol.Add objNewMember
    Else
        mCol.Add objNewMember, sKey
    End If

    
    'return the object created
    Set Add = objNewMember
    Set objNewMember = Nothing

End Function

Public Property Get Item(vntIndexKey As Variant) As cGUI_obj
Attribute Item.VB_UserMemId = 0
    'used when referencing an element in the collection
    'vntIndexKey contains either the Index or Key to the collection,
    'this is why it is declared as a Variant
    'Syntax: Set foo = x.Item(xyz) or Set foo = x.Item(5)
         
  Set Item = mCol(vntIndexKey)
End Property



Public Property Get Count() As Long
    'used when retrieving the number of elements in the
    'collection.
    Count = mCol.Count
End Property


Public Sub Remove(vntIndexKey As Variant)
    'used when removing an element from the collection
    'vntIndexKey contains either the Index or Key, which is why
    'it is declared as a Variant
    'Syntax: x.Remove(xyz)


    mCol.Remove vntIndexKey
End Sub


Public Property Get NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    'this property allows you to enumerate
    'this collection with the For...Each syntax
    Set NewEnum = mCol.[_NewEnum]
End Property


Private Sub Class_Initialize()
    'creates the collection when this class is created
    Set mCol = New Collection
End Sub


Private Sub Class_Terminate()
    'destroys collection when this class is terminated
    Set mCol = Nothing
End Sub


Public Function getObjectFromIndex(Index As Integer, sTYPE As String) As cGUI_obj
    Dim cg As cGUI_obj
    
    For Each cg In mCol
        ' to speed it up doubled "if" is used instead of "AND":
        If cg.objGUI.Index = Index Then
            If cg.sTYPE = sTYPE Then
                Set getObjectFromIndex = cg
                Exit Function
            End If
        End If
    Next
    
    Debug.Print "Object with index: " & Index & " type: " & sTYPE & " not found!"
    Set getObjectFromIndex = Nothing
End Function

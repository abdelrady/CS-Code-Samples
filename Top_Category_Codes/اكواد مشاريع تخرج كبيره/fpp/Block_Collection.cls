VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Block_Collection"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Collection" ,"cBlock"
Attribute VB_Ext_KEY = "Member0" ,"cBlock"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
' =========================================================
'  === Project of Data-flow Visual Programming Language ===
' =========================================================
' Copyright Emu8086, Inc. Free Code !
'
'
' URL: http://www.emu8086.com/vb/



' info@emu8086.com
' =========================================================
' Collection for cBlock objects
' =========================================================

Option Explicit

'local variable to hold collection
Private mCol As Collection
'To fire this event, use RaiseEvent with the following syntax:
'RaiseEvent linkError[(arg1, arg2, ... , argn)]
Public Event linkError(sERROR As String)


Public Function AddShape(ShapeType As Integer, sKey As String, iLeft As Single, iTop As Single) As cBlock
    'create a new object
    Dim objNewMember As cBlock
    Set objNewMember = New cBlock

    ' in case this method is called when program is loaded
    '  it is also set, but it has no effect because after
    '  loading this variable is set to FALSE:
    bIS_MODIFIED = True


    'set the properties passed into the method
    
    If bGUI Then
        MAX_SHAPE = MAX_SHAPE + 1
        Load frmMain.shp(MAX_SHAPE)
        
        Set objNewMember.theObjectShape = frmMain.shp(MAX_SHAPE)
   
        ' sets last buit shape to be selected:
        PREV_SELECTED_SHAPE = SELECTED_SHAPE
        SELECTED_SHAPE = MAX_SHAPE
    Else
        ' to prevent any possible errors, it is set to first
        '   static object:
        Set objNewMember.theObjectShape = Nothing 'frmMain.shp(0)
    End If
        

    With objNewMember
        If bGUI Then
            .shapeLeft = iLeft 'frmMain.ScaleWidth / 2 - .shapeWidth / 2
            .shapeTop = iTop 'frmMain.ScaleHeight / 2 - .shapeHeight / 2
            .Shape = ShapeType
            .theObjectShape.ZOrder 0
            .Visible = True
        End If
        
        .TagID = sKey
    End With

            
    'If Len(sKey) = 0 Then
    '    mCol.Add objNewMember
    'Else
    '    mCol.Add objNewMember, sKey
    'End If

    mCol.Add objNewMember, sKey ' objNewMember.TagID
        
    'return the object created
    Set AddShape = objNewMember
    Set objNewMember = Nothing

End Function

Public Property Get Item(vntIndexKey As Variant) As cBlock
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


' allows to remove only when there are no connections
' to this object:
Public Sub removeShape(Index As Integer)
    
    If Index = -1 Then Exit Sub
       
    Dim xL As cLine
    Dim sName As String
    
    sName = frmMain.shp(Index).Tag
    
    For Each xL In frmMain.theLineCollection
        If (xL.sFrom = sName) Or (xL.sTo = sName) Then
            RaiseEvent linkError(cLang("Cannot delete connected object."))
            Exit Sub
        End If
    Next xL
    
    frmMain.shp(Index).Visible = False
    
    Me.Remove sName  ' actual delete (won't be loaded on next load).


    ' hide selector:
    frmMain.shp_Selector.Visible = False
        
    SELECTED_SHAPE = -1 ' nothing selected

End Sub

' returns free ID for an object that is not used yet:
Public Function getFreeTagID() As String

    Dim xB As cBlock
    
    Dim Index As Integer
    Dim sName As String
    Index = 1
    
    sName = "id" & Index
    
    Do While (getIndexFromTag(sName) <> -1)
        Index = Index + 1
        sName = "id" & Index
    Loop

    getFreeTagID = sName
End Function

' returns the index of Active-X myShape that is associated
' with this cBlock:
Public Function getIndexFromTag(sTag As String) As Integer
    Dim xB As cBlock
    
    For Each xB In Me
        If (xB.TagID = sTag) Then
            getIndexFromTag = xB.theObjectShape.Index
            Exit Function
        End If
    Next xB
  
    getIndexFromTag = -1    ' not found!
    
End Function

' it may never happen...
' check anyway...
Public Sub checkLinks()

    Dim xL As cLine
    
    For Each xL In frmMain.theLineCollection
        If Me.getIndexFromTag(xL.sFrom) = -1 Then
             RaiseEvent linkError("Line #" & xL.theObjectLine.Index & " has wrong FROM")
        ElseIf Me.getIndexFromTag(xL.sTo) = -1 Then
             RaiseEvent linkError("Line #" & xL.theObjectLine.Index & " has wrong TO")
        End If
    Next xL
    
End Sub



Public Function objectNameExists(sName As String) As Boolean
    Dim cb As cBlock
    
    For Each cb In Me
       If StrComp(sName, cb.TagID, vbTextCompare) = 0 Then
            objectNameExists = True
            Exit Function
       End If
    Next cb
    
    ' if gets here, not found:
    objectNameExists = False
End Function

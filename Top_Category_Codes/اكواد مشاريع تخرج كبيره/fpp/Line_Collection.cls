VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Line_Collection"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Collection" ,"cLine"
Attribute VB_Ext_KEY = "Member0" ,"cLine"
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
' Collection for cLine objects
' =========================================================

Option Explicit

'local variable to hold collection
Private mCol As Collection

'To fire this event, use RaiseEvent with the following syntax:
'RaiseEvent linkError[(arg1, arg2, ... , argn)]
Public Event linkError(sERROR As String)

Public Sub AddCaptionToLine(sFrom As String, sTo As String, sCaption As String)
    Dim xL As cLine
    
    For Each xL In Me
         
        If ((xL.sFrom = sFrom) And (xL.sTo = sTo)) _
         Or ((xL.sTo = sFrom) And (xL.sFrom = sTo)) Then
            xL.sCaption = sCaption
            
            Dim tL As Single
            Dim tT As Single
                
            tL = xL.theObjectLine.x1 + (xL.theObjectLine.x2 - xL.theObjectLine.x1) / 2 - frmMain.lblLineCap(xL.theObjectLine.Index).Width / 2
            tT = xL.theObjectLine.y1 + (xL.theObjectLine.y2 - xL.theObjectLine.y1) / 2 - frmMain.lblLineCap(xL.theObjectLine.Index).Height / 2
                
            frmMain.lblLineCap(xL.theObjectLine.Index).Move tL, tT
            
        End If
        
    Next xL
    
End Sub

Public Function AddLine(sFrom As String, sTo As String, sCaption As String) As cLine

    If sFrom = "" Or sTo = "" Then
        RaiseEvent linkError("Cannot make a link!!!!")
        Exit Function
    End If
    

    'create a new object
    Dim objNewMember As cLine
    Set objNewMember = New cLine


    'set the properties passed into the method
    objNewMember.sFrom = sFrom
    objNewMember.sTo = sTo

    ' objNewMember.sCaption = "" ' not intitialized yet.
    ' (removed parameter: , Optional sKey As String)
    'If Len(sKey) = 0 Then
        mCol.Add objNewMember
    'Else
    '    mCol.Add objNewMember, sKey
    'End If

    If bGUI Then
        ' make GUI connection
                
        MAX_LINE = MAX_LINE + 1
        Load frmMain.ln(MAX_LINE)
        ' one arrow for each line:
        Load frmMain.aDot(MAX_LINE)
        Load frmMain.arrUp(MAX_LINE)
        Load frmMain.arrDown(MAX_LINE)
        ' one caption for each line/arrow:
        Load frmMain.lblLineCap(MAX_LINE)
    
        Set objNewMember.theObjectLine = frmMain.ln(MAX_LINE)
    
        Dim iFrom As Integer
        Dim iTo As Integer
    
        iFrom = frmMain.theBlockCollection.getIndexFromTag(sFrom)
        iTo = frmMain.theBlockCollection.getIndexFromTag(sTo)
    
        frmMain.lblLineCap(MAX_LINE).Visible = False
        objNewMember.sCaption = sCaption
    
        objNewMember.updateLine
        
        ' make line label visible only if there is something:
        If sCaption <> "" Then
            frmMain.lblLineCap(MAX_LINE).Visible = True
        End If
        
        objNewMember.theObjectLine.Visible = True
                
        'frmMain.lblLineCap(MAX_LINE).Left = objNewMember.theObjectLine.x1 + (objNewMember.theObjectLine.x2 - objNewMember.theObjectLine.x1) / 2 - frmMain.lblLineCap(MAX_LINE).Width / 2
        'frmMain.lblLineCap(MAX_LINE).Top = objNewMember.theObjectLine.y1 + (objNewMember.theObjectLine.y2 - objNewMember.theObjectLine.y1) / 2 - frmMain.lblLineCap(MAX_LINE).Height / 2
        
        frmMain.lblLineCap(MAX_LINE).ZOrder 0
    Else
        ' if not GUI then just set caption:
        objNewMember.sCaption = sCaption
    End If

    'return the object created
    Set AddLine = objNewMember
    Set objNewMember = Nothing

End Function

Public Property Get Item(vntIndexKey As Variant) As cLine
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



Public Sub deleteLine(xFrom As Integer, xTo As Integer)

    If xFrom = -1 Or xTo = -1 Then
        RaiseEvent linkError(cLang("Cannot determine which arrow to delete."))
        Exit Sub
    End If

    Dim i As Integer
    
    Dim sNameFrom As String
    Dim sNameTo As String
    
    Dim lineIndex As Integer
    
    sNameFrom = frmMain.shp(xFrom).Tag
    sNameTo = frmMain.shp(xTo).Tag
    
    For i = Me.Count To 1 Step -1
    
        If ((Me(i).sFrom = sNameFrom) And (Me(i).sTo = sNameTo)) Or _
           ((Me(i).sFrom = sNameTo) And (Me(i).sTo = sNameFrom)) Then
            
            Me(i).theObjectLine.Visible = False
            Me(i).sFrom = ""
            Me(i).sTo = ""
            
            lineIndex = Me(i).theObjectLine.Index
            frmMain.aDot(lineIndex).Visible = False
            frmMain.arrUp(lineIndex).Visible = False
            frmMain.arrDown(lineIndex).Visible = False
            frmMain.lblLineCap(lineIndex).Visible = False
            
            Me.Remove i    ' actual delete (won't be loaded on next load).
            
        End If

    Next i

End Sub

' updates all lines:
Public Sub updateAllLines()

    Dim xL As cLine
        
    For Each xL In Me

        xL.updateLine
        
    Next xL
    
End Sub

' updates only those lines that are connected to
'   a block (block with TagID=sTag):
Public Sub updateConntectedLines(sTag As String)

    Dim xL As cLine
        
    For Each xL In Me

        If (xL.sFrom = sTag) Or (xL.sTo = sTag) Then
            xL.updateLine
        End If
        
    Next xL
    
End Sub

Private Function getCollectionIndex_from_objectIndex(lineIndex As Integer) As Integer
    Dim i As Integer
    
    For i = 1 To Me.Count
        If Me(i).theObjectLine.Index = lineIndex Then
            getCollectionIndex_from_objectIndex = i
            Exit Function
        End If
    Next i
    
    getCollectionIndex_from_objectIndex = -1 ' not found!
    
End Function



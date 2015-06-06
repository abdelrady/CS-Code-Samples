VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cList"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------
' Module    : cList
' DateTime  : 17/04/2005 13:11
' Author    : D K Richmond
' Status    : BETA RELEASE 1.0
' Version   : Visual Basic 6 (SP6)
' User Type : Beginner/Intermediate/Advanced
' Applicable: Database/Data Sorting/Key Retrieval/Binary Trees/Node Traversals
'
' Disclaimer:
' -----------
' This class/software is provided as-if, no liability accepted in using
' this code or part of this code where information is used and relied upon in any
' other system or systems, projects, modules etc.
' In other words, it is provided for educational value and where experimenting
' in writing applications needing a simulated Listbox class non-gui and
' running experimental non-critical non-business applications.
'
' Copyright:
' -----------
' This was written by entirely by myself.
' ALL OF THIS CODE IN THIS CLASS WAS WRITTEN FROM A BLANK WORKSHEET.  IN OTHER WORDS NON OF THIS CODE
' WAS STRIPPED, EXTRACTED OR COPIED FROM OTHER PEOPLES WORK.  PLEASE RESPECT THAT AND
' IF YOU USE THIS CODE IN ANY OF YOUR APPLICATIONS/EXAMPLES PLEASE GIVE CREDIT FOR MY WORK.
'
' DAVID K RICHMOND dk.richmond@ntlworld.com
'
' GUIDELINES:
' -----------
'
' Nomenclature (normal):
' -------------
'      i - integer prefix
'      l - long prefix
'      d - double prefix
'      s - string prefix
'      e - enum
'      c - original class prefix
'      cls - instance of a class prefix
'
'      m_i - member integer prefix
'      m_l - member long prefix
'      m_d - member double prefix
'      m_s - member string prefix
'      m_e - member enum
'      m_cls - member instance of a class prefix
'
' Nomenclature (not normal):
' -------------------------
'      ip - parameter integer prefix
'      lp - parameter long prefix
'      dp - parameter double prefix
'      sp - parameter string prefix
'
'      ipo - parameter optional integer prefix
'      lpo - parameter optional long prefix
'      dpo - parameter optional double prefix
'      spo - parameter optional string prefix
' ##########################################################################################################

Option Explicit

' Private Storage Definitions

Private m_vaList() As Variant
Private m_vaListShadow() As Variant
 ' notes:
 ' m_lListCount is base 0
 ' ListCount is base 1
Private m_lListCount As Long
 ' notes:
 ' m_lListCount is base 0
Private m_lListIndex As Long


'---------------------------------------------------------------------------------------
' Procedure : ListCount
' DateTime  : 17/04/2005 13:11
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get ListCount() As Long
    ListCount = m_lListCount + 1
End Property


'---------------------------------------------------------------------------------------
' Procedure : List
' DateTime  : 17/04/2005 13:11
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function List(ByVal plIndex As Long) As Variant
    
    If (m_lListCount = -1) Or (plIndex < 0) Or (plIndex > m_lListCount) Then
        Err.Raise vbObjectError + 404, "RemoveListItem Error", "RemoveListItem Error"
    Else
        List = m_vaList(plIndex)
    End If
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : AddItem
' DateTime  : 17/04/2005 13:11
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function AddItem(ByVal pvItem As Variant) As Long

    m_lListCount = m_lListCount + 1
    ReDim Preserve m_vaList(m_lListCount)
    m_vaList(m_lListCount) = pvItem

AddItem = m_lListCount
End Function


'---------------------------------------------------------------------------------------
' Procedure : RemoveItem
' DateTime  : 17/04/2005 13:12
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function RemoveItem(ByVal plIndex As Long) As Long

    If RemoveListItem(plIndex) = True Then
        RemoveItem = plIndex
    Else
        RemoveItem = -1
    End If
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : Clear
' DateTime  : 17/04/2005 13:12
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function Clear()
    
    ReDim m_vaList(0)
    m_lListCount = -1
    m_lListIndex = -1

End Function


'---------------------------------------------------------------------------------------
' Procedure : Class_Initialize
' DateTime  : 17/04/2005 13:12
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub Class_Initialize()

    ReDim m_vaList(0)
    m_lListCount = -1
    m_lListIndex = -1
    
End Sub


'---------------------------------------------------------------------------------------
' Procedure : RemoveListItem
' DateTime  : 17/04/2005 13:12
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Function RemoveListItem(ByVal plIndex As Long) As Boolean
 Dim lRow As Long
 Dim iOffset As Integer
 Dim iCol As Integer
 Dim lDataPos As Long
 Dim iAdjust As Integer
 Dim lIndirectRow As Long
 
 RemoveListItem = False
 
 ' [notes]:
 ' ListCount is base 1
 ' m_lListCount is base 0
 ' m_lListIndex is base 0
 ' plIndex is base 0

   On Error GoTo RemoveListItem_Error

    If (m_lListCount = -1) Or (plIndex < 0) Or (plIndex > m_lListCount) Then
        Err.Raise vbObjectError + 404, "RemoveListItem Error", "RemoveListItem Error"
        Exit Function
    End If
     
    ' check if only one item and item is item
    If (plIndex = 0) And (ListCount = 1) Then
        ' only 1 item
        ReDim m_vaList(0)
        m_lListCount = -1
        m_lListIndex = -1
        RemoveListItem = True
        On Error GoTo 0
        Exit Function
    End If
    
    ' Original to Shadow removing item on the way
    lDataPos = -1 ' invalidate
    iOffset = 0
    lDataPos = 0
    iAdjust = 0
    ReDim m_vaListShadow(m_lListCount - 1)
    For lRow = 0 To m_lListCount - 1
        If (lRow = plIndex) Then
            lDataPos = lRow
            iOffset = 1
        End If
        m_vaListShadow(lRow) = m_vaList(lRow + iOffset)
    Next
    If lDataPos = -1 Then
        If (plIndex <> m_lListCount) Then
            MsgBox "Fatal error in function RemoveListItem !", vbCritical
            Err.Raise vbObject + 340, "", ""
        End If
    End If
    
    ' Shadow back to Orginal
    m_lListCount = m_lListCount - 1
    ReDim m_vaList(m_lListCount)
    
    For lRow = 0 To m_lListCount
        m_vaList(lRow) = m_vaListShadow(lRow)
    Next
    
    RemoveListItem = True

   On Error GoTo 0
   Exit Function
   
RemoveListItem_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure RemoveListItem of Class Module clsList"

End Function



' <eoc>
 



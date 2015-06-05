VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cLine"
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
' =========================================================
'  The class for cLine
'  (works with Line - VB Object
'   two these objects are single big object).
' cLine connects cBlock one with another.
' =========================================================

Option Explicit

Public theObjectLine As Line

'local variable(s) to hold property value(s)
Private mvarsFrom As String 'local copy
Private mvarsTo As String 'local copy

Private mvar_sCaption As String ' added to support no GUI.

Public Property Let sCaption(ByVal vData As String)
    mvar_sCaption = vData
    
    If bGUI Then
        frmMain.lblLineCap(theObjectLine.Index).Caption = mvar_sCaption
        
        If sCaption <> "" Then
            frmMain.lblLineCap(theObjectLine.Index).Visible = True
        Else
            frmMain.lblLineCap(theObjectLine.Index).Visible = False
        End If
    End If
End Property

Public Property Get sCaption() As String
    sCaption = mvar_sCaption ' frmMain.lblLineCap(theObjectLine.Index).Caption
End Property


Public Property Let sTo(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sTo = 5
    mvarsTo = vData
End Property


Public Property Get sTo() As String
'used when retrieving value of a property, on the right side of an assignment.
    sTo = mvarsTo
End Property



Public Property Let sFrom(ByVal vData As String)
'used when assigning a value to the property, on the left side of an assignment.
'Syntax: X.sFrom = 5
    mvarsFrom = vData
End Property


Public Property Get sFrom() As String
'used when retrieving value of a property, on the right side of an assignment.
    sFrom = mvarsFrom
End Property

' updates line position and its arrow:
Public Sub updateLine()
    Dim iFrom As Integer
    Dim iTo As Integer
    Dim lineIndex As Integer
    
    If Not bGUI Then Exit Sub
    
    ' temporary variables:
    Dim x1 As Single
    Dim y1 As Single
    Dim x2 As Single
    Dim y2 As Single
    
    
        With frmMain.theBlockCollection
            iFrom = .getIndexFromTag(sFrom)
            iTo = .getIndexFromTag(sTo)
        End With
       
            
            ' set start of line (not an arrow)
            ' to the nearest edge of the block (source):
            
            ' arrow will be on the right side:
            If frmMain.shp(iTo).Left > (frmMain.shp(iFrom).Left + frmMain.shp(iFrom).Width) Then
                x1 = frmMain.shp(iFrom).Left + frmMain.shp(iFrom).Width
                y1 = frmMain.shp(iFrom).Top + frmMain.shp(iFrom).Height / 2
            ' arrow will be at the bottom:
            ElseIf frmMain.shp(iTo).Top > (frmMain.shp(iFrom).Top + frmMain.shp(iFrom).Height) Then
                x1 = frmMain.shp(iFrom).Left + frmMain.shp(iFrom).Width / 2
                y1 = frmMain.shp(iFrom).Top + frmMain.shp(iFrom).Height
            ' arrow will be on the left:
            ElseIf (frmMain.shp(iTo).Left + frmMain.shp(iTo).Width) < frmMain.shp(iFrom).Left Then
                x1 = frmMain.shp(iFrom).Left
                y1 = frmMain.shp(iFrom).Top + frmMain.shp(iFrom).Height / 2
            ' arrow will be at the top:
            Else
                x1 = frmMain.shp(iFrom).Left + frmMain.shp(iFrom).Width / 2
                y1 = frmMain.shp(iFrom).Top
            End If
            
            
            
            ' set end of line (an arrow)
            ' to the nearest edge of the block (target):
            
            ' arrow will be on the right side:
            If frmMain.shp(iFrom).Left > (frmMain.shp(iTo).Left + frmMain.shp(iTo).Width) Then
                x2 = frmMain.shp(iTo).Left + frmMain.shp(iTo).Width
                y2 = frmMain.shp(iTo).Top + frmMain.shp(iTo).Height / 2
            ' arrow will be at the bottom:
            ElseIf frmMain.shp(iFrom).Top > (frmMain.shp(iTo).Top + frmMain.shp(iTo).Height) Then
                x2 = frmMain.shp(iTo).Left + frmMain.shp(iTo).Width / 2
                y2 = frmMain.shp(iTo).Top + frmMain.shp(iTo).Height
            ' arrow will be on the left:
            ElseIf (frmMain.shp(iFrom).Left + frmMain.shp(iFrom).Width) < frmMain.shp(iTo).Left Then
                x2 = frmMain.shp(iTo).Left
                y2 = frmMain.shp(iTo).Top + frmMain.shp(iTo).Height / 2
            ' arrow will be at the top:
            Else
                x2 = frmMain.shp(iTo).Left + frmMain.shp(iTo).Width / 2
                y2 = frmMain.shp(iTo).Top
            End If
            
            ' update position of line's caption:
            If frmMain.lblLineCap(lineIndex).Caption <> "" Then
                lineIndex = theObjectLine.Index
                Dim tL As Single
                Dim tT As Single
                tL = x1 + (x2 - x1) / 2 - frmMain.lblLineCap(lineIndex).Width / 2
                tT = y1 + (y2 - y1) / 2 - frmMain.lblLineCap(lineIndex).Height / 2
                ' to prevent flickering:
                If (Fix(frmMain.lblLineCap(lineIndex).Left) <> Fix(tL)) _
                    Or (Fix(frmMain.lblLineCap(lineIndex).Top) <> Fix(tT)) Then
                        frmMain.lblLineCap(lineIndex).Move tL, tT
                        ' Debug.Print "Label updated: " & frmMain.lblLineCap(lineIndex).Index
                End If
            End If
        
        
        ' to prevent flickering (and unnecessary actions):
        If (Fix(theObjectLine.x1) <> Fix(x1)) Or (Fix(theObjectLine.y1) <> Fix(y1)) _
          Or (Fix(theObjectLine.x2) <> Fix(x2)) Or (Fix(theObjectLine.y2) <> Fix(y2)) Then
            theObjectLine.x1 = x1
            theObjectLine.y1 = y1
            theObjectLine.x2 = x2
            theObjectLine.y2 = y2
            
            ' update arrow for this line:
            showArrow
            
           ' Debug.Print "Line updated: " & theObjectLine.Index & "  " & x1, y1, x2, y2
           ' Debug.Print theObjectLine.y1, y1
        End If
        


End Sub


Private Sub showArrow()

    Dim mSin As Double
    Dim mCos As Double
    Dim pril As Double
    Dim prot As Double
    Dim gip As Double
    
    Dim arINDEX As Integer
    
    arINDEX = theObjectLine.Index
    
    pril = (theObjectLine.x1 - theObjectLine.x2)
    prot = (theObjectLine.y1 - theObjectLine.y2)
    
    gip = Sqr(pril ^ 2 + prot ^ 2)
    
    If gip <> 0 Then
        mSin = prot / gip
        mCos = pril / gip
    Else
        mSin = 0
        mCos = 0
        'Debug.Print "gip is zero!"
    End If
    
   Dim iXcor As Double
   Dim iYcor As Double
   
   Dim new_mSin1 As Double
   Dim new_mCos1 As Double
   Dim new_mSin2 As Double
   Dim new_mCos2 As Double
   
   Dim arrow_angle As Double
   Dim arrow_len As Double
   
   arrow_angle = 0.5
   arrow_len = 15
   
   ' according to quadrant add or subtract angle:
   If (mSin >= 0) And (mCos >= 0) Then
        new_mSin1 = sIn(Arcsin(mSin) - arrow_angle)
        new_mSin2 = sIn(Arcsin(mSin) + arrow_angle)
        new_mCos1 = Cos(Arccos(mCos) - arrow_angle)
        new_mCos2 = Cos(Arccos(mCos) + arrow_angle)
     ElseIf (mSin <= 0) And (mCos >= 0) Then
        new_mSin1 = sIn(Arcsin(mSin) - arrow_angle)
        new_mSin2 = sIn(Arcsin(mSin) + arrow_angle)
        new_mCos1 = Cos(Arccos(mCos) + arrow_angle)
        new_mCos2 = Cos(Arccos(mCos) - arrow_angle)
   ElseIf (mSin >= 0) And (mCos <= 0) Then
        new_mSin1 = sIn(Arcsin(mSin) + arrow_angle)
        new_mSin2 = sIn(Arcsin(mSin) - arrow_angle)
        new_mCos1 = Cos(Arccos(mCos) - arrow_angle)
        new_mCos2 = Cos(Arccos(mCos) + arrow_angle)
   ElseIf (mSin <= 0) And (mCos <= 0) Then
        new_mSin1 = sIn(Arcsin(mSin) + arrow_angle)
        new_mSin2 = sIn(Arcsin(mSin) - arrow_angle)
        new_mCos1 = Cos(Arccos(mCos) + arrow_angle)
        new_mCos2 = Cos(Arccos(mCos) - arrow_angle)
   End If
   
    
    ' arrow point:
    iXcor = theObjectLine.x2
    iYcor = theObjectLine.y2

    Dim X As Double
    Dim Y As Double

    X = iXcor   ' xRadius=0
    Y = iYcor   ' yRadius=0

    frmMain.aDot(arINDEX).Left = X - frmMain.aDot(arINDEX).Width / 2
    frmMain.aDot(arINDEX).Top = Y - frmMain.aDot(arINDEX).Height / 2
    
      
   frmMain.arrUp(arINDEX).x1 = frmMain.aDot(arINDEX).Left + frmMain.aDot(arINDEX).Width / 2
   frmMain.arrUp(arINDEX).y1 = frmMain.aDot(arINDEX).Top + frmMain.aDot(arINDEX).Height / 2
   frmMain.arrDown(arINDEX).x1 = frmMain.arrUp(arINDEX).x1
   frmMain.arrDown(arINDEX).y1 = frmMain.arrUp(arINDEX).y1
   
   ' xRadius=yRadius=0
   frmMain.arrUp(arINDEX).x2 = new_mCos1 * arrow_len + iXcor
   frmMain.arrUp(arINDEX).y2 = new_mSin1 * arrow_len + iYcor
   frmMain.arrDown(arINDEX).x2 = new_mCos2 * arrow_len + iXcor
   frmMain.arrDown(arINDEX).y2 = new_mSin2 * arrow_len + iYcor
   
    
   frmMain.arrUp(arINDEX).Visible = True
   frmMain.arrUp(arINDEX).ZOrder 0
   frmMain.arrDown(arINDEX).Visible = True
   frmMain.arrDown(arINDEX).ZOrder 0
   frmMain.aDot(arINDEX).Visible = True
   frmMain.aDot(arINDEX).ZOrder 0
    
End Sub


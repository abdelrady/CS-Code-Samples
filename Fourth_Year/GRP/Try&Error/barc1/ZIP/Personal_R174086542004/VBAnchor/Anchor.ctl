VERSION 5.00
Begin VB.UserControl Anchor 
   ClientHeight    =   495
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   495
   InvisibleAtRuntime=   -1  'True
   Picture         =   "Anchor.ctx":0000
   PropertyPages   =   "Anchor.ctx":0BE2
   ScaleHeight     =   495
   ScaleWidth      =   495
   ToolboxBitmap   =   "Anchor.ctx":0BF2
End
Attribute VB_Name = "Anchor"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
'******************************************
'* Developer : Hamed Oveisi               *
'******************************************
Dim LastHeight As Long, LastWidth As Long
Public MinHeight As Long, MinWidth As Long
Dim WithEvents Frm As Form
Attribute Frm.VB_VarHelpID = -1


'********************************************
' DoResize checks the control tag and resize
'it.
'
' HeightChange and WidthChange are both save
'changing in height or width
'
'
' Use Tag this way: Left,Top,Right and Bottom
' If U want to resize your control from all 4 sides
'use Tag this way: TTTT (T means True)
'********************************************
Public Sub DoResize()
    On Error Resume Next
    Dim HeightChange As Long, WidthChange As Long
    Dim Tg As String
    Dim i As Integer
    
    
    ' Exit sub on Minimize
    If Frm.WindowState = vbMinimized Then Exit Sub
    
    ' Check the form for Min Values
    If Frm.Height <= MinHeight Then Frm.Height = MinHeight
    If Frm.Width <= MinWidth Then Frm.Width = MinWidth
    
    'Calculate the Changes
    HeightChange = Frm.Height - LastHeight
    WidthChange = Frm.Width - LastWidth
    'If this is not the first time of resize
    If LastHeight <> 0 And LastWidth <> 0 Then
'FIXIT: 'Controls.Count' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls.Count' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
        For i = 0 To Frm.Controls.Count - 1
            Tg = Ctrls(i)
            
            'Checking Tag
            If Right$(Tg, 1) = "T" Then
                If Mid$(Tg, 2, 1) = "T" Then
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
                    Frm.Controls(i).Height = Frm.Controls(i).Height + HeightChange
                Else
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
                    Frm.Controls(i).Top = Frm.Controls(i).Top + HeightChange
                End If
            End If
            
            If Mid$(Tg, 3, 1) = "T" Then
                If Left$(Tg, 1) = "T" Then
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
                    Frm.Controls(i).Width = Frm.Controls(i).Width + WidthChange
                Else
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
                    Frm.Controls(i).Left = Frm.Controls(i).Left + WidthChange
                End If
            End If
        Next i
    Else
        'This is the first Resize
        MinHeight = Frm.Height
        MinWidth = Frm.Width
    End If
    'Save Last values
    LastHeight = Frm.Height
    LastWidth = Frm.Width
End Sub


Private Sub Frm_Load()
    On Error Resume Next
    Dim i As Integer
    Dim Tg As String
    Set Frm = Extender.Parent
'FIXIT: 'Controls.Count' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls.Count' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
    ReDim Ctrls(Frm.Controls.Count)
    'Save Tag Properties of Controls so that Tag
    'Can be use in runtime for other reasons
'FIXIT: 'Controls.Count' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls.Count' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
    For i = 0 To Frm.Controls.Count - 1
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
         Tg = Frm.Controls(i).Tag
         ' Every anchor information ends with */
         If InStr(1, Tg, "*/") > 0 Then
            Ctrls(i) = Left$(Tg, 4)
            ' Now eliminate anchors from Tag property!
            ' So there is no dependency to
            ' the TAG property of the object.
'FIXIT: 'Controls(i' is not a property of the generic 'Form' object in Visual Basic .NET. To access 'Controls(i' declare 'Frm' using its actual type instead of 'Form'     FixIT90210ae-R1460-RCFE85
            Frm.Controls(i).Tag = Right$(Tg, Len(Tg) - 6)
         End If
    Next i
End Sub

Private Sub Frm_Resize()
    DoResize
End Sub

Private Sub UserControl_Initialize()
   On Error Resume Next
   Set Frm = Extender.Parent
   Set CtrlParent = Extender.Parent
   
End Sub

Private Sub UserControl_InitProperties()
   On Error Resume Next
   Set Frm = Extender.Parent
   Set CtrlParent = Extender.Parent
   
End Sub

Private Sub UserControl_Resize()
    On Error Resume Next
    Set Frm = Extender.Parent
    Set CtrlParent = Extender.Parent
    Width = 480
    Height = 465
   
End Sub

Public Sub About()
Attribute About.VB_UserMemId = -552
   Dim Msg As String
   Msg = "Anchor Property for Visual Basic V2.0" & vbCr
   Msg = Msg & "Written by : Hamed Oveisi"
   MsgBox Msg, vbInformation, "About Anchor"
   
End Sub

VERSION 5.00
Begin VB.UserControl GShape 
   Appearance      =   0  'Flat
   BackColor       =   &H80000005&
   ClientHeight    =   1470
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   1590
   FillColor       =   &H00FFFFFF&
   FillStyle       =   0  'Solid
   BeginProperty Font 
      Name            =   "Fixedsys"
      Size            =   9
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00000000&
   MaskColor       =   &H00000000&
   ScaleHeight     =   98
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   106
End
Attribute VB_Name = "GShape"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
' ===========================================
'  === Project of Visual Logic Language ===
' ===========================================
' Authors:
'           Yuri Margolin
'           Asaf Shoshani
' ORT Academic College
' July 2001
' ===========================================
'  Active-X code for myShape
' ===========================================

Option Explicit
'Default Property Values:
Const m_def_TextColor = 0
Const m_def_BGColor = 0
Const m_def_Shape = 0
Const m_def_BorderColor = 0
Const m_def_sCaptionUp = ""
Const m_def_sCaption = ""
'Property Variables:
Dim m_TextColor As OLE_COLOR
Dim m_BGColor As OLE_COLOR
Dim m_Shape As Integer
Dim m_BorderColor As OLE_COLOR
Dim m_sCaptionUp As String
Dim m_sCaption As String

Dim downX As Single
Dim downY As Single
'Event Declarations:
Event DblClick() 'MappingInfo=UserControl,UserControl,-1,DblClick
Attribute DblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseDown
Attribute MouseDown.VB_Description = "Occurs when the user presses the mouse button while an object has the focus."
Event MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseMove
Attribute MouseMove.VB_Description = "Occurs when the user moves the mouse."
Event MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseUp
Attribute MouseUp.VB_Description = "Occurs when the user releases the mouse button while an object has the focus."


'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,
Public Property Get sCaption() As String
    sCaption = m_sCaption
End Property

Public Property Let sCaption(ByVal New_sCaption As String)
    m_sCaption = New_sCaption
    PropertyChanged "sCaption"
End Property

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    m_sCaption = m_def_sCaption
    m_BorderColor = m_def_BorderColor
    m_Shape = m_def_Shape
    m_sCaptionUp = m_def_sCaptionUp
    m_BGColor = m_def_BGColor
    m_TextColor = m_def_TextColor
End Sub

Private Sub UserControl_Paint()
    Dim tWidth As Single
    Dim tHeight As Single
    Dim p(0 To 5) As POINTAPI

 ' because of below:
 On Error GoTo err_expt

' sometimes there is an error: Client site not available!
'  in the end  of execution of c.tzr (on closing of frmMain):
    UserControl.BackColor = UserControl.Parent.BackColor
    UserControl.Cls

    ' temporary variables to keep width-1 and height-1
    tWidth = UserControl.ScaleWidth - 1
    tHeight = UserControl.ScaleHeight - 1

    UserControl.ForeColor = m_BorderColor
    UserControl.FillColor = m_BGColor

    Select Case m_Shape
    
    Case 0      ' rectangle
        ' draw frame:
        UserControl.Line (0, 0)-(tWidth, tHeight), , B
        ' draw inside:
        UserControl.Line (1, 1)-(tWidth - 1, tHeight - 1), UserControl.FillColor, BF
    Case 2      ' oval
        UserControl.Circle (tWidth / 2, tHeight / 2), tWidth / 2, , , , tHeight / tWidth
    
    Case 3      ' circle
        UserControl.Circle (tWidth / 2, tHeight / 2), tWidth / 2
    
    Case 91     ' parallelogram.
        p(0).x = 10
        p(0).y = 0
        p(1).x = tWidth
        p(1).y = 0
        p(2).x = tWidth - 10
        p(2).y = tHeight
        p(3).x = 0
        p(3).y = tHeight
        Polygon UserControl.hdc, p(0), 4
        
    Case 92     ' diamond.
        p(0).x = tWidth / 2
        p(0).y = 0
        p(1).x = tWidth
        p(1).y = tHeight / 2
        p(2).x = tWidth / 2
        p(2).y = tHeight
        p(3).x = 0
        p(3).y = tHeight / 2
        Polygon UserControl.hdc, p(0), 4
        
    Case 93     ' six-point diamond.
        p(0).x = 0
        p(0).y = tHeight / 2
        p(1).x = 10
        p(1).y = 0
        p(2).x = tWidth - 10
        p(2).y = 0
        p(3).x = tWidth
        p(3).y = tHeight / 2
        p(4).x = tWidth - 10
        p(4).y = tHeight
        p(5).x = 10
        p(5).y = tHeight
        Polygon UserControl.hdc, p(0), 6
          
    Case Else
        MsgBox "wrong setting to Shape property: " & m_Shape
    End Select

   
    ' print the caption:
    
    ' restore ForeColor:
    UserControl.ForeColor = m_TextColor
    
    ' in case there is one line caption:
    If m_sCaptionUp = "" Then
        UserControl.CurrentX = tWidth / 2 - UserControl.TextWidth(m_sCaption) / 2
        UserControl.CurrentY = tHeight / 2 - UserControl.TextHeight(m_sCaption) / 2
        UserControl.Print m_sCaption
    ' in case there are two lines in caption:
    Else
        ' print first line:
        UserControl.CurrentX = tWidth / 2 - UserControl.TextWidth(m_sCaptionUp) / 2
        UserControl.CurrentY = tHeight / 2 - UserControl.TextHeight(m_sCaptionUp)
        UserControl.Print m_sCaptionUp
        ' print second line:
        UserControl.CurrentX = tWidth / 2 - UserControl.TextWidth(m_sCaption) / 2
        UserControl.CurrentY = tHeight / 2
        UserControl.Print m_sCaption
    End If

    Exit Sub
err_expt:

End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)

    m_sCaption = PropBag.ReadProperty("sCaption", m_def_sCaption)
    m_BorderColor = PropBag.ReadProperty("BorderColor", m_def_BorderColor)
    m_Shape = PropBag.ReadProperty("Shape", m_def_Shape)
    m_sCaptionUp = PropBag.ReadProperty("sCaptionUp", m_def_sCaptionUp)
    m_BGColor = PropBag.ReadProperty("BGColor", m_def_BGColor)
    m_TextColor = PropBag.ReadProperty("TextColor", m_def_TextColor)
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("sCaption", m_sCaption, m_def_sCaption)
    Call PropBag.WriteProperty("BorderColor", m_BorderColor, m_def_BorderColor)
    Call PropBag.WriteProperty("Shape", m_Shape, m_def_Shape)
    Call PropBag.WriteProperty("sCaptionUp", m_sCaptionUp, m_def_sCaptionUp)
    Call PropBag.WriteProperty("BGColor", m_BGColor, m_def_BGColor)
    Call PropBag.WriteProperty("TextColor", m_TextColor, m_def_TextColor)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=10,0,0,0
Public Property Get BorderColor() As OLE_COLOR
    BorderColor = m_BorderColor
End Property

Public Property Let BorderColor(ByVal New_BorderColor As OLE_COLOR)
    m_BorderColor = New_BorderColor
    PropertyChanged "BorderColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=7,0,0,0
Public Property Get Shape() As Integer
    Shape = m_Shape
End Property

Public Property Let Shape(ByVal New_Shape As Integer)
    m_Shape = New_Shape
    PropertyChanged "Shape"
End Property

Private Sub UserControl_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseDown(Button, Shift, x, y)
End Sub

Private Sub UserControl_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseMove(Button, Shift, x, y)
End Sub

Private Sub UserControl_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
    RaiseEvent MouseUp(Button, Shift, x, y)
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,
Public Property Get sCaptionUp() As String
    sCaptionUp = m_sCaptionUp
End Property

Public Property Let sCaptionUp(ByVal New_sCaptionUp As String)
    m_sCaptionUp = New_sCaptionUp
    PropertyChanged "sCaptionUp"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=14
Public Function RepaintBlock() As Variant
    UserControl_Paint
End Function

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=10,0,0,0
Public Property Get BGColor() As OLE_COLOR
    BGColor = m_BGColor
End Property

Public Property Let BGColor(ByVal New_BGColor As OLE_COLOR)
    m_BGColor = New_BGColor
    PropertyChanged "BGColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=10,0,0,0
Public Property Get TextColor() As OLE_COLOR
    TextColor = m_TextColor
End Property

Public Property Let TextColor(ByVal New_TextColor As OLE_COLOR)
    m_TextColor = New_TextColor
    PropertyChanged "TextColor"
End Property

Private Sub UserControl_DblClick()
    RaiseEvent DblClick
End Sub


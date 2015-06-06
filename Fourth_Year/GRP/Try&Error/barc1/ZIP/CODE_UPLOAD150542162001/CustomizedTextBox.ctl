VERSION 5.00
Begin VB.UserControl CustomizedTextBox 
   BackStyle       =   0  'Transparent
   ClientHeight    =   90
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   90
   ScaleHeight     =   90
   ScaleWidth      =   90
   ToolboxBitmap   =   "CustomizedTextBox.ctx":0000
   Begin VB.TextBox txtTextBox 
      Height          =   225
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   75
   End
End
Attribute VB_Name = "CustomizedTextBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
' DISCLAIMER (for public posting):
' This software is provided on an "as is, where is" basis, with no warranty whatsoever.
' As a condition of your using this software, you agree that Westinghouse Electric Company
' shall not be liable with respect to or as a result of such use.  Further, you agree to
' indemnify and hold Westinghouse harmless in the event a claim is made against
' Westinghouse with respect to or as a result of your use of the software.


' Control: CustomizedTextBox
' Purpose: To provide an enhanced textbox control
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/22/01)


Option Explicit

   
' ******************************************************************************************************************
' DECLARATION OF PRIVATE CONTROL CONSTANTS
' ******************************************************************************************************************
Private Const KEY_BACKSPACE = 8
Private Const KEY_COPY As Integer = 3
Private Const KEY_CUT As Integer = 24
Private Const KEY_ENTER As Integer = 13
Private Const KEY_ESCAPE As Integer = 27
Private Const KEY_PASTE As Integer = 22
Private Const KEY_UNDO As Integer = 26


' ******************************************************************************************************************
' DECLARATION OF USER DEFINED TYPES
' ******************************************************************************************************************
' Used for the "Alignment" property
Enum udtAlignment
    Left_Justify = 0
    Right_Justify = 1
    Center = 2
End Enum

' Used for the "Appearance" property
Enum udtAppearance
    Appear_Flat = 0
    Appear_3D = 1
End Enum

' Used for the "BorderStyle" property
Enum udtBorderStyle
    None = 0
    Fixed_Single = 1
End Enum

' Used for the "LinkMode" property
Enum udtLinkMode
    None = 0
    Automatic = 1
    Manual = 2
    Notify = 3
End Enum

' Used for the "MousePointer" property
Enum udtMousePointer
    Default = 0
    Arrow = 1
    Cross = 2
    I_Beam = 3
    Icon = 4
    Size = 5
    Size_NE_SW = 6
    Size_N_S = 7
    Size_NW_SE = 8
    Size_W_E = 9
    Up_Arrow = 10
    Hourglass = 11
    No_Drop = 12
    Arrow_And_Hourglass = 13
    Arrow_And_Question = 14
    Size_All = 15
    Custom = 99
End Enum

' Used for "OLEDragMode" property
Enum udtOLEDragMode
    Manual = 0
    Automatic = 1
End Enum

' Used for "OLEDropMode" property
Enum udtOLEDropMode
    None = 0
    Manual = 1
    Automatic = 2
End Enum

' Used for "TextType" Property
Enum udtTextType
    AlphaNumeric = 0
    AlphaNumeric_NoSymbols = 1
    Alpha_WithSymbols = 2
    Alpha_NoSymbols = 3
    Numeric_Integers_Pos = 4
    Numeric_Integers_Neg = 5
    Numeric_Integers_All = 6
    Numeric_Real_Pos = 7
    Numeric_Real_Neg = 8
    Numeric_Real_All = 9
    Numeric_WithSymbols = 10
End Enum


' ******************************************************************************************************************
' DECLARATION OF PRIVATE CONTROL PROPERTY HOLDERS & OBJECTS
' ******************************************************************************************************************
Private mBackColor_OnGotFocus As OLE_COLOR
    ' The color that the textbox changes to when it receives the focus
Private mBackColor_Normal As OLE_COLOR
    ' The color that the textbox has to when it doesn't have the focus
    
Private mstrDefaultText As String
    ' The default text for the textbox
Private mstrUndoText As String
    ' The textbox "undo" text

Private mlngEntryStartTime As Long
    ' Holds the tick count at the start of text entry
Private mlngMaxEntryTime As Long
    ' The maximum amount of time allowed once an entry begins (if expires, the "EntryTimedOut" event fires)
    
Private mintTextType As Integer
    ' The type of text that is allowed in the textbox (numeric, non-numeric, etc.)
    
Private mblnAutoSelect As Boolean
    ' Flag - Should the textbox text be automatically selected when the textbox receives the focus?
Private mblnAutoUpperCase As Boolean
    ' Flag - Should the textbox text be automatically converted to uppercase as text is entered?
Private mblnEntryTimedOut As Boolean
    ' Flag - Did the current text entry time out?
Private mblnEntryTimerEnabled As Boolean
    ' Flag - Should the entry timer be used?
Private mblnMouseDown As Boolean
    ' Flag - Is the mouse button currently clicked down?
Private mblnSelectWhenClicked  As Boolean
    ' Flag - Should the textbox text be selected the next time the textbox is clicked?
Private mblnUseDefaultText As Boolean
    ' Flag - Should default text be used when user presses escape twice (after undo)?

    
' ******************************************************************************************************************
' DECLARATION OF PRIVATE CONTROL EVENTS
' ******************************************************************************************************************
Event Change()
Event Click()
Event DblClick()
Event EntryTimedOut()
Event KeyPress(KeyAscii As Integer)
Event KeyDown(KeyCode As Integer, Shift As Integer)
Event KeyUp(KeyCode As Integer, Shift As Integer)
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
Event OLECompleteDrag(Effect As Long)
Event OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
Event OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
Event OLEGiveFeedback(Effect As Long, DefaultCursors As Boolean)
Event OLESetData(Data As DataObject, DataFormat As Integer)
Event OLEStartDrag(Data As DataObject, AllowedEffects As Long)


' ******************************************************************************************************************
' IMPLEMENTATION OF CLASS PROPERTY GET / LET STATEMENTS
' ******************************************************************************************************************
' ******************************************************************************************************************
' Property: CustomizedTextBox.Alignment
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Alignment() As udtAlignment
Attribute Alignment.VB_Description = "Returns/sets the text alignmnent"
    Alignment = txtTextBox.Alignment
End Property

Public Property Let Alignment(ByVal udtValue As udtAlignment)
    txtTextBox.Alignment = udtValue
    PropertyChanged "Alignment"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.Appearance
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Appearance() As udtAppearance
    Appearance = txtTextBox.Appearance
End Property

Public Property Let Appearance(ByVal udtValue As udtAppearance)
    txtTextBox.Appearance = udtValue
    PropertyChanged "Appearance"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.AutoUpperCase
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get AutoUpperCase() As Boolean
    AutoUpperCase = mblnAutoUpperCase
End Property

Public Property Let AutoUpperCase(ByVal blnValue As Boolean)
    mblnAutoUpperCase = blnValue
    PropertyChanged "AutoUpperCase"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.AutoSelect
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get AutoSelect() As Boolean
    AutoSelect = mblnAutoSelect
End Property

Public Property Let AutoSelect(ByVal blnValue As Boolean)
    mblnAutoSelect = blnValue
    PropertyChanged "AutoSelect"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.BackColor_OnGotFocus
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get BackColor_OnGotFocus() As OLE_COLOR
Attribute BackColor_OnGotFocus.VB_Description = "This is the color that the textbox will change to when it receives focus."
Attribute BackColor_OnGotFocus.VB_ProcData.VB_Invoke_Property = ";Appearance"
    BackColor_OnGotFocus = mBackColor_OnGotFocus
End Property

Public Property Let BackColor_OnGotFocus(ByVal oleValue As OLE_COLOR)
    mBackColor_OnGotFocus = oleValue
    PropertyChanged "BackColor_OnGotFocus"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.BackColor_Normal
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get BackColor_Normal() As OLE_COLOR
Attribute BackColor_Normal.VB_Description = "This is the color that the textbox will change to when it loses focus."
Attribute BackColor_Normal.VB_ProcData.VB_Invoke_Property = ";Appearance"
    BackColor_Normal = mBackColor_Normal
End Property

Public Property Let BackColor_Normal(ByVal oleValue As OLE_COLOR)
    mBackColor_Normal = oleValue
    PropertyChanged "BackColor_Normal"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.BorderStyle
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get BorderStyle() As udtBorderStyle
    BorderStyle = txtTextBox.BorderStyle
End Property

Public Property Let BorderStyle(ByVal udtValue As udtBorderStyle)
    txtTextBox.BorderStyle = udtValue
    PropertyChanged "BorderStyle"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.CausesValidation
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get CausesValidation() As Boolean
    CausesValidation = txtTextBox.CausesValidation
End Property

Public Property Let CausesValidation(ByVal blnValue As Boolean)
    txtTextBox.CausesValidation = blnValue
    PropertyChanged "CausesValidation"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.DataField
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get DataField() As String
Attribute DataField.VB_MemberFlags = "103c"
    DataField = txtTextBox.DataField
End Property

Public Property Let DataField(ByVal strValue As String)
    txtTextBox.DataField = strValue
    PropertyChanged "DataField"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.DefaultText
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get DefaultText() As String
Attribute DefaultText.VB_ProcData.VB_Invoke_Property = ";Text"
    DefaultText = mstrDefaultText
End Property

Public Property Let DefaultText(ByVal strValue As String)
    mstrDefaultText = strValue
    PropertyChanged "DefaultText"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.Enabled
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get Enabled() As Boolean
    Enabled = txtTextBox.Enabled
End Property

Public Property Let Enabled(ByVal blnValue As Boolean)
    txtTextBox.Enabled = blnValue
    PropertyChanged "Enabled"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.MaxEntryTime
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: January 22, 2001 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Public Property Get MaxEntryTime() As Long
Attribute MaxEntryTime.VB_Description = "The maximum amount of time (in ms) that can pass once text entry has started before the entry times out."
    MaxEntryTime = mlngMaxEntryTime
End Property

Public Property Let MaxEntryTime(ByVal lngValue As Long)
    mlngMaxEntryTime = lngValue
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.EntryTimedOut
' Access: Read only
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: January 22, 2001 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Public Property Get EntryTimedOut() As Long
    EntryTimedOut = mblnEntryTimedOut
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.EntryTimerEnabled
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: January 22, 2001 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Public Property Get EntryTimerEnabled() As Boolean
Attribute EntryTimerEnabled.VB_Description = "Enables/disables the entry timer, which is used to determine whether or not the text entry is scanned."
    EntryTimerEnabled = mblnEntryTimerEnabled
End Property

Public Property Let EntryTimerEnabled(ByVal blnValue As Boolean)
    mblnEntryTimerEnabled = blnValue
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.Font
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Font() As Font
Attribute Font.VB_ProcData.VB_Invoke_Property = ";Font"
   Set Font = txtTextBox.Font
End Property

Public Property Set Font(ByVal fonValue As Font)
   Set txtTextBox.Font = fonValue
   PropertyChanged "Font"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontBold
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontBold() As Boolean
Attribute FontBold.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontBold.VB_MemberFlags = "400"
   FontBold = txtTextBox.FontBold
End Property

Public Property Let FontBold(ByVal blnValue As Boolean)
   txtTextBox.FontBold = blnValue
   PropertyChanged "FontBold"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontItalic
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontItalic() As Boolean
Attribute FontItalic.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontItalic.VB_MemberFlags = "400"
   FontItalic = txtTextBox.FontItalic
End Property

Public Property Let FontItalic(ByVal blnValue As Boolean)
   txtTextBox.FontItalic = blnValue
   PropertyChanged "FontItalic"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontName
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontName() As String
Attribute FontName.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontName.VB_MemberFlags = "400"
   FontName = txtTextBox.FontName
End Property

Public Property Let FontName(ByVal strValue As String)
   txtTextBox.FontName = strValue
   PropertyChanged "FontName"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontSize
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontSize() As Integer
Attribute FontSize.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontSize.VB_MemberFlags = "400"
   FontSize = txtTextBox.FontSize
End Property

Public Property Let FontSize(ByVal intValue As Integer)
   txtTextBox.FontSize = intValue
   PropertyChanged "FontSize"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontStrikethru
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontStrikethru() As Boolean
Attribute FontStrikethru.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontStrikethru.VB_MemberFlags = "400"
   FontStrikethru = txtTextBox.FontStrikethru
End Property

Public Property Let FontStrikethru(ByVal blnValue As Boolean)
   txtTextBox.FontStrikethru = blnValue
   PropertyChanged "FontStrikethru"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.FontUnderline
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get FontUnderline() As Boolean
Attribute FontUnderline.VB_ProcData.VB_Invoke_Property = ";Font"
Attribute FontUnderline.VB_MemberFlags = "400"
   FontUnderline = txtTextBox.FontUnderline
End Property

Public Property Let FontUnderline(ByVal blnValue As Boolean)
   txtTextBox.FontUnderline = blnValue
   PropertyChanged "FontUnderline"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.ForeColor
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get ForeColor() As OLE_COLOR
   ForeColor = txtTextBox.ForeColor
End Property

Public Property Let ForeColor(ByVal oleValue As OLE_COLOR)
   txtTextBox.ForeColor = oleValue
   PropertyChanged "ForeColor"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.HideSelection
' Access: Read only
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get HideSelection() As Boolean
   HideSelection = txtTextBox.HideSelection
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.hWnd
' Access: Read only
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get hWnd() As Long
   hWnd = txtTextBox.hWnd
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.Index
' Access: Read only
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Index() As Long
   Index = txtTextBox.Index
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.Left
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Left() As Long
   Left = txtTextBox.Left
End Property

Public Property Let Left(ByVal lngValue As Long)
   txtTextBox.Left = lngValue
   PropertyChanged "Left"
End Property
        
' ******************************************************************************************************************
' Property:  CustomizedTextBox.LinkItem
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get LinkItem() As String
   LinkItem = txtTextBox.LinkItem
End Property

Public Property Let LinkItem(ByVal strValue As String)
   txtTextBox.LinkItem = strValue
   PropertyChanged "LinkItem"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.Locked
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Locked() As Boolean
   Locked = txtTextBox.Locked
End Property

Public Property Let Locked(ByVal blnValue As Boolean)
   txtTextBox.Locked = blnValue
   PropertyChanged "Locked"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.MaxLength
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get MaxLength() As Long
   MaxLength = txtTextBox.MaxLength
End Property

Public Property Let MaxLength(ByVal lngValue As Long)
   txtTextBox.MaxLength = lngValue
   PropertyChanged "MaxLength"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.MousePointer
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get MousePointer() As udtMousePointer
   MousePointer = txtTextBox.MousePointer
End Property

Public Property Let MousePointer(ByVal udtValue As udtMousePointer)
   txtTextBox.MousePointer = udtValue
   PropertyChanged "MousePointer"
End Property
        
' ******************************************************************************************************************
' Property:  CustomizedTextBox.MultiLine
' Access: Read only
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get MultiLine() As Boolean
   MultiLine = txtTextBox.MultiLine
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.OLEDragMode
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get OLEDragMode() As udtOLEDragMode
   OLEDragMode = txtTextBox.OLEDragMode
End Property

Public Property Let OLEDragMode(ByVal udtValue As udtOLEDragMode)
   txtTextBox.OLEDragMode = udtValue
   PropertyChanged "OLEDragMode"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.OLEDropMode
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get OLEDropMode() As udtOLEDropMode
   OLEDropMode = txtTextBox.OLEDropMode
End Property

Public Property Let OLEDropMode(ByVal udtValue As udtOLEDropMode)
   txtTextBox.OLEDropMode = udtValue
   PropertyChanged "OLEDropMode"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.PasswordChar
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get PasswordChar() As String
   PasswordChar = txtTextBox.PasswordChar
End Property

Public Property Let PasswordChar(ByVal strValue As String)
   txtTextBox.PasswordChar = strValue
   PropertyChanged "PasswordChar"
End Property

' ******************************************************************************************************************
' Property:  CustomizedTextBox.RightToLeft
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get RightToLeft() As Boolean
   RightToLeft = txtTextBox.RightToLeft
End Property

Public Property Let RightToLeft(ByVal blnValue As Boolean)
   txtTextBox.RightToLeft = blnValue
   PropertyChanged "RightToLeft"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.Text
' Access: Read / write
' Note: This property will be used as a "text" property, allowing textbox text to be updated at
'       design time as it is entered (see "Text_AsDefaultProperty" for other half of this "trick")
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Text() As String
Attribute Text.VB_ProcData.VB_Invoke_Property = ";Text"
Attribute Text.VB_UserMemId = -517
    Text = txtTextBox.Text
End Property

Public Property Let Text(ByVal strNewText As String)
    txtTextBox.Text() = strNewText
    PropertyChanged "Text"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.Text_AsDefaultProperty
' Access: Read / write
' Note: This property will be used as control's default property, and can only be set at runtime;
'       however, it will not be visible to the developer (even though it will receive the text)
'       This trick allows textbox text to be default property as well as a "text" property
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get Text_AsDefaultProperty() As String
    Text_AsDefaultProperty = txtTextBox.Text
End Property

Public Property Let Text_AsDefaultProperty(ByVal strNewText As String)
Attribute Text_AsDefaultProperty.VB_ProcData.VB_Invoke_PropertyPut = ";Text"
Attribute Text_AsDefaultProperty.VB_UserMemId = 0
Attribute Text_AsDefaultProperty.VB_MemberFlags = "40"
    txtTextBox.Text() = strNewText
    PropertyChanged "Text_AsDefaultProperty"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.TextType
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 18, 2000 (Last Updated: 10/18/00)
' ******************************************************************************************************************
Public Property Get TextType() As udtTextType
    TextType = mintTextType
End Property

Public Property Let TextType(ByVal intValue As udtTextType)
    mintTextType = intValue
    PropertyChanged "TextType"
End Property

' ******************************************************************************************************************
' Property: CustomizedTextBox.UseDefaultText
' Access: Read / write
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Public Property Get UseDefaultText() As Boolean
    UseDefaultText = mblnUseDefaultText
End Property

Public Property Let UseDefaultText(ByVal blnValue As Boolean)
    mblnUseDefaultText = blnValue
    PropertyChanged "UseDefaultText"
End Property


' ******************************************************************************************************************
' IMPLEMENTATION OF PRIVATE CONTROL EVENTS
' ******************************************************************************************************************
' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_Change
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' *****************************************************************************************************************
Private Sub txtTextBox_Change()
    RaiseEvent Change
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_Click
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/17/01)
' *****************************************************************************************************************
Private Sub txtTextBox_Click()
    RaiseEvent Click
    
    With txtTextBox
        ' If text is supposed to be selected due to textbox being clicked...
        If mblnAutoSelect And mblnSelectWhenClicked Then
            ' Select text
            .SelStart = 0
            .SelLength = Len(.Text)
            
            ' Reset flag (this will be set again when textbox loses focus)
            mblnSelectWhenClicked = False
        End If
    End With
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_DblClick
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 11/03/00)
' *****************************************************************************************************************
Private Sub txtTextBox_DblClick()
    RaiseEvent DblClick
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_GotFocus
' Purpose: Performs various operations when textbox receives the focus
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/17/01)
' ******************************************************************************************************************
Private Sub txtTextBox_GotFocus()
    With txtTextBox
        ' If "auto select" is on...
        If mblnAutoSelect Then
            ' If textbox received focus via tab, select text and reset "select when clicked"
            If GetKeyState(VK_TAB) < 0 Then
                .SelStart = 0
                .SelLength = Len(.Text)
                mblnSelectWhenClicked = False
            ' Otherwise, if textbox received focus via click, set "select when clicked"
            ElseIf mblnMouseDown Then
                mblnSelectWhenClicked = True
            ' Otherwise (probably form load), select text and reset "select when clicked"
            Else
                .SelStart = 0
                .SelLength = Len(.Text)
                mblnSelectWhenClicked = False
            End If
        End If
        
        ' Get the "undo" text
        mstrUndoText = .Text
    
        ' Change the color to the "got focus" color
        .BackColor = mBackColor_OnGotFocus
    End With
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_KeyDown
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' *****************************************************************************************************************
Private Sub txtTextBox_KeyDown(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyDown(KeyCode, Shift)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_KeyPress
' Purpose: Performs various actions when key is pressed (text entered into textbox)
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Private Sub txtTextBox_KeyPress(KeyAscii As Integer)
    RaiseEvent KeyPress(KeyAscii)
    
    ' Convert to uppercase
    If mblnAutoUpperCase Then KeyAscii = Asc(UCase(Chr$(KeyAscii)))
    
    ' If "escape" key pressed, undo changes made since textbox received focus, then exit sub
    If KeyAscii = KEY_ESCAPE Then
        ' Restore text
        txtTextBox.Text = mstrUndoText
        
        ' Select text
        txtTextBox.SelStart = 0
        txtTextBox.SelLength = Len(txtTextBox.Text)
        
        ' If "use default" flag is true, set undo to default so that next time, "escape" will revert to default
        If mblnUseDefaultText Then
            mstrUndoText = mstrDefaultText
        End If
        
        Exit Sub
    ' Otherwise, if some other sort of control key (backspace, enter, etc.) was pressed, exit sub
    ElseIf KeyAscii = KEY_BACKSPACE Or KeyAscii = KEY_ENTER Or KeyAscii = KEY_CUT _
        Or KeyAscii = KEY_COPY Or KeyAscii = KEY_PASTE Or KeyAscii = KEY_UNDO Then
        Exit Sub
    End If

    ' If entry timer is enabled...
    If mblnEntryTimerEnabled Then
        ' If entry timer hasn't been started yet, start it now
        If mlngEntryStartTime = 0 And Not (mblnEntryTimedOut) Then
            mlngEntryStartTime = GetTickCount()
        ' Otherwise (timer started), if timer is still running (not already tripped), check to see if max time has
        ' expired; if it has, trip timer now (timer will not be started and/or checked again until manually reset)
        ElseIf Not (mblnEntryTimedOut) And GetTickCount() - mlngEntryStartTime > mlngMaxEntryTime Then
            mblnEntryTimedOut = True
            RaiseEvent EntryTimedOut
        End If
    End If
    
    Select Case mintTextType
        ' Allow all ASCII chars
        Case udtTextType.AlphaNumeric
        
        ' Allow alpha and numeric chars, but no symbols
        Case udtTextType.AlphaNumeric_NoSymbols
            If KeyAscii < 48 Or (KeyAscii > 57 And KeyAscii < 65) Or (KeyAscii > 90 And KeyAscii < 97) _
                Or KeyAscii > 122 Then KeyAscii = 0
                
        ' Allow alpha chars with symbols
        Case udtTextType.Alpha_WithSymbols
            If KeyAscii >= 48 And KeyAscii <= 57 Then KeyAscii = 0
            
        ' Allow alpha chars with no symbols
        Case udtTextType.Alpha_NoSymbols
            If KeyAscii < 65 Or (KeyAscii > 90 And KeyAscii < 97) Or KeyAscii > 122 Then KeyAscii = 0
        
        ' Allow only positive integers
        Case udtTextType.Numeric_Integers_Pos
            If (KeyAscii < 48 Or KeyAscii > 57) Then KeyAscii = 0
        
        ' Allow only negative integers
        Case udtTextType.Numeric_Integers_Neg
            If ((KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 45) _
                Or (KeyAscii = 45 And Len(txtTextBox) <> 0 And txtTextBox.SelLength <> Len(txtTextBox)) _
                Or ((Len(txtTextBox) = 0 Or txtTextBox.SelLength = Len(txtTextBox)) And KeyAscii <> 45) Then KeyAscii = 0
    
        ' Allow all integers
        Case udtTextType.Numeric_Integers_All
            If ((KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 45) _
                Or (KeyAscii = 45 And Len(txtTextBox) <> 0 And txtTextBox.SelLength <> Len(txtTextBox)) Then KeyAscii = 0
    
        ' Allow only positive real numbers
        Case udtTextType.Numeric_Real_Pos
            If ((KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 46) _
                Or (KeyAscii = 46 And (InStr(1, txtTextBox, Chr$(46)) Or txtTextBox.SelLength = Len(txtTextBox))) Then KeyAscii = 0

        ' Allow only negative real numbers
        Case udtTextType.Numeric_Real_Neg
            If ((KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 45 And KeyAscii <> 46) _
                Or (KeyAscii = 45 And Len(txtTextBox) <> 0 And txtTextBox.SelLength <> Len(txtTextBox)) _
                Or ((Len(txtTextBox) = 0 Or txtTextBox.SelLength = Len(txtTextBox)) And KeyAscii <> 45) _
                Or (KeyAscii = 46 And (InStr(1, txtTextBox, Chr$(46)) Or txtTextBox.SelLength = Len(txtTextBox))) Then KeyAscii = 0
        
        ' Allow all real numbers
        Case udtTextType.Numeric_Real_All
            If ((KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 45 And KeyAscii <> 46) _
                Or (KeyAscii = 45 And Len(txtTextBox) <> 0 And txtTextBox.SelLength <> Len(txtTextBox)) _
                Or (KeyAscii = 46 And (InStr(1, txtTextBox, Chr$(46)) Or txtTextBox.SelLength = Len(txtTextBox))) Then KeyAscii = 0

        ' Allow all numbers and symbols (no alpha)
        Case udtTextType.Numeric_WithSymbols
            If (KeyAscii >= 65 And KeyAscii <= 90) Or (KeyAscii >= 97 And KeyAscii <= 122) Then KeyAscii = 0
        
        ' Undefined cases
        Case Else
            KeyAscii = 0
    End Select
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_KeyUp
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' *****************************************************************************************************************
Private Sub txtTextBox_KeyUp(KeyCode As Integer, Shift As Integer)
    RaiseEvent KeyUp(KeyCode, Shift)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_LostFocus
' Purpose: Performs various operations when textbox loses the focus
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/11/01)
' ******************************************************************************************************************
Private Sub txtTextBox_LostFocus()
    txtTextBox.BackColor = mBackColor_Normal
    
    ' Reset flag
    mblnSelectWhenClicked = True
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_MouseDown
' Purpose: Raise associated control event and set flag
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/17/01)
' ******************************************************************************************************************
Private Sub txtTextBox_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, X, Y)
    mblnMouseDown = True
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_MouseMove
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseMove(Button, Shift, X, Y)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_MouseUp
' Purpose: Raise associated control event and reset flag
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/17/01)
' ******************************************************************************************************************
Private Sub txtTextBox_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, X, Y)
    mblnMouseDown = False
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLECompleteDrag
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLECompleteDrag(Effect As Long)
    RaiseEvent OLECompleteDrag(Effect)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLEDragDrop
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent OLEDragDrop(Data, Effect, Button, Shift, X, Y)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLEDragOver
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    RaiseEvent OLEDragOver(Data, Effect, Button, Shift, X, Y, State)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLEGiveFeedback
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLEGiveFeedback(Effect As Long, DefaultCursors As Boolean)
    RaiseEvent OLEGiveFeedback(Effect, DefaultCursors)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLESetData
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLESetData(Data As DataObject, DataFormat As Integer)
    RaiseEvent OLESetData(Data, DataFormat)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.txtTextBox_OLEStartDrag
' Purpose: Raise associated control event
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub txtTextBox_OLEStartDrag(Data As DataObject, AllowedEffects As Long)
    RaiseEvent OLEStartDrag(Data, AllowedEffects)
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.UserControl_InitProperties
' Purpose: Setup of the initial control properties
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Private Sub UserControl_InitProperties()
    ' Set defaults for custom properties
    mblnAutoSelect = True
    mblnAutoUpperCase = False
    mBackColor_OnGotFocus = vbCyan
    mBackColor_Normal = vbWhite
    mstrDefaultText = ""
    mblnUseDefaultText = True
    mlngMaxEntryTime = 400
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.UserControl_ReadProperties
' Purpose: Reads the control properties from the "property bag" (remembers properties)
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    ' Customized properties
    mblnAutoSelect = PropBag.ReadProperty("AutoSelect", True)
    mblnAutoUpperCase = PropBag.ReadProperty("AutoUpperCase", False)
    mBackColor_OnGotFocus = PropBag.ReadProperty("BackColor_OnGotFocus", vbCyan)
    mBackColor_Normal = PropBag.ReadProperty("BackColor_OnlostFocus", vbWhite)
    mstrDefaultText = PropBag.ReadProperty("DefaultText", "")
    mlngMaxEntryTime = PropBag.ReadProperty("MaxEntryTime", 400)
    mblnEntryTimerEnabled = PropBag.ReadProperty("EntryTimerEnabled", False)
    mblnUseDefaultText = PropBag.ReadProperty("UseDefaultText", True)
    mintTextType = PropBag.ReadProperty("TextType", udtTextType.AlphaNumeric)
    
    ' Standard "textbox" properties
    With txtTextBox
        .Alignment = PropBag.ReadProperty("Alignment", udtAlignment.Left_Justify)
        .Appearance = PropBag.ReadProperty("Appearance", udtAppearance.Appear_3D)
        .BorderStyle = PropBag.ReadProperty("BorderStyle", udtBorderStyle.Fixed_Single)
        .CausesValidation = PropBag.ReadProperty("CausesValidation", True)
        .DataField = PropBag.ReadProperty("DataField", "")
        .Enabled = PropBag.ReadProperty("Enabled", True)
        .FontBold = PropBag.ReadProperty("FontBold", False)
        .FontItalic = PropBag.ReadProperty("FontItalic", False)
        .FontName = PropBag.ReadProperty("FontName", "MS Sans Serif")
        .FontSize = PropBag.ReadProperty("FontSize", 8)
        .FontStrikethru = PropBag.ReadProperty("FontStrikethru", False)
        .FontUnderline = PropBag.ReadProperty("FontUnderline", False)
        .ForeColor = PropBag.ReadProperty("ForeColor", vbBlack)
        .Left = PropBag.ReadProperty("Left", 0)
        .Locked = PropBag.ReadProperty("Locked", False)
        .MaxLength = PropBag.ReadProperty("MaxLength", 0)
        .MousePointer = PropBag.ReadProperty("MousePointer", udtMousePointer.Default)
        .OLEDragMode = PropBag.ReadProperty("OLEDragMode", False)
        .OLEDropMode = PropBag.ReadProperty("OLEDropMode", False)
        .PasswordChar = PropBag.ReadProperty("PasswordChar", "")
        .RightToLeft = PropBag.ReadProperty("RightToLeft", False)
        .Text = PropBag.ReadProperty("Text", "")
    End With
    
    ' Use default text if flag is set
    If mblnUseDefaultText Then txtTextBox.Text = mstrDefaultText
End Sub

' ******************************************************************************************************************
' Event: CustomizedTextBox.UserControl_Resize
' Purpose: To make sure the textbox is the same size as its container when container is resized
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 10/17/00)
' ******************************************************************************************************************
Private Sub UserControl_Resize()
    txtTextBox.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

' ******************************************************************************************************************
' Event: cTextBox.UserControl_WriteProperties
' Purpose: Writes the control properties to the "property bag" (remembers properties)
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: October 17, 2000 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    ' Customized properties
    Call PropBag.WriteProperty("AutoSelect", mblnAutoSelect, True)
    Call PropBag.WriteProperty("AutoUpperCase", mblnAutoUpperCase, False)
    Call PropBag.WriteProperty("BackColor_OnGotFocus", mBackColor_OnGotFocus, vbCyan)
    Call PropBag.WriteProperty("BackColor_OnLostFocus", mBackColor_Normal, vbWhite)
    Call PropBag.WriteProperty("DefaultText", mstrDefaultText, "")
    Call PropBag.WriteProperty("MaxEntryTime", mlngMaxEntryTime, 400)
    Call PropBag.WriteProperty("EntryTimerEnabled", mblnEntryTimerEnabled, False)
    Call PropBag.WriteProperty("TextType", mintTextType, udtTextType.AlphaNumeric)
    Call PropBag.WriteProperty("UseDefaultText", mblnUseDefaultText, True)
    
    ' Standard "textbox" properties
    With txtTextBox
        Call PropBag.WriteProperty("Alignment", .Alignment, udtAlignment.Left_Justify)
        Call PropBag.WriteProperty("Appearance", .Appearance, udtAppearance.Appear_3D)
        Call PropBag.WriteProperty("BorderStyle", .BorderStyle, udtBorderStyle.Fixed_Single)
        Call PropBag.WriteProperty("CausesValidation", .CausesValidation, True)
        Call PropBag.WriteProperty("DataField", .DataField, "")
        Call PropBag.WriteProperty("Enabled", .Enabled, True)
        Call PropBag.WriteProperty("FontBold", .FontBold, False)
        Call PropBag.WriteProperty("FontItalic", .FontItalic, False)
        Call PropBag.WriteProperty("FontName", .FontName, "MS Sans Serif")
        Call PropBag.WriteProperty("FontSize", .FontSize, 8)
        Call PropBag.WriteProperty("FontStrikethru", .FontStrikethru, False)
        Call PropBag.WriteProperty("FontUnderline", .FontUnderline, False)
        Call PropBag.WriteProperty("ForeColor", .ForeColor, vbBlack)
        If IsArray(txtTextBox) Then Call PropBag.WriteProperty("Index", .Index)
        Call PropBag.WriteProperty("Left", .Left, 0)
        Call PropBag.WriteProperty("Locked", .Locked, False)
        Call PropBag.WriteProperty("MaxLength", .MaxLength, 0)
        Call PropBag.WriteProperty("MousePointer", .MousePointer, udtMousePointer.Default)
        Call PropBag.WriteProperty("MultiLine", .MultiLine, False)
        Call PropBag.WriteProperty("OLEDragMode", .OLEDragMode, udtOLEDragMode.Manual)
        Call PropBag.WriteProperty("OLEDropMode", .OLEDropMode, udtOLEDropMode.None)
        Call PropBag.WriteProperty("PasswordChar", .PasswordChar, "")
        Call PropBag.WriteProperty("RightToLeft", .RightToLeft, False)
        Call PropBag.WriteProperty("Text", .Text, "")
    End With
End Sub


' ******************************************************************************************************************
' IMPLEMENTATION OF PUBLIC CLASS PROCEDURES
' ******************************************************************************************************************
' ******************************************************************************************************************
' Procedure: CustomizedTextBox.ResetEntryTimer
' Purpose: Reset entry timer
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: January 22, 2001 (Last Updated: 01/22/01)
' ******************************************************************************************************************
Public Sub ResetEntryTimer()
    mblnEntryTimedOut = False
    mlngEntryStartTime = 0
End Sub

' ******************************************************************************************************************
' Procedure: CustomizedTextBox.SelectText
' Purpose: Provides method of selecting all text in textbox on demand
' Author: Jesse Davis (Copyright, Westinghouse Electric Company, 2000)
' Date: January 9, 2001 (Last Updated: 01/11/01)
' ******************************************************************************************************************
Public Sub SelectText()
    ' Select the text
    With txtTextBox
        .SelStart = 0
        .SelLength = Len(.Text)
    End With
    
    ' Reset flag so that next mouse click doesn't select the text (since already selected)
    ' Note: This flag will be set to true again if the textbox loses focus
    mblnSelectWhenClicked = False
End Sub

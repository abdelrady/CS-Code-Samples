VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CAutoCompleteComboBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' Private class constants
Private Const CB_FINDSTRING = &H14C
Private Const CB_FINDSTRINGEXACT = &H158
Private Const CB_ERR = (-1)

' Private class API function declarations
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long

Private WithEvents m_oComboBox  As ComboBox
Attribute m_oComboBox.VB_VarHelpID = -1
Private m_bKeyOk                As Boolean

Public Sub Init(ComboBox As ComboBox)
    Set m_oComboBox = ComboBox
End Sub

Private Sub Class_Initialize()
    Set m_oComboBox = Nothing
End Sub

Private Sub Class_Terminate()
    Set m_oComboBox = Nothing
End Sub

Private Sub m_oComboBox_Change()
    Dim iRet        As Long
    Dim sPartial    As String
        
    If m_bKeyOk Then
        With m_oComboBox
            sPartial = .Text
            
            If Len(sPartial) > 0 Then
                iRet = SendMessage(.hwnd, CB_FINDSTRING, -1, ByVal sPartial)
                
                If iRet <> CB_ERR Then
                    Dim iPos%
                    iPos = Len(.Text)
                    .ListIndex = iRet
                    .Text = Left$(.Text, iPos) & Mid$(.list(iRet), iPos + 1)
                    .SelStart = iPos
                    .SelLength = 65535
                End If
            End If
        End With
    End If
End Sub

Private Sub m_oComboBox_KeyDown(KeyCode As Integer, Shift As Integer)
    m_bKeyOk = (KeyCode <> vbKeyBack) And (KeyCode <> vbKeyDelete)
End Sub

VERSION 5.00
Begin VB.UserControl BarCode 
   ClientHeight    =   1980
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   7425
   PropertyPages   =   "BarCode.ctx":0000
   ScaleHeight     =   1980
   ScaleWidth      =   7425
   Begin VB.PictureBox pctBar 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   1815
      Left            =   120
      ScaleHeight     =   121
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   481
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   120
      Width           =   7215
   End
End
Attribute VB_Name = "BarCode"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "PropPageWizardRun" ,"Yes"
Option Explicit

Dim m_CodeName(4) As String
Dim m_Value As String
Dim m_CodeNameIndex As String

Enum BarCodeFonts
    Code39
    Code128
    Code2by5
    Codabar
End Enum

Public Property Get CodeName() As BarCodeFonts
    CodeName = m_CodeNameIndex
End Property

Public Property Let CodeName(str As BarCodeFonts)
    m_CodeNameIndex = str
    PropertyChanged ("CodeName")
    
    Call DrawBarCode
End Property

Public Property Get Value() As String
Attribute Value.VB_ProcData.VB_Invoke_Property = "Customize"
    Value = m_Value
End Property

Public Property Let Value(str As String)
    m_Value = str
    PropertyChanged ("Value")
    Call DrawBarCode
End Property

Public Sub PrintPicture()
    Barcode m_CodeName(m_CodeNameIndex), m_Value, Printer, 15, 1500, 1000, 500
    
    Printer.EndDoc
End Sub

Public Sub save(FileName As String)
    SavePicture pctBar.Image, FileName
End Sub

Public Sub Copy()
    Clipboard.SetData pctBar.Image
End Sub

Private Sub UserControl_Initialize()
    m_CodeNameIndex = 0
    m_Value = "15236325"
    
    m_CodeName(0) = "39"
    m_CodeName(1) = "128"
    m_CodeName(2) = "2/5"
    m_CodeName(3) = "Codabar"
    
    Call DrawBarCode
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    m_CodeNameIndex = PropBag.ReadProperty("CodeName", "39")
    m_Value = PropBag.ReadProperty("Value", "15236325")
End Sub

Private Sub UserControl_Resize()
    If UserControl.Width < 7425 Then
        UserControl.Width = 7425
    End If
    
    If UserControl.Height < 1980 Then
        UserControl.Height = 1980
    End If
    
    pctBar.Width = UserControl.Width
    pctBar.Height = UserControl.Height
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
    PropBag.WriteProperty "CodeName", m_CodeNameIndex
    PropBag.WriteProperty "Value", m_Value
End Sub

Private Sub DrawBarCode()
    pctBar.Cls
    Barcode m_CodeName(m_CodeNameIndex), m_Value, pctBar, 2, 60, 20, 20
End Sub

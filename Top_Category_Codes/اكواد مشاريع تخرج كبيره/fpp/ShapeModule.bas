Attribute VB_Name = "ShapeModule"
' ===========================================
'  === Project of Visual Logic Language ===
' ===========================================
' Authors:
'           Yuri Margolin
'           Asaf Shoshani
' ORT Academic College
' July 2001
' ===========================================
'  Declaration module for Active-X
' ===========================================

Option Explicit

' declaration of function to draw complex figures:
Public Declare Function Polygon Lib "gdi32" (ByVal hdc As Long, lpPoint As POINTAPI, ByVal nCount As Long) As Long
' type used by Polygon API function:
Public Type POINTAPI
        x As Long
        y As Long
End Type

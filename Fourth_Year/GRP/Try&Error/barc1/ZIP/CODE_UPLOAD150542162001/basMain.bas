Attribute VB_Name = "basMain"
' DISCLAIMER (for public posting):
' This software is provided on an "as is, where is" basis, with no warranty whatsoever.
' As a condition of your using this software, you agree that Westinghouse Electric Company
' shall not be liable with respect to or as a result of such use.  Further, you agree to
' indemnify and hold Westinghouse harmless in the event a claim is made against
' Westinghouse with respect to or as a result of your use of the software.


' ******************************************************************************************************************
' DECLARATION OF PUBLIC CONSTANTS
' ******************************************************************************************************************
Global Const VK_TAB = 9


' ******************************************************************************************************************
' DECLARATION OF PUBLIC API FUNCTIONS
' ******************************************************************************************************************
' For detecting if a tab or mouse click caused a control to receive focus
' (from MSKB article: http://support.microsoft.com/support/kb/articles/Q75/4/11.ASP)
Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

' For getting the time in ticks (milliseconds) from a certain starting point
Public Declare Function GetTickCount Lib "kernel32" () As Long

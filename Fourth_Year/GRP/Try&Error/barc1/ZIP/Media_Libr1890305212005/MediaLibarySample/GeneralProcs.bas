Attribute VB_Name = "GeneralProcs"
'---------------------------------------------------------------------------------------
' Module    : GeneralProcs
' DateTime  : 04/05/2005 08:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' BUG FIX   :
' Version   : 1.1
' Details   : added WildStringMatch function but not used as yet
'
'
' Other changes:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'
' Purpose:
'        This is a beta media library sample using the BSTN class as it's database engine.
'        Other p-s-c visitors offered their help in testing the beta sample, checking the adds, removes,
'        ordered lists etc. and it's overall general usage.
'        The sample maintains details of media such as CDs, DVDs, Audio Tapes, VHS Videos etc.
'
'---------------------------------------------------------------------------------------

' Project   : Media Library
' DateTime  : 28/04/2005 20:37
' Author    : D K Richmond
' Status    : BETA RELEASE 1.1
' Version   : Visual Basic 6 (SP6)
' User Type : Beginner/Intermediate/Advanced
' Applicable: Database/Data Sorting/Key Retrieval/Binary Trees/Node Traversals
'
' Credits :    Chan Wilson - for all extra beta testing
' ---------
'
' Disclaimer:
' -----------
' This software is provided as-is, no liability accepted in using
' this code or part of this code where information is used and relied upon in any
' other system or systems, projects, modules etc.
' In other words, it is provided for educational value and where experimenting
' in writing applications needing fast ordered key retrieval for testing and
' running experimental non-critical non-business applications.
'
' Copyright:
' -----------
' This was written by myself based on information from various Data Abstraction
' and storage techniques.  Some of the deletion routines are based on information (only information not code)
' from various pages on the internet (non-copyright).
' There are some excellent articles on the internet, try google.com .. searching for "Binary Trees"
'
' ALL OF THIS CODE IN THIS CLASS WAS WRITTEN FROM A BLANK WORKSHEET.  IN OTHER WORDS NONE OF THIS CODE
' WAS STRIPPED, EXTRACTED OR COPIED FROM OTHER PEOPLES WORK.  PLEASE RESPECT THAT AND
' IF YOU USE THIS CODE IN ANY OF YOUR APPLICATIONS/EXAMPLES PLEASE GIVE CREDIT FOR MY WORK.
'
' DAVID K RICHMOND dk.richmond@ntlworld.com
'
' GUIDELINES:
' -----------
'
' OVERVIEW:
' -----------
'
' DEBUGGING:
' ---------
' In BSTN Class Initialise :  gbDebug = False   '  change this to true to see lots of debug message boxes
'
' SURPRISES:
'  I have left some msgbox's and some redundant error trapping in some routines, this will be taken out real soon.
'  The are some extra definitions that I have left for the future.

' FUTURE:
' -------
' There is a lot of scope to improve this code.
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
'
' ##########################################################################################################

Option Explicit

' #### general functions/procedures ###

Global bgRefreshView As Boolean
Global Const igcColumnSizing = 1700

'---------------------------------------------------------------------------------------
' Procedure : RemoveQuotes
' DateTime  : 05/05/2005 19:58
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function RemoveQuotes(ByVal spText As String) As String

    If Left(spText, 1) = Chr(34) Then
        spText = Mid(spText, 2)
    End If
    If Right(spText, 1) = Chr(34) Then
        spText = Left(spText, Len(spText) - 1)
    End If
    RemoveQuotes = spText
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : GetLastPart
' DateTime  : 06/05/2005 16:58
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetLastPart(ByVal spLine As String, ByVal spToken As String) As String
 Dim iPos As Integer
 
     iPos = InStrRev(spLine, spToken)
     If (iPos > 0) Then
        GetLastPart = Mid(spLine, iPos + 1)
    Else
        GetLastPart = spLine
    End If

End Function

'---------------------------------------------------------------------------------------
' Procedure : RemoveLastPart
' DateTime  : 06/05/2005 16:58
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function RemoveLastPart(ByVal spLine As String, ByVal spToken As String) As String
 Dim iPos As Integer
 
     iPos = InStrRev(spLine, spToken)
     If (iPos > 0) Then
        RemoveLastPart = Left(spLine, iPos - 1)
    Else
        RemoveLastPart = spLine
    End If

End Function

'---------------------------------------------------------------------------------------
' Procedure : WildStringMatch
' DateTime  : 07/05/2005 14:45
' Author    : D K Richmond
' Purpose   : wild pattern matching using '*'s
' e.g
' spMaskPattern = "*.txt*"
'---------------------------------------------------------------------------------------
'
Public Function WildStringMatch(ByVal spTextLine As String, ByVal spMaskPattern As String, ByVal bpIgnoreCase As Boolean)

' Version 1.0 beta (WildCardPatterns)

 Dim saLineParts() As String
 Dim iaLineParts() As Integer
 Dim iParts As Integer
 Dim iIndex As Integer
 Dim sMatchPart As String
 Dim iPos As Integer
 Dim iFrom As Integer
 Dim bMatched As Boolean
 Dim bZeroFound As Boolean
    
    If (bpIgnoreCase = True) Then
        spMaskPattern = UCase(spMaskPattern)
    End If
    If (bpIgnoreCase = True) Then
        spTextLine = UCase(spTextLine)
    End If
                
    If InStr(1, spMaskPattern, "*") > 0 Then
        saLineParts = Split("" & spMaskPattern & "", "*")
        iParts = UBound(saLineParts)
        If (iParts >= 1) Then
                'compare parts
                ReDim iaLineParts(iParts)
                iPos = 1
                For iIndex = 0 To iParts
                    iaLineParts(iIndex) = iPos
                   If (bpIgnoreCase = True) Then
                        saLineParts(iIndex) = UCase(saLineParts(iIndex))    ' used later for checking *s
                    End If
                    sMatchPart = saLineParts(iIndex)
                    'Debug.Print iIndex & "  =  [ " & sMatchPart & "]"
                    iFrom = iPos
                    If (sMatchPart <> "") Then
                        If (iFrom = 0) Then iFrom = 1
                        iPos = InStr(iFrom, spTextLine, sMatchPart)
                        iaLineParts(iIndex) = iPos
                    End If
                Next
                
                ' check the results for a good match
                bMatched = True
                bZeroFound = False
                For iIndex = 1 To iParts
                    If (iaLineParts(iIndex) > 0) And (iaLineParts(iIndex - 1) > 0) Then
                        If (iaLineParts(iIndex) <= iaLineParts(iIndex - 1)) Then
                            bMatched = False
                            Exit For
                        End If
                    Else
                            bMatched = False
                            bZeroFound = True
                            Exit For
                    End If
                Next
                If (saLineParts(iParts) <> "") And (bMatched = False) Then  ' means last char was asterisk
                    bMatched = True
                    ' what if *.tx  used and looks at xxxxxx.txt
                    If (iaLineParts(iParts) + Len(saLineParts(iParts))) <= Len(spTextLine) Then
                        bMatched = False
                    End If
                End If
                If (saLineParts(iParts) <> "") And (bMatched = True) Then  ' means last char was asterisk
                    ' what if *s  used and looks and finds costs.txt
                    If Right(spTextLine, Len(saLineParts(iParts))) <> saLineParts(iParts) Then
                        bMatched = False
                    End If
                End If
                
                If (saLineParts(iParts) = "") And (bZeroFound = False) Then  ' means last char was asterisk
                    ' what if  cost* used and looks at costs.txt?
                    bMatched = True
                End If
        End If
    Else
        bMatched = CBool(spMaskPattern = spTextLine)
    End If

WildStringMatch = bMatched
End Function


Public Sub UseDiskBasedFile_On()

    clsgBSTStore.ActivateDiskFile App.Path & "\DATA\medialibrary.xxx"
    
End Sub

Public Sub UseDiskBasedFile_Off()

    clsgBSTStore.DeActivateDiskFile
    
End Sub

'eom

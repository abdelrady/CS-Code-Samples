Attribute VB_Name = "MediaLibarySample"
'---------------------------------------------------------------------------------------
' Module    : MediaLibarySample
' DateTime  : 29/04/2005 09:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' BUG FIX   :
' Version   :
' Details   :
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
' Status    : BETA RELEASE 1.0
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

' ### globals declarations ##
 Global Const sgcLibraryFileName = "MediaLibrary.dat"
 Global sgLibraryFileName As String
 Global sgLibraryFilePathName As String
'
' global check for records added, update etc to prompt save library
 Global bgDirtyFlag As Boolean
' global key field identifier - default is 0
 Global igKeyFieldNumber As Integer
' mulit-dimensional array params
 Global igKeyFields As Integer
' how record fields are divided
 Global sgFieldDelimiter As String

' BSTN class storage global
 Global clsgBSTStore As cBSTNStorage

' ### globals declarations ##

Global Const sgcDefaultCoverPictureFileName = "NoMediaCover.JPG"

'---------------------------------------------------------------------------------------
' Procedure : InitialiseLibrary
' DateTime  : 29/04/2005 09:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function InitialiseLibrary(Optional ByVal ipoKeyFieldNumber As Variant)

   On Error GoTo InitialiseLibrary_Error

    Set clsgBSTStore = Nothing
     
    If Not IsMissing(ipoKeyFieldNumber) Then
        igKeyFieldNumber = ipoKeyFieldNumber
    Else
        igKeyFieldNumber = 0
    End If
    
    Set clsgBSTStore = New cBSTNStorage
    
    ' virtualise
    'Erase clsgBSTStore.vaLibraryRecords()
    clsgBSTStore.CreateLibrarySize (-1)
    'Erase vgaLibraryMemoryRecords()
    
    'lgLibraryRecord = -1
    bgDirtyFlag = False

   On Error GoTo 0
   Exit Function

InitialiseLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure InitialiseLibrary of Module MediaLibarySample"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : NewLibrary
' DateTime  : 29/04/2005 09:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function NewLibrary() As Boolean

    Set clsgBSTStore = Nothing
    Call InitialiseLibrary
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : LoadLibrary
' DateTime  : 29/04/2005 09:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function LoadLibrary(Optional ByRef lblpoLoadingStatus As Variant, Optional ByVal bpoGarbageCollect As Boolean, Optional ByVal spoLibraryFilePathName As Variant) As Boolean
 Dim sLibraryFilePathName As String
 Dim iInChan As Integer
 Dim iRecordFields As Integer
 Dim iMaxKeyFields As Integer
 Dim iKeyField As Integer
' Dim vaLibraryRecord() As Variant
 Dim sLibRecordLine As String
 Dim bOk As Boolean
 Dim sKeyValue As String
 Dim saLibraryRecord() As String
 Dim lNodeIndex As Long
 Dim lLibraryRecord As Long
 Dim bGarbageCollect As Boolean
 Dim bProcessRecord As Boolean
 
    LoadLibrary = False
    
   On Error GoTo LoadLibrary_Error
    
    If (Not IsMissing(spoLibraryFilePathName)) Then
        sLibraryFilePathName = spoLibraryFilePathName
    Else
        sLibraryFilePathName = sgLibraryFilePathName
    End If
    
    iMaxKeyFields = -1
    lLibraryRecord = 0
    iInChan = FreeFile()
    Debug.Print sLibraryFilePathName
    ' pre-scan library before read all the records
    Open sLibraryFilePathName For Input As #iInChan
    While Not EOF(iInChan)
        Line Input #iInChan, sLibRecordLine
        Debug.Print sLibRecordLine
        saLibraryRecord() = Split(sLibRecordLine, sgFieldDelimiter)
        iRecordFields = UBound(saLibraryRecord())
         ' update global to track multi-dimensional array largest field
        If (iRecordFields > iMaxKeyFields) Then
            iMaxKeyFields = iRecordFields
        End If
        lLibraryRecord = lLibraryRecord + 1
        If Not IsMissing(lblpoLoadingStatus) Then
            lblpoLoadingStatus.Caption = "Scanning Media Record .." & lLibraryRecord
            lblpoLoadingStatus.Refresh
        End If
    Wend
    Close #iInChan
    
    'virtualise
    'ReDim clsgBSTStore.vaLibraryRecords(lgLibraryRecord, igKeyFields)
    bOk = clsgBSTStore.CreateLibrarySize(lLibraryRecord, iMaxKeyFields)
    'ReDim vgaLibraryMemoryRecords(lgLibraryRecord, igKeyFields)
    clsgBSTStore.KeyField = 0  ' set key field number for key extraction
        
    If Not IsMissing(bpoGarbageCollect) Then
        bGarbageCollect = bpoGarbageCollect
    Else
        bGarbageCollect = False
    End If
    
    lLibraryRecord = 0
    iInChan = FreeFile()
    ' read all the records
    Open sLibraryFilePathName For Input As #iInChan
    While Not EOF(iInChan)
    
        Line Input #iInChan, sLibRecordLine
        
        bProcessRecord = True
        
        If (bpoGarbageCollect = True) Then
            If Left(sLibRecordLine, 1) = clsgBSTStore.DataRemovalCharacter Then
                bProcessRecord = False
            End If
            If Left(sLibRecordLine, Len(clsgBSTStore.GarbageIdentityKey)) = clsgBSTStore.GarbageIdentityKey Then
                bProcessRecord = False
            End If
            ' allow for ||||| lines therefore null key invalid
            If Left(sLibRecordLine, 1) = "|" Then
                bProcessRecord = False
            End If
            
        End If
        
        If (bProcessRecord = True) Then
            saLibraryRecord = Split(sLibRecordLine, sgFieldDelimiter)
            iRecordFields = UBound(saLibraryRecord())
            For iKeyField = 0 To iRecordFields
                If iKeyField <= iMaxKeyFields Then
                    clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyField) = RemoveQuotes(saLibraryRecord(iKeyField))
                Else
                    clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyField) = ""
                End If
            Next
            sKeyValue = clsgBSTStore.vaLibraryRecord(lLibraryRecord, clsgBSTStore.KeyField)
            If lLibraryRecord = 0 Then
                bOk = clsgBSTStore.InitRootNode(sKeyValue)
                lNodeIndex = 0  ' used to set data index value
                bOk = True  ' need to sort out InitRootNode return value
            Else
                bOk = clsgBSTStore.InsertBSTN(sKeyValue, lNodeIndex)
            End If
            If bOk = True Then
                ' set the data index value of the node we inserted to the index of the data array to use to get data from key finds
                bOk = clsgBSTStore.SetDataNodeIndex(lNodeIndex, lLibraryRecord)
            Else
                MsgBox "Failed to insert key " & sKeyValue, vbCritical
                Err.Raise 94095405, 94059405, "", ""
                Exit Function
            End If
            If bOk = False Then
                MsgBox "Error Load Library failed setting key/index for value: " & sKeyValue, vbCritical
                Exit Function
            End If
            lLibraryRecord = lLibraryRecord + 1
            If Not IsMissing(lblpoLoadingStatus) Then
                lblpoLoadingStatus.Caption = "Loading Media Record .. " & lLibraryRecord
                lblpoLoadingStatus.Refresh
            End If
        End If
        
        DoEvents
        
    Wend
    Close #iInChan
    
    If Not IsMissing(lblpoLoadingStatus) Then
        ' final status
        lblpoLoadingStatus.Caption = "Loaded (" & lLibraryRecord & ") Records." & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        lblpoLoadingStatus.Refresh
    End If
    
    LoadLibrary = True
     
   On Error GoTo 0
   Exit Function

LoadLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure LoadLibrary of Module MediaLibarySample"
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : SaveLibrary
' DateTime  : 29/04/2005 09:18
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function SaveLibrary(ByRef lblpoLoadingStatus As Variant) As Boolean
 Dim iOutChan As Integer
 Dim lLibraryRecord As Long
 Dim lLibraryRecords As Long
 Dim iRecordField As Integer
 Dim iRecordFields As Integer
 Dim iKeyFieldNumber As Integer
 Dim sFieldDelimiter As String
 
    SaveLibrary = False
 
   On Error GoTo SaveLibrary_Error

    lLibraryRecords = clsgBSTStore.LibraryRecords '- 1 DKR:DKR:DKR
    iRecordFields = clsgBSTStore.RecordFields
    iKeyFieldNumber = clsgBSTStore.KeyField
    
    iOutChan = FreeFile()
    Open sgLibraryFilePathName For Output As #iOutChan
    For lLibraryRecord = 0 To lLibraryRecords
        If (clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyFieldNumber) <> "") Then
            sFieldDelimiter = sgFieldDelimiter
            For iRecordField = 0 To iRecordFields
                ' dont keep putting extra field delimiter on records each save record line
                If iRecordField = iRecordFields Then
                    sFieldDelimiter = ""
                End If
                Print #iOutChan, clsgBSTStore.vaLibraryRecord(lLibraryRecord, iRecordField) & sFieldDelimiter;
            Next
            Print #iOutChan, ""  ' crlf
            If Not IsMissing(lblpoLoadingStatus) Then
                lblpoLoadingStatus.Caption = "Saving Record .. " & lLibraryRecord
                lblpoLoadingStatus.Refresh
            End If
        Else
            Debug.Print "not saving blank record @ " & lLibraryRecord
        End If
    Next
    Close #iOutChan
    
    If Not IsMissing(lblpoLoadingStatus) Then
        ' final status
        lblpoLoadingStatus.Caption = "Saved (" & lLibraryRecord & ") Records." & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        lblpoLoadingStatus.Refresh
    End If
    SaveLibrary = True
    ' don't forget to reset any dirty flags!
   On Error GoTo 0
   Exit Function

SaveLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure SaveLibrary of Module MediaLibarySample"

End Function

'---------------------------------------------------------------------------------------
' Procedure : SaveLibrary
' DateTime  : 29/04/2005 09:18
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function BuildDiskFileFromLibrary(Optional ByRef lblpoLoadingStatus As Variant) As Boolean
 ' channels
 Dim iOutDataChan As Integer
 Dim iOutNodeChan As Integer
 Dim iOutKeysChan As Integer
 Dim iOutDataOfsChan As Integer
 '
 Dim lLibraryRecord As Long
 Dim lLibraryRecords As Long
 Dim iRecordField As Integer
 Dim iRecordFields As Integer
 Dim iKeyFieldNumber As Integer
 Dim sFieldDelimiter As String
' library builds
 Dim sLibraryFileName As String
 Dim sKeysFilePathName As String
 Dim sDataFilePathName As String
 Dim sNodeFilePathName As String
 Dim sDataOffsetFilePathName As String
 ' node values
 Dim lParentNode As Long
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lDataIndex As Long
 ' data offset
 Dim dDataOffset As Double
 Dim dKeyOffset As Double
 Dim sKeyValue As String
 Dim sParentNode As String
 Dim sLeftNode As String
 Dim sRightNode As String
 Dim sDataIndex As String
 Dim sDataOffset As String
 Dim sKeyOffset As String
 Dim lNodeIndex As Long
 Dim sNodeDelimiter As String
 Dim bOk As Boolean
 Dim dDataOffsetSeek As Double
 Dim lProcessedRecordsCount As Long
 
   On Error GoTo BuildDiskFileFromLibrary_Error

    BuildDiskFileFromLibrary = False
 
    lLibraryRecords = clsgBSTStore.LibraryRecords - 1
    iRecordFields = clsgBSTStore.RecordFields
    iKeyFieldNumber = clsgBSTStore.KeyField
    
    ' set build file names
    sLibraryFileName = RemoveLastPart(GetLastPart(sgLibraryFilePathName, "\"), ".")
    sKeysFilePathName = App.Path & "\DATA\" & clsgBSTStore.MakeKeysFileName(sLibraryFileName)
    sDataFilePathName = App.Path & "\DATA\" & clsgBSTStore.MakeDataFileName(sLibraryFileName)
    sNodeFilePathName = App.Path & "\DATA\" & clsgBSTStore.MakeNodeFileName(sLibraryFileName)
    sDataOffsetFilePathName = App.Path & "\DATA\" & clsgBSTStore.MakeDataOffsetFileName(sLibraryFileName)
    sNodeDelimiter = clsgBSTStore.NodeDelimiter

    iOutNodeChan = FreeFile()
    Close #iOutNodeChan: Open sNodeFilePathName For Output As #iOutNodeChan
    Print #iOutNodeChan, "0o0o0p0o0o|0o0o0l0o0o|0o0o0r0o0o|0o0o0i0o0o|0o0o0k0o0o"
    
    iOutKeysChan = FreeFile()
    Close #iOutKeysChan: Open sKeysFilePathName For Output As #iOutKeysChan
    ' base 0 so add 1 and header
    Print #iOutKeysChan, NodePlusMinusFormat(lLibraryRecords) & "|" & NodePlusMinusFormat(iRecordFields) & "|" & NodePlusMinusFormat(iKeyFieldNumber) & "  --- KEYS HEADER----"
    
    iOutDataChan = FreeFile()
    Close #iOutDataChan: Open sDataFilePathName For Output As #iOutDataChan
    
    iOutDataOfsChan = FreeFile()
    Close #iOutDataOfsChan: Open sDataOffsetFilePathName For Output As #iOutDataOfsChan
    
    lProcessedRecordsCount = 0
    For lLibraryRecord = 0 To lLibraryRecords
        If Not IsEmpty(clsgBSTStore.vaLibraryRecord(lLibraryRecord, 0)) Or (clsgBSTStore.vaLibraryRecord(lLibraryRecord, 0) <> "") Then
            Print #iOutDataOfsChan, NodePlusMinusFormat(0)
        Else
            'MsgBox "dataoffset create: skipping empty record or null key @ record : " & lLibraryRecord, vbInformation
        End If
    Next
    Close #iOutDataOfsChan: Open sDataOffsetFilePathName For Binary As #iOutDataOfsChan
    
    For lLibraryRecord = 0 To lLibraryRecords
        If Not IsEmpty(clsgBSTStore.vaLibraryRecord(lLibraryRecord, 0)) Or (clsgBSTStore.vaLibraryRecord(lLibraryRecord, 0) <> "") Then

            sKeyValue = clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyFieldNumber)
            If (sKeyValue <> "") Then
                    
                bOk = clsgBSTStore.SearchBSTN(sKeyValue, lNodeIndex)
                If bOk = False Then
                    MsgBox "Failed to get key node data for key " & sKeyValue
                    Err.Raise vbObjectError + 934930, "Failed to get key node data for key", "BuildDiskFromLibrary"
                End If
                
                lParentNode = clsgBSTStore.GetParentNodeOfIndex(lNodeIndex)
                lLeftNode = clsgBSTStore.GetLeftNodeOfIndex(lNodeIndex)
                lRightNode = clsgBSTStore.GetRightNodeOfIndex(lNodeIndex)
                lDataIndex = clsgBSTStore.GetDataNodeIndex(lNodeIndex)
                
                sParentNode = NodePlusMinusFormat(lParentNode)
                sLeftNode = NodePlusMinusFormat(lLeftNode)
                sRightNode = NodePlusMinusFormat(lRightNode)
                sDataIndex = NodePlusMinusFormat(lDataIndex)
                
                dKeyOffset = Seek(iOutKeysChan)
                sKeyOffset = NodePlusMinusFormat(dKeyOffset)  ' this isn't big enough mask
                
                Print #iOutKeysChan, sKeyValue
                
                dDataOffset = Seek(iOutDataChan)
                sDataOffset = NodePlusMinusFormat(dDataOffset)  ' this isn't big enough mask
                
                dDataOffsetSeek = lDataIndex * (10 + 2) + 1 ' format string + crlf
                Seek #iOutDataOfsChan, dDataOffsetSeek
                Put #iOutDataOfsChan, , sDataOffset
                
                'Print #iOutNodeChan, sParentNode & sNodeDelimiter & sLeftNode & sNodeDelimiter & sRightNode & sNodeDelimiter & sDataIndex & sNodeDelimiter & sKeyOffset & sNodeDelimiter & sDataOffset
                Print #iOutNodeChan, sParentNode & sNodeDelimiter & sLeftNode & sNodeDelimiter & sRightNode & sNodeDelimiter & sDataIndex & sNodeDelimiter & sKeyOffset
                
                sFieldDelimiter = sgFieldDelimiter
                For iRecordField = 0 To iRecordFields
                    ' dont keep putting extra field delimiter on records each save record line
                    If iRecordField = iRecordFields Then
                        sFieldDelimiter = ""
                    End If
                    Print #iOutDataChan, clsgBSTStore.vaLibraryRecord(lLibraryRecord, iRecordField) & sFieldDelimiter;
                Next
                Print #iOutDataChan, ""  ' crlf
                If Not IsMissing(lblpoLoadingStatus) Then
                    lblpoLoadingStatus.Caption = "Saving Record .. " & lLibraryRecord
                    lblpoLoadingStatus.Refresh
                End If
                lProcessedRecordsCount = lProcessedRecordsCount + 1
            Else
                Debug.Print "not saving blank record @ " & lLibraryRecord
            End If
        Else
            'MsgBox "rebuild : skipping empty record or null key @ record : " & lLibraryRecord, vbInformation
        End If
    Next
    ' close built files
    Close #iOutDataChan
    Close #iOutKeysChan
    Close #iOutNodeChan
    Close #iOutDataOfsChan
    
    Debug.Print "Re-Built Library File " & sLibraryFileName & " (" & lProcessedRecordsCount & ") Records of (" & lLibraryRecords & ") on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        
    If Not IsMissing(lblpoLoadingStatus) Then
        ' final status
        lblpoLoadingStatus.Caption = "Re-Built Library File " & sLibraryFileName & " (" & lProcessedRecordsCount & ") Records of (" & lLibraryRecords & ") on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        lblpoLoadingStatus.Refresh
    End If
    
    ' adjust the records trackers back down excluding garbage
    lLibraryRecords = lProcessedRecordsCount

' update disk file records tracker
Dim iDiskKeyChan As Integer
Dim sLibraryRecords As String

        iDiskKeyChan = FreeFile()
        Close #iDiskKeyChan: Open sKeysFilePathName For Binary As #iDiskKeyChan
        sLibraryRecords = NodePlusMinusFormat(lLibraryRecords)
        Seek #iDiskKeyChan, 1
        Put #iDiskKeyChan, , sLibraryRecords
        Close #iDiskKeyChan
    
    BuildDiskFileFromLibrary = True
    
   On Error GoTo 0
   Exit Function

BuildDiskFileFromLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure BuildDiskFileFromLibrary of Module MediaLibarySample"
    ' close built files
    Close #iOutDataChan
    Close #iOutKeysChan
    Close #iOutNodeChan
    Close #iOutDataOfsChan
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : NodePlusMinusFormat
' DateTime  : 07/05/2005 08:42
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function NodePlusMinusFormat(ByVal vpNumber As Variant) As String

    If vpNumber < 0 Then
        NodePlusMinusFormat = "-" & Format(Abs(vpNumber), "000000000")   ' need central mask not local
            
    Else
        NodePlusMinusFormat = "+" & Format(Abs(vpNumber), "000000000")  ' need central mask not local
    End If
    
End Function


'---------------------------------------------------------------------------------------
' Procedure : FindMedia
' DateTime  : 29/04/2005 10:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function FindMedia(ByVal spKeyValue As String, ByRef lpDataIndex As Long)
 Dim bOk As Boolean
 Dim lFoundNode As Long
 
    lFoundNode = -1
    lpDataIndex = -1
    
    bOk = clsgBSTStore.SearchBSTN(spKeyValue, lFoundNode)

    If bOk = True Then
        lpDataIndex = clsgBSTStore.GetDataNodeIndex(lFoundNode)
    End If

FindMedia = bOk
End Function


'---------------------------------------------------------------------------------------
' Procedure : DeleteMedia
' DateTime  : 03/05/2005 18:39
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function DeleteMedia(ByVal spKeyValue As String, ByRef lpDataIndex As Long)
 Dim bOk As Boolean
 Dim lFoundNode As Long
 
   On Error GoTo DeleteMedia_Error

    lFoundNode = -1
    lpDataIndex = -1
    
    bOk = clsgBSTStore.SearchBSTN(spKeyValue, lFoundNode)

    If bOk = True Then
        lpDataIndex = clsgBSTStore.GetDataNodeIndex(lFoundNode)
        bOk = RemoveMediaDataRecord(lpDataIndex)   ' don't compress the library records or all data indexes are voided
        If bOk = True Then
            bOk = clsgBSTStore.RemoveNode(spKeyValue)
            If bOk = True Then
                MsgBox "Removed key from library store for key : " & spKeyValue, vbInformation
            Else
                MsgBox "Failed to remove key from library store for key : " & spKeyValue, vbCritical
            End If
        Else
            MsgBox "Failed to remove record data @ " & lpDataIndex & " from library store for key : " & spKeyValue, vbCritical
        End If
    End If

DeleteMedia = bOk

   On Error GoTo 0
   Exit Function

DeleteMedia_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure DeleteMedia of Module MediaLibarySample"
End Function


'---------------------------------------------------------------------------------------
' Procedure : UpdateMediaToLibrary
' DateTime  : 05/05/2005 09:16
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function UpdateMediaToLibrary(ByVal spKeyValue As String, spaMediaDataValues() As String, ByRef lblpStatus As Label) As Boolean
' Dim iKeyField As Integer
 Dim iRecordFields As Integer
 Dim iRecordField As Integer
 Dim iMediaFields As Integer
 Dim bOk As Boolean
 Dim lpFoundNode As Long
 Dim lLibraryRecord As Long
     
     UpdateMediaToLibrary = False
      
   On Error GoTo UpdateMediaToLibrary_Error
 
    lblpStatus.Caption = ""
    lblpStatus.Refresh
    
    bOk = clsgBSTStore.SearchBSTN(spKeyValue, lpFoundNode)
    If bOk = False Then
        MsgBox "Error Update Record to Library failed key not found for value: " & spKeyValue, vbCritical
        'Err.Raise vbObjectError + 394035, "", ""
        Exit Function
    End If
    
    lLibraryRecord = clsgBSTStore.GetDataNodeIndex(lpFoundNode)
    iRecordFields = clsgBSTStore.RecordFields
    
    bOk = clsgBSTStore.SetMediaRecordDataValues(lLibraryRecord, spaMediaDataValues())
    
'
'    iMediaFields = UBound(spaMediaDataValues())
'    ' load the passed array with values from the Library record
'
'    For iRecordField = 0 To iRecordFields
'        If iRecordField <= iMediaFields Then
'            clsgBSTStore.vaLibraryRecord(lLibraryRecord, iRecordField) = spaMediaDataValues(iRecordField)
'        Else
'            clsgBSTStore.vaLibraryRecord(lLibraryRecord, iRecordField) = ""
'        End If
'    Next
'
    If bOk = True Then
        ' final status
        lblpStatus.Caption = "Updated (" & lLibraryRecord & ") Media Record Key: " & spKeyValue & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        lblpStatus.Refresh
        UpdateMediaToLibrary = True
    Else
        lblpStatus.Caption = "FAILED: Updated (" & lLibraryRecord & ") Media Record Key: " & spKeyValue & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
        lblpStatus.Refresh
    End If
    
   On Error GoTo 0
   Exit Function

UpdateMediaToLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure UpdateMediaToLibrary of Module MediaLibarySample"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : AddMediaToLibrary
' DateTime  : 29/04/2005 18:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function AddMediaToLibrary(ByVal spKeyValue As String, spaMediaDataValues() As String, ByRef lblpStatus As Label) As Boolean
 Dim iKeyField As Integer
 Dim iRecordFields As Integer
 Dim iMediaFields As Integer
 Dim bOk As Boolean
 Dim lpFoundNode As Long
 Dim lLibraryRecord As Long
 
    AddMediaToLibrary = False
    
   On Error GoTo AddMediaToLibrary_Error
    
    lblpStatus.Caption = ""
    lblpStatus.Refresh
    
    bOk = clsgBSTStore.SearchBSTN(spKeyValue, lpFoundNode)
    If bOk = True Then
        MsgBox "Error Add Record to Library failed duplicate key/index for value: " & spKeyValue, vbCritical
        'Err.Raise vbObjectError + 394035, "", ""
        Exit Function
    End If
    
    bOk = clsgBSTStore.AddMediaDataRecord(lLibraryRecord)
    
    If bOk = False Then
        MsgBox "Error Add Record to Library failed increasing record media store for key: " & spKeyValue, vbCritical
        Err.Raise vbObjectError + 394034, "", ""
        Exit Function
    End If

    bOk = clsgBSTStore.InsertBSTN(spKeyValue, lpFoundNode)

    If bOk = False Then
        MsgBox "Error Add Record to Library failed setting key/index for value: " & spKeyValue, vbCritical
        Err.Raise vbObjectError + 394035, "", ""
        Exit Function
    End If

    bOk = clsgBSTStore.SetDataNodeIndex(lpFoundNode, lLibraryRecord)

    If bOk = False Then
        MsgBox "Error Add Record to Library failed setting key/index for value: " & spKeyValue, vbCritical
        Err.Raise vbObjectError + 394036, "", ""
        Exit Function
    End If
    iMediaFields = UBound(spaMediaDataValues())
    ' load the passed array with values from the Library record
    iRecordFields = clsgBSTStore.RecordFields
    For iKeyField = 0 To iRecordFields
        If iKeyField <= iMediaFields Then
            clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyField) = spaMediaDataValues(iKeyField)
        Else
            clsgBSTStore.vaLibraryRecord(lLibraryRecord, iKeyField) = ""
        End If
    Next
  
    ' final status
    lblpStatus.Caption = "Added (" & lLibraryRecord & ") Media Record Key: " & spKeyValue & " on : " & Format(Now, "ddd-mmm-yyyy @ hh:mm")
    lblpStatus.Refresh

' DKR:DKR:DKR:
    clsgBSTStore.IncreaseKeyFileRecordsCounter
    
    AddMediaToLibrary = True

   On Error GoTo 0
   Exit Function

AddMediaToLibrary_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure AddMediaToLibrary of Module MediaLibarySample"
    
End Function



'---------------------------------------------------------------------------------------
' Procedure : RemoveMediaDataRecord
' DateTime  : 03/05/2005 20:25
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'don't compress the library or all data indexes are voided
Public Function RemoveMediaDataRecord(ByVal lpLibraryRecord As Long) As Boolean
 Dim lRow As Long
 Dim iOffset As Integer
 Dim iCol As Integer
 Dim lDataPos As Long
 Dim iAdjust As Integer
 Dim lIndirectRow As Long
 Dim lLibraryRecord As Long
 Dim lLibraryRecords As Long
 Dim iRecordField As Long
 Dim iRecordFields As Long
 
RemoveMediaDataRecord = False

   On Error GoTo RemoveMediaDataRecord_Error

    RemoveMediaDataRecord = False
    
    lLibraryRecords = clsgBSTStore.LibraryRecords
    
'DKR:DKR:DKR
    If clsgBSTStore.DiskMediaActivated = False Then
        ' library records bounds check
        If (lpLibraryRecord < 0) Or (lpLibraryRecord > lLibraryRecords) Then
            Exit Function
        End If
    End If
    
    ' BUG FIX:  iRecordFields was 0 so only removing field 0 and not the rest
    iRecordFields = clsgBSTStore.RecordFields
    ' end: BUG FIX 15/05/2005 08:35

    For iRecordField = 0 To iRecordFields
          clsgBSTStore.vaLibraryRecord(lpLibraryRecord, iRecordField) = ""
    Next

RemoveMediaDataRecord = True

   On Error GoTo 0
   Exit Function

RemoveMediaDataRecord_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure RemoveMediaDataRecord of Module MediaLibarySample"

End Function


'---------------------------------------------------------------------------------------
' Procedure : DiskFileActivated
' DateTime  : 07/05/2005 11:17
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function DiskFileActivated() As Boolean

    DiskFileActivated = clsgBSTStore.ReadFromDiskFileActive
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : DiskMediaGarbageStatistics
' DateTime  : 15/05/2005 14:39
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function DiskMediaGarbageStatistics() As Boolean
 Dim dDataOffsetGPercent As Double
 Dim dDataGPercent As Double
 Dim dKeysGPercent As Double
 Dim dNodesGPercent As Double
    
DiskMediaGarbageStatistics = True

   On Error GoTo DiskMediaGarbageStatistics_Error

    DiskMediaGarbageStatistics = clsgBSTStore.DiskMediaGarbageStatistics(dDataOffsetGPercent, dDataGPercent, dKeysGPercent, dNodesGPercent)
    
    Debug.Print dDataOffsetGPercent
    Debug.Print dDataGPercent
    Debug.Print dKeysGPercent
    Debug.Print dNodesGPercent
    
    MsgBox "Data Garbage " & dDataGPercent & "% and Key Garbage " & dKeysGPercent & "% ", vbInformation

   On Error GoTo 0
   Exit Function

DiskMediaGarbageStatistics_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure DiskMediaGarbageStatistics of Module MediaLibarySample"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : DiskMediaGarbageCollection
' DateTime  : 15/05/2005 09:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
' we take the media data file which includes any garbage data and copy it to .tmp
' then we read back with load library call and then rebuild library using rebuild library
' call passing the garbage collect flag.  We need to turn off use disk media to allow
' library load, then we turn it back on at the very end.  The menu option that allow us to
' arrive here is only enabled when 'use disk media' is on!
'
Public Function DiskMediaGarbageCollection() As Boolean
 Dim sDataOffsetLine As String
 Dim sDataLine As String
 Dim sKeyLine As String
 Dim sNodeLine As String
 Dim iInDataOfsChan As Integer
 Dim iInDataChan As Integer
 Dim sDataOffsetFilePathName As String
 Dim sDataFilePathName As String
 Dim dDataFileSize As Double
 Dim dDataGarbageSize As Double
 Dim dKeyFileSize As Double
 Dim dKeyGarbageSize As Double
 Dim bOk As Boolean
 Dim sLibraryFilePathName As String
 Dim sLibraryTempFilePathName As String
 
   On Error GoTo DiskMediaGarbageCollection_Error

 DiskMediaGarbageCollection = False
 
        sLibraryFilePathName = clsgBSTStore.MakeDataFileName(clsgBSTStore.DiskMediaFileName)
        
        sLibraryTempFilePathName = RemoveLastPart(sLibraryFilePathName, ".") & ".tmp"
        
        Debug.Print sLibraryFilePathName
        Debug.Print sLibraryTempFilePathName
        
        ' copy existing media data file with garbage to .tmp to release the media data file for rebuild
        FileCopy sLibraryFilePathName, sLibraryTempFilePathName
        
        UseDiskBasedFile_Off  ' all data indexes were overwritten
        
        ' load the existing media data file as .tmp to allow access to the media data file
        bOk = LoadLibrary(bpoGarbageCollect:=True, spoLibraryFilePathName:=sLibraryTempFilePathName)
        If bOk = False Then
            MsgBox "Failed to re-load library during garbage collection!", vbCritical
            Exit Function
        End If
        
        ' rebuild the existing media data file from memory to disk media data file
        bOk = BuildDiskFileFromLibrary()
        If bOk = False Then
            MsgBox "Failed to rebuild library during garbage collection!"
            Exit Function
        End If
        
        UseDiskBasedFile_On

 DiskMediaGarbageCollection = True
   On Error GoTo 0
   Exit Function

DiskMediaGarbageCollection_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure DiskMediaGarbageCollection of Module MediaLibarySample"

End Function

' eom

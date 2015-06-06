VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "cBSTNStorage"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' BUG FIX   :
' Version   : 1.0 to 1.1
' Details   :  Add optional lpdataindex to allow tree rebalance to keep the
'              new root key dataindex else rebalanced key record data index is lost
'              causing orphaned or mixed up data record, if data index
'              being used to referenc external data records.
'
' Other changes:
'               tidy up nomenclature for parameters passed
'
' Version   : 1.1 to 1.2
' Details   :  virtualise the storage array in preparation for disk based version

' Version   : 1.2 to 1.3
' Details   :  ALL (except Delete Media) virtualised storage array functions implemented for disk based version
'
' Version   : 1.3 to 1.4
' Details   :  Allow use of Delete Media in disk access mode, fixed bug in member routine where
'           :   only one field being updated for valibraryrecord field.
'           :  add Garbage statistics from main menu under tools in media sample library
'           :   and associated member functions here.
'           :  add Garbage collect from main menu under tools in media sample library
'           :   and associated member functions here.
'
' Exceptional Items:
'
'   1.  Okay so there is too much programming in the 'Property' areas, I accept this for the minute and
'           will try to change it in later release(s).
'
'   2.  There is a lot of commented out code, yes, I did not want to remove all these as I am still extensively
'          testing the disk file operations and these help me to remember what I did before and maybe some things
'           I may need to check if I do find any bugs/defects.  I hope they won't cause others too much trouble.
'           After all if you get the highlighting in the IDE right, like make comments lighter, they lose focus
'           when reading the active code.
'
'   3.  Occasionally the nomenclature are ordered differently to my explanations section.  That's a mistake in the code.
'           I keep trying to improve this area of coding so that I can make less mistakes when cutting and pasting
'           like sections to different areas.  I only recently stabilised on the order to include the optional params which
'           could easily be forgotten.  The idea of this version of nomenclature, is that it is based on the
'           generally accepted version (I may get contradicted here!), but extends it slightly to show parameters
'           and optional parameters.  It does not go far enough to show inputs and outputs however, that's included
'           as an integral part of .NET anyway, so I think the idea whilst being a good one would make the parameter
'           prefixes just too messy for now.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'
' NEWS:  May 2005
'        There is a beta media library memory and disk file sample currently in development
'        using this class as it's database engine.  (see later explanation of Media Sample Library Disk Version)
'        If you are <not> interested in the disk file overload functions, don't worry.  The is a member variable
'        flag which has to be set for those disk access parts of BSTN to be active.  If the flag is never changed
'        from it's default, BSTN member functions act as normal (memory mode).  There is a slight overhead on each
'        call to the overloaded member functions of BSTN, but it is very small.  There are real benefits in the
'        overloaded member function to support disk based operations and they are implemented in-line rather
'        than separate to keep the BSTN core code together.  This means that BSTN members can be updated for the
'        memory version and where applicable the disk version can be updated accordingly.
'
'        The sample maintains details of media such as CDs, DVDs, Audio Tapes, VHS Videos etc.
'        Testing and functionality has been completed on the memory mode operations. The earlier sample published
'        on p-s-c supported just memory operations, so if you prefer less code to look through, maybe download that
'        p-s-c article in place of this one.  Due to time constraints, the earlier version will be 'frozen' at that
'        publish point.  Any bug fixes or problems detected will only be applied to this later version with
'        the disk file support.
'
'        Beta <memory> only version(s) were published on p-s-c in April 2005 under the heading of :-
'
'               Binary Search Tree Node Class (database engine)
' and
'               Media Library Sample (using Binary Search Tree Node Class as database engine)
'
'        This later version was published in May 2005 under the heading of :
'
'               Media Library Disk/Memory Sample (using Binary Search Tree Node Class as database engine)
'
'        IMPORTANT: please note that it has <not> been <extensively> tested in disk mode but it has in memory mode.
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'
' NEWS:  April 2005
'        There is a beta media library sample in development using this class as it's database engine.
'        Other p-s-c visitors offered their help in testing the beta sample, checking the adds, removes,
'        ordered lists etc. and it's overall general usage.
'        The sample maintains details of media such as CDs, DVDs, Audio Tapes, VHS Videos etc.
'        Once testing and functionality has been completed, the sample will be published on p-s-c.
'        Anticipated to be published by middle of May 2005 (or sooner!)
'
'---------------------------------------------------------------------------------------
' Project   : cBSTNStorage
' DateTime  : 25/04/2005 20:37
' Author    : D K Richmond
' Status    : BETA RELEASE 1.3
' Version   : Visual Basic 6 (SP6)
' User Type : Beginner/Intermediate/Advanced
' Applicable: Database/Data Sorting/Key Retrieval/Binary Trees/Node Traversals
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
'  I have used a test harness (not included) to prove these functions work as I expect them to work.
'  I can not release the test harness, it's not pretty, there are lots of non-modal controls and really
'  it would take me weeks to make user-friendly and provide documentation on.  You will not
'  benefit from having it as it was only used to test randomly as many the possible combinations of trees.
'  As I have spent many many hours (that's more than 2 weeks several hours a day), to test and
'  refine the routines to give the best performance and reliablity, there is little testing left to do.
'  I have deleted many lines of code either because they were non-sensical, confusing or poor.  In some
'  cases where I wanted to experiment with different ideas, where I felt the normal established nodal functions
'  were too complicated or too unreliable or too complex to test for 100% data integrity.
'  The most complicated routines in the whole class were the RemoveNode and the
'  GetPrevNodeInSortedOrder member functions.  I spent many hours refining and checking
'  these along with others as they are interelated and relate to the correct removal of a node
'  with two sub-branches.
'
' OVERVIEW:
' -----------
'   Things to be aware of:
'      All entries into the Binary Tree structure are via the root node unless the member
'      function relies on a previous action and the next action is incremental or
'      decrimental e.g. GetPrevNodeInSortedOrder
'      To start a tree you will need to call InitRootNode passing the string key
'      you want to assign to the root node.  Now ideally this root node needs to be the
'      nearest to the middle of the sorted data as possible, but don't worry too much about
'      this as it won't affect anything expect a very small performance hit on searches, inserts and deletions.
'      Having entered a root node the next thing is to do is add the other nodes (any order), using InsertBSTN.
'      The most balanced tree will be from completeley random data inserted sequentially.
'      If you insert sorted data you will end up with a tree with a very long branch or very long branches.
'      This means that the searching will not be the fastest it could be.  Don't worry
'      if you have sorted data, just set the root node, read the data and then before using
'      it try a RebalanceTree passing the middle value of the sorted data.  The searches
'      will then be working on a reasonably balanced tree, i.e faster.
'   Where is the tree store?
'      There is a linear array, which is allocated up by one index for each node added.
'      As each item in the array is of type TBSTNStore is has the node values to allow Binary Tree access.
'   Why can't I find some things referenced in the project:
'       Generally anything included in this release should be of publication standard, e.g. be typed and error checked
'       correctly, laid out properly and essentially reliable and of course bug free!  This project is changing weekly
'       and a release will include only those things worthy of publication.  If after completing a major change,
'       I need to publish the code and an non-publishable item is critical to the exection/compilation I am forced to include it
'       as is.  Further releases will either include the item to the correct standard or it's dependencies removed and
'       itself removed from the project.  These are going to be small items and I hope those of you that may have already built
'       applications based on earlier versions of this code will be impacted heavily by any of these necessary changes.
'       In the next few months the core functionality should stabilise and changes we will see will be limited to additional
'       member functions.  Things like tree rotation, maybe an extra new style tree re-balance etc.  Maybe even some more
'       everyday practical examples to demonstrate how these functions are used.
'
' Media Sample Library Disk Version :
' -----------------------------------
' Media Library sample now calls BSTN member functions which are overloaded to allow for disk based media file.
' This gives instant access to a disk based media file.  It's all very new and some unit testing done.
' The sample application is a demonstration of how to implement a generic class to deal with memory
' or disk without the need for duplication of the core code.  Obviously when using the memory mode
' the overloaded functions will be slightly slower as there is checking for disk mode within them. However
' it's a small overhead compared with writing the same code twice and then trying to keep both in sync.
' I personally like the speed difference between memory - load library and disk use.  The first load time on my
' normal media library (not the small sample included) is around 10-20 secs, the second is 'instant'.
' In real life,  say you wanted to book out one item, run the application, click use disk media, enter
' barcode, click search, click [ Book Out ] (not implemented as yet!), click exit.  That's it.   No loading, no saving,
' it's all an integral part of BSTN.  Contrast that with, load the application, wait n seconds, enter barcode,
' click search, click [ Book Out ] (not implemented as yet!), click save library, wait n secs, click exit.
'
' DEBUGGING:
' ---------
' In Class Initialise :  gbDebug = False   '  change this to true to see lots of debug message boxes
'
' SURPRISES:
'  I have left some msgbox's and some redundant error trapping in some routines, this will be taken out real soon.
'  The are some extra definitions that I have left for the future.

' FUTURE:
' -------
' There is a lot of scope to improve this class.
'
' o     Ensuring the tree is always the same level deep
' o     Auto balancing the tree
' o     Dealing with garbage collection
' o     Checking garbage collection thresholds
' o     Tree rotation techniques
' o     Using the Binary Trees for real life applications/examples
' o     Providing some simple test harnesses to test and
'       demonstrate the member functions of the class and the usage
' o     performance counters/traversal statistics

' I will be updating this class, adding extra member functions which may address the above future items or other
' items more pressing or necessary for using this class in other projects.  I have some projects that will make
' use of this class immediately.  If you have ideas, want help in understanding things I have ommitted from the
' overview, usage etc, let me know on the above email. Remember the Binary Tree principals are on the internet.
' Try google.com and use the phrase "Binary Trees" with quotes. Please try to use the example below and have a
' try using the functions yourself before contacting me, the rewards will be better.  Also if for example
' 50+ people contact me I am going to struggle to get a reply off to everyone and have time to improve the
' class. Otherwise look for the next update and I hope to include some interesting and hopefully practical
' examples of using the class to the MAX!!
'
'
' Key Compares.
' -----------
'  Use CompareKeys to check if keys are less, equal or more than each other.  This is because
'  there is a lexical member value.  This makes each key lexical compared, so it makes more
'  sense to human readability.  If you change the lexical to non-lexical you will get true
'  computer sorted keys and hence if you use this you will inherit the same comparisons.
'  If you don't and then later change it and you don't change to code outside the class
'  you will get data inconsistent results.
'
' DONT:  Try this with non-unique keys.  For example A,A,B,C,D,D,E,E
'--------------------------------------------------------------------
' If you do try adding the same key more than once, YOU WILL GENERATE an ERROR.
' This is deliberate.  About 10+ years ago, I wrote a procedure (in C) to allow duplicate
' keys in a Binary tree.  It took me ages to perfect, it was always needing updates/tweaks
' and many coding changes.  I know these days, I could add this quite easily but it's a
' lot more testing! So it has not been included in this release. When I have tested
' using duplicate keys in the same tree and it's reliable and allows correct nodal deletes,
' I will then remove the error trap, make it conditional based on global value and thus allow
' duplicate keys to be stored in the tree.  Of course those brave people reading this
' are welcome to take the class and try with duplicate keys, you don't have to wait for  =[8-)
'---------------------------------------------------------------------------------------
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
'
' NOTES for beginners:
' ---------------------
' The class members are protected from external alteration by being made private.  This protects the integrity
' of the data in the binary tree.   If you end up making the private's into public's you need to re-think why you need
' to do so.   There are public property's to allow Read/Write access where applicable to external programs.
' Please try to keep the private members private and if you need to get the value in a private member
' use a public get property.  Try not to go wild here!
' Private Const is used to protect constant values for being changed during runtime
'
' ##########################################################################################################
'
' EXAMPLE USAGE:
'
' Create a new project (standard)
'
' add the following controls:
' o     a listbox named List1
' o     a command button named cmdLoadFile caption "Load File"
' o     a command button named cmdShowSorted caption "Show Sorted List"
'
' then add this code to the form module code
' remember to add both the classes using project menu, add class.
' class:   cBSTNStorage
' and
' class:   cList
'
' now paste this section of example code to the form module code window then
' remove the comment prefix using the ide toolbar function
'
' Run the app, click on the cmdShowSorted button and the letters in the Form_Load
' will appear sorted.
' Now create the file as show in the cmdLoadFile comment for DOS
' click on the cmdLoadFile and see a list of alphabetically sorted filenames
' in the listbox.
'
'  As an example for you to see how easy is it with a binary tree class to find items,
'  write a routine where the item clicked in the list is extracted from the list
'  into a string named sKey. Then use the SearchBSTN passing sKey to located the item in the tree.
'  Use the public property's to retrieve the values of the node Left, Right, Parent and DataIndex.
'
'  Next, I expect having seen some potential, you're thinking, yep, okay, not bad, but what's next?
'  Well, you can use SetDataNodeIndex to assign an index (data type long) to the node.
'  So if you have an array of values elsewhere, you can then assign that index to the node's DataIndex value.
'  Whenever the tree is re-organised the DataIndex value moves with the node.
'  So you can store a whole record, keep the index value and assign it to a key node.
'  You can then perform fast searches and use the GetDataNodeIndex to retrieve the offset to the record.
'
' In SUMMARY: Does that sound similar to a key search on a database record or not?

''  #### start ################### EXAMPLE CODE TO PASTE INTO THE MAIN FORM ##########################
'Dim clsBSTStore As cBSTNStorage
'
'
' Sub Form_Load()
'
'    Set clsBSTStore = New cBSTNStorage
'
'    clsBSTStore.InitRootNode "K"
'
'    clsBSTStore.InsertBSTN "H"
'    clsBSTStore.InsertBSTN "V"
'    clsBSTStore.InsertBSTN "L"
'    clsBSTStore.InsertBSTN "Z"
'    clsBSTStore.InsertBSTN "M"
'    clsBSTStore.InsertBSTN "O"
'
'End Sub
'
'
'Private Sub Form_Unload(Cancel As Integer)
'    Set clsBSTStore = Nothing
'End Sub
'
'
' Sub cmdLoadFile_Click()
'  'use DOS command line:   C:\> dir /b >c:\temp\dir.txt
'    clsBSTStore.InitRootNode "."
'     Open "C:\temp\dir.txt" For Input As #12
'    While Not EOF(12)
'        Line Input #12, sLine
'        clsBSTStore.InsertBSTN sLine
'    Wend
'    Close #12
' End Sub
'
'
' Sub cmdShowSorted_Click()
'
' Dim lNextNode As Long
' Dim sKey As String
'
'    List1.Clear
'
'    clsBSTStore.ResetToRootNode
'
'    Do
'        If clsBSTStore.GetNextNodeInSortedOrder(lNextNode) = True Then
'            Debug.Print String(40, "-")
'            Debug.Print "SO_BTNS[" & lNextNode & "] P=" & clsBSTStore.GetParentNodeOfIndex(lNextNode)
'            Debug.Print "SO_BTNS[" & lNextNode & "] L=" & clsBSTStore.GetLeftNodeOfIndex(lNextNode)
'            Debug.Print "SO_BTNS[" & lNextNode & "] R=" & clsBSTStore.GetRightNodeOfIndex(lNextNode)
'            Debug.Print "SO_BTNS[" & lNextNode & "] K=" & clsBSTStore.GetKeyAtNodeIndex(lNextNode)
'            Debug.Print String(40, "=")
'        Else
'            Exit Do
'        End If
'
'        DoEvents
'
'        If (clsBSTStore.TopOfTreeReached = False) Then
'            sKey = clsBSTStore.GetKeyAtNodeIndex(lNextNode)
'            List1.AddItem sKey
'        End If
'    Loop
'
'End Sub
'
'
''  #### end ################### EXAMPLE CODE TO PASTE INTO THE MAIN FORM ##########################

  
Option Explicit
Dim gbDebug As Boolean

'---------------------------------------------------------------------------------------
' Module    : cBSTNStorage
' DateTime  : 17/04/2005 10:01
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

' ## start: disk file BSTN params ##
Private m_bReadFromDiskFile As Boolean
Private m_sDiskFileName As String
Private m_sDiskNodeFilePathName As String
Private m_sDiskKeyFilePathName As String
Private m_iDiskNodeInChan As Integer
Private m_iDiskKeyChan As Integer
Private m_dFileNodeOffset As Double
Private m_dFileKeyOffset As Double
Private m_sNodeLine As String
Private m_sKeyLine As String
Private m_iRecordLen As Integer
Private Const m_scNodeFileExtension = ".bsn"
Private Const m_scKeyFileExtension = ".bsk"
Private Const m_scDataFileExtension = ".bsd"
Private Const m_scDataOffsetFileExtension = ".bdo"

' ----------------------------------       P          L          R         I         KFO
Private Const m_scRecordStructMask = "0o0o0p0o0o|0o0o0l0o0o|0o0o0r0o0o|0o0o0i0o0o|0o0o0k0o0o"
Private Const m_scNodeFieldDelimeter = "|"
Private m_sDataFieldDelimeter As String

' ## end: disk file BSTN params ##


' #### external data storage params/decls ###
Private m_vaLibraryMemoryRecords() As Variant
Private m_vaLibraryMemoryRecordsShadow() As Variant

' the record data store
Private m_lLibraryRecords As Long
' conversion from external globals to class
Private m_iRecordFields As Integer
Private m_iKeyField As Integer

' ### globals declarations ##


' IMPORTANT NOTE:
' if you add any extra items to this type you will need to add them to any routines
' that maintain them during tree re-organisations
Private Type utBSTNStore
    m_lParent As Long       ' Parent Node Link
    m_lLeft As Long         ' Left Node Link
    m_lRight As Long        ' Right Node Link
    m_sNodeKey As String    ' Node Key Value
    m_lNodeDataIndex As Long   ' provides index into external data and this is maintained during tree reorganisations
End Type


' ######################

Private m_utBSTNStore() As utBSTNStore      ' this is the tree node storage data

Public Enum NodeTypes
    m_ePNodeType = 1       ' Parent node type
    m_eLNodeType = 2       ' Left node type
    m_eRNodeType = 3       ' Right node type
End Enum


' A pretty unique garbage identity key.  If your key value is this then the node has been deleted
Private m_sGarbageIdentityKey  ' = Chr(128) & chr(127) x 5
            
' data removal char - used with garbage detection
Private Const m_DataRemovalCharacter = "¬"

' as it's a percentage of those nodes also allocated on top of store this needs to be reasonably low
Private Const m_cgiGarbageThresholdPercentage = 30

' lexical text matching if set true . ie . a and A are equal value for key compares
Private Const m_cbLexical = True
 
Public Enum TraverseOpCodes
    m_eiUNKNOWN = -1
    m_eiGoFarLeft = 1
    m_eiGoRight = 2
    m_eiGoUpVisit = 3
    m_egiGoUp = 4
    m_eiGoFarRight = 5
    m_eiGoLeft = 6
    m_eiTopofTree = 99
End Enum

' consts TraverseOpTexts
Private Const m_csGoFarLeft = "GoFarLeft"
Private Const m_csGoRight = "GoRight"
Private Const m_csGoUpVisit = "GoUpVisit"
Private Const m_csiGoUp = "GoUp"
Private Const m_csTopofTree = "TopofTree"
' end consts

' tree span counters, watchers
Private m_lNodeHitsCount As Long
Private m_lOffsetLeft As Long
Private m_lOffsetRight As Long
Private m_lNodeLevel As Long
Private m_lCurrentNode As Long
Private m_iOperation As Integer
Private m_lRemovedNodesCount As Long

Private Const m_cNoLink = -1

Public Enum eType
    m_elParent = 0      ' Parent Node Link
    m_elLeft = 1        ' Left Node Link
    m_elRight = 2       ' Right Node Link
    m_elNodeDataIndex = 3  ' provides index into external data and this is maintained during tree reorganisations
' this is referenced in separate file
    m_esNodeKey = 4   ' Node Key Value
  '  m_esDataOffset = 5 ' pseudo enum for disk file
End Enum

' ## external data access properties ##

' ############################ functions properties etc ############################################
' ############################ functions properties etc ############################################
' ############################ functions properties etc ############################################

'---------------------------------------------------------------------------------------
' Procedure : GetGarbageCollectThresholdPercentage
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetGarbageCollectThresholdPercentage() As Integer
    GetGarbageCollectThresholdPercentage = m_cgiGarbageThresholdPercentage
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseOperationCode
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseOperationCode() As Integer
    GetTraverseOperationCode = m_iOperation
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseOperationText
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseOperationText() As String
    GetTraverseOperationText = GetTraverseTextForOpcode(m_iOperation)
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseCurrentNodeIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseCurrentNodeIndex() As Long
    GetTraverseCurrentNodeIndex = m_lCurrentNode
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseCurrentNodeKey
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseCurrentNodeKey() As Long
    GetTraverseCurrentNodeKey = BSTNStore(m_lCurrentNode, m_esNodeKey)
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseNodeLevel
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseNodeLevel() As Long
    GetTraverseNodeLevel = m_lNodeLevel
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseOffsetLeft
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseOffsetLeft() As Long
    GetTraverseOffsetLeft = m_lOffsetLeft
End Property

'---------------------------------------------------------------------------------------
' Procedure : GetTraverseOffsetRight
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetTraverseOffsetRight() As Long
    GetTraverseOffsetRight = m_lOffsetRight
End Property

'---------------------------------------------------------------------------------------
' Procedure : TopOfTreeReached
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function TopOfTreeReached() As Boolean
    TopOfTreeReached = (m_iOperation = m_eiTopofTree)
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetCurrentNodeIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GetCurrentNodeIndex() As Long
    GetCurrentNodeIndex = m_lCurrentNode
End Property

'---------------------------------------------------------------------------------------
' Procedure : DiskMediaActivated
' DateTime  : 15/05/2005 14:59
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get DiskMediaActivated() As String
    DiskMediaActivated = m_bReadFromDiskFile
End Property

'---------------------------------------------------------------------------------------
' Procedure : DiskMediaFileName
' DateTime  : 15/05/2005 14:22
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get DiskMediaFileName() As String
    DiskMediaFileName = m_sDiskFileName
End Property

'---------------------------------------------------------------------------------------
' Procedure : GarbageIdentityKey
' DateTime  : 15/05/2005 09:38
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get GarbageIdentityKey() As String
    GarbageIdentityKey = m_sGarbageIdentityKey  ' = Chr(128) & chr(127) x 5
End Property

'---------------------------------------------------------------------------------------
' Procedure : DataRemovalCharacter
' DateTime  : 15/05/2005 09:38
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get DataRemovalCharacter() As String
    ' data removal char - used with garbage detection
    DataRemovalCharacter = m_DataRemovalCharacter
End Property
            
'---------------------------------------------------------------------------------------
' Procedure : ReadFromDiskFileActive
' DateTime  : 07/05/2005 11:16
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get ReadFromDiskFileActive() As Boolean
    ReadFromDiskFileActive = m_bReadFromDiskFile
End Property

'---------------------------------------------------------------------------------------
' Procedure : NodeDelimiter
' DateTime  : 07/05/2005 08:46
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get NodeDelimiter() As String
    NodeDelimiter = m_scNodeFieldDelimeter
End Property

'---------------------------------------------------------------------------------------
' Procedure : MakeNodeFileName
' DateTime  : 07/05/2005 08:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function MakeNodeFileName(ByVal spFileName As String)
    MakeNodeFileName = spFileName & m_scNodeFileExtension
End Function

'---------------------------------------------------------------------------------------
' Procedure : MakeKeysFileName
' DateTime  : 07/05/2005 08:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function MakeKeysFileName(ByVal spFileName As String)
    MakeKeysFileName = spFileName & m_scKeyFileExtension
End Function

'---------------------------------------------------------------------------------------
' Procedure : MakeDataFileName
' DateTime  : 07/05/2005 08:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function MakeDataFileName(ByVal spFileName As String)
    MakeDataFileName = spFileName & m_scDataFileExtension
End Function

'---------------------------------------------------------------------------------------
' Procedure : MakeDataOffsetFileName
' DateTime  : 09/05/2005 21:11
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function MakeDataOffsetFileName(ByVal spFileName As String)
    MakeDataOffsetFileName = spFileName & m_scDataOffsetFileExtension
End Function

'---------------------------------------------------------------------------------------
' Procedure : KeyField
' DateTime  : 06/05/2005 22:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Let KeyField(ByVal iKeyFieldNumber As Integer)
    m_iKeyField = iKeyFieldNumber
End Property

'---------------------------------------------------------------------------------------
' Procedure : KeyField
' DateTime  : 06/05/2005 22:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get KeyField() As Integer
    KeyField = m_iKeyField
End Property

'---------------------------------------------------------------------------------------
' Procedure : RecordFields
' DateTime  : 06/05/2005 22:03
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get RecordFields() As Integer
    RecordFields = m_iRecordFields
End Property

'---------------------------------------------------------------------------------------
' Procedure : LibraryRecords
' DateTime  : 07/05/2005 08:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get LibraryRecords() As Long
    LibraryRecords = m_lLibraryRecords
End Property

'---------------------------------------------------------------------------------------
' Procedure : vaLibraryRecord
' DateTime  : 06/05/2005 20:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
' BUG FIX:  : ByVal iField As Integer to ByVal ipField As Integer - used later to solve other bug
Public Property Get vaLibraryRecord(ByRef lpLibraryRecord As Long, ByVal ipField As Integer) As Variant
 Dim sDataFilePathName As String
 Dim dDataOffset As Double
 Dim sDataLine As String
 Dim saFields() As String
 Dim iMaxFields As Integer
 Dim iInDataChan As Integer
 Dim sKeyValue As String
    
'debug
'If lpLibraryRecord >= 71 Then
'    MsgBox "eek!", lpLibraryRecord
'    Debug.Print ""
'End If

   On Error GoTo vaLibraryRecord_Error

    If (m_bReadFromDiskFile = False) Then
        vaLibraryRecord = m_vaLibraryMemoryRecords(lpLibraryRecord, ipField)
        Exit Property
    End If

    If (m_bReadFromDiskFile = True) Then
    
        If (gbDebug = True) Then
            MsgBox "DISKFILE!", vbCritical
        End If
        
        ' data index is offset to field data in data file not record index to array
        ' load the passed array with values from the Library data file
        sDataFilePathName = MakeDataFileName(m_sDiskFileName)
        dDataOffset = lpLibraryRecord
        ' get existing line data to find length to write out deleted line of equal length
        iInDataChan = FreeFile()
        Close #iInDataChan: Open sDataFilePathName For Input As #iInDataChan
            Seek #iInDataChan, dDataOffset
            Line Input #iInDataChan, sDataLine
        Close #iInDataChan
        saFields = Split(sDataLine, m_sDataFieldDelimeter)
        sKeyValue = saFields(m_iKeyField)
        iMaxFields = UBound(saFields())
        If (ipField < 0) Or (ipField > iMaxFields) Then
            Err.Raise 3040394 + 2093092, "", ""
        End If
        
        vaLibraryRecord = saFields(ipField)
        
     End If

   On Error GoTo 0
   Exit Property

vaLibraryRecord_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure vaLibraryRecord of Class Module cBSTNStorage"
    
End Property

'---------------------------------------------------------------------------------------
' Procedure : vaLibraryRecord
' DateTime  : 06/05/2005 20:57
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
' BUG FIX:  : ByVal iField As Integer to ByVal ipField As Integer - used later to solve other bug
Public Property Let vaLibraryRecord(ByRef lpLibraryRecord As Long, ByVal ipField As Integer, ByVal vpValue As Variant)
 Dim iRecordField As Integer
 Dim sDataFilePathName As String
 Dim dDataOffset As Double
 Dim sDataLine As String
 Dim saFields() As String
 Dim iMaxFields As Integer
 Dim iInDataChan As Integer
 Dim iOutBinaryDataChan As Integer
 Dim sUpdateLine As String
 Dim iAppendDataChan As Integer
 Dim iDiskNodeChan As Integer
 Dim sUpdateDataOffset As String
 Dim iMax As Integer
 Dim sKeyValue As String
 Dim lFoundNode As Long
 Dim bOk As Boolean
 Dim iDataOfsChan As Integer
 Dim sDataOffsetLine As String
 Dim dDataOffsetSeek As Double
 Dim sDataOffsetFilePathName As String
 Dim iInDataOfsChan As Integer
 
 
    If (m_bReadFromDiskFile = False) Then
        m_vaLibraryMemoryRecords(lpLibraryRecord, ipField) = vpValue
        Exit Property
    End If
    
      If (m_bReadFromDiskFile = True) Then
    
          ' lpRecord is the data file offset passed from getdata index

        If (gbDebug = True) Then
            MsgBox "DISKFILE!", vbCritical
        End If
        
        ' data index is offset to field data in data file not record index to array
        ' load the passed array with values from the Library data file
        sDataOffsetFilePathName = MakeDataOffsetFileName(m_sDiskFileName)
        
        ' THIS NEXT LINE HAS HARD CODED VALUES - NEEDS TO BE BASED on record mask!
        dDataOffsetSeek = lpLibraryRecord * (10 + 2) + 1  ' format len + crlf + next line
        
        iInDataOfsChan = FreeFile()
        Close #iInDataOfsChan: Open sDataOffsetFilePathName For Input As #iInDataOfsChan
            Seek #iInDataOfsChan, dDataOffsetSeek
            Line Input #iInDataOfsChan, sDataOffsetLine
        Close #iInDataOfsChan
        dDataOffset = Val(sDataOffsetLine)
 
       ' Err.Raise 2309930293# + 209320, "", ""
        ' data index is offset to field data in data file not record index to array
        ' load the passed array with values from the Library data file
        sDataFilePathName = MakeDataFileName(m_sDiskFileName)
        'dDataOffset = lpLibraryRecord
        ' get existing line data to find length to write out deleted line of equal length
        iInDataChan = FreeFile()
        Close #iInDataChan: Open sDataFilePathName For Input As #iInDataChan
            Seek #iInDataChan, dDataOffset
            Line Input #iInDataChan, sDataLine
        Close #iInDataChan
        saFields = Split(sDataLine, m_sDataFieldDelimeter)
        sKeyValue = saFields(m_iKeyField)
        ' write out deleted line of equal length
        iOutBinaryDataChan = FreeFile()
        Close #iOutBinaryDataChan: Open sDataFilePathName For Binary As #iOutBinaryDataChan
            Seek #iOutBinaryDataChan, dDataOffset
            sDataLine = String(Len(sDataLine), m_DataRemovalCharacter)
            Put #iOutBinaryDataChan, , sDataLine   ' relative to seek
        Close #iOutBinaryDataChan
        
        iMaxFields = UBound(saFields())
        If (ipField < 0) Or (ipField > iMaxFields) Then
            Err.Raise 3040394 + 2093092, "", ""
        End If
'        If (iField = m_iKeyField) Then
'            If sKeyValue <> CStr(vpValue) Then
'                Err.Raise 3040394 + 2093092, "cant", "cant"
'            End If
'        End If

' BUG FIX: start : creating input past end of line errors - due to extra delimeter
Dim sDelim As String

sDelim = m_scNodeFieldDelimeter
' BUG FIX: end : creating input past end of line errors - due to extra delimeter

        sUpdateLine = ""
        For iRecordField = 0 To m_iRecordFields
            If (iRecordField <= iMaxFields) Then  'protect array
' BUG FIX: start : creating input past end of line errors - due to extra delimeter
'                If (iField <> iRecordField) Then
'                    sUpdateLine = sUpdateLine & saFields(iRecordField) & "|"
'                Else
'                    sUpdateLine = sUpdateLine & CStr(vpValue) & "|"
'                End If
                
                If (iRecordField = iMaxFields) Or (iRecordField = m_iRecordFields) Then
                    sDelim = ""
                End If
                
                If (iRecordField <> ipField) Then
                    sUpdateLine = sUpdateLine & saFields(iRecordField) & sDelim
                Else
                    sUpdateLine = sUpdateLine & CStr(vpValue) & sDelim
                End If
 ' BUG FIX: end : creating input past end of line errors - due to extra delimeter
            Else
                ' put something obscure for testing only change to "" for release
                'sUpdateLine = sUpdateLine & "???" & "|"
                MsgBox "Data Update Error! - fields mismatch!", vbCritical
                Err.Raise 300394 + 3940394, "", ""
                Exit Property
            End If
        Next
        ' write out updated line (old line has been deleted to equal length)
        iAppendDataChan = FreeFile()
        Close #iAppendDataChan: Open sDataFilePathName For Append As #iAppendDataChan
            dDataOffset = LOF(iAppendDataChan) + 1   ' +1 neccessary to take to next char past eof
            Debug.Print dDataOffset
            Print #iAppendDataChan, sUpdateLine
            'Debug.Print Seek(iAppendDataChan)
            ' Seek(iAppendDataChan) - Len(sUpdateLine) this doesn't give correct number !!
        Close #iAppendDataChan
        
        ' update to new data offset
        sDataOffsetLine = NodePlusMinusFormat(dDataOffset)
        dDataOffsetSeek = lpLibraryRecord * (10 + 2) + 1 ' format len + crlf
        iDataOfsChan = FreeFile()
        Close #iDataOfsChan: Open sDataOffsetFilePathName For Binary As #iDataOfsChan
            Seek #iDataOfsChan, dDataOffsetSeek
            Put #iDataOfsChan, , sDataOffsetLine
        Close #iDataOfsChan

    End If
    
End Property

'---------------------------------------------------------------------------------------
' Procedure : ActivateDiskFile
' DateTime  : 06/05/2005 16:10
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function ActivateDiskFile(ByVal spDiskFilePathName As String) As Boolean
 Dim bOk As Boolean
 Dim sHeaderLine As String
 Dim lLibraryRecords As Long
 Dim saFields() As String
 Dim iKeyFieldNumber As Integer
 Dim iRecordFields As Integer
 
   On Error GoTo ActivateDiskFile_Error

    bOk = False
    If (m_bReadFromDiskFile = False) Then
        m_sDiskFileName = RemoveLastPart(spDiskFilePathName, ".")
        m_sDiskNodeFilePathName = m_sDiskFileName & m_scNodeFileExtension
        m_sDiskKeyFilePathName = m_sDiskFileName & m_scKeyFileExtension
        ' get up number of keys to allocate psuedo array matched for file access
        m_iDiskKeyChan = FreeFile()
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
        ' need check header line for proper format else could load any file
        Line Input #m_iDiskKeyChan, sHeaderLine
        Close #m_iDiskKeyChan
        saFields() = Split(sHeaderLine, m_scNodeFieldDelimeter)
        lLibraryRecords = Val(saFields(0))  ' records count is written to keys file as "n | f | k | header"
        iRecordFields = Val(saFields(1)) ' fields count is written to keys file as "n | f | k | header"
        iKeyFieldNumber = Val(saFields(2)) ' iKeyFieldNumber is written to keys file as "n | f | k | header"
        
        ' allocate memory for cache reads of disk file on one for basis
        ' don't worry about m_vaLibraryMemoryRecords they take care of themselves
        m_lLibraryRecords = lLibraryRecords
        m_iRecordFields = iRecordFields
        m_iKeyField = iKeyFieldNumber
        ' valid
        ReDim m_utBSTNStore(m_lLibraryRecords)
        
        ' set up node file access
        m_iDiskNodeInChan = FreeFile()
        Close #m_iDiskNodeInChan: Open m_sDiskNodeFilePathName For Input As #m_iDiskNodeInChan
        Line Input #m_iDiskNodeInChan, sHeaderLine
        ' need check header line for proper format else could load any file
        If 1 = 0 Then
            Err.Raise vbObjectError + 330349, "Invalid File", "IFile"
        End If
        ' set up key file access
        m_iDiskKeyChan = FreeFile()
        Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
        Line Input #m_iDiskKeyChan, sHeaderLine
        ' check header line
        If 1 = 0 Then
            Err.Raise vbObjectError + 330349, "Invalid File", "IFile"
        End If
        m_bReadFromDiskFile = True
    Else
        Err.Raise vbObjectError + 330349, "huh", "huh"
    End If
    
ActivateDiskFile = bOk

   On Error GoTo 0
   Exit Function

ActivateDiskFile_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure ActivateDiskFile of Class Module cBSTNStorage"
End Function


'---------------------------------------------------------------------------------------
' Procedure : DeActivateDiskFile
' DateTime  : 06/05/2005 16:15
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function DeActivateDiskFile()
        
    If (m_iDiskNodeInChan <> -1) Then
        Close #m_iDiskNodeInChan
        m_iDiskNodeInChan = -1
    End If
     If (m_iDiskKeyChan <> -1) Then
        Close #m_iDiskKeyChan
        m_iDiskKeyChan = -1
    End If
    m_sDiskFileName = ""
    m_sDiskNodeFilePathName = ""
    m_sDiskKeyFilePathName = ""
    m_bReadFromDiskFile = False

End Function

'---------------------------------------------------------------------------------------
' Procedure : BSTNStore
' DateTime  : 06/05/2005 16:08
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Get BSTNStore(ByVal lpRecord As Long, ByVal ipMember As Integer) As Variant
 Dim iMax As Integer
 Dim saFields() As String
 Dim lKeyRecord As Long
 Dim sTempNode As String
 
   On Error GoTo BSTNStore_Error

    If m_bReadFromDiskFile = True Then
'        MsgBox "Diskfile!", vbCritical
        ' node data from data file
        m_dFileNodeOffset = (m_iRecordLen) * (lpRecord + 1) + 1 ' header record is 1 line +1 +crlf
        
        Seek #m_iDiskNodeInChan, m_dFileNodeOffset
        
        If m_dFileNodeOffset > LOF(m_iDiskNodeInChan) Then
            MsgBox "Disk Media File Error!", vbCritical
            Err.Raise 30949304, 3093049, "", ""
        End If
        
        Line Input #m_iDiskNodeInChan, m_sNodeLine
  
        Debug.Print m_sNodeLine
  
        saFields = Split(m_sNodeLine, m_scNodeFieldDelimeter)
        iMax = UBound(saFields())
        If (iMax <> m_esNodeKey) Then  ' P - L - R - DI - KFO - DO   [ 0-5 ]
            Err.Raise vbObject + 229029, "", ""
        Else
            Select Case ipMember
            Case m_elParent
            ' copy from disk to array
                m_utBSTNStore(lpRecord).m_lParent = Val(saFields(m_elParent))
            Case m_elLeft
                m_utBSTNStore(lpRecord).m_lLeft = Val(saFields(m_elLeft))
            Case m_elRight
                m_utBSTNStore(lpRecord).m_lRight = Val(saFields(m_elRight))
            'm_utBSTNStore(lpRecord).m_lNodeDataIndex = Val(saFields(m_elNodeDataIndex))
            ' key data from key file
            Case m_esNodeKey
                sTempNode = saFields(m_esNodeKey)
                If (sTempNode = "0o0o0k0o0o") Then
                    MsgBox "Node key data offset not set!", vbCritical
                    Err.Raise 30949034 + 3094304, "", ""
                End If
                m_dFileKeyOffset = Val(sTempNode) ' inc crlf
                Seek #m_iDiskKeyChan, m_dFileKeyOffset
                Line Input #m_iDiskKeyChan, m_sKeyLine
                m_utBSTNStore(lpRecord).m_sNodeKey = m_sKeyLine
            Case m_elNodeDataIndex
                    m_utBSTNStore(lpRecord).m_lNodeDataIndex = Val(saFields(m_elNodeDataIndex))   ' data type error double to long
            Case Else
                Err.Raise vbObjectError + 22992, "", ""
            End Select
        End If

    End If

    Select Case ipMember
        Case m_elParent
                 BSTNStore = m_utBSTNStore(lpRecord).m_lParent
        Case m_elLeft
                 BSTNStore = m_utBSTNStore(lpRecord).m_lLeft
        Case m_elRight
                 BSTNStore = m_utBSTNStore(lpRecord).m_lRight
        Case m_esNodeKey
                 BSTNStore = m_utBSTNStore(lpRecord).m_sNodeKey
        Case m_elNodeDataIndex
                 BSTNStore = m_utBSTNStore(lpRecord).m_lNodeDataIndex
         Case Else
             Err.Raise vbObjectError + 22992, "", ""
    End Select

   On Error GoTo 0
   Exit Property

BSTNStore_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure BSTNStore of Class Module cBSTNStorage"
    
End Property

'---------------------------------------------------------------------------------------
' Procedure : BSTNStore
' DateTime  : 06/05/2005 16:08
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Property Let BSTNStore(ByVal lpRecord As Long, ByVal ipMember As Integer, ByVal vpValue As Variant)
 Dim iMax As Integer
 Dim saFields() As String
 Dim iField As Integer
 Dim sUpdateNodeLine As String
 Dim iNodeChan As Integer
 Dim sFieldChar As String
 Dim dKeyOffset As Double
 Dim iDiskKeyChan As Integer
 Dim sKeyLine As String
 Dim dDataOffsetSeekCheck As Double
 Dim sDataOffsetLine As String
 Dim sDataOffsetFilePathName As String
 Dim iInDataOfsChan As Integer
 Dim dDataOffsetSeek As Double
 
   On Error GoTo BSTNStore_Error

    If (m_bReadFromDiskFile = False) Then
        Select Case ipMember
           Case m_elParent
                    m_utBSTNStore(lpRecord).m_lParent = vpValue
           Case m_elLeft
                     m_utBSTNStore(lpRecord).m_lLeft = vpValue
           Case m_elRight
                    m_utBSTNStore(lpRecord).m_lRight = vpValue
           Case m_esNodeKey
                    m_utBSTNStore(lpRecord).m_sNodeKey = vpValue
           Case m_elNodeDataIndex
                    m_utBSTNStore(lpRecord).m_lNodeDataIndex = vpValue
            Case Else
                Err.Raise vbObjectError + 22992, "", ""
        End Select
    End If
    

    If m_bReadFromDiskFile = True Then
        'MsgBox "Diskfile!", vbCritical
        ' node data from data file
        m_dFileNodeOffset = (m_iRecordLen) * (lpRecord + 1) + 1 ' header record is 1 line +1 +crlf
        
        If m_dFileNodeOffset > LOF(m_iDiskNodeInChan) Then
            MsgBox "Disk Media err!", vbCritical
        End If
        
        Seek #m_iDiskNodeInChan, m_dFileNodeOffset
        Line Input #m_iDiskNodeInChan, m_sNodeLine
  
        saFields = Split(m_sNodeLine, m_scNodeFieldDelimeter)
        iMax = UBound(saFields())
        If (iMax <> m_esNodeKey) Then  ' P - L - R - DI - KFO  [ 0-5 ]
            Err.Raise vbObject + 229029, "", ""
        Else
            Select Case ipMember
            Case m_elParent
            ' copy from value to disk array
                saFields(0) = NodePlusMinusFormat(vpValue)
            Case m_elLeft
                 saFields(1) = NodePlusMinusFormat(vpValue)
            Case m_elRight
                saFields(2) = NodePlusMinusFormat(vpValue)
            Case m_elNodeDataIndex
                saFields(3) = NodePlusMinusFormat(vpValue)  ' data type error double to long
            Case m_esNodeKey
                ' do it later
            Case Else
                Err.Raise vbObjectError + 22992, "", ""
            End Select
        End If
        
        ' key update
        If (ipMember = m_esNodeKey) Then
            ' if saFields(4) is a new entry like "0o0o0k0o0o" then just allocated new entry so add key and derive offset
            If saFields(4) = "0o0o0k0o0o" Then
                Close #m_iDiskKeyChan
                iDiskKeyChan = FreeFile()
                Close #iDiskKeyChan: Open m_sDiskKeyFilePathName For Append As #iDiskKeyChan
                dKeyOffset = LOF(iDiskKeyChan) + 1
                Print #iDiskKeyChan, vpValue
                Close #iDiskKeyChan
                
                ' NodePlusMinusFormat change the name as not just for nodes
                sDataOffsetLine = NodePlusMinusFormat(dKeyOffset)
                ' data index is offset to field data in data file not record index to array
                ' load the passed array with values from the Library data file
                sDataOffsetFilePathName = MakeDataOffsetFileName(m_sDiskFileName)
                
                iInDataOfsChan = FreeFile()
                Close #iInDataOfsChan: Open sDataOffsetFilePathName For Append As #iInDataOfsChan
                    dDataOffsetSeekCheck = LOF(iInDataOfsChan) + 1
                    Print #iInDataOfsChan, sDataOffsetLine
                Close #iInDataOfsChan
                
                dDataOffsetSeek = lpRecord * (10 + 2) + 1 ' format len + crlf - NEEDS GENERIC to replace 10
'                If dDataOffsetSeek <> dDataOffsetSeekCheck Then
'                    MsgBox "Bad Key update on disk file!", vbCritical
'                    Err.Raise 939203 + 9202309, "", ""
'                    Exit Property
'                End If
        
                ' recalc node offset
                m_dFileNodeOffset = (m_iRecordLen) * (lpRecord - 1) + 1 ' header record is 1 line +1 +crlf
                ' update node file ??
                'saFields(4) = NodePlusMinusFormat(dKeyOffset)
            Else
                dKeyOffset = Val(saFields(4))  '
                Close #m_iDiskKeyChan
                iDiskKeyChan = FreeFile()
                Close #iDiskKeyChan: Open m_sDiskKeyFilePathName For Binary As #iDiskKeyChan
                    Seek #iDiskKeyChan, dKeyOffset
                    Line Input #iDiskKeyChan, sKeyLine
                    Seek #iDiskKeyChan, dKeyOffset
                    Put #iDiskKeyChan, , CStr(String(Len(sKeyLine), m_DataRemovalCharacter))
                Close #iDiskKeyChan
                Open m_sDiskKeyFilePathName For Append As #iDiskKeyChan
                dKeyOffset = LOF(iDiskKeyChan) + 1
                saFields(4) = NodePlusMinusFormat(dKeyOffset)
                Print #iDiskKeyChan, vpValue
                Close #iDiskKeyChan
            End If
            ' re-open
            Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
            
        End If
        
        sFieldChar = m_scNodeFieldDelimeter
        sUpdateNodeLine = ""
        For iField = 0 To iMax
            If (iField = iMax) Then
                sFieldChar = ""
            End If
            sUpdateNodeLine = sUpdateNodeLine & saFields(iField) & sFieldChar
        Next
        Close #m_iDiskNodeInChan
        iNodeChan = FreeFile()
        Close #iNodeChan: Open m_sDiskNodeFilePathName For Binary As #iNodeChan
        Seek #iNodeChan, m_dFileNodeOffset
        Put #iNodeChan, , sUpdateNodeLine
        Close #iNodeChan
        ' reopen node channel
        Close #m_iDiskNodeInChan: Open m_sDiskNodeFilePathName For Input As #m_iDiskNodeInChan
        
    End If

   On Error GoTo 0
   Exit Property

BSTNStore_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure BSTNStore of Class Module cBSTNStorage"
        
End Property


'---------------------------------------------------------------------------------------
' Procedure : GetDataNodeIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetDataNodeIndex(ByVal lpNodeIndex As Long) As Long
 Dim iMax As Integer
 Dim saFields() As String
 Dim lKeyRecord As Long
 Const icDataOffset = 5
   
Dim lpRecord As Long

lpRecord = 0
   On Error GoTo GetDataNodeIndex_Error
 
'    If m_bReadFromDiskFile = True Then 'data index is offset into file
'
'    End If
    
     'If m_bReadFromDiskFile = False Then
        If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
            GetDataNodeIndex = BSTNStore(lpNodeIndex, m_elNodeDataIndex)
        Else
            GetDataNodeIndex = -1
            Err.Raise vbObjectError + 39049, "", ""
            Exit Function
      '  End If
    End If

   On Error GoTo 0
   Exit Function

GetDataNodeIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetDataNodeIndex of Class Module cBSTNStorage"

End Function

'---------------------------------------------------------------------------------------
' Procedure : SetDataNodeIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function SetDataNodeIndex(ByVal lpNodeIndex As Long, ByVal lpObjectNodeIndex As Long) As Boolean

SetDataNodeIndex = False
    
    On Error GoTo SetDataNodeIndex_Error

    If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
        BSTNStore(lpNodeIndex, m_elNodeDataIndex) = lpObjectNodeIndex
    Else
        Err.Raise vbObjectError + 39049, "", ""
        Exit Function
    End If

SetDataNodeIndex = True

   On Error GoTo 0
   Exit Function

SetDataNodeIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure SetDataNodeIndex of Class Module cBSTNStorage"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetKeyAtNodeIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetKeyAtNodeIndex(ByVal lpNodeIndex As Long) As String
    
   On Error GoTo GetKeyAtNodeIndex_Error

    If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
        GetKeyAtNodeIndex = BSTNStore(lpNodeIndex, m_esNodeKey)
    Else
        Err.Raise vbObjectError + 39009, "GetKeyAtNodeIndex", "GetKeyAtNodeIndex"
        Exit Function
    End If

   On Error GoTo 0
   Exit Function

GetKeyAtNodeIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetKeyAtNodeIndex of Class Module cBSTNStorage"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetLeftNodeOfIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetLeftNodeOfIndex(ByVal lpNodeIndex As Long) As Long

   On Error GoTo GetLeftNodeOfIndex_Error

    If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
        GetLeftNodeOfIndex = BSTNStore(lpNodeIndex, m_elLeft)
    Else
        Err.Raise vbObjectError + 39041, "GetLeftNodeOfIndex", "GetLeftNodeOfIndex"
        Exit Function
    End If

   On Error GoTo 0
   Exit Function

GetLeftNodeOfIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetLeftNodeOfIndex of Class Module cBSTNStorage"

End Function

'---------------------------------------------------------------------------------------
' Procedure : GetRightNodeOfIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetRightNodeOfIndex(ByVal lpNodeIndex As Long) As Long
    
   On Error GoTo GetRightNodeOfIndex_Error

    If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
        GetRightNodeOfIndex = BSTNStore(lpNodeIndex, m_elRight)
    Else
        Err.Raise vbObjectError + 39049, "GetRightNodeOfIndex", "GetRightNodeOfIndex"
        Exit Function
    End If

   On Error GoTo 0
   Exit Function

GetRightNodeOfIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetRightNodeOfIndex of Class Module cBSTNStorage"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetParentNodeOfIndex
' DateTime  : 25/04/2005 19:32
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetParentNodeOfIndex(ByVal lpNodeIndex As Long) As Long

   On Error GoTo GetParentNodeOfIndex_Error

    If (lpNodeIndex >= 0) And (lpNodeIndex <= GetNodesMaxIndex()) Then
        GetParentNodeOfIndex = BSTNStore(lpNodeIndex, m_elParent)
    Else
        Err.Raise vbObjectError + 39043, "GetParentNodeOfIndex", "GetParentNodeOfIndex"
        Exit Function
    End If

   On Error GoTo 0
   Exit Function

GetParentNodeOfIndex_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetParentNodeOfIndex of Class Module cBSTNStorage"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetNodesMaxIndex
' DateTime  : 25/04/2005 19:33
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetNodesMaxIndex() As Long
' virtualise
    'GetNodesMaxIndex = UBound(BSTNStore())
    GetNodesMaxIndex = UBound(m_utBSTNStore())
End Function


'---------------------------------------------------------------------------------------
' Procedure : Clear
' DateTime  : 18/04/2005 08:17
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function Clear()

   On Error GoTo Clear_Error

    'ReDim BSTNStore(0)  'virtualise
    ReDim m_utBSTNStore(0)
     
    BSTNStore(0, m_elParent) = m_cNoLink
    BSTNStore(0, m_elLeft) = m_cNoLink
    BSTNStore(0, m_elRight) = m_cNoLink
    BSTNStore(0, m_esNodeKey) = m_sGarbageIdentityKey

    m_lRemovedNodesCount = 0

   On Error GoTo 0
   Exit Function

Clear_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure Clear of Class Module cBSTNStorage"

End Function


'---------------------------------------------------------------------------------------
' Procedure : InitRootNode
' DateTime  : 18/04/2005 08:17
' Author    : D K Richmond
' Purpose   :
' BUG FIX   : add optional lpdataindex to allow rebalance to keep the new root key dataindex
'---------------------------------------------------------------------------------------
'
Public Function InitRootNode(ByVal spNodeKey As String, Optional ByVal lpDataIndex As Variant)

   On Error GoTo InitRootNode_Error

    'ReDim BSTNStore(0)  'virtualise
    ReDim m_utBSTNStore(0)
    
    BSTNStore(0, m_elParent) = m_cNoLink
    BSTNStore(0, m_elLeft) = m_cNoLink
    BSTNStore(0, m_elRight) = m_cNoLink
    BSTNStore(0, m_esNodeKey) = spNodeKey
' BUG FIX   : add optional lpdataindex to allow rebalance to keep the new root key dataindex
    If IsMissing(lpDataIndex) Then
        BSTNStore(0, m_elNodeDataIndex) = -1
    Else
        BSTNStore(0, m_elNodeDataIndex) = lpDataIndex
    End If
    m_lRemovedNodesCount = 0

   On Error GoTo 0
   Exit Function

InitRootNode_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure InitRootNode of Class Module cBSTNStorage"

End Function

'---------------------------------------------------------------------------------------
' Procedure : InitNodeTree
' DateTime  : 25/04/2005 19:33
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
'Public Function InitNodeTree(ByVal spNodeKey As String)
'
'    ReDim BSTNStore(0)
'
'    BSTNStore(0,m_elParent) = m_cNoLink
'    BSTNStore(0,m_elLeft) = m_cNoLink
'    BSTNStore(0,m_elRight) = m_cNoLink
'    BSTNStore(0,m_esNodeKey) = ""
'BSTNStore(0,m_elNodeDataIndex) = -1
'
'End Function


'---------------------------------------------------------------------------------------
' Procedure : GetTraverseTextForOpcode
' DateTime  : 17/04/2005 10:12
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetTraverseTextForOpcode(ByVal ipTraverseOpCode As Integer) As String
 Dim sOPeration As String
 
    Select Case ipTraverseOpCode
        Case TraverseOpCodes.m_eiGoFarLeft:
            sOPeration = m_csGoFarLeft
        Case TraverseOpCodes.m_eiGoRight:
            sOPeration = m_csGoRight
        Case TraverseOpCodes.m_eiGoUpVisit:
            sOPeration = m_csGoUpVisit
        Case TraverseOpCodes.m_egiGoUp:
            sOPeration = m_csiGoUp
        Case TraverseOpCodes.m_eiTopofTree:
            sOPeration = m_csTopofTree
        Case Else
            sOPeration = "?? unknown ??"
     End Select

GetTraverseTextForOpcode = sOPeration
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetNextNodeInSortedOrder
' DateTime  : 17/04/2005 10:01
' Author    : D K Richmond
' Purpose   :
' Notes     : pass thru detects when the node traversal ascends thru a specific node and sets flag
'---------------------------------------------------------------------------------------
'
Public Function GetNextNodeInSortedOrder(ByRef lpNextNode As Long, Optional ByRef lpoCurrentNode As Long = -1, Optional ByRef ipoOperation As Integer = m_eiUNKNOWN, Optional bpoPassThru As Boolean, Optional lpoPassThruNode As Long = -1) As Boolean
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim bMoved As Boolean
 
 GetNextNodeInSortedOrder = False
 
   On Error GoTo GetNextNodeInSortedOrder_Error

    ' @node
    'IF LEFT exist
    '    GO FAR LEFT
    '    next op is go right
    'End If
    '
    'if NOT LEFT exist
    '    if RIGHT exist
    '        GO RIGHT ONE
    '        GO FAR LEFT
    '    End If
    '    ' no left or right
    '    if NOT RIGHT exist
    '        go up
    '        if ascend from right i.e if parent's right is same as current
    '            go up
    '        End If
    '        if ascend from left i.e if parent's left is same as current
    '            at Node
    '        End If
    '    End If
    'End If

    If lpoCurrentNode <> -1 Then
        m_lCurrentNode = lpoCurrentNode
    End If
    If ipoOperation <> m_eiUNKNOWN Then
        m_iOperation = ipoOperation
    End If
    
    bpoPassThru = False
    lpNextNode = m_lCurrentNode
    bMoved = False
    If (m_iOperation = TraverseOpCodes.m_eiGoFarLeft) Then
        Do
            lLeftNode = BSTNStore(lpNextNode, m_elLeft)
            If (lLeftNode = m_cNoLink) Then
                Exit Do
            Else
                lpNextNode = lLeftNode
            End If
            If (lpoPassThruNode = lpNextNode) Then
                bpoPassThru = True
            End If
            m_lNodeLevel = m_lNodeLevel + 1
            m_lOffsetLeft = m_lOffsetLeft + 1
            m_lOffsetRight = m_lOffsetRight - 1
            bMoved = True
        Loop
        If (bMoved = True) Then
            lRightNode = BSTNStore(lpNextNode, m_elRight)
            If (lRightNode <> m_cNoLink) Then
                m_iOperation = TraverseOpCodes.m_eiGoRight
            Else
                m_iOperation = TraverseOpCodes.m_egiGoUp
            End If
            m_lNodeLevel = m_lNodeLevel + 1
            m_lCurrentNode = lpNextNode
            GetNextNodeInSortedOrder = bMoved
            Exit Function
        Else
            m_iOperation = TraverseOpCodes.m_eiGoRight
            m_lCurrentNode = lpNextNode
            GetNextNodeInSortedOrder = True
            Exit Function
        End If
    End If
    
    'DEBUG
    Debug.Print "GNISO Key: " & BSTNStore(m_lCurrentNode, m_esNodeKey); ""
    
    If (m_iOperation = TraverseOpCodes.m_eiGoRight) Then
        lRightNode = BSTNStore(m_lCurrentNode, m_elRight)
        If (lRightNode <> m_cNoLink) Then
            lpNextNode = lRightNode
            If (lpoPassThruNode = lpNextNode) Then
                bpoPassThru = True
            End If
            bMoved = True
            m_lNodeLevel = m_lNodeLevel + 1
            m_lOffsetRight = m_lOffsetRight + 1
            m_lOffsetLeft = m_lOffsetLeft - 1
            Do  'GOFARLEFT
                lLeftNode = BSTNStore(lpNextNode, m_elLeft)
                If (lLeftNode = m_cNoLink) Then
                    Exit Do
                End If
                lpNextNode = lLeftNode
                If (lpoPassThruNode = lpNextNode) Then
                    bpoPassThru = True
                End If
                m_lNodeLevel = m_lNodeLevel + 1
                m_lOffsetLeft = m_lOffsetLeft + 1
                m_lOffsetRight = m_lOffsetRight - 1
                bMoved = True
            Loop
            If bMoved = True Then
                lRightNode = BSTNStore(lpNextNode, m_elRight)
                If (lRightNode <> m_cNoLink) Then
                    m_iOperation = TraverseOpCodes.m_eiGoRight
                Else
                    m_iOperation = TraverseOpCodes.m_egiGoUp
                End If
                m_lCurrentNode = lpNextNode
                GetNextNodeInSortedOrder = bMoved
                Exit Function
            Else
                 m_iOperation = TraverseOpCodes.m_egiGoUp
            End If
            m_lCurrentNode = lpNextNode
            GetNextNodeInSortedOrder = bMoved
            Exit Function
         Else
            m_iOperation = TraverseOpCodes.m_egiGoUp
        End If
     End If
     
    If (m_iOperation = TraverseOpCodes.m_egiGoUp) Then
        lParentNode = BSTNStore(m_lCurrentNode, m_elParent)
        If (lParentNode <> m_cNoLink) Then
            m_lNodeLevel = m_lNodeLevel - 1
            Do
                If BSTNStore(lParentNode, m_elParent) = m_cNoLink Then
                   ' MsgBox "eek!"
                    'Err.Raise vbobjecterror +940945, "", ""
                    'Exit Function
                    ValidateTree  ' DEBUG
                End If
                If BSTNStore(lParentNode, m_elRight) = m_lCurrentNode Then
                    m_lOffsetRight = m_lOffsetRight - 1
                    m_lOffsetLeft = m_lOffsetLeft + 1
                    ' ascending don't show node
                    m_lCurrentNode = lParentNode
                    If (lpoPassThruNode = m_lCurrentNode) Then
                        bpoPassThru = True
                    End If
                    lParentNode = BSTNStore(m_lCurrentNode, m_elParent)
                    If (lParentNode = m_cNoLink) Then
                        m_iOperation = TraverseOpCodes.m_eiTopofTree
                        lpNextNode = 0
                        m_lCurrentNode = lpNextNode
                        GetNextNodeInSortedOrder = False
                        Exit Function
                    Else
                        m_lNodeLevel = m_lNodeLevel - 1
                    End If
                Else
                    If BSTNStore(lParentNode, m_elLeft) = m_lCurrentNode Then
                        m_lOffsetLeft = m_lOffsetLeft - 1
                        m_lOffsetRight = m_lOffsetRight + 1
                        ' ascending show node
                        m_lCurrentNode = lParentNode
                        lpNextNode = lParentNode
                        If lpoPassThruNode = lpNextNode Then
                            bpoPassThru = True
                        End If
                        bMoved = True
                        m_iOperation = TraverseOpCodes.m_eiGoRight
                        m_lCurrentNode = lpNextNode
                        GetNextNodeInSortedOrder = bMoved
                        Exit Function
                    End If
                End If
            Loop
        Else
            m_iOperation = TraverseOpCodes.m_eiTopofTree
        End If
    End If

GetNextNodeInSortedOrder = bMoved

   On Error GoTo 0
   Exit Function

GetNextNodeInSortedOrder_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetNextNodeInSortedOrder of Class Module cBSTNStorage"
End Function


'---------------------------------------------------------------------------------------
' Procedure : GetNextAllocationNode
' DateTime  : 17/04/2005 10:01
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Function GetNextAllocationNode() As Long
 Dim saFields() As String
 Dim sKeyHeaderLine As String
 
    ' virtualise
    'GetNextAllocationNode = UBound(BSTNStore) + 1
    If (m_bReadFromDiskFile = False) Then
        GetNextAllocationNode = UBound(m_utBSTNStore) + 1
    Else
         Seek #m_iDiskKeyChan, 1
         Line Input #m_iDiskKeyChan, sKeyHeaderLine
         saFields() = Split(sKeyHeaderLine, m_scNodeFieldDelimeter)
         GetNextAllocationNode = Val(saFields(0)) ' +1 causes problems with Add Media '+ 1
    End If

End Function


'---------------------------------------------------------------------------------------
' Procedure : SearchBSTN
' DateTime  : 17/04/2005 10:01
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function SearchBSTN(ByVal spKey As String, ByRef lpVisitedNode As Long, Optional ByVal lpCurrentNode As Long = 0) As Boolean
 Dim bNodeFound As Boolean
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim sKey As String
 
    m_lNodeHitsCount = m_lNodeHitsCount + 1
 
    bNodeFound = False  ' default result is not found
    
    If (lpCurrentNode = m_cNoLink) Then
        SearchBSTN = False
        Exit Function
    End If
    
    lpVisitedNode = lpCurrentNode
    
    sKey = BSTNStore(lpCurrentNode, m_esNodeKey)
    
    If (m_cbLexical = True) Then
        sKey = UCase(sKey)
        spKey = UCase(spKey)
    End If
    
    If (spKey = sKey) Then
        ' yes key found
        bNodeFound = True
    End If
    If (spKey < sKey) Then
        ' check left branch
        lLeftNode = BSTNStore(lpCurrentNode, m_elLeft)
        If (lLeftNode <> m_cNoLink) Then
            bNodeFound = SearchBSTN(spKey, lpVisitedNode, lLeftNode)
        Else
            Exit Function
        End If
    End If
    If (spKey > sKey) Then
        ' check right branch
        lRightNode = BSTNStore(lpCurrentNode, m_elRight)
        If (lRightNode <> m_cNoLink) Then
            bNodeFound = SearchBSTN(spKey, lpVisitedNode, lRightNode)
        Else
            Exit Function
        End If
    End If

SearchBSTN = bNodeFound
End Function


'---------------------------------------------------------------------------------------
' Procedure : Class_Initialize
' DateTime  : 17/04/2005 10:18
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub Class_Initialize()

    gbDebug = False   '  change this to true to see lots of debug message boxes
    
    m_sGarbageIdentityKey = String(5, Chr(128) & Chr(127))
    
    InitRootNode m_sGarbageIdentityKey
    
    m_lRemovedNodesCount = 0
    
' reset to default disk file params
    m_bReadFromDiskFile = False
    m_sDiskFileName = ""
    m_iDiskNodeInChan = -1
    m_iRecordLen = Len(m_scRecordStructMask) + Len(vbCrLf)
    ' just for now set to standard -allow changes by user after testing
    m_sDataFieldDelimeter = "|"
    
End Sub


Public Function ResetToRootNode() As Boolean

    ' reset counters, trackers.
    m_lOffsetLeft = 0
    m_lOffsetRight = 0
    m_lNodeLevel = 0
    
    ' reset traversal params
    m_lCurrentNode = 0
    m_iOperation = TraverseOpCodes.m_eiGoFarLeft

ResetToRootNode = True
End Function


'---------------------------------------------------------------------------------------
' Procedure : InsertBSTN
' DateTime  : 17/04/2005 11:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------

' optional lpoAllocatedNode is temporary for compatibility

Public Function InsertBSTN(ByVal spKey As String, Optional ByRef lpoAllocatedNode) As Boolean
 Dim sKey As String
 Dim bNodeFound As Boolean
 Dim lVisitedNode As Long
 Dim sVisited As String
 Dim sAllocated As String
 Dim bOk As Boolean
 
    InsertBSTN = False
    lpoAllocatedNode = -1
    m_lNodeHitsCount = 0
 
    If BSTNStore(0, m_esNodeKey) = m_sGarbageIdentityKey Then
        MsgBox "Tree is empty going to replace root node with " & spKey
        BSTNStore(0, m_esNodeKey) = spKey
        InsertBSTN = True
        lpoAllocatedNode = 0
        Exit Function
    End If
    
    bNodeFound = SearchBSTN(spKey, lVisitedNode)

    ' prevent duplicates for now
    If (bNodeFound = False) Then
        lpoAllocatedNode = GetNextAllocationNode()
        
        'ReDim Preserve BSTNStore(lpoAllocatedNode) 'virtualise

        ' resize node library via disk file options
        ' this will add a dummy line of n fields to bsd
        bOk = Resize_BSTNStore(lpoAllocatedNode)
        'ReDim Preserve m_utBSTNStore(lpoAllocatedNode)
        If (bOk = False) Then
            MsgBox "failed to resize BSTN store"
            Err.Raise 39403940 + 3040930, "", ""
            Exit Function
        End If
                
        BSTNStore(lpoAllocatedNode, m_esNodeKey) = spKey
        
        sAllocated = BSTNStore(lpoAllocatedNode, m_esNodeKey)
        sVisited = BSTNStore(lVisitedNode, m_esNodeKey)
        If (m_cbLexical = True) Then
            sAllocated = UCase(sAllocated)
            sVisited = UCase(sVisited)
        End If

        ' traversals must end on a leaf of some kind so this is valid
        ' no checking of m_cNoLink required.
        If (sAllocated < sVisited) Then
            BSTNStore(lVisitedNode, m_elLeft) = lpoAllocatedNode
        Else
            BSTNStore(lVisitedNode, m_elRight) = lpoAllocatedNode
        End If
        
        BSTNStore(lpoAllocatedNode, m_elParent) = lVisitedNode
        BSTNStore(lpoAllocatedNode, m_elLeft) = m_cNoLink
        BSTNStore(lpoAllocatedNode, m_elRight) = m_cNoLink
        BSTNStore(lpoAllocatedNode, m_elNodeDataIndex) = m_cNoLink
        InsertBSTN = True

    End If
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : ReleaseRootNode
' DateTime  : 17/04/2005 13:37
' Author    : D K Richmond
' Purpose   : used to release the root node prior to node removal
'---------------------------------------------------------------------------------------
'
Public Function ReleaseRootNode() As Boolean
 Dim ListX As cList
 Dim lNextNode As Long
 Dim iOperation As Integer
 Dim sKey As String
 Dim sOPeration As String
 Dim lIndex As Long
 Dim lMax As Long
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim sRebalanceKey As String
 Dim sRootNodeKey As String
 Dim iRandom As Integer
 Dim bOk As Boolean
 Dim lDataIndex As Long
 
ReleaseRootNode = False
 
    Set ListX = New cList
    
    ' use list to rebuild keys held in the tree one side of root node key
    ListX.Clear
 
    lParentNode = GetParentNodeOfIndex(0)
    lLeftNode = GetLeftNodeOfIndex(0)
    lRightNode = GetRightNodeOfIndex(0)
    sRootNodeKey = GetKeyAtNodeIndex(0)
    sRebalanceKey = ""  ' if fails nothing happens

    If (lLeftNode = m_cNoLink) And (lRightNode <> m_cNoLink) Then
        ' rebalance on right
        sRebalanceKey = GetKeyAtNodeIndex(lRightNode)
        lDataIndex = GetDataNodeIndex(lRightNode)
    End If
    If (lLeftNode <> m_cNoLink) And (lRightNode = m_cNoLink) Then
        ' rebalance on left
        sRebalanceKey = GetKeyAtNodeIndex(lLeftNode)
        lDataIndex = GetDataNodeIndex(lLeftNode)
    End If
    If (lLeftNode <> m_cNoLink) And (lRightNode <> m_cNoLink) Then
        iRandom = Int(Rnd(1) * 2)
        If (iRandom \ 1) = 1 Then
            sRebalanceKey = GetKeyAtNodeIndex(lLeftNode)
            lDataIndex = GetDataNodeIndex(lLeftNode)
        Else
            sRebalanceKey = GetKeyAtNodeIndex(lRightNode)
            lDataIndex = GetDataNodeIndex(lRightNode)
        End If
    End If
    
    bOk = RebalanceTree(sRebalanceKey, False, lDataIndex)
    
    If bOk = False Then
        MsgBox "Problem with Rebalance in ReleaseRoot Node", vbCritical
        Err.Raise vbObjectError + 4054095, "", ""
    End If
    
ReleaseRootNode = bOk
End Function

'---------------------------------------------------------------------------------------
' Procedure : WhatGarbage
' DateTime  : 17/04/2005 20:31
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
' notes: 'there is a time penalty for each time to call this if dynamic used
Public Function WhatGarbage(ByVal bAutoGarbageCollect As Boolean, Optional ByVal bDynamic As Boolean = False) As Double
Dim lMax As Long
Dim lIndex As Long
Dim lCount As Long
Dim dPercentGarbage As Double
Dim bOk As Boolean

    lMax = GetNodesMaxIndex()
    If (bDynamic = True) Then
        lCount = 0
        For lIndex = 0 To lMax
            If GetKeyAtNodeIndex(lIndex) = m_sGarbageIdentityKey Then
                lCount = lCount + 1
            End If
        Next
    Else
        lCount = m_lRemovedNodesCount
    End If
    
    If (lCount > 0) And (lMax > 0) Then
        dPercentGarbage = lCount / lMax * 100
    Else
        dPercentGarbage = 0
    End If
    
    If (dPercentGarbage > m_cgiGarbageThresholdPercentage) Then
        If (bAutoGarbageCollect = True) Then
            MsgBox "Garbage Collection Activated G%=" & dPercentGarbage & " >  GMAX%=" & m_cgiGarbageThresholdPercentage
            bOk = RebalanceTree()
            If (bOk = False) Then
                MsgBox "Garbage Collection Failed!"
                Err.Raise vbObjectError + 3490394, "", ""
            End If
        End If
    End If

WhatGarbage = dPercentGarbage
End Function

'---------------------------------------------------------------------------------------
' Procedure : RebalanceRootNode
' DateTime  : 17/04/2005 20:36
' Author    : D K Richmond
' Purpose   : Used to rebalance the tree around a central key value - may promote a need
'               to call Garbage Collection
' Notes     : uses pseudo non-gui list class
'
' BUG FIX   : add optional lpdataindex to allow rebalance to keep the new root key dataindex
' NOTE: if around middle is used the local lpdataindex is recalculated else the data index passed is used
'         for the new root node
'---------------------------------------------------------------------------------------
'
Public Function RebalanceTree(Optional ByVal spKey As String, Optional ByVal bpoAroundMiddle As Boolean = False, Optional lpoDataIndex As Long) As Boolean
 Dim lAllocatedNode As Long
 Dim lNextNode As Long
 Dim sKey As String
 Dim lIndex As Long
 Dim lMax As Long
 Dim sRebalanceKey As String
 Dim lRebalanceDataIndex As Long
 Dim sNodeKey As String
 Dim lNodeCount As Long
 Dim lNodesMiddle As Long
 Dim List4 As cList
 Dim List6 As cList
 Dim bOk As Boolean

RebalanceTree = False

    If spKey = "" Then
        sNodeKey = GetKeyAtNodeIndex(0)
    Else
        sNodeKey = spKey
    End If
    
    If (sNodeKey <> m_sGarbageIdentityKey) Then
        sRebalanceKey = sNodeKey
        lRebalanceDataIndex = lpoDataIndex
    Else
        MsgBox "Tree is empty!", vbCritical
        Exit Function
    End If
    
    Set List4 = New cList
    Set List6 = New cList
    ' use list to rebuild keys held in the tree one side of root node key
    List4.Clear
    List6.Clear
    
    lNodeCount = 0
    lNodesMiddle = CLng((GetNodesMaxIndex() + 1) / 2)
    ResetToRootNode
    Do
        If GetNextNodeInSortedOrder(lNextNode) = True Then
            Debug.Print String(40, "-")
            Debug.Print "SO_BSTN[" & lNextNode & "] P=" & GetParentNodeOfIndex(lNextNode)
            Debug.Print "SO_BSTN[" & lNextNode & "] L=" & GetLeftNodeOfIndex(lNextNode)
            Debug.Print "SO_BSTN[" & lNextNode & "] R=" & GetRightNodeOfIndex(lNextNode)
            Debug.Print "SO_BSTN[" & lNextNode & "] C**=" & GetKeyAtNodeIndex(lNextNode)
            Debug.Print String(40, "=")
        Else
            Exit Do
        End If
        If (TopOfTreeReached = False) Then
            sKey = GetKeyAtNodeIndex(lNextNode)
            List4.AddItem sKey
            List6.AddItem BSTNStore(lNextNode, m_elNodeDataIndex)
            lNodeCount = lNodeCount + 1
            If bpoAroundMiddle = True Then
                If lNodeCount >= lNodesMiddle Then
                    sRebalanceKey = sKey
                    lRebalanceDataIndex = BSTNStore(lNextNode, m_elNodeDataIndex)
                    bpoAroundMiddle = False
                End If
            End If
        End If
        If (TopOfTreeReached = True) Then
            Exit Do
        End If
    Loop
    
    Debug.Print String(40, "*")
    
    lMax = List4.ListCount - 1
    For lIndex = 0 To lMax
        Debug.Print "SO_BSTN[" & lIndex & "] C**=" & GetKeyAtNodeIndex(lIndex)
    Next
    Debug.Print String(40, "=")
    Debug.Print "SO_BSTN Root [" & 0 & "] C**=" & sNodeKey
    
    If sRebalanceKey = "" Then
        InitRootNode m_sGarbageIdentityKey
        MsgBox "Tree is empty", vbInformation
        'Err.Raise vbobjecterror + 3490394, "RootNodeKey null error!", ""
        Exit Function
    End If
    
    InitRootNode sRebalanceKey
' BUG FIX   : add optional lpdataindex to allow rebalance to keep the new root key dataindex
    ' preserve the data index - root is always node 0
    ' index is passed or set from middle item
    SetDataNodeIndex 0, lRebalanceDataIndex

    ' needs to rebuild randomly in order to have a reasonable tree shape else all left or right nodes
    While (List4.ListCount > 0)  ' allow for rebalance key
        lIndex = Int(Rnd(1) * (List4.ListCount - 1))
        sKey = List4.List(lIndex)
        If sKey <> sRebalanceKey Then
            Debug.Print "Replay Key: " & sKey
            bOk = InsertBSTN(sKey, lAllocatedNode)
            If (bOk = False) Then
                MsgBox "Failed to replay key : " & sKey & " DATASTORE CORRUPTED!"
                Err.Raise vbObjectError + 9393390, "", ""
                Exit Function
            Else
                BSTNStore(lAllocatedNode, m_elNodeDataIndex) = CLng(List6.List(lIndex))
                List4.RemoveItem lIndex
                List6.RemoveItem lIndex
            End If
        Else
            List4.RemoveItem lIndex
            List6.RemoveItem lIndex
        End If
    Wend
    
    
Set List4 = Nothing
Set List6 = Nothing
RebalanceTree = True
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetPrevNodeInSortedOrder
' DateTime  : 25/04/2005 20:48
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetPrevNodeInSortedOrder(ByVal spKey As String, ByRef lpVisitedNode As Long, ByRef spVisitedKey As String) As Boolean
 Dim lCurrentNode As Long
 Dim lNextNode As Long
 Dim sKey As String
 Dim bOk As Boolean
 Dim lLeftNode As Long
 Dim sOrgKey As String
 Dim lParentNode As Long
 Dim lRightNode As Long
 Dim bNodeFound As Boolean
 Dim bPassThru As Boolean
 Dim lPassThru As Long
 Dim bLeftie As Boolean
 
 GetPrevNodeInSortedOrder = False
 
    spVisitedKey = ""
    lpVisitedNode = -1
       
    sOrgKey = spKey

    bOk = SearchBSTN(sOrgKey, lCurrentNode)
    If (bOk = False) Then
        Exit Function
    End If
    
    lPassThru = lCurrentNode
    bNodeFound = False
    ' first find a parent that is a right node of current
    bLeftie = False
    
    lLeftNode = GetLeftNodeOfIndex(lCurrentNode)
    If (lLeftNode <> m_cNoLink) Then
        MsgBox "leftdec!"
        lCurrentNode = lLeftNode
        bNodeFound = GetNextNodeInSortedOrder(lNextNode, lCurrentNode, m_eiGoFarLeft, bPassThru, lPassThru)  ' GOFARLEFT
    Else
        Do
            lParentNode = GetParentNodeOfIndex(lCurrentNode)
            Debug.Print "SO_BTNS[" & lCurrentNode & "] C**=" & GetKeyAtNodeIndex(lCurrentNode)
                
            If (lParentNode = m_cNoLink) Then
                MsgBox "no parent!"
                Exit Do
            End If
            
            lLeftNode = GetLeftNodeOfIndex(lParentNode)
            If (lLeftNode = lCurrentNode) Then
                ' ascended to a right parent
                MsgBox "ascended to a right parent"
                lCurrentNode = lParentNode
            End If
            lRightNode = GetRightNodeOfIndex(lParentNode)
            If (lRightNode = lCurrentNode) Then
                ' ascended to a left parent
                bLeftie = True
                MsgBox "ascended to a right parent"
            End If
            
            Debug.Print "SOP_BTNS[" & lCurrentNode & "] C**=" & GetKeyAtNodeIndex(lParentNode)
          
            If (bLeftie = True) Then
                    lCurrentNode = lParentNode
                    bNodeFound = GetNextNodeInSortedOrder(lNextNode, lCurrentNode, m_eiGoFarLeft, bPassThru, lPassThru)  ' GOFARLEFT
                    Exit Do
            End If
        Loop
    End If
    
    If (bNodeFound = False) Then
        MsgBox "start of alpha list"
        Exit Function
    End If
    
    Do
        If (bPassThru = True) Then
            Exit Do
        End If
        
        If bNodeFound = True Then
            Debug.Print String(40, "-")
            Debug.Print "SO_BTNS[" & lNextNode & "] P=" & GetParentNodeOfIndex(lNextNode)
            Debug.Print "SO_BTNS[" & lNextNode & "] L=" & GetLeftNodeOfIndex(lNextNode)
            Debug.Print "SO_BTNS[" & lNextNode & "] R=" & GetRightNodeOfIndex(lNextNode)
            Debug.Print "SO_BTNS[" & lNextNode & "] C**=" & GetKeyAtNodeIndex(lNextNode)
            Debug.Print String(40, "=")
        Else
            Exit Do
        End If
        
        If (TopOfTreeReached = False) Then
            sKey = GetKeyAtNodeIndex(lNextNode)
        End If
     
        bNodeFound = GetNextNodeInSortedOrder(lNextNode, bpoPassThru:=bPassThru, lpoPassThruNode:=lPassThru)
        
    Loop
  

MsgBox "Previous from : " & sOrgKey & " is " & sKey
 

lpVisitedNode = lCurrentNode
spVisitedKey = GetKeyAtNodeIndex(lpVisitedNode)  'sKey
GetPrevNodeInSortedOrder = True
End Function

'------------------------------------------
' -- Function: GetNodeType
' -- Desc    : determine from parent and current details if node is left,right or parent
' -- Passed  :
' -- Uses    :
' -- Calls   : other functions
' -- Returns : LEFT,RIGHT OR PARENT type node
' -- DateTime: Org-19:54 22/05/00
'------------------------------------------
Function GetNodeType(ByVal lpCurrentNode As Long) As Integer
 Dim lRightNode As Long
 Dim lParentNode  As Long
 Dim lLeftNode As Long
 Dim lCurrentNode As Long
 
    lCurrentNode = lpCurrentNode
    
    ' to find out what type of node we are on we need to interogate the parent node
    ' check the value of the right and left node with current node
    GetNodeType = m_ePNodeType  ' default with no siblings
    lParentNode = GetParentNodeOfIndex(lpCurrentNode)
    If lParentNode <> m_cNoLink Then
        lLeftNode = GetLeftNodeOfIndex(lParentNode)
        If (lCurrentNode = lLeftNode) Then
            GetNodeType = m_eLNodeType
        End If
        ' only really need to do this if no left node found
        lRightNode = GetRightNodeOfIndex(lParentNode)
        If (lCurrentNode = lRightNode) Then
            GetNodeType = m_eRNodeType
        End If
    End If
End Function


'---------------------------------------------------------------------------------------
' Procedure : CompKeys
' DateTime  : 20/04/2005 13:18
' Author    : D K Richmond
' Purpose   : use this for all key comparisons as it allow for lexical or non-lexical
'---------------------------------------------------------------------------------------
'
Public Function CompareKeys(ByVal spKey1 As String, spKey2 As String) As Integer

    ' if key1 < key 2 return -1
    ' if key1 = key 2 return 0
    ' if key1 > key 2 return +1

    If (m_cbLexical = True) Then
        spKey1 = UCase(spKey1)
        spKey2 = UCase(spKey2)
    End If
    
    If (spKey1 = spKey2) Then
        CompareKeys = 0
    End If
    If (spKey1 < spKey2) Then
        CompareKeys = -1
    End If
    If (spKey1 > spKey2) Then
        CompareKeys = 1
    End If
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : RemoveNode
' DateTime  : 25/04/2005 20:20
' Author    : D K Richmond
' Purpose   : remove a node whether left, right or both sub branches, calls
'   RemoveNodeLeftOrRightOnly to deal with nodes with two sub branches
'    as well as ones with either left or right nodes
'---------------------------------------------------------------------------------------
'
Public Function RemoveNode(ByVal spKey As String) As Boolean
 Dim lCurrentNode As Long
 Dim bOk As Boolean
 Dim iOperation As Integer
 Dim sOrgKey As String
 Dim sPrevKey As String
 Dim bFound As Boolean
 Dim sHighestKey As String
 Dim lOtherNode As Long
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim sKey As String
 Dim lNextNode As Long
 Dim bNodeFound As Boolean
 Dim sLastkeyVisited As String
 Dim sNextKey As String
 Dim sCurrentKey As String
 Dim sOtherKey As String
 Dim iR As Integer
 
 ' check if root node is target for deletion and if so release it
 ' this rebalances the tree and hence the root node will have moved
 ' this means a new search .. it may end up as a leaf or a node with
 ' two sub branches
 ' check the target node for deletion has one, or two branches
 ' if it has two then .. then we need to move a node into it's position
 ' Search down the first left then all right or first right then all left
 ' randomly choose the left or the right to try not to unbalance the tree.
  
RemoveNode = False
                
    sKey = spKey
    bOk = SearchBSTN(sKey, lCurrentNode)
                
    If lCurrentNode = 0 Then   'if root node.. rebalance means location moves
        MsgBox "Deletion or root node means rebalance"
        bOk = ReleaseRootNode()
        If (bOk = False) Then
            Exit Function
        Else
            bOk = SearchBSTN(sKey, lCurrentNode)
        End If
    End If

    sOrgKey = GetKeyAtNodeIndex(lCurrentNode)
    lLeftNode = GetLeftNodeOfIndex(lCurrentNode)
    lRightNode = GetRightNodeOfIndex(lCurrentNode)
    lOtherNode = lCurrentNode
    
    ' ############# check for deletion of node having two child branches #############
    bFound = False
    If (lLeftNode <> m_cNoLink) And (lRightNode <> m_cNoLink) Then

        If (gbDebug = True) Then
            MsgBox "has left and right branches", vbInformation
        End If
        If bOk = True Then
            ' find largest key lower than current
            If bOk = True Then
                bOk = GetPrevInSortedOrder(lCurrentNode, lNextNode)
                If (bOk = True) Then
                    sPrevKey = GetKeyAtNodeIndex(lNextNode)
                    'MsgBox "Previous of " & sKey & " is " & sPrevKey
                Else
                    MsgBox "Failed!"
                    Err.Raise vbObjectError + 93049404, "", ""
                    Exit Function
                End If
                If (gbDebug = True) Then
                    MsgBox "**Highest left leaf from : " & sOrgKey & " is " & sPrevKey, vbInformation
                End If
                Debug.Print "**Highest left leaf from : " & sOrgKey & " is " & sPrevKey, vbInformation
            End If
        Else
            MsgBox "Failed!"
            Err.Raise vbObjectError + 93049404, "", ""
            Exit Function
        End If
        
        'If bFound = False Then
        If (1 > 0) Then
            ' find smallest key higher than current
            sKey = spKey
            bOk = SearchBSTN(sKey, lCurrentNode)
            sCurrentKey = GetKeyAtNodeIndex(lCurrentNode)
            Debug.Print "CK: " & sCurrentKey
            If bOk = True Then
                bOk = GetNextInSortedOrder(lCurrentNode, lNextNode)
                If bOk = True Then
                    sNextKey = GetKeyAtNodeIndex(lNextNode)
                Else
                    MsgBox "Failed!"
                    Err.Raise vbObjectError + 93049404, "", ""
                    Exit Function
                End If
                'MsgBox "Next of " & sKey & " is " & sNextKey
            End If
    
            If gbDebug = True Then
                MsgBox "**Lowest right leaf from : " & sOrgKey & " is " & sNextKey, vbInformation
            End If
            Debug.Print "**Lowest right leaf from : " & sOrgKey & " is " & sNextKey, vbInformation
        Else
            MsgBox "Failed!"
        End If
        
        'randomly decide on left or right substitution on deleted node position
        iR = Int(Rnd(1) * 2)
        If (iR = 1) Then
            sOtherKey = sNextKey
            If gbDebug = True Then
                MsgBox "random right" & "Key: " & sOrgKey & " Moving " & sOtherKey
            End If
            Debug.Print "random right: " & "Key: " & sOrgKey & " Moving " & sOtherKey
        Else
            sOtherKey = sPrevKey
            If gbDebug = True Then
                MsgBox "random left" & "Key: " & sOrgKey & " Moving " & sOtherKey
            End If
            Debug.Print "random left: " & "Key: " & sOrgKey & " Moving " & sOtherKey
        End If
        
        ' because we found the largest left or the smallest right
        ' it CANNOT have two branches as one of them would have to be
        ' the key we are trying to delete.  Hence we only have to deal
        ' with one of the branches when we move the node to the current
        ' key node being deleted
        
        ' now get the node index for the other node
        ' #### this section is to cater for things as yet unknown
        '       so far nothing has been discovered and soon this will
        '         disappear   #################
        bOk = SearchBSTN(sOtherKey, lOtherNode)
        If bOk = False Then
            MsgBox "Failed!"
            Err.Raise vbObjectError + 93049404, "", ""
            Exit Function
        End If
            
        If lCurrentNode = lOtherNode Then
          MsgBox "no can do!"
          Exit Function
          Err.Raise vbObjectError + 3940349, "", ""
        End If

        If lCurrentNode = 0 Then
          MsgBox "no can do on root moving!"
          Exit Function
          Err.Raise vbObjectError + 3940349, "", ""
        End If

        If lOtherNode = 0 Then
          MsgBox "no can do on root!"
          Exit Function
          Err.Raise vbObjectError + 3940349, "", ""
      End If
    
      ' end section #################
        
      If gbDebug = True Then
        MsgBox "only check for either left or right branches for the moving node", vbInformation
      End If
      
      bOk = RemoveNodeLeftOrRightOnly(sOtherKey, lCurrentNode)
      If bOk = False Then
         MsgBox "failed to remove node to be moved!"
         Err.Raise vbObjectError + 30493, "", ""
      End If
    
      ' this moves the node from the chosen to the deleted node key
      '     L & R & P links remain the same
      BSTNStore(lCurrentNode, m_esNodeKey) = sOtherKey
      
      RemoveNode = True
    
    Else
        
        If gbDebug = True Then
            MsgBox "only check for either left or right branches", vbInformation
        End If
        
        bOk = RemoveNodeLeftOrRightOnly(sKey, lCurrentNode)
        
        If bOk = False Then
            MsgBox "failed to remove node to be moved!"
            Err.Raise vbObjectError + 30493, "", ""
        Else
            RemoveNode = True
        End If
End If

End Function

'---------------------------------------------------------------------------------------
' Procedure : RemoveNodeLeftOrRightOnly
' DateTime  : 25/04/2005 20:29
' Author    : D K Richmond
' Purpose   : private - only usually call from RemoveNode
'---------------------------------------------------------------------------------------
'
Private Function RemoveNodeLeftOrRightOnly(ByVal spKey As String, ByVal plCurrent As Long) As Boolean
 Dim lCurrentNode As Long
 Dim bOk As Boolean
 Dim sOrgKey As String
 Dim bFound As Boolean
 Dim lOtherNode As Long
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim sKey As String
 Dim sOtherKey As String

 ' check if node for removal is a left or right sub branch and act accordingly
 
RemoveNodeLeftOrRightOnly = False

    lCurrentNode = plCurrent
    sKey = spKey
    bOk = SearchBSTN(sKey, lCurrentNode)
                
    If lCurrentNode = 0 Then   'if root node.. rebalance means location moves
        MsgBox "Deletion or root node means rebalance"
        bOk = ReleaseRootNode
        If bOk = False Then
            Exit Function
        Else
            ' rescan to find current node that moved during re-balance
            bOk = SearchBSTN(sKey, lCurrentNode)
        End If
    End If

    sOrgKey = GetKeyAtNodeIndex(lCurrentNode)
    lLeftNode = GetLeftNodeOfIndex(lCurrentNode)
    lRightNode = GetRightNodeOfIndex(lCurrentNode)
    lOtherNode = lCurrentNode
    
    ' ############# check for deletion node having two child branches #############
    bFound = False
    If (lLeftNode <> m_cNoLink) And (lRightNode <> m_cNoLink) Then

        MsgBox "has left and right branches this routine is not used for those nodes !!", vbInformation
        Err.Raise vbObjectError + 3494, "", ""
        Exit Function
    End If
    
    If gbDebug = True Then
        MsgBox "only check for either left or right branches", vbInformation
    End If
        
    ' ############# check for deletion node having left child branches #############
    If (lLeftNode <> m_cNoLink) And (lRightNode = m_cNoLink) Then
        ' deletion of node with left branch
        ' NOTE: ORDER OF OPERATIONS CRITICAL
        ' if CP.Left is Cn then CP.Left = On   or..
        ' if CP.Right is Cn then CP.Right = On
        ' if OP <> m_cNoLink then OP = CP
        lOtherNode = lLeftNode
        ' sort out node we are trying to remove
        sKey = GetKeyAtNodeIndex(lOtherNode)  ' debug
        sKey = GetKeyAtNodeIndex(lCurrentNode) ' debug
        ' if CP.Left is Cn then CP.Left = On    or..
        ' if CP.Right is Cn then CP.Right = On
        lParentNode = BSTNStore(lCurrentNode, m_elParent)
        If lParentNode <> -1 Then Debug.Print "cP=" & GetKeyAtNodeIndex(lParentNode)
        If lParentNode <> m_cNoLink Then
            If BSTNStore(lParentNode, m_elLeft) = lCurrentNode Then
                BSTNStore(lParentNode, m_elLeft) = lOtherNode
            End If   ' or ...
            If BSTNStore(lParentNode, m_elRight) = lCurrentNode Then
                BSTNStore(lParentNode, m_elRight) = lOtherNode
            End If
            ' OP = CP
            BSTNStore(lOtherNode, m_elParent) = lParentNode
        End If
        
        BSTNStore(lCurrentNode, m_elLeft) = m_cNoLink ' reset n's left branch
        BSTNStore(lCurrentNode, m_elRight) = m_cNoLink  ' reset n's right branch
        BSTNStore(lCurrentNode, m_elParent) = m_cNoLink  ' reset n's parent
        BSTNStore(lCurrentNode, m_esNodeKey) = m_sGarbageIdentityKey ' reset n's key to empty
        
        RemoveNodeLeftOrRightOnly = True
      End If
      
      ' ############# check for deletion node having right child branches #############
      If (lLeftNode = m_cNoLink) And (lRightNode <> m_cNoLink) Then
            ' deletion of node with left branch
            ' NOTE: ORDER OF OPERATIONS CRITICAL
            ' if CP.Left is Cn then CP.Left = On   or..
            ' if CP.Right is Cn then CP.Right = On
            ' if OP <> m_cNoLink then OP = CP
            lOtherNode = lRightNode
            ' sort out node we are trying to remove
            sKey = GetKeyAtNodeIndex(lOtherNode)  ' debug
            sKey = GetKeyAtNodeIndex(lCurrentNode) ' debug
            ' if CP.Left is Cn then CP.Left = On    or..
            ' if CP.Right is Cn then CP.Right = On
            lParentNode = BSTNStore(lCurrentNode, m_elParent)
            If lParentNode <> m_cNoLink Then Debug.Print "cP=" & GetKeyAtNodeIndex(lParentNode)
            If lParentNode <> m_cNoLink Then
                If BSTNStore(lParentNode, m_elLeft) = lCurrentNode Then
                    BSTNStore(lParentNode, m_elLeft) = lOtherNode
                End If   ' or ...
                If BSTNStore(lParentNode, m_elRight) = lCurrentNode Then
                    BSTNStore(lParentNode, m_elRight) = lOtherNode
                End If
                ' OP = CP
                BSTNStore(lOtherNode, m_elParent) = lParentNode
            End If
            
            BSTNStore(lCurrentNode, m_elLeft) = m_cNoLink ' reset n's left branch
            BSTNStore(lCurrentNode, m_elRight) = m_cNoLink  ' reset n's right branch
            BSTNStore(lCurrentNode, m_elParent) = m_cNoLink  ' reset n's parent
            BSTNStore(lCurrentNode, m_esNodeKey) = m_sGarbageIdentityKey ' reset n's key to empty
            
            RemoveNodeLeftOrRightOnly = True
      End If
      
      ' ############# check for deletion node being a leaf #############
      If (lLeftNode = m_cNoLink) And (lRightNode = m_cNoLink) Then
            ' deletion of node with left branch
            ' NOTE: ORDER OF OPERATIONS CRITICAL
            ' if OP.Left is Cn then OP.Left = m_cNoLink    or..
            ' if OP.Right is Cn then OP.Right = m_cNoLink
            lOtherNode = BSTNStore(lCurrentNode, m_elParent)
            ' sort out node we are trying to remove
            If lOtherNode <> m_cNoLink Then sKey = GetKeyAtNodeIndex(lOtherNode)  ' debug
            If lOtherNode <> m_cNoLink Then sKey = GetKeyAtNodeIndex(lCurrentNode) ' debug
            ' if OP.Left is Cn then OP.Left = m_cNoLink    or..
            ' if OP.Right is Cn then OP.Right = m_cNoLink
            If lOtherNode <> m_cNoLink Then Debug.Print "cP=" & GetKeyAtNodeIndex(lParentNode)
            If lOtherNode <> m_cNoLink Then
                If BSTNStore(lOtherNode, m_elLeft) = lCurrentNode Then
                    BSTNStore(lOtherNode, m_elLeft) = m_cNoLink
                End If   ' or ...
                If BSTNStore(lOtherNode, m_elRight) = lCurrentNode Then
                    BSTNStore(lOtherNode, m_elRight) = m_cNoLink
                End If
            End If
            
            BSTNStore(lCurrentNode, m_elLeft) = m_cNoLink ' reset n's left branch
            BSTNStore(lCurrentNode, m_elRight) = m_cNoLink  ' reset n's right branch
            BSTNStore(lCurrentNode, m_elParent) = m_cNoLink  ' reset n's parent
            BSTNStore(lCurrentNode, m_esNodeKey) = m_sGarbageIdentityKey ' reset n's key to empty
            
            RemoveNodeLeftOrRightOnly = True
        
     End If

End Function

'---------------------------------------------------------------------------------------
' Procedure : ValidateTree
' DateTime  : 25/04/2005 20:31
' Author    : D K Richmond
' Purpose   :
' for debugging
'---------------------------------------------------------------------------------------
'
Public Function ValidateTree()
 Dim lMax As Long
 Dim lIndex As Long
 Dim lLeftNode As Long
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim sKey As String
 Dim sCurrentKey As String
 
   On Error GoTo ValidateTree_Error

    lMax = GetNodesMaxIndex() - 1
    For lIndex = 0 To lMax
       sCurrentKey = GetKeyAtNodeIndex(lIndex)
       lLeftNode = BSTNStore(lIndex, m_elLeft)
       lRightNode = BSTNStore(lIndex, m_elRight)
       lParentNode = BSTNStore(lIndex, m_elParent)
       If lLeftNode <> m_cNoLink Then
           If BSTNStore(lLeftNode, m_elParent) <> lIndex Then
               sKey = GetKeyAtNodeIndex(lLeftNode)
               MsgBox "Error in Left Key: " & sKey
           End If
       End If
       If lRightNode <> m_cNoLink Then
           If BSTNStore(lRightNode, m_elParent) <> lIndex Then
               sKey = GetKeyAtNodeIndex(lRightNode)
               MsgBox "Error in Right Key: " & sKey
           End If
       End If
    Next
    

   On Error GoTo 0
   Exit Function

ValidateTree_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure ValidateTree of Class Module cBSTNStorage"

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
     If iPos > 0 Then
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
     If iPos > 0 Then
        RemoveLastPart = Left(spLine, iPos - 1)
    Else
        RemoveLastPart = spLine
    End If

End Function

'---------------------------------------------------------------------------------------
' Procedure : DiskMediaGarbageStatistics
' DateTime  : 15/05/2005 09:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function DiskMediaGarbageStatistics(ByRef dDataOffsetPercent As Double, _
        ByRef dDataPercent As Double, _
            ByRef dKeysPercent As Double, _
                    ByRef dNodesPercent As Double) As Boolean

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
 
   On Error GoTo DiskMediaGarbageStatistics_Error

        dDataOffsetPercent = 0: dDataPercent = 0: dKeysPercent = 0: dNodesPercent = 0
   
        'dataoffset media file
        sDataOffsetFilePathName = MakeDataOffsetFileName(m_sDiskFileName)
        iInDataOfsChan = FreeFile()
        Close #iInDataOfsChan: Open sDataOffsetFilePathName For Input As #iInDataOfsChan
            Line Input #iInDataOfsChan, sDataOffsetLine
        Close #iInDataOfsChan
  
         'data media file
        dDataGarbageSize = 0
        sDataFilePathName = MakeDataFileName(m_sDiskFileName)
        iInDataChan = FreeFile()
        Close #iInDataChan: Open sDataFilePathName For Input As #iInDataChan
        While Not EOF(iInDataChan)
            Line Input #iInDataChan, sDataLine
            
            dDataFileSize = LOF(iInDataChan)
            
            If Left(sDataLine, 1) = m_DataRemovalCharacter Then
                dDataGarbageSize = dDataGarbageSize + Len(sDataLine)
            End If
            
            If Left(sDataLine, Len(m_sGarbageIdentityKey)) = m_sGarbageIdentityKey Then
                dDataGarbageSize = dDataGarbageSize + Len(m_sGarbageIdentityKey)
            End If
            
        Wend
        Close #iInDataChan
        
        If (dDataGarbageSize > 0) Then
            dDataPercent = Format(dDataGarbageSize / dDataFileSize * 100, "##.##")
        End If
        
        ' key media file - free running channel
        ' input access allowed as this channel free runs
        dKeyGarbageSize = 0
        Seek #m_iDiskKeyChan, 1
        While Not EOF(m_iDiskKeyChan)
            Line Input #m_iDiskKeyChan, sKeyLine
            
            dKeyFileSize = LOF(m_iDiskKeyChan)
            
            If Left(sKeyLine, 1) = m_DataRemovalCharacter Then
                dKeyGarbageSize = dKeyGarbageSize + Len(sKeyLine)
            End If
            
            If Left(sDataLine, Len(m_sGarbageIdentityKey)) = m_sGarbageIdentityKey Then
                dKeyGarbageSize = dKeyGarbageSize + Len(m_sGarbageIdentityKey)
            End If
            
        Wend
        
        If (dKeyGarbageSize > 0) Then
            dKeysPercent = Format(dKeyGarbageSize / dKeyFileSize * 100, "##.##")
        End If
        
        
        ' node media file - free running channel
        ' input access allowed as this channel free runs
        Seek #m_iDiskNodeInChan, 1
        Line Input #m_iDiskNodeInChan, sNodeLine

   On Error GoTo 0
   Exit Function

DiskMediaGarbageStatistics_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure DiskMediaGarbageStatistics of Class Module cBSTNStorage"
        
End Function

'---------------------------------------------------------------------------------------
' Procedure : CreateLibrarySize
' DateTime  : 06/05/2005 20:45
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function CreateLibrarySize(ByVal lpLibraryRecord As Long, Optional ByVal ipoKeyFields As Integer) As Boolean

   On Error GoTo CreateLibrarySize_Error

    If (lpLibraryRecord = -1) Then
        Erase m_vaLibraryMemoryRecords()
        m_lLibraryRecords = -1
        m_iRecordFields = -1
    Else
        ReDim m_vaLibraryMemoryRecords(lpLibraryRecord, ipoKeyFields)
        m_lLibraryRecords = lpLibraryRecord
        m_iRecordFields = ipoKeyFields
        
'DEBUG
If m_iRecordFields > 5 Then
    MsgBox "DEBUG: problem with garbage collection and rebuild change fields value", vbCritical
End If

    End If
    

   On Error GoTo 0
   Exit Function

CreateLibrarySize_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure CreateLibrarySize of Class Module cBSTNStorage"
    
End Function
    
'---------------------------------------------------------------------------------------
' Procedure : IncreaseKeyFileRecordsCounter
' DateTime  : 19/05/2005 08:50
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
' DKR:DKR:DKR
Public Function IncreaseKeyFileRecordsCounter()
 Dim sLibraryRecords As String
 Dim sKeyHeaderLine As String
 Dim saFields() As String
 Dim iDiskKeyChan As Integer
 Dim lLibraryRecords As Long
  
    If (m_bReadFromDiskFile = True) Then
        
        If gbDebug = True Then
            MsgBox "DISKFILE!", vbCritical
        End If
  
        ' from AddMediaDataRecord
     ' start: get library records, add one, write back
        Seek #m_iDiskKeyChan, 1
        Line Input #m_iDiskKeyChan, sKeyHeaderLine
        saFields() = Split(sKeyHeaderLine, m_scNodeFieldDelimeter)
        lLibraryRecords = Val(saFields(0))
        iDiskKeyChan = FreeFile()
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Binary As #iDiskKeyChan
        lLibraryRecords = lLibraryRecords + 1
        sLibraryRecords = NodePlusMinusFormat(lLibraryRecords)
        Seek #iDiskKeyChan, 1
        Put #iDiskKeyChan, , sLibraryRecords
        Close #iDiskKeyChan
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
        ' end: get library records, add one, write back
  End If
  
End Function

'---------------------------------------------------------------------------------------
' Procedure : AddMediaDataRecord
' DateTime  : 02/05/2005 11:06
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function AddMediaDataRecord(Optional ByRef lpoLibraryRecord As Variant) As Boolean
 Dim iRecordField As Integer
 Dim lRow As Long
 Dim lLibraryRecord As Long
 Dim sDataFilePathName As String
 Dim dDataOffset As Double
 Dim sDataLine As String
 Dim saFields() As String
 Dim iMaxFields As Integer
 Dim iInDataChan As Integer
 Dim iOutBinaryDataChan As Integer
 Dim sUpdateLine As String
 Dim iAppendDataChan As Integer
 Dim iDiskNodeChan As Integer
 Dim sUpdateDataOffset As String
 Dim iMax As Integer
 Dim sKeyValue As String
 Dim lFoundNode As Long
 Dim bOk As Boolean
 Dim iDataOfsChan As Integer
 Dim sDataOffsetLine As String
 Dim dDataOffsetSeek As Double
 Dim sDataOffsetFilePathName As String
 Dim iInDataOfsChan As Integer
 
 Dim sKeyHeaderLine As String
 Dim sAddLine As String
 
 Dim iField As Integer
 Dim iDiskKeyChan As Integer
 Dim sLibraryRecords As String
 Dim lLibraryRecords As Long
 
    AddMediaDataRecord = False
 
 On Error GoTo AddMediaDataRecord_Error
 
    If (m_bReadFromDiskFile = True) Then
        
        If gbDebug = True Then
            MsgBox "DISKFILE!", vbCritical
        End If
        ' lpoLibraryRecord is the data file offset passed from getdata index if disk access on
       
        ' get, increase and write back library records total and give new record the totals records value
        
    ' THIS PART IS RENDERED INEFFECTUAL SEE - IncreaseKeyFileRecordsCounter instead!! DKR:DKR:DKR
        ' start: get library records, add one, write back
        Seek #m_iDiskKeyChan, 1
        Line Input #m_iDiskKeyChan, sKeyHeaderLine
        saFields() = Split(sKeyHeaderLine, m_scNodeFieldDelimeter)
        lLibraryRecords = Val(saFields(0))
        iDiskKeyChan = FreeFile()
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Binary As #iDiskKeyChan
        'DKR:DKR:DKR :::  lLibraryRecords = lLibraryRecords + 1
        sLibraryRecords = NodePlusMinusFormat(lLibraryRecords)
        Seek #iDiskKeyChan, 1
        Put #iDiskKeyChan, , sLibraryRecords
        Close #iDiskKeyChan
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
        lLibraryRecord = lLibraryRecords
        ' end: get library records, add one, write back
        
         ' start: append a sample data line
        iAppendDataChan = FreeFile()
        sDataFilePathName = MakeDataFileName(m_sDiskFileName)
        Close #iAppendDataChan: Open sDataFilePathName For Append As #iAppendDataChan
        dDataOffset = LOF(iAppendDataChan) + 1   ' +1 neccessary to take to next char past eof
        Debug.Print dDataOffset
        Debug.Print "$" & Hex(dDataOffset)
    
    ' BUG FIX start: to keep field arrays consistent
Dim sDelim As String
    sDelim = m_scNodeFieldDelimeter
    
        sAddLine = ""   ' just put anything the other routines will do the rest
        For iRecordField = 0 To m_iRecordFields
        ' BUG FIX: start : creating input past end of line errors - due to extra delimeter
            If (iRecordField = m_iRecordFields) Then
                sDelim = ""
            End If
            sAddLine = sAddLine & "xxxx" & sDelim
        Next
    '    BUG FIX: end : creating input past end of line errors - due to extra delimeter
    ' BUG FIX start: to keep field arrays consistent
        
        Print #iAppendDataChan, sAddLine
        Close #iAppendDataChan
         ' end: append a sample data line
        
        ' start: update to new data offset
        sDataOffsetFilePathName = MakeDataOffsetFileName(m_sDiskFileName)
        sDataOffsetLine = NodePlusMinusFormat(dDataOffset)
        dDataOffsetSeek = lLibraryRecord * (10 + 2) + 1 ' format len + crlf - HARDCODED change needed
        iDataOfsChan = FreeFile()
        Close #iDataOfsChan: Open sDataOffsetFilePathName For Append As #iDataOfsChan
            Print #iDataOfsChan, sDataOffsetLine
        Close #iDataOfsChan
        ' end: update to new data offset

        If Not IsEmpty(lpoLibraryRecord) Then
            lpoLibraryRecord = lLibraryRecord
        Else
            MsgBox "can't return record number!"
            Err.Raise 940594 + 4090303, "", ""
        End If
        
        AddMediaDataRecord = True
        Exit Function
      End If
      
 '   If (m_bReadFromDiskFile = False) Then

    ' rebuild the record store from the shadow, having adding a brefore the copy
    ReDim m_vaLibraryMemoryRecordsShadow(m_lLibraryRecords + 1, m_iRecordFields)
    For lRow = 0 To m_lLibraryRecords
        ' load the original record store array with values from the Library shadow store
        For iRecordField = 0 To m_iRecordFields
              m_vaLibraryMemoryRecordsShadow(lRow, iRecordField) = m_vaLibraryMemoryRecords(lRow, iRecordField)
        Next
    Next
  
      ' rebuild the record store from the shadow, having added an empty record during the copy
    ReDim m_vaLibraryMemoryRecords(m_lLibraryRecords + 1, m_iRecordFields)
    For lRow = 0 To m_lLibraryRecords
        ' load the original record store array with values from the Library shadow store
        For iRecordField = 0 To m_iRecordFields
              m_vaLibraryMemoryRecords(lRow, iRecordField) = m_vaLibraryMemoryRecordsShadow(lRow, iRecordField)
        Next
    Next
       ' increase record store by one record
    m_lLibraryRecords = m_lLibraryRecords + 1
  
    If (m_bReadFromDiskFile = False) Then
    ' DKR:DKR:DKR
    lpoLibraryRecord = m_lLibraryRecords
  End If
  
    Erase m_vaLibraryMemoryRecordsShadow()
  'End If

    AddMediaDataRecord = True

   On Error GoTo 0
   Exit Function

AddMediaDataRecord_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure AddMediaDataRecord of Module MediaLibarySample"
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : GetMediaRecordDataValues
' DateTime  : 29/04/2005 11:08
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetMediaRecordDataValues(ByVal lpLibraryRecord As Long, spaMediaDataValues() As String) As Boolean
 Dim iRecordField As Integer
 ' data file
 Dim sDataFilePathName As String
 Dim sDataOffsetFilePathName As String
 Dim dDataOffset As Double
 Dim sDataLine As String
 Dim saFields() As String
 Dim iMaxFields As Integer
 Dim iInDataChan As Integer
 Dim iInDataOfsChan As Integer
 Dim sDataOffsetLine As String
 Dim dDataOffsetSeek As Double
 
   On Error GoTo GetMediaRecordDataValues_Error

    GetMediaRecordDataValues = False
    
    'Erase spaMediaDataValues
    
    ReDim spaMediaDataValues(m_iRecordFields)
    
    If (m_bReadFromDiskFile = True) Then
        ' data index is offset to field data in data file not record index to array
        ' load the passed array with values from the Library data file
        sDataOffsetFilePathName = MakeDataOffsetFileName(m_sDiskFileName)
        dDataOffsetSeek = lpLibraryRecord * (10 + 2) + 1 ' format len + crlf
        iInDataOfsChan = FreeFile()
        Close #iInDataOfsChan: Open sDataOffsetFilePathName For Input As #iInDataOfsChan
            Seek #iInDataOfsChan, dDataOffsetSeek
            Line Input #iInDataOfsChan, sDataOffsetLine
        Close #iInDataOfsChan
        dDataOffset = Val(sDataOffsetLine)
        sDataFilePathName = MakeDataFileName(m_sDiskFileName)
        iInDataChan = FreeFile()
        Close #iInDataChan: Open sDataFilePathName For Input As #iInDataChan
            Seek #iInDataChan, dDataOffset
            Line Input #iInDataChan, sDataLine
        Close #iInDataChan
        saFields = Split(sDataLine, m_sDataFieldDelimeter)
        iMaxFields = UBound(saFields())
        For iRecordField = 0 To m_iRecordFields
            If iRecordField <= iMaxFields Then  'protect array
              spaMediaDataValues(iRecordField) = saFields(iRecordField)
            Else
              spaMediaDataValues(iRecordField) = "" ' "FILE-DATA"  ' put something obscure for testing only change to "" for release
            End If
        Next
        
        GetMediaRecordDataValues = True
        Exit Function
        
    End If
    
    If (m_bReadFromDiskFile = False) Then
        ' library records bounds check
        If (lpLibraryRecord < 0) Or (lpLibraryRecord > m_lLibraryRecords) Then
            Exit Function
        End If
    End If
    
    ' load the passed array with values from the Library record
    For iRecordField = 0 To m_iRecordFields
          spaMediaDataValues(iRecordField) = clsgBSTStore.vaLibraryRecord(lpLibraryRecord, iRecordField)
    Next
  
GetMediaRecordDataValues = True

   On Error GoTo 0
   Exit Function

GetMediaRecordDataValues_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure GetMediaRecordDataValues of Module MediaLibarySample"
End Function

'---------------------------------------------------------------------------------------
' Procedure : SetMediaRecordDataValues
' DateTime  : 29/04/2005 11:08
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function SetMediaRecordDataValues(ByVal lpLibraryRecord As Long, spaMediaDataValues() As String) As Boolean
 ' temp parameter variable
  Dim iRecordField As Integer
 ' data file
   
   On Error GoTo SetMediaRecordDataValues_Error

    SetMediaRecordDataValues = False
  
    If (m_bReadFromDiskFile = False) Then
        ' library records bounds check
        If (lpLibraryRecord < 0) Or (lpLibraryRecord > m_lLibraryRecords) Then
            Exit Function
        End If
    End If
    
    ' load the passed array with values from the Library record
    For iRecordField = 0 To m_iRecordFields
          clsgBSTStore.vaLibraryRecord(lpLibraryRecord, iRecordField) = spaMediaDataValues(iRecordField)
    Next
  
SetMediaRecordDataValues = True

   On Error GoTo 0
   Exit Function

SetMediaRecordDataValues_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure SetMediaRecordDataValues of Module MediaLibarySample"
        
End Function

'---------------------------------------------------------------------------------------
' Procedure : Resize_BSTNStore
' DateTime  : 15/05/2005 09:27
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function Resize_BSTNStore(ByVal lpAllocatedNode As Long) As Boolean
 Dim iDiskNodeChan As Integer
 Dim dpDataOffset As Double
 Dim sNodeAppendLine As String
 Dim lpLibraryRecord As Long
 Dim dDataOffsetSeek As Double
 Dim iInDataOfsChan As Integer
 Dim sDataOffsetFilePathName As String
 Dim sDataOffsetLine As String
 Dim dDataOffset As Double
 Dim dDataKeyOffset As Double
 Dim iDiskKeyChan As Integer
 
     Resize_BSTNStore = False
     
     If (m_bReadFromDiskFile = False) Then
        ReDim Preserve m_utBSTNStore(lpAllocatedNode)
     Else
     ' update dataoffset in node line from key file for the data offset change
        sNodeAppendLine = m_scRecordStructMask
        
        iDiskKeyChan = FreeFile()
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Append As #iDiskKeyChan
        dDataKeyOffset = LOF(iDiskKeyChan) + 1
        Print #iDiskKeyChan, , "XXXXXX"  ' temp key
        Close #iDiskKeyChan
        ' re-open free running channel
        Close #m_iDiskKeyChan: Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
        
        sNodeAppendLine = Left(sNodeAppendLine, Len(sNodeAppendLine) - Len("0o0o0k0o0o")) & NodePlusMinusFormat(dDataKeyOffset)
        iDiskNodeChan = FreeFile()
        Close #m_iDiskNodeInChan  ' in order to do an update this channel free runs
        Open m_sDiskNodeFilePathName For Append As #iDiskNodeChan
            Print #iDiskNodeChan, sNodeAppendLine
        Close #iDiskNodeChan
        ' re-open free running channel
        Close #m_iDiskNodeInChan: Open m_sDiskNodeFilePathName For Input As #m_iDiskNodeInChan
        
        ' finally update the memory array for the new data offset for updates

        ReDim Preserve m_utBSTNStore(lpAllocatedNode)
        m_utBSTNStore(lpAllocatedNode).m_lNodeDataIndex = -1 ' dpDataOffset   ' data type error double to long
        
     End If
     
     Resize_BSTNStore = True
End Function

'---------------------------------------------------------------------------------------
' Procedure : ReOpenKeyChan
' DateTime  : 15/05/2005 14:06
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function ReOpenKeyChan() As Boolean
    ' re-open
    Open m_sDiskKeyFilePathName For Input As #m_iDiskKeyChan
End Function

'---------------------------------------------------------------------------------------
' Procedure : ReOpenNodeChan
' DateTime  : 15/05/2005 14:06
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function ReOpenNodeChan() As Boolean
    ' re-open free running channel
    Close #m_iDiskNodeInChan: Open m_sDiskNodeFilePathName For Input As #m_iDiskNodeInChan
End Function

' ##############################################################################################################
' ############################# functions below here are in re-design in order to be removed ###################
' #############  or be re-established as part of the main project ##############################################
' ##############################################################################################################


' PLEASE DON'T MAKE TO MANY REFERENCES TO THIS MEMBER FUNCTION AS IT IS LIKELY TO BE SUPERSEEDED IN LATER RELEASES.
'------------------------------------------
' -- Function: GetPrevInSortedOrder
' -- Desc    : Get Previous Node In Sorted Order
' -- Passed  : nothing
' -- Uses    :
' -- Calls   : other functions
' -- Returns : 0 success, -1 fail
' -- DateTime: Org - 20:17 24/05/00
'------------------------------------------
Private Function GetPrevInSortedOrder(ByVal lpCurrentNode As Long, ByRef lpNextNode As Long, Optional bpoPassThru As Boolean = False, Optional lpoPassThruNode As Long = -1) As Boolean
 Dim iNodeType As Integer
 Dim iPrevNodeType As Integer
 Dim lRightNode As Long
 Dim lParentNode As Long
 Dim lLeftNode As Long
 
    GetPrevInSortedOrder = False

    iNodeType = GetNodeType(lpCurrentNode)
 
    If (iNodeType = m_eRNodeType) Then
        lLeftNode = GetLeftNodeOfIndex(lpCurrentNode)
        If (lLeftNode <> m_cNoLink) Then
            ' left exists
            lpCurrentNode = lLeftNode
            If lpoPassThruNode = lpCurrentNode Then _
                                            bpoPassThru = True
            Do
            lRightNode = GetRightNodeOfIndex(lpCurrentNode)
            If (lRightNode = m_cNoLink) Then
                Exit Do
            Else
                ' right exists
                lpCurrentNode = lRightNode
                If lpoPassThruNode = lpCurrentNode Then _
                                            bpoPassThru = True
            End If
            Loop
        Else
            lParentNode = GetParentNodeOfIndex(lpCurrentNode)
            If (lParentNode <> m_cNoLink) Then
                lpCurrentNode = lParentNode
                If lpoPassThruNode = lpCurrentNode Then _
                            bpoPassThru = True
            End If
        End If
    Else
     If (iNodeType = m_eLNodeType) Or (iNodeType = m_ePNodeType) Then
        ' go left if any exist then all left
        lLeftNode = GetLeftNodeOfIndex(lpCurrentNode)
        If (lLeftNode <> m_cNoLink) Then
            lpCurrentNode = lLeftNode
            If lpoPassThruNode = lpCurrentNode Then _
                            bpoPassThru = True
            Do
                lRightNode = GetRightNodeOfIndex(lpCurrentNode)
                If (lRightNode <> m_cNoLink) Then
                    ' right exists
                    lpCurrentNode = lRightNode
                    If lpoPassThruNode = lpCurrentNode Then _
                            bpoPassThru = True
                Else
                    Exit Do
                End If
            Loop
        Else
           Do
                iNodeType = GetNodeType(lpCurrentNode)
                lParentNode = GetParentNodeOfIndex(lpCurrentNode)
                If (lParentNode <> m_cNoLink) Then
                    lpCurrentNode = lParentNode
                    If lpoPassThruNode = lpCurrentNode Then _
                            bpoPassThru = True
                    iPrevNodeType = iNodeType
                Else
                    Exit Do
                End If
           Loop Until iNodeType <> m_eLNodeType
           '  If dw_GetCurrentPNodeRecNo() = 0 Then         ' at root
           '     MsgBox "underrun sot!"
           '     wResult = -98
           ' End If
           
        End If
     End If
     
        If (lpCurrentNode = 0) And (iNodeType = m_ePNodeType) Then
            MsgBox "Gone to root!"
              GetPrevInSortedOrder = False
              Exit Function
        End If
        
'     If dw_GetCurrentPNodeRecNo() = 0 And iPrevNodeType = gcLNODETYPE Then         ' at root
 '       MsgBox "underrun sot!"
  '      wResult = -98
  '   End If
  End If
lpNextNode = lpCurrentNode
  
  GetPrevInSortedOrder = True

End Function

'------------------------------------------
' -- Function: GetNextInSortedOrder
' -- Passed  : nothing
' -- Uses    :
' -- Calls   : other functions using and updating globals
' -- Returns : 0 success, -1 fail
' -- DateTime: 20:17 24/05/00
'------------------------------------------
' PLEASE DON'T MAKE TO MANY REFERENCES TO THIS MEMBER FUNCTION AS IT IS LIKELY TO BE SUPERSEEDED IN LATER RELEASES.

Private Function GetNextInSortedOrder(ByVal lpCurrentNode As Long, ByRef lpNextNode As Long) As Boolean
 
 Dim lRightNode As Long
 Dim lParentNode  As Long
 'Dim lParentNode As Long
 Dim lLeftNode As Long
 Dim iPrevNodeType As Integer
 Dim iNodeType As Integer
 Dim lPrevNode As Long
 
    GetNextInSortedOrder = False

    ' next in sorted alpha data order
    lPrevNode = -1
    ' go right if any exist then all left
    lRightNode = GetRightNodeOfIndex(lpCurrentNode)
    If (lRightNode <> m_cNoLink) Then
        ' right exists
        lpCurrentNode = lRightNode
        Do
            lLeftNode = GetLeftNodeOfIndex(lpCurrentNode)
            If (lLeftNode <> m_cNoLink) Then
                lpCurrentNode = lLeftNode
            Else
                Exit Do
            End If
        Loop
    Else
        Do
            iNodeType = GetNodeType(lpCurrentNode)
            lParentNode = GetParentNodeOfIndex(lpCurrentNode)
            If (lParentNode <> m_cNoLink) Then
                lPrevNode = lpCurrentNode
                lpCurrentNode = lParentNode
                iPrevNodeType = iNodeType
            Else
                Exit Do
            End If
        Loop Until iNodeType <> m_eRNodeType
        iNodeType = GetNodeType(lPrevNode)
        If (lpCurrentNode = 0) And (iNodeType = m_eRNodeType) Then
            MsgBox "Gone to root!"
              GetNextInSortedOrder = False
              Exit Function
        End If

    '     If dw_GetCurrentPNodeRecNo() = 0 Then    ' at root
    '        MsgBox "overrun eot!"
    '        wResult = -99 ' gcFail
    '     End If
    End If

 lpNextNode = lpCurrentNode
  GetNextInSortedOrder = True

End Function



' <eoc>

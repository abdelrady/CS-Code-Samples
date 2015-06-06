VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmMainMediaLibrary 
   Caption         =   "Media Library (Beta) HDF Not For Release (C) David K Richmond"
   ClientHeight    =   7560
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   9645
   Icon            =   "frmMainMediaLibrary.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   7560
   ScaleWidth      =   9645
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdGetTestData 
      Caption         =   "GetTestData"
      Height          =   375
      Left            =   2760
      TabIndex        =   37
      Top             =   240
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.PictureBox pctMemory 
      AutoSize        =   -1  'True
      Height          =   540
      Left            =   120
      Picture         =   "frmMainMediaLibrary.frx":0442
      ScaleHeight     =   480
      ScaleWidth      =   480
      TabIndex        =   36
      Top             =   120
      Width           =   540
   End
   Begin VB.CommandButton cmdBookIn 
      Caption         =   "Book &In"
      Enabled         =   0   'False
      Height          =   375
      Left            =   4800
      TabIndex        =   34
      Top             =   1920
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.CommandButton cmdBookOut 
      Caption         =   "Book &Out"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2880
      TabIndex        =   33
      Top             =   1920
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.PictureBox pctMediaCover 
      Height          =   2775
      Left            =   7440
      ScaleHeight     =   2715
      ScaleWidth      =   1875
      TabIndex        =   32
      Top             =   120
      Width           =   1935
   End
   Begin VB.PictureBox pctDiskFile 
      AutoSize        =   -1  'True
      Height          =   540
      Left            =   960
      Picture         =   "frmMainMediaLibrary.frx":0884
      ScaleHeight     =   480
      ScaleWidth      =   480
      TabIndex        =   31
      Top             =   120
      Visible         =   0   'False
      Width           =   540
   End
   Begin VB.CommandButton cmdUseDiskBasedFile 
      Caption         =   "Use Disk Media"
      Height          =   375
      Left            =   5880
      TabIndex        =   30
      Top             =   6720
      Width           =   1575
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "&Exit"
      Height          =   375
      Left            =   7920
      TabIndex        =   29
      Top             =   6720
      Width           =   1575
   End
   Begin VB.CommandButton cmdMediaDelete 
      Caption         =   "&Delete Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3840
      TabIndex        =   28
      Top             =   6600
      Width           =   1575
   End
   Begin VB.PictureBox Picture1 
      AutoSize        =   -1  'True
      Height          =   540
      Left            =   6720
      Picture         =   "frmMainMediaLibrary.frx":0B8E
      ScaleHeight     =   480
      ScaleWidth      =   480
      TabIndex        =   27
      Top             =   120
      Width           =   540
   End
   Begin VB.CommandButton cmdMediaEdit 
      Caption         =   "&Edit Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2040
      TabIndex        =   26
      Top             =   6120
      Width           =   1575
   End
   Begin VB.CommandButton cmdShowAll 
      Caption         =   "Show All Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   360
      TabIndex        =   25
      Top             =   6600
      Width           =   1455
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   5640
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdUpdateMedia 
      Caption         =   "&Update Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3840
      TabIndex        =   22
      Top             =   6120
      Width           =   1575
   End
   Begin VB.CommandButton cmdSearchMedia 
      Caption         =   "&Search Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   360
      TabIndex        =   21
      Top             =   6120
      Width           =   1455
   End
   Begin VB.CommandButton cmdAddMedia 
      Caption         =   "&Add Media"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2040
      TabIndex        =   20
      Top             =   6600
      Width           =   1575
   End
   Begin VB.TextBox Text3 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   19
      Top             =   5520
      Visible         =   0   'False
      Width           =   3015
   End
   Begin VB.TextBox txtCoverFileName 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   18
      Top             =   4920
      Width           =   2895
   End
   Begin VB.TextBox txtClassification 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   17
      Top             =   4320
      Width           =   2895
   End
   Begin VB.Frame frMediaType 
      Caption         =   "Media Type"
      Enabled         =   0   'False
      Height          =   2295
      Left            =   5760
      TabIndex        =   6
      Top             =   4320
      Width           =   3735
      Begin VB.OptionButton OptMediaVHS 
         Caption         =   "VHS Video"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   1320
         TabIndex        =   24
         Top             =   1680
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaPC 
         Caption         =   "PC Stuff"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   2640
         TabIndex        =   13
         Top             =   960
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaPS2Game 
         Caption         =   "PS2 Game"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   1320
         TabIndex        =   12
         Top             =   960
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaPS1Game 
         Caption         =   "PS1 Game"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   360
         TabIndex        =   11
         Top             =   960
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaAudioTape 
         Caption         =   "Audio Tape"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   360
         TabIndex        =   10
         Top             =   1680
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaBook 
         Caption         =   "Book"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   2640
         TabIndex        =   9
         Top             =   360
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaDVD 
         Caption         =   "DVD"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   1320
         TabIndex        =   8
         Top             =   360
         Width           =   1000
      End
      Begin VB.OptionButton OptMediaCD 
         Caption         =   "CD"
         BeginProperty Font 
            Name            =   "Comic Sans MS"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   400
         Left            =   360
         TabIndex        =   7
         Top             =   360
         Width           =   1000
      End
   End
   Begin VB.TextBox txtPublisher 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   5
      Top             =   3720
      Width           =   6735
   End
   Begin VB.TextBox txtTitle 
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   4
      Top             =   3120
      Width           =   6735
   End
   Begin VB.TextBox txtMediaIdentifier 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   2640
      TabIndex        =   3
      Top             =   2520
      Width           =   3615
   End
   Begin VB.Label Label2 
      Caption         =   "Sample Memory/Disk  Media Library (Beta)"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   600
      TabIndex        =   35
      Top             =   1080
      Width           =   6495
   End
   Begin VB.Label lblLoadingStatus 
      Height          =   375
      Left            =   120
      TabIndex        =   23
      Top             =   7200
      Width           =   9375
   End
   Begin VB.Label Label8 
      Caption         =   "Date:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   16
      Top             =   5520
      Visible         =   0   'False
      Width           =   2055
   End
   Begin VB.Label Label7 
      Caption         =   "Cover File Name:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   15
      Top             =   4920
      Width           =   2055
   End
   Begin VB.Label Label6 
      Caption         =   "Classification:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   14
      Top             =   4320
      Width           =   2055
   End
   Begin VB.Label Label5 
      Caption         =   "Publisher:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   2
      Top             =   3720
      Width           =   2055
   End
   Begin VB.Label Label4 
      Caption         =   "Title:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   1
      Top             =   3120
      Width           =   2055
   End
   Begin VB.Label Label3 
      Caption         =   "Media Identifier:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   0
      Top             =   2520
      Width           =   2055
   End
   Begin VB.Menu mnuMain 
      Caption         =   "Main"
      Begin VB.Menu mnuNewLibrary 
         Caption         =   "New Library"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuLoadLibrary 
         Caption         =   "Load Library"
      End
      Begin VB.Menu mnuSaveLibrary 
         Caption         =   "Save Library"
      End
      Begin VB.Menu mnuSpacer2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuBuildDiskFileFromLibrary 
         Caption         =   "Build DiskFile From Library (Memory)"
         Enabled         =   0   'False
      End
      Begin VB.Menu spacer5 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuShow 
      Caption         =   "Show"
      Begin VB.Menu mnuShowAll 
         Caption         =   "Show All Media"
         Enabled         =   0   'False
      End
   End
   Begin VB.Menu mnuTools 
      Caption         =   "Tools"
      Begin VB.Menu mnuDiskMediaGarbageStats 
         Caption         =   "Disk Media Garbage Stats"
         Enabled         =   0   'False
      End
      Begin VB.Menu spacer8 
         Caption         =   "-"
      End
      Begin VB.Menu mnuDiskMediaGarbageCollection 
         Caption         =   "Disk Media Garbage Collection"
         Enabled         =   0   'False
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Help"
      Begin VB.Menu mnuNotes 
         Caption         =   "Notes"
      End
      Begin VB.Menu space12 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHowTo 
         Caption         =   "How-To"
      End
      Begin VB.Menu spacer13 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "frmMainMediaLibrary"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'---------------------------------------------------------------------------------------
' Module    : frmMainMediaLibrary
' DateTime  : 04/05/2005 08:30
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
' Updated: 21/05/2005 07:12 - testing of Disk File mode, fix record index inconsistencies
'                           - sometimes forcing a garbage collect to recover data not showing
'                           -  in ShowAll listview.
' Updated: 17/05/2005 03:19
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'
' BUG FIX   : testing of Disk File mode, fix record index inconsistencies
' Version   : 6.0 - 6.1
' Details   : disk file mode sometimes forced to peform a garbage collect to recover data not shown
'
' BUG FIX   : Garbage collection causing file access errors
' Version   : 6.0
' Details   : Garbage collection failure to update disk file records tracker index after finding garbage and deleted records.
'           : Add write to key file of reconciled disk records counter in Library rebuild.
'
' BUG FIX   : Records updates.
' Version   : 1.0-5.0
' Details   : fixed bug in member routine where only one field being updated for valibrayrecord field.
'
' BUG FIX   :
' Version   :
' Details   :
'
' New Additions:
' Details   :  Allow use of Delete Media, fixed bug in member routine where only one field being updated for valibrayrecord field.
'           :  add Garbage statistics from main menu under tools
'           :  add Garbage collect from main menu under tools

' Other changes:
' Example now supports BSTN member functions now overloaded to allow for disk based media file.
' This gives instant access to a disk based media file.  It's all very new and some unit testing done.
' The sample application is a demonstration of how to implement a generic class to deal with memory
' or disk without the need for duplication of the core code.  Obviously when using the memory mode
' the overloaded functions will be slightly slower as there is checking for disk mode within them, but
' it's a small overhead compared with writing the same code twice and then trying to keep both in sync.
' I personally like the speed difference between memory - load library and disk use.  The first load time on my
' normally media library (not the small sample included) is around 10 secs, the second is 'instant'.
' In real life,  say you wanted to book out one item, run the application, click use disk media, enter
' barcode, click search, click [ Book Out ] (not implemented as yet!), click exit.  That's it.   No loading, no saving,
' it's all and integral part of BSTN.  Contrast that with, load the application, wait n seconds, enter barcode,
' click search, click [ Book Out ] (not implemented as yet!), click save library, wait n secs, click exit.
'
' IMPORTANT:  Changes on the disk file result in garbage tokens.  This is because re-ordering and re-shulffling the disk
'               file all the time would result in massive speed penalties.  I haven't yet implemented the garbage collection
'               routines to tidy up these garbage entries.   If you can't wait until these changes are published you can achieve
'               the same by using the .bsd as a .dat file and using the rebuilding the library file routine and
'               looking for and excluding any line with the garbage token within it.
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

Option Explicit

' testing only
Dim sagTestData() As String

' media types
Public Enum MediaTypes
    egMediaIdentifier = 0
    egMediaTitle = 1
    egMediaPublisher = 2
    egMediaType = 3
    egMediaClassification = 4
    egMediaCover = 5
    egMediaEOD = 6
End Enum


'---------------------------------------------------------------------------------------
' Procedure : cmdAddMedia_Click
' DateTime  : 05/05/2005 19:55
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdAddMedia_Click()
 Dim saRecordFields() As String
 Dim bOk As Boolean
 Dim sKeyValue As String
 
    cmdAddMedia.Enabled = False
   
   On Error GoTo cmdAddMedia_Click_Error

    If pctDiskFile.Visible = True Then
        'MsgBox "Disk based Library operations are very very BETA (Delete not implemented yet!) - use them experimentally!", vbExclamation
        'Exit Sub
    End If

' BUG FIX start: input past line errors after updates and garbage collections - found problem here
    '  where Recordfiels was increasing by one each time until it all fell apart

    '    ReDim saRecordFields(egMediaEOD)
   ' ReDim saRecordFields(egMediaEOD - 1)   ' BUG FIX: EOD now EOD-1 causing input past line errors in disk media application
   
Dim iRecordFields As Integer

    iRecordFields = clsgBSTStore.RecordFields
    
    If iRecordFields >= egMediaEOD Then
        MsgBox "Problem with too many fields for update!", vbCritical
        Err.Raise 3904394 + 920392, "", ""
        Exit Sub
    End If
    
    ReDim saRecordFields(iRecordFields)
    
' BUG FIX end:
    
    sKeyValue = txtMediaIdentifier.Text
    saRecordFields(0) = txtMediaIdentifier.Text
    saRecordFields(egMediaTitle) = txtTitle.Text
    saRecordFields(egMediaPublisher) = txtPublisher.Text
    saRecordFields(egMediaClassification) = txtClassification.Text
    saRecordFields(egMediaCover) = txtCoverFileName.Text
 
    SetMediaTypeFromOptionBoxes saRecordFields(egMediaType)
     
' BUG FIX start: not valid since bug fix above
    'saRecordFields(egMediaEOD) = "-- unknown --"
' BUG FIX end:
   
    
    bOk = AddMediaToLibrary(sKeyValue, saRecordFields(), lblLoadingStatus)
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " No Data Added!", vbCritical
        Exit Sub
    Else
        frMediaType.Enabled = False
        cmdMediaEdit.Enabled = True
        txtPublisher.Enabled = False
        txtTitle.Enabled = False
        txtClassification.Enabled = False
        txtCoverFileName.Enabled = False
        
        'MsgBox "Media " & sKeyValue & " Data Added!", vbInformation
        lblLoadingStatus.Caption = "Media " & sKeyValue & " Data Added!"
        SetDirtyFlag
    End If

   On Error GoTo 0
   Exit Sub

cmdAddMedia_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdAddMedia_Click of Form frmMainMediaLibrary"
    
End Sub


'---------------------------------------------------------------------------------------
' Procedure : SetDirtyFlag
' DateTime  : 05/05/2005 19:55
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Sub SetDirtyFlag()

    If clsgBSTStore.DiskMediaActivated = False Then
        mnuSaveLibrary.Enabled = True
        bgDirtyFlag = True
    End If
    
    bgRefreshView = True
    
End Sub

Public Sub ResetDirtyFlag()

    If clsgBSTStore.DiskMediaActivated = False Then
        bgDirtyFlag = False
    End If
    
End Sub
'---------------------------------------------------------------------------------------
' Procedure : GetDirtyFlag
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Function GetDirtyFlag() As Boolean

    GetDirtyFlag = bgDirtyFlag

End Function

Private Sub cmdBookIn_Click()
Dim sKeyValue As String
 Dim lDataIndex As Long
 Dim saDataValues() As String
 Dim bOk As Boolean
     
    sKeyValue = txtMediaIdentifier.Text
    
    bOk = FindMedia(sKeyValue, lDataIndex)
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " Not Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If

    bOk = clsgBSTStore.GetMediaRecordDataValues(lDataIndex, saDataValues())
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " No Data Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If
    
    ' saDataValues(egMediaIdentifier)  ' needs to be the key global value
    ' saDataValues(egMediaPublisher)
    ' saDataValues(egMediaTitle)
    ' saDataValues(egMediaClassification)
    ' saDataValues(egMediaCover)
    
End Sub

Private Sub cmdBookOut_Click()
 Dim sKeyValue As String
 Dim lDataIndex As Long
 Dim saDataValues() As String
 Dim bOk As Boolean
     
    sKeyValue = txtMediaIdentifier.Text
    
    bOk = FindMedia(sKeyValue, lDataIndex)
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " Not Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If

    bOk = clsgBSTStore.GetMediaRecordDataValues(lDataIndex, saDataValues())
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " No Data Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If
    
    ' saDataValues(egMediaIdentifier)  ' needs to be the key global value
    ' saDataValues(egMediaPublisher)
    ' saDataValues(egMediaTitle)
    ' saDataValues(egMediaClassification)
    ' saDataValues(egMediaCover)
    
End Sub

 Private Sub cmdExit_Click()
    Unload Me
End Sub

Private Sub cmdGetTestData_Click()
 Dim lIndex As Long
 Dim r As Integer
Dim saFields() As String
Dim sLine As String

 lIndex = 0
 On Error Resume Next
    Debug.Print UBound(sagTestData())
 If Err.Number <> 0 Then
    Err.Clear
    On Error GoTo 0
     Close #99: Open App.Path & "/MediaLibrary.dat" For Input As #99
    While Not EOF(99)
        Line Input #99, sLine
        ReDim Preserve sagTestData(lIndex)
         sagTestData(lIndex) = sLine
        lIndex = lIndex + 1
    Wend
    Close #99
Else
    lIndex = UBound(sagTestData())
End If
  On Error GoTo 0
  


    r = Rnd(1) * lIndex
    
    sLine = sagTestData(r)
    
    saFields() = Split(sLine, "|")
    
    txtMediaIdentifier.Text = saFields(0)
    txtTitle.Text = saFields(1)
    Me.txtPublisher.Text = saFields(2)
    SetMediaTypeOptionBoxes saFields(3)
    
    txtClassification.Text = saFields(4)
    txtCoverFileName.Text = saFields(5)
    
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : cmdMediaDelete_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdMediaDelete_Click()
 Dim bOk As Boolean
 Dim sKeyValue As String
 Dim lDataIndex As Long
 
   On Error GoTo cmdMediaDelete_Click_Error
    
    If pctDiskFile.Visible = True Then
        MsgBox "Now available disk based file delete (needs more testing and any fixes due in next release!", vbInformation
       ' Exit Sub
    End If

    
    cmdAddMedia.Enabled = False
    cmdMediaEdit.Enabled = False
    cmdSearchMedia.Enabled = False
    cmdUpdateMedia.Enabled = False
    
    cmdMediaDelete.Enabled = False
    
    sKeyValue = txtMediaIdentifier.Text
    
    bOk = DeleteMedia(sKeyValue, lDataIndex)
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " Not Deleted!", vbExclamation
        cmdMediaEdit.Enabled = True
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If
    
    MsgBox "Media Record @" & lDataIndex & " Key: " & sKeyValue & " Deleted!", vbInformation
    
    SetDirtyFlag

    frMediaType.Enabled = False
    cmdMediaEdit.Enabled = True
    cmdSearchMedia.Enabled = True
    
   On Error GoTo 0
   Exit Sub

cmdMediaDelete_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdMediaDelete_Click of Form frmMainMediaLibrary"
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : cmdMediaEdit_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdMediaEdit_Click()
    
   On Error GoTo cmdMediaEdit_Click_Error

    cmdMediaEdit.Enabled = False
    cmdAddMedia.Enabled = True
    txtMediaIdentifier.Enabled = True
    txtPublisher.Enabled = True
    txtTitle.Enabled = True
    txtClassification.Enabled = True
    txtCoverFileName.Enabled = True
    frMediaType.Enabled = True
    cmdUpdateMedia.Enabled = True
    
   On Error GoTo 0
   Exit Sub

cmdMediaEdit_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdMediaEdit_Click of Form frmMainMediaLibrary"
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : cmdSearchMedia_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdSearchMedia_Click()
 Dim sKeyValue As String
 Dim lDataIndex As Long
 Dim saDataValues() As String
 Dim bOk As Boolean
 Dim sMediaCoverFileName As String
 Dim sMediaCoverFilePathName As String
 Dim sDefaultCoverPictureFilePathName As String
 
   On Error GoTo cmdSearchMedia_Click_Error

    cmdAddMedia.Enabled = False
    cmdMediaDelete.Enabled = False
    cmdSearchMedia.Enabled = False
    cmdUpdateMedia.Enabled = False
    
    sKeyValue = txtMediaIdentifier.Text
    
    bOk = FindMedia(sKeyValue, lDataIndex)
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " Not Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If

    bOk = clsgBSTStore.GetMediaRecordDataValues(lDataIndex, saDataValues())
    
    If bOk = False Then
        MsgBox "Media " & sKeyValue & " No Data Found!", vbExclamation
        cmdSearchMedia.Enabled = True
        Exit Sub
    End If
    
    txtMediaIdentifier.Text = saDataValues(egMediaIdentifier)  ' needs to be the key global value
    txtPublisher.Text = saDataValues(egMediaPublisher)
    txtTitle.Text = saDataValues(egMediaTitle)
    txtClassification.Text = saDataValues(egMediaClassification)
    txtCoverFileName.Text = saDataValues(egMediaCover)
    
    ' begin: ###  display cover of media if exists ###
    sMediaCoverFileName = saDataValues(egMediaCover)
    ' dir doesn't work for all files .. just a quick and dirty soltion for now needs FSO really
    If Len(sMediaCoverFileName) > 1 Then
        sDefaultCoverPictureFilePathName = App.Path & "\DATA\" & sgcDefaultCoverPictureFileName
        sMediaCoverFilePathName = App.Path & "\DATA\" & sMediaCoverFileName
'        If InStr(1, sMediaCoverFilePathName, " ") Then
'            sMediaCoverFilePathName = Chr(34) & sMediaCoverFilePathName & Chr(34)
'        End If
        If Dir(sMediaCoverFilePathName, 63) = "" Then
            pctMediaCover.Picture = LoadPicture(sDefaultCoverPictureFilePathName)
        Else
            ' display default picture
            pctMediaCover.Picture = LoadPicture(sMediaCoverFilePathName)
        End If
    End If
    ' end: ###  display cover of media if exists ###
    
    SetMediaTypeOptionBoxes saDataValues(egMediaType)
      
    cmdMediaDelete.Enabled = True
    cmdMediaEdit.Enabled = True
    cmdSearchMedia.Enabled = True

   On Error GoTo 0
   Exit Sub

cmdSearchMedia_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdSearchMedia_Click of Form frmMainMediaLibrary"
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : SetMediaTypeOptionBoxes
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Public Sub SetMediaTypeOptionBoxes(ByVal spMediaType As String)
  
   On Error GoTo SetMediaTypeOptionBoxes_Error

  ' centralised
    OptMediaCD.Value = False
    OptMediaPS1Game.Value = False
    OptMediaPS2Game.Value = False
    OptMediaAudioTape.Value = False
    OptMediaDVD.Value = False
    OptMediaPS2Game.Value = False
    OptMediaBook.Value = False
    OptMediaPC.Value = False
    OptMediaVHS.Value = False
    
    Select Case spMediaType
        Case "CD Music"
            OptMediaCD = True
        Case "DVD"
            OptMediaDVD = True
        Case "Book"
            OptMediaBook = True
        Case "PS1 Game"
            OptMediaPS1Game = True
        Case "PS2 Game"
            OptMediaPS2Game = True
        Case "PC Game"
            OptMediaPC = True
        Case "Audio Tape"
            OptMediaAudioTape = True
        Case "VHS Video"
            OptMediaVHS.Value = True
    End Select

   On Error GoTo 0
   Exit Sub

SetMediaTypeOptionBoxes_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure SetMediaTypeOptionBoxes of Form frmMainMediaLibrary"

End Sub

'---------------------------------------------------------------------------------------
' Procedure : cmdShowAll_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdShowAll_Click()
        
   On Error GoTo cmdShowAll_Click_Error

        cmdAddMedia.Enabled = False
        cmdMediaDelete.Enabled = False
        cmdUpdateMedia.Enabled = False
        frmShowAllMedia.Show

   On Error GoTo 0
   Exit Sub

cmdShowAll_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdShowAll_Click of Form frmMainMediaLibrary"

End Sub

Private Sub cmdUpdateMedia_Click()
 Dim saRecordFields() As String
 Dim bOk As Boolean
 Dim sKeyValue As String
 
   On Error GoTo cmdUpdateMedia_Click_Error

    cmdUpdateMedia = False
    
' BUG FIX start: input past line errors after updates and garbage collections - found problem here
'  where Recordfiels was increasing by one each time until it all fell apart

   ' ReDim saRecordFields(egMediaEOD - 1)   ' BUG FIX: EOD now EOD-1 causing input past line errors in disk media application
   
Dim iRecordFields As Integer

    
iRecordFields = clsgBSTStore.RecordFields
    
    If iRecordFields >= egMediaEOD Then
        MsgBox "Problem with too many fields for update!", vbCritical
        Err.Raise 3904394 + 920392, "", ""
        Exit Sub
    End If
    
    ReDim saRecordFields(iRecordFields)
    
' BUG FIX end:

    sKeyValue = txtMediaIdentifier.Text
    saRecordFields(egMediaIdentifier) = txtMediaIdentifier.Text
    saRecordFields(egMediaPublisher) = txtPublisher.Text
    saRecordFields(egMediaTitle) = txtTitle.Text
    saRecordFields(egMediaClassification) = txtClassification.Text
    saRecordFields(egMediaCover) = txtCoverFileName.Text
    
    SetMediaTypeFromOptionBoxes saRecordFields(egMediaType)
    
' BUG FIX start: not valid since bug fix above
    'saRecordFields(egMediaEOD) = "-- unknown --"
' BUG FIX end:
    
    bOk = UpdateMediaToLibrary(sKeyValue, saRecordFields(), lblLoadingStatus)
    
    cmdUpdateMedia.Enabled = True

    If bOk = False Then
        MsgBox "Media " & sKeyValue & " No Data Updated!", vbCritical
        Exit Sub
    Else
        cmdMediaEdit.Enabled = True
        txtPublisher.Enabled = False
        txtTitle.Enabled = False
        txtClassification.Enabled = False
        txtCoverFileName.Enabled = False
        cmdMediaEdit.Enabled = False
        cmdUpdateMedia.Enabled = False
        frMediaType.Enabled = False
        'MsgBox "Media " & sKeyValue & " Data Updated!", vbInformation
        lblLoadingStatus.Caption = "Media " & sKeyValue & " Data Updated!"
        SetDirtyFlag
    End If

   On Error GoTo 0
   Exit Sub

cmdUpdateMedia_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdUpdateMedia_Click of Form frmMainMediaLibrary"

End Sub

'---------------------------------------------------------------------------------------
' Procedure : SetMediaTypeFromOptionBoxes
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub SetMediaTypeFromOptionBoxes(ByRef spRecordField As String)

   On Error GoTo SetMediaTypeFromOptionBoxes_Error

    If OptMediaPS1Game.Value = True Then
        spRecordField = "PS1 Game"
    End If
    If OptMediaAudioTape.Value = True Then
        spRecordField = "Audio Tape"
    End If
    If OptMediaBook.Value = True Then
        spRecordField = "Book"
    End If
    If OptMediaCD.Value = True Then
        spRecordField = "CD Music"
    End If
    If OptMediaDVD.Value = True Then
        spRecordField = "DVD"
    End If
    If OptMediaPC.Value = True Then
        spRecordField = "PC Game"
    End If
    If OptMediaPS2Game.Value = True Then
        spRecordField = "PS2 Game"
    End If
    If OptMediaVHS.Value = True Then
        spRecordField = "VHS Tape"
    End If

   On Error GoTo 0
   Exit Sub

SetMediaTypeFromOptionBoxes_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure SetMediaTypeFromOptionBoxes of Form frmMainMediaLibrary"
    
End Sub
    
    
'---------------------------------------------------------------------------------------
' Procedure : cmdUseDiskBasedFile_Click
' DateTime  : 07/05/2005 16:51
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub cmdUseDiskBasedFile_Click()
 Dim bOk As Boolean
 Dim bDirtyFlag As Boolean
 Dim sYN As String
 Dim bQuit As Boolean
 
  bDirtyFlag = GetDirtyFlag()
  
   On Error GoTo cmdUseDiskBasedFile_Click_Error

    cmdUseDiskBasedFile.Enabled = False
    
    If pctDiskFile.Visible = True Then
        UseDiskBasedFile_Off  ' all data indexes were overwritten
        MsgBox "Data Indexes overwritten when disk accessed - Restoring Memory Database!", vbExclamation
        bOk = LoadLibrary(lblLoadingStatus)
        If bOk = False Then
            MsgBox "Failed to restore memory library!", vbCritical
        End If
        pctDiskFile.Visible = False
        pctMemory.Visible = True
        mnuLoadLibrary.Enabled = True
        mnuSaveLibrary.Enabled = True
        mnuBuildDiskFileFromLibrary.Enabled = True
        mnuBuildDiskFileFromLibrary.Enabled = True
        cmdUseDiskBasedFile.Caption = "Use Disk File!"
        mnuDiskMediaGarbageStats.Enabled = False
        mnuDiskMediaGarbageCollection.Enabled = False
    Else
        'MsgBox "Disk based Library operations are very very BETA (Delete not implemented yet!) - use them experimentally!", vbExclamation
        If (bDirtyFlag = True) Then
         sYN = UCase(InputBox("Save Library (Y/N/Q)?", "Save", "Y"))
         If sYN = "Q" Then
             bQuit = True
             Exit Sub
         End If
         If sYN = "Y" Then
             bOk = SaveLibrary(lblLoadingStatus)
         End If
        End If
        ResetDirtyFlag
        UseDiskBasedFile_On
        pctDiskFile.Visible = True
        pctMemory.Visible = False
        cmdShowAll.Enabled = True
        cmdSearchMedia.Enabled = True
        cmdMediaEdit.Enabled = True
        mnuLoadLibrary.Enabled = False
        mnuSaveLibrary.Enabled = False
        cmdBookIn.Enabled = True
        cmdBookOut.Enabled = True
        mnuBuildDiskFileFromLibrary.Enabled = False
        cmdUseDiskBasedFile.Caption = "Use Memory Media"
        mnuShowAll.Enabled = True
        mnuDiskMediaGarbageStats.Enabled = True
        mnuDiskMediaGarbageCollection.Enabled = True
    End If
    
    cmdUseDiskBasedFile.Enabled = True

   On Error GoTo 0
   Exit Sub

cmdUseDiskBasedFile_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure cmdUseDiskBasedFile_Click of Form frmMainMediaLibrary"
    
End Sub


'---------------------------------------------------------------------------------------
' Procedure : Form_Load
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub Form_Load()
    
   On Error GoTo Form_Load_Error
Randomize ' for test data
' in case they go for the disk based before load library
    sgLibraryFileName = sgcLibraryFileName
    sgLibraryFilePathName = App.Path & "\DATA\" & sgLibraryFileName
    
    Call InitialiseLibrary
     
    mnuLoadLibrary.Enabled = False
    mnuSaveLibrary.Enabled = False
     
    sgFieldDelimiter = "|"  ' this must be before loadlibrary
   
   ' mnuLoadLibrary_Click
   mnuLoadLibrary.Enabled = True

    
    cmdAddMedia.Enabled = False

    bgRefreshView = True

    
   On Error GoTo 0
   Exit Sub

Form_Load_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure Form_Load of Form frmMainMediaLibrary"
    
End Sub

 Private Sub Form_Unload(Cancel As Integer)
  Dim sYN As String
  Dim bOk As Boolean
  Dim bQuit As Boolean
  Dim bDirtyFlag As Boolean
  
  bDirtyFlag = GetDirtyFlag()
   On Error GoTo Form_Unload_Error
     
     If pctDiskFile.Visible = True Then
        ' no dirty flag required is disk based version used all changes made to files already
        bDirtyFlag = False
     End If
     
     bOk = True
     bQuit = False
     If (bDirtyFlag = True) Then
         sYN = UCase(InputBox("Save Library (Y/N/Q)?", "Save", "Y"))
         If sYN = "Q" Then
             bQuit = True
         End If
         If sYN = "Y" Then
             bOk = SaveLibrary(lblLoadingStatus)
         End If
     End If
     If (bOk = True) Or (bQuit = True) Then
         MsgBox "Exit", vbInformation
         Unload frmShowAllMedia
         Set frmMainMediaLibrary = Nothing
     Else
         Cancel = 1
         MsgBox "Problem with Library.", vbCritical
     End If

   On Error GoTo 0
   Exit Sub

Form_Unload_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure Form_Unload of Form frmMainMediaLibrary"
     
 End Sub


'---------------------------------------------------------------------------------------
' Procedure : mnuBuildDiskFileFromLibrary_Click
' DateTime  : 19/05/2005 08:15
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuBuildDiskFileFromLibrary_Click()
Dim bOk As Boolean
 
   On Error GoTo mnuBuildDiskFileFromLibrary_Click_Error

    If DiskFileActivated() = True Then
        MsgBox "Disk File Accessed Activated - Deactivate before attempting external build!", vbExclamation
        Exit Sub
    End If
    
    bOk = BuildDiskFileFromLibrary(lblLoadingStatus)
    
    If bOk = True Then
        MsgBox "Library Built Ok!", vbInformation
        ' menu and globals
        mnuBuildDiskFileFromLibrary.Enabled = True
    Else
        MsgBox "Failed to Build Library!", vbInformation
    End If
    
   On Error GoTo 0
   Exit Sub

mnuBuildDiskFileFromLibrary_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure mnuBuildDiskFileFromLibrary_Click of Form frmMainMediaLibrary"
 
End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuDiskMediaGarbageCollection_Click
' DateTime  : 19/05/2005 08:15
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuDiskMediaGarbageCollection_Click()
 Dim bOk As Boolean
 
    mnuDiskMediaGarbageCollection.Enabled = False
    
    bOk = DiskMediaGarbageStatistics()
    
    MsgBox "Problems with blank records can cause media disk file corruption!", vbExclamation
    
    bOk = DiskMediaGarbageCollection()
    
    If bOk = True Then
        MsgBox "Garbage Collection Completed!", vbExclamation
    Else
        MsgBox "Garbage Collection Failed!", vbCritical
    End If
    
    bOk = DiskMediaGarbageStatistics()
    
    mnuDiskMediaGarbageCollection.Enabled = True
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuDiskMediaGarbageStats_Click
' DateTime  : 19/05/2005 08:15
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuDiskMediaGarbageStats_Click()
    
    mnuDiskMediaGarbageStats.Enabled = False
    
    DiskMediaGarbageStatistics
    
    mnuDiskMediaGarbageStats.Enabled = True
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuExit_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
 Private Sub mnuExit_Click()
     
     Unload Me
     
 End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuAbout_Click
' DateTime  : 19/05/2005 08:16
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuAbout_Click()
 Dim sAbout As String
 
    sAbout = "Media Library Sample (BETA) [HDFO]" & vbCrLf
    sAbout = sAbout & "Written by David K Richmond April 2005" & vbCrLf
    sAbout = sAbout & "[ Uses Binary Search Tree Node Class inc Disk File Wrappers ]" & vbCrLf
    sAbout = sAbout & "[ Demonstration of small media library CDs,DVDs etc ]" & vbCrLf
    sAbout = sAbout & " { APP Details: " & App.FileDescription & " " & App.Major & "." & App.Minor & " }"
    MsgBox sAbout, vbInformation
     
End Sub


'---------------------------------------------------------------------------------------
' Procedure : mnuHowTo_Click
' DateTime  : 14/05/2005 09:28
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuHowTo_Click()
    frmHowTo.Show
End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuLoadLibrary_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuLoadLibrary_Click()
 Dim bOk As Boolean
 
   On Error GoTo mnuLoadLibrary_Click_Error

    If pctDiskFile.Visible = True Then
        MsgBox "UnFudge first!"
        Exit Sub
    End If
    
   ' Enabled = False
    Screen.MousePointer = vbHourglass
    
  'MsgBox "Load", vbInformation
  
'  CommonDialog1.DefaultExt = "dat"
'  CommonDialog1.FileName = sgcLibraryFileName
'  CommonDialog1.InitDir = App.Path & "\DATA"
'  CommonDialog1.ShowOpen

    ' quick testing option
    sgLibraryFileName = sgcLibraryFileName
    sgLibraryFilePathName = App.Path & "\DATA\" & sgLibraryFileName
    
    bOk = LoadLibrary(lblLoadingStatus)
    
    If bOk = True Then
'        MsgBox "Library Loaded Ok!", vbInformation
    Else
        MsgBox "Failed to Load Library!", vbInformation
    End If

   ' Enabled = True
    Screen.MousePointer = vbNormal
    cmdShowAll.Enabled = True
    cmdSearchMedia.Enabled = True
    cmdMediaEdit.Enabled = True
    cmdBookIn.Enabled = True
    cmdBookOut.Enabled = True
    
    mnuShowAll.Enabled = True
    mnuBuildDiskFileFromLibrary.Enabled = True
    
   On Error GoTo 0
   Exit Sub

mnuLoadLibrary_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure mnuLoadLibrary_Click of Form frmMainMediaLibrary"
    
End Sub


Private Sub mnuNotes_Click()
    frmNotes.Show
End Sub

'---------------------------------------------------------------------------------------
' Procedure : mnuSaveLibrary_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuSaveLibrary_Click()
 Dim bOk As Boolean
 
   On Error GoTo mnuSaveLibrary_Click_Error

    bOk = SaveLibrary(lblLoadingStatus)
    
    If bOk = True Then
        MsgBox "Library Saved Ok!", vbInformation
        ' menu and globals
        mnuSaveLibrary.Enabled = False
        bgDirtyFlag = False
    Else
        MsgBox "Failed to SaveLibrary!", vbInformation
    End If
    

   On Error GoTo 0
   Exit Sub

mnuSaveLibrary_Click_Error:

    MsgBox "Error " & Err.Number & " (" & Err.Description & ") in procedure mnuSaveLibrary_Click of Form frmMainMediaLibrary"
    
End Sub


'---------------------------------------------------------------------------------------
' Procedure : mnuShowAll_Click
' DateTime  : 05/05/2005 19:56
' Author    : D K Richmond
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub mnuShowAll_Click()

    frmShowAllMedia.Show
    
End Sub


'---------------------------------------------------------------------------------------
' Procedure : txtMediaIdentifier_KeyPress
' DateTime  : 19/05/2005 08:16
' Author    : Miniopolos
' Purpose   :
'---------------------------------------------------------------------------------------
'
Private Sub txtMediaIdentifier_KeyPress(KeyAscii As Integer)
    
    If KeyAscii = 13 Then
        cmdSearchMedia_Click
    End If
    
End Sub

' eom

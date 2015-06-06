Attribute VB_Name = "ModPrint"
Option Explicit
Private Const CCHDEVICENAME = 32
Private Const CCHFORMNAME = 32
Private Const ERROR_INSUFFICIENT_BUFFER = 122
Private Const PRINTER_STATUS_BUSY = &H200
Private Const PRINTER_STATUS_DOOR_OPEN = &H400000
Private Const PRINTER_STATUS_ERROR = &H2
Private Const PRINTER_STATUS_INITIALIZING = &H8000
Private Const PRINTER_STATUS_IO_ACTIVE = &H100
Private Const PRINTER_STATUS_MANUAL_FEED = &H20
Private Const PRINTER_STATUS_NO_TONER = &H40000
Private Const PRINTER_STATUS_NOT_AVAILABLE = &H1000
Private Const PRINTER_STATUS_OFFLINE = &H80
Private Const PRINTER_STATUS_OUT_OF_MEMORY = &H200000
Private Const PRINTER_STATUS_OUTPUT_BIN_FULL = &H800
Private Const PRINTER_STATUS_PAGE_PUNT = &H80000
Private Const PRINTER_STATUS_PAPER_JAM = &H8
Private Const PRINTER_STATUS_PAPER_OUT = &H10
Private Const PRINTER_STATUS_PAPER_PROBLEM = &H40
Private Const PRINTER_STATUS_PAUSED = &H1
Private Const PRINTER_STATUS_PENDING_DELETION = &H4
Private Const PRINTER_STATUS_PRINTING = &H400
Private Const PRINTER_STATUS_PROCESSING = &H4000
Private Const PRINTER_STATUS_TONER_LOW = &H20000
Private Const PRINTER_STATUS_USER_INTERVENTION = &H100000
Private Const PRINTER_STATUS_WAITING = &H2000
Private Const PRINTER_STATUS_WARMING_UP = &H10000
Private Const JOB_STATUS_DELETING = &H4
Private Const JOB_STATUS_ERROR = &H2
Private Const JOB_STATUS_OFFLINE = &H20
Private Const JOB_STATUS_PAPEROUT = &H40
Private Const JOB_STATUS_PAUSED = &H1
Private Const JOB_STATUS_PRINTED = &H80
Private Const JOB_STATUS_PRINTING = &H10
Private Const JOB_STATUS_SPOOLING = &H8
Private Const JOB_STATUS_USER_INTERVENTION = &H10000
Private Const JOB_STATUS_USER_INTERVENTION2 = &H400
Private Const PRINTER_ACCESS_ADMINISTER = &H4
Private Const PRINTER_ACCESS_USE = &H8

'Types Definition
Private Type DEVMODE
    dmDeviceName As String * CCHDEVICENAME
    dmSpecVersion As Integer
    dmDriverVersion As Integer
    dmSize As Integer
    dmDriverExtra As Integer
    dmFields As Long
    dmOrientation As Integer
    dmPaperSize As Integer
    dmPaperLength As Integer
    dmPaperWidth As Integer
    dmScale As Integer
    dmCopies As Integer
    dmDefaultSource As Integer
    dmPrintQuality As Integer
    dmColor As Integer
    dmDuplex As Integer
    dmYResolution As Integer
    dmTTOption As Integer
    dmCollate As Integer
    dmFormName As String * CCHFORMNAME
    dmUnusedPadding As Integer
    dmBitsPerPel As Long
    dmPelsWidth As Long
    dmPelsHeight As Long
    dmDisplayFlags As Long
    dmDisplayFrequency As Long
End Type

Private Type PRINTER_DEFAULTS
    pDatatype As String
    pDevMode As DEVMODE
    DesiredAccess As Long
End Type

Private Type SYSTEMTIME
    wYear As Integer
    wMonth As Integer
    wDayOfWeek As Integer
    wDay As Integer
    wHour As Integer
    wMinute As Integer
    wSecond As Integer
    wMilliseconds As Integer
End Type

Private Type JOB_INFO_1_API
    JobId As Long
    pPrinterName As Long
    pMachineName As Long
    pUserName As Long
    pDocument As Long
    pDatatype As Long
    pStatus As Long
    Status As Long
    Priority As Long
    Position As Long
    TotalPages As Long
    PagesPrinted As Long
    Submitted As SYSTEMTIME
End Type

Private Type JOB_INFO_1
    JobId As Long
    pPrinterName As String
    pMachineName As String
    pUserName As String
    pDocument As String
    pDatatype As String
    pStatus As String
    Status As Long
    Priority As Long
    Position As Long
    TotalPages As Long
    PagesPrinted As Long
    Submitted As SYSTEMTIME
End Type

Private Declare Function OpenPrinter Lib "winspool.drv" Alias "OpenPrinterA" (ByVal pPrinterName As String, phPrinter As Long, pDefault As PRINTER_DEFAULTS) As Long
Private Declare Function EnumJobs Lib "winspool.drv" Alias "EnumJobsA" (ByVal HPrinter As Long, ByVal FirstJob As Long, ByVal NoJobs As Long, ByVal level As Long, ByVal pJob As Long, ByVal cdBuf As Long, pcbNeeded As Long, pcReturned As Long) As Long
Private Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As Long) As Long

Private Declare Sub CopyMem Lib "kernel32.dll" Alias "RtlMoveMemory" (pTo As Any, uFrom As Any, ByVal lSize As Long)
Private Declare Function lstrlenW Lib "kernel32.dll" (ByVal lpString As Long) As Long

Private Declare Function HeapAlloc Lib "kernel32.dll" (ByVal hHeap As Long, ByVal dwflags As Long, ByVal dwBytes As Long) As Long
Private Declare Function GetProcessHeap Lib "kernel32.dll" () As Long
Private Declare Function HeapFree Lib "kernel32.dll" (ByVal hHeap As Long, ByVal dwflags As Long, lpMem As Any) As Long

'Public structure filled by GetPrinterQueue with all the documents data in the selected printer queue
Private JobsDesc() As JOB_INFO_1

'<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

Private Type CharRange
    cpMin As Long     ' First character of range (0 for start of doc)
    cpMax As Long     ' Last character of range (-1 for end of doc)
End Type
'for printing purposes
Private Type FormatRange
    hDC         As Long       ' Actual DC to draw on
    hdcTarget   As Long ' Target DC for determining text formatting
    rc          As RECT        ' Region of the DC to draw to (in twips)
    rectPage    As RECT    ' Region of the entire DC (page size) (in twips)
    chrg        As CharRange ' Range of text to draw (see above declaration)
End Type

Private Declare Function GetDeviceCaps Lib "gdi32" (ByVal hDC As Long, ByVal nIndex As Long) As Long
' Win32 Declarations for Cut, Copy, Paste and Delete
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long

'---------------end of printing

Private Const WM_USER As Long = &H400
Private Const EM_FORMATRANGE As Long = WM_USER + 57
Private Const EM_SETTARGETDEVICE As Long = WM_USER + 72
Private Const PHYSICALOFFSETX As Long = 112
Private Const PHYSICALOFFSETY As Long = 113

'Public Const CB_FINDSTRINGEXACT = &H158
Public Const CB_FINDSTRING = &H14C
'Public Const CB_ERR = (-1)

Private Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, ByVal lpDeviceName As String, ByVal lpOutput As Long, ByVal lpInitData As Long) As Long

Public Sub PrintPreview(RTF As RichTextBox, LeftMarginWidth As Currency, TopMarginHeight As Currency, RightMarginWidth As Currency, BottomMarginHeight As Currency, pgOrientation As Integer, ToDisplayPage As Long)
      
Dim LeftOffset          As Long, TopOffset      As Long
Dim LeftMargin          As Long, TopMargin      As Long
Dim RightMargin         As Long, BottomMargin   As Long
Dim Frange              As FormatRange
Dim rectDrawTo          As RECT
Dim rectPage            As RECT
Dim TextLength          As Long
Dim NextCharPosition    As Long
Dim L                   As Long
Dim iCount              As Integer

    On Error GoTo WriteMyError
        
    'Set the orientation of the printer
    Printer.Orientation = pgOrientation
    Printer.ScaleMode = vbTwips

    ' Calculate the Left, Top, Right, and Bottom margins
    LeftMargin = CLng(LeftMarginWidth - LeftOffset)
    TopMargin = CLng(TopMarginHeight - TopOffset)
    RightMargin = CLng((Printer.Width - RightMarginWidth) - LeftOffset)
    BottomMargin = CLng((Printer.Height - BottomMarginHeight) - TopOffset)

    ' Set printable area rect
    rectPage.left = 0
    rectPage.top = 0
    rectPage.Right = Printer.ScaleWidth
    rectPage.Bottom = Printer.ScaleHeight

    ' Set rect in which to print (relative to printable area)
    rectDrawTo.left = LeftMargin
    rectDrawTo.top = TopMargin
    rectDrawTo.Right = RightMargin
    rectDrawTo.Bottom = BottomMargin

    SizePreview Printer.Width, Printer.Height

    Frange.hDC = frmPreview.picPreview(0).hDC
    Frange.hdcTarget = frmPreview.picPreview(0).hDC
    Frange.rc = rectDrawTo
    Frange.rectPage = rectPage
    Frange.chrg.cpMin = 0
    Frange.chrg.cpMax = -1

    TextLength = Len(RTF.Text)

    Dim iPage As Integer
    
    iPage = 1
    frmPreview.cboTable.Clear
    frmPreview.cboTable.Enabled = False
    
    Do
        frmPreview.cboTable.AddItem "Page " & iPage
        If iPage = ToDisplayPage + 1 Then
            Frange.hDC = frmPreview.picPreview(0).hDC
            Frange.hdcTarget = frmPreview.picPreview(0).hDC
            frmPreview.picPreview(0).Print
        Else
            Frange.hDC = frmPreview.picPreview(1).hDC
            Frange.hdcTarget = frmPreview.picPreview(1).hDC
            frmPreview.picPreview(1).Print
        End If
        NextCharPosition = SendMessage(RTF.hWnd, EM_FORMATRANGE, True, Frange)
        If NextCharPosition >= TextLength Then Exit Do  'If done then exit
        Frange.chrg.cpMin = NextCharPosition ' Starting position for next page
        iPage = iPage + 1
'        K = K + 1
'        If K Mod 300 = 0 Then
'            DoEvents: K = 0: If UnFreeze = True Then UnFreeze = False: Exit Do
'        End If
    Loop
    frmPreview.cboTable.Tag = "Process"
    frmPreview.cboTable.ListIndex = ToDisplayPage
    frmPreview.cboTable.Tag = ""
    frmPreview.cboTable.Enabled = True

    L = SendMessage(RTF.hWnd, EM_FORMATRANGE, False, ByVal CLng(0))
    
    frmPreview.Preview_Activate

    Exit Sub
    
WriteMyError:
    Select Case Err.Number
        Case 482
            MsgBox App.EXEName & " couldn't find an installed printer.  Install a Windows-compatible printer and try again.", vbCritical, "No Windows-printer found."
            Exit Sub
        Case Else
            MsgBox Err.Number & " " & Err.Description
            Resume Next
    End Select
    
End Sub

Private Sub AddPage(PageNumber As Integer)
    If PageNumber > 1 Then
        Load frmPreview.picPreview(PageNumber - 1)
        Set frmPreview.picPreview(PageNumber - 1) = Nothing
        frmPreview.cboTable.AddItem "Page " & PageNumber
    End If
End Sub

Public Sub SizePreview(lWidth As Long, lHeight As Long)
    Dim iCount As Integer
    For iCount = 0 To frmPreview.picPreview.count - 1
        With frmPreview.picPreview(iCount)
            .left = 0
            .top = 0
            .Width = lWidth
            .Height = lHeight
        End With
    Next
    frmPreview.picChild.Move 0, 0, lWidth, lHeight
End Sub

Public Sub PrintRTF(RTF As RichTextBox, LeftMarginWidth As Long, TopMarginHeight, RightMarginWidth, BottomMarginHeight)
    '** Print the active document
    On Error GoTo WriteMyError
    Dim LeftOffset          As Long, TopOffset      As Long
    Dim LeftMargin          As Long, TopMargin      As Long
    Dim RightMargin         As Long, BottomMargin   As Long
    Dim Frange              As FormatRange
    Dim rectDrawTo          As RECT
    Dim rectPage            As RECT
    Dim TextLength          As Long
    Dim NextCharPosition    As Long
    Dim L                   As Long

    ' Start a print job to get a valid Printer.hDC
    Printer.Print Space(1)
    Printer.ScaleMode = vbTwips

    ' Get the offsett to the printable area on the page in twips
    LeftOffset = Printer.ScaleX(GetDeviceCaps(Printer.hDC, PHYSICALOFFSETX), vbPixels, vbTwips)
    TopOffset = Printer.ScaleY(GetDeviceCaps(Printer.hDC, PHYSICALOFFSETY), vbPixels, vbTwips)

    ' Calculate the Left, Top, Right, and Bottom margins
    LeftMargin = LeftMarginWidth - LeftOffset
    TopMargin = TopMarginHeight - TopOffset
    RightMargin = (Printer.Width - RightMarginWidth) - LeftOffset
    BottomMargin = (Printer.Height - BottomMarginHeight) - TopOffset

    ' Set printable area rect
    rectPage.left = 0
    rectPage.top = 0
    rectPage.Right = Printer.ScaleWidth
    rectPage.Bottom = Printer.ScaleHeight

    ' Set rect in which to print (relative to printable area)
    rectDrawTo.left = LeftMargin
    rectDrawTo.top = TopMargin
    rectDrawTo.Right = RightMargin
    rectDrawTo.Bottom = BottomMargin

    ' Set up the print instructions
    Frange.hDC = Printer.hDC            ' Use the same DC for measuring and rendering
    Frange.hdcTarget = Printer.hDC      ' Point at printer hDC
    Frange.rc = rectDrawTo              ' Indicate the area on page to draw to
    Frange.rectPage = rectPage          ' Indicate entire size of page
    Frange.chrg.cpMin = 0               ' Indicate start of text through
    Frange.chrg.cpMax = -1              ' end of the text

    ' Get length of text in RTF
    TextLength = Len(RTF.Text)

    ' Loop printing each page until done
    Do
        ' Print the page by sending EM_FORMATRANGE message
        NextCharPosition = SendMessage(RTF.hWnd, EM_FORMATRANGE, True, Frange)
        If NextCharPosition >= TextLength Then Exit Do  'If done then exit
        Frange.chrg.cpMin = NextCharPosition ' Starting position for next page
        Printer.NewPage                  ' Move on to next page
        Printer.Print Space(1) ' Re-initialize hDC
        Frange.hDC = Printer.hDC
        Frange.hdcTarget = Printer.hDC
'        K = K + 1
'        If K Mod 300 = 0 Then
'            DoEvents: K = 0: If UnFreeze = True Then UnFreeze = False: Exit Do
'        End If
    Loop

    ' Commit the print job
    Printer.EndDoc

    ' Allow the RTF to free up memory
    L = SendMessage(RTF.hWnd, EM_FORMATRANGE, False, ByVal CLng(0))
Exit Sub
WriteMyError:
End Sub

Public Sub ScanPrinters(istree As Boolean, TheImage As String, Optional TheRelative As String)
Dim pPrinter        As Printer
Dim sPrinter        As String

    For Each pPrinter In Printers
        sPrinter = pPrinter.DeviceName & " on " & pPrinter.Port
        If istree = True Then
            If left$(pPrinter.Port, 2) = "\\" Then ' network printed
'                mdiMain.trview.Nodes.add TheRelative, tvwChild, TheRelative & "\" & sPrinter, sPrinter & " Remote", TheImage
            Else
'                mdiMain.trview.Nodes.add TheRelative, tvwChild, TheRelative & "\" & pPrinter.DeviceName, sPrinter & " Local", TheImage
            End If
        Else
            TheImage = TheImage & vbCrLf & sPrinter
        End If
    Next pPrinter
End Sub

Private Function TrimStr(StrName As String) As String
    'Finds a null then trims the string
    Dim X As Integer

    X = InStr(StrName, vbNullChar)
    If X > 0 Then TrimStr = left(StrName, X - 1) Else TrimStr = StrName
End Function

Private Function LPSTRtoSTRING(ByVal lngPointer As Long) As String
    Dim lngLength As Long

    'Get number of characters in string
    lngLength = lstrlenW(lngPointer) * 2
    'Initialize string so we have something to copy the string into
    LPSTRtoSTRING = String(lngLength, 0)
    'Copy the string
    CopyMem ByVal StrPtr(LPSTRtoSTRING), ByVal lngPointer, lngLength
    'Convert to Unicode
    LPSTRtoSTRING = TrimStr(StrConv(LPSTRtoSTRING, vbUnicode))
End Function

'Get the number of Jobs in the specified Printer Queue (max 128)... the PrinterName can be a network path: "\\MYSERVER\MYPRINTER"
Function GetPrinterQueue(PrinterName As String) As Long
    Dim PrinterStruct       As PRINTER_DEFAULTS
    Dim HPrinter            As Long
    Dim ret                 As Boolean
    Dim Jobs(0 To 127)      As JOB_INFO_1_API
    Dim pcbNeeded           As Long
    Dim pcReturned          As Long
    Dim i                   As Integer
    Dim TempBuff            As Long

    'Initialize the Printer structure
    PrinterStruct.pDatatype = vbNullString
    PrinterStruct.pDevMode.dmSize = Len(PrinterStruct.pDevMode)
    PrinterStruct.DesiredAccess = PRINTER_ACCESS_USE
    'Get the printer Handle
    ret = OpenPrinter(PrinterName, HPrinter, PrinterStruct)
    'Get the Printer active jobs
    ret = EnumJobs(HPrinter, 0, 127, 1, TempBuff, 0, pcbNeeded, pcReturned)
    If pcbNeeded = 0 Then
        GetPrinterQueue = 0
    Else
        'Allocate the Buffer
        TempBuff = HeapAlloc(GetProcessHeap(), 0, pcbNeeded)
        ret = EnumJobs(HPrinter, 0, 127, 1, TempBuff, pcbNeeded, pcbNeeded, pcReturned)
        CopyMem Jobs(0), ByVal TempBuff, pcbNeeded
            ReDim Preserve JobsDesc(pcReturned - 1)
            For i = 0 To pcReturned - 1
                JobsDesc(i).pPrinterName = LPSTRtoSTRING(Jobs(i).pPrinterName)
                JobsDesc(i).pMachineName = LPSTRtoSTRING(Jobs(i).pMachineName)
                JobsDesc(i).pUserName = LPSTRtoSTRING(Jobs(i).pUserName)
                JobsDesc(i).pDocument = LPSTRtoSTRING(Jobs(i).pDocument)
                JobsDesc(i).pDatatype = LPSTRtoSTRING(Jobs(i).pDatatype)
                JobsDesc(i).pStatus = LPSTRtoSTRING(Jobs(i).pStatus)
                JobsDesc(i).JobId = Jobs(i).JobId
                JobsDesc(i).Status = Jobs(i).Status
                JobsDesc(i).Priority = Jobs(i).Priority
                JobsDesc(i).Position = Jobs(i).Position
                JobsDesc(i).TotalPages = Jobs(i).TotalPages
                JobsDesc(i).PagesPrinted = Jobs(i).PagesPrinted
                JobsDesc(i).Submitted = Jobs(i).Submitted
            Next
        If TempBuff Then HeapFree GetProcessHeap(), 0, TempBuff
        GetPrinterQueue = pcReturned
    End If
    'Close printer
    ret = CloseHandle(HPrinter)
End Function


VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmLabel 
   AutoRedraw      =   -1  'True
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Preview Label"
   ClientHeight    =   6195
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9915
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmLabel.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6195
   ScaleWidth      =   9915
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraSettings 
      Caption         =   "Settings"
      Height          =   1755
      Left            =   120
      TabIndex        =   14
      Top             =   1680
      Visible         =   0   'False
      Width           =   3915
      Begin VB.CommandButton cmdSettings 
         Caption         =   "Label Size"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   17
         Top             =   780
         Width           =   1035
      End
      Begin VB.CommandButton cmdSettings 
         Caption         =   "Label Font"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   16
         Top             =   1260
         Width           =   1035
      End
      Begin VB.CommandButton cmdSettings 
         Caption         =   "Orientation"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   120
         TabIndex        =   15
         Top             =   300
         Width           =   1035
      End
      Begin VB.Label lblOrientation 
         Caption         =   "= s|o|p"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1200
         TabIndex        =   20
         Top             =   360
         Width           =   2535
      End
      Begin VB.Label lblLabelSize 
         Caption         =   "= s|s|inch|1|3"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1200
         TabIndex        =   19
         Top             =   840
         Width           =   2535
      End
      Begin VB.Label lblLabelFont 
         Caption         =   "= s|f|Arial|8|true"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1200
         TabIndex        =   18
         Top             =   1320
         Width           =   2535
      End
   End
   Begin VB.CommandButton cmdInfo 
      Caption         =   "View Info about Codes and Formats"
      Height          =   375
      Left            =   120
      TabIndex        =   13
      Top             =   5100
      Width           =   3915
   End
   Begin VB.TextBox txtData 
      Height          =   360
      Left            =   4380
      TabIndex        =   11
      ToolTipText     =   "Enter sample data in order of appearance in the Label Definition, separated by pipes, ex. ""1234|ABC|01/01/2002""."
      Top             =   720
      Width           =   4395
   End
   Begin VB.ComboBox cboPrinter 
      Height          =   360
      Left            =   4380
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   5040
      Width           =   3315
   End
   Begin MSComDlg.CommonDialog cdlgDef 
      Left            =   1260
      Top             =   5580
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      CancelError     =   -1  'True
      Filter          =   "*.def|*.def"
      InitDir         =   "C:\"
   End
   Begin VB.CommandButton cmdLabel 
      Caption         =   "Open"
      Height          =   435
      Index           =   4
      Left            =   120
      TabIndex        =   6
      ToolTipText     =   "Print the Label."
      Top             =   5640
      Width           =   975
   End
   Begin VB.TextBox txtLabelDef 
      Height          =   4275
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   5
      Top             =   540
      Width           =   3915
   End
   Begin VB.CommandButton cmdLabel 
      Caption         =   "Print"
      Enabled         =   0   'False
      Height          =   435
      Index           =   3
      Left            =   7740
      TabIndex        =   4
      ToolTipText     =   "Print the Label."
      Top             =   4980
      Width           =   975
   End
   Begin VB.CommandButton cmdLabel 
      Caption         =   "Save"
      Enabled         =   0   'False
      Height          =   435
      Index           =   2
      Left            =   1980
      TabIndex        =   3
      ToolTipText     =   "Print the Label."
      Top             =   5640
      Width           =   975
   End
   Begin VB.CommandButton cmdLabel 
      Caption         =   "Exit"
      Height          =   435
      Index           =   0
      Left            =   3060
      TabIndex        =   2
      ToolTipText     =   "Transfer the Item."
      Top             =   5640
      Width           =   975
   End
   Begin VB.CommandButton cmdLabel 
      Caption         =   "Preview"
      Height          =   435
      Index           =   1
      Left            =   8820
      TabIndex        =   1
      ToolTipText     =   "Print the Label."
      Top             =   660
      Width           =   975
   End
   Begin VB.PictureBox picPreview 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00FFFFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1507
      Left            =   4380
      ScaleHeight     =   96
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   288
      TabIndex        =   0
      Top             =   1860
      Width           =   4387
   End
   Begin VB.Label lblSampleData 
      Caption         =   "Sample Data:"
      Height          =   315
      Left            =   4380
      TabIndex        =   12
      Top             =   420
      Width           =   4395
   End
   Begin VB.Label lblPrinter 
      Caption         =   "Printer:"
      Height          =   315
      Left            =   4380
      TabIndex        =   10
      Top             =   4740
      Width           =   3315
   End
   Begin VB.Label lblPreview 
      Caption         =   "Label Preview:"
      Height          =   255
      Left            =   4380
      TabIndex        =   8
      Top             =   1560
      Width           =   4395
   End
   Begin VB.Label lblDef 
      Caption         =   "Label Definition:"
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   240
      Width           =   3915
   End
   Begin VB.Line Line1 
      X1              =   4200
      X2              =   4200
      Y1              =   -60
      Y2              =   6180
   End
End
Attribute VB_Name = "frmLabel"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Option Compare Text

Private m_sDefFile As String
Private m_bLoading As Boolean

Private m_bPortrait As Boolean

Private Sub cmdInfo_Click()
    frmInfo.Show
End Sub

Private Sub cmdLabel_Click(Index As Integer)

    Me.MousePointer = vbHourglass
    
    Dim oFSO As New FileSystemObject
    Dim tsDef As TextStream
    Dim sTemp As String
    Dim lResult As Long
    Dim i As Long
    Dim sLine() As String
    Dim bFound As Boolean
    
    Select Case Index
        Case 0  'Exit
            Unload Me
            
        Case 1  'Preview Label
            PreviewLabel txtLabelDef.Text, txtData.Text
            cmdLabel(3).Enabled = True
            
        Case 2  'Save
            Err.Clear
            On Error Resume Next
            
            With cdlgDef
                .DialogTitle = "Save Label Definition"
                If LenB(m_sDefFile) > 0 Then
                    .FileName = m_sDefFile
                End If
                
                .ShowSave
            End With
            
            If Err.Number = 0 Then
                m_sDefFile = cdlgDef.FileName
                
                'Add .def extension if necessary
                If Right$(m_sDefFile, 4) <> ".def" Then
                    m_sDefFile = m_sDefFile & ".def"
                End If
                
                'Save the file
                lResult = vbYes
                If oFSO.FileExists(m_sDefFile) Then
                    lResult = MsgBox("The file already exists.  Do you want to overwrite?", vbQuestion + vbYesNo, App.Title)
                End If
                
                If lResult = vbYes Then
                    cmdLabel(2).Enabled = False
                    sLine = Split(txtLabelDef.Text, vbCrLf)
                    
                    If LenB(txtLabelDef.Text) > 0 Then
                        Set tsDef = oFSO.CreateTextFile(m_sDefFile, True)
                        
                        For i = 0 To UBound(sLine)
                            If i < UBound(sLine) Then
                                tsDef.WriteLine sLine(i)
                            Else
                                tsDef.Write sLine(i)
                            End If
                        Next
                        
                        tsDef.Close
                    End If
                End If
            End If
            
            On Error GoTo 0
            
        Case 3  'Print
            If cboPrinter.Text = "File" Then
                picPreview.Picture = picPreview.Image
                SavePicture picPreview.Picture, App.Path & "\test.bmp"
                
                MsgBox "The label was saved as " & App.Path & "\test.bmp.", vbInformation + vbOKOnly, "Label Maker"
                
            ElseIf cboPrinter.Text <> "None" Then
                bFound = False
                For i = 0 To Printers.Count - 1
                    If Printers(i).DeviceName = cboPrinter.Text Then
                        Set Printer = Printers(i)
                        bFound = True
                        Exit For
                    End If
                Next
                
                If bFound Then
                    'Set orientation
                    Printer.Orientation = 1
                    If Not m_bPortrait Then
                        Printer.Orientation = 2
                    End If
                    
                    'Print label
                    picPreview.Picture = picPreview.Image
                    Printer.PaintPicture picPreview.Picture, 0, 0
                    Printer.EndDoc
                Else
                    MsgBox "Unable to locate specified printer - " & cboPrinter.Text & ".  Please verify the printer settings.", vbExclamation + vbOKOnly, "Printing Label"
                End If
                
            Else
                MsgBox "Please select a printer.", vbExclamation + vbOKOnly, App.Title
            End If
            
        Case 4  'Open
            If cmdLabel(2).Enabled Then
                lResult = MsgBox("Do you wish to save the changes to the current label definition?", vbQuestion + vbYesNoCancel, App.Title)
                
                If lResult = vbYes Then
                    cmdLabel_Click 2
                ElseIf lResult = vbCancel Then
                    GoTo cmdLabel_Click_EXIT
                Else
                    'Do nothing
                End If
            End If
            
            m_bLoading = True
            
            Err.Clear
            On Error Resume Next
            
            With cdlgDef
                .DialogTitle = "Open a Label Definition File"
                .InitDir = App.Path
                
                .ShowOpen
            End With
            
            If Err.Number = 0 Then
                sTemp = cdlgDef.FileName
                
                If oFSO.FileExists(sTemp) Then
                    Set tsDef = oFSO.OpenTextFile(sTemp, ForReading, False, TristateFalse)
                    
                    txtLabelDef.Text = tsDef.ReadAll
                    
                    tsDef.Close
                End If
            Else
                sTemp = ""
            End If
            
            On Error GoTo 0
            
            cmdLabel(2).Enabled = False
            m_sDefFile = sTemp
            m_bLoading = False
            
    End Select
    
cmdLabel_Click_EXIT:
    Erase sLine
    Set tsDef = Nothing
    Set oFSO = Nothing
    
    Me.MousePointer = vbNormal
    
End Sub

Private Sub cmdSettings_Click(Index As Integer)

    Dim sTemp As String
    
    Select Case Index
        Case 0  'Insert Font
            Err.Clear
            On Error Resume Next
            
            With cdlgDef
                .ShowFont
            End With
            
            If Err.Number = 0 Then
                
            End If
            
            On Error GoTo 0
            
        Case 1  'Insert Label Size
            With frmLabelSize
                .Show vbModal
                
                If Not .Cancelled Then
                    
                End If
            End With
            
            Unload frmLabelSize
            
        Case 2  'Insert Orientation
            With frmOrientation
                .Show vbModal
                
                If Not .Cancelled Then
                    
                End If
            End With
            
            Unload frmOrientation
            
    End Select
    
    If Not m_bLoading Then
        cmdLabel(2).Enabled = True
    End If
    
End Sub

Private Sub Form_Load()

    Dim i As Long
    
    'Load printer list
    cboPrinter.Clear
    cboPrinter.AddItem "None"
    cboPrinter.AddItem "File"
    For i = 0 To Printers.Count - 1
        cboPrinter.AddItem Printers(i).DeviceName
    Next
    cboPrinter.ListIndex = 0
    
End Sub

Private Sub Form_Unload(Cancel As Integer)

    Dim lResult As Long
    
    If frmInfo.Visible Then
        Unload frmInfo
    End If
    
    If cmdLabel(2).Enabled Then
        lResult = MsgBox("Do you wish to save the changes to the current label definition?", vbQuestion + vbYesNoCancel, "Exit Label Maker")
        If lResult = vbYes Then
            cmdLabel_Click 2
            End
        ElseIf lResult = vbCancel Then
            Cancel = True
        Else
            End
        End If
    Else
        End
    End If
    
End Sub

Private Sub picPreview_Resize()

    With picPreview
        If (.Left + .Width) > Me.Width Then
            Me.Width = .Left + .Width + 175
        End If
    End With
    
End Sub

Private Sub txtLabelDef_Change()

    If Not m_bLoading Then
        cmdLabel(2).Enabled = True
    End If
    
End Sub

Private Sub PreviewLabel(ByVal sLabelDef As String, ByVal sLineData As String)

    Me.MousePointer = vbHourglass
    
    Dim lResult As Long
    Dim sLine() As String
    Dim sChunk() As String
    Dim sSampData() As String
    Dim sBarcode As String
    Dim i As Long
    Dim j As Long
    Dim iCalc As Integer
    Dim sPrinter As String
    Dim nVarCount As Long
    Dim nStart As Long
    Dim nPos As Long
    Dim nCurVar As Long
    Dim sVarName As String
    Dim sWork() As String
    Dim nSplit1 As Long
    Dim nSplit2 As Long
    Dim sTemp As String
    Dim sText1 As String
    Dim sText2 As String
    Dim bI25 As Boolean 'Barcode Format = I25 or Code39
    
    'Initialize Format
    bI25 = False
    
    'Split Label definition and sample data
    sLine = Split(sLabelDef, vbCrLf)
    sSampData = Split(sLineData, "|")
    
    'Initialize PictureBox - settings & dimensions
    picPreview.ScaleMode = vbPixels
    picPreview.Cls
    picPreview.Picture = Nothing
    picPreview.Refresh
    Me.Refresh
    
    'Process Label Definition
    nCurVar = 0
    For j = 0 To UBound(sLine)
        If Not VerifyLineData(sLine(j)) Then
            GoTo PreviewLabel_BAD_DATA
        End If
        
        sChunk = Split(sLine(j), "|")
        
        nStart = 1
        Select Case sChunk(0)
            Case "s"    'Setting
                If sChunk(1) = "c" Then
                    If sChunk(2) = "I25" Then
                        'Use I25 Barcode Format
                        bI25 = True
                    End If
                ElseIf sChunk(1) = "o" Then
                    'Set portrait or landscape
                    If sChunk(2) = "p" Then
                        m_bPortrait = True
                    Else
                        m_bPortrait = False
                    End If
                ElseIf sChunk(1) = "s" Then
                    'Set Scale mode
                    If sChunk(2) = "in" Then
                        picPreview.ScaleMode = vbInches
                    ElseIf sChunk(2) = "pix" Then
                        picPreview.ScaleMode = vbPixels
                    Else 'If sChunk(2) = "cm" Then
                        picPreview.ScaleMode = vbCentimeters
                    End If
                    
                    'Set label size
                    With picPreview
                        'Set height
                        If .ScaleHeight > CInt(sChunk(3)) Then
                            Do
                                .Height = .Height - 1
                            Loop Until .ScaleHeight < CInt(sChunk(3))
                        End If
                        
                        Do
                            .Height = .Height + 1
                        Loop Until .ScaleHeight > CInt(sChunk(3))
                        
                        .Height = .Height - 1
                        
                        'Set Width
                        If .ScaleWidth > CInt(sChunk(4)) Then
                            Do
                                .Width = .Width - 1
                            Loop Until .ScaleWidth < CInt(sChunk(4))
                        End If
                        
                        Do
                            .Width = .Width + 1
                        Loop Until .ScaleWidth > CInt(sChunk(4))
                        
                        .Width = .Width - 1
                        
                        'Reset the Scale mode
                        .ScaleMode = vbPixels
                    End With
                    
                ElseIf sChunk(1) = "f" Then
                    'Set label font
                    With picPreview
                        .Font = sChunk(2)
                        .FontSize = CInt(sChunk(3))
                        .FontBold = CBool(sChunk(4))
                        .FontItalic = CBool(sChunk(5))
                    End With
                End If
                
            Case "f"    'Frame
                'No other information listed on this line
                'Top
                picPreview.Line (0, 0)-(picPreview.ScaleWidth - 1, 0), &H0&, BF
                'Bottom
                picPreview.Line (0, picPreview.ScaleHeight - 1)-(picPreview.ScaleWidth - 1, picPreview.ScaleHeight - 1), &H0&, BF
                'Left Side
                picPreview.Line (0, 0)-(0, picPreview.ScaleHeight - 1), &H0&, BF
                'Right Side
                picPreview.Line (picPreview.ScaleWidth - 1, 0)-(picPreview.ScaleWidth - 1, picPreview.ScaleHeight - 1), &H0&, BF
                
            Case "b"    'Barcode
                'Barcode only contains actual barcode number -- no special formatting required
                nPos = InStr(1, sChunk(3), "~")
                If nPos > 0 Then
                    nStart = nPos + 1
                    sVarName = Mid$(sChunk(3), nPos, InStr(nStart, sChunk(3), "~") - nPos + 1)
                    sChunk(3) = Replace(sChunk(3), sVarName, sSampData(nCurVar))
                    nCurVar = nCurVar + 1
                End If
                
                'Generate Barcode
                If bI25 Then
                    Dim oI25Barcode As New clsI25Barcode
                    lResult = oI25Barcode.GenerateI25Barcode(picPreview, sChunk(3), sChunk(1), CLng(sChunk(2)))
                    Set oI25Barcode = Nothing
                Else
                    Dim oBarcode As New clsBarcode
                    lResult = oBarcode.GenerateBarCode(picPreview, sChunk(3), sChunk(1), CInt(sChunk(2)))
                    Set oBarcode = Nothing
                End If
                
            Case "t"    'Text
                'Print text on label, where a value of "c" for the x position
                'means center the entry on the label
                nPos = InStr(1, sChunk(3), "~")
                Do Until nPos = 0
                    nStart = nPos + 1
                    sVarName = Mid$(sChunk(3), nPos, InStr(nStart, sChunk(3), "~") - nPos + 1)
                    sChunk(3) = Replace(sChunk(3), sVarName, sSampData(nCurVar))
                    nCurVar = nCurVar + 1
                    
                    nStart = InStr(nStart, sChunk(3), "~") + 1
                    nPos = InStr(nStart, sChunk(3), "~")
                Loop
                
                'Print Text
                With picPreview
                    If sChunk(1) = "c" Then
                        iCalc = (.ScaleWidth - .TextWidth(sChunk(3))) / 2
                        .CurrentX = IIf(iCalc > 0, iCalc, 0)
                    ElseIf CLng(sChunk(1)) < 0 Then
                        .CurrentX = .ScaleWidth - .TextWidth(sChunk(3)) + CLng(sChunk(1))
                    Else 'If CLng(sChunk(1)) >= 0 Then
                        .CurrentX = CLng(sChunk(1))
                    End If
                    .CurrentY = CLng(sChunk(2))
                End With
                
                picPreview.Print sChunk(3)
                
            Case "d"    'Double-line Text
                'Print up to 2 lines of text on label, where a value of "c"
                'for the x position means center the entry on the label.
                nPos = InStr(1, sChunk(3), "~")
                Do Until nPos = 0
                    nStart = nPos + 1
                    sVarName = Mid$(sChunk(3), nPos, InStr(nStart, sChunk(3), "~") - nPos + 1)
                    sChunk(3) = Replace(sChunk(3), sVarName, sSampData(nCurVar))
                    nCurVar = nCurVar + 1
                    
                    nStart = InStr(nStart, sChunk(3), "~") + 1
                    nPos = InStr(nStart, sChunk(3), "~")
                Loop
                
                'Chunk up text
                sWork = Split(sChunk(3), " ")
                
                '****************
                '* First Line
                '****************
                'Initialize
                nSplit1 = 0
                sTemp = ""
                sText1 = ""
                
                'Determine split points
                For i = 0 To UBound(sWork)
                    sTemp = sTemp & IIf(i > 0, " ", "") & sWork(i)
                    If picPreview.TextWidth(sTemp) > picPreview.ScaleWidth Then
                        nSplit1 = i - 1
                        Exit For
                    End If
                Next
                If nSplit1 = 0 Then
                    nSplit1 = UBound(sWork)
                End If
                For i = 0 To nSplit1
                    sText1 = sText1 & IIf(i > 0, " ", "") & sWork(i)
                Next
                
                'Print Text
                With picPreview
                    If sChunk(1) = "c" Then
                        iCalc = (.ScaleWidth - .TextWidth(sText1)) / 2
                        .CurrentX = IIf(iCalc > 0, iCalc, 0)
                    ElseIf CLng(sChunk(1)) < 0 Then
                        .CurrentX = .ScaleWidth - .TextWidth(sText1) + CLng(sChunk(1))
                    Else 'If CLng(sChunk(1)) >= 0 Then
                        .CurrentX = CLng(sChunk(1))
                    End If
                    .CurrentY = CLng(sChunk(2))
                End With
                
                picPreview.Print sText1
                
                '****************
                '* Second Line
                '****************
                If nSplit1 < UBound(sWork) Then
                    'Initialize
                    nSplit1 = nSplit1 + 1
                    nSplit2 = 0
                    sTemp = ""
                    sText2 = ""
                    
                    'Determine split points
                    For i = nSplit1 To UBound(sWork)
                        sTemp = sTemp & IIf(i > nSplit1, " ", "") & sWork(i)
                        If picPreview.TextWidth(sTemp) > picPreview.ScaleWidth Then
                            nSplit2 = i - 1
                            Exit For
                        End If
                    Next
                    If nSplit2 = 0 Then
                        nSplit2 = UBound(sWork)
                    End If
                    For i = nSplit1 To nSplit2
                        sText2 = sText2 & IIf(i > 0, " ", "") & sWork(i)
                    Next
                    
                    'Print Text
                    With picPreview
                        If sChunk(1) = "c" Then
                            iCalc = (.ScaleWidth - .TextWidth(sText2)) / 2
                            .CurrentX = IIf(iCalc > 0, iCalc, 0)
                        ElseIf CLng(sChunk(1)) < 0 Then
                            .CurrentX = .ScaleWidth - .TextWidth(sText2) + CLng(sChunk(1))
                        Else 'If CLng(sChunk(1)) >= 0 Then
                            .CurrentX = CLng(sChunk(1))
                        End If
                        .CurrentY = CLng(sChunk(2)) + .TextHeight(sText1) + 1
                    End With
                    
                    picPreview.Print sText2
                End If
                
        End Select
        
PreviewLabel_BAD_DATA:
    Next
    
PreviewLabel_EXIT:
    picPreview.Refresh
    Me.Refresh
    
    Erase sSampData
    Erase sChunk
    Erase sLine
    Erase sWork
    
    Me.MousePointer = vbNormal
    
End Sub

Private Function VerifyLineData(ByVal sLineData As String) As Boolean

    VerifyLineData = True
    
    Dim sChunk() As String
    Dim sErrMsg As String
    
    sErrMsg = ""
    If LenB(sLineData) > 0 Then
        sChunk = Split(sLineData, "|")
    Else
        ReDim sChunk(0)
        sChunk(0) = ""
    End If
    
    'Verify the line data based on first character (ie line type)
    Select Case sChunk(0)
        Case "s"
            If sChunk(1) = "c" Then
                If sChunk(2) <> "I25" And sChunk(2) <> "C39" Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for Barcode Format."
                End If
            ElseIf sChunk(1) = "o" Then
                If sChunk(2) <> "p" And sChunk(2) <> "l" Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for orientation."
                ElseIf UBound(sChunk) > 2 Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains extra information."
                End If
            ElseIf sChunk(1) = "s" Then
                If sChunk(2) <> "in" And sChunk(2) <> "pix" And sChunk(2) <> "cm" Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for scale."
                ElseIf Not (IsNumeric(sChunk(3)) And IsNumeric(sChunk(4))) Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for height and/or width."
                ElseIf UBound(sChunk) > 4 Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains extra information."
                End If
            ElseIf sChunk(1) = "f" Then
                If Not IsNumeric(sChunk(3)) Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for the font size."
                ElseIf sChunk(4) <> "true" And sChunk(4) <> "false" Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for the bold setting."
                ElseIf sChunk(5) <> "true" And sChunk(5) <> "false" Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains an invalid value for the italics setting."
                ElseIf UBound(sChunk) > 5 Then
                    sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                              sLineData & vbCrLf & vbCrLf & _
                              "contains extra information."
                End If
            Else
                sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                          sLineData & vbCrLf & vbCrLf & _
                          "contains an invalid setting type."
            End If
        Case "f"
            If UBound(sChunk) > 0 Then
                sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                          sLineData & vbCrLf & vbCrLf & _
                          "contains extra information," & vbCrLf & _
                          "when only an 'f' is required."
            End If
            
        Case "b", "t", "d"
            If Not ((sChunk(1) = "c" Or IsNumeric(sChunk(1))) And IsNumeric(sChunk(2))) Then
                sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                          sLineData & vbCrLf & vbCrLf & _
                          "contains an invalid positional value."
            ElseIf UBound(sChunk) > 3 Then
                sErrMsg = "The following line," & vbCrLf & vbCrLf & _
                          sLineData & vbCrLf & vbCrLf & _
                          "contains extra information."
            End If
            
        Case Else
            If LenB(Trim(sLineData)) = 0 Then
                sErrMsg = "A blank line was encountered." & vbCrLf & "Please remove/replace the blank line."
            Else
                sErrMsg = "The following line:" & vbCrLf & vbCrLf & _
                          sLineData & vbCrLf & vbCrLf & _
                          "contains invalid information."
            End If
            
    End Select
    
    Erase sChunk
    
    If LenB(sErrMsg) > 0 Then
        VerifyLineData = False
        MsgBox sErrMsg & vbCrLf & vbCrLf & "Please verify the Label definition.", vbExclamation + vbOKOnly, "Error Generating the Label"
    End If
    
End Function

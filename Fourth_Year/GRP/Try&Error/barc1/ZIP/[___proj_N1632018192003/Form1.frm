VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Trial Details"
   ClientHeight    =   4695
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10815
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4695
   ScaleWidth      =   10815
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtDate 
      Height          =   375
      Left            =   5880
      TabIndex        =   26
      Top             =   1320
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Confirm"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   8520
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   3600
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.ListBox List1 
      Height          =   2400
      Left            =   8160
      TabIndex        =   22
      Top             =   600
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   5880
      TabIndex        =   21
      Top             =   600
      Visible         =   0   'False
      Width           =   2175
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00FFFFFF&
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   3480
      Width           =   1095
   End
   Begin VB.TextBox Text6 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   2057
         SubFormatType   =   1
      EndProperty
      Height          =   285
      Left            =   1800
      TabIndex        =   11
      Text            =   "0"
      Top             =   3000
      Width           =   2535
   End
   Begin VB.TextBox Text5 
      BeginProperty DataFormat 
         Type            =   5
         Format          =   ""
         HaveTrueFalseNull=   1
         TrueValue       =   "Y"
         FalseValue      =   "N"
         NullValue       =   ""
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   2057
         SubFormatType   =   7
      EndProperty
      Height          =   285
      Left            =   1800
      TabIndex        =   9
      Text            =   "Y"
      Top             =   2520
      Width           =   2535
   End
   Begin VB.TextBox Text4 
      Height          =   285
      Left            =   1800
      TabIndex        =   7
      Text            =   "000"
      Top             =   2040
      Width           =   2535
   End
   Begin VB.TextBox Text3 
      Height          =   285
      Left            =   1800
      TabIndex        =   5
      Text            =   "NI"
      Top             =   1560
      Width           =   2535
   End
   Begin VB.TextBox Text2 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "yy"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   2057
         SubFormatType   =   0
      EndProperty
      Height          =   285
      Left            =   1800
      TabIndex        =   3
      Text            =   "00"
      Top             =   1080
      Width           =   2535
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   1800
      TabIndex        =   1
      Text            =   "WC"
      ToolTipText     =   "Eg WC"
      Top             =   600
      Width           =   2535
   End
   Begin VB.Label Label10 
      BackColor       =   &H00FFFFFF&
      Caption         =   "Date"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5880
      TabIndex        =   27
      Top             =   1080
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "Trial details"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   25
      Top             =   240
      Width           =   2535
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Seperation details"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5880
      TabIndex        =   24
      Top             =   240
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Label lblNoFactors 
      Height          =   15
      Left            =   5040
      TabIndex        =   20
      Top             =   2760
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblLen 
      Height          =   15
      Left            =   5040
      TabIndex        =   19
      Top             =   2400
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblDesign 
      Height          =   15
      Left            =   5040
      TabIndex        =   18
      Top             =   2040
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblNoSubBlocks 
      Height          =   15
      Left            =   5040
      TabIndex        =   17
      Top             =   1680
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblNoVar 
      Height          =   15
      Left            =   5040
      TabIndex        =   16
      Top             =   1320
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblReps 
      Height          =   15
      Left            =   5040
      TabIndex        =   15
      Top             =   960
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label lblFirstplot 
      Height          =   15
      Left            =   5160
      TabIndex        =   14
      Top             =   600
      Visible         =   0   'False
      Width           =   15
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "Please enter the trial details."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   600
      TabIndex        =   13
      Top             =   4200
      Width           =   3855
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Cut number"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   10
      Top             =   3000
      Width           =   1935
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Management"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   8
      Top             =   2520
      Width           =   1935
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Trial"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   6
      Top             =   2040
      Width           =   1935
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Region"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   4
      Top             =   1560
      Width           =   1935
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Year"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   2
      Top             =   1080
      Width           =   1935
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Crop"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   0
      Top             =   600
      Width           =   1935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub Command1_Click()
    Dim lineoftext As String

    Dim crop As String, year As String, Reg As String, trial As String, man As String


    'put text into variables
     usrCrop = Text1.Text
     usrYear = Text2.Text
     usrReg = Text3.Text
     usrTrial = Text4.Text
     usrMan = Text5.Text
     usrCutNum = Text6.Text

    'convert strings to uppercase, for comparison to textfile
    UCase usrCrop
    UCase usrYear
    UCase usrReg
    UCase usrTrial
    UCase usrMan
    UCase usrCutNum

    'open the trials file

    Open "c:" & "\trialcontrolfile.txt" For Input As #1
    match = 0
    'read in the  trials control file, 2lines at a time
    Do While Not EOF(1) And match = 0
        Line Input #1, lineoftext                                                                                          'the first line
        Input #1, Firstplot, Reps, NoVar, NoSubBlocks, Design, PlotLen, NoFactors              'the second line
        crop = ValInString(lineoftext)
        year = ValInString(lineoftext)
        Reg = ValInString(lineoftext)
        trial = ValInString(lineoftext)
        man = ValInString(lineoftext)
        
    'Check for match
 If usrCrop = UCase(crop) And usrYear = UCase(year) And usrReg = UCase(Reg) And usrTrial = trial And usrMan = UCase(man) Then
        'match found, exit while
        match = 1
    End If
        'match not found, read next 2 lines.

    Loop
    
Close #1
  'No matching file exists, tell the user
    If match = 0 Then
        MsgBox "Sorry, No such trial exists in the trials control file. Please try again.", vbOKOnly, "Record not found."
        Text1.SetFocus         '  go back to start.
    End If

    If match = 1 Then
        ' matching file exists, no determine if corresponding output files exist
        filematch = 0
 
         randfile = (crop & year & Reg & trial & man & usrCutNum & ".RND")       'the name of the random access file
        seqfile = (crop & year & Reg & trial & man & usrCutNum & ".SEQ")         'the name of the sequential access file
        CurrentPath = App.Path & "\randomfiles\"
        noPlots = (Reps * NoVar)    'Work out the number of plots involved
    
    If Dir(randfile) = "" Then      'check dosnt exist
        'create new file and fill with 0's
        Open randfile For Random As #1
          Put #1, 1, datarecord
          datarecord.plotNo = "00000"
          Dim i As Integer
        For i = 1 To 9
          Put #1, 1, datarecord
          datarecord.weight(i) = "0000000000"
        Next i

            
        For i = 1 To noPlots + 1
          Put #1, i, datarecord
        Next i
        Close #1    'show option for input type + trial date
                    Label8.Visible = True
                    Command2.Visible = True
                    List1.Visible = True
                    Combo1.Visible = True
                    Me.Width = 10650
                    txtDate.Text = Left$(Now(), 10)
                    txtDate.Visible = True
                    Label10.Visible = True
                    Command1.Visible = False
        Else
        Load Form2
        Form2.Show
        Me.Hide
    End If
End If
                
End Sub

Function ValInString(lineoftext)
    ' function to split up the string to get the variables
    locspace = InStr(lineoftext, " ")
    If locspace = 0 And Len(lineoftext) > 0 Then
        ValInString = lineoftext
    Else
        ValInString = Left(lineoftext, locspace - 1)
        lineoftext = Right(lineoftext, (Len(lineoftext)) - locspace)
    End If

End Function

Public Sub Command2_Click()

    'input details to sequential file
    'close file
    Open seqfile For Output As #2
    Write #2, Firstplot, Reps, NoVar, NoSubBlocks, Design, PlotLen, NoFactors, "Separation", "NoSeps", txtDate.Text
    Load Form2
    Close #2
    Form2.Show
    Unload Me
End Sub











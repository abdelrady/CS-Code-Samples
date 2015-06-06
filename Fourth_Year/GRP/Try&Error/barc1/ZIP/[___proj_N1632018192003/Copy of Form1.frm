VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFFFFF&
   Caption         =   "Trial Details"
   ClientHeight    =   4695
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5100
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4695
   ScaleWidth      =   5100
   StartUpPosition =   3  'Windows Default
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
      Caption         =   "Managed?"
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
Dim usrcrop As String, usryear As String, usrReg As String, usrtrial As String
Dim usrman As String, usrCutnum As String
Dim crop As String, year As String, Reg As String, trial As String, man As String

'put text into variables
    Text1.Text = usrcrop
    Text2.Text = usryear
    Text3.Text = usrReg
    Text4.Text = usrtrial
    Text5.Text = usrman
    Text6.Text = usrCutnum

'convert strings to uppercase
    UCase usrcrop
    UCase usryear
    UCase usrReg
    UCase usrtrial
    UCase usrman
    UCase usrCutnum

'open the trials file

Open "c:" & "\trialcontrolfile.txt" For Input As #1
While Not EOF(1)
Line Input #1, lineoftext
Input #1, FirstPlot, Reps, NoVar, NoSubBlocks, Design, PlotLen, NoFactors

Wend
Close #1
Label7.Caption = (usrcrop & " " & usryear & " " & usrReg & " " & usrtrial & " " & usrman & " " & usrCutnum)
'compare strings eg crop to usrcrop

End Sub











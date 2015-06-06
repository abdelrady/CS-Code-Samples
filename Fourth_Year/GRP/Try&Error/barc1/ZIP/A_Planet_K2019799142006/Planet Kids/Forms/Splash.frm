VERSION 5.00
Begin VB.Form fSplash 
   BorderStyle     =   0  'None
   Caption         =   "Loading..."
   ClientHeight    =   3660
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5265
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   244
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   351
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Interval        =   2000
      Left            =   225
      Top             =   720
   End
   Begin VB.Timer Timer1 
      Left            =   225
      Top             =   195
   End
End
Attribute VB_Name = "fSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function SetWindowPos Lib "user32.dll" (ByVal Hwnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Const HWND_TOPMOST As Long = -1
    Private Const SWP_NOACTIVATE As Long = &H10
    Private Const SWP_NOSIZE As Long = &H1

Private Sub Form_Load()
    On Error Resume Next
    
    BackColor = cINI.Value("Settings", "Back_Color", BackColor)
    Picture = LoadPicture(cINI.Value("Settings", "Path_Splash", "Images\splash.jpg"))
    
    Dim picH As Long
    Dim picW As Long
        picH = ScaleY(Picture.Height, vbHimetric, vbPixels)
        picW = ScaleX(Picture.Width, vbHimetric, vbPixels)
        
        ' Resize window same as splash image size
        ' Then move window to the center of the screen
        SetWindowPos Hwnd, HWND_TOPMOST, (800 - picW) / 2, (600 - picH) / 2, picW, picH, SWP_NOACTIVATE
        
    Timer1.Interval = 1 ' Enable timer procedure
    
End Sub

Private Sub Timer1_Timer()
    Dim sPath As String
        sPath = cINI.Value("Settings", "Path_Images", "Images\")
        
    LockJPEGs sPath, ".img", True ' Unlock images for use by the program
    
    Load fMain ' Load main form in background
    
    cINI.Value("Settings", "Actv_Hwnd") = fMain.Hwnd ' Cache main form's hWnd
    
    Dim Height As Long
        Height = Screen.Height / Screen.TwipsPerPixelY
    Dim Width As Long
        Width = Screen.Width / Screen.TwipsPerPixelX
        
    If (cINI.Value("Settings", "Auto_Fullscreen", True)) Then
        
        If (Not Width = 800 And Not Height = 600) Then
            fMain.InFullScreen = mChangeResolution.ChangeResolution(800, 600)
            
            Timer2.Interval = Timer2.Interval + 1000 ' Nothing important
                                                     ' just want to show the splash
                                                     ' screen a little longer
            SetWindowPos Hwnd, _
                         HWND_TOPMOST, _
                         (800 - ScaleWidth) / 2, _
                         (600 - ScaleHeight) / 2, _
                         0, _
                         0, _
                         SWP_NOACTIVATE Or SWP_NOSIZE ' Move window to center of screen
        End If
        
    End If
    
    ' Determine whether to load the form on full screen
    If (Width = 800 And Height = 600) Or (fMain.InFullScreen) Then
        
        Dim cForm As cFormAppearance        '
        Set cForm = New cFormAppearance     '
        Set cForm.Client = fMain            '
            cForm.Titlebar = False          ' Remove titlebar to fullscreen
        Set cForm = Nothing                 '
                                            '
            fMain.imgControlBox.Visible = True
                                            '
        With fMain.picControlBox            ' Show custom control box
            .Picture = LoadPicture(sPath & "ctrlbox.img")
        End With                            '
                                            '
    End If                                  '
    
    Timer1 = False          ' Prevent main form from being able to get focus
    fMain.Enabled = False   ' While splash screen is still visible
                            '
    fMain.lblMain(2) = Me.Tag ' Username
    fMain.lblMain(3) = "Today is " & Format$(Date, "MMM dd, yyyy") ' Login Date
                            '
    fMain.Show              ' After main form has already been loaded, show it behind
                            '
    Timer2 = True           ' Just a short delay before splash screen is dismissed
    
End Sub

Private Sub Timer2_Timer()
    fMain.Enabled = True    ' Allow main form to get focus
    SendKeys "{TAB}", True  ' Bring the form to focus and ready for input
    Unload Me ' Dismiss splash screen after the main form is ready
    
End Sub

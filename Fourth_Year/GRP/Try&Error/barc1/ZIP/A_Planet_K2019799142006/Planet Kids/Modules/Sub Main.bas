Attribute VB_Name = "mSubMain"
Option Explicit

' XP-Style API's
Private Declare Sub InitCommonControls Lib "comctl32.dll" ()
Private Declare Function InitCommonControlsEx Lib "comctl32.dll" (ByRef tInitCCEx As InitCommonControlsExType) As Long ' Modified
    Private Const ICC_DATE_CLASSES      As Long = &H100
    Private Const ICC_LISTVIEW_CLASSES  As Long = &H1
    Private Type InitCommonControlsExType
        dwSize As Long
        dwICC As Long
    End Type

' Program window restore API's
Private Declare Function GetForegroundWindow Lib "user32.dll" () As Long
Private Declare Function IsIconic Lib "user32.dll" (ByVal Hwnd As Long) As Long
Private Declare Function OpenIcon Lib "user32.dll" (ByVal Hwnd As Long) As Long
Private Declare Function SetForegroundWindow Lib "user32.dll" (ByVal Hwnd As Long) As Long

' Prevent crashes after using XP-Styles
Private Declare Function FreeLibrary Lib "kernel32.dll" (ByVal hLibModule As Long) As Long
Private Declare Function LoadLibrary Lib "kernel32.dll" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As Long

Public cINI As cIniConfig

Private Sub Main()
    Set cINI = New cIniConfig ' Instantiate class object
    
    If (Not App.PrevInstance Or StrComp(Command$, "/run", vbTextCompare) = 0) Then
        On Error Resume Next
        
        Dim iMode As Integer
            iMode = cINI.Value("Settings", "Auto_Backup_Mode")
            
        If (iMode > 0) Then ' If mode not manual backup
            ' Prepare paths
            Dim sData As String
                sData = cINI.Value("Settings", "Path_Database")
                
                If (InStr(1, sData, ":") = 0) Then
                    sData = App.Path & "\" & sData
                End If
                
            Dim sPath As String
                sPath = cINI.Value("Settings", "Path_Backup")
                sPath = sPath & Format$(Date$, "mmm dd yyyy") & ".mdb"
                
                If (InStr(1, sPath, ":") = 0) Then
                    sPath = App.Path & "\" & sPath
                End If
                
            If (iMode = 1) Then
                Dim iMonth As Integer
                    iMonth = Month(Date)
                    
                Dim iDate As Integer
                
                ' Determine the last day of the month
                Select Case iMonth
                    Case 1, 3, 5, 7, 8, 10, 12 ' 31
                        iDate = 31
                    Case 2 ' 28, 29
                        If (IsDate(DateSerial(Year(Date), 2, 29))) Then
                            iDate = 29
                        Else
                            iDate = 28
                        End If
                    Case 4, 6, 9, 11 ' 30
                        iDate = 30
                End Select
                
                If (DateSerial(Year(Date), iMonth, iDate) = Date) Then
                    ' Check if backup has already been made
                    If (Len(Dir$(sPath, vbNormal Or vbArchive)) = 0) Then
                        Err.Clear
                        ' Copy database file to backup location
                        FileCopy sData, sPath
                        
                        If (Not Err) Then
                            cINI.Value("Settings", "Last_BackupDate") = Format$(Date$, "mmm dd yyyy")
                            MsgBoxEx "AutoBackupSuccess", vbInformation
                        End If
                    End If
                End If
                
            ElseIf (iMode = 2) Then
                Dim dDate As Date
                    dDate = CDate(cINI.Value("Settings", "Auto_Backup_Date"))
                    
                    If (dDate = Date) Then
                        ' Check if backup has already been made
                        If (Len(Dir$(sPath, vbNormal Or vbArchive)) = 0) Then
                            Err.Clear
                            ' Copy database file to backup location
                            FileCopy sData, sPath
                            
                            If (Not Err) Then
                                cINI.Value("Settings", "Last_BackupDate") = Format$(Date$, "mmm dd yyyy")
                                MsgBoxEx "AutoBackupSuccess", vbInformation
                                cINI.Value("Settings", "Auto_Backup_Mode") = 0 ' Manual
                            End If
                        End If
                    End If
            End If
        End If
        
        ' Now attempt to connect to database
        If (Not mPublic.DatabaseConnect) Then
            Set cINI = Nothing
            Exit Sub ' Unsuccessful to connect to database
        Else
            mPublic.LoadSettings
        End If
        
        Dim tInitCCEx As InitCommonControlsExType
            tInitCCEx.dwSize = Len(tInitCCEx)
            tInitCCEx.dwICC = ICC_DATE_CLASSES Or ICC_LISTVIEW_CLASSES
            
        cINI.Value("Settings", "Actv_Shell32") = LoadLibrary("Shell32.dll")
        
        If (Not InitCommonControlsEx(tInitCCEx)) Then
            InitCommonControls ' Attemp again :)
        End If
        
        fLoginForm.Show
    Else
        Dim Hwnd As Long
            Hwnd = CLng(cINI.Value("Settings", "Actv_Hwnd", 0))
            
        If (Not IsIconic(Hwnd)) Then
            OpenIcon Hwnd ' Restore and activate existing window
        End If
        
        If (Not GetForegroundWindow = Hwnd) Then
            SetForegroundWindow Hwnd ' Bring existing window to top and activated
        End If
        
        Set cINI = Nothing
    End If
    
End Sub

Public Sub UnloadLibrary()
    On Error Resume Next
    
    ' Disconnect to database
    mPublic.DatabaseDisconnect
    
    Dim hLibModule As Long
        hLibModule = CLng(cINI.Value("Settings", "Actv_Shell32", 0))
        
    If (hLibModule) Then
        FreeLibrary hLibModule ' Prevent unexpected crashes when using XP styles
        cINI.DeleteKey "Settings", "Actv_Shell32"
    End If
    
    cINI.DeleteKey "Settings", "Actv_Hwnd"
    
    Dim sPath As String
        sPath = cINI.Value("Settings", "Path_Images", "Images\")
        
        ' Lock images to avoid access from novice user
        LockJPEGs sPath, ".img"
        
    Set cINI = Nothing ' Remove class instance from memory
    
End Sub

' //-- Image processing --//

Public Sub LockJPEGs(sPath As String, sExtn As String, Optional UnlockJPEGs As Boolean)
    Dim iAttr As VbFileAttribute
        iAttr = vbNormal Or vbArchive Or vbReadOnly Or vbHidden Or vbSystem ' All files
        
    Dim sFile As String
        sFile = Dir$(sPath & "*" & sExtn, iAttr)
        
        On Error Resume Next
        
    While (Len(sFile))
        If (Not (sFile = "." Or sFile = "..")) Then
            
            sFile = sPath & sFile           ' Append images directory to image filename
                                            '
            SetAttr sFile, vbNormal         ' Avoid read errors
                                            '
            Dim iFile As Integer            '
                iFile = FreeFile            ' Get available file number
                                            '
            Open sFile For Binary As iFile  ' Open image file
                                            '
            If (UnlockJPEGs) Then           '
                Put iFile, , &HD8FF         ' Original file header
                Put iFile, , &HE0FF         '
                Put iFile, , &H1000         '
                Put iFile, , &H464A         '
                Put iFile, , &H4649         '
            Else                            '
                Put iFile, , &H4144         ' Custom file header (DACARASOFT)
                Put iFile, , &H4143         '
                Put iFile, , &H4152         '
                Put iFile, , &H4F53         '
                Put iFile, , &H5446         '
            End If                          '
                                            '
            Close iFile                     ' Close image file
        End If                              '
                                            '
        sFile = Dir$                        ' Get next image file if there is any
    Wend
    
End Sub

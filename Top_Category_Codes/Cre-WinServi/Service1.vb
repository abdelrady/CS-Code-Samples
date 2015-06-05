Imports System.ServiceProcess

'Basic Windows Service
'Build the executable
'To install this service open under Start - Microsoft Visual Studio.NET - Visual Studio.NET Tools -
'Visual Studio.NET Command Prompt,  give InstallUtil + the path of the executable in the console, hit enter, _
'the Service is being build, you can start and stop the service under the control panel, now all _
'changes to the Windows directory are logged, especially usefull if you install new programms _
'and you want to monitor which new ocx's or dll's and so on got into your Windows Directory


Public Class Service1
    Inherits System.ServiceProcess.ServiceBase

#Region " Vom Component Designer generierter Code "

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf wird vom Komponenten-Designer benötigt.
        InitializeComponent()

        ' Fügen Sie Initialisierungscode hinter dem InitializeComponent()-Aufruf ein

    End Sub

    'UserService überschreibt den Löschvorgang zum Bereinigen der Komponentenliste.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Der Haupteinstiegspunkt für den Vorgang
    <MTAThread()> _
    Shared Sub Main()
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' Innerhalb desselben Prozesses können mehrere NT-Dienste ausgeführt werden. Um einen
        ' weiteren Dienst zum Prozess hinzuzufügen, änderen Sie die folgende Zeile,
        ' um ein zweites Dienstprojekt zu erstellen. Z.B.,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '
        ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub

    ' Für Komponenten-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    ' HINWEIS: Die folgende Prozedur wird vom Komponenten-Designer benötigt.
    ' Sie kann mit dem Komponenten-Designer modifiziert werden. Verwenden Sie nicht
    ' den Code-Editor zur Bearbeitung.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.ServiceName = "Service1"
    End Sub

#End Region

#Region " Private Variables "

Private Log As EventLog
Private oWatcher As IO.FileSystemWatcher

#End Region


Protected Overrides Sub OnStart(ByVal args() As String)

Dim dirName As String

'Winnt 4, 5 or XP
If System.Environment.OSVersion.Version.Major = 4 Then
  dirName = "C:\WINNT\"
ElseIf System.Environment.OSVersion.Version.Major = 5 Then
  dirName = "C:\WINNT\"
ElseIf System.Environment.OSVersion.Version.Major = 6 Then
  dirName = "C:\Windows\"
End If



  'initialize new event log
  Log = New EventLog()
  'initialize Watcher
  oWatcher = New IO.FileSystemWatcher()
  'check if log already exists
  If Not Log.SourceExists("LogWinDir") Then
    Log.CreateEventSource("LogWinDir", "LogWinNT")
  End If

  Log.Source = "LogWinDir"

  'Set Path to Watch
  oWatcher.Path = dirName
  'Set Filter to *.*
  oWatcher.Filter = ""
  'Watch Subdirectories
  oWatcher.IncludeSubdirectories = True
  'Set Changes to be watched
  oWatcher.NotifyFilter = IO.NotifyFilters.Attributes Or _
                          IO.NotifyFilters.CreationTime Or _
                          IO.NotifyFilters.DirectoryName Or _
                          IO.NotifyFilters.FileName Or _
                          IO.NotifyFilters.LastWrite

  'Pointer on Sub for events
  AddHandler oWatcher.Created, AddressOf Changed
  AddHandler oWatcher.Changed, AddressOf Changed
  AddHandler oWatcher.Deleted, AddressOf Changed
  AddHandler oWatcher.Renamed, AddressOf FileRenamed
  AddHandler oWatcher.Error, AddressOf ErrorOccured

  'Start Watching
  oWatcher.EnableRaisingEvents = True

End Sub

#Region " Subs for Delegate "

Private Sub Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs)

  Log.WriteEntry("LogWinnt", String.Format("{0} - {1} - {2}", Date.Now.ToString, e.ChangeType.ToString, e.FullPath), EventLogEntryType.Information)

End Sub

Private Sub ErrorOccured(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs)

  Log.WriteEntry("LogWinnt", String.Format("{0} - {1} - {2}", Date.Now.ToString, e.GetException.Message), EventLogEntryType.Information)

End Sub

Private Sub FileRenamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs)

  Log.WriteEntry("LogWinnt", String.Format("{0} - {1} - {2}", Date.Now.ToString, e.ChangeType.ToString, e.ChangeType.ToString, e.OldFullPath, e.FullPath), EventLogEntryType.Information)

End Sub

#End Region

Protected Overrides Sub OnStop()

  oWatcher.Dispose()
  Log.Dispose()

End Sub



End Class

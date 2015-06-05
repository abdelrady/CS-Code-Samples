Imports System.ComponentModel
Imports System.Configuration.Install

<RunInstaller(True)> Public Class ProjectInstaller
    Inherits System.Configuration.Install.Installer

#Region " Vom Component Designer generierter Code "

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Komponenten-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen

    End Sub

    'Installer überschreibt den Löschvorgang zum Bereinigen der Komponentenliste.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Für Komponenten-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist für den Komponenten-Designer erforderlich
    'Sie kann mit dem Komponenten-Designer modifiziert werden.
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
  Friend WithEvents ServiceProcessInstaller1 As System.ServiceProcess.ServiceProcessInstaller
  Friend WithEvents WatchWinnt As System.ServiceProcess.ServiceInstaller
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.ServiceProcessInstaller1 = New System.ServiceProcess.ServiceProcessInstaller()
Me.WatchWinnt = New System.ServiceProcess.ServiceInstaller()
'
'ServiceProcessInstaller1
'
Me.ServiceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem
Me.ServiceProcessInstaller1.Password = Nothing
Me.ServiceProcessInstaller1.Username = Nothing
'
'WatchWinnt
'
Me.WatchWinnt.ServiceName = "WatchWinnt"
'
'ProjectInstaller
'
Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.ServiceProcessInstaller1, Me.WatchWinnt})

    End Sub

#End Region

End Class

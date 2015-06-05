Public Class Class1
    Private Sub startup_project(ByVal path As String)
        Dim oShell As Object = CreateObject("WScript.Shell")
        Dim sPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim oSCut As Object
        oSCut = oShell.CreateShortcut(sPath & "\TestStartup.lnk")
        oSCut.TargetPath = path
        oSCut.Save()
    End Sub

End Class

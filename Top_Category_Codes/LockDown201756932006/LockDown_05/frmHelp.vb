Public Class frmHelp
    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sr As New IO.StreamReader(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LockDown.readme.txt"))
        Dim Result As String = sr.ReadToEnd
        sr.Close()
        rtfContent.Text = Result
    End Sub
End Class

Partial Class ImageIntoProfile_vb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Membership.GetUser Is Nothing) Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Profile.Photo = New System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream)
        Profile.ImageName = FileUpload1.FileName
        Profile.Save()
        ltrlStatus.Text = " „ Õ›Ÿ «·’Ê—… ›Ï „·›ﬂ «·‘Œ’Ì"
    End Sub
End Class

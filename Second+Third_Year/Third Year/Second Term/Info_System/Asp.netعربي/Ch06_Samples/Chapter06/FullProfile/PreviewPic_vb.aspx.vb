
Partial Class PreviewPic_vb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Membership.GetUser Is Nothing) Then
            FormsAuthentication.RedirectToLoginPage()
        Else
            Dim temp As System.Drawing.Bitmap
            If (Profile.Photo Is Nothing) Then
                temp = New System.Drawing.Bitmap(Server.MapPath("NoImage.JPG"))
            Else
                temp = New System.Drawing.Bitmap(Profile.Photo)
            End If
            temp.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub
End Class

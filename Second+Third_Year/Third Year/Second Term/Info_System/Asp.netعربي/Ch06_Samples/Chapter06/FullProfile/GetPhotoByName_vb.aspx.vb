
Partial Class GetPhotoByName_vb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not (Request.QueryString("Name")) Is Nothing) Then
            Dim strName As String = Request.QueryString("Name")
            Dim tempProfile As ProfileCommon = Profile.GetProfile(strName)
            Dim tempImage As System.Drawing.Bitmap
            If (tempProfile.Photo Is Nothing) Then
                tempImage = New System.Drawing.Bitmap(Server.MapPath("NoImage.JPG"))
            Else
                tempImage = New System.Drawing.Bitmap(tempProfile.Photo)
            End If
            tempImage.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If

    End Sub
End Class

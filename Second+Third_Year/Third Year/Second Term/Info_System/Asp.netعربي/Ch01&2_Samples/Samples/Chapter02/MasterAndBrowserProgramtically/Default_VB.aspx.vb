
Partial Class Default_VB
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim imgHolder As Image = CType(Master.FindControl("img_BrowserImage"), Image)
        Dim lblHolder As Label = CType(Master.FindControl("lbl_BrowserInfo"), Label)
        imgHolder.ImageUrl = "~\Images\" + Request.Browser.Browser + ".jpg"
        lblHolder.Text = String.Format("<pre>{0}</pre>", Request.Browser.Browser)
    End Sub
End Class

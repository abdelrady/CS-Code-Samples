
Partial Class GoogleSearch_VB
    Inherits System.Web.UI.UserControl

    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Response.Redirect(String.Format("http://www.google.com/search?q={0}", txtQuery.Text))
    End Sub
End Class

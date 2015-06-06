
Partial Class ProfileSelection
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Profile.Preferred.BookTitle = ddlBook.SelectedValue
        Profile.Preferred.CarBrand = ddlCar.SelectedValue
        Profile.Preferred.Color = ddlColor.SelectedValue
        Profile.Preferred.SunGlassBrand = ddlSunGlasses.SelectedValue
        Profile.Save()
    End Sub
End Class

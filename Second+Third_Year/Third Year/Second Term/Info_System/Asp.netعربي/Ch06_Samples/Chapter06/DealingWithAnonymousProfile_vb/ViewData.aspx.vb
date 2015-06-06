
Partial Class ViewData
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblBook.Text = Profile.Preferred.BookTitle
        lblCar.Text = Profile.Preferred.CarBrand
        lblColor.Text = Profile.Preferred.Color
        lblSunGlasses.Text = Profile.Preferred.SunGlassBrand
    End Sub
End Class

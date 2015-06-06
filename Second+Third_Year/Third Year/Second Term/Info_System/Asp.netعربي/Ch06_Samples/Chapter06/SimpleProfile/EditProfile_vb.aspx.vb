
Partial Class EditProfile_vb
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim TempUser As MembershipUser
        TempUser = Membership.GetUser()
        If (TempUser Is Nothing) Then
            FormsAuthentication.RedirectToLoginPage()
        Else
            If Not IsPostBack Then
                txtName.Text = Profile.UserInformation.Name
                txtAddress.Text = Profile.Contacts.Address
                txtCountry.Text = Profile.UserInformation.Country
                txtDate.Text = Profile.UserInformation.BirthDate
                txtMobile.Text = Profile.Contacts.Mobile
                txtNationality.Text = Profile.UserInformation.Nationality
                txtNotes.Text = Profile.UserInformation.Notes
                txtPhone.Text = Profile.Contacts.Phone
                ddlSystemColor.SelectedValue = Profile.UserInformation.color
            End If
            updateColor()
        End If
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Profile.UserInformation.Name = txtName.Text
        Profile.Contacts.Address = txtAddress.Text
        Profile.UserInformation.Country = txtCountry.Text
        Profile.UserInformation.BirthDate = txtDate.Text
        Profile.Contacts.Mobile = txtMobile.Text
        Profile.UserInformation.Nationality = txtNationality.Text
        Profile.UserInformation.Notes = txtNotes.Text
        Profile.Contacts.Phone = txtPhone.Text
        Profile.UserInformation.color = ddlSystemColor.SelectedValue
        Profile.Save()
        updateColor()
    End Sub

    Private Sub updateColor()
        Select Case (Profile.UserInformation.color)
            Case "0"
                lblColorTest.BackColor = System.Drawing.Color.Red
            Case "1"
                lblColorTest.BackColor = System.Drawing.Color.Green
            Case "2"
                lblColorTest.BackColor = System.Drawing.Color.Yellow
            Case Else
                lblColorTest.BackColor = System.Drawing.Color.Wheat
        End Select
    End Sub
End Class

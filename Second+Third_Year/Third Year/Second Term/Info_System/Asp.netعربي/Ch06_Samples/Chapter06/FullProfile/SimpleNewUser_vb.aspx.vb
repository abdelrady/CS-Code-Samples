
Partial Class SimpleNewUser_vb
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Page.Validate()
        Dim tempCreateStatus As MembershipCreateStatus
        Membership.CreateUser(txtName.Text, txtPassword.Text, txtEmail.Text, txtQuestion.Text, txtAnswer.Text, True, tempCreateStatus)
        ltrlResult.Text = String.Format("<font color=red> <b> {0} <b> </font>", tempCreateStatus.ToString)
        If (tempCreateStatus = MembershipCreateStatus.Success) Then
            Response.Redirect("ImageIntoProfile_vb.aspx")
        End If
    End Sub
End Class

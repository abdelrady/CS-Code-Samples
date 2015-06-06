
Partial Class GetAllProfiles_vb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each temp As MembershipUser In Membership.GetAllUsers
            Response.Write((temp.UserName + (" - <a href=mailto:" _
                            + (temp.Email + (">" _
                            + (temp.Email + ("</a> <img src=GetPhotoByName_vb.aspx?Name=" _
                            + (temp.UserName + "> <br> <hr>"))))))))
        Next
    End Sub
End Class

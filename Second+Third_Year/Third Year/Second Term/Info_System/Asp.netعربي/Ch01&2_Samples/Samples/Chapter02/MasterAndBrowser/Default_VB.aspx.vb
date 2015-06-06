
Partial Class Default_VB
    Inherits System.Web.UI.Page

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        Select Case Request.Browser.Browser.ToLower()
            Case "ie"
                MasterPageFile = "MasterForIE.master"
            Case "opera"
                MasterPageFile = "MasterForOpera.master"
            Case "firefox"
                MasterPageFile = "MasterForFireFox.master"
            Case Else
                MasterPageFile = "MasterForDefault.master"
        End Select
    End Sub
End Class

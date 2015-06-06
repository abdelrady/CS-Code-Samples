Imports system.Threading
Imports System.Globalization

Partial Class Default_VB
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        lblHello.Text = Thread.CurrentThread.CurrentCulture.Name
        If Not IsPostBack Then
            Dim AllCul() As CultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures)
            For Each temp As CultureInfo In AllCul
                Dim t As ListItem = New ListItem(temp.DisplayName, temp.Name)
                DropDownList1.Items.Add(t)
            Next
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Thread.CurrentThread.CurrentCulture = New CultureInfo(DropDownList1.SelectedValue)
    End Sub

End Class

Public Class WebForm2
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strAll As String

        '/ Clears all content output from the buffer stream /
        Response.ClearContent()

        '/ Clears all headers from the buffer stream /
        Response.ClearHeaders()

        '/ Gets the content type of the file system resource /
        Response.ContentType = "text/xml"

        strAll = "<?xml version=""1.0"" encoding=""UTF-8"" ?>"
        strAll &= "<xsl:stylesheet version=""1.0"" xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"">"
        strAll &= "<xsl:template match=""/"">"
        strAll &= "<select name=" & Chr(34) & Request("cboName").ToString & Chr(34) & " onChange=""javascript:show_date(this.value,this.name)"">"

        If Request("cboName").ToString = "cboSTATES" Then
            strAll &= "<option value=""-"">--- Select State ---</option>"
        Else
            strAll &= "<option value=""-"">--- Districts ---</option>"
        End If

        strAll &= "<xsl:for-each select=""users/user"">"
        strAll &= "<option>"
        strAll &= "<xsl:attribute name=""value"">"
        strAll &= "<xsl:value-of select=""id"" />"
        strAll &= "</xsl:attribute>"
        strAll &= "<xsl:value-of select=""name"" />"
        strAll &= "</option>"
        strAll &= "</xsl:for-each>"
        strAll &= "</select>"
        strAll &= "</xsl:template>"
        strAll &= "</xsl:stylesheet>"

        Response.Write(strAll)
    End Sub

End Class

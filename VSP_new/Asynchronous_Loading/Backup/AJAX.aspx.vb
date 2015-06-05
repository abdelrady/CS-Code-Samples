Imports System.Data.SqlClient
Imports System.Xml
Imports System.Xml.Xsl
Imports System.Xml.XPath

Public Class WebForm1
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

    Private Con As SqlConnection
    Private Com As SqlCommand
    Private DR As SqlDataReader

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Request("Type").ToString.ToUpper = "STATES" Then
            FillCategory()
        ElseIf Request("Type").ToString.ToUpper = "DISTRICTS" Then
            FillItems()
        End If
    End Sub

    Private Sub CreateConnection()
        Dim CString As String = ConfigurationSettings.AppSettings("INDIA")
        Con = New SqlConnection(CString)
    End Sub

    Private Sub FillCategory()
        Dim strXmlCategory As String = "", strs As String = Request("q").ToString

        CreateConnection()
        Com = New SqlCommand("SELECT StateID,Description FROM States ORDER BY DESCRIPTION", Con)
        Con.Open()
        DR = Com.ExecuteReader(CommandBehavior.CloseConnection)

        While DR.Read
            If strs.ToUpper = DR.GetString(1).Substring(0, strs.Length).ToUpper Then
                strXmlCategory &= "<user>"
                strXmlCategory &= "<name>" & DR.GetString(1).Replace("&", "And") & "</name>"
                strXmlCategory &= "<id>" & DR.GetInt32(0).ToString & "</id>"
                strXmlCategory &= "</user>"
            End If
        End While
        'Con.Close()
        Con.Dispose()

        strXmlCategory = "<?xml version=""1.0""?><users>" & strXmlCategory & "</users>"

        Dim xDoc As New XmlDocument()

        '... 'LoadXml' - Loads the XML document from the Variable 'strXmlCategory' to 'xDoc' Object 
        xDoc.LoadXml(strXmlCategory)

        '... 'XPathNavigator' - Is a read-only random access to data, Is used as an input to XSLT
        Dim xPathNav As XPathNavigator = xDoc.CreateNavigator

        '... 'XslTransform' - Transforms XML data using an XSLT stylesheet
        Dim xslt As XslTransform = New XslTransform()

        '... Loads the XSLT stylesheet.
        '... 'Load' - The URL "http://localhost/Asynchronous_Loading/WebForm2.aspx?cboName=cboSTATES" Returns the XSLT Based Result by the 'WEBFORM2.aspx' Page. 

        'xslt.Load("http://localhost/Asynchronous_Loading/WebForm2.aspx?cboName=cboSTATES")
        xslt.Load("http://172.26.11.215/Asynchronous_Loading/WebForm2.aspx?cboName=cboSTATES")

        '... 'Transform' - Transforms the specified XML data using the loaded XSLT stylesheet and outputs the results.
        xslt.Transform(xPathNav, Nothing, Response.OutputStream)
    End Sub

    Private Sub FillItems()
        Dim strXmlItems As String = "", strs As String = Request("q").ToString

        CreateConnection()
        Com = New SqlCommand("SELECT DistrictID,Description FROM Districts WHERE DistrictID=" & strs & " ORDER BY Description", Con)
        Con.Open()
        DR = Com.ExecuteReader(CommandBehavior.CloseConnection)

        While DR.Read
            strXmlItems &= "<user>"
            strXmlItems &= "<name>" & DR.GetString(1).Replace("&", "And") & "</name>"
            strXmlItems &= "<id>" & DR.GetInt32(0).ToString & "</id>"
            strXmlItems &= "</user>"
        End While
        'Con.Close()
        Con.Dispose()

        strXmlItems = "<?xml version=""1.0""?><users>" & strXmlItems & "</users>"

        Dim xDoc As New XmlDocument()

        '... 'LoadXml' - Loads the XML document from the Variable 'strXmlItems' to 'xDoc' Object 
        xDoc.LoadXml(strXmlItems)

        '... 'XPathNavigator' - Is a read-only random access to data, Is used as an input to XSLT
        Dim xPathNav As XPathNavigator = xDoc.CreateNavigator

        Dim xslt As XslTransform = New XslTransform()

        '... 'Load' - The URL "http://localhost/Asynchronous_Loading/WebForm2.aspx?cboName=cboDISTRICTS" Returns the XSLT Based Result by the 'WEBFORM2.aspx' Page. 
        'xslt.Load("http://localhost/Asynchronous_Loading/WebForm2.aspx?cboName=cboDISTRICTS")

        xslt.Load("http://172.26.11.215/Asynchronous_Loading/WebForm2.aspx?cboName=cboDISTRICTS")

        '... 'Transform' - Transforms the specified XML data using the loaded XSLT stylesheet and outputs the results.
        xslt.Transform(xPathNav, Nothing, Response.OutputStream)
    End Sub

End Class

<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
<asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
    <itemtemplate>
        <b><%#XPath("title")%> </b><br />
        <i><%#XPath("description") %></i>&nbsp;<%#XPath("pubDate")%><br />
        <a href='<%#XPath("link") %>'>Link</a><br />
        <br />
    </itemtemplate>
    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
    <AlternatingItemStyle BackColor="#DCDCDC" />
    <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
  </asp:DataList>
        &nbsp;
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/RSS.xml"
    XPath="rss/channel/item"></asp:XmlDataSource>
    </form>
</body>
</html>

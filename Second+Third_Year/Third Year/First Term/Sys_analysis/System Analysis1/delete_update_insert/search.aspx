<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(Image14.png)">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 100;
            left: 214px; position: absolute; top: 67px" Text="Name :"></asp:Label>
        &nbsp;&nbsp;
        <asp:Table ID="Table1" runat="server" GridLines="Both" Style="z-index: 101; left: 286px;
            position: absolute; top: 205px" Visible="False" Width="95px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True">Name</asp:TableCell>
                <asp:TableCell ID="na" runat="server" Width="300px"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True">Address</asp:TableCell>
                <asp:TableCell ID="a" runat="server" Width="200px"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" Font-Bold="True" Font-Italic="True">Phone</asp:TableCell>
                <asp:TableCell ID="p" runat="server" Width="40px"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Style="z-index: 102;
            left: 296px; position: absolute; top: 135px" Height="30px" ImageUrl="~/Untitled-12.gif" />
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 103; left: 289px; position: absolute;
            top: 64px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Style="z-index: 104;
            left: 302px; position: absolute; top: 96px" Visible="False"></asp:Label>
        &nbsp; &nbsp;
    
    </div>
    </form>
</body>
</html>

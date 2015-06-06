<%@ Page Language="C#" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(Image14.png)">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 100; left: 442px; position: absolute;
            top: 160px" Text=": ÃÓã ÇáãÓÎÏã"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 101; left: 438px; position: absolute;
            top: 73px" Text=": ÑÞã ÇáãÓÊÎÏã"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            Font-Bold="True" Font-Italic="True" Style="z-index: 102; left: 267px; position: absolute;
            top: 160px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            Font-Bold="True" Font-Italic="True" Style="z-index: 103; left: 267px; position: absolute;
            top: 73px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            Font-Bold="True" Font-Italic="True" Style="z-index: 104; left: 267px; position: absolute;
            top: 116px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" BackColor="Red" BorderColor="Cyan" BorderStyle="Solid"
            Style="z-index: 105; left: 342px; position: absolute; top: 206px" Visible="False"></asp:Label>
        <asp:Label ID="Label4" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 106; left: 454px; position: absolute;
            top: 116px" Text=": ßáãÉ ÇáÓÑ"></asp:Label>
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Style="z-index: 108;
            left: 321px; position: absolute; top: 246px" ImageUrl="~/Untitled-11.gif" />
    
    </div>
    </form>
</body>
</html>

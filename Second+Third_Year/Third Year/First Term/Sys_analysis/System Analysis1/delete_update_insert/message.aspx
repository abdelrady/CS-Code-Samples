<%@ Page Language="C#" AutoEventWireup="true" CodeFile="message.aspx.cs" Inherits="message" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="135px" Style="z-index: 100; left: 158px;
            position: absolute; top: 185px" TextMode="MultiLine" Width="439px"></asp:TextBox>
        &nbsp; &nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label4" runat="server" BackColor="DeepPink" BorderColor="#FF8000"
            BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Font-Overline="False"
            Font-Size="Large" ForeColor="Blue" Style="z-index: 102; left: 188px; position: absolute;
            top: 17px" Text="«·—”«∆·     " Width="381px"></asp:Label>
        &nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="Silver" Font-Bold="True"
            Font-Italic="True" Style="z-index: 104; left: 169px; position: absolute; top: 139px" Width="91px">
            <asp:ListItem>«·√Ê·Ï</asp:ListItem>
            <asp:ListItem>«·À«‰Ì…</asp:ListItem>
            <asp:ListItem Selected="True">«·À«·À…</asp:ListItem>
            <asp:ListItem>«·—»⁄…</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 105; left: 275px; position: absolute;
            top: 141px" Text=": «·›—ﬁ…" Width="51px"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Height="20px" Style="z-index: 106; left: 519px;
            position: absolute; top: 141px" Text=": √”„ «·ÿ«·»"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            Style="z-index: 107; left: 352px; position: absolute; top: 141px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 108; left: 500px; position: absolute;
            top: 92px" Text=": €—÷ «·—”«·…"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Style="z-index: 109;
            left: 350px; position: absolute; top: 92px" Width="135px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" BackColor="#E0E0E0" BorderColor="Silver" BorderStyle="Solid"
            Font-Bold="True" Font-Italic="True" Style="z-index: 110; left: 278px; position: absolute;
            top: 92px" Text=": «·—«”·" Width="47px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" BackColor="#E0E0E0" BorderColor="Silver"
            BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Style="z-index: 111;
            left: 155px; position: absolute; top: 92px" Width="100px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 113;
            left: 346px; position: absolute; top: 361px" Text="⁄—÷" />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default_VB.aspx.vb" Inherits="Default_VB"     meta:resourcekey="PageResource1"     UICulture="auto" Culture="auto"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> ⁄œœ «··€« </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblHello" runat="server" Text="Label"></asp:Label><br />
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" Text="ﬂÌ› Õ«·ﬂ Ì« "></asp:Label>
        <asp:Label ID="Label2" runat="server" meta:resourcekey="Label2Resource1"></asp:Label>
        &nbsp;
        <asp:Calendar ID="Calendar1" runat="server" meta:resourcekey="Calendar1Resource1"></asp:Calendar>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" meta:resourcekey="Button1Resource1" Text="—”«·… «· —ÕÌ»" />
        <asp:Panel ID="Panel1" runat="server" Height="26px" Width="395px">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" /></asp:Panel>
    </form>
</body>
</html>
<!--
                <asp:ListItem Value="ar-lb">·»‰«‰Ì</asp:ListItem>
                <asp:ListItem Value="ar-sa">”⁄ÊœÌ</asp:ListItem>
                <asp:ListItem Value="ar-eg">„’—Ì</asp:ListItem>
                <asp:ListItem Value="en-us">English US</asp:ListItem>
                <asp:ListItem Value="de">German</asp:ListItem> -->
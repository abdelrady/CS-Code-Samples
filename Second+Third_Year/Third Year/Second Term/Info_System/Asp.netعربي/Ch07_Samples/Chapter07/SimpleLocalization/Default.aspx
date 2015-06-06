<%@ Page Language="C#" 
    AutoEventWireup="true"  
    CodeFile="Default.aspx.cs" 
    Inherits="_Default" 
    meta:resourcekey="PageResource1" 
    UICulture="auto" Culture="auto"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>تعدد اللغات</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblHello" runat="server" Text="Label"></asp:Label><br />
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" Text="كيف حالك يا "></asp:Label>
        <asp:Label ID="Label2" runat="server" meta:resourcekey="Label2Resource1"></asp:Label>
        &nbsp;
        <asp:Calendar ID="Calendar1" runat="server" meta:resourcekey="Calendar1Resource1"></asp:Calendar>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" meta:resourcekey="Button1Resource1" Text="رسالة الترحيب" OnClick="Button1_Click" />
        <asp:Panel ID="Panel1" runat="server" Height="26px" Width="395px">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" /></asp:Panel>
    </form>
</body>
</html>
<!--
                <asp:ListItem Value="ar-lb">لبناني</asp:ListItem>
                <asp:ListItem Value="ar-sa">سعودي</asp:ListItem>
                <asp:ListItem Value="ar-eg">مصري</asp:ListItem>
                <asp:ListItem Value="en-us">English US</asp:ListItem>
                <asp:ListItem Value="de">German</asp:ListItem> -->
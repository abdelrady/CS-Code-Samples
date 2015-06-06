<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newuser.aspx.cs" Inherits="newuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>

</head>
<body bgcolor="slategray">
    <form id="form1" runat="server">
    <div>
        
        <center><asp:Label ID="Label1" runat="server" Text="Username" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="155px"></asp:TextBox><br /></center>
        
        <center><asp:Label ID="Label2" runat="server" Text="Password" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="155px" TextMode="Password"></asp:TextBox></center>
        <center>
            <asp:Label ID="Label7" runat="server" Font-Size="Large" ForeColor="Cyan" Text="Gender"
                Width="155px"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mf" Text="Mail" Width="78px" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="mf" Text="Femal" Width="78px" /></center>
        
        <center><asp:Label ID="Label3" runat="server" Text="Email" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="155px"></asp:TextBox><br /></center>
        
        <center><asp:Label ID="Label4" runat="server" Text="City" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="155px"></asp:TextBox><br /></center>
        
        <center><asp:Label ID="Label5" runat="server" Text="Phone" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="155px"></asp:TextBox><br /></center>
        
        <center><asp:Label ID="Label6" runat="server" Text="Position" Width="155px" Font-Size="Large" ForeColor="Cyan"></asp:Label>
            <asp:DropDownList ID="DropDownList4" runat="server" Width="160px">
                <asp:ListItem>Engineer</asp:ListItem>
                <asp:ListItem>Doctor</asp:ListItem>
                <asp:ListItem>Computer related</asp:ListItem>
            </asp:DropDownList></center>
        <center>
        <center><asp:Label ID="Label8" runat="server" Text="Data Of Birth" ForeColor="Cyan" Width="155px" Font-Size="Large"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="42px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="44px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" Width="66px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList></center>
        </center>
        <center>
            &nbsp;</center>
        <center>
            <asp:Button ID="Button1" runat="server" BackColor="#C0FFFF" BorderColor="#FFFFC0"
                Font-Bold="True" Font-Size="X-Large" OnClick="Button1_Click" Text="Register"
                Width="133px" />&nbsp;</center>
    
    </div>
    </form>
</body>
</html>

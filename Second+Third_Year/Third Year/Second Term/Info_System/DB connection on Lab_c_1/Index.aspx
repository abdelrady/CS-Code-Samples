<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="slategray">
    <form id="form1" runat="server">
    <center>
    <div>
        &nbsp;</div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Yellow"
            Text="Username" Width="154px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="154px"></asp:TextBox>
        &nbsp;<br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Yellow"
            Text="Password" Width="154px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="154px"></asp:TextBox>
        &nbsp;<br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button
            ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />&nbsp;
        <asp:Button ID="Button2" runat="server" Text="New User" OnClick="Button2_Click" />
    </center></form>
</body>
</html>

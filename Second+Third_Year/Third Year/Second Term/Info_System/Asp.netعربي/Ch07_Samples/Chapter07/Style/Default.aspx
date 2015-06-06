<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Classic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblComment" runat="server" Text="و أعتصموا بحبل الله جميعا و لا تفرقوا"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" EnableTheming="True"></asp:Calendar>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="تطبيق الاسلوب الجديد" Width="258px" EnableTheming="True" /></div>
    </form>
</body>
</html>

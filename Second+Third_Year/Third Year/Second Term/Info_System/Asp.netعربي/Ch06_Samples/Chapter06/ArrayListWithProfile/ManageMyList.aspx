<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ManageMyList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>قوائم المشتركين</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        أهلا بك
        <asp:LoginName ID="LoginName1" runat="server" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutText="للخروج أضغط هنا" />
        <br />
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="أضافة" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="يجب أدخال قيمة" ValidationGroup="AddGroup"></asp:RequiredFieldValidator><br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="حذف" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ListBox1"
            ErrorMessage="يجب أختيار عنصر" ValidationGroup="DeleteGroup"></asp:RequiredFieldValidator>
    </div>
    </form>
</body>
</html>

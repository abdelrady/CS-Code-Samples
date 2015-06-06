<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                سجل دخول من
                <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="هنا" LogoutText="خروج" />
                &nbsp;أو لو لم تكن مسجل بالضغط على
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Registeration.aspx">تسجيل</asp:LinkButton>
                أو أذا كنت مسجل و نسيت كلمة المرور أدخل
                <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="ResetPassword.aspx">هنا</asp:LinkButton>
            </AnonymousTemplate>
            <LoggedInTemplate>
                أهلا يك &nbsp;<asp:LoginName ID="LoginName1" runat="server" />
                &nbsp;للخروج أضغط
                <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="هنا" LogoutText="خروج" />
                <br />
                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="ChangePassword.aspx">تغيير كلمة السر</asp:LinkButton>
            </LoggedInTemplate>
        </asp:LoginView>
        &nbsp; &nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
        </asp:DetailsView>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid"
            BorderWidth="1px" FailureText="ÏÎæá ÎÇØÆ ÍÇæá ãÑÉ ÃÎÑì" Font-Names="Verdana"
            Font-Size="10pt" LoginButtonText="ÏÎæá" Orientation="Horizontal" PasswordLabelText="ßáãÉ ÇáÓÑ"
            RememberMeText="ÊÐßÑäí" TitleText="ÏÎæá" UserNameLabelText="ÃÓã ÇáãÓÊÎÏã" DestinationPageUrl="ManageMyList.aspx">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
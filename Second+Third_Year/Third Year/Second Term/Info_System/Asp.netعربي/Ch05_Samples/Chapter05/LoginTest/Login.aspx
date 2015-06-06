<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4"
            BorderStyle="Solid" BorderWidth="1px" CreateUserText="ãÓÊÎÏã ÌÏíÏ" CreateUserUrl="~/Registeration.aspx"
            FailureText="ÏÎæá ÎÇØÆ ãä ÝÖáß ÍÇæá ãÑÉ ÃÎÑì" Font-Names="Verdana" Font-Size="0.8em"
            ForeColor="#333333" LoginButtonText="ÏÎæá" PasswordLabelText="ßáãÉ ÇáÓÑ" PasswordRecoveryText="äÓíÊ ßáãÉ ÇáÓÑ"
            PasswordRecoveryUrl="~/ResetPassword.aspx" PasswordRequiredErrorMessage="áÇÈÏ ãä ÃÏÎÇá ßáãÉ ÇáÓÑ"
            RememberMeText="ÊÐßÑäí" TitleText="ÏÎæá" UserNameLabelText="ÃÓã ÇáãÓÊÎÏã" UserNameRequiredErrorMessage="áÇÈÏ ãä ÃÏÎÇá ÃÓã ÇáãÓÊÎÏã">
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        </asp:Login>
    
    </div>
    </form>
</body>
</html>

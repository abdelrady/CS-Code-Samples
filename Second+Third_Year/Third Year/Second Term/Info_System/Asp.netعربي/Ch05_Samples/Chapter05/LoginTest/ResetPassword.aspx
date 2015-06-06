<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" AnswerLabelText="ÇáÃÌÇÈÉ"
            AnswerRequiredErrorMessage="ÇáÃÌÇÈÉ ÃÌÈÇÑíÉ" BackColor="#F7F6F3" BorderColor="#E6E2D8"
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
            Font-Size="0.8em" GeneralFailureText="ÝÔáÊ ÚãáíÉ ÃÚÇÏÉ ÃÑÓÇá ßáãÉ ÇáÓÑ" QuestionFailureText="ÃÌÇÈÉ ÇáÓÄÇá ÎØÃ"
            QuestionInstructionText="ÃÌÈ Úáì ÇáÓÄÇá áßì äÑÓá áß ßáãÉ ÇáÓÑ ÇáÌÏíÏÉ" QuestionLabelText="ÇáÓÄÇá"
            QuestionTitleText="ÊÃßíÏ ÇáåæíÉ" SubmitButtonText="ÃÑÓá" SuccessPageUrl="~/Default.aspx"
            SuccessText="ßáãÉ ÇáÓÑ ÇáÌÏíÏÉ Êã ÃÑÓáåÇ" UserNameFailureText="áã äÓÊØÚ ÇáæÕæá áÈíÇäÇÊß"
            UserNameInstructionText="ÃÏÎá ÃÓã ÇáãÓÊÎÏã áÊÓÊáã ßáãÉ ÇáÓÑ" UserNameLabelText="ßáãÉ ÇáÓÑ"
            UserNameRequiredErrorMessage="ÃÓã ÇáããÓÊÎÏã ÃÌÈÇÑí" UserNameTitleText="äÓíÊ ßáãÉ ÇáÓÑ ÇáÎÇÕÉ Èß ¿">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <MailDefinition BodyFileName="~/BUG.htm" 
                                From="Site@internet.com" 
                                Subject="UR new password :D" 
                                IsBodyHtml="True" Priority="High" >
                    <EmbeddedObjects>
                        <asp:EmbeddedMailObject />
                    </EmbeddedObjects>
                </MailDefinition>
        </asp:PasswordRecovery>
    
    </div>
    </form>
</body>
</html>

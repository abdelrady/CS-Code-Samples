<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registeration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" AnswerLabelText="ÃÌÇÈÉ ÇáÓÄÇá ÇáÓÑí"
            AnswerRequiredErrorMessage="ÃÏÎÇá ÃÌÇÈå ááÓÄÇá ÇáÓÑí ÃÌÈÇÑí" BackColor="#F7F6F3"
            BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" CancelButtonText="ÇáÛÇÁ ÇáÚãáíå"
            CompleteSuccessText="Êã ÃäÔÇÁ ÇáÍÓÇÈ ÈäÌÇÍ" ConfirmPasswordCompareErrorMessage="ßáãÉ ÇáÓÑ æ ÊÃßíÏ ßáãÉ ÇáÓÑ ÛíÑ ãÊæÇÝÞíä"
            ConfirmPasswordLabelText="ÊÃßíÏ ßáãÉ ÇáÓÑ" ConfirmPasswordRequiredErrorMessage="ÊÃßíÏ ßáãÉ ÇáÓÑ ÃÌÈÇÑí"
            ContinueButtonText="ãÊÇÈÚå" CreateUserButtonText="ÃäÔÇÁ ãÓÊÎÏã" DuplicateEmailErrorMessage="ÇáÈÑíÏ ÇáÃáßÊÑæäì ÇáÐí ÃÏÎáÊå ãÓÌá ãä ÞÈá"
            DuplicateUserNameErrorMessage="ãä ÝÖáß Þã ÈÊÛííÑ ÃÓã ÇáãÓÊÎÏã" EmailLabelText="ÇáÈÑíÏ ÇáÃáßÊÑæäí"
            EmailRegularExpressionErrorMessage="ÃÏÎá ÚäæÇä ÈÑíÏ ÃáßÊÑæäí ãÎÊáÝ" EmailRequiredErrorMessage="ÚäæÇä ÈÑíÏ ÇáßÊÑæäí ÃÌÈÇÑí"
            FinishCompleteButtonText="ÃäåÇÁ" FinishPreviousButtonText="ÇáÓÇÈÞ" Font-Names="Verdana"
            Font-Size="0.8em" InvalidAnswerErrorMessage="ÃÏÎá ÃÌÇÈÉ ÓÑíÉ ãÎÊáÝÉ" InvalidEmailErrorMessage="ÃÏÎá ÚäæÇä ÈÑíÏ ÃáßÊÑæäí ÈØÑíÞÉ ÕÍíÍÉ"
            InvalidPasswordErrorMessage="ÇáÍÏ ÇáÃÏäì áÚÏÏ ÍÑæÝ ßáãÉ ÇáÓÑ: {0}. ÃÏÎá ÈÚÖ ÇáÑãæÒ: {1}."
            InvalidQuestionErrorMessage="ÃÏÎá ÓÄÇá ÓÑí ãÎÊáÝ" PasswordLabelText="ßáãÉ ÇáÓÑ"
            PasswordRegularExpressionErrorMessage="ÃÏÎá ßáãÉ ÓÑ ãÎÊáÝÉ" PasswordRequiredErrorMessage="ßáãÉ ÇáÓÑ ÃÌÈÇÑí"
            QuestionLabelText="ÇáÓÄÇá ÇáÓÑí" QuestionRequiredErrorMessage="ÇáÓÄÇá ÇáÓÑí ÃÌÈÇÑí"
            StartNextButtonText="ÇáÊÇáì" StepNextButtonText="ÇáÊÇáì" StepPreviousButtonText="ÇáÓÇÈÞ"
            UnknownErrorMessage="áã íÊã ÃäÔÇÁ ÇáÍÓÇÈ ÍÇæá ãÑÉ ÃÎÑì" UserNameLabelText="ÃÓã ÇáãÓÊÎÏã"
            UserNameRequiredErrorMessage="ÃÓã ÇáãÓÊÎÏã ÃÌÈÇÑí">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
            <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em"
                ForeColor="White" HorizontalAlign="Center" />
            <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <StepStyle BorderWidth="0px" />
        </asp:CreateUserWizard>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" CancelButtonText="�����"
            ChangePasswordButtonText="����� ���� ����" ChangePasswordFailureText="���� �� ���. ���� ������ ���� ���� ���� �������: {0}. ����� ����� ��� ������: {1}."
            ChangePasswordTitleText="���� ���� ���� ������ ��" ConfirmNewPasswordLabelText="����� ���� ���� �������"
            ConfirmPasswordCompareErrorMessage="��� �� ������ ���� ���� ������� � ����� ���� ���� �������"
            ConfirmPasswordRequiredErrorMessage="����� ���� ���� ������" ContinueButtonText="������"
            Font-Names="Verdana" Font-Size="0.8em" NewPasswordLabelText="���� ���� �������"
            NewPasswordRegularExpressionErrorMessage="���� ���� �� ������" NewPasswordRequiredErrorMessage="���� ���� ������� ������"
            PasswordLabelText="���� ����" PasswordRequiredErrorMessage="���� ���� ������"
            SuccessPageUrl="~/Default.aspx" SuccessText="�� ����� ���� ����" SuccessTitleText="�� ����� ���� ����"
            UserNameLabelText="��� ��������" UserNameRequiredErrorMessage="��� �������� ������">
            <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <PasswordHintStyle Font-Italic="True" ForeColor="#888888" />
            <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <TextBoxStyle Font-Size="0.8em" />
        </asp:ChangePassword>
    
    </div>
    </form>
</body>
</html>

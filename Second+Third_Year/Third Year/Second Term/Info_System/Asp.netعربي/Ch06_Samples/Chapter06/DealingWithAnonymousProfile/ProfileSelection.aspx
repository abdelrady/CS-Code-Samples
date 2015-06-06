<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileSelection.aspx.cs" Inherits="ProfileSelection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>��� ��������</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp;
        <br />
        <table>
            <tr>
                <td>
                    ������ �������</td>
                <td>
                    ���� ������</td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:ListBox ID="ddlCar" runat="server" >
                        <asp:ListItem Selected="True">����� �����</asp:ListItem>
                        <asp:ListItem>����� �����</asp:ListItem>
                        <asp:ListItem>����� ������</asp:ListItem>
                        <asp:ListItem>����� ������</asp:ListItem>
                        <asp:ListItem>����� �������</asp:ListItem>
                    </asp:ListBox></td>
                <td style="width: 100px">
                    <asp:ListBox ID="ddlColor" runat="server">
                        <asp:ListItem Selected="True">����</asp:ListItem>
                        <asp:ListItem>����</asp:ListItem>
                        <asp:ListItem>����</asp:ListItem>
                        <asp:ListItem>������</asp:ListItem>
                        <asp:ListItem>�����</asp:ListItem>
                    </asp:ListBox></td>
            </tr>
            <tr>
                <td>
                    ��� ������ �����</td>
                <td>
                    ����� ������</td>
            </tr>
            <tr>
                <td >
                    <asp:ListBox ID="ddlSunGlasses" runat="server">
                        <asp:ListItem Selected="True">����� �����</asp:ListItem>
                        <asp:ListItem>����� �����</asp:ListItem>
                        <asp:ListItem>����� ������</asp:ListItem>
                        <asp:ListItem>����� ������</asp:ListItem>
                        <asp:ListItem>����� �������</asp:ListItem>
                    </asp:ListBox></td>
                <td >
                    <asp:ListBox ID="ddlBook" runat="server">
                        <asp:ListItem Selected="True">���� ����</asp:ListItem>
                        <asp:ListItem>��� ���� ����</asp:ListItem>
                        <asp:ListItem>��� ����</asp:ListItem>
                        <asp:ListItem>�� ���</asp:ListItem>
                        <asp:ListItem>�� ����� </asp:ListItem>
                        <asp:ListItem>�� ����</asp:ListItem>
                        <asp:ListItem>����� �����</asp:ListItem>
                    </asp:ListBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="��� ��������" /></td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" DestinationPageUrl="~/ViewData.aspx" FailureText="���� ���� ���� ��� ����" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" LoginButtonText="����" Orientation="Horizontal" PasswordLabelText="���� ����" RememberMeText="������" TitleText="����" UserNameLabelText="��� ��������">
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        </asp:Login>
    </form>
</body>
</html>

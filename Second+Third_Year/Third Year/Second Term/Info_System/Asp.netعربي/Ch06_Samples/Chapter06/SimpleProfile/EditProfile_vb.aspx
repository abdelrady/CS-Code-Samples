<%@ Page Language="VB" AutoEventWireup="false" CodeFile="EditProfile_vb.aspx.vb" Inherits="EditProfile_vb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head id="Head1" runat="server">
    <title>����� ���� ������</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td >
                    �����</td>
                <td >
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td >
                </td>
            </tr>
            <tr>
                <td >
                    �������</td>
                <td >
                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td >
                    ��� ��������</td>
                <td >
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                <td >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="���� ��� ������ ������ �����" ControlToValidate="txtPhone" ValidationExpression="\d{7}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td >
                    ������</td>
                <td >
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
                <td >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="���� ��� ������ ������ �����" ControlToValidate="txtMobile" ValidationExpression="\d\d\d-\d\d\d\d\d\d\d"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td >
                    ����� �������</td>
                <td >
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
                <td >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="���� ������ ������ �����" ControlToValidate="txtDate" ValidationExpression="\d\d-\d\d-\d\d\d\d"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td >
                    ������</td>
                <td >
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
                <td >
                </td>
            </tr>
            <tr>
                <td >
                    �������</td>
                <td >
                    <asp:TextBox ID="txtNationality" runat="server"></asp:TextBox></td>
                <td >
                </td>
            </tr>
            <tr>
                <td>
                    �������</td>
                <td >
                    <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                <td >
                </td>
            </tr>
            <tr>
                <td >
                    ��� ������</td>
                <td >
                    <asp:DropDownList ID="ddlSystemColor" runat="server">
                        <asp:ListItem Value="0">����</asp:ListItem>
                        <asp:ListItem Value="1">����</asp:ListItem>
                        <asp:ListItem Value="2">����</asp:ListItem>
                    </asp:DropDownList></td>
                <td >
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="�������������" /><br />
                    <asp:Literal ID="ltrl" runat="server"></asp:Literal><br />
                    <asp:Label ID="lblColorTest" runat="server" Font-Size="XX-Large" Text="��� �����"></asp:Label>
                    <br />
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

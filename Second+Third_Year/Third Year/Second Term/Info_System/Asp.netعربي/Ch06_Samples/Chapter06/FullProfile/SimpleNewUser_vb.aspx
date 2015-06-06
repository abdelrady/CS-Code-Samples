<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleNewUser_vb.aspx.vb" Inherits="SimpleNewUser_vb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir=rtl >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td> ����� </td>
                <td> <asp:TextBox ID="txtName" runat="server"/> </td>
                <td> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                        ErrorMessage="���� ��� ��������"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td> ���� ����</td>
                <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/> </td>
                <td> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="���� ���� ����"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td> ����� ���� ����</td>
                <td> <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"/> </td>
                <td> &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtConfirmPassword"
                        ControlToValidate="txtPassword" ErrorMessage="��� �� ������ ��� �� ���� ���� � ����� ���� ����"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td>
                    ���� ��������</td>
                <td><asp:TextBox ID="txtEmail" runat="server"/></td>
                <td>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="���� ������ ����������"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    ���� ����� ������</td>
                <td><asp:TextBox ID="txtQuestion" runat="server"/></td>
                <td>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="���� ������"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    ����� ������</td>
                <td><asp:TextBox ID="txtAnswer" runat="server"/></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="���� �������"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="�����" /><br />
                    <asp:Literal ID="ltrlResult" runat="server"></asp:Literal></td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileSelection.aspx.cs" Inherits="ProfileSelection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>ЌЁў гЏбжг« я</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp;
        <br />
        <table>
            <tr>
                <td>
                    ”н«— я «бгЁ÷б…</td>
                <td>
                    бждя «бгЁ÷б</td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:ListBox ID="ddlCar" runat="server" >
                        <asp:ListItem Selected="True">’д«Џе г’—не</asp:ListItem>
                        <asp:ListItem>’д«Џе ”ж—не</asp:ListItem>
                        <asp:ListItem>’д«Џе ќбнћне</asp:ListItem>
                        <asp:ListItem>’д«Џе ”Џжѕне</asp:ListItem>
                        <asp:ListItem>’д«Џе ћ“«∆—не</asp:ListItem>
                    </asp:ListBox></td>
                <td style="width: 100px">
                    <asp:ListBox ID="ddlColor" runat="server">
                        <asp:ListItem Selected="True">√ќ÷—</asp:ListItem>
                        <asp:ListItem>√Ќг—</asp:ListItem>
                        <asp:ListItem>√’Ё—</asp:ListItem>
                        <asp:ListItem>ЁЌбжён</asp:ListItem>
                        <asp:ListItem>»дѕён</asp:ListItem>
                    </asp:ListBox></td>
            </tr>
            <tr>
                <td>
                    джЏ дў«—«  «б‘г”</td>
                <td>
                    я «»я «бгЁ÷б</td>
            </tr>
            <tr>
                <td >
                    <asp:ListBox ID="ddlSunGlasses" runat="server">
                        <asp:ListItem Selected="True">’д«Џе г’—не</asp:ListItem>
                        <asp:ListItem>’д«Џе ”ж—не</asp:ListItem>
                        <asp:ListItem>’д«Џе ќбнћне</asp:ListItem>
                        <asp:ListItem>’д«Џе ”Џжѕне</asp:ListItem>
                        <asp:ListItem>’д«Џе ћ“«∆—не</asp:ListItem>
                    </asp:ListBox></td>
                <td >
                    <asp:ListBox ID="ddlBook" runat="server">
                        <asp:ListItem Selected="True">я «» «ббе</asp:ListItem>
                        <asp:ListItem>”д… —”жб «ббе</asp:ListItem>
                        <asp:ListItem>–я— «ббе</asp:ListItem>
                        <asp:ListItem>Ќ» —»я</asp:ListItem>
                        <asp:ListItem>Ќ» —”жбя </asp:ListItem>
                        <asp:ListItem>Ќ» ѕндя</asp:ListItem>
                        <asp:ListItem>«бЏгб бѕндя</asp:ListItem>
                    </asp:ListBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ЌЁў «бќн«—« " /></td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" DestinationPageUrl="~/ViewData.aspx" FailureText="ѕќжб ќ«Ў∆ Ќ«жб г—… √ќ—м" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" LoginButtonText="ѕќжб" Orientation="Horizontal" PasswordLabelText="ябг… «б”—" RememberMeText=" –я—дн" TitleText="ѕќжб" UserNameLabelText="√”г «бг” ќѕг">
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        </asp:Login>
    </form>
</body>
</html>

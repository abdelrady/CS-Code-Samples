<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="contentBackground" style="BACKGROUND-POSITION: center top; MARGIN-TOP: 2px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 485px;z-index:1;">
<IMG height=585 src="images/headerbox.png" width=772>
</div>
<div id="ContentPlaceHolder" style="MARGIN-TOP: 0px; MARGIN-LEFT: 7px;z-index:0;left: 50px; position: relative; top: -505px;">

    <h1>
        &nbsp;
        Log In</h1>
    <p>
        &nbsp;</p>
    
        <table border="0" cellpadding="4" cellspacing="0" background="imagenew/sn_bk.jpg" style="left: 5pt; position: relative; top: -25px; width: 449pt;">
            <tr>
                <td align="left" colspan="2" valign="center">
        <asp:Label ID="Label1" runat="server" BorderColor="ActiveCaptionText" BorderStyle="None" Height="121px" Width="455px"></asp:Label></td>
            </tr>
            <tr>
                <td align="right" valign="center" width="42%">
                    Type:</td>
                <td align="left" valign="center" style="width: 264px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Employer</asp:ListItem>
                        <asp:ListItem>Job Seeker</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" valign="center" width="42%">
                    <span class="content">User ID:</span></td>
                <td align="left" valign="center" style="width: 264px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="Required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="right" valign="center" width="30%" style="height: 26px">
                    <span class="content">Password:</span></td>
                <td align="left" valign="center" style="height: 26px; width: 264px;">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                        ErrorMessage="Required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="right" valign="center">
                    <input id="rememberme" name="rememberme" type="checkbox" /></td>
                <td align="left" valign="center" style="width: 264px">
                    Remember my ID on this computer
                </td>
            </tr>
            <tr>
                <td width="30%">
                </td>
                <td align="left" valign="top" style="width: 264px">
                    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <p>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Register Here</asp:LinkButton>&nbsp;</p>
                        
                    <p>
                        Lost your password? <a href="Employee_Lost_Password.aspx"><span
                            style="color: #0000ff">Click here</span></a>
                        <br />
                        For additional help, email <a href="mailto:abdelrady@gmail.com"><span style="color: #0000ff">
                            abdelrady@gmail.com</span></a>
                        <br />
                    </p>
                </td>
            </tr>
        </table>
    
</asp:Content>


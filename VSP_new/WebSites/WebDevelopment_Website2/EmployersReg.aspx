<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployersReg.aspx.cs" Inherits="EmployersReg" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
<!--

function Checkbox2_onclick(form) {
document.aspnetForm.ctl00$ContentPlaceHolder1$Button1.disabled=!document.aspnetForm.ctl00$ContentPlaceHolder1$Button1.disabled;
}

function IMG2_onclick() {

}

// -->
</script>
<div id="contentBackground" style="BACKGROUND-POSITION:center top; MARGIN-TOP: 2px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 485px;z-index:1;">
<IMG height=1430 src="images/headerbox.png" width=772>
</div>
    
<div id="ContentPlaceHolder" style="MARGIN-TOP: 0px;MARGIN-LEFT: 7px;z-index:0;left: 10px; position:relative; top: -500px;width:740px;">
    <h1>
        Employer Registration
    </h1>
    <p>
        To register, complete the fields below.</p>
    <p>
        If you already have been assigned a CareerFCIS.com ID and password, log in to your
        <a href="login.aspx?type=Employers"><b><span style="color: #0000ff">Member Desktop</span></b></a>
        to begin.</p>
    <h3>
        <asp:Label ID="Label1" runat="server"></asp:Label>&nbsp;</h3>
    <h3>
        Member Name&nbsp;
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            
            <td align="left" colspan="4">
                <span class="tablenote"><span class="mandatory" style="font-size: 7pt; color: red">*=
                    required field </span></span>
            </td>
        </tr>
        <tr style="font-size: 7pt; color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr style="font-size: 7pt; color: #000000">
            <td align="middle" valign="top" width="10">
                <img height="5" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tabletitle"><span class="mandatory"><span
                    style="color: #000000">First Name</span><em><span style="font-size: 7pt; color: #ff0000">*</span></em><span
                        style="color: #000000"> </span></span></span>
                    <br />
                    <img height="2" src="images/space.gif" style="color: #000000"
                        width="110" /><em><span style="font-size: 7pt"></span></em></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span><span class="tabletitle"><span class="mandatory"><span
                    style="color: #000000">
                    Last Name <span>*</span></span></span></span><br />
                    <img id="IMG1" height="2" src="images/space.gif"
                        style="color: #000000" width="110" /></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox2" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/space.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span style="color: #000000" class="tabletitle">Title</span>
                <br />
                <img height="2" src="images/space.gif" width="110" id="IMG2" language="javascript" onclick="return IMG2_onclick()" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox3" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Company Name</span><span
                    style="color: #000000">&nbsp; &nbsp;</span><a href=""
                        tabindex="3001"></a></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox4" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
    </table>
    <h3>
        Address&nbsp;
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" style="height: 21px" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td style="height: 21px" valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span><span><span class="tabletitle"><span class="mandatory" style="color: #000000">
                    Address </span></span>
                    <br />
                    <img height="2" src="images/space.gif" width="110" /></span></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000; height: 21px" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td style="color: #000000; height: 21px" width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000; height: 21px" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox5" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/space.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory" style="color: #000000">&nbsp;</span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox7" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">City</span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox6" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Country</span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;&nbsp;<br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Egypt</asp:ListItem>
                    <asp:ListItem>Saudi</asp:ListItem>
                    <asp:ListItem>Qatar</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>UAE</asp:ListItem>
                </asp:DropDownList>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
    </table>
    <h3>
        <span style="font-size: 7pt;">Contact Info&nbsp;</span></h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Phone</span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox8" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory"><span style="font-size: 7pt; text-transform: capitalize;
                    color: #ff0000">email</span><span style="color: #000000"> for Account Communications<span
                        style="font-size: 7pt; color: #000000">*</span></span></span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox9" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/space.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span class="tabletitle" style="color: #000000">Website</span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox10" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
    </table>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        
        <h3>
            Your Account</h3>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory"><span style="color: #000000">User ID<em><span
                    style="font-size: 7pt; color: #ff0000">*</span></em></span><a href="" tabindex="3002"></a></span></span>
                <br />
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                &nbsp;<br />
                &nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="233px"></asp:TextBox>
                <img height="2" src="images/space.gif" width="1" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox11"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Password</span><a
                    href="" onclick="javascript:popup(this.href, 350, 450, 'Password');return false;"
                    tabindex="3004"></a><em><span style="font-size: 7pt; color: #ff0000">*</span></em></span>
                <div class="tablenote">
                    <span class="mandatory"></span>
                </div>
                <img height="2" src="images/space.gif" width="110" /></td>
            <td bgcolor="#c9d1f2" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                <img height="2" src="images/space.gif" width="1" />
                <asp:TextBox ID="TextBox12" runat="server" TextMode="Password" Width="233px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox12"
                    ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox12"
                    ControlToValidate="TextBox13" ErrorMessage="Passwords Must Match"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                <img height="6" src="images/space.gif" width="5" /><br />
                <img height="5" src="images/red.gif" width="5" /><img
                    height="2" src="images/space.gif" width="5" /></td>
            <td valign="top" width="110">
                <img height="2" src="images/space.gif" width="110" /><br />
                <span style="color: #000000"><span class="tablenote"><span class="mandatory" style="font-size: 10pt;">Re-enter
                    Password<span style="font-size: 7pt; color: #ff0000">*</span><br />
                </span></span>
                    <br />
                    <img height="2" src="images/space.gif" width="110" /></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                <img height="10" src="images/space.gif"
                    width="1" /></td>
            <td style="color: #000000" width="5">
                <img height="10" src="images/space.gif"
                    width="5" /></td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <img height="2" src="images/space.gif" width="1" /><br />
                <img height="2" src="images/space.gif" width="1" />
                <asp:TextBox ID="TextBox13" runat="server" TextMode="Password" Width="233px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox13"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                <img height="1" src="images/space.gif" width="456" /></td>
        </tr>
        <tr>
            <td align="middle" colspan="6">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="4">
                <span style="font-size: 7pt; color: #000066"><strong>
                    &nbsp; 
                    <input id="Checkbox2" type="checkbox" language="javascript" onclick="return Checkbox2_onclick(this)" />
                    Click To Accept <a onclick="showModelessDialog('EmptyPolicy.aspx');" onmouseover="" style="color:Blue;text-decoration:underline;">website Terms</a></strong></span></td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                <img height="3" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                <img height="3" src="images/space.gif" width="1" /></td>
        </tr>
        <tr>
            <td align="middle" colspan="5" style="height: 12px">
                <span class="tabletext">&nbsp; &nbsp; &nbsp;<asp:Button ID="Button1" runat="server"
                    OnClick="Button1_Click" Text="Register" Enabled="False" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input name="Clear" type="reset" value="Clear Form" /></span></td>
        </tr>
    </table>
    </div>
 
                                    
</asp:Content>


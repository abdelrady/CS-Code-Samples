<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeReg.aspx.cs" Inherits="EmployeeReg" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
<!--
function IMG1_onclick() {

}

function validate1()
{

 if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox1.value.length <3) {
 alert('Your FirstName must be at least\n3 characters long.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox1.focus();
 }
 else if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox2.value<3){alert('Your LastName must be at least\n3 characters long.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox2.focus();}
 else if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox3.value<3){alert('You Have to enter Any Key words In Job Experts.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox3.focus();}
 else if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox9.value<3){alert('There are no email addresses in the To field.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox9.focus();}
 else if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox11.value<3){alert('You Must Enter User ID.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder11$TextBox11.focus();}
 else if(document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox12.value<3){alert('You Must Enter Password.\nPlease try again.');document.aspnetForm.ctl00$ContentPlaceHolder1$TextBox12.focus();}
}

function Checkbox2_onclick() {
document.aspnetForm.ctl00$ContentPlaceHolder1$Button1.disabled=!document.aspnetForm.ctl00$ContentPlaceHolder1$Button1.disabled;
}

// -->
</script>
<div id="contentBackground" style="BACKGROUND-POSITION: center top; MARGIN-TOP: 2px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 485px;z-index:1;">
<IMG height=1595 src="images/headerbox.png" width=772>
</div>
<div id="ContentPlaceHolder" style="MARGIN-TOP: 0px; MARGIN-LEFT: 7px;z-index:0;left: 100px; position: relative; top: -450px;width:500px;">

 <h1>
     Employee Registration
    </h1>
    <p>
        To register, complete the fields below.</p>
    <p>
        If you already have been assigned a FCIS.com ID and password, log in to your
        <a href="login.aspx?type=Employee"><b><span style="color: #0000ff">Member Desktop</span></b></a>
        to begin.</p>
    <h3>
        <asp:Label ID="Label1" runat="server" Font-Size="Small"></asp:Label>&nbsp;<asp:Label
            ID="Label2" runat="server"></asp:Label></h3>
    <h3>
        <span style="color: #000000">Member Name&nbsp;</span>
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            <td align="middle" valign="top" width="10">
            </td>
            <td align="left" colspan="4">
                <span class="tablenote"><span class="mandatory" style="font-size: 7pt; color: red">*=
                    required field </span></span>
            </td>
        </tr>
        <tr style="font-size: 7pt; color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
            </td>
        </tr>
        <tr style="font-size: 7pt; color: #000000">
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                <br />
                <span style="color: #000000"><span class="tabletitle"><span class="mandatory"><span
                    style="color: #000000">First Name</span><em><span style="font-size: 7pt; color: #ff0000">*</span></em><span
                        style="color: #000000"> </span></span></span>
                    <br />
                <em><span style="font-size: 7pt"></span></em></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                </td>
            <td style="color: #000000" width="5">
                </td>
            <td align="left" style="color: #000000" valign="top" width="330">
                &nbsp;<br />
                <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                
                <span><span class="tabletitle"><span class="mandatory"><span
                    style="color: #000000">
                    Last Name <span>*</span></span></span></span><br />
                </span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                </td>
            <td style="color: #000000" width="5">
                </td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <asp:TextBox ID="TextBox2" runat="server" Width="233px"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        
        <tr style="font-size: 7pt; color: #000000">
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                <br />
                <span class="tabletitle"><span class="mandatory"><span
                    style="color: #000000">Experts in Key Words</span><em><span style="font-size: 7pt; color: #ff0000">*</span></em><span
                        style="color: #000000"> </span></span>
                    <br />
                    <em><span style="font-size: 7pt"></span></em></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                </td>
            <td style="color: #000000" width="5">
                </td>
            <td align="left" style="color: #000000" valign="top" width="330">
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Width="233px"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:TextBox ID="TextBox4" runat="server" Width="233px"></asp:TextBox><br />
                <asp:TextBox ID="TextBox10" runat="server" Width="233px"></asp:TextBox><br />
                <asp:DropDownList ID="DropDownList2" runat="server" Width="237px">
                    <asp:ListItem>Computer System</asp:ListItem>
                    <asp:ListItem>Education</asp:ListItem>
                    <asp:ListItem>Agriculture</asp:ListItem>
                    <asp:ListItem>Commerce</asp:ListItem>
                    <asp:ListItem>Engineering</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td align="middle" valign="top" width="10">
            </td>
            <td valign="top" width="110">
            </td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
            </td>
            <td style="color: #000000" width="5">
            </td>
            <td align="left" style="color: #000000" valign="top" width="330">
            </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
    </table>
    <h3>
        Address&nbsp;
    </h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td align="middle" style="height: 21px" valign="top" width="10">
                </td>
            <td style="height: 21px" valign="top" width="110">
                <br />
                <span><span><span class="tabletitle"><span class="mandatory" style="color: #000000">
                    Address </span></span>
                    <br />
                    </span></span></td>
            <td bgcolor="#c9d1f2" style="color: #000000; height: 21px" width="1">
                </td>
            <td style="color: #000000; height: 21px" width="5">
                </td>
            <td align="left" style="color: #000000; height: 21px" valign="top" width="330">
                <br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox5" runat="server" Width="233px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                <br />
                <span class="tabletitle"><span class="mandatory" style="color: #000000">&nbsp;</span></span>
                <br />
                </td>
            <td bgcolor="#c9d1f2" width="1">
                </td>
            <td width="5">
                </td>
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
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Egypt</asp:ListItem>
                    <asp:ListItem>Saudi</asp:ListItem>
                    <asp:ListItem>Qatar</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>UAE</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
    </table>
    <h3>
        <span style="font-size: 7pt;"><span style="font-size: 13pt; color: #000000">Contact Info&nbsp;</span></span></h3>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                <span class="tabletitle"><span class="mandatory" style="color: #000000">Phone</span></span>
                <br />
                </td>
            <td bgcolor="#c9d1f2" width="1">
                </td>
            <td width="5">
                </td>
            <td align="left" valign="top" width="330">
                <asp:TextBox ID="TextBox8" runat="server" Width="233px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                
                <span class="tabletitle"><span class="mandatory"><span style="font-size: 7pt; text-transform: capitalize;
                    color: #ff0000">email</span><span style="color: #000000"> for Account Communications<span
                        style="font-size: 7pt; color: #000000">*</span></span></span></span>
                <br />
                </td>
            <td bgcolor="#c9d1f2" width="1">
                </td>
            <td width="5">
                </td>
            <td align="left" valign="top" width="330">
                <br />
                &nbsp;<br />
                <asp:TextBox ID="TextBox9" runat="server" Width="233px" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
    </table>
    <table border="0" cellpadding="0" cellspacing="0" width="456" background="imagenew/sn_bk.jpg">
        
        <h3>
            Your Account</h3>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td align="middle" valign="top" width="10">
                </td>
            <td valign="top" width="110">
                
                <span class="tabletitle"><span class="mandatory"><span style="color: #000000">User ID<em><span
                    style="font-size: 7pt; color: #ff0000">*</span></em></span></span></span>
                <br />
                </td>
            <td bgcolor="#c9d1f2" width="1">
                </td>
            <td width="5">
</td>
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
                
                <span style="color: #000000"><span class="tablenote"><span class="mandatory" style="font-size: 10pt;">Re-enter
                    Password<span style="font-size: 7pt; color: #ff0000">*</span><br />
                </span></span>
                    <br />
                   </span> </td>
            <td bgcolor="#c9d1f2" style="color: #000000" width="1">
                </td>
            <td style="color: #000000" width="5">
                </td>
            <td align="left" style="color: #000000" valign="top" width="330">
                
                <asp:TextBox ID="TextBox13" runat="server" TextMode="Password" Width="233px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox13"
                    ErrorMessage="Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr style="color: #000000">
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
        </tr>
        <tr>
            <td bgcolor="#c9d1f2" colspan="5" height="1">
                </td>
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
<textarea id="TextArea1" readonly="readonly" style="width: 435px; height: 144px" >While the administrators and moderators of this forum will attempt to remove or edit any generally objectionable material as quickly as possible, it is impossible to review every message. Therefore you acknowledge that all posts made to these forums express the views and opinions of the author and not the administrators, moderators or webmaster (except for posts by these people) and hence will not be held liable.

You agree not to post any abusive, obscene, hateful, threatening or any other material that may violate any applicable laws. Doing so may lead to you being immediately and permanently banned (and your service provider being informed). The IP address of all posts is recorded to aid in enforcing these conditions. As a user you agree to any information you have entered above being stored in a database. While this information will not be disclosed to any third party without your consent the webmaster, administrator and moderators cannot be held responsible for any hacking attempt that may lead to the data being compromised.

This forum system uses cookies to store information on your local computer. These cookies do not contain any of the information you have entered above; they serve only to improve your viewing pleasure. The e-mail address is used only for confirming your registration details and password (and for sending new passwords should you forget your current one).

By clicking Register below you agree to be bound by these conditions.
</textarea>
                    <input id="Checkbox2" type="checkbox" language="javascript" onclick="return Checkbox2_onclick()" />
                    Click To Accept <a href="policy.aspx">website Terms</a></strong></span></td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                </td>
        </tr>
        <tr>
            <td colspan="5" height="3">
                </td>
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
   
</asp:Content>


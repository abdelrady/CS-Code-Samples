<%@ page language="C#" master="~/forumtemplate.master"%>

<script runat=server>

</script>

<asp:content id="SiteContent" ContentPlaceHolderId="sitecontent" runat="server">

    <table style="WIDTH: 544px; HEIGHT: 270px" cellpadding="5" width="544" border="0">
        <tbody>
            <tr>
                <td width="10">
                </td>
                <td colspan="3">
                    <p>
                        <span id="pagetitle">Login</span>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="10">
                </td>
                <td rowspan="2" style="WIDTH: 396px">
                    <asp:login id="Login1" runat="server" font-size="0.8em" font-names="Verdana" height="141px"
                        width="504px" hidewhenloggedin="False" passwordrecoverytext="Forgot Password?"
                        passwordrecoveryurl="passwordrecovery.aspx">
                        <layouttemplate>
                            <table border="0" align="left" height="140" style="font:Verdana; font-size:.8em; font-color:blue;">
                                <tr>
                                    <td align="left">Email:</td>
                                    <td width="10">
                                    </td>
                                    <td>
                                        <asp:textbox runat="server" id="UserName" size="37"></asp:textbox><asp:requiredfieldvalidator runat="server" id="UserNameRequired" controltovalidate="UserName" errormessage="Email is required.">*</asp:requiredfieldvalidator>
                                    </td>
                                    <td rowspan="5" valign="top">
                                    <img height="128" src="images/lock.gif" width="91" alt="padlock"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">Password:</td>
                                    <td width="10">
                                    </td>
                                    <td>
                                        <asp:textbox runat="server" id="Password" textmode="Password" size="39"></asp:textbox><asp:requiredfieldvalidator runat="server" id="PasswordRequired" controltovalidate="Password"
                                            errormessage="Password is Required.">*</asp:requiredfieldvalidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" align="left">
                                        <br />
                                        <asp:checkbox runat="server" forecolor="Maroon" text="Remember me next time." id="RememberMe"></asp:checkbox>
                                    </td>
                                </tr>
                                <tr>
                                </tr>
                                <tr>
                                    <td align="left" valign="bottom" colspan="3" height="40">
                                        <br />
                                        <asp:imagebutton imageurl="images/loginbuttonsmall.jpg" runat="server" text="Login"
                                            id="Button" commandname="Submit"></asp:imagebutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <br />
                                        <asp:literal runat="server" id="FailureText"></asp:literal>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="3">
                                        <asp:validationsummary id="Validationsummary1" runat="server" />
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="3" align="left" height="30">
                                        <asp:hyperlink runat="server" forecolor="Maroon" font="Verdana" font-underline="true"
                                            text="Forgot Your Password?" navigateurl="PasswordReminder.aspx" id="ForgotPassword"></asp:hyperlink>
                                        <br /> 
                                        <asp:hyperlink runat="server" forecolor="Maroon" font="Verdana" font-underline="true"
                                            text="Register New Account" navigateurl="Register.aspx" id="GoToRegister"></asp:hyperlink><br>
                                    
                                    </td>
                                </tr>
                                
                            </table>
                        </layouttemplate>
                    </asp:login>
                </td>
            </tr>
        </tbody>
    </table>
    
</asp:content>

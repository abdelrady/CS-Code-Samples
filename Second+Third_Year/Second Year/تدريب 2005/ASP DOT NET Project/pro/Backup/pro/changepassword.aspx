<%@ page language="C#" master="~/forumtemplate.master"%>

<script language="C#" runat="server">

    void ChangePassword_Click(object Sender, ImageClickEventArgs e) {
    
       if (Page.IsValid) {
            try {
                MembershipUser user;
                user = Membership.GetUser();
                user.ChangePassword(Password.Text, PasswordNew1.Text);

                Status.Text = "Password Updated";
            }            
            catch(Exception ex) {
                Status.Text = "We were unable to update your password. Please try again.";
            }
          
       }
        
    }

</script>

<asp:content id="SiteContent" ContentPlaceHolderId="sitecontent" runat="server"><table style="WIDTH: 530px; HEIGHT: 261px" cellpadding="5" width="400" border="0">
        <tbody>
            <tr>
                <td width="5">
                </td>
                <td colspan="3">
                    <p>
                        <span id="pagetitle">Change Password</span>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="5">
                </td>
                <td rowspan="2" valign="top">
                    <table border="0">
                        <tr>
                            <td width="140">
                                <span id="bodytext">Old Password:</span> &nbsp;
                            </td>
                            <td>
                                <asp:textbox textmode="Password" id="Password" size="30" runat="server" />
                            </td>
                            <td style="WIDTH: 3px">&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <span id="bodytext">New Password:</span>
                            </td>
                            <td>
                                <asp:textbox textmode="Password" id="PasswordNew1" size="30" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span id="bodytext">Repeat New Password:</span>
                            </td>
                            <td>
                                <asp:textbox textmode="Password" id="PasswordNew2" size="30" runat="server" />
                                <asp:comparevalidator id="CompareValidator1" runat="server" errormessage="Passwords do not match!"
                                    controltocompare="PasswordNew2" controltovalidate="PasswordNew1" display="Dynamic">*</asp:comparevalidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" height="80" align="left" valign="bottom"><br /><br />
                                <asp:imagebutton id="Imagebutton1" runat="server" onclick="ChangePassword_Click"
                                    imageurl="images/changepasswordbutton.gif" /><br />
                                <br />
                                <asp:validationsummary id="ValidationSummary1" runat="server" />
                                <asp:label id="Status" runat="server" font-bold="True" forecolor="Red"></asp:label>
                                <br />
                            </td>
                            <td style="WIDTH: 3px">
                                
                            </td>
                         
                        </tr>
                    </table>
            <tr>
                <td width="5"></td>
                <td width="16" valign="top">
                    <img height="128" src="images/lockandkey.gif" width="91" /></td>
            </tr>
        </tbody>
    </table>
</asp:content>

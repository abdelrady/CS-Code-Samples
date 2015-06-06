<%@ page language="C#" master="~/forumtemplate.master"%>
<asp:content id="SiteContent" ContentPlaceHolderId="sitecontent" runat="server"><table style="WIDTH: 544px; HEIGHT: 270px" cellpadding="5" width="544" border="0">
        <tbody>
            <tr>
                <td width="10">
                </td>
                <td colspan="3">
                    <p>
                        <span id="pagetitle">Password Reminder</span>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="10">
                </td>
                <td rowspan="2">
                    <p>
                        <asp:passwordrecovery id="PasswordRecovery1" runat="server" font-names="Verdana"
                            width="400px" height="200px">
                            <successtemplate>
                                <table border="0"><tr>
                                        <td><span id="bodytext">Your password has been reset <br />
                                                                and sent to you by email.</span>
                                            <br><br>
                                            <span id="redtext">
                                            <asp:hyperlink runat="server" forecolor="Maroon" font="Verdana" font-underline="true"
                                            text="Click Here to Change Your Password" navigateurl="ChangePassword.aspx"></asp:hyperlink>
                                            </span> 
                                                                </td>
                                    </tr></table>
                            </successtemplate>
                            <questiontemplate>
                                <table border="0"><tr>
                                        <td id="bodytext" colspan="3" height="60"><b>Identity Confirmation</b></td>
                                    </tr>
                   
                                    <tr>
                                        <td id="bodytext" width="120"><b>Email:</b></td>
                                        <td id="bodytext">
                                            <asp:literal runat="server" id="UserName1"></asp:literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td id="bodytext"><b>Question:</b></td>
                                        <td id="bodytext">
                                            <asp:literal runat="server" id="Question"></asp:literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td id="bodytext"><b>Answer:</b></td>
                                        <td id="bodytext">
                                            <asp:textbox runat="server" id="Answer" size="30"></asp:textbox>
                                            <asp:requiredfieldvalidator runat="server" controltovalidate="Answer" errormessage="Answer."
                                                id="AnswerRequired">*</asp:requiredfieldvalidator></td>
                                    </tr>
                                    <tr>
                                        <td align="Left" colspan="2" height="80">
                                           <asp:imagebutton src="images/emailbutton.gif" runat="server" commandname="Submit" text="Submit" id="Imagebutton1"></asp:imagebutton>
                                         </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="color:Red;">
                                            <asp:literal runat="server" id="FailureText1"></asp:literal>
                                        </td>
                                    </tr></table>
                            </questiontemplate>
                            <usernametemplate>
                                <table border="0">
                                    <tbody>
                                        <tr>
                                            <td align="left" colspan="2" height="20" size="2" font-name="Verdana" valign="middle">
                                                <span id="bodytext">Enter your email address to receive your password.</span>
                                                <br />
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" size="2" height="20" font-name="Verdana" valign="middle">
                                                <span id="bodytext">Email:</span>
                                            </td>
                                            <td align="right">
                                                <asp:textbox id="UserName" runat="server" size="30"></asp:textbox>
                                                <asp:requiredfieldvalidator id="UserNameRequired" runat="server" errormessage="User Name."
                                                    controltovalidate="UserName">*</asp:requiredfieldvalidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" colspan="3" font-name="Verdana" height="50" valign="bottom">
                                            <br />
                                            <asp:imagebutton src="images/emailbutton.gif" runat="server" commandname="Submit" text="Submit" id="Button1"></asp:imagebutton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="COLOR: red" colspan="2" font-name="Verdana" font-size="2">
                                                <asp:literal id="FailureText2" runat="server"></asp:literal>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </usernametemplate>
                            
                            
                            
                        </asp:passwordrecovery>
                        
                        
                    </p>
                </td>
                <td colspan="2"><img  src="images/lightbulb.gif" /></td>
               
                    
            </tr>
            <tr>
                <td width="10">
                </td>
                <td width="16">
                </td>
                <td>&nbsp;</td>
            </tr>
        </tbody>
    </table>
</asp:content>

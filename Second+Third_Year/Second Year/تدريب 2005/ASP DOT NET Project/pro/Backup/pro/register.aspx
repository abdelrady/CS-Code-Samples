<%@ page language="C#" master="~/forumtemplate.master"%>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>
<script runat="server" language="C#">

    void Register_Click(Object Sender, ImageClickEventArgs e) {
        
        if(Page.IsValid) {
        
            try {
               
                
                MembershipUser user;
                user = Membership.CreateUser(Email.Text, Password.Text, Email.Text);
                user.ChangePasswordQuestionAndAnswer(Password.Text, Question.SelectedItem.Value, Answer.Text);
                Membership.UpdateUser(user);
                               
                FormsAuthentication.SetAuthCookie(Email.Text, false);
                 //////////////////////////
               string constr = 
            "provider=Microsoft.JET.OLEDB.4.0; " +
            "data source = E:/WebSites/pro/Data/users.mdb";    
          string comstr = "insert into client (send) values('"+Email.Text+"')";
          OleDbDataAdapter dataAdapter = 
            new OleDbDataAdapter (
            comstr, constr);  
          DataSet dataSet = new DataSet(  );
          dataAdapter.Fill(dataSet,"client");
          DataTable dataTable = new DataTable("client");
          DataRow row; 
          row = dataTable.NewRow();
          dataTable.Rows.Add (row);
          
        
        //DataTable dataTable = dataSet.Tables[0]
               
                                                               
                //////////////////////////                
                Response.Redirect("Default.aspx");
            }
            catch(Exception ex) {
                Status.Text = "The email address you entered is already in use. Please choose a different email address.";
            }
            
        }
        
    }

</script>

<asp:content id="sitecontent" runat="Server" ContentPlaceHolderId="sitecontent"><table cellpadding="3" border="0">
        <tbody>
            <tr>
                <td width="20" height="86">
                    &nbsp;
                </td>
                <td valign="top" colspan="3">
                    <p>
                        <span id="pagetitle">Register New Account</span>&nbsp;
                    </p>
                </td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;
                </td>
                <td width="87">
                    <span id="bodytext">Email:</span></td>
                <td width="360">
                    <asp:textbox runat="server" id="Email" width="306px" />
                    <asp:regularexpressionvalidator id="Regularexpressionvalidator1" display="Dynamic"
                        runat="server" errormessage="Invalid email address" controltovalidate="Email"
                        cssclass="validationWarningSmall" validationexpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:regularexpressionvalidator>
                    <asp:requiredfieldvalidator id="emailValidator" display="Dynamic" runat="server"
                        errormessage="Email is required" controltovalidate="Email" cssclass="validationWarningSmall">*</asp:requiredfieldvalidator>
                </td>
                <td width="131" rowspan="3">
                    <img src="images/pen.jpg" border="0" alt="pen on paper"/>
                </td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;
                </td>
                <td>
                    <span id="bodytext">Password:</span></td>
                <td>
                    <asp:textbox runat="server" textmode="Password" id="Password" width="304px" />
                    <asp:comparevalidator id="CompareValidator1" runat="server" errormessage="Passwords must be the same"
                        controltocompare="PasswordVerify" controltovalidate="Password" display="Dynamic">*</asp:comparevalidator>
                    <asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" errormessage="Password required"
                        controltovalidate="Password" display="Dynamic">*</asp:requiredfieldvalidator>
                </td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;
                </td>
                <td>
                    <span id="bodytext">Retype Password:</span></td>
                <td>
                    <asp:textbox runat="server" textmode="Password" id="PasswordVerify" width="304px" /></td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;
                </td>
                <td>
                    <span id="bodytext">Password Question:</span></td>
                <td>
                    <asp:dropdownlist id="Question" runat="server" width="308px">
                        <asp:listitem text="What is the name of your favorite pet?"/>
                        <asp:listitem text="What was your childhood nickname?"/>
                        <asp:listitem text="Who was your childhood hero?"/>
                        <asp:listitem text="What was your highschool mascot?"/>
                    </asp:dropdownlist>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;
                </td>
                <td>
                    <span id="bodytext">Answer:</span></td>
                <td>
                    <asp:textbox runat="server" id="Answer" width="304px" /></td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td colspan="2">
                    <br />
                    <br />
                    <div align="left">
                       <asp:imagebutton id="Imagebutton1" imageurl="images/registerbutton.jpg" onclick="Register_Click" runat="server" />
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td colspan="2">
                    <span id="redtext">
                        <p>
                            <asp:literal id="Status" runat="server" />
                            <asp:validationsummary id="ValidationSummary1" runat="server"></asp:validationsummary>
                    </span>
                 
                  </td>
                <td>
                </td>
            </tr>
        </tbody>
    </table>
    
</asp:content>

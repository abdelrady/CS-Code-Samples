<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<%@ import Namespace="System.Web.Mail" %>
<!--#include file="config.aspx" -->
<!--#include file="registervalidations.aspx" -->
<!--#include file="securetrans.aspx" -->
<html>
<head>
    <title>GSM Lanka-Sign up</title> <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
</style>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
<!--
.style1 {color: #FFFFFF}
.style3 {color: #CC3300}
.style4 {color: #999999}
.style6 {color: #FF9900}
.style7 {
	color: #000000;
	font-size: 12px;
}
.style8 {color: #336699}
.style9 {color: #003366#336699}
.style11 {color: #FF6600}
-->
</style>
</head>
<body>
    <form runat="server">
        <table cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td valign="top" width="112" height="38">
                        <img height="38" alt="Logo" src="imagenew/sg_logo.jpg" width="112" /></td>
                    <td width="586">
                        &nbsp;</td>
                    <td valign="bottom" width="101">
                        <span class="address"><span class="style3"><a href="index.aspx">GSM</a></span> <a href="index.aspx"><span class="style4">Lanka <span class="style6">Home</span></span></a><span class="style4"> </span></span></td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td class="address" valign="center" align="middle" width="275" height="39">
                        <span class="style8">Already a <span class="style3">GSM</span> <span class="style4">Lanka</span> member</span><span class="style9">? <a href="login.aspx">Sign
                        In</a>.</span> 
                    </td>
                    <td width="105">
                        &nbsp;</td>
                    <td valign="center" align="middle" width="390">
                        <asp:Label id="lblmessege" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
                    <td width="29">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="210" height="14">
                        <h1 class="style7"><span class="style8">Create Your</span> <span class="style3">GSM</span> <span class="style8">Lanka!
                            ID</span> 
                        </h1>
                    </td>
                    <td width="587">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="8" height="3">
                    </td>
                    <td width="781">
                    </td>
                    <td width="8">
                    </td>
                </tr>
                <tr>
                    <td height="135">
                    </td>
                    <td valign="top">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="14" height="1">
                                    </td>
                                    <td valign="center" align="right" width="165" rowspan="2">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="P" for="pw">GSM
                                        Lanka ID :</label> </span></span></td>
                                    <td width="9">
                                    </td>
                                    <td width="315">
                                    </td>
                                    <td width="62">
                                    </td>
                                    <td width="96">
                                    </td>
                                    <td width="120">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="20">
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="3" rowspan="2">
                                        <asp:TextBox id="txtUserid" runat="server" Width="150" MaxLength="20"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chuserid" runat="server" errormessege="userID cannot be blank" text="*" Font-Size="12" controltovalidate="txtUserid" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <br />
                                        <asp:RegularExpressionValidator id="nospace" runat="server" text="* user id cannot contain spaces" ErrorMessage="no spaces please" ControlToValidate="txtuserid" ValidationExpression="\S*"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="14">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="12">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="23">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="P" for="pw">Password
                                        :</label> </span></span></td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="3">
                                        <asp:TextBox id="txtPass1" runat="server" Width="150" MaxLength="20" TextMode="Password"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chpass" runat="server" errormessege="enter password" text="*" Font-Size="12" controltovalidate="txtpass1" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:Label id="lblpasserror" runat="server" forecolor="#CC0000"></asp:Label></td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="P" for="pw">Conform
                                        Password :</label> </span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtPass2" runat="server" Width="150" MaxLength="20" TextMode="Password"></asp:TextBox>
                                        <asp:comparevalidator id="passcom" runat="server" text="*" Font-Size="12" controltovalidate="txtPass1" Controltocompare="txtPass2"></asp:comparevalidator>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="34">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="P" for="pw">E-mail
                                        :</label> </span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="2">
                                        <asp:TextBox id="txtemail" runat="server" Width="200"></asp:TextBox>
                                        <asp:RequiredFieldValidator id="emailmust" runat="server" text="*" Font-Size="12" controltovalidate="txtemail" errormessage="must enter an email"></asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RegularExpressionValidator id="checkmail" runat="server" text="* invalid email address" controltovalidate="txtemail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" errormessage="not a valid mail"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="5">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="2">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_down_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="210" height="14">
                        <h1 class="style7"><span class="style8">Personal Details </span>
                        </h1>
                    </td>
                    <td width="587">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="8" height="135">
                    </td>
                    <td valign="top" width="781">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="14" height="23">
                                        &nbsp;</td>
                                    <td valign="center" align="right" width="165">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="F" for="fname">First
                                        name :</label> <label accesskey="P" for="pw"></label></span></span></td>
                                    <td width="9">
                                        &nbsp;</td>
                                    <td valign="top" colspan="6">
                                        <asp:TextBox id="txtFname" runat="server" Width="150" MaxLength="50"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chfname" runat="server" errormessege="name cannot be blank" text="*" Font-Size="12" controltovalidate="txtFname" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td width="250">
                                        &nbsp;</td>
                                    <td width="28">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td width="20">
                                    </td>
                                    <td width="12">
                                    </td>
                                    <td width="20">
                                    </td>
                                    <td width="23">
                                    </td>
                                    <td width="30">
                                    </td>
                                    <td width="210">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="F" for="fname">Last
                                        name :</label> <label accesskey="P" for="pw"></label></span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="6">
                                        <asp:TextBox id="txtLname" runat="server" Width="150" MaxLength="50"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chLname" runat="server" errormessege="Lname cannot be blank" text="*" Font-Size="12" controltovalidate="txtLname" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="12">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td class="style8" valign="top">
                                        MM</td>
                                    <td>
                                    </td>
                                    <td class="style8" valign="top" rowspan="2">
                                        DD</td>
                                    <td>
                                    </td>
                                    <td class="style8" valign="top">
                                        YYYY</td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="1">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="F" for="fname"></label><label accesskey="B" for="bday">Birthday
                                        :</label> </span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="7">
                                        <asp:TextBox id="txtDd" runat="server" Width="20" MaxLength="2" Columns="2"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chdate" runat="server" errormessege="enter data" text="*" Font-Size="12" controltovalidate="txtDD" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:TextBox id="txtMm" runat="server" Width="20" MaxLength="2" Columns="2"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chmnt" runat="server" errormessege="enter data" text="*" Font-Size="12" controltovalidate="txtMM" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:TextBox id="txtYy" runat="server" Width="50" MaxLength="4" Columns="2" AutoPostBack="false"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chyear" runat="server" errormessege="enter data" text="*" Font-Size="12" controltovalidate="txtYY" Font-Bold="true"></asp:requiredfieldvalidator>
                                        <asp:Label id="lblerrdate" runat="server" forecolor="#CC0000"></asp:Label></td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="F" for="fname"></label><label accesskey="G" for="sex">Gender
                                        :</label> </span></span></td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="6">
                                        <asp:DropDownList id="cboGen" runat="server" Width="90" value="2">
                                            <asp:ListItem value="Male">Male</asp:ListItem>
                                            <asp:ListItem value="Female">Female</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="7">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="8">
                    </td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_down_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="210" height="14">
                        <h1 class="style7"><span class="style8">Country Details </span>
                        </h1>
                    </td>
                    <td width="587">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="8" height="135">
                        &nbsp;</td>
                    <td valign="top" width="781">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="13" height="22">
                                        &nbsp;</td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="F" for="fname">Country
                                        :</label> <label accesskey="P" for="pw"></label></span></span></td>
                                    <td width="8">
                                        &nbsp;</td>
                                    <td valign="top" width="258">
                                        <asp:DropDownList id="cboCOn" runat="server">
                                            <asp:ListItem Value="AF">Afghanistan</asp:ListItem>
                                            <asp:ListItem Value="AL">Albania</asp:ListItem>
                                            <asp:ListItem Value="DZ">Algeria</asp:ListItem>
                                            <asp:ListItem Value="AS">American Samoa</asp:ListItem>
                                            <asp:ListItem Value="AD">Andorra</asp:ListItem>
                                            <asp:ListItem Value="AO">Angola</asp:ListItem>
                                            <asp:ListItem Value="AI">Anguilla</asp:ListItem>
                                            <asp:ListItem Value="AQ">Antarctica</asp:ListItem>
                                            <asp:ListItem Value="AG">Antigua And Barbuda</asp:ListItem>
                                            <asp:ListItem Value="AR">Argentina</asp:ListItem>
                                            <asp:ListItem Value="AM">Armenia</asp:ListItem>
                                            <asp:ListItem Value="AW">Aruba</asp:ListItem>
                                            <asp:ListItem Value="AU">Australia</asp:ListItem>
                                            <asp:ListItem Value="AT">Austria</asp:ListItem>
                                            <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
                                            <asp:ListItem Value="BS">Bahamas</asp:ListItem>
                                            <asp:ListItem Value="BH">Bahrain</asp:ListItem>
                                            <asp:ListItem Value="BD">Bangladesh</asp:ListItem>
                                            <asp:ListItem Value="BB">Barbados</asp:ListItem>
                                            <asp:ListItem Value="BY">Belarus</asp:ListItem>
                                            <asp:ListItem Value="BE">Belgium</asp:ListItem>
                                            <asp:ListItem Value="BZ">Belize</asp:ListItem>
                                            <asp:ListItem Value="BJ">Benin</asp:ListItem>
                                            <asp:ListItem Value="BM">Bermuda</asp:ListItem>
                                            <asp:ListItem Value="BT">Bhutan</asp:ListItem>
                                            <asp:ListItem Value="BO">Bolivia</asp:ListItem>
                                            <asp:ListItem Value="BA">Bosnia And Herzegowina</asp:ListItem>
                                            <asp:ListItem Value="BW">Botswana</asp:ListItem>
                                            <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>
                                            <asp:ListItem Value="BR">Brazil</asp:ListItem>
                                            <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
                                            <asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>
                                            <asp:ListItem Value="BG">Bulgaria</asp:ListItem>
                                            <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
                                            <asp:ListItem Value="BI">Burundi</asp:ListItem>
                                            <asp:ListItem Value="KH">Cambodia</asp:ListItem>
                                            <asp:ListItem Value="CM">Cameroon</asp:ListItem>
                                            <asp:ListItem Value="CA">Canada</asp:ListItem>
                                            <asp:ListItem Value="CV">Cape Verde</asp:ListItem>
                                            <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
                                            <asp:ListItem Value="CF">Central African Republic</asp:ListItem>
                                            <asp:ListItem Value="TD">Chad</asp:ListItem>
                                            <asp:ListItem Value="CL">Chile</asp:ListItem>
                                            <asp:ListItem Value="CN">China</asp:ListItem>
                                            <asp:ListItem Value="CX">Christmas Island</asp:ListItem>
                                            <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
                                            <asp:ListItem Value="CO">Colombia</asp:ListItem>
                                            <asp:ListItem Value="KM">Comoros</asp:ListItem>
                                            <asp:ListItem Value="CG">Congo</asp:ListItem>
                                            <asp:ListItem Value="CK">Cook Islands</asp:ListItem>
                                            <asp:ListItem Value="CR">Costa Rica</asp:ListItem>
                                            <asp:ListItem Value="CI">Cote D'Ivoire</asp:ListItem>
                                            <asp:ListItem Value="HR">Croatia (Local Name: Hrvatska)</asp:ListItem>
                                            <asp:ListItem Value="CU">Cuba</asp:ListItem>
                                            <asp:ListItem Value="CY">Cyprus</asp:ListItem>
                                            <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
                                            <asp:ListItem Value="DK">Denmark</asp:ListItem>
                                            <asp:ListItem Value="DJ">Djibouti</asp:ListItem>
                                            <asp:ListItem Value="DM">Dominica</asp:ListItem>
                                            <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
                                            <asp:ListItem Value="TP">East Timor</asp:ListItem>
                                            <asp:ListItem Value="EC">Ecuador</asp:ListItem>
                                            <asp:ListItem Value="EG">Egypt</asp:ListItem>
                                            <asp:ListItem Value="SV">El Salvador</asp:ListItem>
                                            <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
                                            <asp:ListItem Value="ER">Eritrea</asp:ListItem>
                                            <asp:ListItem Value="EE">Estonia</asp:ListItem>
                                            <asp:ListItem Value="ET">Ethiopia</asp:ListItem>
                                            <asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>
                                            <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
                                            <asp:ListItem Value="FJ">Fiji</asp:ListItem>
                                            <asp:ListItem Value="FI">Finland</asp:ListItem>
                                            <asp:ListItem Value="FR">France</asp:ListItem>
                                            <asp:ListItem Value="GF">French Guiana</asp:ListItem>
                                            <asp:ListItem Value="PF">French Polynesia</asp:ListItem>
                                            <asp:ListItem Value="TF">French Southern Territories</asp:ListItem>
                                            <asp:ListItem Value="GA">Gabon</asp:ListItem>
                                            <asp:ListItem Value="GM">Gambia</asp:ListItem>
                                            <asp:ListItem Value="GE">Georgia</asp:ListItem>
                                            <asp:ListItem Value="DE">Germany</asp:ListItem>
                                            <asp:ListItem Value="GH">Ghana</asp:ListItem>
                                            <asp:ListItem Value="GI">Gibraltar</asp:ListItem>
                                            <asp:ListItem Value="GR">Greece</asp:ListItem>
                                            <asp:ListItem Value="GL">Greenland</asp:ListItem>
                                            <asp:ListItem Value="GD">Grenada</asp:ListItem>
                                            <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
                                            <asp:ListItem Value="GU">Guam</asp:ListItem>
                                            <asp:ListItem Value="GT">Guatemala</asp:ListItem>
                                            <asp:ListItem Value="GN">Guinea</asp:ListItem>
                                            <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
                                            <asp:ListItem Value="GY">Guyana</asp:ListItem>
                                            <asp:ListItem Value="HT">Haiti</asp:ListItem>
                                            <asp:ListItem Value="HM">Heard And Mc Donald Islands</asp:ListItem>
                                            <asp:ListItem Value="VA">Holy See (Vatican City State)</asp:ListItem>
                                            <asp:ListItem Value="HN">Honduras</asp:ListItem>
                                            <asp:ListItem Value="HK">Hong Kong</asp:ListItem>
                                            <asp:ListItem Value="HU">Hungary</asp:ListItem>
                                            <asp:ListItem Value="IS">Icel And</asp:ListItem>
                                            <asp:ListItem Value="IN">India</asp:ListItem>
                                            <asp:ListItem Value="ID">Indonesia</asp:ListItem>
                                            <asp:ListItem Value="IR">Iran (Islamic Republic Of)</asp:ListItem>
                                            <asp:ListItem Value="IQ">Iraq</asp:ListItem>
                                            <asp:ListItem Value="IE">Ireland</asp:ListItem>
                                            <asp:ListItem Value="IL">Israel</asp:ListItem>
                                            <asp:ListItem Value="IT">Italy</asp:ListItem>
                                            <asp:ListItem Value="JM">Jamaica</asp:ListItem>
                                            <asp:ListItem Value="JP">Japan</asp:ListItem>
                                            <asp:ListItem Value="JO">Jordan</asp:ListItem>
                                            <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
                                            <asp:ListItem Value="KE">Kenya</asp:ListItem>
                                            <asp:ListItem Value="KI">Kiribati</asp:ListItem>
                                            <asp:ListItem Value="KP">Korea, Dem People'S Republic</asp:ListItem>
                                            <asp:ListItem Value="KR">Korea, Republic Of</asp:ListItem>
                                            <asp:ListItem Value="KW">Kuwait</asp:ListItem>
                                            <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
                                            <asp:ListItem Value="LA">Lao People'S Dem Republic</asp:ListItem>
                                            <asp:ListItem Value="LV">Latvia</asp:ListItem>
                                            <asp:ListItem Value="LB">Lebanon</asp:ListItem>
                                            <asp:ListItem Value="LS">Lesotho</asp:ListItem>
                                            <asp:ListItem Value="LR">Liberia</asp:ListItem>
                                            <asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>
                                            <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
                                            <asp:ListItem Value="LT">Lithuania</asp:ListItem>
                                            <asp:ListItem Value="LU">Luxembourg</asp:ListItem>
                                            <asp:ListItem Value="MO">Macau</asp:ListItem>
                                            <asp:ListItem Value="MK">Macedonia</asp:ListItem>
                                            <asp:ListItem Value="MG">Madagascar</asp:ListItem>
                                            <asp:ListItem Value="MW">Malawi</asp:ListItem>
                                            <asp:ListItem Value="MY">Malaysia</asp:ListItem>
                                            <asp:ListItem Value="MV">Maldives</asp:ListItem>
                                            <asp:ListItem Value="ML">Mali</asp:ListItem>
                                            <asp:ListItem Value="MT">Malta</asp:ListItem>
                                            <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
                                            <asp:ListItem Value="MQ">Martinique</asp:ListItem>
                                            <asp:ListItem Value="MR">Mauritania</asp:ListItem>
                                            <asp:ListItem Value="MU">Mauritius</asp:ListItem>
                                            <asp:ListItem Value="YT">Mayotte</asp:ListItem>
                                            <asp:ListItem Value="MX">Mexico</asp:ListItem>
                                            <asp:ListItem Value="FM">Micronesia, Federated States</asp:ListItem>
                                            <asp:ListItem Value="MD">Moldova, Republic Of</asp:ListItem>
                                            <asp:ListItem Value="MC">Monaco</asp:ListItem>
                                            <asp:ListItem Value="MN">Mongolia</asp:ListItem>
                                            <asp:ListItem Value="MS">Montserrat</asp:ListItem>
                                            <asp:ListItem Value="MA">Morocco</asp:ListItem>
                                            <asp:ListItem Value="MZ">Mozambique</asp:ListItem>
                                            <asp:ListItem Value="MM">Myanmar</asp:ListItem>
                                            <asp:ListItem Value="NA">Namibia</asp:ListItem>
                                            <asp:ListItem Value="NR">Nauru</asp:ListItem>
                                            <asp:ListItem Value="NP">Nepal</asp:ListItem>
                                            <asp:ListItem Value="NL">Netherlands</asp:ListItem>
                                            <asp:ListItem Value="AN">Netherlands Ant Illes</asp:ListItem>
                                            <asp:ListItem Value="NC">New Caledonia</asp:ListItem>
                                            <asp:ListItem Value="NZ">New Zealand</asp:ListItem>
                                            <asp:ListItem Value="NI">Nicaragua</asp:ListItem>
                                            <asp:ListItem Value="NE">Niger</asp:ListItem>
                                            <asp:ListItem Value="NG">Nigeria</asp:ListItem>
                                            <asp:ListItem Value="NU">Niue</asp:ListItem>
                                            <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
                                            <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
                                            <asp:ListItem Value="NO">Norway</asp:ListItem>
                                            <asp:ListItem Value="OM">Oman</asp:ListItem>
                                            <asp:ListItem Value="PK">Pakistan</asp:ListItem>
                                            <asp:ListItem Value="PW">Palau</asp:ListItem>
                                            <asp:ListItem Value="PA">Panama</asp:ListItem>
                                            <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
                                            <asp:ListItem Value="PY">Paraguay</asp:ListItem>
                                            <asp:ListItem Value="PE">Peru</asp:ListItem>
                                            <asp:ListItem Value="PH">Philippines</asp:ListItem>
                                            <asp:ListItem Value="PN">Pitcairn</asp:ListItem>
                                            <asp:ListItem Value="PL">Poland</asp:ListItem>
                                            <asp:ListItem Value="PT">Portugal</asp:ListItem>
                                            <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
                                            <asp:ListItem Value="QA">Qatar</asp:ListItem>
                                            <asp:ListItem Value="RE">Reunion</asp:ListItem>
                                            <asp:ListItem Value="RO">Romania</asp:ListItem>
                                            <asp:ListItem Value="RU">Russian Federation</asp:ListItem>
                                            <asp:ListItem Value="RW">Rwanda</asp:ListItem>
                                            <asp:ListItem Value="KN">Saint K Itts And Nevis</asp:ListItem>
                                            <asp:ListItem Value="LC">Saint Lucia</asp:ListItem>
                                            <asp:ListItem Value="VC">Saint Vincent, The Grenadines</asp:ListItem>
                                            <asp:ListItem Value="WS">Samoa</asp:ListItem>
                                            <asp:ListItem Value="SM">San Marino</asp:ListItem>
                                            <asp:ListItem Value="ST">Sao Tome And Principe</asp:ListItem>
                                            <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
                                            <asp:ListItem Value="SN">Senegal</asp:ListItem>
                                            <asp:ListItem Value="SC">Seychelles</asp:ListItem>
                                            <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
                                            <asp:ListItem Value="SG">Singapore</asp:ListItem>
                                            <asp:ListItem Value="SK">Slovakia (Slovak Republic)</asp:ListItem>
                                            <asp:ListItem Value="SI">Slovenia</asp:ListItem>
                                            <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
                                            <asp:ListItem Value="SO">Somalia</asp:ListItem>
                                            <asp:ListItem Value="ZA">South Africa</asp:ListItem>
                                            <asp:ListItem Value="GS">South Georgia , S Sandwich Is.</asp:ListItem>
                                            <asp:ListItem Value="ES">Spain</asp:ListItem>
                                            <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
                                            <asp:ListItem Value="SH">St. Helena</asp:ListItem>
                                            <asp:ListItem Value="PM">St. Pierre And Miquelon</asp:ListItem>
                                            <asp:ListItem Value="SD">Sudan</asp:ListItem>
                                            <asp:ListItem Value="SR">Suriname</asp:ListItem>
                                            <asp:ListItem Value="SJ">Svalbard, Jan Mayen Islands</asp:ListItem>
                                            <asp:ListItem Value="SZ">Sw Aziland</asp:ListItem>
                                            <asp:ListItem Value="SE">Sweden</asp:ListItem>
                                            <asp:ListItem Value="CH">Switzerland</asp:ListItem>
                                            <asp:ListItem Value="SY">Syrian Arab Republic</asp:ListItem>
                                            <asp:ListItem Value="TW">Taiwan</asp:ListItem>
                                            <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
                                            <asp:ListItem Value="TZ">Tanzania, United Republic Of</asp:ListItem>
                                            <asp:ListItem Value="TH">Thailand</asp:ListItem>
                                            <asp:ListItem Value="TG">Togo</asp:ListItem>
                                            <asp:ListItem Value="TK">Tokelau</asp:ListItem>
                                            <asp:ListItem Value="TO">Tonga</asp:ListItem>
                                            <asp:ListItem Value="TT">Trinidad And Tobago</asp:ListItem>
                                            <asp:ListItem Value="TN">Tunisia</asp:ListItem>
                                            <asp:ListItem Value="TR">Turkey</asp:ListItem>
                                            <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
                                            <asp:ListItem Value="TC">Turks And Caicos Islands</asp:ListItem>
                                            <asp:ListItem Value="TV">Tuvalu</asp:ListItem>
                                            <asp:ListItem Value="UG">Uganda</asp:ListItem>
                                            <asp:ListItem Value="UA">Ukraine</asp:ListItem>
                                            <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
                                            <asp:ListItem Value="GB">United Kingdom</asp:ListItem>
                                            <asp:ListItem Value="US">United States</asp:ListItem>
                                            <asp:ListItem Value="UM">United States Minor Is.</asp:ListItem>
                                            <asp:ListItem Value="UY">Uruguay</asp:ListItem>
                                            <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
                                            <asp:ListItem Value="VU">Vanuatu</asp:ListItem>
                                            <asp:ListItem Value="VE">Venezuela</asp:ListItem>
                                            <asp:ListItem Value="VN">Viet Nam</asp:ListItem>
                                            <asp:ListItem Value="VG">Virgin Islands (British)</asp:ListItem>
                                            <asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>
                                            <asp:ListItem Value="WF">Wallis And Futuna Islands</asp:ListItem>
                                            <asp:ListItem Value="EH">Western Sahara</asp:ListItem>
                                            <asp:ListItem Value="YE">Yemen</asp:ListItem>
                                            <asp:ListItem Value="YU">Yugoslavia</asp:ListItem>
                                            <asp:ListItem Value="ZR">Zaire</asp:ListItem>
                                            <asp:ListItem Value="ZM">Zambia</asp:ListItem>
                                            <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td width="338">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td width="164">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="leftlink1"><label accesskey="Z" for="zip">ZIP/Postal
                                        code :</label> <label accesskey="F" for="fname"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtZip" runat="server" Width="45" MaxLength="10"></asp:TextBox>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="leftlink1"><label accesskey="Z" for="zip">Address
                                        :</label> <label accesskey="F" for="fname"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtAddr" runat="server" Width="210" MaxLength="500" TextMode="MultiLine" rows="3"></asp:TextBox>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                    </td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="leftlink1">Phone <label accesskey="Z" for="zip">:</label> <label accesskey="F" for="fname"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox id="txtPhone" runat="server"></asp:TextBox>
                                        <asp:RegularExpressionValidator id="chphn" runat="server" ErrorMessage="digits only" ControlToValidate="txtphone" ValidationExpression="\d*" Text="* Digits only"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="8">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <td width="8">
            &nbsp;</td>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_down_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td valign="top" width="511" height="14">
                        <h1 class="style7"><span class="style8">If You Forget Your Password... </span>
                        </h1>
                    </td>
                    <td width="286">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="8" height="68">
                        &nbsp;</td>
                    <td valign="top" width="781">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="13" height="22">
                                        &nbsp;</td>
                                    <td valign="center" align="right" width="164">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="Q" for="pwq">Security
                                        question :</label> <label accesskey="F" for="fname"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td width="9">
                                        &nbsp;</td>
                                    <td valign="top" width="415">
                                        <asp:TextBox id="txtSec" runat="server" Width="210"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chques" runat="server" errormessege="enter data" text="*" Font-Size="12" controltovalidate="txtSec" Font-Bold="true"></asp:requiredfieldvalidator>
                                    </td>
                                    <td width="180">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="13">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="22">
                                        &nbsp;</td>
                                    <td valign="center" align="right">
                                        <span class="leftlink2"><span class="style3">*</span><span class="leftlink1"> <label accesskey="A" for="pwa">Your
                                        answer :</label> <label accesskey="Q" for="pwq"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top">
                                        <asp:TextBox id="txtAnswer" runat="server" Width="210"></asp:TextBox>
                                        <asp:requiredfieldvalidator id="chans" runat="server" errormessege="enter data" text="*" Font-Size="12" Font-Bold="true" ControlToValidate="txtAnswer"></asp:requiredfieldvalidator>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="11">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="8">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_down_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sml_already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/sn_bk.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="8" height="22">
                        &nbsp;</td>
                    <td valign="top" width="781">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="13" height="22">
                                        &nbsp;</td>
                                    <td valign="center" align="right" width="164">
                                        <span class="leftlink2"><span class="leftlink1">Avater URL <label accesskey="Q" for="pwq">:</label> <label accesskey="F" for="fname"></label><label accesskey="P" for="pw"></label></span></span></td>
                                    <td width="9">
                                        &nbsp;</td>
                                    <td valign="top" width="304">
                                        <asp:TextBox id="txtavatar" runat="server" Width="220"></asp:TextBox>
                                        <asp:RegularExpressionValidator id="churl" runat="server" text="invalid URL" controltovalidate="txtavatar" ValidationExpression="http://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" errormessage="not valid url"></asp:RegularExpressionValidator>
                                    </td>
                                    <td valign="top" width="122">
                                        <asp:Button id="cmdsubmit" onclick="register" runat="server" Text="Register"></asp:Button>
                                    </td>
                                    <td width="169">
                                        &nbsp;</td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="9">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/dlink_ban-new-copy.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="192" height="28">
                        &nbsp;</td>
                    <td valign="center" align="middle" width="394">
                        <span class="style1">Copyright © GSM Lanka (Pvt) Ltd, </span></td>
                    <td width="213">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
    </form>
</body>
</html>

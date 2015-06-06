<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    lblmessege.text=""
    
    
    If Not isPostBack Then
    if session("adminlog")=true then
    lblerror.text="You are not authorized in to access the feature you requested"
    lblerror.visible="true"
    else
    lblerror.visible="false"
    end if
    lblmessege.text=""
    end if
    End Sub

</script>
<!--#include file="config.aspx" -->
<!--#include file="securetrans.aspx" -->
<!--#include file="adminverify.aspx" -->
<html>
<head>
    <title>.::Welcome to GSMLanka::.</title>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet1" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
.borderTable {
	BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; BORDER-LEFT: #cccccc 1px solid; PADDING-TOP: 0px; BORDER-BOTTOM: #cccccc 1px solid
}
</style>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet1" />
    <style type="text/css">.style1 {
	COLOR: #ffffff
}
.style3 {
	FONT-WEIGHT: bold
}
</style>
    <link href="stylesheet1.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <table cellspacing="0" cellpadding="0" width="734" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="734" height="365">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="6" height="62">
                                    </td>
                                    <td width="197">
                                        &nbsp;</td>
                                    <td width="155">
                                        &nbsp;</td>
                                    <td width="14">
                                    </td>
                                    <td width="31">
                                    </td>
                                    <td width="67">
                                    </td>
                                    <td width="10">
                                    </td>
                                    <td width="81">
                                    </td>
                                    <td width="106">
                                    </td>
                                    <td width="47">
                                    </td>
                                    <td width="20">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="15">
                                    </td>
                                    <td valign="top" colspan="2" rowspan="9">
                                        <table class="border5" cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td height="14">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <!--DWLayoutTable-->
                                                <tr>
                                                    <td width="19" height="48">
                                                        &nbsp;</td>
                                                    <td valign="top" width="318">
                                                        <div align="right"><img height="40" alt="Sign in Logo" src="buttons/sign_in_logo.jpg" width="250" /> 
                                                        </div>
                                                    </td>
                                                    <td width="14">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="134">
                                                        &nbsp;</td>
                                                    <td valign="top" align="right">
                                                        <p class="leftlink2">
                                                            GSMLanka Admin! 
                                                            <br />
                                                            Welcome again to the site!<br />
                                                            <br />
                                                            GSMLanka ID 
                                                        </p>
                                                        <p>
                                                            <span class="leftlink2">Highly secured zone.ip address tracked for<br />
                                                            security reasons</span> 
                                                            <br />
                                                        </p>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
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
                                    <td height="41">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="6">
                                        <table id="iNUCont" cellspacing="0" cellpadding="0" width="100%">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="339" height="24">
                                                        <p class="leftlink2">
                                                            Are you an admin? This page is not for regular members.Login with GSMLANKA ID which
                                                            has Administrator Priviladge <strong></strong>. 
                                                        </p>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="3">
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="18">
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="3">
                                        <span class="redfont">Sign in </span></td>
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
                                    <td height="24">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td class="leftlink2" valign="center" align="right" colspan="2">
                                        Admin ID:</td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="2" rowspan="2">
                                        <asp:TextBox id="txtGsmadmin" runat="server" Height="20" Width="150"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="admincheck" runat="server" ControlToValidate="txtgsmadmin" errormessage="enter Admins ID" text="* Enter Admin ID"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="25">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="20">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="center" align="right" colspan="2">
                                        <label class="leftlink2" for="i0118">Password:</label></td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="2" rowspan="2">
                                        <asp:TextBox id="txtadminlogPas" runat="server" Height="20" Width="150" TextMode="Password"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="txtpasscheck" runat="server" ControlToValidate="txtadminlogpas" errormessage="enter password" text="* Enter a password"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="25">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="23">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="2">
                                        <asp:ImageButton id="signIn" onclick="loginAdmin" runat="server" ImageUrl="buttons/sign_in.jpg"></asp:ImageButton>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="18">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td valign="top" colspan="5">
                                        <asp:Label id="lblmessege" runat="server" forecolor="#CC0000"></asp:Label></td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="24">
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
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
                                    <td height="20">
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td valign="top" colspan="6">
                                        <asp:Label id="lblError" runat="server" forecolor="#CC0000" font-bold="true"></asp:Label></td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="42">
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
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
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>

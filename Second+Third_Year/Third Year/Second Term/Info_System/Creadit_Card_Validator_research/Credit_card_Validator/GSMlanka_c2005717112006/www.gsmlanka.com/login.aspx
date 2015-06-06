<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    lblmessege.text=""
    
    
    If Not isPostBack Then
    if session("checklog")=true then
    lblerror.text="You are not logged in to access the feature you requested"
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
<!--#include file="verify.aspx" -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>GSMLanka Sign in</title>
    <link href="favicon.ico" type="image/ico" rel="icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <script language="JavaScript" src="javascript.js"></script>
    <style type="text/css">
<!--
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #cccccc;
}
.borderTable {padding: 0px 0px 0px 0px;
border: 1px solid #CCCCCC;
}
-->
</style>
    <link href="stylesheet.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
<!--
.style2 {color: #336699}
-->
</style>
</head>
<body>
    <form runat="server">
        <p>
        </p>
        <table cellspacing="0" cellpadding="0" width="798" align="center" background="imagenew/full_up_line.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="798" height="45">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="798" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="9" height="332">
                        &nbsp;</td>
                    <td valign="top" width="771">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="96" height="24">
                                        &nbsp;</td>
                                    <td valign="top" width="379">
                                        <asp:Label id="lblerror" runat="server"></asp:Label></td>
                                    <td width="12">
                                        &nbsp;</td>
                                    <td width="284">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" colspan="2" rowspan="2">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td valign="top" width="233" rowspan="3">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td valign="center" align="middle" width="233" height="277">
                                                                        <img height="277" alt="Mob Login" src="imagenew/log_in_image.gif" width="138" /></td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="31">
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                    <td width="242" height="61">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" height="167">
                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td class="leftlink" valign="top" width="242" height="167">
                                                                        <p class="redfont">
                                                                            <strong>your are 1 step away to enter the mobile world of GSMLANKA<sup>©</sup>. </strong>
                                                                        </p>
                                                                        <ul>
                                                                            <li>
                                                                                Find Details abour your favourite phone 
                                                                            </li>
                                                                            <li>
                                                                                Purchase online, &amp; get it deleverd to ur door. 
                                                                            </li>
                                                                            <li>
                                                                                Discuss with mobile experts. 
                                                                            </li>
                                                                        </ul>
                                                                        <p>
                                                                            dont have an ID yet? <a href="signup.aspx">SIGN UP</a> now 
                                                                        </p>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="80">
                                                        &nbsp;</td>
                                                </tr>
                                                <!--DWLayoutTable-->
                                            </tbody>
                                        </table>
                                    </td>
                                    <td height="20">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td height="288">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="14" height="20">
                                                    </td>
                                                    <td width="260">
                                                        &nbsp;</td>
                                                    <td width="10">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="29">
                                                    </td>
                                                    <td valign="top" colspan="2">
                                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/up_line.jpg" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="270" height="29">
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="160">
                                                    </td>
                                                    <td valign="top" colspan="2">
                                                        <table class="border4" cellspacing="0" cellpadding="0" width="100%" background="imagenew/b_images.jpg" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="6" height="13">
                                                                    </td>
                                                                    <td width="53">
                                                                    </td>
                                                                    <td width="129">
                                                                    </td>
                                                                    <td width="56">
                                                                    </td>
                                                                    <td width="6">
                                                                    </td>
                                                                    <td width="18">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="86">
                                                                    </td>
                                                                    <td valign="top" colspan="4">
                                                                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                                            <!--DWLayoutTable-->
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td valign="center" align="right" width="79" height="22">
                                                                                        <span class="th style2">User ID: </span></td>
                                                                                    <td width="6">
                                                                                        &nbsp;</td>
                                                                                    <td valign="top" width="159">
                                                                                        <asp:TextBox id="txtuser" runat="server" Width="150"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="20">
                                                                                        &nbsp;</td>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                    <td valign="top">
                                                                                        <asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" controltovalidate="txtuser" text="Please enter username" errormessege="Please enter username"></asp:requiredfieldvalidator>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td valign="center" align="right" height="22">
                                                                                        <label class="leftlink style2" for="passwd"><span class="th style2">Password:</span></label></td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <label for="passwd"></label>
                                                                                        <asp:TextBox id="txtpass" runat="server" Width="150" MaxLength="15" TextMode="Password"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td height="22">
                                                                                        &nbsp;</td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td valign="top">
                                                                                        <asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" controltovalidate="txtpass" text="Password cannot be blank" errormessege="Please enter password"></asp:requiredfieldvalidator>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="24">
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Button id="Button1" onclick="loginuser" runat="server" Text="Submit"></asp:Button>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td height="26">
                                                                    </td>
                                                                    <td>
                                                                    </td>
                                                                    <td class="leftlink" valign="center" align="right" colspan="3">
                                                                        Forget your ID or password?<br />
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
                                                                    <td>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="12">
                                                    </td>
                                                    <td valign="top" colspan="2">
                                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/dwn_line.jpg" border="0">
                                                            <!--DWLayoutTable-->
                                                            <tbody>
                                                                <tr>
                                                                    <td width="270" height="12">
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="14">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="29">
                                                    </td>
                                                    <td valign="top">
                                                        <asp:Label id="lblmessege" runat="server" text="" backcolor="#00FF00" forecolor="#000000" width="50"></asp:Label></td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="24">
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td width="16">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <table cellspacing="0" cellpadding="0" width="798" align="center" background="imagenew/full_dwn_line.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="222" height="45">
                        &nbsp;</td>
                    <td valign="center" align="middle" width="358">
                        <span class="leftlink">Copyright © GSM Lanka (Pvt) Ltd, </span></td>
                    <td width="218">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>

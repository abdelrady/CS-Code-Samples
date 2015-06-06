<%@ Page Explicit="True" Language="VB" Debug="True" validaterequest="False" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    Sub Page_Load( s As Object, e As EventArgs )
    
    if session("AdminID")="" then
    session("adminlog")=true
    response.Redirect("adminlogin.aspx")
    
    else
    lbladmin.text=session("adminID")
    
    end if
    End Sub
    
    
    
    
    sub sendmail( s As Object, e As EventArgs )
    
      Dim EmailMessage As New System.Web.Mail.MailMessage
    
                  call dbcon
                  mcmd=new sqlcommand("select email from users",bcon)
                  bcon.open
                  tempdr=mcmd.executereader
                  while tempdr.read
                    'Smtp object to send the message
                 Dim emailSMTP As System.Web.Mail.SmtpMail
    
                 'build the mailMessage
                 EmailMessage.From = "noreply@azmil.com"
                 EmailMessage.To = tempdr("email")
                EmailMessage.BodyFormat = Mail.MailFormat.Html
                 EmailMessage.Subject = txtsubject.text
    
                 EmailMessage.Body = replace(txtmsg.text,chr(13),"<BR>")
    
    
    
                 emailSMTP.SmtpServer = "localhost"
    
                      emailSMTP.Send(EmailMessage)
        end while
        response.Redirect("dbsuccess.aspx")
    end sub

</script>
<!--#include file="config.aspx" -->
<html>
<head>
    <title>GSMLanka -Control panel</title>
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
    <style type="text/css">
<!--
.style1 {color: #FFFFFF}
.style3 {color: #CC3300}
.style4 {color: #999999}
.style6 {color: #FF9900}
.style15 {color: #D93F3F}
-->
</style>
    <script type="text/JavaScript">
<!--
function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
//-->
</script>
</head>
<body onload="MM_preloadImages('buttons/addnewphn2.gif','buttons/ModiyPhone2.gif','buttons/User-Management2.gif','buttons/Orders2.gif','buttons/sign_out1.gif')">
    <form runat="server">
        <table cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td valign="top" width="112" rowspan="2">
                        <img height="38" alt="Logo" src="imagenew/sg_logo.jpg" width="112" /></td>
                    <td width="155" height="16">
                    </td>
                    <td width="197">
                    </td>
                    <td width="234">
                    </td>
                    <td valign="bottom" width="101" rowspan="2">
                        <span class="address"><span class="style3">GSM</span> <span class="style4">Lanka <span class="style6">Home</span> </span></span></td>
                </tr>
                <tr>
                    <td class="redfont" valign="center" height="25">
                        Welcome Administrator:</td>
                    <td class="redfont" valign="center">
                        <asp:Label id="lblAdmin" runat="server" cssclass="redfont" font-bold="true"></asp:Label>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="buttons/Admin_bblank.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="4" height="39">
                        &nbsp;</td>
                    <td valign="top" width="125">
                        <a onmouseover="MM_swapImage('Add New Phone','','buttons/addnewphn2.gif',1)" onmouseout="MM_swapImgRestore()" href="phonemanager.aspx"><img height="39" alt="Add New Phone" src="buttons/addnewphn1.gif" width="125" border="0" name="Add New Phone" /></a></td>
                    <td valign="top" width="123">
                        <a onmouseover="MM_swapImage('Modiy Phone','','buttons/ModiyPhone2.gif',1)" onmouseout="MM_swapImgRestore()" href="selectphone.aspx"><img height="39" alt="Modiy Phone" src="buttons/ModiyPhone1.gif" width="127" border="0" name="Modiy Phone" /></a></td>
                    <td valign="top" width="148">
                        <a onmouseover="MM_swapImage('User Managemen','','buttons/User-Management2.gif',1)" onmouseout="MM_swapImgRestore()" href="usermanager.aspx"><img height="39" alt="User Managemen" src="buttons/User-Management1.gif" width="148" border="0" name="User Managemen" /></a></td>
                    <td valign="top" width="97">
                        <a onmouseover="MM_swapImage('Orders','','buttons/Orders2.gif',1)" onmouseout="MM_swapImgRestore()" href="orderManagement.aspx"><img height="39" alt="Orders" src="buttons/Orders1.gif" width="97" border="0" name="Orders" /></a></td>
                    <td valign="top" width="100">
                        <a onmouseover="MM_swapImage('E-letter','','buttons/eletter2.gif',0)" onmouseout="MM_swapImgRestore()" href="eletter.aspx"><img height="39" alt="E-letter" src="buttons/eletter1.gif" width="100" border="0" name="E-letter" /></a></td>
                    <td width="89">
                        &nbsp;</td>
                    <td valign="top" width="83">
                        <a onmouseover="MM_swapImage('Sign out','','buttons/sign_out1.gif',1)" onmouseout="MM_swapImgRestore()" href="signout.aspx"><img height="39" alt="Sign out" src="buttons/sign_out.gif" width="91" border="0" name="Sign out" /></a></td>
                    <td width="18">
                        &nbsp;</td>
                </tr>
            </tbody>
        </table>
        <br />
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/phoneman_up.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="799" height="11">
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="border4" cellspacing="0" cellpadding="0" width="799" align="center" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="24" height="9">
                    </td>
                    <td width="477">
                    </td>
                    <td width="103">
                    </td>
                    <td width="162">
                    </td>
                    <td width="31">
                    </td>
                </tr>
                <tr>
                    <td height="28">
                    </td>
                    <td valign="top" colspan="3">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="center" align="middle" width="742" height="28">
                                        <p class="redfont">
                                            Please enter the subject and the HTML/text message in the body and click send 
                                        </p>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="6">
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
                    <td height="30">
                    </td>
                    <td valign="top" colspan="3">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td class="leftlink1" valign="top" align="right" width="172" height="30">
                                        Subject : 
                                    </td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td valign="top" width="560">
                                        <asp:TextBox id="txtsubject" runat="server" Width="300" Columns="40"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="subcheck" runat="server" ControlToValidate="txtsubject" ErrorMessage="Subject cannot be blank" Text="Please fill the subject field" ForeColor="#CC0000" Font-Bold="true"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
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
                    <td height="35">
                    </td>
                    <td valign="top" colspan="3">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td class="leftlink1" valign="top" align="right" width="172" height="30">
                                        Message : 
                                    </td>
                                    <td width="11">
                                        &nbsp;</td>
                                    <td valign="top" width="559">
                                        <asp:TextBox id="txtmsg" runat="server" Width="400" Columns="50" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator id="msgcheck" runat="server" ControlToValidate="txtmsg" ErrorMessage="cannot be blank" Text="Mail body cannot be empty!" ForeColor="#CC0000" Font-Bold="true"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
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
                </tr>
                <tr>
                    <td height="29">
                    </td>
                    <td>
                    </td>
                    <td valign="top">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="top" width="103" height="29">
                                        <asp:Button id="btnsend" onclick="sendmail" runat="server" Text="Send Letters" Height="20"></asp:Button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
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

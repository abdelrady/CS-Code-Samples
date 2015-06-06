<%@ Page Explicit="True" Language="VB" Debug="True" %>
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

</script>
<html>
<head>
    <title>GSMLanka - Control Panel-Success Database Modification</title>
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
.style13 {color: #D63C3C}
.style14 {color: #63C03C}
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
                    <td width="158" height="16">
                    </td>
                    <td width="124">
                    </td>
                    <td width="304">
                    </td>
                    <td valign="bottom" width="101" rowspan="2">
                        <span class="address"><span class="style3">GSM</span> <span class="style4">Lanka <span class="style6">Home</span> </span></span></td>
                </tr>
                <tr>
                    <td class="redfont" valign="center" align="left" height="25">
                        Welcome Administrator:</td>
                    <td valign="center">
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
                    <td width="270" height="29">
                        &nbsp;</td>
                    <td width="271">
                        &nbsp;</td>
                    <td width="246">
                        &nbsp;</td>
                    <td width="10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="42">
                        &nbsp;</td>
                    <td valign="top">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td valign="center" align="middle" width="224" height="42">
                                        <p class="redfont style13">
                                            Database modified successfully 
                                        </p>
                                    </td>
                                    <td valign="top" width="47">
                                        <img height="42" alt="Success" src="imagenew/right.jpg" width="47" /></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
                </tr>
                <tr>
                    <td height="13">
                    </td>
                    <td>
                    </td>
                    <td class="leftlink" valign="center" align="right">
                        To Add a Newphone <a href="phonemanager.aspx">Click Here</a> 
                    </td>
                    <td>
                    </td>
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
                </tr>
                <tr>
                    <td height="13">
                    </td>
                    <td>
                    </td>
                    <td class="leftlink" valign="center" align="right">
                        To modify phone <a href="selectphone.aspx">click here </a></td>
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

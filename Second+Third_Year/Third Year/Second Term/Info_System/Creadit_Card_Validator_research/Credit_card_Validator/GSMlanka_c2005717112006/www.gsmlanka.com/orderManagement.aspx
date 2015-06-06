<%@ Page Explicit="True" Language="VB" Debug="True" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.sqlclient" %>
<script runat="server">

    public manIDpass as integer
    
    Sub Page_Load( s As Object, e As EventArgs )
    
    if session("AdminID")="" then
    session("adminlog")=true
    response.Redirect("adminlogin.aspx")
    
    else
    lbladmin.text=session("adminID")
    call filldata1
    call fillstat
    end if
    End Sub
    
    
    sub filldata1
    dim statSQL as string
    call dbcon
    if  cboORd.items.count=0 then
    statSQL= "select orderID from payments where status='no' order by orderID"
    bcon.open
    bcmd = New SqlCommand(statSQL, Bcon)
    objreader = bcmd.ExecuteReader
    cboOrd.items.add("select an Order")
    while objreader.read
    cboORD.items.add(objreader("OrderID"))
    end while
    bcon.close
    end if
    end sub
    
    sub fillstat
    if  cbostat.items.count=0 then
    cbostat.items.add("select status")
    cbostat.items.add("yes")
    cbostat.items.add("no")
    cbostat.items.add("rejected")
    
    end if
    end sub
    
    
    
    
    
    sub selOrder(sender As Object, e As EventArgs)
    
    dim privSql as string
    call dbcon
    if cboORD.selecteditem.text<>"select a user" then
    privSql="select status from payments where status<>'yes' and orderID='" & cboORD.selecteditem.text & " ' "
    TCMD=NEW SQLCOMMAND(privSql,bcon)
    bcon.open
    dr=tcmd.executereader
    dr.read
    cbostat.selecteditem.text=dr("status")
    bcon.close
    end if
    
    
    end sub
    
    
    
    
    sub updateORD( sender As Object, e As System.Web.UI.ImageClickEventArgs)
    
    mcmd= new sqlcommand("update payments set status='" & cbostat.selecteditem.text & "' where orderID='"& cboOrd.selecteditem.text &"'",bcon)
    bcon.open
    mcmd.executenonquery
    bcon.close
    response.Redirect("DBsuccess.aspx")
    
    
    end sub

</script>
<!--#include file="config.aspx" -->
<html>
<head>
    <title>GSMLanka - Phone Manager</title>
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
.style7 {
	color: #000000;
	font-size: 12px;
}
.style8 {color: #336699}
.style9 {color: #003366#336699}
.style11 {color: #FF6600}
-->
</style>
    <script type="text/JavaScript">
<!--
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
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
                    <td width="269" height="25">
                        &nbsp;</td>
                    <td width="317">
                    </td>
                    <td valign="bottom" width="101" rowspan="2">
                        <span class="address"><span class="style3">GSM</span> <span class="style4">Lanka <span class="style6">Home</span> </span></span></td>
                </tr>
                <tr>
                    <td class="redfont" valign="top" height="16">
                        Welcome Administrator: <asp:Label id="lblAdmin" runat="server" font-bold="true"></asp:Label></td>
                    <td>
                    </td>
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
        <table cellspacing="0" cellpadding="0" width="799" align="center" background="imagenew/already_have_id.jpg" border="0">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td class="address" align="left" width="275" height="39">
                        <span class="style8">&nbsp;&nbsp;<img height="34" alt="Phone Manger " src="imagenew/Phn_man_icn..png" width="48" />Phone
                        Manger </span><span class="style9"></span>: USER MANAGEMENT 
                    </td>
                    <td width="123">
                        &nbsp;</td>
                    <td valign="center" align="left" width="401">
                        <asp:Label id="lblstatus" runat="server" font-bold="true" forecolor="#CC0000"></asp:Label></td>
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
                    <td width="10" height="209">
                        &nbsp;</td>
                    <td valign="top" width="776">
                        <table cellspacing="0" cellpadding="0" width="100%" border="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="195" height="17">
                                    </td>
                                    <td width="419">
                                    </td>
                                    <td width="162">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="12">
                                    </td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/selectphone_bk_line.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="419" height="12">
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="145">
                                    </td>
                                    <td valign="top">
                                        <table class="border4" cellspacing="0" cellpadding="0" width="100%" background="imagenew/sn_bk.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td class="redfont" valign="top" colspan="6" height="32">
                                                        &nbsp;&nbsp; select an order and click update to change status 
                                                    </td>
                                                    <td width="59">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td width="42" height="22">
                                                    </td>
                                                    <td class="leftlink1" valign="center" align="right" width="111">
                                                        User ID : 
                                                    </td>
                                                    <td width="9">
                                                        &nbsp;</td>
                                                    <td valign="top" colspan="2">
                                                        <asp:DropDownList id="cboORD" runat="server" AutoPostBack="true" OnSelectedIndexChanged="selOrder"></asp:DropDownList>
                                                    </td>
                                                    <td width="45">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="18">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td width="67">
                                                    </td>
                                                    <td width="84">
                                                    </td>
                                                    <td>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="23">
                                                    </td>
                                                    <td class="leftlink1" valign="center" align="right">
                                                        Status : 
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top" colspan="2">
                                                        <asp:DropDownList id="cbostat" runat="server"></asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td height="24">
                                                    </td>
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
                                                    <td height="28">
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td valign="top">
                                                        <asp:ImageButton id="cmdupdate" onclick="updateORD" runat="server" imageurl="buttons/updatesmal.jpg"></asp:ImageButton>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
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
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="12">
                                    </td>
                                    <td valign="top">
                                        <table cellspacing="0" cellpadding="0" width="100%" background="imagenew/selectphone_bk_dwn_line.jpg" border="0">
                                            <!--DWLayoutTable-->
                                            <tbody>
                                                <tr>
                                                    <td width="419" height="12">
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="23">
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                    </td>
                                </tr>
                                <!--DWLayoutTable-->
                            </tbody>
                        </table>
                    </td>
                    <td width="11">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td height="7">
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

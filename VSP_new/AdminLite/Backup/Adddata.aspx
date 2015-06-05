<%@ Page Language="c#" Inherits="AdminLite.Adddata" CodeFile="Adddata.aspx.cs" %>

<HTML>
  <HEAD><TITLE>.:Universal Data Admin:. - Welcome</TITLE>
<%

%>
	<META http-equiv=Content-Type content="text/html; charset=iso-8859-1">
  </HEAD>
<BODY bgColor=#ffffff leftMargin=0 topMargin=0 
MARGINHEIGHT="0" MARGINWIDTH="0">
<center>
<TABLE cellSpacing=0 cellPadding=0 width=798 bgColor=#ffffff border=0>
  <TR>
    <TD vAlign=top bgColor=#ffffff rowSpan=2>
						</TD>
    <TD width=605 colSpan=2>
						</TD></TR>
  <TR>
    <TD vAlign=top width=405>
      <TABLE id=Table1 height=407 cellSpacing=0 cellPadding=0 width="100%" 
      bgColor=#ffffff border=0 valign="top">
        <tr vAlign=top>
          <td colSpan=2><IMG alt="" src="images/Admin.gif" ></TD></TR>
        <tr>
          <td colSpan=2 height=10><font color=#006699 
            size=2 ="arial"></FONT><br>
            <h5>&nbsp;&nbsp;<A href="dbmain.aspx" ><SPAN 
            style="TEXT-DECORATION: none"><FONT face=arial 
            color=#006699>&lt;&lt; Back to Main 
            Page</H5></SPAN></FONT></A></TD></TR>
        <tr>
          <td width="4%"></TD>
          <td vAlign=top align=center>
            <form id=frmViewState action=test.aspx method=post 
             runat="server">
            <TABLE height=85 cellSpacing=0 cellPadding=0 width=372 border=0 
             ms_2d_layout="TRUE">
              <TR vAlign=top>
                <TD width=10 height=15></TD>
                <TD vAlign=middle width=362><asp:button id=Button1 runat="server" Text="<- Back to List" onclick="Button1_Click"></asp:Button>&nbsp;<asp:label id=lblstatus runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="#004000" Font-Size="Smaller"></t>ADD RECORD: Ready </asp:Label><br 
                  ><br></TD></TR>
              <TR vAlign=top>
                <TD height=15></TD>
                <TD><asp:table id=Table2 runat="server" Font-Size="8pt" CellSpacing="0" CellPadding="1" Font-Name="Verdana" HorizontalAlign="Center" GridLines="Both" height="45" border="1" width="361"></asp:table></TD></TR>
              <TR vAlign=top>
                <TD height=15></TD>
                <TD></TD></TR>
              <TR vAlign=top>
                <TD height=25></TD>
                <TD><asp:button id=btnBack runat="server" Text="<- Back to List" onclick="btnBack_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:button id=btnSubmit runat="server" text="Add Data" onclick="btnSubmit_Click"></asp:button></TD></TR></TABLE></FORM></TD></TR>
        <tr>
          <td colSpan=2><!--#include file="includes/bot.htm"--></TD></TR></TABLE></TD></TR></TABLE></CENTER></BODY>
</HTML>
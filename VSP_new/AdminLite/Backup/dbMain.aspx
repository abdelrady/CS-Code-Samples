<%@ Page Language="c#" validateRequest="false" Inherits="AdminLite.dbMain" CodeFile="dbMain.aspx.cs" %>
<HTML>
	<HEAD>
		<TITLE>.:Universal Data Admin:. - Welcome </TITLE>
		<%

%>
		<META http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<BODY bgColor="#ffffff" leftMargin="0" topMargin="0" MARGINHEIGHT="0" MARGINWIDTH="0">
	<script type="text/javascript">
function getOption()
{
var x=document.getElementById("cdatatype")
var y=document.getElementById("datatype")
y.value = (x.options[x.selectedIndex].text)
}
</script>
		<center>
			<TABLE cellSpacing="0" cellPadding="0" width="798" border="0" bgColor="#ffffff">
				<TR>
					<TD vAlign="top" width="405">
						<TABLE border="0" id="Table1" cellSpacing="0" cellPadding="0" width="100%" bgColor="#ffffff"
							valign="top">
							<tr vAlign="top">
								<td colSpan="2"><IMG alt="" src="images/admin.gif"></td>
							</tr>
							<tr>
								<td height="5" colspan="2"><BR>
									<asp:Label id="lblHeader" runat="server" Font-Names="Arial" ForeColor="DimGray" Font-Size="Smaller"></asp:Label></td>
							</tr>
							<tr>
								<td></td>
								<td>
									<table border="0" cellpadding="0" cellspacing="0" width="100%">
										<tr>
											<TD align="left" bgColor='#ffffff'><a href='dbMain.aspx?action=executesql'> <FONT face='Arial' color='#006699' size='2'>
													Execute Custom SQL Statement </a>
												<br>
												<br>
												</FONT></FONT></TD>
											<TD align="right" bgColor='#ffffff'>
												<a href='dbMain.aspx?action=addtable'><FONT face='Arial' color='#006699' size='2'>Add 
													New Table</a><br>
												<br>
												</FONT></FONT></TD>
										</tr>
									</table>
								</td>
							</tr>
							<TR>
								<TD></TD>
								<TD vAlign="top" align="left">
									<table cellSpacing="1" cellPadding="1" border="1" width="100%" bordercolorlight="#ffffff"
										bordercolordark="#999999" id="Table1" height="88">
										<asp:Label id="lbltables" runat="server">
											<STRONG>Select a Table from the Database</STRONG></asp:Label>
									</table>
									<table border="0" align="center">
										<tr>
											<td colspan="5" align="center"><br> <!--#include file="includes/bot.htm"--></td>
										</tr>
									</table>
								</TD>
							</TR>
						</TABLE>
						<CENTER></CENTER>
					</TD>
				</TR>
			</TABLE>
		</center>
	</BODY>
</HTML>

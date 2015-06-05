<%@ Page Language="c#" Inherits="AdminLite.Index" CodeFile="Index.aspx.cs" %>
<HTML>
	<HEAD>
		<TITLE>.:Universal Data Admin:. - Welcome </TITLE>
		<%

%>
		<META http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<BODY bgColor="#ffffff" leftMargin="0" topMargin="0" MARGINHEIGHT="0" MARGINWIDTH="0">
		<center>
			<script language="javascript">
	function validate_length1(oSrc, args)
	{
		args.Isvalid=true;
		if(args.Value)
		{
			var length = args.Value.length;
			if( length<4)
			{
				args.IsValid=false;
				
			}
		}
	}</script>
			<TABLE cellSpacing="0" cellPadding="0" width="798" border="0" bgColor="white">
				<TR>
					<TD width="605" colSpan="2">
						<!--include file="includes/top.htm"--></TD>
				</TR>
				<TR>
					<TD vAlign="top" width="405">
						<TABLE border="1" id="Table1" height="300" cellSpacing="0" cellPadding="0" width="100%"
							bordercolorlight="#ffffff" bordercolordark="#999999" bgColor="white" valign="top">
							<tr vAlign="top" height="47" width="405">
								<td><IMG alt="" src="images/Admin.gif"></td>
							</tr>
							<tr>
								<td vAlign="top" align="center">
									<form runat="server">
										<P><FONT face="Arial" size="2"></FONT>&nbsp;</P>
										<P><FONT face="Arial" color="#006699"><STRONG>WELCOME</STRONG></FONT></P>
										<P><FONT face="Arial" color="#006699" size="2"><A href="dbmain.aspx">Click here to proceed</A></FONT></P>
									</form>
								</td>
							</tr>
							<tr>
								<td colspan="2"><!--#include file="includes/bot.htm"--></td>
							</tr>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</center>
	</BODY>
</HTML>

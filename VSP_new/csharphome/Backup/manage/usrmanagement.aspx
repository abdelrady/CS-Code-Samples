<%@ Page language="c#" Codebehind="usrmanagement.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.usrmanagement" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - User Management</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" value="void" name="__EVENTTARGET"> <input type="hidden" value="void" name="__EVENTARGUMENT">
			<script language="javascript">
			<!--
				function __doPostBack(eventTarget, eventArgument) {
						var theform = document.Form1;
						theform.__EVENTTARGET.value = eventTarget;
						theform.__EVENTARGUMENT.value = eventArgument;
						theform.submit();
							}
				function __confirmUserDeletion(userid) {
						var deleteit = confirm('Are you sure you want to delete this user?');
						if (deleteit) {
							__doPostBack('deleteusr', userid);
						}

							}
			// -->
			</script>
			<!-- #include virtual="../header.inc" -->
			<HR width="100%" SIZE="1">
			<p>
				<TABLE border="0" id="Table1" cellSpacing="1" cellPadding="1" width="100%">
					<TR>
						<TD vAlign="top" width="15%">
							<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
							<P><STRONG>Welcome<BR>
									<%= Session["User_Name"] %>
									!</STRONG></P>
							<% } %>
							<asp:Literal id="liLinks" runat="server"></asp:Literal></TD>
						<TD vAlign="top" width="85%">
							<H3>User Management</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P>
								<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								<asp:Table id="tableUsers" runat="server" Width="100%"></asp:Table><% } %></P>
						</TD>
					</TR>
				</TABLE>
			</p>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted © 2003 David Elizalde</P>
		</form>
	</body>
</HTML>

<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage._default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - Home Management</title>
		<meta content="False" name="vs_showGrid">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
				function __confirmArticleDeletion(articleid) {
						var deleteit = confirm('Are you sure you want to delete this article?');
						if (deleteit) {
							__doPostBack('deletearticle', articleid);
						}

							}
			// -->
			</script>
			<!-- #include virtual="../header.inc" -->
			<HR width="100%" SIZE="1">
			<p>
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD vAlign="top" width="15%">
							<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
							<P><STRONG>Welcome<BR>
									<%= Session["User_Name"] %>
									!</STRONG></P>
							<% } %>
							<P><asp:literal id="liLinks" runat="server"></asp:literal></P>
						</TD>
						<TD vAlign="top">
							<H3>Home Management</H3>
							<P>This section allows Administrators to modify the majority of settings&nbsp;for 
								the&nbsp;main site itself; such as Links Panel, Articles on the main page, 
								Style Sheets and the Webmaster's email address (used for various things).</P>
							<P><asp:literal id="liMessage" runat="server"></asp:literal></P>
							<P><STRONG>Links</STRONG><BR>
								<asp:table id="tableLinks" runat="server" Width="100%"></asp:table></P>
							<P><STRONG>Articles</STRONG><% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
								(<A title="Post a new article" href="./editors/postarticle.aspx"><IMG src="../images/icons/thread.gif" border="0">Post 
									New Article</A>)<% } %><BR>
								<asp:table id="tableArticles" runat="server" Width="100%"></asp:table></P>
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

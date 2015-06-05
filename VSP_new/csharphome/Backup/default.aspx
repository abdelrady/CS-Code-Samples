<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="csharphome.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="./title.inc" --></title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<!-- #include virtual="./header.inc" -->
			<HR width="100%" SIZE="1">
			<MARQUEE DIRECTION="left" BEHAVIOR="alternate" SCROLLDELAY="100"><!-- #include virtual="./scroll.inc" --></MARQUEE>
			<HR width="100%" SIZE="1">
			<p>
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
					<TR>
						<TD width="15%" vAlign="top">
							<% if (Convert.ToBoolean(Session["LoggedIn"])) { %>
							<P><STRONG>Welcome<BR>
									<%= Session["User_Name"] %>
									!</STRONG></P>
							<% } %>
							<asp:Literal id="liLinks" runat="server"></asp:Literal>
						</TD>
						<TD vAlign="top">
							<P>
								<asp:Literal id="liArticles" runat="server"></asp:Literal><BR>
								<% if (Convert.ToBoolean(Request.QueryString["showall"]) == false) { %>
								<a href="./?showall=true" title="Show All Articles (Show Old Articles)"><FONT size="1">Show 
										All Articles</FONT></a>
								<% } else { %>
								<a href="./?showall=false" title="Display Current Articles"><font size="1">Show Current 
										Articles</font></a>
								<% } %>
							</P>
						</TD>
					</TR>
				</TABLE>
			</p>
			<P align="center">
				<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted 2003 David Elizalde<br>
				<img src="./feat/counter.aspx?for=home" border="0"></P>
		</form>
	</body>
</HTML>

<%@ Page language="c#" Codebehind="login.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - Login</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<!-- #include virtual="../header.inc" -->
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
							<H3>Login</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0">
									<TR>
										<TD width="25%">Username</TD>
										<TD>
											<asp:TextBox id="txtUsername" runat="server" Width="161px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD>Password</TD>
										<TD>
											<asp:TextBox id="txtPassword" runat="server" TextMode="Password" Width="161px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<P>
												<asp:LinkButton id="lnkForgotPassword" runat="server" ToolTip="Forgot your password? Click Here.">Forgot your password? Click Here.</asp:LinkButton><BR>
												<a href="./signup.aspx" title="Don't have an account? Click Here.">Don't have an 
													account? Click Here.</a><BR>
												<BR>
											</P>
										</TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<asp:Button id="btnSignin" runat="server" Text="Sign in"></asp:Button>
											<asp:Button id="btnSignout" runat="server" Text="Sign Out"></asp:Button></TD>
									</TR>
								</TABLE>
							</P>
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

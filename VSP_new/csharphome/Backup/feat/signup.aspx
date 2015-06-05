<%@ Page language="c#" Codebehind="signup.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.signup" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - Sign Up</title>
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
							<asp:Literal id="liMessage" runat="server"></asp:Literal>
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD width="84" colSpan="1" rowSpan="1" vAlign="top"><FONT size="2">Username</FONT></TD>
									<TD><FONT size="2"><asp:textbox id="txtUsername" runat="server" Width="258px"></asp:textbox>&nbsp;<FONT size="1">At 
												least 8 characters</FONT></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2"></FONT></TD>
									<TD><FONT size="2"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px; HEIGHT: 21px" width="144" vAlign="top"><FONT size="2">Password</FONT></TD>
									<TD style="HEIGHT: 21px"><FONT size="2"><asp:textbox id="txtPassword" runat="server" Width="258px" TextMode="Password"></asp:textbox>&nbsp;</FONT><FONT size="1">At 
											least 8 characters</FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2">Confirm Password</FONT></TD>
									<TD><FONT size="2"><asp:textbox id="txtPasswordConfirm" runat="server" Width="258px" TextMode="Password"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2"></FONT></TD>
									<TD><FONT size="2"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2">Email Address</FONT></TD>
									<TD><FONT size="2"><asp:textbox id="txtEmail" runat="server" Width="258px"></asp:textbox>&nbsp;</FONT><FONT size="1">Required 
											for password recovery</FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2"></FONT></TD>
									<TD><FONT size="2"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px; HEIGHT: 25px" width="144" vAlign="top"><FONT size="2">Your 
											account description</FONT></TD>
									<TD style="HEIGHT: 25px"><FONT size="2"><asp:textbox id="txtInfo" runat="server" Width="260px" TextMode="MultiLine" Height="102px" MaxLength="200"></asp:textbox><BR>
										</FONT><FONT size="1">Optional.</FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" vAlign="top" width="144"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2">&nbsp;&nbsp;</FONT></TD>
									<TD><FONT size="2"><EM>A user "icon" can be added after sign up.</EM></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" vAlign="top" width="144"></TD>
									<TD></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2"></FONT></TD>
									<TD>
										<P><FONT size="2">By using this site and/or signing up with an account you 
												automatically agree that the owner/owners' of this site are not responsible for 
												anything within or related to this site.</FONT>
										</P>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top">&nbsp;&nbsp;</TD>
									<TD>&nbsp;&nbsp;</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 144px" width="144" vAlign="top"><FONT size="2"></FONT></TD>
									<TD><FONT size="2">
											<P align="center"><asp:linkbutton id="lnkSignUp" runat="server">I Agree to the terms, and sign me up.</asp:linkbutton></P>
										</FONT>
									</TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</p>
			<HR width="100%" SIZE="1">
			<P></P>
			<P></P>
			<P align="center">Copyrighted  2003 David Elizalde</P>
		</form>
	</body>
</HTML>

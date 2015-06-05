<%@ Page language="c#" Codebehind="usrsettings.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.usrsettings" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - User Settings</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server" enctype="multipart/form-data">
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
						<TD>
							<H3>User Settings</H3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<P>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">
											<P><STRONG>Password</STRONG></P>
										</TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">Old Password</TD>
										<TD>
											<asp:textbox id="txtOldPwd" runat="server" Width="187px" TextMode="Password"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">New Password</TD>
										<TD>
											<asp:textbox id="txtNewPwd" runat="server" Width="187px" TextMode="Password"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">New Password Confirmed</TD>
										<TD>
											<asp:textbox id="txtConfirmNewPwd" runat="server" Width="187px" TextMode="Password"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD>
											<P>
												<asp:button id="cmbUpdatePwd" runat="server" Text="Update Password"></asp:button></P>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"><STRONG>Email Address</STRONG></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">New Email Address</TD>
										<TD>
											<asp:TextBox id="txtEmailAddr" runat="server" Width="187px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD>
											<asp:Button id="btnUpdateEmailAddr" runat="server" Text="Update Email Address"></asp:Button></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"><STRONG>User Description</STRONG></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">Description</TD>
										<TD><FONT size="2"><TEXTAREA rows="8" cols="34" id="txtInfo" style="WIDTH: 298px; HEIGHT: 127px" name="txtInfo" runat="server">
												</TEXTAREA><TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD>
											<asp:Button id="btnUpdateDesc" runat="server" Text="Update User Desc."></asp:Button>
											<asp:TextBox id="txtEdited" runat="server" Visible="False">NO</asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top"><STRONG>User Picture</STRONG></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">Current Picture</TD>
										<TD><img src="./userpic.aspx?usrid=<%= usrId %>" alt="Your user icon"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 155px" vAlign="top">Upload new Picture</TD>
										<TD>
											<INPUT id="txtFileUpload" type="file" name="txtFileUpload">&nbsp;
											<asp:Button id="btnUploadPic" runat="server" Text="Upload Picture"></asp:Button><BR>
											Note: Your picture will be reduced to a thumbnail size picture.</TD>
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
			<P align="center">Copyrighted 2003 David Elizalde</P>
		</form>
	</body>
</HTML>

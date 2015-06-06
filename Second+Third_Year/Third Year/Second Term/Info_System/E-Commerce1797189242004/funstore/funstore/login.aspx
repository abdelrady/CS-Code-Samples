<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.login" CodeFile="login.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>login</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:header id="Header1" runat="server"></uc1:header><uc1:menu id="Menu1" runat="server"></uc1:menu><uc1:footer id="Footer1" runat="server"></uc1:footer>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>
				<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 360px; WIDTH: 400px; POSITION: absolute; TOP: 216px; HEIGHT: 178px; BACKGROUND-COLOR: #ffffcc"
					cellSpacing="1" cellPadding="1" width="400" border="1">
					<TR>
						<TD align="center" colSpan="2"><asp:label id="Label3" runat="server" Font-Names="Bodoni MT Black" Width="166px" ForeColor="#C04000"
								Font-Bold="True">LOGIN</asp:label></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 170px; HEIGHT: 37px" align="center"><asp:label id="Label1" runat="server" Width="128px" ForeColor="#C00000" Font-Bold="True">E-Mail Address</asp:label></TD>
						<TD style="HEIGHT: 37px" align="center"><asp:textbox id="txtmail" runat="server" Width="184px" Height="24px"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
								ErrorMessage="*" ControlToValidate="txtmail"></asp:regularexpressionvalidator></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 170px; HEIGHT: 46px" align="center"><asp:label id="Label2" runat="server" Width="128px" ForeColor="#C00000" Font-Bold="True" Height="24px">Password</asp:label></TD>
						<TD style="HEIGHT: 46px" align="center"><asp:textbox id="txtpass" runat="server" Width="184px" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtpass"
								Display="Dynamic"></asp:requiredfieldvalidator></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 170px" align="center" colSpan="2"><asp:checkbox id="CheckBox1" runat="server" Width="173px" ForeColor="#C04000" Text="Remember Login "></asp:checkbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 170px" align="center"><asp:button id="btnLogin" runat="server" Width="108px" Text="LOGIN" onclick="btnLogin_Click"></asp:button></TD>
						<TD style="WIDTH: 167px" align="center" colSpan="2">&nbsp;
							<asp:button id="btnReset" runat="server" Width="100px" Text="RESET" onclick="btnReset_Click"></asp:button></TD>
					</TR>
				</TABLE>
			</P>
			<P>&nbsp;</P>
			<P><asp:label id="lblerror" style="Z-INDEX: 104; LEFT: 368px; POSITION: absolute; TOP: 192px"
					runat="server" Width="384px" ForeColor="Red" Font-Bold="True"></asp:label></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><A href="register.aspx"><img style="Z-INDEX: 103; LEFT: 368px; WIDTH: 160px; POSITION: absolute; TOP: 464px; HEIGHT: 28px"
						height="28" src="file:///C:\Inetpub\wwwroot\funstore\images\reg.JPG" width="160" border="0"></A></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><asp:label id="Label4" style="Z-INDEX: 102; LEFT: 360px; POSITION: absolute; TOP: 408px" runat="server"
					Width="400px" ForeColor="#C04000">If you dont Have and Account In Our Furniture store register and get and account now</asp:label></P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>

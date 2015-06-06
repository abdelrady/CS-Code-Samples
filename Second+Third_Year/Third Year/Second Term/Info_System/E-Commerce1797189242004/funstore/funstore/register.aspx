<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Page language="c#" Inherits="funstore.register" CodeFile="register.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>register</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:header id="Header1" runat="server"></uc1:header><uc1:menu id="Menu1" runat="server"></uc1:menu><uc1:footer id="Footer1" runat="server"></uc1:footer>
			<DIV style="Z-INDEX: 101; LEFT: 288px; WIDTH: 576px; POSITION: absolute; TOP: 176px; HEIGHT: 464px; BACKGROUND-COLOR: lightgrey"><asp:label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
					Width="96px">First Name</asp:label><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 320px; POSITION: absolute; TOP: 16px" runat="server"
					Width="96px">Last Name</asp:label><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 48px" runat="server"
					Width="96px">Address</asp:label><asp:label id="Label5" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 88px" runat="server"
					Width="80px">City</asp:label><asp:label id="Label6" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 216px" runat="server">Email</asp:label><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 176px" runat="server"
					Width="40px">Fax</asp:label><asp:label id="Label8" style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 136px" runat="server"
					Width="57px">Phone</asp:label><asp:label id="Label9" style="Z-INDEX: 108; LEFT: 16px; POSITION: absolute; TOP: 256px" runat="server"
					Width="72px">PassWord</asp:label><asp:label id="Label11" style="Z-INDEX: 109; LEFT: 24px; POSITION: absolute; TOP: 336px" runat="server"
					Width="80px">Card Type</asp:label><asp:label id="Label12" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 304px" runat="server"
					Width="120px">Confirm Password</asp:label><asp:label id="Label13" style="Z-INDEX: 111; LEFT: 24px; POSITION: absolute; TOP: 368px" runat="server"
					Width="81px">Card NO.</asp:label><asp:button id="btnRegister" style="Z-INDEX: 112; LEFT: 152px; POSITION: absolute; TOP: 416px"
					runat="server" Width="96px" Text="REGISTER" ForeColor="#C04000" Font-Bold="True" onclick="btnRegister_Click"></asp:button><asp:button id="Button2" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 416px" runat="server"
					Width="104px" Text="RESET" ForeColor="#C04000" Font-Bold="True" onclick="Button2_Click"></asp:button><asp:textbox id="txtfname" style="Z-INDEX: 114; LEFT: 112px; POSITION: absolute; TOP: 16px" runat="server"></asp:textbox><asp:textbox id="txtaddress" style="Z-INDEX: 115; LEFT: 112px; POSITION: absolute; TOP: 48px"
					runat="server" Width="368px"></asp:textbox><asp:textbox id="txtcity" style="Z-INDEX: 116; LEFT: 120px; POSITION: absolute; TOP: 88px" runat="server"></asp:textbox><asp:textbox id="txtfax" style="Z-INDEX: 117; LEFT: 112px; POSITION: absolute; TOP: 168px" runat="server"
					Width="192px"></asp:textbox><asp:textbox id="txtphone" style="Z-INDEX: 118; LEFT: 120px; POSITION: absolute; TOP: 128px"
					runat="server" Width="200px"></asp:textbox><asp:textbox id="txtmail" style="Z-INDEX: 119; LEFT: 112px; POSITION: absolute; TOP: 216px" runat="server"
					Width="208px"></asp:textbox><asp:textbox id="txtlname" style="Z-INDEX: 120; LEFT: 392px; POSITION: absolute; TOP: 16px" runat="server"></asp:textbox><asp:textbox id="txtp1" style="Z-INDEX: 121; LEFT: 120px; POSITION: absolute; TOP: 256px" runat="server"
					Width="184px" TextMode="Password"></asp:textbox><asp:textbox id="txtpass" style="Z-INDEX: 122; LEFT: 112px; POSITION: absolute; TOP: 296px" runat="server"
					Width="184px" TextMode="Password"></asp:textbox><asp:textbox id="txtcardno" style="Z-INDEX: 123; LEFT: 112px; POSITION: absolute; TOP: 368px"
					runat="server" Width="208px"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" style="Z-INDEX: 124; LEFT: 280px; POSITION: absolute; TOP: 24px"
					runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtfname"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator2" style="Z-INDEX: 125; LEFT: 552px; POSITION: absolute; TOP: 16px"
					runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtlname"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator3" style="Z-INDEX: 126; LEFT: 496px; POSITION: absolute; TOP: 64px"
					runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtaddress"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator6" style="Z-INDEX: 127; LEFT: 296px; POSITION: absolute; TOP: 96px"
					runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtcity"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator7" style="Z-INDEX: 128; LEFT: 344px; POSITION: absolute; TOP: 224px"
					runat="server" ErrorMessage="*" ControlToValidate="txtmail"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator8" style="Z-INDEX: 129; LEFT: 344px; POSITION: absolute; TOP: 304px"
					runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtpass"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="RegularExpressionValidator1" style="Z-INDEX: 130; LEFT: 368px; POSITION: absolute; TOP: 232px"
					runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator><asp:textbox id="txtcardt" style="Z-INDEX: 131; LEFT: 120px; POSITION: absolute; TOP: 336px"
					runat="server" Width="208px"></asp:textbox></DIV>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P><asp:label id="lblerror" style="Z-INDEX: 102; LEFT: 288px; POSITION: absolute; TOP: 144px"
					runat="server" Width="576px"></asp:label></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
		</form>
	</body>
</HTML>

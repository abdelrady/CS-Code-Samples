<%@ Page language="c#" Inherits="funstore.thankyou" CodeFile="thankyou.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>thankyou</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:Header id="Header1" runat="server"></uc1:Header>
			<uc1:Menu id="Menu1" runat="server"></uc1:Menu>
			<uc1:Footer id="Footer1" runat="server"></uc1:Footer>
			<asp:Image id="Image1" style="Z-INDEX: 101; LEFT: 408px; POSITION: absolute; TOP: 184px" runat="server"
				Width="240px" Height="88px" ImageUrl="file:///C:\Inetpub\wwwroot\funstore\images\DEV.JPEG"></asp:Image>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 352px; POSITION: absolute; TOP: 288px" runat="server"
				Width="472px" Height="32px" ForeColor="#FF8000" Font-Bold="True">THANK YOU FOR SHOPPING AT INDEX FURNITURE STORE</asp:Label>
			<asp:Image id="Image2" style="Z-INDEX: 103; LEFT: 448px; POSITION: absolute; TOP: 328px" runat="server"
				Width="72px" Height="32px" ImageUrl="file:///C:\Inetpub\wwwroot\funstore\images\icon_visa.gif"></asp:Image>
			<asp:Image id="Image3" style="Z-INDEX: 104; LEFT: 552px; POSITION: absolute; TOP: 328px" runat="server"
				Width="72px" Height="32px" ImageUrl="file:///C:\Inetpub\wwwroot\funstore\images\icon_mastercard.gif"></asp:Image>
		</form>
	</body>
</HTML>

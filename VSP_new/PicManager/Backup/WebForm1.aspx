<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="PicManager.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>vivekthangaswamy@rediffmail.com</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="Button" style="Z-INDEX: 101; LEFT: 504px; POSITION: absolute; TOP: 240px" runat="server"
				Text="Upload" OnClick="OnUpload" Width="80px" BorderStyle="Groove" BorderColor="Silver"></asp:Button>
			<asp:TextBox id="Comment" style="Z-INDEX: 102; LEFT: 344px; POSITION: absolute; TOP: 240px" runat="server"
				BorderStyle="Groove" BorderColor="Silver"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 152px; POSITION: absolute; TOP: 56px" runat="server"
				Width="664px" Font-Bold="True" ForeColor="Gray" Font-Size="X-Large">Save The Image Into SQL Server 2000 Database</asp:Label><INPUT id="Upload" style="Z-INDEX: 104; BORDER-LEFT-COLOR: gainsboro; LEFT: 344px; BORDER-BOTTOM-COLOR: gainsboro; BORDER-TOP-STYLE: groove; BORDER-TOP-COLOR: gainsboro; BORDER-RIGHT-STYLE: groove; BORDER-LEFT-STYLE: groove; POSITION: absolute; TOP: 192px; BORDER-BOTTOM-STYLE: groove"
				type="file" name="Upload" runat="server">
			<asp:Label id="Label2" style="Z-INDEX: 105; LEFT: 208px; POSITION: absolute; TOP: 240px" runat="server"
				Font-Bold="True" ForeColor="Gray">Image Description</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 592px; POSITION: absolute; TOP: 448px" runat="server"
				Width="288px">vivekthangaswamy@rediffmail.com</asp:Label>
			<asp:LinkButton id="LinkButton1" style="Z-INDEX: 107; LEFT: 64px; POSITION: absolute; TOP: 448px"
				runat="server" Width="168px">ViewImage</asp:LinkButton>
		</form>
	</body>
</HTML>

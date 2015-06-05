<%@ Page language="c#" Codebehind="DefaultPage.aspx.cs" AutoEventWireup="false" Inherits="PicManager.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PicManager :) ->> A Complete Solution For Photo Management</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:LinkButton id="lk_upload" style="Z-INDEX: 101; LEFT: 776px; POSITION: absolute; TOP: 320px"
				runat="server" Width="96px">Upload Photo</asp:LinkButton>
			<asp:LinkButton id="LinkButton1" style="Z-INDEX: 102; LEFT: 776px; POSITION: absolute; TOP: 368px"
				runat="server" Width="96px">Edit Photo</asp:LinkButton>
			<asp:TextBox id="Comment" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 168px" runat="server"
				Width="216px"></asp:TextBox>
			<asp:Button id="Upload" style="Z-INDEX: 104; LEFT: 424px; POSITION: absolute; TOP: 168px" runat="server"
				Width="288px" OnClick="OnUpload" Text="Button"></asp:Button>
		</form>
	</body>
</HTML>

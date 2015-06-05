<%@ Page language="c#" Codebehind="punnett.aspx.cs" AutoEventWireup="false" Inherits="csharphome.test.punnett" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>punnett</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link rel="stylesheet" type="text/css" href="../styles.css">
	</HEAD>
	<body>
		<form id="punnett" method="get" runat="server">
			<p>Parent A: <input type="text" name="a" value="<%= Request.QueryString["a"] %>"><br>
			Parent B: <input text="text" name="b" value="<%= Request.QueryString["b"] %>"><br>
			<br><input type="submit"></p>
			<asp:Table id="punnetttable" runat="server" GridLines="Both"></asp:Table></form>
	</body>
</HTML>

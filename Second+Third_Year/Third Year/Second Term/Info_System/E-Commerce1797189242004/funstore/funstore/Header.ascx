<%@ Control Language="c#" Inherits="funstore.Header" CodeFile="Header.ascx.cs" %>
<DIV style="WIDTH: 944px; POSITION: relative; HEIGHT: 128px">
	<asp:Image id="Image1" style="Z-INDEX: 101; LEFT: 712px; POSITION: absolute; TOP: 8px" runat="server"
		Width="208px" Height="80px" ImageUrl="file:///C:\Inetpub\wwwroot\funstore\images\logo.JPG"></asp:Image>
	<DIV style="Z-INDEX: 102; LEFT: 0px; WIDTH: 944px; POSITION: absolute; TOP: 80px; HEIGHT: 48px; BACKGROUND-COLOR: #cc9966">
		<asp:Button id="btnSearch" style="Z-INDEX: 101; LEFT: 464px; POSITION: absolute; TOP: 8px" Width="152px"
			runat="server" Font-Bold="True" ForeColor="Magenta" Text="SEARCH PRODUCTS" onclick="btnSearch_Click"></asp:Button>
		<asp:Button id="btnCart" style="Z-INDEX: 102; LEFT: 360px; POSITION: absolute; TOP: 8px" runat="server"
			Width="88px" ForeColor="Magenta" Font-Bold="True" Text="CART" onclick="btnCart_Click"></asp:Button>
		<asp:Button id="btnRegister" style="Z-INDEX: 103; LEFT: 224px; POSITION: absolute; TOP: 8px"
			runat="server" Width="120px" ForeColor="Magenta" Font-Bold="True" Text="REGISTRATION" onclick="btnRegister_Click"></asp:Button>
		<asp:Button id="btnHome" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 8px" runat="server"
			Width="88px" ForeColor="Magenta" Font-Bold="True" Text="HOME" onclick="Button2_Click"></asp:Button>
		<asp:Button id="btnAbout" style="Z-INDEX: 105; LEFT: 16px; POSITION: absolute; TOP: 8px" runat="server"
			Width="80px" ForeColor="Magenta" Font-Bold="True" Text="ABOUT US" onclick="btnAbout_Click"></asp:Button>
		<asp:Button id="btnLogin" style="Z-INDEX: 106; LEFT: 632px; POSITION: absolute; TOP: 8px" Width="104px"
			runat="server" Text="LOGIN" ForeColor="Magenta" Font-Bold="True" onclick="btnLogin_Click"></asp:Button></DIV>
	<OBJECT style="WIDTH: 424px; HEIGHT: 70px" codeBase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0"
		height="70" width="424" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000">
		<PARAM NAME="_cx" VALUE="11218">
		<PARAM NAME="_cy" VALUE="1852">
		<PARAM NAME="FlashVars" VALUE="">
		<PARAM NAME="Movie" VALUE="furniture.swf">
		<PARAM NAME="Src" VALUE="furniture.swf">
		<PARAM NAME="WMode" VALUE="Window">
		<PARAM NAME="Play" VALUE="-1">
		<PARAM NAME="Loop" VALUE="-1">
		<PARAM NAME="Quality" VALUE="High">
		<PARAM NAME="SAlign" VALUE="">
		<PARAM NAME="Menu" VALUE="-1">
		<PARAM NAME="Base" VALUE="">
		<PARAM NAME="AllowScriptAccess" VALUE="always">
		<PARAM NAME="Scale" VALUE="ShowAll">
		<PARAM NAME="DeviceFont" VALUE="0">
		<PARAM NAME="EmbedMovie" VALUE="0">
		<PARAM NAME="BGColor" VALUE="">
		<PARAM NAME="SWRemote" VALUE="">
		<PARAM NAME="MovieData" VALUE="">
		<embed src="furniture.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
			type="application/x-shockwave-flash" width="468" height="70"> </embed>
	</OBJECT>
</DIV>

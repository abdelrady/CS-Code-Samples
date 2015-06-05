<%@ Page language="c#" Codebehind="editarticle.aspx.cs" AutoEventWireup="false" Inherits="csharphome.manage.editors.editarticle" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../../title.inc" --> - Home Management - Articles - Edit Article</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../../styles.css">
		<SCRIPT LANGUAGE="Javascript" SRC="../ColorPicker2.js"></SCRIPT>
		<SCRIPT LANGUAGE="JavaScript">
var cp = new ColorPicker('window');
var cp2 = new ColorPicker();
// Runs when a color is clicked
function pickColor(color) {
	field.value = color;
	}

var field;
function pick1(anchorname) {
	field = document.forms[0].color;
	cp.show(anchorname);
	}
function pick2(anchorname) {
	field = document.forms[0].color2;
	cp2.show(anchorname);
	}
		</SCRIPT>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<!-- #include virtual="../../header.inc" -->
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
						<TD vAlign="top"><h3>Edit Article</h3>
							<P>
								<asp:Literal id="liMessage" runat="server"></asp:Literal></P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P><TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD style="WIDTH: 84px" valign="top">Subject</TD>
										<TD>
											<asp:TextBox id="txtArticleSubject" runat="server" Width="289px"></asp:TextBox>&nbsp;Id:
											<asp:TextBox id="txtId" runat="server" Width="27px" ReadOnly="True"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px" valign="top">Posted by</TD>
										<TD>
											<asp:TextBox id="txtPostedBy" runat="server" Width="289px" ReadOnly="True"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px" valign="top">Image</TD>
										<TD>
											<asp:TextBox id="txtImage" runat="server" Width="289px">NOIMAGE</asp:TextBox>&nbsp;(Specify 
											'NOIMAGE' if there isn't going to be one.)</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px; HEIGHT: 17px" valign="top">Description</TD>
										<TD style="HEIGHT: 17px">
											<asp:TextBox id="txtDescription" runat="server" TextMode="MultiLine" Width="523px" Height="51px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px; HEIGHT: 17px" vAlign="top">Outside link?</TD>
										<TD style="HEIGHT: 17px">
											<asp:CheckBox id="chkOutside" runat="server" Text="Yes"></asp:CheckBox>&nbsp;(Note:&nbsp;When 
											you&nbsp;are doing outside links, place the link inside the 'Article' textbox.)</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px; HEIGHT: 18px" vAlign="top">HTML Tools</TD>
										<TD style="HEIGHT: 18px">
											<INPUT style="WIDTH: 77px; HEIGHT: 22px" type="text" size="7" name="color2">&nbsp;<A id="pick2" onclick="pick2('pick2');return false;" href="javascript:void()" name="pick2">Colors</A>
											<SCRIPT language="javascript">cp.writeDiv()</SCRIPT>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px" valign="top">Article</TD>
										<TD>
											<asp:TextBox id="txtArticle" runat="server" TextMode="MultiLine" Width="523px" Height="200px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 84px"></TD>
										<TD>
											<asp:Button id="btnPostArticle" runat="server" Text="Post Edited Article"></asp:Button>
											<asp:TextBox id="txtEdited" runat="server" Visible="False">NO</asp:TextBox></TD>
									</TR>
								</TABLE>
							</P>
							<% } %>
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

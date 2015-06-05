<%@ Page Language="c#" Inherits="AdminLite.DB" CodeFile="db.aspx.cs" %>
<HTML>
	<HEAD>
		<TITLE>.:Universal Data Admin:. - Welcome </TITLE>
		<%

%>
		<META http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
	</HEAD>
	<BODY bgColor="#ffffff" leftMargin="0" topMargin="0" MARGINHEIGHT="0" MARGINWIDTH="0">
		<center>
			<TABLE cellSpacing="0" cellPadding="0" width="798" bgColor="#ffffff" border="0">
				<TR>
					<TD vAlign="top" width="405">
						<TABLE id="Table1" height="559" cellSpacing="0" cellPadding="0" width="572" bgColor="#ffffff"
							border="0" valign="top">
							<tr vAlign="top">
								<td colSpan="2"><IMG alt="" src="images/Admin.gif"></td>
							</tr>
							<tr>
								<td colSpan="2" height="10"><FONT color="#006900" size="2" face="arial"></FONT><BR>
									<H5>&nbsp;&nbsp;<A href="dbmain.aspx"><SPAN style="TEXT-DECORATION: none">
												<font color="#006699" face="arial">&lt;&lt; Back to Main Page</H5>
									</SPAN></FONT></A></td>
							</tr>
							<tr>
								<td>&nbsp;</td>
								<td vAlign="top" align="center">
									<form runat="server">
										<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
											<TR vAlign="top">
												<TD width="10" height="15"></TD>
												<TD vAlign="middle"><asp:button width="16%" id="Button1" runat="server" Text="Add Record" onclick="Button1_Click"></asp:button>
													<asp:TextBox id="txtSQL" runat="server" Font-Names="Verdana" Width="66%"></asp:TextBox>
													<asp:Button Width="16%" id="Button2" runat="server" Text="Run Query" onclick="Button2_Click"></asp:Button><br>
												</TD>
											</TR>
											<TR vAlign="top">
												<TD width="10" height="15"></TD>
												<TD vAlign="middle" align="right"><asp:Label id="lblSQLError" runat="server" ToolTip="w3schools.com - Learn to write SQL queries (new window)"></asp:Label>
													<!--		<br>
													<asp:label id="lblstatus" runat="server" Font-Size="XX-Small" ForeColor="Gray" Font-Names="Verdana">&nbsp;</t>VIEW ALL RECORD: </asp:label>-->
												</TD>
											</TR>
											<TR vAlign="top">
												<TD width="10" height="15"></TD>
												<TD><asp:datagrid id="DGtable" runat="server" Font-Names="Verdana" Font-Size="X-Small" Width="100%"
														BorderColor="LightSteelBlue" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4"
														ShowFooter="True" AllowPaging="True" AllowSorting="True">
														<FooterStyle Font-Size="X-Small" Font-Names="Verdana" ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
														<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="GhostWhite"></SelectedItemStyle>
														<AlternatingItemStyle ForeColor="Gray" BackColor="White"></AlternatingItemStyle>
														<ItemStyle ForeColor="Gray" BackColor="White"></ItemStyle>
														<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" ForeColor="Gray" BackColor="White"></HeaderStyle>
														<Columns></Columns>
														<PagerStyle Font-Size="X-Small" Font-Names="Arial" HorizontalAlign="Left" ForeColor="#330099"
															Position="TopAndBottom" BackColor="GhostWhite" Mode="NumericPages"></PagerStyle>
													</asp:datagrid></TD>
											</TR>
											<!--<tr>
												<td></td>
												<td align="left"><asp:TextBox id="txtSQL1" runat="server" Font-Names="Verdana" Width="82%"></asp:TextBox>
													<asp:Button Width = 17% id="Button21" runat="server" Text="Run Query"></asp:Button><br>
													<asp:Label id="lblSQLError1" runat="server" ToolTip="w3schools.com - Learn to write SQL queries (new window)"></asp:Label>
												</td>
											</tr>-->
										</TABLE>
									</form>
								</td>
							</tr>
							<tr>
								<td colspan="2"><!--#include file="includes/bot.htm"--></td>
							</tr>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</center>
	</BODY>
</HTML>

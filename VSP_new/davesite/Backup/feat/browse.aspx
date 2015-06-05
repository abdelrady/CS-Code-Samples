<%@ Page language="c#" Codebehind="browse.aspx.cs" AutoEventWireup="false" Inherits="csharphome.feat.browse" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title><!-- #include virtual="../title.inc" --> - Browse</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" type="text/css" href="../styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server" enctype="multipart/form-data">
			<input type="hidden" value="void" name="__EVENTTARGET"> <input type="hidden" value="void" name="__EVENTARGUMENT">
			<script language="javascript">
			<!--
				function __doPostBack(eventTarget, eventArgument) {
						var theform = document.Form1;
						theform.__EVENTTARGET.value = eventTarget;
						theform.__EVENTARGUMENT.value = eventArgument;
						theform.submit();
							}
				function __confirmFileDeletion(filename, basefilename) {
						var deleteit = confirm('Are you sure you want to delete this file?\n\n\"' + basefilename + '\"');
						if (deleteit) {
							__doPostBack('deletefile', filename);
						}
							}
				function __renameFile(oldfilename, basepath, basefilename) {
						var newfilename = prompt("Type a new filename to replace:", basefilename);
						if (newfilename == null) { return; }
						
						var renameit = confirm('Are you sure you want to rename\n\n' + basefilename + '\n\nto:\n\n' + newfilename);
						if (renameit) {
							__doPostBack('renamefile', oldfilename + '\n' + basepath + '\n' + newfilename);
					    }
							}
				function __renameFolder(oldFolder, basepath, foldername) {
						var newfoldername = prompt("Type a new name for this folder:", foldername);
						if (newfoldername == null) { return; }
						
						var renameit = confirm('Are you sure you want to rename\n\n' + foldername + '\n\nto:\n\n' + newfoldername);
						if (renameit) {
							__doPostBack('renamefolder', oldFolder + '\n' + basepath + '\n' + newfoldername);
					    }
							}
				function __deleteFolder(filename, basefilename) {
						var deleteit = confirm('Are you sure you want to delete this folder?\nAll the files and folders in this directory will also be deleted.\n\n\"' + basefilename + '\"');
						if (deleteit) {
							__doPostBack('deletefolder', filename);
						}
							}
				function __copyFile(from, to) {
						var newfilename = prompt("Type new location to copy file", to);
						if (newfilename == null) { return; }
						
						__doPostBack('copyfile', from + '\n' + newfilename);
							}
				function __moveFile(from, to) {
						var newfilename = prompt("Type new location to move file", to);
						if (newfilename == null) { return; }
						
						__doPostBack('movefile', from + '\n' + newfilename);
							}
			// -->
			</script>
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
						<TD vAlign="top">
							<P>
								<asp:literal id="liBrowse" runat="server"></asp:literal></P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P>
								<asp:TextBox id="txtBrowseTo" runat="server" Width="303px"></asp:TextBox>&nbsp;
								<asp:Button id="btnBrowseTo" runat="server" Text="Browse To"></asp:Button></P>
							<% } %>
							<P>
								<asp:table id="tableFolders" runat="server" Width="100%"></asp:table><BR>
								<asp:table id="tableFiles" runat="server" Width="100%"></asp:table></P>
							<P>
								<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD><A 
            href="browse.aspx?fldr=<%= strRawRequestDirectory %>&amp;offset=<%= intOffset - intDisplay %>&amp;display=<%= intDisplay %>">Prev.</A></TD>
										<TD>
											<P align="right"><A 
            href="browse.aspx?fldr=<%= strRawRequestDirectory %>&amp;offset=<%= intOffset + intDisplay %>&amp;display=<%= intDisplay %>">Next</A></P>
										</TD>
									</TR>
								</TABLE>
							</P>
							<% if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) { %>
							<P>
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
									<TR>
										<TD>File 1:</TD>
										<TD style="WIDTH: 256px">
											<INPUT id="txtFileUpload" type="file" name="txtFileUpload"></TD>
										<TD>File 5:</TD>
										<TD>
											<INPUT id="File1" type="file" name="File1"></TD>
									</TR>
									<TR>
										<TD>File 2:</TD>
										<TD style="WIDTH: 256px">
											<INPUT id="File2" type="file" name="File2"></TD>
										<TD>File 6:</TD>
										<TD>
											<INPUT id="File3" type="file" name="File3"></TD>
									</TR>
									<TR>
										<TD>File 3:</TD>
										<TD style="WIDTH: 256px">
											<INPUT id="File4" type="file" name="File2"></TD>
										<TD>New Folder</TD>
										<TD>
											<asp:TextBox id="txtNewFldName" runat="server">New Folder</asp:TextBox>
											<asp:Button id="btnNewFolder" runat="server" Text="Create"></asp:Button></TD>
									</TR>
									<TR>
										<TD>File 4:</TD>
										<TD style="WIDTH: 256px">
											<INPUT id="File6" type="file" name="File2"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<asp:Button id="btnUpload" runat="server" Text="Upload"></asp:Button>
											<P></P>
										</TD>
										<TD></TD>
										<TD></TD>
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

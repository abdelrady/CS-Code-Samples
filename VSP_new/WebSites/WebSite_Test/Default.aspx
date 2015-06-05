<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {

}

// ]]>
</script>
</head>
<body>
    <form name="form1" method="post" action="default.aspx" id="form1" runat =server>
<div>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
</div>
<div>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span id="lbl">Hello, world</span>
</div>
</form>
</body>
</html>

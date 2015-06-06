<%@ Page Language="C#" AutoEventWireup="true" CodeFile="advert.aspx.cs" Inherits="advert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

<script language="javascript">
function bindListControl()
 {
  OleDbConnection myConn 
  OleDbDataAdapter myOleDbAdapter  
  string connStr, sqlStr  
  Dataset myDataSet   
  connStr="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb"
  sqlStr = "SELECT  text"+ "FROM Table1"
  myConn= New OleDbConnection(connStr)
  myConn.Open()
  //myOleDbAdapter =New OleDbDataAdapter(sqlStr,myConn)
  //myOleDbAdapter.Fill(myDataSet,"dtProducts")
  //DataGrid1.DataSource = myDataSet.Tables("dtProducts")
  //DataGrid1.DataBind()
  myConn.Close()
}

function BClick()
{ 
var text=""
text=form1.name.value
document.write(" <div align='right'>&nbsp;");
document.write("<MARQUEE dir=rtl onmouseover=this.stop() onmouseout=this.start() scrollAmount=5 scrollDelay=100 direction=right style='height: 22px' >");
document.write("<FONT color=#990000>");
document.write(text);
document.write("</FONT></MARQUEE>");
document.write("<input type='text' name='name' style='z-index: 100; left: 143px; width: 429px; position: absolute; top: 106px; height: 109px'>");
document.write("<input type='button' value='submit' ");
document.write("onclick='BClick()' style='z-index: 101; left: 344px; position: absolute; top: 253px' id='Button1'  name='asd'>");
document.write("</div>"); 
window.open("Youth_care.aspx");  
} 
</script>
    <title>Untitled Page</title>
</head>
<body id=all leftMargin=0 topMargin=3 scroll=no rightMargin=0 marginheight="0" 
marginwidth="0" >
    <form id="form1" runat="server" >
    <div align="right">
        &nbsp;
 <MARQUEE dir=rtl onmouseover=this.stop() onmouseout=this.start() scrollAmount=5 
 scrollDelay=100 direction=right style="height: 22px" ><FONT color=#990000>welcome</FONT></MARQUEE>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 100;
            left: 346px; position: absolute; top: 264px" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server" Height="138px" OnTextChanged="TextBox1_TextChanged"
            Style="z-index: 102; left: 116px; position: absolute; top: 64px" TextMode="MultiLine"
            Width="491px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="138px" OnTextChanged="TextBox1_TextChanged"
            Style="z-index: 102; left: 216px; position: absolute; top: 110px" TextMode="MultiLine"
            Width="491px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        &nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Style="z-index: 100;
            left: 204px; position: absolute; top: 264px" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
 </div>
 
 </form>
</body>
</html>

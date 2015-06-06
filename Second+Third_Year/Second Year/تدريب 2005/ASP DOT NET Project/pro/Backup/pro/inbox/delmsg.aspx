<%@ page language="C#" master=~/forumtemplate.master  %>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>
<script runat="server">
 void Button1_Click(object sender, System.EventArgs e)
    {
        Response.Redirect ("inbox.aspx");
    }    
    
    
    void Page_Load(object sender, System.EventArgs e)
    {
        string send=HttpContext.Current.User.Identity.Name;
        int req = int.Parse(Request.QueryString.Get("number"));
        string sql = "delete from msg where number="+req;
           string constr = 
            "provider=Microsoft.JET.OLEDB.4.0; " +
            "data source = "+Server.MapPath("../data/users.mdb");    
          
        OleDbConnection cn = new OleDbConnection();
        cn.ConnectionString = constr;
        cn.Open();
        OleDbCommand command = new OleDbCommand(sql,cn);  
          OleDbDataReader d;
          d = command.ExecuteReader ();
         cn.Close();
    }
    
</script>
<asp:content id="sendart" runat=Server contentplaceholderid ="sitecontent" >
 
<table width="100%" height="90%" cellspacing="0" cellpadding="0"    >
<tr>
<td height="8%" style="WIDTH: 20%" >&nbsp;</td>
<td width="70%" height="10%" >
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label1"
            runat="server" width="200px" height="24px" forecolor="#0000C0" font-bold="True">
                                                                                                                          Deleted Succefully
            </asp:label>
</td>

    
</tr>
<tr>
<td height="10%" style="WIDTH: 20%" >&nbsp;</td>
<td width="70%" height="10%" >
    &nbsp;&nbsp;&nbsp;
</td>
</tr>
<tr>
<td colspan=2 valign=top align=center height=60%  >
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:button id="Button1" runat="server" text="Inbox" font-bold="True" forecolor="#0000C0"
                                                                     onclick="Button1_Click" />

</td>
</tr>
<tr>
<td colspan=2  height="10%" valign=top  >
</td>
</tr>

   </table>         
            

</asp:content>

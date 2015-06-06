<%@ page language="C#" master=~/forumtemplate.master  %>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>
<script runat="server">
 void Button1_Click(object sender, System.EventArgs e)
    {
        
        
    }    
    
    
    void Page_Load(object sender, System.EventArgs e)
    {
        string send=HttpContext.Current.User.Identity.Name;
        int req = int.Parse(Request.QueryString.Get("number"));
        string sql = "select * from msg where number="+req;
           string constr = 
            "provider=Microsoft.JET.OLEDB.4.0; " +
            "data source = "+Server.MapPath("../data/users.mdb");    
          string comstr = "insert into msg (send,sendfrom,code,title,message) values('"+ss.Text+"','"+send+"','"+DateTime.Now.ToShortDateString()+"','"+name.Text+"','"+art.Text+"')";
          
        OleDbConnection cn = new OleDbConnection();
        cn.ConnectionString = constr;
        cn.Open();
        OleDbCommand command = new OleDbCommand(sql,cn);  
          OleDbDataReader d;
          d = command.ExecuteReader ();
          d.Read ();
          art.Text = d["message"].ToString ();
          name.Text = d["title"].ToString ();
          ss.Text = d["sendfrom"].ToString ();
         cn.Close();
    }
    
</script>
<asp:content id="sendart" runat=Server contentplaceholderid ="sitecontent" >
 
<table width="100%" height="90%" cellspacing="0" cellpadding="0"    >
<tr>
<td height="8%" style="WIDTH: 20%" >
<asp:label id="Label1"
            runat="server" width="80px" height="24px" forecolor="#0000C0" font-bold="True">Tittel
            </asp:label>
</td>
<td width="70%" height="10%" >
<asp:textbox id="name"
            runat="server" width="224px">
        </asp:textbox>
</td>

    
</tr>
<tr>
<td height="10%" style="WIDTH: 20%" >
<asp:label id="Label3"
            runat="server" width="80px" height="24px" forecolor="#0000C0" font-bold="True">Send To        
</asp:label>

</td>
<td width="70%" height="10%" >
    &nbsp;<asp:textbox id="ss" runat="server">
          </asp:textbox>&nbsp;&nbsp;
</td>
</tr>
<tr>
<td colspan=2 valign=top align=center height=60%  >
<asp:textbox id="art"
            runat="server" width="504px" height="100%" textmode="MultiLine">
        </asp:textbox>

</td>
</tr>
<tr>
<td colspan=2  height="10%" valign=top  >
</td>
</tr>

   </table>         
            

</asp:content>

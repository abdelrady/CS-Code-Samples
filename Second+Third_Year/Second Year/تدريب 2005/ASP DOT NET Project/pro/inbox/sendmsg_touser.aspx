<%@ page language="C#" master=~/forumtemplate.master  %>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>
<script runat="server">
 void Button1_Click(object sender, System.EventArgs e)
    {
        string send=HttpContext.Current.User.Identity.Name;
        string sql = "select send from client where send='"+ss.Text.ToString()+"'";
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
      
          if (!d.Read())
          {
              Response.Redirect("error.aspx");
              //Response.Redirect ("sendmsg_touser.aspx");
          }
          cn.Close();
//        DataColumn col = new DataColumn ("name",Type.GetType("System.String"));
        OleDbDataAdapter dataAdapter = 
            new OleDbDataAdapter (
            comstr, constr); 
          DataSet dataSet = new DataSet();
          dataAdapter.Fill(dataSet,"msg");
          //DataTable dataTable = new DataTable("msg");
          //DataRow row; 
          //row = dataTable.NewRow();
          //dataTable.Rows.Add (row);
        
        //DataTable dataTable = dataSet.Tables[0]
    }    
    
    
    void Page_Load(object sender, System.EventArgs e)
    {
        String sendto = Request.QueryString.Get ("sendto");
        ss.Text = sendto;
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
<center>
<asp:button id="Button1"
            runat="server" width="112px" text="Send Messag" onclick="Button1_Click" forecolor="#0000C0" font-bold="True" />
</center>
</td>
</tr>

   </table>         
            

</asp:content>

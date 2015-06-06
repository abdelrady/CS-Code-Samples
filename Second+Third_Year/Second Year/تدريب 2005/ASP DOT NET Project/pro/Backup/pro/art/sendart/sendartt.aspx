<%@ page language="C#" master=~/forumtemplate.master  %>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>
<script runat="server"> 
    void Button1_Click(object sender, System.EventArgs e)
    {
           String user= HttpContext.Current.User.Identity.Name;
          string constr = 
            "provider=Microsoft.JET.OLEDB.4.0; " +
            "data source = E:/WebSites/pro/Data/articles.mdb";    
          string comstr = "insert into article (name,username,articles,description,code) values('"+name.Text+"','"+user+"','"+art.Text+"','"+desc.Text+"','"+DateTime.Now.Date.ToString()+"')";
          OleDbDataAdapter dataAdapter = 
            new OleDbDataAdapter (
            comstr, constr);  
//        DataColumn col = new DataColumn ("name",Type.GetType("System.String"));
          DataSet dataSet = new DataSet(  );
          dataAdapter.Fill(dataSet,"article");
          DataTable dataTable = new DataTable("article");
          DataRow row; 
          row = dataTable.NewRow();
          dataTable.Rows.Add (row);
          
        
        //DataTable dataTable = dataSet.Tables[0]
    }    
</script> 

<asp:content id="sendart" runat=Server contentplaceholderid ="sitecontent"  >
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
            runat="server" width="80px" height="24px" forecolor="#0000C0" font-bold="True">Discription        
</asp:label>

</td>
<td width="70%" height="10%" >
<asp:textbox id="desc"
            runat="server" width="336px">
        </asp:textbox>
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
            runat="server" width="112px" text="Send Articel" onclick="Button1_Click" forecolor="#0000C0" font-bold="True" />
</center>
</td>
</tr>

   </table>         
            
            
 </asp:content>
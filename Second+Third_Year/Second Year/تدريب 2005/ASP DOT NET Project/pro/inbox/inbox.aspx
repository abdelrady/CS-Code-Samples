<%@ page language="C#" master=~/forumtemplate.master %>
<%@ import namespace="System.Data" %>
<%@ import namespace="System.Data.OleDb" %>

<script runat="server" language="C#">


    
    
    void Page_Load(object sender, System.EventArgs e)
    {
        tt.Text=HttpContext.Current.User.Identity.Name;
        //string s = curuser;
        
         
    }  
    
  </script>

<asp:content id="sitecontent" runat="Server" contentplaceholderid="sitecontent">
    &nbsp;
    <asp:accessdatasource id="inbox" runat="server" deletecommand="delete  from msg where number=@s" selectcommand="select * from msg where send = @s"
        datafile="../Data/users.mdb" sharemode="ReadWrite">
        <selectparameters>
            <asp:controlparameter name="send" propertyname="Text" type="String" controlid="tt">
            </asp:controlparameter>
        </selectparameters>
    </asp:accessdatasource>
    <asp:textbox id="tt" runat="server" visible="False">
    </asp:textbox>
    <asp:datalist id="DataList1" runat="server" datasourceid="inbox">
        <itemtemplate>
            <tr height=100%>
              <td>
            <a href='<%#"viewmsg.aspx?number="+DataBinder.Eval(Container.DataItem, "number")%>' target=_self >
            <asp:label id="Label1" text='<%# Eval("send") %>' runat="server">
            </asp:label></a> 
             </td>
             <td>
               <asp:label id="Label2" text='<%# Eval("sendfrom") %>' runat="server">
            </asp:label>
             </td>
             <td>
              <asp:label id="Label3" text='<%# Eval("code") %>' runat="server">
            </asp:label>
             </td>
             <td>
             <asp:label id="Label4" text='<%# Eval("title") %>' runat="server">
            </asp:label>
             </td>
             <td>
             <a href='<%#"delmsg.aspx?number="+DataBinder.Eval(Container.DataItem, "number")%>' target=_self >del</a> 
             </td>
             </tr>
             <tr>
             <td colspan=5>
              <hr /></td>
             </tr>
                  
            
            
        </itemtemplate>
    </asp:datalist>
</asp:content>     
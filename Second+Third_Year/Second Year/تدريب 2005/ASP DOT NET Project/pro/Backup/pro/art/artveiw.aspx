<%@ page language="C#" master=~/forumtemplate.master   %>

<script runat="server">   
       </script>

<asp:content id="sendart" runat=Server contentplaceholderid ="sitecontent"  >
    <asp:detailsview id="DetailsView1" runat="server" width="600px" autogeneraterows="False"
            datasourceid="artview" height="32px">
            <itemtemplate >
            <tr >
            <td colspan=2><b><font size=3 color=#000099><%#DataBinder.Eval(Container.DataItem, "name") %></font></b>
            </td>
            <td>
            <i>
            <font size=3 color=#000099>
            <%#DataBinder.Eval(Container.DataItem,"code") %> <a href='<%#"../msg/sendmsg_touser.aspx?sendto="+DataBinder.Eval(Container.DataItem, "username") %>' target=_self > <%#DataBinder.Eval(Container.DataItem, "username") %></a> 
            </td>
           
            </tr>
            <tr>
            <td colspan=3>
            <textarea  rows="20" cols="60"  ><%#DataBinder.Eval(Container.DataItem,"articles") %></textarea>
            
            </td>
           
            </tr>
            </itemtemplate>
        </asp:detailsview>
  
         <asp:accessdatasource id="artview" runat="server" selectcommand="select * from article where name=n"
            datafile="../Data/articles.mdb" >
            
            <selectparameters>
            
            <asp:querystringparameter name=n querystringfield="artnam">
            </asp:querystringparameter>
            </selectparameters>
        </asp:accessdatasource>
        
</asp:content> 
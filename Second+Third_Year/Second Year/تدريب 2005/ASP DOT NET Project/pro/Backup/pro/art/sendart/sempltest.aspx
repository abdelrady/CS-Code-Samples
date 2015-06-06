<%@ page language="C#" %>

<script runat="server">
    public void veiw_Click (object sender, System.EventArgs e)
    {
        
    }
</script>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body ms_positioning="GridLayout">
    <form runat="server">
        <asp:datalist  id="list" runat="server" datasourceid="db" width="432px">
       <itemtemplate>
       <asp:button id="sele" commandname="select" text="view" />
       <%#DataBinder.Eval(Container.DataItem,"articles")%> 
       </itemtemplate>
       
        </asp:datalist> 
        <asp:accessdatasource id="db" runat="server" deletecommand="delete from article where name='asd'"
            updatecommand="update article set name ='xxx'" selectcommand="select *from article"
            insertcommand="insert into article (username,name,code,articles) values ('kemo','memy','11/11/1002','ooooooooo'"
            datafile="../../Data/articles.mdb" sharemode="ReadWrite">
        </asp:accessdatasource>
       <asp:button id="veiw" commandname="select" text="view" runat=Server onclick="veiw_Click" />&nbsp;&nbsp;&nbsp;
        <asp:repeater id="Rep" runat="server" datasourceid="db">
       <itemtemplate>
       <asp:button id="sele" commandname="select" text="view" />
      <%#  DataBinder.Eval(Container.DataItem,"username")%>
       </itemtemplate>
        </asp:repeater>

    </form>
</body>
</html>

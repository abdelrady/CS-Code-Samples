<%@ page language="C#" master=~/forumtemplate.master  %>

<script runat="server">

    
    </script>

<asp:content id="sendart" runat=Server contentplaceholderid ="sitecontent"  >

<center>
<h2>Articles</h2>
</center>
<table id="Table1"   height="10%" width="100%" bgcolor="gray">
            <tr height=100%>
              <td style="WIDTH: 173px">
            Article Tittel
             </td>
             <td style="WIDTH: 106px">
            Sender
             </td>
             <td>
               Date Of Send
             </td>
             <td style="WIDTH: 84px">
             Article Description
             </td>
             </tr>
        <table>
<asp:accessdatasource id="artdataveiw" runat="server" selectcommand="select * from article" 
               datafile="../Data/articles.mdb">
        </asp:accessdatasource>
  <asp:datalist id="DataList1"  runat="server" width="600px" height="8px" datasourceid="artdataveiw" gridlines=Vertical forecolor="Black" borderwidth="1px" bordercolor="#DEDFDE" cellpadding="4" backcolor="White" borderstyle="None" >
            <itemstyle backcolor="#F7F7DE" font-italic="False" font-bold="False">
            </itemstyle>
            <footerstyle backcolor="#CCCC99" font-italic="False" font-bold="False">
            </footerstyle>
            <headerstyle forecolor="White" backcolor="#6B696B" font-italic="False" font-bold="True">
            </headerstyle>
            <selecteditemstyle forecolor="White" backcolor="#CE5D5A" font-italic="False" font-bold="True">
            </selecteditemstyle>
     
            <alternatingitemstyle font-italic="False" font-bold="False" backcolor="White">
            </alternatingitemstyle>
            
            <itemtemplate >
              <tr height=100%>
              <td>
              <%#DataBinder.Eval(Container.DataItem, "name") %>
             </td>
             <td>
               <%#DataBinder.Eval(Container.DataItem, "username") %>
             </td>
             <td>
               <%#DataBinder.Eval(Container.DataItem, "code") %>
             </td>
             <td>
               <a href='<%#"artveiw.aspx?artnam="+ DataBinder.Eval(Container.DataItem, "name")%>' target=_self > <%#DataBinder.Eval(Container.DataItem, "description") %></a> 
             </td>
             </tr>
             <tr>
             <td colspan=4>
              <hr /></td>
             </tr>
              
            </itemtemplate>
          
        </asp:datalist>&nbsp;&nbsp;&nbsp;
  </asp:content> 


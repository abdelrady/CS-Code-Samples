<%@ Page language="c#" master="~/forumtemplate.master" %>
<script runat="server" language="c#">
   
   public String UserName;
    
    void Page_Load(object sender, System.EventArgs e)
    {
           UserName=HttpContext.Current.User.Identity.Name;
    
    }
    
</script>

<asp:content id="Form1" runat="Server" contentplaceholderid="sitecontent">
<center>
<h3>Welcome To Friends Chat </h3>
<font size=3 color=#ffcc66 ><b>Click Any Room To Join</b></font>
  <br />
    <asp:datalist id="DataList1" runat="server" datasourceid="room">
        <itemtemplate>
        <b>
           <a href='<%#"chat_room/ChatWin.aspx?chanel="+DataBinder.Eval(Container.DataItem,"chanel")+",UserName="+UserName %>' target=_self ><%# DataBinder.Eval(Container.DataItem, "room")%></a>
           </b><br />
           
        </itemtemplate>
    </asp:datalist>
    <asp:accessdatasource id="room" runat="server" selectcommand="select * from chatroom"
        datafile="Data/chatroom.mdb">
    </asp:accessdatasource>
</center>
</asp:content>
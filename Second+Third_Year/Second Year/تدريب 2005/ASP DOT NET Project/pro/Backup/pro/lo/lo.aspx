<%@ page language="C#" %>

<script runat="server">
  
    
    
    void Button1_Click(object sender, System.EventArgs e)
    {
        tu.Text = HttpContext.Current.User.Identity.Name;
       
    }
    
    
    
    
</script>

<html>
<head runat="server" id="Head1">
    <title>Untitled Page</title>
</head>
<body ms_positioning="GridLayout">
    <form runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%String i = "mohammed";
          i+="<asp:loginname id="+"LN"+" runat="+"server" +" formatstring="+"{0}"+"style="+"Z-INDEX:+"+ "101; LEFT: 280px; POSITION: absolute; TOP: 16px"+" />";%>
    <%Response.Write (i); %>
    <%Response.Write ("hiiiiiii"); %>

        <asp:loginname id="ln" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: 72px"
            runat="server" width="204px" />
            <%=ln.ClientID  %>
            <% %>
        <asp:textbox id="tu" style="Z-INDEX: 102; LEFT: 184px; POSITION: absolute; TOP: 200px"
            runat="server" width="256px">
        </asp:textbox>
        <asp:button id="Button1" style="Z-INDEX: 103; LEFT: 320px; POSITION: absolute; TOP: 272px"
            runat="server" width="104px" text="Button" onclick="Button1_Click" />
        <asp:login id="Login1" style="Z-INDEX: 104; LEFT: 328px; POSITION: absolute; TOP: 32px"
            runat="server" width="176px" height="112px" >
        </asp:login>
        <asp:loginview id="LoginView1" runat="server">
        </asp:loginview>
        <asp:passwordrecovery id="rec" style="Z-INDEX: 105; LEFT: 112px; POSITION: absolute; TOP: 184px"
            runat="server" width="192px" height="48px">
        </asp:passwordrecovery>
    </form>
</body>
</html>

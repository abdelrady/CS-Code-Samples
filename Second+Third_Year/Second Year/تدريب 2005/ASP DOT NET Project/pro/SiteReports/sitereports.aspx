<%@ page language="C#" master=~/forumtemplate.master %>
<%@ import Namespace="System.Data" %>

<script language="C#" runat="server">

    void ImageButton1_Click(Object Sender, ImageClickEventArgs e) {
        
        SiteCounters.Flush();
                
        GridView1.DataSource = SiteCounters.GetRows(DateTime.MinValue, DateTime.MaxValue, CounterGroup.SelectedValue, null);
        GridView1.DataBind();
        
    }

</script>

<asp:content id="SiteContent"  ContentPlaceHolderId="sitecontent" runat="server">

    <table cellpadding="3" border="0">
        <tbody>
            <tr>
                <td width="20" height="86">
                    &nbsp; 
                </td>
                <td valign="top" colspan="3">
                    <p>
                        <font face="Verdana" color="#808080" size="6">Reports</font> 
                    </p>
                </td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp; 
                </td>
                <td width="87">
                    <font face="Verdana, Arial, Helvetica, sans-serif" size="2">
                    <asp:DropDownList id="CounterGroup" runat="server">
                        <asp:ListItem Value="AdRotator"></asp:ListItem>
                        <asp:ListItem Value="PageCounters"></asp:ListItem>
                    </asp:DropDownList>
                    </font></td>
                <td width="342">
                    &nbsp;<asp:ImageButton id="ImageButton1" src="../images/emailbutton.gif" onclick="ImageButton1_Click" runat="server"></asp:ImageButton>
                </td>
            </tr>
        </tbody>
    </table>
    
    <table cellpadding="26" bordercolor="0">
        <tr>
            <td >
    
            <asp:gridview autogeneratecolumns="false" runat=server id=GridView1 forecolor="#585880" bgcolor="#EEEEEE" borderstyle="Double" bordercolor="#E7E5DB"  borderwidth="2pt" font-size=".9em" font-names="Verdana" cellpadding="1" >

                <AlternatingRowStyle Font-Size="0.7em" ForeColor="#585880" BackColor="#F8F7F4"></AlternatingRowStyle>
                <EditRowStyle        font-size="0.7em" ForeColor="#585880" BackColor="#F8F7F4"></EditRowStyle>
                <Headerstyle         Font-Bold="true" Font-Size="0.7em" ForeColor="#FFFFFF"  BackColor="#000066"></HeaderStyle>
                <RowStyle            Font-Size="0.7em" ForeColor="#585880" BorderColor="White" BackColor="White"></RowStyle>
                <summarytitlestyle width="400px"></summarytitlestyle>
                <NullRowStyle        Font-Size="0.7em" ForeColor="#585880"  BackColor="#F8F7F4"></NullRowStyle>
                <PagerStyle          Font-Size="0.7em" ForeColor="#585880"  BorderWidth="1pt" BorderColor="#585880" BorderStyle="Solid" BackColor="#F8F7F4"></PagerStyle>
                <ColumnFields>
                    <asp:BoundField DataField="EndTime" HeaderText="Date" DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="PageUrl" HeaderText="Page URL"/>
                    <asp:BoundField DataField="CounterName" HeaderText="Counter Name"/>
                    <asp:BoundField DataField="CounterEvent" HeaderText="Counter Event"/>
                    <asp:BoundField DataField="NavigateUrl" HeaderText="Ad URL"/>
                    <asp:BoundField DataField="Total" HeaderText="Total"/>
                </ColumnFields>
            
            </asp:gridview> 
    
            </td>
            </tr>
    </table>

</asp:content>


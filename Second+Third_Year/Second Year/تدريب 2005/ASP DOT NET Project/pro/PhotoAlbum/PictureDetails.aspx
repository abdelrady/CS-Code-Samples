<%@ page language="C#" master="~/sitetemplate.master" %>
<script runat="server" language="c#">

</script>


<asp:content id="sitecontent" ContentPlaceHolderId="sitecontent" runat="server">

    <asp:accessdatasource id="Photos" datafile="~\data\PhotoAlbum.mdb" selectcommand="select * from photos where photoid=@photoid" runat="server">
        <selectparameters>
            <asp:querystringparameter name="photoid" querystringfield="photoid" defaultvalue="1" type="int32"/>
        </selectparameters>
    </asp:accessdatasource>

    <table cellpadding="10" border="0">
        <tr>
            <td width="40"></td>
            <td>
                <asp:detailsview id="Detailsview1" datasourceid="Photos" runat="server">
                    <itemtemplate>
                        <span id="pagetitle"><%# DataBinder.Eval(Container.DataItem,"name") %></span>
                    
                        <br /><br />
                    
                        <asp:image id="Image1" imageurl='<%#"~/PhotoAlbum/Photos/big_" + DataBinder.Eval(Container.DataItem, "ImageUrl")%>' runat="server"></asp:image>

                        <br /><br />

                        <span id="bodytext">
                            <b>Description:</b> <%# DataBinder.Eval(Container.DataItem, "Description") %> <br />
                            <b>Taken By:</b> <%# DataBinder.Eval(Container.DataItem, "TakenBy") %> <br />
                            <b>Location:</b> <%# DataBinder.Eval(Container.DataItem, "LocationTaken") %> <br />
                            <b>Date Taken:</b> <%# DataBinder.Eval(Container.DataItem, "DateTaken") %> <br />
                        </span>
                        
                    </itemtemplate>
                </asp:detailsview>                
            </td>
        </tr>
    </table>  

</asp:content>
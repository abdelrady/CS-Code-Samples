<%@ page language="C#" master="~/sitetemplate.master" %>

<asp:content id="sitecontent" ContentPlaceHolderId="sitecontent" runat="server">

    <asp:accessdatasource id="Photos" datafile="~\data\PhotoAlbum.mdb" selectcommand="select * from photos where albumid=@albumid" runat="server">
        <selectparameters>
            <asp:querystringparameter name="albumid" querystringfield="albumid" defaultvalue="1" type="int32"/>
        </selectparameters>
    </asp:accessdatasource>

    <asp:accessdatasource id="AlbumName" datafile="~\data\PhotoAlbum.mdb" selectcommand="select AlbumName from albums where albumid=@albumid" runat="server">
        <selectparameters>
            <asp:querystringparameter name="albumid" querystringfield="albumid" defaultvalue="1" type="int32"/>
        </selectparameters>
    </asp:accessdatasource>

    <table cellpadding="10" border="0">
        <tr>
            <td width="40"></td>
            <td>
                <asp:detailsview id="Detailsview1" DataSourceId="AlbumName" runat="server">
                    <itemtemplate>
                        <Span id="pagetitle"><%# DataBinder.Eval(Container.DataItem, "AlbumName") %></span>
                    </itemtemplate>
                </asp:detailsview>                
            </td>
        </tr>
        <tr>
            <td width="40"></td>
            <td>
                <asp:datalist id="DataList1" cellspacing=15  repeatcolumns=2 itemstyle-verticalalign=Top runat="server" datasourceid="Photos" borderstyle="None" borderwidth="0" backcolor="White" gridlines="Horizontal" bordercolor="#E7E7FF" cellpadding="8" font-size="X-Small" font-names="Verdana">

                    <itemtemplate>
                       
                            <a href='<%#"PictureDetails.aspx?photoid=" + DataBinder.Eval(Container.DataItem, "PhotoId")%>'> 
                                <asp:image imageurl='<%#"~/PhotoAlbum/Photos/" + DataBinder.Eval(Container.DataItem, "ImageUrl")%>' runat="server"></asp:image>
                            </a>
                            <br />
                            <b><%#DataBinder.Eval(Container.DataItem, "name")%></b>
                            <br /><br />
                            
                    </itemtemplate>
                    
                </asp:datalist>
            </td>
        </tr>
    </table>      
 
</asp:content>
   

         



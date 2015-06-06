<%@ page language="C#" master="~/sitetemplate.master" %>

<asp:content id="sitecontent"  ContentPlaceHolderId="sitecontent" runat="server">
<asp:accessdatasource id="PhotoAlbums" datafile="~/Data/PhotoAlbum.mdb" selectcommand="select * from Albums" runat="server" />
    
    <table cellpadding="10" border="0">
        <tr>
            <td width="40">
            </td>
            <td valign="bottom">
            
                <table width="100%" cellpadding="0" cellspacing="0">
                  <tr>
                     <td>
                        <span id="pagetitle">Photo Albums</span>
                     </td>
                     <td align="right">
                         <img src="images/photoalbum.jpg" alt="Photo Album with Slides"/>
                     </td>
                  </tr>
        
                  <tr>
                    <td colspan="2">
                    <hr />
                   </td>
                 </tr>
               </table>
    
           </td> 
       </tr>
    
        <tr>
            <td width="40"></td>
            <td>
                <br />
                <span id="SmallPageTitle">
                
                    <asp:datalist id="DataList1" runat="server" datasourceid="PhotoAlbums">
                        <itemtemplate>                      
                             <span id="bluearticletitle">
                                <a id="A1" href='<%# "PictureAlbum.aspx?AlbumId=" + DataBinder.Eval(Container.DataItem, "albumid") %>' runat="server">
                                    <em><%# DataBinder.Eval(Container.DataItem, "albumname") %></em>
                                </a>
                            </span>
                        
                            <br />
                        
                            <span id="bodytext">
                                <%# DataBinder.Eval(Container.DataItem, "AlbumDescription") %>
                            </span>
                            <br /><br />
                        </itemtemplate>
                    </asp:datalist>
                    
                </span>
            </td>
       </tr>
    </table>    

</asp:content>
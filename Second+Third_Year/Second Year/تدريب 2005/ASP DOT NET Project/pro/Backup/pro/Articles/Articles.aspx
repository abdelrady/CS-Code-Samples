<%@ page language="C#" master="~/sitetemplate.master"%>

<asp:content id="SiteContent" ContentPlaceHolderId="sitecontent" runat="server"><table border="0" cellpadding="10" style="WIDTH: 600px;">
             <tr>
            <td width="40"></td>
            <td valign="bottom">
            <table width="100%" cellpadding="0" cellspacing="0">
              <tr>
                 <td>
                  <Span id="pagetitle">Article Archive</span>
                 </td>
                 <td align="right">
                 <img src="images/articles.jpg" alt="pen and paper"/>
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
            <td width="40">
            </td>
            <td>
                    <br />
                    <span id="pagetitle">
                        <asp:datalist id="DataList1" runat="server" datasourceid="DataSetDataSource1">
                            <itemtemplate>
                            
                                <span id="bluearticletitle">
                                    <a href='<%# "~/" + DataBinder.Eval(Container.DataItem, "url") %>' runat="server"><em><%# DataBinder.Eval(Container.DataItem, "title") %></em></a>
                                </span>
                            
                                <br />
                            
                                <span id="bodytext">
                                    <%# DataBinder.Eval(Container.DataItem, "Description") %>
                                </span>
                                <br /><br />
                            </itemtemplate>
                        </asp:datalist>
                    </span>

                   <asp:datasetdatasource id="DataSetDataSource1" runat="server" datafile="Articles.xml"></asp:datasetdatasource>

            </td>
        </tr>
    </table>
</asp:content>

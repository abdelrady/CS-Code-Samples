<%@ page language="C#" master="~/forumtemplate.master" %>
<script runat="server" language="C#">


</script>

<asp:content id="sitecontent" runat="Server" ContentPlaceHolderId="sitecontent">
    
    <table cellpadding="5" height="100%" width="420px" border="0" bgcolor="white">
        <tbody>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td colspan="4" height="58">
                   
                        <Span id="pagetitle">My Internet Site</span>
                    
                </td>
                <td>
                   
                </td>
            </tr>
            <tr>
                <td ></td>
                <td ></td>
                <td  valign="top" height="150" width="300" colspan="2">
                    <p> <span id="bodytext">
                        This project template enables
                            you to quickly jumpstart the development of Internet web applications using Visual
                            Studio and ASP.NET.
                            <br /><br/>
                            It provides a pre-configured template that includes an Internet security membership
                            system, a site navigation architecture for optimized site layout/organization, a
                            ad-banner system with impression/clickthrough tracking and reporting, and a master
                            page template design that enables developers to quickly modify the look and feel
                            of a site without recoding.</span>
                        <br />
                        <br />
                </td>
                
                <td valign="top" align="left"><br /><img height="220" src="Images/defaultpicture.jpg" width="185" alt="building under construction" align="top"/></td>
               
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td></td>
                <td colspan="2" valign="top">
                    <table width="300"  cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" background="images/boxbackground.jpg" border="1"
                                    bordercolor="#C2C2C2" width="300">
                                    <tr>
                                        <td>
                                            &nbsp;<span id=articletitle>Articles</span>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table background="images/boxbackgroundblue.jpg" height="1" width="300"
                                    cellpadding="0" cellspacing="0" border="1" bordercolor="#C2C2C2">
                                    <tr>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table cellpadding="0" height="165" cellspacing="0" border="1" width="300pt" bordercolor="#C2C2C2">
                                    <tr>
                                        <td><table bgcolor="white" width="100%" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td valign="top" style="WIDTH: 200px">
                                                        <br />
                                                        <asp:bulletedlist id="Bulletedlist1" datasourceid="Article" displaymode="HyperLink"
                                                            runat="server" datatextfield="title" datavaluefield="url" font-names="Verdana"
                                                            font-size="0.8em" forecolor="Black" bulletstyle="Circle" height="98px" cssclass="underlineanchor" />
                                                        <asp:datasetdatasource id="Article" runat="server" datafile="articles/articles.xml" />
                                                    </td>
                                                    <td valign="bottom" >
                                                        
                                                        <table border="0"  align="left">
                                                            <tr valign="bottom" >
                                                                <td  align="left">
                                                                    <img src="images/reader.jpg" border="0" alt="man reading"/>&nbsp;
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                
                <td align="right" width="197" valign="top">
                <table width="186" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" background="images/boxbackground.jpg" border="1"
                                    bordercolor="#C2C2C2" width="186">
                                    <tr>
                                        <td>
                                            &nbsp;<span id=LinkTitle>Links</span>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table background="images/boxbackgroundblue.jpg" height="1" width="186"
                                    cellpadding="0" cellspacing="0" border="1" bordercolor="#C2C2C2">
                                    <tr>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" border="0" width="195" bordercolor="#C2C2C2" width="186">
                                    <tr>
                                        <td width="186" valign="top" >
                                           <table height="165" width="186" border="1" cellpadding="0" cellspacing="0">
                                                <tr><td valign="middle" id="UnderlineAnchor" style="WIDTH: 182px" > 
                                                        <asp:bulletedlist id="Bulletedlist2" datasourceid="Links" displaymode="HyperLink"
                                                         runat="server" datatextfield="title" datavaluefield="url" font-names="Verdana"
                                                         font-size="0.8em" font-underline="true" forecolor="Black" bulletstyle="CustomImage" width="130px" height="109px" bulletimageurl="images/bullet.gif" cssclass="underlineanchor" />
                                                        <asp:datasetdatasource id="Links" runat="server" datafile="data/toplinks.xml" /></td>
                                                </tr>
                                            </table></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    
                </td>
            </tr>
             <tr>
                <td>
                 
                </td>
                <td style="WIDTH: 1px">
              
                </td>
                
                <td colspan="3">
  
                </td>
               
             </tr>
        </tbody>
    </table>
    
    <br />
    <br />
    
</asp:content>

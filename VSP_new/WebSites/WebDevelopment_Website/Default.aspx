<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server"></asp:Label><br />
    <div class="paddedcell content">
    <table style="width: 463px; height: 174px">
        <tr>
            <td>
            <div id="splashleftcol">
<div id="splashtext">
<img alt="Welcome to CareerFCIS.com" src="images/image1.jpg"><div>
With thousands of new jobs posted every day and thousands of employers
searching for candidates just like you. CareerFCIS.com offers you one
convenient source for career information, including personalized search
agents, automatic matching of jobs against resume, and expert advice on
all aspects of your job hunt. </div>
</div>
<div id="splashresume">
<div class="splashboxheader">
<img src="images/postresumehead.gif"></div>
<div class="splashboxbody">
<img src="images/splash_resume2.gif"><div class="splashboxbodytext">
                        Make it easy for employers to find you by posting your resume online.
                    </div>
<a href="employeereg.aspx">Post Your Resume Now »</a>
</div>
<div class="splashboxfooter">
<img src="images/postresumefoot.gif"></div>
</div>
<div id="splashcprofiles">
<div class="splashboxheader">
<img src="images/compprofileshead.gif"></div>
<div class="splashboxbody">
<div style="width: 340px;" class="splashboxbodytext">
                        This month's featured profile is FCIS Group.
                    </div>
<a href="contactus.aspx">See all company profiles »</a>
</div>
<div class="splashboxfooter">
<img src="images/compprofilesfoot.gif"></div>
</div>
</div>
            </td>
            <td>
            <div id="splashrightcol">
<div id="splashquicksearch">
<div class="splashboxheader">
<map name="helplink" id="helplink"><area onclick="javascript:popup(this.href, 350, 450, 'AboutSearch');return false;" href="Help.aspx" alt="Click for Help" coords="316,12,341,36" shape="rect">

</map>
<img usemap="#helplink" src="images/searchboxhead.gif" border="0"></div>
<div class="splashboxbody">
    
<label>Keyword:<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></label><label>Category:</label><asp:DropDownList
        ID="DropDownList1" runat="server" Width="236px">
        <asp:ListItem>Computer System</asp:ListItem>
        <asp:ListItem>Education</asp:ListItem>
        <asp:ListItem>Agriculture</asp:ListItem>
        <asp:ListItem>Commerce</asp:ListItem>
        <asp:ListItem>Engineering</asp:ListItem>
        <asp:ListItem>Other</asp:ListItem>
    </asp:DropDownList>
<div class="cityanchor">
<label class="cityanchor">
    Country:</label>
    <asp:DropDownList ID="DropDownList2" runat="server" Width="231px">
        <asp:ListItem>Egypt</asp:ListItem>
        <asp:ListItem>Saudi</asp:ListItem>
        <asp:ListItem>Qatar</asp:ListItem>
        <asp:ListItem>USA</asp:ListItem>
        <asp:ListItem>UK</asp:ListItem>
        <asp:ListItem>UAE</asp:ListItem>
    </asp:DropDownList></div>
<div style="clear: both; height: 1px;"></div>
<div class="quicksearchlinks">
<a href="Employers_Search.aspx">Click Here for Advanced Search »</a>
</div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/searchbutton.gif"
            OnClick="ImageButton1_Click" />&nbsp;
<div style="height: 3px;"></div>
</div>
<div class="splashboxfooter">
<img src="images/searchboxfoot.gif"></div>
</div>
<div id="splashctools">
<div class="splashboxheader">
<img src="images/careertoolshead.gif"></div>
<div style="background-color: transparent;" class="splashboxbody">
<div style="width: 340px;" class="splashboxbodytext">
                        Use our tools to make finding your next job even easier.
                    </div>
</div>
<div class="splashboxfooter">
<img src="images/careertoolsfoot.gif"></div>
</div>
</div>
            </td>
        </tr>
        
    </table>
    <br />
    




</div>
</asp:Content>


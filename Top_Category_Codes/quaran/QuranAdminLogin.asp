<!--#Include File="QuranConfig.asp"-->
<%
if Request.ServerVariables("Request_Method")="POST" Then
	Dim LID,LPws
	Lid=Request.Form("LoginID")
	LPws=Request.Form("LoginPWS")
	If LID=LoginID And StrComp(LPws,LoginPws,0)=0 Then
	Session("QuranAdmin")=True
	isAdmin=Session("QuranAdmin")
	Response.Redirect "QuranAdmin.asp"
	End if
	
End if
%>

<%
PageTitle=" ÕÝÍÉ ÇבÏÎזב ÈÑהÇדÌ ÇבÞÑÂה Çב‗Ñםד בבזםÈ "
ShowHeader
%>
<p>
<FORM name=QuranAdminLogin Method=POST Action=QuranAdminLogin.asp>
ÇÓד ÇבÏÎזב:<INPUT type="text" name=LogInID size="20"><BR>
‗בדÉ ÇבדÑזÑ:<INPUT type="password" name=LoginPws size="20"><BR>
<INPUT type="submit" value="ÏÎזב" id=submit1 name=submit1>
</FORM>
</p>
<%ShowFooter%>
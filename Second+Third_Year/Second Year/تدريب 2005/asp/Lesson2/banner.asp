<%
'*****************************************************
'* Code written by Alexander Haneng (C) 1998-2001    *
'* FREE download from http://www.haneng.com/         *
'*****************************************************

RANDOMIZE
LowestNumber = 1
HighestNumber = 10
RandomNumber = INT((HighestNumber-LowestNumber+1)*Rnd+LowestNumber)
SELECT CASE RandomNumber
CASE "1"%>
<A HREF="link1.htm"><IMG SRC="banner1.gif" BORDER=0></A>
<%CASE "2"%>
<A HREF="link2.htm"><IMG SRC="banner2.gif" BORDER=0></A>
<%CASE "3"%>
<A HREF="link3.htm"><IMG SRC="banner3.gif" BORDER=0></A>
<%CASE "4"%>
<A HREF="link4.htm"><IMG SRC="banner4.gif" BORDER=0></A>
<%CASE "5"%>
<A HREF="link5.htm"><IMG SRC="banner5.gif" BORDER=0></A>
<%CASE "6"%>
<A HREF="link6.htm"><IMG SRC="banner6.gif" BORDER=0></A>
<%CASE "7"%>
<A HREF="link7.htm"><IMG SRC="banner7.gif" BORDER=0></A>
<%CASE "8"%>
<A HREF="link8.htm"><IMG SRC="banner8.gif" BORDER=0></A>
<%CASE "9"%>
<A HREF="link9.htm"><IMG SRC="banner9.gif" BORDER=0></A>
<%CASE "10"%>
<A HREF="link10.htm"><IMG SRC="banner10.gif" BORDER=0></A>
<%END SELECT%>  
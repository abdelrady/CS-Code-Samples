<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html dir="rtl">

<head>
</head>
<BODY background="">
<p align=right>
<TABLE align=right border=0>
  
  <TR>
    <TD align=middle>&nbsp;
      <P>&nbsp;</P>
      <P>&nbsp;</P>
      <P>&nbsp;</P>
      <P>&nbsp;</P>
      <P>&nbsp;</P>
      <P>&nbsp;</P></TD>
    <TD>
      <TABLE height=269>
        
        <TR>
          <TD align=right><FONT size=4><B>
            <MARQUEE behavior=alternate width=400>���� ��� �� ���� ����� ������ 
            ��������� ����&nbsp;</MARQUEE></B></FONT>
            <HR align=right width=450 color=#d2b85b SIZE=1>
          </TD></TR>
        <TR>
          <TD align=right><FONT color=#d5404f>�<SPAN 
            lang=ar-eg><B>���</B></SPAN><I><B> ��� �� ���� ����� ������ ������ 
            <BR>��� ������ ���� ���� �������� ������� ������ ��������� ��������� 
            �� �� ������ </B></I><B><BR>�� ����� ��� ���� ������� ���������� 
            �������� ��� ���� ����� ��������� ���� <I>����� ��� ���� 
            �������</I></B></FONT>
            <P align=center><FONT color=#0000ff><B><A 
            href="mailto:elzehor_prepschool@yahoo.com">elzehor_prepschool@yahoo.com<BR></A><A 
            href="mailto:elzehor_prepschool@hotmail.com">elzehor_prepschool@hotmail.com</B></FONT></A></P></TD></TR>
        <TR>
          <TD align=right>

<table border=0 bordercolor=lightblue width=500 height=200>
<tr><td>
<form method=post action="login.asp" name=b>
<font size=3 color=aqua><B>
&nbsp;�����:&nbsp;&nbsp;&nbsp;
<input type=text name=userid size="27">
<br>
���� ������:
<input type=password name=userpassword>
</b></font>
<br>
<input type=submit name=submit value=����>
</form>


			</TD></TR></TABLE></TD></TR></TABLE>
	<%
Set objRotate=Server.CreateObject("MSWC.AdRotator")
objRotate.Border=0
objRotate.Clickable=false
RotateHTML=objRotate.GetAdvertisement("layer1.txt")
Response.Write(RotateHTML)
%></P>


</BODY>
</html>

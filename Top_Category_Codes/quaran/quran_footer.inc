<%
Dim FooterString
Dim FooterTempaltes(1)
Dim RandNum
FooterTempaltes(0)=Array(" ≈цдшу« дуЌъдх ду“шубъду« Џубунъяу «бъёх—ъ¬ду  уд“цнб«р  ", " [ «б≈д”«д «б¬н… 23] ")
FooterTempaltes(1)=Array(" ≈цдшу« дуЌъдх ду“шубъду« «б–шцяъ—у жу≈цдшу« буех буЌу«Ёцўхжду ", " [ «бЌћ— «б¬н… 9] ")
Randomize
'int((max-min+1)*rnd+min)
RandNum=int((ubound(FooterTempaltes)+1)*rnd)
FooterString=FooterTempaltes(RandNum)
%>
<hr color="#007F00">
<p align="center">
<b>
<font face="AGA Arabesque" color="blue">
]
</font>
<%=FooterString(0)%>
<font face="AGA Arabesque" color="blue">
[
</font>
</b>
<BR>
<%=FooterString(1)%>
</p>
<p align="center"><font face="Simplified Arabic" size="2"><b><span lang="ar-qa">
<a href="http://www.alnoor-world.com/">Џ«бг «бдж—</a></span></b></font></p>

</HTML>
<!--
var soraaNames=new Array();
soraaNames[0]=new Array(1,1,' �������');
soraaNames[1]=new Array(2,2,' ������');
soraaNames[2]=new Array(3,50,' �� �����');
soraaNames[3]=new Array(4,77,' ������');
soraaNames[4]=new Array(5,106,' �������');
soraaNames[5]=new Array(6,128,' �������');
soraaNames[6]=new Array(7,151,' �������');
soraaNames[7]=new Array(8,177,' �������');
soraaNames[8]=new Array(9,187,' ������');
soraaNames[9]=new Array(10,208,' ����');
soraaNames[10]=new Array(11,221,' ���');
soraaNames[11]=new Array(12,235,' ����');
soraaNames[12]=new Array(13,249,' �����');
soraaNames[13]=new Array(14,255,' �������');
soraaNames[14]=new Array(15,262,' �����');
soraaNames[15]=new Array(16,267,' �����');
soraaNames[16]=new Array(17,282,' �������');
soraaNames[17]=new Array(18,293,' �����');
soraaNames[18]=new Array(19,305,' ����');
soraaNames[19]=new Array(20,312,' ��');
soraaNames[20]=new Array(21,322,' ��������');
soraaNames[21]=new Array(22,332,' ����');
soraaNames[22]=new Array(23,342,' ��������');
soraaNames[23]=new Array(24,350,' �����');
soraaNames[24]=new Array(25,359,' �������');
soraaNames[25]=new Array(26,367,' �������');
soraaNames[26]=new Array(27,377,' �����');
soraaNames[27]=new Array(28,385,' �����');
soraaNames[28]=new Array(29,396,' ��������');
soraaNames[29]=new Array(30,404,' �����');
soraaNames[30]=new Array(31,411,' �����');
soraaNames[31]=new Array(32,415,' ������');
soraaNames[32]=new Array(33,418,' �������');
soraaNames[33]=new Array(34,428,' ���');
soraaNames[34]=new Array(35,434,' ����');
soraaNames[35]=new Array(36,440,' ��');
soraaNames[36]=new Array(37,446,' �������');
soraaNames[37]=new Array(38,453,' �');
soraaNames[38]=new Array(39,458,' �����');
soraaNames[39]=new Array(40,467,' ����');
soraaNames[40]=new Array(41,477,' ����');
soraaNames[41]=new Array(42,483,' ������');
soraaNames[42]=new Array(43,489,' ������');
soraaNames[43]=new Array(44,496,' ������');
soraaNames[44]=new Array(45,499,' �������');
soraaNames[45]=new Array(46,502,' �������');
soraaNames[46]=new Array(47,507,' ����');
soraaNames[47]=new Array(48,511,' �����');
soraaNames[48]=new Array(49,515,' �������');
soraaNames[49]=new Array(50,518,' �');
soraaNames[50]=new Array(51,520,' ��������');
soraaNames[51]=new Array(52,523,' �����');
soraaNames[52]=new Array(53,526,' �����');
soraaNames[53]=new Array(54,528,' �����');
soraaNames[54]=new Array(55,531,' ������');
soraaNames[55]=new Array(56,534,' �������');
soraaNames[56]=new Array(57,537,' ������');
soraaNames[57]=new Array(58,542,' ��������');
soraaNames[58]=new Array(59,545,' �����');
soraaNames[59]=new Array(60,549,' ��������');
soraaNames[60]=new Array(61,551,' ����');
soraaNames[61]=new Array(62,553,' ������');
soraaNames[62]=new Array(63,554,' ���������');
soraaNames[63]=new Array(64,556,' �������');
soraaNames[64]=new Array(65,558,' ������');
soraaNames[65]=new Array(66,560,' �������');
soraaNames[66]=new Array(67,562,' �����');
soraaNames[67]=new Array(68,564,' �����');
soraaNames[68]=new Array(69,566,' ������');
soraaNames[69]=new Array(70,568,' �������');
soraaNames[70]=new Array(71,570,' ���');
soraaNames[71]=new Array(72,572,' ����');
soraaNames[72]=new Array(73,574,' ���������');
soraaNames[73]=new Array(74,575,' �������');
soraaNames[74]=new Array(75,577,' �������');
soraaNames[75]=new Array(76,578,' �������');
soraaNames[76]=new Array(77,580,' ��������');
soraaNames[77]=new Array(78,582,' �����');
soraaNames[78]=new Array(79,583,' ��������');
soraaNames[79]=new Array(80,585,' ���');
soraaNames[80]=new Array(81,586,' �������');
soraaNames[81]=new Array(82,587,' ��������');
soraaNames[82]=new Array(83,587,' ��������');
soraaNames[83]=new Array(84,589,'��������');
soraaNames[84]=new Array(85,590,' ������');
soraaNames[85]=new Array(86,591,' ������');
soraaNames[86]=new Array(87,591,' ������');
soraaNames[87]=new Array(88,592,' �������');
soraaNames[88]=new Array(89,593,' �����');
soraaNames[89]=new Array(90,594,' �����');
soraaNames[90]=new Array(91,595,' �����');
soraaNames[91]=new Array(92,595,' �����');
soraaNames[92]=new Array(93,596,' �����');
soraaNames[93]=new Array(94,596,' �����');
soraaNames[94]=new Array(95,597,' �����');
soraaNames[95]=new Array(96,597,' �����');
soraaNames[96]=new Array(97,598,' �����');
soraaNames[97]=new Array(98,598,' ������');
soraaNames[98]=new Array(99,599,' �������');
soraaNames[99]=new Array(100,599,' ��������');
soraaNames[100]=new Array(101,600,' �������');
soraaNames[101]=new Array(102,600,' �������');
soraaNames[102]=new Array(103,601,' �����');
soraaNames[103]=new Array(104,601,' ���������');
soraaNames[104]=new Array(105,601,' �����');
soraaNames[105]=new Array(106,602,' ����');
soraaNames[106]=new Array(107,602,' �������');
soraaNames[107]=new Array(108,602,' ������');
soraaNames[108]=new Array(109,603,' ��������');
soraaNames[109]=new Array(110,603,' �����');
soraaNames[110]=new Array(111,603,' �����');
soraaNames[111]=new Array(112,604,' �������');
soraaNames[112]=new Array(113,604,' �����');
soraaNames[113]=new Array(114,604,' �����');
// SoraaNO,PageNO,SoraaName

function SoraaNamesSelectByPageNO(curPage){
var html="<FORM name=QuranForm action=Quran.asp method=get>"
var selected=""
	html+="���� ���:"
	html+="<SELECT name=page onChange=\"if(!isNaN(this.value))location.href='quran.asp?page='+this.value;\" >"
	for (var i=0;i<=soraaNames.length-1;i++){
	if(curPage==soraaNames[i][1]) 
		{selected=" selected"}
	else
		{selected=""}
		html+="<option "+selected+ " class=\"soraa_op\" value="+soraaNames[i][1]+">"+soraaNames[i][2]+""
	}
html+="</select></form>"
	return(html)
}

function SoraaNamesSelectByID(){
var  html="<SELECT multiple name=soraaNo size=5 >"
	for (var i=0;i<=soraaNames.length-1;i++){
 	html+="<option "+" class=\"soraa_op\" value="+soraaNames[i][0]+">"+soraaNames[i][2]+""
	}
html+="</select>"
	return(html)
}

function SoraaNamesSelectByID_Admin(id){
var selected=""
var  html="<SELECT name=soraaNo size=1 >"
	for (var i=0;i<=soraaNames.length-1;i++){
	if(soraaNames[i][0]==id) {selected="selected"} else {selected=""}
 	html+="<option "+selected+" class=\"soraa_op\" value="+soraaNames[i][0]+">"+soraaNames[i][2]+""
	}
html+="</select>"
	return(html)
}

function SoraaNamesSelectByID_admin(SelectedSorah){
var isSelected=""
var  html="<SELECT multiple name=soraaNo size=5 ><OPTION value=0> �� ����� </OPTION>"
	for (var i=0;i<=soraaNames.length-1;i++){
		for (var ii=0;ii<=SelectedSorah.length-1;ii++){
		if(SelectedSorah[ii]>0){
		 if(soraaNames[i][0]==SelectedSorah[ii]) {
			isSelected="selected"
			ii=SelectedSorah.length-1}
		 else{isSelected=""}}
		}
 	html+="<option "+isSelected+" class=\"soraa_op\" value="+soraaNames[i][0]+">"+soraaNames[i][2]+""
	}
html+="</select>"
	return(html)
}



function SoraaNamesGetByID_admin(SelectedSorah){
var  html=" ������� ����� : <BR> "
if(SelectedSorah[0]>0){
	for (var i=0;i<=soraaNames.length-1;i++){
		for (var ii=0;ii<=SelectedSorah.length-1;ii++){
			if(SelectedSorah[ii]>0){
			 if(soraaNames[i][0]==SelectedSorah[ii]) {
			if (i>0)html+=","
			html+="<A href='#soraa_"+soraaNames[i][0]+"'>" +soraaNames[i][2]+"</A>" }
			}
		}
	}
}
else{
html+=" ���� ����� "
}
	return(html)
}

	// Navigation
function goToPageForm(){
var html=	"<FORM name=QuranForm action=Quran.asp method=get>"
       	+" ���� ��� ������: "
	+"<INPUT name=page style=\"WIDTH: 37px; HEIGHT: 22px\" size=5>"
	+"<INPUT type=\"submit\" value=\"�����\" >"
	+"</FORM>"
document.write(html)
}
function navigation(){
	if(PageNO==null){PageNO=1}
	var url="quran.asp?page="
	var _1st_page=1
	var prev_page=PageNO-1
	var next_page=PageNO+1
	var last_page=604
	if(prev_page<=0){prev_page=1}

	var _1st_page_html="<a title=\" ������ ������ \" href=\""+url+_1st_page +"\"> |&lt;&lt; </a>"
	var prev_page_html="<a title=\" ������ �������\" href=\""+url+prev_page +"\">      &lt; </a>"
	var next_page_html="<a title=\" ������ �������\" href=\""+url+next_page +"\">		 &gt; </a>"
	var last_page_html="<a title=\" ������ �������\" href=\""+url+last_page +"\"> &gt;&gt;| </a>"
	
	var nav_html="<TABLE width=\"100%\">"
				+"<TR>"
				+"<TD align=right>"
				+	_1st_page_html
				+"</TD>"
				+"<TD align=middle>"
				+	prev_page_html
				+"</TD>"
				+"<TD align=middle>"
				+	next_page_html
				+"</TD>"
				+"<TD align=left>"
				+	last_page_html
				+"</TD>"
				+"</TR>"
				+"</TABLE>"
	document.write(nav_html)
}

//-->
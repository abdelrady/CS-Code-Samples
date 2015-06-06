var selectedLayout=get_Cookie("myLayout");var selectedColor=get_Cookie("myColor");if (selectedLayout != null) setStylesheet(selectedLayout,selectedColor);else { if (screen.width<= 800){ chooseStyle('small');}else{ chooseStyle('big');}
}
window.onunload = function unloadEvent()
{var selectedLayout=get_Cookie("myLayout");if(selectedLayout==null)selectedLayout="small";delete_Cookie("myLayout", '/', '');set_Cookie("myLayout",selectedLayout,10);var selectedColor=get_Cookie("myColor");if(selectedColor==null)selectedColor="blue";delete_Cookie("myColor", '/', '');set_Cookie("myColor",selectedColor,10);
var clips = new Array(); clips[0] = "ent"; clips[1] = "sprt"; clips[2] = "eco"; clips[3] = "isl"; clips[4] = "new"; for (i=0;i<clips.length;i++) {var clip= clips[i]; for (var x=1;x<=8;x++) {delete_Cookie(clip+"_"+x, '/', '');} for (var x=8;x>=1;x--) { f=document.getElementById(clip+"_"+x); if(f.style.display=="block") {set_Cookie(clip+"_"+x,"b",10);break }}}}
function GetClipsStatus(){ApplyFontSize(); var clips = new Array(); clips[0] = "ent"; clips[1] = "sprt"; clips[2] = "eco"; clips[3] = "isl"; clips[4] = "new"; for (i=0;i<clips.length;i++){var clip= clips[i]; for (var x=8;x>=1;x--){var value=get_Cookie(clip+"_"+x); if(value == "b") {f=document.getElementById(clip+"_"+x); f.style.display="block"; for (var y=x+1;y<=8;y++)
{f=document.getElementById(clip+"_"+y); f.style.display="none"; }for (var z=x-1;z>=1;z--){f=document.getElementById(clip+"_"+z); f.style.display="block";} if(x==8){s=document.getElementById(clip+"_p"); s.style.display="none";} if(x==1){s=document.getElementById(clip+"_m"); s.style.display="none";} break; }}}}
//function getStatus(){var selectedLayout=get_Cookie("myLayout"); var selectedColor=get_Cookie("myColor"); if (selectedLayout != null) setStylesheet(selectedLayout,selectedColor); else { switch(screen.width){ case 800: chooseStyle('small'); case 1024: chooseStyle('big');}}}
function delete_Cookie(name,path,domain){if (get_Cookie(name)) {document.cookie = name + "=" + ((path) ? "; path=" + path : "") + ((domain) ? "; domain=" + domain : "") + "; expires=Thu, 01-Jan-70 00:00:01 GMT";}}
function plus(clip){/**/ s=document.getElementById(clip+"_m"); if(s.style.display=="none"){s.style.display="block";}/**/for (var x=1;x<=8;x++) {if(document.getElementById(clip+"_"+x)!=null){f=document.getElementById(clip+"_"+x);	if(f.style.display=="none")	{f.style.display="block"; /**/if(x==8){s=document.getElementById(clip+"_p"); s.style.display="none";}/**/ return;}}}}
function Minus(clip){/**/s=document.getElementById(clip+"_p"); if(s.style.display=="none"){s.style.display="block";}/**/for (var x=8;x>1;x--)  {if(document.getElementById(clip+"_"+x)!=null){f=document.getElementById(clip+"_"+x);	if(f.style.display=="block"){f.style.display="none";/**/if(x==2){s=document.getElementById(clip+"_m"); s.style.display="none";}/**/	return;}}}}
function set_Cookie(name, value, days) {
var expireDate = new Date()
var expstring=(typeof days!="undefined")? expireDate.setDate(expireDate.getDate()+parseInt(days)) : expireDate.setDate(expireDate.getDate()-5)
document.cookie = name+"="+value+"; expires="+expireDate.toGMTString()+"; path=/";
}function get_Cookie(Name) { 
var re=new RegExp(Name+"=[^;]+", "i"); 
if (document.cookie.match(re)) 
{return document.cookie.match(re)[0].split("=")[1];}
else{return null;}
}function ShowWindow(search,cat,keyword)
{if(keyword.replace(/ /g,"")=="")
{return ;}
var encodeStr=escape(keyword)
var oWnd       
oWnd=window.radopen ("results.aspx?search="+search+"&cat="+cat+"&keyword="+encodeStr,"RadWindow4"); 
}
function ShowNextFrame()
{ctl00_ContentPlaceHolder1_Featured1_RadRotator1.ShowNextFrame();}
function ShowPrevFrame()
{ctl00_ContentPlaceHolder1_Featured1_RadRotator1.ShowPrevFrame();}
function setStylesheet(layout,color) {
var i, cacheobj
for(i=0; (cacheobj=document.getElementsByTagName("link")[i]); i++) 
{
if(cacheobj.getAttribute("rel").indexOf("style") != -1 && cacheobj.getAttribute("title")) {
cacheobj.disabled = true
if(cacheobj.getAttribute("title") == 'default')
cacheobj.disabled = false
if(cacheobj.getAttribute("title") == layout)
cacheobj.disabled = false
if(cacheobj.getAttribute("title") == color)
cacheobj.disabled = false}}}
function chooseStyle(styletitle)
{if (document.getElementById)
{var selectedColor=get_Cookie("myColor");
delete_Cookie("myLayout", '/', '')
delete_Cookie("myColor", '/', '')
setStylesheet(styletitle,selectedColor)
set_Cookie("myLayout",styletitle,10);
set_Cookie("myColor",selectedColor,10);}}
function chooseColor(styleColor)
{if (document.getElementById)
{var selectedLayout=get_Cookie("myLayout");
delete_Cookie("myLayout", '/', '')
delete_Cookie("myColor", '/', '')
setStylesheet(selectedLayout,styleColor)
set_Cookie("myLayout",selectedLayout,10);
set_Cookie("myColor",styleColor,10);}}
function indicateSelected(element){ 
var i
if (selectedLayout!=null && (element.type==undefined || element.type=="select-one")){ 
var element=(element.type=="select-one") ? element.options : element
for (i=0; i<element.length; i++){
if (element[i].value==selectedLayout){ 
if (element[i].tagName=="OPTION")
element[i].selected=true
else 
element[i].checked=true
break}}}}
var min=12;
var max=18;
var normal=16;
function NormalFontSize() {
var body = document.getElementsByTagName('body');
for(i=0;i<body.length;i++) {
body[i].style.fontSize = normal+"px"}
set_Cookie("font",normal,10)
d=document.getElementById('font_p'); if(d.style.display=="none"){d.style.display="inline";} e=document.getElementById('font_m'); if(e.style.display=="none"){e.style.display="inline";}}
function increaseFontSize() {e=document.getElementById('font_m'); if(e.style.display=="none"){e.style.display="inline";}
var body = document.getElementsByTagName('body');
for(i=0;i<body.length;i++) {
if(body[i].style.fontSize) {
var s = parseInt(body[i].style.fontSize.replace("px",""));
} else {var s = 16;}
if(s!=max) {s += 1;}
body[i].style.fontSize = s+"px" ;}
set_Cookie("font",s,10);
if(s==max){d=document.getElementById('font_p'); d.style.display="none"; }}
function decreaseFontSize() { d=document.getElementById('font_p');if(d.style.display=="none"){d.style.display="inline";}
var body = document.getElementsByTagName('body');
for(i=0;i<body.length;i++) {
if(body[i].style.fontSize) {
var s = parseInt(body[i].style.fontSize.replace("px",""));
} else { var s = 16;}if(s!=min){s -= 1;} body[i].style.fontSize = s+"px"}
set_Cookie("font",s,10); if(s==min){e=document.getElementById('font_m'); e.style.display="none"; }}

function ApplyFontSize() { var s=get_Cookie("font"); if (s >= 12 && s <= 18 ){
var body = document.getElementsByTagName('body');
for(i=0;i<body.length;i++) {
body[i].style.fontSize = s+"px"}}
if(s==min){e=document.getElementById('font_m'); e.style.display="none"; } if(s==max){d=document.getElementById('font_p'); d.style.display="none"; }}
//SSO
if (document.getElementById('pnlLock') != null)
{var height,Width;
height = document.body.scrollHeight;
Width = document.body.scrollWidth;
document.getElementById('pnlLock').style.height = height;
document.getElementById('pnlLock').style.width = Width;
var ControlsCount = document.forms[0].elements.length;
var i;var mydropdown;for (i=0;i<ControlsCount;i++){if(document.forms[0].elements[i].type == "select-one"){mydropdown = document.forms[0].elements[i]; document.getElementById(mydropdown.id).style.display = 'none';}}}
function clickButton(e, buttonid){ 
var bt = document.getElementById(buttonid); 
if (typeof bt == 'object'){if(navigator.appName.indexOf("Netscape")>(-1)){if (e.keyCode == 13){bt.click(); return false; }} 
if (navigator.appName.indexOf("Microsoft Internet Explorer")>(-1)){if (event.keyCode == 13){bt.click(); return false;}}}} 
function clickButton(e, buttonid){var bt = document.getElementById(buttonid);if (typeof bt == 'object'){if(navigator.appName.indexOf("Netscape")>(-1)){if (e.keyCode == 13){bt.click(); return false; }}if (navigator.appName.indexOf("Microsoft Internet Explorer")>(-1)){if (event.keyCode == 13){bt.click(); return false; }}}} 
function targem(word){win = window.open('http://torgoman.masrawy.com/scripts/ata/urltrs.dll?lang=arb&atatheme=0&options=abbr&options=translit&urlTarget=' + word)}
function showtable(tblName){document.getElementById("tblOnkosh").style.display ="none";document.getElementById("tblNews").style.display ="none"; document.getElementById("tblClassifieds").style.display ="none"; /*document.getElementById("tblTogoman").style.display ="none";*/ document.getElementById("tblDsl").style.display ="none"; f=document.getElementById(tblName); f.style.display=""; g=document.getElementById('dslCase'); g.value=tblName; }
function func()
{
//alert('start');
t=document.getElementById('ctl00_NHBox1_textTorgoman');
t.value='http://';
if (t.createTextRange)
{var FieldRange = t.createTextRange(); FieldRange.moveStart('character', t.value.length); FieldRange.collapse(); FieldRange.select();}}

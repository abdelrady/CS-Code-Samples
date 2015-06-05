
var ISopera=window.navigator.userAgent.indexOf('Opera')+1;var ISff2=window.navigator.userAgent.indexOf('Firefox')+1;var ISie=window.navigator.userAgent.indexOf('MSIE')+1;var ISsafari=window.navigator.userAgent.indexOf('Safari')+1;var imcCInterval=45000;var imcCDelta=1000;var tpCInterval=20000;var tpCDelta=1000;var tpCTick=0;var tpast=0;var ticktock;var tcount;var tpw_len;var textarea_mon;var offline503=0;var suspended=0;window.onblur=function(){}
window.onfocus=function(){}
function fill_textarea(id,str){var fld=document.getElementById(id);fld.value=unescape(str)+fld.value;}
function post_form(id,url){post_form_to(id,url,pending);}
function post_form_to(id,url,idoutput){var form=document.getElementById(id);pending=idoutput;if(form){var parameters="";var e=form.elements;for(var i=0;i<form.elements.length;i++){var e=form.elements[i];if(e.name&&typeof(e.name)!='undefined'&&typeof(e.value)!='undefined'){if(parameters){parameters=parameters+"&";}
parameters=parameters+e.name+"="+encodeURIComponent(e.value);}}
var req=newXMLHttpRequest();var callbackHandler=inlineajaxUpdate(req,inlineajaxDoit);req.onreadystatechange=callbackHandler;req.open('POST',url,true);req.setRequestHeader("Content-type","application/x-www-form-urlencoded");req.setRequestHeader("Content-length",parameters.length);req.setRequestHeader("Connection","close");req.send(parameters);}else{alert("could not find form");}}
function imc(){var div=document.getElementById("imc_out");if(div){if(imcCInterval>=1800000||offline503||suspended){div.innerHTML=' <small>(<a href="javascript:window.location.reload();">checking disabled</a>)</small>';return;}
var req=newXMLHttpRequest();var callbackHandler=getReadyStateHandler(req,imcUpdate);setTimeout('imc();',imcCInterval);imcCInterval+=imcCDelta;imcCDelta+=5000;req.onreadystatechange=callbackHandler;req.open("GET","/ajax/imc",true);req.send(null);}}
function topic_poll_write(id,url){if(id){textarea_mon=document.getElementById(id);}
var ms=5000;if(textarea_mon&&!offline503&&!suspended){if(textarea_mon.value){var len=textarea_mon.value.length;if(len!=tpw_len){tpw_len=len;var req=newXMLHttpRequest();var callbackHandler=StateHandlerText(req,tpwUpdate);req.onreadystatechange=callbackHandler;req.open("GET",url+"?poll=w",true);req.send(null);ms=5000;}else{ms=15000;}}else{ms=5000;}}
setTimeout('topic_poll_write(null,"'+url+'");',ms);}
function tpwUpdate(txt){}
function topic_poll(cnt,url){if(cnt!=null){tcount=cnt;tpCTick=2000;ticktock=document.getElementById('ticktock');}
tpCTick-=1000;setTimeout('topic_poll(null,"'+url+'");',1000);if(tpCTick<=0){if(tpCInterval<1800000&&!offline503&&!suspended){tpCInterval+=tpCDelta;tpCDelta+=5000;}else{ticktock.innerHTML="(monitoring stopped)";return;}
tpCTick=tpCInterval;var req=newXMLHttpRequest();var callbackHandler=StateHandlerText(req,tpUpdate);req.onreadystatechange=callbackHandler;req.open("GET",url,true);req.send(null);}else{if(((tpCTick/1000%5))==0){ticktock.innerHTML=parseInt(tpCTick/1000)+"";}}}
function tpUpdate(txt){var div=document.getElementById('poll_out');if(div){var regexp=/([0-9]+) ([0-9]+) ([0-9]+)/;var h=regexp.exec(txt);var newtcount=parseInt(h[1]);var online=parseInt(h[2]);var writing=parseInt(h[3]);var str="";var refresh=0;if(newtcount>tcount){var diff=newtcount-tcount+tpast;if(diff>1){str=diff+' new replies!';refresh=tcount+1;}else if(diff==1){str='1 new reply!';refresh=tcount+1;}
var t=document.title;var r=/^(\[.*\])/;var h1=r.exec(t);if(h1){t=t.replace(h1[1],"");}
document.title='['+str+'] '+t;}
if(online>1){str+='&nbsp;'+online+' readers';}
if(writing>1){writing--;str+='&nbsp;'+writing+' other typing';}
if(refresh&&(ISff2||ISie||ISsafari||ISopera)){var nr_div=document.getElementById("newreplies");if(nr_div){var href=window.location+"";if(href.indexOf('forum/r')>0){if(href.indexOf('time=')>0){href=href.replace(/~time=\d+/g,"");}
if(href.indexOf('reverse=')>0){href=href.replace(/~reverse=\d+/g,"");}
if(href.indexOf('start=')>0){href=href.replace(/~start=\d+/g,"");}
if(href.indexOf('#')>0){href=href.replace(/#.*/g,"");}
href=href+"~start="+refresh+"?ajh=1&lprefs=1";inlineajax_add(href,"newreplies");tcount=newtcount;tpast=diff;}}}
if(str){str+="&nbsp;<br>";div.innerHTML=str;tpCInterval=20000;tpCDelta=1000;}}}
var midsShown=new Array();function imcUpdate(xml){var div=document.getElementById("imc_out");if(div!=null){var d=xml.getElementsByTagName("data");var l=d.length;var str='';for(var i=0;i<l;i++){var res=d[i].firstChild.data;str=str+res;}
div.innerHTML=str;makeNiceTitles();}}
function getScrollXY(){var scrOfX=0,scrOfY=0;if(typeof(window.pageYOffset)=='number'){scrOfY=window.pageYOffset;scrOfX=window.pageXOffset;}else if(document.body&&(document.body.scrollLeft||document.body.scrollTop)){scrOfY=document.body.scrollTop;scrOfX=document.body.scrollLeft;}else if(document.documentElement&&(document.documentElement.scrollLeft||document.documentElement.scrollTop)){scrOfY=document.documentElement.scrollTop;scrOfX=document.documentElement.scrollLeft;}
return[scrOfX,scrOfY];}
function popup(e,url){var lnk;if(window.event&&window.event.srcElement){lnk=window.event.srcElement}else if(e&&e.target){lnk=e.target}
if(!lnk)return true;var islayer=0;var mpos=findPosition(lnk);var mx=mpos[0];var my=mpos[1];if(lnk.offsetParent&&lnk.offsetParent.style.position=='fixed'){islayer=1;if(ISopera){var xyscroll=getScrollXY();mx-=xyscroll[0];my-=xyscroll[1];}}
div=document.getElementById("popup_out");if(div){div.relx=mx;div.rely=my;if(islayer){div.style.position='fixed';}else{div.style.position='absolute';}
inlineajax(url,"popup_out");return false;}
return true;}
function silkpanel_page(){obj=document.getElementById("silkpanel");if(obj){var regexp=/page([0-9]+)/;var h=regexp.exec(obj.src);var p=parseInt(h[1]);return p;}
return null;}
function silkpanel_move(delta){obj=document.getElementById("silkpanel");if(obj){var p=silkpanel_page();p+=delta;if(p<1)p=1;if(p>16)p=16;obj.src="http://i.dslr.net/silk/page"+p+".png";}}
function silkpanel_click(e){var lnk;var posx,posy;if(window.event&&window.event.srcElement){lnk=window.event.srcElement}else if(e&&e.target){lnk=e.target}
if(!lnk)return true;var mpos=findPosition(lnk);if(!e){var e=window.event;}
if(lnk.offsetParent&&lnk.offsetParent.style.position=='fixed'){if(ISopera){var po=document.getElementById('popup_out');var xyscroll=getScrollXY();mpos[0]+=(po.relx+15);mpos[1]+=(po.rely+15);mpos[0]-=xyscroll[0];mpos[1]-=xyscroll[1];}else if(document.all&&document.getElementById){var po=document.getElementById('popup_out');mpos[0]+=(po.relx+15);mpos[1]+=(po.rely+15);}}
if(e.clientX||e.clientY){posx=e.clientX;posy=e.clientY;}else if(e.pageX||e.pageY){posx=e.pageX;posy=e.pageY;}
var mx=posx-mpos[0];var my=posy-mpos[1];var p=silkpanel_page();var no=(p-1)*64+parseInt(my/18)*8+parseInt(mx/18);return no;}
function reposition(div){var mx=div.relx;var my=div.rely;if(mx||my){var w=div.clientWidth;var h=div.clientHeight;if(w<30)w=30;var iw=document.clientWidth;var ih=document.clientHeight;if(!ih)ih=document.body.clientHeight;if(!iw)iw=document.body.clientWidth;if(iw){if(mx+w>=iw){mx-=w;}else{mx+=15;}}
if(ih){if(my+h>=ih)my-=h;}
div.style.left=mx+'px';div.style.top=(my+15)+'px';}}
var opac;function layerfade(id){opac=100;setTimeout('layerfadeout("'+id+'")',1000);}
function layerfadeout(id){var div=document.getElementById(id);var ie5=(!ISopera&&document.all&&document.getElementById);var ns6=(!document.all&&document.getElementById&&!div.style.KhtmlOpacity);var kht=(div.style.KhtmlOpacity);opac-=8;if(opac<=0){div.style.visibility='hidden';if(ie5)div.filters.alpha.opacity=100;if(ns6||ISopera)div.style.opacity=1;if(kht)div.style.KhtmlOpacity=1;return;}
setTimeout('layerfadeout("'+id+'")',50);if(ie5)div.filters.alpha.opacity=opac;if(ns6||ISopera)div.style.opacity=opac/100;if(kht)div.style.KhtmlOpacity=opac/100;}
function imfetch(e,mid){var lnk;if(window.event&&window.event.srcElement){lnk=window.event.srcElement}else if(e&&e.target){lnk=e.target}
if(!lnk)return true;var islayer=0;if(lnk.offsetParent&&lnk.offsetParent.style.position=='fixed')islayer=1;var mpos=findPosition(lnk);var mx=mpos[0];var my=mpos[1];div=document.getElementById("im_live_out");if(div){if(islayer){div.style.position='fixed';}else{div.style.position='absolute';}
div.style.left=mx+'px';div.style.top=(my+15)+'px';if(div.style.visibility=='hidden'){div.style.visibility='visible';}
inlineajax("/instant?mid="+mid+"&ajh=1","im_live_out");return false;}
return true;}
function imsend(e,uid,msg){var lnk;if(window.event&&window.event.srcElement){lnk=window.event.srcElement}else if(e&&e.target){lnk=e.target}
if(!lnk)return true;var mpos=findPosition(lnk);var mx=mpos[0];var my=mpos[1];var islayer=0;if(lnk.offsetParent&&lnk.offsetParent.style.position=='fixed'){islayer=1;}
div=document.getElementById("im_live_out");if(div){if(islayer){div.style.position='fixed';}else{div.style.position='absolute';}
div.style.left=mx+'px';div.style.top=(my+15)+'px';if(div.style.visibility=='hidden'){div.style.visibility='visible';}
inlineajax("/instant?ireply="+uid+"&msg="+encodeURIComponent(msg)+"&ajh=1","im_live_out");return false;}
return true;}
function teaser(){var req=newXMLHttpRequest();var callbackHandler=getReadyStateHandler(req,teaserUpdate);req.onreadystatechange=callbackHandler;var div=document.getElementById('teaser_out');div.innerHTML='<center><IMG SRC="http://i.dslr.net/spinner.gif" align=absmiddle width=16 height=16> loading reviews</center>';var b=document.sform.typ.options[document.sform.typ.selectedIndex].text;var c=document.getElementById('zipcode').value;var d=document.getElementById('q').value;var e=document.getElementById('short').value;var f=document.getElementById('coyid').value;var arg="typ="+b+"&zip="+c+"&q="+d+"&short="+e+"&coy="+f;req.open("GET","/ajax/teaser?"+arg,true);req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");req.send(null);}
function teaserUpdate(testXML){var test=testXML.getElementsByTagName("data");var l=test.length;var div=document.getElementById('teaser_out');div.innerHtml='';var str='';for(var i=0;i<l;i++){var res=test[i].firstChild.data;str=str+res;}
div.innerHTML=str;makeNiceTitles();}
function lookup(){var req=newXMLHttpRequest();var callbackHandler=getReadyStateHandler(req,butUpdate);req.onreadystatechange=callbackHandler;var h=document.getElementById("hcheck");var v=h.value;req.open("GET","/ajax/ishandleok?handle="+v,true);req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");req.send("");}
function butUpdate(testXML){var test=testXML.getElementsByTagName("handle")[0];var res=test.getAttribute("res");var but=document.getElementById('isfree');but.value=res;}
function ticker_toggle(id,con,coff){var handle=document.getElementById(id);var togval=document.getElementById("t"+id);if(togval.value==1){handle.style.backgroundColor=coff;togval.value=0;}else{handle.style.backgroundColor=con;togval.value=1;}}
function tick(delta){var req=newXMLHttpRequest();var callbackHandler=getReadyStateHandler(req,tickUpdate);req.onreadystatechange=callbackHandler;var handle=document.getElementById("id");var v=parseInt(handle.value);handle.value=v;var cats="";for(var i=1;i<3;i++){var h=document.getElementById("t"+i);if(h.value==1){cats=cats+","+i;}}
req.open("GET","/ajax/ticker?id="+v+"&delta="+delta+"&cats="+cats,true);req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");req.send("");}
function tickUpdate(testXML){var test=testXML.getElementsByTagName("ticker")[0];var res=test.getAttribute("html");var id=test.getAttribute("id");var handle=document.getElementById("id");handle.value=parseInt(id);var s=document.getElementById('ticker_html');s.innerHTML=res;}
var pending_status_check;function kicksubmit(){pending_status_check=0;document.getElementById('uploadbtn').disabled=true;document.myform.submit();self.setTimeout("uploadstatus()",1000);}
function uploadstatus(){if(pending_status_check){return;}
var req=newXMLHttpRequest();var callbackHandler=getReadyStateHandler(req,uploadFeedback);req.onreadystatechange=callbackHandler;var tagf=document.getElementById("tag");var tag=tagf.value;req.open("GET","/r0/upload?xml=1&tag="+tag,true);req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");req.send("tag="+tag);pending_status_check=1;}
var lastPing=0;function uploadFeedback(testXML){var test=testXML.getElementsByTagName("test")[0];var message=testXML.getElementsByTagName("message")[0];var nof=testXML.getElementsByTagName("nof")[0];var nofv=nof.firstChild.nodeValue;var x;pending_status_check=0;var timestamp=test.getAttribute("timestamp");if(timestamp>lastPing){lastPing=timestamp;for(x=1;x<=4;x++){var e=testXML.getElementsByTagName("fn"+x)[0];var v=e.getAttribute("name");var f=document.getElementById("fn"+x);if(f){var chk=f.innerHTML;if(chk!=v){f.innerHTML=v;}}}
var pcf=testXML.getElementsByTagName("pc")[0];var msf=testXML.getElementsByTagName("ms")[0];if(pcf!=null&&msf!=null){var pc=pcf.firstChild.nodeValue;var ms=msf.firstChild.nodeValue;var message_value=message.firstChild.nodeValue;var msg_display=document.getElementById("msg_display");msg_display.innerHTML=message_value;if(pc==100){msg_display.innerHTML="Complete! One moment..";self.setTimeout("uploadfinish()",1000);}else{self.setTimeout("uploadstatus()",ms);}}else{self.setTimeout("uploadstatus()",5000);}}}
function uploadfinish(){var msg_display=document.getElementById("msg_display");msg_display.innerHTML="Complete! One moment..";document.getElementById('uploadbtn').disabled=false;var sf=document.getElementById("subform");if(sf!=null){sf.submit();}
var pf=document.getElementById("pform");if(pf!=null){pf.submit();}}
function newXMLHttpRequest(){var xmlreq=false;if(window.XMLHttpRequest){xmlreq=new XMLHttpRequest();}else if(window.ActiveXObject){try{xmlreq=new ActiveXObject("Msxml2.XMLHTTP");}catch(e1){try{xmlreq=new ActiveXObject("Microsoft.XMLHTTP");}catch(e2){}}}
return xmlreq;}
function getReadyStateHandler(req,responseXmlHandler){return function(){try{if(req.readyState==4){if(req.status==200){responseXmlHandler(req.responseXML);}else if(req.status==503){offline503=1;}}}catch(e){}}}
function StateHandlerText(req,fn){return function(){try{if(req.readyState==4){if(req.status==200){fn(req.responseText);}else if(req.status==503){offline503=1;}}}catch(e){}}}
function inlineajax_add(url,md5){inlineajax_base(url,md5,1);}
function inlineajax(url,md5){inlineajax_base(url,md5,0);}
function inlineajax_base(url,md5,add){var req=newXMLHttpRequest();var callbackHandler;if(add){callbackHandler=inlineajaxUpdate(req,inlineajaxDoit_add);}else{callbackHandler=inlineajaxUpdate(req,inlineajaxDoit);}
req.onreadystatechange=callbackHandler;pending=md5;var div=document.getElementById(md5);if(!add){div.innerHTML='<IMG SRC="http://i.dslr.net/spinner.gif" align=absmiddle width=16 height=16 alt="please wait">';}
if(div.style.display=='none'){div.style.display='block';}
if(div.style.visibility=='hidden'){div.style.visibility='visible';}
reposition(div);req.open("GET",url,true);try{req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");}catch(e2){}
try{req.overrideMimeType('text/html');}catch(e2){}
req.send(null);}
function inlineajaxDoit_add(html){var div=document.getElementById(pending);if(div){if(html&&html.length>0){div.innerHTML+=html;}}}
function inlineajaxDoit(html){var div=document.getElementById(pending);if(div){if(html&&html.length>0){div.innerHTML=html;reposition(div);if(div.style.display=="none"){div.style.display="block";Fat.fade_element(pending,10,1000,null);}}else{div.style.visibility='hidden';}
div=document.getElementById(pending+".link");if(div){div.innerHTML="";}}}
function inlineajaxUpdate(req,fn){return function(){try{if(req.readyState==4){if(req.status==200){fn(req.responseText);}else if(req.status){var div=document.getElementById(pending);div.innerHTML="Request error: "+req.status;}else{fn(null);}
pending=null;}}catch(e){}}}
function quickHelp(which){file="/"+which;newWin=window.open(file,"NewWin",'toolbar=0,location=0,directories=0,status=0,menubar=0,scrollbars=1,width=450,height=500,resizable=1');newWin.creator=self}
var MSG_ANNOTATION_SAVING='Saving..';var MSG_ANNOTATION_SAVED='Saved!';var MSG_UNKNOWN_ERROR='Error';var MSG_RATING_POOR='Poor';var MSG_RATING_POOR_SHORT='Poor';var MSG_RATING_BELOW_AVERAGE='Below Average';var MSG_RATING_BELOW_AVERAGE_SHORT='Below Avg';var MSG_RATING_AVERAGE='Average';var MSG_RATING_AVERAGE_SHORT='Average';var MSG_RATING_ABOVE_AVERAGE='Above Average';var MSG_RATING_ABOVE_AVERAGE_SHORT='Above Avg';var MSG_RATING_EXCELLENT='Excellent!';var MSG_RATING_EXCELLENT_SHORT='Excellent!';function area_toggle(i,i1)
{if(document.getElementById(i).style.display=="none"){document.getElementById(i).style.display="block";document.getElementById(i1).style.display="none";}else{Fat.fade_element(i1,10,1000,null);document.getElementById(i).style.display="none";document.getElementById(i1).style.display="block";}}
function doin_toggle(){if(document.getElementById('doin').style.display=="none"){document.getElementById('doin').style.display="inline";document.getElementById('undoin').style.display="none";}else{document.getElementById('doin').style.display="none";document.getElementById('undoin').style.display="inline";}}
function doin_submit(){var req=newXMLHttpRequest();var b=document.getElementById('doinstr').value;var o=document.getElementById('doinout');o.innerHTML=b;var arg="s="+encodeURIComponent(b);req.open("GET","/doing?"+arg,true);req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");req.send(null);}
var Fat={make_hex:function(r,g,b)
{r=r.toString(16);if(r.length==1)r='0'+r;g=g.toString(16);if(g.length==1)g='0'+g;b=b.toString(16);if(b.length==1)b='0'+b;return"#"+r+g+b;},fade_element:function(id,fps,duration,from,to)
{if(!fps)fps=30;if(!duration)duration=3000;if(!from||from=="#"){var bg=this.get_bgcolor(id);var isrgb=bg.indexOf('rgba')+1;var i;if(isrgb){i=parseInt(bg.substr(5,3),16);}else{i=parseInt(bg.substr(1,2),16);}
if(i<=128){from="#333300";}else{from="#FFFF33";}}
var rt,gt,bt;if(!to)to=this.get_bgcolor(id);if(to.indexOf('rgba(')+1){var regexp=/rgba\(([0-9]+), ([0-9]+), ([0-9]+),/;var h=regexp.exec(to);rt=parseInt(h[1]);gt=parseInt(h[2]);bt=parseInt(h[3]);}else{if(to.length<7)to+=to.substr(1,3);rt=parseInt(to.substr(1,2),16);gt=parseInt(to.substr(3,2),16);bt=parseInt(to.substr(5,2),16);}
var frames=Math.round(fps*(duration/1000));var interval=duration/frames;var delay=interval;var frame=0;if(from.length<7)from+=from.substr(1,3);var rf=parseInt(from.substr(1,2),16);var gf=parseInt(from.substr(3,2),16);var bf=parseInt(from.substr(5,2),16);var r,g,b,h;Fat.set_bgcolor(id,from);while(frame<frames){r=Math.floor(rf*((frames-frame)/frames)+rt*(frame/frames));g=Math.floor(gf*((frames-frame)/frames)+gt*(frame/frames));b=Math.floor(bf*((frames-frame)/frames)+bt*(frame/frames));h=this.make_hex(r,g,b);setTimeout("Fat.set_bgcolor('"+id+"','"+h+"')",delay);frame++;delay=interval*frame;}
setTimeout("Fat.set_bgcolor('"+id+"','"+to+"')",delay);},set_bgcolor:function(id,c)
{var o=document.getElementById(id);o.style.backgroundColor=c;},get_bgcolor:function(id)
{var o=document.getElementById(id);while(o)
{var c;if(window.getComputedStyle)c=window.getComputedStyle(o,null).getPropertyValue("background-color");if(o.currentStyle)c=o.currentStyle.backgroundColor;if((c!=""&&c!="transparent")&&o.tagName=="BODY"){break;}
o=o.parentNode;}
if(c==undefined||c==""||c=="transparent")c="#FFFFFF";var rgb=c.match(/rgb\s*\(\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*\)/);if(rgb)c=this.make_hex(parseInt(rgb[1]),parseInt(rgb[2]),parseInt(rgb[3]));return c;}}
function Browser(){var ua,s,i;this.isIE=false;this.isNS=false;this.version=null;ua=navigator.userAgent;s="MSIE";if((i=ua.indexOf(s))>=0){this.isIE=true;this.version=parseFloat(ua.substr(i+s.length));return;}
s="Netscape6/";if((i=ua.indexOf(s))>=0){this.isNS=true;this.version=parseFloat(ua.substr(i+s.length));return;}
s="Gecko";if((i=ua.indexOf(s))>=0){this.isNS=true;this.version=6.1;return;}}
var browser=new Browser();var dragObj=new Object();dragObj.zIndex=0;function dragStart(event,id){var el;var x,y;if(id)
dragObj.elNode=document.getElementById(id);else{if(browser.isIE)
dragObj.elNode=window.event.srcElement;if(browser.isNS)
dragObj.elNode=event.target;if(dragObj.elNode.nodeType==3)
dragObj.elNode=dragObj.elNode.parentNode;}
if(browser.isIE){x=window.event.clientX+document.documentElement.scrollLeft
+document.body.scrollLeft;y=window.event.clientY+document.documentElement.scrollTop
+document.body.scrollTop;}
if(browser.isNS){x=event.clientX+window.scrollX;y=event.clientY+window.scrollY;}
dragObj.cursorStartX=x;dragObj.cursorStartY=y;dragObj.elStartLeft=parseInt(dragObj.elNode.style.left,10);dragObj.elStartTop=parseInt(dragObj.elNode.style.top,10);if(isNaN(dragObj.elStartLeft))dragObj.elStartLeft=0;if(isNaN(dragObj.elStartTop))dragObj.elStartTop=0;dragObj.elNode.style.zIndex=++dragObj.zIndex;if(browser.isIE){document.attachEvent("onmousemove",dragGo);document.attachEvent("onmouseup",dragStop);window.event.cancelBubble=true;window.event.returnValue=false;}
if(browser.isNS){document.addEventListener("mousemove",dragGo,true);document.addEventListener("mouseup",dragStop,true);event.preventDefault();}}
function dragGo(event){var x,y;if(browser.isIE){x=window.event.clientX+document.documentElement.scrollLeft
+document.body.scrollLeft;y=window.event.clientY+document.documentElement.scrollTop
+document.body.scrollTop;}
if(browser.isNS){x=event.clientX+window.scrollX;y=event.clientY+window.scrollY;}
dragObj.elNode.style.left=(dragObj.elStartLeft+x-dragObj.cursorStartX)+"px";dragObj.elNode.style.top=(dragObj.elStartTop+y-dragObj.cursorStartY)+"px";if(browser.isIE){window.event.cancelBubble=true;window.event.returnValue=false;}
if(browser.isNS)
event.preventDefault();}
function dragStop(event){if(browser.isIE){document.detachEvent("onmousemove",dragGo);document.detachEvent("onmouseup",dragStop);}
if(browser.isNS){document.removeEventListener("mousemove",dragGo,true);document.removeEventListener("mouseup",dragStop,true);}}
function Tabber(target){typeof target=="object"?this.element=target:this.element=document.getElementById(target);if(!this.element)return false;this.ul=this.element.getElementsByTagName("ul")[0];this.tabs=this.ul.getElementsByTagName("li");this.tabContent=this.getTabContent();this.bind();}
Tabber.prototype.getTabContent=function(){tabContent=new Array();this.divs=this.element.getElementsByTagName("div");for(var i=0;i<this.divs.length;i++){if(/tabContent/i.test(this.divs[i].className)){tabContent.push(this.divs[i]);}}
return tabContent;}
Tabber.prototype.bind=function(){var o=this;for(var i=0;i<this.tabs.length;i++){this.tabs[i].onclick=function(){if(this.className!='selected'){o.open(this);return false;var a=this.getElementsByTagName("a")[0];if(a)a.onclick=function(){return false;}}}}}
Tabber.prototype.open=function(caller){for(var i=0;i<this.tabs.length;i++){var tab=this.tabs[i];if(tab==caller){this.collapse();tab.className="selected"
this.tabContent[i].style.display="block";}}}
Tabber.prototype.collapse=function(){for(var i=0;i<this.tabs.length;i++){this.tabs[i].className="";this.tabContent[i].style.display="none";}}

addEvent(window,"load",makeNiceTitles);var XHTMLNS="http://www.w3.org/1999/xhtml";var CURRENT_NICE_TITLE;var browser=new Browser();function makeNiceTitles(){if(!document.createElement||!document.getElementsByTagName)return;if(!document.createElementNS)
{document.createElementNS=function(ns,elt){return document.createElement(elt);}}
if(!document.links)
{document.links=document.getElementsByTagName("a");}
for(var ti=0;ti<document.links.length;ti++){var lnk=document.links[ti];if(lnk.title&&lnk.id.toLowerCase()=='nt'){lnk.setAttribute("nicetitle",lnk.title);lnk.removeAttribute("title");addEvent(lnk,"mouseover",snt);addEvent(lnk,"mouseout",hnt);addEvent(lnk,"focus",snt);addEvent(lnk,"blur",hnt);}}}
function findPosition(oLink){if(oLink.offsetParent){for(var posX=0,posY=0;oLink.offsetParent;oLink=oLink.offsetParent){posX+=oLink.offsetLeft;posY+=oLink.offsetTop;}
return[posX,posY];}else{return[oLink.x,oLink.y];}}
function snt(e){if(CURRENT_NICE_TITLE)hnt(CURRENT_NICE_TITLE);if(!document.getElementsByTagName)return;if(window.event&&window.event.srcElement){lnk=window.event.srcElement}else if(e&&e.target){lnk=e.target}
if(!lnk)return;if(lnk.getAttribute("nicetitle")==null){lnk=getParent(lnk,"A");}
if(!lnk)return;nicetitle=lnk.getAttribute("nicetitle");var d=document.createElementNS(XHTMLNS,"div");var viewmode="2";if(viewmode=="1"){d.className="nicetitleav1";w=567;}else{d.className="nicetitle";w=267;}
d.innerHTML="<p classname='titletext'>"+unescape(nicetitle);d.style.width=w+'px';mpos=findPosition(lnk);mx=mpos[0];my=mpos[1];d.style.left=(mx+15)+'px';d.style.top=(my+35)+'px';if(window.innerWidth&&((mx+w)>window.innerWidth)){d.style.left=(window.innerWidth-w-25)+"px";}
if(document.body.scrollWidth&&((mx+w)>document.body.scrollWidth)){d.style.left=(document.body.scrollWidth-w-25)+"px";}
document.getElementsByTagName("body")[0].appendChild(d);CURRENT_NICE_TITLE=d;}
function hnt(e){if(!document.getElementsByTagName)return;if(CURRENT_NICE_TITLE){document.getElementsByTagName("body")[0].removeChild(CURRENT_NICE_TITLE);CURRENT_NICE_TITLE=null;}}
function addEvent(obj,evType,fn){if(obj.addEventListener){obj.addEventListener(evType,fn,false);return true;}else if(obj.attachEvent){var r=obj.attachEvent("on"+evType,fn);return r;}else{return false;}}
function getParent(el,pTagName){if(el==null)return null;else if(el.nodeType==1&&el.tagName.toLowerCase()==pTagName.toLowerCase())
return el;else
return getParent(el.parentNode,pTagName);}
function getMousePosition(event){if(browser.isIE){x=window.event.clientX+document.documentElement.scrollLeft
+document.body.scrollLeft;y=window.event.clientY+document.documentElement.scrollTop
+document.body.scrollTop;}
if(browser.isNS){x=event.clientX+window.scrollX;y=event.clientY+window.scrollY;}
return[x,y];}
function Browser(){var ua,s,i;this.isIE=false;this.isNS=false;this.version=null;ua=navigator.userAgent;s="MSIE";if((i=ua.indexOf(s))>=0){this.isIE=true;this.version=parseFloat(ua.substr(i+s.length));return;}
s="Netscape6/";if((i=ua.indexOf(s))>=0){this.isNS=true;this.version=parseFloat(ua.substr(i+s.length));return;}
s="Gecko";if((i=ua.indexOf(s))>=0){this.isNS=true;this.version=6.1;return;}}
function getCookie(name){var dc=document.cookie;var prefix=name+"=";var begin=dc.indexOf("; "+prefix);if(begin==-1){begin=dc.indexOf(prefix);if(begin!=0){return null;}}else{begin+=2;}
var end=document.cookie.indexOf(";",begin);if(end==-1){end=dc.length;}
return unescape(dc.substring(begin+prefix.length,end));}
var originalFirstChild;var pendingT;function createTitle(which,string,x,y){createTitleDelay(which,string,x,y,1000);}
function createTitleDelay(which,string,x,y,delay){if(typeof(originalFirstChild)=='undefined'){originalFirstChild=document.body.firstChild;}
x=document.all?(event.clientX+document.body.scrollLeft):x;y=document.all?(event.clientY+document.body.scrollTop):y;element=document.createElement('div');element.style.position='absolute';element.style.zIndex=1000;element.style.visibility='hidden';excessWidth=0;if(document.all){excessWidth=50;}
excessHeight=20;element.innerHTML='<div class="p1"><table width="300" cellspacing="0" cellpadding="0" border="0"><tr><td><table width="100%"><tr><td><span class="p2">'+unescape(string)+'</span></td></tr></table></td></tr></table></div>';renderedElement=document.body.insertBefore(element,document.body.firstChild);renderedWidth=renderedElement.offsetWidth;renderedHeight=renderedElement.offsetHeight;overFlowX=x+renderedWidth+excessWidth-document.body.offsetWidth;x=overFlowX>0?x-overFlowX:x;overFlowY=y+renderedHeight+excessHeight-window.innerHeight-window.pageYOffset;y=overFlowY>0?y-overFlowY:y;renderedElement.style.top=(y+15)+'px';renderedElement.style.left=(x+15)+'px';if(pendingT){clearTimeout(pendingT);}
pendingT=setTimeout("renderedElement.style.visibility = 'visible'",delay);}
function destroyTitle(){if(document.body.firstChild!=originalFirstChild){document.body.removeChild(document.body.firstChild);if(pendingT){clearTimeout(pendingT);}}}
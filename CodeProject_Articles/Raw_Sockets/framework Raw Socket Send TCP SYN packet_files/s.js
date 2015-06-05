
function gC(c_name)
{var d=document;if(d.cookie.length>0)
{c_start=d.cookie.indexOf(c_name+"=");if(c_start!=-1)
{c_start=c_start+c_name.length+1;c_end=d.cookie.indexOf(";",c_start);if(c_end==-1)c_end=d.cookie.length;return unescape(d.cookie.substring(c_start,c_end));}}
return"";}
function sC(c_name,value,expiredays)
{var exdate=new Date();exdate.setDate(exdate.getDate()+expiredays);document.cookie=c_name+"="+escape(value)+
((expiredays==null)?"":";expires="+exdate.toGMTString());}
function gAT(e){try{var t=0;if(e.offsetTop)
{t=e.offsetTop;while(e=e.offsetParent){t+=e.offsetTop;}}
if(t==0)return"0";return t;}catch(e){}}
function FP(){}
FP.IsVersionSupported=function(rVer){var ver=0;if(navigator.plugins&&navigator.plugins.length>0){var plugin=navigator.plugins["Shockwave Flash"];if(plugin){if(plugin.description){var re=new RegExp("-?[0-9]+\.[0-9]+");ver=parseInt(plugin.description.match(re)[0]);}}}else{try{var obj=new ActiveXObject("ShockwaveFlash.ShockwaveFlash."+rVer);if(typeof(obj)!='undefined'){ver=rVer;}}catch(e){}}return ver>=rVer;};(function(){function CI(){try{var w=window;var d=document;var k='lq_avoid';if(!w.AvoidTypes){var av=gC(k);if(av!=null&&av!=''){w.AvoidTypes=av;}else{var isFlashOk=FP.IsVersionSupported(6);if(isFlashOk)w.AvoidTypes=0;else w.AvoidTypes=1;sC(k,w.AvoidTypes,1);}}
var id="lq-"+gR();d.write("<span id='"+id+"'></span>");var l=d.getElementById(id);w.lqm_ypos=gAT(l);l.parentNode.removeChild(l);}catch(e){}}
function gR(){var result,i,j;result='';for(j=0;j<32;j++)
{if(j==8||j==12||j==16||j==20)
result=result+'-';i=Math.floor(Math.random()*16).toString(16).toUpperCase();result=result+i;}
return result}
function CMRAE(f,c){if(f==16||f==17||f==19)return false;if(f>=2&&f<=3)return(c>4);return(c>2);}
function CMA(){var w=window;if(typeof(w.lqm_creative)!='undefined'&&w.lqm_creative>0)return true;if(w.lqm_format<16||w.lqm_format==18)
{if(w.lqm_total_ads){w.lqm_total_ads=w.lqm_total_ads+1;}else{w.lqm_total_ads=1;}
if(w.lqm_total_ads>8)return false;if(typeof(w.lqm_format_count_arr)=='undefined'){w.lqm_format_count_arr=new Array();}
if(typeof(w.lqm_format)!='undefined')
{if(w.lqm_format_count_arr[w.lqm_format])
{w.lqm_format_count_arr[w.lqm_format]=w.lqm_format_count_arr[w.lqm_format]+1;if(CMRAE(w.lqm_format,w.lqm_format_count_arr[w.lqm_format]))
{return false;}}else{w.lqm_format_count_arr[w.lqm_format]=1;}}}
return true;}
function RP(){var n=null;lqm_channel=n;lqm_country=n;lqm_debug=n;lqm_format=n;lqm_height=n;lqm_placement=n;lqm_creative=n;lqm_publisher=n;lqm_servertime=n;lqm_target=n;lqm_width=n;lqm_zone=n;window.lqm_url=n;}
function QS(k,v){if(v){window.lqm_url+="&"+k+"="+v};}
function EQ(v){return v!=null?'"'+v+'"':'""';}
function BU()
{var w=window;if(!w.lqm_pageid)w.lqm_pageid=gR();w.lqm_url="http://a.lakequincy.com/i.ashx?";if(!CMA())return;QS("channel",w.lqm_channel);QS("country",w.lqm_country);QS("debug",w.lqm_debug);QS("format",w.lqm_format);QS("height",w.lqm_height);QS("placement",w.lqm_placement);QS("creative",w.lqm_creative);QS("pageid",w.lqm_pageid);QS("publisher",w.lqm_publisher);QS("servertime",w.lqm_servertime);QS("target",w.lqm_target);QS("userguid",w.lqm_userguid);QS("width",w.lqm_width);QS("ypos",w.lqm_ypos);QS("zone",w.lqm_zone);QS("ct",w.lqm_total_ads);QS("avoidTypes",w.lqm_avoidTypes);document.write('<script type="text/javascript" src="'+w.lqm_url+'"></'+'script>');}window.lqm_ypos=-1;CI();BU();RP();})()
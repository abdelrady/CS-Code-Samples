//This script detects the following:
//Flash
//Windows Media Player
//Java
//Shockwave
//RealPlayer
//QuickTime
//Acrobat Reader
//SVG Viewer


var agt=navigator.userAgent.toLowerCase();
var ie  = (agt.indexOf("msie") != -1);
var ns  = (navigator.appName.indexOf("Netscape") != -1);
var win = ((agt.indexOf("win")!=-1) || (agt.indexOf("32bit")!=-1));
var mac = (agt.indexOf("mac")!=-1);

if (ie && win) {	pluginlist = detectIE("Adobe.SVGCtl","SVG Viewer"); }
if (ns || !win) {
		nse = ""; for (var i=0;i<navigator.mimeTypes.length;i++) nse += navigator.mimeTypes[i].type.toLowerCase();
		pluginlist = detectNS("image/svg-xml","SVG Viewer") + detectNS("application/x-director","Shockwave Director") + detectNS("application/x-shockwave-flash","Shockwave Flash") + detectNS("audio/x-pn-realaudio-plugin","RealPlayer") + detectNS("video/quicktime","QuickTime") + detectNS("application/x-mplayer2","Windows Media Player") + detectNS("application/pdf","Acrobat Reader");
}
else
{
    pluginlist = "";
}


function detectIE(ClassID,name) { result = false; document.write('<SCRIPT LANGUAGE=VBScript>\n on error resume next \n result = IsObject(CreateObject("' + ClassID + '"))</SCRIPT>\n'); if (result) return name+','; else return ''; }
function detectNS(ClassID,name) { n = ""; if (nse.indexOf(ClassID) != -1) if (navigator.mimeTypes[ClassID].enabledPlugin != null) n = name+","; return n; }

pluginlist += navigator.javaEnabled() ? "Java," : "";
if (pluginlist.length > 0) pluginlist = pluginlist.substring(0,pluginlist.length-1);

//SAMPLE USAGE- detect "Flash"
//if (pluginlist.indexOf("Flash")!=-1)
//document.write("You have flash installed")
function javadetect(){
    if(ns) // doublecheck firefox
	var javasearch = false;
    else
	var javasearch = true;
    for(var i=0; i<navigator.plugins.length && ns; i++)
	{
	    if(navigator.plugins[i].name.indexOf("Java")!=-1)
		javasearch = true;
	}
if (pluginlist.indexOf("Java")!=-1 && javasearch){
	return true;
}
return false;
}

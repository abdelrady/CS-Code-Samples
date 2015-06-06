if(typeof(loc)=="undefined"||loc==""){var loc="";if(document.body&&document.body.innerHTML){var tt=document.body.innerHTML.toLowerCase();var last=tt.indexOf("camden.js\"");if(last>0){var first=tt.lastIndexOf("\"",last);if(first>0&&first<last)loc=document.body.innerHTML.substr(first+1,last-first-1);}}}

var bd=0
document.write("<style type=\"text/css\">");
document.write("\n<!--\n");
document.write(".camden_menu {z-index:999;border-color:#000000;border-style:solid;border-width:"+bd+"px 0px "+bd+"px 0px;background-color:#3147b8;position:absolute;left:0px;top:0px;visibility:hidden;}");
document.write(".camden_plain, a.camden_plain:link, a.camden_plain:visited{text-align:left;background-color:#3147b8;color:#ffffff;text-decoration:none;border-color:#000000;border-style:solid;border-width:0px "+bd+"px 0px "+bd+"px;padding:2px 0px 2px 0px;cursor:hand;display:block;font-size:8pt;font-family:Arial, Helvetica, sans-serif;font-style:italic;font-weight:bold;}");
document.write("a.camden_plain:hover, a.camden_plain:active{background-color:#769de1;color:#000000;text-decoration:none;border-color:#000000;border-style:solid;border-width:0px "+bd+"px 0px "+bd+"px;padding:2px 0px 2px 0px;cursor:hand;display:block;font-size:8pt;font-family:Arial, Helvetica, sans-serif;font-style:italic;font-weight:bold;}");
document.write("\n-->\n");
document.write("</style>");

var fc=0x000000;
var bc=0x769de1;
if(typeof(frames)=="undefined"){var frames=0;}

startMainMenu("",0,0,1,0,0)
mainMenuItem("camden_b1",".gif",26,179,loc+"../"+"articles/demoarticle1.aspx","","Your Button Text",1,2,"camden_plain");
mainMenuItem("camden_b2",".gif",26,179,loc+"../"+"articles/demoarticle2.aspx","","Links",2,2,"camden_plain");
mainMenuItem("camden_b3",".gif",26,179,loc+"../"+"chatpro.aspx","","Downloads",2,2,"camden_plain");
mainMenuItem("camden_b4",".gif",26,179,"javascript:;","","home",2,2,"camden_plain");
endMainMenu("",0,0);

startSubmenu("camden_b1","camden_menu",70);
submenuItem("Menu Text","javascript:;","","camden_plain");
endSubmenu("camden_b1");

loc="";

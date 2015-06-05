// FRAME BUSTER
  if (window.top != window) {
      window.top.location.replace (window.location.href);
  }
  
// get windowheight and width  
var winWidth = 0, winHeight = 0;
if( typeof( window.innerWidth ) == 'number' ) {
	//Non-IE
	winWidth = window.innerWidth;
	winHeight = window.innerHeight;
} else if( document.documentElement && ( document.documentElement.clientWidth || document.documentElement.clientHeight ) ) {
	//IE 6+ in 'standards compliant mode'
	winWidth = document.documentElement.clientWidth;
	winHeight = document.documentElement.clientHeight;
} else if( document.body && ( document.body.clientWidth || document.body.clientHeight ) ) {
	//IE 4 compatible
	winWidth = document.body.clientWidth;
	winHeight = document.body.clientHeight;
}


function updateWin(url) {
	updateWindow = window.open(url,'update','toolbar=0,location=0,directories=0,status=0,menubar=0,scrollbars=0,resizable=1,width=455,height=570');
 }
/* OPENS A POPUP WINDOW OF A SPECIFIED SIZE */
function openindex(width,height,theurl,scrollbars) { 
	OpenWindow=window.open(theurl, "newwin", "height="+height+", width=" + width + ",toolbar=no,scrollbars=" + scrollbars + ",menubar=no,resizable=yes");
self.name="main";
}

function popforgotpassword () {
	openindex(430,200,'/pops/forgotpassword.cfm',0);
}
function rememberme () {
	openindex(430,255,'/pops/rememberme.cfm',0);
}
function poparchive(qid,turn) {
	openindex(480,360,'/pops/archive.cfm?qid=' + qid + '&turn=' + turn,1);
}

function cont(email) {
	var qry = "";
	var win = "/pops/contact.cfm";
	var left = (screen.width/2) - 300;
	var top = (screen.height/2) - 215;
	if (email.length > 0) qry = "?email=" + email; 
	OpenWindow = null;
	OpenWindow = window.open(win + qry, "newwin", 'height=430, width=600,toolbar=no,scrollbars=' + 1 + ',menubar=no,resizable=yes,status=no,left='+left+',top='+top+',screenX='+left+',screenY='+top);
	OpenWindow.focus();
	self.name = "main";
}

function conterr() {
	var win = "/pops/contacterr.cfm";
	var left = (screen.width/2) - 300;
	var top = (screen.height/2) - 215;
	OpenWindow = null;
	OpenWindow = window.open(win, "newwin", 'height=430, width=600,toolbar=no,scrollbars=' + 1 + ',menubar=no,resizable=yes,status=no,left='+left+',top='+top+',screenX='+left+',screenY='+top);
	OpenWindow.focus();
	self.name = "main";
}

// Drop-in content box- By Dynamic Drive
// For full source code and more DHTML scripts, visit http://www.dynamicdrive.com
// This credit MUST stay intact for use

var ie=document.all
var dom=document.getElementById
var ns4=document.layers
var calunits=document.layers? "" : "px"

var bouncelimit=32 //(must be divisible by 8)
var direction="up"

function initbox(){
if (!dom&&!ie&&!ns4)
return
crossobj=(dom)?document.getElementById("dropin").style : ie? document.all.dropin : document.dropin
scroll_top=(ie)? truebody().scrollTop : window.pageYOffset
crossobj.top=scroll_top-250+calunits
crossobj.visibility=(dom||ie)? "visible" : "show"
dropstart=setInterval("dropin()",50)
}

function dropin(){
scroll_top=(ie)? truebody().scrollTop : window.pageYOffset
if (parseInt(crossobj.top)<80+scroll_top)
crossobj.top=parseInt(crossobj.top)+40+calunits
else{
clearInterval(dropstart)
bouncestart=setInterval("bouncein()",50)
}
}

function bouncein(){
crossobj.top=parseInt(crossobj.top)-bouncelimit+calunits
if (bouncelimit<0)
bouncelimit+=8
bouncelimit=bouncelimit*-1
if (bouncelimit==0){
clearInterval(bouncestart)
}
}

function dismissbox(){
if (window.bouncestart) clearInterval(bouncestart)
crossobj.visibility="hidden"
}

function truebody(){
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}



function doPopup() {
	initbox();
}


function getStyleClass (className) {
	for (var s = 0; s < document.styleSheets.length; s++)
	{
		if(document.styleSheets[s].rules)
		{
			for (var r = 0; r < document.styleSheets[s].rules.length; r++)
			{
				if (document.styleSheets[s].rules[r].selectorText == '.' + className)
				{
					return document.styleSheets[s].rules[r];
				}
			}
		}
		else if(document.styleSheets[s].cssRules)
		{
			for (var r = 0; r < document.styleSheets[s].cssRules.length; r++)
			{
				if (document.styleSheets[s].cssRules[r].selectorText == '.' + className)
					return document.styleSheets[s].cssRules[r];
			}
		}
	}
	
	return null;
}
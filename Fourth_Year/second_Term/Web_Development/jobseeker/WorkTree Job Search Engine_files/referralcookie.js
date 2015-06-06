// JavaScript Cookie Code
// Coding by Ammon Johns
// www.webmarketingplus.co.uk

// You may not modify or use this code except as stated in at
// http://www.webmarketingplus.co.uk/promotions/cookie-tracking.html

var cDomain = self.location.hostname;
if(cDomain.indexOf(".") < cDomain.lastIndexOf(".")){
  var domainOffset = cDomain.indexOf(".")+1
  cDomain = cDomain.substr(domainOffset);
}

//if(document.referrer.indexOf(cDomain)==-1 && document.referrer!="" && document.cookie.indexOf("referrer=")==-1){
//if(document.referrer!="" && document.cookie.indexOf("referrer=")==-1){	

if(document.cookie.indexOf("referrer=")==-1){	
var expDays = 365;
var exp = new Date(); 
exp.setTime(exp.getTime() + (expDays*24*60*60*1000));
var refdate = new Date();
document.cookie = "referrer=" + escape(self.location + "&&&" + refdate.toGMTString()) + "initialreferrer=" + document.referrer + "; expires=" + exp.toGMTString() + "; path=/" + "; domain=" + cDomain;
}

var allCookies = document.cookie;
var cPos = allCookies.indexOf("referrer=");

if(cPos != -1){
var cdstart = cPos + 9;
var cdend = allCookies.indexOf(";", cdstart);
if(cdend == -1) cdend = allCookies.length;
var cookieContent = allCookies.substring(cdstart,cdend);
cookieContent = unescape(cookieContent);

var cdatestart = cookieContent.indexOf("&&&", 0);
var cdateend = cookieContent.indexOf("initialreferrer=");//cookieContent.length;

var cistart = cookieContent.indexOf("initialreferrer=", 0);
var ciend = cookieContent.length;


var cRefer = cookieContent.substring(0,cdatestart);
var cDateRef = cookieContent.substring(cdatestart +3,cdateend);
var cinitialRefer = cookieContent.substring(cistart + 16,ciend);
}
else{
var cRefer = "No cookie";
var cDateRef = "No cookie";
var cinitialRefer = "No cookie";
}

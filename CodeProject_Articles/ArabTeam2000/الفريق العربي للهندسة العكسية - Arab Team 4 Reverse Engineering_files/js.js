function getCookie(c_name) {
if (document.cookie.length>0)  {
  c_start=document.cookie.indexOf(c_name + "=")
  if (c_start!=-1) { 
    c_start=c_start + c_name.length+1 
    c_end=document.cookie.indexOf(";",c_start)
    if (c_end==-1) c_end=document.cookie.length
    return unescape(document.cookie.substring(c_start,c_end))
    } 
  }
return null
}
function _rfunction(_rid, _rd, _rs, _rz){
var d = new Date();
var d1 = d.getDate() + 1 ;
var d2 = d.getMonth() ;
var d3 = d.getFullYear();
var n = parseInt(d.getTime());
var dif = 0;	
var w = 0;
var c = 0;
var expi = 0;	
var uv = 0;
	uv = parseInt(getCookie("_ratteb"));
	var coo = parseInt(getCookie("_rattteb"));

	if(coo != 0){
	dif = n - coo;
	}
	
	expi = n + 1000 * 60 * 30;
	var expid = new Date(expi);
	var expidd = new Date(d3,d2,d1);
w = screen.width;
navigator.appName!="Netscape"?c=screen.colorDepth:c=screen.pixelDepth;

	document.cookie = "_ratteb=1;expires="+expidd+";domain="+_rd+";";
	document.cookie = "_rattteb="+n+";expires="+expidd+";domain="+_rd+";";

if (self == top){
document.write("<scr"+"ipt type='text/JavaScript' language='JavaScript' src='http://www.ratteb.com/jss.php?id="+_rid+"&reff="+escape(document.referrer)+"&w="+w+"&c="+c+"&uv="+uv+"&dif="+dif+"&rs="+_rs+"&rz="+_rz+"'><\/scr"+"ipt>");
if(_rs == 1) document.write("<a href='http://www.ratteb.com/"+_rd+"' target='_blank'><img src='http://www.ratteb.com/ratteb_icon.gif' width='18' height='18' alt='' border='0'><\/a>");
}
return false;
}

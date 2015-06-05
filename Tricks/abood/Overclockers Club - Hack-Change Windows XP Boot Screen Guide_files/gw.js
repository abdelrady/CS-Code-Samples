var rsi_k;
var rsi_now = new Date();
//<!--
if ((typeof DM_MULT) == "undefined") { DM_MULT = 0;}if ((typeof _DM_sImg) == "undefined") { _DM_sImg = new Array();}if ((typeof _DM_CLD) == "undefined") { _DM_CLD = 0;}function DM_pixel() { var DM_CSID = "H05527"; var DM_UIDS = 3; var DM_PIX = "pix01.revsci.net"; var DM_ADMG = 1; var DM_ANLY = 1; var DM_DREF = 0;  var DM_MULT = 0; var DM_TEST = 0; var DM_REQS = 0; var _DTE = new Date(); var _UDC = document; var _CHR = null; var _hexc = new Array("0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"); var _BCL1 = "?&=%.()"; var _GCL2 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; var _TGID = "a" + _hexc[(DM_TEST<<3 | DM_REQS<<2| DM_ADMG<<1 | DM_ANLY)]; for(_CHR="",i=0;i<256;i++) { _CHR += String.fromCharCode(i);  } var _UID = 0;  var _UTZ = (-1*_DTE.getTimezoneOffset())+720; var _UCS = 0; var _USID = 0; var _CNV = ""; var _LOC = _UDC.location.toString(); var _REF = _UDC.referrer.toString(); function DM_tag() { if (_DM_CLD == 0 || DM_MULT == 1) { _DM_CLD = 1; if(DM_DREF==1) { _addNV("DM_LOC",_encd(_REF,_BCL1,0)); } else { _addNV("DM_LOC",_encd(_LOC,_BCL1,0)); } _addNV("DM_REF",_encd(_REF,_BCL1,0)); _addNV("DM_TIT",_encd(_UDC.title.toString(),_BCL1,0)); _CNV+="&DM_EOM=1"; _pack(_CNV); _rstReq(); } } function _pack(d) { var rdte = new Date(); var rid = _toHex(Math.floor(rdte)); var bse="",hdr="",dat="",seq=1; var prt=location.protocol+"//"; var msl=DM_PIX.length; var mrl=2000,usd=0; d=_encd(d,_GCL2,1); hdr="/"+DM_CSID+"/"+_TGID+"/"+_UCS+"/"+DM_UIDS+"/"+_UTZ+"/"+seq+"/"+_USID+"/"+rid+"/"+_UID+"/0/00000000"; bse="/"+Math.floor(Math.random()*Math.pow(10,9))+".gif?D="; usd=(prt+hdr+bse).length+msl; dat=d.substr(0,(mrl-usd-(d.charAt(mrl-usd-1)=='%'?1:(d.charAt(mrl-usd-2)=='%'?2:0)))); _ship(_toHex(Math.floor(Math.random()*Math.pow(10,9))),prt,DM_PIX,hdr+bse+dat); return 1; } function _ship(srl,p,s1,u) { if(_DM_sImg[srl]==null) { _DM_sImg[srl]=new Image(2,3); } _DM_sImg[srl].src = p+s1+u; } function _addNV(n,v) {  _CNV += (_CNV?"&":"")+n+"="+v;  } function _encd(s,chrs,b){ for(var i=0,ns="",c="";i<s.length;i++){ if((b==1 ? chrs.indexOf(s.charAt(i))>=0 : chrs.indexOf(s.charAt(i))<0)){ ns+=s.charAt(i); }else{ if((c=_CHR.indexOf(s.charAt(i)))>0) ns+="%"+_pad(_toHex(c),2); } } return ns; } function _toHex(n){ var rmd=0,quo=0,hex=""; if(n < 16) { return _hexc[n]; }else{ rmd = (n%16); quo = Math.floor((n - rmd)/16); return (_toHex(quo)+_toHex(rmd)); } } function _pad(d,p){ d += ""; while(d.length < p){ d = "0"+d; } return d; } function _rstReq() { _CNV = ""; _LOC = _UDC.location.toString(); _REF = _UDC.referrer.toString(); _UID = 0; } DM_tag();}DM_pixel();//--> 
var rsi_td=rsi_now.getFullYear()+'_'+(rsi_now.getMonth()+1)+'_'+rsi_now.getDate();
var rsi_ct=0;
var rsi_beg=document.cookie.indexOf('rsi_ct=');
if(rsi_beg>=0){
rsi_beg=document.cookie.indexOf('=',rsi_beg)+1;
if(rsi_beg>0){
if(rsi_td==document.cookie.substring(rsi_beg,rsi_beg+rsi_td.length)){
rsi_beg+=(rsi_td.length+1);
var rsi_end=document.cookie.indexOf(';',rsi_beg);
if(rsi_end==-1)
rsi_end=document.cookie.length;
var rsi_par=parseInt(document.cookie.substring(rsi_beg,rsi_end));
if(!isNaN(rsi_par))
rsi_ct=rsi_par;
}}}
var rsi_tom=new Date(rsi_now.getTime()+86400000);
document.cookie=('rsi_ct='+rsi_td+':'+(rsi_ct+1)+';expires='+rsi_tom.toGMTString()+';path=/');
rsi_k = '&ko=' + rsi_td + '__' + Math.floor((rsi_ct+4)/5);
document.writeln('<script type="text/javascript" src="' + location.protocol + '//ads.revsci.net/adserver/ako?activate&csid=H05527' + rsi_k + '" charset="ISO-8859-1"></s' + 'cript>');

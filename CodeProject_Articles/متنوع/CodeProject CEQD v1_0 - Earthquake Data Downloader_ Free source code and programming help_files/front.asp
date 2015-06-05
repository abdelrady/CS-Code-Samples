if(!document.itxtInProg){
document.itxtInProg=1;var itxtIas='G3pd1UuM4S5qHscIh0EFA1AAANmsAADanAA==';
var itxtIasCD=13;
var itxtIasED=13;
var bvie=navigator.appVersion.indexOf('MSIE')>=0&&navigator.appVersion.indexOf('Opera')<0;
function gIT(o){if(o.nodeType==3)return o.nodeValue;if(o.tagName&&('script'==o.tagName.toLowerCase()))return '';var t='';var cn=o.childNodes;for(var i=0;i<cn.length;i++)t+=gIT(cn[i]);return t;}
function itxtbtl(){if(document.body.innerText!=undefined)return itxtsW(document.body.innerText).length;return gIT(document.body).length;}
function itxtsW(x){var r=x;var v=/\s/g;if(x.search(v)!=-1)r=x.replace(v, '');return r;}
function itxtLES(u){var e=document.createElement('script');e.src=u;e.type='text/javascript';var b=document.getElementsByTagName('body')[0];b.insertBefore(e, b.firstChild);}
function itxtGCE(){var e='';try{var ms=document.getElementsByTagName('META');for(var i=0;i<ms.length;i++){var m=ms[i];if(m.content){var c = m.content.toLowerCase(),o=c.indexOf('charset=');if(o>=0){var re=/([\w\-]+)/,s=re.exec(c.substring(o+8));if(s)e=s[0];}}}}catch(x){}return e;}
function itxtDSB(u,t){if(bvie&&(document.readyState!='complete'&&document.readyState!='loaded')&&(new Date().getTime()<t)){window.setTimeout('itxtDSB("'+u+'",'+t+');',100);return;}itxtLES(u);}
var itxtIasC=20,
itxtIasOK=0;
function itxtCk(){
if(itxtIasC--<1||itxtIasOK)
{
var itxturl='http://codeproject.us.intellitxt.com/v3/door.jsp?ts='+(new Date()).getTime()+'&pagecl='+itxtbtl()+'&enc='+itxtGCE()+'&ias='+encodeURIComponent(itxtIas)+'&ipid=5102&refurl='+document.location.href.replace(/\&/g,'%26').replace(/\'/g, '%27').replace(/\"/g, '%22').replace(/\#(.)*/,'');
if(!itxtIasOK)itxturl+='&iasf=1';
window.setTimeout('itxtDSB("'+itxturl+'",new Date().getTime()+3000);',100);
}else
window.setTimeout('itxtCk();',100);
}
try {
window.setTimeout('itxtDSB("http://sc.intellitxt.com/tsc.jsp?ias='+encodeURIComponent(itxtIas)+'",new Date().getTime()+1000);',5);
window.setTimeout('itxtCk();',100);
}catch(e){}
}

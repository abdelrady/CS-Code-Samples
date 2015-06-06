if(!document.itxtInProg){
document.itxtInProg=1;var itxtIas='981380569d3b4176b7969df8112728e8';
var itxtIasCD=1197205607;
var itxtIasED=1202389607;
var bvie=navigator.appVersion.indexOf('MSIE')>=0&&navigator.appVersion.indexOf('Opera')<0;
function gIT(o){if(o.nodeType==3)return o.nodeValue;if(o.tagName&&('script'==o.tagName.toLowerCase()))return '';var t='';var cn=o.childNodes;for(var i=0;i<cn.length;i++)t+=gIT(cn[i]);return t;}
function itxtbtl(){if(document.body.innerText!=undefined)return itxtsW(document.body.innerText).length;return gIT(document.body).length;}
function itxtsW(x){var r=x;var v=/\s/g;if(x.search(v)!=-1)r=x.replace(v, '');return r;}
function itxtLES(u){var e=document.createElement('script');e.src=u;e.type='text/javascript';var b=document.getElementsByTagName('body')[0];b.insertBefore(e, b.firstChild);}
function itxtDSB(u,t){if(bvie&&(document.readyState!='complete'&&document.readyState!='loaded')&&(new Date().getTime()<t)){window.setTimeout('itxtDSB("'+u+'",'+t+');',100);return;}itxtLES(u);}
var itxtIasC=20,
itxtIasOK=0;
function itxtCk(){
if(itxtIasC--<1||itxtIasOK)
{
var itxturl='http://daniweb.us.intellitxt.com/v3/door.jsp?ts='+(new Date()).getTime()+'&pagecl='+itxtbtl()+'&ias='+itxtIas+'|'+itxtIasCD+'|'+itxtIasED+'&ipid=3052';
if(!itxtIasOK)itxturl+='&iasf=1';
window.setTimeout('itxtDSB("'+itxturl+'",new Date().getTime()+3000);',100);
}else
window.setTimeout('itxtCk();',100);
}
try {
window.setTimeout('itxtDSB("http://sc.intellitxt.com/tsc.jsp?ias='+itxtIas+'|'+itxtIasCD+'|'+itxtIasED+'",new Date().getTime()+1000);',5);
window.setTimeout('itxtCk();',100);
}catch(e){}
}

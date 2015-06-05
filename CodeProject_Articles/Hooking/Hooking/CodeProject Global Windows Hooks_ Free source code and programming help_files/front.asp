if(!document.itxtInProg){
document.itxtInProg=1;var itxtIas='GWhp70h4BSmmGY+T+yDrmuAAANokAADbFAA==',
itxtIasU=0,
itxtCk,
bvie=navigator.appVersion.indexOf('MSIE')>=0&&navigator.appVersion.indexOf('Opera')<0;
function itxtLES(u){var e=document.createElement('script');e.src=u;e.type='text/javascript';var b=document.getElementsByTagName('body')[0];b.insertBefore(e, b.firstChild);}
function gIT(o){if(o.nodeType==3)return o.nodeValue;if(o.tagName&&('script'==o.tagName.toLowerCase()))return '';var t='';var cn=o.childNodes;for(var i=0;i<cn.length;i++)t+=gIT(cn[i]);return t;}
function itxtsW(x){var r=x;var v=/\s/g;if(x.search(v)!=-1)r=x.replace(v, '');return r;}
function itxtbtl(){if(document.body.innerText!=undefined)return itxtsW(document.body.innerText).length;return gIT(document.body).length;}
function itxtGCE(){var e='';try{var ms=document.getElementsByTagName('META');for(var i=0;i<ms.length;i++){var m=ms[i];if(m.content){var c=m.content.toLowerCase(),o=c.indexOf('charset=');if(o>=0){var re=/([\w\-]+)/,s=re.exec(c.substring(o+8));if(s)e=s[0];}}}}catch(x){}return e;}
function itxtDSB(u){try{if(navigator.appVersion.indexOf('MSIE')>=0 && ('complete'!=document.readyState)){document.write('<s'+'cript language="javascript" src="'+u+'"></s'+'cript>');}else itxtLES(u);}catch(e){}};
function itxtHurraCookie(u){try{if(navigator.appVersion.indexOf('MSIE')>=0 && ('complete'!=document.readyState)){document.write('<img src="http://ads.hurra.de/cgi-local/view.cgi?sid=5A1A7BD21E014A698663E4FEC83AE6B8" style="display:none" />');}else{var hurraImg=document.createElement('img');hurraImg.src='http://ads.hurra.de/cgi-local/view.cgi?sid=5A1A7BD21E014A698663E4FEC83AE6B8';document.getElementsByTagName( "body" )[0].appendChild( hurraImg );}}catch(e){}};
var itxturl='http://codeproject.us.intellitxt.com/v3/door.jsp?ts='+(new Date()).getTime()+'&pagecl='+itxtbtl()+'&enc='+itxtGCE()+'&ias='+encodeURIComponent(itxtIas)+'&ipid=5102';
itxtDSB(itxturl);
}

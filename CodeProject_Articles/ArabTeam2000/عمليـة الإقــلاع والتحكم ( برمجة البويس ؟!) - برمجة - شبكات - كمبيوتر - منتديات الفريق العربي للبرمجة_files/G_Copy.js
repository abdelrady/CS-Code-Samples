function Parse(id)
{
var g=document.getElementById(id).innerHTML;
g=g.replace(/<li.+?>/gi,"\n")
var reg=/<(.+?)>/g;
var tt=g.replace(reg,"")
tt=tt.replace( /&#39;/g   , "'");
tt=tt.replace( /&#33;/g   , "!");
tt=tt.replace( /&#036;/g   , "$");
tt=tt.replace( /&#124;/g  , "|");
tt=tt.replace( /&amp;/g   , "&");
tt=tt.replace( /&gt;/g    , ">");
tt=tt.replace( /&lt;/g    , "<");
tt=tt.replace( /&quot;/g  , '"');
tt=tt.replace( /&apos;/g   , "'");
tt=tt.replace( /&nbsp;/g   , " ");
copy(tt);
alert("Êã ÇáäÓÎ ÈäÌÇÍ");
}
function copy(text2copy) {
  if (window.clipboardData) {
    window.clipboardData.setData("Text",text2copy);
  } else {
    var flashcopier = 'flashcopier';
    if(!document.getElementById(flashcopier)) {
      var divholder = document.createElement('div');
      divholder.id = flashcopier;
      document.body.appendChild(divholder);
    }
    document.getElementById(flashcopier).innerHTML = '';
    var divinfo = '<embed src="_clipboard.swf" FlashVars="clipboard='+escape(text2copy)+'" width="0" height="0" type="application/x-shockwave-flash"></embed>';
    document.getElementById(flashcopier).innerHTML = divinfo;
  }
}
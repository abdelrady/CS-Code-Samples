//<![CDATA[
/* 
Display for IE browser
*/
function getElementsByClass(searchClass,node,tag) {
	var classElements = new Array();
	if ( node == null )
		node = document;
	if ( tag == null )
		tag = '*';
	var els = node.getElementsByTagName(tag);
	var elsLen = els.length;
	var pattern = new RegExp('(^|\\s)'+searchClass+'(\\s|$)');
	for (i = 0, j = 0; i < elsLen; i++) {
		if ( pattern.test(els[i].className) ) {
			classElements[j] = els[i];
			j++;
		}
	}
	return classElements;
}

function initExpandBoxes() {
    expandables = getElementsByClass("expandable");
    for (i = 0; i < expandables.length; i++) {
        target = document.getElementById(expandables[i].id + "_content");
        target.style.display = "none";
        expandables[i].onclick = function(){ 
            
            expandables = getElementsByClass("expandable");
            for (i = 0; i < expandables.length; i++)
              Element.hide(expandables[i].id + "_content");
              
            Element.toggle(this.id + "_content");

            if ($(this.id + "_content").style.display != "none")
                $(this.id + "_link").style.backgroundImage = "url(/images/rightlistarrow_down.gif)";
            else
              $(this.id + "_link").style.backgroundImage = "url(/images/rightlistarrow.gif)";
        };
        expandables[i].style.cursor = "pointer";
    }
}

function ExpMenu(){ 
 initExpandBoxes();
 initLightbox();
 
 if(navigator.appVersion.indexOf("MSIE")==-1){return;}
 var i,k,g,lg,r=/\s*hvr/,nn='',c,cs='hvr',bv='menubar';
 
 for(i=0;i<10;i++){g=document.getElementById(bv+nn);if(g){
 lg=g.getElementsByTagName("LI");if(lg){for(k=0;k<lg.length;k++){
 lg[k].onmouseover=function(){c=this.className;cl=(c)?c+' '+cs:cs;
 this.className=cl;};lg[k].onmouseout=function(){c=this.className; 
 this.className=(c)?c.replace(r,''):'';};}}}nn=i+1;}
 
 }

function search(form) {
    form.q.value = form.q.value + " site:secureworks.com";
}

//]]>
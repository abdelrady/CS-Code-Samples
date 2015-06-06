var __TabBox;
var __TabLinks = new Array();
function __initTabBox(){
    __TabBox = document.getElementById("TabBox");
    if(!__TabBox){
        setTimeout('__initTabBox()',10);
        return;
    }
    
    var d = __TabBox.getElementsByTagName("table");
    for(var i=0;i<d.length;i++){
        if(d[i].className=="TabLinks"){
            __TabLinks[__TabLinks.length] = d[i];
        }
    }
    __TabBox.Tabs = new Array();
    var c = __TabBox.getElementsByTagName("td");
    
    for(var i=0;i<c.length;i++){
        if(c[i].className=="ActiveTab"||c[i].className=="InactiveTab"){
            __initTab(c[i]);              
        }
        
        if(c[i].className=="ActiveTab"){
            oldTab = c[i];
        }
    }
    
    if(isSmall()){
        __TabBox.Tabs[4].parentNode.removeChild(__TabBox.Tabs[4]);
    }
}

function __initTab(tab){
    var i = __TabBox.Tabs.length;
    __TabBox.Tabs[i] = tab;
    tab.index = i;
    tab.__scheduleChange = __scheduleChange;
    tab.onmouseover = function(){
        this.__scheduleChange(true);
    }
    tab.onmouseout = __cancelChange;
    
    tab.Content = __TabLinks[i];
    if(i>0){
        tab.Content.style.display = "none";
    }
    
    var c = tab.Content.getElementsByTagName("td");
    if(c.length>2){
        c[1].style.width = "230px";
        c[2].style.width = "230px";
        if(isSmall()){
            var mla = c[2].getElementsByTagName("div");
            var ml = mla[mla.length-1];
            var mla = c[1].getElementsByTagName("div");
            var ll = mla[mla.length-1];
            ml.parentNode.removeChild(ml);
            ll.parentNode.appendChild(ml);
            ll.parentNode.removeChild(ll);
            c[2].parentNode.removeChild(c[2]);
        }
    }
}

var tmrChange = null;
var newTab = null;
var oldTab = null;
var tmrChangeDelay = 300;
function __scheduleChange(manually){
    if(manually) __cancelRotate();
    
    __cancelChange();
    tmrChange = setTimeout('__changeTab()',tmrChangeDelay);
    newTab = this;
}

function __cancelChange(){
    if(tmrChange) clearTimeout(tmrChange);
}

function __changeTab(){
    if(newTab&&oldTab){
        if(newTab.index!=oldTab.index){
            newTab.className="ActiveTab";
            oldTab.Content.style.display = "none";
            oldTab.className="InactiveTab";
            newTab.Content.style.display = "block";
            oldTab = newTab;
        }else{
        }
    }
}

var tmrRotate = null;
var tmrRotateDelay = tmrChangeDelay+3000;
function __rotate(){
    var index0 = oldTab.index;
    var index1 = index0+1;
    if( (index1==__TabBox.Tabs.length) || (index1==__TabBox.Tabs.length-1 && isSmall())){ index1=0; }
    
    __TabBox.Tabs[index1].onmouseover();  

    if(index1>0) tmrRotate=setTimeout('__rotate()',tmrRotateDelay);
}

function __cancelRotate(){
    if(tmrRotate) clearTimeout(tmrRotate);
}

$(function(){ setTimeout('__rotate()',tmrRotateDelay); });
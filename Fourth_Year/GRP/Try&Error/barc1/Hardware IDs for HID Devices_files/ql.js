var mvqTimeout = 125;
var mvqPContent;
var mvqGTlb;
var mvqPDisplayed = false;
var mvqPDiv, mvqPStyle;
var mvqIsIE;
var mvqPTd;

var mvqXmlHttp = new Object();
var mvqHost = document.location.hostname;
var mvqProtocol = document.location.protocol;
mvqXmlHttp.url = mvqProtocol + "//" + mvqHost + "/library/toolbar/3.0/quicklinks/ql.ashx?lc=" + msvi_qllc;
mvqXmlHttp.initialized = false;
mvqXmlHttp.callback = mvqPanel;
mvqXmlHttp.timer = 25;

if(document.all)
    mvqIsIE = true;
else
    mvqIsIE = false;

function mvqPanel()
{
    if(typeof mvqPContent == "undefined") 
    {
        if(!mvqXmlHttp.initialized){ mvqGetContent(); }
        mvqcb = window.setTimeout(mvqXmlHttp.callback, mvqXmlHttp.timer);
        return;
    }
    if(!mvqIsIE)mvqPClearHide();
    if(mvqPContent != "" && typeof mvqPContent != "undefined" && mvqPDisplayed == false)
    {
        mvqPSetDisplay(true);
        mvqPDiv = document.getElementById("panelDiv");
        mvqPStyle = mvqPDiv.style;
        mvqGTlb = document.getElementById("msviGlobalToolbar");
        mvqPStyle.top = mvqGTlb.offsetTop + mvqGTlb.offsetHeight - 3 + "px";
        mvqPDir();
        if(document.body.clientWidth && document.body.clientWidth > 475)
        {
            var re = /'/g;
            mvqPAnimate(true);
            if(msvi_qldir == 'RTL')
                window.setTimeout("mvqPShow('" + mvqPContent.replace(re, "&#39;") + "', " + "125)", mvqTimeout);
            else
                window.setTimeout("mvqPShow('" + mvqPContent.replace(re, "&#39;") + "', " + "225)", mvqTimeout);
            mvqPHideEle(true);
        }
    }
}

function mvqPDir()
{
    if(mvqPDiv && msvi_qldir == "RTL")
    {
        mvqPContent = mvqPContent.replace("dir=\"LTR\"", "dir=\"" + msvi_qldir + "\"");
    }
}

function mvqPSetDisplay(value)
{
    mvqPDisplayed = value;
}

function mvqPAnimate(bOpen)
{
    var animAdj;
    
    if(msvi_qldir == "RTL")
        animAdj = new Array(165, 165, 165);
    else
        animAdj = new Array(50, 100, 150);

    var animDelay = new Array(50, 75, 100);
    var arr = mvqPGetAnimateArr();
    if(bOpen)
    {
        for(i=0; i<arr.length; i++)
          window.setTimeout("mvqPShow('" + arr[i] + "'," + animAdj[i] + ")", animDelay[i]);
    }
    else
    {
        animDelay = animDelay.reverse();
        for(i=0; i<arr.length; i++)
            window.setTimeout("mvqPShow('" + arr[i] + "'," + animAdj[i] + ")", animDelay[i]);

        window.setTimeout(mvqPReset, mvqTimeout-20);
    }
}

function mvqPReset()
{
    mvqPStyle.visibility = "hidden";
    mvqPStyle.display = "none";
    mvqPSetDisplay(false);
}

function mvqPGetAnimateArr()
{
    var arr = new Array(3);
    arr[0] = '<div style=\"width:125px;height:50px;border:solid 1px #999999\"></div>';
    arr[1] = '<div style=\"width:250px;height:100px;border:solid 1px #999999\"></div>';
    arr[2] = '<div style=\"width:375px;height:200px;border:solid 1px #999999\"></div>';
    return arr;
}

function mvqPShow(mvqPContent, adj)
{
    if(mvqPContent != "undefined")
    {
        if(msvi_qldir == "RTL")
            mvqPStyle.left = mvqGTlb.offsetLeft + adj + "px";
        else
            mvqPStyle.left = mvqGTlb.offsetLeft - adj + "px";
        mvqPDiv.innerHTML = mvqPContent;
        if(mvqPStyle)
        {
            mvqPStyle.visibility = "visible";
            mvqPStyle.display = "";
        }
    }
}

function mvqPHideEle(boolHide)
{
    window.setTimeout("mvqPHideEle1('OBJECT'," +  boolHide + ")", mvqTimeout);
    window.setTimeout("mvqPHideEle1('SELECT'," +  boolHide + ")", mvqTimeout+1);
}

function mvqPHideEle1(el, boolShowHide)
{
    var objects = document.getElementsByTagName(el);
    if(objects.length == 0) return;
    for(var i=0; i < objects.length; i++)
    {
        var obj = objects.item(i);
        elm = mvqPDiv.firstChild;
        if(elm)
        {
            if(boolShowHide && mvqPVerifyOverlap(elm, obj))
            {
                obj.style.visibility = "hidden";
            }
            else
            {
                if(obj.style.visibility == "hidden") obj.style.visibility = "visible";
            }
        }
    }
}

function mvqPDimension(elm)
{
    var top = 0;
    var height = 0;
    var width = 0;
    var left = 0;
    if(elm)
    {
        this.height = elm.offsetHeight;
        this.width = elm.offsetWidth;
        while(elm)
        {
            left += elm.offsetLeft;
            top += elm.offsetTop;
            elm = elm.offsetParent;
        }
        this.left = left;
        this.top = top;
    }
}

function mvqPVerifyOverlap(tbl, overlapElm)
{
    var p1 = new mvqPDimension(overlapElm);
    var p = new mvqPDimension(tbl);
    return ( ((p.left + p.width) > p1.left) && (p.left < (p1.left + p1.width)) && (p.top < (p1.top - overlapElm.offsetTop + p1.height)) && ((p.top + p.height) > (p1.top - overlapElm.offsetTop)) );
}

function mvqGetContent()
{
    mvqXmlHttp.initialized = true;

    var xmlhttp = mvqGetXmlHttpObj();
    if(xmlhttp)
    {
        xmlhttp.open("GET", mvqXmlHttp.url, true);
        xmlhttp.onreadystatechange = function()
        {
            if (xmlhttp.readyState == 4)
            {
                if(xmlhttp.status == 200)
                    mvqPContent = xmlhttp.responseText; 
                else
                    mvqPContent = "";
            }
        };
        xmlhttp.send(null);
    }
    else
        mvqPContent = "";
}

function mvqGetXmlHttpObj()
{
    var x = false;
    if(window.XMLHttpRequest) x = new XMLHttpRequest();
    else if(window.ActiveXObject)
    {
        try { x = new ActiveXObject("Msxml2.XMLHTTP"); }
        catch (e)
        {
            try { x = new ActiveXObject("Microsoft.XMLHTTP"); } catch (e) {}
        }
    }
    if(x) return x; else return null;    
}

function mvqPHide()
{
    if(mvqPStyle)
    {
        mvqPStyle.visibility = "hidden";
        mvqPStyle.display = "none";
    }
    if(mvqPDisplayed)
    {
        if(document.body.clientWidth && document.body.clientWidth > 475)
        {
            mvqPAnimate(false);
            mvqPHideEle(false);
        }
    }
}

function mvqPClearHide()
{
    if (typeof delayHide != "undefined") 
    {
         clearTimeout(delayHide);
    }
}

function mvqPDecideHide(e)
{
    if(typeof mvqcb != "undefined") clearTimeout(mvqcb);
    e = (e) ? e : (window.event ? window.event : "");
    if(e)
    {
        if (mvqIsIE && !mvqPTd.contains(e.toElement)) mvqPDelayHide();
        else if (!mvqIsIE && !mvqPCheckParent(e.currentTarget, e.relatedTarget)) mvqPDelayHide();
    }
}

function mvqPDelayHide()
{
    delayHide = setTimeout(mvqPHide, mvqTimeout);
}

function mvqPCheckParent(a, b)
{
    while(b)
    {
        if (b == a) return true;
        b = b.parentNode;
    }
    return false;
}

window.onresize = mvqPDelayHide;
mvqAEvt(window, "load", mvqInit);

function mvqInit()
{
    mvqPTd = document.getElementById("panelTd");
    if(mvqPTd)
    {
        var aElm = mvqPTd.getElementsByTagName("a");
        if(aElm) aElm[0].href = "javascript:void(0)";

        mvqAEvt(mvqPTd, "mouseover", mvqMOv);
        mvqAEvt(mvqPTd, "mouseout", mvqMOu);
        mvqAEvt(mvqPTd, "keypress", mvqKPr);

        if(mvqIsIE)
        {
            mvqAEvt(aElm[0], "focus", mvqMOv);
            mvqAEvt(aElm[0], "focusout", mvqFOu);
        }
        if(!mvqIsIE)
        {
            mvqAEvt(mvqPTd, "focus", mvqMOv);
            mvqAEvt(mvqPTd, "blur", mvqFOu);
        }
    }
}

function mvqAEvt(oName, eName, fName)
{
    if(window.attachEvent) oName.attachEvent("on" + eName, fName);
    if(window.addEventListener) oName.addEventListener(eName, fName, false);
}

function mvqKPr()
{
    var e = (e) ? e : (window.event ? window.event : "");
    if(e)
    {
        if(e.which == 13 && !mvqIsIE || e.keyCode == 13 && mvqIsIE) mvqMOv();
    }
}

function mvqMOv()
{
    if(mvqPTd)
    {
        mvqPTd.className = 'gt1';
        mvqPanel();
    }
}

function mvqMOu()
{
    if(mvqPTd)
    {
        mvqPTd.className = 'gt0';
        if(mvqIsIE) mvqPDecideHide();
        if(!mvqIsIE) mvqPTd.onmouseout = mvqPDecideHide;
    }
}

function mvqFOu()
{
    if(mvqPTd)
    {
        mvqPTd.className = 'gt0';
        if(mvqIsIE) mvqPDecideHide();
        if(!mvqIsIE) mvqPTd.onblur = mvqPDecideHide;
    }
}
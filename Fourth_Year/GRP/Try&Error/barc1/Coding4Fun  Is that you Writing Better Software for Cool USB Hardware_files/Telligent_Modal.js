
Telligent_Modal=new Object();Telligent_Modal._variableName='Telligent_Modal';Telligent_Modal.LoadingHtmlUrl=null;Telligent_Modal.WindowCssClasses=new Array();Telligent_Modal.WindowTitleCssClasses=new Array();Telligent_Modal.WindowCloseCssClasses=new Array();Telligent_Modal.WindowContentCssClasses=new Array();Telligent_Modal.WindowMaskCssClasses=new Array();Telligent_Modal.WindowFooterCssClasses=new Array();Telligent_Modal.WindowResizeCssClasses=new Array();Telligent_Modal.ZIndex=100;Telligent_Modal._isShown=false;Telligent_Modal._initialized=false;Telligent_Modal._modal=null;Telligent_Modal._modalTitle=null;Telligent_Modal._modalClose=null;Telligent_Modal._modalAnimationMask=null;Telligent_Modal._modalMask=null;Telligent_Modal._modalIframe=null;Telligent_Modal._modalResize=null;Telligent_Modal._modalFooter=null;Telligent_Modal._modalContent=null;Telligent_Modal._animationHandle=null;Telligent_Modal._isOpening=false;Telligent_Modal._hiddenSelects=null;Telligent_Modal._checkForScrollResizeHandle=null;Telligent_Modal._lastModalInfo=null;Telligent_Modal._lastWindowInfo=null;Telligent_Modal._isDragging=false;Telligent_Modal._moveModalInfo=null;Telligent_Modal._resizeModalInfo=null;Telligent_Modal._isResizing=false;Telligent_Modal.Configure=function(loadingHtmlUrl,windowCssClasses,windowTitleCssClasses,windowCloseCssClasses,windowContentCssClasses,windowFooterCssClasses,windowResizeCssClasses,windowMaskCssClasses,zIndex)
{this.LoadingHtmlUrl=loadingHtmlUrl;this.WindowCssClasses=windowCssClasses;this.WindowTitleCssClasses=windowTitleCssClasses;this.WindowCloseCssClasses=windowCloseCssClasses;this.WindowContentCssClasses=windowContentCssClasses;this.WindowMaskCssClasses=windowMaskCssClasses;this.WindowFooterCssClasses=windowFooterCssClasses;this.WindowResizeCssClasses=windowResizeCssClasses;this.ZIndex=zIndex;}
Telligent_Modal.IsShown=function()
{return this._isShown;}
Telligent_Modal._getWindowInfo=function()
{var scrollX=0,scrollY=0,width=0,height=0,contentWidth=0,contentHeight=0;if(typeof(window.pageXOffset)=='number')
{scrollX=window.pageXOffset;scrollY=window.pageYOffset;}
else if(document.body&&(document.body.scrollLeft||document.body.scrollTop))
{scrollX=document.body.scrollLeft;scrollY=document.body.scrollTop;}
else if(document.documentElement&&(document.documentElement.scrollLeft||document.documentElement.scrollTop))
{scrollX=document.documentElement.scrollLeft;scrollY=document.documentElement.scrollTop;}
if(typeof(window.innerWidth)=='number')
{width=window.innerWidth;height=window.innerHeight;}
else if(document.documentElement&&(document.documentElement.clientWidth||document.documentElement.clientHeight))
{width=document.documentElement.clientWidth;height=document.documentElement.clientHeight;}
else if(document.body&&(document.body.clientWidth||document.body.clientHeight))
{width=document.body.clientWidth;height=document.body.clientHeight;}
if(document.documentElement&&(document.documentElement.scrollHeight||document.documentElement.offsetHeight))
{if(document.documentElement.scrollHeight>document.documentElement.offsetHeight)
{contentWidth=document.documentElement.scrollWidth;contentHeight=document.documentElement.scrollHeight;}
else
{contentWidth=document.documentElement.offsetWidth;contentHeight=document.documentElement.offsetHeight;}}
else if(document.body&&(document.body.scrollHeight||document.body.offsetHeight))
{if(document.body.scrollHeight>document.body.offsetHeight)
{contentWidth=document.body.scrollWidth;contentHeight=document.body.scrollHeight;}
else
{contentWidth=document.body.offsetWidth;contentHeight=document.body.offsetHeight;}}
else
{contentWidth=width;contentHeight=height;}
if(height>contentHeight)
height=contentHeight;if(width>contentWidth)
width=contentWidth;var rect=new Object();rect.ScrollX=scrollX;rect.ScrollY=scrollY;rect.Width=width;rect.Height=height;rect.ContentWidth=contentWidth;rect.ContentHeight=contentHeight;return rect;}
Telligent_Modal._getCurrentStyleValue=function(element,styleRule,jsStyleRule)
{var value=0;if(document.defaultView&&document.defaultView.getComputedStyle)
value=parseInt(document.defaultView.getComputedStyle(element,"").getPropertyValue(styleRule),0);else if(element.currentStyle)
value=parseInt(element.currentStyle[jsStyleRule],0);if(!isNaN(value))
return value;else
return 0;}
Telligent_Modal._calculateStyleOffset=function(element)
{var result=new Object();result.Height=this._getCurrentStyleValue(element,'border-top-width','borderTopWidth')+
this._getCurrentStyleValue(element,'border-bottom-width','borderBottomWidth')+
this._getCurrentStyleValue(element,'padding-top','paddingTop')+
this._getCurrentStyleValue(element,'padding-bottom','paddingBottom');result.Width=this._getCurrentStyleValue(element,'border-left-width','borderLeftWidth')+
this._getCurrentStyleValue(element,'border-right-width','borderRightWidth')+
this._getCurrentStyleValue(element,'padding-left','paddingLeft')+
this._getCurrentStyleValue(element,'padding-right','paddingRight');return result;}
Telligent_Modal.Open=function(url,width,height,onCloseFunction,x,y,ignoreCloseAndAnimation)
{if(!ignoreCloseAndAnimation&&this._isShown)
this.Close();else if(this._hiddenSelects)
{for(var i=0;i<this._hiddenSelects.length;i++)
{if(this._hiddenSelects[i].Element.style.visibility=='hidden')
this._hiddenSelects[i].Element.style.visibility=this._hiddenSelects[i].Visibility;}
this._hiddenSelects=null;}
if(!this._initialized)
this._initialize();try
{this._modalTitle.childNodes[1].innerHTML=this._modalIframe.contentWindow.document.title;}
catch(err)
{}
if(!ignoreCloseAndAnimation)
this._modalIframe.src=url;try
{this._modalIframe.contentWindow.opener=window;}
catch(err)
{}
this._modalAnimationMask.style.display='none';this._modalMask.style.display='none';this._lastWindowInfo=this._getWindowInfo();this._modalAnimationMask.style.display='block';if(width>this._lastWindowInfo.Width)
width=this._lastWindowInfo.Width;this._modalAnimationMask.style.position='absolute';this._modalAnimationMask.style.zIndex=this.ZIndex;this._modalAnimationMask.style.display='block';this._modalAnimationMask.style.visibility='hidden';this._modalAnimationMask.style.overflow='hidden';this._modalAnimationMask.style.width=width+'px';this._modalContent.style.width=width+'px';this._modal.style.position='absolute';this._modal.style.display='block';this._modal.style.visibility='hidden';this._modal.style.left='0px';this._modal.style.top='0px';this._modalMask.style.position='absolute';this._modalMask.style.display='block';this._modalMask.style.zIndex=this.ZIndex;this._modalMask.style.visibility='visible';var modalContentOffset=this._calculateStyleOffset(this._modalContent);var offset=(this._modal.offsetHeight-this._modalContent.offsetHeight)-modalContentOffset.Height;if(height+offset>this._lastWindowInfo.Height)
height=this._lastWindowInfo.Height-offset;if(width<this._modalResize.offsetWidth*2)
width=this._modalResize.offsetWidth*2;if(width<this._modalClose.offsetWidth*2)
width=this._modalClose.offsetWidth*2;if(height<this._modalTitle.offsetHeight+this._modalFooter.offsetHeight)
height=this._modalTitle.offsetHeight+this._modalFooter.offsetHeight;this._modalIframe.style.height=height+'px';this._modalContent.style.height=height+'px';this._modalContent.style.width=(width-(this._modal.offsetWidth-this._modalContent.offsetWidth)-modalContentOffset.Width)+'px';this._modalAnimationMask.style.width=width+'px';this._modalAnimationMask.style.height=this._modal.offsetHeight+'px';this._modalMask.style.left='0px';this._modalMask.style.top='0px';this._modalMask.style.width=this._lastWindowInfo.ContentWidth+'px';this._modalMask.style.height=this._lastWindowInfo.ContentHeight+'px';this._lastWindowInfo=this._getWindowInfo();var panelWidth=this._modal.offsetWidth;var panelHeight=this._modal.offsetHeight;var animatePropertyName,animateTargetValue,animateNextValue;if(typeof(x)=='undefined'||isNaN(parseInt(x,10)))
x=((this._lastWindowInfo.Width-panelWidth)/2)+this._lastWindowInfo.ScrollX;if(x+panelWidth>this._lastWindowInfo.Width+this._lastWindowInfo.ScrollX)
x=this._lastWindowInfo.Width+this._lastWindowInfo.ScrollX-panelWidth;if(x<this._lastWindowInfo.ScrollX)
x=this._lastWindowInfo.ScrollX;if(typeof(y)=='undefined'||isNaN(parseInt(y,10)))
y=((this._lastWindowInfo.Height-panelHeight)/2)+this._lastWindowInfo.ScrollY;if(y+panelHeight>this._lastWindowInfo.Height+this._lastWindowInfo.ScrollY)
y=this._lastWindowInfo.Height+this._lastWindowInfo.ScrollY-panelHeight;if(y<this._lastWindowInfo.ScrollY)
y=this._lastWindowInfo.ScrollY;this._modalAnimationMask.style.left=x+'px';this._modalAnimationMask.style.top=y+'px';animateTargetValue=0;animateNextValue=-panelHeight;this._modal.style.visibility='visible';this._modalAnimationMask.style.visibility='visible';this._modalAnimationMask.style.overflow='hidden';if(this._modalAnimationMask.getClientRects)
{var selectBoxes=document.getElementsByTagName('select');this._hiddenSelects=new Array();for(var i=0;i<selectBoxes.length;i++)
{this._hiddenSelects[this._hiddenSelects.length]={Element:selectBoxes[i],Visibility:selectBoxes[i].style.visibility};selectBoxes[i].style.visibility='hidden';}}
this._isOpening=true;if(ignoreCloseAndAnimation)
this._animationHandle=window.setTimeout(new Function(this._variableName+'._animate(0,0,0,0);'),9);else
{this._modalIframe.style.display='none';this._animate(0,-panelHeight,panelHeight/3,.67);}
this._lastModalInfo={Url:this._modalIframe.src,OnCloseFunction:onCloseFunction,X:x,Y:y,Width:parseInt(width,10),Height:parseInt(height,10)};this._isShown=true;}
Telligent_Modal._checkForScrollResize=function()
{if(this._checkForScrollResizeHandle)
window.clearTimeout(this._checkForScrollResizeHandle);if(this._isShown&&!this._isOpening&&this._lastWindowInfo)
{try
{this._modalTitle.childNodes[1].innerHTML=this._modalIframe.contentWindow.document.title;}
catch(err)
{}
var windowInfo=this._getWindowInfo();if(windowInfo.ScrollX!=this._lastWindowInfo.ScrollX||windowInfo.ScrollY!=this._lastWindowInfo.ScrollY||windowInfo.Width!=this._lastWindowInfo.Width||windowInfo.Height!=this._lastWindowInfo.Height)
this.Open(null,this._lastModalInfo.Width,this._lastModalInfo.Height,this._lastModalInfo.OnCloseFunction,this._lastModalInfo.X,this._lastModalInfo.Y,true);else
this._checkForScrollResizeHandle=window.setTimeout(new Function('window.'+this._variableName+'._checkForScrollResize();'),999);}}
Telligent_Modal.Close=function(returnValue)
{if(this._isShown)
{if(!this._initialized)
this._initialize();this._modal.style.position='absolute';this._modal.style.display='none';this._modalAnimationMask.style.position='absolute';this._modalAnimationMask.style.display='none';this._modalMask.style.position='absolute';this._modalMask.style.display='none';this._modalIframe.src=this.LoadingHtmlUrl;var onCloseFunction=this._lastModalInfo.OnCloseFunction;this._isShown=false;this._lastModalInfo=null;this._windowInfo=null;if(this._hiddenSelects)
{for(var i=0;i<this._hiddenSelects.length;i++)
{if(this._hiddenSelects[i].Element.style.visibility=='hidden')
this._hiddenSelects[i].Element.style.visibility=this._hiddenSelects[i].Visibility;}
this._hiddenSelects=null;}
if(onCloseFunction)
onCloseFunction(returnValue);this.Dispose();}}
Telligent_Modal.Refresh=function()
{if(this._animationHandle)
window.clearTimeout(this._animationHandle);this.Dispose();if(this._isShown&&this._lastModalInfo)
this.Open(this._lastModalInfo.Url,this._lastModalInfo.Width,this._lastModalInfo.OnCloseFunction,this._lastModalInfo.Height,this._lastModalInfo.OnCloseFunction,this._lastModalInfo.X,this._lastModalInfo.Y);}
Telligent_Modal._initialize=function()
{this._modalMask=document.createElement('div');this._modalMask.style.width='auto';this._modalMask.style.height='auto';this._modalMask.style.position='absolute';this._modalMask.style.display='none';var mm=this._modalMask;if(this.WindowMaskCssClasses.length>0)
{mm.className=this.WindowMaskCssClasses[0];for(var i=1;i<this.WindowMaskCssClasses.length;i++)
{mm.appendChild(document.createElement('div'));mm=mm.childNodes[0];mm.className=this.WindowMaskCssClasses[i];mm.style.width='auto';mm.style.height='auto';}}
document.body.appendChild(this._modalMask);this._modalAnimationMask=document.createElement('div');this._modalAnimationMask.style.position='absolute';this._modalAnimationMask.style.display='none';this._modalAnimationMask.style.overflow='hidden';this._modal=document.createElement('div');this._modal.style.width='auto';this._modal.style.height='auto';this._modal.style.position='absolute';this._modal.style.display='none';var m=this._modal;if(this.WindowCssClasses.length>0)
{m.className=this.WindowCssClasses[0];for(var i=1;i<this.WindowCssClasses.length;i++)
{m.appendChild(document.createElement('div'));m=m.childNodes[0];m.className=this.WindowCssClasses[i];m.style.width='auto';m.style.height='auto';}}
this._modalTitle=document.createElement('div');m.appendChild(this._modalTitle);if(this.WindowTitleCssClasses.length>0)
{this._modalTitle.className=this.WindowTitleCssClasses[0];for(var i=1;i<this.WindowTitleCssClasses.length;i++)
{this._modalTitle.appendChild(document.createElement('div'));this._modalTitle=this._modalTitle.childNodes[0];this._modalTitle.className=this.WindowTitleCssClasses[i];}}
this._modalTitle.onmousedown=new Function('event','window.'+this._variableName+'._startDrag(event); return false;');this._modalClose=document.createElement('div');this._modalTitle.appendChild(this._modalClose);var mc=this._modalClose;if(this.WindowCloseCssClasses.length>0)
{mc.className=this.WindowCloseCssClasses[0];for(var i=1;i<this.WindowCloseCssClasses.length;i++)
{mc.appendChild(document.createElement('div'));mc=mc.childNodes[0];mc.className=this.WindowCloseCssClasses[i];}}
this._modalClose.onclick=new Function('window.'+this._variableName+'.Close();');this._modalTitle.appendChild(document.createElement('span'));var e=document.createElement('div');e.style.clear='both';this._modalTitle.appendChild(e);this._modalContent=document.createElement('div');m.appendChild(this._modalContent);if(this.WindowContentCssClasses.length>0)
{this._modalContent.className=this.WindowContentCssClasses[0];for(var i=1;i<this.WindowContentCssClasses.length;i++)
{this._modalContent.appendChild(document.createElement('div'));this._modalContent=this._modalContent.childNodes[0];this._modalContent.className=this.WindowContentCssClasses[i];}}
this._modalIframe=document.createElement('iframe');this._modalIframe.src=this.LoadingHtmlUrl;this._modalIframe.width='100%';this._modalIframe.border='0';this._modalIframe.frameBorder='no';this._modalIframe.style.borderLeftWidth='0px';this._modalIframe.style.borderRightWidth='0px';this._modalIframe.style.borderTopWidth='0px';this._modalIframe.style.borderBottomWidth='0px';this._modalContent.appendChild(this._modalIframe);this._modalFooter=document.createElement('div');m.appendChild(this._modalFooter);var mf=this._modalFooter;if(this.WindowFooterCssClasses.length>0)
{mf.className=this.WindowFooterCssClasses[0];for(var i=1;i<this.WindowFooterCssClasses.length;i++)
{mf.appendChild(document.createElement('div'));mf=mf.childNodes[0];mf.className=this.WindowFooterCssClasses[i];}}
this._modalResize=document.createElement('div');mf.appendChild(this._modalResize);var e=document.createElement('div');e.style.clear='both';mf.appendChild(e);var mr=this._modalResize;if(this.WindowResizeCssClasses.length>0)
{mr.className=this.WindowResizeCssClasses[0];for(var i=1;i<this.WindowResizeCssClasses.length;i++)
{mr.appendChild(document.createElement('div'));mr=mr.childNodes[0];mr.className=this.WindowResizeCssClasses[i];}}
this._modalResize.onmousedown=new Function('event','window.'+this._variableName+'._startResize(event); return false;');this._modalAnimationMask.appendChild(this._modal);document.body.appendChild(this._modalAnimationMask);this._initialized=true;}
Telligent_Modal.Dispose=function()
{if(this._initialized)
{if(this._animationHandle)
window.clearTimeout(this._animationHandle);this._isShown=false;this._isOpening=false;if(document&&document.body)
{document.body.removeChild(this._modalAnimationMask);document.body.removeChild(this._modalMask);this._modalClose.onclick=null;this._modalTitle.onmousedown=null;this._modalResize.onmousedown=null;this._modal=null;this._modalTitle=null;this._modalClose=null;this._modalAnimationMask=null;this._modalMask=null;this._modalIframe=null;this._modalResize=null;this._modalFooter=null;this._modalContent=null;}
this._initialized=false;}}
Telligent_Modal._animate=function(targetValue,nextValue,step,acceleration)
{if(this._animationHandle)
window.clearTimeout(this._animationHandle);if(!this._isOpening)
return;var currValue=parseInt(this._modal.style.top,10);if((step<0&&currValue<targetValue)||(step>0&&currValue>targetValue)||Math.abs(step)<1)
{if(this._hiddenSelects)
{for(var i=0;i<this._hiddenSelects.length;i++)
this._hiddenSelects[i].Element.style.visibility='hidden';}
this._modal.style.top=targetValue+'px';this._modal.style.position='static';this._modalAnimationMask.style.overflow='visible';this._animationHandle=null;if(!this._isResizing&&!this._isDragging)
this._modalIframe.style.display='block';this._isOpening=false;this._lastWindowInfo=this._getWindowInfo();this._checkForScrollResizeHandle=window.setTimeout(new Function('window.'+this._variableName+'._checkForScrollResize();'),999);}
else
{this._modal.style.top=nextValue+'px';nextValue=nextValue+step;if(step>0&&nextValue>targetValue)
nextValue=targetValue;else if(step<0&&nextValue<targetValue)
nextValue=targetValue;step=step*acceleration;this._animationHandle=window.setTimeout(new Function(this._variableName+'._animate('+targetValue+','+nextValue+','+step+','+acceleration+');'),19);}}
Telligent_Modal._startDrag=function(event)
{if(!this._initialized)
this._initialize();if(!event)
event=window.event;this._moveModalInfo=new Object();this._moveModalInfo.StartMouseX=event.pageX?event.pageX:event.screenX;this._moveModalInfo.StartMouseY=event.pageY?event.pageY:event.screenY;this._moveModalInfo.StartModalX=this._lastModalInfo.X;this._moveModalInfo.StartModalY=this._lastModalInfo.Y;this._moveModalInfo.Button=event.button;document.onmouseup=new Function('event','window.'+this._variableName+'._endDrag(event); return false;');document.onmousemove=new Function('event','window.'+this._variableName+'._drag(event); return false;');this._modalIframe.style.display='none';this._isDragging=true;}
Telligent_Modal._endDrag=function(event)
{if(!this._initialized)
this._initialize();this._isDragging=false;this._moveModalInfo=null;document.onmouseup=null;document.onmousemove=null;this._modalIframe.style.display='block';}
Telligent_Modal._drag=function(event)
{if(!this._initialized)
this._initialize();if(!event)
event=window.event;if(event.button!=this._moveModalInfo.Button)
{this._endDrag(event);return;}
var eventX=typeof(event.pageX)!='undefined'?event.pageX:event.screenX;var eventY=typeof(event.pageY)!='undefined'?event.pageY:event.screenY;var xChange=eventX-this._moveModalInfo.StartMouseX;var yChange=eventY-this._moveModalInfo.StartMouseY;this.Open(null,this._lastModalInfo.Width,this._lastModalInfo.Height,this._lastModalInfo.OnCloseFunction,this._moveModalInfo.StartModalX+xChange,this._moveModalInfo.StartModalY+yChange,true);}
Telligent_Modal._startResize=function(event)
{if(!this._initialized)
this._initialize();if(!event)
event=window.event;this._resizeModalInfo=new Object();this._resizeModalInfo.StartMouseX=event.pageX?event.pageX:event.screenX;this._resizeModalInfo.StartMouseY=event.pageY?event.pageY:event.screenY;this._resizeModalInfo.StartModalWidth=this._lastModalInfo.Width;this._resizeModalInfo.StartModalHeight=this._lastModalInfo.Height;this._resizeModalInfo.Button=event.button;document.onmouseup=new Function('event','window.'+this._variableName+'._endResize(event); return false;');document.onmousemove=new Function('event','window.'+this._variableName+'._resize(event); return false;');this._modalIframe.style.display='none';this._isResizing=true;}
Telligent_Modal._endResize=function(event)
{if(!this._initialized)
this._initialize();this._isResizing=false;this._resizeModalInfo=null;document.onmouseup=null;document.onmousemove=null;this._modalIframe.style.display='block';}
Telligent_Modal._resize=function(event)
{if(!this._initialized)
this._initialize();if(!event)
event=window.event;if(event.button!=this._resizeModalInfo.Button)
{this._endResize(event);return;}
var eventX=typeof(event.pageX)!='undefined'?event.pageX:event.screenX;var eventY=typeof(event.pageY)!='undefined'?event.pageY:event.screenY;var xChange=eventX-this._resizeModalInfo.StartMouseX;var yChange=eventY-this._resizeModalInfo.StartMouseY;this.Open(null,this._resizeModalInfo.StartModalWidth+xChange,this._resizeModalInfo.StartModalHeight+yChange,this._lastModalInfo.OnCloseFunction,this._lastModalInfo.X,this._lastModalInfo.Y,true);}
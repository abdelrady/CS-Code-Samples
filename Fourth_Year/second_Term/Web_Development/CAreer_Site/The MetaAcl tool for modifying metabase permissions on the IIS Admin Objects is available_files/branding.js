﻿




var gsfx_brnd_surroundingheight=0;var gsfx_brnd_resizeContentArea=function(){var ca=MS_GetEl('contentArea');var pc=MS_GetEl('gsfx_brnd_PageContainer');if(ca&&pc){if(!gsfx_brnd_surroundingheight){gsfx_brnd_surroundingheight=0;for(var i=0;i<pc.childNodes.length;i++){
 
 if(pc.childNodes[i].nodeType===1&&pc.childNodes[i].id!='gsfx_brnd_ContentContainer'&&pc.childNodes[i].id!='gsfx_brnd_PageHeaderImage'){gsfx_brnd_surroundingheight+=pc.childNodes[i].offsetHeight;}}}var bh=BrowserHW().height;if(bh>gsfx_brnd_surroundingheight){bh=(bh>450)? bh : 450;pc.style.height=bh;ca.style.height=bh - gsfx_brnd_surroundingheight;}}};


var gsfx_brnd_resizetimer=setInterval(gsfx_brnd_resizeContentArea,250);
function gsfx_brnd_CreateLeftNavFlyout(el,doMatte){if(typeof(el)==='string'){el=document.getElementById(el);}if(!el){return;}var btype=0;var msin='mouseenter';var msout='mouseleave';if(window.attachEvent&&/MSIE/.test(navigator.userAgent)){btype=1;}else if(window.addEventListener){btype=2;msin='mouseover';msout='mouseout';}else {return;}if (/MSIE ([1-6])/.test(navigator.userAgent)){doMatte=true;}var menuItems=el.getElementsByTagName('li');for(var i=0;i<menuItems.length;i++){var hasUL=menuItems[i].getElementsByTagName('UL')[0];if(hasUL){menuItems[i].className+=' gsfx_lnav_upmenu gsfx_lnav_submenu';var mdiv=document.createElement('div');mdiv.className='gsfx_lnav_menulink';var linknode=menuItems[i].getElementsByTagName('a')[0];var linknodechildren=linknode.childNodes;linknode.insertBefore(mdiv,linknodechildren[0]);var mover=function(event){var e=(btype===1)? srcEl(event): this;e.className=e.className.replace(/( ?|^)gsfx_lnav_upmenu\b/gi,'gsfx_lnav_dropmenu');gsfx_brnd_MoveFlyout(e);};var mout=function(event){var e=(btype===1)? srcEl(event): this;e.className=e.className.replace(/( ?|^)gsfx_lnav_dropmenu\b/gi,'gsfx_lnav_upmenu');};MS_AddEvent(menuItems[i],msin,mover);MS_AddEvent(menuItems[i],msout,mout);if(doMatte===true){var ifMatte=document.createElement('IFRAME');ifMatte.className='gsfx_lnav_iframeMatte';ifMatte.style.height=(hasUL.offsetHeight+2)+'px';ifMatte.style.width=(hasUL.offsetWidth+2)+'px';hasUL.insertBefore(ifMatte,hasUL.firstChild);}}else{menuItems[i].className+=' gsfx_lnav_nomenu';}}}MS_AddEvent(window,'load',function(){gsfx_brnd_CreateLeftNavFlyout('gsfx_lnav_LeftNav');});


function gsfx_brnd_MoveFlyout(e){var flyout=srcEl(e);if(flyout){var hasUL=flyout.getElementsByTagName('UL')[0];if(hasUL){var hw=BrowserHW();var fp=AbsPos(flyout);var y=(window.event)? document.documentElement.scrollTop+document.body.scrollTop : window.scrollY;if((fp.top+hasUL.offsetHeight - y)>hw.height){hasUL.style.top=-((fp.top+hasUL.offsetHeight)-(hw.height+y))+'px';}else{hasUL.style.top="0px";}}}}
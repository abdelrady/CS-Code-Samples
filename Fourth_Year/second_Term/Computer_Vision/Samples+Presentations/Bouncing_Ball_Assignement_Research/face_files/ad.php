var AD_timerCloseAll=0,AD_timerCloseAd=0,AD_timerRido=0,AD_timerFade=0,AD_opacity=0,AD_closedAd=0;
var AD_windowWidth=0,AD_windowHeight=0;
var AD_swapDiv='ADIMG';
var AD_layers=new Array('ADHEAD','ADIMG');

/***************** redirect *****************/

myreg=new RegExp("lycos\.it","i");
if ( !myreg.test("'"+top.location+"'") ) {
	nwreg=new RegExp ("http://([^/]+)?(/([a-z0-9A-Z\-\_]+)?[^']+)","i");
	rn=nwreg.exec("'"+self.location+"'");
	if (parent.frames.length==2) { top.location="http://" + rn[1] + rn[2]; }
	else { top.location="http://" + rn[1] + "/" + rn[3]; }
}

/***************** frameset *****************/

function AD_clientWindowSize() {
	var sfMax=0;
	var sf,frameMax;
	var ad=1;

	if (self.innerWidth) {
		AD_windowWidth=self.innerWidth;
		AD_windowHeight=self.innerHeight;
	} else if (document.documentElement && document.documentElement.clientWidth) {
		AD_windowWidth=document.documentElement.clientWidth;
		AD_windowHeight=document.documentElement.clientHeight;
	} else if (document.body) {
		AD_windowWidth=document.body.clientWidth;
		AD_windowHeight=document.body.clientHeight;
	}
	if (document.layers||navigator.userAgent.toLowerCase().indexOf("gecko")>=0) AD_windowWidth-=16;

	if ( top !=self || top.frames.length !=0 ) {
		ad=0;
		if (document.all) {
			sf=(top.document.body.clientWidth * top.document.body.clientHeight) / (self.document.body.clientWidth * self.document.body.clientHeight);
			if (sf<3) {
				ad=1;
			}
		} else {
			function getSurface(w) {
				try{
						if (!w.sf) w.sf=w.innerWidth * w.innerHeight;
						if (w.sf >=sfMax) { sfMax=w.sf; frameMax=w; }
				} catch(err){};
			}
			function findFrameMax(w) {
				var i;
				if (w.frames.length==0) getSurface(w);
				else for (i=0; i < w.frames.length; i++) { if (w.frames[i].frames.length > 0) { findFrameMax(w.frames[i]); } else { getSurface(w.frames[i]); } }
			}
			if ((top !=self) || (top.frames.length==0)) {
				findFrameMax(top);
				if (frameMax==self) ad=1;
			}
		}
	}

	if (AD_windowWidth<480) ad=0;
	if (AD_windowHeight<80) ad=0;

	return ad;
}

/***************** layers functions *****************/

function AD_findObj(n, d) {
	var p,i,x;	if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
		d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
	if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
	for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=AD_findObj(n,d.layers[i].document);
	if(!x && document.getElementById) x=document.getElementById(n); return x;
}

function AD_showHideLayers() {
	var i,p,v,obj,args=AD_showHideLayers.arguments;
	for (i=0; i<(args.length-1); i+=2) if ((obj=AD_findObj(args[i]))!=null) { v=args[i+1];
		if (obj.style) { obj=obj.style; v=(v=='show')?'visible':(v='hide')?'hidden':v; }
		obj.visibility=v; }
}

function AD_transitionIE(action) {
	if (document.all) {
		var i=0;
		for(i=0;i<AD_layers.length;i++) {
			obj=AD_findObj(AD_layers[i]);
			if (action=='play') {
				if (obj.style) {
					if (obj.style.visibility=='visible') {
						obj.style.filter="revealTrans(duration=1,transition=-1)";
						obj.style.visibility='hidden';
						obj.filters.revealTrans.stop();
						obj.filters.revealTrans.apply();
						obj.filters.revealTrans.play();
						obj.style.visibility='visible';
					}
				}
			} else if (action=='stop') {
				if (obj.filters&&obj.filters.revealTrans) {
					obj.filters.revealTrans.stop();
					obj.style.filter="";
				}
			}
		}
	}
}

function AD_fade(fadeStep) {
	if (AD_timerFade) clearTimeout(AD_timerFade);
	var i=0;
	for(i=0;i<AD_layers.length;i++) {
		obj=AD_findObj(AD_layers[i]);
		AD_opacity=AD_opacity + fadeStep;
		if(obj.style){
			if (obj.filters) {
				if (obj.style.filter) {
					obj.filters.alpha.opacity=AD_opacity;
				} else {
					obj.style.filter="alpha(opacity=0)";
					obj.filters.alpha.opacity=AD_opacity;
				}
			} else {
				obj.style.MozOpacity=0;
				obj.style.MozOpacity=AD_opacity/100;
			}
		}
		if(AD_opacity<100 && AD_opacity>0) {
			AD_timerFade=setTimeout('AD_fade('+fadeStep+')',100);
		}
	}
}

function AD_setPos(layer,left,top) {
	var obj=AD_findObj(layer);

	if (obj.style) {
		if (document.all) {
			if (left!='') obj.style.pixelLeft=left;
			if (top!='') obj.style.pixelTop=top;
		} else {
			if (left!='') obj.style.left=left;
			if (top!='') obj.style.top=top;
		}
	} else {
		if (left!='') obj.left=left;
		if (top!='') obj.top=top;
	}
}

function AD_rido(i,bound,way) {
	if (AD_timerRido) clearTimeout(AD_timerRido);
	else AD_showHideLayers('ADCLOSE','hide','ADHEAD','show',AD_swapDiv,'show');
	if (i>bound) i=bound;
	switch (way) {
		case 1: AD_setPos(AD_swapDiv,AD_windowWidth-i,''); break;
		case 2: AD_setPos(AD_swapDiv,'',i); break;
		case 3: AD_setPos(AD_swapDiv,i,''); break;
		case 4: AD_setPos(AD_swapDiv,'',AD_windowHeight-i);	break;
	}
	if (i!=bound) AD_timerRido=setTimeout("AD_rido("+(i+15)+","+bound+","+way+")",10);
}


/***************** events *****************/

function AD_closeAll() {
	if (AD_timerCloseAll) clearTimeout(AD_timerCloseAll);
	if (AD_timerCloseAd) clearTimeout(AD_timerCloseAd);
	AD_showHideLayers(AD_swapDiv,'hide','ADHEAD','hide','ADCLOSE','hide');
	AD_closedAd=2;
}

function AD_close() {
	if (AD_timerFade) clearTimeout(AD_timerFade);
	if (AD_timerRido) clearTimeout(AD_timerRido);
	if (AD_timerCloseAll) clearTimeout(AD_timerCloseAll);
	if (AD_timerCloseAd) clearTimeout(AD_timerCloseAd);
			
	AD_showHideLayers(AD_swapDiv,'hide','ADHEAD','hide','ADCLOSE','show');
	AD_timerCloseAll=setTimeout("AD_closeAll()",10000);
	AD_closedAd=1;
}

function AD_closeWarning() {
	if (AD_swapDiv!='ADIMG') {
		AD_showHideLayers(AD_swapDiv,'hide');
		if (AD_closedAd==0) AD_showHideLayers('ADIMG','show');
		AD_swapDiv='ADIMG';
	}
}

function AD_start() {
	AD_closedAd=0;
	if (AD_timerStart) clearTimeout(AD_timerStart);
		AD_showHideLayers('ADCLOSE','hide','ADHEAD','show',AD_swapDiv,'show');

		if (AD_timerFade) clearTimeout(AD_timerFade);
	if (AD_timerCloseAll) clearTimeout(AD_timerCloseAll);
	if (AD_timerCloseAd) clearTimeout(AD_timerCloseAd);
	AD_timerCloseAd=setTimeout("AD_close()",15000);
}

function AD_reloadPage(init) {
	//reloads the window if NS4 resized
	if (init==true) with (navigator) {
		if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
			document.pgW=innerWidth; document.pgH=innerHeight;
			onresize=AD_reloadPage;
		}
	} else if (innerWidth!=document.pgW || innerHeight!=document.pgH) {
		if (AD_closedAd==0) location.reload();
	}

	if (AD_clientWindowSize) {
		AD_setPos('ADCLOSE',AD_windowWidth-300,'');

		AD_setPos('ADIMG',AD_windowWidth-750,'');
	}
}

/***************** init layers *****************/

function AD_drawLayers() {

document.writeln('<style type="text/css">\n.adstyle1 {font-family:verdana,helvetica,arial;font-size:10px;color:white;font-weight:bold;text-decoration:none;}\n.adstyle2 {font-family:verdana,helvetica,arial;font-size:12px;color:white;font-weight:bold;text-decoration:none;}\n.adstyle3 {font-family:verdana,helvetica,arial;font-size:12px;color:black;font-weight:normal;text-decoration:none;}\n</style>\n');

document.writeln('<div id="ADCLOSE" style="position:absolute; width:300px; height: 14px; left:0px; top:0px; visibility:hidden; z-index:1000; overflow: hidden;">');
document.writeln('<table border="0" cellpadding="0" cellspacing="0" width="300" height="14"><tr>'+
'<td width="48" height="14"  align=right valign=top rowspan=2 class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_replay_lycos.gif" border="0" width="48" height="14"></td>'+
'<td height="13"  bgcolor=#0099CC  align=center valign=top nowrap class="adstyle1"><a href="javascript:void(0)" onclick="AD_start()" class="adstyle1">Guarda la pubblicit&aacute;</a></td>'+
'<td width="20" height="13"  bgcolor=#0099CC  align=right valign=top class="adstyle1"><a href="javascript:void(0)" onclick="AD_start()" class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_replay_fleche.gif" border="0" width="20" height="13"></a></td>'+
'</tr><tr><td bgcolor="#000000" colspan="2"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_vide.gif" border="0" width="1" height="1"></td></tr></table>');
document.writeln('</div>');

document.writeln('<div id="ADHEAD" style="position:absolute; top:0px; left:0px; visibility:hidden; z-index:1001;">'+
'<table border="0" cellpadding="0" cellspacing="0" width="'+AD_windowWidth+'" height="23" bgcolor="#0099CC"><tr>'+
'<td width="82" height="22" align=left class="adstyle1"><a href="http://www.lycos.it" target="ad_url" class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_lycos.gif" border="0" width="82" height="22"></a></td>'+
'<td width="74" height="22" align=left class="adstyle1"><a href="http://www.tripod.lycos.it" target="ad_url" class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_tripod.gif" border="0" width="74" height="22"></a></td>'+
'<td width="21" height="22" align=center nowrap class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_onglet.gif" border="0" width="21" height="22"></td>'+
'<td height="22" align=center nowrap class="adstyle1">&nbsp;</td>'+
'<td width="21" height="22" align=center nowrap class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_onglet.gif" border="0" width="21" height="22"></td>'+
'<td height="22" align=center nowrap class="adstyle1"><a href="http://love.lycos.it" target="ad_url" class="adstyle1">Cerchi incontri divertenti e stuzzicanti? Love@Lycos!</a></td>'+
'<td width="21" height="22" align=center nowrap class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_onglet.gif" border="0" width="21" height="22"></td>'+
'<td height="22" align=center nowrap class="adstyle1">&nbsp;</td>'+
'<td height="22"  align=right class="adstyle1"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_fleche.gif" border="0" height="22"></td>'+
'</tr><tr><td bgcolor="#000000" colspan="9"><img src="http://ads.tripod.lycos.it/ad/img/it/pub_vide.gif" border="0" width="1" height="1"></td></tr></table>'+
'</div>');

// skin 0
document.writeln('<div id="ADIMG" style="position:absolute; top:23px; left:0px; width:750px; visibility:hidden; z-index:1003;">'+
'<table width="750" border="0" cellspacing="0" cellpadding="0">'+
'<tr><td width="750" align="center" valign="middle">');

document.writeln('<div id="AD" style="width:750px; overflow: hidden; text-align: right;">');

document.writeln("<iframe name=\"adcreative\" id=\"adcreative\" src=\"http://ads.tripod.lycos.it/ad/adlink_src.php?cc=it&adCat=\" width=\"750\" height=\"600\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" vspace=\"0\" hspace=\"0\" scrolling=\"no\" allowTransparency=\"true\"></iframe>");
document.writeln('</div></td>'+
'</tr>'+
'</table></div>');
document.writeln('<iframe src="http://fe.lea.lycos.it/html.ng/grp=build_a_site&country=it&affiliate=ittripod&svc=hosting&adpos=1&ee=1&params.styles=img-tr&btype=7&ts=2046619719?" width="1" height="1" frameborder="0" border="0"></iframe>');

AD_reloadPage(true);
AD_timerStart=setTimeout("AD_start()",1000);
}

if (AD_clientWindowSize()) AD_drawLayers();


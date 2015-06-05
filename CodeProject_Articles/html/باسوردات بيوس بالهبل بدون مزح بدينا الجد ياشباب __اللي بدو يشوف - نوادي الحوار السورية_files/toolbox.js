
////////////////////////// set default parameters //////////////////////////
function poem_setDefaultVar() {
  poemDefaultFont = "simplified arabic,tahoma,ms sans serif,verdana,arial,helvetica";  

  poemType = "0",
  poemAlign = "center",
  poemLine = "0";
  poemUse = "ex";

  poemFontName = "",
  poemFontSize = "4",  // 1 to 7
  poemFontColor = "",
  poemFontBold = "",
  poemFontItalic = "";

  poemBackColor = "none",
  poemBackImage = "none";

  poemBorderStyle = "none",
  poemBorderWidth = "4",
  poemBorderColor = "gray";

  poemSerialNum = "0",
  poemSerialNumColor = "";  

}

//////////////////////////////////////////////////////////////////////////           
  var poemSpaceWidth, poemExtendWidth;
  var poemToolFix, poemPrevHTML, poemMargin, poemPadding;
            
  var poemLetters1 = "«√≈¬ƒ¡œ–—“Ê…Ï"
  var poemLetters2 = "«√≈¬ƒ∆» ÀÃÕŒœ–—“”‘’÷ÿŸ⁄€›ﬁﬂ·„‰ÂÊÌ…Ï";
  var poemLetters3 = "ÛıÒˆÚ˙¯";

  function create_poemTestWidth_table() {
    if (!document.getElementById("poemtestWidth")) {
      var HTML = "<table border=1 width=1px style='visibility:hidden;position:absolute'>";
      HTML += "<tr><td id='poemTestWidth' width='0px' nowrap></td></tr>";
      HTML += "</table>";
      document.body.insertAdjacentHTML("afterBegin", HTML);
    }
  }

  function poem_getValue(t, p) {
    var r = new RegExp("([ \"]|^)" + t + "[ ]*=[ ]*\"[^\"]*\"", "i");
    var m = p.match(r);    
    if (!m) {
      r = new RegExp("([ \"]|^)" + t + "[ ]*=[ ]*[^\" ]*([ ]|$)", "i");
      m = p.match(r);
      if (!m)          
        return "";
    }
    m = m[0];
    m = m.replace(/\"/gi,"");    
    var i = m.search("=");
    return m.substring(i + 1);
  }

  function poem_getDefault(p, d) {
	  var r = ((p)?p:d);
	  return poem_trim(r);
  }
    
  function poem_setArg(arg) {        
    var par, poemFontSize2;

    par = poem_getValue("font", arg) + ",,,,";  //comas = number of arrays - 1
    par = par.split(",");
    poemFontName = poem_getDefault(par[0], poemFontName);
	poemFontName = poemFontName.replace(/\-/g, ",");
    poemFontSize2 = parseInt(poem_getDefault(par[1], poemFontSize));
	if (isNaN(poemFontSize2))
		poemFontSize2 = 0;
	if (poemFontSize2 < 1 || poemFontSize2 > 7)
		poemFontSize2 = poemFontSize;
	poemFontSize = poemFontSize2;

    poemFontColor = poem_getDefault(par[2], poemFontColor);
    poemFontBold = poem_getDefault(par[3], poemFontBold);
    poemFontItalic = poem_getDefault(par[4], poemFontItalic);

    par = poem_getValue("border", arg) + ",,";
    par = par.split(",");
    poemBorderStyle = poem_getDefault(par[0], poemBorderStyle);
    poemBorderWidth = poem_getDefault(par[1], poemBorderWidth);
    poemBorderColor = poem_getDefault(par[2], poemBorderColor);

    par = poem_getValue("num", arg) + ",";	
	par = par.split(",");
    poemSerialNum = poem_getDefault(par[0], poemSerialNum);
	if (!poemSerialNum)
		poemSerialNum = 0;
	else {
		poemSerialNum = parseInt(poemSerialNum);
		if (isNaN(poemSerialNum))
			poemSerialNum = 0;
	}
    poemSerialNumColor = poem_getDefault(par[1], poemSerialNumColor);

    par = poem_getValue("type", arg);
    poemType = poem_getDefault(par, poemType);

    par = poem_getValue("align", arg);
    poemAlign = poem_getDefault(par, poemAlign).toLowerCase();

    par = poem_getValue("line", arg);
    poemLine = poem_getDefault(par, poemLine);
	poemLine = parseInt(poemLine);
	if (isNaN(poemLine))
		poemLine = 0;
	if (poemLine == 0) {
		poemPadding = "5px";
		poemMargin = "";
	} else {
		poemPadding = 15;
		poemMargin = "margin-bottom:" + poemPadding;
	}

    par = poem_getValue("use", arg);
    poemUse = poem_getDefault(par, poemUse).toLowerCase();

    par = poem_getValue("bkcolor", arg);
    poemBackColor = poem_getDefault(par, poemBackColor);

    par = poem_getValue("bkimage", arg);
    poemBackImage = poem_getDefault(par, poemBackImage);

    //////////// set style ///////////
    var facesize = new Array("xx-small","x-small","small","medium","large","x-large","xx-large");
    poemFontSize = facesize[poemFontSize - 1];

    poemFontName += "," + poemDefaultFont;

    poemTestWidth.style.fontFamily = poemFontName;
    poemTestWidth.style.fontSize = poemFontSize;
    poemTestWidth.style.fontWeight = poemFontBold;
    poemTestWidth.style.fontStyle = poemFontItalic;

    ///////////////////////////////////
  }
  
  function poem_trim(t) {
    t = t.replace(/^[ ]+/, "");
    t = t.replace(/[ ]+$/, "");
    return t;
  }
  
  function poem_textWidth(t) {
	t = t.replace(/ /g, "&nbsp;");
	t = t.replace(/\^/g, "");
	poemTestWidth.innerHTML= t;	
    return (poemTestWidth.clientWidth - 2) * 0.75;
  }
  
  function poem_strReplace(t, s1, s2, c) {
	if (c <= 0) 
	  return;
    t=t.split(s1);
    var s="";
    for (var i=t.length-1;i>0;i--)
	  if (c-->0)
        s = s2 + t[i] + s;
	  else
		s = s1 + t[i] + s;

	s = t[0] + s;
    return s;
  }
  
  function poem_count(str, ch) {
    var c = 0;
    for (var i = 0; i < str.length; i++)
      c += (str.charAt(i) == ch);
    return c;
  }

  function poem_space(n) {
    if (n == 1)
      return " ";
    return  " " + poem_space(n-1);
  }
  
  function poem_createExtend(t) {
    var alef = "«√≈¬";
    var s = "";
    var befor = "", ch = "";
    t = t.replace(/«··Â/g,"alh");
	t = t.replace(/··Â/g,"lah");
    for (i = 0; i < t.length; i++) {
      ch = t.charAt(i);
      if (poemLetters2.indexOf(ch.charAt(0)) != -1 || ch.charAt(0) == "¡") {        
        if (befor != "")
          if (poemLetters1.indexOf(befor.charAt(0)) == -1 && poemLetters2.indexOf(ch.charAt(0)) != -1 
            && (befor.charAt(0) != "·" 
            || alef.indexOf(ch.charAt(0)) == -1))
            s += "^";
        befor = ch;
        s += ch;
      }
      else {
        s += ch;
        if (poemLetters3.indexOf(ch.charAt(0)) == -1)
          befor = "";
      }        
    }
    s = s.replace(/alh/g,"«··Â");
	s = s.replace(/lah/g,"··Â");
    return s;
  }
  
  function poem_extend(n) {
	if (n <= 0)
      return ""; 
    if (n == 1)
      return "‹";
    return  "‹" + poem_extend(n-1);
  } 

  function poem_justifyBYextend(t, w) {
    var ex = 0, i, d, n, p, m;
    ex = poem_count(t, "^");
    if (ex == 0) return t;
    d = Math.floor((w - poem_textWidth(t.replace(/\^/g,""))) / poemExtendWidth);      
    t = t.split(" ");
    n = 0;
    for (i = 0; i < t.length; i++)      
      n += (t[i].indexOf("^") != -1);
    p = Math.floor(d / n);
    m = d % n;
    for (i = t.length-1; i >= 0; i--) {    
      ex = poem_count(t[i], "^");
      if (ex == 0)
        continue;
      d = p + (m-- > 0);
      n = Math.floor(d / ex);      
      if (n > 0)
        t[i] = t[i].replace(/\^/g, "^" + poem_extend(n));
      if (d % ex > 0)
        t[i] = poem_strReplace(t[i], "^", "‹", d % ex);
    }
    t = t.join(" ");
    t = t.replace(/\^/g, ""); 
    return t;
  }
  
  function poem_justifyBYspace(t, w, dir) {
    var sp = 0, i, d, tw, n;
    sp = poem_count(t, " ");
    if (sp != 0) {
      d = Math.floor((w - poem_textWidth(t)) / poemSpaceWidth);
      n = Math.floor(d / sp);
      if (n > 0)
        t = t.replace(/ /g, poem_space(n + 1));
      if (d % sp > 0)
        t = poem_strReplace(t, poem_space(n + 1), poem_space(n + 2), d % sp);
    }
    tw = w - poem_textWidth(t);
    if (tw > 0) {
      i = t.lastIndexOf(" ");
      if (i == -1)
        if (dir == 0)
          return t;
        else
          i = ((dir==2)?-1:t.length-1);	  
    } else
		tw = 0;
	t = t.substr(0, i+1) + poemToolFix.replace(/%w%/,tw + "pt") + t.substr(i+1);
    return t; 
  }
  
  function poem_justify(t, w, dir) {
    if (poemUse == "ex") t = poem_justifyBYextend(t, w);    
    return poem_justifyBYspace(t, w, dir);
  }

  function showPoemLine(preview, html) {
	if (preview)
		poemPrevHTML += html;
	else
		document.write(html);
  }
  
  function doPoem(preview) {
	var found = 0, div;
	poem_setDefaultVar();
	if (preview) {
		div = poemExample;		
		poemPrevHTML = "";
	}
	else {
		var d = document.getElementsByTagName("div");
		div = d[d.length -1];		
	}
	var poem = div.innerHTML.replace(/<br \/>|<br>/gi, "\r");
	if (poem == "")
		return;
	if (!div.tag)
		div.tag = "";
	if (!preview)
		div.innerHTML = "";	
	var arg = div.tag.replace(/\\\"/g, "'");		
	
	create_poemTestWidth_table(); 

	poem_setArg(arg);
	
	poemToolFix = "<span style='font-size:1pt;padding-right:%w%;'></span>";
    poemToolFix = poemToolFix.replace(/ /g,"^");

	poem = poem.replace(/</g, "&lt;");
	poem = poem.replace(/>/g, "&gt;");	
	poem = poem.replace(/[\^]|^[\r]+|[\r]+$|\n/g, "");
	poem = poem.replace(/^[ ]+|[ ]+$|/g, "");
	poem = poem.replace(/[‹]+( |$)/g, "ext1");
	poem = poem.replace(/(^| )[‹]+/g, "ext2");
	poem = poem.replace(/‹/g, "");
	poem = poem.replace(/ext1/g, "‹");
	poem = poem.replace(/ext2/g, "‹");
    poem = poem.replace(/[ ]+/g, " ");
	poem = poem.replace(/[ ]*=[ ]*/g, "=");
	poem = poem.replace(/[ ]+\r|\r[ ]+/g, "\r");	
	
	if (poem.substring(poem.length-1) != "\r") poem += "\r";

	poemExtendWidth = poem_textWidth("‘" + "‹‹" + "‘");
    poemExtendWidth -= poem_textWidth("‘" + "‹" + "‘");
    poemSpaceWidth = poem_textWidth("‘" + "&nbsp;&nbsp;" + "‘");
    poemSpaceWidth -= poem_textWidth("‘" + "&nbsp;" + "‘");

	var tmp, MTW, MTW1;	
	
	tmp = "\r" + poem + "\r";
	tmp = tmp.replace(/\r[^\r]+\=[^\r]+/gi,"");
	tmp = tmp.replace(/\r/g,"<br>");
	var MTW1 = poem_textWidth(tmp);

	tmp = "\r" + poem + "\r";
	tmp = tmp.replace(/\r[^=]+\r/gi,"\r");	
	tmp = tmp.replace(/=/g,"<br>");
	tmp = tmp.replace(/\r/g,"<br>");
	var MTW = poem_textWidth(tmp);
	tmp = "";

	if (poemUse=="ex") {
	  var test = poem_textWidth(poem);
	  poem = poem_createExtend(poem);
      test = (poem_textWidth(poem.replace(/\^/g, "‹")) - test) / poem_count(poem,"^");
	  //if (test != poemExtendWidth) //problem in some fonts
		//poem = poem.replace(/\^/g, "^‹");
    }

// *************
    var poemBodyStyle = "", fonts = "";
	fonts += ";font-family:" + poemFontName;
    fonts += ";font-size:" + poemFontSize;
    fonts += ";color:" + poemFontColor;
    fonts += ";font-weight:" + poemFontBold;
    fonts += ";font-style:" + poemFontItalic;
	poemBodyStyle += fonts;
    poemBodyStyle += ";background-color:" + poemBackColor; 
    poemBodyStyle += ";background-image:url(" + poemBackImage + ")";
	poemBodyStyle += ";border:" + poemBorderWidth + "px " + poemBorderStyle + " " + poemBorderColor; 
	
	showPoemLine(preview, "<div align='" + poemAlign + "'>");
    showPoemLine(preview, "<table dir='rtl' border='0' cellpadding='0' cellspacing='0' width='1px' style='" + poemBodyStyle + ";'>");
// *************	
	poem = "\r" + poem;

	var L, R, i, j = 0, cr = 0, sn = 0;
	var poemSide, poemSideNum, wnum;
	if (poemSerialNum > 0)
		sn = poemSerialNum - 1;	
    while (1) {
   	  poemSideNum = "";
      poemSide = "";
	  if (sn == 0)
		poemSide = "<div style='height:" + poemPadding + "px;font-size:1'></div>";
      cr = poem.indexOf("\r", cr);
	  if (cr == -1) break;	  
      if (poem.substring(j, cr) != "") {
        i = poem.indexOf("=", j);
        if (i == -1 || i > cr) i = cr; //no '=' in this line
		
        L = poem.substring(j, i);
		if (L != "\r" && L != "") {
			if (i != cr)
				L = poem_justify(L, MTW, 1);
			else {
				L = poem_justify(L, MTW1, 0);
			}
			L = L.replace(/ /g, "&nbsp;");
			L = L.replace(/\^/g, " ");
		}

		R = poem.substring(i + 1, cr);
		if (R != "\r" && R != "") {
			R = poem_justify(R, MTW, 2);
			R = R.replace(/ /g, "&nbsp;");
			R = R.replace(/\^/g, " ");
		}

		if (poemType == 0) {
		  if (i != cr) {
			  if (L != "" && R == "")
				poemSide = L;
			  else if (L == "" && R != "")
				poemSide = R;
			  else if (L != "" && R != "")
				poemSide = L + poemToolFix.replace(/%w%/, Math.floor(MTW / 2.1) + "px").replace(/\^/, " ") + R;
		  } else
			    poemSide = L;

		  poemSide = "<div align=center style='" + fonts + ";" + poemMargin +"'>" + poemSide + "</div>";
		  
		  poemSideNum = ++sn;
		}
		else if (poemType == 1) {
			if (i == cr) {
				poemSide = "<div align=center style='" + fonts + ";" + poemMargin +"'>" + L + "</div>";
			} else {
				poemSide = "<div align='right' style='" + fonts + "; margin-left:" + Math.round(MTW) + "pt;" + poemMargin + "'>" + L + "</div>";
				poemSide += "<div align='left' style='" + fonts + "; margin-right:" + Math.round(MTW) + "pt;" + poemMargin + "'>" + R + "</div>";
			}
			poemSideNum = ++sn;
		}
		else if (poemType == 2 || poemType > 3 || poemType < 1) {
			if (i == cr) {
				poemSide = "<div align=center style='" + fonts + ";" + poemMargin +"'>" + L + "</div>";
			} else {
				poemSide = "<div align='right' style='" + fonts + "; margin-left:" + Math.round(MTW/2) + "pt;" + poemMargin + "'>" + L + "</div>";
				poemSide += "<div align='left' style='" + fonts + "; margin-right:" + Math.round(MTW/2) + "pt;" + poemMargin + "'>" + R + "</div>";
			}
			poemSideNum = ++sn;
		}
		else if (poemType == 3) {
		  poemSideNum = ++sn;
		  poemSide = "<div style='" + fonts + ";" + poemMargin + "'>" + L + "</div>";
  		  poemSide += "<div style='" + fonts + ";" + poemMargin + "'>" + R + "</div>";
		}        
	  }
	  if (poemSerialNum > 0 && poemSideNum != "")
		  showPoemLine(preview, "<tr><td align=left valign=top style='" + fonts + "; color:" + poemSerialNumColor + "' nowrap>&nbsp;&nbsp;" + poemSideNum + "</td>");
	  showPoemLine(preview, "<td align=center valign=middle style='" + fonts + ";padding-left:15px;padding-right:15px;' nowrap>" + poemSide + "</td></tr>");
	  cr += 1;
	  j = cr;
    }
	if (poemLine == 0) {
		poemSide = "<div style='height:" + poemPadding + "px;font-size:1'></div>";		
		if (poemSerialNum > 0 && poemSideNum != "")
		  showPoemLine(preview, "<tr><td align=left valign=top style='" + fonts + "; color:" + poemSerialNumColor + "' nowrap>&nbsp;&nbsp;" + poemSideNum + "</td>");
		showPoemLine(preview, "<td align=center valign=middle style='" + fonts + ";padding-left:15px;padding-right:15px;' nowrap>" + poemSide + "</td></tr>");
	}

    showPoemLine(preview, "</table></div>");

	if (preview)
		poemPreview.innerHTML = poemPrevHTML;
	poemPrevHTML = "";

	// *******************************************

	poem_textWidth("");
  } 

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \\

// ******************* function smilie() ******************* //
function smilie(thesmilie) {
	var oSelect, oSelectRange;
	if (!document.vbform) {
		if (opener.document.vbform.message) {
			opener.document.vbform.message.focus();
			oSelect = opener.document.selection;
			oSelectRange = oSelect.createRange();
			oSelectRange.text = thesmilie;
			document.body.focus();
		}
	}
	else {
		obj = document.vbform.message.focus();
		oSelect = document.selection;
		oSelectRange = oSelect.createRange();
		oSelectRange.text = thesmilie;
	}
}

// ******************* [glint] code ******************* //
setInterval("doGlintText()", 50);
document.write('<div tag="dummy" id="myglinttext" style="display:none;filter:alpha(opacity=100);width:100%"></div>');
function doGlintText() {
	try {
		var a, d;
		for (var i = 0; i < myglinttext.length; i++) {
			if (myglinttext[i].tag == "dummy")
				continue;			
			a = parseInt(myglinttext[i].filters.alpha.opacity);
			d = parseInt(myglinttext[i].tag);			
			if (d == 1 || d == -1)	{
				a += d * 5;
				if (a <= 0) {				
					myglinttext[i].tag = "1";
				} if (a >= 100) {
					myglinttext[i].tag = "2";
				}
				myglinttext[i].filters.alpha.opacity = a;
			} else if (d >= 10)
				myglinttext[i].tag = -1;
			else
				myglinttext[i].tag = ++d;
		}
	} catch(e) {
	;
	}
}

// ******************* [blink] code ******************* //
setInterval("doBlinkText()", 500);
document.write('<span id="myblinktext" style="display:none"></span>');
function doBlinkText() {
	try {
		for (var i = 1; i < myblinktext.length; i++)
			if (myblinktext[i].style.visibility == "hidden")
				myblinktext[i].style.visibility = "visible";
			else
				myblinktext[i].style.visibility = "hidden";
	} catch(e) {
	;
	}
}

// ******************* Open My RealPlayer Window ******************* //
function OpenRealMediaWindow(url) {
	open("realmedia_form.php?url="+url, "", "width=340,height=340,left=0,top=0,fullscreen=no");
}

// ******************* [frame] code ******************* //
function drawFrame() {
	var found = 0;
	var d = document.getElementsByTagName("DIV");	
	for (var i = d.length - 1; i >= 0; i--) {
		if (d[i].id == "myframe") {			
			div = d[i];
			div.id = "";
			found = 1;
			break;
		}
	}
	if (found == 0) return;
	tag = div.tag.replace(/[ ]+/g, " ");
	tag = tag.split("|");
	wdth = tag[1];
	if (wdth > 100) wdth = 100;
	var html = ('<center><table dir="rtl" border="0" width="' + wdth + '%" cellpadding="0" cellspacing="0"><tr><td width="1%"><img border="0" src="' + bburl + 'images/toolbox/myframes/tl' + tag[0] + '.gif" style="filter:fliph"></td><td width="33%" background="' + bburl + 'images/toolbox/myframes/t' + tag[0] + '.gif"></td><td width="1%"><img border="0" src="' + bburl + 'images/toolbox/myframes/tl' + tag[0] + '.gif"></td></tr><tr><td width="1%" background="' + bburl + 'images/toolbox/myframes/l' + tag[0] + '.gif" style="filter:fliph"></td><td width="33%" background="' + bburl + 'images/toolbox/myframes/' + tag[0] + '.gif" style="padding:2">'+tag[2]);
	html += (div.innerHTML.replace(/^<br>/i, "").replace(/<br>$/i, ""));	
	html += ('</td><td width="1%" background="' + bburl + 'images/toolbox/myframes/l' + tag[0] + '.gif"></td></tr><tr><td width="1%"><img border="0" src="' + bburl + 'images/toolbox/myframes/tl' + tag[0] + '.gif" style="filter:flipv fliph"></td><td width="33%" background="' + bburl + 'images/toolbox/myframes/t' + tag[0] + '.gif" style="filter:flipv"></td><td width="1%"><img border="0" src="' + bburl + 'images/toolbox/myframes/tl' + tag[0] + '.gif" style="filter:flipv"></td></tr></table></center>');
	div.innerHTML = html;
	div.style.display = "block";	
}
// ******************* [/frame] code ******************* //

// ******************* [gradient] code ******************* //
// 1001 Astuces Nam@ni , la Source JavaScript!!
// http://www.namani.net
function gradient_gradient_browser() {
	gradient_browser = "unknown";
	gradient_version = 0;
	if (navigator.userAgent.indexOf("Opera") >= 0)
	 gradient_browser = "opera";
	else if (navigator.userAgent.indexOf("obot") >= 0)
	 gradient_browser = "robot";
	else if (navigator.appName.indexOf("etscape") >= 0)
	 gradient_browser = "netscape";
	else if (navigator.appName.indexOf("icrosoft") >= 0)
	 gradient_browser = "msie";
	gradient_version = parseFloat(navigator.appVersion);
	if (isNaN(gradient_version)) gradient_version = 0;
	if ((gradient_browser == "msie")&&(gradient_version == 2)) gradient_version = 3;
	gradient_tohex = new Array(256);
	var hex = "0123456789ABCDEF";
	var count = 0;
	for (var x=0; x<16; x++) {
	 for (var y=0; y<16; y++) {
		gradient_tohex[count] = hex.charAt(x) + hex.charAt(y);
		count++;
	 }
	}
}

function ColorCode(hexcode) {
  if (hexcode.length == 7) {
    this.gradient_r = parseInt(hexcode.substring(1,3),16);
    this.gradient_g = parseInt(hexcode.substring(3,5),16);
    this.gradient_b = parseInt(hexcode.substring(5,7),16);
  }
  else if (hexcode.length == 6) {
    this.gradient_r = parseInt(hexcode.substring(0,2),16);
    this.gradient_g = parseInt(hexcode.substring(2,4),16);
    this.gradient_b = parseInt(hexcode.substring(4,6),16);
  }
  else {
    this.gradient_r = this.gradient_g = this.gradient_b = 0;    
  }  
}

function ColorList(hexcodes) {
  var i = 0;
  var c = 0;
  this.gradient_codes = new Array(Math.round(hexcodes.length/7));
  while (i < hexcodes.length) {
    if (isNaN(parseInt(hexcodes.substring(i,i+6),16))) ++i;
    else {
      this.gradient_codes[c] = new ColorCode(hexcodes.substring(i,i+6));
      i += 7;
      ++c;
    }
  }
  this.len = c;
}

function interpolate (x1, y1, x3, y3, x2) {
  if (x3 == x1) return y1
  else return (x2-x1)*(y3-y1)/(x3-x1) + y1
}

function lowcolorindex (x, y, z) {
  if (y == 1) return 0
  else return Math.floor( (x*(z-1))/(y-1) )
}

function hicolorindex (x, y, z, low) { 
  if ( low*(y-1) == x*(z-1) ) return low
  else if (y == 1) return 0
  else return Math.floor( (x*(z-1))/(y-1) + 1 )
}

function drawGradient() {
	var found = 0;
	var d = document.getElementsByTagName("DIV");
	for (var i = d.length - 1; i >= 0; i--) {
		if (d[i].id == "mygradient") {
			d[i].id = "";
			div = d[i];
			found = 1;
			break;
		}
	}
	if (found == 0) return;	
	clr = div.tag
	clr = clr.replace(/\#/g, "");
	clr = clr.replace(/[ ]+/g, " ");
	clr += "      ";
	clr = clr.split(" ");
	gradient_gradient_browser();
	gradient_thecolors = "#" + clr[0].substr(0,6);
	gradient_thecolors += "#" + clr[1].substr(0,6);
	gradient_thecolors += "#" + clr[2].substr(0,6);
	gradient_thecolors += "#" + clr[3].substr(0,6);
	gradient_thecolors += "#" + clr[4].substr(0,6);	
	
	var gradient_html = "";
	if (((gradient_browser == "netscape")||(gradient_browser == "msie")||(gradient_browser == "opera"))&&(gradient_version>=3.0)) {
		
		var colors = new ColorList(gradient_thecolors);
		if (colors.len < 2) {
			div.style.display = "block";
			return;
		}		
		var numcolors = colors.len;		
		var numchars = div.innerText.replace(/[\n\r\t ]/g, "").length;
		var rr = 0;
		var gg = 0;
		var bb = 0;
		var lci = 0; //lower color index
		var hci = 0; //high color index
		var chr, p = 0;
		for (i = 0; p < numchars; ++i) {
			chr = div.innerText.charAt(i);
			if (" \r\n\t".indexOf(chr) != -1) {
				gradient_html += chr;
			} else {				
				lci = lowcolorindex(p, numchars, numcolors);
				hci = hicolorindex(p, numchars, numcolors, lci);
				rr = Math.round(interpolate( lci/(numcolors-1), colors.gradient_codes[lci].gradient_r, hci/(numcolors-1), colors.gradient_codes[hci].gradient_r, p/(numchars-1)));
				gg = Math.round(interpolate( lci/(numcolors-1), colors.gradient_codes[lci].gradient_g, hci/(numcolors-1), colors.gradient_codes[hci].gradient_g, p/(numchars-1)));
				bb = Math.round(interpolate( lci/(numcolors-1), colors.gradient_codes[lci].gradient_b, hci/(numcolors-1), colors.gradient_codes[hci].gradient_b, p/(numchars-1)));
				if (gradient_browser == "opera") {
					rr = 255 - rr;
					gg = 255 - gg;
					bb = 255 - bb;
				}				
				gradient_html += chr.fontcolor(gradient_tohex[rr]+gradient_tohex[gg]+gradient_tohex[bb]);
				p++;
			}
		}
	} else
		gradient_html += div.innerText;	
	div.innerHTML = gradient_html.replace(/\r/gi, "<br>");
	gradient_html = "";
	div.style.display = "block";
}
// *********** [/gradient] code *********** //

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \\

var buttons = new Array();

var btn_backcolor_over, btn_backcolor_down, btn_bordercolor;
var toolbox_background,toolbox_backcolor;
var btn_obj = "";

function button_over(eButton, w) {
	if (w == "qkeys") {
		eButton.parentElement.background = bburl + "images/toolbox/key_2.gif";
		eButton.style.color = "white";
	} else {
		vbform.toolboxbar.style.color = statusColor;
		vbform.toolboxbar.value = w;
		doButton(btn_backcolor_over, 1, eButton);
	}
}

function button_out(eButton, w) {
	if (w == "qkeys") {
		eButton.parentElement.background = "transparent";
		eButton.style.color = "black";
	} else {
		vbform.toolboxbar.style.color = tipColor;
		vbform.toolboxbar.value = tip;
		doButton("transparent", 0, eButton);
	}
}

function button_down(eButton, w) {
	if (w != "qkeys")
		doButton(btn_backcolor_down, 1, eButton);
}

function button_up(eButton, w) {
	if (w != "qkeys")
		doButton(btn_backcolor_over, 1, eButton);
	eButton = null;
}

function doButton(bk, s, btn) {
	if (event.button == 2) return;
	btn.style.backgroundColor = bk;
	if (s == 0)	{
		btn.parentElement.style.backgroundColor = "transparent";		
	} else {		
		btn.parentElement.style.backgroundColor = btn_bordercolor;
	}
}

function do_button(c) {
	var bn, ob, k;
	ob = window.event.srcElement;
	if (bn=ob.tag) {		
		if (bn.indexOf("|||") >= 0) {
			if (ob.tagName == "IMG")
				ob = ob.parentElement;
			bn = bn.split("|||");
			if (c == 1) //click
				execTool(bn[0]);
			else if (c == 2) //mouse over
				button_over(ob, bn[1]);
			else if (c == 3) //mouse out
				button_out(ob, bn[1]);
			else if (c == 4) //mouse down
				button_down(ob, bn[1]);
			else if (c == 5) //mouse up
				button_up(ob, bn[1]);
		}
	}
}



function showColorsWindow() {
	var posX = event.screenX;
	var posY = event.screenY + 5;
	var screenW = screen.width;                                 // screen size
	var screenH = screen.height - 20;                           // take taskbar into account
	if (posX + 232 > screenW) { posX = posX - 232 - 40; }       // if mouse too far right
	if (posY + 164 > screenH) { posY = posY - 164 - 80; }       // if mouse too far down
	var wPosition = "dialogLeft:" +posX+ "; dialogTop:" +posY;
	return showModalDialog("magic_toolbox.php?todo=color", "",
		"dialogWidth:238px; dialogHeight: 195px; resizable: no; help: no; status: no; scroll: no; "	+ wPosition);
}

function execTool(btn) {	
	if (event.altKey) {
		if (btn.substr(0,6) != "qkeys_") {			
			open("magic_toolbox.php?todo=help&toolsel=" + btn, "help", "toolbar=no,scrollbars=yes,resizable=yes,width=550px,height=350px,left=50px,top=100px");
		}
	} else
		EditorFunctions(btn);
}

function Editor_getSelText() {
	var oSelect,oSelectRange;
	document.vbform.message.focus();
    oSelect = document.selection;
    oSelectRange = oSelect.createRange();
    return oSelectRange; 
}

function Editor_addCode(tag1,tag2) {	
  var oSelText = Editor_getSelText();
  if (oSelText.text == "")
     alert(vbphrase["mtool_highlight_first"]);
  else
     oSelText.text = tag1 + oSelText.text + tag2;     
}

function EditorFunctions(tag) {
  if (tag.substr(0, 6) == "qkeys_") {  // Arabic Keyboard
	var oSelText = Editor_getSelText();
	tag = tag.substr(6);
	if (tag == "Â‹") tag = "Â";
	oSelText.text = tag;
  }
  else if (tag == "rtl" || tag == "ltr") {
    document.vbform.message.dir=tag.substr(tag);
  }
  else if (tag == "bold") {
    Editor_addCode("[B]","[/B]");
  }
  else if (tag == "italic") {
    Editor_addCode("[I]","[/I]");
  }
  else if (tag == "uline") {
    Editor_addCode("[U]","[/U]");
  }
  else if (tag == "gradient") {
	var oSelText = Editor_getSelText();
	if (oSelText.text == "") {
		alert(vbphrase["mtool_highlight_first"]);
		return;
	}
    code = showModalDialog("magic_toolbox.php?todo=gradient","","help:no; center:yes; status:no; dialogHeight:220px; dialogWidth:500px");
	if (!code)
		return;
    oSelText.text = "[grade=\"" + code + "\"]" + oSelText.text + "[/grade]"
  }  
  else if (tag == "left" || tag == "center" || tag == "right" || tag == "justify") {
    Editor_addCode("[align="+tag.toLowerCase()+"]","[/align]");
  }
  else if (tag == "link") {
    var oSelText = Editor_getSelText();
    var ob = window.prompt(vbphrase["insert_hyperlink"] + ":","http://");
    txt = oSelText.text;
    if (ob) {
		if (txt=="")
		  txt = window.prompt(vbphrase["enter_link_text"],"");
		if (txt)
		  oSelText.text = "[url="+ob+"]"+txt+"[/url]";
		else
		  oSelText.text = "[url]"+ob+"[/url]";
    }
  }
  else if (tag == "email") {
	var oSelText = Editor_getSelText();
    var ob = window.prompt(vbphrase["enter_email_link"],"@");
    if (ob)
	  if (oSelText.text=="")
        oSelText.text = "[email]"+ob+"[/email]";
      else
        oSelText.text = "[email="+ob+"]"+oSelText.text +"[/email]";
  }
  else if (tag == "image") {
	var oSelText = Editor_getSelText();
	var link=((oSelText.text=="")?"http://":oSelText.text);
	var ob = window.prompt(vbphrase["enter_image_url"],link);
    if (ob)
      oSelText.text = "[img]"+ob+"[/img]";
  }
  else if (tag == "mleft" || tag == "mleft" || tag == "mright" || tag == "mup" || tag == "mdown") {
    Editor_addCode("[move="+tag.substr(1).toLowerCase()+"]","[/move]");
  }
  else if (tag == "quote") {
    Editor_addCode("[quote]","[/quote]");
  }
  else if (tag == "code") {
    Editor_addCode("[code]","[/code]");
  }
  else if (tag == "php") {
	  Editor_addCode("[php]","[/php]");
  }
  else if (tag == "line") {
	var oSelText = Editor_getSelText();
    oSelText.text = "[line]";
  }
// [START HACK='Picture Signature' AUTHOR='uaeweb' VERSION='1.0' CHANGEID= 1 ]
  else if (tag == "signatureimage") {
	var oSelText = Editor_getSelText();
    oSelText.text = "[signatureimage]";
  }
// [END HACK='Picture Signature' AUTHOR='uaeweb' VERSION='1.0' CHANGEID= 1 ]
  else if (tag == "rplayer") {
	var oSelText = Editor_getSelText();
	var link=((oSelText.text=="")?"http://":oSelText.text);
    var ob = window.prompt(vbphrase["mtool_enter_ram_url"], link);
    if (ob) {
	  t = window.prompt("" + vbphrase["mtool_sound_only"] + "= 0\r\n" + vbphrase["mtool_real_video"] + " = 1", 0);
	  if (t) {
	    if (t==0)
			oSelText.text = "[rams]"+ob+"[/rams]";
		else
			oSelText.text = "[ramv]"+ob+"[/ramv]";
	  }	  
	}
  }
  else if (tag == "media") {
	var oSelText = Editor_getSelText();
	var link=((oSelText.text=="")?"http://":oSelText.text);
    var ob = window.prompt(vbphrase["mtool_sound_video"], link);
    if (ob)
      oSelText.text = "[media]"+ob+"[/media]";
  }
  else if (tag == "flash") {
	var oSelText = Editor_getSelText();
	var link=((oSelText.text=="")?"http://":oSelText.text);
	var ob = window.prompt(vbphrase["mtool_enter_flash_url"], link);
    if (!ob) return;
    var w = window.prompt(vbphrase["mtool_flash_hight"],"400");
    if (!w) return;
    var h = window.prompt(vbphrase["mtool_flash_width"],"350");
    if (!h) return;
    oSelText.text = "[flash="+ob+"]WIDTH="+w+" HEIGHT="+h+"[/flash]";
  }
  else if (tag == "web") {
	var oSelText = Editor_getSelText();
	var link=((oSelText.text=="")?"http://":oSelText.text);
    var ob = window.prompt(vbphrase["mtool_enter_page_url"], link);
    if (ob)
      oSelText.text = "[web]"+ob+"[/web]";
  }
  else if (tag == "poem") {
	var oSelText = Editor_getSelText();
	if (oSelText.text == "") {
		alert(vbphrase["mtool_poem_type"]);
		return;
	}
    code = showModalDialog("magic_toolbox.php?todo=poem","","help:no; center:yes; status:no; dialogHeight:420px; dialogWidth:560px");
	if (!code)
		return;
    oSelText.text = "[poem " + code + "]\n" + oSelText.text + "[/poem]"
  }
  else if (tag == "frame") {
	var oSelText = Editor_getSelText();
	if (oSelText.text == "") {
		alert(vbphrase["mtool_highlight_first"]);
		return;
	}
    code = showModalDialog("magic_toolbox.php?todo=frame","","help:no; center:yes; status:no; dialogHeight:250px; dialogWidth:450px");
	if (!code)
	  return;
    oSelText.text = '[frame="' + code + '"]' + oSelText.text + '[/frame]';
  }
  else if (tag=="text") {
	var oSelText = Editor_getSelText();
	if (oSelText.text == "") {
		alert(vbphrase["mtool_highlight_first"]);
		return;
	}
    oSelText = showModalDialog("magic_toolbox.php?todo=text",oSelText,"help:no; center:yes; status:no; dialogHeight:400px; dialogWidth:700px");
  }
  else if (tag == "plain") {
	var oSelText = Editor_getSelText();
    if (oSelText.parentElement().name=="message") {
	  var temp = oSelText.text;
	  temp = temp.replace(/\[FLASH=([^\]]*)\]WIDTH=[0-9]{0,4} HEIGHT=[0-9]{0,4}\[\/FLASH\]/gi,"$1");
	  temp = temp.replace(/\[VIDEO=([^\]]*)\]WIDTH=[0-9]{0,4} HEIGHT=[0-9]{0,4}\[\/VIDEO\]/gi,"$1");
	  oSelText.text = temp.replace(/\[[^\]]*\]/gi,"");
	}
  }
  else if (tag == "list") {
    Editor_addCode("[list]\n","\n[/list]");
  }
  else if (tag == "blink") {
    Editor_addCode("[blink]","[/blink]");
  }
  else if (tag == "glint") {
    Editor_addCode("[glint]","[/glint]");
  }
  else if (tag == "cut" || tag == "copy" || tag == "paste" || tag == "delete") {
	  var oSelText = Editor_getSelText();
	  oSelText.execCommand(tag);
  }
  else if (tag == "smile") {
  	  window.open("magic_toolbox.php?todo=smilies", "smilies", "toolbar=no,status=no,scrollbars=yes,resizable=yes,width=440px,height=280px");
  }
  else if (tag == "undo") {
	  alert(vbphrase["undo"]);
  }
  else if (tag == "redo") {
	  alert(vbphrase["redo"]);
  }
  else if (tag == "keyb") {	  
	  if (keyboardTable.style.display == "none") {		  
		  event.srcElement.src = bburl + "images/toolbox/keybx.gif";
		  keyboardTable.style.display = "inline";
		  event.srcElement.alt = "" + vbphrase["mtool_hide_keyboard"] + "";
	  }
	  else {		  
		  event.srcElement.src = bburl + "images/toolbox/keyb.gif";
		  keyboardTable.style.display = "none";
		  event.srcElement.alt = "" + vbphrase["mtool_keyboard"] + "";
	  }
  }
  else if (tag == "preview") {
	  var c = document.vbform.message.value.replace(/^[\r\n\t ]*|[\r\n\t ]*$/gi, "").length;
	  if (c < minchars)
		  alert(vbphrase["mtool_message_too_short"] + " " + minchars);
	  else if (c > maxchars)
		  alert(vbphrase["mtool_message_too_long"] + " " + maxchars);
	  else
		  open("magic_toolbox.php?todo=preview", "postpreview");
  }
  else if (tag == "colorpicker") {
	  var c = showColorsWindow();
	  if (c) {
		var oSelText = Editor_getSelText();
		oSelText.text = c;
	  }
  } else if (tag == "glow" || tag == "mark" || tag == "color") {
		var oSelText = Editor_getSelText();
		if (oSelText.text == "") {
			alert(vbphrase["mtool_highlight_first"]);
			return;
		}
		var c = showColorsWindow();
		if (c) {
			oSelText.text = "[" + tag + "=" + c + "]" + oSelText.text + "[/" + tag + "]";
		}
  } else if (tag == "help") {
	  open("magic_toolbox.php?todo=help", "help",  "toolbar=no,scrollbars=yes,resizable=yes,width=550px,height=350px,left=50px,top=100px");
  }
}

function Editor_addCommonWord(tag1) {
	if (tag1==0)
	 {
		location.href='profile.php?do=cwlist';
		return false;
	 }	
  var oSelText = Editor_getSelText();
     oSelText.text = " " + tag1 + " ";
}
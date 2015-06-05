//------------------------------------------
// Invision Power Board v2.0
// Global JS File
// (c) 2003 Invision Power Services, Inc.
//
// http://www.invisionboard.com
//------------------------------------------

//==========================================
// Set up
//==========================================

var input_red      = 'input-warn';
var input_green    = 'input-ok';
var input_ok_box   = 'input-ok-content';
var input_warn_box = 'input-warn-content';

var img_blank      = 'blank.gif';
var img_tick       = 'aff_tick.gif';
var img_cross      = 'aff_cross.gif';

// Sniffer based on http://www.mozilla.org/docs/web-developer/sniffer/browser_type.html

var uagent    = navigator.userAgent.toLowerCase();
var is_safari = ( (uagent.indexOf('safari') != -1) || (navigator.vendor == "Apple Computer, Inc.") );
var is_opera  = (uagent.indexOf('opera') != -1);
var is_webtv  = (uagent.indexOf('webtv') != -1);
var is_ie     = ( (uagent.indexOf('msie') != -1) && (!is_opera) && (!is_safari) && (!is_webtv) );
var is_ie4    = ( (is_ie) && (uagent.indexOf("msie 4.") != -1) );
var is_moz    = ( (navigator.product == 'Gecko')  && (!is_opera) && (!is_webtv) && (!is_safari) );
var is_ns     = ( (uagent.indexOf('compatible') == -1) && (uagent.indexOf('mozilla') != -1) && (!is_opera) && (!is_webtv) && (!is_safari) );
var is_ns4    = ( (is_ns) && (parseInt(navigator.appVersion) == 4) );
var is_kon    = (uagent.indexOf('konqueror') != -1);

var is_win    =  ( (uagent.indexOf("win") != -1) || (uagent.indexOf("16bit") !=- 1) );
var is_mac    = ( (uagent.indexOf("mac") != -1) || (navigator.vendor == "Apple Computer, Inc.") );
var ua_vers   = parseInt(navigator.appVersion);

var ipb_pages_shown = 0;
var ipb_pages_array = new Array();

/*-------------------------------------------------------------------------*/
// DST Auto correction
/*-------------------------------------------------------------------------*/

function global_dst_check( tzo, dst )
{
	var thisoffset = tzo + dst;
	var dstoffset  = new Date().getTimezoneOffset() / 60;
	var dstset     = 0;
	var url        = ipb_var_base_url + 'act=xmlout&do=dst-autocorrection&md5check=' + ipb_md5_check;
	
	if ( Math.abs( thisoffset + dstoffset ) == 1 )
	{
		try
		{
			//----------------------------------
			// Fancy first...
			//----------------------------------
			
			xml_dst_set( url + '&xml=1' );
			dstset = 1;
		}
		catch(e)
		{
			dstset = 0;
		}
		
		//----------------------------------
		// No fancy?
		//----------------------------------
		
		if ( dstset == 0 )
		{
			window.location = url;
		}
	}
}

/*-------------------------------------------------------------------------*/
// Get cookie
/*-------------------------------------------------------------------------*/

function my_getcookie( name )
{
	cname = ipb_var_cookieid + name + '=';
	cpos  = document.cookie.indexOf( cname );
	
	if ( cpos != -1 )
	{
		cstart = cpos + cname.length;
		cend   = document.cookie.indexOf(";", cstart);
		
		if (cend == -1)
		{
			cend = document.cookie.length;
		}
		
		return unescape( document.cookie.substring(cstart, cend) );
	}
	
	return null;
}

/*-------------------------------------------------------------------------*/
// Set cookie
/*-------------------------------------------------------------------------*/

function my_setcookie( name, value, sticky )
{
	expire = "";
	domain = "";
	path   = "/";
	
	if ( sticky )
	{
		expire = "; expires=Wed, 1 Jan 2020 00:00:00 GMT";
	}
	
	if ( ipb_var_cookie_domain != "" )
	{
		domain = '; domain=' + ipb_var_cookie_domain;
	}
	
	if ( ipb_var_cookie_path != "" )
	{
		path = ipb_var_cookie_path;
	}
	
	document.cookie = ipb_var_cookieid + name + "=" + value + "; path=" + path + expire + domain + ';';
}

/*-------------------------------------------------------------------------*/
// Lang replace
/*-------------------------------------------------------------------------*/

function lang_build_string()
{
	if ( ! arguments.length || ! arguments )
	{
		return;
	}
	
	var string = arguments[0];
	
	for( var i = 1 ; i < arguments.length ; i++ )
	{
		var match  = new RegExp('<%' + i + '>', 'gi');
		string = string.replace( match, arguments[i] );
	}
	
	return string;
}

/*-------------------------------------------------------------------------*/
// Pop up MyAssistant window
/*-------------------------------------------------------------------------*/

function buddy_pop()
{
	var not_loaded_yet = 0;
	
	if ( use_enhanced_js )
	{
		try
		{
			xml_myassistant_init();
			not_loaded_yet = 1;
		}
		catch( e )
		{
			//alert(e);
			not_loaded_yet = 0;
		}
	}
	
	if ( ! not_loaded_yet )
	{
		ipb_var_base_url = ipb_var_base_url.replace( '&amp;', '&' );
		window.open( ipb_var_base_url + 'act=buddy','BrowserBuddy','width=250,height=500,resizable=yes,scrollbars=yes');
	}
}

/*-------------------------------------------------------------------------*/
// Multi Page jumps
/*-------------------------------------------------------------------------*/

function do_multi_page_jump( pages_id )
{
	var pages       = 1;
	var cur_st      = ipb_var_st;
	var cur_page    = 1;
	var total_posts = ipb_pages_array[ pages_id ][2];
	var per_page    = ipb_pages_array[ pages_id ][1];
	var url_bit     = ipb_pages_array[ pages_id ][0];
	var userPage    = parseInt( document.getElementById( 'st-'+pages_id ).value );
	
	//-----------------------------------
	// Fix up URL BIT
	//-----------------------------------
	
	url_bit = url_bit.replace( new RegExp( "&amp;", "g" ) , '&' );
	
	//-----------------------------------
	// Work out pages
	//-----------------------------------
	
	if ( total_posts % per_page == 0 )
	{
		pages = total_posts / per_page;
	}
	else
	{
		pages = Math.ceil( total_posts / per_page );
	}
	
	if ( cur_st > 0 )
	{
		cur_page = cur_st / per_page; cur_page = cur_page -1;
	}

	if ( userPage > 0  )
	{
		if ( userPage < 1 )     {    userPage = 1;  }
		if ( userPage > pages ) { userPage = pages; }
		if ( userPage == 1 )    {     start = 0;    }
		else { start = (userPage - 1) * per_page; }
		
		window.location = url_bit + "&st=" + start;
		return false;
	}
}

/*-------------------------------------------------------------------------*/
// Hide / Unhide menu elements
/*-------------------------------------------------------------------------*/

function pages_st_focus( pages_id )
{
	document.getElementById( 'st-'+pages_id ).focus();
}

/*-------------------------------------------------------------------------*/
// Hide / Unhide menu elements
/*-------------------------------------------------------------------------*/

function ShowHide(id1, id2)
{
	if (id1 != '') toggleview(id1);
	if (id2 != '') toggleview(id2);
}
	
/*-------------------------------------------------------------------------*/
// Get element by id
/*-------------------------------------------------------------------------*/

function my_getbyid(id)
{
	itm = null;
	
	if (document.getElementById)
	{
		itm = document.getElementById(id);
	}
	else if (document.all)
	{
		itm = document.all[id];
	}
	else if (document.layers)
	{
		itm = document.layers[id];
	}
	
	return itm;
}

/*-------------------------------------------------------------------------*/
// Show/hide toggle
/*-------------------------------------------------------------------------*/

function toggleview(id)
{
	if ( ! id ) return;
	
	if ( itm = my_getbyid(id) )
	{
		if (itm.style.display == "none")
		{
			my_show_div(itm);
		}
		else
		{
			my_hide_div(itm);
		}
	}
}

/*-------------------------------------------------------------------------*/
// Set DIV ID to hide
/*-------------------------------------------------------------------------*/

function my_hide_div(itm)
{
	if ( ! itm ) return;
	
	itm.style.display = "none";
}

/*-------------------------------------------------------------------------*/
// Set DIV ID to show
/*-------------------------------------------------------------------------*/

function my_show_div(itm)
{
	if ( ! itm ) return;
	
	itm.style.display = "";
}

/*-------------------------------------------------------------------------*/
// Change cell colour
/*-------------------------------------------------------------------------*/

function change_cell_color( id, cl )
{
	itm = my_getbyid(id);
	
	if ( itm )
	{
		itm.className = cl;
	}
}

/*-------------------------------------------------------------------------*/
// Toggle category
/*-------------------------------------------------------------------------*/

function togglecategory( fid, add )
{
	saved = new Array();
	clean = new Array();

	//-----------------------------------
	// Get any saved info
	//-----------------------------------
	
	if ( tmp = my_getcookie('collapseprefs') )
	{
		saved = tmp.split(",");
	}
	
	//-----------------------------------
	// Remove bit if exists
	//-----------------------------------
	
	for( i = 0 ; i < saved.length; i++ )
	{
		if ( saved[i] != fid && saved[i] != "" )
		{
			clean[clean.length] = saved[i];
		}
	}
	
	//-----------------------------------
	// Add?
	//-----------------------------------
	
	if ( add )
	{
		clean[ clean.length ] = fid;
		my_show_div( my_getbyid( 'fc_'+fid  ) );
		my_hide_div( my_getbyid( 'fo_'+fid  ) );
	}
	else
	{
		my_show_div( my_getbyid( 'fo_'+fid  ) );
		my_hide_div( my_getbyid( 'fc_'+fid  ) );
	}
	
	my_setcookie( 'collapseprefs', clean.join(','), 1 );
}

/*-------------------------------------------------------------------------*/
// locationjump
/*-------------------------------------------------------------------------*/

function locationjump(url)
{
	window.location = ipb_var_base_url + url;
}

/*-------------------------------------------------------------------------*/
// CHOOSE SKIN
/*-------------------------------------------------------------------------*/

function chooseskin(obj)
{
	choosebox = obj.options[obj.selectedIndex].value;
	extravars = '';
	
	if ( choosebox != -1 && ! isNaN( choosebox ) )
	{
		if ( document.skinselectorbox.skinurlbits.value )
		{
			extravars = '&' + document.skinselectorbox.skinurlbits.value;
			
			//----------------------------------
			// Strip out old skin change stuff
			// setskin=1&skinid=2
			//----------------------------------
			
			extravars = extravars.replace( /setskin=\d{1,}/g, ''  );
			extravars = extravars.replace( /skinid=\d{1,}/g , ''  );
			extravars = extravars.replace( /&{1,}/g         , '&' );
			extravars = extravars.replace( /s=&/g           , ''  );
		}
		
		locationjump( 'setskin=1&skinid=' + choosebox + extravars );
	}
}

/*-------------------------------------------------------------------------*/
// CHOOSE LANG
/*-------------------------------------------------------------------------*/

function chooselang(obj)
{
	choosebox = obj.options[obj.selectedIndex].value;
	extravars = '';
	
	if ( document.langselectorbox.langurlbits.value )
	{
		extravars = '&' + document.langselectorbox.langurlbits.value;

		//----------------------------------
		// Strip out old skin change stuff
		// setskin=1&skinid=2
		//----------------------------------
			
		extravars = extravars.replace( /setlanguage=\d{1,}/g, ''  );
		extravars = extravars.replace( /cal_id=&/g, ''  );
		extravars = extravars.replace( /langid=\w{1,}/g , ''  );
		extravars = extravars.replace( /&{1,}/g         , '&' );
		extravars = extravars.replace( /s=&/g           , ''  );
	}
	
	locationjump( 'setlanguage=1&langid=' + choosebox + extravars );
}

/*-------------------------------------------------------------------------*/
// pop up window
/*-------------------------------------------------------------------------*/

function PopUp(url, name, width,height,center,resize,scroll,posleft,postop)
{
	showx = "";
	showy = "";
	
	if (posleft != 0) { X = posleft }
	if (postop  != 0) { Y = postop  }
	
	if (!scroll) { scroll = 1 }
	if (!resize) { resize = 1 }
	
	if ((parseInt (navigator.appVersion) >= 4 ) && (center))
	{
		X = (screen.width  - width ) / 2;
		Y = (screen.height - height) / 2;
	}
	
	if ( X > 0 )
	{
		showx = ',left='+X;
	}
	
	if ( Y > 0 )
	{
		showy = ',top='+Y;
	}
	
	if (scroll != 0) { scroll = 1 }
	
	var Win = window.open( url, name, 'width='+width+',height='+height+ showx + showy + ',resizable='+resize+',scrollbars='+scroll+',location=no,directories=no,status=no,menubar=no,toolbar=no');
}

/*-------------------------------------------------------------------------*/
// Array: Get stack size
/*-------------------------------------------------------------------------*/

function stacksize(thearray)
{
	for (i = 0 ; i < thearray.length; i++ )
	{
		if ( (thearray[i] == "") || (thearray[i] == null) || (thearray == 'undefined') )
		{
			return i;
		}
	}
	
	return thearray.length;
}

/*-------------------------------------------------------------------------*/
// Array: Push stack
/*-------------------------------------------------------------------------*/

function pushstack(thearray, newval)
{
	arraysize = stacksize(thearray);
	thearray[arraysize] = newval;
}

/*-------------------------------------------------------------------------*/
// Array: Pop stack
/*-------------------------------------------------------------------------*/

function popstack(thearray)
{
	arraysize = stacksize(thearray);
	theval = thearray[arraysize - 1];
	delete thearray[arraysize - 1];
	return theval;
}

/*-------------------------------------------------------------------------*/
// Converts "safe" innerHTML back to normal template
/*-------------------------------------------------------------------------*/

function innerhtml_template_to_html( t )
{
	t = t.replace( /&lt;%(\d+?)&gt;/ig, "<%$1>" );
	t = t.replace( /%3C%(\d+?)%3E/ig  , "<%$1>" );
	return t;
}

/*-------------------------------------------------------------------------*/
// Global freeze events
/*-------------------------------------------------------------------------*/

function global_cancel_bubble(obj, extra)
{
	if ( ! obj || is_ie)
	{
		if ( extra )
		{
			window.event.returnValue = false;
		}
		
		window.event.cancelBubble = true;
		
		return window.event;
	}
	else
	{
		obj.stopPropagation();
		
		if ( extra )
		{
			obj.preventDefault();
		}
		
		return obj;
	}
}

/*-------------------------------------------------------------------------*/
// Get left posititon of object
/*-------------------------------------------------------------------------*/

function _get_obj_leftpos(obj)
{
	var left = obj.offsetLeft;
	
	while( (obj = obj.offsetParent) != null )
	{
		left += obj.offsetLeft;
	}
	
	return left;
}

/*-------------------------------------------------------------------------*/
// Get top position of object
/*-------------------------------------------------------------------------*/

function _get_obj_toppos(obj)
{
	var top = obj.offsetTop;
	
	while( (obj = obj.offsetParent) != null )
	{
		top += obj.offsetTop;
	}
	
	return top;
}

/*-------------------------------------------------------------------------*/
// Center a div on the screen
/*-------------------------------------------------------------------------*/

function center_div()
{
	this.divname = '';
	this.divobj  = '';
}

/*-------------------------------------------------------------------------*/
// Main run function
/*-------------------------------------------------------------------------*/

center_div.prototype.move_div = function()
{
	try
	{
		this.divobj = document.getElementById( this.divname );
	}
	catch(e)
	{
		return;
	}
	
	//----------------------------------
	// Figure width and height
	//----------------------------------
	
	var my_width  = 0;
	var my_height = 0;
	
	if ( typeof( window.innerWidth ) == 'number' )
	{
		//----------------------------------
		// Non IE
		//----------------------------------
	  
		my_width  = window.innerWidth;
		my_height = window.innerHeight;
	}
	else if ( document.documentElement && ( document.documentElement.clientWidth || document.documentElement.clientHeight ) )
	{
		//----------------------------------
		// IE 6+
		//----------------------------------
		
		my_width  = document.documentElement.clientWidth;
		my_height = document.documentElement.clientHeight;
	}
	else if ( document.body && ( document.body.clientWidth || document.body.clientHeight ) )
	{
		//----------------------------------
		// Old IE
		//----------------------------------
		
		my_width  = document.body.clientWidth;
		my_height = document.body.clientHeight;
	}
	
	//----------------------------------
	// Show...
	//----------------------------------
	
	this.divobj.style.position = 'absolute';
	this.divobj.style.display  = 'block';
	this.divobj.style.zIndex   = 99;
	
	//----------------------------------
	// Get div height && width
	//----------------------------------
	
	var divheight = parseInt( this.divobj.style.Height );
	var divwidth  = parseInt( this.divobj.style.Width );
	
	divheight = divheight ? divheight : 200;
	divwidth  = divwidth  ? divwidth  : 400;
	
	//----------------------------------
	// Get current scroll offset
	//----------------------------------
	
	var scrolly = this.getYscroll();
	
	//----------------------------------
	// Finalize...
	//----------------------------------
	
	var setX = ( my_width  - divwidth  ) / 2;
	var setY = ( my_height - divheight ) / 2 + scrolly;
	
	setX = ( setX < 0 ) ? 0 : setX;
	setY = ( setY < 0 ) ? 0 : setY;
	
	this.divobj.style.left = setX + "px";
	this.divobj.style.top  = setY + "px";
}

/*-------------------------------------------------------------------------*/
// Hide div
/*-------------------------------------------------------------------------*/

center_div.prototype.hide_div = function()
{
	try
	{
		if ( ! this.divobj )
		{
			return;
		}
		else
		{
			this.divobj.style.display  = 'none';
		}
	}
	catch(e)
	{
		return;
	}
}

/*-------------------------------------------------------------------------*/
// Get YScroll
/*-------------------------------------------------------------------------*/

center_div.prototype.getYscroll = function()
{
	var scrollY = 0;
	
	if ( document.documentElement && document.documentElement.scrollTop )
	{
		scrollY = document.documentElement.scrollTop;
	}
	else if ( document.body && document.body.scrollTop )
	{
		scrollY = document.body.scrollTop;
	}
	else if ( window.pageYOffset )
	{
		scrollY = window.pageYOffset;
	}
	else if ( window.scrollY )
	{
		scrollY = window.scrollY;
	}
	
	return scrollY;
}
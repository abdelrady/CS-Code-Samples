/*-------------------------------------------------------------------------*/
// IPS BASIC MENU CLASS
// (c) 2005 Invision Power Services, Inc
// ASSUMES "ips_global.js" has been loaded
/*-------------------------------------------------------------------------*/

var menu_registered = new Array();
var menu_openfuncs  = new Array();
var menu_built      = new Array();
var menu_open_menus = new Array();
var menu_cur_open   = false;

/*-------------------------------------------------------------------------*/
// menu_do_global_init: Initiate all registered menus in HTML
/*-------------------------------------------------------------------------*/

function menu_do_global_init()
{
	if ( menu_registered.length > 0 )
	{
		for( var i in menu_registered )
		{
			menu_init( menu_registered[i] );
		}
		
		//----------------------------------
		// Close all menus on click
		//----------------------------------
		
		document.onclick = menu_action_close;
	}
}

/*-------------------------------------------------------------------------*/
// menu_init: Initiate a single menu
/*-------------------------------------------------------------------------*/

function menu_init(cid)
{
	var mid  = _menu_get_base_name(cid) + "_menu";
	var mobj = my_getbyid(mid);

	if ( document.getElementsByTagName && mobj )
	{
		//----------------------------------
		// Control object (link / img, etc)
		//----------------------------------
		
		var cobj = my_getbyid(cid);
		
		// Change cursor to show link
		try
		{
			cobj.style.cursor = "pointer";
		}
		catch(e)
		{
			cobj.style.cursor = "hand";
		}
	
		cobj.unselectable = true;
		cobj.onclick      = _event_menu_click;
		cobj.onmouseover  = _event_menu_mouseover;
		
		//----------------------------------
		// Save CPU - already init?
		//----------------------------------
		
		if ( typeof( menu_built[mid]) != "undefined" )
		{
			return;
		}
		
		//----------------------------------
		// Pop-up menu obj (hidden div)
		//----------------------------------
		
		var pobj = my_getbyid(mid);
		
		// Set up style defaults
		pobj.style.display  = "none";
		pobj.style.position = "absolute";
		pobj.style.left     = "0px";
		pobj.style.top      = "0px";
		pobj.onclick        = _cancel_bubble;
		pobj.zIndex         = 1000;
		
		menu_built[mid] = true;
	}
}

/*-------------------------------------------------------------------------*/
// Register menu control ID (add to array)
/*-------------------------------------------------------------------------*/

function menu_register(cid, callback)
{
	if ( document.getElementsByTagName )
	{
		var cobj = my_getbyid(cid);
		
		if (cobj)
		{			
			menu_registered[menu_registered.length] = cid;
			
			if ( callback )
			{
				menu_openfuncs[ cobj ] = callback;
			}
			
			return true;
		}
	}
	
	return false;
}

/*-------------------------------------------------------------------------*/
// ACTION: If registered control ID clicked, open menu
/*-------------------------------------------------------------------------*/

function menu_action_open(e)
{
	var openmenu = menu_cur_open;
	var negpad   = true;
	
	//----------------------------------
	// Close current menu(s)
	//----------------------------------
	
	menu_action_close();
	
	//----------------------------------
	// Save CPU - cur open clicked?
	//----------------------------------
	
	if ( openmenu == e.id )
	{
		return false;
	}
	
	//----------------------------------
	// Get ID of menu DIV to show
	//----------------------------------
	
	var mid         = _menu_get_base_name(e.id) + "_menu";	
	var mobj        = my_getbyid(mid);
	var left_px     = _get_obj_leftpos(e);
	var top_px      = _get_obj_toppos(e) + e.offsetHeight;
	var callbackobj = my_getbyid( e.id );
	var ifid        = e.id;
	
	menu_open_menus[e.id] = true;
	menu_cur_open         = e.id;
	
	//----------------------------------
	// Show menu DIV
	//----------------------------------
	
	mobj.style.display = "";
	
	//----------------------------------
	// Try and keep it on screen
	//----------------------------------
	
	var width = parseInt( mobj.style.width ) ? parseInt( mobj.style.width ) : mobj.offsetWidth;
	
	if ( (left_px + width) >= document.body.clientWidth )
	{
		left_px = left_px + e.offsetWidth - width;
		negpad  = false;
	}
	
	//----------------------------------
	// IE needs a tweak...
	//----------------------------------
	
	if ( is_ie )
	{
		left_px += ( negpad ) ? -2 : 2;
	}
	
	//----------------------------------
	// Finalize menu position
	//----------------------------------
	
	mobj.style.left   = left_px + "px";
	mobj.style.top    = top_px  + "px";
	mobj.style.zIndex = 100;
	
	//----------------------------------
	// Run a custom function?
	//----------------------------------
	
	if ( menu_openfuncs[ callbackobj ] )
	{ 
		eval( menu_openfuncs[ callbackobj ] );
	}
	
	//----------------------------------
	// Workaround for IE bug which shows
	// select boxes and other windows GUI
	// over divs. SHOW IFRAME
	//----------------------------------
	
	if ( is_ie )
	{
		try
		{
			if ( ! document.getElementById( 'if_' + e.id ) )
			{ 
				var iframeobj = document.createElement('iframe');
				
				iframeobj.src = 'javascript;';
				iframeobj.id  = 'if_' + e.id;
				
				document.getElementsByTagName('body').appendChild( iframeobj );
			}
			else
			{
				var iframeobj = document.getElementById( 'if_' + e.id );
			}
			
			iframeobj.scrolling      = 'no';
			iframeobj.frameborder    = 'no';
			iframeobj.className      = 'iframeshim';
			iframeobj.style.position = 'absolute';
				
			iframeobj.style.width   = parseInt(mobj.offsetWidth)  + 'px';
			iframeobj.style.height  = parseInt(mobj.offsetHeight) + 'px';
			iframeobj.style.top     = mobj.style.top;
			iframeobj.style.left    = mobj.style.left;
			iframeobj.style.zIndex  = 99;
			iframeobj.style.display = "block";
    		
    	}
    	catch(e)
    	{
    		//alert(e); // Oh dear, someones stolen the iframe
    	}
	}
	
	//----------------------------------
	// Work around for safari which doesnt
	// allow a hrefs top be clickable in
	// a pop up div
	//----------------------------------
	
	if ( is_safari )
	{
		try
		{
			mlinks = mobj.getElementsByTagName('a');
			
			for ( var i = 0 ; i <= mlinks.length ; i++ )
			{
				//----------------------------------
				// Ignore non links and links that end with #
				// As safari likes to do that with href='#' links
				//----------------------------------
				
				if ( mlinks[i].href && ( mlinks[i].href.indexOf( '#', 0 ) != (mlinks[i].href.length - 1) ) )
				{
					mlinks[i].onmousedown = _safari_onclick_handler;
					mlinks[i].id          = 'saf-link-' + mid + i;
				}
			}
		}
		catch( e )
		{
			//alert( e );
		}
	}
	
	return false;
}

/*-------------------------------------------------------------------------*/
// Safari: bug fix
/*-------------------------------------------------------------------------*/

function _safari_onclick_handler()
{
	if ( this.id )
	{
		window.location = document.getElementById( this.id ).href;
	}
}


/*-------------------------------------------------------------------------*/
// ACTION: Close all open menus
/*-------------------------------------------------------------------------*/

function menu_action_close()
{
	if ( menu_cur_open )
	{
		for ( i in menu_open_menus )
		{
			my_getbyid(_menu_get_base_name(i) + "_menu").style.display = "none";
			
			//----------------------------------
			// Workaround for IE bug which shows
			// select boxes and other windows GUI
			// over divs. Hide IFRAME
			//----------------------------------
			
			if ( is_ie )
			{
				try
				{
					document.getElementById( 'if_' + i ).style.display = "none";
				}
				catch(e)
				{
					//alert(e);// Oh dear, someones stolen the iframe
				}
			}
	
			menu_open_menus[i] = false;
		}
	}
	
	menu_cur_open = false;
}

/*-------------------------------------------------------------------------*/
// ACTION: If menu open and hover over another cid, close cur open new
/*-------------------------------------------------------------------------*/

function menu_action_hover(e)
{
	for ( i in menu_open_menus )
	{
		if (menu_open_menus[i] == true && i != e.id)
		{
			menu_action_open(e);
			return;
		}
	}
}

/*-------------------------------------------------------------------------*/
// Prevent browser bubblin'
/*-------------------------------------------------------------------------*/

function _cancel_bubble(obj, extra)
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
		if (obj.target.type == 'submit')
		{
			obj.target.form.submit();
		}
		
		obj.stopPropagation();
		
		if ( extra )
		{
			obj.preventDefault();
		}
		
		return obj;
	}
}

/*-------------------------------------------------------------------------*/
// EVENT : Mouse over menu
/*-------------------------------------------------------------------------*/

function _event_menu_mouseover(e)
{
	e = _cancel_bubble(e, true);
	menu_action_hover(this);
}

/*-------------------------------------------------------------------------*/
// EVENT: Menu click
/*-------------------------------------------------------------------------*/

function _event_menu_click(e)
{
	e = _cancel_bubble(e, true);
	menu_action_open(this);
}

/*-------------------------------------------------------------------------*/
// Get menu basename
/*-------------------------------------------------------------------------*/

function _menu_get_base_name(cid)
{
	var endpos = cid.indexOf(".");
	
	if (endpos != -1)
	{
		return cid.substr(0, endpos);
	}
	else
	{
		return cid;
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
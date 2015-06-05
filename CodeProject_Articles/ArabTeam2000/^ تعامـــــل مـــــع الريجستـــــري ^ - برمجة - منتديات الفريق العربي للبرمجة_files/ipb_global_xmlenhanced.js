//------------------------------------------------------------------------------
// IPS XML HTTP REQUEST:: GET NEW POSTS
//------------------------------------------------------------------------------
// Supports Safari, Mozilla 1.3+ (Firefox, etc) and IE 5.5+
// (c) 2005 Invision Power Services, Inc.
// http://www.invisionpower.com
//------------------------------------------------------------------------------

/*--------------------------------------------*/
// INIT VARS
/*--------------------------------------------*/

var gnp_div  = 'get-new-posts_menu';
var msg_div  = 'get-new-msgs_menu';
var mem_div  = 'get-members';
var divobj;
var divopen  = 0;
var xmlobj;

var myass_main;
var myass_loaded   = 0;
var pm_cycle_count = 0;
var search_cache   = {};
var posts_st       = 0;

/*--------------------------------------------*/
// Get NEXT posts link
/*--------------------------------------------*/

function xml_show_new_posts( st )
{
	posts_st = st;
	xml_myassistant_init( 'posts' );
}

/*--------------------------------------------*/
// Load MyASSISTANT!
/*--------------------------------------------*/

function xml_myassistant_init( tab )
{
	myass_main    = document.getElementById( 'get-myassistant' );
	myass_drag    = document.getElementById( 'myass-drag' );
	myass_content = document.getElementById( 'myass-content' );
	
	/*--------------------------------------------*/
	// Main function to do on request
	// Must be defined first!!
	/*--------------------------------------------*/
	
	do_request_function = function()
	{
		//----------------------------------
		// Ignore unless we're ready to go
		//----------------------------------
		
		if ( ! xmlobj.readystate_ready_and_ok() )
		{
			// Could do a little loading graphic here?
			return;
		}
		
		//----------------------------------
		// INIT
		//----------------------------------
		
		var html = xmlobj.xmlhandler.responseText;
		
		//----------------------------------
		// Stop IE showing select boxes over
		// floating div [ 1 ]
		//----------------------------------
		
		if ( is_ie )
		{
			 html = "<iframe id='myass-shim' src='javascript;' class='iframshim' scrolling='no' frameborder='0' style='position:absolute; top:0px; left:0px; right:0px; display: none;'></iframe>" + html;
		}
		
		myass_content.innerHTML = html;
		
		//----------------------------------
		// Stop IE showing select boxes over
		// floating div [ 2 ]
		//----------------------------------
		
		if ( is_ie )
		{
			myass_shim               = document.getElementById('myass-shim');
			myass_shim.style.width   = myass_content.offsetWidth;
			myass_shim.style.height  = myass_content.offsetHeight;
			myass_shim.style.zIndex  = myass_content.style.zIndex - 1;
			myass_shim.style.top     = myass_content.style.top;
			myass_shim.style.left    = myass_content.style.left;
			myass_shim.style.display = "block";
		}
	}
	
	xmlobj = new ajax_request();
	xmlobj.onreadystatechange( do_request_function );
	
	//----------------------------------
	// LOAD XML
	//----------------------------------
	
	if ( ! tab )
	{
		xmlobj.process( ipb_var_base_url + 'act=buddy&xml=1' );
	}
	else if ( tab == 'newpms' )
	{
		//----------------------------------
		// Figure out where we are..
		//----------------------------------
		
		var limit_a = 0;
		
		pm_cycle_count++;
		
		if ( pm_cycle_count <= ipb_new_msgs )
		{
			limit_a = pm_cycle_count - 1;
		}
		else
		{
			pm_cycle_count = 1;
		}
		
		xmlobj.process( ipb_var_base_url + 'act=buddy&xml=1&tab=' + tab + '&limit=' + limit_a );

		myass_content.style.width = '399px';
		myass_content.style.overflow = 'auto';
	}
	else if ( tab == 'posts' )
	{
		xmlobj.process( ipb_var_base_url + 'act=buddy&xml=1&tab=' + tab + '&st=' + posts_st );
	}
	else
	{
		xmlobj.process( ipb_var_base_url + 'act=buddy&xml=1&tab=' + tab);
	}
  	
  	myass_main.style.position = 'absolute';
	myass_main.style.display  = 'block';
	myass_main.style.zIndex   = 99;
	
	//----------------------------------
	// Not loaded? INIT
	//----------------------------------
	
	if ( ! myass_loaded )
	{
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
		else if( document.body && ( document.body.clientWidth || document.body.clientHeight ) )
		{
			//----------------------------------
			// Old IE
			//----------------------------------
			
			my_width  = document.body.clientWidth;
			my_height = document.body.clientHeight;
		}
		
		//----------------------------------
		// Get div height && width
		//----------------------------------
		
		var divheight = parseInt( myass_main.style.Height );
		var divwidth  = parseInt( myass_main.style.Width );
		
		divheight = divheight ? divheight : 400;
		divwidth  = divwidth  ? divwidth  : 400;
		
		//----------------------------------
		// Got it stored in a cookie?
		//----------------------------------
		
		var divxy = my_getcookie( 'ipb-myass-div' );
		var co_ords;
		
		if ( divxy && divxy != null )
		{
			co_ords = divxy.split( ',' );
		
			//----------------------------------
			// Got co-ords?
			//----------------------------------
			
			if ( co_ords.length )
			{
				var final_width  = co_ords[0];
				var final_height = co_ords[1];
				
				if ( co_ords[0] > my_width )
				{
					//----------------------------------
					// Keep it on screen
					//----------------------------------
					
					final_width = my_width - divwidth;
				}
				
				if ( co_ords[1] > my_height )
				{
					//----------------------------------
					// Keep it on screen
					//----------------------------------
					
					final_height = my_height - divheight;
				}
				
				myass_main.style.left = final_width  + 'px';
				myass_main.style.top  = final_height + 'px';
			}
		}
		else
		{
			//----------------------------------
			// Reposition DIV roughly centered
			//----------------------------------
			
			myass_main.style.left = my_width  / 2  - (divwidth / 2)  + 'px';
			myass_main.style.top  = my_height / 2 - (divheight / 2 ) + 'px';
		}
		
		Drag.cookiename = 'ipb-myass-div';
		Drag.init( myass_drag, myass_main );
		
		myass_loaded = 1;
	}
}

/*--------------------------------------------*/
// Alter DST Retrieve XML document
/*--------------------------------------------*/

function xml_myassistant_search( url )
{
	var keywords  = document.getElementById('myass-search-input').value;
	var msg_field = document.getElementById('myass-search-message');
	var url       = ipb_var_base_url+'act=Search&CODE=01&forums=all&cat_forum=forum&joinname=1&search_in=posts&result_type=topics&xml=1&keywords='+escape(keywords);

	if ( keywords.length < 4 )
	{
		msg_field.innerHTML = ipb_myass_chars_lang;
		return false;
	}
	
	//----------------------------------
	// Already cached?
	//----------------------------------
	
	if ( search_cache[ keywords ] )
	{
		msg_field.innerHTML = search_cache[ keywords ];
		return;
	}
	
	/*--------------------------------------------*/
	// Main function to do on request
	// Must be defined first!!
	/*--------------------------------------------*/
	
	do_request_function = function()
	{
		//----------------------------------
		// Ignore unless we're ready to go
		//----------------------------------
		
		if ( ! xmlobj.readystate_ready_and_ok() )
		{
			xmlobj.show_loading();
			return;
		}
		
		xmlobj.hide_loading();
		
		//----------------------------------
		// INIT
		//----------------------------------
		
		var html = xmlobj.xmlhandler.responseText;
	
		msg_field.innerHTML      = html;
		search_cache[ keywords ] = html;
	}
	
	//----------------------------------
	// LOAD XML
	//----------------------------------
	
	xmlobj = new ajax_request();
	xmlobj.onreadystatechange( do_request_function );
	
	xmlobj.process( url );
}

/*--------------------------------------------*/
// Alter DST Retrieve XML document
/*--------------------------------------------*/

function xml_dst_set( url )
{
	/*--------------------------------------------*/
	// Main function to do on request
	// Must be defined first!!
	/*--------------------------------------------*/
	
	do_request_function = function()
	{
		//----------------------------------
		// Ignore unless we're ready to go
		//----------------------------------
		
		if ( ! xmlobj.readystate_ready_and_ok() )
		{
			// Could do a little loading graphic here?
			return;
		}
		
		//----------------------------------
		// INIT
		//----------------------------------
		
		var html = xmlobj.xmlhandler.responseText;
	
		if ( html == 'error' )
		{
			window.location = url.replace( '&xml=1', '&xml=0');
		}
	}
	
	//----------------------------------
	// LOAD XML
	//----------------------------------
	
	xmlobj = new ajax_request();
	xmlobj.onreadystatechange( do_request_function );
	
	xmlobj.process( url );
}






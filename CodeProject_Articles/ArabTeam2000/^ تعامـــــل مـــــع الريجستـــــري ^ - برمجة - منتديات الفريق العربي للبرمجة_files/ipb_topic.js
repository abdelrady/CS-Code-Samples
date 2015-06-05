//------------------------------------------
// Invision Power Board v2.1
// Topics JS File
// (c) 2005 Invision Power Services, Inc.
//
// http://www.invisionboard.com
//------------------------------------------

var mystored_selection = '';
var post_cache    = new Array();
var ajax_loaded   = 1;
var ignore_cache  = new Array();

/*--------------------------------------------*/
// Fast reply stuff
/*--------------------------------------------*/

function emoticon( ecode, eobj, eurl )
{
	ecode = ' ' + ecode + ' ';
	var obj_ta = document.getElementById( 'fastreplyarea' );

	if ( (ua_vers >= 4) && is_ie && is_win)
	{
		if (obj_ta.isTextEdit)
		{
			obj_ta.focus();
			var sel = document.selection;
			var rng = sel.createRange();
			rng.colapse;
			if((sel.type == "Text" || sel.type == "None") && rng != null)
			{
				if(ecode != "" && rng.text.length > 0)
					ecode = rng.text + ecode ;
	
				rng.text = ecode;
			}
		}
		else
		{
			obj_ta.value += ecode;
		}
	}
	//----------------------------------------
	// It's MOZZY!
	//----------------------------------------
	
	else if ( obj_ta.selectionEnd )
	{ 
		var ss = obj_ta.selectionStart;
		var st = obj_ta.scrollTop;
		var es = obj_ta.selectionEnd;
		
		if (es <= 2)
		{
			es = obj_ta.textLength;
		}
		
		var start  = (obj_ta.value).substring(0, ss);
		var middle = (obj_ta.value).substring(ss, es);
		var end    = (obj_ta.value).substring(es, obj_ta.textLength);
		
		//-----------------------------------
		// text range?
		//-----------------------------------
		
		if (obj_ta.selectionEnd - obj_ta.selectionStart > 0)
		{
			middle = ecode + middle;
		}
		else
		{
			middle = ecode + middle;
			
		}
		
		obj_ta.value = start + middle + end;
		
		var cpos = ss + (middle.length);
		
		obj_ta.selectionStart = cpos;
		obj_ta.selectionEnd   = cpos;
		obj_ta.scrollTop      = st;
	}
	//----------------------------------------
	// It's CRAPPY!
	//----------------------------------------
	else
	{
		obj_ta.value += ecode;
	}
	
	obj_ta.focus();

	if ( (ua_vers >= 4) && is_ie && is_win && emowindow != 'undefined' )
	{
		emowindow.focus();
	}

	//document.getElementById( 'fastreplyarea' ).value += ' ' + ecode + ' ';
}

/*--------------------------------------------*/
// Topic: Scroll to post: IE fix
/*--------------------------------------------*/

function topic_scroll_to_post( post_id )
{
	//----------------------------------
	// Check for PID
	//----------------------------------
	
	if ( ! post_id )
	{
		return false;
	}
	
	try
	{
		var post_main_obj = document.getElementById( 'post-main-' + post_id );
	}
	catch(error)
	{
		var post_main_obj;
	}
	
	if ( post_main_obj )
	{
		var post_box_top  = _get_obj_toppos( post_main_obj );
		
		if ( post_box_top )
		{
			scroll( 0, post_box_top - 30 );
		}
	}
}

/*--------------------------------------------*/
// Show hidden post
/*--------------------------------------------*/

function topic_show_ignored_post( pid )
{
	try
	{
		// Set up
		var post_main   = document.getElementById( 'post-main-'   + pid );
		var post_ignore = document.getElementById( 'post-ignore-' + pid );
		
		// Show it
		post_main.innerHTML = ignore_cache[ pid ];
	}
	catch( e )
	{
		//alert( e );
	}
	
	return false;
}


/*--------------------------------------------*/
// Initiate topic hide
/*--------------------------------------------*/

function topic_init_ignored_post( pid )
{
	try
	{
		// Set up
		var post_main   = document.getElementById( 'post-main-'   + pid );
		var post_ignore = document.getElementById( 'post-ignore-' + pid );
		
		// Cache it...
		ignore_cache[ pid ] = post_main.innerHTML;
		
		// Display "ignored" msg
		post_main.innerHTML = post_ignore.innerHTML;
	}
	catch( e )
	{
		//alert( e );
	}
}

/*--------------------------------------------*/
// Window Resize
/*--------------------------------------------*/

function ajax_std_window_resize( pix, pid )
{
	var box        = document.getElementById( 'post-edit-'+pid );
	var cur_height = parseInt( box.style.height ) ? parseInt( box.style.height ) : 300;
	var new_height = cur_height + pix;
	
	if ( new_height > 0 )
	{
		box.style.height = new_height + "px";
	}
	
	return false;
}

/*--------------------------------------------*/
// Ajax: Cancel for edit
/*--------------------------------------------*/

function ajax_cancel_for_edit( post_id )
{
	if ( post_cache[ post_id ] != "" )
	{
		document.getElementById( 'post-'+post_id ).innerHTML = post_cache[ post_id ];
	}
	
	return false;
}

/*--------------------------------------------*/
// Ajax: Save for edit
/*--------------------------------------------*/

function ajax_save_for_edit( post_id )
{
	//----------------------------------
	// INIT
	//----------------------------------
	
	var url    = ipb_var_base_url+'act=xmlout&do=post-edit-save&p='+post_id+'&t='+ipb_input_t+'&f='+ipb_input_f;
	var fields = new Array();

	//----------------------------------
	// Populate fields
	//----------------------------------
	
	fields['md5check'] = ipb_md5_check;
	fields['t']        = ipb_input_t;
	fields['f']        = ipb_input_f;
	fields['p']        = post_id;
	fields['act']      = 'xmlout';
	fields['do']       = 'post-edit-save';
	fields['Post']     = document.getElementById( 'post-edit-'+post_id ).value;
	fields['std_used'] = 1;  // Make sure STD BBCode parser is used
	
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

		if ( html != 'error' )
		{
			document.getElementById( 'post-'+post_id ).innerHTML = html;
		}
	}
	
	//----------------------------------
	// LOAD XML
	//----------------------------------
	
	xmlobj = new ajax_request();
	xmlobj.onreadystatechange( do_request_function );
	var xmlreturn = xmlobj.process( url, 'POST', xmlobj.format_for_post(fields) );
	
	post_cache[ post_id ] = '';
	
	return false;
}

/*--------------------------------------------*/
// Ajax: Prep for edit
/*--------------------------------------------*/

function ajax_prep_for_edit( post_id, event )
{
	//----------------------------------
	// Cancel bubble (Prevent IE scroll...)
	//----------------------------------
	
	global_cancel_bubble( event, true );
	
	var post_main_obj = document.getElementById( 'post-main-' + post_id );
	var post_box_top  = _get_obj_toppos( post_main_obj );
	
	//----------------------------------
	// INIT
	//----------------------------------
	
	var url = ipb_var_base_url+'act=xmlout&do=post-edit-show&p='+post_id+'&t='+ipb_input_t+'&f='+ipb_input_f;
	
	if ( ! post_cache[ post_id ] || post_cache[ post_id ] == '' )
	{
		post_cache[ post_id ] = document.getElementById( 'post-'+post_id ).innerHTML;
	}

	//----------------------------------
	// Attempt to close open menus
	//----------------------------------
	
	try
	{
		menu_action_close();
	}
	catch(e)
	{
		//alert( e );
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
		
		if ( html == 'nopermission' )
		{
			alert( js_error_no_permission );
		}
		else if ( html != 'error' )
		{
			if ( post_box_top )
			{
				scroll( 0, post_box_top - 30 );
			}
			
			document.getElementById( 'post-'+post_id ).innerHTML = html;
		}
		
	}
	
	//----------------------------------
	// LOAD XML
	//----------------------------------
	
	xmlobj = new ajax_request();
	xmlobj.onreadystatechange( do_request_function );
	
	xmlobj.process( url );
	
	return false;
}

/*--------------------------------------------*/
// check selection
/*--------------------------------------------*/

function checkselection()
{
	var myselection = '';
	
	if ( window.getSelection )
	{
		myselection = window.getSelection();
	}
	else if ( document.selection )
	{
		myselection = document.selection.createRange().text;
	}
	else if ( document.getSelection )
	{
		myselection = document.getSelection();
	}
	
 	if ( myselection != '' && myselection != null )
	{
		if ( myselection != mystored_selection )
		{
			document.getElementById('fastreply-pastesel').style.display = '';
			mystored_selection = (myselection.toString() != '') ? myselection.toString() : null;
		}
	}
	else
	{
		mystored_selection = null;
	}
}

/*--------------------------------------------*/
// Paste selection
/*--------------------------------------------*/

function pasteselection()
{
	if ( mystored_selection != '' && mystored_selection != null )
	{
		var fr = document.getElementById('fastreplyarea');
		if (fr)
		{
			fr.value += '[quote]'+mystored_selection+'[/quote]\n';
			fr.focus();
		}
	}

	return false;
}

/*--------------------------------------------*/
// Link to a post
/*--------------------------------------------*/

function link_to_post(pid)
{
	temp = prompt( ipb_lang_tt_prompt, ipb_var_base_url + "showtopic=" + ipb_input_t + "&view=findpost&p=" + pid );
	return false;
}

/*--------------------------------------------*/
// Delete post
/*--------------------------------------------*/

function delete_post(theURL)
{
	if (confirm( ipb_lang_js_del_1 ))
	{
		window.location.href=theURL;
	}
	else
	{
		alert ( ipb_lang_js_del_2 );
	} 
}

/*--------------------------------------------*/
// Multi quote
/*--------------------------------------------*/

function multiquote_add(id)
{
	saved = new Array();
	clean = new Array();
	add   = 1;
	
	//-----------------------------------
	// Get any saved info
	//-----------------------------------
	
	if ( tmp = my_getcookie('mqtids') )
	{
		saved = tmp.split(",");
	}
	
	//-----------------------------------
	// Remove bit if exists
	//-----------------------------------
	
	for( i = 0 ; i < saved.length; i++ )
	{
		if ( saved[i] != "" )
		{
			if ( saved[i] == id )
			{
				 add = 0;
			}
			else
			{
				clean[clean.length] = saved[i];
			}
		}
	}
	
	//-----------------------------------
	// Add?
	//-----------------------------------
	
	if ( add )
	{
		clean[ clean.length ] = id;
		eval("document.mad_"+id+".src=removequotebutton");
	}
	else
	{
		eval(" document.mad_"+id+".src=addquotebutton");
	}
	
	my_setcookie( 'mqtids', clean.join(','), 0 );
	
	return false;
}

/*--------------------------------------------*/
// Check delete
/*--------------------------------------------*/

function checkdelete()
{
	if ( ! document.modform.selectedpids.value )
	{
		return false;
	}
	
	isDelete = document.modform.tact.options[document.modform.tact.selectedIndex].value;
	
	if (isDelete == 'delete')
	{
		formCheck = confirm( lang_suredelete );
		
		if (formCheck == true)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

/*--------------------------------------------*/
// Toggle selection
//*--------------------------------------------*/

function topic_toggle_pid( pid )
{
	//-----------------------------------
	// Got a number?
	//-----------------------------------
	
	if ( isNaN( pid ) )
	{
		return false;
	}
	
	saved = new Array();
	clean = new Array();
	add   = 1;
	
	//-----------------------------------
	// Get form info
	//-----------------------------------
	
	tmp = document.modform.selectedpids.value;
	
	saved = tmp.split(",");
	
	//-----------------------------------
	// Remove bit if exists
	//-----------------------------------
	
	for( i = 0 ; i < saved.length; i++ )
	{
		if ( saved[i] != "" )
		{
			if ( saved[i] == pid )
			{
				 add = 0;
			}
			else
			{
				clean[clean.length] = saved[i];
			}
		}
	}
	
	//-----------------------------------
	// Add?
	//-----------------------------------
	
	if ( add )
	{
		clean[ clean.length ] = pid;
		eval("document.img"+pid+".src=selectedbutton");
	}
	else
	{
		eval(" document.img"+pid+".src=unselectedbutton");
	}
	
	newvalue = clean.join(',');
	
	my_setcookie( 'modpids', newvalue, 0 );
	
	document.modform.selectedpids.value = newvalue;
	
	newcount = stacksize(clean);
	
	document.modform.gobutton.value = lang_gobutton + ' (' + newcount + ')';
	
	return false;
}
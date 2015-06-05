var ztag_xml;
var ztag_deleted;
var ztag_next;

function ztag_submit(submitaction, querystr, formobj)
{
	ztag_xml = new vB_AJAX_Handler(true);
	ztag_xml.init();
	if( !ztag_xml.is_compatible() )
	{
		return true;
	}

	var tag = formobj.tag.value;
	formobj.tag.value = "";
	ztag_xml.onreadystatechange(handle_ajax_ztag_submit);
	ztag_xml.send(submitaction, querystr + "&tag=" + PHP.urlencode(tag));
	return false;
}

function ztag_remove_tag(submitaction, querystr, tag, nexttag)
{
	ztag_xml = new vB_AJAX_Handler(true);
	if( !ztag_xml.is_compatible() )
	{
		return true;
	}

	ztag_xml.onreadystatechange(handle_ajax_ztag_submit);
	ztag_xml.send("ajax.php", querystr);
	return false;
}

function handle_ajax_ztag_submit()
{
	if( ztag_xml.handler.readyState == 4 && ztag_xml.handler.status == 200 )
	{
		if( ztag_xml.handler.responseXML )
		{
			if( fetch_tags(ztag_xml.handler.responseXML, 'error').length)
			{
				alert(ztag_xml.fetch_data(fetch_tags(ztag_xml.handler.responseXML, 'error')[0]));
			}
			else
			{
				if( fetch_tags(ztag_xml.handler.responseXML, 'tagcloud')[0] )
				{
					fetch_object("ztag_container").innerHTML = ztag_xml.fetch_data(fetch_tags(ztag_xml.handler.responseXML, 'tagcloud')[0]);
				}
			}
		}
	}
}
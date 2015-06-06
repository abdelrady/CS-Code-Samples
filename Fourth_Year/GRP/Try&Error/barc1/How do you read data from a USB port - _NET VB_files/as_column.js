function google_ad_request_done(google_ads) {
/*
* This function is required and is used to display
* the ads that are returned from the JavaScript
* request. You should modify the document.write
* commands so that the HTML they write out fits
* with your desired ad layout.
*/
var s = '';
var i;

/*
* Verify that there are actually ads to display.
*/
if (google_ads.length == 0) {
return;
}


if (google_ads[0].type == "flash") {


   s += '' + 
'<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"' +
' codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0"' +
' WIDTH="' + google_ad.image_width +
'" HEIGHT="' + google_ad.image_height + '">' +
'<PARAM NAME="movie" VALUE="' + google_ad.image_url + '">'
'<PARAM NAME="quality" VALUE="high">'
'<PARAM NAME="AllowScriptAccess" VALUE="never">'
'<EMBED src="' + google_ad.image_url +
'" WIDTH="' + google_ad.image_width +
'" HEIGHT="' + google_ad.image_height + 
'" TYPE="application/x-shockwave-flash"' + 
' AllowScriptAccess="never" ' + 
' PLUGINSPAGE="http://www.macromedia.com/go/getflashplayer"></EMBED></OBJECT>' +
'<div class="gcoladby"><a href=\"' + google_info.feedback_url + '\" style="color:000000">Ads by Google</a></div>';


} else if (google_ads[0].type == "image") {


s += '<a href="' + google_ads[0].url +
'" target="_top" title="go to ' + google_ads[0].visible_url +
'"><img border="0" src="' + google_ads[0].image_url +
'"width="' + google_ads[0].image_width +
'"height="' + google_ads[0].image_height + '"></a>' +
'<div class="gcoladby"><a href=\"' + google_info.feedback_url + '\" style="color:000000">Ads by Google</a></div>';


} else {


	/*
	* For text ads, append each ad to the string.
	*/

	s += '<div id="rightads">';

	for(i = 0; i < google_ads.length; ++i) {


				s += '<div class="gcolad">' +
		'<a href="' + google_ads[i].url + '" ' +
		'onmouseout="window.status=\'\'" ' +
		'onmouseover="window.status=\'go to ' +
		google_ads[i].visible_url + '\'">' +
		'<span class="title">' + google_ads[i].line1 + '</span>' +
		'<span class="desc"> - ' +
		google_ads[i].line2 + ' ' +
		google_ads[i].line3 + '' +
		'. ( <span class="url">' +
		google_ads[i].visible_url + '' +
		'</span> ) </span>' +
		'</a>' +
		'</div>';

	}

	s += '<div class="gcoladby">' +
	'<a href=\"' + google_info.feedback_url + '\">Ads by Google</a>' +
	'</div></div>';


}


	document.write(s);
	return;
	}

	google_ad_client = 'pub-8550604525820387'; // substitute your client_id (pub-#)
	google_ad_channel = "5288019193";
	google_ad_output = 'js';
	google_skip = '2'; 
	google_max_num_ads = '3';
	google_ad_type = 'text';
	google_image_size = '300x250';
	google_feedback = 'on';
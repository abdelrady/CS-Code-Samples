
	function showCookieMessage() {
		
		msgBox = document.getElementById('cookiemessage');
		
		msgVal = '<p style="color: #FF0000"><strong>Thank You for using '+sitename+ ' </strong></p>';
		msgVal += '<p style="color: #FF0000"><strong>We noticed that cookies are not currently enabled in your browser which will keep you from being able to log into our site. Please take a moment and update your cookie settings. For instructions on how to make this update, please click <a href=\"/'+faqlink+'\"> here</a>.</strong></p>';
		
		msgBox.innerHTML = msgVal;

		msgBox.style.height = 'auto';
		msgBox.style.width = 'auto';
		msgBox.style.fontFamily = '"Trebuchet MS", Tahoma, Helvetica, sans-serif';
		msgBox.style.fontSize = '12px';
		msgBox.style.marginTop = '10px';
		msgBox.style.marginRight = '110px';
		msgBox.style.marginLeft = '110px';
		msgBox.style.marginBottom = '10px';
		msgBox.style.paddingRight = '10px';
		msgBox.style.paddingLeft = '10px';
		msgBox.style.border = '1px solid #740000';
		msgBox.style.visibility = 'visible';
		msgBox.style.backgroundColor='#EEEEEE';
		msgBox.style.position = 'relative';
		msgBox.style.zIndex= '999';
		}

if ( !checkCookie() )
		showCookieMessage();
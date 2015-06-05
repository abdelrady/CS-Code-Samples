function iMAWebSyncIDAppender() {
	var cookieName = 'com.vtrenz.iMAWebCookie';
	var iMAWindowOnLoad;
	
	this.main = function() {
		if(window.onload) iMAWindowOnLoad = window.onload;
		window.onload = _iMAWebSyncIDAppender.appendCookieToLinks;
	}

	this.appendCookieToLinks = function() {
		if(iMAWindowOnLoad) iMAWindowOnLoad();
		
		var webSyncID = readCookie(cookieName);
		
		if(webSyncID) {
			var linkarray = document.getElementsByTagName("A");
			
			for(var i=0; i<linkarray.length; i++) {
				var href = linkarray[i].href;
				var param = 'webSyncID=' + webSyncID;
				
				if(href.indexOf("//gw.") > 0) {
					if(href.indexOf("?") > 0)
						param = '&' + param;
					else
						param = '?' + param;
						
					linkarray[i].href = href + param;
				}
			}
		}
	}

	var readCookie = function(name) {
		var ca = document.cookie.split(';');
		var nameEQ = name + "=";
		
		for(var i=0; i < ca.length; i++) {
			var c = ca[i];

			while (c.charAt(0)==' ')
				c = c.substring(1, c.length); //delete spaces

			if (c.indexOf(nameEQ) == 0)
				return c.substring(nameEQ.length, c.length);
		}
		
		return "";
	}
}

var _iMAWebSyncIDAppender = new iMAWebSyncIDAppender();
_iMAWebSyncIDAppender.main();

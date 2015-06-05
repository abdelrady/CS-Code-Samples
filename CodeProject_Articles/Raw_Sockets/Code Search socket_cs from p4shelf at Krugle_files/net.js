//<![CDATA[
/*
 * net.js - provides network "AJAX" HTTP loader object, and supporting functionality
 * Chris Burmester, Krugle, Inc.
 *
 * Requires krugle namespace
 * Uses krugle.auth module (doesn't block load, however)
*/
var moduleName = "krugle.net (net.js)";

/* make sure we have all required dependencies loaded for this module */
var loadErrors = "";

if (window.krugle === undefined) {
	// check for krugle namespacing object literal
	loadErrors += "- requires that the krugle namespace {} be defined\n";
	
} else {

}

if (loadErrors !== "") {
	alert(moduleName + ":\n" + loadErrors + "\n\nAborting load of module.");

} else {
	// required dependencies present - load module

	/* create a support namespacing object literal */
	krugle.net = {};
	
	krugle.net.READY_STATE_UNINITIALIZED = 0;
	krugle.net.READY_STATE_LOADING = 1;
	krugle.net.READY_STATE_LOADED = 2;
	krugle.net.READY_STATE_INTERACTIVE = 3;
	krugle.net.READY_STATE_COMPLETE = 4;
	
	/* flag for whether to show group access denied error */
	/* a hack to only show this message once in a session - on load */
	krugle.net.showGroupAccessDeniedMsg = true;
	
	/* Stubs for start and stop indicator functions. These do
	** nothing and should be overridden by the application to
	** provide progress indication during Http load.  */
	krugle.net.startProgress = function() {};
	krugle.net.stopProgress = function() {};
	
	/* internal progress indicator methods - allows other activities to occur */
	krugle.net.initiateProgress = function(url)
	{
		if (url.indexOf("api_log.pl") == -1) {
			// only start progress indicator if not a "log" event
			krugle.net.startProgress();
		}
	};

	krugle.net.terminateProgress = function(url)
	{
		if (url.indexOf("api_log.pl") == -1) {
			// only stop progress indicator if not a "log" event
			krugle.net.stopProgress();
		}
	};
	
	/* Cross-Browser Http Loader object. Instantiate a separate object for
	** each connection/request so that they do not collide.
	*/
	krugle.net.HttpLoader = function(
		url,
		onload,
		context,
		onerror,
		method,
		params,
		contentType,
		username,
		password)
	{
	
		this.url=url;
		this.req=null;
		this.context=(context) ? context : "";	// passed data for context
		this.onload=onload;
		this.onerror=(onerror) ? onerror : this.defaultError;
		this.method=(method) ? method : "GET";	// default to GET
		this.params=params;
		this.contentType=contentType;
		this.username = (username) ? username: "";
		this.password = (password) ? password: "";
	
		krugle.net.initiateProgress(this.url);
	
		var values = this.addAuthInfo(url,params);
		url = values[0];
		params = values[1];
	
		this.loadXMLDoc(url,this.method,params,contentType,username,password);
	};
	
	/* method used to re-submit a loader object that was previously paused and queued */
	krugle.net.HttpLoader.prototype.reSubmit = function()
	{
		var values = this.addAuthInfo(this.url,this.params);
		url = values[0];
		params = values[1];
	
		this.loadXMLDoc(
			url,
			this.method,
			params,
			this.contentType,
			this.username,
			this.password);
	};
	
	/* HACK: method to add authentication information to all krugle API calls */
	krugle.net.HttpLoader.prototype.addAuthInfo = function(url,params)
	{
		var authStr = krugle.auth.urlAuthParams();
	
		if (this.method == "GET") {
			if (url.indexOf("_krugleun") == -1) {
				if (url.indexOf("?") == -1) {
					url += "?" + authStr;
				} else {
					url += "&" + authStr;
				}
			}
		} else {
			if (params !== "") {
				params += "&";
			}
			params += authStr;
		}
		return [url,params];
	};
	
	/* using browser appropriate method, request load of document */
	krugle.net.HttpLoader.prototype.loadXMLDoc = function(
		url,
		method,
		params,
		contentType,
		username,
		password)
	{
	
		if (!contentType && method=="POST"){
			contentType='application/x-www-form-urlencoded';
		}
		
		if (window.XMLHttpRequest){
			this.req=new XMLHttpRequest();
		} else if (window.ActiveXObject){
			this.req=new ActiveXObject("Microsoft.XMLHTTP");
		}
		
		if (this.req){
			try {
				var loader=this;
				this.req.onreadystatechange = function() {
					krugle.net.HttpLoader.onReadyState.call(loader);
				};
				this.req.open(method,url,true,username,password);
				if (contentType) {
					this.req.setRequestHeader('Content-Type', contentType);
				}
				this.req.send(params);
			} catch (err) {
				krugle.net.terminateProgress(this.url);
				this.onerror.call(this);
			}
		}
	};
	
	/* method to call when the ready state of the connection changes */
	krugle.net.HttpLoader.onReadyState = function()
	{
		var req=this.req;
		var ready=req.readyState;
	
		if (ready == krugle.net.READY_STATE_COMPLETE) {
			var httpStatus = req.status;
			if (httpStatus == 200 || httpStatus === 0) {
				krugle.net.terminateProgress(this.url);
				this.onload.call(this);
			} else {
				krugle.net.terminateProgress(this.url);
				if (httpStatus == 403 && krugle.auth.reAuthenticate) {
					// authorization error
					if (this.context[0] == "SIGNIN") {
						// failed re-signing attempt
						if (this.context[1] == "MANUAL") {
							// user login, show signin again
							krugle.auth.showSignin();
						} else {
							// auto signin - error - shouldn't happen
							alert("Failed session reauthorization. Please reload the page.");
						}
					} else {
						// expired credentials, reauthenticate
						krugle.auth.reAuthenticate(this);
					}
				} else {
					this.onerror.call(this);
				}
			}
		}
	};
	
	/* default error function to use when one isn't specified */
	krugle.net.HttpLoader.prototype.defaultError = function()
	{
		// supress net loader errors from log callbacks
		if (this.url.indexOf("api_log.pl") == -1) {
			if (this.req.responseText.indexOf("KRUGLE_ERROR") == 0) {
				// specific error message from middleware - display in alert
				var parts = this.req.responseText.split("\n");
				if (parts[1] == "-30") {
					if (krugle.net.showGroupAccessDeniedMsg) {
						// don't show this message again
						krugle.net.showGroupAccessDeniedMsg = false;
						alert("You do not have privileges necessary to access requested resources.\n\nContact your Krugle administrator for assistance.");
					}
					if (krugle.kse !== undefined) {
						krugle.kse.logEvent(krugle.log.kseAccessRestricted, {url: ("/kse/" + parts[2])});
					}
				} else {
					alert(parts[3]);
				}
			} else {
				// show generic error message
				alert("Error fetching data."
					+"\n\nreadyState: " + this.req.readyState
					+"\nurl: " + this.url
					+"\nstatus: " + this.req.status
					+"\ndata: " + this.req.responseText
					+"\nheaders: " + this.req.getAllResponseHeaders());
			}
		}
	};
	
	/* General purpose callback function for the net content loader object to use
	** to give a simple confirmation message. The name of the object that is being
	** confirmed as received is passed in the content loader's this.context. This
	** method is called with context of "this" set to the content loader object.
	*/
	krugle.net.loaderReturnConfirm = function()
	{
		alert("Your " + this.context + " has been received. Thank you.");
	};

}
//]]>

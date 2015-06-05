//<![CDATA[
/*
 * auth.js - provides signin and authentication functionality
 * Chris Burmester, Krugle, Inc.
 *
 * Requires krugle namespace.
 * Requires krugle.net module
 * Requires krugle.dialogs module
 * Requires krugle.log module
 * Required inclusion of XHTML template code from /include/auth.html
*/

var moduleName = "krugle.auth (auth.js)";

/* make sure we have all required dependencies loaded for this module */
var loadErrors = "";

if (window.krugle === undefined) {
	// check for krugle namespacing object literal
	loadErrors += "- requires that the krugle namespace {} be defined\n";
	
} else {
	// check for required modules
	if (krugle.net === undefined) {
		loadErrors += "- requires that the krugle.net module be loaded\n";
	}
	if (krugle.dialogs === undefined) {
		loadErrors += "- requires that the krugle.dialogs module be loaded\n";
	}
}

if (loadErrors !== "") {
	alert(moduleName + ":\n" + loadErrors + "\n\nAborting load of module.");

} else {
	// required dependencies present - load module

	/* create a support namespacing object literal */
	krugle.auth = {};

	/* constants used by this module */
	krugle.auth.anonUserName = "anonymous";
	krugle.auth.tempUserName = "";
	krugle.auth.clientName = "";
	krugle.auth.clientAuth = "";
	krugle.auth.userName = "";
	krugle.auth.userAuth = "";
	krugle.auth.userPassword = "";
	krugle.auth.userEmail = "";
	
	/* tokens used when the KSE is using both local and Open/Public API */
	krugle.auth.openAPI = {};
	krugle.auth.openAPI.userName = "";
	krugle.auth.openAPI.userAuth = "";
	krugle.auth.openAPI.clientName = "";
	krugle.auth.openAPI.clientAuth = "";
	
	krugle.auth.openAPI.isEnabled = function() {
		return (krugle.auth.openAPI.userName
			&& krugle.auth.openAPI.userAuth
			&& krugle.auth.openAPI.clientName
			&& krugle.auth.openAPI.clientAuth);
	};
	
	/* default target URL (return to URL) passed to registration page to return to */
	krugle.auth.regTargetUrl = "/";
	
	/* prefix assigned to the visible sign-in link - defaults to nothing - useful for partner sites
	** and typically set in the topnav.html include to differentiate our signin from their signin */
	krugle.auth.signInLinkPrefix = "";
	
	/* user definable onSignin Success/Cancel event methods - reset after each signin attempt */
	krugle.auth.onSigninSuccess = function() {};
	krugle.auth.onSigninCancel = function() {};
	
	
	/* UI Text Constants */
	krugle.auth.signinTitle = "Sign In";
	krugle.auth.signinCancelBtn = "Cancel";
	krugle.auth.signinSubmitBtn = "Sign In";
	
	/* test method to determine if user is anonymous user */
	krugle.auth.isAnonymous = function(userName)
	{
		if (!userName) {
			userName = krugle.auth.userName;
		}
		return (userName.indexOf(krugle.auth.anonUserName) == 0);
	};
	
	/* show a signin dialog */
	krugle.auth.showSignin = function(onSigninSuccessMethod, onSigninCancelMethod)
	{
		try {
			// log this event
			var eventData = {
				event: krugle.log.kseSigninLink
			};
			krugle.eventLogger.send(eventData);
	
			if (onSigninSuccessMethod) {
				// extra functionality defined to be called if/when signin successful
				krugle.auth.onSigninSuccess = onSigninSuccessMethod;
			} else {
				krugle.auth.onSigninSuccess = function() {};
			}
			
			if (onSigninCancelMethod) {
				krugle.auth.onSigninCancel = onSigninCancelMethod;
			} else {
				krugle.auth.onSigninCancel = function() {};
			}
			
			var templateHTML = "";
			if (krugle.conf.mode == "enterprise") {
				templateHTML = document.getElementById('_template_enterprise_signinform').innerHTML;
			} else {
				templateHTML = document.getElementById('_template_signinform').innerHTML;
			}
			
			var hideCancelBtn = false;
			// hide the cancel button if in enterprise mode and user signin is required
			if (krugle.conf.mode === "enterprise" && krugle.conf.authRequired) {
				// hide the cancel button for enterprise
				hideCancelBtn = true;
			}
			
			krugle.dialogs.showModalWindow(
				krugle.auth.signinTitle,
				false,
				krugle.auth.handleSignin,
				krugle.auth.signinCancelBtn,
				krugle.auth.signinSubmitBtn,
				templateHTML,
				'username',
				krugle.auth.cancelSignin,
				hideCancelBtn);
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.auth.showSignin",e);
		}
	};
	
	/* called when the signin dialog is canceled */
	krugle.auth.cancelSignin = function()
	{
		// log this event
		var eventData = {
			event: krugle.log.kseDialogCancel,
			uiType: "signinDialog"
		};
		krugle.eventLogger.send(eventData);
		
		// call the user definable signin cancel method
		krugle.auth.onSigninCancel();
		
		// reset the onSignin Success/Cancel user definable methods
		krugle.auth.onSigninSuccess = function() {};
		krugle.auth.onSigninCancel = function() {};
	};
	
	/* function to handle the submit of the signin dialog */
	krugle.auth.handleSignin = function()
	{
		var errorStr = "";
		var logErrorStr = "";
		if (document._mw_form.username.value === "") {
			errorStr += "Please enter your user name.\n";
			logErrorStr += "no username,";
		} else {
			if (krugle.auth.isAnonymous(document._mw_form.username.value)) {
				errorStr += "You can't signin as an anonymous user. Please use your personal username or register to obtain one.\n";
				logErrorStr += "anonymous username,";
			}
		}
		if (document._mw_form.password.value === "") {
			errorStr += "Please enter your password.\n";
			logErrorStr += "no password,";
		}

		// log this event
		var eventData = {
			event: krugle.log.kseDialogSubmit,
			uiType: "signinDialog",
			uiInputInvalid: logErrorStr,
			uiMisc: encodeURIComponent("new_un=" + document._mw_form.username.value)
		};
		krugle.eventLogger.send(eventData);

		if (errorStr) {
			alert(errorStr);
			return false;
		}
		

		// update temp UserName used
		krugle.auth.tempUserName = document._mw_form.username.value;
		
		// check if the SSO/remember me checkbox is checked
		var sso = "";
		if (document._mw_form.sso.checked) {
			sso = encodeURIComponent(document._mw_form.sso.value);
		}
		// now post call to re-authenticate
		var loader = new krugle.net.HttpLoader(krugle.conf.middlewareServerURL + krugle.conf.middlewarePath + "/api_auth.pl?action=login&"
			+ "un=" + encodeURIComponent(document._mw_form.username.value)
			+ "&pw=" + encodeURIComponent(document._mw_form.password.value)
			+ "&sso=" + sso,
			krugle.auth.handleAuthResponse, ["SIGNIN", "MANUAL",krugle.auth.onSigninSuccess,krugle.auth.onSigninCancel]);
			
		return true;
	};
	
	/* method called to load to the MyKrugle Registration page */
	krugle.auth.loadRegistration = function(targetUrl)
	{
		try {
			krugle.auth.postKrugleAuthState("/usersettings/register.jsp", targetUrl);
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.auth.loadRegistration",e);
		}
	};
	
	/* function called to post the authentication values and kse state to another pageUrl - typically MyKrugle */
	krugle.auth.postKrugleAuthState = function(pageUrl, targetUrl)
	{
		document.krugleStatePostForm.action = pageUrl;

		document.krugleStatePostForm._krugleun.value = krugle.auth.userName;
		document.krugleStatePostForm._krugleua.value = krugle.auth.userAuth;
		document.krugleStatePostForm._kruglecn.value = krugle.auth.clientName;
		document.krugleStatePostForm._krugleca.value = krugle.auth.clientAuth;
		document.krugleStatePostForm._oun.value = krugle.auth.openAPI.userName;
		document.krugleStatePostForm._oua.value = krugle.auth.openAPI.userAuth;
		document.krugleStatePostForm._ocn.value = krugle.auth.openAPI.clientName;
		document.krugleStatePostForm._oca.value = krugle.auth.openAPI.clientAuth;
		
		if (!targetUrl) {
			targetUrl = "/";	// always default to the KSE
		}
		document.krugleStatePostForm.url.value = targetUrl;

		if (krugle.kse) {
			// if in the KSE, then save state
			document.krugleStatePostForm.ksestate.value = krugle.kse.serializeState();
		}
		
		document.krugleStatePostForm.submit();
	};	
	
	/* called by the /register registration page when registration is complete
	** to pass the username and password back to the client so that we can
	** sign in the user
	*/
	krugle.auth.handleRegistration = function(username,password)
	{
		document._mw_form.username.value = username;
		document._mw_form.password.value = password;
		alert("Your registration is complete.\n\nPlease submit your new username and password to sign in.");
		
	};
	
	
	/* called when loader gets a 403 - call to reauthenticate */
	krugle.auth.reAuthenticate = function(loader)
	{
		// add loader to queue
		krugle.auth.reAuthenticate._authQueue[krugle.auth.reAuthenticate._authQueue.length] = loader;
		
		if ( !krugle.auth.reAuthenticate._authenticating ) {
			krugle.auth.reAuthenticate._authenticating = true;
			/* do anonymous signin on reauthentication */
			krugle.auth.doAnonymousSignin(krugle.auth.userName);
		}
	};
	krugle.auth.reAuthenticate._authenticating = false;
	krugle.auth.reAuthenticate._authQueue = [];
	
	/* start an anonymous sign in request */
	krugle.auth.doAnonymousSignin = function(userName)
	{
		// allow passing of username to use to sign in with
		// so that it can be used to flag a reauthentication attempt
		// when sessions time out
		if (!userName) {
			userName = krugle.auth.anonUserName;
		}
		// update temp UserName used
		krugle.auth.tempUserName = userName;
		
		// now post call to re-authenticate
		// anonymous password stored in middleware - pass placeholder password
		var loader = new krugle.net.HttpLoader(krugle.conf.middlewareServerURL
			+ krugle.conf.middlewarePath + "/api_auth.pl?action=login&"
			+ "un=" + encodeURIComponent(userName)
			+ "&pw=" + encodeURIComponent(""),
			krugle.auth.handleAuthResponse, ["SIGNIN","AUTO"]);
	};
	
	/* sign out by signing in as anonymous user */
	krugle.auth.doSignOut = function()
	{	
		try {		
			// log this event
			var eventData = {
				event: krugle.log.kseSignoutLink
			};
			krugle.eventLogger.send(eventData);
	
			// make a call to sign out
			var loader_signout = new krugle.net.HttpLoader(
				krugle.conf.middlewareServerURL + krugle.conf.middlewarePath + "/api_auth.pl?action=logout",
				nullReturn);
			
			// update temp UserName used
			krugle.auth.tempUserName = krugle.auth.anonUserName;
		
			// now resignin as anonymous user
			// anonymous password stored in middleware - pass placeholder password
			var loader_signin = new krugle.net.HttpLoader(
				krugle.conf.middlewareServerURL + krugle.conf.middlewarePath + "/api_auth.pl?action=login&"
				+ "un=" + encodeURIComponent(krugle.auth.anonUserName)
				+ "&pw=" + encodeURIComponent(""),
				krugle.auth.handleAuthResponse, ["SIGNIN","MANUAL"]);
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.auth.doSignOut",e);
		}

	};
	
	/* LOADER CALLBACK: get's successful response from reauthorization
	** should update the global authentication tokens and then relaunch
	** each of the queued loader objects */
	krugle.auth.handleAuthResponse = function()
	{
		// format of response is "username\nclientAuthToken\nuserAuthToken\nemail\nopenAPIuserName\nopenAPIclientAuth\nopenAPIuserAuth\n"
		// or "fail\n\n\n\n\n\n\n"
		// If an OpenAPI is in use, then a second set of OpenAPI tokens are also
		// returned
		tokens = this.req.responseText.split("\n");
		
		var signinSuccessMethod = false;
		var signinCancelMethod = false;
		if (this.context.length > 2) {
			signinSuccessMethod = this.context[2];
			signinCancelMethod = this.context[3];
		}
		
		if (tokens[0] == "fail") {
			krugle.auth.showSignin(signinSuccessMethod,signinCancelMethod);
			document._mw_form.username.value = krugle.auth.tempUserName;
			alert("Invalid username or password. Please check your entry and try again.");
		} else if (tokens[0] == "failclient") {
			krugle.auth.showSignin(signinSuccessMethod,signinCancelMethod);
			document._mw_form.username.value = krugle.auth.tempUserName;
			var message = "Missing or incorrect authentication credentials.";
			if (krugle.conf.mode === "enterprise") {
				message += "\n\nPlease verify with your system administrator that your Krugle Enterprise client login and password are set correctly.";
			}
			alert(message);
		} else if (tokens[0] == "signin page") {
			// display the standalone signin page
			window.location.href = "/signin/";
		} else {
			var prevUserName = krugle.auth.userName;
			krugle.auth.userName = tokens[0];
			krugle.auth.clientAuth = tokens[1];
			krugle.auth.userAuth = tokens[2];
			krugle.auth.userEmail = tokens[3];
			
			// Open API tokens - only set if in use
			krugle.auth.openAPI.userName = tokens[4];
			krugle.auth.openAPI.clientAuth = tokens[5];
			krugle.auth.openAPI.userAuth = tokens[6];
			
			krugle.auth.updateSignInLink();
		
			if (krugle.auth.isAnonymous()) {
				// anonymous signin - reauthentication
				if (prevUserName != krugle.auth.anonUserName) {
					// was signed in as valid user before, notify them
					if (this.context[1] == "AUTO") {
						// auto anonymous reauthentication
						alert("Your " + prevUserName + " user session expired. You have been signed out.");
					}
				}
				// otherwise just re-signing in as anonymous - nothing to say or do
			}
			
			// release authentication semaphore
			krugle.auth.reAuthenticate._authenticating = false;
			
			// now pop all loader objects off queue and resubmit them
			// starting from the first elemenet of the array
			var loader;
			while (krugle.auth.reAuthenticate._authQueue.length > 0) {
				loader = krugle.auth.reAuthenticate._authQueue.shift();
				loader.reSubmit();
			}
			
			// call user definable onSignin Success event handler
			krugle.auth.onSigninSuccess();
	
			// reset the onSignin Success/Cancel user definable methods
			krugle.auth.onSigninSuccess = function() {};
			krugle.auth.onSigninCancel = function() {};
		}
		
	};
	
	
	/* update the display of the sign in/out link appropriately */
	krugle.auth.updateSignInLink = function()
	{
		// update link only if document element is found
		if (document.getElementById('tl_signin')) {
			var linkHTML = "";
			if (krugle.auth.isAnonymous()) {
				linkHTML = "<a href='' onmouseover='return true;' onclick='krugle.auth.showSignin();return false;' style='border:0;'>" + krugle.auth.signInLinkPrefix + "Sign In</a>";
			} else {
				linkHTML = "<a href='' onmouseover='return true;' onclick='krugle.auth.doSignOut();return false;' style='border:0;'>" + krugle.auth.signInLinkPrefix + "Sign Out</a> <b>(" + krugle.auth.userName + ")</b>";
			}
			document.getElementById('tl_signin').innerHTML = linkHTML;
		}
	};
	
	/* generate a string of name/value auth constants for URL parameters */
	krugle.auth.urlAuthParams = function()
	{
		var authStr = "_kruglecn=" + encodeURIComponent(krugle.auth.clientName)
			+ "&_krugleca=" + encodeURIComponent(krugle.auth.clientAuth)
			+ "&_krugleun=" + encodeURIComponent(krugle.auth.userName)
			+ "&_krugleua=" + encodeURIComponent(krugle.auth.userAuth);
			
		if (krugle.auth.openAPI && krugle.auth.openAPI.isEnabled()) {
			authStr += "&_ocn=" + encodeURIComponent(krugle.auth.openAPI.clientName)
						+ "&_oca=" + encodeURIComponent(krugle.auth.openAPI.clientAuth)
						+ "&_oun=" + encodeURIComponent(krugle.auth.openAPI.userName)
						+ "&_oua=" + encodeURIComponent(krugle.auth.openAPI.userAuth);
		}
		return authStr;
	};

}
//]]>

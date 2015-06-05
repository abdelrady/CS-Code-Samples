//<![CDATA[
/*
 * Log.js - Event Logging Object - logs events to the /activities servlet
 * Chris Burmester, Krugle, Inc.
 *
 * Requires krugle namespace
*/
var moduleName = "krugle.log module (Log.js)";

/* make sure we have all required dependencies loaded for this module */
var loadErrors = "";

if (window.krugle === undefined) {
	// check for krugle namespacing object literal
	loadErrors += "- requires that the krugle namespace {} be defined\n";
	
} else {
	if (krugle.log !== undefined) {
		loadErrors += "- already loaded - skipping second load\n";
	}

}

if (loadErrors !== "") {
	alert(moduleName + ":\n" + loadErrors + "\n\nAborting load of module.");

} else {
	// required dependencies present - load object

	/* create a support namespacing object literal */
	krugle.log = {};

	// set the debug reporting on
	krugle.log.debug = true;
	
	// set the default referrer
	krugle.log.referrer = false;

	/* define known event types */
	krugle.log.kseError = "kseError";
	krugle.log.kseSearchSubmit = "kseSearchSubmit";
	krugle.log.kseNextResultsPage = "kseNextResultsPage";
	krugle.log.ksePrevResultsPage = "ksePrevResultsPage";
	krugle.log.kseChannelSelect = "kseChannelSelect";
	krugle.log.kseSearchSelectedSubmit = "kseSearchSelectedSubmit";
	krugle.log.kseDialogSubmit = "kseDialogSubmit";
	krugle.log.kseDialogCancel = "kseDialogCancel";
	krugle.log.kseDialogClose = "kseDialogClose";
	krugle.log.kseSigninLink = "kseSigninLink";
	krugle.log.kseSignoutLink = "kseSignoutLink";
	krugle.log.kseHit = "kseHit";
	krugle.log.kseAdLink = "kseAdLink";
	krugle.log.kseHitLicenseLink = "kseHitLicenseLink";
	krugle.log.kseHitRelated = "kseHitRelated";
	krugle.log.kseHitProjectLink = "kseHitProjectLink";
	krugle.log.kseHitSoloLink = "kseHitSoloLink";
	krugle.log.kseHitInSituLink = "kseHitInSituLink";
	krugle.log.kseHitShowClonesLink = "kseHitShowClonesLink";
	krugle.log.kseMyKrugleLink = "kseMyKrugleLink";
	krugle.log.kseInfobarTitleLink = "kseInfobarTitleLink";
	krugle.log.kseInfobarSoloLink = "kseInfobarSoloLink";
	krugle.log.kseInfobarProjectLink = "kseInfobarProjectLink";
	krugle.log.kseInfobarLicenseLink = "kseInfobarLicenseLink";
	krugle.log.kseInfobarShowClonesLink = "kseInfobarShowClonesLink";
	krugle.log.kseCodeLineNumbers = "kseCodeLineNumbers";
	krugle.log.kseCodeSaveFile = "kseCodeSaveFile";
	krugle.log.kseCodeAddNote = "kseCodeAddNote";
	krugle.log.kseCodeSearchSelected = "kseCodeSearchSelected";
	krugle.log.kseCodeShowInDirectory = "kseCodeShowInDirectory";
	krugle.log.kseShowNoteLink = "kseShowNoteLink";
	krugle.log.kseNoteNext = "kseNoteNext";
	krugle.log.kseNotePrev = "kseNotePrev";
	krugle.log.kseHitMoreLink = "kseHitMoreLink";
	krugle.log.kseRelatedMore = "kseRelatedMore";
	krugle.log.kseTabSelectResults = "kseTabSelectResults";
	krugle.log.kseTabSelectPage = "kseTabSelectPage";
	krugle.log.kseTabClose = "kseTabClose";
	krugle.log.kseTreeShow = "kseTreeShow";
	krugle.log.kseTreeHide = "kseTreeHide";
	krugle.log.kseTreeDirectoryOpen = "kseTreeDirectoryOpen";
	krugle.log.kseTreeDirectoryClose = "kseTreeDirectoryClose";
	krugle.log.kseTreeFileClick = "kseTreeFileClick";
	krugle.log.kseFeedbackLink = "kseFeedbackLink";
	krugle.log.kseFeedbackInContext = "kseFeedbackInContext";
	krugle.log.kseHiddenTabMenu = "kseHiddenTabMenu";
	krugle.log.kseHiddenTabSelect = "kseHiddenTabSelect";
	krugle.log.kseTestimonalSearchExample = "kseTestimonalSearchExample";
	krugle.log.kseTestimonalNextLink = "kseTestimonalNextLink";
	krugle.log.kseMenuOpen = "kseMenuOpen";
	krugle.log.kseMenuCancel = "kseMenuCancel";
	krugle.log.kseMenuItemSelect = "kseMenuItemSelect";
	krugle.log.kseCreateCodespaceLink = "kseCreateCodespaceLink";
	krugle.log.ksePlainLoad = "ksePlainLoad";
	krugle.log.kseFollowPageDeepLink = "kseFollowPageDeepLink";
	krugle.log.kseFollowSearchDeepLink = "kseFollowSearchDeepLink";
	krugle.log.kseFollowCodespaceLink = "kseFollowCodespaceLink";
	krugle.log.ksePostStateRestore = "ksePostStateRestore";
	krugle.log.kseForgotPasswordLink = "kseForgotPasswordLink";
	krugle.log.kspPlainLoad = "kspPlainLoad";
	krugle.log.kseProjectShowInDirectory = "kseProjectShowInDirectory";
	krugle.log.kdirPlainLoad = "kdirPlainLoad";
	krugle.log.kseLandingPageAction = "kseLandingPageAction";
	krugle.log.kseWebLink = "kseWebLink";
	krugle.log.kseSearchProjectMetricLink = "kseSearchProjectMetricLink";
	krugle.log.kseSearchProjectLicenseLink = "kseSearchProjectLicenseLink";
	krugle.log.kseAccessRestricted = "kseAccessRestricted";
	krugle.log.kseHomeLink = "kseHomeLink";
	krugle.log.kseShowAllProjectsLink = "kseShowAllProjectsLink";
	krugle.log.kseHomeGetInfoLink = "kseHomeGetInfoLink";
	krugle.log.kseHomeReloadReportLink = "kseHomeReloadReportLink";
	krugle.log.kseHomeReportProjectLink = "kseHomeReportProjectLink";
	krugle.log.kseHomeReportOpenLink = "kseHomeReportOpenLink";
	krugle.log.kseHomeReportCloseLink = "kseHomeReportCloseLink";
	krugle.log.kseHomeSCMCommentsLink = "kseHomeSCMCommentsLink";
	krugle.log.kseHomeSearchProjectLicenseLink = "kseHomeSearchProjectLicenseLink";
	krugle.log.kseHomeSearchProjectMetricLink = "kseHomeSearchProjectMetricLink";

		
	krugle.log.pageName = "/kse";
	krugle.log.eventID = 0;			// start the event sequence serial number
	
	/* define logging object */
	krugle.log.Log = function() {
	
		/* send an event to the server */
		this.send = function(data)
		{
			// construct pageName
			data.pageName = this.constructPageName(data);

			// if no eventID specified, use next value
			if (!data.eventID) {
				data.eventID = krugle.log.eventID++;
			}
			
			// add the referrer
			if (krugle.log.referrer === false) {
				// referrer is false on first event logged
				// use the actual document referrer
				krugle.log.referrer = document.referrer;
			}
			data.referrer = krugle.log.referrer;
			
			// set up the referrer for the next event to be this event's "URL"
			krugle.log.referrer = window.location.protocol + "//"
								+ window.location.hostname
								+ data.pageName;
								
			// add the "clientContext" or partnerId - set on load - will be null for non KSE events
			data.clientContext = krugle.partnerId;
			
			// pass the protocol used to load the page (http/https) to the activity logger
			// so that it can use it to construct the ominture URL appropriately - if applicable
			data.omnitureProtocol = window.location.protocol.substring(0,(window.location.protocol.length-1));
			
			// "data" is an object literal of event data to log
			var theURL = krugle.conf.middlewareServerURL + krugle.conf.middlewarePath
				+ "/api_log.pl?action=log&" + this.urlEncodeEventData(data);
			var loader = new krugle.net.HttpLoader(theURL, this.logCallback, [this,data]);
	
		};
		
		/* construct artificial "pageName" url for logging */
		this.constructPageName = function(data)
		{
			var pageName = data.pageName;
			if (!pageName) {
				pageName = krugle.log.pageName;
			}
			pageName += "/" + data.event + "/";
			if (data.searchType) {
				pageName += data.searchType + "/";
			}
			if (data.uiType) {
				pageName += data.uiType + "/";
			}
			return pageName;
		};
		
		/* serialize event data object literal into a name value pair string */
		this.urlEncodeEventData = function(data)
		{
			var str = "";
			for (var i in data) {
				if (str !== "") {
					str += "&";
				}
				str += encodeURIComponent(i) + "=" + encodeURIComponent(data[i]);
			}
			return str;
		};
		
		/* data loader callback function for calls to the log API */
		this.logCallback = function()
		{
			// "this" context is the ContentLoader object
			var logger = this.context[0];	// reference to log object that initiated call
			var data = this.context[1];		// event data passed to log API
	
			var parts = this.req.responseText.split('\n');
			var statuscode = parts[0];
			var omniture_url = parts[1];
			var ad_words = parts[2];
	
			if(statuscode == "0") {	//if not 0 no point in going on, something happened
	
				// dispatch ad keywords in an event appropriate manner
				logger.dispatchAds(data,ad_words);
	
				// if we got an Omniture URL
				// and if configured to log to Omniture, load Omniture URL
				// (undefined value treated as true, i.e. default to true)
				if (omniture_url && krugle.conf.init.logToOmniture !== false) {
					// load omniture URL into image URL
					var omnitureImg = new Image();
					omnitureImg.src = omniture_url;
				}
			}
		};
	
		/* make calls, when appropriate, to dispatch ads for display in the interface */
		this.dispatchAds = function(data,ad_words)
		{
			if (krugle.kse) {
				// for KSE - dispatch ads for search events
				if (data.event == krugle.log.kseSearchSubmit
					|| data.event == krugle.log.kseNextResultsPage
					|| data.event == krugle.log.ksePrevResultsPage
					|| data.event == krugle.log.kseChannelSelect
					|| data.event == krugle.log.kseSearchSelectedSubmit
					|| data.event == krugle.log.kseRelatedMore
					|| data.event == krugle.log.kseFollowSearchDeepLink
					|| data.event == krugle.log.kseFollowCodeSpaceLink
					|| data.event == krugle.log.ksePostStateRestore
					|| data.event == krugle.log.kseTestimonalSearchExample) {
						krugleSearch.requestAds(ad_words);
				}
			}
		};
		
		/* dedicated function for logging errors */
		this.logError = function(method,error)
		{
			// method is the fully namespaced method name that threw the error
			// error is the error object thrown
			var eventData = {event: krugle.log.kseError};
			eventData.errorSource = "kse";
			eventData.errorType = error.name;
			eventData.errorMessage = error.message;
			eventData.url = method;
			eventData.userAgent = navigator.userAgent;
			this.send(eventData);
		};
	
	};
	
	// instantiate one version of this object
	krugle.eventLogger = new krugle.log.Log();
	
	/* define function for global window error handling */
	krugle.log.errorHandler = function(message,url,line)
	{
		if (krugle.log.debug) {
			// report the error
			alert("Javascript Error:\n" + message + "\n" + url + "\nline: " + line);
		}
		
		// log error to server
		var errorObj = {};
		errorObj.message = message;
		errorObj.name = "GenericError";
		krugle.eventLogger.logError(url + ":" + line, errorObj);
		
		// we have not handled this error - propogate normally
		return false;
		
	};

}
//]]>

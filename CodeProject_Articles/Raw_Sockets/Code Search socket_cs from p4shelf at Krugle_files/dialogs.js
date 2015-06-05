//<![CDATA[
/*
 * dialogs.js - provides dialog windowing (modal and info) ability
 * Chris Burmester, Krugle, Inc.
 *
 * Requires krugle namespace, drag.js, and utilities.js functionality.
 * Requires the inclusion XHTML templates in /include/dialogs.html
*/

/* make sure we have a krugle namespacing object literal */
if (window.krugle === undefined) {
	alert("dialogs.js requires that the krugle namespace {} be defined. Aborting load of krugle dialog module.");

} else {

	// check dependencies for this module - drag.js functionality
	if (krugle.drag === undefined) {
		alert("dialogs.js requires that drag.js module be included. Drag functionality will not work");
	}

	/* create a dialogs namespacing object literal */
	krugle.dialogs = {};

	/* create flag indicating whether we have a submit or cancel methods to run */
	krugle.dialogs.submitMethod = false;
	krugle.dialogs.cancelMethod = false;

	/* modal dialog window content setup and display */
	krugle.dialogs.showModalWindow = function(
		titleText,			// title to display in dialog window title
		titleImgURL,		// image url of image icon to display in dialog window title or false
		onSubmitMethod,		// reference to method to call on submit of dialog or false
		cancelTitle,		// Title of cancel button
		submitTitle,		// title of submit button
		formContents,		// the contents to display in the body of the dialog
		focusFieldName,		// form field to place focus on after displaying dialog or false if none
		onCancelMethod,		// reference to method to call on cancel button click or false
		hideCancelBtn)		// whether to hide the cancel button
	{

		var mw = document.getElementById('_mw');
		if (krugle.util.isIE()) {
			// is IE 6 or less, show mask for select elements
			document.getElementById('_mw_ie6mask').style.display = 'block';
		} else {
			document.getElementById('_mw_ie6mask').style.display = 'none';
		}

		// close the dialog if it is open
		if (mw.style.visibility == 'visible') {
			mw.style.visibility = 'hidden';
			mw.style.overflow = 'hidden';
		}
		// add the window to the display hierarchy if it's not
		if (mw.style.display == 'none') {
			mw.style.display = 'block';
		}

		if (!cancelTitle) { cancelTitle = "Cancel"; }
		if (!submitTitle) { submitTitle = "Submit"; }

		// define cancel/submit buttons
		var submitBtnHTML = "<input name='_mw_submit' type='submit' class='control' value='" + submitTitle + "' />";
		var cancelBtnHTML = "<input name='_mw_cancel' type='button' class='control' value='" + cancelTitle + "' onclick='krugle.dialogs.cancelModalWindow();' />";

		// render Cancel/Submit buttons in traditional OS specific order
		if (navigator.appVersion.indexOf("Win")!=-1) {
			// windows style - submit to left of cancel
			document.getElementById('_mw_form_buttons').innerHTML = submitBtnHTML + (hideCancelBtn ? "" : "&nbsp;" + cancelBtnHTML);
		} else {
			// Mac/Unix style - submit to right of cancel
			document.getElementById('_mw_form_buttons').innerHTML = (hideCancelBtn ? "" : cancelBtnHTML + "&nbsp;") + submitBtnHTML;
		}

		// set the title bar content
		var titleHTML = "";
		if (titleImgURL) {
			titleHTML = "<img align='center' src='" + titleImgURL + "' border='0' />&nbsp;";
		}
		titleHTML += titleText;
		document.getElementById('_mw_title').innerHTML = titleHTML;

		// set the submit and cancel methods
		krugle.dialogs.submitMethod = onSubmitMethod;
		krugle.dialogs.cancelMethod = onCancelMethod;

		// workaround to fix insertion point not showing in Firefox bug
		document.getElementById('_mw_form_contents').innerHTML = formContents;

		//set overflow
		mw.style.overflow = "auto";

		// position the modal window centered on the page
		var wh = getWindowHeight();
		var ww = getWindowWidth();
		var mwTop = Math.round((wh - mw.offsetHeight)/2);
		var mwLeft = Math.round((ww - mw.offsetWidth)/2);
		mw.style.top = mwTop + 'px';
		mw.style.left = mwLeft + 'px';

		// show the click filter
		krugle.util.showClickfilter('_mw_clickfilter');

		// show the modal window
		mw.style.display = 'block';
		mw.style.visibility = 'visible';

		if (focusFieldName) {
			document._mw_form[focusFieldName].focus();
		}
	};

	/* hide the modal window */
	krugle.dialogs.hideModalWindow = function()
	{
		try {
			// hide the modal window
			var mw = document.getElementById('_mw');
			mw.style.overflow = "hidden";
			mw.style.display = 'none';
	
			// hide the click filter
			krugle.util.hideClickfilter('_mw_clickfilter');
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.dialogs.hideModalWindow",e);
		}
	};

	/* called by onsubmit() event handler of modal window template form */
	krugle.dialogs.submitModalWindow = function()
	{
		var retVal = true;
		try {
			if (krugle.dialogs.submitMethod) {
				retVal = krugle.dialogs.submitMethod.apply(null,[]);
			}
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.dialogs.submitModalWindow",e);
		}
		return retVal;
	};

	/* called by onClick() event handler of modal window form cancel button */
	krugle.dialogs.cancelModalWindow = function()
	{
		try {
			krugle.dialogs.hideModalWindow();
			// run the cancelMethod, if any
			if (krugle.dialogs.cancelMethod) {
				krugle.dialogs.cancelMethod.apply(null,[]);
			}
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.dialogs.cancelModalWindow",e);
		}
	};

	// method to call on close of info window - if user specified
	krugle.dialogs.closeMethod = false;

	/* show an information window - not modal - i.e. no click filter */
	krugle.dialogs.showInfoWindow = function(
		titleText,			// title to display in dialog window title
		titleImgURL,		// image url of image icon to display in dialog window title or false
		closeBtnName,		// title of close button
		windowContents,		// contents to display in info windows
		closeMethod)		// method, if any, to call on close
	{

		if (krugle.util.isIE() && document.getElementById('_iw_ie6mask')) {
			// is IE 6 or less, show mask for select elements
			document.getElementById('_iw_ie6mask').style.display = 'block';
		} else {
			document.getElementById('_iw_ie6mask').style.display = 'none';
		}

		krugle.dialogs.closeMethod = closeMethod;

		document.getElementById('_iw_contents').innerHTML = "";

		var iw = document.getElementById('_iw');

		// close the window if it is open
		if (iw.style.visibility == 'visible') {
			iw.style.visibility = 'hidden';
			iw.style.overflow = 'hidden';
		}
		// add the window to the display hierarchy if it's not
		if (iw.style.display == 'none') {
			iw.style.display = 'block';
		}
		// instantiate the window template
		var titleHTML = "";
		if (titleImgURL) {
			titleHTML = "<img align='center' src='" + titleImgURL + "' border='0' />&nbsp;";
		}
		titleHTML += titleText;
		document.getElementById('_iw_title').innerHTML = titleHTML;
		document.getElementById('_iw_closebutton').value = closeBtnName;
		document.getElementById('_iw_contents').innerHTML = windowContents;

		//set overflow
		iw.style.overflow = "auto";

		// position the modal window centered on the page
		var wh = getWindowHeight();
		var ww = getWindowWidth();
		var mwTop = Math.round((wh - iw.offsetHeight)/2);
		var mwLeft = Math.round((ww - iw.offsetWidth)/2);
		iw.style.top = mwTop + 'px';
		iw.style.left = mwLeft + 'px';

		// show the click filter
		krugle.util.showClickfilter('_mw_clickfilter');
		
		// show the window
		iw.style.display = 'block';
		iw.style.visibility = 'visible';
	};

	/* hide the modal window */
	krugle.dialogs.hideInfoWindow = function()
	{
		try {
			// call user close method, if defined
			if (krugle.dialogs.closeMethod) {
				krugle.dialogs.closeMethod();
				krugle.dialogs.closeMethod = false;
			}
	
			krugle.util.hideClickfilter('_mw_clickfilter');
	
			// hide the info window
			var iw = document.getElementById('_iw');
			iw.style.overlfow = "hidden";
			iw.style.display = 'none';
		}
		catch (e) {
			krugle.eventLogger.logError("krugle.dialogs.hideInfoWindow",e);
		}
	};


}
//]]>

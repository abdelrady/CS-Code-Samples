// //
// Copyright 2008 comScore Networks. All rights reserved.

// Frequency of the popup.
SiteRecruit_Config.frequency = 0.0003;

// Skips the cookie test. Use for debugging.
SiteRecruit_Config.useCookie = true;

// Invitation constructor - sets necessary defaults.
function SiteRecruit_InvitationConfiguration()
{
    this.otherCookies = new Array();
    this.otherVariables = new Array();    
}

// The array of survey configurations.
SiteRecruit_Config.invitations = new Array();

// Iterate through the survey configurations.

    
            
        SiteRecruit_Config.invitations[0] = new SiteRecruit_InvitationConfiguration();
        SiteRecruit_Config.invitations[0].weight = 100;
        SiteRecruit_Config.invitations[0].projectId = '3332mt';
        SiteRecruit_Config.invitations[0].invitationType = 2;
        SiteRecruit_Config.invitations[0].acceptUrl = 'http://survey2.surveysite.com/wix/p15466742.aspx';
        SiteRecruit_Config.invitations[0].viewUrl = 'http://web.survey-poll.com/tc/CreateLog.aspx';
        SiteRecruit_Config.invitations[0].acceptParams = 'l=9&mth=1&site=90';
        SiteRecruit_Config.invitations[0].viewParams = 'log=comscore/view/p15466742-view.log&site=90';
        SiteRecruit_Config.invitations[0].invitationContent = '<table width="360" cellpadding="3" cellspacing="0" border="0" bgcolor="#FFFFFF"><tr><td> <table width="100%" cellpadding="1" cellspacing="0" border="0" bgcolor="#999999"><tr><td> <table width="100%" cellpadding="0" cellspacing="0" border="0" bgcolor="#FFFFFF"><tr valign="top"><td> <img src="/library/svy/logo-stripe.gif" /><a href="Close" onclick="@declineHandler"><img border="0" src="/library/svy/close.gif" /></a><br /> <img src="/library/svy/top-stripe.gif" /> <table width="100%" cellpadding="5"><tr><td>  <div style="font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: 11px; color: #000000; margin: 0 0 15px 0;">Microsoft is conducting an online survey to understand use of the Microsoft.com Web site.  We’d like to see which pages you visit today and then have you complete a survey when you leave the Microsoft.com Web site.  Would you like to participate?</div>  <div align="center" style="margin: 0; padding: 0"> <input style="font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: 11px; margin: 0; padding: 0" type="button" value="  Yes  " onclick="@acceptHandler" />&nbsp;&nbsp; <input style="font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: 11px; margin: 0; padding: 0"  type="button" value=" No " onclick="@declineHandler" /> </div>  <div style="font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: 11px; color: #000000; margin: 15px 0 2px 0;"><a href="http://www.microsoft.com/info/privacy.mspx" target="_blank">Privacy Statement</a></div>  </td></tr></table> <img src="/library/svy/bottom-stripe.gif" /></td></tr></table> </td></tr></table> </td></tr></table>   '; 
        SiteRecruit_Config.invitations[0].invitationHeight = 210;
        SiteRecruit_Config.invitations[0].invitationWidth = 390;
        SiteRecruit_Config.invitations[0].revealDelay = 1000;
        SiteRecruit_Config.invitations[0].horizontalAlignment = 1;
        SiteRecruit_Config.invitations[0].verticalAlignment = 0;
        SiteRecruit_Config.invitations[0].horizontalMargin = 0;
        SiteRecruit_Config.invitations[0].verticalMargin = 0;
        SiteRecruit_Config.invitations[0].hideBlockingElements = true;
        SiteRecruit_Config.invitations[0].autoCentering = true;
    
            
            
                    SiteRecruit_Config.invitations[0].trackerUrl = '/library/svy/SiteRecruit_Tracker_3332mt-us.htm';
            
            //(features, width, height, orientation, offsetX, offsetY)
            SiteRecruit_Config.invitations[0].trackerWindowConfig = { "width":400,
																		"height":270,
																		"orientation":'Center',
																		"offsetX":0,
																		"offsetY":0,
																		"autoFocus":true,
																		"hideToolbars":true };
                
        SiteRecruit_Config.invitations[0].useRapidCookie = false;
        
                
       
        
    
// //
// Copyright 2008 comScore Networks. All rights reserved.

// Class to read and write cookies.
function SiteRecruit_CookieUtilities()
{
    // Cookie removal date.
    this.cookieRemovalDate = 'Fri, 02-Jan-1970 00:00:00 GMT';

    // Attach methods.
    this.setSurveyCookie = CookieUtilities_setSurveyCookie;
    this.setSurveyCookieX = CookieUtilities_setSurveyCookieX;
    this.setEmailDomainDepartureCookie = CookieUtilities_setEmailDomainDepartureCookie;
    this.getSurveyCookie = CookieUtilities_getSurveyCookie;
    this.getCookieValue = CookieUtilities_getCookieValue;
    this.removeSurveyCookie = CookieUtilities_removeSurveyCookie;
    this.surveyCookieExists = CookieUtilities_surveyCookieExists;

    // Set the cookie to the standard cookie string.
    function CookieUtilities_setSurveyCookie(cookieType)
    {
        this.setSurveyCookieX(cookieType, false);
    }

    // New cookie method to optionally support rapid cookies.
    function CookieUtilities_setSurveyCookieX(cookieType, useRapidCookie)
    {
        var currentDate = new Date();  
        var expireDate = new Date();
        
        var duration = SiteRecruit_Config.cookieDuration;
        if (useRapidCookie)
        {
            duration = SiteRecruit_Config.rapidCookieDuration;
        }
        
        if (SiteRecruit_Config.cookieLifetimeType == SiteRecruit_Constants.cookieLifetimeType.duration)
        {
            expireDate.setTime(currentDate.getTime() + duration);
        }
        else
        {
            expireDate.setTime(Date.parse(SiteRecruit_Config.cookieExpireDate));
        }        
        
        var c = '=' + cookieType;
        if (cookieType == SiteRecruit_Constants.cookieType.inProgress)
        {
            var j = SiteRecruit_Constants.cookieJoinChar;
            c += ':' + escape(document.location) + ':' + currentDate.getTime() + ':0';
        }        
        c += '; path=' + SiteRecruit_Config.cookiePath;

        if (cookieType == SiteRecruit_Constants.cookieType.alreadyAsked) c += '; expires=' + expireDate.toGMTString();
        if (SiteRecruit_Config.cookieDomain != '') c += '; domain=' + SiteRecruit_Config.cookieDomain;

        document.cookie = SiteRecruit_Config.cookieName + c;
        
        return true;
    }
    
    // Sets a email domain dep cookie with a generated user ID.
    function CookieUtilities_setEmailDomainDepartureCookie(userId, trackingDuration)
    {
        var expireDate = new Date();
        expireDate.setTime(expireDate.getTime() + trackingDuration);
           
        var c = '=' + SiteRecruit_Constants.cookieType.emailDomainDeparture
            + ':' + userId
            + '; path=' + SiteRecruit_Config.cookiePath
            + '; expires=' + expireDate.toGMTString();
            
        if (SiteRecruit_Config.cookieDomain != '') c += '; domain=' + SiteRecruit_Config.cookieDomain;
        document.cookie = SiteRecruit_Config.cookieName + c;
    }
        
    // Grabs the value of the survey cookie.
    function CookieUtilities_getSurveyCookie()
    {
        return this.getCookieValue(SiteRecruit_Config.cookieName);
    }
    
    // Grabs the value of a cookie.
    function CookieUtilities_getCookieValue(cookieName)
    {
        var c = document.cookie.toString();
        var index = c.indexOf(cookieName);
        if (index == -1) return null;
        var endc = c.length;
        c = c.substring(index, endc);
        var ind1 = c.indexOf(';');
        if (ind1 != -1) c = c.substring(0, ind1);
        var ind2 = c.indexOf('=');
        c = c.substring(ind2 + 1);        
        return c;
    }

    // Removes the cookie by setting to an expired date.
    function CookieUtilities_removeSurveyCookie()
    {
        var c = SiteRecruit_Config.cookieName + '='
            + '; path=' + SiteRecruit_Config.cookiePath
            + '; expires=' + this.cookieRemovalDate;

        if (SiteRecruit_Config.cookieDomain != '')
        {
            c += '; domain=' + SiteRecruit_Config.cookieDomain;
        }

        document.cookie = c;
    }

    // Returns true if a survey cookie exists. Call optionally with a type.
    function CookieUtilities_surveyCookieExists(cookieType)
    {
        var t = '';
        if (cookieType) t = cookieType;
        
        return (document.cookie.indexOf(SiteRecruit_Config.cookieName + '=' + t) != -1)
    }
}

// Create an instance of the utils.
SiteRecruit_Globals.cookieUtils = new SiteRecruit_CookieUtilities();
// //
// Copyright 2008 comScore Networks. All rights reserved.
										
SiteRecruit_TrackerWindow.Orientation = { "Default":"Default",
										"Center":"Center",
										"BottomCenter":"BottomCenter",
										"BottomLeft":"BottomLeft",
										"BottomRight":"BottomRight" };										

function SiteRecruit_TrackerWindow(width, height, orientation, offsetX, offsetY, autoFocus, hideToolbars)
{
	this.features = "";
	this.width = width;
	this.height = height;
	this.orientation = orientation;
	this.offsetX = offsetX;
	this.offsetY = offsetY;	
	this.autoFocus = autoFocus;
	this.hideToolbars = hideToolbars;
	
	// wireup methods
	this.open = TrackerWindow_Open;
	this.getFeatures = TrackerWindow_GetFeatures;

	function TrackerWindow_GetFeatures()
	{
		// standard window features
		var f = "";
		
		if (this.hideToolbars)		
			f = "location=0,menubar=0,resizable=1,scrollbars=1,toolbar=0,";
		else
			f = "location=1,menubar=1,resizable=1,scrollbars=1,toolbar=1,";
		
		if (this.width && this.height && this.orientation)
		{			
			if (this.width > 0 || this.height > 0)
				f += "width=" + this.width + ",height=" + this.height + ",";
			
			var screenWidth = SiteRecruit_Globals.Utils.GetScreenWidth();
			var screenHeight = SiteRecruit_Globals.Utils.GetScreenHeight();
		
			var offsetX = (this.offsetX ? this.offsetX : 0);
			var offsetY = (this.offsetY ? this.offsetY : 0);
				
			// move window
			var moveToX;
			var moveToY;
				
			if (this.orientation == SiteRecruit_TrackerWindow.Orientation.Center)
			{
				moveToX = (screenWidth/2) - (this.width/2);
				moveToY = (screenHeight/2) - (this.height/2);
			}	
			else if (this.orientation == SiteRecruit_TrackerWindow.Orientation.BottomCenter)
			{
				moveToX = (screenWidth/2) - (this.width/2);
				moveToY = screenHeight - this.height;
			}	
			else if (this.orientation == SiteRecruit_TrackerWindow.Orientation.BottomLeft)
			{
				moveToX = 0;
				moveToY = screenHeight - this.height;
			}	
			else if (this.orientation == SiteRecruit_TrackerWindow.Orientation.BottomRight)
			{
				moveToX = screenWidth - this.width;
				moveToY = screenHeight - this.height;
			}
			
			if (moveToX != null && moveToY != null)
			{
				moveToX += offsetX;
				moveToY += offsetY;
				
				f += "left=" + moveToX + ",top=" + moveToY;
			}
		}			
		
		this.features = f;
		
		return this.features;
	}
	
	function TrackerWindow_Open(url)
	{
		window.open(url, '', this.getFeatures());
		
			}	
	

}// //
// Copyright 2008 comScore Networks. All rights reserved.

// Misc utilities and helpers
function SiteRecruit_Utilities()
{
	// wire up methods
	this.GetScreenWidth = Utilities_GetScreenWidth;
	this.GetScreenHeight = Utilities_GetScreenHeight;
	
	this.GetWindowWidth = Utilities_GetWindowWidth;
	this.GetWindowHeight = Utilities_GetWindowHeight;
	this.GetWindowLeft = Utilities_GetWindowLeft;
	this.GetWindowTop = Utilities_GetWindowTop;

	// ************************************************************
	// Window utilities
	// ************************************************************
	
	function Utilities_GetScreenWidth()
	{
		return self.screen.availWidth;
	}
	
	function Utilities_GetScreenHeight()
	{
		return self.screen.availHeight;
	}
	
	function Utilities_GetWindowLeft(win)
	{
		return (win.screenX == null ? win.screenLeft : win.screenX);	
	}
	
	function Utilities_GetWindowTop(win)
	{
		return (win.screenY == null ? win.screenTop : win.screenY);	
	}
	
	function Utilities_GetWindowWidth(win)
	{
		return (win.outerWidth == null ? win.document.body.scrollWidth + 12 : win.outerWidth);		
	}
	
	function Utilities_GetWindowHeight(win)
	{
		var height = 0;
		
		// handle tricky IE window height
		if (SiteRecruit_Globals.isInternetExplorer)
		{
			if (win.document.documentElement && win.document.documentElement.clientHeight) 
				height = win.document.documentElement.clientHeight;
			else 
				height = win.document.body.clientHeight;
				
			if (height < win.document.body.scrollHeight) 
				height = win.document.body.scrollHeight;
				
			if (height < win.document.body.offsetHeight) 
				height = win.document.body.offsetHeight; 
		}
		else
			height = win.outerHeight;
			
		return height;
	}
}

// Create an instance of the utils.
SiteRecruit_Globals.Utils = new SiteRecruit_Utilities();
// //
// Copyright 2008 comScore Networks. All rights reserved.

// Class to test for frequencies and eligibility and start surveys.
function SiteRecruit_Primer()
{
    // Attach methods.
    this.isEligible = Primer_isEligible;
    this.srandom = Primer_srandom;

    // Custom random number generator.
    function Primer_srandom()
    {
        var n = 1000000000;
        
        function ugen(old, a, q, r, m)
        {
            var t = Math.floor(old / q);
            t = a * (old - (t * q)) - (t * r);
            return Math.round((t < 0) ? (t + m) : t);
        }
        
        var m1 = 2147483563;
        var m2 = 2147483399;
        var a1 = 40014;
        var a2 = 40692;
        var q1 = 53668;
        var q2 = 52774;
        var r1 = 12211;
        var r2 = 3791;
        var x = 67108862;
        var shuffle = new Array(32);
        var g1 = (Math.round(((new Date()).getTime() % 100000)) & 0x7FFFFFFF);
        var g2 = g1;
        var i = 0;
        
        for (; i < 19; i++)
        {
            g1 = ugen(g1, a1, q1, r1, m1);
        }
        for (i = 0; i < 32; i++)
        {
            g1 = ugen(g1, a1, q1, r1, m1);
            shuffle[31 - i] = g1;
        }
        g1 = ugen(g1, a1, q1, r1, m1);
        g2 = ugen(g2, a2, q2, r2, m2);
        var s = Math.round((shuffle[Math.floor(shuffle[0] / x)] + g2) % m1);
    
        return Math.floor(s / (m1 / (n + 1))) / n;
    }

    // Decide whether to hit the user with the invitation.
    function Primer_isEligible()
    {
        if (!SiteRecruit_Config.useCookie || !SiteRecruit_Globals.cookieUtils.surveyCookieExists())
        {
            // Roll the dice, and inject the survey scripts if the user is chosen.
            if (SiteRecruit_Config.frequency > this.srandom())
            {
                return true;
            }
                    }
                
        return false;
    }
}

// Run the builder only if it qualifies below.
SiteRecruit_Globals.startBuilder = false;

// Only kick things off if it's a known browser.
if (SiteRecruit_Globals.isInternetExplorer || SiteRecruit_Globals.isMozilla)
{
    // Create a primer and try to run a survey.
    SiteRecruit_Globals.primer = new SiteRecruit_Primer();
    if (SiteRecruit_Globals.primer.isEligible())
    {  
        SiteRecruit_Globals.startBuilder = true;
        
                    var uniqueUrl = '/library/svy/SiteRecruit_InvitationBuilder.js?' + (new Date()).getTime();

            document.write('<script language="JavaScript" src="' + uniqueUrl + '"></script>');
            }    
}
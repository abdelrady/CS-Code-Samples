// //
// Copyright 2007 comScore Networks. All rights reserved.

// Name: Microsoft-www
// Date: 2007-12-07


// Multiple script protection.
if (!window.SiteRecruit_Globals) {

// Create the configuration, globals, and constants namespaces.
var SiteRecruit_Config = new Object();
var SiteRecruit_Globals = new Object();
var SiteRecruit_Constants = new Object();

// Validation variables.
SiteRecruit_Globals.parseFlag = false;
SiteRecruit_Globals.empty = false;

// Browser information.
SiteRecruit_Constants.browser = new Object();
SiteRecruit_Constants.browser.internetExplorer = 'Microsoft Internet Explorer';
SiteRecruit_Constants.browser.mozilla = 'Netscape';
SiteRecruit_Constants.browser.opera = 'Opera';

// Check browser information.
SiteRecruit_Globals.browserName = navigator.appName; 
SiteRecruit_Globals.browserVersion = parseInt(navigator.appVersion);

// Initialize browser flags.
SiteRecruit_Globals.isInternetExplorer = false;
SiteRecruit_Globals.isMozilla = false;
SiteRecruit_Globals.isInternetExplorer7 = false;

// Check for Internet Explorer based browsers.
if (SiteRecruit_Globals.browserName == SiteRecruit_Constants.browser.internetExplorer)
{
    if (SiteRecruit_Globals.browserVersion > 3)
    {
        // Only 5.5 and above.
        var a = navigator.userAgent.toLowerCase();
        if (a.indexOf("msie 5.0") == -1 && a.indexOf("msie 5.0") == -1)
        {
            SiteRecruit_Globals.isInternetExplorer = true;
        }
        
        // Check for 7.
        if (a.indexOf("msie 7") != -1)
        {
            SiteRecruit_Globals.isInternetExplorer7 = true;
        }
    }
}

// Check for Mozilla based browsers.
if (SiteRecruit_Globals.browserName == SiteRecruit_Constants.browser.mozilla)
{
    if (SiteRecruit_Globals.browserVersion > 4)
    {
        SiteRecruit_Globals.isMozilla = true;
    }
}

// Since Opera 9.02, they no longer use 'Mozilla' in the browser name
if (SiteRecruit_Globals.browserName == SiteRecruit_Constants.browser.opera)
{
	SiteRecruit_Globals.isMozilla = true;	// treat the same as Mozilla
}



// Cookie lifetime.
SiteRecruit_Constants.cookieLifetimeType = new Object();
SiteRecruit_Constants.cookieLifetimeType.duration = 1;
SiteRecruit_Constants.cookieLifetimeType.expireDate = 2;
    
// Invitation type.
SiteRecruit_Constants.invitationType = new Object();
SiteRecruit_Constants.invitationType.standard = 0;
SiteRecruit_Constants.invitationType.email = 1;
SiteRecruit_Constants.invitationType.domainDeparture = 2;
SiteRecruit_Constants.invitationType.emailDomainDeparture = 3;
    
// Cookie type flags.
SiteRecruit_Constants.cookieType = new Object();
SiteRecruit_Constants.cookieType.alreadyAsked = 1;
SiteRecruit_Constants.cookieType.inProgress = 2;
SiteRecruit_Constants.cookieType.emailDomainDeparture = 3;

// Alignment types.
SiteRecruit_Constants.horizontalAlignment = new Object();
SiteRecruit_Constants.horizontalAlignment.left = 0;
SiteRecruit_Constants.horizontalAlignment.middle = 1;
SiteRecruit_Constants.horizontalAlignment.right = 2;
SiteRecruit_Constants.verticalAlignment = new Object();
SiteRecruit_Constants.verticalAlignment.top = 0;
SiteRecruit_Constants.verticalAlignment.middle = 1;
SiteRecruit_Constants.verticalAlignment.bottom = 2;

// Survey cookie configuration.
SiteRecruit_Config.cookieName = 'msresearch';
SiteRecruit_Config.cookieDomain = '.microsoft.com';
SiteRecruit_Config.cookiePath = '/';

SiteRecruit_Constants.cookieJoinChar = ':';

// Settings for cookie lifetime.
SiteRecruit_Config.cookieLifetimeType = 1;

    // Duration of the cookie in days.
    SiteRecruit_Config.cookieDuration = 90 * 86400000;

// Duration of the rapid cookie.
SiteRecruit_Config.rapidCookieDuration = 0 * 86400000;

// URL of the email domain dep server.
SiteRecruit_Config.listenerUrl = '';// //
// Copyright 2007 comScore Networks. All rights reserved.

// KeepAlive class definition.
function SiteRecruit_KeepAlive()
{
    // Time between page checks.
    this.keepAlivePollDelay = 1000;

    // Unique (well, sorta) ID for this page.
    this.id = Math.random();

    // Attach methods.
    this.attemptStart = KeepAlive_attemptStart;
    this.checkCookie = KeepAlive_checkCookie;
    this.inProgressCookieExists = KeepAlive_inProgressCookieExists;
    this.cookieExists = KeepAlive_cookieExists;

    // Check for either domain dep or email domain dep cookies and act accordingly.
    function KeepAlive_attemptStart()
    {
        if (this.inProgressCookieExists())
        {
            setInterval('SiteRecruit_Globals.keepAlive.checkCookie()', this.keepAlivePollDelay);
        }
        else
        {
            if (this.cookieExists(SiteRecruit_Constants.cookieType.emailDomainDeparture))
            {
                var c = document.cookie.toString();
                var index = c.indexOf(SiteRecruit_Config.cookieName + '=' + SiteRecruit_Constants.cookieType.emailDomainDeparture);
                var endc = c.length;
                c = c.substring(index, endc);
                var ind1 = c.indexOf(';');
                if (ind1 != -1) c = c.substring(0, ind1);        
                var ind2 = c.indexOf('=');
                c = c.substring(ind2 + 1);
                var values = c.split(':');
                if (values.length == 2)
                {
                    var url = SiteRecruit_Config.listenerUrl;
                    
                    // append ? to qs if needed
					url += (url.indexOf('?') == -1 ? '?' : '&');
					
                    url += 'action=log'
                        + '&user=' + values[1]
                        + '&location=' + escape(window.location);
                    
                    setTimeout("var i = new Image(); i.src = '" + url + "&' + (new Date()).getTime(); ", 5);
                }
            }
        }
    }
    
    // Check and update the cookie.
    function KeepAlive_checkCookie()
    {
        if (this.inProgressCookieExists())
        {
            var c = SiteRecruit_Config.cookieName + '=' + SiteRecruit_Constants.cookieType.inProgress
                + ':' + escape(document.location)
                + ':' + (new Date()).getTime()
                + ':' + this.id
                + '; path=' + SiteRecruit_Config.cookiePath;
            
            if (SiteRecruit_Config.cookieDomain != '')
            {
                c += '; domain=' + SiteRecruit_Config.cookieDomain;
            }
            
            document.cookie = c;
        }
    }

    // Return true if an in-progress cookie exists.
    function KeepAlive_inProgressCookieExists()
    {
        return this.cookieExists(SiteRecruit_Constants.cookieType.inProgress);
    }
    
    // Return true if a cookie of the given type exists.
    function KeepAlive_cookieExists(cookieType)
    {
        var c = SiteRecruit_Config.cookieName + '=' + cookieType;
        if (document.cookie.indexOf(c) != -1)
        {
            return true;
        }
        return false;
    }
}

// Create the KeepAlive if a suitable cookie exists.
SiteRecruit_Globals.keepAlive = new SiteRecruit_KeepAlive();
SiteRecruit_Globals.keepAlive.attemptStart();
// //
// Copyright 2007 comScore Networks. All rights reserved.

// Broker class definition.
function SiteRecruit_PageConfigurationBroker()
{
    // List of mappings, each contains [url, page, priority, prereqs]    
    this.m = [        
    ['//[\\w\\.-]+/about((/)|(/((default)|(index))\\.((html?)|(aspx?)|(mspx))))?$', '/library/svy/SiteRecruit_PageConfiguration_3331mt2.js', 0, null],
    ['//[\\w\\.-]+/athome/', '/library/svy/SiteRecruit_PageConfiguration_3331mt3.js', 0, null],
    ['//[\\w\\.-]+/athome/security/', '/library/svy/SiteRecruit_PageConfiguration_3331mt3-3331mt4.js', 1, null],
    ['//[\\w\\.-]+/atwork', '/library/svy/SiteRecruit_PageConfiguration_3331mt5.js', 0, null],
    ['//[\\w\\.-]+/australia/smallbusiness(/(?!sbrp)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Australia.js', 0, null],
    ['//[\\w\\.-]+/austria/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Austria.js', 0, null],
    ['//[\\w\\.-]+/belux.*/fr/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Belguim-fr.js', 0, null],
    ['//[\\w\\.-]+/belux.*/nl/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Belguim-nl.js', 0, null],
    ['//[\\w\\.-]+/brasil/pequenasempresas', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Brazil.js', 0, null],
    ['//[\\w\\.-]+/business(/(?!executivecircle|appplat|bizinfra|coreinfra|process|performance|info|mobility|customerconnections|compliance|(.*tlp))|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt8.js', 0, null],
    ['//[\\w\\.-]+/business/peopleready(/(?!executivecircle|appplat|bizinfra|coreinfra|process|performance|info|mobility|customerconnections|compliance|(.*tlp))|$)', '/library/svy/SiteRecruit_PageConfiguration_p15394611.js', 1, null],
    ['//[\\w\\.-]+/canada/smallbiz(/(?!sbplus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_EnglishCanada.js', 0, null],
    ['//[\\w\\.-]+/china/smallbusiness', '/library/svy/SiteRecruit_PageConfiguration_2933mt_China.js', 0, null],
    ['//[\\w\\.-]+/danmark/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Danmark.js', 0, null],
    ['//[\\w\\.-]+/downloads/.*displaylang=en', '/library/svy/SiteRecruit_PageConfiguration_3331mt13-3332mt-3519mt.js', 0, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=0818d425-cd47-4279-be8d-24aba14530a3&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_Windows.js', 1, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=2d1189bf-d86a-4acf-9dcc-4d61f500ad6d&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_Office.js', 1, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyId=3BF4C5CA-B905-4EBC-8901-1D4C1D1DA884&displaylang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_SQL.js', 0, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=444c259e-605f-4a82-96d5-a2f448c9d4ff&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_Exchange.js', 1, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=7d0fbe8d-0174-4b49-b0e9-bbe6dfad3f79&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_Forefront.js', 1, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=baa3ad86-bfc1-4bd4-9812-d9e710d44f42&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_SharePoint.js', 1, null],
    ['//[\\w\\.-]+/downloads/details\\.aspx\\?FamilyID=f027b66d-f615-426f-a45b-1e76a45371d5&DisplayLang=en$', '/library/svy/SiteRecruit_PageConfiguration_p19471936_System.js', 1, null],
    ['//[\\w\\.-]+/downloads/Search\\.aspx\\?displaylang=en$', '/library/svy/SiteRecruit_PageConfiguration_3331mt13-3332mt-3519mt-lang=en.js', 1, null],
    ['//[\\w\\.-]+/dynamics(/(?!dynamicsresearch.mspx|everyonegetsit)|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt14.js', 0, null],
    ['//[\\w\\.-]+/dynamics/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_3331mt14_flashfix.js', 1, null],
    ['//[\\w\\.-]+/education(/(?!facultyconnection)|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt15.js', 0, null],
    ['//[\\w\\.-]+/education/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_3331mt15_Flashfix.js', 1, null],
    ['//[\\w\\.-]+/events', '/library/svy/SiteRecruit_PageConfiguration_3331mt16.js', 0, null],
    ['//[\\w\\.-]+/exchange', '/library/svy/SiteRecruit_PageConfiguration_3331mt17.js', 0, null],
    ['//[\\w\\.-]+/exchange/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_3331mt17_flashfix.js', 1, null],
    ['//[\\w\\.-]+/france/entrepreneur(/(?!plus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_France.js', 0, null],
    ['//[\\w\\.-]+/france/msdn', '/library/svy/SiteRecruit_PageConfiguration_p15466742_19.js', 0, null],
    ['//[\\w\\.-]+/france/technet', '/library/svy/SiteRecruit_PageConfiguration_FR-technet-p12038685-p15466742.js', 0, null],
    ['//[\\w\\.-]+/france/windows/', '/library/svy/SiteRecruit_PageConfiguration_p15466742_21.js', 0, null],
    ['//[\\w\\.-]+/germany/kleinunternehmen(/(?!small-business-plus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Germany.js', 0, null],
    ['//[\\w\\.-]+/germany/mittelstand/', '/library/svy/SiteRecruit_PageConfiguration_p11880082-German.js', 0, null],
    ['//[\\w\\.-]+/germany/msdn/', '/library/svy/SiteRecruit_PageConfiguration_DE-msdn-p12038685.js', 0, null],
    ['//[\\w\\.-]+/germany/server(/|$)', '/library/svy/SiteRecruit_PageConfiguration_DE-wss-p12038685.js', 0, null],
    ['//[\\w\\.-]+/germany/windows(/|$)', '/library/svy/SiteRecruit_PageConfiguration_DE-windows-p12038685.js', 0, null],
    ['//[\\w\\.-]+/hardware((/)|(/default\\.asp)|(/default\\.mspx)|(/default\\.aspx))?$', '/library/svy/SiteRecruit_PageConfiguration_p16565330-hardware.js', 0, null],
    ['//[\\w\\.-]+/hardware/broadbandnetworking((/)|(/default\\.asp)|(/default\\.mspx)|(/default\\.aspx))?$', '/library/svy/SiteRecruit_PageConfiguration_2546mt_BroadbandNetworking.js', 0, null],
    ['//[\\w\\.-]+/hardware/digitalcommunication((/)|(/((default)|(index))\\.((html?)|(aspx?)|(mspx))))?$', '/library/svy/SiteRecruit_PageConfiguration_p16565330-digital.js', 0, null],
    ['//[\\w\\.-]+/hardware/mouseandkeyboard/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_p16565330-mouseandkeyboard.js', 0, null],
    ['//[\\w\\.-]+/industry/financialservices', '/library/svy/SiteRecruit_PageConfiguration_3331mt29.js', 0, null],
    ['//[\\w\\.-]+/industry/government', '/library/svy/SiteRecruit_PageConfiguration_3331mt30.js', 0, null],
    ['//[\\w\\.-]+/industry/healthcare', '/library/svy/SiteRecruit_PageConfiguration_3331mt31.js', 0, null],
    ['//[\\w\\.-]+/industry/hospitality', '/library/svy/SiteRecruit_PageConfiguration_3331mt32.js', 0, null],
    ['//[\\w\\.-]+/industry/manufacturing', '/library/svy/SiteRecruit_PageConfiguration_3331mt33.js', 0, null],
    ['//[\\w\\.-]+/industry/professionalservices', '/library/svy/SiteRecruit_PageConfiguration_3331mt34.js', 0, null],
    ['//[\\w\\.-]+/industry/retail', '/library/svy/SiteRecruit_PageConfiguration_3331mt35.js', 0, null],
    ['//[\\w\\.-]+/ireland/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Ireland.js', 0, null],
    ['//[\\w\\.-]+/italy', '/library/svy/SiteRecruit_PageConfiguration_p17637473_120.js', 0, null],
    ['//[\\w\\.-]+/italy/pmi(/(?!plus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Italy.js', 1, null],
    ['//[\\w\\.-]+/japan/msdn', '/library/svy/SiteRecruit_PageConfiguration_JA-p12038685-msdn.js', 0, null],
    ['//[\\w\\.-]+/japan/smallbiz((/)|(/((default)|(index))\\.((html?)|(aspx?)|(mspx))))?$', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Japan-Default.js', 1, null],
    ['//[\\w\\.-]+/japan/smallbiz', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Japan.js', 0, null],
    ['//[\\w\\.-]+/japan/technet/', '/library/svy/SiteRecruit_PageConfiguration_JA-p12038685-technet.js', 0, null],
    ['//[\\w\\.-]+/japan/users', '/library/svy/SiteRecruit_PageConfiguration_JA-p12038685-users.js', 0, null],
    ['//[\\w\\.-]+/japan/users/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_JA-p15466742-users-Flashfix.js', 1, null],
    ['//[\\w\\.-]+/japan/windows(/(?!(downloads/ie/au\\.mspx)|(downloads/ie/iedelete\\.mspx))|$)', '/library/svy/SiteRecruit_PageConfiguration_JA-p12038685-windows.js', 0, null],
    ['//[\\w\\.-]+/learning((/)|(/default\\.asp)|(/default\\.mspx)|(/default\\.aspx))?$', '/library/svy/SiteRecruit_PageConfiguration_3331mt42.js', 0, null],
    ['//[\\w\\.-]+/licensing', '/library/svy/SiteRecruit_PageConfiguration_3331mt43.js', 0, null],
    ['//[\\w\\.-]+/mexico/pymes', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Mexico.js', 0, null],
    ['//[\\w\\.-]+/midsizebusiness', '/library/svy/SiteRecruit_PageConfiguration_3123mt.js', 0, null],
    ['//[\\w\\.-]+/netherlands/lifestyle', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_319.js', 0, null],
    ['//[\\w\\.-]+/netherlands/lifestyle/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_319-flash_fix.js', 1, null],
    ['//[\\w\\.-]+/netherlands/manager', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_321.js', 0, null],
    ['//[\\w\\.-]+/netherlands/msdn', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_315.js', 1, null],
    ['//[\\w\\.-]+/netherlands/ondernemers(/(?!plus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Netherlands.js', 1, null],
    ['//[\\w\\.-]+/netherlands/partner', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_318.js', 1, null],
    ['//[\\w\\.-]+/netherlands/technet', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_317.js', 1, null],
    ['//[\\w\\.-]+/netherlands/windows/home', '/library/svy/SiteRecruit_PageConfiguration_p15466742-nl_320.js', 1, null],
    ['//[\\w\\.-]+/norge/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Norway.js', 0, null],
    ['//[\\w\\.-]+/portugal/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Portugal.js', 0, null],
    ['//[\\w\\.-]+/products/info/.*view=22', '/library/svy/SiteRecruit_PageConfiguration_3331mt48.js', 0, null],
    ['//[\\w\\.-]+/protect(/(?!computer/updates/bulletins)|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt4.js', 0, null],
    ['//[\\w\\.-]+/rus', '/library/svy/SiteRecruit_PageConfiguration_p17637473-p12030529mt-Russia.js', 0, null],
    ['//[\\w\\.-]+/security', '/library/svy/SiteRecruit_PageConfiguration_3331mt49-3332mt.js', 0, null],
    ['//[\\w\\.-]+/smallbusiness(/(?!small-business-plus)|$)', '/library/svy/SiteRecruit_PageConfiguration_2933mt_UnitedStates.js', 0, null],
    ['//[\\w\\.-]+/spain/empresas', '/library/svy/SiteRecruit_PageConfiguration_2933mt_Spain.js', 1, null],
    ['//[\\w\\.-]+/sql', '/library/svy/SiteRecruit_PageConfiguration_3331mt52.js', 0, null],
    ['//[\\w\\.-]+/sverige', '/library/svy/SiteRecruit_PageConfiguration_p17637473-sweden.js', 0, null],
    ['//[\\w\\.-]+/switzerland.*/de/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Swiss-de.js', 0, null],
    ['//[\\w\\.-]+/switzerland.*/fr/', '/library/svy/SiteRecruit_PageConfiguration_p12030529mt-Swiss-fr.js', 0, null],
    ['//[\\w\\.-]+/technet(/(?!mnp_utility\\.mspx/framesmenu)|$)', '/library/svy/SiteRecruit_PageConfiguration_p15808382-3332mt.js', 0, null],
    ['//[\\w\\.-]+/uc(/(?!livemeeting)|$)', '/library/svy/SiteRecruit_PageConfiguration_p12529714.js', 0, null],
    ['//[\\w\\.-]+/uc((/)|(/((default)|(index))\\.((html?)|(aspx?)|(mspx))))?$', '/library/svy/SiteRecruit_PageConfiguration_p12529714-FlashPortion.js', 1, null],
    ['//[\\w\\.-]+/uc/voipasyouare/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_p12529714-Flash-VoIP.js', 2, null],
    ['//[\\w\\.-]+/uk/smallbusiness...', '/library/svy/SiteRecruit_PageConfiguration_3300mt-uk.js', 0, null],
    ['//[\\w\\.-]+/uk/windows/digitallife/default\\.mspx', '/library/svy/SiteRecruit_PageConfiguration_p18904973mt-DDS-Email-UK.js', 0, null],
    ['//[\\w\\.-]+/windows/digitallife/default\\.mspx', '/library/svy/SiteRecruit_PageConfiguration_p18904973mt-DDS-Email.js', 0, null],
    ['//[\\w\\.-]+/windows/embedded', '/library/svy/SiteRecruit_PageConfiguration_3331mt174.js', 0, null],
    ['//[\\w\\.-]+/windows/products/windowsvista(/|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt64.js', 0, null],
    ['//[\\w\\.-]+/windows/products/winfamily/ie(/|$)', '/library/svy/SiteRecruit_PageConfiguration_3331mt62.js', 0, null],
    ['//[\\w\\.-]+/windowsmobile', '/library/svy/SiteRecruit_PageConfiguration_3331mt173.js', 0, null],
    ['//[\\w\\.-]+/windowsmobile/default\\.mspx$', '/library/svy/SiteRecruit_PageConfiguration_3331mt173_flashfix.js', 1, null],
    ['//[\\w\\.-]+/windowsserver2003', '/library/svy/SiteRecruit_PageConfiguration_3331mt63.js', 0, null],
    ];
    
    // Attach methods.
    this.start = PageConfigurationBroker_start;
    this.getConfigurationForPage = PageConfigurationBroker_getConfigurationForPage;
    this.loadConfiguration = PageConfigurationBroker_loadConfiguration;

    // Start the Broker.
    function PageConfigurationBroker_start(url)
    {        
        // Decide if there are surveys to run for this page.
        var configuration = this.getConfigurationForPage(url);
        
        // If there is, load id up.
        if (configuration != null)
        {
            this.loadConfiguration(configuration);
        }
    }
    
    // Return the appropriate configuration for the given URL, if any.
    function PageConfigurationBroker_getConfigurationForPage(url)
    {
        
        var currentScore = 0;
        var currentMatch = -1;
        
        // Iterate over each URL.
        for (var i = 0; i < this.m.length; i++)
        {
            if (this.m[i] != null)
            {
                // Do the reg exp match.
                var r = new RegExp(this.m[i][0], 'i');
                if (url.toString().search(r) != -1)
                {
                    var prereqs = this.m[i][3];
                    var matchPrereqs = true;
                    
                    // Now check the prereqs.
                    if (prereqs != null)
                    {
                        for (var j = 0; j < prereqs.length; j++)
                        {
                            var p = prereqs[j];
                            if (p != null)
                            {
                                if (p.elementType)
                                {
                                    var matchContent = false;
                                    var matchAttribute = false;
                                    
                                    var elements = document.getElementsByTagName(p.elementType);
                                    for (var k = 0; k < elements.length; k++)
                                    {
                                        if (p.contentValue != '')
                                        {
                                            if (elements[k].innerHTML.search(p.contentValue) != -1)
                                            {
                                                matchContent = true;
                                            }
                                        }
                                        else
                                        {
                                            matchContent = true;
                                        }
                                        
                                        if (p.attributeName != '')
                                        {
                                            var a = elements[k].attributes.getNamedItem(p.attributeName);
                                            if (a != null)
                                            {
                                                if (p.attributeValue != '')
                                                {
                                                    if (a.value.search(p.attributeValue) != -1)
                                                    {
                                                        matchAttribute = true;
                                                    }
                                                }
                                                else
                                                {
                                                    matchAttribute = true;
                                                }
                                             }
                                        }
                                        else
                                        {
                                            matchAttribute = true;
                                        }
                                    }
                                    
                                    if (!matchContent || !matchAttribute)
                                    {
                                        matchPrereqs = false;
                                        break;
                                    }
                                }
                                else if (p.cookieName)
                                {
                                    var cookieTemplate = p.cookieName + '=';
                                    if (p.cookieValue)
                                    {
                                        cookieTemplate += p.cookieValue;
                                    }
                                    if (document.cookie.indexOf(cookieTemplate) == -1)
                                    {
                                        matchPrereqs = false;
                                        break;
                                    }
                                }
                                else if (p.language)
                                {
                                    if (navigator.language && navigator.language.toString().toLowerCase().indexOf(p.language) == -1)
                                    {
                                        matchPrereqs = false;
                                        break;
                                    }
                                    else if (navigator.userLanguage && navigator.userLanguage.toString().toLowerCase().indexOf(p.language) == -1)
                                    {
                                        matchPrereqs = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        matchPrereqs = true;
                    }
                    
                    if (matchPrereqs)
                    {
                        // Take the current if the score is equal or better.
                        var newScore = this.m[i][2];
                        if (newScore >= currentScore)
                        {
                            currentMatch = i;
                            currentScore = newScore;
                        }
                    }
                }
            }
        }
        
        // If there was a match, return the appropriate page configuration.
        var page = null;
        if (currentMatch >= 0)
        {
            page = this.m[currentMatch][1];
        }
        
                
        return page;
    }
    
    // Dynamically loads the associated configuration.
    function PageConfigurationBroker_loadConfiguration(configuration)
    {
                
        document.write('<script language="JavaScript" src="' + configuration + '"></script>');
    }
}

try
{
    // Only run if the browser is supported.
    if (SiteRecruit_Globals.isInternetExplorer || SiteRecruit_Globals.isMozilla)
    {
        // Create and start the Broker for the current location.
        SiteRecruit_Globals.broker = new SiteRecruit_PageConfigurationBroker();
        SiteRecruit_Globals.broker.start(window.location);
    }
}
catch (e)
{
    // Suppress any errors.
}

SiteRecruit_Globals.parseFlag = true;

// Multiple script protection.
}
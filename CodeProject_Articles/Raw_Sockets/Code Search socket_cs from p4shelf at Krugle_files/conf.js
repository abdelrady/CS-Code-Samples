//<![CDATA[
/*
 * conf.js - required by all krugle modules. Defines base krugle namespace
 * and server and middleware configuration variables.
 * Chris Burmester, Krugle, Inc.
 *
*/

if (window.krugle === undefined) {
	// only setup the krugle namespace once

	/* create a base "krugle" namespacing object literal */
	window.krugle = {};
	
	/* create an empty partnerId or clientContext */
	krugle.partnerId = "";
	
	/* create a conf namespacing object to hold configuration variables */
	krugle.conf = {};

	/* public vs. enterprise mode */
	krugle.conf.mode = "public";
	
	/* whether or not user login is required to access the search environment */
	krugle.conf.authRequired = false;
	
	/* create an init namespacing object to hold initialization parameters */
	krugle.conf.init = {};
	
	krugle.conf.middlewareServerURL = "";	// URL of server to call for the middleware.
											// Do not include trailing slash and include protocol.
											// i.e. "http://www.krugle.org"
											// Use same base domain for middleware as web server.
	krugle.conf.middlewarePath = "/perl";	// Path on server to call middleware. Use mod_perl

}
//]]>

/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 3                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example3;


import com.devwizard.javaexe.examples.common.service.*;


/*****************************************************************************/
public class Example3_ServiceManagement extends Examples_ServiceManagement
{
	/*******************************************/
	public static boolean serviceInit()
	{
		app = new Example3();

		return true;
	}

	/*******************************************/
	public static String[] serviceGetInfo()
	{
		return new String[]
			{
				"JavaExe : Example3",					// Full name
				"JavaExe : Example3 of Java Services",	// Desc
				"0",									// IsAutomatic
				""+Example3_Config.cnfgAcceptStop,		// IsAcceptStop
				"",										// failure exe
				"",										// args failure
				"eventlog\t"							// dependencies
				+""
			};
	}


	/*---------------------------------------------------*/

	static
	{
		Example3_Config.init();
	}
}

/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 5                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example5;


import java.io.*;
import com.devwizard.javaexe.examples.common.service.*;


/*****************************************************************************/
public class Example5_ServiceManagement extends Examples_ServiceManagement
{
	/*******************************************/
	public static boolean serviceInit()
	{
		app = new Example5();

		return true;
	}

	/*******************************************/
	public static String[] serviceGetInfo()
	{
		return new String[]
			{
				"JavaExe : Example5",								// Full name
				"JavaExe : Example5 of Java Services & TrayIcon",	// Desc
				"1",												// IsAutomatic
				""+Example5_Config.cnfgAcceptStop,					// IsAcceptStop
				"",													// failure exe
				"",													// args failure
				""													// dependencies
			};
	}

	/*******************************************/
	public static void serviceDataFromUI(Serializable data)
	{
		if(app != null
		&& (data instanceof String) && "init".equals(data))
			app.reinit();
	}


	/*---------------------------------------------------*/

	static
	{
		Example5_Config.init();
	}
}

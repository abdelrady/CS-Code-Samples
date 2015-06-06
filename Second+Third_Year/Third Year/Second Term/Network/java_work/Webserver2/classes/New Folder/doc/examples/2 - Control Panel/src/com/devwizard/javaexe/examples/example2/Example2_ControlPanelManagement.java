/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 2                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example2;


import com.devwizard.javaexe.interfaces.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example2_ControlPanelManagement
	implements JavaExe_I_ControlPanelManagement
{
	/*******************************************/
	public static boolean cplIsCreate()
	{
		return Examples_UtilsGUI.showConfirmDialog("Create Control Panel"
			,"Do you want to install the Control Panel ?");
	}

	/*******************************************/
	public static boolean cplIsDelete()
	{
		return Examples_UtilsGUI.showConfirmDialog("Delete Control Panel"
			,"This Control Panel is already installed.\nDo you want to delete it ?");
	}

	/*******************************************/
	public static void cplOpen()
	{
		new Example2();
	}

	/*******************************************/
	public static String[] cplGetInfo()
	{
		return new String[]
			{
				"JavaExe : Example2",							// Name
				"JavaExe : Example of Control Panel with Java",	// Description
				""+CATGR_THEMES+","								// Categories
				  +CATGR_SECURITY
			};
	}


	/*---------------------------------------------------*/

	static
	{
		Example2_Config.init();
	}
}

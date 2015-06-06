/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.service;


import com.devwizard.javaexe.interfaces.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_ServiceManagement
	implements JavaExe_I_ServiceManagement
{
	public static Examples_AppService app = null;


	/*******************************************/
	public static boolean serviceIsCreate()
	{
		return Examples_ConfigService.showDialogOption("Create Service"
			,"Do you want to install the Server ?");
	}

	/*******************************************/
	public static boolean serviceIsLaunch()
	{
		return Examples_ConfigService.cnfgAutoStart;
	}

	/*******************************************/
	public static boolean serviceIsDelete()
	{
		return Examples_UtilsGUI.showConfirmDialog("Delete Service"
			,"This Server is already installed.\nDo you want to delete it ?");
	}

	/*******************************************/
	public static boolean serviceControl_Pause()
	{
		if(app != null)
			app.setFlagWait(true);

		return true;
	}

	/*******************************************/
	public static boolean serviceControl_Continue()
	{
		if(app != null)
			app.setFlagWait(false);

		return true;
	}

	/*******************************************/
	public static boolean serviceControl_Stop()
	{
		if(app != null)
			app.setFlagEnd(true);

		return true;
	}

	/*******************************************/
	public static boolean serviceControl_Shutdown()
	{
		if(app != null)
			app.setFlagEnd(true);

		return true;
	}

	/*******************************************/
	public static void serviceFinish()
	{
		System.exit(0);
	}
}

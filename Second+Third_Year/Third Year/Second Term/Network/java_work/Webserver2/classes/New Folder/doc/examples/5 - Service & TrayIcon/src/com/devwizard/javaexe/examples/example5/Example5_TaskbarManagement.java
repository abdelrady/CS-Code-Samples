/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 5                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example5;


import java.io.*;
import com.devwizard.javaexe.interfaces.*;


/*****************************************************************************/
public class Example5_TaskbarManagement
	implements JavaExe_I_TaskbarManagement
{
	static final int ID_MENU_CONF	= 1;
	static final int ID_MENU_WEB	= 2;

	static final String LBL_MENU_CONF	= "Config...";
	static final String LBL_MENU_WEB	= "Open browser";

	static boolean isData = false;


	/*******************************************/
	public static String[][] taskGetMenu(boolean isRightClick, int menuID)
	{
		if(!isRightClick || menuID > 0)
			return null;

		return new String[][]
			{
				{ ""+ID_MENU_CONF, LBL_MENU_CONF, "", "" },
				{ ""+ID_MENU_WEB,  LBL_MENU_WEB,  "", "" },
			};
	}

	/*******************************************/
	public static void taskDoAction(boolean isRightClick, int menuID)
	{
		switch(menuID)
		{
			case ID_MENU_CONF :
				isData = Example5_Config.showDialogOption("Modif config..."
					,"Do you want to modif the config ?",false);
				break;

			case ID_MENU_WEB :
				try
				{
					String path = Example5_Config.getRsrcPathname("openBrowser.bat");

					Runtime.getRuntime().exec("\""+path+"\" http://localhost:"+Example5_Config.cnfgPortNumber);
				}
				catch(Exception ex) {}
				break;
		}
	}

	/*******************************************/
	public static String[] taskGetInfo()
	{
		return new String[]
			{
				"JavaExe : Example5 of Service & TrayIcon with Java",	// Description
				""+ACT_CLICK_MENU,										// action "1 click-Right"
				""+ACT_CLICK_NOP,										// action "2 click-Right"
				""+ACT_CLICK_NOP,										// action "1 click-Left"
				""+ACT_CLICK_NOP										// action "2 click-Left"
			};
	}

	/*******************************************/
	public static boolean taskIsDataForService()
	{
		return isData;
	}

	/*******************************************/
	public static Serializable taskDataForService()
	{
		isData = false;

		return "init";
	}


	/*---------------------------------------------------*/

	static
	{
		Example5_Config.init();
	}
}

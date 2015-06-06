/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 4                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example4;


import java.awt.*;
import com.devwizard.javaexe.interfaces.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example4_TaskbarManagement
	implements JavaExe_I_TaskbarManagement
{
	static final int ID_MENU_OPEN		= 1;
	static final int ID_MENU_OPTION		= 2;
	static final int ID_MENU_QUIT		= 3;
	static final int ID_MENU_OPT_PREF 	= 4;
	static final int ID_MENU_OPT_MENU	= 5;

	static final String LBL_MENU_OPEN		= "Open";
	static final String LBL_MENU_OPTION		= "Options";
	static final String LBL_MENU_QUIT		= "Quit";
	static final String LBL_MENU_OPT_PREF	= "Preferences...";
	static final String LBL_MENU_OPT_MENU	= "Menu...";

	static int defaultAction = ID_MENU_OPEN;


	/*******************************************/
	public static String[][] taskGetMenu(boolean isRightClick, int menuID)
	{
		if(!isRightClick)
			return null;

		if(menuID <= 0)
			return new String[][]
				{
					{ ""+ID_MENU_OPEN,   LBL_MENU_OPEN, "", "" },
					{ ""+ID_MENU_OPTION, LBL_MENU_OPTION, "", "" },
					{ "", "", ""+MFT_SEPARATOR, "" },
					{ ""+ID_MENU_QUIT,   LBL_MENU_QUIT, "", "" },
				};

		switch(menuID)
		{
			case ID_MENU_OPTION :
				return new String[][]
					{
						{ ""+ID_MENU_OPT_PREF, LBL_MENU_OPT_PREF, "", "" },
						{ ""+ID_MENU_OPT_MENU, LBL_MENU_OPT_MENU, "", "" },
					};
		}

		return null;
	}

	/*******************************************/
	public static int taskGetDefaultMenuID(boolean isRightClick)
	{
		return defaultAction;
	}

	/*******************************************/
	public static boolean taskDisplayMenu(boolean isRightClick, Component parent, int x, int y)
	{
		if(isRightClick)
			return false;

		Example4_Menu.open(parent,x,y);
		return true;
	}

	/*******************************************/
	public static void taskDoAction(boolean isRightClick, int menuID)
	{
		switch(menuID)
		{
			case ID_MENU_OPEN :
				Example4_Dialog.open();
				break;

			case ID_MENU_OPT_PREF :
				Example4_Config.showDialogOption();
				break;

			case ID_MENU_OPT_MENU :
				int cmd = Example4_Config.showDialogMenu();
				if(cmd >= 0) defaultAction = cmd;
				break;

			case ID_MENU_QUIT : System.exit(0);
		}
	}

	/*******************************************/
	public static String[] taskGetInfo()
	{
		return new String[]
			{
				"JavaExe : Example4 of TrayIcon with Java",	// Description
				""+ACT_CLICK_MENU,							// action "1 click-Right"
				""+ACT_CLICK_NOP,							// action "2 click-Right"
				""+ACT_CLICK_MENU,							// action "1 click-Left"
				""+ACT_CLICK_OPEN							// action "2 click-Left"
			};
	}

	/*******************************************/
	public static boolean taskIsShow()
	{
		return Example4_Dialog.isShowIcon();
	}


	/*---------------------------------------------------*/

	static
	{
		Example4_Config.init();
	}
}

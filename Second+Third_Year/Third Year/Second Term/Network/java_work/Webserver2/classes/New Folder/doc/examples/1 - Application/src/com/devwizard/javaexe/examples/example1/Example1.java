/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 1                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example1;


import java.util.*;
import com.devwizard.javaexe.interfaces.*;


/*****************************************************************************/
public class Example1
	implements JavaExe_I_ApplicationManagement
{
	static long time1 = (new Date()).getTime();


	/*******************************************/
	public static boolean isCloseSplash()
	{
		long time2 = (new Date()).getTime();

		return(time2-time1 > 5000);
	}

	/*******************************************/
	public static void main(String[] args)
	{
		Example1_Config.init();
		Example1_Config.showDialogOption();
	}
}

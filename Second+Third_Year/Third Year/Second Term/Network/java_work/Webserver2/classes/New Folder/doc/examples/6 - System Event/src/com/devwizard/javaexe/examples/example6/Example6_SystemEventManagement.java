/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 6                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example6;


import com.devwizard.javaexe.examples.common.event.*;


/*****************************************************************************/
public class Example6_SystemEventManagement extends Examples_SystemEventManagement
{
	/*******************************************/
	public static int notifyEvent(int msg, int val1, int val2, String val3
		,int[] arr1, byte[] arr2)
	{
		while(Example6.app==null)
			try { Thread.sleep(500); }
			catch(Exception ex) {}

		return notifyEvent(Example6.app, true, msg, val1, val2, val3, arr1, arr2);
	}
}

/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 6                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example6;


import java.awt.*;
import com.devwizard.javaexe.examples.common.event.*;


/*****************************************************************************/
public class Example6 extends Examples_DialogEvent
{
	/*******************************************/
	public Example6()
	{
		show();
	}


	/*---------------------------------------------------*/

	public static Example6 app = null;


	/*******************************************/
	public static void main(String[] args)
	{
		System.out.println("** press CTRL-C to break the console **");

		app = new Example6();
	}
}

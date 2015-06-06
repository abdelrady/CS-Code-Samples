/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common;


import java.awt.*;
import java.io.*;
import java.net.*;
import java.util.*;
import javax.swing.*;


/*****************************************************************************/
public class Examples_Config
{
	static String nameApp = "";


	/*******************************************/
	public static void init(String name)
	{
		nameApp = name;
	}

	/*******************************************/
	public static boolean showDialogOption()
	{
		Examples_Panel p0 = new Examples_Panel();
		Examples_Panel p1 = new Examples_Panel(" Title 1 ");
		Examples_Panel p2 = new Examples_Panel(" Title 2 ");
		Examples_Panel p3 = new Examples_Panel(" Title 3 ");

		Examples_UtilsGUI.putCheckbox(p1,"option 1");
		Examples_UtilsGUI.putCheckbox(p1,"option 2");
		Examples_UtilsGUI.putCheckbox(p1,"option 3");
		Examples_UtilsGUI.putCheckbox(p1,"option 4");

		Examples_UtilsGUI.putTextfield(p2,"option 5");
		Examples_UtilsGUI.putTextfield(p2,"option 6");
		Examples_UtilsGUI.putTextfield(p3,"option 7");
		Examples_UtilsGUI.putTextfield(p3,"option 8");

		p0.putComponent(p1, 1, 2, GridBagConstraints.BOTH);
		p0.putLastComponent(p2);
		p0.putLastComponent(p3);

		return Examples_UtilsGUI.showConfirmDialog("Preferences...",p0);
	}

	/*******************************************/
	public static Properties loadProperties()
	{
		Properties prop = new Properties();

		try
		{
			prop.load(new FileInputStream(getRsrcProperties()));
		}
		catch(Exception ex) {}

		return prop;
	}

	/*******************************************/
	public static boolean saveProperties(Properties prop)
	{
		if(prop != null)
			try
			{
				prop.store(new FileOutputStream(getRsrcProperties()),null);

				return true;
			}
			catch(Exception ex) {}

		return false;
	}

	/*******************************************/
	public static String getRsrcProperties()
	{
		return getRsrcPathname(nameApp+".properties");
	}

	/*******************************************/
	public static String getRsrcPathname(String name)
	{
		if(!name.startsWith("/"))
			name = "/"+name;

		String path = getRsrcFile(name);

		if(path.equals(""))
		{
			path = getRsrcFile("/"+nameApp+".exe");

			int ndx = path.lastIndexOf("/");
			if(ndx >= 0) path = path.substring(0,ndx);

			path += name;
		}

		if(path.startsWith("/"))
			path = path.substring(1);

		return path;
	}

	/*******************************************/
	public static String getRsrcFile(String name)
	{
		try
		{
			URL u = getRsrcURL(name);

			if(u != null)
				return URLDecoder.decode(u.getFile(),"UTF-8");
		}
		catch(Exception ex) {}

		return "";
	}

	/*******************************************/
	public static URL getRsrcURL(String name)
	{
		return Examples_Config.class.getResource(name);
	}

	/*******************************************/
	public static String getCurrentTime()
	{
		GregorianCalendar calendar = new GregorianCalendar();

		calendar.setTime(new Date());

		int h = calendar.get(Calendar.HOUR_OF_DAY);
		int m = calendar.get(Calendar.MINUTE);
		int s = calendar.get(Calendar.SECOND);

		return((h <= 9 ? "0"+h : ""+h)
			+":"+(m <= 9 ? "0"+m : ""+m)
			+":"+(s <= 9 ? "0"+s : ""+s));
	}


	/*---------------------------------------------------*/

	static
	{
		Examples_UtilsGUI.setLookSystem();
	}
}

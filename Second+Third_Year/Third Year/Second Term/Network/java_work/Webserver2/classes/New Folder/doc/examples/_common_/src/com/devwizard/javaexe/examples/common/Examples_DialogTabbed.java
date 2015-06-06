/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common;


import java.awt.*;
import java.util.*;
import javax.swing.*;
import javax.swing.border.*;


/*****************************************************************************/
public class Examples_DialogTabbed extends Examples_Dialog
{
	JTabbedPane tabs = null;
	Vector vectTabs = new Vector();


	/*******************************************/
	public Examples_DialogTabbed(String title,
		String[] tabTitles, Component[] tabComponents)
	{
		super(null, title, null, false, true, false);

		tabs = new JTabbedPane();
		tabs.setBorder(new EmptyBorder(2,2,0,2));

		if(tabTitles != null && tabComponents != null
		&& tabTitles.length==tabComponents.length)
			for(int i=0;i < tabTitles.length;i++)
				addTab(tabTitles[i], tabComponents[i]);

		initComponent(new JComponent[] { tabs });
		setComponent(tabs,"Center");

		loadProperties();
	}

	/*******************************************/
	public void addTab(String title, Component comp)
	{
		vectTabs.add(comp);
		comp = Examples_UtilsGUI.getComponentLeftPaned(comp);

		if(comp != null)
			tabs.add((title==null ? "" : title), comp);
	}

	/*******************************************/
	public Point getXY()
	{
		return new Point(100,100);
	}

	/*******************************************/
	public void loadProperties()
	{
		Properties prop = Examples_Config.loadProperties();

		if(prop==null)
			return;

		int nb = vectTabs.size();

		for(int i=0;i < nb;i++)
		{
			Object tab = vectTabs.get(i);

			if(tab instanceof Examples_I_DialogTab)
				((Examples_I_DialogTab) tab).loadProperties(prop);
		}
	}

	/*******************************************/
	public void saveProperties()
	{
		Properties prop = Examples_Config.loadProperties();

		if(prop==null)
			return;

		int nb = vectTabs.size();

		for(int i=0;i < nb;i++)
		{
			Object tab = vectTabs.get(i);

			if(tab instanceof Examples_I_DialogTab)
				((Examples_I_DialogTab) tab).saveProperties(prop);
		}

		Examples_Config.saveProperties(prop);
	}
}

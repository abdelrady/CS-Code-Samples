/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.service;


import java.awt.*;
import java.util.*;
import javax.swing.*;
import javax.swing.border.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_ConfigService extends Examples_Config
{
	public static int cnfgPortNumber	= 12367;
	public static boolean cnfgAutoStart	= true;
	public static boolean cnfgAcceptStop= true;


	/*******************************************/
	public static void init(String name)
	{
		Examples_Config.init(name);
		initParameters();
	}

	/*******************************************/
	public static boolean showDialogOption(String title, String msg)
	{
		return showDialogOption(title,msg,true);
	}

	/*******************************************/
	public static boolean showDialogOption(String title, String msg, boolean isAll)
	{
		JTextField txtPort = new JTextField(""+cnfgPortNumber,5);
		JCheckBox chkRun   = new JCheckBox("Run server",cnfgAutoStart);
		JCheckBox chkStop  = new JCheckBox("Accept Stop",cnfgAcceptStop);

		Examples_Panel p1 = new Examples_Panel();
		Examples_Panel p2 = new Examples_Panel(" Parameters ",10,0,10,0);

		p2.putComponent(new JLabel("Port number ",JLabel.RIGHT));
		p2.putComponent(txtPort,GridBagConstraints.REMAINDER,1,GridBagConstraints.BOTH,0,0,10,0);

		if(isAll)
		{
			p2.putLastComponent(chkRun);
			p2.putLastComponent(chkStop);
		}

		p1.putLastComponent(new JLabel(msg));
		p1.putLastComponent(p2);

		if(!Examples_UtilsGUI.showConfirmDialog(title,p1))
			return false;

		try
		{
			cnfgPortNumber = Integer.parseInt(txtPort.getText());
			cnfgAutoStart  = chkRun.isSelected();
			cnfgAcceptStop = chkStop.isSelected();

			saveParameters();
		}
		catch(Exception ex) {}

		return true;
	}

	/*******************************************/
	static void initParameters()
	{
		Properties prop = loadProperties();

		if(prop != null)
			try
			{
				cnfgPortNumber = Integer.parseInt(prop.getProperty("cnfgPortNumber",""+cnfgPortNumber));
				cnfgAutoStart  = Boolean.valueOf(prop.getProperty("cnfgAutoStart",""+cnfgAutoStart)).booleanValue();
				cnfgAcceptStop = Boolean.valueOf(prop.getProperty("cnfgAcceptStop",""+cnfgAcceptStop)).booleanValue();
			}
			catch(Exception ex) {}
	}

	/*******************************************/
	static void saveParameters()
	{
		Properties prop = loadProperties();

		if(prop != null)
		{
			prop.setProperty("cnfgPortNumber",""+cnfgPortNumber);
			prop.setProperty("cnfgAutoStart",""+cnfgAutoStart);
			prop.setProperty("cnfgAcceptStop",""+cnfgAcceptStop);

			saveProperties(prop);
		}
	}
}

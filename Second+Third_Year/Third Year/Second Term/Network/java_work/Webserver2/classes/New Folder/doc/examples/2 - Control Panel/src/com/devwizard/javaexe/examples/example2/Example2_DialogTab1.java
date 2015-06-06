/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 2                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example2;


import java.awt.*;
import java.util.*;
import javax.swing.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example2_DialogTab1 extends Examples_Panel
	implements Examples_I_DialogTab
{
	JTextField optField1 = new JTextField(10);
	JTextField optField2 = new JTextField(10);


	/*******************************************/
	public Example2_DialogTab1()
	{
		putComponent(new JLabel("option 1"));
		putLastComponent(optField1);

		putComponent(new JLabel("option 2"));
		putLastComponent(optField2);
	}

	/*******************************************/
	public void loadProperties(Properties prop)
	{
		optField1.setText(prop.getProperty("tab1.option1"));
		optField2.setText(prop.getProperty("tab1.option2"));
	}

	/*******************************************/
	public void saveProperties(Properties prop)
	{
		prop.setProperty("tab1.option1",optField1.getText());
		prop.setProperty("tab1.option2",optField2.getText());
	}
}

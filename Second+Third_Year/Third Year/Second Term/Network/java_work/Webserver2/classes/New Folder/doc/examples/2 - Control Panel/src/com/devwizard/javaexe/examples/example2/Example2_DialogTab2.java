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
public class Example2_DialogTab2 extends Examples_Panel
	implements Examples_I_DialogTab
{
	JCheckBox opt1check = new JCheckBox("option 1");
	JCheckBox opt2check = new JCheckBox("option 2");
	JCheckBox opt3check = new JCheckBox("option 3");
	JCheckBox opt4check = new JCheckBox("option 4");

	JTextField opt5field = new JTextField(10);
	JTextField opt6field = new JTextField(10);
	JTextField opt7field = new JTextField(10);
	JTextField opt8field = new JTextField(10);


	/*******************************************/
	public Example2_DialogTab2()
	{
		Examples_Panel p1 = new Examples_Panel(" Title 1 ");
		Examples_Panel p2 = new Examples_Panel(" Title 2 ");
		Examples_Panel p3 = new Examples_Panel(" Title 3 ");

		p1.putLastComponent(opt1check);
		p1.putLastComponent(opt2check);
		p1.putLastComponent(opt3check);
		p1.putLastComponent(opt4check);

		p2.putComponent(new JLabel("option 5"));
		p2.putLastComponent(opt5field);
		p2.putComponent(new JLabel("option 6"));
		p2.putLastComponent(opt6field);

		p3.putComponent(new JLabel("option 7"));
		p3.putLastComponent(opt7field);
		p3.putComponent(new JLabel("option 8"));
		p3.putLastComponent(opt8field);

		putComponent(p1,1,2,GridBagConstraints.BOTH);
		putLastComponent(p2);
		putLastComponent(p3);
	}

	/*******************************************/
	public void loadProperties(Properties prop)
	{
		opt1check.setSelected("true".equals(prop.getProperty("tab2.option1")));
		opt2check.setSelected("true".equals(prop.getProperty("tab2.option2")));
		opt3check.setSelected("true".equals(prop.getProperty("tab2.option3")));
		opt4check.setSelected("true".equals(prop.getProperty("tab2.option4")));

		opt5field.setText(prop.getProperty("tab2.option5"));
		opt6field.setText(prop.getProperty("tab2.option6"));
		opt7field.setText(prop.getProperty("tab2.option7"));
		opt8field.setText(prop.getProperty("tab2.option8"));
	}

	/*******************************************/
	public void saveProperties(Properties prop)
	{
		prop.setProperty("tab2.option1", ""+opt1check.isSelected());
		prop.setProperty("tab2.option2", ""+opt2check.isSelected());
		prop.setProperty("tab2.option3", ""+opt3check.isSelected());
		prop.setProperty("tab2.option4", ""+opt4check.isSelected());

		prop.setProperty("tab2.option5", opt5field.getText());
		prop.setProperty("tab2.option6", opt6field.getText());
		prop.setProperty("tab2.option7", opt7field.getText());
		prop.setProperty("tab2.option8", opt8field.getText());
	}
}

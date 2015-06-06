/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 2                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example2;


import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example2 extends Examples_DialogTabbed
{
	JButton butApply;


	/*******************************************/
	public Example2()
	{
		super(""
			,new String[]
				{
					" Tab1 ",
					" Tab2 ",
					" Tab3 "
				}
			,new JPanel[]
				{
					new Example2_DialogTab1(),
					new Example2_DialogTab2(),
					new Example2_DialogTab3()
				});

		String[] lst = Example2_ControlPanelManagement.cplGetInfo();

		if(lst != null)
			setTitle(lst[1]);

		show();
	}

	/*******************************************/
	public void putButtons()
	{
		butApply = new JButton("Apply");
		initComponent(new JButton[] { butApply });

		putButton(butApply);

		super.putButtons();
	}

	/*******************************************/
	public Dimension getWH()
	{
		return new Dimension(300,300);
	}

	/*******************************************/
	public void actionPerformed(ActionEvent evt)
	{
		Object obj = evt.getSource();

		if(obj==butApply || obj==butOK)
			saveProperties();

		super.actionPerformed(evt);
	}


	/*---------------------------------------------------*/

	/*******************************************/
	public static void main(String[] args)
	{
		Example2_ControlPanelManagement.cplOpen();
	}
}

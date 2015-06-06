/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 4                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example4;


import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example4_Dialog extends Examples_Dialog
{
	JCheckBox chkShow;


	/*******************************************/
	public Example4_Dialog()
	{
		super(null, "Example4", false, false);

		addWindowListener(new WindowAdapter()
			{
				/*******************************************/
				public void windowClosing(WindowEvent evt)
				{
					if(!isShow && nbOpen <= 1)
						System.exit(0);

					incrNb(-1);
				}

				/*******************************************/
				public void windowActivated(WindowEvent evt)
				{
					chkShow.setSelected(isShow);
				}
			});

		incrNb(+1);
		show();
	}

	/*******************************************/
	public Dimension getWH()
	{
		return new Dimension(300,300);
	}

	/*******************************************/
	public void putPanels()
	{
		chkShow = new JCheckBox("Show icon in the taskbar",isShow);

		setComponent(new JLabel(Examples_UtilsGUI.getIcon("construct.gif")),"Center",false);
		setComponent(chkShow,"South",false);

		chkShow.addActionListener(new ActionListener()
			{
				/*******************************************/
				public void actionPerformed(ActionEvent evt)
				{
					setShowIcon(chkShow.isSelected());
				}
			});
	}


	/*---------------------------------------------------*/

	static boolean isShow = true;
	static int nbOpen = 0;


	/*******************************************/
	static synchronized void incrNb(int add)
	{
		nbOpen += add;
	}

	/*******************************************/
	static synchronized void setShowIcon(boolean b)
	{
		isShow = b;
	}

	/*******************************************/
	public static boolean isShowIcon()
	{
		return isShow;
	}

	/*******************************************/
	public static void open()
	{
		new Example4_Dialog();
	}
}

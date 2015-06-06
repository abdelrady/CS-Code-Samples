/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 8                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example8;


import java.awt.*;
import java.awt.event.*;
import com.devwizard.javaexe.examples.common.event.*;


/*****************************************************************************/
public class Example8 extends Examples_DialogEvent
{
	/*******************************************/
	public Example8()
	{
		setDefaultCloseOperation(HIDE_ON_CLOSE);
		hide();
	}

	/*******************************************/
	public void putPanels()
	{
		super.putPanels();

		tableLog.setIsFileLog(false);
	}

	/*******************************************/
	public void putButtons()
	{
		super.putButtons();

		if(butOK != null)
			butOK.setText(" Hide ");
	}

	/*******************************************/
	public Point getXY()
	{
		Point pt = new Point(0,0);
		Toolkit tk = Toolkit.getDefaultToolkit();

		if(tk != null)
			try
			{
				Dimension dim = tk.getScreenSize();

				pt.x = dim.width - APP_WIDTH - 5;
				pt.y = dim.height - APP_HEIGHT - 50;
			}
			catch(Exception ex) {}

		return pt;
	}

	/*******************************************/
	public void actionPerformed(ActionEvent evt)
	{
		Object obj = evt.getSource();

		if(obj==butOK)
			hide();
		else
			super.actionPerformed(evt);
	}

	/*******************************************/
	public void show()
	{
		super.show();
		toFront();
	}


	/*---------------------------------------------------*/

	public static Example8 app = null;


	/*******************************************/
	public static void createApp()
	{
		if(app==null)
			app = new Example8();
	}

	/*******************************************/
	public static boolean isShow()
	{
		return(app != null && app.isVisible());
	}
}

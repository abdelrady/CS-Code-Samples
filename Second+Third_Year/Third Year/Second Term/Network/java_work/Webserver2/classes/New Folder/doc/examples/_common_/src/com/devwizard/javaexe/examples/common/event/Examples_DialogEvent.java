/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.event;


import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_DialogEvent extends Examples_Dialog
	implements Examples_I_LogEvent
{
	public static final int APP_WIDTH	= 800;
	public static final int APP_HEIGHT	= 300;


	public Examples_TableEventLog tableLog;
	public JButton butClear;


	/*******************************************/
	public Examples_DialogEvent()
	{
		super(null, "System Event", null, true, false, false);

		initComponent(new JButton[] { butClear });
	}

	/*******************************************/
	public void putButtons()
	{
		butClear = new JButton("Clear");

		putButton(butClear);
		putButton(butOK);
	}

	/*******************************************/
	public void putPanels()
	{
		tableLog = new Examples_TableEventLog();
		Examples_Panel p = new Examples_Panel(" History ");

		JScrollPane sp = new JScrollPane(tableLog);
		JViewport vp = sp.getViewport();

		vp.setBackground(tableLog.getBackground());

		p.setLayout(new BorderLayout());
		p.add("Center",sp);

		setComponent(p,"Center",false);
	}

	/*******************************************/
	public Dimension getWH()
	{
		return new Dimension(APP_WIDTH,APP_HEIGHT);
	}

	/*******************************************/
	public void actionPerformed(ActionEvent evt)
	{
		Object obj = evt.getSource();

		if(obj==butClear)
		{
			if(tableLog != null)
				tableLog.clearLog();
		}
		else
			super.actionPerformed(evt);
	}

	/*******************************************/
	public void logEvent(String event, String param)
	{
		if(tableLog != null)
			tableLog.appendLog(event, param);
	}

	/*******************************************/
	public void setIsFileLog(boolean isFileLog)
	{
		if(tableLog != null)
			tableLog.setIsFileLog(isFileLog);
	}
}

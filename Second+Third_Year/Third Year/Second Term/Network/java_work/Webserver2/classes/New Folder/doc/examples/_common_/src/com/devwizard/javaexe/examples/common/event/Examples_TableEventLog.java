/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.event;


import java.awt.*;
import java.util.*;
import javax.swing.*;
import javax.swing.table.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Examples_TableEventLog extends JTable
{
	boolean isFileLog = false;
	DefaultTableModel model = new DefaultTableModel(new String[]
		{
			"Time","Event","Parameters"
		}
		,0);


	/*******************************************/
	public Examples_TableEventLog()
	{
		this(true);
	}

	/*******************************************/
	public Examples_TableEventLog(boolean isFileLog)
	{
		this.isFileLog = isFileLog;

		setModel(model);
		setShowGrid(false);
		setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
		setAutoResizeMode(AUTO_RESIZE_LAST_COLUMN);
		setIntercellSpacing(new Dimension(0,0));

		TableColumnModel cm = getColumnModel();

		if(cm != null)
		{
			TableColumn c = cm.getColumn(0);
			if(c != null) c.setPreferredWidth(80);

			c = cm.getColumn(1);
			if(c != null) c.setPreferredWidth(170);

			c = cm.getColumn(2);
			if(c != null) c.setPreferredWidth(550);
		}
	}

	/*******************************************/
	public void appendLog(String event, String param)
	{
		appendLog(new String[] { Examples_Config.getCurrentTime(), event, param });
	}

	/*******************************************/
	public void appendLog(String[] data)
	{
		if(data != null)
		{
			model.addRow(data);

			if(isFileLog)
				Examples_UtilsEvent.logEvent(data);
		}
	}

	/*******************************************/
	public void clearLog()
	{
		for(int nb=model.getRowCount();nb > 0;nb--)
			model.removeRow(0);
	}

	/*******************************************/
	public boolean isCellEditable(int row, int column)
	{
		return false;
	}

	/*******************************************/
	public void setIsFileLog(boolean isLog)
	{
		isFileLog = isLog;
	}
}

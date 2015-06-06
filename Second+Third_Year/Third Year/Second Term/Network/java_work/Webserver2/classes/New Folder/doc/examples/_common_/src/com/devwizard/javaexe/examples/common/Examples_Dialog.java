/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common;


import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


/*****************************************************************************/
public class Examples_Dialog extends JDialog
	implements ActionListener
{
	public JPanel panelButton = null;
	public JButton butOK = new JButton("OK");
	public JButton butCncl = new JButton("Cancel");


	/*******************************************/
	public Examples_Dialog(Frame mainFrame, String title)
	{
		this(mainFrame,title,false);
	}

	/*******************************************/
	public Examples_Dialog(Frame mainFrame, String title
		,boolean isResize)
	{
		this(mainFrame,title,isResize,true);
	}

	/*******************************************/
	public Examples_Dialog(Frame mainFrame, String title
		,boolean isResize, boolean isModal)
	{
		this(mainFrame,title,null,isResize,isModal);
	}

	/*******************************************/
	public Examples_Dialog(Frame mainFrame, String title, Component panel
		,boolean isResize, boolean isModal)
	{
		this(mainFrame, title, panel, isResize, isModal, true);
	}

	/*******************************************/
	public Examples_Dialog(Frame mainFrame, String title, Component panel
		,boolean isResize, boolean isModal, boolean isSep)
	{
		super(mainFrame,title,isModal);

		initComponent(new JButton[] { butOK,butCncl });

		panelButton = new JPanel(new FlowLayout(FlowLayout.RIGHT));
		JPanel p = panelButton;

		if(isSep)
		{
			p = new JPanel(new BorderLayout(0,0));

			p.add("North",new JSeparator(JSeparator.HORIZONTAL));
			p.add("Center",panelButton);
		}

		Container c = getContentPane();

		c.setLayout(new BorderLayout());
		c.add("South",p);

		setComponent(panel,"Center");
		putPanels();
		putButtons();

		Point xy = getXY();
		Dimension wh = getWH();

		if(wh==null)
			pack();
		else
			setSize(wh);

		setLocation(xy==null ? new Point(0,0) : xy);
		setResizable(isResize);
		setDefaultCloseOperation(DISPOSE_ON_CLOSE);

		toFront();
	}

	/*******************************************/
	public void setComponent(Component comp, String pos)
	{
		setComponent(comp, pos, true);
	}

	/*******************************************/
	public void setComponent(Component comp, String pos, boolean isPaned)
	{
		if(isPaned)
			comp = Examples_UtilsGUI.getComponentLeftPaned(comp);

		Container c = getContentPane();

		if(c != null && comp != null)
			c.add(pos,comp);
	}

	/*******************************************/
	public Point getXY()
	{
		return null;
	}

	/*******************************************/
	public Dimension getWH()
	{
		return null;
	}

	/*******************************************/
	public void initComponent(JComponent[] lstLbl)
	{
		Examples_UtilsGUI.initComponent(lstLbl);
	}

	/*******************************************/
	public void initComponent(AbstractButton[] lstBut)
	{
		Examples_UtilsGUI.initComponent(lstBut,this);
	}

	/*******************************************/
	public void initComponent(JComponent[] lstLbl, AbstractButton[] lstBut)
	{
		Examples_UtilsGUI.initComponent(lstLbl,lstBut,this);
	}

	/*******************************************/
	public void putPanels()
	{
	}

	/*******************************************/
	public void putButtons()
	{
		putButton(butOK);
		putButton(butCncl);
	}

	/*******************************************/
	public void putButton(Component comp)
	{
		if(comp != null)
			panelButton.add(comp);
	}

	/*******************************************/
	public void removeButton(Component comp)
	{
		if(comp != null)
		{
			panelButton.remove(comp);
			panelButton.updateUI();
		}
	}

	/*******************************************/
	public void clearButton()
	{
		panelButton.removeAll();
		panelButton.updateUI();
	}

	/*******************************************/
	public void actionPerformed(ActionEvent evt)
	{
		Object obj = evt.getSource();

		if(obj==butOK || obj==butCncl)
			dispose();
	}


	/*---------------------------------------------------*/

	static
	{
		Examples_UtilsGUI.setLookSystem();
	}
}

/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common;


import java.awt.*;
import java.awt.event.*;
import java.net.*;
import javax.swing.*;
import javax.swing.text.*;


/*****************************************************************************/
public class Examples_UtilsGUI
{
	public static Font font_TNR_12 = new Font("Times New Roman",0,12);


	/*******************************************/
	public static void initComponent(JComponent[] lstLbl)
	{
		initComponent(lstLbl,null,null);
	}

	/*******************************************/
	public static void initComponent(JComponent[] lstLbl, Font fnt)
	{
		initComponent(lstLbl,null,null,fnt);
	}

	/*******************************************/
	public static void initComponent(AbstractButton[] lstBut)
	{
		initComponent(null,lstBut,null);
	}

	/*******************************************/
	public static void initComponent(AbstractButton[] lstBut, Font fnt)
	{
		initComponent(null,lstBut,null,fnt);
	}

	/*******************************************/
	public static void initComponent(AbstractButton[] lstBut, ActionListener act)
	{
		initComponent(null,lstBut,act);
	}

	/*******************************************/
	public static void initComponent(JComponent[] lstLbl, AbstractButton[] lstBut)
	{
		initComponent(lstLbl,lstBut,null);
	}

	/*******************************************/
	public static void initComponent(JComponent[] lstLbl, AbstractButton[] lstBut
		,ActionListener act)
	{
		initComponent(lstLbl, lstBut, act, font_TNR_12);
	}

	/*******************************************/
	public static void initComponent(JComponent[] lstLbl, AbstractButton[] lstBut
		,ActionListener act, Font fnt)
	{
		if(lstLbl != null)
			for(int i=0;i < lstLbl.length;i++)
				if(lstLbl[i] != null)
					lstLbl[i].setFont(fnt);

		if(lstBut != null)
			for(int i=0;i < lstBut.length;i++)
				if(lstBut[i] != null)
				{
					lstBut[i].setFont(fnt);
					if(act != null) lstBut[i].addActionListener(act);
				}
	}

	/*******************************************/
	public static JTextField putTextfield(Examples_Panel p, String txt)
	{
		JTextField txtField = new JTextField(10);

		p.putComponent(new JLabel(txt));
		p.putLastComponent(txtField);

		return txtField;
	}

	/*******************************************/
	public static JCheckBox putCheckbox(Examples_Panel p, String txt)
	{
		JCheckBox chk = new JCheckBox(txt);

		p.putLastComponent(chk);

		return chk;
	}

	/*******************************************/
	public static Component getComponentLeftPaned(Component comp)
	{
		if(comp != null
		&& !(comp instanceof JScrollPane)
		&& !(comp instanceof JTabbedPane)
		&& !(comp instanceof JPanel))
		{
			JPanel p = new JPanel(new FlowLayout(FlowLayout.LEFT));

			p.add(comp);
			comp = p;
		}

		return comp;
	}

	/*******************************************/
	public static Image getImage(String nameFile)
	{
		ImageIcon icn = getIcon(nameFile);

		return(icn==null ? null : icn.getImage());
	}

	/*******************************************/
	public static ImageIcon getIcon(String nameFile)
	{
		URL u = Examples_Config.getRsrcURL("/Images/"+nameFile);

		return(u==null ? null : new ImageIcon(u));
	}

	/*******************************************/
	public static boolean showConfirmDialog(String title, Object msg)
	{
		int ret = JOptionPane.showConfirmDialog(null, msg, title
			,JOptionPane.YES_NO_OPTION);

		return(ret==JOptionPane.YES_OPTION);
	}

	/*******************************************/
	public static void showInfoDialog(String title, Object msg)
	{
		showMessageDialog(title, msg, JOptionPane.INFORMATION_MESSAGE);
	}

	/*******************************************/
	public static void showMessageDialog(String title, Object msg)
	{
		showMessageDialog(title, msg, JOptionPane.ERROR_MESSAGE);
	}

	/*******************************************/
	public static void showMessageDialog(String title, Object msg, int type)
	{
		JOptionPane.showMessageDialog(null, msg, title, type);
	}

	/*******************************************/
	public static void setLookSystem()
	{
		try
		{
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		}
		catch(Exception ex) {}
	}


	/*---------------------------------------------------*/

	static
	{
		setLookSystem();
	}
}

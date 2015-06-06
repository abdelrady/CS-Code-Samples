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
import javax.swing.border.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example4_Menu extends JPopupMenu
	implements ActionListener
{
	JMenuItem menu1 = new JMenuItem("Action 1", Examples_UtilsGUI.getIcon("action1.gif"));
	JMenuItem menu2 = new JMenuItem("Action 2", Examples_UtilsGUI.getIcon("action2.gif"));
	JMenuItem menu3 = new JMenuItem("Action 3", Examples_UtilsGUI.getIcon("action3.gif"));
	JMenuItem menu4 = new JMenuItem("Action 4", Examples_UtilsGUI.getIcon("action4.gif"));


	/*******************************************/
	public Example4_Menu()
	{
		add(menu1);
		add(menu2);
		add(menu3);
		addSeparator();
		add(menu4);

		setBorder(new BevelBorder(BevelBorder.RAISED));
		pack();

		addMouseListener(new MouseAdapter()
			{
				/*****************************************/
				public void mouseClicked(MouseEvent evt)
				{
					setVisible(false);
				}
			});
	}

	/*******************************************/
	public JMenuItem add(JMenuItem item)
	{
		item.addActionListener(this);

		return super.add(item);
	}

	/*******************************************/
	public void show(Component parent, int x, int y)
	{
		Dimension wh = getPreferredSize();

		x -= wh.width;
		y -= wh.height;

		super.show(parent,x,y);
		updateUI();
	}

	/*******************************************/
	public void actionPerformed(ActionEvent evt)
	{
		Object o = evt.getSource();

		if(o==menu1)
			Examples_UtilsGUI.showInfoDialog("Example4", menu1.getText());

		else if(o==menu2)
			Examples_UtilsGUI.showInfoDialog("Example4", menu2.getText());

		else if(o==menu3)
			Examples_UtilsGUI.showInfoDialog("Example4", menu3.getText());

		else if(o==menu4)
			Examples_UtilsGUI.showInfoDialog("Example4", menu4.getText());
	}


	/*---------------------------------------------------*/

	static Example4_Menu menu	= null;


	/*******************************************/
	public static void open(Component parent, int x, int y)
	{
		if(menu==null)
			menu = new Example4_Menu();

		menu.show(parent,x,y);
	}
}

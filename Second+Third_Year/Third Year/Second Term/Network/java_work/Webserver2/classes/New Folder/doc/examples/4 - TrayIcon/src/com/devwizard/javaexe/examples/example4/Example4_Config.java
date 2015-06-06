/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/***                                                                       ***/
/***                                                                       ***/
/***   Example 4                                                           ***/
/***                                                                       ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.example4;


import java.awt.*;
import javax.swing.*;
import com.devwizard.javaexe.examples.common.*;


/*****************************************************************************/
public class Example4_Config extends Examples_Config
{
	/*******************************************/
	public static void init()
	{
		init("Example4");
	}

	/*******************************************/
	public static int showDialogMenu()
	{
		Examples_Panel p = new Examples_Panel();
		ButtonGroup grp  = new ButtonGroup();

		p.putComponent(new JLabel("Choose the default menu entry for 2-click :")
			,GridBagConstraints.REMAINDER, 1, GridBagConstraints.BOTH, 0, 0, 10, 0);

		putRB(p, grp, Example4_TaskbarManagement.LBL_MENU_OPEN,     Example4_TaskbarManagement.ID_MENU_OPEN);
		putRB(p, grp, Example4_TaskbarManagement.LBL_MENU_OPT_PREF, Example4_TaskbarManagement.ID_MENU_OPT_PREF);
		putRB(p, grp, Example4_TaskbarManagement.LBL_MENU_OPT_MENU, Example4_TaskbarManagement.ID_MENU_OPT_MENU);
		putRB(p, grp, Example4_TaskbarManagement.LBL_MENU_QUIT,     Example4_TaskbarManagement.ID_MENU_QUIT);

		if(Examples_UtilsGUI.showConfirmDialog("Menu...",p))
		{
			ButtonModel bm = grp.getSelection();

			if(bm != null)
				try
				{
					return Integer.parseInt(bm.getActionCommand());
				}
				catch(Exception ex) {}
		}

		return -1;
	}

	/*******************************************/
	static void putRB(Examples_Panel p, ButtonGroup grp, String txt, int cmd)
	{
		p.putLastComponent(createRB(grp,txt,cmd));
	}

	/*******************************************/
	static JRadioButton createRB(ButtonGroup grp, String txt, int cmd)
	{
		JRadioButton rb = new JRadioButton(txt);

		grp.add(rb);
		grp.setSelected(rb.getModel(), (cmd==Example4_TaskbarManagement.defaultAction));

		rb.setActionCommand(""+cmd);

		return rb;
	}
}

/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common;


import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;


/*****************************************************************************/
public class Examples_Panel extends JPanel
{
	GridBagLayout gridBag = new GridBagLayout();
	GridBagConstraints gridConst = new GridBagConstraints();

	int defaultFill;


	/*******************************************/
	public Examples_Panel()
	{
		this(null);
	}

	/*******************************************/
	public Examples_Panel(String title)
	{
		this(title,0,0,0,0);
	}

	/*******************************************/
	public Examples_Panel(String title, int top, int left, int bottom, int right)
	{
		setLayout(gridBag);

		AbstractBorder b1 = null;
		AbstractBorder b2 = null;

		if(top != 0 || left != 0 || bottom != 0 || right != 0)
			b1 = new EmptyBorder(top,left,bottom,right);

		if(title != null)
			b2 = new TitledBorder(title);

		if(b1 != null && b2 != null)
			setBorder(new CompoundBorder(b1,b2));
		else if(b1 != null)
			setBorder(b1);
		else if(b2 != null)
			setBorder(b2);

		init(GridBagConstraints.NONE);
	}

	/*******************************************/
	public void init(int fill)
	{
		defaultFill = fill;

		gridConst.fill = fill;
		gridConst.weightx = 0.0;
		gridConst.weighty = 0.0;
		gridConst.insets = new Insets(1,1,1,1);
		gridConst.ipadx = 0;
		gridConst.ipady = 0;
		gridConst.anchor = GridBagConstraints.NORTHWEST;
	}

	/*******************************************/
	public void putLastComponent(JComponent obj)
	{
		putComponent(obj, GridBagConstraints.REMAINDER, 1, GridBagConstraints.BOTH);
	}

	/*******************************************/
	public void putComponent()
	{
		putComponent(new JLabel(""), GridBagConstraints.REMAINDER, 1
			,GridBagConstraints.BOTH, 1.0, 0.0);

		gridConst.gridx = 0;
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp)
	{
		gridConst.gridx = gridx;
		putComponent(comp);
	}

	/*******************************************/
	public void putComponent(Component comp)
	{
		putComponent(comp, 1, 1);
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth)
	{
		putComponent(comp, gridwidth, 1);
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth, int gridheight)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth, gridheight);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight)
	{
		putComponent(comp, gridwidth, gridheight, 0.0, 0.0);
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth, int gridheight
		,int fill)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth, gridheight, fill);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight
		,int fill)
	{
		putComponent(comp, gridwidth, gridheight, fill, 0.0, 0.0);
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth, int gridheight
		,int fill, int insetLeft, int insetRight)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth, gridheight, fill, insetLeft, insetRight);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight
		,int fill, int insetLeft, int insetRight)
	{
		putComponent(comp, gridwidth, gridheight, fill, 1, insetLeft, 1, insetRight);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight
		,int fill, int insetTop, int insetLeft, int insetBottom, int insetRight)
	{
		gridConst.insets = new Insets(insetTop, insetLeft, insetBottom, insetRight);

		putComponent(comp, gridwidth, gridheight, fill);

		gridConst.insets = new Insets(1,1,1,1);
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth, int gridheight
		,int fill, double weightx, double weighty)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth, gridheight, fill, weightx, weighty);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight
		,int fill, double weightx, double weighty)
	{
		gridConst.fill = fill;
		putComponent(comp, gridwidth, gridheight, weightx, weighty);

		gridConst.fill = defaultFill;
	}

	/*******************************************/
	public void putComponent(int gridx, Component comp, int gridwidth, int gridheight
		,double weightx, double weighty)
	{
		gridConst.gridx = gridx;
		putComponent(comp, gridwidth, gridheight, weightx, weighty);
	}

	/*******************************************/
	public void putComponent(Component comp, int gridwidth, int gridheight
		,double weightx, double weighty)
	{
		gridConst.gridwidth = gridwidth;
		gridConst.gridheight = gridheight;
		gridConst.weightx = weightx;
		gridConst.weighty = weighty;

		addComponent(comp);
	}

	/*******************************************/
	public void putComponent(Component comp
		,int gridx, int gridy
		,int gridwidth, int gridheight
		,double weightx, double weighty
		,int anchor, int fill
		,Insets insets
		,int ipadx, int ipady)
	{
		gridConst.gridx = gridx;
		gridConst.gridy = gridy;
		gridConst.gridwidth = gridwidth;
		gridConst.gridheight = gridheight;
		gridConst.weightx = weightx;
		gridConst.weighty = weighty;
		gridConst.anchor = anchor;
		gridConst.fill = fill;
		gridConst.insets = insets;
		gridConst.ipadx = ipadx;
		gridConst.ipady = ipady;

		addComponent(comp);

		gridConst.ipadx = 0;
		gridConst.ipady = 0;
	}

	/*******************************************/
	public void addComponent(Component comp)
	{
		gridBag.setConstraints(comp,gridConst);
		add(comp);

		gridConst.gridx = GridBagConstraints.RELATIVE;
	}
}

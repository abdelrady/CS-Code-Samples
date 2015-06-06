import java.util.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
/////////////////////////
public class Clock extends JFrame implements ActionListener{
	private JTextField hourfield;
	private JTextField minutefield;
	private JTextField secondfield;
	private JButton stopbutton,starbutton;
	private clockpanel clock;
	private JLabel l1,l2,l3;
	////////////CONSTRUCTOR////////////////
public Clock()
	{
		super("clock project");
		Container c=getContentPane();
		////////////SET BUTTONS PANEL////////////
		JPanel pan1=new JPanel();
		pan1.setLayout(new FlowLayout());
		stopbutton=new JButton("STOP");
		starbutton=new JButton ("STAR");
		stopbutton.setMnemonic('p');
		starbutton.setMnemonic('r');
		pan1.add(stopbutton);
		pan1.add(starbutton);
		c.add(pan1,BorderLayout.NORTH);
		pan1.setBackground(new Color(50,50,250));
		//////////////SET H,M,S PANEL////////////////
		JPanel pan2=new JPanel();
		pan2.setLayout(new FlowLayout());
		hourfield=new JTextField("12",3);
		minutefield=new JTextField("00",3);
		secondfield=new JTextField("00",3);
		l1=new JLabel("HOUR");
		l2=new JLabel("MINUTE");
		l3=new JLabel("SECOND");
		pan2.add(l1);
		pan2.add(hourfield);
		pan2.add(l2);
		pan2.add(minutefield);
		pan2.add(l3);
		pan2.add(secondfield);
		c.add(pan2,BorderLayout.SOUTH);
		pan2.setBackground(new Color(0,200,250));
		////////////////SET EVENT HANDLER////////////
		hourfield.addActionListener(this);
		minutefield.addActionListener(this);
		secondfield.addActionListener(this);
		stopbutton.addActionListener(this);
		starbutton.addActionListener(this);
		///////////////SET OBJECT OF CLOCK PANEL//////////
		clock=new clockpanel();
		c.add(clock,BorderLayout.CENTER);
		////////////////SET MENUS///////////////////////
		JMenuBar menu=new JMenuBar();
		setJMenuBar(menu);
		JMenu m1=new JMenu("ABOUT PROGRAMMER");
		JMenu m2=new JMenu("HELP");
		menu.add(m1);
		menu.add(m2);
		JMenuItem info=new JMenuItem("ABOUT PROGRAMMER");
		m1.add(info);
		JMenuItem d=new JMenuItem("USER GUIDE");
		JMenuItem ex=new JMenuItem("EXIT");
		m2.add(d);
		m2.add(ex);
		info.addActionListener(this);
		d.addActionListener(this);
		ex.addActionListener(this);
		///////////////////////////////////
		clock.setBackground(new Color(00,250,0));
		//////////////////////////////////////
		setSize(500,600);
		setVisible(true);
	}
	///////////////END OF COSTRUCTOR//////////////////
	/////////////////////////////////////////////
	public void setclock()
	{
		double h=Double.parseDouble(hourfield.getText());
		double m=Double.parseDouble(minutefield.getText());
		double s=Double.parseDouble(secondfield.getText());
        clock.setTime(h,m,s);
    }
    /////////////////MAIN//////////////////////////////
    public static void main(String args[])
    {
    	Clock application=new Clock();
			application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    /////////////////////////////////////////////////////////////////////
    ///////////////////////IMPLEMENT ACTION EVENTS////////////////
    
    	public void actionPerformed(ActionEvent e)
    	{
    		if(e.getSource()==hourfield)
    		 setclock();
    	    if(e.getSource()==minutefield)
    	   	setclock();
    	   	if(e.getSource()==secondfield)
    	   	setclock();
    	   	if(e.getSource()==stopbutton)
    	   	   {
    	   		clock.stopp();
    	   		stopbutton.setEnabled(false);
    	   		starbutton.setEnabled(true);
    	   		}
    	   	if(e.getSource()==starbutton)
    	   	    {
    	   		clock.play();
    	   		stopbutton.setEnabled(true);
    	   		starbutton.setEnabled(false);
    	   		}
    	   		String s="";
    	   	if(e.getActionCommand()=="ABOUT PROGRAMMER")
    	   	    {
    	   			 s+="NAME: LOTFY RABEE\n"+"FACULTY: COMPUTER &INFORMATION SIENCES\n"+"SEC: 4\n";
    	   			JOptionPane.showMessageDialog(null,s,"lotfy",JOptionPane.INFORMATION_MESSAGE);
    	   		}
    	   	if(e.getActionCommand()=="EXIT")
    	   		System.exit(0);
    	   	if(e.getActionCommand()=="USER GUIDE")
    	     	{
    	   	        s+="TO ADJEST CLOCK\n"+"1: YOU MUST PRESS STOP\n"+"2:ADJEST YOUR TIME\n"+"3:PRESS STAR.";
    	   		   JOptionPane.showMessageDialog(null,s,"GUIDE",JOptionPane.INFORMATION_MESSAGE);
    	   		}
    
    }
    
///////////////// PANEL CLOCK////////////////////////////////////
class clockpanel extends JPanel implements Runnable
	{
		private double min=0;
		private double s1=0;
		private double r=100;
		private double mhl=0.6*r;
		private double hhl=0.5*r;
		private double shl=0.7*r;
		private Thread runner;
		private JLabel l1,l2,l3;
		///////////////////////////////////////////////////
		///////////////////DRAW CLOCK///////////////////
		public void paintComponent(Graphics g)
		{
			super.paintComponent(g);
			Graphics2D g2=(Graphics2D)g;
			g2.setStroke(new BasicStroke(8));
			Ellipse2D circle=new Ellipse2D.Double(0,0,2*r,2*r);
			g2.setPaint(new GradientPaint(0,0,Color.green,(int)(2*r),(int)(2*r),Color.red,true));
		        g2.fill(new Ellipse2D.Double(0,0,2*r,2*r));
			g2.draw(circle);
			double hangel=Math.toRadians(90-360*min/(12*60));
			g.setColor(Color.white);
			g2.setStroke(new BasicStroke(4));
			drawhand(g2,hangel,hhl);	
		double mangel=Math.toRadians(90-360*min/60);
			drawhand(g2,mangel,mhl);
				double sangel=Math.toRadians(90-360*s1/60);
			drawhand(g2,sangel,shl);
			///////////////////DRAW NUMBER///////////
	g.setColor(Color.black);
	g2.setStroke(new BasicStroke(10.0f));
	g2.drawString("12",95,10);
	g2.drawString("11",45,20);
	g2.drawString("10",9,59);
	g2.drawString("9",0,102);
	g2.drawString("8",7,148);
	g2.drawString("7",36,184);
	g2.drawString("6",92,203);
	g2.drawString("5",152,187);
	g2.drawString("4",185,150);
	g2.drawString("3",196,105);
	g2.drawString("2",187,60);
	g2.drawString("1",155,23);
	g2.fillOval(97,99,6,6);
	////////////////////////////////////////////////////
	g2.setColor(Color.blue);
	g2.setFont(new Font("Serif",Font.ITALIC,15));
	g2.drawString("LOTFY RABEE AHMED",20,130);
	g2.drawString("SEC 4",80,160);
			
		/////////// DRAW METHOD////////////////////////
		}
		public void drawhand(Graphics2D g2,double angle,double handlength)
		{
			Point2D end=new Point2D.Double(
				r+handlength*Math.cos(angle),
				r-handlength*Math.sin(angle));
				Point2D center=new Point2D.Double(r,r);
				g2.draw(new Line2D.Double(center,end));
			}
			/////////////////////////////////////////
			public Dimension getPreferredSize()
			{
			return new Dimension(150,100);
		}
		/////////////////CHANGE TIME METHOD///////////
			public void setTime(double hh,double mm,double ss)
			{
				min=hh*60+mm;
				s1=ss;
				repaint();
			}
		//////////////////////////////////////////
			void play(){
				if(runner==null){
					runner=new Thread(this);
					runner.start();
				}
			}
	//////////////////////////////////////////////
			void stopp(){
				if(runner!=null)
				runner=null;
			}
	////////////////////////////////////////////////
			public void run()
			{
					double mys=Double.parseDouble(secondfield.getText());
					double mym=Double.parseDouble(minutefield.getText());
					double myh=Double.parseDouble(hourfield.getText());
				
				Thread t=Thread.currentThread();
				while(runner==t)
			    	{
					mys+=1;
					if(mys==60)
					{
					mym+=1;
					mys=0;
				   }
					setTime(myh,mym,mys);
					
            	try
            	      {
		               Thread.sleep(1000);
		               
	                  }
		              catch(InterruptedException e){}
                    } ////////END WHILE///////////////
					
				}////////////END RUN///////////
			
			}/////////END CLOCK PANEL/////////////
			
}////////////////END CLASS CLOCK/////////////
		
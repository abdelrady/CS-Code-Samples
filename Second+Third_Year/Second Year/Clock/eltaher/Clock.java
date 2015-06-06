 import java.util.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
/////////////////////////
public class Clock extends JFrame implements ActionListener{
	private JTextField hournum;
	private JTextField minutenum;
	private JTextField secondf;
	private JLabel l1;
        private JLabel l2;
        private JLabel l3;
	private JButton stopbutton,starbutton;
	private clockpanel clock;
	public Clock()
	{
		super(" Eltaher clock ");
		Container cont=getContentPane();
		//****************************************************************
		JPanel panel1=new JPanel();
		panel1.setLayout(new FlowLayout());
		stopb=new JButton("STOP");
		starb=new JButton ("STAR");
		panel1.add(stopbutton);
		panel1.add(starbutton);
		cont.add(panel1,BorderLayout.NORTH);
		
		JPanel pan2=new JPanel();
		pan2.setLayout(new FlowLayout());
		hourfield=new JTextField(3);
		minutefield=new JTextField(3);
		secondfield=new JTextField(3);
		l1=new JLabel("HOUR");
		l2=new JLabel("MINUTE");
		l3=new JLabel("SECOND");
		pan2.add(l1);
		pan2.add(hourfield);
		pan2.add(l2);
		pan2.add(minutefield);
		pan2.add(l3);
		pan2.add(secondfield);
		////////////////////////////
		hourfield.addActionListener(this);
		stopbutton.addActionListener(this);

		starbutton.addActionListener(this);

		minutefield.addActionListener(this);
		secondfield.addActionListener(this);
		/////////////////////////
		c.add(pan2,BorderLayout.SOUTH);
		clock=new clockpanel();
		c.add(clock,BorderLayout.CENTER);
		///////////////////////////////////////
		///////////////////////////////////////
		setSize(200,300);
		setVisible(true);
	}
	public void setclock()
	{
		double h=Double.parseDouble(hourfield.getText());
		double m=Double.parseDouble(minutefield.getText());
		double s=Double.parseDouble(secondfield.getText());
        clock.setTime(h,m,s);
    }
    /////////////////
    public static void main(String args[])
    {
    	Clock application=new Clock();
			application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    /////////////////////////////////
    	   	
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
    
    	   	
    	   }
    
	/////////////////
class clockpanel extends JPanel implements Runnable 
	{
		private double min=0;
		private double s1=0;
		private double r=100;
		private double mhl=0.8*r;
		private double hhl=0.6*r;
		private double shl=0.5*r;
		private Thread runner;
		public void paintComponent(Graphics g)
		{
			super.paintComponent(g);
			Graphics2D g2=(Graphics2D)g;
			Ellipse2D circle=new Ellipse2D.Double(0,0,2*r,2*r);
	         g2.draw(circle);
			g2.setBackground(Color.blue);
			double hangel=Math.toRadians(90-360*min/(12*60));
			g.setColor(Color.blue);
			g2.setStroke(new BasicStroke(4));
			drawhand(g2,hangel,hhl);	
		double mangel=Math.toRadians(90-360*min/60);
			drawhand(g2,mangel,mhl);
				double sangel=Math.toRadians(90-360*s1/60);
			drawhand(g2,sangel,shl);
		}
		public void drawhand(Graphics2D g2,double angle,double handlength)
		{
			Point2D end=new Point2D.Double(
				r+handlength*Math.cos(angle),
				r-handlength*Math.sin(angle));
				Point2D center=new Point2D.Double(r,r);
				g2.draw(new Line2D.Double(center,end));
			}
			/////////////////////////////
			public void setTime(double hh,double mm,double ss)
			{
				min=hh*60+mm;
				s1=ss;
				repaint();
			}
			/////////////////CHANGE TIME METHOD///////////
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
                    } 
					
				}
			
			}
			
}
		
       
       



		
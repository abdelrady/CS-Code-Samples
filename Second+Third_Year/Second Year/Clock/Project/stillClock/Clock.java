import java.awt.*;
import javax.swing.*;
import java.awt.Graphics2D;
//import javax.swing.event.DocumentEvent;
import java.awt.event.*;
import java.awt.geom.*;
import javax.swing.JOptionPane;
import javax.swing.event.*;
//****************************************************************
public class Clock extends JPanel
{
		private double minutes=0;
		int sb=0;
		private double radius=100;
		private double MINUEL=0.8*radius;
		private double HOUREL=0.6*radius;
	    private double shl=0.5*radius;

		private int x;
		private int y;
		private String s="12";
		private String s1="3";
		private String s2="6";
		private String s3="9";
		public void paintComponent(Graphics g)
			{
				super.paintComponent(g);
			 	x=(getSize().width)/2;
				y=(getSize().height)/2;
				Graphics2D g2=(Graphics2D)g;
				g2.setStroke(new BasicStroke(8));
				//container.add(panel,BorderLayout.SOUTH);
				Ellipse2D circle=new Ellipse2D.Double(0,0,2*radius,2*radius);
		        g2.setPaint(new GradientPaint(0,0,Color.green,(int)(2*radius),(int)(2*radius),Color.black,true));
		        g2.fill(new Ellipse2D.Double(0,0,2*radius,2*radius)); 
		        g2.setColor(new Color(0,255,255));
		        g2.draw(circle);
		        g2.setStroke(new BasicStroke(4));
		        g2.drawString(s,-5,(int)-radius);
		        g2.drawString(s1,(int)(radius+20),3);
		         
 		        double hourangle=Math.toRadians(90-360*minutes/(12*60));
		        drawhand(g2,hourangle,HOUREL);
		        double minutangle=Math.toRadians(90-360*minutes/60);
		        g2.setStroke(new BasicStroke(4));
		        g2.setColor(Color.blue);
		        drawhand(g2,minutangle,MINUEL);
		        double sangel=Math.toRadians(90-360*sb/60);
			drawhand(g2,sangel,shl);

		        //double minutangle=Math.toRadians(90-360*minutes/60);
		       
		      }
		      public void drawhand(Graphics2D g2,double angle,double handl)
		      {
		      	Point2D end=new Point2D.Double(radius+handl*Math.cos(angle),
		      	radius-handl*Math.sin(angle));
		      	Point2D center=new Point2D.Double(radius,radius);
		      	g2.draw(new Line2D.Double(center,end));
		      }
		      	public void settime(int h,int m)
		      	{
		      		minutes=(h*60)+m;
		      		repaint();
		      	}
		      
		      
		  }
//****************************************************************
class Clocktest extends JFrame
	{
     	private Clock clock;
     	private Color color;
	    private JLabel l1,l2;
	    private	JTextField minutefield;
	    private JTextField hourfield;
	    private static final int DEFAULT_WIDTH=1000,DEFUALT_HEIGHT=1000;
	    public Clocktest()
	    {
		  super("„Õ„œ„Õ„œ⁄»œ«··ÿÌ›");
		 
	//	color=random()%256;
		JPanel panel=new JPanel();
		l1=new JLabel("hour");
		l2=new JLabel("minutes");
		Container container=getContentPane();
		DocumentListener listener=new ClockfieldListener();
		hourfield=new JTextField("12",3);
		panel.add(l1);
		panel.add(hourfield);
		hourfield.getDocument().addDocumentListener(listener);
		minutefield=new JTextField("00",3);
		panel.add(l2);
		panel.add(minutefield);
		minutefield.getDocument().addDocumentListener(listener);
		container.add(panel, BorderLayout.NORTH);
	    clock=new Clock();
		container.add(clock,BorderLayout. CENTER);
		setSize(DEFAULT_WIDTH,DEFUALT_HEIGHT);
		setVisible(true);
	//	for(;;){
	//	color=new Color(0,255,0);
		container.setBackground(color);
	   }
//****************************************************************
		public void setclock()
		{
			try
			{
				int hours=Integer.parseInt(hourfield.getText().trim());
				int minutes=Integer.parseInt(minutefield.getText().trim());
                clock.settime(hours,minutes);
            }
           catch(NumberFormatException e){}
        }
        
		//	setSize(DEFAULT_WIDTH,DEFUALT_HEIGHT);
			
	
		 
			
		      public static void main(String args[])
		      {
		      	Clocktest khaled=new Clocktest();
		      	khaled.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	
		      //	khaled.setDefualtCloseOperation(JFrame.EXIT_ON_CLOSE);
	            //khaled.show();
	         }
	       
		private  class ClockfieldListener implements DocumentListener
        {
        	public void insertUpdate(DocumentEvent e){setclock();}
            public void removeUpdate(DocumentEvent e){setclock();}   
				public void changedUpdate(DocumentEvent e){setclock();}
		}
	}
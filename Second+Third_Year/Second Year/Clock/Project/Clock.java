import java.util.*;
import java.text.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
/////////////////////////
public class Clock extends JFrame implements ActionListener{
	private JButton stopbutton,starbutton;
	private Clockpanel clock;
	private JLabel l1,l2,l3;
	private JTextField hourfield;
	private JTextField minutefield;
	private JTextField secondfield;
	
	public Clock()
	{
		super("åÐÇ ãä ÝÖá ÑÈì áíÈáæäì ÇÃÔßÑ Çã ÇßÝÑ");
		Container c=getContentPane();
		////////////////////////////////
		JPanel pan1=new JPanel();
		pan1.setLayout(new FlowLayout());
		stopbutton=new JButton("STOP");
		starbutton=new JButton ("START");
		stopbutton.setMnemonic('p');
		starbutton.setMnemonic('r');
		pan1.add(stopbutton);
		pan1.add(starbutton);
		JPanel pan2=new JPanel();
		pan1.setLayout(new FlowLayout());
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
		pan2.setBackground(Color.blue);
		
		stopbutton.addActionListener(this);
		starbutton.addActionListener(this);
		c.add(pan1,BorderLayout.NORTH);
		c.add(pan2,BorderLayout.SOUTH);
		clock=new Clockpanel();
		//clock.start();
		c.add(clock,BorderLayout.CENTER);
		clock.setBackground(new Color(0,200,100));
		setSize(500,600);
		setVisible(true);
	}

    /////////////////
    public static void main(String args[])
    {
    	Clock application=new Clock();
			application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    //////////////////////////////////
 public void actionPerformed(ActionEvent e)
    	{
    		
    	   	if(e.getSource()==stopbutton)
    	   	{
    	   		JOptionPane.showMessageDialog(null,"!WARNNIG YOU WILL STOP WATCH");
    	   		clock.stop();
    	   		stopbutton.setEnabled(false);
    	   		starbutton.setEnabled(true);}
    	   	if(e.getSource()==starbutton)
    	   	{
    	   	     	   		clock.start();
    	   		stopbutton.setEnabled(true);
    	   		starbutton.setEnabled(false);
    	   		JOptionPane.showMessageDialog(null,"SUCCESSFULLY START");

    	   		}
    	   	}
    	
}    
    	
       
	/////////////////
class Clockpanel extends JPanel implements Runnable
	{
		
		Thread timer;            
    
		 int lastxs =0, lastys =0 ,lastxm =0, lastym =0, lastxh =0, lastyh = 0;
        SimpleDateFormat formatter = new SimpleDateFormat ("EEE MMM dd hh:mm:ss yyyy", Locale.getDefault());
        Date currentDate = new Date();
        String lastdate = formatter.format(currentDate);
        Font clockFaceFont = new Font("Serif", Font.BOLD, 16);
        Font khaledf=new Font("Serif",Font.BOLD,18);
        Font khaledc=new Font("Serif",Font.BOLD+Font.ITALIC,16);
        Color handColor =  Color.red;
       Color numberColor = Color.black;
       Color numberColor1 = Color.blue;
    public void plotpoints(int x0, int y0, int x, int y, Graphics g) {
        g.drawLine(x0+x,y0+y,x0+x,y0+y);
        g.drawLine(x0+y,y0+x,x0+y,y0+x);
        g.drawLine(x0+y,y0-x,x0+y,y0-x);
        g.drawLine(x0+x,y0-y,x0+x,y0-y);
        g.drawLine(x0-x,y0-y,x0-x,y0-y);
        g.drawLine(x0-y,y0-x,x0-y,y0-x);
        g.drawLine(x0-y,y0+x,x0-y,y0+x);
        g.drawLine(x0-x,y0+y,x0-x,y0+y);
    }

    // Circle is just Bresenham's algorithm for a scan converted circle
    public void circle(int x0, int y0, int r, Graphics g) {
        int x,y;
        float d;
        x=0;
        y=r;
        d=5/4-r;
        plotpoints(x0,y0,x,y,g);

        while (y>x){
            if (d<0) {
                d=d+2*x+3;
                x++;
            }
            else {
                d=d+2*(x-y)+5;
                x++;
                y--;
            }
            plotpoints(x0,y0,x,y,g);
        }
    }

		public void paintComponent(Graphics g)
		{
			super.paintComponent(g);
			currentDate = new Date();
        lastdate = formatter.format(currentDate);
			   int xh, yh, xm, ym, xs, ys, s = 0, m = 10, h = 10, xcenter, ycenter;
        String today;

        currentDate = new Date();
        SimpleDateFormat formatter = new SimpleDateFormat("s",Locale.getDefault());
        try {
            s = Integer.parseInt(formatter.format(currentDate));
        } catch (NumberFormatException n) {
            s = 0;
        }
        formatter.applyPattern("m");
        try {
            m = Integer.parseInt(formatter.format(currentDate));
        } catch (NumberFormatException n) {
            m = 10;
        }    
        formatter.applyPattern("h");
        try {
            h = Integer.parseInt(formatter.format(currentDate));
        } catch (NumberFormatException n) {
            h = 10;
        }
        formatter.applyPattern("EEE MMM dd HH:mm:ss yyyy");
        today = formatter.format(currentDate);
         xcenter=100;
        ycenter=90;
         xs = (int)(Math.cos(s * 3.14f/30 - 3.14f/2) * 45 + xcenter);
        ys = (int)(Math.sin(s * 3.14f/30 - 3.14f/2) * 45 + ycenter);
        xm = (int)(Math.cos(m * 3.14f/30 - 3.14f/2) * 40 + xcenter);
        ym = (int)(Math.sin(m * 3.14f/30 - 3.14f/2) * 40 + ycenter);
        xh = (int)(Math.cos((h*30 + m/2) * 3.14f/180 - 3.14f/2) * 30 + xcenter);
        yh = (int)(Math.sin((h*30 + m/2) * 3.14f/180 - 3.14f/2) * 30 + ycenter);
    
    // Draw the circle and numbers
    
        g.setFont(clockFaceFont);
        g.setColor(handColor);
        Graphics2D g2=(Graphics2D)g;
	    g2.setStroke(new BasicStroke(4)); 
        g.setColor(Color.black);
        g2.setPaint(new GradientPaint(xcenter,ycenter,Color.green,100,100,Color.blue,true));
          g2.setPaint(new GradientPaint(xcenter,ycenter,Color.red,100,100,Color.blue,true));
        circle(xcenter,ycenter,50,g);
        g.setColor( Color.black);
           g2.setPaint(new GradientPaint(xcenter,ycenter,Color.red,60,60,Color.blue,true)); 
        //g.fillOval(43,47,8,8);
        g2.setPaint(new GradientPaint(xcenter,ycenter,Color.blue,60,60,Color.yellow));
        g.setColor(numberColor); 
        g.drawString("1",xcenter+20,ycenter-32);
        g.drawString("2",xcenter+35,ycenter-15);
        g.drawString("11",xcenter-25,ycenter-30);
        g.drawString("10",xcenter-43,ycenter-15); 
        g.drawString("9",xcenter-45,ycenter+3);
        g.drawString("3",xcenter+40,ycenter+8);
        g.drawString("4",xcenter+32,ycenter+25);
        g.drawString("5",xcenter+16,ycenter+41);
        g.drawString("12",xcenter-5,ycenter-37);
        g.drawString("6",xcenter-3,ycenter+45);
        g.drawString("7",xcenter-29,ycenter+40);
        g.drawString("8",xcenter-40,ycenter+24);
        g.setColor(numberColor1);
        String str="Mohammed Mohammed Abd Ellatif"+"\n"+"sec 4";
        g.setFont(khaledf);
        g.drawString( str,150,120);
          String str2="ELSWIFY CLOCK";
             g.setFont(khaledc);
           g.drawString( str2,20,22);
         g.setColor(getBackground());
        if (xs != lastxs || ys != lastys) {
            g2.setStroke(new BasicStroke(10));
            g.drawLine(xcenter, ycenter, lastxs, lastys);
            g.drawString(lastdate, 5, 125);
        }
        if (xm != lastxm || ym != lastym) {
            g.drawLine(xcenter, ycenter-1, lastxm, lastym);
            g.drawLine(xcenter-1, ycenter, lastxm, lastym); }
        if (xh != lastxh || yh != lastyh) {
            g.drawLine(xcenter, ycenter-1, lastxh, lastyh);
           // g2.setPaint(new GradientPaint(xcenter,ycenter,Color.green,100,100,Color.blue,true));
            g.drawLine(xcenter-1, ycenter, lastxh, lastyh); }
        g.setColor(Color.blue);
        g.drawString("", 5, 170);
         g.setFont(khaledf);
        g.drawString(today, 5, 170);    
        g.drawLine(xcenter, ycenter, xs, ys);
        g.setColor(handColor);
        g.drawLine(xcenter, ycenter-1, xm, ym);
        g.drawLine(xcenter-1, ycenter, xm, ym);
        g.drawLine(xcenter, ycenter-1, xh, yh);
        g.drawLine(xcenter-1, ycenter, xh, yh);
        lastxs=xs; lastys=ys;
        lastxm=xm; lastym=ym;
        lastxh=xh; lastyh=yh;
        lastdate = today;
        currentDate=null;
       
    }

    public void start() {
        timer = new Thread(this);
        timer.start();
    }

    public void stop() {
        timer = null;
    }

    public void run() {
        Thread me = Thread.currentThread();
        while (timer == me) {
            try {
                Thread.currentThread().sleep(100);
            } catch (InterruptedException e) {
            }
            repaint();
        }
    }

    public void update(Graphics g) {
        paint(g);
    }}
        
        

		
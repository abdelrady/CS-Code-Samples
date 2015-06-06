/*
 * @(#)EEE.java 1.0 07/03/09
 *
 * You can modify the template of this file in the
 * directory ..\JCreator\Templates\Template_1\Project_Name.java
 *
 * You can also create your own project template by making a new
 * folder in the directory ..\JCreator\Template\. Use the other
 * templates as examples.
 *
 */

import java.io.*;
 import java.net.*;
 import java.awt.*;
 import java.awt.event.*;
import java.awt.*;
//import java.awt.event.*;
import javax.swing.*;

public class EEE extends JFrame {
	
	public EEE() {
		Container con=getContentPane();
		setSize( 300, 150 );
		setVisible( true );
		
	}
	

	public static void main(String args[]) {
		System.out.println("Starting EEE...");
		EEE mainFrame = new EEE();
		mainFrame.setSize(400, 400);
		mainFrame.setTitle("EEE");
		mainFrame.setVisible(true);
	}
}

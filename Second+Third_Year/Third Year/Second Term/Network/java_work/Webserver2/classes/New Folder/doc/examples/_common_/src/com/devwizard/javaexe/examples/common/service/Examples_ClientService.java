/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.service;


import java.io.*;
import java.net.*;
import java.util.*;


/*****************************************************************************/
public class Examples_ClientService extends Thread
{
	Socket sockClient;


	/*******************************************/
	public Examples_ClientService(Socket client)
	{
		sockClient = client;
		start();
	}

	/*******************************************/
	public void run()
	{
		try
		{
			BufferedReader in = new BufferedReader(new InputStreamReader(sockClient.getInputStream()));
			PrintStream out = new PrintStream(sockClient.getOutputStream());

			in.readLine();

			out.println("service running : "+(new Date()));
			out.flush();
			out.close();
		}
		catch(Exception ex) {}

		try
		{
			sockClient.close();
		}
		catch(Exception ex) {}

		sockClient = null;
	}
}

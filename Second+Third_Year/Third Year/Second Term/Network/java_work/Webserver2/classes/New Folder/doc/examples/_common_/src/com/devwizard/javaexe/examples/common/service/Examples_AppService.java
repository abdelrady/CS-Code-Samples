/*****************************************************************************/
/***  (c) 2002-2006, DevWizard (DevWizard@free.fr)                         ***/
/*****************************************************************************/

package com.devwizard.javaexe.examples.common.service;


import java.net.*;


/*****************************************************************************/
public class Examples_AppService extends Thread
{
	boolean isEnd = false;
	boolean isWait = false;
	boolean isReinit = false;
	ServerSocket sockServer = null;


	/*******************************************/
	public Examples_AppService()
	{
		start();
	}

	/*******************************************/
	public void run()
	{
		try
		{
			while(!isEnd)
			{
				sockServer = new ServerSocket(Examples_ConfigService.cnfgPortNumber);
				setFlagReinit(false);

				while(!isEnd && !isReinit)
				{
					testPaused();

					try
					{
						doAction(sockServer.accept());
					}
					catch(Exception ex3) {}
				}

				try
				{
					sockServer.close();
				}
				catch(Exception ex2) {}
			}
		}
		catch(Exception ex1) {}

		sockServer = null;
	}

	/*******************************************/
	public synchronized void setFlagWait(boolean flag)
	{
		isWait = flag;
	}

	/*******************************************/
	public synchronized void setFlagEnd(boolean flag)
	{
		isEnd = flag;
	}

	/*******************************************/
	public synchronized void setFlagReinit(boolean flag)
	{
		isReinit = flag;
	}

	/*******************************************/
	public void reinit()
	{
		Examples_ConfigService.initParameters();
		setFlagReinit(true);

		try
		{
			sockServer.close();
		}
		catch(Exception ex) {}
	}

	/*******************************************/
	void doAction(Socket client)
	{
		testPaused();

		new Examples_ClientService(client);
	}

	/*******************************************/
	void testPaused()
	{
		while(isWait)
			try { Thread.sleep(250); }
			catch(Exception ex) {}
	}
}
